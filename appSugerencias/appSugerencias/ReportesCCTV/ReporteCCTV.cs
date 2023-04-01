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

namespace appSugerencias.ReportesCCTV
{
    public partial class ReporteCCTV : Form
    {
        string usuario = "";
        public ReporteCCTV(string user)
        {
            usuario = user;
          
            InitializeComponent();
        }

  

        private void BT_exportar_Click(object sender, EventArgs e)
        {

            //OBTENER LAS SUCURSALES DONDE EL USUARIO GENERÓ EL REPORTE
            MySqlConnection con = BDConexicon.BodegaOpen();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            ArrayList sucursales = new ArrayList();
            ArrayList conceptos = new ArrayList();

            DataTable dt2 = new DataTable();
            
            MySqlCommand cmd = new MySqlCommand("SELECT  DISTINCT sucursal FROM rd_reporte_cctv WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "' AND usuario='"+usuario+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            //LAS SUCURSALES SE GUARDAN EN EL ARREGLO
            while (dr.Read())
            {
                sucursales.Add(dr["sucursal"].ToString());
            }
            dr.Close();


           
           


            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel.Worksheet hoja = null;//DECLARO UNA HOJA DE EXCEL

            MySqlCommand cmd3 = new MySqlCommand("SELECT concepto FROM rd_conceptoscctv",con);
            MySqlDataReader dr2 = cmd3.ExecuteReader();
            while (dr2.Read())
            {
                conceptos.Add(dr2["concepto"].ToString());
            }
            dr2.Close();

            try
            {

               
                for (int i = 0; i < sucursales.Count; i++)
                {

                    dt.Clear();
                    dt2.Clear();

                    MySqlCommand cmd2 = new MySqlCommand("SELECT concepto,descripcion,fecha,hora FROM rd_reporte_cctv WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "' AND usuario='" + usuario + "' AND sucursal='"+sucursales[i].ToString()+"'",con);
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
                    ad.Fill(dt);
                    DG_tabla.DataSource = dt;

                    MySqlCommand cmd4 = new MySqlCommand("SELECT concepto,count(concepto) as num_reportes FROM rd_reporte_cctv WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "' AND usuario='" + usuario + "' AND sucursal='" + sucursales[i].ToString() + "' GROUP BY concepto", con);
                    MySqlDataAdapter ad2 = new MySqlDataAdapter(cmd4);
                    ad2.Fill(dt2);
                    DG_tabla2.DataSource = dt2;




                    hoja = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets.Add();//AGREGO LA HOJA DE EXCEL
                    hoja.Name = sucursales[i].ToString();

                
            
                    //lista de incidencias
                    int indiceColumna = 0;

                    foreach (DataGridViewColumn col in DG_tabla.Columns)
                    {
                        indiceColumna++;
                        excel.Cells[7, indiceColumna] = col.Name;


                        excel.Range["A6:D6"].Merge();
                        excel.Range["A6:D6"].Value = "LISTADO DE INCIDENCIAS";

                        excel.Range["F6:G6"].Merge();
                        excel.Range["F6:G6"].Value = "NUMERO DE INCIDENCIAS";

                        excel.Range["A7:D7"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                        excel.Range["A7:D7"].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                        excel.Range["A7:D7"].Font.Bold = 1;

                        excel.Range["F7:G7"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
                        excel.Range["F7:G7"].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);
                        excel.Range["F7:G7"].Font.Bold = 1;
                    }

                    int indiceFila = 6;

                    foreach (DataGridViewRow row in DG_tabla.Rows)
                    {
                        indiceFila++;
                        indiceColumna = 0;




                        foreach (DataGridViewColumn col in DG_tabla.Columns)
                        {
                            indiceColumna++;

                            excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value.ToString();

                        }

                    }

                    //num de incidencias por concepto
                    int indexColumna = 5;

                    foreach (DataGridViewColumn col in DG_tabla2.Columns)
                    {
                        indexColumna++;
                        excel.Cells[7, indexColumna] = col.Name;

                    }

                    int indexFila = 6;

                    foreach (DataGridViewRow row in DG_tabla2.Rows)
                    {
                        indexFila++;
                        indexColumna = 5;




                        foreach (DataGridViewColumn col in DG_tabla2.Columns)
                        {
                            indexColumna++;

                            excel.Cells[indexFila + 1, indexColumna] = row.Cells[col.Name].Value.ToString();

                        }

                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }






            con.Close();


            excel.Visible = true;
        }

        private void ReporteCCTV_Load(object sender, EventArgs e)
        {
            LB_usuario.Text = usuario;
        }
    }
}
