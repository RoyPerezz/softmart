using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class Lupa : Form
    {
        bool seguirMouse;
        public Lupa(bool seguirMouse)
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.seguirMouse = seguirMouse;
        }

        Graphics GraficoCaptura;
        Bitmap ImagenTemporal;
        Point frmMover;
        Boolean MoverMouse;
        int zoom = 2;
        private void Lupa_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ancho y alto de la imagen (picturebox)
            int AnchoImagen = pictureBox1.Width;
            int AltoImagen = pictureBox1.Height;

            //posicion mouse
            int mouseX = MousePosition.X;
            int mouseY = MousePosition.Y;

            //captura de pantalla
            ImagenTemporal = new Bitmap(AnchoImagen / zoom, AltoImagen / zoom,System.Drawing.Imaging.PixelFormat.Format64bppPArgb);
            GraficoCaptura = this.CreateGraphics();
            GraficoCaptura = Graphics.FromImage(ImagenTemporal);

            //copia exacta de pantalla
            GraficoCaptura.CopyFromScreen(mouseX-AnchoImagen/(zoom*2),mouseY-AltoImagen/(zoom*2),0,0,pictureBox1.Size);

            //aumentar el tamaño de la pantalla
            Bitmap nuevaImagen = new Bitmap(AnchoImagen,AltoImagen);
            GraficoCaptura = Graphics.FromImage(nuevaImagen);
            GraficoCaptura.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            GraficoCaptura.DrawImage(ImagenTemporal,new Rectangle(0,0,AnchoImagen,AltoImagen));
            pictureBox1.Image = nuevaImagen;

            //Forma circular de la lupa
            //Rectangle rect = new Rectangle(0,0,AnchoImagen,AltoImagen);
            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(rect);
            //pictureBox1.Region = new Region(path);
            ////forma circular al panel
            //Rectangle rectp = new Rectangle(0,0,panel1.Width,panel1.Height);
            //GraphicsPath pathp = new GraphicsPath();
            //pathp.AddEllipse(rectp);

            //panel1.Region = new Region(pathp);

            //lupa siga al mouse

            if (seguirMouse==true)
            {
                this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            }

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoverMouse)
            {
                Location = new Point(Cursor.Position.X - frmMover.X,Cursor.Position.Y-frmMover.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            frmMover = new Point(Cursor.Position.X -Location.X,Cursor.Position.Y - Location.Y);
            MoverMouse = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoverMouse = false;
        }

        private void Lupa_KeyDown(object sender, KeyEventArgs e)
        {
            //comando para modificar el zoom
            if ((e.KeyCode & Keys.Z)==Keys.Z)
            {
                zoom++;
            }

            if ((e.KeyCode & Keys.ControlKey)==Keys.ControlKey)
            {
                if (zoom>1)
                {
                    zoom--;
                }
            }

            if ((e.KeyCode & Keys.Escape) == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
