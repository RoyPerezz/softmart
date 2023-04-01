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
    public partial class Rep_ComCubreJefeAlmacen : Form
    {
        public Rep_ComCubreJefeAlmacen()
        {
            InitializeComponent();
        }

        private void Rep_ComCubreJefeAlmacen_Load(object sender, EventArgs e)
        {
            DG_tabla.Rows.Add("LIMPIEZA INTERIOR Y EXTERIOR");
            DG_tabla.Rows.Add("CLAVE Y DESCRIPCION EN PRODUCTOS");
            DG_tabla.Rows.Add("BAÑOS LIMPIOS");
            DG_tabla.Rows.Add("MENOS MERCANCIA PENDIENTE DE ENVIAR");
            DG_tabla.Rows.Add("PASILLOS DESPEJADOS NO MERCANCIA EN PISO");
            DG_tabla.Rows.Add("EMPAQUES BIEN SELLADOS");
            DG_tabla.Rows.Add("NO MERCANCIA FUERA DE SU EMPAQUE");
            DG_tabla.Rows.Add("NO REZAGO DE DEVOLUCIONES A PROVEEDOR");
            DG_tabla.Rows.Add("REPARTO DE 3 A 5 DIAS DE ATRAZO");
            DG_tabla.Rows.Add("CALIFICACION");
            DG_tabla.Rows.Add("APOYO SEMANAL");
            DG_tabla.Rows.Add("DESCUENTO");
            DG_tabla.Rows.Add("TOTAL A PAGAR");
            DG_tabla.Rows.Add("CUBRE");

            DG_tabla.Columns["ASPECTOS"].Width = 350;
        }


        double totalAcumulado = 0;

        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            string query = "SELECT * FROM rd_calif_cubre_jefealmacen WHERE inicio_semana ='" + inicio.ToString("yyyy-MM-dd") + "' and fin_semana='" + fin.ToString("yyyy-MM-dd") + "'";

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
                lista.Add("A");
                lista.Add("B");
                lista.Add("C");
                lista.Add("D");


                for (int i = 0; i < filas; i++)
                {
                    DG_tabla.Columns.Add(lista[i].ToString(), "");
                }

                dr = cmd.ExecuteReader();
                int nColumnas = DG_tabla.ColumnCount;
                int col = 1;
                double totalPagar = 0;
                double prom = 0;
                double apoyo_semanal = 0;
                double descuento = 0;
               
                while (dr.Read())
                {

                    if (col <= nColumnas)
                    {
                        DG_tabla.Columns[col].Name = dr["sucursal"].ToString();
                        apoyo_semanal = Convert.ToDouble(dr["apoyo_semanal"].ToString());
                        prom = Convert.ToDouble(dr["promedio"].ToString());
                        DG_tabla.Columns[col].HeaderText = dr["sucursal"].ToString();

                        DG_tabla.Rows[0].Cells[col].Value = dr["limpieza"].ToString();
                        DG_tabla.Rows[1].Cells[col].Value = dr["clave_descrip"].ToString();
                        DG_tabla.Rows[2].Cells[col].Value = dr["banios"].ToString();
                        DG_tabla.Rows[3].Cells[col].Value = dr["merc_pendiente"].ToString();


                        DG_tabla.Rows[4].Cells[col].Value = dr["pasillos"].ToString();
                        DG_tabla.Rows[5].Cells[col].Value = dr["empaques"].ToString();
                        DG_tabla.Rows[6].Cells[col].Value = dr["fuera_empaque"].ToString();
                        DG_tabla.Rows[7].Cells[col].Value = dr["devoluciones"].ToString();

                        DG_tabla.Rows[8].Cells[col].Value = dr["reparto_atrasado"].ToString();
                        DG_tabla.Rows[9].Cells[col].Value = dr["promedio"].ToString();
                        DG_tabla.Rows[10].Cells[col].Value = apoyo_semanal.ToString("C2");
                        descuento = 800 - (800 * (prom / 100));
                        DG_tabla.Rows[11].Cells[col].Value = descuento.ToString("C2");
                        totalPagar = 800 - descuento;
                        DG_tabla.Rows[12].Cells[col].Value = totalPagar.ToString("C2");
                        DG_tabla.Rows[13].Cells[col].Value = dr["cubre"].ToString();
                        totalAcumulado += totalPagar;
                        col++;

                    }

                }
                dr.Close();

                TB_total.Text = totalAcumulado.ToString("C2");
                totalPagar = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar la informacion: " + ex);
            }
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

            excel.Range["F18"].Value = totalAcumulado.ToString("C2");


            excel.Visible = true;
        }
    }
}
