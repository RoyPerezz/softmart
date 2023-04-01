using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ReporteComVerif : Form
    {
        public ReporteComVerif()
        {
            InitializeComponent();
        }

       
        ArrayList ids = new ArrayList();
        ArrayList verificadores = new ArrayList();
        ArrayList fechas = new ArrayList();

        double totalPagar = 0;


        public void Verificadores()
        {
            DG_tabla.Rows.Clear();
            TB_total.Text = "";
            fechas.Clear();

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            //SE OBTIENE LAS FECHAS PARA COLOCAR COMO NOMBRE DE COLUMNAS
            int indice = 1;
            string aux = "";
            for (DateTime dia = inicio; dia <= fin; dia = dia.AddDays(1))
            {
                aux = Convert.ToString(dia.ToShortDateString());
                fechas.Add(aux);
            }

            for (int j = 0; j < fechas.Count; j++)
            {
                DG_tabla.Columns[indice].HeaderText = Convert.ToString(fechas[j]);
                DG_tabla.Columns[indice].Name = Convert.ToString(fechas[j]);
                indice++;
            }
            //###############################################################



            string query = "SELECT DISTINCT verificador FROM rd_comisiones_verif WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_tabla.Rows.Add(dr["verificador"].ToString(), "$0.00", "$0.00", "$0.00", "$0.00", "$0.00", "$0.00", "$0.00", "$0.00");
            }
            dr.Close();

          


            //COLOCAR CANTIDADES A CADA USUARIO EN FECHA CORRESPONDIENTE
            string calificaciones = "SELECT verificador,fecha,total FROM rd_comisiones_verif WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlCommand cmd3 = new MySqlCommand(calificaciones, conexion);
            MySqlDataReader dr3 = null;
            string verificador = "";
            string verificadorBD = "";
            string comision = "";
            string fecha = "";
            DateTime f2;
            for (int rows = 0; rows < DG_tabla.RowCount; rows++)
            {
                verificador = Convert.ToString(DG_tabla.Rows[rows].Cells[0].Value);
                dr3 = cmd3.ExecuteReader();

                while (dr3.Read())
                {
                    verificadorBD = dr3["verificador"].ToString();
                    f2 = Convert.ToDateTime(dr3["fecha"].ToString());
                    fecha = f2.ToString("dd/MM/yyyy");

                    comision = dr3["total"].ToString();

                    for (int col = 0; col <= DG_tabla.ColumnCount; col++)
                    {
                        if (verificador.Equals(verificadorBD) && fecha.Equals(DG_tabla.Columns[col].HeaderText))
                        {
                            double c = Convert.ToDouble(comision);

                           
                            DG_tabla.Rows[rows].Cells[col].Value = String.Format("{0:0.##}", c.ToString("C"));
                            break;
                        }


                    }
                }
                dr3.Close();
            }
           
            conexion.Close();

            string texto = "";
            double columna = 0;
            double total = 0;
            decimal digito2 = 0;
            totalPagar = 0;
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                for (int j = 1; j < DG_tabla.ColumnCount; j++)
                {


                    digito2 = decimal.Parse(DG_tabla.Rows[i].Cells[j].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    texto = digito2.ToString("G0");
                    columna = Convert.ToDouble(texto);
                    total += columna;

                    //tope normal
                    if (total>900)
                    {
                        total = 900;
                    }
                }

                DG_tabla.Rows[i].Cells[8].Value = Convert.ToString(String.Format("{0:0.##}", total.ToString("C")));
                total = 0;
            }

          
            decimal digito3 = 0;
            string texto2 = "";
            double totales = 0;
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {

                digito3 = decimal.Parse(DG_tabla.Rows[i].Cells[8].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                texto2 = digito3.ToString("G0");
                totales = Convert.ToDouble(texto2);
                totalPagar += totales;
          
            }

            TB_total.Text=Convert.ToString(String.Format("{0:0.##}", totalPagar.ToString("C")));
            
        }    

        private void BT_consultar_Click(object sender, EventArgs e)
        {
            Verificadores();
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            DateTime F_ini, F_fin;
            string inicio = "", fin = "";

            F_ini = DT_inicio.Value;
            F_fin = DT_fin.Value;

            inicio = F_ini.ToLongDateString();
            fin = F_fin.ToLongDateString();


            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



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

            excel.Cells.Range["A4:J4"].Merge();
            excel.Cells.Range["A4"].Value = "COMISIONES DE LA SEMANA DEL    " + inicio.ToUpper() + "   AL    " + fin.ToUpper();


            excel.Cells.Range["G18:H18"].Merge();
            excel.Cells.Range["G18"].Value = "TOTAL COMISIONES =";
            excel.Cells.Range["I18"].Value =totalPagar;
            excel.Cells.Range["I18"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["B6:I16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["I6:I16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["J6:J16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["K6:K16"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["L6:L16"].NumberFormat = "$#,##0.00";

            excel.Visible = true;
        }
    }
}
