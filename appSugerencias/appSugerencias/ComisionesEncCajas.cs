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
    public partial class ComisionesEncCajas : Form
    {

#pragma warning disable CS0414 // El campo 'ComisionesEncCajas.apoyo_semanal' está asignado pero su valor nunca se usa
        int apoyo_semanal = 0;
#pragma warning restore CS0414 // El campo 'ComisionesEncCajas.apoyo_semanal' está asignado pero su valor nunca se usa
        int presentacion = 0, equipos = 0, fondo = 0, fondo_morralla = 0, solicitar_cambio = 0, mercancia_vitrinas = 0, saludo = 0, sugerencias_solucionadas = 0, gafete = 0, fondo_adicional = 0, presentacion_verif = 0;
        int pelotas = 0, caja_entrada = 0, depuracion_conceptos = 0, caja_cliente = 0, reunion_diaria = 0, cortes = 0, policia = 0, envio_comisiones = 0, gastos_ordenados = 0, apertura_caja = 0, carritos_limpios = 0, trabajo_personal = 0;
        int area_sola = 0, retiro_cajas = 0, exhibicion_productos = 0, precios_exhibidos = 0, precios_oferta = 0, atencion_cliente = 0, no_regresar_cliente = 0, digitos4 = 0, formato_cubres = 0, comida = 0, info_tienda = 0;
        int reporte_camaras = 0, comisiones = 0, solucion_problemas = 0, bitacora = 0, sobrante = 0, factura = 0, area_limpia = 0;
        double comisionTotal = 0;

        public ComisionesEncCajas()
        {
            InitializeComponent();
        }



        private void BT_exportar_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


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

            comisionTotal = 0;
            for (int i = 6; i < DG_tabla.Columns.Count; i++)
            {
               comisionTotal+=Convert.ToDouble(DG_tabla.Rows[43].Cells[i].Value);
            }

            excel.Cells.Range["A3:F3"].Merge();
            excel.Cells.Range["A3"].Value = "COMISIONES DE LA SEMANA DEL " + inicio.ToString("dd-MM-yyyy") + " AL " + fin.ToString("dd-MM-yyyy") + "";
            excel.Cells.Range["B6:J49"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["K49"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["K49"].Value = comisionTotal;



            excel.Visible = true;
        }

        public void Calcular()
        {
            for (int i = 2; i < 6; i++)
            {
                presentacion = Convert.ToInt32(DG_tabla.Rows[0].Cells[i].Value);
                equipos = Convert.ToInt32(DG_tabla.Rows[1].Cells[i].Value);
                fondo = Convert.ToInt32(DG_tabla.Rows[2].Cells[i].Value);
                fondo_morralla = Convert.ToInt32(DG_tabla.Rows[3].Cells[i].Value);
                solicitar_cambio = Convert.ToInt32(DG_tabla.Rows[4].Cells[i].Value);
                mercancia_vitrinas = Convert.ToInt32(DG_tabla.Rows[5].Cells[i].Value);
                saludo = Convert.ToInt32(DG_tabla.Rows[6].Cells[i].Value);
                sugerencias_solucionadas = Convert.ToInt32(DG_tabla.Rows[7].Cells[i].Value);
                gafete = Convert.ToInt32(DG_tabla.Rows[8].Cells[i].Value);
                fondo_adicional = Convert.ToInt32(DG_tabla.Rows[9].Cells[i].Value);
                presentacion_verif = Convert.ToInt32(DG_tabla.Rows[10].Cells[i].Value);
                pelotas = Convert.ToInt32(DG_tabla.Rows[11].Cells[i].Value);
                caja_entrada = Convert.ToInt32(DG_tabla.Rows[12].Cells[i].Value);
                depuracion_conceptos = Convert.ToInt32(DG_tabla.Rows[13].Cells[i].Value);
                caja_cliente = Convert.ToInt32(DG_tabla.Rows[14].Cells[i].Value);
                reunion_diaria = Convert.ToInt32(DG_tabla.Rows[15].Cells[i].Value);
                cortes = Convert.ToInt32(DG_tabla.Rows[16].Cells[i].Value);
                policia = Convert.ToInt32(DG_tabla.Rows[17].Cells[i].Value);
                envio_comisiones = Convert.ToInt32(DG_tabla.Rows[18].Cells[i].Value);
                gastos_ordenados = Convert.ToInt32(DG_tabla.Rows[19].Cells[i].Value);
                apertura_caja = Convert.ToInt32(DG_tabla.Rows[20].Cells[i].Value);
                carritos_limpios = Convert.ToInt32(DG_tabla.Rows[21].Cells[i].Value);
                trabajo_personal = Convert.ToInt32(DG_tabla.Rows[22].Cells[i].Value);
                area_sola = Convert.ToInt32(DG_tabla.Rows[23].Cells[i].Value);
                retiro_cajas = Convert.ToInt32(DG_tabla.Rows[24].Cells[i].Value);
                exhibicion_productos = Convert.ToInt32(DG_tabla.Rows[25].Cells[i].Value);
                precios_exhibidos = Convert.ToInt32(DG_tabla.Rows[26].Cells[i].Value);
                precios_oferta = Convert.ToInt32(DG_tabla.Rows[27].Cells[i].Value);
                atencion_cliente = Convert.ToInt32(DG_tabla.Rows[28].Cells[i].Value);
                no_regresar_cliente = Convert.ToInt32(DG_tabla.Rows[29].Cells[i].Value);
                digitos4 = Convert.ToInt32(DG_tabla.Rows[30].Cells[i].Value);
                formato_cubres = Convert.ToInt32(DG_tabla.Rows[31].Cells[i].Value);
                comida = Convert.ToInt32(DG_tabla.Rows[32].Cells[i].Value);
                info_tienda = Convert.ToInt32(DG_tabla.Rows[33].Cells[i].Value);
                reporte_camaras = Convert.ToInt32(DG_tabla.Rows[34].Cells[i].Value);
                comisiones = Convert.ToInt32(DG_tabla.Rows[35].Cells[i].Value);
                solucion_problemas = Convert.ToInt32(DG_tabla.Rows[36].Cells[i].Value);
                bitacora = Convert.ToInt32(DG_tabla.Rows[37].Cells[i].Value);
                sobrante = Convert.ToInt32(DG_tabla.Rows[38].Cells[i].Value);
                factura = Convert.ToInt32(DG_tabla.Rows[39].Cells[i].Value);
                area_limpia = Convert.ToInt32(DG_tabla.Rows[40].Cells[i].Value);

                DG_tabla.Rows[0].Cells[i + 4].Value = presentacion * 5;
                DG_tabla.Rows[1].Cells[i + 4].Value = equipos * 5;
                DG_tabla.Rows[2].Cells[i + 4].Value = fondo * 20;
                DG_tabla.Rows[3].Cells[i + 4].Value = fondo_morralla * 5;
                DG_tabla.Rows[4].Cells[i + 4].Value = solicitar_cambio * 5;
                DG_tabla.Rows[5].Cells[i + 4].Value = mercancia_vitrinas * 5;
                DG_tabla.Rows[6].Cells[i + 4].Value = saludo * 3;
                DG_tabla.Rows[7].Cells[i + 4].Value = sugerencias_solucionadas * 10;
                DG_tabla.Rows[8].Cells[i + 4].Value = gafete * 3;
                DG_tabla.Rows[9].Cells[i + 4].Value = fondo_adicional * 10;
                DG_tabla.Rows[10].Cells[i + 4].Value = presentacion_verif * 3;
                DG_tabla.Rows[11].Cells[i + 4].Value = pelotas * 5;
                DG_tabla.Rows[12].Cells[i + 4].Value = caja_entrada * 10;
                DG_tabla.Rows[13].Cells[i + 4].Value = depuracion_conceptos * 10;
                DG_tabla.Rows[14].Cells[i + 4].Value = caja_cliente * 10;
                DG_tabla.Rows[15].Cells[i + 4].Value = reunion_diaria * 5;
                DG_tabla.Rows[16].Cells[i + 4].Value = cortes * 10;
                DG_tabla.Rows[17].Cells[i + 4].Value = policia * 10;
                DG_tabla.Rows[18].Cells[i + 4].Value = envio_comisiones * 10;
                DG_tabla.Rows[19].Cells[i + 4].Value = gastos_ordenados * 5;
                DG_tabla.Rows[20].Cells[i + 4].Value = apertura_caja * 20;
                DG_tabla.Rows[21].Cells[i + 4].Value = carritos_limpios * 10;
                DG_tabla.Rows[22].Cells[i + 4].Value = trabajo_personal * 10;
                DG_tabla.Rows[23].Cells[i + 4].Value = area_sola * 20;
                DG_tabla.Rows[24].Cells[i + 4].Value = retiro_cajas * 20;
                DG_tabla.Rows[25].Cells[i + 4].Value = exhibicion_productos * 5;
                DG_tabla.Rows[26].Cells[i + 4].Value = precios_exhibidos * 5;
                DG_tabla.Rows[27].Cells[i + 4].Value = precios_oferta * 5;
                DG_tabla.Rows[28].Cells[i + 4].Value = atencion_cliente * 10;
                DG_tabla.Rows[29].Cells[i + 4].Value = no_regresar_cliente * 10;
                DG_tabla.Rows[30].Cells[i + 4].Value = digitos4 * 5;
                DG_tabla.Rows[31].Cells[i + 4].Value = formato_cubres * 20;
                DG_tabla.Rows[32].Cells[i + 4].Value = comida * 5;
                DG_tabla.Rows[33].Cells[i + 4].Value = info_tienda * 5;
                DG_tabla.Rows[34].Cells[i + 4].Value = reporte_camaras * 10;
                DG_tabla.Rows[35].Cells[i + 4].Value = comisiones * 20;
                DG_tabla.Rows[36].Cells[i + 4].Value = solucion_problemas * 5;
                DG_tabla.Rows[37].Cells[i + 4].Value = bitacora * 10;
                DG_tabla.Rows[38].Cells[i + 4].Value = sobrante * 5;
                DG_tabla.Rows[39].Cells[i + 4].Value = factura * 5;
                DG_tabla.Rows[40].Cells[i + 4].Value = area_limpia * 5;

                DG_tabla.Columns["TOTALVALLARTA"].DefaultCellStyle.Format="C2";
                DG_tabla.Columns["TOTALRENA"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["TOTALVELAZQUEZ"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["TOTALCOLOSO"].DefaultCellStyle.Format = "C2";

                DG_tabla.Rows[41].DefaultCellStyle.BackColor = Color.SeaGreen;
                DG_tabla.Rows[42].DefaultCellStyle.BackColor = Color.SeaGreen;
                DG_tabla.Rows[43].DefaultCellStyle.BackColor = Color.SeaGreen;
                DG_tabla.Rows[44].DefaultCellStyle.BackColor = Color.SeaGreen;
                DG_tabla.Rows[41].DefaultCellStyle.ForeColor = Color.White;
                DG_tabla.Rows[42].DefaultCellStyle.ForeColor = Color.White;
                DG_tabla.Rows[43].DefaultCellStyle.ForeColor = Color.White;
                DG_tabla.Rows[44].DefaultCellStyle.ForeColor = Color.White;





            }
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {


        

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


            string query = "SELECT * FROM rd_calif_enc_cajas WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "' and puesto ='ENC DE CAJAS'";
            //string query1 = "SELECT * FROM rd_calif_enc_cajas_va WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "'";
            //string query2 = "SELECT * FROM rd_calif_enc_cajas_re WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "'";
            //string query3 = "SELECT * FROM rd_calif_enc_cajas_ve WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "'";
            //string query4 = "SELECT * FROM rd_calif_enc_cajas_co WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "'";

            MySqlConnection con = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand(query, con);
            string sucursal = "";
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sucursal = dr["sucursal"].ToString();

                if (sucursal.Equals("VALLARTA"))
                {
                    DG_tabla.Rows[0].Cells[2].Value = Convert.ToInt32(dr["presentacion"].ToString());
                    DG_tabla.Rows[1].Cells[2].Value = Convert.ToInt32(dr["equipos"].ToString());
                    DG_tabla.Rows[2].Cells[2].Value = Convert.ToInt32(dr["fondo"].ToString());
                    DG_tabla.Rows[3].Cells[2].Value = Convert.ToInt32(dr["fondos_morralla"].ToString());
                    DG_tabla.Rows[4].Cells[2].Value = Convert.ToInt32(dr["solicitar_cambio"].ToString());
                    DG_tabla.Rows[5].Cells[2].Value = Convert.ToInt32(dr["mercancia_vitrinas"].ToString());
                    DG_tabla.Rows[6].Cells[2].Value = Convert.ToInt32(dr["saludo"].ToString());
                    DG_tabla.Rows[7].Cells[2].Value = Convert.ToInt32(dr["sugerencias_solucionadas"].ToString());
                    DG_tabla.Rows[8].Cells[2].Value = Convert.ToInt32(dr["gafete"].ToString());
                    DG_tabla.Rows[9].Cells[2].Value = Convert.ToInt32(dr["fondo_adicional"].ToString());
                    DG_tabla.Rows[10].Cells[2].Value = Convert.ToInt32(dr["presentacion_verif"].ToString());
                    DG_tabla.Rows[11].Cells[2].Value = Convert.ToInt32(dr["pelotas"].ToString());
                    DG_tabla.Rows[12].Cells[2].Value = Convert.ToInt32(dr["caja_entrada"].ToString());
                    DG_tabla.Rows[13].Cells[2].Value = Convert.ToInt32(dr["depuracion_conceptos"].ToString());
                    DG_tabla.Rows[14].Cells[2].Value = Convert.ToInt32(dr["caja_cliente"].ToString());
                    DG_tabla.Rows[15].Cells[2].Value = Convert.ToInt32(dr["reunion_diaria"].ToString());
                    DG_tabla.Rows[16].Cells[2].Value = Convert.ToInt32(dr["cortes"].ToString());
                    DG_tabla.Rows[17].Cells[2].Value = Convert.ToInt32(dr["policia"].ToString());
                    DG_tabla.Rows[18].Cells[2].Value = Convert.ToInt32(dr["envio_comisiones"].ToString());
                    DG_tabla.Rows[19].Cells[2].Value = Convert.ToInt32(dr["gastos_ordenados"].ToString());
                    DG_tabla.Rows[20].Cells[2].Value = Convert.ToInt32(dr["apertura_caja"].ToString());
                    DG_tabla.Rows[21].Cells[2].Value = Convert.ToInt32(dr["carritos_limpios"].ToString());
                    DG_tabla.Rows[22].Cells[2].Value = Convert.ToInt32(dr["trabajo_personal"].ToString());
                    DG_tabla.Rows[23].Cells[2].Value = Convert.ToInt32(dr["area_sola"].ToString());
                    DG_tabla.Rows[24].Cells[2].Value = Convert.ToInt32(dr["retiro_cajas"].ToString());
                    DG_tabla.Rows[25].Cells[2].Value = Convert.ToInt32(dr["exhibicion_productos"].ToString());
                    DG_tabla.Rows[26].Cells[2].Value = Convert.ToInt32(dr["precios_exhibidos"].ToString());
                    DG_tabla.Rows[27].Cells[2].Value = Convert.ToInt32(dr["precios_ofertas"].ToString());
                    DG_tabla.Rows[28].Cells[2].Value = Convert.ToInt32(dr["atencion_cliente"].ToString());
                    DG_tabla.Rows[29].Cells[2].Value = Convert.ToInt32(dr["no_regresar_cliente"].ToString());
                    DG_tabla.Rows[30].Cells[2].Value = Convert.ToInt32(dr["digitos4"].ToString());
                    DG_tabla.Rows[31].Cells[2].Value = Convert.ToInt32(dr["formato_cubres"].ToString());
                    DG_tabla.Rows[32].Cells[2].Value = Convert.ToInt32(dr["comida"].ToString());
                    DG_tabla.Rows[33].Cells[2].Value = Convert.ToInt32(dr["info_tienda"].ToString());
                    DG_tabla.Rows[34].Cells[2].Value = Convert.ToInt32(dr["reporte_camaras"].ToString());
                    DG_tabla.Rows[35].Cells[2].Value = Convert.ToInt32(dr["comisiones"].ToString());
                    DG_tabla.Rows[36].Cells[2].Value = Convert.ToInt32(dr["solucion_problemas"].ToString());
                    DG_tabla.Rows[37].Cells[2].Value = Convert.ToInt32(dr["bitacora"].ToString());
                    DG_tabla.Rows[38].Cells[2].Value = Convert.ToInt32(dr["sobrante"].ToString());
                    DG_tabla.Rows[39].Cells[2].Value = Convert.ToInt32(dr["factura"].ToString());
                    DG_tabla.Rows[40].Cells[2].Value = Convert.ToInt32(dr["area_limpia"].ToString());
                    DG_tabla.Rows[41].Cells[6].Value = Convert.ToInt32(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[42].Cells[6].Value = Convert.ToInt32(dr["totaldesc"].ToString());
                    DG_tabla.Rows[43].Cells[6].Value = Convert.ToInt32(dr["totalpagar"].ToString());
                    DG_tabla.Rows[44].Cells[6].Value = dr["nom_enc_cajas"].ToString();
                }

                if (sucursal.Equals("RENA"))
                {
                    DG_tabla.Rows[0].Cells[3].Value = Convert.ToInt32(dr["presentacion"].ToString());
                    DG_tabla.Rows[1].Cells[3].Value = Convert.ToInt32(dr["equipos"].ToString());
                    DG_tabla.Rows[2].Cells[3].Value = Convert.ToInt32(dr["fondo"].ToString());
                    DG_tabla.Rows[3].Cells[3].Value = Convert.ToInt32(dr["fondos_morralla"].ToString());
                    DG_tabla.Rows[4].Cells[3].Value = Convert.ToInt32(dr["solicitar_cambio"].ToString());
                    DG_tabla.Rows[5].Cells[3].Value = Convert.ToInt32(dr["mercancia_vitrinas"].ToString());
                    DG_tabla.Rows[6].Cells[3].Value = Convert.ToInt32(dr["saludo"].ToString());
                    DG_tabla.Rows[7].Cells[3].Value = Convert.ToInt32(dr["sugerencias_solucionadas"].ToString());
                    DG_tabla.Rows[8].Cells[3].Value = Convert.ToInt32(dr["gafete"].ToString());
                    DG_tabla.Rows[9].Cells[3].Value = Convert.ToInt32(dr["fondo_adicional"].ToString());
                    DG_tabla.Rows[10].Cells[3].Value = Convert.ToInt32(dr["presentacion_verif"].ToString());
                    DG_tabla.Rows[11].Cells[3].Value = Convert.ToInt32(dr["pelotas"].ToString());
                    DG_tabla.Rows[12].Cells[3].Value = Convert.ToInt32(dr["caja_entrada"].ToString());
                    DG_tabla.Rows[13].Cells[3].Value = Convert.ToInt32(dr["depuracion_conceptos"].ToString());
                    DG_tabla.Rows[14].Cells[3].Value = Convert.ToInt32(dr["caja_cliente"].ToString());
                    DG_tabla.Rows[15].Cells[3].Value = Convert.ToInt32(dr["reunion_diaria"].ToString());
                    DG_tabla.Rows[16].Cells[3].Value = Convert.ToInt32(dr["cortes"].ToString());
                    DG_tabla.Rows[17].Cells[3].Value = Convert.ToInt32(dr["policia"].ToString());
                    DG_tabla.Rows[18].Cells[3].Value = Convert.ToInt32(dr["envio_comisiones"].ToString());
                    DG_tabla.Rows[19].Cells[3].Value = Convert.ToInt32(dr["gastos_ordenados"].ToString());
                    DG_tabla.Rows[20].Cells[3].Value = Convert.ToInt32(dr["apertura_caja"].ToString());
                    DG_tabla.Rows[21].Cells[3].Value = Convert.ToInt32(dr["carritos_limpios"].ToString());
                    DG_tabla.Rows[22].Cells[3].Value = Convert.ToInt32(dr["trabajo_personal"].ToString());
                    DG_tabla.Rows[23].Cells[3].Value = Convert.ToInt32(dr["area_sola"].ToString());
                    DG_tabla.Rows[24].Cells[3].Value = Convert.ToInt32(dr["retiro_cajas"].ToString());
                    DG_tabla.Rows[25].Cells[3].Value = Convert.ToInt32(dr["exhibicion_productos"].ToString());
                    DG_tabla.Rows[26].Cells[3].Value = Convert.ToInt32(dr["precios_exhibidos"].ToString());
                    DG_tabla.Rows[27].Cells[3].Value = Convert.ToInt32(dr["precios_ofertas"].ToString());
                    DG_tabla.Rows[28].Cells[3].Value = Convert.ToInt32(dr["atencion_cliente"].ToString());
                    DG_tabla.Rows[29].Cells[3].Value = Convert.ToInt32(dr["no_regresar_cliente"].ToString());
                    DG_tabla.Rows[30].Cells[3].Value = Convert.ToInt32(dr["digitos4"].ToString());
                    DG_tabla.Rows[31].Cells[3].Value = Convert.ToInt32(dr["formato_cubres"].ToString());
                    DG_tabla.Rows[32].Cells[3].Value = Convert.ToInt32(dr["comida"].ToString());
                    DG_tabla.Rows[33].Cells[3].Value = Convert.ToInt32(dr["info_tienda"].ToString());
                    DG_tabla.Rows[34].Cells[3].Value = Convert.ToInt32(dr["reporte_camaras"].ToString());
                    DG_tabla.Rows[35].Cells[3].Value = Convert.ToInt32(dr["comisiones"].ToString());
                    DG_tabla.Rows[36].Cells[3].Value = Convert.ToInt32(dr["solucion_problemas"].ToString());
                    DG_tabla.Rows[37].Cells[3].Value = Convert.ToInt32(dr["bitacora"].ToString());
                    DG_tabla.Rows[38].Cells[3].Value = Convert.ToInt32(dr["sobrante"].ToString());
                    DG_tabla.Rows[39].Cells[3].Value = Convert.ToInt32(dr["factura"].ToString());
                    DG_tabla.Rows[40].Cells[3].Value = Convert.ToInt32(dr["area_limpia"].ToString());
                    DG_tabla.Rows[41].Cells[7].Value = Convert.ToInt32(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[42].Cells[7].Value = Convert.ToInt32(dr["totaldesc"].ToString());
                    DG_tabla.Rows[43].Cells[7].Value = Convert.ToInt32(dr["totalpagar"].ToString());
                    DG_tabla.Rows[44].Cells[7].Value = dr["nom_enc_cajas"].ToString();
                }

                if (sucursal.Equals("VELAZQUEZ"))
                {

                    DG_tabla.Rows[0].Cells[4].Value = Convert.ToInt32(dr["presentacion"].ToString());
                    DG_tabla.Rows[1].Cells[4].Value = Convert.ToInt32(dr["equipos"].ToString());
                    DG_tabla.Rows[2].Cells[4].Value = Convert.ToInt32(dr["fondo"].ToString());
                    DG_tabla.Rows[3].Cells[4].Value = Convert.ToInt32(dr["fondos_morralla"].ToString());
                    DG_tabla.Rows[4].Cells[4].Value = Convert.ToInt32(dr["solicitar_cambio"].ToString());
                    DG_tabla.Rows[5].Cells[4].Value = Convert.ToInt32(dr["mercancia_vitrinas"].ToString());
                    DG_tabla.Rows[6].Cells[4].Value = Convert.ToInt32(dr["saludo"].ToString());
                    DG_tabla.Rows[7].Cells[4].Value = Convert.ToInt32(dr["sugerencias_solucionadas"].ToString());
                    DG_tabla.Rows[8].Cells[4].Value = Convert.ToInt32(dr["gafete"].ToString());
                    DG_tabla.Rows[9].Cells[4].Value = Convert.ToInt32(dr["fondo_adicional"].ToString());
                    DG_tabla.Rows[10].Cells[4].Value = Convert.ToInt32(dr["presentacion_verif"].ToString());
                    DG_tabla.Rows[11].Cells[4].Value = Convert.ToInt32(dr["pelotas"].ToString());
                    DG_tabla.Rows[12].Cells[4].Value = Convert.ToInt32(dr["caja_entrada"].ToString());
                    DG_tabla.Rows[13].Cells[4].Value = Convert.ToInt32(dr["depuracion_conceptos"].ToString());
                    DG_tabla.Rows[14].Cells[4].Value = Convert.ToInt32(dr["caja_cliente"].ToString());
                    DG_tabla.Rows[15].Cells[4].Value = Convert.ToInt32(dr["reunion_diaria"].ToString());
                    DG_tabla.Rows[16].Cells[4].Value = Convert.ToInt32(dr["cortes"].ToString());
                    DG_tabla.Rows[17].Cells[4].Value = Convert.ToInt32(dr["policia"].ToString());
                    DG_tabla.Rows[18].Cells[4].Value = Convert.ToInt32(dr["envio_comisiones"].ToString());
                    DG_tabla.Rows[19].Cells[4].Value = Convert.ToInt32(dr["gastos_ordenados"].ToString());
                    DG_tabla.Rows[20].Cells[4].Value = Convert.ToInt32(dr["apertura_caja"].ToString());
                    DG_tabla.Rows[21].Cells[4].Value = Convert.ToInt32(dr["carritos_limpios"].ToString());
                    DG_tabla.Rows[22].Cells[4].Value = Convert.ToInt32(dr["trabajo_personal"].ToString());
                    DG_tabla.Rows[23].Cells[4].Value = Convert.ToInt32(dr["area_sola"].ToString());
                    DG_tabla.Rows[24].Cells[4].Value = Convert.ToInt32(dr["retiro_cajas"].ToString());
                    DG_tabla.Rows[25].Cells[4].Value = Convert.ToInt32(dr["exhibicion_productos"].ToString());
                    DG_tabla.Rows[26].Cells[4].Value = Convert.ToInt32(dr["precios_exhibidos"].ToString());
                    DG_tabla.Rows[27].Cells[4].Value = Convert.ToInt32(dr["precios_ofertas"].ToString());
                    DG_tabla.Rows[28].Cells[4].Value = Convert.ToInt32(dr["atencion_cliente"].ToString());
                    DG_tabla.Rows[29].Cells[4].Value = Convert.ToInt32(dr["no_regresar_cliente"].ToString());
                    DG_tabla.Rows[30].Cells[4].Value = Convert.ToInt32(dr["digitos4"].ToString());
                    DG_tabla.Rows[31].Cells[4].Value = Convert.ToInt32(dr["formato_cubres"].ToString());
                    DG_tabla.Rows[32].Cells[4].Value = Convert.ToInt32(dr["comida"].ToString());
                    DG_tabla.Rows[33].Cells[4].Value = Convert.ToInt32(dr["info_tienda"].ToString());
                    DG_tabla.Rows[34].Cells[4].Value = Convert.ToInt32(dr["reporte_camaras"].ToString());
                    DG_tabla.Rows[35].Cells[4].Value = Convert.ToInt32(dr["comisiones"].ToString());
                    DG_tabla.Rows[36].Cells[4].Value = Convert.ToInt32(dr["solucion_problemas"].ToString());
                    DG_tabla.Rows[37].Cells[4].Value = Convert.ToInt32(dr["bitacora"].ToString());
                    DG_tabla.Rows[38].Cells[4].Value = Convert.ToInt32(dr["sobrante"].ToString());
                    DG_tabla.Rows[39].Cells[4].Value = Convert.ToInt32(dr["factura"].ToString());
                    DG_tabla.Rows[40].Cells[4].Value = Convert.ToInt32(dr["area_limpia"].ToString());
                    DG_tabla.Rows[41].Cells[8].Value = Convert.ToInt32(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[42].Cells[8].Value = Convert.ToInt32(dr["totaldesc"].ToString());
                    DG_tabla.Rows[43].Cells[8].Value = Convert.ToInt32(dr["totalpagar"].ToString());
                    DG_tabla.Rows[44].Cells[8].Value = dr["nom_enc_cajas"].ToString();

                }

                if (sucursal.Equals("COLOSO"))
                {
                    DG_tabla.Rows[0].Cells[5].Value = Convert.ToInt32(dr["presentacion"].ToString());
                    DG_tabla.Rows[1].Cells[5].Value = Convert.ToInt32(dr["equipos"].ToString());
                    DG_tabla.Rows[2].Cells[5].Value = Convert.ToInt32(dr["fondo"].ToString());
                    DG_tabla.Rows[3].Cells[5].Value = Convert.ToInt32(dr["fondos_morralla"].ToString());
                    DG_tabla.Rows[4].Cells[5].Value = Convert.ToInt32(dr["solicitar_cambio"].ToString());
                    DG_tabla.Rows[5].Cells[5].Value = Convert.ToInt32(dr["mercancia_vitrinas"].ToString());
                    DG_tabla.Rows[6].Cells[5].Value = Convert.ToInt32(dr["saludo"].ToString());
                    DG_tabla.Rows[7].Cells[5].Value = Convert.ToInt32(dr["sugerencias_solucionadas"].ToString());
                    DG_tabla.Rows[8].Cells[5].Value = Convert.ToInt32(dr["gafete"].ToString());
                    DG_tabla.Rows[9].Cells[5].Value = Convert.ToInt32(dr["fondo_adicional"].ToString());
                    DG_tabla.Rows[10].Cells[5].Value = Convert.ToInt32(dr["presentacion_verif"].ToString());
                    DG_tabla.Rows[11].Cells[5].Value = Convert.ToInt32(dr["pelotas"].ToString());
                    DG_tabla.Rows[12].Cells[5].Value = Convert.ToInt32(dr["caja_entrada"].ToString());
                    DG_tabla.Rows[13].Cells[5].Value = Convert.ToInt32(dr["depuracion_conceptos"].ToString());
                    DG_tabla.Rows[14].Cells[5].Value = Convert.ToInt32(dr["caja_cliente"].ToString());
                    DG_tabla.Rows[15].Cells[5].Value = Convert.ToInt32(dr["reunion_diaria"].ToString());
                    DG_tabla.Rows[16].Cells[5].Value = Convert.ToInt32(dr["cortes"].ToString());
                    DG_tabla.Rows[17].Cells[5].Value = Convert.ToInt32(dr["policia"].ToString());
                    DG_tabla.Rows[18].Cells[5].Value = Convert.ToInt32(dr["envio_comisiones"].ToString());
                    DG_tabla.Rows[19].Cells[5].Value = Convert.ToInt32(dr["gastos_ordenados"].ToString());
                    DG_tabla.Rows[20].Cells[5].Value = Convert.ToInt32(dr["apertura_caja"].ToString());
                    DG_tabla.Rows[21].Cells[5].Value = Convert.ToInt32(dr["carritos_limpios"].ToString());
                    DG_tabla.Rows[22].Cells[5].Value = Convert.ToInt32(dr["trabajo_personal"].ToString());
                    DG_tabla.Rows[23].Cells[5].Value = Convert.ToInt32(dr["area_sola"].ToString());
                    DG_tabla.Rows[24].Cells[5].Value = Convert.ToInt32(dr["retiro_cajas"].ToString());
                    DG_tabla.Rows[25].Cells[5].Value = Convert.ToInt32(dr["exhibicion_productos"].ToString());
                    DG_tabla.Rows[26].Cells[5].Value = Convert.ToInt32(dr["precios_exhibidos"].ToString());
                    DG_tabla.Rows[27].Cells[5].Value = Convert.ToInt32(dr["precios_ofertas"].ToString());
                    DG_tabla.Rows[28].Cells[5].Value = Convert.ToInt32(dr["atencion_cliente"].ToString());
                    DG_tabla.Rows[29].Cells[5].Value = Convert.ToInt32(dr["no_regresar_cliente"].ToString());
                    DG_tabla.Rows[30].Cells[5].Value = Convert.ToInt32(dr["digitos4"].ToString());
                    DG_tabla.Rows[31].Cells[5].Value = Convert.ToInt32(dr["formato_cubres"].ToString());
                    DG_tabla.Rows[32].Cells[5].Value = Convert.ToInt32(dr["comida"].ToString());
                    DG_tabla.Rows[33].Cells[5].Value = Convert.ToInt32(dr["info_tienda"].ToString());
                    DG_tabla.Rows[34].Cells[5].Value = Convert.ToInt32(dr["reporte_camaras"].ToString());
                    DG_tabla.Rows[35].Cells[5].Value = Convert.ToInt32(dr["comisiones"].ToString());
                    DG_tabla.Rows[36].Cells[5].Value = Convert.ToInt32(dr["solucion_problemas"].ToString());
                    DG_tabla.Rows[37].Cells[5].Value = Convert.ToInt32(dr["bitacora"].ToString());
                    DG_tabla.Rows[38].Cells[5].Value = Convert.ToInt32(dr["sobrante"].ToString());
                    DG_tabla.Rows[39].Cells[5].Value = Convert.ToInt32(dr["factura"].ToString());
                    DG_tabla.Rows[40].Cells[5].Value = Convert.ToInt32(dr["area_limpia"].ToString());
                    DG_tabla.Rows[41].Cells[9].Value = Convert.ToInt32(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[42].Cells[9].Value = Convert.ToInt32(dr["totaldesc"].ToString());
                    DG_tabla.Rows[43].Cells[9].Value = Convert.ToInt32(dr["totalpagar"].ToString());
                    DG_tabla.Rows[44].Cells[9].Value = dr["nom_enc_cajas"].ToString();

                }





            }
            dr.Close();



            //MySqlCommand cmdRE = new MySqlCommand(query2, con);
            //MySqlDataReader drRE = cmdRE.ExecuteReader();
            //while (drRE.Read())
            //{
            //    DG_tabla.Rows[0].Cells[3].Value = Convert.ToInt32(drRE["presentacion"].ToString());
            //    DG_tabla.Rows[1].Cells[3].Value = Convert.ToInt32(drRE["equipos"].ToString());
            //    DG_tabla.Rows[2].Cells[3].Value = Convert.ToInt32(drRE["fondo"].ToString());
            //    DG_tabla.Rows[3].Cells[3].Value = Convert.ToInt32(drRE["fondos_morralla"].ToString());
            //    DG_tabla.Rows[4].Cells[3].Value = Convert.ToInt32(drRE["solicitar_cambio"].ToString());
            //    DG_tabla.Rows[5].Cells[3].Value = Convert.ToInt32(drRE["mercancia_vitrinas"].ToString());
            //    DG_tabla.Rows[6].Cells[3].Value = Convert.ToInt32(drRE["saludo"].ToString());
            //    DG_tabla.Rows[7].Cells[3].Value = Convert.ToInt32(drRE["sugerencias_solucionadas"].ToString());
            //    DG_tabla.Rows[8].Cells[3].Value = Convert.ToInt32(drRE["gafete"].ToString());
            //    DG_tabla.Rows[9].Cells[3].Value = Convert.ToInt32(drRE["fondo_adicional"].ToString());
            //    DG_tabla.Rows[10].Cells[3].Value = Convert.ToInt32(drRE["presentacion_verif"].ToString());
            //    DG_tabla.Rows[11].Cells[3].Value = Convert.ToInt32(drRE["pelotas"].ToString());
            //    DG_tabla.Rows[12].Cells[3].Value = Convert.ToInt32(drRE["caja_entrada"].ToString());
            //    DG_tabla.Rows[13].Cells[3].Value = Convert.ToInt32(drRE["depuracion_conceptos"].ToString());
            //    DG_tabla.Rows[14].Cells[3].Value = Convert.ToInt32(drRE["caja_cliente"].ToString());
            //    DG_tabla.Rows[15].Cells[3].Value = Convert.ToInt32(drRE["reunion_diaria"].ToString());
            //    DG_tabla.Rows[16].Cells[3].Value = Convert.ToInt32(drRE["cortes"].ToString());
            //    DG_tabla.Rows[17].Cells[3].Value = Convert.ToInt32(drRE["policia"].ToString());
            //    DG_tabla.Rows[18].Cells[3].Value = Convert.ToInt32(drRE["envio_comisiones"].ToString());
            //    DG_tabla.Rows[19].Cells[3].Value = Convert.ToInt32(drRE["gastos_ordenados"].ToString());
            //    DG_tabla.Rows[20].Cells[3].Value = Convert.ToInt32(drRE["apertura_caja"].ToString());
            //    DG_tabla.Rows[21].Cells[3].Value = Convert.ToInt32(drRE["carritos_limpios"].ToString());
            //    DG_tabla.Rows[22].Cells[3].Value = Convert.ToInt32(drRE["trabajo_personal"].ToString());
            //    DG_tabla.Rows[23].Cells[3].Value = Convert.ToInt32(drRE["area_sola"].ToString());
            //    DG_tabla.Rows[24].Cells[3].Value = Convert.ToInt32(drRE["retiro_cajas"].ToString());
            //    DG_tabla.Rows[25].Cells[3].Value = Convert.ToInt32(drRE["exhibicion_productos"].ToString());
            //    DG_tabla.Rows[26].Cells[3].Value = Convert.ToInt32(drRE["precios_exhibidos"].ToString());
            //    DG_tabla.Rows[27].Cells[3].Value = Convert.ToInt32(drRE["precios_ofertas"].ToString());
            //    DG_tabla.Rows[28].Cells[3].Value = Convert.ToInt32(drRE["atencion_cliente"].ToString());
            //    DG_tabla.Rows[29].Cells[3].Value = Convert.ToInt32(drRE["no_regresar_cliente"].ToString());
            //    DG_tabla.Rows[30].Cells[3].Value = Convert.ToInt32(drRE["digitos4"].ToString());
            //    DG_tabla.Rows[31].Cells[3].Value = Convert.ToInt32(drRE["formato_cubres"].ToString());
            //    DG_tabla.Rows[32].Cells[3].Value = Convert.ToInt32(drRE["comida"].ToString());
            //    DG_tabla.Rows[33].Cells[3].Value = Convert.ToInt32(drRE["info_tienda"].ToString());
            //    DG_tabla.Rows[34].Cells[3].Value = Convert.ToInt32(drRE["reporte_camaras"].ToString());
            //    DG_tabla.Rows[35].Cells[3].Value = Convert.ToInt32(drRE["comisiones"].ToString());
            //    DG_tabla.Rows[36].Cells[3].Value = Convert.ToInt32(drRE["solucion_problemas"].ToString());
            //    DG_tabla.Rows[37].Cells[3].Value = Convert.ToInt32(drRE["bitacora"].ToString());
            //    DG_tabla.Rows[38].Cells[3].Value = Convert.ToInt32(drRE["sobrante"].ToString());
            //    DG_tabla.Rows[39].Cells[3].Value = Convert.ToInt32(drRE["factura"].ToString());
            //    DG_tabla.Rows[40].Cells[3].Value = Convert.ToInt32(drRE["area_limpia"].ToString());
            //    DG_tabla.Rows[41].Cells[7].Value = Convert.ToInt32(drRE["apoyo_semanal"].ToString());
            //    DG_tabla.Rows[42].Cells[7].Value = Convert.ToInt32(drRE["totaldesc"].ToString());
            //    DG_tabla.Rows[43].Cells[7].Value = Convert.ToInt32(drRE["totalpagar"].ToString());
            //    DG_tabla.Rows[44].Cells[7].Value = drRE["nom_enc_cajas"].ToString();
               
            //}
            //drRE.Close();


            //MySqlCommand cmdVE = new MySqlCommand(query3, con);
            //MySqlDataReader drVE = cmdVE.ExecuteReader();
            //while (drVE.Read())
            //{
            //    DG_tabla.Rows[0].Cells[4].Value = Convert.ToInt32(drVE["presentacion"].ToString());
            //    DG_tabla.Rows[1].Cells[4].Value = Convert.ToInt32(drVE["equipos"].ToString());
            //    DG_tabla.Rows[2].Cells[4].Value = Convert.ToInt32(drVE["fondo"].ToString());
            //    DG_tabla.Rows[3].Cells[4].Value = Convert.ToInt32(drVE["fondos_morralla"].ToString());
            //    DG_tabla.Rows[4].Cells[4].Value = Convert.ToInt32(drVE["solicitar_cambio"].ToString());
            //    DG_tabla.Rows[5].Cells[4].Value = Convert.ToInt32(drVE["mercancia_vitrinas"].ToString());
            //    DG_tabla.Rows[6].Cells[4].Value = Convert.ToInt32(drVE["saludo"].ToString());
            //    DG_tabla.Rows[7].Cells[4].Value = Convert.ToInt32(drVE["sugerencias_solucionadas"].ToString());
            //    DG_tabla.Rows[8].Cells[4].Value = Convert.ToInt32(drVE["gafete"].ToString());
            //    DG_tabla.Rows[9].Cells[4].Value = Convert.ToInt32(drVE["fondo_adicional"].ToString());
            //    DG_tabla.Rows[10].Cells[4].Value = Convert.ToInt32(drVE["presentacion_verif"].ToString());
            //    DG_tabla.Rows[11].Cells[4].Value = Convert.ToInt32(drVE["pelotas"].ToString());
            //    DG_tabla.Rows[12].Cells[4].Value = Convert.ToInt32(drVE["caja_entrada"].ToString());
            //    DG_tabla.Rows[13].Cells[4].Value = Convert.ToInt32(drVE["depuracion_conceptos"].ToString());
            //    DG_tabla.Rows[14].Cells[4].Value = Convert.ToInt32(drVE["caja_cliente"].ToString());
            //    DG_tabla.Rows[15].Cells[4].Value = Convert.ToInt32(drVE["reunion_diaria"].ToString());
            //    DG_tabla.Rows[16].Cells[4].Value = Convert.ToInt32(drVE["cortes"].ToString());
            //    DG_tabla.Rows[17].Cells[4].Value = Convert.ToInt32(drVE["policia"].ToString());
            //    DG_tabla.Rows[18].Cells[4].Value = Convert.ToInt32(drVE["envio_comisiones"].ToString());
            //    DG_tabla.Rows[19].Cells[4].Value = Convert.ToInt32(drVE["gastos_ordenados"].ToString());
            //    DG_tabla.Rows[20].Cells[4].Value = Convert.ToInt32(drVE["apertura_caja"].ToString());
            //    DG_tabla.Rows[21].Cells[4].Value = Convert.ToInt32(drVE["carritos_limpios"].ToString());
            //    DG_tabla.Rows[22].Cells[4].Value = Convert.ToInt32(drVE["trabajo_personal"].ToString());
            //    DG_tabla.Rows[23].Cells[4].Value = Convert.ToInt32(drVE["area_sola"].ToString());
            //    DG_tabla.Rows[24].Cells[4].Value = Convert.ToInt32(drVE["retiro_cajas"].ToString());
            //    DG_tabla.Rows[25].Cells[4].Value = Convert.ToInt32(drVE["exhibicion_productos"].ToString());
            //    DG_tabla.Rows[26].Cells[4].Value = Convert.ToInt32(drVE["precios_exhibidos"].ToString());
            //    DG_tabla.Rows[27].Cells[4].Value = Convert.ToInt32(drVE["precios_ofertas"].ToString());
            //    DG_tabla.Rows[28].Cells[4].Value = Convert.ToInt32(drVE["atencion_cliente"].ToString());
            //    DG_tabla.Rows[29].Cells[4].Value = Convert.ToInt32(drVE["no_regresar_cliente"].ToString());
            //    DG_tabla.Rows[30].Cells[4].Value = Convert.ToInt32(drVE["digitos4"].ToString());
            //    DG_tabla.Rows[31].Cells[4].Value = Convert.ToInt32(drVE["formato_cubres"].ToString());
            //    DG_tabla.Rows[32].Cells[4].Value = Convert.ToInt32(drVE["comida"].ToString());
            //    DG_tabla.Rows[33].Cells[4].Value = Convert.ToInt32(drVE["info_tienda"].ToString());
            //    DG_tabla.Rows[34].Cells[4].Value = Convert.ToInt32(drVE["reporte_camaras"].ToString());
            //    DG_tabla.Rows[35].Cells[4].Value = Convert.ToInt32(drVE["comisiones"].ToString());
            //    DG_tabla.Rows[36].Cells[4].Value = Convert.ToInt32(drVE["solucion_problemas"].ToString());
            //    DG_tabla.Rows[37].Cells[4].Value = Convert.ToInt32(drVE["bitacora"].ToString());
            //    DG_tabla.Rows[38].Cells[4].Value = Convert.ToInt32(drVE["sobrante"].ToString());
            //    DG_tabla.Rows[39].Cells[4].Value = Convert.ToInt32(drVE["factura"].ToString());
            //    DG_tabla.Rows[40].Cells[4].Value = Convert.ToInt32(drVE["area_limpia"].ToString());
            //    DG_tabla.Rows[41].Cells[8].Value = Convert.ToInt32(drVE["apoyo_semanal"].ToString());
            //    DG_tabla.Rows[42].Cells[8].Value = Convert.ToInt32(drVE["totaldesc"].ToString());
            //    DG_tabla.Rows[43].Cells[8].Value = Convert.ToInt32(drVE["totalpagar"].ToString());
            //    DG_tabla.Rows[44].Cells[8].Value = drVE["nom_enc_cajas"].ToString();
             
            //}
            //drVE.Close();

            //MySqlCommand cmdCO = new MySqlCommand(query4, con);
            //MySqlDataReader drCO = cmdCO.ExecuteReader();
            //while (drCO.Read())
            //{
            //    DG_tabla.Rows[0].Cells[5].Value = Convert.ToInt32(drCO["presentacion"].ToString());
            //    DG_tabla.Rows[1].Cells[5].Value = Convert.ToInt32(drCO["equipos"].ToString());
            //    DG_tabla.Rows[2].Cells[5].Value = Convert.ToInt32(drCO["fondo"].ToString());
            //    DG_tabla.Rows[3].Cells[5].Value = Convert.ToInt32(drCO["fondos_morralla"].ToString());
            //    DG_tabla.Rows[4].Cells[5].Value = Convert.ToInt32(drCO["solicitar_cambio"].ToString());
            //    DG_tabla.Rows[5].Cells[5].Value = Convert.ToInt32(drCO["mercancia_vitrinas"].ToString());
            //    DG_tabla.Rows[6].Cells[5].Value = Convert.ToInt32(drCO["saludo"].ToString());
            //    DG_tabla.Rows[7].Cells[5].Value = Convert.ToInt32(drCO["sugerencias_solucionadas"].ToString());
            //    DG_tabla.Rows[8].Cells[5].Value = Convert.ToInt32(drCO["gafete"].ToString());
            //    DG_tabla.Rows[9].Cells[5].Value = Convert.ToInt32(drCO["fondo_adicional"].ToString());
            //    DG_tabla.Rows[10].Cells[5].Value = Convert.ToInt32(drCO["presentacion_verif"].ToString());
            //    DG_tabla.Rows[11].Cells[5].Value = Convert.ToInt32(drCO["pelotas"].ToString());
            //    DG_tabla.Rows[12].Cells[5].Value = Convert.ToInt32(drCO["caja_entrada"].ToString());
            //    DG_tabla.Rows[13].Cells[5].Value = Convert.ToInt32(drCO["depuracion_conceptos"].ToString());
            //    DG_tabla.Rows[14].Cells[5].Value = Convert.ToInt32(drCO["caja_cliente"].ToString());
            //    DG_tabla.Rows[15].Cells[5].Value = Convert.ToInt32(drCO["reunion_diaria"].ToString());
            //    DG_tabla.Rows[16].Cells[5].Value = Convert.ToInt32(drCO["cortes"].ToString());
            //    DG_tabla.Rows[17].Cells[5].Value = Convert.ToInt32(drCO["policia"].ToString());
            //    DG_tabla.Rows[18].Cells[5].Value = Convert.ToInt32(drCO["envio_comisiones"].ToString());
            //    DG_tabla.Rows[19].Cells[5].Value = Convert.ToInt32(drCO["gastos_ordenados"].ToString());
            //    DG_tabla.Rows[20].Cells[5].Value = Convert.ToInt32(drCO["apertura_caja"].ToString());
            //    DG_tabla.Rows[21].Cells[5].Value = Convert.ToInt32(drCO["carritos_limpios"].ToString());
            //    DG_tabla.Rows[22].Cells[5].Value = Convert.ToInt32(drCO["trabajo_personal"].ToString());
            //    DG_tabla.Rows[23].Cells[5].Value = Convert.ToInt32(drCO["area_sola"].ToString());
            //    DG_tabla.Rows[24].Cells[5].Value = Convert.ToInt32(drCO["retiro_cajas"].ToString());
            //    DG_tabla.Rows[25].Cells[5].Value = Convert.ToInt32(drCO["exhibicion_productos"].ToString());
            //    DG_tabla.Rows[26].Cells[5].Value = Convert.ToInt32(drCO["precios_exhibidos"].ToString());
            //    DG_tabla.Rows[27].Cells[5].Value = Convert.ToInt32(drCO["precios_ofertas"].ToString());
            //    DG_tabla.Rows[28].Cells[5].Value = Convert.ToInt32(drCO["atencion_cliente"].ToString());
            //    DG_tabla.Rows[29].Cells[5].Value = Convert.ToInt32(drCO["no_regresar_cliente"].ToString());
            //    DG_tabla.Rows[30].Cells[5].Value = Convert.ToInt32(drCO["digitos4"].ToString());
            //    DG_tabla.Rows[31].Cells[5].Value = Convert.ToInt32(drCO["formato_cubres"].ToString());
            //    DG_tabla.Rows[32].Cells[5].Value = Convert.ToInt32(drCO["comida"].ToString());
            //    DG_tabla.Rows[33].Cells[5].Value = Convert.ToInt32(drCO["info_tienda"].ToString());
            //    DG_tabla.Rows[34].Cells[5].Value = Convert.ToInt32(drCO["reporte_camaras"].ToString());
            //    DG_tabla.Rows[35].Cells[5].Value = Convert.ToInt32(drCO["comisiones"].ToString());
            //    DG_tabla.Rows[36].Cells[5].Value = Convert.ToInt32(drCO["solucion_problemas"].ToString());
            //    DG_tabla.Rows[37].Cells[5].Value = Convert.ToInt32(drCO["bitacora"].ToString());
            //    DG_tabla.Rows[38].Cells[5].Value = Convert.ToInt32(drCO["sobrante"].ToString());
            //    DG_tabla.Rows[39].Cells[5].Value = Convert.ToInt32(drCO["factura"].ToString());
            //    DG_tabla.Rows[40].Cells[5].Value = Convert.ToInt32(drCO["area_limpia"].ToString());
            //    DG_tabla.Rows[41].Cells[9].Value = Convert.ToInt32(drCO["apoyo_semanal"].ToString());
            //    DG_tabla.Rows[42].Cells[9].Value = Convert.ToInt32(drCO["totaldesc"].ToString());
            //    DG_tabla.Rows[43].Cells[9].Value = Convert.ToInt32(drCO["totalpagar"].ToString());
            //    DG_tabla.Rows[44].Cells[9].Value = drCO["nom_enc_cajas"].ToString();
              
            //}
            //drCO.Close();


            con.Close();
            

            Calcular();
        }

        private void ComisionesEncCajas_Load(object sender, EventArgs e)
        {
            DG_tabla.Rows.Add("PRESENTACION UNIFORMES PEINADOS MAQUILLAJE", "$5.00", 0, 0,0,0,0,0,0,0);
            DG_tabla.Rows.Add("EQUIPOS DE COMPUTO ( FUNCIONANDO, LIMPIO, CAJAS CON LLAVE, IMPRESORA, TERMINAL FUNCIONANDO, STOCK DE ROLLOS(TERMINAL E IMPRESORA, ENCENDIDO DESDE INICIO DE TURNO", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("FONDO ( ENTREGAR Y RECIBIR AL GERENTE O CUBRE) ", "$20.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("FONDO DE MORALLA EN CAJAS, (COMPLETO, A TIEMPO Y TODAS LAS DENOMINACIONE)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE CAJERA SOLICITE CAMBIO DE MANERA AMABLE)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("EXIBIHICION DE MERCANCIA DE VITRINAS", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("SALUDO AL CLIENTE", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("SUGERENCIAS  SOLUCIONADAS (FALTA DE HERRAMIENTA DE TRABAJO, FRANELA, LAPICERO, CALCULADORA, BLEDO, MARCADOR DE BILLETES, GRAPADORAS, CUADERNO)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("GAFETE ", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("TENER UN FONDO ADICIONAL EN CAJA YA ASIGNADA LA CAJERA)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("PRESENTACION DE LOS VERIFICADORES FAJADOS Y PEINADOS", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("PELOTAS Y BALONES SURTIDOS", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("LA CAJA DE LA ENTRADA SOLO USARLA COMO ULTIMA OPCION", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("DEPURACION DE CONCEPTOS ", "10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("OFRECER UNA CAJA AL CLIENTE. (UTILIZAR TODOS LOS TAMAÑOS DE CAJAS)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("TENER REUNION DIARIA CON GERENTES Y ALMACEN PARA PASAR INFORMACION Y AREAS DE OPORTUNIDAD", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("REVISION EN TIEMPO Y FORMA DE LOS CORTES", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE EL POLICIA VIGILE QUE EL PERSONAL DE EXTERNO ", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("ENVIO DE SUS COMISIONES", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE TENGAN EN ORDEN SUS GASTOS. ", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("SE APERTURA CAJA ADICIONAL A PARTIR DE 6 CLIENTES.", "$20.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("CARRITIOS LIMPIOS  Y EN BUENAS CONDICIONES ", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("REVISAR QUE EL PERSONAL ESTE REVISANDO CORRECTAMENTE SU TRABAJO (ESPECIALMENTE LA ENTRADA)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("AREA SOLA", "$20.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("RETIROS EN CAJAS (NINGUN RETIRO EN CAJA, NO DAR CLAVE)", "$20.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("EXHIBICION DE PRODUCTOS (IMAGEN, PANEL, REGILLAS, PELOTAS(DESINFLADAS, SUCIAS, VIEJAS)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("PRECIOS EXHIBIDOS", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("PRECIOS DE OFERTA", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("ATENCION AL CLIENTE (DE MALA GANA, SIN INFORMACION)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO REGRESAR AL CLEINTE PARA EL REVISADO DE PRODUCTOS. (AUDIFONOS PROVARLOS DESPUES DE LA COMPRA)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("CATALOGO DE LOS 4 DIGITOS ", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("SEGUIMIENTO A SU FORMATOS PARA CUBRES", "$20.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("COMIDA(LLEGAR CON LA COMIDA O COMPRARLA SOLAMENTE CON LAS PERSONAS QUE VAN A OFRECERLA AHÍ. SOLO TORTILLAS Y UNA SOLA PERSONA)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("INFORMACION DE TIENDA, (PUBLICIDAD Y PROMOCIONES)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("REPORTES DE CAMARAS ", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("ENVIAR EN TIEMPO Y FORMA COMISIONES (FOTOS DE CIERRE DE DIA)", "$20.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("DAR SOLICION INMEDIATA A PROBLEMAS MAS TARDAR 5 MIN)  ", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("BITACORA DE MANTENIMIENTO, SISTEMA Y PERSONAL EXTERNO", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("SOBRANTE, MERCANCIA APARTADA, BASURA", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("ELABORAR LA FACTURA LA ENCARGADA DE CAJAS", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("AREA LIMPIA (CAJAS, COMPUTADORA, PAQUETERIA, CRISTALES, ESTACIONAMIENTO, BANQUETA, PAREDES, CESTO DE BASURA, MODULO DE ENCARGADAS)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("APOYO SEMANAL", "", "", "", "", "",0, 0, 0, 0);
            DG_tabla.Rows.Add("TOTAL DESCUENTO", "", "","","","", 0, 0, 0, 0);
            DG_tabla.Rows.Add("TOTAL A PAGAR", "", "", "", "", "", 0, 0, 0, 0);
            DG_tabla.Rows.Add("ENC DE CAJAS","","","","","","","","","");


            DG_tabla.Columns[0].Width = 500;
        }
    }
}
