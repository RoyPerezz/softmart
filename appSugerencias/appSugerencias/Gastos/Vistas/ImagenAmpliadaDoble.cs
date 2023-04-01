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
    public partial class ImagenAmpliadaDoble : Form
    {

        Image imagen1,imagen2;
#pragma warning disable CS0414 // El campo 'ImagenAmpliadaDoble.seguirMouse' está asignado pero su valor nunca se usa
        bool seguirMouse = false;
#pragma warning restore CS0414 // El campo 'ImagenAmpliadaDoble.seguirMouse' está asignado pero su valor nunca se usa
        public ImagenAmpliadaDoble(Image imagen1,Image imagen2)
        {
            this.imagen1 = imagen1;
            this.imagen2 = imagen2;
            InitializeComponent();
        }

        private void ImagenAmpliadaDoble_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imagen1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = imagen2;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BT_lupa_Click(object sender, EventArgs e)
        {
            Lupa lupa = new Lupa(false);
            lupa.Show();
        }
    }
}
