using appSugerencias.Cajas.Cajeras.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Cajas.Cajeras.Vista
{
    public partial class VistaAuxArticulos : Form
    {
        string articulo = "";
        string clave = "", descripcion = "";
        public VistaAuxArticulos(string articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
        }
        
        public void BuscarArticulos()
        {
            DataTable dt = IncidenciasEtiquetasController.BuscarArticulosCoincidencia(articulo);

            foreach (DataRow item in dt.Rows)
            {
                DG_tabla.Rows.Add(item["ARTICULO"].ToString(),item["DESCRIPCION"].ToString());
            }
        }
        private void VistaAuxArticulos_Load(object sender, EventArgs e)
        {
            BuscarArticulos();
        }

        private void DG_tabla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                clave = DG_tabla.Rows[e.RowIndex].Cells[0].Value.ToString();
                descripcion = DG_tabla.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            catch (Exception ex)

            {


            }
        }

        private void DG_tabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegistroIncidenciaEtiqueta etiqueta = Owner as RegistroIncidenciaEtiqueta;
                etiqueta.TB_articulo.Text = clave;
                etiqueta.TB_descripcion.Text =descripcion;
                this.Close();
            }
        }
    }
}
