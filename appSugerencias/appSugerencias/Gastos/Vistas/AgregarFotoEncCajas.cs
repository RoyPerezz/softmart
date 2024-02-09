using AForge.Video;
using AForge.Video.DirectShow;
using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace appSugerencias.Gastos.Vistas
{
    public partial class AgregarFotoEncCajas : Form
    {


        private string rutaLocal =@"C:";
        int actualizarFoto1 = 0, actualizarFoto2 = 0, actualizarFoto3 = 0, actualizarComentario = 0;
        private IDatos idatos;
        string concepto = "", descripcion = "",encajas="";
        double importe = 0;
        int fila = 0,id=0;

        string rutaOrigen = "", rutaFoto = "",rutaOrigen2="",rutaOrigen3="",rutaDestino2="",rutaDestino3="";
        string nombre = "",comentario ="",sucursal,nombreFoto,usuario ="",nombreFoto2="",nombreFoto3="",rutaFoto2="",rutaFoto3="",nombre2="",nombre3="",ticket="",clave="";

       
        DateTime fecha;

        bool hayDispositivo = false;

        private VideoCaptureDevice cam = new VideoCaptureDevice();//capturar video
        private FilterInfoCollection MiDispositivos = null;//detectar los dispositivos que se encuentren
        private VideoCaptureDevice MiWebCam;//verirfica si la camara está activa

        #region NO SE UTILIZAN
        private void TB_detalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void TB_comentario_tienda_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void LB_fecha_Click(object sender, EventArgs e)
        {

        }

        private void LB_importe_Click(object sender, EventArgs e)
        {

        }

        private void CB_camaras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TomarFoto2();
            CerrarWebCam();
            button1.BackColor = Color.LightGray;
            button1.ForeColor = Color.Black;
            BT_foto.Enabled = false;
            BT_foto2.Enabled = false;
            BT_foto3.Enabled = false;
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TomarFoto3();
            CerrarWebCam();
            button1.BackColor = Color.LightGray;
            button1.ForeColor = Color.Black;
            BT_foto.Enabled = false;
            BT_foto2.Enabled = false;
            BT_foto3.Enabled = false;
            button1.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LB_descripcion_Click(object sender, EventArgs e)
        {

        }

        private void LB_concepto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion


       

        public AgregarFotoEncCajas(IDatos _idatos,string concepto,string descripcion,double importe,int fila,string comentario,string foto,string sucursal,DateTime fecha,int id,string nombreFoto,
            string usuario,string rutaFoto2,string nombreFoto2,string rutaFoto3,string nombreFoto3,string ticket,string encajas,string clave)
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
            this.encajas = encajas;
            this.clave = clave;
       

            InitializeComponent();
        }

       
        //boton foto3
        private void button2_Click(object sender, EventArgs e)
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

        //boton foto2
        private void button1_Click(object sender, EventArgs e)
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

        private void BT_foto_Click(object sender, EventArgs e)
        {

            
            TomarFoto1();
            CerrarWebCam();
            button1.BackColor = Color.LightGray;
            button1.ForeColor = Color.Black;
            BT_foto.Enabled = false;
            BT_foto2.Enabled = false;
            BT_foto3.Enabled = false;
            button1.Enabled = true;
        }

        private void TB_cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            string ruta = RutaFoto(sucursal);


            if (abrirImagen.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = abrirImagen.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                pictureBox1.Tag = abrirImagen.FileName;
                rutaOrigen = pictureBox1.Tag.ToString();
                nombre = Path.GetFileName(pictureBox1.Tag.ToString());
                rutaFoto = ruta + nombre;
            }
        }

   



        public string RutaServidor(string sucursal)
        {
            string ruta = "";

            if (sucursal.Equals("VALLARTA"))
            {
                ruta = @"\\192.168.5.2\Users\Administrador.WIN-SJDEC013JTB\Documents\imgTickets\";
            }
            else if(sucursal.Equals("RENA"))
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
            //string ruta = "";

            //if (sucursal.Equals("VALLARTA"))
            //{
            //    ruta = @"\\\\192.168.1.2\\Users\\Administrador.WIN-SJDEC013JTB\\Documents\\imgTickets\\";
            //}
            //else if (sucursal.Equals("RENA"))
            //{
            //    ruta = @"\\\\192.168.2.2\\Users\\Administrador.WIN-1E300DIGI8A\\Documents\\imgTickets\\";
            //}
            //else if (sucursal.Equals("VELAZQUEZ"))
            //{
            //    ruta = @"\\\\192.168.4.2\\Users\\Administrador.WIN-EFLLK2MJD9S\\Documents\\imgTickets\\";
            //}
            //else if (sucursal.Equals("COLOSO"))
            //{
            //    ruta = @"\\\\192.168.3.2\\Users\\Administrador.WIN-KP12TVSM78R\\Documents\\imgTickets\\";
            //}
            //else
            //{

            //}
            string ruta = "";

            if (sucursal.Equals("VALLARTA"))
            {
                ruta = @"\\\\\\\\192.168.5.2\\\\Users\\\\Administrador.WIN-SJDEC013JTB\\\\Documents\\\\imgTickets\\\\";
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



        private void BT_guardar_Click(object sender, EventArgs e)
        {
            if (TB_detalle.Text.Equals(""))
            {
                MessageBox.Show("Captura la descripción detallada del gasto");
            }
            else
            {
                string comentario = "";

                GastosController gc = new GastosController();
                bool respuesta = gc.ExisteGasto(id, sucursal);


                if (respuesta == true)
                {

                    string comentarioGuardado = comentario;
                    try
                    {
                        if (nombre.Equals(""))
                        {
                            nombre = nombreFoto;//nombreFoto var global

                        }

                        if (!rutaOrigen.Equals(""))
                        {

                            File.Copy(rutaOrigen, rutaFoto, true);
                            //foto = rutaDestino + nombre;
                            actualizarFoto1 = 1;
                        }

                        if (!rutaFoto.Equals(""))
                        {
                            string ruta = RutaFoto(sucursal);
                            //rutaDestino = ruta + nombre;
                            //rutaFoto = RutaFoto(sucursal);
                        }


                        if (nombre2.Equals(""))
                        {
                            nombre2 = nombreFoto2;
                        }

                        if (!rutaOrigen2.Equals(""))
                        {

                            File.Copy(rutaOrigen2, rutaFoto2, true);
                            //  foto = rutaDestino + nombre;
                            actualizarFoto2 = 1;

                        }

                        if (!rutaDestino2.Equals(""))
                        {
                            string ruta = RutaFoto(sucursal);

                            rutaDestino2 = ruta + nombre2;
                            //rutaFoto2 = RutaFoto(sucursal);
                        }
                        if (nombre3.Equals(""))
                        {
                            nombre3 = nombreFoto3;
                        }

                        if (!rutaOrigen3.Equals(""))
                        {

                            File.Copy(rutaOrigen3, rutaFoto3, true);
                            actualizarFoto3 = 1;


                        }

                        if (!rutaDestino3.Equals(""))
                        {
                            string ruta = RutaFoto(sucursal);
                            rutaDestino3 = ruta + nombre3;
                            //rutaFoto3 = RutaFoto(sucursal);
                        }

                        if (comentarioGuardado.Equals(TB_detalle.Text))
                        {
                            comentario = comentarioGuardado;
                        }
                        else
                        {
                            comentario = TB_detalle.Text;
                            actualizarComentario = 1;
                        }
                       


                        gc.Actualizar(actualizarFoto1,actualizarFoto2,actualizarFoto3,actualizarComentario,id, TB_detalle.Text, rutaFoto, nombre, sucursal, rutaFoto2, nombre2, rutaFoto3, nombre3);


                        idatos.DatosGastoEncCajas(comentario, rutaFoto, fila, nombre, id, rutaFoto2, nombre2, rutaFoto3, nombre3);
                        this.Close();
                        MessageBox.Show("Gasto actualizado");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al actualizar gasto: " + ex);
                    }



                }
                else
                {
                    try
                    {


                        //CrearCarpetasGastos();// si la carpeta imgGastos no existe, la crea
                        comentario = TB_detalle.Text;

                        try
                        {


                            if (nombre.Equals(""))
                            {
                                nombre = nombreFoto;
                            }
                            if (!rutaOrigen.Equals(""))
                            {
                                File.Copy(rutaOrigen, rutaFoto, true);
                            }
                            else
                            {
                                rutaFoto = "";
                            }



                            if (nombre2.Equals(""))
                            {
                                nombre2 = nombreFoto2;
                            }

                            if (!rutaOrigen2.Equals(""))
                            {

                                File.Copy(rutaOrigen2, rutaFoto2, true);


                            }
                            else
                            {
                                rutaDestino2 = "";
                            }

                            if (nombre3.Equals(""))
                            {
                                nombre3 = nombreFoto3;
                            }

                            if (!rutaOrigen3.Equals(""))
                            {

                                File.Copy(rutaOrigen3, rutaFoto3, true);

                            }
                            else
                            {
                                rutaDestino3 = "";
                            }



                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);

                        }

                        var gasto = new Gasto()
                        {

                            Concepto = concepto,
                            Descripcion = descripcion,
                            Importe = importe,
                            Detalle = comentario,
                            RutaFoto = rutaFoto,
                            NombreFoto = nombre,
                            RutaFoto2 = rutaFoto2,
                            NombreFoto2 = nombre2,
                            RutaFoto3 = rutaFoto3,
                            NombreFoto3 = nombre3,
                            Ticket = ticket


                        };
                        if (rutaFoto.Equals("") && rutaFoto2.Equals("") && rutaFoto3.Equals(""))
                        {
                            this.Close();
                        }
                        else
                        {
                            gc.GuardarGastos(gasto, sucursal, fecha, usuario, encajas, clave);
                            int id = gc.ObtenerId(sucursal);
                            // idatos.DatosGastoEncCajas(comentario, rutaDestino + nombre, fila, nombre,id);
                            idatos.DatosGastoEncCajas(comentario, rutaFoto, fila, nombre, id, rutaFoto2, nombre2, rutaFoto3, nombre3);

                            MessageBox.Show("Se ha guardado el gasto");
                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al guardar gasto: " + ex);
                    }

                    CerrarWebCam();
                    GC.Collect(GC.MaxGeneration);
                    //GC.Collect();
                    //GC.WaitForPendingFinalizers();
                }


                //Elimina la foto guardada temporalmente en la carpeta imgTickets
                for (int i = 0; i < fotos.Count; i++)
                {
                    System.IO.File.Delete("imgTickets\\" + fotos[i].ToString() + ".jpeg");
                }
            }
             
            
        }

        private void AgregarFotoEncCajas_Load(object sender, EventArgs e)
        {
            GC.Collect(GC.MaxGeneration);
            LB_concepto.Text = concepto;
            LB_descripcion.Text = descripcion;
            LB_importe.Text = importe.ToString("C2");
            LB_fecha.Text = fecha.ToString("yyyy-MM-dd");
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

            this.FormClosing += new FormClosingEventHandler(Cerrar);
            CargaDispositivo();
            BT_foto.Enabled = false;
            BT_foto2.Enabled = false;
            BT_foto3.Enabled = false;

        }

        //Iniciar cámara
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Color.DodgerBlue;
            button1.ForeColor = Color.White;
            BT_foto.Enabled = true;
            BT_foto2.Enabled = true;
            BT_foto3.Enabled = true;
            TB_cargar.Enabled = false;
            BT_cargar2.Enabled = false;
            BT_cargar3.Enabled = false;
            CapturarFoto();
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
           
            TimeSpan ts = new TimeSpan(0,0,0,0,(int)oSW.ElapsedMilliseconds);
           
            this.LB_contador.Text = ts.Seconds.ToString();

            if (ts.Seconds==20)
            {
                CerrarWebCam();
                GC.Collect(GC.MaxGeneration);
                button1.BackColor = Color.LightGray;
                button1.ForeColor = Color.Black;
                BT_foto.Enabled = false;
                BT_foto2.Enabled = false;
                BT_foto3.Enabled = false;
                this.timer1.Enabled = false;
                timer1.Stop();
                oSW.Reset();
                button1.Enabled = true;
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
            pictureBox0.SizeMode = PictureBoxSizeMode.StretchImage;
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
                string ruta = RutaFoto(sucursal);
                Bitmap bitmap = (Bitmap)pictureBox0.Image;
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = bitmap;
                //pictureBox1.Image = pictureBox0.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Tag = abrirImagen.FileName;
                rutaOrigen = pictureBox1.Tag.ToString();
                nombre = Path.GetFileName(pictureBox1.Tag.ToString());
                rutaFoto = rutaLocal;
                GuardarImagen(pictureBox1.Image,true,false,false);
                
            }
            this.timer1.Enabled = false;
            timer1.Stop();
            oSW.Reset();
            this.LB_contador.Text = "0";

            CerrarWebCam();
            GC.Collect(GC.MaxGeneration);
            TB_cargar.Enabled = true;
            BT_cargar2.Enabled = true;
            BT_cargar3.Enabled = true;
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
                string ruta = RutaFoto(sucursal);
                Bitmap bitmap = (Bitmap)pictureBox0.Image;
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox2.Image = bitmap;
                //pictureBox2.Image = pictureBox0.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Tag = abrirImagen.FileName;
                rutaOrigen2 = pictureBox2.Tag.ToString();
                nombre2 = Path.GetFileName(pictureBox2.Tag.ToString());
                rutaFoto2 = rutaLocal;
                GuardarImagen(pictureBox2.Image,false,true,false);
            }
            this.timer1.Enabled = false;
            timer1.Stop();
            oSW.Reset();
            this.LB_contador.Text = "0";
            CerrarWebCam();
            GC.Collect(GC.MaxGeneration);
            TB_cargar.Enabled = true;
            BT_cargar2.Enabled = true;
            BT_cargar3.Enabled = true;
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

            string rutaLocal = "imgTickets\\" + nombreFoto;
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
            TB_cargar.Enabled = true;
            BT_cargar2.Enabled = true;
            BT_cargar3.Enabled = true;
        }

        ArrayList fotos = new ArrayList();
        public void GuardarImagen(Image img,bool img1,bool img2,bool img3)
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
            string time = año.ToString()+ mes.ToString() + dia.ToString() + hora.ToString() + minutos.ToString() + segundos.ToString() + miliseg.ToString();
            string nombreFoto = "imagen" + time;
            //SaveFileDialog Guardar = new SaveFileDialog();
            //Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            Image Imagen = img;
            //Guardar.ShowDialog();
            //string nombre = Path.GetFileName(Guardar.FileName);
            //string ruta = Guardar.FileName;
            //Imagen.Save(Guardar.FileName);
            string eliminarImagen = "";
            if (img1==true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto = nombreFoto;
                string ruta = RutaFoto(sucursal);
                rutaFoto = ruta + "\\" + nombreFoto;
                eliminarImagen = rutaOrigen;
                fotos.Add(nombreFoto);
            }else if(img2==true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen2 = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto2 = nombreFoto;
                string ruta = RutaFoto(sucursal);
                rutaFoto2 = ruta + "\\" + nombreFoto;
                eliminarImagen = rutaOrigen2;
                fotos.Add(nombreFoto2);
            }
            else if(img3==true)
            {
                Imagen.Save("ImgTickets\\" + nombreFoto + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
                rutaOrigen3 = "ImgTickets\\" + nombreFoto + ".jpeg";
                this.nombreFoto3 = nombreFoto;
                string ruta = RutaFoto(sucursal);
                rutaFoto3 = ruta + "\\" + nombreFoto;
                eliminarImagen = rutaOrigen3;
                fotos.Add(nombreFoto3);
            }

           
        }
    }
}
