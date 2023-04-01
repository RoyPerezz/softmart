using appSugerencias.Piso_de_venta.Controladores;
using appSugerencias.Piso_de_venta.Modelo;
using appSugerencias.Utilidades;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Piso_de_venta.Vista
{
    public partial class ReporteArticulosExistencia : Form
    {
        string clave = "";
        public ReporteArticulosExistencia()
        {
            InitializeComponent();
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DG_tabla.Rows.Clear();
            List<Articulo> lista = PisoVentaController.ArticulosConExistencia(clave);
            int num = 1;
          
            foreach (var item in lista)
            {
                DG_tabla.Rows.Add("0",item.Clave, item.Descripcion, item.PrecioMayoreo.ToString("C2"), item.PrecioMenudeo.ToString("C2"), item.Existencia);
                
            }
            DG_tabla.Sort(DG_tabla.Columns[2], ListSortDirection.Ascending);
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                DG_tabla.Rows[i].Cells[0].Value = num;
                num++;
            }


            lista.Clear();
            LB_cantidad.Text = DG_tabla.Rows.Count.ToString() + " artículos";
            
        }

        private void ReporteArticulosExistencia_Load(object sender, EventArgs e)
        {
            List<Articulo> lineas = PisoVentaController.Lineas();
           

            foreach (var item in lineas)
            {

                CB_lineas.Items.Add(item.LineaDescrip);
                CB_lineas.ValueMember = item.Linea;
                CB_lineas.DisplayMember = item.LineaDescrip;

            }
        }

        private void CB_lineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            clave = PisoVentaController.Clavelinea(CB_lineas.Text);
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;
            excel.Cells.Range["B6:B20000"].NumberFormat = "@";

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
            excel.Range["A3:C3"].Merge();
            excel.Range["A3"].Value = "Reporte de artículos con existencia";
            excel.Range["A3"].Font.Bold = true;
            excel.Range["A4:C4"].Merge();
            excel.Range["A4"].Value="Departamento: "+CB_lineas.Text;
            excel.Range["A4"].Font.Bold = true;
            excel.Range["D3:G3"].Merge();
            excel.Range["D3"].Value = "Fecha: "+DateTime.Now.ToString("dd-MM-yyyy")+ "            Fecha término: __________________";
            excel.Range["D3"].Font.Bold = true;
            excel.Range["D3:G3"].Merge();




            TextReader IP;
            IP = new StreamReader("IP.txt");
            string sucursal = Sucursal.NombreSucursalIP(IP.ReadLine());
            excel.Range["D4"].Value = "Sucursal: "+sucursal;
            excel.Range["D4"].Font.Bold = true;


            excel.Cells.Range["A5:G5"].Interior.ColorIndex = 25;
            excel.Cells.Range["A5:G5"].Font.ColorIndex = 2;


            string indiceNombre = (indiceFila + 3).ToString();
            excel.Range["B" + indiceNombre].Value = "Nombre: ";
            excel.Range["B" + indiceNombre].Font.Bold = true;
            excel.Cells.Range["C"+indiceNombre].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
           
            string indiceFirma = (indiceFila + 5).ToString();
            excel.Range["B" + indiceFirma].Value = "Firma: ";
            excel.Range["B" + indiceFirma].Font.Bold = true;
            excel.Cells.Range["C" + indiceFirma].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

            //string indiceFechaFin = (indiceFila + 7).ToString();
            //excel.Range["B" + indiceFechaFin].Value = "Fecha término: ";
            //excel.Range["B" + indiceFechaFin].Font.Bold = true;
            //excel.Cells.Range["C" + indiceFechaFin].Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;






            int indice = indiceFila + 1;
            int indiceHorizontal = indiceFila + 2;
            excel.Cells.Range["A5:G" + indice].Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A5:A" + indice].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["D5:G" + indice].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A4:G" + indiceHorizontal].Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;


            excel.Cells.Range["A3:G" + indiceFirma].Font.Size = 9;
          
            excel.Visible = true;
        }
    }
}
