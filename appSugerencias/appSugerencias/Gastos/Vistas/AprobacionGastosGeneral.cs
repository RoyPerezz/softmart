using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
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

namespace appSugerencias.Gastos
{
    public partial class AprobacionGastosGeneral : Form
    {
        public AprobacionGastosGeneral()
        {
            InitializeComponent();
        }

        public void PintarFila()
        {

            string estado = "";


            if (DG_tabla.Rows.Count > 0)
            {
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    estado = DG_tabla.Rows[i].Cells["ESTADO"].Value.ToString();

                    if (estado.Equals("APROBADO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (estado.Equals("RECHAZADO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (estado.Equals("CORREGIDO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                }
            }

        }
        public void BuscarGastos(string sucursal)
        {

            LB_total.Text = "";
            DG_tabla.Rows.Clear();
            DG_tabla.RowTemplate.Height = 30;
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            if (sucursal.Equals("FINANZAS"))
            {
                List<GastoExterno> lista = GastoFinanzasController.ListaGastos(inicio, fin);
                double total = 0;
                if (lista.Count == 0)
                {
                    MessageBox.Show("No hay gastos en el rango de fecha seleccionado");
                }
                else
                {
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.EstadoAprobacion, item.Id, "", "", item.Fecha.ToString("yyyy-MM-dd"), item.Importe, item.PersonaGeneraGasto, item.Descripcion, item.Concepto_gral, item.ConceptoDetalle, item.Folio, item.Foto1, item.Foto2, item.ComentarioAprobacion, item.NumAutorizacion);
                        total += item.Importe;
                    }

                    LB_total.Text = total.ToString("C2");
                    total = 0;
                    PintarFila();
                    DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";

                    lista.Clear();


                    DG_tabla.Columns["PERSONA"].Visible = true;
                }

            }
            else if (sucursal.Equals("CEDIS"))
            {
                List<GastoAlmacenCedis> lista = GastosAlmacenCedisController.BuscarGastos(inicio, fin);

                double total = 0;
                if (lista.Count == 0)
                {
                    MessageBox.Show("No hay gastos en el rango de fecha seleccionado");
                }
                else
                {
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.EstadoAprobacion, item.Id, "", "", item.Fecha.ToString("yyyy-MM-dd"), item.Importe, item.Usuario, item.DescripcionDetallada, item.ConceptoGral, item.ConceptoDetalle, item.FolioSalida, item.Imagen1, item.Imagen2, item.ComSra, item.FolioAprobacion);
                        total += item.Importe;
                    }

                    LB_total.Text = total.ToString("C2");
                    total = 0;
                    PintarFila();
                    DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";

                    lista.Clear();

                    DG_tabla.Columns["PERSONA"].Visible = false;
                }

            }
            DG_tabla.Columns["ESTADO"].Width = 145;
            DG_tabla.Columns["FECHA"].Width = 90;
            DG_tabla.Columns["IMPORTE"].Width = 100;
            DG_tabla.Columns["PERSONA"].Width = 200;
            DG_tabla.Columns["CONCEPTOGRAL"].Width = 150;
            DG_tabla.Columns["CONCEPTODETALLE"].Width = 150;
            DG_tabla.Columns["DESCRIPCION"].Width = 260;
            DG_tabla.Columns["FOLIO"].Width = 130;
            DG_tabla.Columns["COMENTARIO"].Width = 250;
            DG_tabla.Columns["NUMAUTORIZACION"].Width = 120;



        }
        private void BT_buscar_Click(object sender, EventArgs e)
        {
            BuscarGastos(CB_sucursal.Text);


        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            string estado = "";
            string numAprobacion = "";
            int id = 0;
            string comentarioSRA = "";
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {

                estado = DG_tabla.Rows[i].Cells["ESTADO"].Value.ToString();
                id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value.ToString());

                if (!estado.Equals("APROBADO"))
                {
                    numAprobacion = "0";

                    if (DG_tabla.Rows[i].Cells["COMENTARIO"].Value == null || DG_tabla.Rows[i].Cells["COMENTARIO"].Value.ToString().Equals(""))
                    {
                        comentarioSRA = "";
                    }
                    else
                    {
                        comentarioSRA = DG_tabla.Rows[i].Cells["COMENTARIO"].Value.ToString();
                    }



                    if (CB_sucursal.Text.Equals("FINANZAS"))
                    {
                        GastosAlmacenCedisController.ActualizarEstadoAprobacionFinanzas(estado, numAprobacion, comentarioSRA, id);

                    }else if(CB_sucursal.Text.Equals("CEDIS"))
                    {

                        GastosAlmacenCedisController.ActualizarEstadoAprobacion(estado,numAprobacion,comentarioSRA,id);
                    }
                    else
                    {

                    }
                    
                }
                else
                {

                    numAprobacion = DG_tabla.Rows[i].Cells["NUMAUTORIZACION"].Value.ToString();
                    int num = 0;
                    if (numAprobacion.Equals("0"))
                    {


                        if (CB_sucursal.Text.Equals("FINANZAS"))
                        {
                            num = Convert.ToInt32(RevisionGastosController.NumAutorizacionFinanzas());
                            numAprobacion = "F" + "-" + num.ToString();
                            comentarioSRA = DG_tabla.Rows[i].Cells["COMENTARIO"].Value.ToString();
                            GastosAlmacenCedisController.ActualizarEstadoAprobacionFinanzas(estado, numAprobacion, comentarioSRA, id);

                        }else if(CB_sucursal.Text.Equals("CEDIS"))
                        {
                            num = Convert.ToInt32(RevisionGastosController.GenerarNumAprobacion("CEDIS"));
                            numAprobacion = "GG" + "" + num.ToString();
                            comentarioSRA = DG_tabla.Rows[i].Cells["COMENTARIO"].Value.ToString();
                            GastosAlmacenCedisController.ActualizarEstadoAprobacion(estado, numAprobacion, comentarioSRA, id);
                        }
                        else
                        {

                        }
                       


                    }

                }            
               
                    
            }


