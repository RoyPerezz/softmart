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
    public partial class ImagenAmpliada : Form
    {
        Image imagen;
        int boton = 0;
        bool seguirMouse= false;
        public ImagenAmpliada(Image imagen,int boton)
        {
            this.imagen = imagen;
            this.boton = boton;
           
            InitializeComponent();
        }

        private void ImagenAmpliada_Load(object sender, EventArgs e)
        {
            if (boton == 3)
            {
                //pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                pictureBox1.Dock = DockStyle.Fill;
                seguirMouse = true;


            }
            pictureBox1.Image = imagen;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

           
           
        }

        private void BT_lupa_Click(object sender, EventArgs e)
        {
            Lupa lupa = new Lupa(seguirMouse);
            lupa.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
