using appSugerencias.Cajas.Cajeras.Controlador;
using appSugerencias.Cajas.Cajeras.Modelo;
using appSugerencias.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Cajas.Enc_Cajas.Vista
{
    public partial class AgregarFotoIncidenciaEtiqueta : Form
    {
        public IncidenciaEtiqueta ie;
        int id = 0;
        string rutaOrigen = "", rutaFoto = "", nombreFoto = "";
        bool bandera;
        public AgregarFotoIncidenciaEtiqueta(IncidenciaEtiqueta ie,bool bandera)
        {
            this.ie = ie;
            this.bandera = bandera;
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


        //ruta que se guarda en la bd
        public string RutaFoto(string sucursal)
        {
            string ruta = "";

            if (sucursal.Equals("VALLARTA"))
            {
                ruta = @"\\\\192.168.1.2\\Users\\Administrador.WIN-SJDEC013JTB\\Documents\\imgTickets\\";
            }
            else if (sucursal.Equals("RENA"))
            {
                ruta = @"\\\\192.168.2.2\\Users\\Administrador.WIN-1E300DIGI8A\\Documents\\imgTickets\\";
            }
            else if (sucursal.Equals("VELAZQUEZ"))
            {
                ruta = @"\\\\192.168.4.2\\Users\\Administrador.WIN-EFLLK2MJD9S\\Documents\\imgTickets\\";
            }
            else if (sucursal.Equals("COLOSO"))
            {
                ruta = @"\\\\192.168.3.2\\Users\\Administrador.WIN-KP12TVSM78R\\Documents\\imgTickets\\";
            }
            else
            {

            }



            return ruta;
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {

            string sucursal = "";
            if (nombreFoto.Equals(""))
            {
                nombreFoto = ie.NombreFoto;
            }

            if (!rutaOrigen.Equals(""))
            {

                File.Copy(rutaOrigen, rutaFoto, true);
                //foto = rutaDestino + nombre;

            }

            if (!rutaFoto.Equals(""))
            {
                string ruta = RutaFoto(sucursal);
                //rutaDestino = ruta + nombre;
                //rutaFoto = RutaFoto(sucursal);
            }

            IncidenciasEtiquetasController.GuardarFotoEtiqueta(rutaFoto,nombreFoto,id);
            MessageBox.Show("Se ha guardado la foto de la incidencia");
        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            IncidenciasEtiquetasController.EliminarIncidencia(id);
            MessageBox.Show("Se ha eliminado el registro");
            this.Close();
        }

        private void BT_ampliar_Click(object sender, EventArgs e)
        {


            AmpliarFotoIncidenciaEtiqueta afoto = new AmpliarFotoIncidenciaEtiqueta(ie);
            afoto.Show();
        }

        private void AgregarFotoIncidenciaEtiqueta_Load(object sender, EventArgs e)
        {
            id = ie.Id;
            TB_articulo.Text = ie.Articulo;
            TB_descripcion.Text = ie.Descripcion;
            TB_fecha.Text = ie.Fecha.ToString("yyyy-MM-dd");
            TB_usuario.Text = ie.Usuario;
            TB_caja.Text = ie.Caja;
            TB_incidencia.Text = ie.Incidencia;

            if (!ie.RutaFoto.Equals(""))
            {


                PB_foto.Image = Image.FromFile(ie.RutaFoto);
                PB_foto.SizeMode = PictureBoxSizeMode.StretchImage;



            }

            if (bandera == true)
            {
                BT_eliminar.Visible = true;
                BT_ampliar.Visible = false;
            }
            else
            {
                BT_eliminar.Visible = false;
                BT_ampliar.Visible = true;
            }

        }

        private void BT_cargar_foto_Click(object sender, EventArgs e)
        {
            string sucursal = Sucursal.NombreSucursalIP(BDConexicon.optieneIp());

            OpenFileDialog abrirImagen = new OpenFileDialog();
            string ruta = RutaFoto(sucursal);


            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                PB_foto.ImageLocation = abrirImagen.FileName;
                PB_foto.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                PB_foto.Tag = abrirImagen.FileName;
                rutaOrigen = PB_foto.Tag.ToString();
                nombreFoto = Path.GetFileName(PB_foto.Tag.ToString());
                rutaFoto = ruta + nombreFoto;
            }

        }
    }
}
