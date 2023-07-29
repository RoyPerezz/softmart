using appSugerencias.Cuentas_Bancarias.Controlador;
using appSugerencias.Cuentas_Bancarias.Modelo;
using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
using appSugerencias.Gastos_Externos.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class CapturaGastoFinanzas : Form
    {
        string rutaOrigen = "", rutaServidor = "", nombreFoto = "", rutaBD = "", nombreFoto2 = "", rutaBD2 = "", rutaOrigen2 = "", rutaServidor2 = "";
        int id = 0;
       

#pragma warning disable CS0414 // El campo 'CapturaGastoFinanzas.clickFoto1' está asignado pero su valor nunca se usa
        bool clickFoto1 = false;
#pragma warning restore CS0414 // El campo 'CapturaGastoFinanzas.clickFoto1' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'CapturaGastoFinanzas.clickFoto2' está asignado pero su valor nunca se usa
        bool clickFoto2 = false;
#pragma warning restore CS0414 // El campo 'CapturaGastoFinanzas.clickFoto2' está asignado pero su valor nunca se usa
        string usuario;
        GastoExterno GX_finanzas;
        public CapturaGastoFinanzas(GastoExterno GX_finanzas,string usuario)
        {
            this.GX_finanzas = GX_finanzas;
            this.usuario = usuario;
            InitializeComponent();
        }


        public void PersonasQueGenernaGastos()
        {
            CB_persona.Items.Clear();
            string query = "SELECT * FROM rd_persona_gasto_externo";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_persona.Items.Add(dr["nombre"].ToString());
            }

            dr.Close();
            con.Close();

        }
        private void CapturaGastoFinanzas_Load(object sender, EventArgs e)
        {
            id = GX_finanzas.Id;
            DT_fecha.Value = GX_finanzas.Fecha;
            TB_importe.Text = GX_finanzas.Importe.ToString();
            TB_folio.Text = GX_finanzas.Folio;
            CB_persona.Text = GX_finanzas.PersonaGeneraGasto;
            CB_conceptogral.Text = GX_finanzas.Concepto_gral;
            CB_conceptoDetalle.Text = GX_finanzas.ConceptoDetalle;
            TB_descripcion.Text = GX_finanzas.Descripcion;
            TB_comentario.Text = GX_finanzas.ComentarioAprobacion;

            if (!GX_finanzas.Foto1.Equals(""))
            {
                rutaBD = GX_finanzas.Foto1;
                PB_imagen1.Image = Image.FromFile(GX_finanzas.Foto1);

                PB_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            if (!GX_finanzas.Foto2.Equals(""))

            {
                rutaBD2 = GX_finanzas.Foto2;
                PB_imagen2.Image = Image.FromFile(GX_finanzas.Foto2);
                PB_imagen2.SizeMode = PictureBoxSizeMode.StretchImage;

            }


            List<Egreso> lista = TipoGastosController.ConceptosGrales("GENERAL");

            foreach (var item in lista)
            {
                CB_conceptogral.Items.Add(item.ConceptoGral);
            }
            PersonasQueGenernaGastos();
        }

        private void CB_conceptogral_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_conceptoDetalle.Items.Clear();
            CB_conceptoDetalle.Text = "";
            string conceptoGral = CB_conceptogral.SelectedItem.ToString();
            List<Egreso> lista = TipoGastosController.ConceptoDetalleFinanzas(conceptoGral, "GENERAL");
            foreach (var item in lista)
            {
                CB_conceptoDetalle.Items.Add(item.ConceptoDetalle.ToString());
            }
        }

        public string RutaBD(string nombreImagen, bool actualizar)
        {
            string ruta = "";

            if (actualizar == false)
            {
                ruta = @"\\\\192.168.6.190\\Users\\Admin\\Documents\\imgGastos\\" + nombreImagen;
            }
            else
            {
                ruta = @"\\\\\\\\192.168.6.190\\\\Users\\\\Admin\\\\Documents\\\\imgGastos\\\\" + nombreImagen;
            }


            return ruta;
        }


        //personaas que generan gastos
        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistrarPersonaGeneraGasto persona = new RegistrarPersonaGeneraGasto();
            persona.Show();

        }


        //Vuelve a cargar las personas que generan gastos en el combobox
        private void button2_Click_1(object sender, EventArgs e)
        {
            PersonasQueGenernaGastos(); ;
        }

        public string RutaServidor(string nombreImagen)
        {

            string ruta = @"\\192.168.6.190\Users\Admin\Documents\imgGastos\" + nombreImagen;


            return ruta;
        }

        public void Limpiar()
        {
            TB_importe.Text = "";
            TB_folio.Text = "";
            TB_descripcion.Text = "";
            CB_persona.Text = "";
            CB_conceptogral.Text = "";
            CB_conceptoDetalle.Text = "";
            PB_imagen1.Image = null;
            PB_imagen2.Image = null;
            rutaBD = "";
            nombreFoto = "";
            rutaBD2 = "";
            nombreFoto2 = "";
        }
        private void BT_guardar_Click(object sender, EventArgs e)
        {

            ArrayList sucursales = new ArrayList();
            sucursales.Add("VALLARTA");
            sucursales.Add("RENA");
            sucursales.Add("VELAZQUEZ");
            sucursales.Add("COLOSO");

#pragma warning disable CS0219 // La variable 'rutaFoto' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'rutaFoto2' está asignada pero su valor nunca se usa
            string rutaFoto = "",rutaFoto2="";
#pragma warning restore CS0219 // La variable 'rutaFoto2' está asignada pero su valor nunca se usa
#pragma warning restore CS0219 // La variable 'rutaFoto' está asignada pero su valor nunca se usa

            GastoExterno ge = new GastoExterno()
            {
                Id = GX_finanzas.Id,
                Fecha = DT_fecha.Value,
                Importe = Convert.ToDouble(TB_importe.Text),
                Folio = TB_folio.Text,
                PersonaGeneraGasto = CB_persona.Text,
                Concepto_gral = CB_conceptogral.Text,
                ConceptoDetalle = CB_conceptoDetalle.Text,
                Descripcion = TB_descripcion.Text,
                Foto1 =rutaBD,
                NombreFoto1 = nombreFoto,
                Foto2=rutaBD2,
                EstadoAprobacion = GX_finanzas.EstadoAprobacion,
                NombreFoto2 = nombreFoto2
                
            };


            string fechaGasto = DT_fecha.Value.ToString("yyyy-MM-dd");
            string hora = DT_fecha.Value.ToString("HH:mm:ss");
           
            CuentaBancariaOsmart cbo = new CuentaBancariaOsmart()
            {
                SucursalCuenta = "BODEGA",
                Mov = "GE",
                IE = 'E',
                Banco = "FINANZAS",
                Cuenta = "ENVIO",
                ClienteBancario = "GASTOS GENERALES FINANZAS",
                Importe = Convert.ToDouble(TB_importe.Text),
                Fecha = Convert.ToDateTime(fechaGasto),
                Hora = hora,
                FK_GastoExterno = 0,
                Ref_GastoExterno = TB_descripcion.Text,
                Suc_pago ="",
                FK_flujo=0

            };

            int idGasto = GastoExternoController.ObtenerIDGastoExterno(CB_conceptogral.Text, CB_conceptoDetalle.Text, "GENERAL");

            GastoExternoPago gep = new GastoExternoPago()
            {
                Fecha = Convert.ToDateTime(fechaGasto),
                Hora =hora,
                Importe = Convert.ToDouble(TB_importe.Text),
                IdGastoExterno = idGasto,
                ConceptoDetalle = CB_conceptoDetalle.Text,
                ConceptoGral = CB_conceptogral.Text,
                TipoGasto = "GENERAL",
                Usuario =usuario,
                FechaCreacion = DateTime.Now,
                Observacion = TB_descripcion.Text


            };

            if (GX_finanzas.Id==0)
            {
                if (!nombreFoto.Equals(""))
                {
                    File.Copy(rutaOrigen, RutaServidor(ge.NombreFoto1), true);
                }

                if (!nombreFoto2.Equals(""))
                {
                    File.Copy(rutaOrigen2, RutaServidor(ge.NombreFoto2), true);
                }
                GastoFinanzasController.GuardarGasto(ge);//GUARDA EL GASTO CAPTURADO POR EL USUARIO
              
                for (int i = 0; i < sucursales.Count; i++)
                {
                    CuentasController.RegistrarIngresoEgreso(cbo,sucursales[i].ToString()); //INSERTA UN REGISTRO POR TIENDA EN EL ESTADO DE CUENTAS DE FINANZAS (EL IMPORTE TOTAL SE DIVIDE ENTRE EL NUM DE TIENDAS)
                }

                for (int i = 0; i < sucursales.Count; i++)
                {
                    PagoGastoExternoController.InsertarPagoGastoExterno(sucursales[i].ToString(),gep); //INSERTA REGISTRO EN TABLA RD_GASTOS_EXTERNOSPAGOS, E IGUAL EL IMPORTE SE DIVIDE ENTRE 4
                }
                

                
                MessageBox.Show("Se ha guardado el gasto");
                Limpiar();
            }
            else
            {

                if (!GX_finanzas.NombreFoto1.Equals("") )
                {
                    ge.Foto1 = "";
                    ge.Foto1 = RutaBD(GX_finanzas.NombreFoto1, true);
                    ge.NombreFoto1 = GX_finanzas.NombreFoto1;


                }
                else
                {

                    if (!nombreFoto.Equals(""))
                    {
                        File.Copy(rutaOrigen, rutaServidor, true);
                    }

                }

                if (!GX_finanzas.NombreFoto2.Equals("") )
                {
                    ge.Foto2 = "";
                    ge.Foto2 = RutaBD(GX_finanzas.NombreFoto2, true);
                    ge.NombreFoto2 = GX_finanzas.NombreFoto2;
                }
                else
                {
                    if (!nombreFoto2.Equals(""))
                    {
                        File.Copy(rutaOrigen2, rutaServidor2, true);
                    }

                }

                if (ge.EstadoAprobacion.Equals("RECHAZADO"))
                {
                    ge.EstadoAprobacion = "CORREGIDO";
                }
                GastoFinanzasController.ModificarGasto(ge);
                MessageBox.Show("Se ha modificado el gasto");
                this.Close();

            }


        }


        ArrayList fotos = new ArrayList();
        public void GuardarImagen(Image img, bool img1, bool img2, bool img3)
        {

            DateTime fecha = DateTime.Now;
            int año = fecha.Year;
            int mes = fecha.Month;
            int dia = fecha.Day;
            int hora = fecha.Hour;
            int minutos = fecha.Minute;
            int segundos = fecha.Second;
            int miliseg = fecha.Millisecond;
            string time = año.ToString() + mes.ToString() + dia.ToString() + hora.ToString() + minutos.ToString() + segundos.ToString() + miliseg.ToString();
            string nombreFoto = "imagen" + time;

            Image Imagen = img;

            string eliminarImagen = "";
            if (img1 == true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto = nombreFoto;
                string ruta = RutaBD(nombreFoto, false);
                rutaBD = ruta;
                eliminarImagen = rutaOrigen;
                fotos.Add(nombreFoto);
            }
            else if (img2 == true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen2 = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto2 = nombreFoto;
                string ruta = RutaBD(nombreFoto, false);
                rutaBD2 = ruta;
                eliminarImagen = rutaOrigen2;
                fotos.Add(nombreFoto2);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrirImagen = new OpenFileDialog();



            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                PB_imagen1.ImageLocation = abrirImagen.FileName;
                PB_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                PB_imagen1.Tag = abrirImagen.FileName;
                rutaOrigen = PB_imagen1.Tag.ToString();
                nombreFoto = Path.GetFileName(PB_imagen1.Tag.ToString());
                rutaServidor = RutaServidor(nombreFoto);

                rutaBD = RutaBD(nombreFoto,false);
            }
            clickFoto1 = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();



            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                PB_imagen2.ImageLocation = abrirImagen.FileName;
                PB_imagen2.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                PB_imagen2.Tag = abrirImagen.FileName;
                rutaOrigen2 = PB_imagen2.Tag.ToString();
                nombreFoto2 = Path.GetFileName(PB_imagen2.Tag.ToString());
                rutaServidor2 = RutaServidor(nombreFoto2);
                rutaBD2 = RutaBD(nombreFoto2,false);
            }

            clickFoto2 = true;
        }
    }
}
