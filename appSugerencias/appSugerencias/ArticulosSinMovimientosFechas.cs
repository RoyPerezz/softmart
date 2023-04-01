using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ArticulosSinMovimientosFechas : Form
    {
        public ArticulosSinMovimientosFechas()
        {
            InitializeComponent();
        }

        
        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DG_tabla.Rows.Clear();
            DataTable articulos = new DataTable();
            articulos.Columns.Add("ARTICULO",typeof(string));
            articulos.Columns.Add("DESCRIPCION", typeof(string));
            articulos.Columns.Add("FECHA", typeof(string));
            articulos.Columns.Add("CANTIDAD", typeof(int));

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            //string query = "select movsinv.ARTICULO,prods.DESCRIP" +
            //" FROM prods inner join movsinv ON prods.ARTICULO = movsinv.ARTICULO WHERE movsinv.F_MOVIM < '"+inicio.ToString("yyyy-MM-dd")+"' and movsinv.F_MOVIM > '"+fin.ToString("yyyy-MM-dd")+"' order by movsinv.F_MOVIM";

            string query = "select distinct movsinv.ARTICULO,prods.DESCRIP,prods.EXISTENCIA FROM movsinv inner join prods on prods.ARTICULO = movsinv.ARTICULO WHERE F_MOVIM< '" + inicio.ToString("yyyy-MM-dd") + "' and F_MOVIM > '" + fin.ToString("yyyy-MM-dd") + "' and prods.EXISTENCIA > 0 order by movsinv.F_MOVIM";
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                articulos.Rows.Add(dr["ARTICULO"].ToString(),dr["DESCRIP"].ToString(),"",Convert.ToInt32(dr["EXISTENCIA"].ToString()));
            }
            dr.Close();

            string articulo = "";
            ArrayList claves = new ArrayList();
            MySqlCommand cmd2 = null;
            MySqlDataReader dr2 = null;
            DateTime fecha;
            for (int i = 0; i < articulos.Rows.Count; i++)
            {
                articulo = articulos.Rows[i]["ARTICULO"].ToString();
                cmd2 = new MySqlCommand("select articulo,ent_sal,f_movim from movsinv where articulo = '"+articulo+"' and tipo_movim in('COM','TK','T+','T-','A+','A-') order by consec desc limit 1",con);
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    fecha = Convert.ToDateTime(dr2["f_movim"].ToString());
                    if (fecha > inicio)
                    {
                        claves.Add(articulo);
                    }else
                    {
                        articulos.Rows[i]["FECHA"] = Convert.ToDateTime(dr2["f_movim"].ToString()).ToString("dd-MM-yyyy");
                    }
                    
                }
                dr2.Close();
            }

          

            

            DG_tabla.DataSource =  articulos;
            
           var f_movim = "";
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                 f_movim = DG_tabla.Rows[i].Cells["FECHA"].Value.ToString();

                if (f_movim.Equals(""))
                {
                    this.DG_tabla.CurrentCell = null;

                    DG_tabla.Rows[i].Visible = false;
                }
            }

            //string articuloTabla = "", articuloLista = "";
            //for (int i = 0; i < articulos.Rows.Count; i++)
            //{
            //    articuloTabla = articulos.Rows[i]["ARTICULO"].ToString();

            //    for (int j = 0; j < claves.Count; j++)

            //    {
            //        articuloLista = claves[j].ToString();
            //        if (articuloTabla.Equals(articuloLista))
            //        {
            //            DG_tabla.Rows.RemoveAt(i);
            //        }
            //    }

            //}
            con.Close();
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;
            excel.Cells.Range["A6:A20000"].NumberFormat = "@";

            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;



            foreach (DataGridViewRow row in DG_tabla.Rows)

                if (row.Visible == true)
                {
                    indiceFila++;
                    indiceColumna = 0;

                    foreach (DataGridViewColumn col in DG_tabla.Columns)
                    {
                        indiceColumna++;


                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;




                    }

                }

            excel.Cells.Range["A5"].Value = "ARTICULO";
            excel.Cells.Range["B5"].Value = "DESCRIPCION";
            excel.Cells.Range["C5"].Value = "ULTIMO MOVIMIENTO";
        

            excel.Visible = true;
        }
    }
}
