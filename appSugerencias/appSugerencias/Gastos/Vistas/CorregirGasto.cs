using AForge.Video;
using AForge.Video.DirectShow;
using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using System;
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
    public partial class CorregirGasto : Form
    {
        private IDatos idatos;
        int actualizarFoto1 = 0, actualizarFoto2 = 0, actualizarFoto3 = 0, actualizarComentario = 0;

        bool hayDispositivo = false;

        private VideoCaptureDevice cam = new VideoCaptureDevice();//capturar video
        private FilterInfoCollection MiDispositivos = null;//detectar los dispositivos que se encuentren
        private VideoCaptureDevice MiWebCam;//verirfica si la camara está activa

        string NombreFotoEliminada = "";

        string concepto = "", descripcion = "";
        double importe = 0;
        int fila = 0, id = 0;
        DateTime fecha;
        string rutaOrigen = "", rutaFoto = "", rutaOrigen2 = "", rutaOrigen3 = "", rutaDestino2 = "", rutaDestino3 = "";
        string nombre = "", comentario = "", sucursal, nombreFoto, usuario = "", nombreFoto2 = "", nombreFoto3 = "", rutaFoto2 = "", rutaFoto3 = "", nombre2 = "", nombre3 = "", ticket = "",comRevision="";
        string comRevision2 = "";
        private void BT_eliminar3_Click(object sender, EventArgs e)
        {

           
            pictureBox3.Image = null;
            GastosController gc = new GastosController();
            bool exito = gc.EliminarFoto(3, id, sucursal);
            string rutaFoto = RutaServidor(sucursal);
            string rutaImagen = rutaFoto + nombreFoto3;
            if (exito == true)
            {
                Image.FromFile(rutaFoto3).Dispose();
                GC.Collect(GC.MaxGeneration);
                if (System.IO.File.Exists(rutaImagen))
                {
                    // Use a try block to catch IOExceptions, to
                    // handle the case of the file already being
                    // opened by another process.
                    try
                    {
                        //System.IO.File.Delete(rutaImagen);
                        rutaOrigen3 = ""; rutaFoto3 = ""; rutaDestino3 = ""; nombreFoto3 = "";
                    }
                    catch (System.IO.IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
              




                MessageBox.Show("La foto ha sido eliminada, si lo deseas puedes cargar otra foto");
            }
        }

        private void BT_eliminar2_Click(object sender, EventArgs e)
        {
          


            pictureBox2.Image = null;
            GastosController gc = new GastosController();
            string rutaFoto = RutaServidor(sucursal);
            bool exito = gc.EliminarFoto(2, id, sucursal);
            string rutaImagen = rutaFoto + nombreFoto2;
            if (exito == true)
            {
                Image.FromFile(rutaFoto2).Dispose();
                GC.Collect(GC.MaxGeneration);
                if (System.IO.File.Exists(rutaImagen))
                {
                   

                    // Use a try block to catch IOExceptions, to
                    // handle the case of the file already being
                    // opened by another process.
                    try
                    {
                        rutaOrigen2 = ""; rutaFoto2 = ""; rutaDestino2 = ""; nombreFoto2 = "";
                       // System.IO.File.Delete(rutaImagen);
                       
                    }
                    catch (System.IO.IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
               
                MessageBox.Show("La foto ha sido eliminada, si lo deseas puedes cargar otra foto");
            }

        }

        private void BT_iniciar_cam_Click(object sender, EventArgs e)
        {

            BT_iniciar_cam.BackColor = Color.DodgerBlue;
            BT_iniciar_cam.ForeColor = Color.White;
            BT_TomarFoto1.Enabled = true;
            BT_TomarFoto2.Enabled = true;
            BT_tomarFoto3.Enabled = true;
            BT_img1.Enabled = false;
            BT_img2.Enabled = false;
            BT_img3.Enabled = false;
            BT_eliminar1.Enabled = false;
            BT_eliminar2.Enabled = false;
            BT_eliminar3.Enabled = false;

            CapturarFoto();
        }

        private void BT_TomarFoto1_Click(object sender, EventArgs e)
        {
            TomarFoto1();
            TomarFoto3();
            BT_iniciar_cam.BackColor = Color.LightGray;
            BT_iniciar_cam.ForeColor = Color.Black;
            BT_TomarFoto1.Enabled = false;
            BT_TomarFoto2.Enabled = false;

            BT_tomarFoto3.Enabled = false;

            CerrarWebCam();
        }

        private void BT_TomarFoto2_Click(object sender, EventArgs e)
        {
            TomarFoto2();
           
            BT_iniciar_cam.BackColor = Color.LightGray;
            BT_iniciar_cam.ForeColor = Color.Black;
            BT_TomarFoto1.Enabled = false;
            BT_TomarFoto2.Enabled = false;

            BT_tomarFoto3.Enabled = false;

            CerrarWebCam();
        }

        private void BT_tomarFoto3_Click(object sender, EventArgs e)
        {
            TomarFoto3();
            BT_iniciar_cam.BackColor = Color.LightGray;
            BT_iniciar_cam.ForeColor = Color.Black;
            BT_TomarFoto1.Enabled = false;
            BT_TomarFoto2.Enabled = false;

            BT_tomarFoto3.Enabled = false;

            CerrarWebCam();
        }

      

        private void BT_eliminar1_Click(object sender, EventArgs e)
        {

            
            pictureBox1.Image = null;
            GastosController gc = new GastosController();
            string rutaFoto_ = RutaServidor(sucursal);
            bool exito = gc.EliminarFoto(1,id,sucursal);

            if (exito == true)
            {
                Image.FromFile(rutaFoto).Dispose();
                GC.Collect(GC.MaxGeneration);

                if (System.IO.File.Exists(rutaFoto))
                {
                    // Use a try block to catch IOExceptions, to
                    // handle the case of the file already being
                    // opened by another process.
                    try
                    {
                       // System.IO.File.Delete(rutaFoto_ + nombreFoto);
                        rutaOrigen = ""; rutaFoto = ""; nombreFoto = "";
                    }
                    catch (System.IO.IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
               
                MessageBox.Show("La foto ha sido eliminada, si lo deseas puedes cargar otra foto");
            }
            
        }

      




        #region BOTONES
        private void BT_img3_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            string ruta = RutaFoto(sucursal);
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.ImageLocation = abrirImagen.FileName;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                pictureBox3.Tag = abrirImagen.FileName;
                rutaOrigen3 = pictureBox3.Tag.ToString();
                nombre3 = Path.GetFileName(pictureBox3.Tag.ToString());
                rutaFoto3 = ruta + nombre3;
            }
        }

        private void BT_img2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            string ruta = RutaFoto(sucursal);

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = abrirImagen.FileName;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                pictureBox2.Tag = abrirImagen.FileName;
                rutaOrigen2 = pictureBox2.Tag.ToString();
                nombre2 = Path.GetFileName(pictureBox2.Tag.ToString());
                rutaFoto2 = ruta + nombre2;
            }
        }

        private void BT_img1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            string ruta = RutaFoto(sucursal);


            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = abrirImagen.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                pictureBox1.Tag = abrirImagen.FileName;
                rutaOrigen = pictureBox1.Tag.ToString();
                nombre = Path.GetFileName(pictureBox1.Tag.ToString());
                rutaFoto = ruta + nombre;
            }
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            string comentario = this.comentario;
            
            GastosController gc = new GastosController();





            try
            {
                if (nombre.Equals(""))
                {
                   

                    if (nombreFoto.Equals(""))
                    {

                    }
                    else
                    {
                        nombre = nombreFoto;
                        string ruta = RutaFoto(sucursal);
                        rutaFoto = ruta + nombre;
                    }
                }

                if (!rutaOrigen.Equals(""))
                {

                    File.Copy(rutaOrigen, rutaFoto, true);
                    //foto = rutaDestino + nombre;
                    actualizarFoto1 = 1;

                }

                if (!rutaFoto.Equals(""))
                {
                    string ruta = RutaServidor(sucursal);
                    //rutaDestino = ruta + nombre;
                    //rutaFoto = RutaFoto(sucursal);
                }


                if (nombre2.Equals(""))
                {

                    if (nombreFoto2.Equals(""))
                    {

                    }
                    else
                    {
                        nombre2 = nombreFoto2;
                        string ruta = RutaFoto(sucursal);
                        rutaFoto2 = ruta + nombre2;
                    }

                   
                }

                if (!rutaOrigen2.Equals(""))
                {

                    File.Copy(rutaOrigen2, rutaFoto2, true);
                    //  foto = rutaDestino + nombre;
                    actualizarFoto2 = 1;

                }

                if (!rutaDestino2.Equals(""))
                {
                    string ruta = RutaServidor(sucursal);

                    rutaDestino2 = ruta + nombre2;
                    //rutaFoto2 = RutaFoto(sucursal);
                }
                if (nombre3.Equals(""))
                {
                    
                    if (nombreFoto3.Equals(""))
                    {

                    }
                    else
                    {
                        nombre3 = nombreFoto3;
                        string ruta = RutaFoto(sucursal);
                        rutaFoto3 = ruta + nombre3;
                    }

                }

                if (!rutaOrigen3.Equals(""))
                {

                    File.Copy(rutaOrigen3, rutaFoto3, true);
                    actualizarFoto3 = 1;


                }

                if (!rutaDestino3.Equals(""))
                {
                    string ruta = RutaServidor(sucursal);
                    rutaDestino3 = ruta + nombre3;
                    //rutaFoto3 = RutaFoto(sucursal);
                }


                if (this.comentario.Equals(TB_detalle.Text))
                {

                }
                else
                {
                    comentario = TB_detalle.Text;
                    actualizarComentario = 1;
                }
                
                
                gc.ActualizarRevision(id,sucursal);
                gc.Actualizar(actualizarFoto1,actualizarFoto2,actualizarFoto3, actualizarComentario, id, TB_detalle.Text, rutaFoto, nombre, sucursal, rutaFoto2, nombre2, rutaFoto3, nombre3);
               

                idatos.GastosPorCorregir(comentario, rutaFoto, fila, nombre, id, rutaFoto2, nombre2, rutaFoto3, nombre3);
                this.Close();
                MessageBox.Show("Gasto actualizado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar gasto: " + ex);
            }

            CerrarWebCam();
            GC.Collect(GC.MaxGeneration);


        }
        #endregion


        #region  METODOS
        public CorregirGasto(IDatos _idatos, string concepto, string descripcion, double importe, int fila, string comentario, string foto, string sucursal, DateTime fecha, int id, string nombreFoto,
           string usuario, string rutaFoto2, string nombreFoto2, string rutaFoto3, string nombreFoto3, string ticket,string comRevision,string comRevision2)
        {
            idatos = _idatos;
            this.concepto = concepto;
            this.descripcion = descripcion;
            this.importe = importe;
            this.fila = fila;
            this.comentario = comentario;
            this.rutaFoto = foto;
            this.sucursal = sucursal;
            this.fecha = fecha;
            this.id = id;
            this.nombreFoto = nombreFoto;
            this.rutaFoto2 = rutaFoto2;
            this.nombreFoto2 = nombreFoto2;
            this.rutaFoto3 = rutaFoto3;
            this.nombreFoto3 = nombreFoto3;
            this.usuario = usuario;
            this.ticket = ticket;
            this.comRevision = comRevision;
            this.comRevision2 = comRevision2;
           
            InitializeComponent();
        }

        public string RutaServidor(string sucursal)
        {
            string ruta = "";

            if (sucursal.Equals("VALLARTA"))
            {
                ruta = @"\\192.168.1.2\Users\Administrador.WIN-SJDEC013JTB\Documents\imgTickets\";
            }
            else if (sucursal.Equals("RENA"))
            {
                ruta = @"\\192.168.2.2\Users\Administrador.WIN-1E300DIGI8A\Documents\imgTickets\";
            }
            else if (sucursal.Equals("VELAZQUEZ"))
            {
                ruta = @"\\192.168.4.2\Users\Administrador.WIN-EFLLK2MJD9S\Documents\imgTickets\";
            }
            else if (sucursal.Equals("COLOSO"))
            {
                ruta = @"\\192.168.3.2\Users\Administrador.WIN-KP12TVSM78R\Documents\imgTickets\";
            }
            else
            {

            }



            return ruta;
        }

        public string RutaFoto(string sucursal)
        {
            string ruta = "";

            if (sucursal.Equals("VALLARTA"))
            {
                ruta = @"\\\\\\\\192.168.1.2\\\\Users\\\\Administrador.WIN-SJDEC013JTB\\\\Documents\\\\imgTickets\\\\";
            }
            else if (sucursal.Equals("RENA"))
            {
                ruta = @"\\\\\\\\192.168.2.2\\\\Users\\\\Administrador.WIN-1E300DIGI8A\\\\Documents\\\\imgTickets\\\\";
            }
            else if (sucursal.Equals("VELAZQUEZ"))
            {
                ruta = @"\\\\\\\\192.168.4.2\\\\Users\\\\Administrador.WIN-EFLLK2MJD9S\\\\Documents\\\\imgTickets\\\\";
            }
            else if (sucursal.Equals("COLOSO"))
            {
                ruta = @"\\\\\\\\192.168.3.2\\\\Users\\\\Administrador.WIN-KP12TVSM78R\\\\Documents\\\\imgTickets\\\\";
            }
            else
            {

            }



            return ruta;
        }


        private void CorregirGasto_Load(object sender, EventArgs e)
        {
            LB_concepto.Text = concepto;
            LB_descripcion.Text = descripcion;
            LB_importe.Text = importe.ToString("C2");
            LB_fecha.Text = fecha.ToString("yyyy-MM-dd");
            TB_comentarioRevision.Text = comRevision;
            TB_comentarioRev2.Text = comRevision2;
            //decimal digito = decimal.Parse(LB_importe.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            //string num = digito.ToString("G0");
            //LB_importe.Text = num;
            if (!comentario.Equals(""))
            {
                TB_detalle.Text = comentario;
            }

           

            if (!rutaFoto.Equals(""))
            {


                pictureBox1.Image = Image.FromFile(rutaFoto);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;



            }

            if (!rutaFoto2.Equals(""))
            { 
              
                pictureBox2.Image = Image.FromFile(rutaFoto2);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }

            if (!rutaFoto3.Equals(""))
            {

                pictureBox3.Image = Image.FromFile(rutaFoto3);
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            CargaDispositivo();
        }


        #region METODOS DE CAMARA
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

        private void Cerrar(object sender, EventArgs e)
        {
            CerrarWebCam();
        }

        Stopwatch oSW = new Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);

            this.LB_contador.Text = ts.Seconds.ToString();

            if (ts.Seconds == 15)
            {
                CerrarWebCam();
                GC.Collect(GC.MaxGeneration);
                BT_iniciar_cam.BackColor = Color.LightGray;
                BT_iniciar_cam.ForeColor = Color.Black;
                BT_TomarFoto1.Enabled = false;
                BT_TomarFoto2.Enabled = false;
                BT_tomarFoto3.Enabled = false;
                this.timer1.Enabled = false;
                timer1.Stop();
                oSW.Reset();
                this.LB_contador.Text = "0";
            }
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

        public void GuardarImagen(Image img, bool img1, bool img2, bool img3)
        {
            //System.Drawing.Imaging.ImageFormat.Jpeg
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
            //SaveFileDialog Guardar = new SaveFileDialog();
            //Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            Image Imagen = img;
            //Guardar.ShowDialog();
            //string nombre = Path.GetFileName(Guardar.FileName);
            //string ruta = Guardar.FileName;
            //Imagen.Save(Guardar.FileName);
            if (img1 == true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto = nombreFoto;
                string ruta = RutaFoto(sucursal);
                rutaFoto = ruta + "\\" + nombreFoto;
            }
            else if (img2 == true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen2 = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto2 = nombreFoto;
                string ruta = RutaFoto(sucursal);
                rutaFoto2 = ruta + "\\" + nombreFoto;
            }
            else if (img3 == true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen3 = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto3 = nombreFoto;
                string ruta = RutaFoto(sucursal);
                rutaFoto3 = ruta + "\\" + nombreFoto;
            }

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

            string rutaLocal = "ImgTickets\\" + nombreFoto;
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                string ruta = RutaFoto(sucursal);
                pictureBox1.Image = pictureBox0.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Tag = abrirImagen.FileName;
                rutaOrigen = pictureBox1.Tag.ToString();
                nombre = Path.GetFileName(pictureBox1.Tag.ToString());
                rutaFoto = rutaLocal;
                GuardarImagen(pictureBox1.Image, true, false, false);
            }
            this.timer1.Enabled = false;
            timer1.Stop();
            oSW.Reset();
            this.LB_contador.Text = "0";

            CerrarWebCam();
            GC.Collect(GC.MaxGeneration);
            BT_img1.Enabled = true;
            BT_img2.Enabled = true;
            BT_img3.Enabled = true;
            BT_eliminar1.Enabled = true;
            BT_eliminar2.Enabled = true;
            BT_eliminar3.Enabled = true;
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

            string rutaLocal = "ImgTickets\\" + nombreFoto;

            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                string ruta = RutaFoto(sucursal);
                pictureBox2.Image = pictureBox0.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Tag = abrirImagen.FileName;
                rutaOrigen2 = pictureBox2.Tag.ToString();
                nombre2 = Path.GetFileName(pictureBox2.Tag.ToString());
                rutaFoto2 = rutaLocal;
                GuardarImagen(pictureBox2.Image, false, true, false);
            }
            this.timer1.Enabled = false;
            timer1.Stop();
            oSW.Reset();
            this.LB_contador.Text = "0";

            CerrarWebCam();
            GC.Collect(GC.MaxGeneration);
            BT_img1.Enabled = true;
            BT_img2.Enabled = true;
            BT_img3.Enabled = true;
            BT_eliminar1.Enabled = true;
            BT_eliminar2.Enabled = true;
            BT_eliminar3.Enabled = true;
        }

        private void TomarFoto3()
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

            string rutaLocal = "ImgTickets\\" + nombreFoto;
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                string ruta = RutaFoto(sucursal);
                pictureBox3.Image = pictureBox0.Image;
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox3.Tag = abrirImagen.FileName;
                rutaOrigen3 = pictureBox3.Tag.ToString();
                nombre3 = Path.GetFileName(pictureBox3.Tag.ToString());
                rutaFoto3 = rutaLocal;
                GuardarImagen(pictureBox3.Image, false, false, true);
            }
            this.timer1.Enabled = false;
            timer1.Stop();
            oSW.Reset();
            this.LB_contador.Text = "0";

            CerrarWebCam();
            GC.Collect(GC.MaxGeneration);
            BT_img1.Enabled = true;
            BT_img2.Enabled = true;
            BT_img3.Enabled = true;
            BT_eliminar1.Enabled = true;
            BT_eliminar2.Enabled = true;
            BT_eliminar3.Enabled = true;
        }
        #endregion

        private void CrearCarpetasGastos()
        {
            //VARIBLE QUE CONTENDRA EL NOMBRE DE LA CARPETA PRODUCTOS
            string ruta = @"C:\Users\Administrador.WIN-SJDEC013JTB\Documents\imgTickets\";
            //string ruta = @"C:\Users\Sistemas\Documents\imgGastos";
            string imgProductos = Application.StartupPath + ruta;

            try
            {
                if (!Directory.Exists(imgProductos))//&& Directory.Exists(imgProductos))
                {

                    Directory.CreateDirectory(imgProductos);
                    //MessageBox.Show("Se ha creado la carpera imgGastos");
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                //MessageBox.Show("Ocurrio un Error :\n " + ex);
            }
        }

        
        #endregion


    }
}
