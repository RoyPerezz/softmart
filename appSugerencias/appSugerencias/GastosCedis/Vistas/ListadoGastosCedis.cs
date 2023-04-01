using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.GastosCedis.Vistas
{
    public partial class ListadoGastosCedis : Form
    {
        public ListadoGastosCedis()
        {
            InitializeComponent();
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            GastosRechazadosYPorCorregir();
            DG_tabla.Rows.Clear();
            DateTime inicio, fin;
            inicio = DT_inicio.Value;
            fin = DT_fin.Value;
            List<GastoAlmacenCedis> lista = GastosAlmacenCedisController.BuscarGastos(inicio,fin);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Id,item.ConceptoGral,item.ConceptoDetalle,item.DescripcionDetallada,item.Importe,item.FolioSalida,item.Fecha.ToString("yyyy-MM-dd"),item.Imagen1,item.NombreFoto,item.Imagen2,item.NombreFoto2,item.EstadoRevision,item.EstadoAprobacion,item.ComRevision,item.ComSra,item.FolioAprobacion);
            }

            PintarFila();
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string estado = DG_tabla.Rows[e.RowIndex].Cells["ESTADOAPROBACION"].Value.ToString();
            if (!estado.Equals("APROBADO"))
            {
                GastoAlmacenCedis ac = new GastoAlmacenCedis()
                {
                    Id = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells["ID"].Value),
                    ConceptoGral = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTOGRAL"].Value.ToString(),
                    ConceptoDetalle = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTODETALLE"].Value.ToString(),
                    DescripcionDetallada = DG_tabla.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString(),
                    Importe = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["IMPORTE"].Value.ToString()),
                    FolioSalida = DG_tabla.Rows[e.RowIndex].Cells["FOLIOSALIDA"].Value.ToString(),
                    Fecha = Convert.ToDateTime(DG_tabla.Rows[e.RowIndex].Cells["FECHA"].Value.ToString()),
                    Imagen1 = DG_tabla.Rows[e.RowIndex].Cells["IMAGEN1"].Value.ToString(),
                    Imagen2 = DG_tabla.Rows[e.RowIndex].Cells["IMAGEN2"].Value.ToString(),
                    NombreFoto = DG_tabla.Rows[e.RowIndex].Cells["NOMBREFOTO1"].Value.ToString(),
                    NombreFoto2 = DG_tabla.Rows[e.RowIndex].Cells["NOMBREFOTO2"].Value.ToString(),
                    ComRevision = DG_tabla.Rows[e.RowIndex].Cells["COMREVISION"].Value.ToString(),
                    ComSra = DG_tabla.Rows[e.RowIndex].Cells["COMAPROBACION"].Value.ToString(),
                    EstadoRevision = DG_tabla.Rows[e.RowIndex].Cells["ESTADOREVISION"].Value.ToString(),
                    EstadoAprobacion = DG_tabla.Rows[e.RowIndex].Cells["ESTADOAPROBACION"].Value.ToString(),
                    Actualizar = true
                };
                GastosAlmacenCedis gac = new GastosAlmacenCedis(ac);
                gac.Show();
            }
            else
            {
                MessageBox.Show("El gasto ya no se puede alterar porque ya fue aprobado");
            }
        }

        public void PintarFila()
        {

            string estado = "", aprobacion = "";


            if (DG_tabla.Rows.Count > 0)
            {
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    estado = DG_tabla.Rows[i].Cells["ESTADOREVISION"].Value.ToString();
                    aprobacion = DG_tabla.Rows[i].Cells["ESTADOAPROBACION"].Value.ToString();
                    if (estado.Equals("REVISADO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (estado.Equals("CORREGIR") || aprobacion.Equals("RECHAZADO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (estado.Equals("CORREGIDO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }

        }

        public void GastosRechazadosYPorCorregir()
        {
            DataTable dt = GastosAlmacenCedisController.GastosPorCorregir();
            DataTable dt2 = GastosAlmacenCedisController.GastosRechazados();
            int num = dt.Rows.Count;
            int num2 = dt2.Rows.Count;
            if (num > 0)
            {

                LB_mensaje.Visible = true;
                LK_label.Visible = true;
            }


            if (num2 > 0)
            {
                LB_mensaje2.Visible = true;
                LK_label2.Visible = true;
            }
        }
        private void ListadoGastosCedis_Load(object sender, EventArgs e)
        {
            GastosRechazadosYPorCorregir();
        }

        private void LK_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            CantGastosPorCorregir gxc = new CantGastosPorCorregir(false);
            gxc.Show();
        }

        private void LK_label2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            CantGastosPorCorregir gxc = new CantGastosPorCorregir(true);
            gxc.Show();
        }
    }
}
