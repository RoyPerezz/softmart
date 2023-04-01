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
    public partial class ComisionesVerificadores : Form
    {
        public ComisionesVerificadores()
        {
            InitializeComponent();
        }

        int idVerif = 0, presentacion = 0, ofrecer_bolsa = 0, cajas_limpias = 0, estacionamiento = 0, pisos_limpios = 0, canastas_limpias = 0;
        int carritos_limpios = 0, herramientas = 0, tickets = 0, saludo_despedida = 0, disponibilidad = 0, iniciativa = 0;
        int area_cartones = 0, senalamientos = 0, tapete = 0, surtir_pelotas = 0, exhibicion = 0, tubos_num_cajas = 0, reporte_camaras = 0;
        int rejillas_limpias = 0, rejillas_surtidas = 0, colocar_ofertas = 0, presentacion_area_cajas = 0, cristales_limpios = 0;

        private void CB_verificadores_SelectedIndexChanged(object sender, EventArgs e)
        {

            TB_presentacion.Text = "6";
            TB_ofrecer_bolsa.Text = "5";
            TB_cajas_limpias.Text = "5";
            TB_estacionamiento.Text = "6";
            TB_pisos_limpios.Text = "7";
            TB_canastas_limpias.Text = "6";
            TB_carritos_limpios.Text = "6";
            TB_cristales_limpios.Text = "6";
            TB_herramientas.Text = "6";
            TB_tickets.Text = "6";
            TB_papel_bodega.Text = "0.50";
            TB_saludo.Text = "6";
            TB_disponibilidad.Text = "6";
            TB_iniciativa.Text = "6";
            TB_cartones.Text = "6";
            TB_señalamientos.Text = "6";
            TB_tapete.Text = "6";
            TB_surtir_pelotas.Text = "6";
            TB_limpiart_ex.Text = "6";
            TB_tubos_cajas.Text = "6";
            TB_reportes.Text = "0";
            TB_rejillas_limpias.Text = "6";
            TB_rejillas_surtidas.Text = "5";
            TB_ofertas_precios.Text = "4";
            TB_presentacion_cajas.Text = "5";
        }

        double papel_bodega = 0;
        double total = 0;

        


        private void BT_calcular_Click(object sender, EventArgs e)
        {
            presentacion = 0; ofrecer_bolsa = 0; cajas_limpias = 0; estacionamiento = 0; pisos_limpios = 0; canastas_limpias = 0; carritos_limpios = 0; cristales_limpios = 0;
            herramientas = 0; tickets = 0; papel_bodega = 0; saludo_despedida = 0; disponibilidad = 0; iniciativa = 0; area_cartones = 0; senalamientos = 0; tapete = 0; surtir_pelotas = 0;
            exhibicion = 0; tubos_num_cajas = 0; reporte_camaras = 0; rejillas_limpias = 0; rejillas_surtidas = 0; colocar_ofertas = 0; presentacion_area_cajas = 0;


            idVerif = Convert.ToInt32(0);
            presentacion = Convert.ToInt32(TB_presentacion.Text);
            ofrecer_bolsa = Convert.ToInt32(TB_ofrecer_bolsa.Text);
            cajas_limpias = Convert.ToInt32(TB_cajas_limpias.Text);
            estacionamiento = Convert.ToInt32(TB_estacionamiento.Text);
            pisos_limpios = Convert.ToInt32(TB_pisos_limpios.Text);
            canastas_limpias = Convert.ToInt32(TB_canastas_limpias.Text);
            carritos_limpios = Convert.ToInt32(TB_carritos_limpios.Text);
            cristales_limpios = Convert.ToInt32(TB_cristales_limpios.Text);
            herramientas = Convert.ToInt32(TB_herramientas.Text);
            tickets = Convert.ToInt32(TB_tickets.Text);
            papel_bodega = Convert.ToDouble(TB_papel_bodega.Text);
            saludo_despedida = Convert.ToInt32(TB_saludo.Text);
            disponibilidad = Convert.ToInt32(TB_disponibilidad.Text);
            iniciativa = Convert.ToInt32(TB_iniciativa.Text);
            area_cartones = Convert.ToInt32(TB_cartones.Text);
            senalamientos = Convert.ToInt32(TB_señalamientos.Text);
            tapete = Convert.ToInt32(TB_tapete.Text);
            surtir_pelotas = Convert.ToInt32(TB_surtir_pelotas.Text);
            exhibicion = Convert.ToInt32(TB_limpiart_ex.Text);
            tubos_num_cajas = Convert.ToInt32(TB_tubos_cajas.Text);
            reporte_camaras = Convert.ToInt32(TB_reportes.Text);
            rejillas_limpias = Convert.ToInt32(TB_rejillas_limpias.Text);
            rejillas_surtidas = Convert.ToInt32(TB_rejillas_surtidas.Text);
            colocar_ofertas = Convert.ToInt32(TB_ofertas_precios.Text);
            presentacion_area_cajas = Convert.ToInt32(TB_presentacion_cajas.Text);


          total = (papel_bodega + presentacion + ofrecer_bolsa + cajas_limpias + estacionamiento + pisos_limpios + canastas_limpias + carritos_limpios + herramientas + tickets + saludo_despedida + disponibilidad + iniciativa + area_cartones + senalamientos + tapete + surtir_pelotas + exhibicion + tubos_num_cajas  + rejillas_limpias + rejillas_surtidas + colocar_ofertas + presentacion_area_cajas + cristales_limpios)- reporte_camaras;



            //tope normal
            if (total > 133.34)
            {
                total = 133.34;
            }
            //if (total>171.43)
            //{
            //    total = 171.43;
            //}

            LB_total.Text = total.ToString("C2");

           
        }

      public void ValoresIniciales()
        {

            TB_presentacion.Text = "6";
            TB_ofrecer_bolsa.Text = "5";
            TB_cajas_limpias.Text = "5";
            TB_estacionamiento.Text = "6";
            TB_pisos_limpios.Text = "7";
            TB_canastas_limpias.Text = "6";
            TB_carritos_limpios.Text = "6";
            TB_cristales_limpios.Text = "6";
            TB_herramientas.Text = "6";
            TB_tickets.Text = "6";
            TB_papel_bodega.Text = "0.50";
            TB_saludo.Text = "6";
            TB_disponibilidad.Text = "6";
            TB_iniciativa.Text = "6";
            TB_cartones.Text = "6";
            TB_señalamientos.Text = "6";
            TB_tapete.Text = "6";
            TB_surtir_pelotas.Text = "6";
            TB_limpiart_ex.Text = "6";
            TB_tubos_cajas.Text = "6";
            TB_reportes.Text = "0";
            TB_rejillas_limpias.Text = "6";
            TB_rejillas_surtidas.Text = "5";
            TB_ofertas_precios.Text = "4";
            TB_presentacion_cajas.Text = "5";
        }

        private void ComisionesVerificadores_Load(object sender, EventArgs e)
        {


            TB_presentacion.Text = "6";
            TB_ofrecer_bolsa.Text = "5";
            TB_cajas_limpias.Text = "5";
            TB_estacionamiento.Text = "6";
            TB_pisos_limpios.Text = "7";
            TB_canastas_limpias.Text = "6";
            TB_carritos_limpios.Text = "6";
            TB_cristales_limpios.Text = "6";
            TB_herramientas.Text = "6";
            TB_tickets.Text = "6";
            TB_papel_bodega.Text = "0.50";
            TB_saludo.Text = "6";
            TB_disponibilidad.Text = "6";
            TB_iniciativa.Text = "6";
            TB_cartones.Text = "6";
            TB_señalamientos.Text = "6";
            TB_tapete.Text = "6";
            TB_surtir_pelotas.Text = "6";
            TB_limpiart_ex.Text = "6";
            TB_tubos_cajas.Text = "6";
            TB_reportes.Text = "0";
            TB_rejillas_limpias.Text = "6";
            TB_rejillas_surtidas.Text = "5";
            TB_ofertas_precios.Text = "4";
            TB_presentacion_cajas.Text = "5";


            try
            {
                MySqlConnection conexion = BDConexicon.conectar();
                string query = "SELECT  USUARIO FROM rd_asesoras_venta WHERE PUESTO ='VERIFICADOR/A'";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    CB_verificadores.Items.Add(read["USUARIO"].ToString());
                }
                read.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Error al tratar de obtener los usuarios de los verificadores");
      
            }
        }

        #region codigo que no sirve
   
        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        public string ObtenerIdVerificador(string usuario)
        {
           string  verificador = "";

                MySqlConnection conexion = BDConexicon.conectar();
                string query = "SELECT idasesora FROM rd_asesoras_venta WHERE usuario ='"+usuario+"'";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    verificador = dr["idasesora"].ToString();
                }
            dr.Close();
            conexion.Close();
            return verificador;
           
           
        }

        public bool VerificarCalificacion(string verificador)
        {
            bool respuesta = false;
            DateTime fecha = DT_fecha.Value;
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT * FROM rd_comisiones_verif WHERE FECHA='"+fecha.ToString("yyyy-MM-dd")+"' and  verificador='"+ verificador+ "'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                respuesta = true;
            }
            



            return respuesta;

        }

        public void Limpiar()
        {
            TB_presentacion.Text = "";
            TB_ofrecer_bolsa.Text = "";
            TB_cajas_limpias.Text = "";
            TB_estacionamiento.Text = "";
            TB_pisos_limpios.Text = "";
            TB_canastas_limpias.Text = "";
            TB_carritos_limpios.Text = "";
            TB_cristales_limpios.Text = "";
            TB_herramientas.Text = "";
            TB_tickets.Text = "";
            TB_papel_bodega.Text = "";
            TB_saludo.Text = "";
            TB_disponibilidad.Text = "";
            TB_iniciativa.Text = "";
            TB_cartones.Text = "";
            TB_señalamientos.Text = "";
            TB_tapete.Text = "";
            TB_surtir_pelotas.Text = "";
            TB_limpiart_ex.Text = "";
            TB_tubos_cajas.Text = "";
            TB_reportes.Text = "";
            TB_rejillas_limpias.Text = "";
            TB_rejillas_surtidas.Text = "";
            TB_ofertas_precios.Text = "";
            TB_presentacion_cajas.Text = "";
            LB_total.Text = "";
        }


        private void BT_guardar_Click(object sender, EventArgs e)
        {
          

            try
            {

                string verificador = ObtenerIdVerificador(CB_verificadores.SelectedItem.ToString());
                bool respuesta = VerificarCalificacion(verificador);


                if (respuesta==true)
                {
                    MessageBox.Show("Ya se calificó al verificador en la fecha seleccionada");
                }
                else
                {
                    if (presentacion >6)
                    {
                        MessageBox.Show("El valor de PRESENTACIÓN no puede ser mas de $4.00");
                    }
                    else if(ofrecer_bolsa>5){
                        MessageBox.Show("El valor de OFRECER CAJA O BOLSA AL CLIENTE no puede ser mas de $3.00");
                    }
                    else if (cajas_limpias >5)
                    {
                        MessageBox.Show("El valor de CAJAS LIMPIAS no puede ser mas de $3.00");
                    }else if(estacionamiento > 6)
                    {
                        MessageBox.Show("El valor de ESTACIONAMIENTO LIMPIO no puede ser mas de $4.00");
                    }else if(pisos_limpios>7)
                    {
                        MessageBox.Show("El valor de PISOS LIMPIOS no puede ser mas de $7.00");
                    }else if (canastas_limpias>6)
                    {

                        MessageBox.Show("El valor de CANASTAR LIMPIAS no puede ser mas de $6.00");
                    }else if(carritos_limpios >6)
                    {

                        MessageBox.Show("El valor de CARRITOS LIMPIOS no puede ser mas de $6.00");
                    }else if(cristales_limpios > 6)
                    {

                        MessageBox.Show("El valor de CRISTALES LIMPIOS no puede ser mas de $6.00");
                    }else if (herramientas>6)
                    {

                        MessageBox.Show("El valor de HERRAMIENTAS DE TRABAJO COMPLETAS Y EN BUEN ESTADO no puede ser mas de $6.00");
                    }
                    else if (tickets > 6)
                    {

                        MessageBox.Show("El valor de INICIAL DE LOS TICKETS no puede ser mas de $6.00");
                    }
                    else if (papel_bodega>27)
                    {
                        MessageBox.Show("El valor de DOBLAR PAPEL DE BODEGA no puede ser mas de $27.00");

                    }else if (saludo_despedida>6)
                    {
                        MessageBox.Show("El valor de SALUDO Y DESPEDIDA AL CLIENTE no puede ser mas de $6.00");

                    }
                    else if (disponibilidad > 6)
                    {
                        MessageBox.Show("El valor de DISPONIBILIDAD DE HACER LAS COSAS no puede ser mas de $6.00");

                    }
                    else if (iniciativa >6)
                    {
                        MessageBox.Show("El valor de INICIATIVA DE MODIFICAR SU ENTORNO no puede ser mas de $6.00");
                    }else if(area_cartones > 6)
                    {
                        MessageBox.Show("El valor de AREA DE CARTONES ORDENADA no puede ser mas de $6.00");
                    }else if (senalamientos > 6)
                    {
                        MessageBox.Show("El valor de CAMBIAR SEÑALAMIENTOS no puede ser mas de $6.00");
                    }
                    else if (tapete > 6)
                    {
                        MessageBox.Show("El valor de LAVAR TAPETE no puede ser mas de $6.00");
                    }
                    else if (surtir_pelotas >6)
                    {
                        MessageBox.Show("El valor de SURTIR PELOTAS no puede ser mas de $6.00");
                    }
                    else if (exhibicion > 6)
                    {
                        MessageBox.Show("El valor de LIMPIAR EXHIBICION no puede ser mas de $6.00");

                    }
                    else if (tubos_num_cajas > 6)
                    {
                        MessageBox.Show("El valor de LIMPIAR TUBOS Y NUMEROS DE CAJAS no puede ser mas de $6.00");

                    }
                    else if (rejillas_limpias > 6)
                    {
                        MessageBox.Show("El valor de REJILLAS LIMPIAS no puede ser mas de $6.00");

                    }
                    else if (rejillas_surtidas > 5)
                    {
                        MessageBox.Show("El valor de REJILLAS SURTIDAS no puede ser mas de $5.00");

                    }
                    else if (colocar_ofertas > 4)
                    {
                        MessageBox.Show("El valor de OFERTAS Y PRECIOS COLOCADOS no puede ser mas de $4.00");

                    }
                    else if (presentacion_area_cajas > 5)
                    {
                        MessageBox.Show("El valor de PRESENTACION DE AREA DE CAJAS no puede ser mas de $5.00");

                    }
                    else
                    {
                        DateTime fecha = DT_fecha.Value;
                        MySqlConnection conexion = BDConexicon.conectar();
                        string query = "INSERT INTO rd_comisiones_verif(verificador,fecha,presentacion,ofrecer_bolsa,cajas_limpias,estacionamiento,pisos_limpios,canastas_limpias,carritos_limpios,cristales_limpios,herramientas,tickets,papel_bodega,saludo_despedida,disponibilidad,iniciativa,area_cartones,senalamientos,tapete,surtir_pelotas,exhibicion,tubos_num_cajas,reporte_camaras,rejillas_limpias,rejillas_surtidas,colocar_ofertas,presentacion_area_cajas,total)" +
                            "VALUES(?verificador,?fecha,?presentacion,?ofrecer_bolsa,?cajas_limpias,?estacionamiento,?pisos_limpios,?canastas_limpias,?carritos_limpios,?cristales_limpios,herramientas,?tickets,?papel_bodega,?saludo_despedida,?disponibilidad,?iniciativa,?area_cartones,?senalamientos,?tapete,?surtir_pelotas,?exhibicion,?tubos_num_cajas,?reporte_camaras,?rejillas_limpias,?rejillas_surtidas,?colocar_ofertas,?presentacion_area_cajas,?total)";

                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("?verificador", CB_verificadores.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?presentacion", presentacion);
                        cmd.Parameters.AddWithValue("?ofrecer_bolsa", ofrecer_bolsa);
                        cmd.Parameters.AddWithValue("?cajas_limpias", cajas_limpias);
                        cmd.Parameters.AddWithValue("?estacionamiento", estacionamiento);
                        cmd.Parameters.AddWithValue("?pisos_limpios", pisos_limpios);
                        cmd.Parameters.AddWithValue("?canastas_limpias", canastas_limpias);
                        cmd.Parameters.AddWithValue("?carritos_limpios", carritos_limpios);
                        cmd.Parameters.AddWithValue("?cristales_limpios", cristales_limpios);
                        cmd.Parameters.AddWithValue("?herramientas", herramientas);
                        cmd.Parameters.AddWithValue("?tickets", tickets);
                        cmd.Parameters.AddWithValue("?papel_bodega", papel_bodega);
                        cmd.Parameters.AddWithValue("?saludo_despedida", saludo_despedida);
                        cmd.Parameters.AddWithValue("?disponibilidad", disponibilidad);
                        cmd.Parameters.AddWithValue("?iniciativa", iniciativa);
                        cmd.Parameters.AddWithValue("?area_cartones", area_cartones);
                        cmd.Parameters.AddWithValue("?senalamientos", senalamientos);
                        cmd.Parameters.AddWithValue("?tapete", tapete);
                        cmd.Parameters.AddWithValue("?surtir_pelotas", surtir_pelotas);
                        cmd.Parameters.AddWithValue("?exhibicion", exhibicion);
                        cmd.Parameters.AddWithValue("?tubos_num_cajas", tubos_num_cajas);
                        cmd.Parameters.AddWithValue("?reporte_camaras", reporte_camaras);
                        cmd.Parameters.AddWithValue("?rejillas_limpias", rejillas_limpias);
                        cmd.Parameters.AddWithValue("?rejillas_surtidas", rejillas_surtidas);
                        cmd.Parameters.AddWithValue("?colocar_ofertas", colocar_ofertas);
                        cmd.Parameters.AddWithValue("?presentacion_area_cajas", presentacion_area_cajas);
                        cmd.Parameters.AddWithValue("?total", total);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se ha guardado la calificación del verificador  "+CB_verificadores.SelectedItem.ToString());
                        //Limpiar();
                        ValoresIniciales();
                        LB_total.Text = "";
                    }

                }





            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar las calificaciones: "+ex);
            }
        }
    }
}
