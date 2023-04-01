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
    public partial class Rep_cubreEncCajas : Form
    {
        public Rep_cubreEncCajas()
        {
            InitializeComponent();
        }


        double totalAcumulado = 0;
        double totalReporte = 0;
        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DG_tabla.Rows.Clear();
            DG_tabla.Columns.Clear();
            DG_tabla.Columns.Add("ASPECTOS", "ASPECTOS");
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

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
            DG_tabla.Rows.Add("APOYO SEMANAL", 0, 0, 0);
            DG_tabla.Rows.Add("DESCUENTO", 0, 0, 0);
            DG_tabla.Rows.Add("TOTAL", 0, 0, 0);
          

            DG_tabla.Columns["ASPECTOS"].Width = 700;




            string query = "SELECT * FROM rd_calif_enc_cajas WHERE inicio_semana ='"+inicio.ToString("yyyy-MM-dd")+"' and fin_semana='"+fin.ToString("yyyy-MM-dd")+"' and puesto ='CUBRE ENC DE CAJAS'";

            try
            {
                MySqlConnection con = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = null;
                int filas = 0;

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    filas++;
                }
                dr.Close();

                ArrayList lista = new ArrayList();
                lista.Clear();
                lista.Add("A");
                lista.Add("B");
                lista.Add("C");
                lista.Add("D");
                lista.Add("E");
                lista.Add("F");


                for (int i = 0; i < filas; i++)
                {
                    DG_tabla.Columns.Add(lista[i].ToString(), "");
                }

                dr = cmd.ExecuteReader();
                int nColumnas = DG_tabla.ColumnCount;
                int col = 1;
                double totalPagar = 0;
#pragma warning disable CS0219 // La variable 'prom' está asignada pero su valor nunca se usa
                double prom = 0;
#pragma warning restore CS0219 // La variable 'prom' está asignada pero su valor nunca se usa
                double apoyo_semanal = 0;
                double descuento = 0;
               
                while (dr.Read())
                {

                    if (col <= nColumnas)
                    {
                        DG_tabla.Columns[col].Name = dr["nom_enc_cajas"].ToString();
                        apoyo_semanal = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                        //prom = Convert.ToDouble(dr["promedio"].ToString());
                        DG_tabla.Columns[col].HeaderText = dr["nom_enc_cajas"].ToString();
                      
                        DG_tabla.Rows[0].Cells[col].Value = dr["presentacion"].ToString();
                        DG_tabla.Rows[1].Cells[col].Value = dr["equipos"].ToString();
                        DG_tabla.Rows[2].Cells[col].Value = dr["fondo"].ToString();
                        DG_tabla.Rows[3].Cells[col].Value = dr["fondos_morralla"].ToString();
                       
                       
                        DG_tabla.Rows[4].Cells[col].Value = dr["solicitar_cambio"].ToString();
                        DG_tabla.Rows[5].Cells[col].Value = dr["mercancia_vitrinas"].ToString();
                        DG_tabla.Rows[6].Cells[col].Value = dr["saludo"].ToString();
                        DG_tabla.Rows[7].Cells[col].Value = dr["sugerencias_solucionadas"].ToString();

                        DG_tabla.Rows[8].Cells[col].Value = dr["gafete"].ToString();
                        DG_tabla.Rows[9].Cells[col].Value = dr["fondo_adicional"].ToString();
                        DG_tabla.Rows[10].Cells[col].Value = dr["fondo_adicional"].ToString();
                        DG_tabla.Rows[11].Cells[col].Value = dr["presentacion_verif"].ToString();
                        DG_tabla.Rows[12].Cells[col].Value = dr["pelotas"].ToString();
                        DG_tabla.Rows[13].Cells[col].Value = dr["caja_entrada"].ToString();
                        DG_tabla.Rows[14].Cells[col].Value = dr["depuracion_conceptos"].ToString();
                        DG_tabla.Rows[15].Cells[col].Value = dr["caja_cliente"].ToString();
                        DG_tabla.Rows[16].Cells[col].Value = dr["reunion_diaria"].ToString();
                        DG_tabla.Rows[17].Cells[col].Value = dr["cortes"].ToString();
                        DG_tabla.Rows[18].Cells[col].Value = dr["policia"].ToString();
                        DG_tabla.Rows[19].Cells[col].Value = dr["envio_comisiones"].ToString();
                        DG_tabla.Rows[20].Cells[col].Value = dr["gastos_ordenados"].ToString();
                        DG_tabla.Rows[21].Cells[col].Value = dr["apertura_caja"].ToString();
                        DG_tabla.Rows[22].Cells[col].Value = dr["carritos_limpios"].ToString();
                        DG_tabla.Rows[23].Cells[col].Value = dr["trabajo_personal"].ToString();
                        DG_tabla.Rows[24].Cells[col].Value = dr["area_sola"].ToString();
                        DG_tabla.Rows[25].Cells[col].Value = dr["retiro_cajas"].ToString();
                        DG_tabla.Rows[26].Cells[col].Value = dr["exhibicion_productos"].ToString();
                        DG_tabla.Rows[27].Cells[col].Value = dr["precios_exhibidos"].ToString();
                        DG_tabla.Rows[28].Cells[col].Value = dr["precios_ofertas"].ToString();
                        DG_tabla.Rows[29].Cells[col].Value = dr["atencion_cliente"].ToString();
                        DG_tabla.Rows[30].Cells[col].Value = dr["no_regresar_cliente"].ToString();
                        DG_tabla.Rows[31].Cells[col].Value = dr["digitos4"].ToString();
                        DG_tabla.Rows[32].Cells[col].Value = dr["formato_cubres"].ToString();
                        DG_tabla.Rows[33].Cells[col].Value = dr["comida"].ToString();
                        DG_tabla.Rows[34].Cells[col].Value = dr["info_tienda"].ToString();
                        DG_tabla.Rows[35].Cells[col].Value = dr["comisiones"].ToString();
                        DG_tabla.Rows[36].Cells[col].Value = dr["solucion_problemas"].ToString();
                        DG_tabla.Rows[37].Cells[col].Value = dr["bitacora"].ToString();
                        DG_tabla.Rows[38].Cells[col].Value = dr["sobrante"].ToString();
                        DG_tabla.Rows[39].Cells[col].Value = dr["factura"].ToString();
                        DG_tabla.Rows[40].Cells[col].Value = dr["area_limpia"].ToString();


                        descuento = Convert.ToDouble(dr["totaldesc"].ToString());
                        apoyo_semanal = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                        DG_tabla.Rows[41].Cells[col].Value = apoyo_semanal.ToString("C2");
                        totalPagar = apoyo_semanal - descuento;
                        DG_tabla.Rows[42].Cells[col].Value = descuento.ToString("C2");
                        DG_tabla.Rows[43].Cells[col].Value = totalPagar.ToString("C2");

                        totalAcumulado += totalPagar;
                        col++;

                    }

                }
                dr.Close();

                TB_total.Text = totalAcumulado.ToString("C2");
                totalPagar = 0;
                totalReporte = totalAcumulado;
                totalAcumulado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la informacion: "+ex);
            }
        }

        private void Rep_cubreEncCajas_Load(object sender, EventArgs e)
        {
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

            DG_tabla.Columns["ASPECTOS"].Width = 700;
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_tabla.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;

                }



            }


            //for (int i = 1; i < DG_tabla.Columns.Count; i++)
            //{
            //    totalAcumulado += Convert.ToDouble(DG_tabla.Rows[43].Cells[i].Value);
            //}

            excel.Range["F49"].Value = totalReporte.ToString("C2");
            excel.Visible = true;
        }
    }
}
