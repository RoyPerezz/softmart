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
    public partial class CalifBodega : Form
    {
        public CalifBodega()
        {
            InitializeComponent();
        }

        //######################## VARIABLES GLOBALES ###################################
        const int DEFICIENTE = 0;
        const int INFERIOR = 20;
        const int MEDIO_INFERIOR = 40;
        const int SUPERIOR = 80;
        const int MEDIO_SUPERIOR = 60;
        const int MUY_SUPERIOR = 100;

        const double APOYO_AREA = 6;
        const double MERC_ESTANCADA = 6;
        const double LLEGADA_MERC = 12;
        const double REP_MERC = 1;
        const double EXIBICION_MERC = 12;

        double imagen = 0;
        double cajas = 0;
        double articulos = 0;
        double areas = 0;
        double mercSinEmpaque = 0;
        double mercOordenada = 0;
        double señalizacion = 0;
        double bañosLimpios = 0;
        double total = 0;
        double promedio = 0;
        double Tpagar = 0;
        double apoyoArea = 0;
        double mercEstancada = 0;
        double llegada_merc = 0;
        double repMerc = 0;
        double exibicionMerc = 0;
        double precioDescarga = 15.0;
      

        //##############################################################################
        public void Empleados()
        {
            MySqlConnection con = BDConexicon.conectar();
            string query = "SELECT nombre FROM rd_alta_empbodega";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_empleado.Items.Add(dr["nombre"].ToString());
            }
            dr.Close();
            con.Close();
        }


        public void CalculoCalificacion()
        {
            //****** calif de imagen ******************************
            if (CB_imagen.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                imagen = DEFICIENTE;

            }

            if (CB_imagen.SelectedItem.ToString().Equals("INFERIOR"))
            {
                imagen = INFERIOR;
            }

            if (CB_imagen.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                imagen = MEDIO_INFERIOR;
            }

            if (CB_imagen.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                imagen = MEDIO_SUPERIOR;
            }

            if (CB_imagen.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                imagen = SUPERIOR;
            }

            if (CB_imagen.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                imagen = MUY_SUPERIOR;
            }
            //******************************************************

            //****** calif de CAJAS CON CLAVE Y DESCRIPCION ******************************
            if (CB_cajas.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                cajas = DEFICIENTE;
            }

            if (CB_cajas.SelectedItem.ToString().Equals("INFERIOR"))
            {
                cajas = INFERIOR;
            }

            if (CB_cajas.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                cajas = MEDIO_INFERIOR;
            }

            if (CB_cajas.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                cajas = MEDIO_SUPERIOR;
            }

            if (CB_cajas.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                cajas = SUPERIOR;
            }

            if (CB_cajas.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                cajas = MUY_SUPERIOR;
            }
            //******************************************************

            //****** calif de ARTICULOS VISIBLES CON CLAVE Y DESCRI. ******************************
            if (CB_articulos.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                articulos = DEFICIENTE;
            }

            if (CB_articulos.SelectedItem.ToString().Equals("INFERIOR"))
            {
                articulos = INFERIOR;
            }

            if (CB_articulos.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                articulos = MEDIO_INFERIOR;
            }

            if (CB_articulos.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                articulos = MEDIO_SUPERIOR;
            }

            if (CB_articulos.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                articulos = SUPERIOR;
            }

            if (CB_articulos.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                articulos = MUY_SUPERIOR;
            }
            //******************************************************

            //****** calif de AREAS, ANAQUELES Y PASILLOS LIMPIOS Y DESP. ******************************
            if (CB_areas.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                areas = DEFICIENTE;
            }

            if (CB_areas.SelectedItem.ToString().Equals("INFERIOR"))
            {
                areas = INFERIOR;
            }

            if (CB_areas.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                areas = MEDIO_INFERIOR;
            }

            if (CB_areas.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                areas = MEDIO_SUPERIOR;
            }

            if (CB_areas.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                areas = SUPERIOR;
            }

            if (CB_areas.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                areas = MUY_SUPERIOR;
            }
            //******************************************************

            //****** calif de MERCANCIA FUERA DE SU EMPAQUE ******************************
            if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                mercSinEmpaque = DEFICIENTE;
            }

            if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("INFERIOR"))
            {
                mercSinEmpaque = INFERIOR;
            }

            if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                mercSinEmpaque = MEDIO_INFERIOR;
            }

            if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                mercSinEmpaque = MEDIO_SUPERIOR;
            }

            if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                mercSinEmpaque = SUPERIOR;
            }

            if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                mercSinEmpaque = MUY_SUPERIOR;
            }
            //******************************************************

            //****** calif de MERCANCIA ORDENADA POR AREAS ******************************
            if (CB_merc_ordenada.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                mercOordenada = DEFICIENTE;
            }

            if (CB_merc_ordenada.SelectedItem.ToString().Equals("INFERIOR"))
            {
                mercOordenada = INFERIOR;
            }

            if (CB_merc_ordenada.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                mercOordenada = MEDIO_INFERIOR;
            }

            if (CB_merc_ordenada.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                mercOordenada = MEDIO_SUPERIOR;
            }

            if (CB_merc_ordenada.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                mercOordenada = SUPERIOR;
            }

            if (CB_merc_ordenada.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                mercOordenada = MUY_SUPERIOR;
            }
            //******************************************************

            //****** calif de BODEGAS Y ANAQUELES SEÑALIZADOS ******************************
            if (CB_señalizacion.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                señalizacion = DEFICIENTE;
            }

            if (CB_señalizacion.SelectedItem.ToString().Equals("INFERIOR"))
            {
                señalizacion = INFERIOR;
            }

            if (CB_señalizacion.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                señalizacion = MEDIO_INFERIOR;
            }

            if (CB_señalizacion.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                señalizacion = MEDIO_SUPERIOR;
            }

            if (CB_señalizacion.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                señalizacion = SUPERIOR;
            }

            if (CB_señalizacion.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                señalizacion = MUY_SUPERIOR;
            }
            //******************************************************

            //****** calif de BAÑOS LIMPIOS******************************
            if (CB_baños_limpios.SelectedItem.ToString().Equals("DEFICIENTE"))
            {
                bañosLimpios = DEFICIENTE;
            }

            if (CB_baños_limpios.SelectedItem.ToString().Equals("INFERIOR"))
            {
                bañosLimpios = INFERIOR;
            }

            if (CB_baños_limpios.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
            {
                bañosLimpios = MEDIO_INFERIOR;
            }

            if (CB_baños_limpios.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
            {
                bañosLimpios = MEDIO_SUPERIOR;
            }

            if (CB_baños_limpios.SelectedItem.ToString().Equals("SUPERIOR"))
            {
                bañosLimpios = SUPERIOR;
            }

            if (CB_baños_limpios.SelectedItem.ToString().Equals("MUY SUPERIOR"))
            {
                bañosLimpios = MUY_SUPERIOR;
            }
            //******************************************************


            //****** calculo de apoyo en area****************************
            int vecesArea = Convert.ToInt32(TB_cant_apoyo_area.Text);
            apoyoArea = vecesArea * APOYO_AREA;
            TB_total_apoyo_area.Text = Convert.ToString(apoyoArea);
            //***********************************************************

            //****** calculo de mercancia estancada****************************
            int vecesEstancada = Convert.ToInt32(TB_cant_merc_estancada.Text);
            mercEstancada = vecesEstancada * MERC_ESTANCADA;
            TB_total_merc_estancada.Text = Convert.ToString(mercEstancada);
            //***********************************************************

            //****** calculo de llegada mercancia ****************************
            int vecesLlegada = Convert.ToInt32(TB_llegada_merc.Text);
            llegada_merc = vecesLlegada * LLEGADA_MERC;
            TB_total_llegada_merc.Text = Convert.ToString(llegada_merc);
            //***********************************************************

            //****** calculo de Reparación de mercancía ****************************
            int vecesReparacion = Convert.ToInt32(TB_rep_merc.Text);
            repMerc = vecesReparacion * REP_MERC;
            TB_total_rep_merc.Text = Convert.ToString(repMerc);
            //***********************************************************

            //****** calculo de Exibicion de mercancia ****************************
            int vecesExibicion = Convert.ToInt32(TB_exibicion_merc.Text);
            exibicionMerc = vecesExibicion * EXIBICION_MERC;
            TB_total_exibicion_merc.Text = Convert.ToString(exibicionMerc);
            //***********************************************************


            promedio = (imagen + cajas + articulos + areas + mercSinEmpaque + mercOordenada + señalizacion + bañosLimpios)/8;
            total = apoyoArea + mercEstancada + llegada_merc + repMerc + exibicionMerc;

            //TB_promedio.Text = Convert.ToString(promedio);
            TB_total.Text = Convert.ToString(total);
            TB_promedio.Text = Convert.ToString(promedio);
            Tpagar = (promedio / 100) * 80;
            TB_pagar.Text = Convert.ToString(Tpagar);
            imagen = 0; cajas = 0; articulos = 0; areas = 0; mercSinEmpaque = 0; mercOordenada = 0; señalizacion = 0; bañosLimpios = 0; promedio = 0; Tpagar=0;
            apoyoArea = 0; mercEstancada = 0; llegada_merc = 0; repMerc = 0; exibicionMerc = 0;

        }


        private void CalifBodega_Load(object sender, EventArgs e)
        {
          
            Empleados();
            GB_aspectos.Enabled = false;
            GB_otrosAspectos.Enabled = false;
            GB_etiquetadores.Enabled = false;
        }

        private void CB_empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                MySqlConnection con = BDConexicon.conectar();
                string query = "SELECT idemp,puesto FROM rd_alta_empbodega WHERE nombre='" + CB_empleado.SelectedItem.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_id.Text = dr["idemp"].ToString();
                    TB_puesto.Text= dr["puesto"].ToString();
                }
                dr.Close();
                con.Close();

                if (TB_puesto.Text.Equals("ETIQUETADOR"))
                {
                    GB_aspectos.Enabled = false;
                    GB_otrosAspectos.Enabled = false;
                    GB_etiquetadores.Enabled = true;
                }
                else
                {
                    GB_etiquetadores.Enabled = false;
                    GB_aspectos.Enabled = true;
                    GB_otrosAspectos.Enabled = true;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                
            }
        }

        private void BT_calcular_Click(object sender, EventArgs e)
        {
            CalculoCalificacion();
        }

        private void TB_id_TextChanged(object sender, EventArgs e)
        {



        }


        //EVENTO DE CB_IMAGEN
        private void CB_imagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //****** calif de imagen ******************************
                if (CB_imagen.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_imagen.Text = Convert.ToString(DEFICIENTE);

                }

                if (CB_imagen.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_imagen.Text = Convert.ToString(INFERIOR);
                }

                if (CB_imagen.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_imagen.Text = Convert.ToString(MEDIO_INFERIOR);
                }

                if (CB_imagen.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_imagen.Text = Convert.ToString(MEDIO_SUPERIOR);
                }

                if (CB_imagen.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_imagen.Text = Convert.ToString(SUPERIOR);
                }

                if (CB_imagen.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_imagen.Text = Convert.ToString(MUY_SUPERIOR);
                }
                //******************************************************
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                
            }


        }

        //EVENTO DE CB_CAJAS

        private void CB_cajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (CB_cajas.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_cajas.Text = Convert.ToString(DEFICIENTE);
                }

                if (CB_cajas.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_cajas.Text = Convert.ToString(INFERIOR);
                }

                if (CB_cajas.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_cajas.Text = Convert.ToString(MEDIO_INFERIOR);

                }

                if (CB_cajas.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_cajas.Text = Convert.ToString(MEDIO_SUPERIOR);

                }

                if (CB_cajas.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_cajas.Text = Convert.ToString(SUPERIOR);

                }

                if (CB_cajas.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_cajas.Text = Convert.ToString(MUY_SUPERIOR);

                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                
            }
        }

        //EVENTO DE CB_ARTICULOS
        private void CB_articulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (CB_articulos.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_articulos.Text = Convert.ToString(DEFICIENTE);
                }

                if (CB_articulos.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_articulos.Text = Convert.ToString(INFERIOR);
                }

                if (CB_articulos.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_articulos.Text = Convert.ToString(MEDIO_INFERIOR);
                }

                if (CB_articulos.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_articulos.Text = Convert.ToString(MEDIO_SUPERIOR);
                }

                if (CB_articulos.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_articulos.Text = Convert.ToString(SUPERIOR);
                }

                if (CB_articulos.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_articulos.Text = Convert.ToString(MUY_SUPERIOR);
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

               
            }
        }

        //EVENTO DE CB_AREAS
        private void CB_areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_areas.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_areas.Text = Convert.ToString(DEFICIENTE);
                }

                if (CB_areas.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_areas.Text = Convert.ToString(INFERIOR);
                }

                if (CB_areas.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_areas.Text = Convert.ToString(MEDIO_INFERIOR);

                }

                if (CB_areas.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_areas.Text = Convert.ToString(MEDIO_SUPERIOR);

                }

                if (CB_areas.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_areas.Text = Convert.ToString(SUPERIOR);

                }

                if (CB_areas.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_areas.Text = Convert.ToString(MUY_SUPERIOR);

                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

               
            }
        }

        //EVENTO DE CB_MERC_SIN_EMPAQUE
        private void CB_merc_sin_empaque_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_merc_sin_empaque.Text = Convert.ToString(DEFICIENTE);
                }

                if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_merc_sin_empaque.Text = Convert.ToString(INFERIOR);

                }

                if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_merc_sin_empaque.Text = Convert.ToString(MEDIO_INFERIOR);
                }

                if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_merc_sin_empaque.Text = Convert.ToString(MEDIO_SUPERIOR);
                }

                if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_merc_sin_empaque.Text = Convert.ToString(SUPERIOR);
                }

                if (CB_merc_sin_empaque.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_merc_sin_empaque.Text = Convert.ToString(MUY_SUPERIOR);

                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

               
            }
        }

        //EVENTO DE CB_MERC_ORDENADA
        private void CB_merc_ordenada_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_merc_ordenada.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_merc_ordenada.Text = Convert.ToString(DEFICIENTE);
                }

                if (CB_merc_ordenada.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_merc_ordenada.Text = Convert.ToString(INFERIOR);

                }

                if (CB_merc_ordenada.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_merc_ordenada.Text = Convert.ToString(MEDIO_INFERIOR);
                }

                if (CB_merc_ordenada.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_merc_ordenada.Text = Convert.ToString(MEDIO_SUPERIOR);

                }

                if (CB_merc_ordenada.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_merc_ordenada.Text = Convert.ToString(SUPERIOR);
                }

                if (CB_merc_ordenada.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_merc_ordenada.Text = Convert.ToString(MUY_SUPERIOR);

                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                
            }
        }

        //EVENTO DE CB_SEÑALIZACION

        private void CB_señalizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_señalizacion.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_señales.Text = Convert.ToString(DEFICIENTE);
                }

                if (CB_señalizacion.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_señales.Text = Convert.ToString(INFERIOR);
                }

                if (CB_señalizacion.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_señales.Text = Convert.ToString(MEDIO_INFERIOR);
                }

                if (CB_señalizacion.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_señales.Text = Convert.ToString(MEDIO_SUPERIOR);
                }

                if (CB_señalizacion.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_señales.Text = Convert.ToString(SUPERIOR);
                }

                if (CB_señalizacion.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_señales.Text = Convert.ToString(MUY_SUPERIOR);
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                
            }
        }

        private void CB_baños_limpios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_baños_limpios.SelectedItem.ToString().Equals("DEFICIENTE"))
                {
                    TB_baños.Text = Convert.ToString(DEFICIENTE);
                }

                if (CB_baños_limpios.SelectedItem.ToString().Equals("INFERIOR"))
                {
                    TB_baños.Text = Convert.ToString(INFERIOR);
                }

                if (CB_baños_limpios.SelectedItem.ToString().Equals("MEDIO INFERIOR"))
                {
                    TB_baños.Text = Convert.ToString(MEDIO_INFERIOR);
                }

                if (CB_baños_limpios.SelectedItem.ToString().Equals("MEDIO SUPERIOR"))
                {
                    TB_baños.Text = Convert.ToString(MEDIO_SUPERIOR);
                }

                if (CB_baños_limpios.SelectedItem.ToString().Equals("SUPERIOR"))
                {
                    TB_baños.Text = Convert.ToString(SUPERIOR);
                }

                if (CB_baños_limpios.SelectedItem.ToString().Equals("MUY SUPERIOR"))
                {
                    TB_baños.Text = Convert.ToString(MUY_SUPERIOR);
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

              
            }
        }


        public void GuardarCalif()//bodegueros
        {
            DateTime fecha = DT_fecha.Value;
            MySqlConnection con = BDConexicon.conectar();
             string query = "INSERT INTO rd_calif_emp_bodega(idempleado,nombre,imagen,cajas,articulos,areas_limpias,merc_fuera_empaque,merc_ord_areas,senalizacion,ba_limpios,promedio,tpagar,apoyo_area,merc_estancada,llegada_merc,rep_merc,merc_exhibida,total,fecha,descarga,cajasurtida,totalEtiquetador,proveedor)VALUES(?idempleado,?nombre,?imagen,?cajas,?articulos,?areas_limpias,?merc_fuera_empaque,?merc_ord_areas,?senalizacion,?ba_limpios,?promedio,?tpagar,?apoyo_area,?merc_estancada,?llegada_merc,?rep_merc,?merc_exhibida,?total,?fecha,?descarga,?cajasurtida,?totalEtiquetador,?proveedor)";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?idempleado",TB_id.Text );
            cmd.Parameters.AddWithValue("?nombre", CB_empleado.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?imagen", TB_imagen.Text);
            cmd.Parameters.AddWithValue("?cajas", TB_cajas.Text);
            cmd.Parameters.AddWithValue("?articulos", TB_articulos.Text);
            cmd.Parameters.AddWithValue("?areas_limpias", TB_areas.Text);
            cmd.Parameters.AddWithValue("?merc_fuera_empaque",TB_merc_sin_empaque.Text);
            cmd.Parameters.AddWithValue("?merc_ord_areas",TB_merc_ordenada.Text);
            cmd.Parameters.AddWithValue("?senalizacion",TB_señales.Text);
            cmd.Parameters.AddWithValue("?ba_limpios",TB_baños.Text);
            cmd.Parameters.AddWithValue("?promedio",TB_promedio.Text);
            cmd.Parameters.AddWithValue("?tpagar", TB_pagar.Text);
            cmd.Parameters.AddWithValue("?apoyo_area",TB_total_apoyo_area.Text);
            cmd.Parameters.AddWithValue("?merc_estancada",TB_total_merc_estancada.Text);
            cmd.Parameters.AddWithValue("?llegada_merc",TB_total_llegada_merc.Text);
            cmd.Parameters.AddWithValue("?rep_merc", TB_total_rep_merc.Text);
            cmd.Parameters.AddWithValue("?merc_exhibida", TB_total_exibicion_merc.Text);
            cmd.Parameters.AddWithValue("?total",TB_total.Text);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("?descarga", "0");
            cmd.Parameters.AddWithValue("?cajasurtida", "0");
            cmd.Parameters.AddWithValue("?totalEtiquetador", "0");
            cmd.Parameters.AddWithValue("?proveedor","");
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("Se ha guardado la Calificación");


        }

        public void Limpiar()
        {
            CB_imagen.SelectedIndex = -1;
            CB_cajas.SelectedIndex = -1;
            CB_articulos.SelectedIndex = -1;
            CB_areas.SelectedIndex = -1;
            CB_merc_sin_empaque.SelectedIndex = -1;
            CB_merc_ordenada.SelectedIndex = -1;
            CB_señalizacion.SelectedIndex = -1;
            CB_baños_limpios.SelectedIndex = -1;
            CB_empleado.SelectedIndex = -1;

            TB_id.Text = "";

            TB_imagen.Text = "";
            TB_cajas.Text = "";
            TB_articulos.Text = "";
            TB_areas.Text = "";
            TB_merc_sin_empaque.Text = "";
            TB_merc_ordenada.Text = "";
            TB_señales.Text = "";
            TB_baños.Text = "";

            TB_total_apoyo_area.Text = "";
            TB_total_rep_merc.Text = "";
            TB_total_exibicion_merc.Text="";
            TB_total_llegada_merc.Text = "";
            TB_total_merc_estancada.Text = "";

            TB_cant_apoyo_area.Text = "0";
            TB_cant_merc_estancada.Text = "0";
            TB_llegada_merc.Text = "0";
            TB_rep_merc.Text = "0";
            TB_exibicion_merc.Text = "0";

            TB_total.Text = "";
            TB_promedio.Text = "";
            TB_pagar.Text="";
        }


        public bool verificarCalificacion(string id,DateTime fecha)
        {
            bool validacion = false;
            string query = "SELECT * FROM rd_calif_emp_bodega WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND idempleado='" + id + "'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                validacion = true;
            }
            else
            {
                validacion = false;
            }
            return validacion;
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DT_fecha.Value;
            bool validacion = verificarCalificacion(TB_id.Text,fecha);

            if (validacion==true)
            {
                MessageBox.Show("Ya se califó a este empleado en la fecha seleccionada");
            }
            else
            {
                GuardarCalif();
            }
          
            
        }

        public void CalcularCalifEtiquetador()
        {
            int veces = Convert.ToInt32(TB_descarga.Text);
            TB_totalDescarga.Text = Convert.ToString(veces * precioDescarga);

            int cajas = Convert.ToInt32(TB_cantidad.Text);
            double precio = Convert.ToDouble(TB_precioCaja.Text);
            TB_totalCaja.Text = Convert.ToString(cajas * precio);

            double totalDescarga = Convert.ToDouble(TB_totalDescarga.Text);
            double totalCaja = Convert.ToDouble(TB_totalCaja.Text);

            TB_totalEtiquetador.Text = Convert.ToString(totalDescarga +  totalCaja);
        }


        private void BT_calcularEtiquetador_Click(object sender, EventArgs e)
        {
            CalcularCalifEtiquetador();
        }



        public void GuardarCalifEtiquetador()
        {
            DateTime fecha = DT_fecha.Value;
            MySqlConnection con = BDConexicon.conectar();
            string query = "INSERT INTO rd_calif_emp_bodega(idempleado,nombre,imagen,cajas,articulos,areas_limpias,merc_fuera_empaque,merc_ord_areas,senalizacion,ba_limpios,promedio,tpagar,apoyo_area,merc_estancada,llegada_merc,rep_merc,merc_exhibida,total,fecha,descarga,cajasurtida,totalEtiquetador,proveedor)VALUES(?idempleado,?nombre,?imagen,?cajas,?articulos,?areas_limpias,?merc_fuera_empaque,?merc_ord_areas,?senalizacion,?ba_limpios,?promedio,?tpagar,?apoyo_area,?merc_estancada,?llegada_merc,?rep_merc,?merc_exhibida,?total,?fecha,?descarga,?cajasurtida,?totalEtiquetador,?proveedor)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?idempleado", TB_id.Text);
            cmd.Parameters.AddWithValue("?nombre",CB_empleado.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?imagen", "0");
            cmd.Parameters.AddWithValue("?cajas", "0");
            cmd.Parameters.AddWithValue("?articulos", "0");
            cmd.Parameters.AddWithValue("?areas_limpias", "0");
            cmd.Parameters.AddWithValue("?merc_fuera_empaque", "0");
            cmd.Parameters.AddWithValue("?merc_ord_areas", "0");
            cmd.Parameters.AddWithValue("?senalizacion", "0");
            cmd.Parameters.AddWithValue("?ba_limpios", "0");
            cmd.Parameters.AddWithValue("?promedio", "0");
            cmd.Parameters.AddWithValue("?tpagar", "0");
            cmd.Parameters.AddWithValue("?apoyo_area", "0");
            cmd.Parameters.AddWithValue("?merc_estancada", "0");
            cmd.Parameters.AddWithValue("?llegada_merc", "0");
            cmd.Parameters.AddWithValue("?rep_merc", "0");
            cmd.Parameters.AddWithValue("?merc_exhibida", "0");
            cmd.Parameters.AddWithValue("?total", "0");
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy/MM/dd"));
            cmd.Parameters.AddWithValue("?descarga", TB_totalDescarga.Text);
            cmd.Parameters.AddWithValue("?cajasurtida", TB_totalCaja.Text);
            cmd.Parameters.AddWithValue("?totalEtiquetador", TB_totalEtiquetador.Text);
            cmd.Parameters.AddWithValue("?proveedor", TB_proveedor.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha guardado la Calificación");
            TB_descarga.Text = "0";
            TB_cantidad.Text = "0";
            TB_precioCaja.Text = "0";
            TB_totalDescarga.Text = "0";
            TB_totalCaja.Text = "0";
            TB_totalEtiquetador.Text = "0";
        }


        private void BT_guardarEtiquetador_Click(object sender, EventArgs e)
        {
            DateTime fecha = DT_fecha.Value;
           
           
                GuardarCalifEtiquetador();
              
            
        }
    }
}
