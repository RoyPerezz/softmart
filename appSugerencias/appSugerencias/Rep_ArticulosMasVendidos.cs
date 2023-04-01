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
    public partial class Rep_ArticulosMasVendidos : Form
    {
        public Rep_ArticulosMasVendidos()
        {
            InitializeComponent();
        }

        MySqlConnection conexion = null;

        private void Rep_ArticulosMasVendidos_Load(object sender, EventArgs e)
        {
            
        }


        public string ObtenerMes(int num)
        {
            string mes = "";
           
            if (num==1)
            {
                mes = "ENE";
            }
            if (num == 2)
            {
                mes = "FEB";
            }
            if (num == 3)
            {
                mes = "MAR";
            }
            if (num == 4)
            {
                mes = "ABR";
            }
            if (num == 5)
            {
                mes = "MAY";
            }
            if (num == 6)
            {
                mes = "JUN";
            }
            if (num == 7)
            {
                mes = "JUL";
            }
            if (num == 8)
            {
                mes = "AGO";
            }
            if (num == 9)
            {
                mes = "SEP";
            }
            if (num == 10)
            {
                mes = "OCT";
            }
            if (num == 11)
            {
                mes = "NOV";
            }
            if (num == 12)
            {
                mes = "DIC";
            }
            return mes;
        }


        public MySqlConnection ElegirSucursal()
        {

            MySqlConnection con = null;
            try
            {
                string tienda = CB_sucursal.SelectedItem.ToString();
                int mes = DT_inicio.Value.Month;
                int año = DT_inicio.Value.Year;
                //DateTime fecha = DT_fecha.Value;




                if (CHK_respaldo.Checked == true)
                {
                    string mesRespaldo = ObtenerMes(mes);
                    if (tienda.Equals("VALLARTA"))
                    {
                        con = BDConexicon.RespaldoVA(mesRespaldo, año);
                    }
                    if (tienda.Equals("RENA"))
                    {
                        con = BDConexicon.RespaldoRE(mesRespaldo, año);
                    }

                    if (tienda.Equals("COLOSO"))
                    {
                        con = BDConexicon.RespaldoCO(mesRespaldo, año);
                    }

                    if (tienda.Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.RespaldoVE(mesRespaldo, año);
                    }

                    if (tienda.Equals("PREGOT"))
                    {
                        con = BDConexicon.RespaldoPRE(mesRespaldo, año);
                    }

                }
                else
                {
                    if (tienda.Equals("BODEGA"))
                    {
                        con = BDConexicon.BodegaOpen();
                    }
                    if (tienda.Equals("VALLARTA"))
                    {
                        con = BDConexicon.VallartaOpen();
                    }
                    if (tienda.Equals("RENA"))
                    {
                        con = BDConexicon.RenaOpen();
                    }

                    if (tienda.Equals("COLOSO"))
                    {
                        con = BDConexicon.ColosoOpen();
                    }

                    if (tienda.Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.VelazquezOpen();
                    }

                    if (tienda.Equals("PREGOT"))
                    {
                        con = BDConexicon.Papeleria1Open();
                    }

              
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Debes elegir una sucursal ERROR: " + ex);
            }

            return con;


        }



        //asigna el valor de la conexion segun la sucursal seleccionada
        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            conexion = ElegirSucursal();
            string linea = CB_lineas.SelectedItem.ToString();
            int cantidad = Convert.ToInt32(TB_cantidad.Text);

            string query = "SELECT prods.articulo as ARTICULO, partvta.observ as DESCRIP, SUM(partvta.cantidad) as Cantidad FROM partvta INNER JOIN prods ON partvta.ARTICULO=prods.ARTICULO " +
                "where prods.LINEA = '" + linea + "' " +
                "GROUP BY partvta.observ ORDER BY Cantidad DESC LIMIT " + cantidad + "  ";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_tabla.Rows.Add(dr["ARTICULO"].ToString(),dr["DESCRIP"].ToString(),dr["Cantidad"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void CB_sucursal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conexion = ElegirSucursal();
            string query = "SELECT LINEA FROM LINEAS ORDER BY LINEA";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_lineas.Items.Add(dr["LINEA"]);
            }
            dr.Close();
            conexion.Close();
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A200"].NumberFormat = "@";
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
