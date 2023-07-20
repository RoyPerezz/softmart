using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
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
    public partial class AprobacionGastos : Form
    {

        string sucursal = "";
        DateTime fecha = DateTime.Now;
        bool respaldo = false;
        public AprobacionGastos(string sucursal, DateTime fecha, bool respaldo)
        {

            this.sucursal = sucursal;
            this.fecha = fecha;
            this.respaldo = respaldo;
            InitializeComponent();

            LB_sucursal.Text = sucursal + " " + fecha.ToString("yyyy-MM-dd");
        }



        public void GastosGuardados()
        {
            double total = 0;
            DG_tabla.Rows.Clear();
            MySqlConnection con = null;
            int m = fecha.Month;
            int año = fecha.Year;
            string mes = FormatoFecha.Mes(m);
            //if (respaldo == true)
            //{
            //    con = BDConexicon.RespMultiSuc(sucursal,mes,año);
            //}
            //else
            //{
            //    con = BDConexicon.ConexionSucursal(sucursal);
            //}
            con = BDConexicon.ConexionSucursal(sucursal);
            string query = "SELECT * FROM rd_auditoria_gastos WHERE fecha='"+fecha.ToString("yyyy-MM-dd")+"'";

            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<Gasto> lista = new List<Gasto>();
            while (dr.Read())
            {






                Gasto gasto = new Gasto()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    Estado = dr["Estado"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Descripcion = dr["descripcion"].ToString(),
                    Revision = dr["revision"].ToString(),
                    Concepto = dr["concepto"].ToString(),
                    Detalle = dr["comentario"].ToString(),
                    Revision2 = Convert.ToInt32(dr["Revision2"].ToString()),
                    ComentarioRevision = dr["comentarioRevision"].ToString(),
                    ComentarioRevision2 = dr["comentarioRevision2"].ToString(),
                    UsuarioAplico = dr["usuario"].ToString(),
                    Ticket = dr["ticket"].ToString(),
                    Encajas = dr["enc_cajas"].ToString(),
                    NumAutorizacion = dr["numAutorizacion"].ToString(),
                    RutaFoto = dr["rutaFoto"].ToString(),
                    RutaFoto2 = dr["rutaFoto2"].ToString(),
                    RutaFoto3 = dr["rutaFoto3"].ToString(),
                    ComentarioSRA = dr["comentarioSRA"].ToString()
                    

                   

                };

                lista.Add(gasto);
                
            }
            string revision = "";
            int fila = 0;
            foreach (var item in lista)
            {
               

                if (item.Estado.Equals(""))
                {
                    item.Estado = "EN REVISION";
                }

                DG_tabla.Rows.Add(item.Id, item.Estado, item.Importe, item.Descripcion, item.Revision, item.Concepto, item.Detalle, item.ComentarioRevision,item.ComentarioRevision2,item.ComentarioSRA ,item.UsuarioAplico, item.Ticket,item.Encajas, item.NumAutorizacion,item.RutaFoto,item.RutaFoto2,item.RutaFoto3);
                total += item.Importe;
                revision = item.Revision;
                PintalCeldaRevision(fila, revision);
                fila++;
                PintarFila();


            }
            LB_total.Text = total.ToString("N2");
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
        }

        public void GastosGuardadosCedis()
        {
            double total = 0;
            DG_tabla.Rows.Clear();
            string revision = "";
            int fila = 0;
            List<GastoAlmacenCedis> lista = GastosAlmacenCedisController.BuscarGastos(fecha,fecha);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Id, item.EstadoAprobacion, item.Importe, item.ConceptoGral, item.EstadoRevision, item.ConceptoDetalle, item.DescripcionDetallada, item.ComRevision, "", item.ComSra, item.Usuario, item.FolioSalida, item.Usuario, item.FolioAprobacion, item.Imagen1, "", item.Imagen2);
                revision = item.EstadoRevision;
                total += item.Importe;
                PintalCeldaRevision(fila, revision);
                fila++;
                PintarFila();

            }


            LB_total.Text = total.ToString("C2");
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
        }

        public void GastosGuardadosFinanzas()
        {
            double total = 0;
            DG_tabla.Rows.Clear();
            string revision = "";
            int fila = 0;

            List<GastoExterno> lista = GastoFinanzasController.ListaGastos(fecha, fecha);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Id,item.EstadoAprobacion,item.Importe,item.Concepto_gral,"",item.ConceptoDetalle,item.Descripcion,"","",item.ComentarioAprobacion,"usuario",item.Folio,"usuario",item.NumAutorizacion,item.Foto1,"",item.Foto2);
                revision = item.EstadoAprobacion;
                total += item.Importe;
                PintalCeldaRevision(fila, revision);
                fila++;
                PintarFila();
            }

            LB_total.Text = total.ToString("C2");
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
        }

        public void BuscarGastosFinanzas()
        {

            DateTime inicio = fecha;
            DateTime fin = fecha;
            List<GastoExterno> lista = GastoFinanzasController.ListaGastos(inicio, fin);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Id, item.EstadoAprobacion, item.Importe, item.Concepto_gral, "", item.ConceptoDetalle,item.Descripcion, "", "", item.ComentarioAprobacion, "usuario", item.Folio,"usuario", item.NumAutorizacion,item.Foto1,"",item.Foto2);
            }
        }
       public void PintalCeldaRevision(int fila,string revision)
        {
            if (revision.Equals("REVISADO"))
            {
                DG_tabla.Rows[fila].Cells["REVISION1"].Style.BackColor = Color.CadetBlue;
                DG_tabla.Rows[fila].Cells["REVISION1"].Style.ForeColor = Color.White;

            }

            
        }
        private void AprobacionGastos_Load(object sender, EventArgs e)
        {




            //GastosGuardados();

            if (sucursal.Equals("CEDIS"))
            {
                GastosGuardadosCedis();
            }else if(sucursal.Equals("FINANZAS"))
            {
                GastosGuardadosFinanzas();
            }
            else
            {
                Gastos();
                
            }
            
        }


       

        public void Gastos()
        {
            List<Gasto> lista = null;

            DG_tabla.Rows.Clear();

            if (sucursal.Equals("CEDIS"))
            {
                List<GastoAlmacenCedis> gastosCedis = GastosAlmacenCedisController.BuscarGastos(fecha, fecha);

                foreach (var item in gastosCedis)
                {
                    DG_tabla.Rows.Add(item.Id,item.EstadoAprobacion,item.Importe,item.ConceptoDetalle,item.EstadoRevision,item.ConceptoGral,item.DescripcionDetallada,item.ComRevision,"","",item.Usuario,item.FolioSalida,item.Usuario,item.FolioAprobacion,item.Imagen1,"",item.Imagen2);
                }
            }
            else
            {
                int fila = 0;
                double total = 0;

                GastosController gc = new GastosController();

                lista = gc.BuscarGastos(sucursal, fecha, respaldo);

                foreach (var item in lista)
                {

                    DG_tabla.Rows.Add(item.Id, "EN REVISION", item.Importe, item.Descripcion, item.Revision, item.Concepto, "", "", "", "", item.UsuarioAplico, item.Ticket, item.Encajas, "0", "", "", "");
                    total += item.Importe;
                }

                DataTable dt = gc.DatosGasto(sucursal, fecha);
                string estado = "";
                try
                {
                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {

                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            if (DG_tabla.Rows[i].Cells["TICKET"].Value.ToString().Equals(dt.Rows[j]["ticket"].ToString()))
                            {


                                estado = dt.Rows[j]["Estado"].ToString();
                                DG_tabla.Rows[i].Cells["ID"].Value = dt.Rows[j]["id"].ToString();

                                if (estado.Equals(""))
                                {
                                    DG_tabla.Rows[i].Cells["ESTADO"].Value = "EN REVISION";
                                }
                                else
                                {
                                    DG_tabla.Rows[i].Cells["ESTADO"].Value = dt.Rows[j]["Estado"].ToString();
                                }

                                DG_tabla.Rows[i].Cells["COMENTARIO"].Value = dt.Rows[j]["comentarioRevision"].ToString();

                                DG_tabla.Rows[i].Cells["COMREV2"].Value = dt.Rows[j]["comentarioRevision2"].ToString();
                                DG_tabla.Rows[i].Cells["COM_SRA"].Value = dt.Rows[j]["comentarioSRA"].ToString();
                                DG_tabla.Rows[i].Cells["USUARIO"].Value = dt.Rows[j]["usuario"].ToString();

                                DG_tabla.Rows[i].Cells["DETALLE"].Value = dt.Rows[j]["comentario"].ToString();
                                DG_tabla.Rows[i].Cells["REVISION1"].Value = dt.Rows[j]["revision"].ToString();
                                DG_tabla.Rows[i].Cells["FOTO1"].Value = dt.Rows[j]["rutaFoto"].ToString();
                                DG_tabla.Rows[i].Cells["FOTO2"].Value = dt.Rows[j]["rutaFoto2"].ToString();
                                DG_tabla.Rows[i].Cells["FOTO3"].Value = dt.Rows[j]["rutaFoto3"].ToString();
                                DG_tabla.Rows[i].Cells["NUM_AUTO"].Value = dt.Rows[j]["numAutorizacion"].ToString();
                                DG_tabla.Rows[i].Cells["ENCAJAS"].Value = dt.Rows[j]["enc_cajas"].ToString();

                                PintalCeldaRevision(fila, dt.Rows[j]["Estado"].ToString());
                                fila++;
                                PintarFila();
                                break;
                            }
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
                LB_total.Text = total.ToString("C2");
                // OcultarGastosRevisados();
                DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";

                lista.Clear();
            }

    

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

        private void DG_tabla_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string estado = DG_tabla.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString();

            if (estado.Equals("APROBADO"))
            {

                DG_tabla.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.CadetBlue;
                DG_tabla.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;

            }
            else if (estado.Equals("RECHAZADO"))
            {
                DG_tabla.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
                DG_tabla.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }else if(estado.Equals("CORREGIDO"))
            {
                DG_tabla.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
                DG_tabla.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }


        }

       
        public void GuardarCambios()
        {
            
            RevisionGastosController rg = new RevisionGastosController();
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
                }
                else
                {

                    numAprobacion = DG_tabla.Rows[i].Cells["NUM_AUTO"].Value.ToString();
                    int num = 0;
                    if (numAprobacion.Equals("0"))
                    {


                        if (sucursal.Equals("CEDIS"))
                        {
                            //si la sra decide que sea aleatorio, que se ejecute solo el codigo dentro del else

                            num = RevisionGastosController.NumAutorizacionCedis();
                            numAprobacion = "GG" + num.ToString();
                            RevisionGastosController.ActualizarNumAutorizacionCedis(num);

                        }else if(sucursal.Equals("FINANZAS"))
                        {
                            num = Convert.ToInt32(RevisionGastosController.NumAutorizacionFinanzas());
                            numAprobacion = "F"+"-"+num.ToString();
                            
                        }
                        else{
                            numAprobacion = RevisionGastosController.GenerarNumAprobacion(sucursal);
                        }
                       
                    }
                      
                   

                   

                }


                if (sucursal.Equals("CEDIS"))
                {
                  
                        comentarioSRA = DG_tabla.Rows[i].Cells["COM_SRA"].Value.ToString();
                        GastosAlmacenCedisController.ActualizarEstadoAprobacion(estado,numAprobacion,comentarioSRA,id);

                   

                }else if(sucursal.Equals("FINANZAS"))
                {
                    comentarioSRA = DG_tabla.Rows[i].Cells["COM_SRA"].Value.ToString();
                    GastosAlmacenCedisController.ActualizarEstadoAprobacionFinanzas(estado, numAprobacion, comentarioSRA, id);
                }
                else
                {
                    if (estado.Equals("RECHAZADO"))
                    {
                        comentarioSRA = DG_tabla.Rows[i].Cells["COM_SRA"].Value.ToString();
                        rg.ActualizarAutorizacionGasto(id, sucursal, "RECHAZADO", estado, comentarioSRA);
                    }
                    else

                    {

                        comentarioSRA = DG_tabla.Rows[i].Cells["COM_SRA"].Value.ToString();
                        rg.ActualizarAutorizacionGasto(id, sucursal, numAprobacion, estado, comentarioSRA);
                    }
                   
                }


               


            }

            if (sucursal.Equals("CEDIS"))
            {
                GastosGuardadosCedis();
            }else if(sucursal.Equals("FINANZAS"))
            {
                GastosGuardadosFinanzas();
            }
            else{
                Gastos();
            }
           
            MessageBox.Show("Se han guardado los cambios");
           
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void BT_aprobar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = DG_tabla.SelectedRows;


            if (filas.Count>0)
            {
                foreach (DataGridViewRow item in filas)
                {
                    DG_tabla.Rows[item.Index].Cells["ESTADO"].Value = "APROBADO";
                }
            }else
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
                foto3 = DG_tabla.Rows[e.RowIndex].Cells["FOTO3"].Value.ToString();
                comentario = DG_tabla.Rows[e.RowIndex].Cells["DETALLE"].Value.ToString();
                comrevision2 = DG_tabla.Rows[e.RowIndex].Cells["COMREV2"].Value.ToString();
                comentarioRev = DG_tabla.Rows[e.RowIndex].Cells["COMENTARIO"].Value.ToString();
                FotoRevision revision = new FotoRevision(foto1, comentario, foto2, foto3, comentarioRev, comrevision2);
                revision.Show();
            }

            catch (Exception ex)

            {

                MessageBox.Show("No hay datos de estos gastos");
            }

           
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
