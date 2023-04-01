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
    public partial class CalificarJefeAlmacenCedis : Form
    {




        public CalificarJefeAlmacenCedis()
        {
            InitializeComponent();
        }


        #region VARIABLES
        int limpieza = 0, clave_descrip = 0, baños = 0, merc_pendiente = 0, pasillos = 0, empaques = 0, fuera_empaque = 0, devoluciones = 0, reparto_atrasado = 0;
        const int DEFICIENTE = 0; const int MEDIO_SUPERIOR = 60; const int SUPERIOR = 80;

       

        const int MUY_SUPERIOR = 100;

        

        const int INFERIOR = 20;

       

        const int MEDIO_INFERIOR = 40;

      
        #endregion

        #region METODOS DE LA CLASE        
        public void Limpiar()
        {
            TB_limpieza.Text = "";
            TB_clave_descrip.Text = "";
            TB_baños.Text = "";
            TB_merc_pendiente.Text = "";
            TB_pasillos.Text = "";
            TB_empaques.Text = "";
            TB_fuera_empaque.Text = "";
            TB_devoluciones.Text = "";
            TB_reparto.Text = "";

            CB_limpieza.SelectedIndex = -1;
            CB_clave_descrip.SelectedIndex = -1;
            CB_baños.SelectedIndex = -1;
            CB_merc_pendiente.SelectedIndex = -1;
            CB_pasillos.SelectedIndex = -1;
            CB_empaques.SelectedIndex = -1;
            CB_fuera_empaque.SelectedIndex = -1;
            CB_devoluciones.SelectedIndex = -1;
            CB_reparto.SelectedIndex = -1;
        }

       

        private void CalificarJefeAlmacenCedis_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT * FROM rd_registro_jefes WHERE puesto='JEFE ALMACEN CEDIS'";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CB_JefeAlmacenCedis.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer los nombres de los cubres: " + ex);
            }
        }

       
        #endregion

        #region BOTONES
        private void BT_calificar_Click(object sender, EventArgs e)
        {
            int promedio = (limpieza + clave_descrip + baños + merc_pendiente + pasillos + empaques + fuera_empaque + devoluciones + reparto_atrasado) / 9;

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "INSERT INTO rd_calif_cubre_jefealmacen(limpieza,clave_descrip,banios,merc_pendiente,pasillos,empaques,fuera_empaque,devoluciones,reparto_atrasado,cubre,inicio_semana,fin_semana,promedio,apoyo_semanal,sucursal)VALUES(?limpieza,?clave_descrip,?banios,?merc_pendiente,?pasillos,?empaques,?fuera_empaque,?devoluciones,?reparto_atrasado,?cubre,?inicio_semana,?fin_semana,?promedio,?apoyo_semanal,?sucursal)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("?limpieza", limpieza);
                cmd.Parameters.AddWithValue("?clave_descrip", clave_descrip);
                cmd.Parameters.AddWithValue("?banios", baños);
                cmd.Parameters.AddWithValue("?merc_pendiente", merc_pendiente);
                cmd.Parameters.AddWithValue("?pasillos", pasillos);
                cmd.Parameters.AddWithValue("?empaques", empaques);
                cmd.Parameters.AddWithValue("?fuera_empaque", fuera_empaque);
                cmd.Parameters.AddWithValue("?devoluciones", devoluciones);
                cmd.Parameters.AddWithValue("?reparto_atrasado", reparto_atrasado);
                cmd.Parameters.AddWithValue("?cubre", CB_JefeAlmacenCedis.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?inicio_semana", inicio.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?fin_semana", fin.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?promedio", promedio);
                cmd.Parameters.AddWithValue("?apoyo_semanal", 1000);
                cmd.Parameters.AddWithValue("?sucursal", "CEDIS");
                cmd.ExecuteNonQuery();

                MessageBox.Show("Calificacion Guardada Correctamente");
                conexion.Close();
                Limpiar();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al insertar la calificacion: " + ex);
            }
        }

        
        #endregion

        #region EVENTOS

        private void CB_limpieza_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_limpieza.SelectedItem.Equals("DEFICIENTE"))
                {
                    TB_limpieza.Text = Convert.ToString(DEFICIENTE);
                    limpieza = DEFICIENTE;
                }

                if (CB_limpieza.SelectedItem.Equals("INFERIOR"))
                {
                    TB_limpieza.Text = Convert.ToString(INFERIOR);
                    limpieza = INFERIOR;
                }

                if (CB_limpieza.SelectedItem.Equals("MEDIO INFERIOR"))
                {
                    TB_limpieza.Text = Convert.ToString(MEDIO_INFERIOR);
                    limpieza = MEDIO_INFERIOR;
                }

                if (CB_limpieza.SelectedItem.Equals("MEDIO SUPERIOR"))
                {
                    TB_limpieza.Text = Convert.ToString(MEDIO_SUPERIOR);
                    limpieza = MEDIO_SUPERIOR;
                }

                if (CB_limpieza.SelectedItem.Equals("SUPERIOR"))
                {
                    TB_limpieza.Text = Convert.ToString(SUPERIOR);
                    limpieza = SUPERIOR;
                }

                if (CB_limpieza.SelectedItem.Equals("MUY SUPERIOR"))
                {
                    TB_limpieza.Text = Convert.ToString(MUY_SUPERIOR);
                    limpieza = MUY_SUPERIOR;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }

        private void CB_clave_descrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_clave_descrip.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_clave_descrip.Text = Convert.ToString(DEFICIENTE);
                    clave_descrip = DEFICIENTE;
                }

                if (CB_clave_descrip.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_clave_descrip.Text = Convert.ToString(INFERIOR);
                    clave_descrip = INFERIOR;
                }

                if (CB_clave_descrip.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_clave_descrip.Text = Convert.ToString(MEDIO_INFERIOR);
                    clave_descrip = MEDIO_INFERIOR;
                }

                if (CB_clave_descrip.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_clave_descrip.Text = Convert.ToString(MEDIO_SUPERIOR);
                    clave_descrip = MEDIO_SUPERIOR;
                }

                if (CB_clave_descrip.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_clave_descrip.Text = Convert.ToString(SUPERIOR);
                    clave_descrip = SUPERIOR;
                }

                if (CB_clave_descrip.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_clave_descrip.Text = Convert.ToString(MUY_SUPERIOR);
                    clave_descrip = MUY_SUPERIOR;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

            }
        }

        private void CB_baños_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_baños.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_baños.Text = Convert.ToString(DEFICIENTE);
                    baños = DEFICIENTE;
                }

                if (CB_baños.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_baños.Text = Convert.ToString(INFERIOR);
                    baños = INFERIOR;
                }


                if (CB_baños.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_baños.Text = Convert.ToString(MEDIO_INFERIOR);
                    baños = MEDIO_INFERIOR;
                }

                if (CB_baños.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_baños.Text = Convert.ToString(MEDIO_SUPERIOR);
                    baños = MEDIO_SUPERIOR;
                }

                if (CB_baños.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_baños.Text = Convert.ToString(SUPERIOR);
                    baños = SUPERIOR;
                }

                if (CB_baños.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_baños.Text = Convert.ToString(MUY_SUPERIOR);
                    baños = MUY_SUPERIOR;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }

        private void CB_merc_pendiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_merc_pendiente.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_merc_pendiente.Text = Convert.ToString(DEFICIENTE);
                    merc_pendiente = DEFICIENTE;
                }


                if (CB_merc_pendiente.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_merc_pendiente.Text = Convert.ToString(INFERIOR);
                    merc_pendiente = INFERIOR;
                }

                if (CB_merc_pendiente.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_merc_pendiente.Text = Convert.ToString(MEDIO_INFERIOR);
                    merc_pendiente = MEDIO_INFERIOR;
                }

                if (CB_merc_pendiente.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_merc_pendiente.Text = Convert.ToString(MEDIO_SUPERIOR);
                    merc_pendiente = MEDIO_SUPERIOR;
                }

                if (CB_merc_pendiente.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_merc_pendiente.Text = Convert.ToString(SUPERIOR);
                    merc_pendiente = SUPERIOR;
                }

                if (CB_merc_pendiente.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_merc_pendiente.Text = Convert.ToString(MUY_SUPERIOR);
                    merc_pendiente = MUY_SUPERIOR;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }

        private void CB_pasillos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_pasillos.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_pasillos.Text = Convert.ToString(DEFICIENTE);
                    pasillos = DEFICIENTE;
                }

                if (CB_pasillos.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_pasillos.Text = Convert.ToString(INFERIOR);
                    pasillos = INFERIOR;
                }

                if (CB_pasillos.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_pasillos.Text = Convert.ToString(MEDIO_INFERIOR);
                    pasillos = MEDIO_INFERIOR;
                }

                if (CB_pasillos.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_pasillos.Text = Convert.ToString(MEDIO_SUPERIOR);
                    pasillos = MEDIO_SUPERIOR;
                }

                if (CB_pasillos.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_pasillos.Text = Convert.ToString(SUPERIOR);
                    pasillos = SUPERIOR;
                }

                if (CB_pasillos.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_pasillos.Text = Convert.ToString(MUY_SUPERIOR);
                    pasillos = MUY_SUPERIOR;
                }

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }

        private void CB_empaques_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_empaques.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_empaques.Text = Convert.ToString(DEFICIENTE);
                    empaques = DEFICIENTE;
                }

                if (CB_empaques.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_empaques.Text = Convert.ToString(INFERIOR);
                    empaques = INFERIOR;
                }

                if (CB_empaques.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_empaques.Text = Convert.ToString(MEDIO_INFERIOR);
                    empaques = MEDIO_INFERIOR;
                }


                if (CB_empaques.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_empaques.Text = Convert.ToString(SUPERIOR);
                    empaques = SUPERIOR;
                }

                if (CB_empaques.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_empaques.Text = Convert.ToString(MEDIO_SUPERIOR);
                    empaques = MEDIO_SUPERIOR;
                }

                if (CB_empaques.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_empaques.Text = Convert.ToString(MUY_SUPERIOR);
                    empaques = MUY_SUPERIOR;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }

        private void CB_fuera_empaque_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_fuera_empaque.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_fuera_empaque.Text = Convert.ToString(DEFICIENTE);
                    fuera_empaque = DEFICIENTE;
                }

                if (CB_fuera_empaque.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_fuera_empaque.Text = Convert.ToString(INFERIOR);
                    fuera_empaque = INFERIOR;
                }

                if (CB_fuera_empaque.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_fuera_empaque.Text = Convert.ToString(MEDIO_INFERIOR);
                    fuera_empaque = MEDIO_INFERIOR;
                }

                if (CB_fuera_empaque.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_fuera_empaque.Text = Convert.ToString(MEDIO_SUPERIOR);
                    fuera_empaque = MEDIO_SUPERIOR;
                }

                if (CB_fuera_empaque.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_fuera_empaque.Text = Convert.ToString(SUPERIOR);
                    fuera_empaque = SUPERIOR;
                }

                if (CB_fuera_empaque.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_fuera_empaque.Text = Convert.ToString(MUY_SUPERIOR);
                    fuera_empaque = MUY_SUPERIOR;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }

        private void CB_devoluciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_devoluciones.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_devoluciones.Text = Convert.ToString(DEFICIENTE);
                devoluciones = DEFICIENTE;
            }

            if (CB_devoluciones.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_devoluciones.Text = Convert.ToString(INFERIOR);
                devoluciones = INFERIOR;
            }

            if (CB_devoluciones.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_devoluciones.Text = Convert.ToString(MEDIO_INFERIOR);
                devoluciones = MEDIO_INFERIOR;
            }

            if (CB_devoluciones.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_devoluciones.Text = Convert.ToString(MEDIO_SUPERIOR);
                devoluciones = MEDIO_SUPERIOR;
            }

            if (CB_devoluciones.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_devoluciones.Text = Convert.ToString(SUPERIOR);
                devoluciones = SUPERIOR;
            }

            if (CB_devoluciones.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_devoluciones.Text = Convert.ToString(MUY_SUPERIOR);
                devoluciones = MUY_SUPERIOR;
            }
        }

        private void CB_reparto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_reparto.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                TB_reparto.Text = Convert.ToString(DEFICIENTE);
                reparto_atrasado = DEFICIENTE;
            }

            if (CB_reparto.SelectedItem.ToString().Equals("INFERIOR"))
            {
                TB_reparto.Text = Convert.ToString(INFERIOR);
                reparto_atrasado = INFERIOR;
            }

            if (CB_reparto.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                TB_reparto.Text = Convert.ToString(MEDIO_INFERIOR);
                reparto_atrasado = MEDIO_INFERIOR;
            }

            if (CB_reparto.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                TB_reparto.Text = Convert.ToString(MEDIO_SUPERIOR);
                reparto_atrasado = MEDIO_SUPERIOR;
            }

            if (CB_reparto.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                TB_reparto.Text = Convert.ToString(SUPERIOR);
                reparto_atrasado = SUPERIOR;
            }

            if (CB_reparto.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                TB_reparto.Text = Convert.ToString(MUY_SUPERIOR);
                reparto_atrasado = MUY_SUPERIOR;
            }
        }

        #endregion





    }
}
