﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class VentasXLinea : Form
    {
        public VentasXLinea()
        {
            InitializeComponent();
        }

        List<string> Lineas = new List<string>();
        DataTable dt = new DataTable();
        DataTable dtVentas = new DataTable();
        DataTable lineas = new DataTable();


        private void button1_Click(object sender, EventArgs e)
        {
            //llenaComboLinea();
            //consulta();
            consultaVA();
            consultaRE();
            consultaVE();
            consultaCO();


        }

        public void consultaVA()
        {
            double total;
            //dgvLineas.Rows.Clear();

            MySqlConnection con = null;
            string lineaTabla = "";
            string lineaBD = "";
            string comando = "";

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            try
            {
                //for (int i = 0; i < dgvLineas.Rows.Count; i++)
                //{

                //progressBar1.Value = valor;
                //valor++;
                con = conectar("VALLARTA");

                total = 0;
                comando = "SELECT prods.linea,lineas.descrip AS desclinea, " +
                "SUM(IF(ventas.tipo_doc = 'DV' OR ventas.tipo_doc = 'DEV', IF(partvta.invent <> 0, partvta.cantidad, 0), " +
                "(partvta.cantidad - partvta.a01))) AS cantvend, SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As Importe," +
                " SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As Impuesto, " +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100))) As Total " +
                 "FROM((partvta LEFT JOIN ventas ON ventas.venta = partvta.venta) INNER JOIN prods ON partvta.articulo = prods.articulo) INNER JOIN lineas ON prods.linea = lineas.linea " +
                 "WHERE ventas.estado = 'CO' AND (ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') " +
                "AND ventas.cierre = 0 and " +
                "lineas.Linea IN ('MASCOTAS','FIESTA','ARTLIMPIEZA','BARBIE','BOLSA - FEB','CPAPE','COSVIP','COVID','NAV','BOLSA','PLY','BISUTE','BPLASTC','COSMET','HAL'," +
                "'JUGUET','MONTAB','MOSTRA','PAT','PELUCHE','PLASTIC','SER','SOMBRILLAS','MAY','FEB','ESCOLA','SYS','LLYMO','SALDOS','UNIFORMES','VITRINA','REYES') and ventas.F_EMISION BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' GROUP BY lineas.linea order by lineas.descrip";
                MySqlCommand cmdr = new MySqlCommand(comando, con);
                MySqlDataReader mdrr;

                mdrr = cmdr.ExecuteReader();

                while (mdrr.Read())
                {
                    total = mdrr.GetDouble("Total");



                    lineaBD = mdrr["linea"].ToString();


                    for (int i = 0; i < dgvLineas.Rows.Count; i++)
                    {

                        lineaTabla = dgvLineas.Rows[i].Cells["CLAVE"].Value.ToString();
                        if (lineaBD.Equals(lineaTabla))
                        {
                            dgvLineas.Rows[i].Cells["VALLARTA"].Value = total.ToString("C");
                            break;

                        }

                    }

                }



                mdrr.Close();





                con.Close();
                //  backgroundWorker1.ReportProgress(i);
                //}
            }
            catch (Exception er)
            {
                MessageBox.Show("Error en la conexion Motivo: " + er.Message);
            }
            total = 0;

        }

        public void consultaRE()
        {
            double total;
            //dgvLineas.Rows.Clear();

            MySqlConnection con = null;
            string lineaTabla = "";
            string lineaBD = "";
            string comando = "";
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            try
            {
                //for (int i = 0; i < dgvLineas.Rows.Count; i++)
                //{

                //progressBar1.Value = valor;
                //valor++;
                con = conectar("RENA");

                total = 0;

                comando = "SELECT prods.linea,lineas.descrip AS desclinea, " +
                "SUM(IF(ventas.tipo_doc = 'DV' OR ventas.tipo_doc = 'DEV', IF(partvta.invent <> 0, partvta.cantidad, 0), " +
                "(partvta.cantidad - partvta.a01))) AS cantvend, SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As Importe," +
                " SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As Impuesto, " +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100))) As Total " +
                 "FROM((partvta LEFT JOIN ventas ON ventas.venta = partvta.venta) INNER JOIN prods ON partvta.articulo = prods.articulo) INNER JOIN lineas ON prods.linea = lineas.linea " +
                 "WHERE ventas.estado = 'CO' AND (ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') " +
                "AND ventas.cierre = 0 and " +
                "lineas.Linea IN ('MASCOTAS','FIESTA','ARTLIMPIEZA','BARBIE','BOLSA - FEB','CPAPE','COSVIP','COVID','NAV','BOLSA','PLY','BISUTE','BPLASTC','COSMET','HAL'," +
                "'JUGUET','MONTAB','MOSTRA','PAT','PELUCHE','PLASTIC','SER','SOMBRILLAS','MAY','FEB','ESCOLA','SYS','LLYMO','SALDOS','UNIFORMES','VITRINA','REYES')  and ventas.F_EMISION BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' GROUP BY lineas.linea order by lineas.descrip";
                MySqlCommand cmdr = new MySqlCommand(comando, con);
                MySqlDataReader mdrr;

                mdrr = cmdr.ExecuteReader();

                while (mdrr.Read())
                {
                    total = mdrr.GetDouble("Total");



                    lineaBD = mdrr["linea"].ToString();


                    for (int i = 0; i < dgvLineas.Rows.Count; i++)
                    {

                        lineaTabla = dgvLineas.Rows[i].Cells["CLAVE"].Value.ToString();
                        if (lineaBD.Equals(lineaTabla))
                        {
                            dgvLineas.Rows[i].Cells["RENA"].Value = total.ToString("C");
                            break;

                        }

                    }

                }



                mdrr.Close();





                con.Close();
                //  backgroundWorker1.ReportProgress(i);
                //}
            }
            catch (Exception er)
            {
                MessageBox.Show("Error en la conexion Motivo: " + er.Message);
            }
            total = 0;

        }

        public void consultaVE()
        {
            double total;
            //dgvLineas.Rows.Clear();

            MySqlConnection con = null;
            string lineaTabla = "";
            string lineaBD = "";
            string comando = "";
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            try
            {
                //for (int i = 0; i < dgvLineas.Rows.Count; i++)
                //{

                //progressBar1.Value = valor;
                //valor++;
                con = conectar("DIEZ");

                total = 0;
                comando = "SELECT prods.linea,lineas.descrip AS desclinea, " +
                "SUM(IF(ventas.tipo_doc = 'DV' OR ventas.tipo_doc = 'DEV', IF(partvta.invent <> 0, partvta.cantidad, 0), " +
                "(partvta.cantidad - partvta.a01))) AS cantvend, SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As Importe," +
                " SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As Impuesto, " +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100))) As Total " +
                 "FROM((partvta LEFT JOIN ventas ON ventas.venta = partvta.venta) INNER JOIN prods ON partvta.articulo = prods.articulo) INNER JOIN lineas ON prods.linea = lineas.linea " +
                 "WHERE ventas.estado = 'CO' AND (ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') " +
                "AND ventas.cierre = 0 and " +
                "lineas.Linea IN ('MASCOTAS','FIESTA','ARTLIMPIEZA','BARBIE','BOLSA - FEB','CPAPE','COSVIP','COVID','NAV','BOLSA','PLY','BISUTE','BPLASTC','COSMET','HAL'," +
                "'JUGUET','MONTAB','MOSTRA','PAT','PELUCHE','PLASTIC','SER','SOMBRILLAS','MAY','FEB','ESCOLA','SYS','LLYMO','SALDOS','UNIFORMES','VITRINA','REYES')  and ventas.F_EMISION BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' GROUP BY lineas.linea order by lineas.descrip";



                MySqlCommand cmdr = new MySqlCommand(comando, con);
                MySqlDataReader mdrr;

                mdrr = cmdr.ExecuteReader();

                while (mdrr.Read())
                {
                    total = mdrr.GetDouble("Total");



                    lineaBD = mdrr["linea"].ToString();


                    for (int i = 0; i < dgvLineas.Rows.Count; i++)
                    {

                        lineaTabla = dgvLineas.Rows[i].Cells["CLAVE"].Value.ToString();
                        if (lineaBD.Equals(lineaTabla))
                        {
                            dgvLineas.Rows[i].Cells["VELAZQUEZ"].Value = total.ToString("C");
                            break;

                        }

                    }

                }



                mdrr.Close();





                con.Close();
                //  backgroundWorker1.ReportProgress(i);
                //}
            }
            catch (Exception er)
            {
                MessageBox.Show("Error en la conexion Motivo: " + er.Message);
            }
            total = 0;
        }

        public void consultaCO()
        {
            double total;
            //dgvLineas.Rows.Clear();

            MySqlConnection con = null;
            string lineaTabla = "";
            string lineaBD = "";
            string comando = "";
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            try
            {
                //for (int i = 0; i < dgvLineas.Rows.Count; i++)
                //{

                //progressBar1.Value = valor;
                //valor++;
                con = conectar("COLOSO");

                total = 0;
                comando = "SELECT prods.linea,lineas.descrip AS desclinea, " +
                "SUM(IF(ventas.tipo_doc = 'DV' OR ventas.tipo_doc = 'DEV', IF(partvta.invent <> 0, partvta.cantidad, 0), " +
                "(partvta.cantidad - partvta.a01))) AS cantvend, SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As Importe," +
                " SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As Impuesto, " +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100))) As Total " +
                 "FROM((partvta LEFT JOIN ventas ON ventas.venta = partvta.venta) INNER JOIN prods ON partvta.articulo = prods.articulo) INNER JOIN lineas ON prods.linea = lineas.linea " +
                 "WHERE ventas.estado = 'CO' AND (ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') " +
                "AND ventas.cierre = 0 and " +
                "lineas.Linea IN ('MASCOTAS','FIESTA','ARTLIMPIEZA','BARBIE','BOLSA - FEB','CPAPE','COSVIP','COVID','NAV','BOLSA','PLY','BISUTE','BPLASTC','COSMET','HAL'," +
                "'JUGUET','MONTAB','MOSTRA','PAT','PELUCHE','PLASTIC','SER','SOMBRILLAS','MAY','FEB','ESCOLA','SYS','LLYMO','SALDOS','UNIFORMES','VITRINA','REYES')  and ventas.F_EMISION BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' GROUP BY lineas.linea order by lineas.descrip";
                MySqlCommand cmdr = new MySqlCommand(comando, con);
                MySqlDataReader mdrr;

                mdrr = cmdr.ExecuteReader();

                while (mdrr.Read())
                {
                    total = mdrr.GetDouble("Total");



                    lineaBD = mdrr["linea"].ToString();


                    for (int i = 0; i < dgvLineas.Rows.Count; i++)
                    {

                        lineaTabla = dgvLineas.Rows[i].Cells["CLAVE"].Value.ToString();
                        if (lineaBD.Equals(lineaTabla))
                        {
                            dgvLineas.Rows[i].Cells["COLOSO"].Value = total.ToString("C");
                            break;

                        }

                    }

                }



                mdrr.Close();





                con.Close();
                //  backgroundWorker1.ReportProgress(i);
                //}
            }
            catch (Exception er)
            {
                MessageBox.Show("Error en la conexion Motivo: " + er.Message);
            }
            total = 0;
        }

        //public void consulta()
        //{
        //    double total;
        //    dgvLineas.Rows.Clear();
        //    progressBar1.Minimum = 0;
        //    progressBar1.Maximum = Lineas.Count - 1;

        //    try
        //    {
        //        for (int i = 0; i < Lineas.Count; i++)
        //        {

        //            MySqlConnection con = conectar();

        //            total = 0;
        //            string comando = "SELECT prods.linea,lineas.descrip AS desclinea, " +
        //                "SUM(IF(ventas.tipo_doc = 'DV' OR ventas.tipo_doc = 'DEV', IF(partvta.invent <> 0, partvta.cantidad, 0), " +
        //                "(partvta.cantidad - partvta.a01))) AS cantvend, SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As Importe," +
        //                " SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As Impuesto, " +
        //                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100))) As Total " +
        //                "FROM((partvta LEFT JOIN ventas ON ventas.venta = partvta.venta) INNER JOIN prods ON partvta.articulo = prods.articulo) INNER JOIN lineas ON prods.linea = lineas.linea " +
        //                "WHERE ventas.estado = 'CO' AND (ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 and lineas.Linea = '" + Lineas[i].ToString() + "' GROUP BY lineas.linea ORDER BY lineas.linea";

        //            MySqlCommand cmdr = new MySqlCommand(comando, con);
        //            MySqlDataReader mdrr;

        //            mdrr = cmdr.ExecuteReader();
        //            if (mdrr.Read())
        //            {
        //                total = mdrr.GetDouble("Total");



        //            }

        //            mdrr.Close();

        //            dgvLineas.Rows.Add(cbTienda.Text, cbMeses.SelectedValue.ToString() + " " + cbYear.Text.ToString(), Lineas[i].ToString(), total.ToString("C"));
        //            con.Close();
        //            backgroundWorker1.ReportProgress(i);
        //        }
        //    }
        //    catch (Exception er)
        //    {
        //        MessageBox.Show("Error en la conexion Motivo: " + er.Message);
        //    }


        //}

        public void NombreLineas()
        {
            dt.Columns.Add("CLAVE", typeof(string));
            dt.Columns.Add("LINEA", typeof(string));
            string query = "SELECT LINEA,DESCRIP FROM LINEAS ORDER BY LINEA";
            MySqlConnection con = BDConexicon.VallartaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (!dr["LINEA"].ToString().Equals("MATERIALES")) // el conta no quiere la linea de materiales en el reporte
                {
                    dt.Rows.Add(dr["LINEA"].ToString(), dr["DESCRIP"].ToString());
                }
                

            }
            dr.Close();
            con.Close();


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvLineas.Rows.Add(dt.Rows[i]["CLAVE0"].ToString(), dt.Rows[i]["LINEA0"].ToString(), 0.ToString("C2"), 0.ToString("C2"), 0.ToString("C2"), 0.ToString("C2"));

            }

        }



        private void VentasXLinea_Load(object sender, EventArgs e)
        {
            lineas.Columns.Add("LINEA", typeof(string));
            lineas.Columns.Add("DESCRIP", typeof(string));

            dtVentas.Columns.Add("CLAVE", typeof(string));
            dtVentas.Columns.Add("LINEA", typeof(string));
            dtVentas.Columns.Add("VALLARTA", typeof(double));
            dtVentas.Columns.Add("RENA", typeof(double));
            dtVentas.Columns.Add("VELAZQUEZ", typeof(double));
            dtVentas.Columns.Add("COLOSO", typeof(double));

            dt.Columns.Add("CLAVE0", typeof(string));
            dt.Columns.Add("LINEA0", typeof(string));


            NombreLineas();
            int year = DateTime.Now.Year;
            int x = 0;
            for (int i = 2015; i <= year; i++)
            {
                cbYear.Items.Add(i);
                x = x + 1;
            }
            cbYear.SelectedIndex = x - 1;

            //dgvGastos.Columns.Add("DESCRIPCION", "DESCRIPCION");
            //dgvGastos.Columns.Add("TOTAL", "TOTAL");

            List<Item> mes = new List<Item>();
            List<Item> tienda = new List<Item>();

            tienda.Add(new Item("VALLARTA", "VALLARTA"));
            tienda.Add(new Item("RENA", "RENA"));
            tienda.Add(new Item("VELAZQUEZ", "DIEZ"));
            tienda.Add(new Item("COLOSO", "COLOSO"));
            //tienda.Add(new Item("PREGOT", "PREGOT"));

            mes.Add(new Item("ENERO", "ENE"));
            mes.Add(new Item("FEBRERO", "FEB"));
            mes.Add(new Item("MARZO", "MAR"));
            mes.Add(new Item("ABRIL", "ABR"));
            mes.Add(new Item("MAYO", "MAY"));
            mes.Add(new Item("JUNIO", "JUN"));
            mes.Add(new Item("JULIO", "JUL"));
            mes.Add(new Item("AGOSTO", "AGO"));
            mes.Add(new Item("SEPTIEMBRE", "SEP"));
            mes.Add(new Item("OCTUBRE", "OCT"));
            mes.Add(new Item("NOVIEMBRE", "NOV"));
            mes.Add(new Item("DICIEMBRE", "DIC"));

            cbMeses.DisplayMember = "Name";
            cbMeses.ValueMember = "Value";
            cbMeses.DataSource = mes;


            cbTienda.DisplayMember = "Name";
            cbTienda.ValueMember = "Value";
            cbTienda.DataSource = tienda;
            //llenaComboLinea();
        }

        //public void llenaComboLinea()
        //{
        //    MySqlConnection Conex = conectar();
        //    MySqlCommand cmd = new MySqlCommand("SELECT Linea FROM  lineas", Conex);

        //    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
        //    System.Data.DataTable dt = new System.Data.DataTable();



        //    adaptador.Fill(dt);



        //    foreach (DataRow item in dt.Rows)
        //    {
        //        Lineas.Add(item["Linea"].ToString());

        //    }
        //}

        public int defineMesActual()
        {
            int mes = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            string mescb = cbMeses.SelectedValue.ToString();
            string mesAux;

            int flag = 0;

            if (cbYear.Text == year.ToString())
            {
                if (mes == 1)
                {
                    mesAux = "ENE";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }
                }
                else if (mes == 2)
                {
                    mesAux = "FEB";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }
                }
                else if (mes == 3)
                {
                    mesAux = "MAR";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }
                }
                else if (mes == 4)
                {
                    mesAux = "ABR";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
                else if (mes == 5)
                {
                    mesAux = "MAY";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
                else if (mes == 6)
                {
                    mesAux = "JUN";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
                else if (mes == 7)
                {
                    mesAux = "JUL";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
                else if (mes == 8)
                {
                    mesAux = "AGO";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
                else if (mes == 9)
                {
                    mesAux = "SEP";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
                else if (mes == 10)
                {
                    mesAux = "OCT";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
                else if (mes == 11)
                {
                    mesAux = "NOV";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
                else if (mes == 12)
                {
                    mesAux = "DIC";
                    if (mescb == mesAux)
                    {
                        flag = 1;
                    }

                }
            }

            return flag;
        }

       


        public MySqlConnection conectar(string tienda)
        {



            string IP = "";
            string BD = ""; ;

            int flag = 0;


            string prefijotienda;

            //tienda = cbTienda.SelectedValue.ToString();

            if (tienda == "VALLARTA")
            {
                IP = "25.48.197.55";

            }
            else if (tienda == "RENA")
            {
                IP = "192.168.2.2";
            }
            else if (tienda == "COLOSO")
            {
                IP = "25.44.173.71";
            }
            else if (tienda == "DIEZ")
            {
                IP = "192.168.4.2";
            }
            //else if (tienda == "PREGOT")
            //{
            //    IP = "192.168.6.2";
            //}

            int numMes = DateTime.Now.Month;
            int mesFecha = DT_inicio.Value.Month;
            flag = defineMesActual();

            //if (flag == 1)
            if (numMes == mesFecha)
            {
                BD = "MyBusinessDelta";
            }
            else
            {

                int m = DT_inicio.Value.Month;
                int a = DT_inicio.Value.Year;
                string mes = FormatoFecha.Mes(m);

                BD = tienda + " " + mes + " " + a;

                //BD = tienda + " " + cbMeses.SelectedValue.ToString() + " " + cbYear.Text.ToString();


            }


            MySqlConnection con = new MySqlConnection("server=" + IP + "; database=" + BD + "; Uid=root; pwd=;");
            con.Open();



            return con;

        }

        public MySqlConnection conectar2()
        {



            string IP = "";
            string BD = ""; ;
            string tienda;
            //int flag = 0;

#pragma warning disable CS0168 // La variable 'prefijotienda' se ha declarado pero nunca se usa
            string prefijotienda;
#pragma warning restore CS0168 // La variable 'prefijotienda' se ha declarado pero nunca se usa

            tienda = cbTienda.SelectedValue.ToString();

            if (tienda == "VALLARTA")
            {
                IP = "25.48.197.55";

            }
            else if (tienda == "RENA")
            {
                IP = "192.168.2.2";
            }
            else if (tienda == "COLOSO")
            {
                IP = "25.44.173.71";
            }
            else if (tienda == "DIEZ")
            {
                IP = "192.168.4.2";
            }
            //else if (tienda == "PREGOT")
            //{
            //    IP = "192.168.6.2";
            //}

            //flag = defineMesActual();

            //if (flag == 1)
            //{
            //    BD = "MyBusinessDelta";
            //}
            //else
            //{
            //    BD = tienda + " " + cbMeses.SelectedValue.ToString() + " " + cbYear.Text.ToString();
            //}

            BD = "MyBusinessDelta";

            MySqlConnection con = new MySqlConnection("server=" + IP + "; database=" + BD + "; Uid=root; pwd=;");
            con.Open();



            return con;

        }


        public string definemes(string mes, string Year)
        {

            string cadena;
            cadena = "";
            if (mes == "ENE")
            {
                cadena = "'" + Year + "-01-01' AND " + "'" + Year + "-01-31' ";

            }
            else if (mes == "FEB")
            {
                cadena = "'" + Year + "-02-01' AND" + "'" + Year + "-02-29'";

            }
            else if (mes == "MAR")
            {
                cadena = "'" + Year + "-03-01' AND " + "'" + Year + "-03-31'";

            }
            else if (mes == "ABR")
            {
                cadena = "'" + Year + "-04-01' AND " + "'" + Year + "-04-30' ";


            }
            else if (mes == "MAY")
            {
                cadena = "'" + Year + "-05-01' AND " + "'" + Year + "-05-31'";

            }
            else if (mes == "JUN")
            {
                cadena = "'" + Year + "-06-01' AND " + "'" + Year + "-06-30'";

            }
            else if (mes == "JUL")
            {
                cadena = "'" + Year + "-07-01' AND " + "'" + Year + "-07-31'";

            }
            else if (mes == "AGO")
            {
                cadena = "'" + Year + "-08-01'  AND " + "'" + Year + "-08-31'";

            }
            else if (mes == "SEP")
            {
                cadena = "'" + Year + "09-01' AND " + "'" + Year + "-09-30'";

            }
            else if (mes == "OCT")
            {
                cadena = "'" + Year + "-10-01' AND  " + "'" + Year + "-10-30'";

            }
            else if (mes == "NOV")
            {
                cadena = "'" + Year + "-11-01' AND " + "'" + Year + "-11-31'";

            }
            else if (mes == "DIC")
            {
                cadena = "'" + Year + "-12-01' AND  " + "'" + Year + "-12-31'";


            }


            return cadena;
        }


        private void BT_exportar_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in dgvLineas.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in dgvLineas.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in dgvLineas.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }



            excel.Visible = true;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
        }

        
    }
}
