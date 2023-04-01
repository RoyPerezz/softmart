using appSugerencias.Cajas.Cajeras.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Cajas.Enc_Cajas.Vista
{
    public partial class AmpliarFotoIncidenciaEtiqueta : Form
    {

        IncidenciaEtiqueta ie;
        public AmpliarFotoIncidenciaEtiqueta(IncidenciaEtiqueta ie)
        {
            this.ie = ie;
            InitializeComponent();
        }

        private void AmpliarFotoIncidenciaEtiqueta_Load(object sender, EventArgs e)
        {
            if (!ie.RutaFoto.Equals(""))
            {


                PB_imagen.Image = Image.FromFile(ie.RutaFoto);
                PB_imagen.SizeMode = PictureBoxSizeMode.StretchImage;



            }

        }
    }
}
