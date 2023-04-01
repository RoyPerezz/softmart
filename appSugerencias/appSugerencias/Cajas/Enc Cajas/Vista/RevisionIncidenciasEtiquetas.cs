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
    public partial class RevisionIncidenciasEtiquetas : Form
    {
        public RevisionIncidenciasEtiquetas()
        {
            InitializeComponent();
        }


        public void BuscarIncidencias()
        {
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            List<IncidenciaEtiqueta> lista = IncidenciasEtiquetasController.ListadoIncidenciasXSucursal(CB_sucursal.SelectedItem.ToString(), inicio, fin);
            DataGridViewCheckBoxCell estado = new DataGridViewCheckBoxCell();



            foreach (var item in lista)
            {
                if (item.Estado == 1)
                {
                    estado.ThreeState = true;
                }
                else
                {
                    estado.ThreeState = false;
                }
                DG_tabla.Rows.Add(item.Id, item.Articulo, item.Descripcion, item.Fecha.ToString("yyyy-MM-dd"), item.Usuario, item.Caja, item.Incidencia, item.RutaFoto, item.NombreFoto, estado.ThreeState);
            }

            PintarFila();
        }
        private void BT_buscar_Click(object sender, EventArgs e)
        {
            BuscarIncidencias();
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {

            string sucursal = CB_sucursal.Text;
            int id = 0;
            int estado = 0;
            bool edo = false;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value.ToString());
                edo = Convert.ToBoolean(DG_tabla.Rows[i].Cells["CHECK"].Value);

                if (edo ==true)
                {
                    estado = 1;
                }
                else{
                    estado = 0;
                }

                IncidenciasEtiquetasController.ActualizarEstadoincidenciaEtiqueta(estado,id,sucursal);
            }

            BuscarIncidencias();
            MessageBox.Show("Se han realizado los cambios correctamente");
        }

        private void RevisionIncidenciasEtiquetas_Load(object sender, EventArgs e)
        {

        }

        public void PintarFila()
        {
            bool edo = false;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {

                edo = Convert.ToBoolean(DG_tabla.Rows[i].Cells["CHECK"].Value);

                if (edo == true)
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                }
                else
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;

            excel.Range["A1:A4000"].NumberFormat = "@";
            //coloca el nombre de cada columna en la columna A fila 5
            string nombreColumna = "";
            for (int i = 0; i < DG_tabla.Columns.Count; i++)
            {

                if (DG_tabla.Columns[i].Visible == true)
                {
                    indiceColumna++;
                    nombreColumna = DG_tabla.Columns[i].Name;

                    if (nombreColumna.Equals("CHECK"))
                    {
                        nombreColumna = "ESTADO";
                    }
                    excel.Cells[5, indiceColumna] = nombreColumna;
                }
            }
            int indiceFila = 4;




            //Coloca las filas en cada columna
            
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {

                indiceFila++;
                indiceColumna = 0;
                string valorColumna = "";
                for (int j   = 0; j < DG_tabla.Columns.Count; j++)
                {

                    if (DG_tabla.Columns[j].Visible == true)
                    {
                        indiceColumna++;
                        valorColumna = DG_tabla.Rows[i].Cells[DG_tabla.Columns[j].Name].Value.ToString();

                        if (valorColumna.Equals("True"))
                        {
                            valorColumna = "SOLUCIONADO";

                        }else if (valorColumna.Equals("False"))
                        {
                            valorColumna = "NO SOLUCIONADO";
                        }
                        excel.Cells[indiceFila + 1, indiceColumna] = valorColumna;
                    }
                }
            }

            DateTime fecha1 = DT_inicio.Value;
            DateTime fecha2 = DT_fin.Value;
            int indice = indiceFila + 1;
            int indiceHorizontal = indiceFila + 2;
            excel.Cells.Range["E5"].Value = "FECHA";
            excel.Cells.Range["A4:D4"].Merge();
            excel.Cells.Range["A4:D4"].Value = "Reporte de etiquetas por corregir del "+fecha1.ToString("dd-MM-yyyy")+" al "+fecha2.ToString("dd-MM-yyyy")+"";
            excel.Cells.Range["A5:G5"].Interior.ColorIndex = 25;
            excel.Cells.Range["A5:G5"].Font.ColorIndex = 2;
            excel.Cells.Range["A5:G" + indice].Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A5:A" + indice].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["D5:G" + indice].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A4:G" + indiceHorizontal].Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;

            excel.Visible = true;
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            IncidenciaEtiqueta ie = new IncidenciaEtiqueta()
            {
                Articulo = DG_tabla.Rows[e.RowIndex].Cells["ARTICULO"].Value.ToString(),
                Descripcion = DG_tabla.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString(),
                Fecha = Convert.ToDateTime(DG_tabla.Rows[e.RowIndex].Cells["FECHA"].Value.ToString()),
                Usuario = DG_tabla.Rows[e.RowIndex].Cells["USUARIO"].Value.ToString(),
                Caja = DG_tabla.Rows[e.RowIndex].Cells["CAJA"].Value.ToString(),
                Incidencia = DG_tabla.Rows[e.RowIndex].Cells["INCIDENCIA"].Value.ToString(),
                RutaFoto = DG_tabla.Rows[e.RowIndex].Cells["RUTAFOTO"].Value.ToString(),
                NombreFoto = DG_tabla.Rows[e.RowIndex].Cells["NOMBREFOTO"].Value.ToString()
            };

            AgregarFotoIncidenciaEtiqueta af = new AgregarFotoIncidenciaEtiqueta(ie,false);
            af.Show();
        }
    }
}
