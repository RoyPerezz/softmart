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
    public partial class Rep_comisiones_gtes : Form
    {
        public Rep_comisiones_gtes()
        {
            InitializeComponent();
        }

#pragma warning disable CS0414 // El campo 'Rep_comisiones_gtes.id' está asignado pero su valor nunca se usa
        int id = 0;
#pragma warning restore CS0414 // El campo 'Rep_comisiones_gtes.id' está asignado pero su valor nunca se usa
        int area_limpia = 0, precios = 0, precios_oferta = 0, exhibir_productos = 0, limpieza_vitrina = 0, exhibir_prod_personal = 0, presentacion = 0, planograma = 0, formatos_cubres = 0, info_tienda = 0, distribucion_personal = 0;
        int incidencias = 0, zona_ofertas = 0, envio_comisiones = 0, prod_no_exhibido = 0, area_vacia = 0, reuniones = 0, solucionar_problemas = 0, comida = 0, descuento = 0, apoyo_cajas = 0;
#pragma warning disable CS0414 // El campo 'Rep_comisiones_gtes.incentivoVA' está asignado pero su valor nunca se usa
        double incentivoVA = 0, apoyo_semanalVA = 0;
#pragma warning restore CS0414 // El campo 'Rep_comisiones_gtes.incentivoVA' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Rep_comisiones_gtes.incentivoRE' está asignado pero su valor nunca se usa
        double incentivoRE = 0, apoyo_semanalRE = 0;
#pragma warning restore CS0414 // El campo 'Rep_comisiones_gtes.incentivoRE' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Rep_comisiones_gtes.incentivoVE' está asignado pero su valor nunca se usa
        double incentivoVE = 0, apoyo_semanalVE = 0;
#pragma warning restore CS0414 // El campo 'Rep_comisiones_gtes.incentivoVE' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Rep_comisiones_gtes.incentivoCO' está asignado pero su valor nunca se usa
        double incentivoCO = 0, apoyo_semanalCO = 0;
#pragma warning restore CS0414 // El campo 'Rep_comisiones_gtes.incentivoCO' está asignado pero su valor nunca se usa


        double totalAcumulado = 0;
        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            string query1 = "SELECT * FROM rd_calif_gteva WHERE inicio_semana='"+inicio.ToString("yyyy-MM-dd")+"' AND fin_semana='"+fin.ToString("yyyy-MM-dd")+"'";
            string query2 = "SELECT * FROM rd_calif_gtere WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd")+"'";
            string query3 = "SELECT * FROM rd_calif_gteve WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "'";
            string query4 = "SELECT * FROM rd_calif_gteco WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "'";


            string query = "SELECT * FROM rd_calif_gte WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "' AND puesto='GERENTE'";

            MySqlConnection con = BDConexicon.BodegaOpen();

            //traer calificacion de gerente va
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            string sucursal = "";
            totalAcumulado = 0;
            while (dr.Read())
            {
                sucursal = dr["sucursal"].ToString();
                if (sucursal.Equals("VALLARTA"))
                {

                    TB_gte_va.Text = dr["nombre_gerente"].ToString();
                    DG_tabla.Rows[0].Cells[2].Value = dr["area_limpia"].ToString();
                    DG_tabla.Rows[1].Cells[2].Value = dr["precios_exhibidos"].ToString();
                    DG_tabla.Rows[2].Cells[2].Value = dr["precios_oferta"].ToString();
                    DG_tabla.Rows[3].Cells[2].Value = dr["exhibicion_productos"].ToString();
                    DG_tabla.Rows[4].Cells[2].Value = dr["limpieza_vitrina"].ToString();
                    DG_tabla.Rows[5].Cells[2].Value = dr["ofertas_temporada"].ToString();
                    DG_tabla.Rows[6].Cells[2].Value = dr["presentacion"].ToString();
                    DG_tabla.Rows[7].Cells[2].Value = dr["planograma"].ToString();
                    DG_tabla.Rows[8].Cells[2].Value = dr["formatos_cubres"].ToString();
                    DG_tabla.Rows[9].Cells[2].Value = dr["info_tienda"].ToString();
                    DG_tabla.Rows[10].Cells[2].Value = dr["distribucion_personal"].ToString();
                    DG_tabla.Rows[11].Cells[2].Value = dr["incidencias"].ToString();
                    DG_tabla.Rows[12].Cells[2].Value = dr["zona_ofertas"].ToString();
                    DG_tabla.Rows[13].Cells[2].Value = dr["enviar_comisiones"].ToString();
                    DG_tabla.Rows[14].Cells[2].Value = dr["prod_no_exhibido"].ToString();
                    DG_tabla.Rows[15].Cells[2].Value = dr["area_vacia"].ToString();
                    DG_tabla.Rows[16].Cells[2].Value = dr["reunion_diaria"].ToString();
                    DG_tabla.Rows[17].Cells[2].Value = dr["solucion_problemas"].ToString();
                    DG_tabla.Rows[18].Cells[2].Value = dr["comida"].ToString();
                    DG_tabla.Rows[19].Cells[2].Value = dr["descuento_camara"].ToString();
                    DG_tabla.Rows[20].Cells[2].Value = dr["apoyo_en_cajas"].ToString();
                    DG_tabla.Rows[21].Cells[6].Value = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[22].Cells[6].Value = Convert.ToDouble(dr["total_descuento"].ToString());
                    //DG_tabla.Rows[23].Cells[6].Value = Convert.ToDouble(drVA["incentivo"].ToString());
                    DG_tabla.Rows[23].Cells[6].Value = Convert.ToDouble(dr["totalcomision"].ToString());
                    apoyo_semanalVA = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                    totalAcumulado += Convert.ToDouble(dr["totalcomision"].ToString());
                    //incentivoVA = Convert.ToDouble(drVA["incentivo"].ToString());
                }

                if (sucursal.Equals("RENA"))
                {
                    TB_gte_re.Text = dr["nombre_gerente"].ToString();
                    DG_tabla.Rows[0].Cells[3].Value = dr["area_limpia"].ToString();
                    DG_tabla.Rows[1].Cells[3].Value = dr["precios_exhibidos"].ToString();
                    DG_tabla.Rows[2].Cells[3].Value = dr["precios_oferta"].ToString();
                    DG_tabla.Rows[3].Cells[3].Value = dr["exhibicion_productos"].ToString();
                    DG_tabla.Rows[4].Cells[3].Value = dr["limpieza_vitrina"].ToString();
                    DG_tabla.Rows[5].Cells[3].Value = dr["ofertas_temporada"].ToString();
                    DG_tabla.Rows[6].Cells[3].Value = dr["presentacion"].ToString();
                    DG_tabla.Rows[7].Cells[3].Value = dr["planograma"].ToString();
                    DG_tabla.Rows[8].Cells[3].Value = dr["formatos_cubres"].ToString();
                    DG_tabla.Rows[9].Cells[3].Value = dr["info_tienda"].ToString();
                    DG_tabla.Rows[10].Cells[3].Value = dr["distribucion_personal"].ToString();
                    DG_tabla.Rows[11].Cells[3].Value = dr["incidencias"].ToString();
                    DG_tabla.Rows[12].Cells[3].Value = dr["zona_ofertas"].ToString();
                    DG_tabla.Rows[13].Cells[3].Value = dr["enviar_comisiones"].ToString();
                    DG_tabla.Rows[14].Cells[3].Value = dr["prod_no_exhibido"].ToString();
                    DG_tabla.Rows[15].Cells[3].Value = dr["area_vacia"].ToString();
                    DG_tabla.Rows[16].Cells[3].Value = dr["reunion_diaria"].ToString();
                    DG_tabla.Rows[17].Cells[3].Value = dr["solucion_problemas"].ToString();
                    DG_tabla.Rows[18].Cells[3].Value = dr["comida"].ToString();
                    DG_tabla.Rows[19].Cells[3].Value = dr["descuento_camara"].ToString();
                    DG_tabla.Rows[20].Cells[3].Value = dr["apoyo_en_cajas"].ToString();
                    DG_tabla.Rows[21].Cells[7].Value = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[22].Cells[7].Value = Convert.ToDouble(dr["total_descuento"].ToString());
                    //DG_tabla.Rows[23].Cells[7].Value = Convert.ToDouble(drRE["incentivo"].ToString());
                    DG_tabla.Rows[23].Cells[7].Value = Convert.ToDouble(dr["totalcomision"].ToString());
                    totalAcumulado += Convert.ToDouble(dr["totalcomision"].ToString());
                    apoyo_semanalRE = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                }

                if (sucursal.Equals("VELAZQUEZ"))
                {
                    TB_gte_ve.Text = dr["nombre_gerente"].ToString();
                    DG_tabla.Rows[0].Cells[4].Value = dr["area_limpia"].ToString();
                    DG_tabla.Rows[1].Cells[4].Value = dr["precios_exhibidos"].ToString();
                    DG_tabla.Rows[2].Cells[4].Value = dr["precios_oferta"].ToString();
                    DG_tabla.Rows[3].Cells[4].Value = dr["exhibicion_productos"].ToString();
                    DG_tabla.Rows[4].Cells[4].Value = dr["limpieza_vitrina"].ToString();
                    DG_tabla.Rows[5].Cells[4].Value = dr["ofertas_temporada"].ToString();
                    DG_tabla.Rows[6].Cells[4].Value = dr["presentacion"].ToString();
                    DG_tabla.Rows[7].Cells[4].Value = dr["planograma"].ToString();
                    DG_tabla.Rows[8].Cells[4].Value = dr["formatos_cubres"].ToString();
                    DG_tabla.Rows[9].Cells[4].Value = dr["info_tienda"].ToString();
                    DG_tabla.Rows[10].Cells[4].Value = dr["distribucion_personal"].ToString();
                    DG_tabla.Rows[11].Cells[4].Value = dr["incidencias"].ToString();
                    DG_tabla.Rows[12].Cells[4].Value = dr["zona_ofertas"].ToString();
                    DG_tabla.Rows[13].Cells[4].Value = dr["enviar_comisiones"].ToString();
                    DG_tabla.Rows[14].Cells[4].Value = dr["prod_no_exhibido"].ToString();
                    DG_tabla.Rows[15].Cells[4].Value = dr["area_vacia"].ToString();
                    DG_tabla.Rows[16].Cells[4].Value = dr["reunion_diaria"].ToString();
                    DG_tabla.Rows[17].Cells[4].Value = dr["solucion_problemas"].ToString();
                    DG_tabla.Rows[18].Cells[4].Value = dr["comida"].ToString();
                    DG_tabla.Rows[19].Cells[4].Value = dr["descuento_camara"].ToString();
                    DG_tabla.Rows[20].Cells[4].Value = dr["apoyo_en_cajas"].ToString();
                    DG_tabla.Rows[21].Cells[8].Value = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[22].Cells[8].Value = Convert.ToDouble(dr["total_descuento"].ToString());
                    //DG_tabla.Rows[23].Cells[8].Value = Convert.ToDouble(drVE["incentivo"].ToString());
                    DG_tabla.Rows[23].Cells[8].Value = Convert.ToDouble(dr["totalcomision"].ToString());
                    totalAcumulado += Convert.ToDouble(dr["totalcomision"].ToString());
                    apoyo_semanalVE = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                }

                if(sucursal.Equals("COLOSO"))
                {
                    TB_gte_co.Text = dr["nombre_gerente"].ToString();
                    DG_tabla.Rows[0].Cells[5].Value = dr["area_limpia"].ToString();
                    DG_tabla.Rows[1].Cells[5].Value = dr["precios_exhibidos"].ToString();
                    DG_tabla.Rows[2].Cells[5].Value = dr["precios_oferta"].ToString();
                    DG_tabla.Rows[3].Cells[5].Value = dr["exhibicion_productos"].ToString();
                    DG_tabla.Rows[4].Cells[5].Value = dr["limpieza_vitrina"].ToString();
                    DG_tabla.Rows[5].Cells[5].Value = dr["ofertas_temporada"].ToString();
                    DG_tabla.Rows[6].Cells[5].Value = dr["presentacion"].ToString();
                    DG_tabla.Rows[7].Cells[5].Value = dr["planograma"].ToString();
                    DG_tabla.Rows[8].Cells[5].Value = dr["formatos_cubres"].ToString();
                    DG_tabla.Rows[9].Cells[5].Value = dr["info_tienda"].ToString();
                    DG_tabla.Rows[10].Cells[5].Value = dr["distribucion_personal"].ToString();
                    DG_tabla.Rows[11].Cells[5].Value = dr["incidencias"].ToString();
                    DG_tabla.Rows[12].Cells[5].Value = dr["zona_ofertas"].ToString();
                    DG_tabla.Rows[13].Cells[5].Value = dr["enviar_comisiones"].ToString();
                    DG_tabla.Rows[14].Cells[5].Value = dr["prod_no_exhibido"].ToString();
                    DG_tabla.Rows[15].Cells[5].Value = dr["area_vacia"].ToString();
                    DG_tabla.Rows[16].Cells[5].Value = dr["reunion_diaria"].ToString();
                    DG_tabla.Rows[17].Cells[5].Value = dr["solucion_problemas"].ToString();
                    DG_tabla.Rows[18].Cells[5].Value = dr["comida"].ToString();
                    DG_tabla.Rows[19].Cells[5].Value = dr["descuento_camara"].ToString();
                    DG_tabla.Rows[20].Cells[5].Value = dr["apoyo_en_cajas"].ToString();
                    DG_tabla.Rows[21].Cells[9].Value = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[22].Cells[9].Value = Convert.ToDouble(dr["total_descuento"].ToString());
                    //DG_tabla.Rows[23].Cells[9].Value = Convert.ToDouble(drCO["incentivo"].ToString());
                    DG_tabla.Rows[23].Cells[9].Value = Convert.ToDouble(dr["totalcomision"].ToString());
                    totalAcumulado += Convert.ToDouble(dr["totalcomision"].ToString());
                    apoyo_semanalCO = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                    //incentivoCO = Convert.ToDouble(drCO["incentivo"].ToString());
                }


            }
            dr.Close();

            ////traer calificacion de gernete re
            //MySqlCommand cmdRE = new MySqlCommand(query, con);
            //MySqlDataReader drRE = cmdRE.ExecuteReader();

            //while (drRE.Read())
            //{
            //    TB_gte_re.Text = drRE["nombre_gerente"].ToString();
            //    DG_tabla.Rows[0].Cells[3].Value = drRE["area_limpia"].ToString();
            //    DG_tabla.Rows[1].Cells[3].Value = drRE["precios_exhibidos"].ToString();
            //    DG_tabla.Rows[2].Cells[3].Value = drRE["precios_oferta"].ToString();
            //    DG_tabla.Rows[3].Cells[3].Value = drRE["exhibicion_productos"].ToString();
            //    DG_tabla.Rows[4].Cells[3].Value = drRE["limpieza_vitrina"].ToString();
            //    DG_tabla.Rows[5].Cells[3].Value = drRE["ofertas_temporada"].ToString();
            //    DG_tabla.Rows[6].Cells[3].Value = drRE["presentacion"].ToString();
            //    DG_tabla.Rows[7].Cells[3].Value = drRE["planograma"].ToString();
            //    DG_tabla.Rows[8].Cells[3].Value = drRE["formatos_cubres"].ToString();
            //    DG_tabla.Rows[9].Cells[3].Value = drRE["info_tienda"].ToString();
            //    DG_tabla.Rows[10].Cells[3].Value = drRE["distribucion_personal"].ToString();
            //    DG_tabla.Rows[11].Cells[3].Value = drRE["incidencias"].ToString();
            //    DG_tabla.Rows[12].Cells[3].Value = drRE["zona_ofertas"].ToString();
            //    DG_tabla.Rows[13].Cells[3].Value = drRE["enviar_comisiones"].ToString();
            //    DG_tabla.Rows[14].Cells[3].Value = drRE["prod_no_exhibido"].ToString();
            //    DG_tabla.Rows[15].Cells[3].Value = drRE["area_vacia"].ToString();
            //    DG_tabla.Rows[16].Cells[3].Value = drRE["reunion_diaria"].ToString();
            //    DG_tabla.Rows[17].Cells[3].Value = drRE["solucion_problemas"].ToString();
            //    DG_tabla.Rows[18].Cells[3].Value = drRE["comida"].ToString();
            //    DG_tabla.Rows[19].Cells[3].Value = drRE["descuento_camara"].ToString();
            //    DG_tabla.Rows[20].Cells[3].Value = drRE["apoyo_en_cajas"].ToString();
            //    DG_tabla.Rows[21].Cells[7].Value = Convert.ToDouble(drRE["apoyo_semanal"].ToString());
            //    DG_tabla.Rows[22].Cells[7].Value = Convert.ToDouble(drRE["total_descuento"].ToString());
            //    //DG_tabla.Rows[23].Cells[7].Value = Convert.ToDouble(drRE["incentivo"].ToString());
            //    DG_tabla.Rows[23].Cells[7].Value = Convert.ToDouble(drRE["totalcomision"].ToString());
            //    apoyo_semanalRE = Convert.ToDouble(drRE["apoyo_semanal"].ToString());
            //    //incentivoRE = Convert.ToDouble(drRE["incentivo"].ToString());



            //}
            //drRE.Close();


            ////traer calificacion de gernete ve
            //MySqlCommand cmdVE = new MySqlCommand(query, con);
            //MySqlDataReader drVE = cmdVE.ExecuteReader();

            //while (drVE.Read())
            //{
            //    TB_gte_ve.Text = drVE["nombre_gerente"].ToString();
            //    DG_tabla.Rows[0].Cells[4].Value = drVE["area_limpia"].ToString();
            //    DG_tabla.Rows[1].Cells[4].Value = drVE["precios_exhibidos"].ToString();
            //    DG_tabla.Rows[2].Cells[4].Value = drVE["precios_oferta"].ToString();
            //    DG_tabla.Rows[3].Cells[4].Value = drVE["exhibicion_productos"].ToString();
            //    DG_tabla.Rows[4].Cells[4].Value = drVE["limpieza_vitrina"].ToString();
            //    DG_tabla.Rows[5].Cells[4].Value = drVE["ofertas_temporada"].ToString();
            //    DG_tabla.Rows[6].Cells[4].Value = drVE["presentacion"].ToString();
            //    DG_tabla.Rows[7].Cells[4].Value = drVE["planograma"].ToString();
            //    DG_tabla.Rows[8].Cells[4].Value = drVE["formatos_cubres"].ToString();
            //    DG_tabla.Rows[9].Cells[4].Value = drVE["info_tienda"].ToString();
            //    DG_tabla.Rows[10].Cells[4].Value = drVE["distribucion_personal"].ToString();
            //    DG_tabla.Rows[11].Cells[4].Value = drVE["incidencias"].ToString();
            //    DG_tabla.Rows[12].Cells[4].Value = drVE["zona_ofertas"].ToString();
            //    DG_tabla.Rows[13].Cells[4].Value = drVE["enviar_comisiones"].ToString();
            //    DG_tabla.Rows[14].Cells[4].Value = drVE["prod_no_exhibido"].ToString();
            //    DG_tabla.Rows[15].Cells[4].Value = drVE["area_vacia"].ToString();
            //    DG_tabla.Rows[16].Cells[4].Value = drVE["reunion_diaria"].ToString();
            //    DG_tabla.Rows[17].Cells[4].Value = drVE["solucion_problemas"].ToString();
            //    DG_tabla.Rows[18].Cells[4].Value = drVE["comida"].ToString();
            //    DG_tabla.Rows[19].Cells[4].Value = drVE["descuento_camara"].ToString();
            //    DG_tabla.Rows[20].Cells[4].Value = drVE["apoyo_en_cajas"].ToString();
            //    DG_tabla.Rows[21].Cells[8].Value = Convert.ToDouble(drVE["apoyo_semanal"].ToString());
            //    DG_tabla.Rows[22].Cells[8].Value = Convert.ToDouble(drVE["total_descuento"].ToString());
            //    //DG_tabla.Rows[23].Cells[8].Value = Convert.ToDouble(drVE["incentivo"].ToString());
            //    DG_tabla.Rows[23].Cells[8].Value = Convert.ToDouble(drVE["totalcomision"].ToString());
            //    apoyo_semanalVE = Convert.ToDouble(drVE["apoyo_semanal"].ToString());
            //    //incentivoVE = Convert.ToDouble(drVE["incentivo"].ToString());


            //}
            //drVE.Close();


            ////traer calificacion de gernete co
            //MySqlCommand cmdCO = new MySqlCommand(query, con);
            //MySqlDataReader drCO = cmdCO.ExecuteReader();

            //while (drCO.Read())
            //{

            //    TB_gte_co.Text = drCO["nombre_gerente"].ToString();
            //    DG_tabla.Rows[0].Cells[5].Value = drCO["area_limpia"].ToString();
            //    DG_tabla.Rows[1].Cells[5].Value = drCO["precios_exhibidos"].ToString();
            //    DG_tabla.Rows[2].Cells[5].Value = drCO["precios_oferta"].ToString();
            //    DG_tabla.Rows[3].Cells[5].Value = drCO["exhibicion_productos"].ToString();
            //    DG_tabla.Rows[4].Cells[5].Value = drCO["limpieza_vitrina"].ToString();
            //    DG_tabla.Rows[5].Cells[5].Value = drCO["ofertas_temporada"].ToString();
            //    DG_tabla.Rows[6].Cells[5].Value = drCO["presentacion"].ToString();
            //    DG_tabla.Rows[7].Cells[5].Value = drCO["planograma"].ToString();
            //    DG_tabla.Rows[8].Cells[5].Value = drCO["formatos_cubres"].ToString();
            //    DG_tabla.Rows[9].Cells[5].Value = drCO["info_tienda"].ToString();
            //    DG_tabla.Rows[10].Cells[5].Value = drCO["distribucion_personal"].ToString();
            //    DG_tabla.Rows[11].Cells[5].Value = drCO["incidencias"].ToString();
            //    DG_tabla.Rows[12].Cells[5].Value = drCO["zona_ofertas"].ToString();
            //    DG_tabla.Rows[13].Cells[5].Value = drCO["enviar_comisiones"].ToString();
            //    DG_tabla.Rows[14].Cells[5].Value = drCO["prod_no_exhibido"].ToString();
            //    DG_tabla.Rows[15].Cells[5].Value = drCO["area_vacia"].ToString();
            //    DG_tabla.Rows[16].Cells[5].Value = drCO["reunion_diaria"].ToString();
            //    DG_tabla.Rows[17].Cells[5].Value = drCO["solucion_problemas"].ToString();
            //    DG_tabla.Rows[18].Cells[5].Value = drCO["comida"].ToString();
            //    DG_tabla.Rows[19].Cells[5].Value = drCO["descuento_camara"].ToString();
            //    DG_tabla.Rows[20].Cells[5].Value = drCO["apoyo_en_cajas"].ToString();
            //    DG_tabla.Rows[21].Cells[9].Value = Convert.ToDouble(drCO["apoyo_semanal"].ToString());
            //    DG_tabla.Rows[22].Cells[9].Value = Convert.ToDouble(drCO["total_descuento"].ToString());
            //    //DG_tabla.Rows[23].Cells[9].Value = Convert.ToDouble(drCO["incentivo"].ToString());
            //    DG_tabla.Rows[23].Cells[9].Value = Convert.ToDouble(drCO["totalcomision"].ToString());

            //    apoyo_semanalCO = Convert.ToDouble(drCO["apoyo_semanal"].ToString());
            //    //incentivoCO = Convert.ToDouble(drCO["incentivo"].ToString());

            //}
            //drCO.Close();
            Calcular();
            DG_tabla.Columns[6].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[7].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[8].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[9].DefaultCellStyle.Format = "C2";

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



            excel.Cells.Range["A3:F3"].Merge();
            excel.Cells.Range["A3"].Value = "COMISIONES DE LA SEMANA DEL " + inicio.ToString("dd-MM-yyyy") + " AL " + fin.ToString("dd-MM-yyyy") + "";
            excel.Cells.Range["B6:J30"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["K29"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["K29"].Value = totalAcumulado;
            excel.Cells.Range["G4"].Value = TB_gte_va.Text;
            excel.Cells.Range["H4"].Value = TB_gte_re.Text;
            excel.Cells.Range["I4"].Value = TB_gte_ve.Text;
            excel.Cells.Range["J4"].Value = TB_gte_co.Text;

            excel.Visible = true;
        }

      
        private void ComisionesJefes_Load(object sender, EventArgs e)
        {
            
            //ESTE CODIGO SE CARGA AL INICIO DEL FORMULARIO  PARA QUE AGREGUE ESTA INFORMACION AL DATAGIRVIEW
            DG_tabla.Rows.Add("AREA LIMPIA ","$5.00","0","0","0","0","0","0","0","0");
            DG_tabla.Rows.Add("PRECIOS EXHIBIDOS", "$3.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("PRECIOS DE OFERTA", "$3.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("EXHIBICION DE PRODUCTOS (IMAGEN)", "$3.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("LIMPIEZA DE VITRINA (NO POLVO, NO CINTA, BARILLAS LIMPIAS, ETC)", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("PRODUCTOS EXHIBIDOS POR EL PERSONAL (OFERTAS O TEMPORADA)", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("PRESENTACION DEL PERSONAL (UNIFORME, MAQUILLAJE, PEINADO)", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("PLANOGRAMA", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("SEGUIMIENTO A SU FORMATOS PARA CUBRES", "$20.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("INFORMACION DE TIENDA, (PUBLICIDAD Y PROMOCIONES)", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("REALIZAR CORRECTAMENTE LA DISTRIBUCION DEL PERSONAL ", "$20.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("INCIDENCIAS (BAÑOS, PASILLOS DESPEJADOS, TARAS SIN ACOMODAR, ETC.)", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("MOVIMIENTO DE LUGAR, ZONA DE OFERTAS", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("ENVIAR EN TIEMPO Y FORMA COMISIONES (FOTOS DE CIERRE DE DIA)", "$10.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("PRODUCTO NO EXHIBIDO", "$10.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("AREA VACIA (VARILLAS Y PANEL)", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("TENER REUNION DIARIA CON GERENTES Y ALMACEN PARA PASAR INFORMACION Y AREAS DE OPORTUNIDAD", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("SOLUCIONAR A LA BREVEDAD A PRODUCTOS CON PROBLEMAS EN EL AREA DE COBRO.(MAX. 5 MIN.) ", "$10.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("COMIDA(LLEGAR CON LA COMIDA O COMPRARLA SOLAMENTE CON LAS PERSONAS QUE VAN A OFRECERLA AHÍ. SOLO TORTILLAS Y UNA SOLA PERSONA)", "$5.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("DESCUENTO POR CAMARA", "$10.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("APOYAR FISICAMENTE EN CAJAS, CUANDO ESTA AUSENTE LA ENCARGADA. ", "$10.00", "0", "0", "0", "0", "0", "0", "0", "0");
            DG_tabla.Rows.Add("APOYO SEMANAL", "", "", "", "", "", "$0.00", "$0.00", "$0.00", "$0.00");
            DG_tabla.Rows.Add("DESCUENTO TOTAL", "", "", "", "", "", "0", "0", "0", "0");
            //DG_tabla.Rows.Add("INCENTIVOS", "", "", "", "", "", "$0.00", "$0.00", "$0.00", "$0.00");
            DG_tabla.Rows.Add("TOTAL", "", "", "", "", "", "0", "0", "0", "0");
         
            DG_tabla.Columns["ASPECTOS"].Width = 900;
            DG_tabla.Columns["VALOR"].Width = 60;

            DG_tabla.Rows[21].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            DG_tabla.Rows[22].DefaultCellStyle.BackColor = Color.LightSeaGreen;
            
            DG_tabla.Rows[23].DefaultCellStyle.BackColor = Color.Green;
            DG_tabla.Rows[23].DefaultCellStyle.ForeColor = Color.White;


        }

       public void Calcular()
        {
#pragma warning disable CS0219 // La variable 'totalTienda' está asignada pero su valor nunca se usa
            int totalTienda = 0;
#pragma warning restore CS0219 // La variable 'totalTienda' está asignada pero su valor nunca se usa

            for (int tiendas = 2; tiendas < 6; tiendas++)
            {

                //SE OBTIENE LOS VALORES QUE INTRODUCE EL USUARIO COMO CALIFICACION
                area_limpia = Convert.ToInt32(DG_tabla.Rows[0].Cells[tiendas].Value);
                precios = Convert.ToInt32(DG_tabla.Rows[1].Cells[tiendas].Value);
                precios_oferta = Convert.ToInt32(DG_tabla.Rows[2].Cells[tiendas].Value);
                exhibir_productos = Convert.ToInt32(DG_tabla.Rows[3].Cells[tiendas].Value);
                limpieza_vitrina = Convert.ToInt32(DG_tabla.Rows[4].Cells[tiendas].Value);
                exhibir_prod_personal = Convert.ToInt32(DG_tabla.Rows[5].Cells[tiendas].Value);
                presentacion = Convert.ToInt32(DG_tabla.Rows[6].Cells[tiendas].Value);
                planograma = Convert.ToInt32(DG_tabla.Rows[7].Cells[tiendas].Value);
                formatos_cubres = Convert.ToInt32(DG_tabla.Rows[8].Cells[tiendas].Value);
                info_tienda = Convert.ToInt32(DG_tabla.Rows[9].Cells[tiendas].Value);
                distribucion_personal = Convert.ToInt32(DG_tabla.Rows[10].Cells[tiendas].Value);
                incidencias = Convert.ToInt32(DG_tabla.Rows[11].Cells[tiendas].Value);
                zona_ofertas = Convert.ToInt32(DG_tabla.Rows[12].Cells[tiendas].Value);
                envio_comisiones = Convert.ToInt32(DG_tabla.Rows[13].Cells[tiendas].Value);
                prod_no_exhibido = Convert.ToInt32(DG_tabla.Rows[14].Cells[tiendas].Value);
                area_vacia = Convert.ToInt32(DG_tabla.Rows[15].Cells[tiendas].Value);
                reuniones = Convert.ToInt32(DG_tabla.Rows[16].Cells[tiendas].Value);
                solucionar_problemas = Convert.ToInt32(DG_tabla.Rows[17].Cells[tiendas].Value);
                comida = Convert.ToInt32(DG_tabla.Rows[18].Cells[tiendas].Value);
                descuento = Convert.ToInt32(DG_tabla.Rows[19].Cells[tiendas].Value);
                apoyo_cajas = Convert.ToInt32(DG_tabla.Rows[20].Cells[tiendas].Value);


                //REALIZA LOS CALCULOS CORRESPONDIENTES PARA CADA TIENDA
                DG_tabla.Rows[0].Cells[tiendas + 4].Value = area_limpia * 5;
                DG_tabla.Rows[1].Cells[tiendas + 4].Value = precios * 3;
                DG_tabla.Rows[2].Cells[tiendas + 4].Value = precios_oferta * 3;
                DG_tabla.Rows[3].Cells[tiendas + 4].Value = exhibir_productos * 3;
                DG_tabla.Rows[4].Cells[tiendas + 4].Value = limpieza_vitrina * 5;
                DG_tabla.Rows[5].Cells[tiendas + 4].Value = exhibir_prod_personal * 5;
                DG_tabla.Rows[6].Cells[tiendas + 4].Value = presentacion * 5;
                DG_tabla.Rows[7].Cells[tiendas + 4].Value = planograma * 5;
                DG_tabla.Rows[8].Cells[tiendas + 4].Value = formatos_cubres * 20;
                DG_tabla.Rows[9].Cells[tiendas + 4].Value = info_tienda * 5;
                DG_tabla.Rows[10].Cells[tiendas + 4].Value = distribucion_personal * 20;
                DG_tabla.Rows[11].Cells[tiendas + 4].Value = incidencias * 5;
                DG_tabla.Rows[12].Cells[tiendas + 4].Value = zona_ofertas * 5;
                DG_tabla.Rows[13].Cells[tiendas + 4].Value = envio_comisiones * 10;
                DG_tabla.Rows[14].Cells[tiendas + 4].Value = prod_no_exhibido * 10;
                DG_tabla.Rows[15].Cells[tiendas + 4].Value = area_vacia * 5;
                DG_tabla.Rows[16].Cells[tiendas + 4].Value = reuniones * 5;
                DG_tabla.Rows[17].Cells[tiendas + 4].Value = solucionar_problemas * 10;
                DG_tabla.Rows[18].Cells[tiendas + 4].Value = comida * 5;
                DG_tabla.Rows[19].Cells[tiendas + 4].Value = descuento * 10;
                DG_tabla.Rows[20].Cells[tiendas + 4].Value = apoyo_cajas * 10;

                //for (int filas = 0; filas < 21; filas++)
                //{
                //    totalTienda += Convert.ToInt32(DG_tabla.Rows[filas].Cells[tiendas + 4].Value);
                //}

                //DG_tabla.Rows[22].Cells[tiendas + 4].Value = totalTienda;

                //DG_tabla.Rows[24].Cells[tiendas + 4].Value = (1000 + incentivo) - totalTienda;
                //totalTienda = 0;

                DG_tabla.Columns[6].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[7].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[8].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[9].DefaultCellStyle.Format = "C2";





            }

           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

      
        
    }
}
