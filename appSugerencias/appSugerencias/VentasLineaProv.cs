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
    public partial class VentasLineaProv : Form
    {
        public VentasLineaProv()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public string Mes(int num)
        {
            string mes = "";

            switch (num)
            {
                case 1: mes = "ENE";
                    break;
                case 2: mes = "FEB";
                    break;
                case 3:
                    mes = "MAR";
                    break;
                case 4:
                    mes = "ABR";
                    break;
                case 5:
                    mes = "MAY";
                    break;
                case 6:
                    mes = "JUN";
                    break;
                case 7:
                    mes = "JUL";
                    break;
                case 8:
                    mes = "AGO";
                    break;
                case 9:
                    mes = "SEP";
                    break;
                case 10:
                    mes = "OCT";
                    break;
                case 11:
                    mes = "NOV";
                    break;
                case 12:
                    mes = "DIC";
                    break;

                default:
                    break;

                  
            }
            return mes;
        }
        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            string query = "SELECT prods.linea,lineas.descrip AS `desclinea`,SUM( IF( ventas.tipo_doc = 'DV' OR ventas.tipo_doc = 'DEV', IF( partvta.invent <> 0, partvta.cantidad, 0 ),(partvta.cantidad - partvta.a01)) ) AS cantvend, SUM((partvta.costo *(partvta.cantidad - partvta.a01)* (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `costo`, SUM((partvta.costo *(partvta.cantidad - partvta.a01)* (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100) ) As `Impuesto`, SUM((partvta.costo *(partvta.cantidad - partvta.a01)* (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100) )) As `Total`  " +
                "FROM((partvta LEFT JOIN ventas ON ventas.venta = partvta.venta) INNER JOIN prods ON partvta.articulo = prods.articulo) INNER JOIN lineas ON prods.linea = lineas.linea " +
                "WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND partvta.USUFECHA BETWEEN '" + inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"'"+
                "GROUP BY lineas.linea ORDER BY lineas.linea";
            MySqlConnection conexion = null;

            try
            {

                if (CHX_check.Checked)
                {
                    //REALIZARÁ LA BUSQUEDA EN LA BD DEL MES ACTUAL  MYBUSINESSDELTA
                   conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                }
                else
                {
                    //REALIZARÁ LA BUSQUEDA EN EL RESPALDO DEL MES SELECCIONADO EN EL  RANGO DE FECHAS
                    string sucursal = CB_sucursal.SelectedItem.ToString();
                    string mes = Mes(inicio.Month);
                    conexion = BDConexicon.RespMultiSuc(sucursal,mes,inicio.Year);
                }

               
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DG_tabla.Rows.Add(dr["desclinea"].ToString(), Convert.ToDouble(dr["costo"].ToString()), Convert.ToDouble(dr["impuesto"].ToString()), Convert.ToDouble(dr["total"].ToString()));
                }
                dr.Close();
                conexion.Close();

                double totalCosto = 0, totalImpuesto = 0, sumaTotal = 0;

                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    totalCosto += Convert.ToDouble(DG_tabla.Rows[i].Cells[1].Value);
                    totalImpuesto += Convert.ToDouble(DG_tabla.Rows[i].Cells[2].Value);
                    sumaTotal += Convert.ToDouble(DG_tabla.Rows[i].Cells[3].Value);


                }

                DG_tabla.Rows.Add("TOTALES",totalCosto,totalImpuesto,sumaTotal);
                DG_tabla.Columns["COSTO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["IMPUESTO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

                int numFilas = DG_tabla.Rows.Count;
                DG_tabla.Rows[numFilas - 1].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                DG_tabla.Rows[numFilas - 1].DefaultCellStyle.ForeColor = Color.White;
             
            }
            catch (Exception ex)
            {

                MessageBox.Show("EXEPCION CONTROLADA "+ex);
            }
        }

        private void VentasLineaProv_Load(object sender, EventArgs e)
        {
            DG_tabla.Columns[0].Width = 200;
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


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



            excel.Cells.Range["A3:F3"].Merge();
            excel.Cells.Range["A3"].Value = "VENTAS DEL " + inicio.ToString("dd-MM-yyyy") + " AL " + fin.ToString("dd-MM-yyyy") + "";
            excel.Cells.Range["B6:J30"].NumberFormat = "$#,##0.00";
        

            excel.Visible = true;
        }
    }
}
