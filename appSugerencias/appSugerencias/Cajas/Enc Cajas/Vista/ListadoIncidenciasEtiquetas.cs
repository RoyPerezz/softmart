using appSugerencias.Cajas.Cajeras.Controlador;
using appSugerencias.Cajas.Cajeras.Modelo;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Cajas.Enc_Cajas.Vista
{
    public partial class ListadoIncidenciasEtiquetas : Form
    {
        public ListadoIncidenciasEtiquetas()
        {
            InitializeComponent();
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            List<IncidenciaEtiqueta> lista = IncidenciasEtiquetasController.ListadoIncidencias(inicio,fin);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Id,item.Articulo,item.Descripcion,item.Fecha.ToString("yyyy-MM-dd"),item.Usuario,item.Caja,item.Incidencia,item.RutaFoto,item.NombreFoto);
            }
        }

        private void DT_fin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DT_inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            IncidenciaEtiqueta ie = new IncidenciaEtiqueta();

            ie.Id = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            ie.Articulo = DG_tabla.Rows[e.RowIndex].Cells["ARTICULO"].Value.ToString();
            ie.Descripcion = DG_tabla.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString();
            ie.Fecha = Convert.ToDateTime(DG_tabla.Rows[e.RowIndex].Cells["FECHA"].Value.ToString());
            ie.Usuario = DG_tabla.Rows[e.RowIndex].Cells["USUARIO"].Value.ToString();
            ie.Incidencia = DG_tabla.Rows[e.RowIndex].Cells["INCIDENCIA"].Value.ToString();
            ie.Caja = DG_tabla.Rows[e.RowIndex].Cells["CAJA"].Value.ToString();


            ie.RutaFoto = DG_tabla.Rows[e.RowIndex].Cells["RUTAFOTO"].Value.ToString();
            ie.NombreFoto = DG_tabla.Rows[e.RowIndex].Cells["NOMBREFOTO"].Value.ToString();

            

            

            AgregarFotoIncidenciaEtiqueta af = new AgregarFotoIncidenciaEtiqueta(ie,true);
            af.Show();

        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;

            excel.Range["A1:A4000"].NumberFormat = "@";
            //coloca el nombre de cada columna en la columna A fila 5

            for (int i = 0; i < DG_tabla.Columns.Count - 1; i++)
            {

                if (DG_tabla.Columns[i].Visible == true)
                {
                    indiceColumna++;
                    excel.Cells[5, indiceColumna] = DG_tabla.Columns[i].Name;
                }
            }
            int indiceFila = 4;




            //Coloca las filas en cada columna

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {

                indiceFila++;
                indiceColumna = 0;
                for (int j = 0; j < DG_tabla.Columns.Count - 1; j++)
                {

                    if (DG_tabla.Columns[j].Visible == true)
                    {
                        indiceColumna++;
                        excel.Cells[indiceFila + 1, indiceColumna] = DG_tabla.Rows[i].Cells[DG_tabla.Columns[j].Name].Value;
                    }
                }
            }

            int indice = indiceFila + 1;
            int indiceHorizontal = indiceFila + 2;
            excel.Cells.Range["E5"].Value = "FECHA";
            excel.Cells.Range["A4:A4"].Value = "Reporte de etiquetas por corregir";
            excel.Cells.Range["A5:F5"].Interior.ColorIndex = 25;
            excel.Cells.Range["A5:F5"].Font.ColorIndex = 2;
            excel.Cells.Range["A5:F" + indice].Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A5:A" + indice].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["D5:F" + indice].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A4:F" + indiceHorizontal].Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;

            excel.Visible = true;
        }

        private void ListadoIncidenciasEtiquetas_Load(object sender, EventArgs e)
        {

        }
    }
}
