using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Depurar_kardex
{
    public partial class ArticulosADepurar : Form
    {
        string articulo = "",descrip="";
        public ArticulosADepurar(string articulo,string descrip)
        {
            this.articulo = articulo;
            this.descrip = descrip;
            InitializeComponent();
        }

        private void ArticulosADepurar_Load(object sender, EventArgs e)
        {
            string consulta = "select articulo,descrip from prods where descrip like '%"+descrip+"%'";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(consulta,conexion);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_tabla.Rows.Add(dr["articulo"].ToString(),dr["descrip"].ToString());
            }

            dr.Close();
            conexion.Close();

        }

        private void DG_tabla_KeyDown(object sender, KeyEventArgs e)
        {
            

          
        }

        private void DG_tabla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                articulo = DG_tabla.Rows[e.RowIndex].Cells[0].Value.ToString();
                DepurarKardex depurador = Owner as DepurarKardex;
                depurador.TB_articulo.Text = articulo;
                this.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }

        }

        private void DG_tabla_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DepurarKardex depurador = Owner as DepurarKardex;
                depurador.TB_articulo.Text = articulo;
                this.Close();
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

        private void DG_tabla_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                articulo = DG_tabla.Rows[e.RowIndex].Cells[0].Value.ToString();
                //DepurarKardex depurador = Owner as DepurarKardex;
                //depurador.TB_articulo.Text = articulo;
                //this.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }
    }
}
