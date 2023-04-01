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
    public partial class IntercambioMercancia : Form 
    {

        string usuario = "";
        public IntercambioMercancia(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

      

        DataTable DTva = new DataTable();
        DataTable DTre = new DataTable();
        DataTable DTve = new DataTable();
        DataTable DTco = new DataTable();
        DataTable aux = new DataTable();
        DataTable maestro = new DataTable();
        string articulo = "";
        string descripcion = "";
        private void IntercambioMercancia_Load(object sender, EventArgs e)
        {
            //SE LLENA EL DATATABLE LINEAS CON LAS LINEAS DE CEDIS
            DataTable lineas = Kardex.BuscarLineas();


            //SE RECORRE EL DATATABLE LINEAS PARA LLENAR EL COMBOBOX CB_LINEAS
            for (int i = 0; i < lineas.Rows.Count; i++)
            {
                CB_lineas.Items.Add(lineas.Rows[i][0].ToString());
            }

           



            DTva.Columns.Add("ARTICULO",typeof(string));
            DTva.Columns.Add("EXISTENCIA", typeof(int));

            DTre.Columns.Add("ARTICULO", typeof(string));
            DTre.Columns.Add("EXISTENCIA", typeof(int));

            DTve.Columns.Add("ARTICULO", typeof(string));
            DTve.Columns.Add("EXISTENCIA", typeof(int));

            DTco.Columns.Add("ARTICULO", typeof(string));
            DTco.Columns.Add("EXISTENCIA", typeof(int));

            aux.Columns.Add("ARTICULO",typeof(string));
            aux.Columns.Add("DESCRIPCION", typeof(string));
            aux.Columns.Add("PRECIO MAY", typeof(double));
            aux.Columns.Add("PRECIO MEN", typeof(double));
            aux.Columns.Add("VALLARTA", typeof(int));
            aux.Columns.Add("RENA", typeof(int));
            aux.Columns.Add("VELAZQUEZ", typeof(int));
            aux.Columns.Add("COLOSO", typeof(int));

            maestro.Columns.Add("ARTICULO", typeof(string));
            maestro.Columns.Add("DESCRIPCION", typeof(string));
            maestro.Columns.Add("PRECIO MAY", typeof(double));
            maestro.Columns.Add("PRECIO MEN", typeof(double));
            maestro.Columns.Add("VALLARTA", typeof(int));
            maestro.Columns.Add("RENA", typeof(int));
            maestro.Columns.Add("VELAZQUEZ", typeof(int));
            maestro.Columns.Add("COLOSO", typeof(int));

            TB_va.Text = "0"; TB_re.Text = "0";TB_ve.Text ="0";TB_co.Text = "0";
        }

        

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            GRB_traspasos.Text = "TRASPASOS";

            DG_vallarta.Rows.Clear();
            DG_rena.Rows.Clear();
            DG_coloso.Rows.Clear();
            DG_velazquez.Rows.Clear();
            //DG_tabla.Rows.Clear();
            maestro.Rows.Clear();
            DTva.Rows.Clear();
            DTre.Rows.Clear();
            DTve.Rows.Clear();
            DTco.Rows.Clear();

            string linea = CB_lineas.SelectedItem.ToString();
            Productos prod = new Productos();
            DataTable articulos = prod.ArticulosPorLinea(linea);
            int va = 0, re = 0, ve = 0, co = 0;

            double preciomay = 0;
            double preciomen = 0;

            for (int i = 0; i <articulos.Rows.Count; i++)
            {

                preciomen = Convert.ToDouble(articulos.Rows[i][2].ToString());
                preciomay = Convert.ToDouble(articulos.Rows[i][3].ToString());

                preciomen = preciomen * 1.16;
                preciomay = preciomay * 1.16;
                maestro.Rows.Add(articulos.Rows[i][0].ToString(), articulos.Rows[i][1].ToString(),preciomen , preciomay, va,re,ve,co);
                
            }
           
            DTva = prod.ExistenciaVa(linea);
            DTre = prod.ExistenciaRe(linea);
            DTve = prod.ExistenciaVe(linea);
            DTco = prod.ExistenciaCo(linea);

            
            string articuloDG = "";
            string articuloDT = "";


            //VALLARTA
            for (int i = 0; i < maestro.Rows.Count; i++)
            {
                articuloDG = Convert.ToString(maestro.Rows[i][0].ToString());

                foreach (DataRow item in DTva.Rows)
                {
                    articuloDT = Convert.ToString(item[0]);

                    if (articuloDG.Equals(articuloDT))
                    {

                        //DG_tabla.Rows[i].Cells[4].Value = item[1];
                        maestro.Rows[i][4] = item[1];
                        item.Delete();
                        break;
                    }
                }               
                              
            }

            //RENA
            for (int i = 0; i < maestro.Rows.Count; i++)
            {
                articuloDG = Convert.ToString(maestro.Rows[i][0].ToString());

                foreach (DataRow item in DTre.Rows)
                {
                    articuloDT = Convert.ToString(item[0]);

                    if (articuloDG.Equals(articuloDT))
                    {

                        //DG_tabla.Rows[i].Cells[5].Value = item[1];
                        maestro.Rows[i][5] = item[1];
                        item.Delete();
                        break;
                    }
                }

            }

            //VELAZQUEZ
            for (int i = 0; i < maestro.Rows.Count; i++)
            {
                articuloDG = Convert.ToString(maestro.Rows[i][0].ToString());

                foreach (DataRow item in DTve.Rows)
                {
                    articuloDT = Convert.ToString(item[0]);

                    if (articuloDG.Equals(articuloDT))
                    {

                        //DG_tabla.Rows[i].Cells[6].Value = item[1];
                        maestro.Rows[i][6] = item[1];
                        item.Delete();
                        break;
                    }
                }

            }

            //COLOSO
            for (int i = 0; i < maestro.Rows.Count; i++)
            {
                articuloDG = Convert.ToString(maestro.Rows[i][0].ToString());

                foreach (DataRow item in DTco.Rows)
                {
                    articuloDT = Convert.ToString(item[0]);

                    if (articuloDG.Equals(articuloDT))
                    {

                        //DG_tabla.Rows[i].Cells[7].Value = item[1];
                        maestro.Rows[i][7] = item[1];
                        item.Delete();
                        break;
                    }
                }

            }


            DG_tabla.DataSource = maestro;
            DG_tabla.Columns["DESCRIPCION"].Width = 350;
            DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[3].DefaultCellStyle.Format = "C2";

        }

        private void DG_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            articulo = DG_tabla.Rows[e.RowIndex].Cells[0].Value.ToString();
            descripcion = DG_tabla.Rows[e.RowIndex].Cells[1].Value.ToString();

            


            GRB_traspasos.Text = "TRASPASOS DEL ARTICULO "+articulo+"  "+descripcion;


        }

        private void BT_verificar_Click(object sender, EventArgs e)
        {
            
          DG_vallarta.Rows.Clear();
            DG_rena.Rows.Clear();
            DG_coloso.Rows.Clear();
            DG_velazquez.Rows.Clear();
            string entrada = "select max(F_MOVIM) as FECHA,TIPO_MOVIM from movsinv where articulo = '" + articulo+ "' and TIPO_MOVIM = 'T+' GROUP BY TIPO_MOVIM";
            string salida = "select max(F_MOVIM) as FECHA,TIPO_MOVIM from movsinv where articulo = '" + articulo + "' and TIPO_MOVIM = 'T-' GROUP BY TIPO_MOVIM";
            MySqlConnection va = BDConexicon.VallartaOpen();
            MySqlConnection re = BDConexicon.RenaOpen();
            MySqlConnection ve = BDConexicon.VelazquezOpen();
            MySqlConnection co = BDConexicon.ColosoOpen();


            MySqlCommand cmdVA = new MySqlCommand(entrada, va);
            MySqlDataReader drVA = cmdVA.ExecuteReader();
            while (drVA.Read())
            {
                DG_vallarta.Rows.Add(drVA["FECHA"].ToString(), drVA["TIPO_MOVIM"].ToString());
            }
            drVA.Close();
           

            MySqlCommand cmdVA2 = new MySqlCommand(salida, va);
            MySqlDataReader drVA2= cmdVA2.ExecuteReader();
            while (drVA2.Read())
            {
                DG_vallarta.Rows.Add(drVA2["FECHA"].ToString(), drVA2["TIPO_MOVIM"].ToString());
            }
            drVA2.Close();
            va.Close();


            MySqlCommand cmdRE = new MySqlCommand(entrada, re);
            MySqlDataReader drRE = cmdRE.ExecuteReader();
            while (drRE.Read())
            {
                DG_rena.Rows.Add(drRE["FECHA"].ToString(), drRE["TIPO_MOVIM"].ToString());
            }
            drRE.Close();
        
            MySqlCommand cmdRE2 = new MySqlCommand(salida, re);
            MySqlDataReader drRE2 = cmdRE2.ExecuteReader();
            while (drRE2.Read())
            {
                DG_rena.Rows.Add(drRE2["FECHA"].ToString(), drRE2["TIPO_MOVIM"].ToString());
            }
            drRE2.Close();
            re.Close();

            MySqlCommand cmdVE = new MySqlCommand(entrada, ve);
            MySqlDataReader drVE = cmdVE.ExecuteReader();
            while (drVE.Read())
            {
                DG_velazquez.Rows.Add(drVE["FECHA"].ToString(), drVE["TIPO_MOVIM"].ToString());
            }
            drVE.Close();
           


            MySqlCommand cmdVE2 = new MySqlCommand(salida, ve);
            MySqlDataReader drVE2 = cmdVE2.ExecuteReader();
            while (drVE2.Read())
            {
                DG_velazquez.Rows.Add(drVE2["FECHA"].ToString(), drVE2["TIPO_MOVIM"].ToString());
            }
            drVE2.Close();
            ve.Close();


            MySqlCommand cmdCO = new MySqlCommand(entrada, co);
            MySqlDataReader drCO = cmdCO.ExecuteReader();
            while (drCO.Read())
            {
                DG_coloso.Rows.Add(drCO["FECHA"].ToString(), drCO["TIPO_MOVIM"].ToString());
            }
            drCO.Close();
        

            MySqlCommand cmdCO2 = new MySqlCommand(salida, co);
            MySqlDataReader drCO2 = cmdCO2.ExecuteReader();
            while (drCO2.Read())
            {
                DG_coloso.Rows.Add(drCO2["FECHA"].ToString(), drCO2["TIPO_MOVIM"].ToString());
            }
            drCO2.Close();
            co.Close();
        }

       

        private void TB_buscar_TextChanged(object sender, EventArgs e)
        {
            DataView view = maestro.DefaultView;
            view.RowFilter = string.Empty;
            view.RowFilter = "ARTICULO" + " LIKE '%" + TB_buscar.Text + "%'";
            DG_tabla.DataSource = view;
        }

        private void DG_velazquez_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BT_formato_Click(object sender, EventArgs e)
        {
            FormatoIntercambio formato = new FormatoIntercambio();
            formato.Show();
        }

        private void BT_pasar_Click(object sender, EventArgs e)
        {

            DateTime fecha = DateTime.Now;
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "INSERT INTO rd_intercambio_mercancia(articulo,descripcion,envia,vallarta,rena,velazquez,coloso,fecha,usuario,linea)VALUES(?articulo,?descripcion,?envia,?vallarta,?rena,?velazquez,?coloso,?fecha,?usuario,?linea)";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.Parameters.AddWithValue("?articulo",articulo);
                cmd.Parameters.AddWithValue("?descripcion", descripcion);
                cmd.Parameters.AddWithValue("?envia", CB_sucursal.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?vallarta", Convert.ToInt32(TB_va.Text));
                cmd.Parameters.AddWithValue("?rena", Convert.ToInt32(TB_re.Text));
                cmd.Parameters.AddWithValue("?velazquez", Convert.ToInt32(TB_ve.Text));
                cmd.Parameters.AddWithValue("?coloso", Convert.ToInt32(TB_co.Text));
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?usuario", usuario);
                cmd.Parameters.AddWithValue("?linea", CB_lineas.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha agregado el articulo al reporte de intercambio");
                TB_va.Text = "0"; TB_re.Text = "0"; TB_ve.Text = "0"; TB_co.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar articulo al reporte de intercambio  ["+ex+"]");
            }

           
        }
    }
}
