using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class CalificarCubreEncCajas : Form
    {
        public CalificarCubreEncCajas()
        {
            InitializeComponent();
        }


        private const int DEFICIENTE = 0, INFERIOR=20,MEDIO_INFERIOR=40,MEDIO_SUPERIOR=60,SUPERIOR=80,MUY_SUPERIOR=100;

        private int precios_exhibidos = 0, precios_oferta = 0, exhibicion_prods=0, mercancia_danada=0, anaqueles=0, formato=0,pendiente=0,presentacion=0;




       

        //BOTON CALIFICAR
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            string query = "INSERT INTO rd_calif_cubre_enc_cajas(precios_exhibidos,precios_oferta,exhibicion_prods,mercancia_danada,anaqueles,formato,presentacion,pendiente,fecha_inicio,fecha_fin,apoyo_semanal,promedio,descuento,total_pagar,sucursal,cubre)" +
                "VALUES(?precios_exhibidos,?precios_oferta,?exhibicion_prods,?mercancia_danada,?anaqueles,?formato,?presentacion,?pendiente,?fecha_inicio,?fecha_fin,?apoyo_semanal,?promedio,?descuento,?total_pagar,?sucursal,?cubre)";

            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query,conexion);

                cmd.Parameters.AddWithValue("?precios_exhibidos", precios_exhibidos);
                cmd.Parameters.AddWithValue("?precios_oferta", precios_oferta);
                cmd.Parameters.AddWithValue("?exhibicion_prods", exhibicion_prods);
                cmd.Parameters.AddWithValue("?mercancia_danada", mercancia_danada);
                cmd.Parameters.AddWithValue("?anaqueles", anaqueles);
                cmd.Parameters.AddWithValue("?formato", formato);
                cmd.Parameters.AddWithValue("?presentacion", presentacion);
                cmd.Parameters.AddWithValue("?pendiente", pendiente);
                cmd.Parameters.AddWithValue("?fecha_inicio", inicio.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?fecha_fin", fin.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?apoyo_semanal", 800);

                double prom = (precios_exhibidos + precios_oferta + exhibicion_prods + mercancia_danada + anaqueles + formato + presentacion + pendiente)/8;
                int total = precios_exhibidos + precios_oferta + exhibicion_prods + mercancia_danada + anaqueles + formato + presentacion + pendiente;
                int pagar = 800 -(800- total);
                int descuento = 800 - total;
                cmd.Parameters.AddWithValue("?promedio", prom);
                cmd.Parameters.AddWithValue("?descuento", descuento);
                cmd.Parameters.AddWithValue("?total_pagar", pagar);
                cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?cubre",CB_cubreEncCajas.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha calificado al cubre ");
                Limpiar();
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al calificar cubre "+ex);
            }
        }

        public void Limpiar()
        {
            TB_precios_ex.Text = "";
            TB_precios_oferta.Text = "";
            TB_exhibicion_prods.Text = "";
            TB_mercancia.Text = "";
            TB_anaqueles.Text = "";
            TB_formato.Text = "";
            TB_presentacion.Text = "";
            TB_pendiente.Text = "";

            CB_precios_ex.SelectedIndex = -1;
            CB_precios_oferta.SelectedIndex = -1;
            CB_exhibicion_prods.SelectedIndex = -1;
            CB_mercancia.SelectedIndex = -1;
            CB_anaqueles.SelectedIndex = -1;
            CB_formato.SelectedIndex = -1;
            CB_presentacion.SelectedIndex = -1;
            CB_pendiente.SelectedIndex = -1;
            
        }

       

        private void CB_precios_ex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_precios_ex.SelectedItem.Equals("DEFICIENTE"))
            {
                TB_precios_ex.Text = Convert.ToString(DEFICIENTE);
                precios_exhibidos = DEFICIENTE;
            }

            if (CB_precios_ex.SelectedItem.Equals("INFERIOR"))
            {
                TB_precios_ex.Text = Convert.ToString(INFERIOR);
                precios_exhibidos = INFERIOR;
            }

            if (CB_precios_ex.SelectedItem.Equals("MEDIO INFERIOR"))
            {
                TB_precios_ex.Text = Convert.ToString(MEDIO_INFERIOR);
                precios_exhibidos = MEDIO_INFERIOR;
            }

            if (CB_precios_ex.SelectedItem.Equals("MEDIO SUPERIOR"))
            {
                TB_precios_ex.Text = Convert.ToString(MEDIO_SUPERIOR);
                precios_exhibidos = MEDIO_SUPERIOR;
            }

            if (CB_precios_ex.SelectedItem.Equals("SUPERIOR"))
            {
                TB_precios_ex.Text = Convert.ToString(SUPERIOR);
                precios_exhibidos = SUPERIOR;
            }

            if (CB_precios_ex.SelectedItem.Equals("MUY SUPERIOR"))
            {
                TB_precios_ex.Text = Convert.ToString(MUY_SUPERIOR);
                precios_exhibidos = MUY_SUPERIOR;
            }
        }

        private void CB_precios_oferta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_precios_oferta.SelectedItem.Equals("DEFICIENTE"))
            {
                TB_precios_oferta.Text = Convert.ToString(DEFICIENTE);
                precios_oferta = DEFICIENTE;
            }

            if (CB_precios_oferta.SelectedItem.Equals("INFERIOR"))
            {
                TB_precios_oferta.Text = Convert.ToString(INFERIOR);
                precios_oferta = INFERIOR;
            }

            if (CB_precios_oferta.SelectedItem.Equals("MEDIO INFERIOR"))
            {
                TB_precios_oferta.Text = Convert.ToString(MEDIO_INFERIOR);
                precios_oferta = MEDIO_INFERIOR;
            }

            if (CB_precios_oferta.SelectedItem.Equals("MEDIO SUPERIOR"))
            {
                TB_precios_oferta.Text = Convert.ToString(MEDIO_SUPERIOR);
                precios_oferta = MEDIO_SUPERIOR;
            }

            if (CB_precios_oferta.SelectedItem.Equals("SUPERIOR"))
            {
                TB_precios_oferta.Text = Convert.ToString(SUPERIOR);
                precios_oferta = SUPERIOR;
            }

            if (CB_precios_oferta.SelectedItem.Equals("MUY SUPERIOR"))
            {
                TB_precios_oferta.Text = Convert.ToString(MUY_SUPERIOR);
                precios_oferta = MUY_SUPERIOR;
            }
        }

        private void CB_exhibicion_prods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_exhibicion_prods.SelectedItem.Equals("DEFICIENTE"))
            {
                TB_exhibicion_prods.Text = Convert.ToString(DEFICIENTE);
                exhibicion_prods = DEFICIENTE;
            }

            if (CB_exhibicion_prods.SelectedItem.Equals("INFERIOR"))
            {
                TB_exhibicion_prods.Text = Convert.ToString(INFERIOR);
                exhibicion_prods = INFERIOR;
            }

            if (CB_exhibicion_prods.SelectedItem.Equals("MEDIO INFERIOR"))
            {
                TB_exhibicion_prods.Text = Convert.ToString(MEDIO_INFERIOR);
                exhibicion_prods = MEDIO_INFERIOR;
            }

            if (CB_exhibicion_prods.SelectedItem.Equals("MEDIO SUPERIOR"))
            {
                TB_exhibicion_prods.Text = Convert.ToString(MEDIO_SUPERIOR);
                exhibicion_prods = MEDIO_SUPERIOR;
            }

            if (CB_exhibicion_prods.SelectedItem.Equals("SUPERIOR"))
            {
                TB_exhibicion_prods.Text = Convert.ToString(SUPERIOR);
                exhibicion_prods = SUPERIOR;
            }

            if (CB_exhibicion_prods.SelectedItem.Equals("MUY SUPERIOR"))
            {
                TB_exhibicion_prods.Text = Convert.ToString(MUY_SUPERIOR);
                exhibicion_prods = MUY_SUPERIOR;
            }
        }

        private void CB_mercancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_mercancia.SelectedItem.Equals("DEFICIENTE"))
            {
                TB_mercancia.Text = Convert.ToString(DEFICIENTE);
                mercancia_danada = DEFICIENTE;
            }

            if (CB_mercancia.SelectedItem.Equals("INFERIOR"))
            {
                TB_mercancia.Text = Convert.ToString(INFERIOR);
                mercancia_danada = INFERIOR;
            }

            if (CB_mercancia.SelectedItem.Equals("MEDIO INFERIOR"))
            {
                TB_mercancia.Text = Convert.ToString(MEDIO_INFERIOR);
                mercancia_danada = MEDIO_INFERIOR;
            }

            if (CB_mercancia.SelectedItem.Equals("MEDIO SUPERIOR"))
            {
                TB_mercancia.Text = Convert.ToString(MEDIO_SUPERIOR);
                mercancia_danada = MEDIO_SUPERIOR;
            }

            if (CB_mercancia.SelectedItem.Equals("SUPERIOR"))
            {
                TB_mercancia.Text = Convert.ToString(SUPERIOR);
                mercancia_danada = SUPERIOR;
            }

            if (CB_mercancia.SelectedItem.Equals("MUY SUPERIOR"))
            {
                TB_mercancia.Text = Convert.ToString(MUY_SUPERIOR);
                mercancia_danada = MUY_SUPERIOR;
            }
        }

        private void CB_anaqueles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_anaqueles.SelectedItem.Equals("DEFICIENTE"))
            {
                TB_anaqueles.Text = Convert.ToString(DEFICIENTE);
                anaqueles = DEFICIENTE;
            }

            if (CB_anaqueles.SelectedItem.Equals("INFERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(INFERIOR);
                anaqueles = INFERIOR;
            }

            if (CB_anaqueles.SelectedItem.Equals("MEDIO INFERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(MEDIO_INFERIOR);
                anaqueles = MEDIO_INFERIOR;
            }

            if (CB_anaqueles.SelectedItem.Equals("MEDIO SUPERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(MEDIO_SUPERIOR);
                anaqueles = MEDIO_SUPERIOR;
            }

            if (CB_anaqueles.SelectedItem.Equals("SUPERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(SUPERIOR);
                anaqueles = SUPERIOR;
            }

            if (CB_anaqueles.SelectedItem.Equals("MUY SUPERIOR"))
            {
                TB_anaqueles.Text = Convert.ToString(MUY_SUPERIOR);
                anaqueles = MUY_SUPERIOR;
            }
        }

        private void CB_formato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_formato.SelectedItem.Equals("DEFICIENTE"))
            {
                TB_formato.Text = Convert.ToString(DEFICIENTE);
                formato = DEFICIENTE;
            }

            if (CB_formato.SelectedItem.Equals("INFERIOR"))
            {
                TB_formato.Text = Convert.ToString(INFERIOR);
                formato = INFERIOR;
            }

            if (CB_formato.SelectedItem.Equals("MEDIO INFERIOR"))
            {
                TB_formato.Text = Convert.ToString(MEDIO_INFERIOR);
                formato = MEDIO_INFERIOR;
            }

            if (CB_formato.SelectedItem.Equals("MEDIO SUPERIOR"))
            {
                TB_formato.Text = Convert.ToString(MEDIO_SUPERIOR);
                formato = MEDIO_SUPERIOR;
            }

            if (CB_formato.SelectedItem.Equals("SUPERIOR"))
            {
                TB_formato.Text = Convert.ToString(SUPERIOR);
                formato = SUPERIOR;
            }

            if (CB_formato.SelectedItem.Equals("MUY SUPERIOR"))
            {
                TB_formato.Text = Convert.ToString(MUY_SUPERIOR);
                formato = MUY_SUPERIOR;
            }
        }

        private void CB_presentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_presentacion.SelectedItem.Equals("DEFICIENTE"))
            {
                TB_presentacion.Text = Convert.ToString(DEFICIENTE);
                presentacion = DEFICIENTE;
            }

            if (CB_presentacion.SelectedItem.Equals("INFERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(INFERIOR);
                presentacion = INFERIOR;
            }

            if (CB_presentacion.SelectedItem.Equals("MEDIO INFERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(MEDIO_INFERIOR);
                presentacion = MEDIO_INFERIOR;
            }

            if (CB_presentacion.SelectedItem.Equals("MEDIO SUPERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(MEDIO_SUPERIOR);
                presentacion = MEDIO_SUPERIOR;
            }

            if (CB_presentacion.SelectedItem.Equals("SUPERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(SUPERIOR);
                presentacion = SUPERIOR;
            }

            if (CB_presentacion.SelectedItem.Equals("MUY SUPERIOR"))
            {
                TB_presentacion.Text = Convert.ToString(MUY_SUPERIOR);
                presentacion = MUY_SUPERIOR;
            }
        }

        private void CB_pendiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_pendiente.SelectedItem.Equals("DEFICIENTE"))
            {
                TB_pendiente.Text = Convert.ToString(DEFICIENTE);
                pendiente = DEFICIENTE;
            }

            if (CB_pendiente.SelectedItem.Equals("INFERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(INFERIOR);
                pendiente = INFERIOR;
            }

            if (CB_pendiente.SelectedItem.Equals("MEDIO INFERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(MEDIO_INFERIOR);
                pendiente = MEDIO_INFERIOR;
            }

            if (CB_pendiente.SelectedItem.Equals("MEDIO SUPERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(MEDIO_SUPERIOR);
                pendiente = MEDIO_SUPERIOR;
            }

            if (CB_pendiente.SelectedItem.Equals("SUPERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(SUPERIOR);
                pendiente = SUPERIOR;
            }

            if (CB_pendiente.SelectedItem.Equals("MUY SUPERIOR"))
            {
                TB_pendiente.Text = Convert.ToString(MUY_SUPERIOR);
                pendiente = MUY_SUPERIOR;
            }
        }

        private void CalificarCubreEncCajas_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM rd_registro_jefes WHERE puesto='CUBRE ENC CAJAS'";

            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CB_cubreEncCajas.Items.Add(dr["nombre"].ToString());
                }

                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer los nombres de los cubres de enc de cajas "+ex);
            }
        }

    }
}
