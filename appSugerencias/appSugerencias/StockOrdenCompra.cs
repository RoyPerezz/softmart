using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class StockOrdenCompra : Form
    {

        string usuario = "";

        public StockOrdenCompra(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        #region VARIABLES

        double costoXPaq = 0, cajasXPedir = 0, costoXPz = 0,total=0,costo_unitario=0;
        double ped_bo = 0, imp_bo = 0, ped_ce = 0;
        int exva = 0, max_ce = 0, maxva = 0, exre = 0, maxre = 0, exco = 0, maxco = 0, exve = 0, maxve = 0, cajaspedbo = 0, exce = 0;
        double totalbo = 0, totalce = 0, totalva = 0, totalre = 0, totalve = 0, totalco = 0;
        int ex_pasada_va = 0, ex_pasada_re = 0, ex_pasada_ve = 0, ex_pasada_co = 0;
        double pedidoXCaja = 0, pzXCaja = 0, pzXPaq = 0, pzXPedir = 0, ped_va = 0, ped_re = 0, ped_ve = 0, ped_co = 0, importe_bo = 0, importe_va = 0, importe_re = 0, importe_ve = 0, importe_co = 0, importe_ce = 0;
        string modelo = "", claveProducto = "", descripcion = "", departamento = "";
        #endregion


        #region METODOS

        public double CostoArticulo(string articulo)
        {
            double costo = 0;
            string query = "SELECT COSTO_U FROM PRODS WHERE ARTICULO='"+articulo+"'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                costo = Convert.ToDouble(dr["COSTO_U"].ToString());
                costo = (costo * 0.16) + costo;
            }

            dr.Close();
            conexion.Close();

            return costo;
        }
        public int PiezasXCajaCE(string articulo)
        {
            int piezas = 0;
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select Peso from prods where articulo='"+articulo+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                piezas = Convert.ToInt32(dr["Peso"].ToString());
            }
            dr.Close();
            conexion.Close();
            return piezas;
        }

        //public int PiezasXCajaVA(string articulo)
        //{
        //    int piezas = 0;
        //    MySqlConnection conexion = BDConexicon.VallartaOpen();
        //    string query = "select Peso from prods where articulo='" + articulo + "'";
        //    MySqlCommand cmd = new MySqlCommand(query, conexion);
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        piezas = Convert.ToInt32(dr["Peso"].ToString());
        //    }
        //    dr.Close();
        //    conexion.Close();
        //    return piezas;
        //}

        //public int PiezasXCajaRE(string articulo)
        //{
        //    int piezas = 0;
        //    MySqlConnection conexion = BDConexicon.RenaOpen();
        //    string query = "select Peso from prods where articulo='" + articulo + "'";
        //    MySqlCommand cmd = new MySqlCommand(query, conexion);
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        piezas = Convert.ToInt32(dr["Peso"].ToString());
        //    }
        //    dr.Close();
        //    conexion.Close();
        //    return piezas;
        //}

        //public int PiezasXCajaVE(string articulo)
        //{
        //    int piezas = 0;
        //    MySqlConnection conexion = BDConexicon.VelazquezOpen();
        //    string query = "select Peso from prods where articulo='" + articulo + "'";
        //    MySqlCommand cmd = new MySqlCommand(query, conexion);
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        piezas = Convert.ToInt32(dr["Peso"].ToString());
        //    }
        //    dr.Close();
        //    conexion.Close();
        //    return piezas;
        //}

        //public int PiezasXCajaCO(string articulo)
        //{
        //    int piezas = 0;
        //    MySqlConnection conexion = BDConexicon.ColosoOpen();
        //    string query = "select Peso from prods where articulo='" + articulo + "'";
        //    MySqlCommand cmd = new MySqlCommand(query, conexion);
        //    MySqlDataReader dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        piezas = Convert.ToInt32(dr["Peso"].ToString());
        //    }
        //    dr.Close();
        //    conexion.Close();
        //    return piezas;
        //}

        public void Buscar()
        {
            DG_tabla.Rows.Clear();
            string tipoStock = "";
            string query = "SELECT * FROM rd_detalle_stock_compra WHERE fk_stock='" + TB_idstock.Text + "' order by idreg";
            MySqlConnection conexion = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand(query, conexion);

            string columnaExtra = "";

            string query2 = "SELECT totalbo,totalce,totalva,totalre,totalve,totalco,columnaExtra,tipo from rd_stock_compra where idreg='" + TB_idstock.Text + "'";
            MySqlCommand cmd2 = new MySqlCommand(query2, conexion);

            double totalbo = 0, totalce = 0, totalva = 0, totalre = 0, totalve = 0, totalco = 0;

            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                columnaExtra = dr2["columnaExtra"].ToString();
                totalbo = Convert.ToDouble(dr2["totalbo"].ToString());
                totalce = Convert.ToDouble(dr2["totalce"].ToString());
                totalva = Convert.ToDouble(dr2["totalva"].ToString());
                totalre = Convert.ToDouble(dr2["totalre"].ToString());
                totalve = Convert.ToDouble(dr2["totalve"].ToString());
                totalco = Convert.ToDouble(dr2["totalco"].ToString());
                tipoStock = dr2["tipo"].ToString();
            }

            dr2.Close();


            if (tipoStock.Equals("CEDIS"))
            {
                RB_cedis.Checked = true;
                RB_tiendas.Checked = false;

                DG_tabla.Columns[4].Visible = true;
                DG_tabla.Columns[5].Visible = true;
                DG_tabla.Columns[6].Visible = true;
                DG_tabla.Columns[11].Visible = true;
                DG_tabla.Columns[12].Visible = true;
                DG_tabla.Columns[13].Visible = true;
                DG_tabla.Columns[14].Visible = true;
                DG_tabla.Columns[15].Visible = true;
                DG_tabla.Columns[16].Visible = true;
            }

            if (tipoStock.Equals("TODAS"))
            {

                 RB_cedis.Checked = false;
               RB_tiendas.Checked = true;

                DG_tabla.Columns[4].Visible = false;
                DG_tabla.Columns[5].Visible = false;
                DG_tabla.Columns[6].Visible = false;
                DG_tabla.Columns[11].Visible = false;
                DG_tabla.Columns[12].Visible = false;
                DG_tabla.Columns[13].Visible = false;
                DG_tabla.Columns[14].Visible = false;
                DG_tabla.Columns[15].Visible = false;
                DG_tabla.Columns[16].Visible = false;
            }


            LB_totalbo.Text = totalbo.ToString("C2");
            LB_totalce.Text = totalce.ToString("C2");
            LB_totalva.Text = totalva.ToString("C2");
            LB_totalre.Text = totalre.ToString("C2");
            LB_totalve.Text = totalve.ToString("C2");
            LB_totalco.Text = totalco.ToString("C2");
            total = totalbo + totalce + totalva + totalre + totalve + totalco;

            LB_total.Text = total.ToString("C2");

            MySqlDataReader dr = cmd.ExecuteReader();
            int exce = 0, exva = 0, exre = 0, exve = 0, exco = 0;
            while (dr.Read())
            {

                //trae la existencia real del articulo 
                //exce = Existencia(dr["claveProducto"].ToString(), "BODEGA");
                //exva = Existencia(dr["claveProducto"].ToString(), "VALLARTA");
                //exre = Existencia(dr["claveProducto"].ToString(), "RENA");
                //exve = Existencia(dr["claveProducto"].ToString(), "VELAZQUEZ");
                //exco = Existencia(dr["claveProducto"].ToString(), "COLOSO");


                //se agregan los datos en el datagrid
                DG_tabla.Rows.Add(dr["modelo"].ToString(), dr["claveProducto"].ToString(), dr["descripcion"].ToString(), dr["departamento"].ToString(), dr["pzxpedir"].ToString(), Convert.ToDouble(dr["cajasxpedir"].ToString()), dr["cajaspedbo"].ToString(),
                    dr["pzxcaja"].ToString(), dr["pzxpaq"].ToString(), Convert.ToDouble(dr["costoxpaq"].ToString()), Convert.ToDouble(dr["costoxpz"].ToString()), dr["ped_bo"].ToString(), Convert.ToDouble(dr["importe_bo"].ToString()), dr["max_ce"].ToString(), exce, dr["ped_ce"].ToString(), Convert.ToDouble(dr["importeCE"].ToString()), dr["max_va"].ToString()
                    , dr["ex_va"].ToString(), dr["ex_pasada_va"].ToString(), dr["ped_va"].ToString(), Convert.ToDouble(dr["importe_va"].ToString()), dr["max_re"].ToString(), dr["ex_re"].ToString(), dr["ex_pasada_re"].ToString(), dr["ped_re"].ToString(), Convert.ToDouble(dr["importe_re"].ToString()), dr["max_ve"].ToString(), dr["ex_ve"].ToString(),
                    dr["ex_pasada_ve"].ToString(), dr["ped_ve"].ToString(), Convert.ToDouble(dr["importe_ve"].ToString()), dr["max_co"].ToString(), dr["ex_co"].ToString(), dr["ex_pasada_co"].ToString(), dr["ped_co"].ToString(), Convert.ToDouble(dr["importe_co"].ToString()), dr["idreg"].ToString(),dr["costou"].ToString());


            }
            dr.Close();


            DG_tabla.Columns["EX_PASADA_VA"].HeaderText = columnaExtra;
            DG_tabla.Columns["EX_PASADA_RE"].HeaderText = columnaExtra;
            DG_tabla.Columns["EX_PASADA_VE"].HeaderText = columnaExtra;
            DG_tabla.Columns["EX_PASADA_CO"].HeaderText = columnaExtra;

            DG_tabla.Columns[9].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[10].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[12].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[16].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[21].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[26].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[31].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[36].DefaultCellStyle.Format = "C2";

            //Calcular();
            conexion.Close();
        }


        public void Actualizar()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string insertarDetalle = "INSERT INTO rd_detalle_stock_compra(fk_stock,modelo,claveProducto,descripcion,departamento,pzxpedir,cajasxpedir,cajaspedbo,pzxcaja,pzxpaq,costoxpaq,costoxpz,ped_bo,importe_bo,max_ce,ex_ce,ped_ce,importeCE,max_va,ex_va,ex_pasada_va,ped_va,importe_va,max_re,ex_re,ex_pasada_re,ped_re,importe_re,max_ve,ex_ve,ex_pasada_ve,ped_ve,importe_ve,max_co,ex_co,ex_pasada_co,ped_co,importe_co,oferta)" +
                  "VALUES(?fk_stock,?modelo,?claveProducto,?descripcion,?departamento,?pzxpedir,?cajasxpedir,?cajaspedbo,?pzxcaja,?pzxpaq,?costoxpaq,?costoxpz,?ped_bo,?importe_bo,?max_ce,?ex_ce,?ped_ce,?importeCE,?max_va,?ex_va,?ex_pasada_va,?ped_va,?importe_va,?max_re,?ex_re,?ex_pasada_re,?ped_re,?importe_re,?max_ve,?ex_ve,?ex_pasada_ve,?ped_ve,?importe_ve,?max_co,?ex_co,?ex_pasada_co,?ped_co,?importe_co,?oferta)";

           

            string idArticulo = "";
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                idArticulo = Convert.ToString(DG_tabla.Rows[i].Cells["ID"].Value);
                if (string.IsNullOrEmpty(idArticulo))
                {
                    MySqlCommand insertar = new MySqlCommand(insertarDetalle, conexion);
                    insertar.Parameters.AddWithValue("?fk_stock", TB_idstock.Text);
                    if (DG_tabla.Rows[i].Cells[0].Value.ToString().Equals(""))
                    {
                        insertar.Parameters.AddWithValue("?modelo", "");
                    }
                    else
                    {
                        insertar.Parameters.AddWithValue("?modelo", DG_tabla.Rows[i].Cells["MODELO"].Value.ToString());
                    }


                    if (DG_tabla.Rows[i].Cells[1].Value.ToString().Equals(""))
                    {
                        insertar.Parameters.AddWithValue("?claveProducto", "");
                    }
                    else
                    {
                        insertar.Parameters.AddWithValue("?claveProducto", DG_tabla.Rows[i].Cells["CLAVE"].Value.ToString());
                    }




                    insertar.Parameters.AddWithValue("?descripcion", DG_tabla.Rows[i].Cells[2].Value.ToString());
                    insertar.Parameters.AddWithValue("?departamento", DG_tabla.Rows[i].Cells[3].Value.ToString());
                    insertar.Parameters.AddWithValue("?pzxpedir", DG_tabla.Rows[i].Cells[4].Value);
                    insertar.Parameters.AddWithValue("?cajasxpedir", DG_tabla.Rows[i].Cells[5].Value);
                    insertar.Parameters.AddWithValue("?cajaspedbo", DG_tabla.Rows[i].Cells[6].Value);
                    insertar.Parameters.AddWithValue("?pzxcaja", DG_tabla.Rows[i].Cells[7].Value);
                    insertar.Parameters.AddWithValue("?pzxpaq", DG_tabla.Rows[i].Cells[8].Value);
                    insertar.Parameters.AddWithValue("?costoxpaq", DG_tabla.Rows[i].Cells[9].Value);
                    insertar.Parameters.AddWithValue("?costoxpz", DG_tabla.Rows[i].Cells[10].Value);
                    insertar.Parameters.AddWithValue("?ped_bo", DG_tabla.Rows[i].Cells[11].Value);
                    insertar.Parameters.AddWithValue("?importe_bo", DG_tabla.Rows[i].Cells[12].Value);
                    insertar.Parameters.AddWithValue("?max_ce", DG_tabla.Rows[i].Cells[13].Value);
                    insertar.Parameters.AddWithValue("?ex_ce", DG_tabla.Rows[i].Cells[14].Value);
                    insertar.Parameters.AddWithValue("?ped_ce", DG_tabla.Rows[i].Cells[15].Value);
                    insertar.Parameters.AddWithValue("?importeCE", DG_tabla.Rows[i].Cells[16].Value);
                    insertar.Parameters.AddWithValue("?max_va", DG_tabla.Rows[i].Cells[17].Value);
                    insertar.Parameters.AddWithValue("?ex_va", DG_tabla.Rows[i].Cells[18].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_va", DG_tabla.Rows[i].Cells[19].Value);
                    insertar.Parameters.AddWithValue("?ped_va", DG_tabla.Rows[i].Cells[20].Value);
                    insertar.Parameters.AddWithValue("?importe_va", DG_tabla.Rows[i].Cells[21].Value);
                    insertar.Parameters.AddWithValue("?max_re", DG_tabla.Rows[i].Cells[22].Value);
                    insertar.Parameters.AddWithValue("?ex_re", DG_tabla.Rows[i].Cells[23].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_re", DG_tabla.Rows[i].Cells[24].Value);
                    insertar.Parameters.AddWithValue("?ped_re", DG_tabla.Rows[i].Cells[25].Value);
                    insertar.Parameters.AddWithValue("?importe_re", DG_tabla.Rows[i].Cells[26].Value);
                    insertar.Parameters.AddWithValue("?max_ve", DG_tabla.Rows[i].Cells[27].Value);
                    insertar.Parameters.AddWithValue("?ex_ve", DG_tabla.Rows[i].Cells[28].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_ve", DG_tabla.Rows[i].Cells[29].Value);
                    insertar.Parameters.AddWithValue("?ped_ve", DG_tabla.Rows[i].Cells[30].Value);
                    insertar.Parameters.AddWithValue("?importe_ve", DG_tabla.Rows[i].Cells[31].Value);
                    insertar.Parameters.AddWithValue("?max_co", DG_tabla.Rows[i].Cells[32].Value);
                    insertar.Parameters.AddWithValue("?ex_co", DG_tabla.Rows[i].Cells[33].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_co", DG_tabla.Rows[i].Cells[34].Value);
                    insertar.Parameters.AddWithValue("?ped_co", DG_tabla.Rows[i].Cells[35].Value);
                    insertar.Parameters.AddWithValue("?importe_co", DG_tabla.Rows[i].Cells[36].Value);
                    insertar.Parameters.AddWithValue("?oferta", 0);
                    insertar.ExecuteNonQuery();
                }

               


            }



            string query = "UPDATE rd_detalle_stock_compra SET modelo ='" + modelo + "', claveProducto='" + claveProducto + "', descripcion='" + descripcion + "',departamento='" + departamento + "'," +
              "pzxpedir=" + pzXPedir + ",cajasxpedir=" + cajasXPedir + ", cajaspedbo=" + cajaspedbo + ",pzxcaja=" + pzXCaja + ",pzxpaq=" + pzXPaq + ",costoxpaq=" + costoXPaq + ",costoxpz=" + costoXPz + ",ped_bo=" + ped_bo + "," +
              "importe_bo=" + importe_bo + ",max_ce=" + max_ce + ",ex_ce=" + exce + ",ped_ce=" + ped_ce + ",importeCE=" + importe_ce + ",max_va=" + maxva + ",ex_va=" + exva + ",ex_pasada_va=" + ex_pasada_va + ",ped_va=" + ped_va + "," +
              "importe_va=" + importe_va + ",max_re=" + maxre + ",ex_re=" + exre + ",ex_pasada_re=" + ex_pasada_re + ",ped_re=" + ped_re + ",importe_re=" + importe_re + ",max_ve=" + maxve + ",ex_ve=" + exve + ",ex_pasada_ve=" + ex_pasada_ve + "," +
              "ped_ve=" + ped_ve + ",importe_ve=" + importe_ve + ",max_co=" + maxco + ",ex_co=" + exco + ",ex_pasada_co=" + ex_pasada_co + ",ped_co=" + ped_co + ",importe_co=" + importe_co + "";

            double tbo = 0;
            double tce = 0;
            if (RB_cedis.Checked==true)
            {
                decimal valor = decimal.Parse(LB_totalbo.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalbo = valor.ToString("G0");
                tbo = Convert.ToDouble(totalbo);

                decimal valor2 = decimal.Parse(LB_totalce.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalce = valor2.ToString("G0");
                tce = Convert.ToDouble(totalce);
            }
           
          

            

            decimal valor3 = decimal.Parse(LB_totalva.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalva = valor3.ToString("G0");
            double tva = Convert.ToDouble(totalva);

            decimal valor4 = decimal.Parse(LB_totalre.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalre = valor4.ToString("G0");
            double tre = Convert.ToDouble(totalre);

            decimal valor5 = decimal.Parse(LB_totalve.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalve = valor5.ToString("G0");
            double tve = Convert.ToDouble(totalve);

            decimal valor6 = decimal.Parse(LB_totalco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string totalco = valor6.ToString("G0");
            double tco = Convert.ToDouble(totalco);

            string query2 = "UPDATE rd_stock_compra SET totalbo=" + tbo + ", totalce=" + tce + ",totalva=" + tva + "," +
                "totalre=" + tre + ", totalve=" + tve + ",totalco="+tco + " WHERE idreg="+Convert.ToInt32(TB_idstock.Text)+"";

           


          
            MySqlCommand cmd = null;
            int id = 0;
            try
            {
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    if (RB_cedis.Checked==true)
                    {
                        //TOMAR LOS VALORES EN LA TABLA 
                        modelo = Convert.ToString(DG_tabla.Rows[i].Cells["MODELO"].Value);
                        claveProducto = Convert.ToString(DG_tabla.Rows[i].Cells["CLAVE"].Value);
                        descripcion = Convert.ToString(DG_tabla.Rows[i].Cells["DESCRIPCION"].Value);
                        departamento = Convert.ToString(DG_tabla.Rows[i].Cells["DEPTO"].Value);
                        pzXPedir = Convert.ToInt32(DG_tabla.Rows[i].Cells["PIEZAS"].Value);
                        cajasXPedir = Convert.ToDouble(DG_tabla.Rows[i].Cells["CAJAS"].Value);
                        cajaspedbo = Convert.ToInt32(DG_tabla.Rows[i].Cells["CAJAS_BOD"].Value);
                        pzXCaja = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_CAJA"].Value);
                        pzXPaq = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_PAQ"].Value);
                        costoXPaq = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PAQUETE"].Value);
                        costoXPz = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PIEZA"].Value);
                        ped_bo = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_BOD"].Value);
                        importe_bo = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_BOD"].Value);
                        max_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_CE"].Value);
                        exce = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_CE"].Value);
                        ped_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells["PED_CE"].Value);
                        importe_ce = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_CE"].Value);
                        maxva = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_VA"].Value);
                        exva = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_VA"].Value);
                        ex_pasada_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["EX_PASADA_VA"].Value);
                        ped_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_VA"].Value);
                        importe_va = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value);
                        maxre = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_RE"].Value);
                        exre = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_RE"].Value);
                        ex_pasada_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["EX_PASADA_RE"].Value);
                        ped_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_RE"].Value);
                        importe_re = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value);
                        maxve = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_VE"].Value);
                        exve = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_VE"].Value);
                        ex_pasada_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["EX_PASADA_VE"].Value);
                        ped_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_VE"].Value);
                        importe_ve = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value);
                        maxco = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_CO"].Value);
                        exco = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_CO"].Value);
                        ex_pasada_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["EX_PASADA_CO"].Value);
                        ped_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_CO"].Value);
                        importe_co = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value);
                        id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value);
                    }
                    else
                    {
                        // si es un estock de tiendas
                        modelo = Convert.ToString(DG_tabla.Rows[i].Cells["MODELO"].Value);
                        claveProducto = Convert.ToString(DG_tabla.Rows[i].Cells["CLAVE"].Value);
                        descripcion = Convert.ToString(DG_tabla.Rows[i].Cells["DESCRIPCION"].Value);
                        departamento = Convert.ToString(DG_tabla.Rows[i].Cells["DEPTO"].Value);
                        //pzXPedir = Convert.ToInt32(DG_tabla.Rows[i].Cells["PIEZAS"].Value);
                        //cajasXPedir = Convert.ToDouble(DG_tabla.Rows[i].Cells["CAJAS"].Value);
                        //cajaspedbo = Convert.ToInt32(DG_tabla.Rows[i].Cells["CAJAS_BOD"].Value);
                        pzXCaja = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_CAJA"].Value);
                        pzXPaq = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_PAQ"].Value);
                        costoXPaq = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PAQUETE"].Value);
                        costoXPz = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PIEZA"].Value);
                        //ped_bo = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_BOD"].Value);
                        //importe_bo = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_BOD"].Value);
                        //max_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_CE"].Value);
                        //exce = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_CE"].Value);
                        //ped_ce = Convert.ToInt32(DG_tabla.Rows[i].Cells["PED_CE"].Value);
                        //importe_ce = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_CE"].Value);
                        maxva = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_VA"].Value);
                        exva = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_VA"].Value);
                        ex_pasada_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["EX_PASADA_VA"].Value);
                        ped_va = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_VA"].Value);
                        importe_va = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value);
                        maxre = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_RE"].Value);
                        exre = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_RE"].Value);
                        ex_pasada_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["EX_PASADA_RE"].Value);
                        ped_re = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_RE"].Value);
                        importe_re = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value);
                        maxve = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_VE"].Value);
                        exve = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_VE"].Value);
                        ex_pasada_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["EX_PASADA_VE"].Value);
                        ped_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_VE"].Value);
                        importe_ve = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value);
                        maxco = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_CO"].Value);
                        exco = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_CO"].Value);
                        ex_pasada_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["EX_PASADA_CO"].Value);
                        ped_co = Convert.ToInt32(DG_tabla.Rows[i].Cells["PEDIDO_CO"].Value);
                        importe_co = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value);
                        id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value);
                    }
                   

                    //OPERACIONES

                    //if (tipo.Equals("BODEGA"))
                    //{
                    //    pzXPedir = ped_bo;
                    //}
                    //else
                    //{
                    //    pzXPedir = ped_va + ped_re + ped_ve + ped_co;

                    //}


                    cajasXPedir = Convert.ToDouble(pzXPedir) / Convert.ToDouble(pzXCaja) / Convert.ToDouble(pzXPaq);
                    costoXPz = costoXPaq / pzXPaq;
                    ped_bo = cajaspedbo * pzXCaja;
                    ped_ce = ped_bo - ped_va - ped_re - ped_co - ped_co;
                    importe_bo = ped_bo * costoXPaq;
                    importe_ce = ped_ce * costoXPaq;
                    importe_va = ped_va * costoXPaq;
                    importe_re = ped_re * costoXPaq;
                    importe_ve = ped_ve * costoXPaq;
                    importe_co = ped_co * costoXPaq;

                    //Quitar el formato de moneda
                    //decimal costoPaq = decimal.Parse(costoXPaq.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //string cxpaq = costoPaq.ToString("G0");
                    //double costo_paq = Convert.ToDouble(cxpaq);

                    //decimal costoPieza = decimal.Parse(costoXPz.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //string cxpz = costoPieza.ToString("G0");
                    //double costo_pz = Convert.ToDouble(cxpz);

                    //decimal imp_bod = decimal.Parse(importe_bo.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //string impBO = imp_bod.ToString("G0");
                    //double importe_bod = Convert.ToDouble(impBO);

                    //decimal imp_ce = decimal.Parse(importe_ce.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //string impCE = imp_ce.ToString("G0");
                    //double impor_ce = Convert.ToDouble(impCE);

                    //decimal imp_va = decimal.Parse(importe_va.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //string impVA = imp_va.ToString("G0");
                    //double impor_va = Convert.ToDouble(impVA);


                    //  GUARDA LOS TOTALES EN LA TABLA rd_stock_compra
                    MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
                    cmd2.ExecuteNonQuery();
                    //******************************************************



                    if (RB_cedis.Checked==true)
                    {
                        cmd = new MySqlCommand("UPDATE rd_detalle_stock_compra SET modelo ='" + modelo + "', claveProducto='" + claveProducto + "', descripcion='" + descripcion + "',departamento='" + departamento + "'," +
                         "pzxpedir=" + pzXPedir + ",cajasxpedir=" + cajasXPedir + ", cajaspedbo=" + cajaspedbo + ",pzxcaja=" + pzXCaja + ",pzxpaq=" + pzXPaq + ",costoxpaq=" + costoXPaq + ",costoxpz=" + costoXPz + ",ped_bo=" + ped_bo + "," +
                        "importe_bo=" + importe_bo + ",max_ce=" + max_ce + ",ex_ce=" + exce + ",ped_ce=" + ped_ce + ",importeCE=" + importe_ce + ",max_va=" + maxva + ",ex_va=" + exva + ",ex_pasada_va=" + ex_pasada_va + ",ped_va=" + ped_va + "," +
                         "importe_va=" + importe_va + ",max_re=" + maxre + ",ex_re=" + exre + ",ex_pasada_re=" + ex_pasada_re + ",ped_re=" + ped_re + ",importe_re=" + importe_re + ",max_ve=" + maxve + ",ex_ve=" + exve + ",ex_pasada_ve=" + ex_pasada_ve + "," +
                             "ped_ve=" + ped_ve + ",importe_ve=" + importe_ve + ",max_co=" + maxco + ",ex_co=" + exco + ",ex_pasada_co=" + ex_pasada_co + ",ped_co=" + ped_co + ",importe_co=" + importe_co + " where fk_stock='" + TB_idstock.Text + "' and idreg=" + id + "", conexion);
                        cmd.ExecuteNonQuery();

                    }
                    else if(RB_tiendas.Checked==true)
                    {
                        cmd = new MySqlCommand("UPDATE rd_detalle_stock_compra SET modelo ='" + modelo + "', claveProducto='" + claveProducto + "', descripcion='" + descripcion + "',departamento='" + departamento + "'," +
                         "pzxcaja=" + pzXCaja + ",pzxpaq=" + pzXPaq + ",costoxpaq=" + costoXPaq + ",costoxpz=" + costoXPz + "," +
                        "max_va=" + maxva + ",ex_va=" + exva + ",ex_pasada_va=" + ex_pasada_va + ",ped_va=" + ped_va + "," +
                         "importe_va=" + importe_va + ",max_re=" + maxre + ",ex_re=" + exre + ",ex_pasada_re=" + ex_pasada_re + ",ped_re=" + ped_re + ",importe_re=" + importe_re + ",max_ve=" + maxve + ",ex_ve=" + exve + ",ex_pasada_ve=" + ex_pasada_ve + "," +
                             "ped_ve=" + ped_ve + ",importe_ve=" + importe_ve + ",max_co=" + maxco + ",ex_co=" + exco + ",ex_pasada_co=" + ex_pasada_co + ",ped_co=" + ped_co + ",importe_co=" + importe_co + " where fk_stock='" + TB_idstock.Text + "' and idreg=" + id + "", conexion);
                        cmd.ExecuteNonQuery();
                    }

                
                }




                Buscar();
                MessageBox.Show("Stock Actualizado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el stock " + ex);
            }
        }

       

        public void Calcular()
        {
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                costo_unitario = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTOU"].Value);

                try
                {

                  

                    if (RB_cedis.Checked == true)
                    {
                       
                        pedidoXCaja = Convert.ToInt32(DG_tabla.Rows[i].Cells["CAJAS_BOD"].Value);
                        pzXCaja = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_CAJA"].Value);
                        pzXPaq = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_PAQ"].Value);


                        //costoXPaq = pzXPaq * costo_unitario;


                        costoXPaq = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PAQUETE"].Value);



                        //costo piezas por paquete
                        //DG_tabla.Rows[i].Cells[10].Value = costo_unitario * pzXPaq;
                        DG_tabla.Rows[i].Cells[10].Value = costoXPaq / pzXPaq;

                        //Costo por pieza
                        costoXPz = costoXPaq / pzXPaq;
                        DG_tabla.Rows[i].Cells[11].Value = costoXPz;


                        //pedido bodega
                        ped_bo = pedidoXCaja * pzXCaja;
                        DG_tabla.Rows[i].Cells[12].Value = ped_bo;


                        //importe d ebodega
                        imp_bo = ped_bo * costoXPaq;
                        DG_tabla.Rows[i].Cells[13].Value = imp_bo;

                        //-----------CALCULAR EL PEDIDO DE CADA TIENDA----------------------------------------

                        //VALLARTA
                        exva = Convert.ToInt32(DG_tabla.Rows[i].Cells[18].Value);
                        maxva = Convert.ToInt32(DG_tabla.Rows[i].Cells[17].Value);

                        if (maxva == 0)
                        {
                            DG_tabla.Rows[i].Cells[20].Value = 0;
                        }
                        else
                        {
                            if (exva > (maxva / 2))
                            {
                                DG_tabla.Rows[i].Cells[20].Value = 0;
                            }

                            if (exva <= (maxva / 2))
                            {
                                DG_tabla.Rows[i].Cells[20].Value = maxva;
                            }

                            if (exva == 0)
                            {
                                DG_tabla.Rows[i].Cells[20].Value = maxva;
                            }


                        }

                        //RENA
                        exre = Convert.ToInt32(DG_tabla.Rows[i].Cells[23].Value);
                        maxre = Convert.ToInt32(DG_tabla.Rows[i].Cells[22].Value);

                        if (maxre == 0)
                        {
                            DG_tabla.Rows[i].Cells[23].Value = 0;
                        }
                        else
                        {
                            if (exre > (maxre / 2))
                            {
                                DG_tabla.Rows[i].Cells[25].Value = 0;
                            }

                            if (exre <= (maxre / 2))
                            {
                                DG_tabla.Rows[i].Cells[25].Value = maxre;
                            }

                            if (exre == 0)
                            {
                                DG_tabla.Rows[i].Cells[25].Value = maxre;
                            }


                        }


                        //VELAZQUEZ
                        exve = Convert.ToInt32(DG_tabla.Rows[i].Cells[28].Value);
                        maxve = Convert.ToInt32(DG_tabla.Rows[i].Cells[27].Value);

                        if (maxve == 0)
                        {
                            DG_tabla.Rows[i].Cells[30].Value = 0;
                        }
                        else
                        {
                            if (exve > (maxve / 2))
                            {
                                DG_tabla.Rows[i].Cells[30].Value = 0;
                            }

                            if (exve <= (maxve / 2))
                            {
                                DG_tabla.Rows[i].Cells[30].Value = maxve;
                            }

                            if (exve == 0)
                            {
                                DG_tabla.Rows[i].Cells[30].Value = maxve;
                            }

                        }

                        //COLOSO
                        exco = Convert.ToInt32(DG_tabla.Rows[i].Cells[33].Value);
                        maxco = Convert.ToInt32(DG_tabla.Rows[i].Cells[32].Value);

                        if (maxco == 0)
                        {
                            DG_tabla.Rows[i].Cells[35].Value = 0;
                        }
                        else
                        {
                            if (exco > (maxco / 2))
                            {
                                DG_tabla.Rows[i].Cells[35].Value = 0;
                            }

                            if (exco <= (maxco / 2))
                            {
                                DG_tabla.Rows[i].Cells[35].Value = maxco;
                            }

                            if (exco == 0)
                            {
                                DG_tabla.Rows[i].Cells[35].Value = maxco;
                            }


                        }



                        //------------------------------------------------------------------------------------



                        //------PIEZAS POR PEDIR--------------------------------------------------------------
                        ped_bo=Convert.ToInt32(DG_tabla.Rows[i].Cells[11].Value);
                        ped_va = Convert.ToInt32(DG_tabla.Rows[i].Cells[20].Value);
                        ped_re = Convert.ToInt32(DG_tabla.Rows[i].Cells[25].Value);
                        ped_ve = Convert.ToInt32(DG_tabla.Rows[i].Cells[30].Value);
                        ped_co = Convert.ToInt32(DG_tabla.Rows[i].Cells[35].Value);
                        ped_bo = Convert.ToInt32(DG_tabla.Rows[i].Cells[11].Value);


                        //pzXPedir = ped_bo;

                        pzXPedir = ped_va + ped_re + ped_ve + ped_co;


                        DG_tabla.Rows[i].Cells[4].Value = pzXPedir;
                        //DG_tabla.Rows[i].Cells[6].Value = pzXPedir / pzXCaja;
                        DG_tabla.Rows[i].Cells[11].Value = Convert.ToInt32(DG_tabla.Rows[i].Cells[6].Value) * Convert.ToInt32(DG_tabla.Rows[i].Cells[7].Value);
                        DG_tabla.Rows[i].Cells[12].Value = Convert.ToDouble(DG_tabla.Rows[i].Cells[11].Value) * Convert.ToDouble(DG_tabla.Rows[i].Cells[9].Value);
                        DG_tabla.Rows[i].Cells[15].Value = Convert.ToInt32(DG_tabla.Rows[i].Cells[11].Value) - Convert.ToInt32(DG_tabla.Rows[i].Cells[4].Value);
                        //-------------------------------------------------------------------------------------
                        //------------- CAJAS POR PEDIR -------------------------------------------------------
                        pzXCaja = Convert.ToInt32(DG_tabla.Rows[i].Cells[7].Value);
                        pzXPaq = Convert.ToInt32(DG_tabla.Rows[i].Cells[8].Value);
                        cajasXPedir = pzXPedir / pzXCaja / pzXPaq;
                        DG_tabla.Rows[i].Cells[5].Value = cajasXPedir;
                        //-------------------------------------------------------------------------------------

                        //ped_ce = ped_bo - (ped_va + ped_re + ped_ve + ped_co);

                        //---------------------- IMPORTE CEDIS ------------------------------------------------

                        DG_tabla.Rows[i].Cells[16].Value = Convert.ToDouble(DG_tabla.Rows[i].Cells[15].Value) * Convert.ToDouble(DG_tabla.Rows[i].Cells[9].Value);
                        //-------------------------------------------------------------------------------------



                        //--------------IMPORTES DE ACUERDO AL PEDIDO ------------------------------------------
                        DG_tabla.Rows[i].Cells[21].Value = (ped_va * costoXPaq);//IMPORTE VALLARTA
                        DG_tabla.Rows[i].Cells[26].Value = (ped_re * costoXPaq);//IMPORTE RENA
                        DG_tabla.Rows[i].Cells[31].Value = (ped_ve * costoXPaq);//IMPORTE VELAZQUEZ
                        DG_tabla.Rows[i].Cells[36].Value = (ped_co * costoXPaq);//IMPORTE COLOSO

                        //--------------------------------------------------------------------------------------

                        totalbo += Convert.ToDouble(DG_tabla.Rows[i].Cells[12].Value);
                        totalce += Convert.ToDouble(DG_tabla.Rows[i].Cells[16].Value);
                        totalva += Convert.ToDouble(DG_tabla.Rows[i].Cells[21].Value);
                        totalre += Convert.ToDouble(DG_tabla.Rows[i].Cells[26].Value);
                        totalve += Convert.ToDouble(DG_tabla.Rows[i].Cells[31].Value);
                        totalco += Convert.ToDouble(DG_tabla.Rows[i].Cells[36].Value);

                        total = totalce + totalva + totalre + totalve + totalco;

                        LB_totalbo.Text = totalbo.ToString("C2");
                        LB_totalce.Text = totalce.ToString("C2");
                        LB_totalva.Text = totalva.ToString("C2");
                        LB_totalre.Text = totalre.ToString("C2");
                        LB_totalve.Text = totalve.ToString("C2");
                        LB_totalco.Text = totalco.ToString("C2");
                        LB_total.Text = total.ToString("C2");
                    }
                    if (RB_tiendas.Checked==true)
                    {

                       

                        //pzXPedir = ped_va + ped_re + ped_ve + ped_co;
                        pzXCaja = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_CAJA"].Value);
                        pzXPaq = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_PAQ"].Value);

                       costoXPaq = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PAQUETE"].Value);
                        //costoXPaq = pzXPaq * costo_unitario; //calculando el costo por paquete
                       // DG_tabla.Rows[i].Cells["COSTO_PAQUETE"].Value = costoXPaq;

                        //calculando costo por pieza
                        costoXPz = costoXPaq / pzXPaq;
                        DG_tabla.Rows[i].Cells["COSTO_PIEZA"].Value = costoXPz;

                        exva = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_VA"].Value);
                        maxva = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_VA"].Value);

                        exre = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_RE"].Value);
                        maxre = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_RE"].Value);

                        exve = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_VE"].Value);
                        maxve = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_VE"].Value);

                        exco = Convert.ToInt32(DG_tabla.Rows[i].Cells["EXT_CO"].Value);
                        maxco = Convert.ToInt32(DG_tabla.Rows[i].Cells["MAX_CO"].Value);


                        //si es menor al 10% se pide el 150%
                        if (exva <= (maxva*10)/100)
                        {
                            ped_va = maxva + maxva / 2;
                        }
                        else if (exva < (maxva / 2) && exva > (maxva * 10) / 100)//si es menos al 50% pero mayor que el 10%
                        {
                            ped_va = maxva;
                        }
                        else //si es mayor o igual al 50%
                        {
                            ped_va = 0;
                        }

                        //si es menor al 10% se pide el 150%
                        if (exre <= (maxre * 10) / 100)
                        {
                            ped_re = maxre + maxre / 2;
                        }
                        else if (exre < (maxre / 2) && exre > (maxre * 10) / 100)//si es menos al 50% pero mayor que el 10%
                        {
                            ped_re = maxre;
                        }
                        else //si es mayor o igual al 50%
                        {
                            ped_re = 0;
                        }

                        //si es menor al 10% se pide el 150%
                        if (exve <= (maxve * 10) / 100)
                        {
                            ped_ve = maxve + maxve / 2;
                        }
                        else if (exve < (maxve / 2) && exve > (maxve * 10) / 100)//si es menos al 50% pero mayor que el 10%
                        {
                            ped_ve = maxve;
                        }
                        else //si es mayor o igual al 50%
                        {
                            ped_ve = 0;
                        }

                        //si es menor al 10% se pide el 150%
                        if (exco <= (maxco * 10) / 100)
                        {
                            ped_co = maxco + maxco / 2;
                        }
                        else if (exco < (maxco / 2) && exco > (maxco * 10) / 100)//si es menos al 50% pero mayor que el 10%
                        {
                            ped_co = maxco;
                        }
                        else //si es mayor o igual al 50%
                        {
                            ped_co = 0;
                        }



                        //pedido va
                        DG_tabla.Rows[i].Cells["PEDIDO_VA"].Value = ped_va;

                        //pedido rena
                        DG_tabla.Rows[i].Cells["PEDIDO_RE"].Value = ped_re;

                        //pedido velazquez
                        DG_tabla.Rows[i].Cells["PEDIDO_VE"].Value = ped_ve;

                        //pedido coloso
                        DG_tabla.Rows[i].Cells["PEDIDO_CO"].Value = ped_co;

                        //importe vallarta
                        DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value = ped_va*costoXPaq;

                        //importe rena
                        DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value = ped_re * costoXPaq;

                        //importe velazquez
                        DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value = ped_ve * costoXPaq;

                        //importe coloso
                        DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value = ped_co * costoXPaq;



                        //totalbo += Convert.ToDouble(DG_tabla.Rows[i].Cells[12].Value);
                        //totalce += Convert.ToDouble(DG_tabla.Rows[i].Cells[16].Value);
                        totalva += Convert.ToDouble(DG_tabla.Rows[i].Cells[21].Value);
                        totalre += Convert.ToDouble(DG_tabla.Rows[i].Cells[26].Value);
                        totalve += Convert.ToDouble(DG_tabla.Rows[i].Cells[31].Value);
                        totalco += Convert.ToDouble(DG_tabla.Rows[i].Cells[36].Value);

                        LB_totalbo.Text = 0.ToString("C2");
                        LB_totalce.Text = 0.ToString("C2");
                        LB_totalva.Text = totalva.ToString("C2");
                        LB_totalre.Text = totalre.ToString("C2");
                        LB_totalve.Text = totalve.ToString("C2");
                        LB_totalco.Text = totalco.ToString("C2");
                        total = totalva + totalre + totalve + totalco;
                        LB_total.Text = total.ToString("C2");
                    }




                   






                    //DG_tabla.Rows[i].Cells[4].Value = pzXPedir;
                    ////DG_tabla.Rows[i].Cells[6].Value = pzXPedir / pzXCaja;
                    //DG_tabla.Rows[i].Cells[11].Value = Convert.ToInt32(DG_tabla.Rows[i].Cells[6].Value) * Convert.ToInt32(DG_tabla.Rows[i].Cells[7].Value);
                    //DG_tabla.Rows[i].Cells[12].Value = Convert.ToDouble(DG_tabla.Rows[i].Cells[11].Value) * Convert.ToDouble(DG_tabla.Rows[i].Cells[9].Value);
                    //DG_tabla.Rows[i].Cells[15].Value = Convert.ToInt32(DG_tabla.Rows[i].Cells[11].Value) - Convert.ToInt32(DG_tabla.Rows[i].Cells[4].Value);
                    ////-------------------------------------------------------------------------------------
                    ////------------- CAJAS POR PEDIR -------------------------------------------------------
                    //pzXCaja = Convert.ToInt32(DG_tabla.Rows[i].Cells[7].Value);
                    //pzXPaq = Convert.ToInt32(DG_tabla.Rows[i].Cells[8].Value);
                    //cajasXPedir = pzXPedir / pzXCaja / pzXPaq;
                    //DG_tabla.Rows[i].Cells[5].Value = cajasXPedir;
                    ////-------------------------------------------------------------------------------------


                    ////---------------------- IMPORTE CEDIS ------------------------------------------------

                    //DG_tabla.Rows[i].Cells[16].Value = Convert.ToDouble(DG_tabla.Rows[i].Cells[15].Value) * Convert.ToDouble(DG_tabla.Rows[i].Cells[9].Value);
                    ////-------------------------------------------------------------------------------------



                    ////--------------IMPORTES DE ACUERDO AL PEDIDO ------------------------------------------
                    //DG_tabla.Rows[i].Cells[21].Value = (ped_va * costoXPaq);//IMPORTE VALLARTA
                    //DG_tabla.Rows[i].Cells[26].Value = (ped_re * costoXPaq);//IMPORTE RENA
                    //DG_tabla.Rows[i].Cells[31].Value = (ped_ve * costoXPaq);//IMPORTE VELAZQUEZ
                    //DG_tabla.Rows[i].Cells[36].Value = (ped_co * costoXPaq);//IMPORTE COLOSO

                    ////--------------------------------------------------------------------------------------

                    //totalbo += Convert.ToDouble(DG_tabla.Rows[i].Cells[12].Value);
                    //totalce += Convert.ToDouble(DG_tabla.Rows[i].Cells[16].Value);
                    //totalva += Convert.ToDouble(DG_tabla.Rows[i].Cells[21].Value);
                    //totalre += Convert.ToDouble(DG_tabla.Rows[i].Cells[26].Value);
                    //totalve += Convert.ToDouble(DG_tabla.Rows[i].Cells[31].Value);
                    //totalco += Convert.ToDouble(DG_tabla.Rows[i].Cells[36].Value);

                    //LB_totalbo.Text = totalbo.ToString("C2");
                    //LB_totalce.Text = totalce.ToString("C2");
                    //LB_totalva.Text = totalva.ToString("C2");
                    //LB_totalre.Text = totalre.ToString("C2");
                    //LB_totalve.Text = totalve.ToString("C2");
                    //LB_totalco.Text = totalco.ToString("C2");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Excepcion controlada: " + ex);
                }



               


                pedidoXCaja = 0; pzXCaja = 0; pzXPaq = 0; pzXPedir = 0; ped_va = 0; ped_re = 0; ped_ve = 0; ped_co = 0;
                costoXPaq = 0; cajasXPedir = 0; costoXPz = 0;
                ped_bo = 0; imp_bo = 0;

                exva = 0; maxva = 0; exre = 0; maxre = 0; exco = 0; maxco = 0; exve = 0; maxve = 0;


                //totalbo = 0; totalce = 0; totalva = 0; totalre = 0; totalve = 0; totalco = 0;

            }//for

            totalbo = 0; totalce = 0; totalva = 0; totalre = 0; totalve = 0; totalco = 0;total = 0;
            DG_tabla.Columns[9].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[10].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[12].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[16].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[21].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[26].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[31].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[36].DefaultCellStyle.Format = "C2";
        }

        public int Existencia(string articulo,string sucursal)
        {
            int existencia = 0;
            MySqlConnection conexion = null;
            string query = "select existencia from prods where articulo='"+articulo+"'";
            if (sucursal.Equals("BODEGA"))
            {
                conexion = BDConexicon.ConexionSucursal(sucursal);
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    existencia = Convert.ToInt32(dr["existencia"].ToString());
                }
                dr.Close();
            }
            if (sucursal.Equals("VALLARTA"))
            {
                conexion = BDConexicon.ConexionSucursal(sucursal);
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    existencia = Convert.ToInt32(dr["existencia"].ToString());
                }
                dr.Close();
            }
            if (sucursal.Equals("RENA"))
            {
                conexion = BDConexicon.ConexionSucursal(sucursal);
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    existencia = Convert.ToInt32(dr["existencia"].ToString());
                }
                dr.Close();
            }
            if (sucursal.Equals("VELAZQUEZ"))
            {
                conexion = BDConexicon.ConexionSucursal(sucursal);
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    existencia = Convert.ToInt32(dr["existencia"].ToString());
                }
                dr.Close();
            }
            if (sucursal.Equals("COLOSO"))
            {
                conexion = BDConexicon.ConexionSucursal(sucursal);
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    existencia = Convert.ToInt32(dr["existencia"].ToString());
                }
                dr.Close();
            }

            conexion.Close();
            return existencia;
        }
      
        public bool BuscarArticuloDG(string clave)
        {
            bool respuesta = false;
            string claveDG = "";

            for (int i = 0; i < DG_tabla.RowCount - 1; i++)

            {
                claveDG = DG_tabla.Rows[i].Cells[1].Value.ToString();

                if (claveDG.Equals(clave))
                {
                    MessageBox.Show("El Artículo " + clave + " ya se agregó al Stock, por lo tanto ya no se puede agregar de nuevo.");
                    respuesta = true;
                }
                break;
            }


            return respuesta;
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void EliminarArticuloSeleccionado()
        {
            string id =Convert.ToString(DG_tabla.CurrentRow.Cells["ID"].Value);
            string query = "DELETE FROM rd_detalle_stock_compra where idreg='"+id+"'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();

            DG_tabla.Rows.Remove(DG_tabla.CurrentRow);
            Calcular();
        }

       

        public int MaximoArticuloCE(string articulo)

        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select maximo from rd_maximos_bo where articulo='"+articulo+"'";
            int maximo = 0;

            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                maximo = Convert.ToInt32(dr["maximo"].ToString());
            }
            else
            {
                maximo = 0;
            }
            dr.Close();
            conexion.Close();
            return maximo;
        }
  
        public int MaximoArticuloVA(string articulo)

        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select maximo from rd_maximos_va where articulo='"+articulo+"'";
            int maximo = 0;

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                maximo = Convert.ToInt32(dr["maximo"].ToString());
            }
            else
            {
                maximo = 0;
            }
            dr.Close();
            conexion.Close();
            return maximo;
        }

        public int MaximoArticuloRE(string articulo)

        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select maximo from rd_maximos_re where articulo='"+articulo+"'";
            int maximo = 0;

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                maximo = Convert.ToInt32(dr["maximo"].ToString());
            }
            else
            {
                maximo = 0;
            }
            dr.Close();
            conexion.Close();
            return maximo;
        }

        private void RB_tiendas_CheckedChanged(object sender, EventArgs e)
        {
            DG_tabla.Columns["PIEZAS"].Visible = false;
            DG_tabla.Columns["CAJAS"].Visible = false;
            DG_tabla.Columns["CAJAS_BOD"].Visible = false;
            DG_tabla.Columns["PEDIDO_BOD"].Visible = false;
            DG_tabla.Columns["IMPORTE_BOD"].Visible = false;
            DG_tabla.Columns["MAX_CE"].Visible = false; 
            DG_tabla.Columns["EXT_CE"].Visible = false;
            DG_tabla.Columns["PED_CE"].Visible = false;
            DG_tabla.Columns["IMPORTE_CE"].Visible = false;
            LB_totalbo.Text = "";
            LB_totalce.Text = "";
            total = totalva + totalre + totalve + totalco;
            LB_total.Text = total.ToString("C2");
        }

        private void RB_cedis_CheckedChanged(object sender, EventArgs e)
        {
            DG_tabla.Columns["PIEZAS"].Visible = true;
            DG_tabla.Columns["CAJAS"].Visible = true;
            DG_tabla.Columns["CAJAS_BOD"].Visible = true;
            DG_tabla.Columns["PEDIDO_BOD"].Visible = true;
            DG_tabla.Columns["IMPORTE_BOD"].Visible = true;
            DG_tabla.Columns["MAX_CE"].Visible = true;
            DG_tabla.Columns["EXT_CE"].Visible = true;
            DG_tabla.Columns["PED_CE"].Visible = true;
            DG_tabla.Columns["IMPORTE_CE"].Visible = true;
        }

        private void TB_articulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_calculo_manual_Click(object sender, EventArgs e)
        {
            int pedidoVa = 0,pedidoRe=0,pedidoVe=0,pedidoCo=0,pedidoCe=0, pzXPaq=0;
            double costoXPaq = 0;

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {


               

                costoXPaq = Convert.ToDouble(DG_tabla.Rows[i].Cells[9].Value);
                pzXPaq = Convert.ToInt32(DG_tabla.Rows[i].Cells["PZ_PAQ"].Value);
               
             
                costoXPz = costoXPaq / pzXPaq;
                DG_tabla.Rows[i].Cells["COSTO_PIEZA"].Value = costoXPz;

                pedidoVa = Convert.ToInt32(DG_tabla.Rows[i].Cells[20].Value);
                pedidoRe = Convert.ToInt32(DG_tabla.Rows[i].Cells[25].Value);
                pedidoVe = Convert.ToInt32(DG_tabla.Rows[i].Cells[30].Value);
                pedidoCo = Convert.ToInt32(DG_tabla.Rows[i].Cells[35].Value);

                DG_tabla.Rows[i].Cells[16].Value = costoXPaq * pedidoCe;
                DG_tabla.Rows[i].Cells[21].Value = costoXPaq * pedidoVa;
                DG_tabla.Rows[i].Cells[26].Value = costoXPaq * pedidoRe;
                DG_tabla.Rows[i].Cells[31].Value = costoXPaq * pedidoVe;
                DG_tabla.Rows[i].Cells[36].Value = costoXPaq * pedidoCo;



                if (RB_cedis.Checked==true)
                {
                    pedidoCe = Convert.ToInt32(DG_tabla.Rows[i].Cells[15].Value);
                    DG_tabla.Rows[i].Cells[16].Value = costoXPaq * pedidoCe;
                    totalce += Convert.ToDouble(DG_tabla.Rows[i].Cells[16].Value);
                }
                else
                {
                    totalce = 0;
                }
                
                totalva += Convert.ToDouble(DG_tabla.Rows[i].Cells[21].Value);
                totalre += Convert.ToDouble(DG_tabla.Rows[i].Cells[26].Value);
                totalve += Convert.ToDouble(DG_tabla.Rows[i].Cells[31].Value);
                totalco += Convert.ToDouble(DG_tabla.Rows[i].Cells[36].Value);


                total = totalce + totalva + totalre + totalve + totalco;
                LB_totalce.Text = totalce.ToString("C2");
                LB_totalva.Text = totalva.ToString("C2");
                LB_totalre.Text = totalre.ToString("C2");
                LB_totalve.Text = totalve.ToString("C2");
                LB_totalco.Text = totalco.ToString("C2");
                LB_total.Text = total.ToString("C2");
            }

            pedidoXCaja = 0; pzXCaja = 0; pzXPaq = 0; pzXPedir = 0; ped_va = 0; ped_re = 0; ped_ve = 0; ped_co = 0;
            costoXPaq = 0; cajasXPedir = 0; costoXPz = 0;
            ped_bo = 0; imp_bo = 0;
            totalva = 0;totalre = 0;totalco = 0;totalve = 0;total = 0;
            exva = 0; maxva = 0; exre = 0; maxre = 0; exco = 0; maxco = 0; exve = 0; maxve = 0;

        }

        public int MaximoArticuloVE(string articulo)

        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select maximo from rd_maximos_ve where articulo='"+articulo+"'";
            int maximo = 0;

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                maximo = Convert.ToInt32(dr["maximo"].ToString());
            }
            else
            {
                maximo = 0;
            }
            dr.Close();
            conexion.Close();
            return maximo;
        }

        public int MaximoArticuloCO(string articulo)

        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select maximo from rd_maximos_co where articulo='"+articulo+"'";
            int maximo = 0;

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                maximo = Convert.ToInt32(dr["maximo"].ToString());
            }
            else
            {
                maximo = 0;
            }
            dr.Close();
            conexion.Close();
            return maximo;
        }

        int existenciaBO = 0, existenciaVA = 0, existenciaRE = 0, existenciaVE = 0, existenciaCO = 0;
        int maxBo = 0, maxVa = 0, maxRe = 0, maxVe = 0, maxCo = 0,pzCaja=0;
        double costo = 0;

        public void InsertarArticuloDG()
        {

            bool repetido = BuscarArticuloDG(TB_articulo.Text);
            
            if (repetido == false)
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT articulo,descrip,linea FROM prods WHERE articulo='" + TB_articulo.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                Productos prod = new Productos();
                while (dr.Read())
                {
                    pzCaja = PiezasXCajaCE(TB_articulo.Text);
                    costo = CostoArticulo(TB_articulo.Text);


                    existenciaBO = prod.ExistenciaXTienda(TB_articulo.Text,"BODEGA");
                    existenciaVA = prod.ExistenciaXTienda(TB_articulo.Text, "VALLARTA");
                    existenciaRE = prod.ExistenciaXTienda(TB_articulo.Text, "RENA");
                    existenciaVE = prod.ExistenciaXTienda(TB_articulo.Text, "VELAZQUEZ");
                    existenciaCO = prod.ExistenciaXTienda(TB_articulo.Text, "COLOSO");

                    maxBo = MaximoArticuloCE(TB_articulo.Text);
                    maxVa = MaximoArticuloVA(TB_articulo.Text);
                    maxRe = MaximoArticuloRE(TB_articulo.Text);
                    maxVe = MaximoArticuloVE(TB_articulo.Text);
                    maxCo = MaximoArticuloCO(TB_articulo.Text);
                    DG_tabla.Rows.Add("", dr["articulo"].ToString(), dr["descrip"].ToString(), dr["linea"].ToString(), "0", "0", "0", pzCaja, 1,"0", costo, "0", "0", maxBo, existenciaBO, "0", "0", maxVa, existenciaVA, "0", "0", "0", maxRe, existenciaRE, "0", "0", "0", maxVe, existenciaVE, "0","0", "0", maxCo, existenciaCO, "0","0","0","0",costo);
                }
                dr.Close();
                conexion.Close();
                TB_articulo.Text = "";
            }
        }

        private void StockOrdenCompra_Load(object sender, EventArgs e)
        {
            RB_cedis.Checked = true;
            DG_tabla.Columns.Add("ID","ID");
            DG_tabla.Columns.Add("COSTOU", "COSTO UNITARIO");
            DG_tabla.Columns["ID"].Visible = true;
            DG_tabla.Columns["COSTOU"].Visible = true;
            //LLENA EL DATAGRID DE PROVEEDORES CON EL NOMBRE DE LOS PROVEEDORES
            Proveedor proveedores = new Proveedor();
            ArrayList lista = proveedores.Proveedores();

            for (int i = 0; i < lista.Count; i++)
            {
                CB_proveedor.Items.Add(lista[i].ToString());
            }


            //llenar el datagrid de los proveedores que ya tienen un stock
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "Select distinct proveedor From rd_stock_compra";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            Proveedor nombre = new Proveedor();
            while (dr.Read())
            {
                CB_proveedorStock.Items.Add(nombre.NombreProveedor(dr["proveedor"].ToString()));
            }
            dr.Close();
            conexion.Close();

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






            //INMOVILIZAR COLUMNAS
            DG_tabla.Columns["MODELO"].Frozen = true;
            DG_tabla.Columns["CLAVE"].Frozen = true;
            DG_tabla.Columns["DESCRIPCION"].Frozen = true;
           

            //TAMAÑO DE CELDAS
            DG_tabla.Columns["MODELO"].Width = 110;
            DG_tabla.Columns["CLAVE"].Width = 140;
            DG_tabla.Columns["DESCRIPCION"].Width = 300;
            DG_tabla.Columns["DEPTO"].Width = 120;
            DG_tabla.Columns["PIEZAS"].Width = 50;
            DG_tabla.Columns["CAJAS"].Width = 50;
            DG_tabla.Columns["PEDIDO_BOD"].Width = 50;
            DG_tabla.Columns["MAX_CE"].Width = 50;
            DG_tabla.Columns["EXT_CE"].Width = 50;
            DG_tabla.Columns["PED_CE"].Width = 50;
            DG_tabla.Columns["MAX_VA"].Width = 50;
            DG_tabla.Columns["EXT_VA"].Width = 50;
            DG_tabla.Columns["PEDIDO_VA"].Width = 50;
            DG_tabla.Columns["MAX_RE"].Width = 50;
            DG_tabla.Columns["EXT_RE"].Width = 50;
            DG_tabla.Columns["PEDIDO_RE"].Width = 50;
            DG_tabla.Columns["MAX_VE"].Width = 50;
            DG_tabla.Columns["EXT_VE"].Width = 50;
            DG_tabla.Columns["PEDIDO_VE"].Width = 50;
            DG_tabla.Columns["MAX_CO"].Width = 50;
            DG_tabla.Columns["EXT_CO"].Width = 50;
            DG_tabla.Columns["PEDIDO_CO"].Width = 50;


            DG_tabla.Columns["CAJAS_BOD"].DefaultCellStyle.BackColor = Color.Cyan;


           DG_tabla.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[13].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[14].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[15].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[16].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[17].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[18].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[19].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[20].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[21].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[22].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[23].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[24].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[25].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[26].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[27].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[28].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[29].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[30].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[31].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[32].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[33].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[34].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[35].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[36].SortMode = DataGridViewColumnSortMode.NotSortable;
            


        }
        #endregion


        #region BOTONES

        //AGREGA ARTICULOS AL DATAGRID SIN CLAVE
        private void BT_articuloSinClave_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Add("", "", TB_articuloSinClave.Text.ToUpper(), "", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");
            TB_articuloSinClave.Text = "";
        }
        //ELIMINAR ARTICULO DEL STOCK
        private void button6_Click(object sender, EventArgs e)
        {
            EliminarArticuloSeleccionado();
        }

        //LIMPIA LOS ELEMENTOS DE LA VENTATA INCLUYENDO EL DATAGRID
        private void button4_Click(object sender, EventArgs e)
        {
            CB_proveedor.SelectedIndex = -1;
            TB_idProv.Text = "";
            TB_descripcion.Text = "";
            TB_columna.Text = "";
            CBX_cedis.Checked = false;
            TB_articuloSinClave.Text = "";

            TB_idstock.Text = "";
            CB_proveedorStock.SelectedIndex = -1;
            TB_id_prov.Text = "";
            CB_stocks.SelectedIndex = -1;

            TB_consecutivo.Text = "";
            TB_folio.Text = "";
            TB_descuento.Text = "";

           RB_cedis.Checked = true;
            RB_tiendas.Checked = false;

            DG_tabla.Rows.Clear();

            LB_totalbo.Text = "";
            LB_totalce.Text = "";
            LB_totalva.Text = "";
            LB_totalre.Text = "";
            LB_totalve.Text = "";
            LB_totalco.Text = "";
        }



        private void BT_prov_stocks_Click(object sender, EventArgs e)
        {
            CB_proveedorStock.Items.Clear();
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "Select distinct proveedor From rd_stock_compra";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            Proveedor nombre = new Proveedor();
            while (dr.Read())
            {
                CB_proveedorStock.Items.Add(nombre.NombreProveedor(dr["proveedor"].ToString()));
            }
            dr.Close();
            conexion.Close();
        }


        private void BT_buscar_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }


        //actualiza los cambios en el stock
        private void button3_Click_1(object sender, EventArgs e)
        {
            Actualizar();
        }


        //CREAR ORDEN DE COMPRA
        private void button5_Click(object sender, EventArgs e)
        {
            GuardarOrdenCompra();
        }

        //ASIGNA CONSECUTIVO, FOLIO Y DESCUENTO AL STOCK PARA CONVERTIRLO EN UNA ORDEN DE COMPRA
        private void button3_Click(object sender, EventArgs e)
        {
            //string query = "UPDATE rd_stock_compra SET consecutivo ='" + TB_consecutivo.Text + "', folio='" + TB_folio.Text + "', descuento='" + TB_descuento.Text + "'where idreg='" + TB_idstock.Text + "'";

            //if (TB_idstock.Text.Equals(""))
            //{
            //    MessageBox.Show("Debes seleccionar primero el stock al cual quieres convertir en orden de compra");
            //}
            //else
            //{
            //    MySqlConnection conexion = BDConexicon.BodegaOpen();
            //    MySqlCommand cmd = new MySqlCommand(query,conexion);
            //    cmd.ExecuteNonQuery();
            //}
            GuardarOrdenCompra();
        }


        //AGREGAR ARTICULO AL DATAGRID
        private void button1_Click(object sender, EventArgs e)
        {
           
                InsertarArticuloDG();
            


        }

        //eliminar articulo de datagrid
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DG_tabla.Rows.Remove(DG_tabla.CurrentRow);

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar una fila sin datos");

            }
        }


        private void BT_actualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }


    
        private void BT_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void GuardarOrdenCompra()
        {

            //GURDAR LA CABECERA DEL STOCK
            string query = "INSERT INTO rd_orden_compra(consecutivo,folio,fecha,proveedor,descripcion,totalbo,totalce,totalva,totalre,totalve,totalco,usuario,columnaExtra,tipo)" +
              "VALUES(?consecutivo,?folio,?fecha,?proveedor,?descripcion,?totalbo,?totalce,?totalva,?totalre,?totalve,?totalco,?usuario,?columnaExtra,?tipo)";
            DateTime fecha = DT_fecha.Value;

            int idregStock = 0;

            string idStock = "SELECT MAX(idreg) as id FROM rd_orden_compra";
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("?consecutivo",TB_consecutivo.Text);
                cmd.Parameters.AddWithValue("?folio", TB_folio.Text);
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));

                cmd.Parameters.AddWithValue("?proveedor", TB_id_prov.Text);
                cmd.Parameters.AddWithValue("?descripcion", TB_consecutivo.Text+" "+CB_proveedorStock.SelectedItem.ToString()+" "+TB_folio.Text);
                decimal digito = decimal.Parse(LB_totalbo.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalbo = digito.ToString("G0");
                cmd.Parameters.AddWithValue("?totalbo", totalbo);
                decimal digito2 = decimal.Parse(LB_totalce.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalce = digito2.ToString("G0");
                cmd.Parameters.AddWithValue("?totalce", totalce);
                decimal digito3 = decimal.Parse(LB_totalva.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalva = digito3.ToString("G0");
                cmd.Parameters.AddWithValue("?totalva", totalva);
                decimal digito4 = decimal.Parse(LB_totalre.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalre = digito4.ToString("G0");
                cmd.Parameters.AddWithValue("?totalre", totalre);
                decimal digito5 = decimal.Parse(LB_totalve.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalve = digito5.ToString("G0");
                cmd.Parameters.AddWithValue("?totalve", totalve);
                decimal digito6 = decimal.Parse(LB_totalco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalco = digito6.ToString("G0");
                cmd.Parameters.AddWithValue("?totalco", totalco);
                cmd.Parameters.AddWithValue("?usuario", usuario);
                cmd.Parameters.AddWithValue("?columnaExtra",DG_tabla.Columns[19].HeaderText.ToString());
                if (RB_cedis.Checked == true)
                {
                    tipo = "CEDIS";
                }
                else
                {
                    tipo = "TODAS";
                }
                cmd.Parameters.AddWithValue("?tipo", tipo);

                cmd.ExecuteNonQuery();


                //OBTENER EL ID DEL STOCK GENERADO POR LA BD

                MySqlCommand ultimoStock = new MySqlCommand(idStock, conexion);
                MySqlDataReader dr = ultimoStock.ExecuteReader();

                while (dr.Read())
                {
                    idregStock = Convert.ToInt32(dr["id"].ToString());
                }
                dr.Close();
                conexion.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el Stock " + ex);
            }






            //INSERTAR EL DETALLE DEL STOCK(TODOS LOS ARTICULOS CAPTURADOS)
            try
            {


                string insertarDetalle = "INSERT INTO rd_detalle_orden_compra(fk_stock,modelo,claveProducto,descripcion,departamento,pzxpedir,cajasxpedir,cajaspedbo,pzxcaja,pzxpaq,costoxpaq,costoxpz,ped_bo,importe_bo,max_ce,ex_ce,ped_ce,importeCE,max_va,ex_va,ex_pasada_va,ped_va,importe_va,max_re,ex_re,ex_pasada_re,ped_re,importe_re,max_ve,ex_ve,ex_pasada_ve,ped_ve,importe_ve,max_co,ex_co,ex_pasada_co,ped_co,importe_co,oferta)" +
                    "VALUES(?fk_stock,?modelo,?claveProducto,?descripcion,?departamento,?pzxpedir,?cajasxpedir,?cajaspedbo,?pzxcaja,?pzxpaq,?costoxpaq,?costoxpz,?ped_bo,?importe_bo,?max_ce,?ex_ce,?ped_ce,?importeCE,?max_va,?ex_va,?ex_pasada_va,?ped_va,?importe_va,?max_re,?ex_re,?ex_pasada_re,?ped_re,?importe_re,?max_ve,?ex_ve,?ex_pasada_ve,?ped_ve,?importe_ve,?max_co,?ex_co,?ex_pasada_co,?ped_co,?importe_co,?oferta)";
                MySqlConnection conexion = BDConexicon.BodegaOpen();

                for (int i = 0; i < DG_tabla.RowCount; i++)
                {
                    MySqlCommand insertar = new MySqlCommand(insertarDetalle, conexion);
                    insertar.Parameters.AddWithValue("?fk_stock", idregStock);
                    if (DG_tabla.Rows[i].Cells["MODELO"].Value.ToString().Equals(""))
                    {
                        insertar.Parameters.AddWithValue("?modelo", "");
                    }
                    else
                    {
                        insertar.Parameters.AddWithValue("?modelo", DG_tabla.Rows[i].Cells["MODELO"].Value.ToString());
                    }

                    insertar.Parameters.AddWithValue("?claveProducto", DG_tabla.Rows[i].Cells["CLAVE"].Value.ToString());
                    insertar.Parameters.AddWithValue("?descripcion", DG_tabla.Rows[i].Cells["DESCRIPCION"].Value.ToString());
                    insertar.Parameters.AddWithValue("?departamento", DG_tabla.Rows[i].Cells["DEPTO"].Value.ToString());
                    insertar.Parameters.AddWithValue("?pzxpedir", DG_tabla.Rows[i].Cells["PIEZAS"].Value);
                    insertar.Parameters.AddWithValue("?cajasxpedir", DG_tabla.Rows[i].Cells["CAJAS"].Value);
                    insertar.Parameters.AddWithValue("?cajaspedbo", DG_tabla.Rows[i].Cells["CAJAS_BOD"].Value);
                    insertar.Parameters.AddWithValue("?pzxcaja", DG_tabla.Rows[i].Cells["PZ_CAJA"].Value);
                    insertar.Parameters.AddWithValue("?pzxpaq", DG_tabla.Rows[i].Cells["PZ_PAQ"].Value);
                    insertar.Parameters.AddWithValue("?costoxpaq", DG_tabla.Rows[i].Cells["COSTO_PAQUETE"].Value);
                    insertar.Parameters.AddWithValue("?costoxpz", DG_tabla.Rows[i].Cells["COSTO_PIEZA"].Value);
                    insertar.Parameters.AddWithValue("?ped_bo", DG_tabla.Rows[i].Cells["PEDIDO_BOD"].Value);
                    insertar.Parameters.AddWithValue("?importe_bo", DG_tabla.Rows[i].Cells["IMPORTE_BOD"].Value);
                    insertar.Parameters.AddWithValue("?max_ce", DG_tabla.Rows[i].Cells["MAX_CE"].Value);
                    insertar.Parameters.AddWithValue("?ex_ce", DG_tabla.Rows[i].Cells["EXT_CE"].Value);
                    insertar.Parameters.AddWithValue("?ped_ce", DG_tabla.Rows[i].Cells["PED_CE"].Value);
                    insertar.Parameters.AddWithValue("?importeCE", DG_tabla.Rows[i].Cells["IMPORTE_CE"].Value);
                    insertar.Parameters.AddWithValue("?max_va", DG_tabla.Rows[i].Cells["MAX_VA"].Value);
                    insertar.Parameters.AddWithValue("?ex_va", DG_tabla.Rows[i].Cells["EXT_VA"].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_va", DG_tabla.Rows[i].Cells["EX_PASADA_VA"].Value);
                    insertar.Parameters.AddWithValue("?ped_va", DG_tabla.Rows[i].Cells["PEDIDO_VA"].Value);
                    insertar.Parameters.AddWithValue("?importe_va", DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value);
                    insertar.Parameters.AddWithValue("?max_re", DG_tabla.Rows[i].Cells["MAX_RE"].Value);
                    insertar.Parameters.AddWithValue("?ex_re", DG_tabla.Rows[i].Cells["EXT_RE"].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_re", DG_tabla.Rows[i].Cells["EX_PASADA_RE"].Value);
                    insertar.Parameters.AddWithValue("?ped_re", DG_tabla.Rows[i].Cells["PEDIDO_RE"].Value);
                    insertar.Parameters.AddWithValue("?importe_re", DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value);
                    insertar.Parameters.AddWithValue("?max_ve", DG_tabla.Rows[i].Cells["MAX_VE"].Value);
                    insertar.Parameters.AddWithValue("?ex_ve", DG_tabla.Rows[i].Cells["EXT_VE"].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_ve", DG_tabla.Rows[i].Cells["EX_PASADA_VE"].Value);
                    insertar.Parameters.AddWithValue("?ped_ve", DG_tabla.Rows[i].Cells["PEDIDO_VE"].Value);
                    insertar.Parameters.AddWithValue("?importe_ve", DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value);
                    insertar.Parameters.AddWithValue("?max_co", DG_tabla.Rows[i].Cells["MAX_CO"].Value);
                    insertar.Parameters.AddWithValue("?ex_co", DG_tabla.Rows[i].Cells["EXT_CO"].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_co", DG_tabla.Rows[i].Cells["EX_PASADA_CO"].Value);
                    insertar.Parameters.AddWithValue("?ped_co", DG_tabla.Rows[i].Cells["PEDIDO_CO"].Value);
                    insertar.Parameters.AddWithValue("?importe_co", DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value);
                    insertar.Parameters.AddWithValue("?oferta", 0);
                    insertar.Parameters.AddWithValue("?costou", DG_tabla.Rows[i].Cells["COSTOU"].Value);
                    insertar.ExecuteNonQuery();


                }
                MessageBox.Show("SE HA GUARDADO EL STOCK");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar detalle del stock " + ex);
            }
        }

        public void GuardarStock()
        {

            //GURDAR LA CABECERA DEL STOCK
            string query = "INSERT INTO rd_stock_compra(fecha,proveedor,descripcion,totalbo,totalce,totalva,totalre,totalve,totalco,usuario,columnaExtra,tipo)" +
              "VALUES(?fecha,?proveedor,?descripcion,?totalbo,?totalce,?totalva,?totalre,?totalve,?totalco,?usuario,?columnaExtra,?tipo)";
            DateTime fecha = DT_fecha.Value;

            int idregStock = 0;
            string tipo = "";
            string idStock = "SELECT MAX(idreg) as id FROM rd_stock_compra";
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));

                cmd.Parameters.AddWithValue("?proveedor", TB_idProv.Text);
                cmd.Parameters.AddWithValue("?descripcion", TB_descripcion.Text);
                decimal digito = decimal.Parse(LB_totalbo.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalbo = digito.ToString("G0");
                cmd.Parameters.AddWithValue("?totalbo", totalbo);
                decimal digito2 = decimal.Parse(LB_totalce.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalce = digito2.ToString("G0");
                cmd.Parameters.AddWithValue("?totalce", totalce);
                decimal digito3 = decimal.Parse(LB_totalva.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalva = digito3.ToString("G0");
                cmd.Parameters.AddWithValue("?totalva", totalva);
                decimal digito4 = decimal.Parse(LB_totalre.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalre = digito4.ToString("G0");
                cmd.Parameters.AddWithValue("?totalre", totalre);
                decimal digito5 = decimal.Parse(LB_totalve.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalve = digito5.ToString("G0");
                cmd.Parameters.AddWithValue("?totalve", totalve);
                decimal digito6 = decimal.Parse(LB_totalco.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string totalco = digito6.ToString("G0");
                cmd.Parameters.AddWithValue("?totalco", totalco);
                cmd.Parameters.AddWithValue("?usuario", usuario);
                cmd.Parameters.AddWithValue("?columnaExtra", TB_columna.Text);
                if (RB_cedis.Checked == true)
                {
                    tipo = "CEDIS";
                }
                else
                {
                    tipo = "TODAS";
                }
                cmd.Parameters.AddWithValue("?tipo", tipo);

                cmd.ExecuteNonQuery();


                //OBTENER EL ID DEL STOCK GENERADO POR LA BD

                MySqlCommand ultimoStock = new MySqlCommand(idStock, conexion);
                MySqlDataReader dr = ultimoStock.ExecuteReader();

                while (dr.Read())
                {
                    idregStock = Convert.ToInt32(dr["id"].ToString());
                }
                dr.Close();
                conexion.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el Stock " + ex);
            }






            //INSERTAR EL DETALLE DEL STOCK(TODOS LOS ARTICULOS CAPTURADOS)
            try
            {


                string insertarDetalle = "INSERT INTO rd_detalle_stock_compra(fk_stock,modelo,claveProducto,descripcion,departamento,pzxpedir,cajasxpedir,cajaspedbo,pzxcaja,pzxpaq,costoxpaq,costoxpz,ped_bo,importe_bo,max_ce,ex_ce,ped_ce,importeCE,max_va,ex_va,ex_pasada_va,ped_va,importe_va,max_re,ex_re,ex_pasada_re,ped_re,importe_re,max_ve,ex_ve,ex_pasada_ve,ped_ve,importe_ve,max_co,ex_co,ex_pasada_co,ped_co,importe_co,oferta,costou)" +
                    "VALUES(?fk_stock,?modelo,?claveProducto,?descripcion,?departamento,?pzxpedir,?cajasxpedir,?cajaspedbo,?pzxcaja,?pzxpaq,?costoxpaq,?costoxpz,?ped_bo,?importe_bo,?max_ce,?ex_ce,?ped_ce,?importeCE,?max_va,?ex_va,?ex_pasada_va,?ped_va,?importe_va,?max_re,?ex_re,?ex_pasada_re,?ped_re,?importe_re,?max_ve,?ex_ve,?ex_pasada_ve,?ped_ve,?importe_ve,?max_co,?ex_co,?ex_pasada_co,?ped_co,?importe_co,?oferta,?costou)";
                MySqlConnection conexion = BDConexicon.BodegaOpen();

                for (int i = 0; i < DG_tabla.RowCount; i++)
                {
                    MySqlCommand insertar = new MySqlCommand(insertarDetalle, conexion);
                    insertar.Parameters.AddWithValue("?fk_stock", idregStock);
                    if (DG_tabla.Rows[i].Cells["MODELO"].Value.ToString().Equals(""))
                    {
                        insertar.Parameters.AddWithValue("?modelo", "");
                    }
                    else
                    {
                        insertar.Parameters.AddWithValue("?modelo", DG_tabla.Rows[i].Cells["MODELO"].Value.ToString());
                    }
                   
                    insertar.Parameters.AddWithValue("?claveProducto", DG_tabla.Rows[i].Cells["CLAVE"].Value.ToString());
                    insertar.Parameters.AddWithValue("?descripcion", DG_tabla.Rows[i].Cells["DESCRIPCION"].Value.ToString());
                    insertar.Parameters.AddWithValue("?departamento", DG_tabla.Rows[i].Cells["DEPTO"].Value.ToString());
                    insertar.Parameters.AddWithValue("?pzxpedir", DG_tabla.Rows[i].Cells["PIEZAS"].Value);
                    insertar.Parameters.AddWithValue("?cajasxpedir", DG_tabla.Rows[i].Cells["CAJAS"].Value);
                    insertar.Parameters.AddWithValue("?cajaspedbo", DG_tabla.Rows[i].Cells["CAJAS_BOD"].Value);
                    insertar.Parameters.AddWithValue("?pzxcaja", DG_tabla.Rows[i].Cells["PZ_CAJA"].Value);
                    insertar.Parameters.AddWithValue("?pzxpaq", DG_tabla.Rows[i].Cells["PZ_PAQ"].Value);
                    insertar.Parameters.AddWithValue("?costoxpaq", DG_tabla.Rows[i].Cells["COSTO_PAQUETE"].Value);
                    insertar.Parameters.AddWithValue("?costoxpz", DG_tabla.Rows[i].Cells["COSTO_PIEZA"].Value);
                    insertar.Parameters.AddWithValue("?ped_bo", DG_tabla.Rows[i].Cells["PEDIDO_BOD"].Value);
                    insertar.Parameters.AddWithValue("?importe_bo", DG_tabla.Rows[i].Cells["IMPORTE_BOD"].Value);
                    insertar.Parameters.AddWithValue("?max_ce", DG_tabla.Rows[i].Cells["MAX_CE"].Value);
                    insertar.Parameters.AddWithValue("?ex_ce", DG_tabla.Rows[i].Cells["EXT_CE"].Value);
                    insertar.Parameters.AddWithValue("?ped_ce", DG_tabla.Rows[i].Cells["PED_CE"].Value);
                    insertar.Parameters.AddWithValue("?importeCE", DG_tabla.Rows[i].Cells["IMPORTE_CE"].Value);
                    insertar.Parameters.AddWithValue("?max_va", DG_tabla.Rows[i].Cells["MAX_VA"].Value);
                    insertar.Parameters.AddWithValue("?ex_va", DG_tabla.Rows[i].Cells["EXT_VA"].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_va", DG_tabla.Rows[i].Cells["EX_PASADA_VA"].Value);
                    insertar.Parameters.AddWithValue("?ped_va", DG_tabla.Rows[i].Cells["PEDIDO_VA"].Value);
                    insertar.Parameters.AddWithValue("?importe_va", DG_tabla.Rows[i].Cells["IMPORTE_VA"].Value);
                    insertar.Parameters.AddWithValue("?max_re", DG_tabla.Rows[i].Cells["MAX_RE"].Value);
                    insertar.Parameters.AddWithValue("?ex_re", DG_tabla.Rows[i].Cells["EXT_RE"].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_re", DG_tabla.Rows[i].Cells["EX_PASADA_RE"].Value);
                    insertar.Parameters.AddWithValue("?ped_re", DG_tabla.Rows[i].Cells["PEDIDO_RE"].Value);
                    insertar.Parameters.AddWithValue("?importe_re", DG_tabla.Rows[i].Cells["IMPORTE_RE"].Value);
                    insertar.Parameters.AddWithValue("?max_ve", DG_tabla.Rows[i].Cells["MAX_VE"].Value);
                    insertar.Parameters.AddWithValue("?ex_ve", DG_tabla.Rows[i].Cells["EXT_VE"].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_ve", DG_tabla.Rows[i].Cells["EX_PASADA_VE"].Value);
                    insertar.Parameters.AddWithValue("?ped_ve", DG_tabla.Rows[i].Cells["PEDIDO_VE"].Value);
                    insertar.Parameters.AddWithValue("?importe_ve", DG_tabla.Rows[i].Cells["IMPORTE_VE"].Value);
                    insertar.Parameters.AddWithValue("?max_co", DG_tabla.Rows[i].Cells["MAX_CO"].Value);
                    insertar.Parameters.AddWithValue("?ex_co", DG_tabla.Rows[i].Cells["EXT_CO"].Value);
                    insertar.Parameters.AddWithValue("?ex_pasada_co", DG_tabla.Rows[i].Cells["EX_PASADA_CO"].Value);
                    insertar.Parameters.AddWithValue("?ped_co", DG_tabla.Rows[i].Cells["PEDIDO_CO"].Value);
                    insertar.Parameters.AddWithValue("?importe_co", DG_tabla.Rows[i].Cells["IMPORTE_CO"].Value);
                    insertar.Parameters.AddWithValue("?oferta",0);
                    insertar.Parameters.AddWithValue("?costou", DG_tabla.Rows[i].Cells["COSTOU"].Value);
                    insertar.ExecuteNonQuery();


                }
                MessageBox.Show("SE HA GUARDADO EL STOCK");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar detalle del stock " + ex);
            }
        }

        //SE GUARDA TODO EL STOCK EN LA BD.
        private void BT_crear_Click(object sender, EventArgs e)
        {
            //COLOCAR TEXTHEADER A LA COLUMNA DE EXISTENCIA PASADA
            DG_tabla.Columns[19].HeaderText = TB_columna.Text;
            DG_tabla.Columns[24].HeaderText = TB_columna.Text;
            DG_tabla.Columns[29].HeaderText = TB_columna.Text;
            DG_tabla.Columns[34].HeaderText = TB_columna.Text;

            if (CB_proveedor.SelectedIndex==-1||TB_columna.Text.Equals(""))
            {
              

                if (CB_proveedor.SelectedIndex==-1)
                {
                    MessageBox.Show("CAPTURA EL PROVEEDOR");
                }

               

                if (TB_columna.Text.Equals(""))
                {
                    MessageBox.Show("CAPTURA EL NOMBRE DE LAS COLUMNAS DONDE SE MUESTRA LA EXISTENCIA PASADA");
                }

              



            }
            else
            {
                GuardarStock();
            }

        }

        private void BT_existencia_pasada_Click(object sender, EventArgs e)
        {
           
        }

     
        

        DataTable dt = new DataTable();
        DataTable ImportarDatos(string archivo)
        {
            dt.Rows.Clear();
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ={0}; Extended Properties ='Excel 12.0;'", archivo);
            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();

            OleDbCommand consulta = new OleDbCommand("select * from[hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };


            adaptador.Fill(dt);
            conector.Close();
            return dt;




        }
        private void BT_cargaMasiva_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls; *xlsx",
                Title = "Seleccionar Archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                dt = ImportarDatos(openFileDialog.FileName);

            }

            int pzCaja = 0; double costo = 0;
            Productos prod = new Productos();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                pzCaja = PiezasXCajaCE(dt.Rows[i][0].ToString());

                if (pzCaja <= 0)
                {
                    pzCaja = 1;
                }
                costo = CostoArticulo(dt.Rows[i][0].ToString());
                existenciaBO = prod.ExistenciaXTienda(dt.Rows[i][0].ToString(), "BODEGA");
                existenciaVA = prod.ExistenciaXTienda(dt.Rows[i][0].ToString(), "VALLARTA");
                existenciaRE = prod.ExistenciaXTienda(dt.Rows[i][0].ToString(), "RENA");
                existenciaVE = prod.ExistenciaXTienda(dt.Rows[i][0].ToString(), "VELAZQUEZ");
                existenciaCO = prod.ExistenciaXTienda(dt.Rows[i][0].ToString(), "COLOSO");

                maxBo = MaximoArticuloCE(dt.Rows[i][0].ToString());
                maxVa = MaximoArticuloVA(dt.Rows[i][0].ToString());
                maxRe = MaximoArticuloRE(dt.Rows[i][0].ToString());
                maxVe = MaximoArticuloVE(dt.Rows[i][0].ToString());
                maxCo = MaximoArticuloCO(dt.Rows[i][0].ToString());
                DG_tabla.Rows.Add("", dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), "0", "0", "0", pzCaja,1, costo, "0", "0", "0", maxBo, existenciaBO, "0", "0", maxVa, existenciaVA, "0", "0", "0", maxRe, existenciaRE, "0", "0", "0", maxVe, existenciaVE, "0", "0", "0", maxCo, existenciaCO, "0", "0", "0");
            }

        }

        private void TB_proveedor_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void BT_calcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }
        #endregion

        #region EVENTOS

        private void CB_proveedorStock_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            try
            {
                RB_cedis.Checked = false;
                RB_tiendas.Checked = false;
                CB_stocks.Items.Clear();
                CB_stocks.Text = "";
               
                Proveedor proveedor = new Proveedor();
                TB_id_prov.Text = proveedor.IdProveedor(CB_proveedorStock.SelectedItem.ToString());
            }
            catch (Exception)
            {

                
            }

            string query = "select idreg,descripcion from rd_stock_compra where proveedor='" + TB_id_prov.Text + "'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_stocks.Items.Add(dr["descripcion"].ToString());
            }
            dr.Close();
            conexion.Close();
        }
        string tipo = "";

        private void CB_stocks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select idreg from rd_stock_compra where proveedor='" + TB_id_prov.Text + "' and descripcion='" + CB_stocks.SelectedItem.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TB_idstock.Text = dr["idreg"].ToString();
            }
            dr.Close();
            conexion.Close();
        }

        private void CB_proveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Proveedor id = new Proveedor();
                TB_idProv.Text = id.IdProveedor(CB_proveedor.SelectedItem.ToString());
            }
            catch (Exception)
            {

            }
        }
        private void TB_articulo_KeyPress(object sender, KeyPressEventArgs e)
        {




            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                InsertarArticuloDG();
            }
        }


        private void TB_articulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                string clave = TB_articulo.Text;

               
                
                    Aux_AgregarArticuloStock aux = new Aux_AgregarArticuloStock(clave);
                    AddOwnedForm(aux);
                    aux.Show();
                

                
            }
        }


        //obtiene el numero de proveedor
        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        //llena el combobox con los stocks del proveedor seleccionado
        private void CB_proveedorStock_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }


        //trae el id del stock seleccionado

        private void CB_stocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion


    }
}
