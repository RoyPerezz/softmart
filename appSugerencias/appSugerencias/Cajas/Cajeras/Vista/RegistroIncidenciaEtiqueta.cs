using appSugerencias.Cajas.Cajeras.Controlador;
using appSugerencias.Cajas.Cajeras.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Cajas.Cajeras.Vista
{
    public partial class RegistroIncidenciaEtiqueta : Form
    {

        string usuario = "",estacion="";
        public RegistroIncidenciaEtiqueta(string usuario,string estacion)
        {
            this.usuario = usuario;
            this.estacion = estacion;
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            string descripcion = IncidenciasEtiquetasController.BuscarArticuloExacto(TB_articulo.Text);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TB_descripcion.Text = "";
                CB_incidencia.Text = "";


                if (string.IsNullOrEmpty(descripcion) || descripcion.Equals(""))
                {
                    MessageBox.Show("No se encontró artículo con la clave que capturaste, revisa que la clave sea correcta.");
                }
                else
                {
                    TB_descripcion.Text = descripcion;
                }

               
            }
        }
        private void RegistroIncidenciaEtiqueta_Load(object sender, EventArgs e)
        {
            TB_usuario.Text = usuario;
            TB_caja.Text = estacion;

            List<IncidenciaEtiqueta> lista = IncidenciasEtiquetasController.BuscarIncidencias();

            foreach (var item in lista)
            {
                CB_incidencia.Items.Add(item.Incidencia);
            }
        }


        public void Limpiar()
        {
            TB_articulo.Text = "";
            TB_descripcion.Text = "";
            CB_incidencia.Text = "";
        }


        //Registra la incidencia
        private void button1_Click(object sender, EventArgs e)
        {
            if (TB_articulo.Text.Equals("") && TB_descripcion.Text.Equals("") && CB_incidencia.Text.Equals(""))
            {
                MessageBox.Show("Se deben llenar todos los campos para poder registrar la incidencia");
            }else if(TB_articulo.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la clave de un articulo");
            }
            else if (TB_descripcion.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la descripcion del articulo");
            }
            else if (CB_incidencia.Text.Equals(""))
            {
                MessageBox.Show("Ingresa la incidencia del articulo");
            }
            else
            {

                IncidenciaEtiqueta ie = new IncidenciaEtiqueta()
                {
                    Usuario = TB_usuario.Text,
                    Caja = TB_caja.Text,
                    Fecha = DT_fecha.Value,
                    Articulo = TB_articulo.Text,
                    Descripcion = TB_descripcion.Text,
                    Incidencia = CB_incidencia.SelectedItem.ToString(),
                    RutaFoto = "",
                    NombreFoto = "",

                    Estado = 0

                };

                IncidenciasEtiquetasController.Registrar(ie);
                MessageBox.Show("Se ha registrado la incidencia de la etiqueta.");
                Limpiar();
            }
        }

        private void TB_articulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {

                
                
                
                VistaAuxArticulos vaa = new VistaAuxArticulos(TB_articulo.Text);
                AddOwnedForm(vaa);
                vaa.Show();

            }
        }

        private void TB_articulo_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
