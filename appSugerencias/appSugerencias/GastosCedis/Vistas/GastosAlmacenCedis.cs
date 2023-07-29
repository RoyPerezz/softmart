using AForge.Video;
using AForge.Video.DirectShow;
using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class GastosAlmacenCedis : Form
    {

        int id = 0;
        string usuario = "";
        bool hayDispositivo = false;

        private VideoCaptureDevice cam = new VideoCaptureDevice();//capturar video
        private FilterInfoCollection MiDispositivos = null;//detectar los dispositivos que se encuentren
        private VideoCaptureDevice MiWebCam;//verirfica si la camara está activa
        GastoAlmacenCedis gastoCedis;
        public GastosAlmacenCedis(GastoAlmacenCedis gastoCedis,string usuario)
        {
            this.usuario = usuario;
            this.gastoCedis = gastoCedis;
            InitializeComponent();
        }

        string rutaOrigen = "", rutaServidor = "", nombreFoto = "",rutaBD="",nombreFoto2="", rutaBD2="",rutaOrigen2="",rutaServidor2="";
        bool clickFoto1 = false;
        bool clickFoto2 = false;
        private void CB_concepto_gral_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_conceptoDetalle.Items.Clear();
            CB_conceptoDetalle.Text = "";
            string conceptoGral = CB_concepto_gral.SelectedItem.ToString();
            List<Egreso> lista = TipoGastosController.ConceptoDetalle(conceptoGral, "GENERAL");
            foreach (var item in lista)
            {
                CB_conceptoDetalle.Items.Add(item.ConceptoDetalle.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PB_imagen1_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar(object sender, EventArgs e)
        {
            CerrarWebCam();
        }

        private void CargaDispositivo()
        {

            CerrarWebCam();
            MiDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (MiDispositivos.Count > 0)
            {
                hayDispositivo = true;
                for (int i = 0; i < MiDispositivos.Count; i++)
                {
                    CB_camaras.Items.Add(MiDispositivos[i].Name.ToString());
                    CB_camaras.Text = MiDispositivos[0].Name.ToString();
                }
            }
        }

        private void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }
        Stopwatch oSW = new Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void CapturarFoto()
        {
            int i = CB_camaras.SelectedIndex;
            string nombreDispositivo = MiDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(nombreDispositivo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();
            oSW.Start();
            timer1.Enabled = true;

        }

        private void Capturando(object sender, NewFrameEventArgs e)
        {
            Bitmap f = (Bitmap)(e.Frame.Clone());
            pictureBox0.Image = f;
            GC.Collect(GC.MaxGeneration);
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        private void TomarFoto1()
        {
            DateTime fecha = DateTime.Now;
            int año = fecha.Year;
            int mes = fecha.Month;
            int dia = fecha.Day;
            int hora = fecha.Hour;
            int minutos = fecha.Minute;
            int segundos = fecha.Second;
            int miliseg = fecha.Millisecond;
            int time = año + mes + dia + hora + minutos + segundos + miliseg;
            string nombreFoto = "imagen" + time;

            string rutaLocal = "imgTickets\\" + nombreFoto;
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                //string ruta = RutaFoto(sucursal);
                PB_imagen1.Image = pictureBox0.Image;
                PB_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;
                PB_imagen1.Tag = abrirImagen.FileName;
                rutaOrigen = PB_imagen1.Tag.ToString();
                nombreFoto = Path.GetFileName(PB_imagen1.Tag.ToString());
                rutaBD = rutaLocal;
                GuardarImagen(PB_imagen1.Image, true, false, false);

            }
            this.timer1.Enabled = false;
            timer1.Stop();
            oSW.Reset();
            this.LB_contador.Text = "0";

            CerrarWebCam();
            GC.Collect(GC.MaxGeneration);
            TB_cargar.Enabled = true;
            BT_cargar2.Enabled = true;

        }

        private void TomarFoto2()
        {
            DateTime fecha = DateTime.Now;
            int año = fecha.Year;
            int mes = fecha.Month;
            int dia = fecha.Day;
            int hora = fecha.Hour;
            int minutos = fecha.Minute;
            int segundos = fecha.Second;
            int miliseg = fecha.Millisecond;
            int time = año + mes + dia + hora + minutos + segundos + miliseg;
            string nombreFoto = "imagen" + time;

            string rutaLocal = "imgTickets\\" + nombreFoto;

            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
               
                PB_imagen2.Image = pictureBox0.Image;
                PB_imagen2.SizeMode = PictureBoxSizeMode.StretchImage;
                PB_imagen2.Tag = abrirImagen.FileName;
                rutaOrigen2 = PB_imagen2.Tag.ToString();
                nombreFoto2 = Path.GetFileName(PB_imagen2.Tag.ToString());
                string ruta = RutaBD(nombreFoto,false);
                rutaBD2 = rutaLocal;
                GuardarImagen(PB_imagen2.Image, false, true, false);
            }
            this.timer1.Enabled = false;
            timer1.Stop();
            oSW.Reset();
            this.LB_contador.Text = "0";
            CerrarWebCam();
            GC.Collect(GC.MaxGeneration);
            TB_cargar.Enabled = true;
            BT_cargar2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BT_iniciar_camara.Enabled = false;
            BT_iniciar_camara.BackColor = Color.DodgerBlue;
            BT_iniciar_camara.ForeColor = Color.White;
            BT_foto.Enabled = true;
            BT_foto2.Enabled = true;
           
            TB_cargar.Enabled = false;
            
            BT_cargar2.Enabled = false;

            CapturarFoto();
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
                string ruta = RutaBD(nombreFoto,false);
                rutaBD = ruta ;
                eliminarImagen = rutaOrigen;
                fotos.Add(nombreFoto);
            }
            else if (img2 == true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen2 = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto2 = nombreFoto;
                string ruta = RutaBD(nombreFoto,false);
                rutaBD2 = ruta;
                eliminarImagen = rutaOrigen2;
                fotos.Add(nombreFoto2);
            }
           


        }

        private void BT_foto_Click(object sender, EventArgs e)
        {

            TomarFoto1();
            CerrarWebCam();
            BT_iniciar_camara.BackColor = Color.LightGray;
            BT_iniciar_camara.ForeColor = Color.Black;
            TB_cargar.Enabled = true;
            BT_cargar2.Enabled = true;

            BT_foto.Enabled = false;
            BT_foto2.Enabled = false;
            BT_iniciar_camara.Enabled = true;
        }

        private void BT_foto2_Click(object sender, EventArgs e)
        {
            TomarFoto2();
            CerrarWebCam();
            BT_iniciar_camara.BackColor = Color.LightGray;
            BT_iniciar_camara.ForeColor = Color.Black;
            TB_cargar.Enabled = true;
            BT_cargar2.Enabled = true;
            BT_foto.Enabled = false;
            BT_foto2.Enabled = false;
            BT_iniciar_camara.Enabled = true;
        }

        public string RutaBD(string nombreImagen,bool actualizar)
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

        

        public string RutaServidor(string nombreImagen)
        {
           
            string ruta = @"\\192.168.6.190\Users\Admin\Documents\imgGastos\" + nombreImagen;


            return ruta;
        }

        public void Limpiar()
        {
            CB_concepto_gral.Text = "";
           CB_conceptoDetalle.Text = "";
            TB_importe.Text = "";
            TB_folioSalida.Text = "";
            TB_descripcion.Text = "";
            PB_imagen1.Image = null;
            PB_imagen2.Image = null;
            BT_cargar2.Enabled = true;
            TB_cargar.Enabled = true;
            BT_foto.Enabled = false;
            BT_foto2.Enabled = false;
        }
        private void BT_guardar_Click(object sender, EventArgs e)
        {

           

            try
            {
                if (gastoCedis.Id==0)
                {
                    GastoAlmacenCedis ac = new GastoAlmacenCedis()
                    {

                        ConceptoGral = CB_concepto_gral.SelectedItem.ToString(),
                        ConceptoDetalle = CB_conceptoDetalle.SelectedItem.ToString(),
                        DescripcionDetallada = TB_descripcion.Text,
                        Importe = Convert.ToDouble(TB_importe.Text),
                        FolioSalida = TB_folioSalida.Text,
                        Fecha = Convert.ToDateTime(DT_fecha.Value),
                        Usuario = gastoCedis.Usuario,
                        Imagen1 = rutaBD,
                        Imagen2 = rutaBD2,
                        NombreFoto = nombreFoto,
                        NombreFoto2 = nombreFoto2
                    };

                    GastosAlmacenCedisController.RegistrarGasto(ac);

                    //  ######################################## REGISTRAR GASTO EXTERNO #######################################################################
                    ArrayList sucursales = new ArrayList();
                    sucursales.Add("VALLARTA");
                    sucursales.Add("RENA");
                    sucursales.Add("VELAZQUEZ");
                    sucursales.Add("COLOSO");

                    int idGasto = GastoExternoController.ObtenerIDGastoExterno(CB_concepto_gral.Text, CB_conceptoDetalle.Text, "GENERAL");

                    DateTime hora = DT_fecha.Value;
                    GastoExternoPago gep = new GastoExternoPago()
                    {
                        Fecha = DT_fecha.Value,
                        Hora = hora.ToString("HH:mm:ss"),
                        Importe = Convert.ToDouble(TB_importe.Text),
                        IdGastoExterno = idGasto,
                        ConceptoDetalle = CB_conceptoDetalle.Text,
                        ConceptoGral = CB_concepto_gral.Text,
                        TipoGasto = "GENERAL",
                        Usuario = usuario,
                        FechaCreacion = DateTime.Now,
                        Observacion = TB_descripcion.Text


                    };


                    for (int i = 0; i < sucursales.Count; i++)
                    {
                        PagoGastoExternoController.InsertarPagoGastoExterno(sucursales[i].ToString(), gep); //INSERTA REGISTRO EN TABLA RD_GASTOS_EXTERNOSPAGOS, E IGUAL EL IMPORTE SE DIVIDE ENTRE 4
                    }

                    //  #########################################################################################################################################



                    if (!nombreFoto.Equals(""))
                    {
                        File.Copy(rutaOrigen, RutaServidor(ac.NombreFoto), true);
                    }

                    if (!nombreFoto2.Equals(""))
                    {
                        File.Copy(rutaOrigen2, ac.Imagen2, true);
                    }

                    MessageBox.Show("Se ha registrado el gasto correctamente");
                }
                else
                {
                    GastoAlmacenCedis ac = new GastoAlmacenCedis()
                    {
                        Id = id,
                        ConceptoGral = CB_concepto_gral.SelectedItem.ToString(),
                        ConceptoDetalle = CB_conceptoDetalle.SelectedItem.ToString(),
                        DescripcionDetallada = TB_descripcion.Text,
                        Importe = Convert.ToDouble(TB_importe.Text),
                        FolioSalida = TB_folioSalida.Text,
                        Fecha = Convert.ToDateTime(DT_fecha.Value),
                        
                       
                        Imagen1 = rutaBD,
                        Imagen2 = rutaBD2,
                        NombreFoto = nombreFoto,
                        NombreFoto2 = nombreFoto2
                    };



                    if (gastoCedis.EstadoRevision.Equals("CORREGIR"))
                    {
                        ac.EstadoRevision="CORREGIDO";
                    }


                    if (!gastoCedis.NombreFoto.Equals("") && clickFoto1 == false)
                    {
                        ac.Imagen1 = "";
                        ac.Imagen1 = RutaBD(gastoCedis.NombreFoto, true);
                        ac.NombreFoto = gastoCedis.NombreFoto;


                    }
                    else
                    {

                        if (!nombreFoto.Equals(""))
                        {
                            File.Copy(rutaOrigen, rutaServidor, true);
                        }
                       
                    }

                    if (!gastoCedis.NombreFoto2.Equals("") && clickFoto2 == false)
                    {
                        ac.Imagen2 = "";
                        ac.Imagen2 = RutaBD(gastoCedis.NombreFoto2, true);
                        ac.NombreFoto2 = gastoCedis.NombreFoto2;
                    }
                    else
                    {
                        if (!nombreFoto2.Equals(""))
                        {
                            File.Copy(rutaOrigen2, rutaServidor2, true);
                        }
                        
                    }
                  
                  
                    GastosAlmacenCedisController.ModificarGasto(ac);
                   
                    MessageBox.Show("Se ha modificado el gasto correctamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar gasto: "+ex);
            }
            Limpiar();
        }

        private void GastosAlmacenCedis_Load(object sender, EventArgs e)
        {
            List<Egreso> lista = TipoGastosController.ConceptosGrales("GENERAL");

            foreach (var item in lista)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }

            if (gastoCedis.ConceptoGral.Equals(""))
            {

            }
            else
            {
                id = gastoCedis.Id;
                CB_concepto_gral.Text = gastoCedis.ConceptoGral;
               CB_conceptoDetalle.Text = gastoCedis.ConceptoDetalle;
                TB_importe.Text = gastoCedis.Importe.ToString();
                TB_folioSalida.Text = gastoCedis.FolioSalida;
                TB_descripcion.Text = gastoCedis.DescripcionDetallada;
                DT_fecha.Value = gastoCedis.Fecha;
                TB_comentario_rev.Text = gastoCedis.ComRevision;
                if (!gastoCedis.Imagen1.Equals(""))
                {
                    rutaBD = gastoCedis.Imagen1;
                    PB_imagen1.Image = Image.FromFile(gastoCedis.Imagen1);
                    PB_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                if (!gastoCedis.Imagen2.Equals(""))
                    
                {
                    rutaBD2 = gastoCedis.Imagen2;
                    PB_imagen2.Image = Image.FromFile(gastoCedis.Imagen2);
                    PB_imagen2.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }


            BT_foto.Enabled = false;
            BT_foto2.Enabled = false;
            CargaDispositivo();
        }

        private void TB_cargar_Click(object sender, EventArgs e)
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
                
                rutaBD = RutaBD(nombreFoto, gastoCedis.Actualizar);
            }
            clickFoto1 = true;
        }

        private void BT_cargar2_Click(object sender, EventArgs e)
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
                rutaBD2 = RutaBD(nombreFoto2, gastoCedis.Actualizar);
            }

            clickFoto2 = true;
        }
    }
}
