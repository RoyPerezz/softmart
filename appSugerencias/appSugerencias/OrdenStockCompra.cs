using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class OrdenStockCompra : Form
    {
        public OrdenStockCompra()
        {
            InitializeComponent();
        }





        #region VARIABLES
#pragma warning disable CS0414 // El campo 'OrdenStockCompra.porciento' está asignado pero su valor nunca se usa
        string porciento = "";
#pragma warning restore CS0414 // El campo 'OrdenStockCompra.porciento' está asignado pero su valor nunca se usa
        double costoxpaq = 0, costoxpz = 0, importe_bo = 0, importe_ce = 0, importe_va = 0, importe_re = 0, importe_ve = 0, importe_co = 0, porcentaje = 0, cajasxpedir = 0;

        string modelo = "", claveProducto = "", descripcion = "", departamento = "";
        int pzxpedir = 0, cajaspedbo = 0, pzxcaja = 0, pzxpaq = 0, ped_bo = 0, max_ce = 0, ex_ce = 0, ped_ce = 0, max_va = 0, ex_va = 0, ex_pasada_va = 0, max_re = 0, ex_re = 0, ex_pasada_re = 0, ped_re = 0;
        int max_ve = 0, ex_ve = 0, ex_pasada_ve = 0, ped_ve = 0, max_co, ex_co = 0, ex_pasada_co = 0, ped_co = 0, ped_va = 0, pedidoxCajaBod = 0, compra = 0, existencia = 0, vendido = 0, oferta = 0;

        double total_bo = 0, total_ce = 0, total_va = 0, total_re = 0, total_ve = 0, total_co = 0, total = 0;
        int idreg = 0; string tipo = "";
        #endregion



        #region METODOS


        public int CalcularPedidoTienda(int maximo, int existencia)
        {
            int pedido = 0;

            if (existencia > maximo / 2)
            {
                pedido = 0;
            }

            if (existencia <= maximo / 2)
            {
                pedido = maximo;
            }

            if (existencia == 0)
            {
                pedido = maximo;
            }

            return pedido;
        }

        public void TraerProveedores()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT DISTINCT proveedor FROM rd_stock_compra";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            Proveedor prov = new Proveedor();
            while (dr.Read())
            {

                CB_proveedor.Items.Add(prov.NombreProveedor(dr["proveedor"].ToString()));
            }

            dr.Close();
            conexion.Close();
        }


        public void Calcular()
        {

           

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {

                //TOMAR LOS VALORES EN LA TABLA 
                pzxpedir = Convert.ToInt32(DG_tabla.Rows[i].Cells[4].Value);
                cajasxpedir = Convert.ToDouble(DG_tabla.Rows[i].Cells[5].Value);
                pedidoxCajaBod = Convert.ToInt32(DG_tabla.Rows[i].Cells[6].Value);
                pzxcaja = Convert.ToInt32(DG_tabla.Rows[i].Cells[7].Value);
                pzxpaq = Convert.ToInt32(DG_tabla.Rows[i].Cells[8].Value);
                costoxpaq = Convert.ToDouble(DG_tabla.Rows[i].Cells[9].Value);
                costoxpz = Convert.ToDouble(DG_tabla.Rows[i].Cells[10].Value);
                ped_bo = Convert.ToInt32(DG_tabla.Rows[i].Cells[11].Value);
                importe_bo = Convert.ToDouble(DG_tabla.Rows[i].Cells[12].Value);
                max_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells[13].Value);
                ex_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells[14].Value);
                ped_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells[15].Value);
                importe_ce = Convert.ToDouble(DG_tabla.Rows[i].Cells[16].Value);
                max_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[17].Value);
                ex_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[18].Value);
                ex_pasada_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[19].Value);
                //ped_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[20].Value);
                ped_va = CalcularPedidoTienda(max_va, ex_va);
                importe_va = Convert.ToDouble(DG_tabla.Rows[i].Cells[21].Value);
                max_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[22].Value);
                ex_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[23].Value);
                ex_pasada_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[24].Value);
                //ped_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[25].Value);
                ped_re = CalcularPedidoTienda(max_re, ex_re);
                importe_re = Convert.ToDouble(DG_tabla.Rows[i].Cells[26].Value);
                max_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[27].Value);
                ex_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[28].Value);
                ex_pasada_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[29].Value);
                //ped_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[30].Value);
                ped_ve = CalcularPedidoTienda(max_ve, ex_ve);
                importe_ve = Convert.ToDouble(DG_tabla.Rows[i].Cells[31].Value);
                max_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[32].Value);
                ex_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[33].Value);
                ex_pasada_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[34].Value);
                //ped_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[35].Value);
                ped_co = CalcularPedidoTienda(max_co, ex_co);
                importe_co = Convert.ToDouble(DG_tabla.Rows[i].Cells[36].Value);
                compra = Convert.ToInt32(DG_tabla.Rows[i].Cells[37].Value);
                existencia = Convert.ToInt32(DG_tabla.Rows[i].Cells[38].Value);
                vendido = Convert.ToInt32(DG_tabla.Rows[i].Cells[39].Value);
                porcentaje =Convert.ToDouble(DG_tabla.Rows[i].Cells[40].Value);
                oferta = Convert.ToInt32(DG_tabla.Rows[i].Cells[41].Value);


                //OPERACIONES

                if (tipo.Equals("BODEGA"))
                {
                    pzxpedir = ped_bo;
                    existencia = ex_ce;
                }
                else
                {
                    pzxpedir = ped_va + ped_re + ped_ve + ped_co;
                    existencia = ex_ce + ex_va + ex_re + ex_ve + ex_co;
                }



                cajasxpedir = Convert.ToDouble(pzxpedir) / Convert.ToDouble(pzxcaja) / Convert.ToDouble(pzxpaq);
                costoxpz = costoxpaq / pzxpaq;
                ped_bo = pedidoxCajaBod * pzxcaja;
                ped_ce = ped_bo - ped_va - ped_re - ped_co - ped_co;
                importe_bo = ped_bo * costoxpaq;
                importe_ce = ped_ce * costoxpaq;
                importe_va = ped_va * costoxpaq;
                importe_re = ped_re * costoxpaq;
                importe_ve = ped_ve * costoxpaq;
                importe_co = ped_co * costoxpaq;
                compra = pedidoxCajaBod * pzxcaja * pzxpaq;

                vendido = compra - existencia;
                porcentaje = (Convert.ToDouble(vendido) / Convert.ToDouble(compra));


              

                //AGREGAR LOS NUEVOS VALORES CALCULADOS A LA TABLA
                DG_tabla.Rows[i].Cells[4].Value = pzxpedir;
                DG_tabla.Rows[i].Cells[5].Value = cajasxpedir;
                DG_tabla.Rows[i].Cells[6].Value = pedidoxCajaBod;
                DG_tabla.Rows[i].Cells[7].Value = pzxcaja;
                DG_tabla.Rows[i].Cells[8].Value = pzxpaq;
                DG_tabla.Rows[i].Cells[9].Value = costoxpaq;
                DG_tabla.Rows[i].Cells[10].Value = costoxpz;
                DG_tabla.Rows[i].Cells[11].Value = ped_bo;
                DG_tabla.Rows[i].Cells[12].Value = importe_bo;
                DG_tabla.Rows[i].Cells[13].Value = max_ce;
                DG_tabla.Rows[i].Cells[14].Value = ex_ce;
                DG_tabla.Rows[i].Cells[15].Value = ped_ce;
                DG_tabla.Rows[i].Cells[16].Value = importe_ce;
                DG_tabla.Rows[i].Cells[17].Value = max_va;
                DG_tabla.Rows[i].Cells[18].Value = ex_va;
                DG_tabla.Rows[i].Cells[19].Value = ex_pasada_va;
                DG_tabla.Rows[i].Cells[20].Value = ped_va;
                DG_tabla.Rows[i].Cells[21].Value = importe_va;
                DG_tabla.Rows[i].Cells[22].Value = max_re;
                DG_tabla.Rows[i].Cells[23].Value = ex_re;
                DG_tabla.Rows[i].Cells[24].Value = ex_pasada_re;
                DG_tabla.Rows[i].Cells[25].Value = ped_re;
                DG_tabla.Rows[i].Cells[26].Value = importe_re;
                DG_tabla.Rows[i].Cells[27].Value = max_ve;
                DG_tabla.Rows[i].Cells[28].Value = ex_ve;
                DG_tabla.Rows[i].Cells[29].Value = ex_pasada_ve;
                DG_tabla.Rows[i].Cells[30].Value = ped_ve;
                DG_tabla.Rows[i].Cells[31].Value = importe_ve;
                DG_tabla.Rows[i].Cells[32].Value = max_co;
                DG_tabla.Rows[i].Cells[33].Value = ex_co;
                DG_tabla.Rows[i].Cells[34].Value = ex_pasada_co;
                DG_tabla.Rows[i].Cells[35].Value = ped_co;
                DG_tabla.Rows[i].Cells[36].Value = importe_co;
                DG_tabla.Rows[i].Cells[37].Value = compra;
                DG_tabla.Rows[i].Cells[38].Value = existencia;
                DG_tabla.Rows[i].Cells[39].Value = vendido;
                DG_tabla.Rows[i].Cells[40].Value = porcentaje;
                DG_tabla.Rows[i].Cells[41].Value = oferta;


                //totales
                total_bo += Convert.ToDouble(DG_tabla.Rows[i].Cells[12].Value);
                total_ce += Convert.ToDouble(DG_tabla.Rows[i].Cells[16].Value);
                total_va += Convert.ToDouble(DG_tabla.Rows[i].Cells[21].Value);
                total_re += Convert.ToDouble(DG_tabla.Rows[i].Cells[26].Value);
                total_ve += Convert.ToDouble(DG_tabla.Rows[i].Cells[30].Value);
                total_co += Convert.ToDouble(DG_tabla.Rows[i].Cells[36].Value);



                //LB_totalbo.Text = Convert.ToString(total_bo);
                //LB_totalce.Text = Convert.ToString(total_ce);
                //LB_totalva.Text = Convert.ToString(total_va);
                //LB_totalre.Text = Convert.ToString(total_re);
                //LB_totalve.Text = Convert.ToString(total_ve);
                //LB_totalco.Text = Convert.ToString(total_co);

                LB_totalbo.Text = total_bo.ToString("C2");
                LB_totalce.Text = total_ce.ToString("C2");
                LB_totalva.Text = total_va.ToString("C2");
                LB_totalre.Text = total_re.ToString("C2");
                LB_totalve.Text = total_ve.ToString("C2");
                LB_totalco.Text = total_co.ToString("C2");


                DG_tabla.Columns[9].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[10].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[12].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[16].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[21].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[26].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[31].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[36].DefaultCellStyle.Format = "C2";

                DG_tabla.Columns[40].DefaultCellStyle.Format = "P1";


            }
            total = total_bo + total_ce + total_va + total_re + total_re + total_ve + total_co;

            total_bo = 0; total_ce = 0; total_va = 0; total_re = 0; total_ve = 0; total_co = 0; total = 0;
        }


        #endregion

        #region BOTONES

        private void BT_actualizar_Click_1(object sender, EventArgs e)
        {

            Calcular();
        }

        private void BT_guardarCambios_Click_1(object sender, EventArgs e)
        {


            decimal digito = decimal.Parse(LB_totalbo.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalbo = digito.ToString("G0");
          
            decimal digito2 = decimal.Parse(LB_totalce.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalce = digito2.ToString("G0");
        
            decimal digito3 = decimal.Parse(LB_totalva.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalva = digito3.ToString("G0");
     
            decimal digito4 = decimal.Parse(LB_totalre.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalre = digito4.ToString("G0");
         
            decimal digito5 = decimal.Parse(LB_totalve.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalve = digito5.ToString("G0");
      
            decimal digito6 = decimal.Parse(LB_totalco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalco = digito6.ToString("G0");


            string query = "UPDATE rd_detalle_stock_compra SET modelo ='" + modelo + "', claveProducto='" + claveProducto + "', descripcion='" + descripcion + "',departamento='" + departamento + "'," +
              "pzxpedir=" + pzxpedir + ",cajasxpedir=" + cajasxpedir + ", cajaspedbo=" + cajaspedbo + ",pzxcaja=" + pzxcaja + ",pzxpaq=" + pzxpaq + ",costoxpaq=" + costoxpaq + ",costoxpz=" + costoxpz + ",ped_bo=" + ped_bo + "," +
              "importe_bo=" + importe_bo + ",max_ce=" + max_ce + ",ex_ce=" + ex_ce + ",ped_ce=" + ped_ce + ",importeCE=" + importe_ce + ",max_va=" + max_va + ",ex_va=" + ex_va + ",ex_pasada_va=" + ex_pasada_va + ",ped_va=" + ped_va + "," +
              "importe_va=" + importe_va + ",max_re=" + max_re + ",ex_re=" + ex_re + ",ex_pasada_re=" + ex_pasada_re + ",ped_re=" + ped_re + ",importe_re=" + importe_re + ",max_ve=" + max_ve + ",ex_ve=" + ex_ve + ",ex_pasada_ve=" + ex_pasada_ve + "," +
              "ped_ve=" + ped_ve + ",importe_ve=" + importe_ve + ",max_co=" + max_co + ",ex_co=" + ex_co + ",ex_pasada_co=" + ex_pasada_co + ",ped_co=" + ped_co + ",importe_co=" + importe_co + ",oferta=" + oferta + "";


            string query2 = "UPDATE rd_orden_compra SET totalbo=" + totalbo+ ", totalce=" +totalce+ ",totalva=" + totalva+ "," +
                "totalre=" +totalre+ ", totalve=" + totalve + ",totalco=" +totalco+ " WHERE idreg=" + Convert.ToInt32(TB_idstock.Text) + "";

            MySqlConnection conexion = BDConexicon.BodegaOpen();


            //  GUARDA LOS TOTALES EN LA TABLA rd_stock_compra
            MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
            cmd2.ExecuteNonQuery();
            //******************************************************

            MySqlCommand cmd = null;

            try
            {
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {

                    //TOMAR LOS VALORES EN LA TABLA 
                    modelo = Convert.ToString(DG_tabla.Rows[i].Cells[0].Value);
                    claveProducto = Convert.ToString(DG_tabla.Rows[i].Cells[1].Value);
                    descripcion = Convert.ToString(DG_tabla.Rows[i].Cells[2].Value);
                    departamento = Convert.ToString(DG_tabla.Rows[i].Cells[3].Value);
                    pzxpedir = Convert.ToInt32(DG_tabla.Rows[i].Cells[4].Value);
                    cajasxpedir = Convert.ToDouble(DG_tabla.Rows[i].Cells[5].Value);
                    pedidoxCajaBod = Convert.ToInt32(DG_tabla.Rows[i].Cells[6].Value);
                    pzxcaja = Convert.ToInt32(DG_tabla.Rows[i].Cells[7].Value);
                    pzxpaq = Convert.ToInt32(DG_tabla.Rows[i].Cells[8].Value);
                    costoxpaq = Convert.ToInt32(DG_tabla.Rows[i].Cells[9].Value);
                    costoxpz = Convert.ToDouble(DG_tabla.Rows[i].Cells[10].Value);
                    ped_bo = Convert.ToInt32(DG_tabla.Rows[i].Cells[11].Value);
                    importe_bo = Convert.ToDouble(DG_tabla.Rows[i].Cells[12].Value);
                    max_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells[13].Value);
                    ex_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells[14].Value);
                    ped_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells[15].Value);
                    importe_ce = Convert.ToDouble(DG_tabla.Rows[i].Cells[16].Value);
                    max_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[17].Value);
                    ex_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[18].Value);
                    ex_pasada_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[19].Value);
                    ped_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[20].Value);
                    importe_va = Convert.ToDouble(DG_tabla.Rows[i].Cells[21].Value);
                    max_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[22].Value);
                    ex_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[23].Value);
                    ex_pasada_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[24].Value);
                    ped_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[25].Value);
                    importe_re = Convert.ToDouble(DG_tabla.Rows[i].Cells[26].Value);
                    max_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[27].Value);
                    ex_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[28].Value);
                    ex_pasada_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[29].Value);
                    ped_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[30].Value);
                    importe_ve = Convert.ToDouble(DG_tabla.Rows[i].Cells[31].Value);
                    max_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[32].Value);
                    ex_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[33].Value);
                    ex_pasada_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[34].Value);
                    ped_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[35].Value);
                    importe_co = Convert.ToDouble(DG_tabla.Rows[i].Cells[36].Value);
                    compra = Convert.ToInt32(DG_tabla.Rows[i].Cells[37].Value);
                    existencia = Convert.ToInt32(DG_tabla.Rows[i].Cells[38].Value);
                    vendido = Convert.ToInt32(DG_tabla.Rows[i].Cells[39].Value);
                    porcentaje = Convert.ToDouble(DG_tabla.Rows[i].Cells[40].Value);
                    oferta = Convert.ToInt32(DG_tabla.Rows[i].Cells[41].Value);
                    idreg = Convert.ToInt32(DG_tabla.Rows[i].Cells[42].Value);

                    //OPERACIONES

                    if (tipo.Equals("BODEGA"))
                    {
                        pzxpedir = ped_bo;
                    }
                    else
                    {
                        pzxpedir = ped_va + ped_re + ped_ve + ped_co;

                    }


                    cajasxpedir = Convert.ToDouble(pzxpedir) / Convert.ToDouble(pzxcaja) / Convert.ToDouble(pzxpaq);
                    costoxpz = costoxpaq / pzxpaq;
                    ped_bo = pedidoxCajaBod * pzxcaja;
                    ped_ce = ped_bo - ped_va - ped_re - ped_co - ped_co;
                    importe_bo = ped_bo * costoxpaq;
                    importe_ce = ped_ce * costoxpaq;
                    importe_va = ped_va * costoxpaq;
                    importe_re = ped_re * costoxpaq;
                    importe_ve = ped_ve * costoxpaq;
                    importe_co = ped_co * costoxpaq;
                    compra = pedidoxCajaBod * pzxcaja * pzxpaq;
                    existencia = ex_ce + ex_va + ex_re + ex_ve + ex_co;
                    vendido = compra - existencia;
                    porcentaje = (Convert.ToDouble(vendido) / Convert.ToDouble(compra)) * 100;

                    cmd = new MySqlCommand("UPDATE rd_detalle_orden_compra SET modelo ='" + modelo + "', claveProducto='" + claveProducto + "', descripcion='" + descripcion + "',departamento='" + departamento + "'," +
               "pzxpedir=" + pzxpedir + ",cajasxpedir=" + cajasxpedir + ", cajaspedbo=" + pedidoxCajaBod + ",pzxcaja=" + pzxcaja + ",pzxpaq=" + pzxpaq + ",costoxpaq=" + costoxpaq + ",costoxpz=" + costoxpz + ",ped_bo=" + ped_bo + "," +
               "importe_bo=" + importe_bo + ",max_ce=" + max_ce + ",ex_ce=" + ex_ce + ",ped_ce=" + ped_ce + ",importeCE=" + importe_ce + ",max_va=" + max_va + ",ex_va=" + ex_va + ",ex_pasada_va=" + ex_pasada_va + ",ped_va=" + ped_va + "," +
               "importe_va=" + importe_va + ",max_re=" + max_re + ",ex_re=" + ex_re + ",ex_pasada_re=" + ex_pasada_re + ",ped_re=" + ped_re + ",importe_re=" + importe_re + ",max_ve=" + max_ve + ",ex_ve=" + ex_ve + ",ex_pasada_ve=" + ex_pasada_ve + "," +
               "ped_ve=" + ped_ve + ",importe_ve=" + importe_ve + ",max_co=" + max_co + ",ex_co=" + ex_co + ",ex_pasada_co=" + ex_pasada_co + ",ped_co=" + ped_co + ",importe_co=" + importe_co + ",oferta=" + oferta + " WHERE idreg=" + idreg + "", conexion);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Orden Actualizada");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el stock " + ex);
            }
        }


        #endregion


        #region EVENTOS

        private void BuscarStockCompra_Load(object sender, EventArgs e)
        {

            TraerProveedores();

            RB_ocultar.Checked = true;
            DG_tabla.Columns["ID_REG"].Visible = false;
            //INMOVILIZAR COLUMNAS
            DG_tabla.Columns["MODELO_"].Frozen = true;
            DG_tabla.Columns["CLAVE"].Frozen = true;
            DG_tabla.Columns["DESCRIPCION_"].Frozen = true;


            //TAMAÑO DE CELDAS
            DG_tabla.Columns["MODELO_"].Width = 150;
            DG_tabla.Columns["CLAVE"].Width = 150;
            DG_tabla.Columns["DESCRIPCION_"].Width = 300;
            DG_tabla.Columns["DEPTO"].Width = 120;
            DG_tabla.Columns["PIEZAS"].Width = 60;
            DG_tabla.Columns["CAJAS"].Width = 60;
            DG_tabla.Columns["PEDIDO_BOD"].Width = 50;
            DG_tabla.Columns["MAX_CE_"].Width = 50;
            DG_tabla.Columns["EXT_CE"].Width = 50;
            DG_tabla.Columns["PED_CE_"].Width = 50;
            DG_tabla.Columns["MAX_VA_"].Width = 50;
            DG_tabla.Columns["EXT_VA"].Width = 50;
            DG_tabla.Columns["PEDIDO_VA"].Width = 50;
            DG_tabla.Columns["MAX_RE_"].Width = 50;
            DG_tabla.Columns["EXT_RE"].Width = 50;
            DG_tabla.Columns["PEDIDO_RE"].Width = 50;
            DG_tabla.Columns["MAX_VE_"].Width = 50;
            DG_tabla.Columns["EXT_VE"].Width = 50;
            DG_tabla.Columns["PEDIDO_VE"].Width = 50;
            DG_tabla.Columns["MAX_CO_"].Width = 50;
            DG_tabla.Columns["EXT_CO"].Width = 50;
            DG_tabla.Columns["PEDIDO_CO"].Width = 50;



            DG_tabla.EnableHeadersVisualStyles = false;
            DG_tabla.Columns[0].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[1].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[2].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[3].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[4].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[5].HeaderCell.Style.BackColor = Color.DodgerBlue;

            DG_tabla.Columns[6].HeaderCell.Style.BackColor = Color.Cyan;
            DG_tabla.Columns[7].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[8].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[9].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[10].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[11].HeaderCell.Style.BackColor = Color.Magenta;
            DG_tabla.Columns[12].HeaderCell.Style.BackColor = Color.Magenta;
            DG_tabla.Columns[13].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[14].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[15].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[16].HeaderCell.Style.BackColor = Color.DodgerBlue;

            DG_tabla.Columns[17].HeaderCell.Style.BackColor = Color.Orange;
            DG_tabla.Columns[18].HeaderCell.Style.BackColor = Color.Orange;
            DG_tabla.Columns[19].HeaderCell.Style.BackColor = Color.Orange;
            DG_tabla.Columns[20].HeaderCell.Style.BackColor = Color.Orange;
            DG_tabla.Columns[21].HeaderCell.Style.BackColor = Color.Orange;

            DG_tabla.Columns[22].HeaderCell.Style.BackColor = Color.DarkGreen;
            DG_tabla.Columns[23].HeaderCell.Style.BackColor = Color.DarkGreen;
            DG_tabla.Columns[24].HeaderCell.Style.BackColor = Color.DarkGreen;
            DG_tabla.Columns[25].HeaderCell.Style.BackColor = Color.DarkGreen;
            DG_tabla.Columns[26].HeaderCell.Style.BackColor = Color.DarkGreen;


            DG_tabla.Columns[27].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[28].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[29].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[30].HeaderCell.Style.BackColor = Color.DodgerBlue;
            DG_tabla.Columns[31].HeaderCell.Style.BackColor = Color.DodgerBlue;

            DG_tabla.Columns[32].HeaderCell.Style.BackColor = Color.DarkOrange;
            DG_tabla.Columns[33].HeaderCell.Style.BackColor = Color.DarkOrange;
            DG_tabla.Columns[34].HeaderCell.Style.BackColor = Color.DarkOrange;
            DG_tabla.Columns[35].HeaderCell.Style.BackColor = Color.DarkOrange;
            DG_tabla.Columns[36].HeaderCell.Style.BackColor = Color.DarkOrange;










        }

        private void RB_ocultar_CheckedChanged(object sender, EventArgs e)
        {

            DG_tabla.Columns["PEDIDO_BOD"].Visible = false;
            DG_tabla.Columns["IMPORTE_BOD"].Visible = false;
            DG_tabla.Columns["IMPORTE_CE_"].Visible = false;
            DG_tabla.Columns["IMPORTE_VA_"].Visible = false;
            DG_tabla.Columns["IMPORTE_RE_"].Visible = false;
            DG_tabla.Columns["IMPORTE_VE_"].Visible = false;
            DG_tabla.Columns["IMPORTE_CO_"].Visible = false;

        }

        private void RB_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            DG_tabla.Columns["PEDIDO_BOD"].Visible = true;
            DG_tabla.Columns["IMPORTE_BOD"].Visible = true;
            DG_tabla.Columns["IMPORTE_CE_"].Visible = true;
            DG_tabla.Columns["IMPORTE_VA_"].Visible = true;
            DG_tabla.Columns["IMPORTE_RE_"].Visible = true;
            DG_tabla.Columns["IMPORTE_VE_"].Visible = true;
            DG_tabla.Columns["IMPORTE_CO_"].Visible = true;

        }

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            Proveedor prov = new Proveedor();
            TB_proveedor.Text = prov.IdProveedor(CB_proveedor.SelectedItem.ToString());


            CB_stocks.Items.Clear();
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT idreg,consecutivo,proveedor,folio FROM rd_orden_compra WHERE proveedor ='" + TB_proveedor.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            string consecutivo = "", proveedor = "", folio = "";
            while (dr.Read())
            {
                TB_idstock.Text = dr["idreg"].ToString();
                consecutivo = dr["consecutivo"].ToString();
                proveedor = dr["proveedor"].ToString();

                folio = dr["folio"].ToString();

                CB_stocks.Items.Add(consecutivo + " " + prov.NombreProveedor(proveedor) + " " + folio);
            }

            dr.Close();


            //string query2 = "select * from rd_detalle_orden_compra where fk_stock="+idreg+"";
            //MySqlCommand cmd2 = new MySqlCommand(query2,conexion);
            //MySqlDataReader dr2 = cmd2.ExecuteReader();
            //while (dr2.Read())
            //{

            //}
            //dr2.Close();




            conexion.Close();
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();

            string query = "SELECT * FROM rd_detalle_orden_compra WHERE fk_stock='" + TB_idstock.Text + "' order by idreg";
            MySqlConnection conexion = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand(query, conexion);

            string columnaExtra = "";

            string query2 = "SELECT columnaExtra,tipo from rd_orden_compra where idreg='" + TB_idstock.Text + "'";
            MySqlCommand cmd2 = new MySqlCommand(query2, conexion);

            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                columnaExtra = dr2["columnaExtra"].ToString();
                tipo = dr2["tipo"].ToString();
            }

            dr2.Close();



            if (tipo.Equals("CEDIS"))
            {
                RB_cedis.Checked = true;
                RB_todas.Checked = false;
            }

            if (tipo.Equals("TODAS"))
            {
                RB_cedis.Checked = false;
                RB_todas.Checked = true;
            }


            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {



                DG_tabla.Rows.Add(dr["modelo"].ToString(), dr["claveProducto"].ToString(), dr["descripcion"].ToString(), dr["departamento"].ToString(), dr["pzxpedir"].ToString(), Convert.ToDouble(dr["cajasxpedir"].ToString()), dr["cajaspedbo"].ToString(),
                    dr["pzxcaja"].ToString(), dr["pzxpaq"].ToString(), dr["costoxpaq"].ToString(), dr["costoxpz"].ToString(), dr["ped_bo"].ToString(), dr["importe_bo"].ToString(), dr["max_ce"].ToString(), dr["ex_ce"].ToString(), dr["ped_ce"].ToString(), dr["importeCE"].ToString(), dr["max_va"].ToString()
                    , dr["ex_va"].ToString(), dr["ex_pasada_va"].ToString(), dr["ped_va"].ToString(), dr["importe_va"].ToString(), dr["max_re"].ToString(), dr["ex_re"].ToString(), dr["ex_pasada_re"].ToString(), dr["ped_re"].ToString(), dr["importe_re"].ToString(), dr["max_ve"].ToString(), dr["ex_ve"].ToString(),
                    dr["ex_pasada_ve"].ToString(), dr["ped_ve"].ToString(), dr["importe_ve"].ToString(), dr["max_co"].ToString(), dr["ex_co"].ToString(), dr["ex_pasada_co"].ToString(), dr["ped_co"].ToString(), dr["importe_co"].ToString(), 0, 0, 0, 0, dr["oferta"].ToString(), dr["idreg"].ToString());


            }
            dr.Close();


            DG_tabla.Columns["EX_PASADA_VA_"].HeaderText = columnaExtra;
            DG_tabla.Columns["EX_PASADA_RE_"].HeaderText = columnaExtra;
            DG_tabla.Columns["EX_PASADA_VE_"].HeaderText = columnaExtra;
            DG_tabla.Columns["EX_PASADA_CO_"].HeaderText = columnaExtra;


            DG_tabla.Columns[37].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_tabla.Columns[38].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_tabla.Columns[39].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_tabla.Columns[40].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Calcular();

        


            conexion.Close();
        }
        #endregion










        private void CB_stocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //string stock = CB_stocks.SelectedItem.ToString();
            //List<string> list = new List<string>();
            //list = stock.Split(' ').ToList();
            //string consecutivo = list[0].ToString();
            //string proveedor = list[1].ToString();
            //string folio = list[2].ToString();


            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT idreg FROM rd_orden_compra WHERE descripcion='"+CB_stocks.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TB_idstock.Text = dr["idreg"].ToString();
            }
            dr.Close();
            conexion.Close();
        }

       
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

  
      
        private void BT_guardarCambios_Click(object sender, EventArgs e)
        {
           



               

           

        }

        private void BT_actualizar_Click(object sender, EventArgs e)
        {

        }


       
        
    }
}
