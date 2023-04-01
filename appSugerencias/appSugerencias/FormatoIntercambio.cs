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
    public partial class FormatoIntercambio : Form 
    {

       

        public FormatoIntercambio()
        {

           
            InitializeComponent();
        }


      
      
       private void VerificarEntradaSalida_Load(object sender, EventArgs e)
       {
           
       }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT * FROM rd_intercambio_mercancia WHERE fecha between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"' order by idreg";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DG_tabla.Rows.Add(dr["articulo"].ToString(), dr["descripcion"].ToString(), dr["envia"].ToString(), dr["vallarta"].ToString(), dr["rena"].ToString(), dr["velazquez"].ToString(),dr["coloso"].ToString(),dr["linea"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al consultar el intercambio en la fecha seleccionada ["+ex+"]");
            }

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A4000"].NumberFormat = "@";
            int indiceColumna = 0;

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
