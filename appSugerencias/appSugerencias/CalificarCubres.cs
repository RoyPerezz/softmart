using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class CalificarCubres : Form
    {
        public CalificarCubres()
        {
            InitializeComponent();
        }

       



        private void CalificarCubreGerente_Load(object sender, EventArgs e)
        {
        

            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT nombre FROM rd_registro_jefes WHERE puesto ='CUBRE GERENTE'";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_cubreGerente.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer el nombre del cubre de gerente "+ex);
            }

        }



        const int DEFICIENTE = 0; const int INFERIOR = 20; const int MEDIO_INFERIOR = 40; const int MEDIO_SUPERIOR = 60; const int SUPERIOR = 80; const int MUY_SUPERIOR = 100;

        private void CB_areaLimpia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
int areaLimpia = DEFICIENTE;

            if (CB_areaLimpia.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_areaLimpia.Text = Convert.ToString(areaLimpia);
            }


            if (CB_areaLimpia.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_areaLimpia.Text = Convert.ToString(areaLimpia = INFERIOR);
            }

            if (CB_areaLimpia.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_areaLimpia.Text = Convert.ToString(areaLimpia = MEDIO_INFERIOR);
            }

            if (CB_areaLimpia.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_areaLimpia.Text = Convert.ToString(areaLimpia = MEDIO_SUPERIOR);
            }

            if (CB_areaLimpia.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_areaLimpia.Text = Convert.ToString(areaLimpia = SUPERIOR);
            }

            if (CB_areaLimpia.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_areaLimpia.Text = Convert.ToString(areaLimpia = MUY_SUPERIOR);
            }
        }

        private void CB_preciosExhibidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int preciosExhibidos = DEFICIENTE;

            if (CB_preciosExhibidos.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_preciosExhibidos.Text = Convert.ToString(preciosExhibidos);
            }

            if (CB_preciosExhibidos.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_preciosExhibidos.Text = Convert.ToString(preciosExhibidos = INFERIOR);
            }

            if (CB_preciosExhibidos.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_preciosExhibidos.Text = Convert.ToString(preciosExhibidos = MEDIO_INFERIOR);
            }

            if (CB_preciosExhibidos.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_preciosExhibidos.Text = Convert.ToString(preciosExhibidos = MEDIO_SUPERIOR);
            }

            if (CB_preciosExhibidos.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_preciosExhibidos.Text = Convert.ToString(preciosExhibidos = SUPERIOR);
            }

            if (CB_preciosExhibidos.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_preciosExhibidos.Text = Convert.ToString(preciosExhibidos = MUY_SUPERIOR);
            }
        }

        private void CB_preciosOfertas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int preciosOFertas = DEFICIENTE;

            if(CB_preciosOfertas.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_preciosOfertas.Text = Convert.ToString(preciosOFertas);
            }

            if (CB_preciosOfertas.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_preciosOfertas.Text = Convert.ToString(preciosOFertas=INFERIOR);
            }

            if (CB_preciosOfertas.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_preciosOfertas.Text = Convert.ToString(preciosOFertas = MEDIO_INFERIOR);
            }

            if (CB_preciosOfertas.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_preciosOfertas.Text = Convert.ToString(preciosOFertas = MEDIO_SUPERIOR);
            }

            if (CB_preciosOfertas.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_preciosOfertas.Text = Convert.ToString(preciosOFertas = SUPERIOR);
            }

            if (CB_preciosOfertas.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_preciosOfertas.Text = Convert.ToString(preciosOFertas = MUY_SUPERIOR);
            }
        }

        private void CB_exhibicionProds_SelectedIndexChanged(object sender, EventArgs e)
        {
            int exhibicionProds = DEFICIENTE;

            if (CB_exhibicionProds.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_exhibicionProds.Text = Convert.ToString(exhibicionProds);
            }

            if (CB_exhibicionProds.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_exhibicionProds.Text = Convert.ToString(exhibicionProds =  INFERIOR);
            }

            if (CB_exhibicionProds.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_exhibicionProds.Text = Convert.ToString(exhibicionProds = MEDIO_INFERIOR);
            }

            if (CB_exhibicionProds.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_exhibicionProds.Text = Convert.ToString(exhibicionProds = MEDIO_SUPERIOR);
            }

            if (CB_exhibicionProds.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_exhibicionProds.Text = Convert.ToString(exhibicionProds = SUPERIOR);
            }

            if (CB_exhibicionProds.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_exhibicionProds.Text = Convert.ToString(exhibicionProds = MUY_SUPERIOR);
            }
        }

        private void CB_anaqueles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int anaqueles = DEFICIENTE;

            if (CB_anaqueles.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_anaqueles.Text = Convert.ToString(anaqueles);
            }

            if (CB_anaqueles.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(anaqueles = INFERIOR);
            }

            if (CB_anaqueles.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(anaqueles = MEDIO_INFERIOR);
            }

            if (CB_anaqueles.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(anaqueles = MEDIO_SUPERIOR);
            }

            if (CB_anaqueles.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(anaqueles = SUPERIOR);
            }

            if (CB_anaqueles.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(anaqueles = MUY_SUPERIOR);
            }
        }

        private void CB_formato_SelectedIndexChanged(object sender, EventArgs e)
        {
            int formato = DEFICIENTE;

            if (CB_formato.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_formato.Text = Convert.ToString(formato);
            }

            if (CB_formato.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_formato.Text = Convert.ToString(formato = INFERIOR);
            }

            if (CB_formato.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_formato.Text = Convert.ToString(formato = MEDIO_INFERIOR);
            }

            if (CB_formato.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_formato.Text = Convert.ToString(formato = MEDIO_SUPERIOR);
            }

            if (CB_formato.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_formato.Text = Convert.ToString(formato = SUPERIOR);
            }

            if (CB_formato.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_formato.Text = Convert.ToString(formato = MUY_SUPERIOR);
            }


        }

        private void CB_presentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int presentacion = DEFICIENTE;

            if(CB_presentacion.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_presentacion.Text = Convert.ToString(presentacion);

            }

            if (CB_presentacion.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(presentacion = INFERIOR);

            }

            if (CB_presentacion.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(MEDIO_INFERIOR);

            }

             if (CB_presentacion.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(MEDIO_SUPERIOR);

            }

            if (CB_presentacion.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(SUPERIOR);

            }

            if (CB_presentacion.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(MUY_SUPERIOR);

            }
        }

        private void CB_pendiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_pendiente.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_pendiente.Text = Convert.ToString(DEFICIENTE);
            }

            if (CB_pendiente.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(INFERIOR);
            }

            if (CB_pendiente.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(MEDIO_INFERIOR);
            }

            if (CB_pendiente.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(MEDIO_SUPERIOR);
            }

            if (CB_pendiente.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(SUPERIOR);
            }

            if (CB_pendiente.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(MUY_SUPERIOR);
            }
        }

        private void CB_mercDañada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_mercDañada.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_mercDañada.Text = Convert.ToString(DEFICIENTE);
            }

            if (CB_mercDañada.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_mercDañada.Text = Convert.ToString(INFERIOR);
            }

            if (CB_mercDañada.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_mercDañada.Text = Convert.ToString(MEDIO_INFERIOR);
            }

            if (CB_mercDañada.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_mercDañada.Text = Convert.ToString(MEDIO_SUPERIOR);
            }

            if (CB_mercDañada.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_mercDañada.Text = Convert.ToString(SUPERIOR);
            }

            if (CB_mercDañada.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_mercDañada.Text = Convert.ToString(MUY_SUPERIOR);
            }



        }



        public void Limpiar()
        {
            TB_areaLimpia.Text = "";
            TB_preciosExhibidos.Text = "";
            TB_preciosOfertas.Text = "";
            TB_exhibicionProds.Text = "";
            TB_anaqueles.Text = "";
            TB_formato.Text = "";
            TB_presentacion.Text = "";
            TB_pendiente.Text = "";
            TB_mercDañada.Text = "";

            CB_areaLimpia.SelectedIndex = -1;
            CB_preciosExhibidos.SelectedIndex = -1;
            CB_preciosOfertas.SelectedIndex = -1;
            CB_exhibicionProds.SelectedIndex = -1;
            CB_anaqueles.SelectedIndex = -1;
            CB_formato.SelectedIndex = -1;
            CB_presentacion.SelectedIndex = -1;
            CB_pendiente.SelectedIndex = -1;
            CB_mercDañada.SelectedIndex = -1;
        }


        //BOTON GUARDAR
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            int total = 0, area_limpia = 0, precios_exhibidos = 0, precios_oferta = 0, exhibicion_prods=0, anaqueles = 0, formato = 0, presentacion = 0, pendiente = 0, mercdanada = 0;
            area_limpia = Convert.ToInt32(TB_areaLimpia.Text);
            precios_exhibidos = Convert.ToInt32(TB_preciosExhibidos.Text);
            precios_oferta = Convert.ToInt32(TB_preciosOfertas.Text);
            exhibicion_prods = Convert.ToInt32(TB_exhibicionProds.Text);
            anaqueles = Convert.ToInt32(TB_anaqueles.Text);
            formato = Convert.ToInt32(TB_formato.Text);
            presentacion = Convert.ToInt32(TB_presentacion.Text);
            pendiente = Convert.ToInt32(TB_pendiente.Text);
            mercdanada = Convert.ToInt32(TB_mercDañada.Text);

            total = area_limpia + precios_exhibidos + precios_oferta + exhibicion_prods + anaqueles + formato + presentacion + pendiente + mercdanada;
            double promedio = total / 8;


            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "INSERT INTO rd_calif_cubre_gte(nombre,area_limpia,precios_exhibidos,precios_oferta,exhibicion_prods,anaqueles,formato,presentacion,pendiente,mercdanada,sucursal,inicio_semana,fin_semana,apoyo_semanal,total,promedio)" +
                    "VALUES(?nombre,?area_limpia,?precios_exhibidos,?precios_oferta,?exhibicion_prods,?anaqueles,?formato,?presentacion,?pendiente,?mercdanada,?sucursal,?inicio_semana,?fin_semana,?apoyo_semanal,?total,?promedio)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("?nombre", CB_cubreGerente.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?area_limpia", Convert.ToInt32(TB_areaLimpia.Text));
                cmd.Parameters.AddWithValue("?precios_exhibidos", Convert.ToInt32(TB_preciosExhibidos.Text));
                cmd.Parameters.AddWithValue("?precios_oferta", Convert.ToInt32(TB_preciosOfertas.Text));
                cmd.Parameters.AddWithValue("?exhibicion_prods", Convert.ToInt32(TB_exhibicionProds.Text));
                cmd.Parameters.AddWithValue("?anaqueles", Convert.ToInt32(TB_anaqueles.Text));
                cmd.Parameters.AddWithValue("?formato", Convert.ToInt32(TB_formato.Text));
                cmd.Parameters.AddWithValue("?presentacion", Convert.ToInt32(TB_presentacion.Text));
                cmd.Parameters.AddWithValue("?pendiente", Convert.ToInt32(TB_pendiente.Text));
                cmd.Parameters.AddWithValue("?mercdanada", Convert.ToInt32(TB_mercDañada.Text));
                cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?inicio_semana",inicio.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?fin_semana",fin.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?apoyo_semanal",800);
                cmd.Parameters.AddWithValue("?total", total);
                cmd.Parameters.AddWithValue("?promedio",promedio);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Calificación guardada");
                Limpiar();
                conexion.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calificar cubre gerente "+ex);
                
            }
        }
    }
}
