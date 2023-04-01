using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge;
using AForge.Video.DirectShow;

namespace appSugerencias
{
    public partial class WebCamPrueba : Form
    {
        public WebCamPrueba()
        {
            InitializeComponent();
        }

#pragma warning disable CS0414 // El campo 'WebCamPrueba.hayDispositivo' está asignado pero su valor nunca se usa
        bool hayDispositivo = false;
#pragma warning restore CS0414 // El campo 'WebCamPrueba.hayDispositivo' está asignado pero su valor nunca se usa
        private VideoCaptureDevice cam = new VideoCaptureDevice();//capturar video
        private FilterInfoCollection MiDispositivos = null;//detectar los dispositivos que se encuentren
        private VideoCaptureDevice MiWebCam;//verirfica si la camara está activa


        private void WebCamPrueba_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Cerrar);
            CargaDispositivo();
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
                for (int i = 0; i <MiDispositivos.Count; i++)
                {
                    comboBox1.Items.Add(MiDispositivos[i].Name.ToString());
                    comboBox1.Text = MiDispositivos[0].Name.ToString();
                }
            }
        }

        private void CapturarFoto()
        {
            int i = comboBox1.SelectedIndex;
            string nombreDispositivo = MiDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(nombreDispositivo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();
        }

        private void Capturando(object sender,NewFrameEventArgs e)
        {
            Bitmap f = (Bitmap)(e.Frame.Clone());
            pictureBox1.Image = f;
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void CerrarWebCam()
        {
            if (MiWebCam !=null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }

        private void TomarFoto()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                pictureBox2.Image = pictureBox1.Image;
                //pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                
            }
        }

        private void BT_iniciar_Click(object sender, EventArgs e)
        {
            CapturarFoto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TomarFoto();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
