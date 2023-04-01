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
    public partial class RepComisionCubre : Form
    {
        public RepComisionCubre()
        {
            InitializeComponent();
        }

        private void RepComisionCubre_Load(object sender, EventArgs e)
        {

            //DG_tabla.Columns["ASPECTOS"].Width = 400;
            //DG_tabla.Rows.Add("AREA LIMPIA");
            //DG_tabla.Rows.Add("PRECIOS EXHIBIDOS");
            //DG_tabla.Rows.Add("PRECIOS DE OFERTA");
            //DG_tabla.Rows.Add("EXHIBICION DE PRODUCTOS ");
            //DG_tabla.Rows.Add("ACOMODO DE ANAQUELES");
            //DG_tabla.Rows.Add("ENVIA EL FORMATO DEL  PERSONAL CUANDO CUBRE");
            //DG_tabla.Rows.Add("PRESENTACION DEL PERSONAL (UNIFORME, MAQUILLAJE, PEINADO)");
            //DG_tabla.Rows.Add("DEJA PENDIENTE A QUIEN CUBRE");
            //DG_tabla.Rows.Add("MERCANCIA DAÑADA ");
            //DG_tabla.Rows.Add("CALIFICACION");
            //DG_tabla.Rows.Add("APOYO SEMANAL");
            //DG_tabla.Rows.Add("DESCUENTO");
            //DG_tabla.Rows.Add("TOTAL A PAGAR");
            //DG_tabla.Rows.Add("CUBRE");
            DG_tabla.Rows.Add("AREA LIMPIA ", "$5.00", "0", "0");
            DG_tabla.Rows.Add("PRECIOS EXHIBIDOS", "$3.00", "0", "0");
            DG_tabla.Rows.Add("PRECIOS DE OFERTA", "$3.00", "0", "0");
            DG_tabla.Rows.Add("EXHIBICION DE PRODUCTOS (IMAGEN)", "$3.00", "0", "0");
            DG_tabla.Rows.Add("LIMPIEZA DE VITRINA (NO POLVO, NO CINTA, BARILLAS LIMPIAS, ETC)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("PRODUCTOS EXHIBIDOS POR EL PERSONAL (OFERTAS O TEMPORADA)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("PRESENTACION DEL PERSONAL (UNIFORME, MAQUILLAJE, PEINADO)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("PLANOGRAMA", "$5.00", "0", "0");
            DG_tabla.Rows.Add("SEGUIMIENTO A SU FORMATOS PARA CUBRES", "$20.00", "0", "0");
            DG_tabla.Rows.Add("INFORMACION DE TIENDA, (PUBLICIDAD Y PROMOCIONES)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("REALIZAR CORRECTAMENTE LA DISTRIBUCION DEL PERSONAL ", "$20.00", "0", "0");
            DG_tabla.Rows.Add("INCIDENCIAS (BAÑOS, PASILLOS DESPEJADOS, TARAS SIN ACOMODAR, ETC.)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("MOVIMIENTO DE LUGAR, ZONA DE OFERTAS", "$5.00", "0", "0");
            DG_tabla.Rows.Add("ENVIAR EN TIEMPO Y FORMA COMISIONES (FOTOS DE CIERRE DE DIA)", "$10.00", "0", "0");
            DG_tabla.Rows.Add("PRODUCTO NO EXHIBIDO", "$10.00", "0", "0");
            DG_tabla.Rows.Add("AREA VACIA (VARILLAS Y PANEL)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("TENER REUNION DIARIA CON GERENTES Y ALMACEN PARA PASAR INFORMACION Y AREAS DE OPORTUNIDAD", "$5.00", "0", "0");
            DG_tabla.Rows.Add("SOLUCIONAR A LA BREVEDAD A PRODUCTOS CON PROBLEMAS EN EL AREA DE COBRO.(MAX. 5 MIN.) ", "$10.00", "0", "0");
            DG_tabla.Rows.Add("COMIDA(LLEGAR CON LA COMIDA O COMPRARLA SOLAMENTE CON LAS PERSONAS QUE VAN A OFRECERLA AHÍ. SOLO TORTILLAS Y UNA SOLA PERSONA)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("DESCUENTO POR CAMARA", "$10.00", "0", "0");
            DG_tabla.Rows.Add("APOYAR FISICAMENTE EN CAJAS, CUANDO ESTA AUSENTE LA ENCARGADA. ", "$10.00", "0", "0");
            DG_tabla.Rows.Add("APOYO SEMANAL ", "$800.00", "0", "0");
            DG_tabla.Rows.Add("DESCUENTO", "", "0", "0");
            DG_tabla.Rows.Add("TOTAL", "0", "0", "0");
         

            DG_tabla.Columns["ASPECTOS"].Width = 700;

        }

        double totalAcumulado = 0;

        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            DG_tabla.Rows.Clear();

            DG_tabla.Columns.Clear();
            DG_tabla.Columns.Add("ASPECTOS", "ASPECTOS A CALIFICAR");
            DG_tabla.Rows.Add("AREA LIMPIA ", "$5.00", "0", "0");
            DG_tabla.Rows.Add("PRECIOS EXHIBIDOS", "$3.00", "0", "0");
            DG_tabla.Rows.Add("PRECIOS DE OFERTA", "$3.00", "0", "0");
            DG_tabla.Rows.Add("EXHIBICION DE PRODUCTOS (IMAGEN)", "$3.00", "0", "0");
            DG_tabla.Rows.Add("LIMPIEZA DE VITRINA (NO POLVO, NO CINTA, BARILLAS LIMPIAS, ETC)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("PRODUCTOS EXHIBIDOS POR EL PERSONAL (OFERTAS O TEMPORADA)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("PRESENTACION DEL PERSONAL (UNIFORME, MAQUILLAJE, PEINADO)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("PLANOGRAMA", "$5.00", "0", "0");
            DG_tabla.Rows.Add("SEGUIMIENTO A SU FORMATOS PARA CUBRES", "$20.00", "0", "0");
            DG_tabla.Rows.Add("INFORMACION DE TIENDA, (PUBLICIDAD Y PROMOCIONES)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("REALIZAR CORRECTAMENTE LA DISTRIBUCION DEL PERSONAL ", "$20.00", "0", "0");
            DG_tabla.Rows.Add("INCIDENCIAS (BAÑOS, PASILLOS DESPEJADOS, TARAS SIN ACOMODAR, ETC.)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("MOVIMIENTO DE LUGAR, ZONA DE OFERTAS", "$5.00", "0", "0");
            DG_tabla.Rows.Add("ENVIAR EN TIEMPO Y FORMA COMISIONES (FOTOS DE CIERRE DE DIA)", "$10.00", "0", "0");
            DG_tabla.Rows.Add("PRODUCTO NO EXHIBIDO", "$10.00", "0", "0");
            DG_tabla.Rows.Add("AREA VACIA (VARILLAS Y PANEL)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("TENER REUNION DIARIA CON GERENTES Y ALMACEN PARA PASAR INFORMACION Y AREAS DE OPORTUNIDAD", "$5.00", "0", "0");
            DG_tabla.Rows.Add("SOLUCIONAR A LA BREVEDAD A PRODUCTOS CON PROBLEMAS EN EL AREA DE COBRO.(MAX. 5 MIN.) ", "$10.00", "0", "0");
            DG_tabla.Rows.Add("COMIDA(LLEGAR CON LA COMIDA O COMPRARLA SOLAMENTE CON LAS PERSONAS QUE VAN A OFRECERLA AHÍ. SOLO TORTILLAS Y UNA SOLA PERSONA)", "$5.00", "0", "0");
            DG_tabla.Rows.Add("DESCUENTO POR CAMARA", "$10.00", "0", "0");
            DG_tabla.Rows.Add("APOYAR FISICAMENTE EN CAJAS, CUANDO ESTA AUSENTE LA ENCARGADA. ", "$10.00", "0", "0");
            DG_tabla.Rows.Add("APOYO SEMANAL ", "$800.00", "0", "0");
            DG_tabla.Rows.Add("DESCUENTO", "", "0", "0");
            DG_tabla.Rows.Add("TOTAL", "0", "0", "0");
        

            DG_tabla.Columns["ASPECTOS"].Width = 700;








            //string query = "SELECT * FROM rd_calif_cubre_gte WHERE inicio_semana='"+inicio.ToString("yyyy-MM-dd")+"' AND fin_semana='"+fin.ToString("yyyy-MM-dd")+"'";
            string query = "SELECT * FROM rd_calif_gte WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "' and  puesto='CUBRE GERENTE'";
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
               
                ArrayList lista  = new ArrayList();
                lista.Clear();
                lista.Add("A");
                lista.Add("B");
                lista.Add("C");
                lista.Add("D");


                for (int i = 0; i < filas; i++)
                {
                    DG_tabla.Columns.Add(lista[i].ToString(),"");
                }

                dr = cmd.ExecuteReader();
                int nColumnas = DG_tabla.ColumnCount;
                int col = 1;
                double totalPagar = 0;
#pragma warning disable CS0219 // La variable 'prom' está asignada pero su valor nunca se usa
                double prom = 0;
#pragma warning restore CS0219 // La variable 'prom' está asignada pero su valor nunca se usa
                double apoyo_semanal = 800;
                double descuento = 0;
              
                while (dr.Read())
                {

                    if (col <= nColumnas)
                    {
                        DG_tabla.Columns[col].Name = dr["nombre_gerente"].ToString();
                        apoyo_semanal = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                        //prom = Convert.ToDouble(dr["promedio"].ToString());
                        DG_tabla.Columns[col].HeaderText = dr["nombre_gerente"].ToString();
                        DG_tabla.Rows[0].Cells[col].Value = dr["area_limpia"].ToString();
                        DG_tabla.Rows[1].Cells[col].Value = dr["precios_exhibidos"].ToString();
                        DG_tabla.Rows[2].Cells[col].Value = dr["precios_oferta"].ToString();
                        DG_tabla.Rows[3].Cells[col].Value = dr["exhibicion_productos"].ToString();
                        DG_tabla.Rows[4].Cells[col].Value = dr["limpieza_vitrina"].ToString();
                        DG_tabla.Rows[5].Cells[col].Value = dr["ofertas_temporada"].ToString();
                        DG_tabla.Rows[6].Cells[col].Value = dr["presentacion"].ToString();
                        DG_tabla.Rows[7].Cells[col].Value = dr["planograma"].ToString();
                        DG_tabla.Rows[8].Cells[col].Value = dr["formatos_cubres"].ToString();
                        DG_tabla.Rows[9].Cells[col].Value = dr["info_tienda"].ToString();
                        DG_tabla.Rows[10].Cells[col].Value = dr["distribucion_personal"].ToString();
                        DG_tabla.Rows[11].Cells[col].Value = dr["incidencias"].ToString();
                        DG_tabla.Rows[12].Cells[col].Value = dr["zona_ofertas"].ToString();
                        DG_tabla.Rows[13].Cells[col].Value = dr["enviar_comisiones"].ToString();
                        DG_tabla.Rows[14].Cells[col].Value = dr["prod_no_exhibido"].ToString();
                        DG_tabla.Rows[15].Cells[col].Value = dr["area_vacia"].ToString();
                        DG_tabla.Rows[16].Cells[col].Value = dr["reunion_diaria"].ToString();
                        DG_tabla.Rows[17].Cells[col].Value = dr["solucion_problemas"].ToString();
                        DG_tabla.Rows[18].Cells[col].Value = dr["comida"].ToString();
                        DG_tabla.Rows[19].Cells[col].Value = dr["descuento_camara"].ToString();
                        DG_tabla.Rows[20].Cells[col].Value = dr["apoyo_en_cajas"].ToString();


                        descuento =Convert.ToInt32(dr["total_descuento"].ToString());
                        totalPagar = apoyo_semanal - descuento;
                        DG_tabla.Rows[21].Cells[col].Value = apoyo_semanal.ToString("C2");
                        descuento =  Convert.ToInt32(dr["total_descuento"].ToString());
                        DG_tabla.Rows[22].Cells[col].Value = descuento.ToString("C2");
                        //totalPagar = 800-descuento;
                        DG_tabla.Rows[23].Cells[col].Value = totalPagar.ToString("C2");
                      
                        //DG_tabla.Rows[24].Cells[col].Value = dr["nombre_gerente"].ToString();
                        totalAcumulado += totalPagar;
                        col++;
                        
                    }
                    
                }
                dr.Close();

                TB_total.Text = totalAcumulado.ToString("C2");
                totalPagar = 0;
                totalAcumulado = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
                
            }
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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


            excel.Range["G29"].Value = TB_total.Text;
            excel.Range["G29"].NumberFormat = "$#,##0.00";
            excel.Visible = true;

        }
    }
}
