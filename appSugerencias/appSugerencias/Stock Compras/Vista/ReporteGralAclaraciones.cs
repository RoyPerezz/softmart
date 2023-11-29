using appSugerencias.Stock_Compras.Controlador;
using appSugerencias.Stock_Compras.Modelo;
using appSugerencias.Utilidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Stock_Compras.Vista
{
    public partial class ReporteGralAclaraciones : Form
    {

        string usuario = "",area="";
        string tipo = "";
        public ReporteGralAclaraciones(string usuario)
        {

            this.usuario = usuario;
            InitializeComponent();
        }

        string proveedor = ""; //almacena el codigo del proveedor seleccionado
        
        private void ReporteGralAclaraciones_Load(object sender, EventArgs e)
        {

            area = Usuarios.AreaTrabajo(usuario,"BODEGA");

            if (area.Equals("COMPRAS"))
            {
                DG_tabla.Columns["FALTA_VA"].Visible = false;
                DG_tabla.Columns["FALTA_RE"].Visible = false;
                DG_tabla.Columns["FALTA_VE"].Visible = false;
                DG_tabla.Columns["FALTA_CO"].Visible = false;

                DG_tabla.Columns["MEDO_VA"].Visible = false;
                DG_tabla.Columns["MEDO_RE"].Visible = false;
                DG_tabla.Columns["MEDO_VE"].Visible = false;
                DG_tabla.Columns["MEDO_CO"].Visible = false;

                DG_tabla.Columns["SOBRA_VA"].Visible = false;
                DG_tabla.Columns["SOBRA_RE"].Visible = false;
                DG_tabla.Columns["SOBRA_VE"].Visible = false;
                DG_tabla.Columns["SOBRA_CO"].Visible = false;

                DG_tabla.Columns["IMPORTE_VA"].Visible = false;
                DG_tabla.Columns["IMPORTE_RE"].Visible = false;
                DG_tabla.Columns["IMPORTE_VE"].Visible = false;
                DG_tabla.Columns["IMPORTE_CO"].Visible = false;

            }
            List<string> lista = StockController.ListaProveedores();

            //for (int i = 0; i < lista.Count; i++)
            //{
                CB_proveedor.DataSource = lista;
            //}
            DG_tabla.Columns["DESCRIP"].Width = 250;
            DG_tabla.Columns["PZXPAQ"].Width = 40;
            DG_tabla.Columns["COSTO_PAQ"].Width = 70;
            DG_tabla.Columns["COSTO_PZ"].Width = 70;
            DG_tabla.Columns["FALTA_VA"].Width = 40;
            DG_tabla.Columns["MEDO_VA"].Width = 34;
            DG_tabla.Columns["SOBRA_VA"].Width = 46;
            DG_tabla.Columns["IMPORTE_VA"].Width = 70;
            DG_tabla.Columns["FALTA_RE"].Width = 40;
            DG_tabla.Columns["MEDO_RE"].Width = 34;
            DG_tabla.Columns["SOBRA_RE"].Width = 46;
            DG_tabla.Columns["IMPORTE_RE"].Width = 70;
            DG_tabla.Columns["FALTA_VE"].Width = 40;
            DG_tabla.Columns["MEDO_VE"].Width = 34;
            DG_tabla.Columns["SOBRA_VE"].Width = 46;
            DG_tabla.Columns["IMPORTE_VE"].Width = 70;
            DG_tabla.Columns["FALTA_CO"].Width = 40;
            DG_tabla.Columns["MEDO_CO"].Width = 34;
            DG_tabla.Columns["SOBRA_CO"].Width = 46;
            DG_tabla.Columns["IMPORTE_CO"].Width = 70;
            DG_tabla.Columns["TOTAL_FALTANTE"].Width = 100;
            DG_tabla.Columns["TOTAL_SOBRANTE"].Width = 100;
            DG_tabla.Columns["IMPORTE_TOTAL"].Width = 100;

        }

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_id.Text = StockController.ClaveProveedor(CB_proveedor.Text); //Clave del proveedor
            List<string> stocks = StockController.BuscarStocks(TB_id.Text);
            CB_stock.DataSource = stocks;
          
        }

        private void CB_proveedor_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void CB_proveedor_DisplayMemberChanged(object sender, EventArgs e)
        {
            proveedor = CB_proveedor.SelectedValue.ToString();
            TB_id.Text = proveedor;
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            int faltava = 0, mal_estado_va = 0, sobranteva = 0, faltare = 0, mal_estado_re = 0, sobrantere = 0, faltave = 0, mal_estado_ve = 0, sobranteve = 0, faltaco = 0, mal_estado_co = 0, sobranteco = 0;

           
            MySqlConnection con = BDConexicon.BodegaOpen();



            DG_tabla.Rows.Clear();

            string consulta = "SELECT tipo FROM  rd_stock_compra WHERE idreg='"+TB_idStock.Text+"'";
            MySqlCommand cmd1 = new MySqlCommand(consulta,con);
            MySqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                tipo = dr1["tipo"].ToString();
            }
            dr1.Close();



            if (tipo.Equals("TODAS"))
            {

                DG_tabla.Columns["FALTA_BO"].Visible = false;
                DG_tabla.Columns["MEDO_BO"].Visible = false;
                DG_tabla.Columns["SOBRA_BO"].Visible = false;
                DG_tabla.Columns["IMPORTE_BO"].Visible = false;




            }
            else if(tipo.Equals("CEDIS"))
            {
                DG_tabla.Columns["FALTA_BO"].Visible = true;
                DG_tabla.Columns["MEDO_BO"].Visible = true;
                DG_tabla.Columns["SOBRA_BO"].Visible = true;
                DG_tabla.Columns["IMPORTE_BO"].Visible = true;
            }


            string query = "SELECT" +
                "                idreg," +
                "                modelo," +
                "                claveProducto," +
                "                descripcion," +
                "                pzxpaq," +
                "                costoxpaq," +
                "                costoxpz," +
                "                falta_bo," +
                "                mal_estado_bo," +
                "                sobrante_bo," +
                "                total_aclaracion_bo," +
                "                falta_va," +
                "                mal_estado_va," +
                "                sobrante_va," +
                "                total_aclaracion_va," +
                "                falta_re," +
                "                mal_estado_re," +
                "                sobrante_re," +
                "                total_aclaracion_re," +
                "                falta_ve," +
                "                mal_estado_ve," +
                "                sobrante_ve," +
                "                total_aclaracion_ve," +
                "                 falta_co," +
                "                mal_estado_co," +
                "                sobrante_co," +
                "                total_aclaracion_co " +              
                "          FROM rd_detalle_stock_compra" +
                "          WHERE fk_stock='"+TB_idStock.Text+"'" +
                "          ORDER BY idreg";
            //string query = "SELECT" +
            //   "                idreg," +
            //   "                modelo," +
            //   "                claveProducto," +
            //   "                descripcion," +
            //   "                pzxpaq," +
            //   "                costoxpaq," +
            //   "                costoxpz," +
            //   "                falta_va," +
            //   "                mal_estado_va," +
            //   "                sobrante_va," +
            //   "                falta_re," +
            //   "                mal_estado_re," +
            //   "                sobrante_re," +
            //   "                falta_ve," +
            //   "                mal_estado_ve," +
            //   "                sobrante_ve," +
            //   "                falta_co," +
            //   "                mal_estado_co," +
            //   "                sobrante_co" +
            //   "          FROM rd_detalle_stock_compra" +
            //   "          WHERE fk_stock='" + TB_idStock.Text + "'" +
            //   "          ORDER BY idreg";

           
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = null;
            dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {

                //faltava = Convert.ToInt32(dr["falta_va"].ToString());
                //mal_estado_va = Convert.ToInt32(dr["mal_estado_va"].ToString());
                //sobranteva = Convert.ToInt32(dr["sobrante_va"].ToString());

                //faltare = Convert.ToInt32(dr["falta_re"].ToString());
                //mal_estado_re = Convert.ToInt32(dr["mal_estado_re"].ToString());
                //sobrantere = Convert.ToInt32(dr["sobrante_re"].ToString());

                //faltave = Convert.ToInt32(dr["falta_ve"].ToString());
                //mal_estado_ve = Convert.ToInt32(dr["mal_estado_ve"].ToString());
                //sobranteve = Convert.ToInt32(dr["sobrante_ve"].ToString());

                //faltaco = Convert.ToInt32(dr["falta_co"].ToString());
                //mal_estado_co = Convert.ToInt32(dr["mal_estado_co"].ToString());
                //sobranteco = Convert.ToInt32(dr["sobrante_co"].ToString());

                //if (faltav)
                //{

                //}

                DG_tabla.Rows.Add(dr["idreg"].ToString(),dr["modelo"].ToString(),dr["claveProducto"].ToString(),dr["descripcion"].ToString(),dr["pzxpaq"].ToString(),dr["costoxpaq"].ToString(),dr["costoxpz"].ToString(),dr["falta_bo"].ToString(), dr["mal_estado_bo"].ToString(), dr["sobrante_bo"].ToString(), dr["total_aclaracion_bo"].ToString(), dr["falta_va"].ToString(), dr["mal_estado_va"].ToString(), dr["sobrante_va"].ToString(), dr["total_aclaracion_va"].ToString(), dr["falta_re"].ToString(), dr["mal_estado_re"].ToString(), dr["sobrante_re"].ToString(), dr["total_aclaracion_re"].ToString(), dr["falta_ve"].ToString(), dr["mal_estado_ve"].ToString(), dr["sobrante_ve"].ToString(), dr["total_aclaracion_ve"].ToString(), dr["falta_co"].ToString(), dr["mal_estado_co"].ToString(), dr["sobrante_co"].ToString(), dr["total_aclaracion_co"],0,0);
            }
            dr.Close();


            int id = 0;
            
            MySqlCommand cmd2 = null;
            
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value.ToString());
                cmd2 = new MySqlCommand("SELECT * FROM rd_mercancia_aclaraciones where fk_id_articulo=" + id + "",con);
                dr = cmd2.ExecuteReader();

                while (dr.Read())
                {

                    if (tipo.Equals("CEDIS"))
                    {
                        DG_tabla.Rows[i].Cells["FALTA_BO"].Value = dr["FALTA_BO"].ToString();
                        DG_tabla.Rows[i].Cells["MEDO_BO"].Value = dr["MAL_ESTADO_BO"].ToString();
                        DG_tabla.Rows[i].Cells["SOBRA_BO"].Value = dr["SOBRANTE_BO"].ToString();
                        DG_tabla.Rows[i].Cells["IMPORTE_BO"].Value = dr["IMPORTE_BO"].ToString();
                    }


                    DG_tabla.Rows[i].Cells["FALTA_VA"].Value = dr["FALTA_VA"].ToString();
                    DG_tabla.Rows[i].Cells["MEDO_VA"].Value = dr["MAL_ESTADO_VA"].ToString();
                    DG_tabla.Rows[i].Cells["SOBRA_VA"].Value = dr["SOBRANTE_VA"].ToString();
                    DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value = dr["IMPORTE_VA"].ToString();
                    DG_tabla.Rows[i].Cells["FALTA_RE"].Value = dr["FALTA_RE"].ToString();
                    DG_tabla.Rows[i].Cells["MEDO_RE"].Value = dr["MAL_ESTADO_RE"].ToString();
                    DG_tabla.Rows[i].Cells["SOBRA_RE"].Value = dr["SOBRANTE_RE"].ToString();
                    DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value = dr["IMPORTE_RE"].ToString();
                    DG_tabla.Rows[i].Cells["FALTA_VE"].Value = dr["FALTA_VE"].ToString();
                    DG_tabla.Rows[i].Cells["MEDO_VE"].Value = dr["MAL_ESTADO_VE"].ToString();
                    DG_tabla.Rows[i].Cells["SOBRA_VE"].Value = dr["SOBRANTE_VE"].ToString();
                    DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value = dr["IMPORTE_VE"].ToString();
                    DG_tabla.Rows[i].Cells["FALTA_CO"].Value = dr["FALTA_CO"].ToString();
                    DG_tabla.Rows[i].Cells["MEDO_CO"].Value = dr["MAL_ESTADO_CO"].ToString();
                    DG_tabla.Rows[i].Cells["SOBRA_CO"].Value = dr["SOBRANTE_CO"].ToString();
                    DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value = dr["IMPORTE_CO"].ToString();

                }
                dr.Close();
            }

            con.Close();

            Calcular(tipo);
        }

        private void CB_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT idreg" +
                "           FROM rd_stock_compra" +
                "           WHERE descripcion='"+CB_stock.Text+"'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_idStock.Text = dr["idreg"].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {

            List<DetalleStockCompra> aclaraciones = new List<DetalleStockCompra>();
            DetalleStockCompra detalle = null;
            try
            {


                if (tipo.Equals("TODAS"))
                {
                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        detalle = new DetalleStockCompra()
                        {
                            Id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value.ToString()),
                            Falta_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_VA"].Value.ToString()),
                            Mal_estado_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_VA"].Value.ToString()),
                            Sobrante_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_VA"].Value.ToString()),
                            Importe_va = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value.ToString()),

                            Falta_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_RE"].Value.ToString()),
                            Mal_estado_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_RE"].Value.ToString()),
                            Sobrante_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_RE"].Value.ToString()),
                            Importe_re = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value.ToString()),

                            Falta_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_VE"].Value.ToString()),
                            Mal_estado_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_VE"].Value.ToString()),
                            Sobrante_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_VE"].Value.ToString()),
                            Importe_ve = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value.ToString()),

                            Falta_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_CO"].Value.ToString()),
                            Mal_estado_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_CO"].Value.ToString()),
                            Sobrante_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_CO"].Value.ToString()),
                            Importe_co = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value.ToString()),

                            Total_faltante = Convert.ToInt32(DG_tabla.Rows[i].Cells["TOTAL_FALTANTE"].Value.ToString()),
                            Total_sobrante = Convert.ToInt32(DG_tabla.Rows[i].Cells["TOTAL_SOBRANTE"].Value.ToString()),
                            Importe_total_aclaracion = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_TOTAL"].Value.ToString()),
                        };

                        aclaraciones.Add(detalle);
                    }
                }
                else if(tipo.Equals("CEDIS"))
                {
                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        detalle = new DetalleStockCompra()
                        {
                            Id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value.ToString()),
                            Falta_bo = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_BO"].Value.ToString()),
                            Mal_estado_bo = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_BO"].Value.ToString()),
                            Sobrante_bo = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_BO"].Value.ToString()),
                            Importe_bo = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_BO"].Value.ToString()),


                            Falta_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_VA"].Value.ToString()),
                            Mal_estado_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_VA"].Value.ToString()),
                            Sobrante_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_VA"].Value.ToString()),
                            Importe_va = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value.ToString()),

                            Falta_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_RE"].Value.ToString()),
                            Mal_estado_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_RE"].Value.ToString()),
                            Sobrante_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_RE"].Value.ToString()),
                            Importe_re = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value.ToString()),

                            Falta_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_VE"].Value.ToString()),
                            Mal_estado_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_VE"].Value.ToString()),
                            Sobrante_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_VE"].Value.ToString()),
                            Importe_ve = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value.ToString()),

                            Falta_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_CO"].Value.ToString()),
                            Mal_estado_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_CO"].Value.ToString()),
                            Sobrante_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_CO"].Value.ToString()),
                            Importe_co = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value.ToString()),

                            Total_faltante = Convert.ToInt32(DG_tabla.Rows[i].Cells["TOTAL_FALTANTE"].Value.ToString()),
                            Total_sobrante = Convert.ToInt32(DG_tabla.Rows[i].Cells["TOTAL_SOBRANTE"].Value.ToString()),
                            Importe_total_aclaracion = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_TOTAL"].Value.ToString()),
                        };

                        aclaraciones.Add(detalle);
                    }
                }

               

                StockController.GuardarAclaracion(aclaraciones,tipo);
                MessageBox.Show("Se han guardado los cambios");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar las aclaraciones de articulos: "+ex);
            }
        }

        public void Calcular(string tipo)
        {
            double importeBO=0,importeVA = 0, importeRE = 0, importeVE = 0, importeCO = 0, totalFaltante = 0, totalSobrante = 0, importeTotal = 0, costoXPaq = 0,totalBO=0,totalVA=0,totalRE=0,totalVE=0,totalCO=0,total=0;

            int faltaBO=0,medoBO=0,sobraBO=0,faltaVA = 0, medoVA = 0, sobraVA = 0, faltaRE = 0, medoRE = 0, sobraRE = 0, faltaVE = 0, medoVE = 0, sobraVE = 0, faltaCO = 0, medoCO = 0, sobraCO = 0, t_faltante = 0, t_sobrante = 0;
            int t_faltanteVA = 0, t_sobraVA = 0, t_faltanteRE = 0, t_sobraRE = 0, t_faltanteVE = 0, t_sobraVE = 0, t_faltanteCO = 0, t_sobraCO = 0;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {

                costoXPaq = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PAQ"].Value.ToString());

                faltaBO = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_BO"].Value.ToString());
                medoBO = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_BO"].Value.ToString());
                sobraBO = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_BO"].Value.ToString());

                faltaVA = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_VA"].Value.ToString());
                medoVA = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_VA"].Value.ToString());
                sobraVA = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_VA"].Value.ToString());

                faltaRE = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_RE"].Value.ToString());
                medoRE = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_RE"].Value.ToString());
                sobraRE = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_RE"].Value.ToString());

                faltaVE = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_VE"].Value.ToString());
                medoVE = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_VE"].Value.ToString());
                sobraVE = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_VE"].Value.ToString());

                faltaCO = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTA_CO"].Value.ToString());
                medoCO = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO_CO"].Value.ToString());
                sobraCO = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRA_CO"].Value.ToString());

                if (tipo.Equals("TODAS"))
                {
                    totalBO = 0;

                    t_faltante += faltaVA + faltaRE + faltaVE + faltaCO + medoVA + medoRE + medoVE + medoCO;
                    t_sobrante += sobraVA + sobraRE + sobraVE + sobraCO;


                    importeVA = (sobraVA * costoXPaq) - (faltaVA * costoXPaq) - (medoVA * costoXPaq);
                    importeRE = (sobraRE * costoXPaq) - (faltaRE * costoXPaq) - (medoRE * costoXPaq);
                    importeVE = (sobraVE * costoXPaq) - (faltaVE * costoXPaq) - (medoVE * costoXPaq);
                    importeCO = (sobraCO * costoXPaq) - (faltaCO * costoXPaq) - (medoCO * costoXPaq);

                    DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value = importeVA;
                    DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value = importeRE;
                    DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value = importeVE;
                    DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value = importeCO;

                    totalVA += importeVA;
                    totalRE += importeRE;
                    totalVE += importeVE;
                    totalCO += importeCO;

                    DG_tabla.Rows[i].Cells["TOTAL_FALTANTE"].Value = t_faltante;
                    DG_tabla.Rows[i].Cells["TOTAL_SOBRANTE"].Value = t_sobrante;

                    importeTotal = (t_sobrante * costoXPaq) - (t_faltante * costoXPaq);

                    DG_tabla.Rows[i].Cells["IMPORTE_TOTAL"].Value = importeTotal;
                    t_faltante = 0; t_sobrante = 0;
                }
                else if (tipo.Equals("CEDIS"))
                {
                    t_faltante += faltaBO + faltaVA + faltaRE + faltaVE + faltaCO + medoBO + medoVA + medoRE + medoVE + medoCO;
                    t_sobrante += sobraBO + sobraVA + sobraRE + sobraVE + sobraCO;


                    importeBO = (sobraBO * costoXPaq) - (faltaBO * costoXPaq) - (medoBO * costoXPaq);
                    importeVA = (sobraVA * costoXPaq) - (faltaVA * costoXPaq) - (medoVA * costoXPaq);
                    importeRE = (sobraRE * costoXPaq) - (faltaRE * costoXPaq) - (medoRE * costoXPaq);
                    importeVE = (sobraVE * costoXPaq) - (faltaVE * costoXPaq) - (medoVE * costoXPaq);
                    importeCO = (sobraCO * costoXPaq) - (faltaCO * costoXPaq) - (medoCO * costoXPaq);

                    DG_tabla.Rows[i].Cells["IMPORTE_BO"].Value = importeBO;
                    DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value = importeVA;
                    DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value = importeRE;
                    DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value = importeVE;
                    DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value = importeCO;

                    totalBO += importeBO;
                    totalVA += importeVA;
                    totalRE += importeRE;
                    totalVE += importeVE;
                    totalCO += importeCO;

                    DG_tabla.Rows[i].Cells["TOTAL_FALTANTE"].Value = t_faltante;
                    DG_tabla.Rows[i].Cells["TOTAL_SOBRANTE"].Value = t_sobrante;

                    importeTotal = (t_sobrante * costoXPaq) - (t_faltante * costoXPaq);

                    DG_tabla.Rows[i].Cells["IMPORTE_TOTAL"].Value = importeTotal;
                    t_faltante = 0; t_sobrante = 0;
                }

               

                
            }


            total = totalBO + totalVA + totalRE + totalVE + totalCO;
            TB_bodega.Text = totalBO.ToString("C2");
            TB_total_va.Text = totalVA.ToString("C2");
            TB_total_re.Text = totalRE.ToString("C2");
            TB_total_ve.Text = totalVE.ToString("C2");
            TB_total_co.Text = totalCO.ToString("C2");
            TB_total.Text = total.ToString("C2");
            DG_tabla.Columns["COSTO_PAQ"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["COSTO_PZ"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPORTE_BO"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPORTE_VA"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPORTE_RE"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPORTE_VE"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPORTE_CO"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPORTE_TOTAL"].DefaultCellStyle.Format = "C2";

        }
        private void BT_calcular_Click(object sender, EventArgs e)
        {

            Calcular(tipo);
          
        }
    }
}