            BuscarGastos(CB_sucursal.Text);
           

            MessageBox.Show("Se han guardado los cambios");
        }

        private void BT_aprobar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = DG_tabla.SelectedRows;


            if (filas.Count > 0)
            {
                foreach (DataGridViewRow item in filas)
                {
                    DG_tabla.Rows[item.Index].Cells["ESTADO"].Value = "APROBADO";
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila");
            }
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string foto1 = "";
                string foto2 = "";
                string foto3 = "";
                string comentario = "";
                string comrevision2 = "";
                string comentarioRev = "";


                foto1 = DG_tabla.Rows[e.RowIndex].Cells["FOTO1"].Value.ToString();
                foto2 = DG_tabla.Rows[e.RowIndex].Cells["FOTO2"].Value.ToString();
                //foto3 = DG_tabla.Rows[e.RowIndex].Cells["FOTO3"].Value.ToString();
                comentario = DG_tabla.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString();
                //comrevision2 = DG_tabla.Rows[e.RowIndex].Cells["COMREV2"].Value.ToString();
                //comentarioRev = DG_tabla.Rows[e.RowIndex].Cells["COMENTARIO"].Value.ToString();
                FotoRevision revision = new FotoRevision(foto1, comentario, "", foto2, comentarioRev, comrevision2);
                revision.Show();
            }

            catch (Exception ex)

            {

                MessageBox.Show("No hay datos de estos gastos");
            }
        }

        private void BT_gastosXAprobar_Click(object sender, EventArgs e)
        {
            //Evita que la vista de agregar foto se abra mas de una vez
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GastosXAprobar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }
            else
            {
                GastosXAprobar aprobar = new GastosXAprobar(CB_sucursal.Text);
                aprobar.Show();
            }
        }
    }
}
