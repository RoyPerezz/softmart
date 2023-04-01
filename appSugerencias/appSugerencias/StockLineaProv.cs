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
    public partial class StockLineaProv : Form
    {
        public StockLineaProv()
        {
            InitializeComponent();
        }


        DataTable va = new DataTable();
        DataTable re = new DataTable();
        DataTable ve = new DataTable();
        DataTable co = new DataTable();

        private void StockLineaProv_Load(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            ArrayList prov = p.Fabricante();

            for (int i = 0; i < prov.Count; i++)
            {
                CB_proveedor.Items.Add(prov[i].ToString());
            }

            //LINEAS
            string query = "SELECT linea FROM LINEAS ORDER BY linea";
            MySqlConnection con = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_linea.Items.Add(dr["linea"].ToString());
            }
            dr.Close();
            con.Close();

            va.Columns.Add("ARTICULO",typeof(string));
            va.Columns.Add("EXISTENCIA", typeof(int));
            re.Columns.Add("ARTICULO", typeof(string));
            re.Columns.Add("EXISTENCIA", typeof(int));
            ve.Columns.Add("ARTICULO", typeof(string));
            ve.Columns.Add("EXISTENCIA", typeof(int));
            co.Columns.Add("ARTICULO", typeof(string));
            co.Columns.Add("EXISTENCIA", typeof(int));


        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            string query = "SELECT ARTICULO,DESCRIP,EXISTENCIA FROM PRODS WHERE Fabricante ='"+CB_proveedor.SelectedItem.ToString()+"' AND Linea='"+CB_linea.SelectedItem.ToString()+"'";
            va.Rows.Clear();
            re.Rows.Clear();
            ve.Rows.Clear();
            co.Rows.Clear();
            DG_tabla.Rows.Clear();



            MySqlConnection conBO = BDConexicon.BodegaOpen();
            MySqlCommand cmdBO = new MySqlCommand(query, conBO);
            MySqlDataReader drBO = cmdBO.ExecuteReader();
            while (drBO.Read())
            {
                DG_tabla.Rows.Add(drBO["ARTICULO"].ToString(),drBO["DESCRIP"].ToString(),0,drBO["EXISTENCIA"].ToString(),0,0,0,0,0,0,0,0,0,0,0,0,0);
            }
            drBO.Close();
            conBO.Close();


            //EXISTENCIA VALLARTA
            MySqlConnection conVA = BDConexicon.VallartaOpen();
            MySqlCommand cmdVA = new MySqlCommand(query,conVA);
            MySqlDataReader drVA = cmdVA.ExecuteReader();
            while (drVA.Read())
            {
                va.Rows.Add(drVA["ARTICULO"].ToString(),drVA["EXISTENCIA"].ToString());
            }
            drVA.Close();
            conVA.Close();

            //EXISTENCIA RENA
            MySqlConnection conRE = BDConexicon.RenaOpen();
            MySqlCommand cmdRE = new MySqlCommand(query, conRE);
            MySqlDataReader drRE = cmdRE.ExecuteReader();
            while (drRE.Read())
            {
                re.Rows.Add(drRE["ARTICULO"].ToString(), drRE["EXISTENCIA"].ToString());
            }
            drRE.Close();
            //conRE.Close();

            //EXISTENCIA VELAZQUEZ
            MySqlConnection conVE = BDConexicon.VelazquezOpen();
            MySqlCommand cmdVE = new MySqlCommand(query, conVE);
            MySqlDataReader drVE = cmdVE.ExecuteReader();
            while (drVE.Read())
            {
                ve.Rows.Add(drVE["ARTICULO"].ToString(), drVE["EXISTENCIA"].ToString());
            }
            drVE.Close();
            conVE.Close();


            //EXISTENCIA COLOSO
            MySqlConnection conCO = BDConexicon.ColosoOpen();
            MySqlCommand cmdCO = new MySqlCommand(query, conCO);
            MySqlDataReader drCO = cmdCO.ExecuteReader();
            while (drCO.Read())
            {
               co.Rows.Add(drCO["ARTICULO"].ToString(), drCO["EXISTENCIA"].ToString());
            }
            drCO.Close();
            conCO.Close();


            string articuloDG = "", articuloDT = "";

            //COLOCAR EXISTENCIA VA
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                articuloDG = DG_tabla.Rows[i].Cells[0].Value.ToString();
              
                for (int j = 0; j < va.Rows.Count; j++)
                {
                    articuloDT = va.Rows[j][0].ToString();

                    if (articuloDG.Equals(articuloDT))
                    {
                        DG_tabla.Rows[i].Cells[6].Value = Convert.ToInt32(va.Rows[j][1].ToString());
                        break;
                    }
                }
               
            }

            //COLOCAR EXISTENCIA RE
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                articuloDG = DG_tabla.Rows[i].Cells[0].Value.ToString();

                for (int j = 0; j < re.Rows.Count; j++)
                {
                    articuloDT = re.Rows[j][0].ToString();

                    if (articuloDG.Equals(articuloDT))
                    {
                        DG_tabla.Rows[i].Cells[9].Value = Convert.ToInt32(re.Rows[j][1].ToString());
                        break;
                    }
                }

            }

            //COLOCAR EXISTENCIA VE
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                articuloDG = DG_tabla.Rows[i].Cells[0].Value.ToString();

                for (int j = 0; j < ve.Rows.Count; j++)
                {
                    articuloDT = ve.Rows[j][0].ToString();

                    if (articuloDG.Equals(articuloDT))
                    {
                        DG_tabla.Rows[i].Cells[12].Value = Convert.ToInt32(ve.Rows[j][1].ToString());
                        break;
                    }
                }

            }

            //COLOCAR EXISTENCIA CO
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                articuloDG = DG_tabla.Rows[i].Cells[0].Value.ToString();

                for (int j = 0; j < co.Rows.Count; j++)
                {
                    articuloDT = co.Rows[j][0].ToString();

                    if (articuloDG.Equals(articuloDT))
                    {
                        DG_tabla.Rows[i].Cells[15].Value = Convert.ToInt32(co.Rows[j][1].ToString());
                        break;
                    }
                }

            }

            AgregarMaximos();
            CalcularPedido();
        }


        public void AgregarMaximos()
        {
            string articulo = "";

            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlDataReader dr = null;
            string queryCedis = "";
            string queryVa = "SELECT maximo FROM rd_maximos_bo WHERE articulo='" + articulo + "'";
            string queryRe = "SELECT maximo FROM rd_maximos_bo WHERE articulo='" + articulo + "'";
            string queryVe = "SELECT maximo FROM rd_maximos_bo WHERE articulo='" + articulo + "'";
            string queryCo = "SELECT maximo FROM rd_maximos_bo WHERE articulo='" + articulo + "'";

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                articulo = Convert.ToString(DG_tabla.Rows[i].Cells[0].Value);

                //TRAE EL MAXIMO DE CEDIS
                queryCedis = "SELECT maximo FROM rd_maximos_bo WHERE articulo='" + articulo + "'";
                MySqlCommand cmd = new MySqlCommand(queryCedis,conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DG_tabla.Rows[i].Cells[2].Value = dr["maximo"].ToString();
                }
                dr.Close();


                //TRAE EL MAXIMO DE VALLARTA
                queryVa = "SELECT maximo FROM rd_maximos_va WHERE articulo='" + articulo + "'";
                MySqlCommand cmdVA = new MySqlCommand(queryVa, conexion);
                dr = cmdVA.ExecuteReader();
                while (dr.Read())
                {
                    DG_tabla.Rows[i].Cells[5].Value = dr["maximo"].ToString();
                }
                dr.Close();

                //TRAE EL MAXIMO DE RENA
                queryRe = "SELECT maximo FROM rd_maximos_re WHERE articulo='" + articulo + "'";
                MySqlCommand cmdRE = new MySqlCommand(queryRe, conexion);
                dr = cmdRE.ExecuteReader();
                while (dr.Read())
                {
                    DG_tabla.Rows[i].Cells[8].Value = dr["maximo"].ToString();
                }
                dr.Close();

                //TRAE EL MAXIMO DE VELAZQUEZ
                queryVe = "SELECT maximo FROM rd_maximos_ve WHERE articulo='" + articulo + "'";
                MySqlCommand cmdVE = new MySqlCommand(queryVe, conexion);
                dr = cmdVE.ExecuteReader();
                while (dr.Read())
                {
                    DG_tabla.Rows[i].Cells[11].Value = dr["maximo"].ToString();
                }
                dr.Close();

                //TRAE EL MAXIMO DE COLOSO
                queryCo = "SELECT maximo FROM rd_maximos_co WHERE articulo='" + articulo + "'";
                MySqlCommand cmdCO = new MySqlCommand(queryVa, conexion);
                dr = cmdCO.ExecuteReader();
                while (dr.Read())
                {
                    DG_tabla.Rows[i].Cells[14].Value = dr["maximo"].ToString();
                }
                dr.Close();
            }
        }



        public int Pedido(int existencia, int maximo)
        {


            int mitad = maximo / 2;
            int veintePorciento = maximo - (maximo * 80) / 100;
             


            int pedido = 0;
            if (existencia >= maximo/2)
            {
                pedido = 0;
            }

            if ((existencia < maximo / 2) && existencia > (maximo - (maximo * 80) / 100))
            {
                pedido = maximo;
            }

            if (existencia <= (maximo - (maximo * 80) / 100))
            {
                pedido = maximo  +( maximo/2);
            }
            return pedido;
        }

        public void CalcularPedido()
        {
            int existencia = 0, maximo = 0, pedido = 0;


            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                //CEDIS
                maximo = Convert.ToInt32(DG_tabla.Rows[i].Cells[2].Value);
                existencia = Convert.ToInt32(DG_tabla.Rows[i].Cells[3].Value);

                pedido = Pedido(existencia,maximo);
                DG_tabla.Rows[i].Cells[4].Value = pedido;

                //VALLARTA
                maximo = Convert.ToInt32(DG_tabla.Rows[i].Cells[5].Value);
                existencia = Convert.ToInt32(DG_tabla.Rows[i].Cells[6].Value);

                pedido = Pedido(existencia, maximo);
                DG_tabla.Rows[i].Cells[7].Value = pedido;

                //RENA
                maximo = Convert.ToInt32(DG_tabla.Rows[i].Cells[8].Value);
                existencia = Convert.ToInt32(DG_tabla.Rows[i].Cells[9].Value);

                pedido = Pedido(existencia, maximo);
                DG_tabla.Rows[i].Cells[10].Value = pedido;

                //VELAZQUEZ
                maximo = Convert.ToInt32(DG_tabla.Rows[i].Cells[11].Value);
                existencia = Convert.ToInt32(DG_tabla.Rows[i].Cells[12].Value);

                pedido = Pedido(existencia, maximo);
                DG_tabla.Rows[i].Cells[13].Value = pedido;

                //COLOSO
                maximo = Convert.ToInt32(DG_tabla.Rows[i].Cells[14].Value);
                existencia = Convert.ToInt32(DG_tabla.Rows[i].Cells[15].Value);

                pedido = Pedido(existencia, maximo);
                DG_tabla.Rows[i].Cells[16].Value = pedido;

               

            }
            pedido = 0;
        }
        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
      

            int indiceColumna = 0;
            excel.Range["A1:A4000"].NumberFormat = "@";
            excel.Range["A2:B2"].Merge();
            excel.Range["A2"].Value = CB_proveedor.SelectedItem.ToString()+"   "+CB_linea.SelectedItem.ToString();

            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;

                foreach (DataGridViewColumn col in DG_tabla.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;


                }

            }


            excel.Visible = true;
        }
    }
}
