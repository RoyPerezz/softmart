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
    public partial class CalificarEncCajas : Form
    {
        public CalificarEncCajas()
        {
            InitializeComponent();
        }

        int apoyo_semanal =0;
        int presentacion = 0, equipos = 0, fondo = 0, fondo_morralla = 0, solicitar_cambio = 0, mercancia_vitrinas = 0, saludo = 0, sugerencias_solucionadas = 0, gafete = 0, fondo_adicional = 0, presentacion_verif = 0;
        int pelotas = 0, caja_entrada = 0, depuracion_conceptos = 0, caja_cliente = 0, reunion_diaria = 0, cortes = 0, policia = 0, envio_comisiones = 0, gastos_ordenados = 0, apertura_caja = 0, carritos_limpios = 0, trabajo_personal = 0;
        int area_sola=0,retiro_cajas=0,exhibicion_productos=0,precios_exhibidos=0,precios_oferta=0,atencion_cliente=0,no_regresar_cliente=0,digitos4=0,formato_cubres=0,comida=0,info_tienda=0;
        int reporte_camaras = 0, comisiones = 0, solucion_problemas = 0, bitacora = 0, sobrante = 0, factura = 0, area_limpia = 0;


        public void limpiar()
        {
            DG_tabla.Rows.Clear();
            DG_tabla.Rows.Add("PRESENTACION UNIFORMES PEINADOS MAQUILLAJE", "$5.00", 0, 0);
            DG_tabla.Rows.Add("EQUIPOS DE COMPUTO ( FUNCIONANDO, LIMPIO, CAJAS CON LLAVE, IMPRESORA, TERMINAL FUNCIONANDO, STOCK DE ROLLOS(TERMINAL E IMPRESORA, ENCENDIDO DESDE INICIO DE TURNO", "$5.00", 0, 0);
            DG_tabla.Rows.Add("FONDO ( ENTREGAR Y RECIBIR AL GERENTE O CUBRE) ", "$20.00", 0, 0);
            DG_tabla.Rows.Add("FONDO DE MORALLA EN CAJAS, (COMPLETO, A TIEMPO Y TODAS LAS DENOMINACIONE)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE CAJERA SOLICITE CAMBIO DE MANERA AMABLE)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("EXIBIHICION DE MERCANCIA DE VITRINAS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("SALUDO AL CLIENTE", "$3.00", 0, 0);
            DG_tabla.Rows.Add("SUGERENCIAS  SOLUCIONADAS (FALTA DE HERRAMIENTA DE TRABAJO, FRANELA, LAPICERO, CALCULADORA, BLEDO, MARCADOR DE BILLETES, GRAPADORAS, CUADERNO)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("GAFETE ", "$3.00", 0, 0);
            DG_tabla.Rows.Add("TENER UN FONDO ADICIONAL EN CAJA YA ASIGNADA LA CAJERA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("PRESENTACION DE LOS VERIFICADORES FAJADOS Y PEINADOS", "$3.00", 0, 0);
            DG_tabla.Rows.Add("PELOTAS Y BALONES SURTIDOS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("LA CAJA DE LA ENTRADA SOLO USARLA COMO ULTIMA OPCION", "$10.00", 0, 0);
            DG_tabla.Rows.Add("DEPURACION DE CONCEPTOS ", "10.00", 0, 0);
            DG_tabla.Rows.Add("OFRECER UNA CAJA AL CLIENTE. (UTILIZAR TODOS LOS TAMAÑOS DE CAJAS)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("TENER REUNION DIARIA CON GERENTES Y ALMACEN PARA PASAR INFORMACION Y AREAS DE OPORTUNIDAD", "$5.00", 0, 0);
            DG_tabla.Rows.Add("REVISION EN TIEMPO Y FORMA DE LOS CORTES", "$10.00", 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE EL POLICIA VIGILE QUE EL PERSONAL DE EXTERNO ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("ENVIO DE SUS COMISIONES", "$10.00", 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE TENGAN EN ORDEN SUS GASTOS. ", "$5.00", 0, 0);
            DG_tabla.Rows.Add("SE APERTURA CAJA ADICIONAL A PARTIR DE 6 CLIENTES.", "$20.00", 0, 0);
            DG_tabla.Rows.Add("CARRITIOS LIMPIOS  Y EN BUENAS CONDICIONES ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE EL PERSONAL ESTE REVISANDO CORRECTAMENTE SU TRABAJO (ESPECIALMENTE LA ENTRADA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("AREA SOLA", "$20.00", 0, 0);
            DG_tabla.Rows.Add("RETIROS EN CAJAS (NINGUN RETIRO EN CAJA, NO DAR CLAVE)", "$20.00", 0, 0);
            DG_tabla.Rows.Add("EXHIBICION DE PRODUCTOS (IMAGEN, PANEL, REGILLAS, PELOTAS(DESINFLADAS, SUCIAS, VIEJAS)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("PRECIOS EXHIBIDOS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("PRECIOS DE OFERTA", "$5.00", 0, 0);
            DG_tabla.Rows.Add("ATENCION AL CLIENTE (DE MALA GANA, SIN INFORMACION)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("NO REGRESAR AL CLEINTE PARA EL REVISADO DE PRODUCTOS. (AUDIFONOS PROVARLOS DESPUES DE LA COMPRA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("CATALOGO DE LOS 4 DIGITOS ", "$5.00", 0, 0);
            DG_tabla.Rows.Add("SEGUIMIENTO A SU FORMATOS PARA CUBRES", "$20.00", 0, 0);
            DG_tabla.Rows.Add("COMIDA(LLEGAR CON LA COMIDA O COMPRARLA SOLAMENTE CON LAS PERSONAS QUE VAN A OFRECERLA AHÍ. SOLO TORTILLAS Y UNA SOLA PERSONA)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("INFORMACION DE TIENDA, (PUBLICIDAD Y PROMOCIONES)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("REPORTES DE CAMARAS ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("ENVIAR EN TIEMPO Y FORMA COMISIONES (FOTOS DE CIERRE DE DIA)", "$20.00", 0, 0);
            DG_tabla.Rows.Add("DAR SOLICION INMEDIATA A PROBLEMAS MAS TARDAR 5 MIN)  ", "$5.00", 0, 0);
            DG_tabla.Rows.Add("BITACORA DE MANTENIMIENTO, SISTEMA Y PERSONAL EXTERNO", "$10.00", 0, 0);
            DG_tabla.Rows.Add("SOBRANTE, MERCANCIA APARTADA, BASURA", "$5.00", 0, 0);
            DG_tabla.Rows.Add("ELABORAR LA FACTURA LA ENCARGADA DE CAJAS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("AREA LIMPIA (CAJAS, COMPUTADORA, PAQUETERIA, CRISTALES, ESTACIONAMIENTO, BANQUETA, PAREDES, CESTO DE BASURA, MODULO DE ENCARGADAS)", "$5.00", 0, 0);

            LB_totaldesc.Text = "";
            LB_totalPagar.Text = "";
            TB_apellidos.Text = "";
            TB_puesto.Text = "";
            CB_enc_cajas.SelectedIndex = -1;
            CB_SUCURSAL.SelectedIndex = -1;
            //CB_enc_cajas.Items.Clear();
            //CB_enc_cajas.SelectedIndex = 0;
            TB_apellidos.Text = "";
        }

        private void CB_enc_cajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT apellidos,puesto FROM  rd_registro_jefes WHERE nombre='" + CB_enc_cajas.SelectedItem.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_apellidos.Text = dr["apellidos"].ToString();
                    TB_puesto.Text = dr["puesto"].ToString();
                
                }
                dr.Close();
                conexion.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                
            }

        }

        //AL SELECCIONAR UNA SUCURSAL SE LLENA EL COMBOBOX CON EL NOMBRE DE LAS ENC DE CAJAS REGISTRADAS EN ESA SUCURSAL
        private void CB_SUCURSAL_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////try
            ////{

            //    TB_apellidos.Text = "";
            //    CB_enc_cajas.SelectedIndex = -1;
            //    CB_enc_cajas.Items.Clear();
               
            //    MySqlConnection conexion = BDConexicon.BodegaOpen();
            //    string query = "SELECT id,nombre FROM rd_registro_jefes WHERE puesto='ENC DE CAJAS' AND tienda='"+CB_SUCURSAL.SelectedItem.ToString()+"'";
            //    MySqlCommand cmd = new MySqlCommand(query,conexion);
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        CB_enc_cajas.Items.Add(dr["nombre"].ToString());
            //    }
            //    dr.Close();
            //    conexion.Close();
            ////}
            ////catch (Exception ex )
            ////{
            ////    MessageBox.Show("Error al traer los nombres de las  enc de cajas "+ex);
                
            ////}
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            string query = "";
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            query = "INSERT INTO rd_calif_enc_cajas(presentacion,equipos,fondo,fondos_morralla,solicitar_cambio,mercancia_vitrinas,saludo,sugerencias_solucionadas,gafete,fondo_adicional,presentacion_verif,pelotas,caja_entrada,depuracion_conceptos,caja_cliente,reunion_diaria,cortes,policia,envio_comisiones,gastos_ordenados,apertura_caja,carritos_limpios,trabajo_personal,area_sola,retiro_cajas,exhibicion_productos,precios_exhibidos,precios_ofertas,atencion_cliente,no_regresar_cliente,digitos4,formato_cubres,comida,info_tienda,reporte_camaras,comisiones,solucion_problemas,bitacora,sobrante,factura,area_limpia,apoyo_semanal,totaldesc,totalpagar,inicio_semana,fin_semana,nom_enc_cajas,apellidos_enc_cajas,puesto,sucursal)" +
               "VALUES(?presentacion,?equipos,?fondo,?fondos_morralla,?solicitar_cambio,?mercancia_vitrinas,?saludo,?sugerencias_solucionadas,?gafete,?fondo_adicional,?presentacion_verif,?pelotas,?caja_entrada,?depuracion_conceptos,?caja_cliente,?reunion_diaria,?cortes,?policia,?envio_comisiones,?gastos_ordenados,?apertura_caja,?carritos_limpios,?trabajo_personal,?area_sola,?retiro_cajas,?exhibicion_productos,?precios_exhibidos,?precios_ofertas,?atencion_cliente,?no_regresar_cliente,?digitos4,?formato_cubres,?comida,?info_tienda,?reporte_camaras,?comisiones,?solucion_problemas,?bitacora,?sobrante,?factura,?area_limpia,?apoyo_semanal,?totaldesc,?totalpagar,?inicio_semana,?fin_semana,?nom_enc_cajas,?apellidos_enc_cajas,?puesto,?sucursal)";

            //if (CB_SUCURSAL.SelectedItem.ToString().Equals("VALLARTA"))
            //{
            //     query = "INSERT INTO rd_calif_enc_cajas_va(presentacion,equipos,fondo,fondos_morralla,solicitar_cambio,mercancia_vitrinas,saludo,sugerencias_solucionadas,gafete,fondo_adicional,presentacion_verif,pelotas,caja_entrada,depuracion_conceptos,caja_cliente,reunion_diaria,cortes,policia,envio_comisiones,gastos_ordenados,apertura_caja,carritos_limpios,trabajo_personal,area_sola,retiro_cajas,exhibicion_productos,precios_exhibidos,precios_ofertas,atencion_cliente,no_regresar_cliente,digitos4,formato_cubres,comida,info_tienda,reporte_camaras,comisiones,solucion_problemas,bitacora,sobrante,factura,area_limpia,apoyo_semanal,totaldesc,totalpagar,inicio_semana,fin_semana,nom_enc_cajas,apellidos_enc_cajas)" +
            //    "VALUES(?presentacion,?equipos,?fondo,?fondos_morralla,?solicitar_cambio,?mercancia_vitrinas,?saludo,?sugerencias_solucionadas,?gafete,?fondo_adicional,?presentacion_verif,?pelotas,?caja_entrada,?depuracion_conceptos,?caja_cliente,?reunion_diaria,?cortes,?policia,?envio_comisiones,?gastos_ordenados,?apertura_caja,?carritos_limpios,?trabajo_personal,?area_sola,?retiro_cajas,?exhibicion_productos,?precios_exhibidos,?precios_ofertas,?atencion_cliente,?no_regresar_cliente,?digitos4,?formato_cubres,?comida,?info_tienda,?reporte_camaras,?comisiones,?solucion_problemas,?bitacora,?sobrante,?factura,?area_limpia,?apoyo_semanal,?totaldesc,?totalpagar,?inicio_semana,?fin_semana,?nom_enc_cajas,?apellidos_enc_cajas)";
            //}

            //if (CB_SUCURSAL.SelectedItem.ToString().Equals("RENA"))
            //{
            //    query = "INSERT INTO rd_calif_enc_cajas_re(presentacion,equipos,fondo,fondos_morralla,solicitar_cambio,mercancia_vitrinas,saludo,sugerencias_solucionadas,gafete,fondo_adicional,presentacion_verif,pelotas,caja_entrada,depuracion_conceptos,caja_cliente,reunion_diaria,cortes,policia,envio_comisiones,gastos_ordenados,apertura_caja,carritos_limpios,trabajo_personal,area_sola,retiro_cajas,exhibicion_productos,precios_exhibidos,precios_ofertas,atencion_cliente,no_regresar_cliente,digitos4,formato_cubres,comida,info_tienda,reporte_camaras,comisiones,solucion_problemas,bitacora,sobrante,factura,area_limpia,apoyo_semanal,totaldesc,totalpagar,inicio_semana,fin_semana,nom_enc_cajas,apellidos_enc_cajas)" +
            //   "VALUES(?presentacion,?equipos,?fondo,?fondos_morralla,?solicitar_cambio,?mercancia_vitrinas,?saludo,?sugerencias_solucionadas,?gafete,?fondo_adicional,?presentacion_verif,?pelotas,?caja_entrada,?depuracion_conceptos,?caja_cliente,?reunion_diaria,?cortes,?policia,?envio_comisiones,?gastos_ordenados,?apertura_caja,?carritos_limpios,?trabajo_personal,?area_sola,?retiro_cajas,?exhibicion_productos,?precios_exhibidos,?precios_ofertas,?atencion_cliente,?no_regresar_cliente,?digitos4,?formato_cubres,?comida,?info_tienda,?reporte_camaras,?comisiones,?solucion_problemas,?bitacora,?sobrante,?factura,?area_limpia,?apoyo_semanal,?totaldesc,?totalpagar,?inicio_semana,?fin_semana,?nom_enc_cajas,?apellidos_enc_cajas)";
            //}

            //if (CB_SUCURSAL.SelectedItem.ToString().Equals("COLOSO"))
            //{
            //    query = "INSERT INTO rd_calif_enc_cajas_co(presentacion,equipos,fondo,fondos_morralla,solicitar_cambio,mercancia_vitrinas,saludo,sugerencias_solucionadas,gafete,fondo_adicional,presentacion_verif,pelotas,caja_entrada,depuracion_conceptos,caja_cliente,reunion_diaria,cortes,policia,envio_comisiones,gastos_ordenados,apertura_caja,carritos_limpios,trabajo_personal,area_sola,retiro_cajas,exhibicion_productos,precios_exhibidos,precios_ofertas,atencion_cliente,no_regresar_cliente,digitos4,formato_cubres,comida,info_tienda,reporte_camaras,comisiones,solucion_problemas,bitacora,sobrante,factura,area_limpia,apoyo_semanal,totaldesc,totalpagar,inicio_semana,fin_semana,nom_enc_cajas,apellidos_enc_cajas)" +
            //   "VALUES(?presentacion,?equipos,?fondo,?fondos_morralla,?solicitar_cambio,?mercancia_vitrinas,?saludo,?sugerencias_solucionadas,?gafete,?fondo_adicional,?presentacion_verif,?pelotas,?caja_entrada,?depuracion_conceptos,?caja_cliente,?reunion_diaria,?cortes,?policia,?envio_comisiones,?gastos_ordenados,?apertura_caja,?carritos_limpios,?trabajo_personal,?area_sola,?retiro_cajas,?exhibicion_productos,?precios_exhibidos,?precios_ofertas,?atencion_cliente,?no_regresar_cliente,?digitos4,?formato_cubres,?comida,?info_tienda,?reporte_camaras,?comisiones,?solucion_problemas,?bitacora,?sobrante,?factura,?area_limpia,?apoyo_semanal,?totaldesc,?totalpagar,?inicio_semana,?fin_semana,?nom_enc_cajas,?apellidos_enc_cajas)";
            //}

            //if (CB_SUCURSAL.SelectedItem.ToString().Equals("VELAZQUEZ"))
            //{
            //    query = "INSERT INTO rd_calif_enc_cajas_ve(presentacion,equipos,fondo,fondos_morralla,solicitar_cambio,mercancia_vitrinas,saludo,sugerencias_solucionadas,gafete,fondo_adicional,presentacion_verif,pelotas,caja_entrada,depuracion_conceptos,caja_cliente,reunion_diaria,cortes,policia,envio_comisiones,gastos_ordenados,apertura_caja,carritos_limpios,trabajo_personal,area_sola,retiro_cajas,exhibicion_productos,precios_exhibidos,precios_ofertas,atencion_cliente,no_regresar_cliente,digitos4,formato_cubres,comida,info_tienda,reporte_camaras,comisiones,solucion_problemas,bitacora,sobrante,factura,area_limpia,apoyo_semanal,totaldesc,totalpagar,inicio_semana,fin_semana,nom_enc_cajas,apellidos_enc_cajas)" +
            //   "VALUES(?presentacion,?equipos,?fondo,?fondos_morralla,?solicitar_cambio,?mercancia_vitrinas,?saludo,?sugerencias_solucionadas,?gafete,?fondo_adicional,?presentacion_verif,?pelotas,?caja_entrada,?depuracion_conceptos,?caja_cliente,?reunion_diaria,?cortes,?policia,?envio_comisiones,?gastos_ordenados,?apertura_caja,?carritos_limpios,?trabajo_personal,?area_sola,?retiro_cajas,?exhibicion_productos,?precios_exhibidos,?precios_ofertas,?atencion_cliente,?no_regresar_cliente,?digitos4,?formato_cubres,?comida,?info_tienda,?reporte_camaras,?comisiones,?solucion_problemas,?bitacora,?sobrante,?factura,?area_limpia,?apoyo_semanal,?totaldesc,?totalpagar,?inicio_semana,?fin_semana,?nom_enc_cajas,?apellidos_enc_cajas)";
            //}
            if (TB_puesto.Text.Equals("ENC DE CAJAS"))
            {
                apoyo_semanal = 1500;
            }

            if (TB_puesto.Text.Equals("CUBRE ENC DE CAJAS"))
            {
                apoyo_semanal = 800;
            }
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("?presentacion", presentacion);
                cmd.Parameters.AddWithValue("?equipos", equipos);
                cmd.Parameters.AddWithValue("?fondo", fondo);
                cmd.Parameters.AddWithValue("?fondos_morralla", fondo_morralla);
                cmd.Parameters.AddWithValue("?solicitar_cambio", solicitar_cambio);
                cmd.Parameters.AddWithValue("?mercancia_vitrinas", mercancia_vitrinas);
                cmd.Parameters.AddWithValue("?saludo", saludo);
                cmd.Parameters.AddWithValue("?sugerencias_solucionadas", sugerencias_solucionadas);
                cmd.Parameters.AddWithValue("?gafete", gafete);
                cmd.Parameters.AddWithValue("?fondo_adicional", fondo_adicional);
                cmd.Parameters.AddWithValue("?presentacion_verif", presentacion_verif);
                cmd.Parameters.AddWithValue("?pelotas", pelotas);
                cmd.Parameters.AddWithValue("?caja_entrada", caja_entrada);
                cmd.Parameters.AddWithValue("?depuracion_conceptos", depuracion_conceptos);
                cmd.Parameters.AddWithValue("?caja_cliente", caja_cliente);
                cmd.Parameters.AddWithValue("?reunion_diaria", reunion_diaria);
                cmd.Parameters.AddWithValue("?cortes", cortes);
                cmd.Parameters.AddWithValue("?policia", policia);
                cmd.Parameters.AddWithValue("?envio_comisiones", envio_comisiones);
                cmd.Parameters.AddWithValue("?gastos_ordenados", gastos_ordenados);
                cmd.Parameters.AddWithValue("?apertura_caja", apertura_caja);
                cmd.Parameters.AddWithValue("?carritos_limpios", carritos_limpios);
                cmd.Parameters.AddWithValue("?trabajo_personal", trabajo_personal);
                cmd.Parameters.AddWithValue("?area_sola", area_sola);
                cmd.Parameters.AddWithValue("?retiro_cajas", retiro_cajas);
                cmd.Parameters.AddWithValue("?exhibicion_productos", retiro_cajas);
                cmd.Parameters.AddWithValue("?precios_exhibidos", precios_exhibidos);
                cmd.Parameters.AddWithValue("?precios_ofertas", precios_oferta);
                cmd.Parameters.AddWithValue("?atencion_cliente", atencion_cliente);
                cmd.Parameters.AddWithValue("?no_regresar_cliente", no_regresar_cliente);
                cmd.Parameters.AddWithValue("?digitos4", digitos4);
                cmd.Parameters.AddWithValue("?formato_cubres", formato_cubres);
                cmd.Parameters.AddWithValue("?comida", comida);
                cmd.Parameters.AddWithValue("?info_tienda", info_tienda);
                cmd.Parameters.AddWithValue("?reporte_camaras", reporte_camaras);
                cmd.Parameters.AddWithValue("?comisiones", comisiones);
                cmd.Parameters.AddWithValue("?solucion_problemas", solucion_problemas);
                cmd.Parameters.AddWithValue("?bitacora", bitacora);
                cmd.Parameters.AddWithValue("?sobrante", sobrante);
                cmd.Parameters.AddWithValue("?factura", factura);
                cmd.Parameters.AddWithValue("?area_limpia", area_limpia);
                cmd.Parameters.AddWithValue("?apoyo_semanal", apoyo_semanal);
                cmd.Parameters.AddWithValue("?totaldesc", LB_totaldesc.Text);
                cmd.Parameters.AddWithValue("?totalpagar",LB_totalPagar.Text);
                cmd.Parameters.AddWithValue("?inicio_semana", inicio.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?fin_semana", fin.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?nom_enc_cajas",CB_enc_cajas.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?apellidos_enc_cajas",TB_apellidos.Text);
                cmd.Parameters.AddWithValue("?puesto", TB_puesto.Text);
                cmd.Parameters.AddWithValue("?sucursal", CB_SUCURSAL.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha gurdado la calificacion de la enc de caja");
                limpiar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la calificacion "+ex);
            }


        }

        private void BT_calcular_Click(object sender, EventArgs e)
        {

            if (TB_puesto.Text.Equals("ENC DE CAJAS"))
            {
                apoyo_semanal = 1500;
            }

            if (TB_puesto.Text.Equals("CUBRE ENC DE CAJAS"))
            {
                apoyo_semanal = 800;
            }


            presentacion = Convert.ToInt32(DG_tabla.Rows[0].Cells[2].Value);
            equipos = Convert.ToInt32(DG_tabla.Rows[1].Cells[2].Value);
            fondo = Convert.ToInt32(DG_tabla.Rows[2].Cells[2].Value);
            fondo_morralla = Convert.ToInt32(DG_tabla.Rows[3].Cells[2].Value);
            solicitar_cambio = Convert.ToInt32(DG_tabla.Rows[4].Cells[2].Value);
            mercancia_vitrinas = Convert.ToInt32(DG_tabla.Rows[5].Cells[2].Value);
            saludo = Convert.ToInt32(DG_tabla.Rows[6].Cells[2].Value);
            sugerencias_solucionadas = Convert.ToInt32(DG_tabla.Rows[7].Cells[2].Value);
            gafete = Convert.ToInt32(DG_tabla.Rows[8].Cells[2].Value);
            fondo_adicional = Convert.ToInt32(DG_tabla.Rows[9].Cells[2].Value);
            presentacion_verif = Convert.ToInt32(DG_tabla.Rows[10].Cells[2].Value);
            pelotas = Convert.ToInt32(DG_tabla.Rows[11].Cells[2].Value);
            caja_entrada = Convert.ToInt32(DG_tabla.Rows[12].Cells[2].Value);
            depuracion_conceptos = Convert.ToInt32(DG_tabla.Rows[13].Cells[2].Value);
            caja_cliente = Convert.ToInt32(DG_tabla.Rows[14].Cells[2].Value);
            reunion_diaria = Convert.ToInt32(DG_tabla.Rows[15].Cells[2].Value);
            cortes = Convert.ToInt32(DG_tabla.Rows[16].Cells[2].Value);
            policia = Convert.ToInt32(DG_tabla.Rows[17].Cells[2].Value);
            envio_comisiones = Convert.ToInt32(DG_tabla.Rows[18].Cells[2].Value);
            gastos_ordenados = Convert.ToInt32(DG_tabla.Rows[19].Cells[2].Value);
            apertura_caja = Convert.ToInt32(DG_tabla.Rows[20].Cells[2].Value);
            carritos_limpios = Convert.ToInt32(DG_tabla.Rows[21].Cells[2].Value);
            trabajo_personal = Convert.ToInt32(DG_tabla.Rows[22].Cells[2].Value);
            area_sola = Convert.ToInt32(DG_tabla.Rows[23].Cells[2].Value);
            retiro_cajas = Convert.ToInt32(DG_tabla.Rows[24].Cells[2].Value);
            exhibicion_productos = Convert.ToInt32(DG_tabla.Rows[25].Cells[2].Value);
            precios_exhibidos = Convert.ToInt32(DG_tabla.Rows[26].Cells[2].Value);
            precios_oferta = Convert.ToInt32(DG_tabla.Rows[27].Cells[2].Value);
            atencion_cliente = Convert.ToInt32(DG_tabla.Rows[28].Cells[2].Value);
            no_regresar_cliente = Convert.ToInt32(DG_tabla.Rows[29].Cells[2].Value);
            digitos4 = Convert.ToInt32(DG_tabla.Rows[30].Cells[2].Value);
            formato_cubres = Convert.ToInt32(DG_tabla.Rows[31].Cells[2].Value);
            comida = Convert.ToInt32(DG_tabla.Rows[32].Cells[2].Value);
            info_tienda = Convert.ToInt32(DG_tabla.Rows[33].Cells[2].Value);
            reporte_camaras = Convert.ToInt32(DG_tabla.Rows[34].Cells[2].Value);
            comisiones = Convert.ToInt32(DG_tabla.Rows[35].Cells[2].Value);
            solucion_problemas = Convert.ToInt32(DG_tabla.Rows[36].Cells[2].Value);
            bitacora = Convert.ToInt32(DG_tabla.Rows[37].Cells[2].Value);
            sobrante = Convert.ToInt32(DG_tabla.Rows[38].Cells[2].Value);
            factura = Convert.ToInt32(DG_tabla.Rows[39].Cells[2].Value);
            area_limpia = Convert.ToInt32(DG_tabla.Rows[40].Cells[2].Value);

            DG_tabla.Rows[0].Cells[3].Value = presentacion * 5;
            DG_tabla.Rows[1].Cells[3].Value = equipos * 5;
            DG_tabla.Rows[2].Cells[3].Value = fondo * 20;
            DG_tabla.Rows[3].Cells[3].Value = fondo_morralla * 5;
            DG_tabla.Rows[4].Cells[3].Value = solicitar_cambio * 5;
            DG_tabla.Rows[5].Cells[3].Value = mercancia_vitrinas * 5;
            DG_tabla.Rows[6].Cells[3].Value = saludo * 3;
            DG_tabla.Rows[7].Cells[3].Value = sugerencias_solucionadas * 10;
            DG_tabla.Rows[8].Cells[3].Value = gafete * 3;
            DG_tabla.Rows[9].Cells[3].Value = fondo_adicional * 10;
            DG_tabla.Rows[10].Cells[3].Value = presentacion_verif * 3;
            DG_tabla.Rows[11].Cells[3].Value = pelotas * 5;
            DG_tabla.Rows[12].Cells[3].Value = caja_entrada * 10;
            DG_tabla.Rows[13].Cells[3].Value = depuracion_conceptos * 10;
            DG_tabla.Rows[14].Cells[3].Value = caja_cliente * 10;
            DG_tabla.Rows[15].Cells[3].Value = reunion_diaria * 5;
            DG_tabla.Rows[16].Cells[3].Value = cortes * 10;
            DG_tabla.Rows[17].Cells[3].Value = policia * 10;
            DG_tabla.Rows[18].Cells[3].Value = envio_comisiones * 10;
            DG_tabla.Rows[19].Cells[3].Value = gastos_ordenados * 5;
            DG_tabla.Rows[20].Cells[3].Value = apertura_caja * 20;
            DG_tabla.Rows[21].Cells[3].Value = carritos_limpios * 10;
            DG_tabla.Rows[22].Cells[3].Value = trabajo_personal * 10;
            DG_tabla.Rows[23].Cells[3].Value = area_sola * 20;
            DG_tabla.Rows[24].Cells[3].Value = retiro_cajas * 20;
            DG_tabla.Rows[25].Cells[3].Value = exhibicion_productos * 5;
            DG_tabla.Rows[26].Cells[3].Value = precios_exhibidos * 5;
            DG_tabla.Rows[27].Cells[3].Value = precios_oferta * 5;
            DG_tabla.Rows[28].Cells[3].Value = atencion_cliente * 10;
            DG_tabla.Rows[29].Cells[3].Value = no_regresar_cliente * 10;
            DG_tabla.Rows[30].Cells[3].Value = digitos4 * 5;
            DG_tabla.Rows[31].Cells[3].Value = formato_cubres * 20;
            DG_tabla.Rows[32].Cells[3].Value = comida * 5;
            DG_tabla.Rows[33].Cells[3].Value = info_tienda * 5;
            DG_tabla.Rows[34].Cells[3].Value = reporte_camaras * 10;
            DG_tabla.Rows[35].Cells[3].Value = comisiones * 20;
            DG_tabla.Rows[36].Cells[3].Value = solucion_problemas * 5;
            DG_tabla.Rows[37].Cells[3].Value = bitacora * 10;
            DG_tabla.Rows[38].Cells[3].Value = sobrante * 5;
            DG_tabla.Rows[39].Cells[3].Value = factura * 5;
            DG_tabla.Rows[40].Cells[3].Value = area_limpia * 5;


            double totalDesc = 0;

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                totalDesc += Convert.ToDouble(DG_tabla.Rows[i].Cells[3].Value);
            }

            LB_totaldesc.Text = Convert.ToString(totalDesc);
            LB_totalPagar.Text = Convert.ToString(apoyo_semanal - totalDesc);
            totalDesc = 0;






        }


        public void EncCajas()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT nombre FROM rd_registro_jefes WHERE puesto ='ENC DE CAJAS' OR puesto ='CUBRE ENC DE CAJAS'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_enc_cajas.Items.Add(dr["nombre"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void CalificarEncCajas_Load(object sender, EventArgs e)
        {
            EncCajas();
            DG_tabla.Rows.Add("PRESENTACION UNIFORMES PEINADOS MAQUILLAJE", "$5.00",0,0);
            DG_tabla.Rows.Add("EQUIPOS DE COMPUTO ( FUNCIONANDO, LIMPIO, CAJAS CON LLAVE, IMPRESORA, TERMINAL FUNCIONANDO, STOCK DE ROLLOS(TERMINAL E IMPRESORA, ENCENDIDO DESDE INICIO DE TURNO", "$5.00", 0, 0);
            DG_tabla.Rows.Add("FONDO ( ENTREGAR Y RECIBIR AL GERENTE O CUBRE) ", "$20.00", 0, 0);
            DG_tabla.Rows.Add("FONDO DE MORALLA EN CAJAS, (COMPLETO, A TIEMPO Y TODAS LAS DENOMINACIONE)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE CAJERA SOLICITE CAMBIO DE MANERA AMABLE)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("EXIBIHICION DE MERCANCIA DE VITRINAS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("SALUDO AL CLIENTE", "$3.00", 0, 0);
            DG_tabla.Rows.Add("SUGERENCIAS  SOLUCIONADAS (FALTA DE HERRAMIENTA DE TRABAJO, FRANELA, LAPICERO, CALCULADORA, BLEDO, MARCADOR DE BILLETES, GRAPADORAS, CUADERNO)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("GAFETE ", "$3.00", 0, 0);
            DG_tabla.Rows.Add("TENER UN FONDO ADICIONAL EN CAJA YA ASIGNADA LA CAJERA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("PRESENTACION DE LOS VERIFICADORES FAJADOS Y PEINADOS", "$3.00", 0, 0);
            DG_tabla.Rows.Add("PELOTAS Y BALONES SURTIDOS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("LA CAJA DE LA ENTRADA SOLO USARLA COMO ULTIMA OPCION", "$10.00", 0, 0);
            DG_tabla.Rows.Add("DEPURACION DE CONCEPTOS ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("OFRECER UNA CAJA AL CLIENTE. (UTILIZAR TODOS LOS TAMAÑOS DE CAJAS)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("TENER REUNION DIARIA CON GERENTES Y ALMACEN PARA PASAR INFORMACION Y AREAS DE OPORTUNIDAD", "$5.00", 0, 0);
            DG_tabla.Rows.Add("REVISION EN TIEMPO Y FORMA DE LOS CORTES", "$10.00", 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE EL POLICIA VIGILE QUE EL PERSONAL DE EXTERNO ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("ENVIO DE SUS COMISIONES", "$10.00", 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE TENGAN EN ORDEN SUS GASTOS. ", "$5.00", 0, 0);
            DG_tabla.Rows.Add("SE APERTURA CAJA ADICIONAL A PARTIR DE 6 CLIENTES.", "$20.00", 0, 0);
            DG_tabla.Rows.Add("CARRITIOS LIMPIOS  Y EN BUENAS CONDICIONES ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE EL PERSONAL ESTE REVISANDO CORRECTAMENTE SU TRABAJO (ESPECIALMENTE LA ENTRADA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("AREA SOLA", "$20.00", 0, 0);
            DG_tabla.Rows.Add("RETIROS EN CAJAS (NINGUN RETIRO EN CAJA, NO DAR CLAVE)", "$20.00", 0, 0);
            DG_tabla.Rows.Add("EXHIBICION DE PRODUCTOS (IMAGEN, PANEL, REGILLAS, PELOTAS(DESINFLADAS, SUCIAS, VIEJAS)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("PRECIOS EXHIBIDOS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("PRECIOS DE OFERTA", "$5.00", 0, 0);
            DG_tabla.Rows.Add("ATENCION AL CLIENTE (DE MALA GANA, SIN INFORMACION)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("NO REGRESAR AL CLEINTE PARA EL REVISADO DE PRODUCTOS. (AUDIFONOS PROVARLOS DESPUES DE LA COMPRA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("CATALOGO DE LOS 4 DIGITOS ", "$5.00", 0, 0);
            DG_tabla.Rows.Add("SEGUIMIENTO A SU FORMATOS PARA CUBRES", "$20.00", 0, 0);
            DG_tabla.Rows.Add("COMIDA(LLEGAR CON LA COMIDA O COMPRARLA SOLAMENTE CON LAS PERSONAS QUE VAN A OFRECERLA AHÍ. SOLO TORTILLAS Y UNA SOLA PERSONA)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("INFORMACION DE TIENDA, (PUBLICIDAD Y PROMOCIONES)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("REPORTES DE CAMARAS ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("ENVIAR EN TIEMPO Y FORMA COMISIONES (FOTOS DE CIERRE DE DIA)", "$20.00", 0, 0);
            DG_tabla.Rows.Add("DAR SOLICION INMEDIATA A PROBLEMAS MAS TARDAR 5 MIN)  ", "$5.00", 0, 0);
            DG_tabla.Rows.Add("BITACORA DE MANTENIMIENTO, SISTEMA Y PERSONAL EXTERNO", "$10.00", 0, 0);
            DG_tabla.Rows.Add("SOBRANTE, MERCANCIA APARTADA, BASURA", "$5.00", 0, 0);
            DG_tabla.Rows.Add("ELABORAR LA FACTURA LA ENCARGADA DE CAJAS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("AREA LIMPIA (CAJAS, COMPUTADORA, PAQUETERIA, CRISTALES, ESTACIONAMIENTO, BANQUETA, PAREDES, CESTO DE BASURA, MODULO DE ENCARGADAS)", "$5.00", 0, 0);
            //DG_tabla.Rows.Add("APOYO SEMANAL", "", 0, 0);


            DG_tabla.Columns[0].Width = 850;
            DG_tabla.Columns[1].Width = 50;
        }
    }
}
