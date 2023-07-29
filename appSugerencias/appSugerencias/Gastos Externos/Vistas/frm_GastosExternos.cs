using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
using appSugerencias.Gastos_Externos.Vistas;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class frm_GastosExternos : Form
    {

        string tipo_gasto = "";
        int idGastoExterno = 0;
        public frm_GastosExternos()
        {
            InitializeComponent();
        }
        string usuario;

        public frm_GastosExternos(string Usuario)
        {
            InitializeComponent();
            usuario = Usuario;
        }
        
        MySqlConnection con;
        private void frm_GastosExternos_Load(object sender, EventArgs e)
        {
           // llenaComboBox();

            string area = Empleado.Area(usuario);
            if (area.Equals("FINANZAS"))
            {
                cbTienda.SelectedIndex = 0;
                cbTienda.Enabled = false;
                CB_sucursal.Enabled = false;
            }
            
          
        }
        
        public void llenaComboBox()
        {
            MySqlConnection conn;
            conn = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_gastos_externos", conn);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            mysqladap.Fill(dt);

            cbGastos.ValueMember = "id_gasto";
            cbGastos.DisplayMember = "nombre_gasto";
            cbGastos.DataSource = dt;
            conn.Close();
        }


        //CONCEPTO DETALLE
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            idGastoExterno = GastoExternoController.ObtenerIDGastoExterno(cbGastos.SelectedItem.ToString(),
                                                                          CB_concepto_gral.SelectedItem.ToString(),
                                                                          tipo_gasto);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

       public MySqlConnection Conexion (string sucursal)
        {
            MySqlConnection con = null;

            if (sucursal.Equals("BODEGA"))
            {
                con = BDConexicon.BodegaOpen();
            }

            if (sucursal.Equals("VALLARTA"))
            {
                con = BDConexicon.VallartaOpen();
            }

            if (sucursal.Equals("RENA"))
            {
                con = BDConexicon.RenaOpen();
            }

            if (sucursal.Equals("COLOSO"))
            {
                con = BDConexicon.ColosoOpen();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                con = BDConexicon.VelazquezOpen();
            }

          
            return con;
        }

        public void EgresoAcrDiversos(MySqlConnection con)
        {
            DateTime fecha = dtGastos.Value;
            string query = "INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ref_gastoexterno,suc_pago)" +
                "VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ref_gastoexterno,?suc_pago)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?tienda", cbTienda.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?mov", "GE");
            cmd.Parameters.AddWithValue("?ie", "E");
            cmd.Parameters.AddWithValue("?banco", CB_bancosOsmart.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?cuenta", "ENVIO");
            cmd.Parameters.AddWithValue("?pagara", "ACREEDORES DIVERSOS");
            cmd.Parameters.AddWithValue("?cantidad", Convert.ToDouble(tbImporte.Text));
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm"));
            cmd.Parameters.AddWithValue("?fk_gastoexterno", 0);
            cmd.Parameters.AddWithValue("?ref_gastoexterno", tbObservaciones.Text);
            cmd.Parameters.AddWithValue("?suc_pago",CB_sucursal.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            limpiar();
            MessageBox.Show("Se ha registrado el egreso de la cuenta de ACREEDORES DIVERSOS");

        }

        //BOTON AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime fecha = dtGastos.Value;
            //MessageBox.Show(fecha.ToString("yyyy-MM-dd"));
            if (cbTienda.Text == "BODEGA")
            {
                try
                {
                    if (CB_bancosOsmart.SelectedItem.ToString().Equals("FINANZAS")|| CB_bancosOsmart.SelectedItem.ToString().Equals("CAJA GENERAL") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS CEDIS") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS INOCENCIO") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS CDMX"))
                    {
                        con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                        guardaDatos();
                        con.Close();
                    }else if (CB_bancosOsmart.SelectedItem.ToString().Equals("ACREEDORES DIVERSOS"))
                    {
                        con = BDConexicon.BodegaOpen();
                        EgresoAcrDiversos(con);
                    }
                    else
                    {
                        con = Conexion(CB_sucursal.SelectedItem.ToString());
                        guardaDatos();
                        if (CB_bancosOsmart.SelectedItem.ToString().Equals("ACREEDOR"))
                        {
                            GuardarPagoAcreedor(con);
                        }
                        con.Close();
                    }
                        
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "VALLARTA")
            {
                try
                {
                    con = BDConexicon.VallartaOpen();
                    guardaDatos();
                    if (CB_bancosOsmart.SelectedItem.ToString().Equals("ACREEDOR"))
                    {
                        GuardarPagoAcreedor(con);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "RENA")
            {
                try
                { 
                con = BDConexicon.RenaOpen();
                guardaDatos();
                if (CB_bancosOsmart.SelectedItem.ToString().Equals("ACREEDOR"))
                {
                   GuardarPagoAcreedor(con);
                }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "COLOSO")
            {
                try
                {
                con = BDConexicon.ColosoOpen();
                guardaDatos();
                    if (CB_bancosOsmart.SelectedItem.ToString().Equals("ACREEDOR"))
                    {
                        GuardarPagoAcreedor(con);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            else if (cbTienda.Text == "VELAZQUEZ")
            {
                try
                { 
                con = BDConexicon.VelazquezOpen();
                guardaDatos();
                    if (CB_bancosOsmart.SelectedItem.ToString().Equals("ACREEDOR"))
                    {
                        GuardarPagoAcreedor(con);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            

            tbImporte.Text = "";
            tbObservaciones.Text = "";
            //cbGastos.Text = "";
            //CB_bancosOsmart.Text = "";
            CB_sucursal.SelectedIndex = -1;
            CB_cuentasOsmart.Text = "";
            CB_pagara.Text = "";
            TB_saldobanco.Text = "";

        }

        public void limpiar()
        {

            tbImporte.Text = "";
            tbObservaciones.Text = "";
            //cbGastos.Text = "";
            //CB_bancosOsmart.Text = "";
            CB_sucursal.SelectedIndex = -1;
            CB_cuentasOsmart.Text = "";
            CB_pagara.Text = "";
            TB_saldobanco.Text = "";
        }

        public int ConsecAbono()
        {
            int consec = 0;
            string cedis = "BODEGA";
            string query = "";
            if (cedis.Equals(CB_sucursal.SelectedItem.ToString()))
            {
                query = "SELECT Consec FROM consec WHERE Dato='Abonoprov'";
            }
            else
            {
                query = "SELECT Consec FROM consec WHERE Dato='ABONOPROV'";
            }
            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
        
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consec = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            conexion.Close();

            return consec;
        }

        public int ConsecCompra()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='Compra'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consec += consec = Convert.ToInt32(dr["Consec"].ToString());
            }
            return consec;
        }

        public int ConsecCuenxpag()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='cuenxpag'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de cuenxpag " + ex);
            }



            return consec;

        }



        public void GuardarPagoAcreedor(MySqlConnection con)
        {
            int abono = ConsecAbono();
            int cuenxpag = ConsecCuenxpag();
            int compra = ConsecCompra();
            DateTime fecha = dtGastos.Value;
            //REGISTRA UNA COMPRA EN LA TABLA CUENXPAG
            try
            {
                //cuenxpag++;
                MySqlCommand cuenpag = new MySqlCommand("INSERT INTO cuenxpag(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,FECHA_VENC,FACTURA,IMPORTE,MONEDA,SALDO,TIP_CAM,COMPRA,ESTADO,OBSERV,CONTAB,USUARIO,USUFECHA,USUHORA,ORDEN,NPAGO)" +
     "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?FECHA_VENC,?FACTURA,?IMPORTE,?MONEDA,?SALDO,?TIP_CAM,?COMPRA,?ESTADO,?OBSERV,?CONTAB,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?NPAGO)",con);
                cuenpag.Parameters.AddWithValue("?CUENXPAG", cuenxpag);
                cuenpag.Parameters.AddWithValue("?PROVEEDOR", "000001");
                cuenpag.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                cuenpag.Parameters.AddWithValue("?TIPO_DOC", "COM");
                cuenpag.Parameters.AddWithValue("?NO_REFEREN", tbObservaciones.Text);
                cuenpag.Parameters.AddWithValue("?FECHA_VENC", fecha.ToString("yyyy-MM-dd"));
                cuenpag.Parameters.AddWithValue("?FACTURA", tbObservaciones.Text);
                cuenpag.Parameters.AddWithValue("?IMPORTE", tbImporte.Text);
                cuenpag.Parameters.AddWithValue("?MONEDA", "MN");
                cuenpag.Parameters.AddWithValue("?SALDO", tbImporte.Text);
                cuenpag.Parameters.AddWithValue("?TIP_CAM", "");
                cuenpag.Parameters.AddWithValue("?COMPRA", compra);
                cuenpag.Parameters.AddWithValue("?ESTADO", "P");
                cuenpag.Parameters.AddWithValue("?OBSERV", "");
                cuenpag.Parameters.AddWithValue("?CONTAB", "");
                cuenpag.Parameters.AddWithValue("?USUARIO", usuario);
                cuenpag.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                cuenpag.Parameters.AddWithValue("?USUHORA", fecha.Hour);
                cuenpag.Parameters.AddWithValue("?ORDEN", "");
                cuenpag.Parameters.AddWithValue("?NPAGO", "");
                cuenpag.ExecuteNonQuery();

               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al insertar los registros  en la tabla cuenxpag"+ex);
            }



            try
            {
                abono++;
                //INTRODUCE REGISTROS EN LA TABLA PAGOS
                MySqlCommand cmd = new MySqlCommand("INSERT INTO pagos(Abono,Proveedor, tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                               "VALUES(?Abono,?Proveedor,?tipo_doc,?No_referen,?Importe,?Moneda,?TC,ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)", con);
                cmd.Parameters.AddWithValue("?Abono", abono);
                cmd.Parameters.AddWithValue("?Proveedor", "000001");
                cmd.Parameters.AddWithValue("?tipo_doc", "EFE");
                cmd.Parameters.AddWithValue("?No_referen", tbObservaciones.Text);
                cmd.Parameters.AddWithValue("?Importe", tbImporte.Text);
                cmd.Parameters.AddWithValue("?Moneda", "MN");
                cmd.Parameters.AddWithValue("?TC", "1");
                cmd.Parameters.AddWithValue("?ImportBase", "");
                cmd.Parameters.AddWithValue("?Cobrar", "0");
                cmd.Parameters.AddWithValue("?Banco", "");
                cmd.Parameters.AddWithValue("?Fecha_dep", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?Autorizado", "0");
                cmd.Parameters.AddWithValue("?Por_apli", "0");
                cmd.Parameters.AddWithValue("?Aplicado", "0");
                cmd.Parameters.AddWithValue("?Observ", "");
                cmd.Parameters.AddWithValue("?Concepto", "PROV");
                cmd.Parameters.AddWithValue("?Usuario", usuario);
                cmd.Parameters.AddWithValue("?UsuFecha", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?UsuHora", fecha.ToString("HH:mm:ss"));
                cmd.ExecuteNonQuery();

                //actualizar consecutivo de pagos
                
                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + abono + " WHERE Dato='ABONOPROV' OR Dato='Abonoprov'", con);
                actualizaIDabono.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al insertar los registros en la tabla pagos"+ex);
            }

            //INSERTAR EL REGISTRO DEL PAGO EN LA TABLA CUENXPDET
            MySqlCommand cuenxpdet = new MySqlCommand("INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza) " +
                "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)", con);
            cuenxpdet.Parameters.AddWithValue("?CUENXPAG", cuenxpag);
            cuenxpdet.Parameters.AddWithValue("?PROVEEDOR", "000001");
            cuenxpdet.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            cuenxpdet.Parameters.AddWithValue("?TIPO_DOC", "COM");
            cuenxpdet.Parameters.AddWithValue("?NO_REFEREN", tbObservaciones.Text);
            cuenxpdet.Parameters.AddWithValue("?Cargo_ab", "C");
            cuenxpdet.Parameters.AddWithValue("?IMPORTE", tbImporte.Text);
            cuenxpdet.Parameters.AddWithValue("?MONEDA", "MN");
            cuenxpdet.Parameters.AddWithValue("?TIP_CAM", "1");
            cuenxpdet.Parameters.AddWithValue("?COMPRA",compra);
            cuenxpdet.Parameters.AddWithValue("?COBRADOR", "");
            cuenxpdet.Parameters.AddWithValue("?OBSERV", "");
            cuenxpdet.Parameters.AddWithValue("?CONTAB", "");
            cuenxpdet.Parameters.AddWithValue("?ABONO", "");
            cuenxpdet.Parameters.AddWithValue("?USUARIO", usuario);
            cuenxpdet.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            cuenxpdet.Parameters.AddWithValue("?USUHORA", fecha.Hour.ToString("HH:mm:ss"));
            cuenxpdet.Parameters.AddWithValue("?ORDEN", "0");
            cuenxpdet.Parameters.AddWithValue("?poliza", "");
            cuenxpdet.ExecuteNonQuery();

          
            //actualizar el consecutivo de cuenxpag
            MySqlCommand cmdc4 = new MySqlCommand("UPDATE consec SET Consec='" + cuenxpag + "' WHERE Dato='cuenxpag'", con);
            cmdc4.ExecuteNonQuery();

            //ACTUALIZAR COMPRA
            MySqlCommand cmdc5 = new MySqlCommand("UPDATE consec SET Consec='" + compra + "' WHERE Dato='Compra'", con);
            cmdc5.ExecuteNonQuery();
        }

        public void guardaDatos()
        {
            string comando;
            long idInsertado;
            DateTime fecha = dtGastos.Value;
            DateTime fecha_creacion = DateTime.Now;
            //MessageBox.Show(fecha.ToString("yyyy-MM-dd"));
            try
            {

                comando = "INSERT INTO rd_gastos_externos_pagos (fecha,hora,importe,id_gasto_externo,nombre_gasto,concepto_gral,tipo_gasto,usuario,fecha_creacion,observacion) values (?fecha,?hora,?importe,?id_gasto_externo,?nombre_gasto,?concepto_gral,?tipo_gasto,?usuario,?fecha_creacion,?observ)";
               
                

                MySqlCommand cmd = new MySqlCommand(comando, con);
                cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?hora", MySqlDbType.VarChar).Value = "";
                cmd.Parameters.Add("?importe", MySqlDbType.VarChar).Value = tbImporte.Text;
                cmd.Parameters.Add("?id_gasto_externo", MySqlDbType.VarChar).Value = idGastoExterno;
                cmd.Parameters.Add("?nombre_gasto", MySqlDbType.VarChar).Value = cbGastos.Text;
                cmd.Parameters.Add("?concepto_gral", MySqlDbType.VarChar).Value = CB_concepto_gral.SelectedItem.ToString();
                cmd.Parameters.Add("?tipo_gasto", MySqlDbType.VarChar).Value = tipo_gasto;
                cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("?fecha_creacion", MySqlDbType.VarChar).Value = fecha_creacion.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?observ", MySqlDbType.VarChar).Value = tbObservaciones.Text;


                
                cmd.ExecuteNonQuery();
                idInsertado = cmd.LastInsertedId;

                guardaDatosSaldoBancos(idInsertado);

                //tbImporte.Text = "";
                //tbObservaciones.Text = "";
                ////cbGastos.Text = "";
                ////CB_bancosOsmart.Text = "";
                //CB_sucursal.SelectedIndex = -1;
                //CB_cuentasOsmart.Text = "";
                //CB_pagara.Text = "";
                //TB_saldobanco.Text = "";

                MessageBox.Show("Datos gregados con exito: " + idInsertado);
                
            }
            catch(Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }


           
        }

        public void guardaDatosSaldoBancos(long consecutivo)
        {

            DateTime fecha = dtGastos.Value;
            DateTime fecha_creacion = DateTime.Now;
           

            MySqlConnection conx;
            conx = BDConexicon.BodegaOpen();
            string comando,comando2;

            comando = "INSERT INTO rd_historial_saldobancos (tienda,mov,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ie,ref_gastoexterno,suc_pago) values (?tienda,?mov,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ie,?ref_gastoexterno,?suc_pago)";
            comando2 = "INSERT INTO rd_historial_saldobancos (tienda,mov,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ie,ref_gastoexterno) values (?tienda,?mov,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ie,?ref_gastoexterno)";

            if (CB_bancosOsmart.SelectedItem.ToString().Equals("CAJA GENERAL") || CB_bancosOsmart.SelectedItem.ToString().Equals("FINANZAS") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS"))
            {
                MySqlCommand cmd = new MySqlCommand(comando, conx);
                cmd.Parameters.Add("?tienda", MySqlDbType.VarChar).Value = cbTienda.Text;
                cmd.Parameters.Add("?mov", MySqlDbType.VarChar).Value = "GE";
                cmd.Parameters.Add("?banco", MySqlDbType.VarChar).Value = CB_bancosOsmart.Text;
                cmd.Parameters.Add("?cuenta", MySqlDbType.VarChar).Value = CB_cuentasOsmart.Text;
                cmd.Parameters.Add("?pagara", MySqlDbType.VarChar).Value = cbGastos.Text;
                cmd.Parameters.Add("?cantidad", MySqlDbType.VarChar).Value = tbImporte.Text;
                cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?hora", MySqlDbType.VarChar).Value = fecha_creacion.ToString("HH:mm");
                cmd.Parameters.Add("?fk_gastoexterno", MySqlDbType.VarChar).Value = consecutivo;
                cmd.Parameters.Add("?ie", MySqlDbType.VarChar).Value = "E";
                cmd.Parameters.AddWithValue("?ref_gastoexterno", tbObservaciones.Text);
                cmd.Parameters.AddWithValue("?suc_pago", CB_sucursal.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand(comando2, conx);
                cmd.Parameters.Add("?tienda", MySqlDbType.VarChar).Value = cbTienda.Text;
                cmd.Parameters.Add("?mov", MySqlDbType.VarChar).Value = "GE";
                cmd.Parameters.Add("?banco", MySqlDbType.VarChar).Value = CB_bancosOsmart.Text;
                cmd.Parameters.Add("?cuenta", MySqlDbType.VarChar).Value = CB_cuentasOsmart.Text;
                cmd.Parameters.Add("?pagara", MySqlDbType.VarChar).Value = cbGastos.Text;
                cmd.Parameters.Add("?cantidad", MySqlDbType.VarChar).Value = tbImporte.Text;
                cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?hora", MySqlDbType.VarChar).Value = fecha_creacion.ToString("HH:mm");
                cmd.Parameters.Add("?fk_gastoexterno", MySqlDbType.VarChar).Value = consecutivo;
                cmd.Parameters.Add("?ie", MySqlDbType.VarChar).Value = "E";
                cmd.Parameters.AddWithValue("?ref_gastoexterno", tbObservaciones.Text);
                cmd.ExecuteNonQuery();

            }

           

           
           



          

            conx.Close();
        }

        public void SaldoCuentaBancaria()
        {

            string banco = "ACREEDOR";


            double sumar = 0, restar = 0;
            //SI EL BANCO ES ACREEDOR BUSCA EL SALDO DEL ACREEDOR EN LA SUCURSAL SELECCIONADA
            if (banco.Equals(CB_bancosOsmart.SelectedItem.ToString()))
            {

                //MySqlConnection conexion = Conexion(CB_sucursal.SelectedItem.ToString());
                //string query = "SELECT Cargo_ab,importe FROM cuenxpdet WHERE PROVEEDOR='000001'";
                //MySqlCommand saldoAcr = new MySqlCommand(query, conexion);
                //MySqlDataReader read = saldoAcr.ExecuteReader();
                //while (read.Read())
                //{

                //    if (read["Cargo_ab"].ToString().Equals("C"))
                //    {
                //        sumar += Convert.ToDouble(read["importe"].ToString());
                //    }

                //    if (read["Cargo_ab"].ToString().Equals("A"))
                //    {
                //        restar += Convert.ToDouble(read["importe"].ToString());
                //    }
                //}
                //read.Close();
            }
            else
            {
                MySqlConnection con = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand("SELECT mov,ie,cantidad FROM rd_historial_saldobancos WHERE banco ='" + CB_bancosOsmart.SelectedItem.ToString() + "' and cuenta='" + CB_cuentasOsmart.SelectedItem.ToString() + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr["ie"].ToString().Equals("I"))
                    {
                        sumar += Convert.ToDouble(dr["cantidad"].ToString());
                    }

                    if (dr["ie"].ToString().Equals("E"))
                    {
                        restar += Convert.ToDouble(dr["cantidad"].ToString());
                    }


                }
                dr.Close();
                con.Close();
            }
           
            


            double saldo = sumar - restar;
            TB_saldobanco.Text = String.Format("{0:0.##}", saldo.ToString("C"));
          
           
        }

        private void cbTienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_bancosOsmart.Items.Clear();
            CB_bancosOsmart.Items.Add("");
            CB_bancosOsmart.SelectedIndex = 0;

            CB_cuentasOsmart.Items.Clear();
            CB_cuentasOsmart.Items.Add("");
            CB_cuentasOsmart.SelectedIndex = 0;

           
            CB_pagara.Items.Clear();
            CB_pagara.Items.Add("");
            CB_pagara.SelectedIndex = 0;
            CB_sucursal.SelectedIndex = -1;


            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT distinct banco FROM rd_bancos_osmart WHERE tienda='" + cbTienda.SelectedItem.ToString() + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_bancosOsmart.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void CB_bancosOsmart_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_cuentasOsmart.Items.Clear();

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT distinct cuenta FROM rd_bancos_osmart WHERE banco='" + CB_bancosOsmart.SelectedItem.ToString() + "' and tienda='" + cbTienda.SelectedItem.ToString() + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_cuentasOsmart.Items.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            con.Close();

            if (CB_bancosOsmart.SelectedItem.ToString().Equals("FINANZAS")|| CB_bancosOsmart.SelectedItem.ToString().Equals("CAJA GENERAL")|| CB_bancosOsmart.SelectedItem.ToString().Equals("ACREEDORES DIVERSOS") || CB_bancosOsmart.SelectedItem.ToString().Equals("FUNDACION ALBERGUE") || CB_bancosOsmart.SelectedItem.ToString().Equals("ACREEDOR") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS CEDIS") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS INOCENCIO") || CB_bancosOsmart.SelectedItem.ToString().Equals("COMPRAS CDMX"))
            {
                LBSucursal.Enabled = true;
                CB_sucursal.Enabled = true;
            }
            else
            {
                LBSucursal.Enabled =false;
                CB_sucursal.Enabled = false;
            }
        }

        private void CB_cuentasOsmart_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            if (CB_cuentasOsmart.Equals("ACREEDOR"))
            {

                MySqlCommand cmd = new MySqlCommand("SELECT clientebancario FROM rd_bancos_osmart WHERE banco='" + CB_sucursal.SelectedItem.ToString() + "' and cuenta='" + CB_cuentasOsmart.SelectedItem.ToString() + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_pagara.Items.Add(dr["clientebancario"].ToString());
                }
                dr.Close();
                con.Close();

            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("SELECT clientebancario FROM rd_bancos_osmart WHERE banco='" + CB_bancosOsmart.SelectedItem.ToString() + "' and cuenta='" + CB_cuentasOsmart.SelectedItem.ToString() + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_pagara.Items.Add(dr["clientebancario"].ToString());
                }
                dr.Close();
                con.Close();
            }

            SaldoCuentaBancaria();
        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_cuentasOsmart.SelectedItem.ToString().Equals("ACREEDOR"))
                {
                    MySqlConnection conexion = BDConexicon.BodegaOpen();
                    MySqlConnection con = Conexion(CB_sucursal.SelectedItem.ToString());
                    MySqlCommand cmd = new MySqlCommand("SELECT clientebancario FROM rd_bancos_osmart WHERE banco='" + CB_sucursal.SelectedItem.ToString() + "' and cuenta='" + CB_cuentasOsmart.SelectedItem.ToString() + "'", conexion);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CB_pagara.Items.Add(dr["clientebancario"].ToString());
                    }
                    dr.Close();

                    //    SaldoCuentaBancaria();

                    double sumar = 0, restar = 0;

                    string query = "SELECT Cargo_ab,importe FROM cuenxpdet WHERE PROVEEDOR='000001'";
                    MySqlCommand saldoAcr = new MySqlCommand(query, con);
                    MySqlDataReader read = saldoAcr.ExecuteReader();
                    while (read.Read())
                    {

                        if (read["Cargo_ab"].ToString().Equals("C"))
                        {
                            sumar += Convert.ToDouble(read["importe"].ToString());
                        }

                        if (read["Cargo_ab"].ToString().Equals("A"))
                        {
                            restar += Convert.ToDouble(read["importe"].ToString());
                        }
                    }
                    read.Close();
                    con.Close();

                    double saldo = sumar - restar;
                    TB_saldobanco.Text = String.Format("{0:0.##}", saldo.ToString("C"));
                }
                else
                {

                }
            }

            catch (Exception ex)

            {

               
            }
        }

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            tipo_gasto = "TIENDA";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }
        }

        private void RB_general_CheckedChanged(object sender, EventArgs e)
        {

            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            tipo_gasto = "GENERAL";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }
        }

        private void CB_concepto_gral_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            List<GastoExterno> lista = GastoExternoController.ConceptosDetalle(CB_concepto_gral.SelectedItem.ToString(),tipo_gasto);

            foreach (var item in lista)
            {
                cbGastos.Items.Add(item.Nombre_Gasto);



            }
            //cbGastos.ValueMember = "ID";
            //cbGastos.DisplayMember = "CONCEPTO";
            //cbGastos.DataSource = lista;

        }

        private void BT_modificar_Click(object sender, EventArgs e)
        {
            ModificarGastoExternoPago modificar = new ModificarGastoExternoPago();
            modificar.Show();
        }
    }
}
