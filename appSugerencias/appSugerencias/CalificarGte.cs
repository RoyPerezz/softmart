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
    public partial class CalificarGte : Form
    {
        public CalificarGte()
        {
            InitializeComponent();
        }
        int incidencias = 0, zona_ofertas = 0, envio_comisiones = 0, prod_no_exhibido = 0, area_vacia = 0, reuniones = 0, solucionar_problemas = 0, comida = 0, descuento = 0, apoyo_cajas = 0;
#pragma warning disable CS0414 // El campo 'CalificarGte.totalPagar' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'CalificarGte.incentivo' está asignado pero su valor nunca se usa
        double totalDescuento = 0, totalPagar = 0, apoyoSemanal = 0, incentivo = 60;
#pragma warning restore CS0414 // El campo 'CalificarGte.incentivo' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'CalificarGte.totalPagar' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'CalificarGte.apellido1' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'CalificarGte.apellido2' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'CalificarGte.nombre' está asignado pero su valor nunca se usa
        string nombre = "", apellido1 = "",apellido2="";
#pragma warning restore CS0414 // El campo 'CalificarGte.nombre' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'CalificarGte.apellido2' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'CalificarGte.apellido1' está asignado pero su valor nunca se usa
        int area_limpia = 0, precios = 0, precios_oferta = 0, exhibir_productos = 0, limpieza_vitrina = 0, exhibir_prod_personal = 0, presentacion = 0, planograma = 0, formatos_cubres = 0, info_tienda = 0, distribucion_personal = 0;

        private void CB_gerente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string gerente = CB_gerente.SelectedItem.ToString();
                //char limite = ' ';
                //string[] texto = gerente.Split(limite);
                //nombre = texto[0];
                //apellido1 = texto[1];
                ////apellido2 = texto[2];
                ///
                string query = "SELECT apellidos,puesto FROM rd_registro_jefes WHERE nombre ='"+CB_gerente.SelectedItem.ToString()+"'";
                MySqlConnection con = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
             

                while (dr.Read())
                {
                    //nombre = dr["nombre"].ToString();
                    //apellido = dr["apellidos"].ToString();
                    TB_apellidos.Text = dr["apellidos"].ToString();
                    TB_puesto.Text = dr["puesto"].ToString();
                  
                }
                dr.Close();
                con.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Error al trar el puesto del gerente/cubre");
                
            }
        }

      
        public void Limpiar()
        {
            DG_tabla.Rows[0].Cells[3].Value = 0;
            DG_tabla.Rows[1].Cells[3].Value = 0;
            DG_tabla.Rows[2].Cells[3].Value = 0;
            DG_tabla.Rows[3].Cells[3].Value = 0;
            DG_tabla.Rows[4].Cells[3].Value = 0;
            DG_tabla.Rows[5].Cells[3].Value = 0;
            DG_tabla.Rows[6].Cells[3].Value = 0;
            DG_tabla.Rows[7].Cells[3].Value = 0;
            DG_tabla.Rows[8].Cells[3].Value = 0;
            DG_tabla.Rows[9].Cells[3].Value = 0;
            DG_tabla.Rows[10].Cells[3].Value = 0;
            DG_tabla.Rows[11].Cells[3].Value = 0;
            DG_tabla.Rows[12].Cells[3].Value = 0;
            DG_tabla.Rows[13].Cells[3].Value = 0;
            DG_tabla.Rows[14].Cells[3].Value = 0;
            DG_tabla.Rows[15].Cells[3].Value = 0;
            DG_tabla.Rows[16].Cells[3].Value = 0;
            DG_tabla.Rows[17].Cells[3].Value = 0;
            DG_tabla.Rows[18].Cells[3].Value = 0;
            DG_tabla.Rows[19].Cells[3].Value = 0;
            DG_tabla.Rows[20].Cells[3].Value = 0;

            DG_tabla.Rows[0].Cells[2].Value = 0;
            DG_tabla.Rows[1].Cells[2].Value = 0;
            DG_tabla.Rows[2].Cells[2].Value = 0;
            DG_tabla.Rows[3].Cells[2].Value = 0;
            DG_tabla.Rows[4].Cells[2].Value = 0;
            DG_tabla.Rows[5].Cells[2].Value = 0;
            DG_tabla.Rows[6].Cells[2].Value = 0;
            DG_tabla.Rows[7].Cells[2].Value = 0;
            DG_tabla.Rows[8].Cells[2].Value = 0;
            DG_tabla.Rows[9].Cells[2].Value = 0;
            DG_tabla.Rows[10].Cells[2].Value = 0;
            DG_tabla.Rows[11].Cells[2].Value = 0;
            DG_tabla.Rows[12].Cells[2].Value = 0;
            DG_tabla.Rows[13].Cells[2].Value = 0;
            DG_tabla.Rows[14].Cells[2].Value = 0;
            DG_tabla.Rows[15].Cells[2].Value = 0;
            DG_tabla.Rows[16].Cells[2].Value = 0;
            DG_tabla.Rows[17].Cells[2].Value = 0;
            DG_tabla.Rows[18].Cells[2].Value = 0;
            DG_tabla.Rows[19].Cells[2].Value = 0;
            DG_tabla.Rows[20].Cells[2].Value = 0;


            totalDescuento = 0;
            LB_totalPagar.Text = "";
            LB_totaldesc.Text = "";
            //nombre = "";
            //apellido1 = "";
            //apellido2 = "";

        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            try
            {


                string sucursal = CB_SUCURSAL.SelectedItem.ToString();
                string query = "";
                DateTime inicio = DT_inicio.Value;
                DateTime fin = DT_fin.Value;
                MySqlConnection con = BDConexicon.BodegaOpen();


                //if (sucursal.Equals("VALLARTA"))
                //{

                //    query = "INSERT INTO rd_calif_gteva(area_limpia,precios_exhibidos,precios_oferta,exhibicion_productos,limpieza_vitrina,ofertas_temporada,presentacion,planograma,formatos_cubres,info_tienda,distribucion_personal,incidencias,zona_ofertas,enviar_comisiones,prod_no_exhibido,area_vacia,reunion_diaria,solucion_problemas,comida,descuento_camara,apoyo_en_cajas,apoyo_semanal,total_descuento,incentivo,totalcomision,nombre_gerente,apellidos_gerente,inicio_semana,fin_semana,sucursal)" +
                //        "VALUES(?area_limpia,?precios_exhibidos,?precios_oferta,?exhibicion_productos,?limpieza_vitrina,?ofertas_temporada,?presentacion,?planograma,?formatos_cubres,?info_tienda,?distribucion_personal,?incidencias,?zona_ofertas,?enviar_comisiones,?prod_no_exhibido,?area_vacia,?reunion_diaria,?solucion_problemas,?comida,?descuento_camara,?apoyo_en_cajas,?apoyo_semanal,?total_descuento,?incentivo,?totalcomision,?nombre_gerente,?apellidos_gerente,?inicio_semana,?fin_semana,?sucursal)";
                //}


                //if (sucursal.Equals("RENA"))
                //{

                //    query = "INSERT INTO rd_calif_gtere(area_limpia,precios_exhibidos,precios_oferta,exhibicion_productos,limpieza_vitrina,ofertas_temporada,presentacion,planograma,formatos_cubres,info_tienda,distribucion_personal,incidencias,zona_ofertas,enviar_comisiones,prod_no_exhibido,area_vacia,reunion_diaria,solucion_problemas,comida,descuento_camara,apoyo_en_cajas,apoyo_semanal,total_descuento,incentivo,totalcomision,nombre_gerente,apellidos_gerente,inicio_semana,fin_semana,sucursal)" +
                //        "VALUES(?area_limpia,?precios_exhibidos,?precios_oferta,?exhibicion_productos,?limpieza_vitrina,?ofertas_temporada,?presentacion,?planograma,?formatos_cubres,?info_tienda,?distribucion_personal,?incidencias,?zona_ofertas,?enviar_comisiones,?prod_no_exhibido,?area_vacia,?reunion_diaria,?solucion_problemas,?comida,?descuento_camara,?apoyo_en_cajas,?apoyo_semanal,?total_descuento,?incentivo,?totalcomision,?nombre_gerente,?apellidos_gerente,?inicio_semana,?fin_semana,?sucursal)";
                //}

                //if (sucursal.Equals("VELAZQUEZ"))
                //{

                //    query = "INSERT INTO rd_calif_gteve(area_limpia,precios_exhibidos,precios_oferta,exhibicion_productos,limpieza_vitrina,ofertas_temporada,presentacion,planograma,formatos_cubres,info_tienda,distribucion_personal,incidencias,zona_ofertas,enviar_comisiones,prod_no_exhibido,area_vacia,reunion_diaria,solucion_problemas,comida,descuento_camara,apoyo_en_cajas,apoyo_semanal,total_descuento,incentivo,totalcomision,nombre_gerente,apellidos_gerente,inicio_semana,fin_semana,sucursal)" +
                //        "VALUES(?area_limpia,?precios_exhibidos,?precios_oferta,?exhibicion_productos,?limpieza_vitrina,?ofertas_temporada,?presentacion,?planograma,?formatos_cubres,?info_tienda,?distribucion_personal,?incidencias,?zona_ofertas,?enviar_comisiones,?prod_no_exhibido,?area_vacia,?reunion_diaria,?solucion_problemas,?comida,?descuento_camara,?apoyo_en_cajas,?apoyo_semanal,?total_descuento,?incentivo,?totalcomision,?nombre_gerente,?apellidos_gerente,?inicio_semana,?fin_semana,?sucursal)";
                //}

                //if (sucursal.Equals("COLOSO"))
                //{

                //    query = "INSERT INTO rd_calif_gteco(area_limpia,precios_exhibidos,precios_oferta,exhibicion_productos,limpieza_vitrina,ofertas_temporada,presentacion,planograma,formatos_cubres,info_tienda,distribucion_personal,incidencias,zona_ofertas,enviar_comisiones,prod_no_exhibido,area_vacia,reunion_diaria,solucion_problemas,comida,descuento_camara,apoyo_en_cajas,apoyo_semanal,total_descuento,incentivo,totalcomision,nombre_gerente,apellidos_gerente,inicio_semana,fin_semana,sucursal)" +
                //        "VALUES(?area_limpia,?precios_exhibidos,?precios_oferta,?exhibicion_productos,?limpieza_vitrina,?ofertas_temporada,?presentacion,?planograma,?formatos_cubres,?info_tienda,?distribucion_personal,?incidencias,?zona_ofertas,?enviar_comisiones,?prod_no_exhibido,?area_vacia,?reunion_diaria,?solucion_problemas,?comida,?descuento_camara,?apoyo_en_cajas,?apoyo_semanal,?total_descuento,?incentivo,?totalcomision,?nombre_gerente,?apellidos_gerente,?inicio_semana,?fin_semana,?sucursal)";
                //}



                query = "INSERT INTO rd_calif_gte(area_limpia,precios_exhibidos,precios_oferta,exhibicion_productos,limpieza_vitrina,ofertas_temporada,presentacion,planograma,formatos_cubres,info_tienda,distribucion_personal,incidencias,zona_ofertas,enviar_comisiones,prod_no_exhibido,area_vacia,reunion_diaria,solucion_problemas,comida,descuento_camara,apoyo_en_cajas,apoyo_semanal,total_descuento,incentivo,totalcomision,nombre_gerente,apellidos_gerente,puesto,inicio_semana,fin_semana,sucursal)" +
                       "VALUES(?area_limpia,?precios_exhibidos,?precios_oferta,?exhibicion_productos,?limpieza_vitrina,?ofertas_temporada,?presentacion,?planograma,?formatos_cubres,?info_tienda,?distribucion_personal,?incidencias,?zona_ofertas,?enviar_comisiones,?prod_no_exhibido,?area_vacia,?reunion_diaria,?solucion_problemas,?comida,?descuento_camara,?apoyo_en_cajas,?apoyo_semanal,?total_descuento,?incentivo,?totalcomision,?nombre_gerente,?apellidos_gerente,?puesto,?inicio_semana,?fin_semana,?sucursal)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?area_limpia",area_limpia);
                cmd.Parameters.AddWithValue("?precios_exhibidos",precios);
                cmd.Parameters.AddWithValue("?precios_oferta", precios_oferta);
                cmd.Parameters.AddWithValue("?exhibicion_productos",exhibir_productos);
                cmd.Parameters.AddWithValue("?limpieza_vitrina", limpieza_vitrina);
                cmd.Parameters.AddWithValue("?ofertas_temporada", exhibir_prod_personal);
                cmd.Parameters.AddWithValue("?presentacion", presentacion);
                cmd.Parameters.AddWithValue("?planograma", planograma);
                cmd.Parameters.AddWithValue("?formatos_cubres",formatos_cubres);
                cmd.Parameters.AddWithValue("?info_tienda",info_tienda);
                cmd.Parameters.AddWithValue("?distribucion_personal", distribucion_personal);
                cmd.Parameters.AddWithValue("?incidencias", incidencias);
                cmd.Parameters.AddWithValue("?zona_ofertas",zona_ofertas);
                cmd.Parameters.AddWithValue("?enviar_comisiones", envio_comisiones);
                cmd.Parameters.AddWithValue("?prod_no_exhibido", prod_no_exhibido);
                cmd.Parameters.AddWithValue("?area_vacia",area_vacia);
                cmd.Parameters.AddWithValue("?reunion_diaria", reuniones);
                cmd.Parameters.AddWithValue("?solucion_problemas",solucionar_problemas);
                cmd.Parameters.AddWithValue("?comida",comida);
                cmd.Parameters.AddWithValue("?descuento_camara",descuento);
                cmd.Parameters.AddWithValue("?apoyo_en_cajas", apoyo_cajas);
                cmd.Parameters.AddWithValue("?apoyo_semanal", apoyoSemanal);
                cmd.Parameters.AddWithValue("?total_descuento", LB_totaldesc.Text);
                cmd.Parameters.AddWithValue("?incentivo", 0);
                cmd.Parameters.AddWithValue("?totalcomision", LB_totalPagar.Text);
                cmd.Parameters.AddWithValue("?nombre_gerente",CB_gerente.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?apellidos_gerente",TB_apellidos.Text);
                cmd.Parameters.AddWithValue("?puesto", TB_puesto.Text);
                cmd.Parameters.AddWithValue("?inicio_semana",inicio.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?fin_semana", fin.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?sucursal", CB_SUCURSAL.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("SE HA GUARDADO LA CALIFICACION EXITOSAMENTE");

                TB_apellidos.Text = "";
                TB_puesto.Text = "";
                CB_SUCURSAL.SelectedIndex = -1;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar la calificacion del gerente,posiblemente un problema en la red ocasionó el problema " + ex);
              
            }
        }

      


        private void CB_SUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sucursal = CB_SUCURSAL.SelectedItem.ToString();

            //string query = "SELECT nombre, apellidos,puesto FROM rd_registro_jefes WHERE puesto='GERENTE' OR puesto='CUBRE GERENTE' AND tienda='"+sucursal+"'";
            //MySqlConnection con = BDConexicon.BodegaOpen();
            //MySqlCommand cmd = new MySqlCommand(query, con);
            //MySqlDataReader dr = cmd.ExecuteReader();
            //CB_gerente.SelectedIndex = -1;
            //CB_gerente.Items.Clear();
           
            //while (dr.Read())
            //{
            //    //nombre = dr["nombre"].ToString();
            //    //apellido = dr["apellidos"].ToString();
            //    CB_gerente.Items.Add(dr["nombre"].ToString() + " " + dr["apellidos"].ToString());
            //}
            //dr.Close();
            //con.Close();
        }

       public void Gerentes()
        {
            string query = "SELECT nombre, apellidos,puesto FROM rd_registro_jefes WHERE puesto='GERENTE' OR puesto='CUBRE GERENTE'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            CB_gerente.SelectedIndex = -1;
            CB_gerente.Items.Clear();

            while (dr.Read())
            {
                //nombre = dr["nombre"].ToString();
                //apellido = dr["apellidos"].ToString();
                CB_gerente.Items.Add(dr["nombre"].ToString());
            }
            dr.Close();
            con.Close();
        }
            






        private void BT_calcular_Click(object sender, EventArgs e)
        {
            if (TB_puesto.Text.Equals("GERENTE"))
            {
                apoyoSemanal = 1500;
            }

            if (TB_puesto.Text.Equals("CUBRE GERENTE"))
            {
                apoyoSemanal = 800;
            }
          
                area_limpia = Convert.ToInt32(DG_tabla.Rows[0].Cells[2].Value);
                precios = Convert.ToInt32(DG_tabla.Rows[1].Cells[2].Value);
                precios_oferta = Convert.ToInt32(DG_tabla.Rows[2].Cells[2].Value);
                exhibir_productos = Convert.ToInt32(DG_tabla.Rows[3].Cells[2].Value);
                limpieza_vitrina = Convert.ToInt32(DG_tabla.Rows[4].Cells[2].Value);
                exhibir_prod_personal = Convert.ToInt32(DG_tabla.Rows[5].Cells[2].Value);
                presentacion = Convert.ToInt32(DG_tabla.Rows[6].Cells[2].Value);
                planograma = Convert.ToInt32(DG_tabla.Rows[7].Cells[2].Value);
                formatos_cubres = Convert.ToInt32(DG_tabla.Rows[8].Cells[2].Value);
                info_tienda = Convert.ToInt32(DG_tabla.Rows[9].Cells[2].Value);
                distribucion_personal = Convert.ToInt32(DG_tabla.Rows[10].Cells[2].Value);
                incidencias = Convert.ToInt32(DG_tabla.Rows[11].Cells[2].Value);
                zona_ofertas = Convert.ToInt32(DG_tabla.Rows[12].Cells[2].Value);
                envio_comisiones = Convert.ToInt32(DG_tabla.Rows[13].Cells[2].Value);
                prod_no_exhibido = Convert.ToInt32(DG_tabla.Rows[14].Cells[2].Value);
                area_vacia = Convert.ToInt32(DG_tabla.Rows[15].Cells[2].Value);
                reuniones = Convert.ToInt32(DG_tabla.Rows[16].Cells[2].Value);
                solucionar_problemas = Convert.ToInt32(DG_tabla.Rows[17].Cells[2].Value);
                comida = Convert.ToInt32(DG_tabla.Rows[18].Cells[2].Value);
                descuento = Convert.ToInt32(DG_tabla.Rows[19].Cells[2].Value);
                apoyo_cajas = Convert.ToInt32(DG_tabla.Rows[20].Cells[2].Value);



               
            

            DG_tabla.Rows[0].Cells[3].Value = area_limpia * 5;
            DG_tabla.Rows[1].Cells[3].Value = precios * 3;
            DG_tabla.Rows[2].Cells[3].Value = precios_oferta * 3;
            DG_tabla.Rows[3].Cells[3].Value = exhibir_productos * 3;
            DG_tabla.Rows[4].Cells[3].Value = limpieza_vitrina * 5;
            DG_tabla.Rows[5].Cells[3].Value = exhibir_prod_personal * 5;
            DG_tabla.Rows[6].Cells[3].Value = presentacion * 5;
            DG_tabla.Rows[7].Cells[3].Value = planograma * 5;
            DG_tabla.Rows[8].Cells[3].Value = formatos_cubres * 20;
            DG_tabla.Rows[9].Cells[3].Value = info_tienda * 5;
            DG_tabla.Rows[10].Cells[3].Value = distribucion_personal * 20;
            DG_tabla.Rows[11].Cells[3].Value = incidencias * 5;
            DG_tabla.Rows[12].Cells[3].Value = zona_ofertas * 5;
            DG_tabla.Rows[13].Cells[3].Value = envio_comisiones * 10;
            DG_tabla.Rows[14].Cells[3].Value = prod_no_exhibido * 10;
            DG_tabla.Rows[15].Cells[3].Value = area_vacia * 5;
            DG_tabla.Rows[16].Cells[3].Value = reuniones * 5;
            DG_tabla.Rows[17].Cells[3].Value = solucionar_problemas * 10;
            DG_tabla.Rows[18].Cells[3].Value = comida * 5;
            DG_tabla.Rows[19].Cells[3].Value = descuento * 10;
            DG_tabla.Rows[20].Cells[3].Value = apoyo_cajas * 10;

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                totalDescuento += Convert.ToDouble(DG_tabla.Rows[i].Cells[3].Value);
            }

            LB_totaldesc.Text = Convert.ToString(totalDescuento);
            LB_totalPagar.Text = Convert.ToString(apoyoSemanal - totalDescuento);
            totalDescuento = 0;
        }

       
        private void CalificarGte_Load(object sender, EventArgs e)
        {

            Gerentes();



            DG_tabla.Rows.Add("AREA LIMPIA ", "$5.00", "0","0");
            DG_tabla.Rows.Add("PRECIOS EXHIBIDOS", "$3.00", "0","0");
            DG_tabla.Rows.Add("PRECIOS DE OFERTA", "$3.00", "0","0");
            DG_tabla.Rows.Add("EXHIBICION DE PRODUCTOS (IMAGEN)", "$3.00", "0","0");
            DG_tabla.Rows.Add("LIMPIEZA DE VITRINA (NO POLVO, NO CINTA, BARILLAS LIMPIAS, ETC)", "$5.00", "0","0");
            DG_tabla.Rows.Add("PRODUCTOS EXHIBIDOS POR EL PERSONAL (OFERTAS O TEMPORADA)", "$5.00", "0","0");
            DG_tabla.Rows.Add("PRESENTACION DEL PERSONAL (UNIFORME, MAQUILLAJE, PEINADO)", "$5.00", "0","0");
            DG_tabla.Rows.Add("PLANOGRAMA", "$5.00", "0","0");
            DG_tabla.Rows.Add("SEGUIMIENTO A SU FORMATOS PARA CUBRES", "$20.00", "0","0");
            DG_tabla.Rows.Add("INFORMACION DE TIENDA, (PUBLICIDAD Y PROMOCIONES)", "$5.00", "0","0");
            DG_tabla.Rows.Add("REALIZAR CORRECTAMENTE LA DISTRIBUCION DEL PERSONAL ", "$20.00", "0","0");
            DG_tabla.Rows.Add("INCIDENCIAS (BAÑOS, PASILLOS DESPEJADOS, TARAS SIN ACOMODAR, ETC.)", "$5.00", "0","0");
            DG_tabla.Rows.Add("MOVIMIENTO DE LUGAR, ZONA DE OFERTAS", "$5.00", "0","0");
            DG_tabla.Rows.Add("ENVIAR EN TIEMPO Y FORMA COMISIONES (FOTOS DE CIERRE DE DIA)", "$10.00", "0","0");
            DG_tabla.Rows.Add("PRODUCTO NO EXHIBIDO", "$10.00", "0","0");
            DG_tabla.Rows.Add("AREA VACIA (VARILLAS Y PANEL)", "$5.00", "0","0");
            DG_tabla.Rows.Add("TENER REUNION DIARIA CON GERENTES Y ALMACEN PARA PASAR INFORMACION Y AREAS DE OPORTUNIDAD", "$5.00", "0","0");
            DG_tabla.Rows.Add("SOLUCIONAR A LA BREVEDAD A PRODUCTOS CON PROBLEMAS EN EL AREA DE COBRO.(MAX. 5 MIN.) ", "$10.00", "0","0");
            DG_tabla.Rows.Add("COMIDA(LLEGAR CON LA COMIDA O COMPRARLA SOLAMENTE CON LAS PERSONAS QUE VAN A OFRECERLA AHÍ. SOLO TORTILLAS Y UNA SOLA PERSONA)", "$5.00", "0","0");
            DG_tabla.Rows.Add("DESCUENTO POR CAMARA", "$10.00", "0","0");
            DG_tabla.Rows.Add("APOYAR FISICAMENTE EN CAJAS, CUANDO ESTA AUSENTE LA ENCARGADA. ", "$10.00", "0","0");

            DG_tabla.Columns["ASPECTOS"].Width = 700;
        }
    }
}
