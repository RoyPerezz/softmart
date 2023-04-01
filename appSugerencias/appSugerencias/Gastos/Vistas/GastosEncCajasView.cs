using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
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
    public partial class GastosEncCajasView : Form, IDatos
    {
        string encajas = "";
#pragma warning disable CS0414 // El campo 'GastosEncCajasView.inicial' está asignado pero su valor nunca se usa
        string inicial = "";
#pragma warning restore CS0414 // El campo 'GastosEncCajasView.inicial' está asignado pero su valor nunca se usa

        public GastosEncCajasView(string usuario)
        {
            this.encajas = usuario;
            InitializeComponent();
        }


        public string ObtenerSucursal()
        {
            string sucursal = BDConexicon.sucursal();
            return sucursal;
        }

        public void PintarFila()
        {

            string estado = "", aprobacion = "";


            if (DG_tabla.Rows.Count > 0)
            {
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    estado = DG_tabla.Rows[i].Cells["ESTADOREVISION"].Value.ToString();
                    aprobacion = DG_tabla.Rows[i].Cells["NUMAUTORIZACION"].Value.ToString();
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
        private void GastosEncCajasView_Load(object sender, EventArgs e)
        {




            DG_tabla.Columns["CONCEPTO"].ReadOnly = true;
            DG_tabla.Columns["DESCRIPCION"].ReadOnly = true;
            DG_tabla.Columns["IMPORTE"].ReadOnly = true;
            DG_tabla.Columns["COMENTARIO"].ReadOnly = true;
            DG_tabla.Columns["FOTO"].ReadOnly = true;

            string sucursal = ObtenerSucursal();
            if (sucursal.Equals("OSMART VALLARTA"))
            {
                
                CB_sucursal.SelectedIndex = 0;
            }
            else if(sucursal.Equals("OSMART RENACIMIENTO"))
            {
               
                CB_sucursal.SelectedIndex = 1;
            }
            else if (sucursal.Equals("OSMART VELAZQUEZ"))
            {
               
                CB_sucursal.SelectedIndex = 2;
            }
            else if (sucursal.Equals("OSMART COLOSO"))
            {
               
                CB_sucursal.SelectedIndex = 3;
            }
            else if (sucursal.Equals("BODEGA"))
            {
                
                CB_sucursal.SelectedIndex = 0;
            }
            else
            {
               
            }
        }


        public void OcultarGastosRevisados()
        {
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime fecha = DT_fecha.Value;
            RevisionGastosController rg = new RevisionGastosController();
            List<Gasto> revisados = rg.GastosRevisados(sucursal, fecha);
            string ticketTabla = "";
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                ticketTabla = DG_tabla.Rows[i].Cells["TICKET"].Value.ToString();

                for (int j = 0; j < revisados.Count; j++)
                {
                    if (ticketTabla.Equals(revisados[j].Ticket))
                    {
                        DG_tabla.Rows[i].Visible = false;
                    }
                }
            }
        }
       
        public void Gastos()
        {
            List<Gasto> lista = null;
          
            DG_tabla.Rows.Clear();
            bool  respaldo = false;
            if (CBX_respaldo.Checked == true)
            {
                respaldo = true;
            }

            string sucursal = CB_sucursal.SelectedItem.ToString();
#pragma warning disable CS0219 // La variable 'total' está asignada pero su valor nunca se usa
            double total = 0;
#pragma warning restore CS0219 // La variable 'total' está asignada pero su valor nunca se usa
            DateTime fecha = DT_fecha.Value;
            GastosController gc = new GastosController();
           
            lista = gc.BuscarGastos(sucursal, fecha,respaldo);
            
            foreach (var item in lista)
            {
               
                DG_tabla.Rows.Add(item.Concepto, item.Descripcion, item.Importe, "",item.Ticket,"",0,"","","","","",false,item.UsuarioAplico,item.Clave,item.Caja,"","","0",item.Fecha.ToString("yyy-MM-dd"));
            }

            DataTable dt = gc.DatosGasto(sucursal,fecha);

            try
            {
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (DG_tabla.Rows[i].Cells["TICKET"].Value.ToString().Equals(dt.Rows[j]["ticket"].ToString()))
                        {


                            if (!dt.Rows[j]["rutaFoto"].ToString().Equals("")|| !dt.Rows[j]["rutaFoto2"].ToString().Equals("")||!dt.Rows[j]["rutaFoto3"].ToString().Equals(""))
                            {
                                DG_tabla.Rows[i].Cells["EVIDENCIA"].Value = true;
                            }

                            DG_tabla.Rows[i].Cells["COMENTARIO"].Value = dt.Rows[j]["comentario"].ToString();
                           
                            DG_tabla.Rows[i].Cells["FOTO"].Value = dt.Rows[j]["rutaFoto"].ToString();
                            DG_tabla.Rows[i].Cells["ID"].Value = dt.Rows[j]["id"].ToString();
                            DG_tabla.Rows[i].Cells["NOMBRE_FOTO"].Value = dt.Rows[j]["nombreFoto"].ToString();
                            DG_tabla.Rows[i].Cells["FOTO2"].Value = dt.Rows[j]["rutaFoto2"].ToString();
                            DG_tabla.Rows[i].Cells["NOMBRE_FOTO2"].Value = dt.Rows[j]["nombreFoto2"].ToString();
                            DG_tabla.Rows[i].Cells["FOTO3"].Value = dt.Rows[j]["rutaFoto3"].ToString();
                            DG_tabla.Rows[i].Cells["NOMBRE_FOTO3"].Value = dt.Rows[j]["nombreFoto3"].ToString();
                            DG_tabla.Rows[i].Cells["ESTADOREVISION"].Value = dt.Rows[j]["revision"].ToString();
                            DG_tabla.Rows[i].Cells["ESTADOAPROBACION"].Value = dt.Rows[j]["Estado"].ToString();
                            DG_tabla.Rows[i].Cells["NUMAUTORIZACION"].Value = dt.Rows[j]["numAutorizacion"].ToString();
                            break;
                        }
                    }

                   
                }

                PintarFila();
            }
            catch (Exception)
            {

            }

           // OcultarGastosRevisados();
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
          
            lista.Clear();
        }



       

        public void GastosXCorregir()
        {

#pragma warning disable CS0219 // La variable 'respaldo' está asignada pero su valor nunca se usa
            bool respaldo = false;
#pragma warning restore CS0219 // La variable 'respaldo' está asignada pero su valor nunca se usa
            if (CBX_respaldo.Checked==true)
            {
                respaldo = true;
            }


            DG_tabla3.Rows.Clear();
            LB_corregir.Text = "";
            int count = 0;
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime fecha = DT_fecha.Value;
            RevisionGastosController rg = new  RevisionGastosController();
            List<Gasto> lista = rg.GastosPorCorregir(sucursal,fecha);
            string n1 = "", n2 = "", n3 = "";
            foreach (var item in lista)
            {

                if (!string.IsNullOrEmpty(item.NombreFoto))
                {
                    n1 = item.NombreFoto;
                }
                if(!string.IsNullOrEmpty(item.NombreFoto2))
                {
                    n2 = item.NombreFoto2;
                }
                
                if(!string.IsNullOrEmpty(item.NombreFoto3))
                {
                    n3 = item.NombreFoto3;
                }

                DG_tabla3.Rows.Add(item.Id,item.Concepto,item.Descripcion,item.Importe,item.Detalle,item.ComentarioRevision,item.ComentarioRevision2,item.RutaFoto,n1,item.RutaFoto2,n2,item.RutaFoto3,n3, item.Ticket);
                n1 = "";n2 = "";n3 = "";
                count++;
            }
            LB_corregir.Text = "Tienes "+count+" gastos por corregir.";
            LB_corregir.ForeColor = Color.Red;
            DG_tabla3.Columns["IMPORTEGASTO"].DefaultCellStyle.Format = "C2";

          


        }

        public void GastosAprobados()
        {
           
            DG_tabla2.Rows.Clear();
            int count = 0;
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime fecha = DT_fecha.Value;
            RevisionGastosController rg = new RevisionGastosController();
            List<Gasto> lista = rg.GastosAprobados(sucursal, fecha);

            foreach (var item in lista)
            {
                DG_tabla2.Rows.Add(item.Id,item.Concepto,item.Descripcion,item.Importe,item.Detalle,item.RutaFoto,item.RutaFoto2,item.RutaFoto3,item.Ticket,item.NumAutorizacion);
                count++;
            }

            LB_aprobados.Text = "Tienes "+count+" gastos aprobados.";
            LB_aprobados.ForeColor = Color.Green;
            DG_tabla2.Columns["IMPORTE_"].DefaultCellStyle.Format = "C2";
            
        }
        private void BT_gastos_Click(object sender, EventArgs e)
        {
            Gastos();//Gastos obtenidos de la mybusiness
           // GastosAutorizados();//gastos
            GastosAprobados();//gastos con num de autorizacion
            GastosXCorregir();//gastos capturados con errroes
        }

        private void TB_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DT_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            int fila = e.RowIndex;
            string concepto = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTO"].Value.ToString();
            string descripcion = DG_tabla.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString();
            double importe = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["IMPORTE"].Value.ToString());
            string comentario = DG_tabla.Rows[e.RowIndex].Cells["COMENTARIO"].Value.ToString();
            string foto = DG_tabla.Rows[e.RowIndex].Cells["FOTO"].Value.ToString();
            string nombreFoto = DG_tabla.Rows[e.RowIndex].Cells["NOMBRE_FOTO"].Value.ToString();
            string rutaFoto2 = DG_tabla.Rows[e.RowIndex].Cells["FOTO2"].Value.ToString();
            string nombreFoto2 = DG_tabla.Rows[e.RowIndex].Cells["NOMBRE_FOTO2"].Value.ToString();
            string rutaFoto3 = DG_tabla.Rows[e.RowIndex].Cells["FOTO3"].Value.ToString();
            string nombreFoto3 = DG_tabla.Rows[e.RowIndex].Cells["NOMBRE_FOTO3"].Value.ToString();
            string ticket = DG_tabla.Rows[e.RowIndex].Cells["TICKET"].Value.ToString();
            string usuario = DG_tabla.Rows[e.RowIndex].Cells["USER"].Value.ToString();
           string clave = DG_tabla.Rows[e.RowIndex].Cells["CLAVE"].Value.ToString();
            

            try
            {
                id = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                id = 0;
            }

            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime fecha = Convert.ToDateTime(DG_tabla.Rows[e.RowIndex].Cells["FECHA"].Value.ToString());
            
            //Evita que la vista de agregar foto se abra mas de una vez
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AgregarFotoEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
           
            frm = new AgregarFotoEncCajas(this, concepto, descripcion, importe, fila, comentario, foto, sucursal, fecha, id, nombreFoto, usuario, rutaFoto2, nombreFoto2, rutaFoto3, nombreFoto3, ticket, encajas, clave);
            
            frm.Show();
        }

        public void DatosGastoEncCajas(string comentario, string rutaFoto,int fila,string nombreFoto,int id, string rutaFoto2, string nombreFoto2, string rutaFoto3, string nombreFoto3)
        {
           
            DG_tabla.Rows[fila].Cells["COMENTARIO"].Value = comentario;
            DG_tabla.Rows[fila].Cells["FOTO"].Value = rutaFoto;
            DG_tabla.Rows[fila].Cells["NOMBRE_FOTO"].Value = nombreFoto;
            DG_tabla.Rows[fila].Cells["FOTO2"].Value = rutaFoto2;
            DG_tabla.Rows[fila].Cells["NOMBRE_FOTO2"].Value = nombreFoto2;
            DG_tabla.Rows[fila].Cells["FOTO3"].Value = rutaFoto3;
            DG_tabla.Rows[fila].Cells["NOMBRE_FOTO3"].Value = nombreFoto3;
            DG_tabla.Rows[fila].Cells["ID"].Value = id;
           


        }

        private void DG_tabla3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int id = Convert.ToInt32(DG_tabla3.Rows[e.RowIndex].Cells["IDGASTOCORREGIR"].Value.ToString());
            int fila = e.RowIndex;
            string concepto = DG_tabla3.Rows[e.RowIndex].Cells["CONCEPTO_"].Value.ToString();
            string descripcion = DG_tabla3.Rows[e.RowIndex].Cells["DESCRIPGASTO"].Value.ToString();
            double importe = Convert.ToDouble(DG_tabla3.Rows[e.RowIndex].Cells["IMPORTEGASTO"].Value.ToString());
            string detalle = DG_tabla3.Rows[e.RowIndex].Cells["DETALLE"].Value.ToString();
            string foto = DG_tabla3.Rows[e.RowIndex].Cells["IMG1"].Value.ToString();
            string nombreFoto = DG_tabla3.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
            string rutaFoto2 = DG_tabla3.Rows[e.RowIndex].Cells["IMG2"].Value.ToString();
            string nombreFoto2 = DG_tabla3.Rows[e.RowIndex].Cells["NOMBRE2"].Value.ToString();
            string rutaFoto3 = DG_tabla3.Rows[e.RowIndex].Cells["IMG3"].Value.ToString();
            string nombreFoto3 = DG_tabla3.Rows[e.RowIndex].Cells["NOMBRE3"].Value.ToString();
            string ticket = DG_tabla3.Rows[e.RowIndex].Cells["NUMTICKET"].Value.ToString();
            string comRevision = DG_tabla3.Rows[e.RowIndex].Cells["COMENTARIOREVISION"].Value.ToString();
            string comRevision2 = DG_tabla3.Rows[e.RowIndex].Cells["COMREV2"].Value.ToString();
            string usuario = "";
           


            try
            {
                id = Convert.ToInt32(DG_tabla3.Rows[e.RowIndex].Cells["IDGASTOCORREGIR"].Value.ToString());
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                id = 0;
            }

            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime fecha = DT_fecha.Value;
            

            //Evita que la vista de agregar foto se abra mas de una vez
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CorregirGasto);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva

            frm = new  CorregirGasto(this, concepto, descripcion, importe, fila, detalle, foto, sucursal, fecha, id, nombreFoto, usuario, rutaFoto2, nombreFoto2, rutaFoto3, nombreFoto3, ticket, comRevision, comRevision2);

            frm.Show();
        }

        public void GastosPorCorregir(string detalle, string rutaFoto, int fila, string nombreFoto, int id, string rutafoto2, string nombreFoto2, string rutaFoto3, string nombreFoto3)
        {
           
            DG_tabla3.Rows[fila].Cells["DETALLE"].Value= detalle;
           DG_tabla3.Rows[fila].Cells["IMG1"].Value = rutaFoto;
             DG_tabla3.Rows[fila].Cells["NOMBRE"].Value= nombreFoto;
             DG_tabla3.Rows[fila].Cells["IMG2"].Value =rutafoto2;
            DG_tabla3.Rows[fila].Cells["NOMBRE2"].Value  = nombreFoto2;
            DG_tabla3.Rows[fila].Cells["IMG3"].Value  = rutaFoto3;
            DG_tabla3.Rows[fila].Cells["NOMBRE3"].Value = nombreFoto3;
            
        
        }

        private void BT_corregir_Click(object sender, EventArgs e)
        {


            try
            {

                DateTime fecha = DT_fecha.Value;
#pragma warning disable CS0219 // La variable 'respaldo' está asignada pero su valor nunca se usa
                bool respaldo;
#pragma warning restore CS0219 // La variable 'respaldo' está asignada pero su valor nunca se usa

                if (CBX_respaldo.Checked==true)
                {
                    respaldo = true;
                }
                else
                {
                    respaldo = false;
                }
                GastosxCorregir gastosCorregir = new GastosxCorregir(CB_sucursal.SelectedItem.ToString());
                gastosCorregir.Show();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

              
            }
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
