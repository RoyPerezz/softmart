using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class KardexArticulos : Form
    {
        public KardexArticulos()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        private void KardexArticulos_Load(object sender, EventArgs e)
        {


            string query = "select descripcion from rd_sucursales where activo=1";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,conexion);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_sucursal.Items.Add(dr["descripcion"]);
            }
            dr.Close();
            conexion.Close();


            dt.Columns.Add("USUARIO", typeof(string));
            dt.Columns.Add("TIPO MOV", typeof(string));
            dt.Columns.Add("REFERENCIA", typeof(string));
            dt.Columns.Add("MOVIMIENTO", typeof(string));
            dt.Columns.Add("FECHA", typeof(string));
            dt.Columns.Add("ENT SAL", typeof(string));
            dt.Columns.Add("CANTIDAD", typeof(string));
            dt.Columns.Add("EXISTENCIA", typeof(string));
            dt.Columns.Add("COSTO", typeof(string));
            dt.Columns.Add("ALM", typeof(string));
        }

        public void LlenarDataGrid (DataTable dt)
        {
            

           
        }

        private void BT_kardex_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            string query = "select descrip from prods where articulo='"+TB_articulo.Text+"'";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LB_descripcion.Text = dr["descrip"].ToString();
            }
            dr.Close();
            conexion.Close();

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            dt = Kardex.KardexArticulo(TB_articulo.Text,inicio.ToString("yyyy-MM-dd"),fin.ToString("yyyy-MM-dd"),CB_sucursal.SelectedItem.ToString());


            DG_Tabla.DataSource = dt;
            DG_Tabla.AutoResizeColumns();
            DG_Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_Tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_Tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_Tabla.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;
        }
    }
}
