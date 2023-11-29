using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Ventas.Controlador;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class GastosView : Form
    {
        string usuario = "",area="";
       
        public GastosView(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void GastosView_Load(object sender, EventArgs e)
        {

            area = Empleado.Area(usuario);

            if (area.Equals("ADMON GRAL"))
            {
                DG_tabla.Columns["ID"].ReadOnly = true;
                DG_tabla.Columns["CONCEPTO"].ReadOnly = true;
                DG_tabla.Columns["DESCRIPCION"].ReadOnly = true;
                DG_tabla.Columns["IMPORTE"].ReadOnly = true;
                DG_tabla.Columns["DETALLE"].ReadOnly = true;
                DG_tabla.Columns["RutaFoto"].ReadOnly = true;
                DG_tabla.Columns["FECHA"].ReadOnly = true;
                DG_tabla.Columns["COMENTARIO"].ReadOnly = true;
                DG_tabla.Columns["COMREVISION2"].ReadOnly = true;
                DG_tabla.Columns["NUM_AUTORIZACION"].ReadOnly = true;
            }
            else if(area.Equals("CXPAGAR"))
            {
                DG_tabla.Columns["CONCEPTO"].ReadOnly = true;
                DG_tabla.Columns["DESCRIPCION"].ReadOnly = true;
                DG_tabla.Columns["IMPORTE"].ReadOnly = true;
                DG_tabla.Columns["DETALLE"].ReadOnly = true;
                DG_tabla.Columns["RutaFoto"].ReadOnly = true;
                DG_tabla.Columns["FECHA"].ReadOnly = true;
                DG_tabla.Columns["COMENTARIO"].ReadOnly = true;
                DG_tabla.Columns["NUM_AUTORIZACION"].ReadOnly = true;
            }
            else if(area.Equals("FINANZAS"))
            {
                DG_tabla.Columns["CONCEPTO"].ReadOnly = true;
                DG_tabla.Columns["DESCRIPCION"].ReadOnly = true;
                DG_tabla.Columns["IMPORTE"].ReadOnly = true;
                DG_tabla.Columns["DETALLE"].ReadOnly = true;
                DG_tabla.Columns["RutaFoto"].ReadOnly = true;
                DG_tabla.Columns["FECHA"].ReadOnly = true;
                DG_tabla.Columns["COMREVISION2"].ReadOnly = true;
                DG_tabla.Columns["NUM_AUTORIZACION"].ReadOnly = true;
            }
            else
            {

                DG_tabla.Columns["ID"].ReadOnly = true;
                DG_tabla.Columns["CONCEPTO"].ReadOnly = true;
                DG_tabla.Columns["DESCRIPCION"].ReadOnly = true;
                DG_tabla.Columns["IMPORTE"].ReadOnly = true;
                DG_tabla.Columns["DETALLE"].ReadOnly = true;
                DG_tabla.Columns["RutaFoto"].ReadOnly = true;
                DG_tabla.Columns["FECHA"].ReadOnly = true;
                DG_tabla.Columns["COMENTARIO"].ReadOnly = false;
         
                DG_tabla.Columns["NUM_AUTORIZACION"].ReadOnly = true;
                
            }


            
        }

        public void BuscarGastos()
        {
            TB_revisados.Text = "";
            TB_sinrevisar.Text = "";
            TB_porcorregir.Text = "";
            TB_corregidos.Text = "";
            TB_autorizados.Text = "";
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            string sucursal = CB_sucursal.SelectedItem.ToString();
            RevisionGastosController rg =new RevisionGastosController();
            List<Gasto> lista = rg.BuscarXFechas(inicio,fin,sucursal);
          
            DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
            bool evidencia = false;
#pragma warning disable CS0219 // La variable 'checkRevision' está asignada pero su valor nunca se usa
            int checkRevision = 0;
#pragma warning restore CS0219 // La variable 'checkRevision' está asignada pero su valor nunca se usa
            string revision = "";
#pragma warning disable CS0219 // La variable 'ticket' está asignada pero su valor nunca se usa
            string ticket = "",estado="",numAutorizacion="";
#pragma warning restore CS0219 // La variable 'ticket' está asignada pero su valor nunca se usa
            int revisados = 0, sinRevisar = 0, corregir = 0, corregidos = 0, aprobados = 0,rechazados=0;
            string tipo_egreso = "";
            foreach (var item in lista)
            {
                //checkRevision = item.Revision1;

                //if (checkRevision == 1)
                //{
                //    check.ThreeState = true;
                //}
                //else
                //{
                //    check.ThreeState = false;+		$exception	{"Referencia a objeto no establecida como instancia de un objeto."}	System.NullReferenceException

                //}
                if (!item.RutaFoto.Equals("") || !item.RutaFoto2.Equals("") || !item.RutaFoto3.Equals(""))
                {
                    evidencia = true;
                }


                if (item.Revision.Equals(""))
                {
                    revision = "SIN REVISAR";

                }
                else
                {
                    revision = item.Revision;
                }

                estado = item.Revision;
                numAutorizacion = item.NumAutorizacion;
                if (estado.Equals("REVISADO"))
                {
                    revisados++;
                }

                if (estado.Equals("SIN REVISAR"))
                {
                    sinRevisar++;
                }

                if (estado.Equals("CORREGIR"))
                {
                    corregir++;
                }

                if (estado.Equals("CORREGIDO"))
                {
                    corregidos++;
                }

                if (numAutorizacion.Equals("0"))
                {

                }
                else if(numAutorizacion.Equals("RECHAZADO"))
                {
                    rechazados++;
                }else if(numAutorizacion.Equals(""))
                {

                }
                else
                {
                    aprobados++;
                }

                if (item.Descripcion.Equals("GASTO LA PERLA"))
                {
                    tipo_egreso = "GASTOS LA PERLA";
                }else
                {
                    tipo_egreso = item.Tipo_egreso;
                }
                DG_tabla.Rows.Add(tipo_egreso, item.Id, item.Concepto, item.Descripcion, item.Importe, item.Detalle,item.UsuarioAplico, item.Fecha.ToString("yyyy-MM-dd"), item.ComentarioRevision,item.ComentarioRevision2,item.ComentarioSRA ,item.NumAutorizacion, item.RutaFoto, item.RutaFoto2, item.RutaFoto3, evidencia, item.Encajas,revision);
                TB_revisados.Text = revisados.ToString();
                TB_sinrevisar.Text = sinRevisar.ToString();
                TB_porcorregir.Text = corregir.ToString();
                TB_corregidos.Text = corregidos.ToString();
                TB_autorizados.Text = aprobados.ToString();
                TB_rechazados.Text = rechazados.ToString();
                DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
                PintarFila();




            }
        }

        public void GuardarCambios()
        {
            RevisionGastosController rg = new RevisionGastosController();
            int id;
            string comentario = "",comentario2="";
#pragma warning disable CS0168 // La variable 'numAutorizacion' se ha declarado pero nunca se usa
            string numAutorizacion;
#pragma warning restore CS0168 // La variable 'numAutorizacion' se ha declarado pero nunca se usa
#pragma warning disable CS0219 // La variable 'estado' está asignada pero su valor nunca se usa
            bool estado = false;
#pragma warning restore CS0219 // La variable 'estado' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'valor' está asignada pero su valor nunca se usa
            int valor = 0;
#pragma warning restore CS0219 // La variable 'valor' está asignada pero su valor nunca se usa
            string revision = "";

            string sucursal = CB_sucursal.SelectedItem.ToString();
            
                try
                {
                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {

                        id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value);


                    if (string.IsNullOrEmpty(DG_tabla.Rows[i].Cells["REVISION"].Value.ToString()))
                    {

                    }
                    else
                    {
                        revision = DG_tabla.Rows[i].Cells["REVISION"].Value.ToString();
                    }



                    if (DG_tabla.Rows[i].Cells["COMENTARIO"].Value==null)
                    {
                        comentario = "";
                    }
                    else
                    {
                        comentario  = DG_tabla.Rows[i].Cells["COMENTARIO"].Value.ToString();
                    }


                    if (DG_tabla.Rows[i].Cells["COMREVISION2"].Value == null)
                    {
                        comentario2 = "";
                    }
                    else
                    {
                        comentario2 = DG_tabla.Rows[i].Cells["COMREVISION2"].Value.ToString();
                    }








                    rg.ActualizarGastoRevision(id, sucursal, comentario.ToUpper(),comentario2.ToUpper(),revision);
                    }

                    MessageBox.Show("Se han guardado los cambios");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al guardar los cambios " + ex);
                }
            
            
            
            
        }


        public void PintarFila()
        {

            string estado = "",aprobacion="";


            if (DG_tabla.Rows.Count>0)
            {
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    estado = DG_tabla.Rows[i].Cells["REVISION"].Value.ToString();
                    aprobacion = DG_tabla.Rows[i].Cells["NUM_AUTORIZACION"].Value.ToString();
                    if (estado.Equals("REVISADO"))
                    {
                        DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                        DG_tabla.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (estado.Equals("CORREGIR")||aprobacion.Equals("RECHAZADO"))
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




        public void GastosPendientes()
        {
            TB_pendientes.Text = "";
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DG_tabla2.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            //MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            RevisionGastosController rg = new RevisionGastosController();
            List<Gasto> lista = rg.BuscarNumTicket(sucursal, inicio, fin);
            bool respaldo = false;

            if (CBX_respaldo.Checked==true)
            {
                respaldo = true;
            }

            List<Gasto> gastosTienda = rg.BuscarGastos(sucursal, inicio, fin,respaldo);
#pragma warning disable CS0219 // La variable 'ticket' está asignada pero su valor nunca se usa
            string ticket = "";
#pragma warning restore CS0219 // La variable 'ticket' está asignada pero su valor nunca se usa


            foreach (var item2 in gastosTienda)
            {


                DG_tabla2.Rows.Add(item2.Concepto, item2.Descripcion, item2.Importe, item2.Ticket, item2.Fecha.ToString("yyyy-MM-dd"));

            }

            int count = 0;
            foreach (var item in lista)
            {

                for (int i = 0; i < DG_tabla2.Rows.Count; i++)
                {
                    if (item.Ticket.Equals(DG_tabla2.Rows[i].Cells["TICKET"].Value.ToString()))
                    {
                        DG_tabla2.Rows[i].Visible = false;
                    }

                    
                }

               

            }


            for (int i = 0; i < DG_tabla2.Rows.Count; i++)
            {
                if (DG_tabla2.Rows[i].Visible==true)
                {
                    count++;
                }
            }
            TB_pendientes.Text = count.ToString();
            DG_tabla2.Columns["IMPORTE_GASTO"].DefaultCellStyle.Format = "C2";
            count = 0;
        }

        public void OtrosEgresos()
        {
            RevisionGastosController gc = new RevisionGastosController();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            List<Gasto> lista = gc.CuentasRetiroEfectivo(CB_sucursal.SelectedItem.ToString(),inicio,fin);

            foreach (var item in lista)
            {
                DG_otrosEgresos.Rows.Add(item.Descripcion,item.Importe,item.Ticket,item.Fecha);
            }
        }

        public void Sobrantes()
        {
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            DG_sobrantes.Rows.Clear();
            System.Data.DataTable sobrantes = VentaController.Sobrantes(sucursal,inicio,fin,CBX_respaldo.Checked);

            for (int i = 0; i < sobrantes.Rows.Count; i++)
            {
                DG_sobrantes.Rows.Add(sobrantes.Rows[i]["CONCEPTO"].ToString(), sobrantes.Rows[i]["DESCRIPCION"].ToString(), Convert.ToDouble(sobrantes.Rows[i]["IMPORTE"].ToString()),Convert.ToDateTime(sobrantes.Rows[i]["FECHA"].ToString()).ToString("dd-MM-yyyy"), sobrantes.Rows[i]["CAJA"].ToString(), sobrantes.Rows[i]["CAJERA"].ToString(), sobrantes.Rows[i]["TICKET"].ToString());
            }
            DG_sobrantes.Columns["IMPORTE_SOB"].DefaultCellStyle.Format = "C2";
        }

        public void BuscarGastosAlmacenCedis()
        {

            DG_tabla.Rows.Clear();
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            List<GastoAlmacenCedis> lista = GastosAlmacenCedisController.BuscarGastos(inicio,fin);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add("GENERAL", item.Id, item.ConceptoGral, item.ConceptoDetalle, item.Importe, item.DescripcionDetallada, item.Usuario, item.Fecha.ToString("yyyy-MM-dd"), item.ComRevision,"", item.ComSra, item.FolioAprobacion, item.Imagen1, "", item.Imagen2, true, item.Usuario, item.EstadoRevision);
            }
            PintarFila();
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
        }

        private void BT_gastos_Click(object sender, EventArgs e)
        {
            if (CB_sucursal.SelectedIndex==-1)
            {
                MessageBox.Show("Selecciona una sucursal");
            }else
            {


                if (CB_sucursal.SelectedItem.ToString().Equals("CEDIS"))
                {
                    BuscarGastosAlmacenCedis();
                }
                else
                {
                    BuscarGastos();
                    GastosPendientes();
                    OtrosEgresos();
                    Sobrantes();
                }
               
            }
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            if (CB_sucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una sucursal");
            }
            else
            {
                GuardarCambios();
            }
            
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string detalle = DG_tabla.Rows[e.RowIndex].Cells["DETALLE"].Value.ToString();
            string ruta = DG_tabla.Rows[e.RowIndex].Cells["RutaFoto"].Value.ToString();
            string ruta2 = DG_tabla.Rows[e.RowIndex].Cells["FOTO2"].Value.ToString();
            string ruta3 = DG_tabla.Rows[e.RowIndex].Cells["FOTO3"].Value.ToString();
           string comRevision2 = DG_tabla.Rows[e.RowIndex].Cells["COMREVISION2"].Value.ToString();
            string comentarioRev = DG_tabla.Rows[e.RowIndex].Cells["COMENTARIO"].Value.ToString();
            FotoRevision revision = new FotoRevision(ruta, detalle,ruta2,ruta3, comentarioRev,comRevision2,0,0);
            revision.Show();
        }


       

        private void DG_tabla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DG_tabla_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           
           
        }

        private void DG_tabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            PintarFila();

        }

        private void DG_tabla_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DG_tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DG_tabla_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DG_tabla_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void DG_tabla_Click(object sender, EventArgs e)
        {

        }

        private void BT_aprobar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = DG_tabla.SelectedRows;
            DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
            System.Collections.ArrayList lista = new System.Collections.ArrayList();

            foreach (DataGridViewRow row in selectedRows)
            {

                DG_tabla.Rows[row.Index].Cells["REV_SRA"].Value = true;
            }

           
        }

     

        private void BT_exportar_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;


            foreach (DataGridViewColumn col in DG_tabla2.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;



            foreach (DataGridViewRow row in DG_tabla2.Rows)

                if (row.Visible == true)
                {
                    indiceFila++;
                    indiceColumna = 0;

                    foreach (DataGridViewColumn col in DG_tabla2.Columns)
                    {
                        indiceColumna++;


                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;




                    }

                }

            excel.Cells.Range["A5"].Value = "CONCEPTO";
            excel.Cells.Range["B5"].Value = "DESCRIPCION";
            excel.Cells.Range["C5"].Value = "IMPORTE";

            excel.Cells.Range["D5"].Value = "TICKET";

            excel.Cells.Range["E5"].Value = "FECHA";
            excel.Cells.Range["A4:A4"].Value = "Reporte de gastos pendientes por envíar";
            excel.Cells.Range["A5:E5"].Interior.ColorIndex = 25;
            excel.Cells.Range["A5:E5"].Font.ColorIndex = 2;
            excel.Range["C6:C100"].NumberFormat = "$#,##0.00";
            int indice = indiceFila + 1;
            int indiceHorizontal = indiceFila + 2;
            excel.Cells.Range["A5:E" + indice].Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A5:A" + indice].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["D5:E" + indice].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A4:E" + indiceHorizontal].Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            excel.Visible = true;
        }

        private void DG_tabla_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
    }
}
