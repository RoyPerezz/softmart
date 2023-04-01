
using appSugerencias.Gastos.Vistas;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos_Externos.Vistas
{
    public partial class ListaGastosFinanzas : Form
    {
        public ListaGastosFinanzas()
        {
            InitializeComponent();
        }

        public void PintarFila()
        {

#pragma warning disable CS0219 // La variable 'estado' está asignada pero su valor nunca se usa
            string estado = "", aprobacion = "";
#pragma warning restore CS0219 // La variable 'estado' está asignada pero su valor nunca se usa


            if (DG_tabla.Rows.Count > 0)
            {
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                   // estado = DG_tabla.Rows[i].Cells["ESTADOREVISION"].Value.ToString();
                    aprobacion = DG_tabla.Rows[i].Cells["ESTADO"].Value.ToString();
                    //if (estado.Equals("REVISADO"))
                    //{
                    //    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                    //    DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    //}

                    if ( aprobacion.Equals("RECHAZADO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }else if (aprobacion.Equals("APROBADO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (aprobacion.Equals("CORREGIDO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }

        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            List<GastoExterno> lista = GastoFinanzasController.ListaGastos(inicio,fin);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Id,item.Fecha.ToString("yyyy-MM-dd"),item.Importe,item.Folio,item.PersonaGeneraGasto,item.Concepto_gral,item.ConceptoDetalle,item.Descripcion,item.Foto1,item.NombreFoto1,item.Foto2,item.NombreFoto2,item.ComentarioAprobacion,item.EstadoAprobacion,item.NumAutorizacion);
            }
            PintarFila();
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";

        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            GastoExterno ge = new GastoExterno()
            {
                Id = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells["ID"].Value.ToString()),
                Fecha = Convert.ToDateTime(DG_tabla.Rows[e.RowIndex].Cells["FECHA"].Value.ToString()),
                Importe = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["IMPORTE"].Value.ToString()),
                Folio = DG_tabla.Rows[e.RowIndex].Cells["FOLIO"].Value.ToString(),
                PersonaGeneraGasto = DG_tabla.Rows[e.RowIndex].Cells["PERSONA"].Value.ToString(),
                Concepto_gral = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTOGRAL"].Value.ToString(),
                ConceptoDetalle = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTODETALLE"].Value.ToString(),
                Descripcion = DG_tabla.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString(),
                Foto1 = DG_tabla.Rows[e.RowIndex].Cells["FOTO1"].Value.ToString(),
                Foto2 = DG_tabla.Rows[e.RowIndex].Cells["FOTO2"].Value.ToString(),
                ComentarioAprobacion = DG_tabla.Rows[e.RowIndex].Cells["COMENTARIO"].Value.ToString(),
                EstadoAprobacion = DG_tabla.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString(),
                NumAutorizacion = DG_tabla.Rows[e.RowIndex].Cells["NUMAUTORIZACION"].Value.ToString(),
                NombreFoto1 = DG_tabla.Rows[e.RowIndex].Cells["NOMBRE1"].Value.ToString(),
                NombreFoto2 = DG_tabla.Rows[e.RowIndex].Cells["NOMBRE2"].Value.ToString()
                
            };

            CapturaGastoFinanzas gf = new CapturaGastoFinanzas(ge,"");
            gf.Show();
        }
    }
}
