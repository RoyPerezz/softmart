using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class Abonos : Form
    {


        //VARIABLES GLOBALES
#pragma warning disable CS0414 // El campo 'Abonos.mes' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Abonos.año' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Abonos.dia' está asignado pero su valor nunca se usa
        int dia = 0, mes = 0, año = 0;
#pragma warning restore CS0414 // El campo 'Abonos.dia' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'Abonos.año' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'Abonos.mes' está asignado pero su valor nunca se usa
        string usuario = "";
        string tienda = "";
#pragma warning disable CS0414 // El campo 'Abonos.efePRE' está asignado pero su valor nunca se usa
        double efeVA = 0, efeRE = 0, efeCO = 0, efeVE = 0, efePRE = 0,saldo=0;
#pragma warning restore CS0414 // El campo 'Abonos.efePRE' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Abonos.compra' está asignado pero su valor nunca se usa
        string compra = "", proveedor = "", nombre = "";
#pragma warning restore CS0414 // El campo 'Abonos.compra' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Abonos.cont' está asignado pero su valor nunca se usa
        int cont = 0;
#pragma warning restore CS0414 // El campo 'Abonos.cont' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Abonos.mensaje' está asignado pero su valor nunca se usa
        string mensaje = "";
#pragma warning restore CS0414 // El campo 'Abonos.mensaje' está asignado pero su valor nunca se usa
        DataTable DTBodega = new DataTable();
        DataTable DTVallarta = new DataTable();
        DataTable DTRena = new DataTable();
        DataTable DTColoso = new DataTable();
        DataTable DTVelazquez = new DataTable();
        DataTable DTPregot = new DataTable();
        DataTable maestro = new DataTable();
        int va = 0, re = 0, ve = 0, co = 0, pre = 0;


        public Abonos(string proveedor, string nombre, double saldo,string usuario,int va,int re,int ve,int co)
        {
            InitializeComponent();
            this.proveedor = proveedor;
            this.nombre = nombre;
            this.saldo = saldo;
            this.usuario = usuario;
            this.va = va;
            this.re = re;
            this.ve = ve;
            this.co = co;
          
            estadoChecks(va, re, ve, co);
        }

        public void Bancos()
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            CB_banco.Items.Add("");
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT distinct banco FROM rd_cuentas_bancarias WHERE fk_proveedor='" + TB_proveedor.Text + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                CB_banco.Items.Add("");
                CB_banco.Items.Add("EFECTIVO");
                while (dr.Read())
                {
                    CB_banco.Items.Add(dr["banco"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR BANCOS +" + ex);

            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            CB_banco_osmart.Enabled = false;
            CB_cuenta_osmart.Enabled = false;
            TB_saldocuenta.Enabled = false;
            TB_anombrede.Enabled = false;

            //CB_banco_osmart.SelectedIndex = 0;
            //CB_cuenta_osmart.SelectedIndex = 0;
            //TB_saldocuenta.Text = "";
            //TB_anombrede.Text = "";
                
            if (CB_tipodoc.SelectedItem.ToString().Equals("EFECTIVO"))
            {
                TB_cod.Text = "EFE";
                CB_banco.Enabled = true;
                CB_cuenta.Enabled = true;
                CB_persona.Enabled = true;
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("DEVOLUCION"))
            {
                TB_cod.Text = "DEV";
                
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("AJUSTES"))
            {
                TB_cod.Text = "AJ";

            }


            if (CB_tipodoc.SelectedItem.ToString().Equals("SPEI"))
            {
                TB_cod.Text = "SPEI";
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("DESCUENTO"))
            {
                TB_cod.Text = "DESC";
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("DEPOSITO/EFECTIVO"))
            {
                TB_cod.Text = "DEPEFE";
                CB_banco.Enabled = true;
                CB_cuenta.Enabled = true;
                CB_persona.Enabled = true;
            }

            if (CB_tipodoc.SelectedItem.ToString().Equals("ACREEDOR"))
            {
                TB_cod.Text = "ACR";
                CB_banco.Enabled = true;
                CB_cuenta.Enabled = true;
                CB_persona.Enabled = true;
            }


            if (CB_tipodoc.SelectedIndex == 0)
            {
                TB_cod.Text = "";
            }



            if (TB_cod.Text.Equals("SPEI"))
            {
                CB_banco_osmart.Enabled = true;
                CB_cuenta_osmart.Enabled = true;
                TB_saldocuenta.Enabled = true;
                TB_anombrede.Enabled = true;
                CB_sucBanco.Enabled = true;
                CB_banco.SelectedIndex = 2;
                CB_cuenta.SelectedItem = "EFECTIVO";
                //CB_persona.SelectedItem = "EFECTIVO";
                CB_persona.SelectedIndex = 1;
                CB_banco.Enabled = false;
                CB_cuenta.Enabled = false;
                CB_persona.Enabled = false;

            }
            else
            {
                CB_banco_osmart.Enabled = false;
                CB_cuenta_osmart.Enabled =false;
                TB_saldocuenta.Enabled = false;
                TB_anombrede.Enabled = false;
                CB_sucBanco.Enabled = false;

                CB_sucBanco.SelectedIndex = 0;
                CB_banco_osmart.SelectedIndex = 0;
                CB_cuenta_osmart.SelectedIndex = 0;
                TB_saldocuenta.Text = "";
                TB_anombrede.Text = "";
            }

            if (TB_cod.Text.Equals("DESC") || TB_cod.Text.Equals("DEV"))
            {
                //CB_banco.SelectedIndex = 2;
                //CB_cuenta.Items.Add("");
                //CB_cuenta.Items.Add("EFECTIVO");
                //CB_persona.Items.Add("");
                //CB_persona.Items.Add("EFECTIVO");
                //CB_cuenta.SelectedIndex = 1;
                //CB_persona.SelectedIndex = 1;

                CB_banco.Enabled = false;
                CB_cuenta.Enabled = false;
                CB_persona.Enabled = false;
            }
        }


        public MySqlConnection ElegirSucursal()
        {
            MySqlConnection con = null;
            tienda = CB_sucursal.SelectedItem.ToString();
            if (tienda.Equals("BODEGA"))
            {
                con = BDConexicon.BodegaOpen();
            }
            if (tienda.Equals("VALLARTA"))
            {
                con = BDConexicon.VallartaOpen();
            }
            if (tienda.Equals("RENA"))
            {
                con = BDConexicon.RenaOpen();
            }

            if (tienda.Equals("COLOSO"))
            {
                con = BDConexicon.ColosoOpen();
            }

            if (tienda.Equals("VELAZQUEZ"))
            {
                con = BDConexicon.VelazquezOpen();
            }

            //if (tienda.Equals("PREGOT"))
            //{
            //    con = BDConexicon.Papeleria1Open();
            //}

            return con;
        }



        //OBTENER CONSECUTIVO DE ABONOS
        public int ConsecAbonos()
        {
            int consec = 1;
            MySqlConnection con = ElegirSucursal();
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='ABONOPROV'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de Abonos " + ex);
            }



            return consec;

        }



        //OBTENER CONSECUTIVO DE CUENXPAG
        public int ConsecCuenxpag()
        {
            int consec = 1;
            MySqlConnection con = ElegirSucursal();
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



        //OBTENER CONSECUTIVO  DE FLUJO
        public int ConsecFLujo(string sucursal)
        {
            int consec = 1;
            MySqlConnection con = null;

            if (CHK_respaldo.Checked==true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);


                try
                {
                    if (sucursal.Equals("VALLARTA"))
                    {
                        con = BDConexicon.RespaldoVA(mesRespaldo,año);
                    }

                    if (sucursal.Equals("RENA"))
                    {
                        con = BDConexicon.RespaldoRE(mesRespaldo,año);
                    }
                    if (sucursal.Equals("COLOSO"))
                    {
                        con = BDConexicon.RespaldoCO(mesRespaldo,año);
                    }

                    if (sucursal.Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.RespaldoVE(mesRespaldo,año);
                    }

                    //if (sucursal.Equals("PREGOT"))
                    //{
                    //    con = BDConexicon.RespaldoPRE(mesRespaldo,año);
                    //}

                    MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='flujo'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al traer consecutivo de Abonos " + ex);
                }
            }
            else
            {
                try
                {
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

                    //if (sucursal.Equals("PREGOT"))
                    //{
                    //    con = BDConexicon.Papeleria1Open();
                    //}

                    MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='flujo'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al traer consecutivo de Abonos " + ex);
                }
            }

           


            return consec;
        }

        //OBTENER CONSECUTIVO COMPRA
        public int ConsecCompra()
        {
            int consec = 1;
            MySqlConnection con = ElegirSucursal();
            MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='Compra'",con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consec +=consec= Convert.ToInt32(dr["Consec"].ToString());
            }
            return consec;
        }

    
        public int ConsecAbono()
        {
            int consec = 0;
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT Consec FROM consec WHERE Dato='consecAbono'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consec = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            conexion.Close();

            return consec;
        }

        //REALIZA EL ABONO A LA COMPRA E INSERTA LOS REGISTROS EN LAS RESPECTIVAS BD
        public void AplicarPago()
        {

            MySqlConnection con = ElegirSucursal();//elige la sucursal de la compra que se eligio abonar
            int consec = ConsecAbonos();//obtiene el consecutivo del abono
            DateTime fecha = DT_fecha.Value;
            DateTime hora = Convert.ToDateTime(DateTime.Now.ToString("h:mm:ss"));
            DateTime fechActual = DateTime.Now;
            decimal digito = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string abono = digito.ToString("G0");
            string idAbono = Convert.ToString(ConsecAbono());
           
            DateTime fecha2 = DateTime.Now;

            if (CB_tipodoc.SelectedItem.ToString().Equals("SPEI"))//PAGO CON SPEI
            {
                try
                {
                    MySqlConnection bo = BDConexicon.BodegaOpen();
                    double cantidad = Convert.ToDouble(abono);
                   
                    MySqlCommand spei = new MySqlCommand("INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora) VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora) ", bo);
                    spei.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    spei.Parameters.AddWithValue("?mov", "SPEI");
                    spei.Parameters.AddWithValue("?ie", "E");
                    spei.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                    spei.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                    spei.Parameters.AddWithValue("?pagara", CB_persona.SelectedItem.ToString());
                    spei.Parameters.AddWithValue("?cantidad", cantidad);
                    spei.Parameters.AddWithValue("?fecha", fecha2.ToString("yyyy-MM-dd"));
                    spei.Parameters.AddWithValue("?hora", fecha2.ToString("HH:mm:ss"));
                    spei.ExecuteNonQuery();
                    bo.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("[SPEI] Error al insertar registro en tabla rd_historial_saldobancos: "+ex);
                }
                //INSERTAR EL ABONO EN LA TABLA PAGOS
                try
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO pagos(Abono,Proveedor, tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                   "VALUES(?Abono,?Proveedor,?tipo_doc,?No_referen,?Importe,?Moneda,?TC,ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)", con);
                    cmd.Parameters.AddWithValue("?Abono", consec);
                    cmd.Parameters.AddWithValue("?Proveedor", TB_proveedor.Text);
                    cmd.Parameters.AddWithValue("?tipo_doc", TB_cod.Text);
                    cmd.Parameters.AddWithValue("?No_referen", TB_referencia.Text);
                    cmd.Parameters.AddWithValue("?Importe", abono);
                    cmd.Parameters.AddWithValue("?Moneda", "MN");
                    cmd.Parameters.AddWithValue("?TC", "1");
                    cmd.Parameters.AddWithValue("?ImportBase", abono);
                    cmd.Parameters.AddWithValue("?Cobrar", "");
                    cmd.Parameters.AddWithValue("?Banco", "");
                    cmd.Parameters.AddWithValue("?Fecha_dep", fechActual.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?Autorizado", "0");
                    cmd.Parameters.AddWithValue("?Por_apli", "0");
                    cmd.Parameters.AddWithValue("?Aplicado", "0");
                    cmd.Parameters.AddWithValue("?Observ", "");
                    cmd.Parameters.AddWithValue("?Concepto", "PROV");
                    cmd.Parameters.AddWithValue("?Usuario", usuario);
                    cmd.Parameters.AddWithValue("?UsuFecha", fechActual.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?UsuHora", fechActual.ToString("HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("[SPEI]  Error al insertar registro en tabla pagos: "+ex);
                }


                try
                {
                    //INSERTAR EL REGISTRO DEL PAGO EN LA TABLA CUENXPDET
                    MySqlCommand cuenxpdet = new MySqlCommand("INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza) " +
                        "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)", con);
                    cuenxpdet.Parameters.AddWithValue("?CUENXPAG", TB_cxp.Text);
                    cuenxpdet.Parameters.AddWithValue("?PROVEEDOR", TB_proveedor.Text);
                    cuenxpdet.Parameters.AddWithValue("?FECHA", fechActual.ToString("yyyy-MM-dd"));
                    cuenxpdet.Parameters.AddWithValue("?TIPO_DOC", CB_tipodoc.SelectedItem.ToString());
                    cuenxpdet.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
                    cuenxpdet.Parameters.AddWithValue("?Cargo_ab", "A");
                    cuenxpdet.Parameters.AddWithValue("?IMPORTE", abono);
                    cuenxpdet.Parameters.AddWithValue("?MONEDA", "MN");
                    cuenxpdet.Parameters.AddWithValue("?TIP_CAM", "1");
                    cuenxpdet.Parameters.AddWithValue("?COMPRA", CB_cxpag.SelectedItem.ToString());
                    cuenxpdet.Parameters.AddWithValue("?COBRADOR", "");
                    cuenxpdet.Parameters.AddWithValue("?OBSERV", idAbono);
                    cuenxpdet.Parameters.AddWithValue("?CONTAB", "");
                    cuenxpdet.Parameters.AddWithValue("?ABONO", consec);
                    cuenxpdet.Parameters.AddWithValue("?USUARIO", usuario);
                    cuenxpdet.Parameters.AddWithValue("?USUFECHA", fechActual.ToString("yyyy-MM-dd"));
                    cuenxpdet.Parameters.AddWithValue("?USUHORA", fechActual.ToString("HH:mm:ss"));
                    cuenxpdet.Parameters.AddWithValue("?ORDEN", "0");
                    cuenxpdet.Parameters.AddWithValue("?poliza", "");
                    cuenxpdet.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("[SPEI]  Error al insertar registro en la tabla CUENXPDET: "+ex);  
                }

                try
                {
                    //ACTUALIZAR EL CONSECUTIVO DE LOS ABONOS EN LA TABLA CONSEC
                    MySqlCommand actualizarConsec = new MySqlCommand("UPDATE consec SET Consec ='" + consec + "'" + " where Dato ='ABONOPROV'", con);
                    actualizarConsec.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("[SPEI]  Error al actualizar el consecutivo de ABONOPROV: "+ex);
                }

                try
                {
                    //ACTUALIZAR EL CONSECUTIVO DE IDABONO
                    MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                    desglose.Parameters.AddWithValue("?importe", abono);
                    desglose.Parameters.AddWithValue("?fecha_pago", fechActual.ToString("yyyy-MM-dd"));
                    desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                    desglose.Parameters.AddWithValue("?idabono", idAbono);
                    desglose.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                    desglose.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                    desglose.Parameters.AddWithValue("?clientebancario", TB_anombrede.Text);
                    desglose.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("[SPEI]   Error al insertar registro en la tabla rd_desglose_abonos: "+ex);
                }


 //-------------- //actualizar consecutivo id abono para desglose abono
                try
                {
                    int id = Convert.ToInt32(idAbono);
                    id++;
                    MySqlConnection bodega = BDConexicon.BodegaOpen();
                    MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                    actualizaIDabono.ExecuteNonQuery();
                    bodega.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("[SPEI] Error al actualizar el consecutivo de consecAbono de tabla consec: "+ex);
                }
                try
                {

                    //OBTENGO EL SALDO DE LA COMPRA
                    double saldo = 0;
                    MySqlCommand saldoCompra = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE COMPRA='" + CB_cxpag.SelectedItem.ToString() + "'", con);
                    MySqlDataReader salCompra = saldoCompra.ExecuteReader();
                    while (salCompra.Read())
                    {
                        saldo = Convert.ToDouble(salCompra["SALDO"].ToString());
                    }
                    salCompra.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("[SPEI]  Error al traer el saldo de la compra: "+ex);
                }

                try
                {
                    double pago = Convert.ToDouble(abono);
                    double nuevoSaldo = saldo - pago;

                    //AFECTAR EL SALDO DE LA COMPRA (RESTARLE EL ABONO QUE SE APLICÓ)
                    MySqlCommand pagar = new MySqlCommand("UPDATE cuenxpag SET SALDO ='" + nuevoSaldo + "' WHERE COMPRA='" + CB_cxpag.SelectedItem.ToString() + "' and proveedor='" + TB_proveedor.Text + "'", con);
                    pagar.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("[SPEI] Error al actualizar el saldo de la compra: "+ex);
                }


            }
            else
            {
                if (CB_tipodoc.SelectedItem.ToString().Equals("ACREEDOR"))
                {

                    //SE INSERTA EL MONTO EN CUENXPAG PARA INCREMENTAR EL ADEUDO CON EL ACREEDOR
                    int cuenxpag = ConsecCuenxpag();
                    int compra = ConsecCompra();
                    MySqlCommand acr = new MySqlCommand("INSERT INTO cuenxpag(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,FECHA_VENC,FACTURA,IMPORTE,MONEDA,SALDO,TIP_CAM,COMPRA,ESTADO,OBSERV,CONTAB,USUARIO,USUFECHA,USUHORA,ORDEN,NPAGO)" +
                        "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?FECHA_VENC,?FACTURA,?IMPORTE,?MONEDA,?SALDO,?TIP_CAM,?COMPRA,?ESTADO,?OBSERV,?CONTAB,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?NPAGO)",con);
                    acr.Parameters.AddWithValue("?CUENXPAG",cuenxpag);
                    acr.Parameters.AddWithValue("?PROVEEDOR","000001");//000001 ES EL CODIGO/CLAVE DEL ACREEDOR
                    acr.Parameters.AddWithValue("?FECHA", fechActual.ToString("yyyy-MM-dd"));
                    acr.Parameters.AddWithValue("?TIPO_DOC", "COM");
                    acr.Parameters.AddWithValue("?NO_REFEREN",0);
                    acr.Parameters.AddWithValue("?FECHA_VENC", fechActual.ToString("yyyy-MM-dd"));
                    acr.Parameters.AddWithValue("?FACTURA", TB_referencia.Text);
                    acr.Parameters.AddWithValue("?IMPORTE",abono);
                    acr.Parameters.AddWithValue("?MONEDA","MN");
                    acr.Parameters.AddWithValue("?SALDO", TB_abono.Text);
                    acr.Parameters.AddWithValue("?TIP_CAM", 1);
                    acr.Parameters.AddWithValue("?COMPRA",compra);
                    acr.Parameters.AddWithValue("?ESTADO","P");
                    acr.Parameters.AddWithValue("?OBSERV","");
                    acr.Parameters.AddWithValue("?CONTAB",0);
                    acr.Parameters.AddWithValue("?USUARIO", usuario);
                    acr.Parameters.AddWithValue("?USUFECHA", fechActual.ToString("yyyy-MM-dd"));
                    acr.Parameters.AddWithValue("?USUHORA", fechActual.ToString("HH:mm:ss"));
                    acr.Parameters.AddWithValue("?ORDEN",0);
                    acr.Parameters.AddWithValue("?NPAGO",0);
                    acr.ExecuteNonQuery();

                    //ACTUALIZAR EL CONSECUTIVO DE CUENXPAG EN LA TABLA CONSEC
                    MySqlCommand consecCxp = new MySqlCommand("UPDATE consec SET Consec ='" + cuenxpag + "'" + " where Dato ='cuenxpag'", con);
                    consecCxp.ExecuteNonQuery();

                    //ACTUALIZA EL CONSECUTIVO DE COMPRA
                    MySqlCommand consecCompra = new MySqlCommand("UPDATE consec SET Consec ='" + compra + "'" + " where Dato ='Compra'", con);
                    consecCompra.ExecuteNonQuery();

                    //INSERTAR EL REGISTRO DEL PAGO EN LA TABLA CUENXPDET DEL ACREEDOR
                    MySqlCommand cpdetacreedor = new MySqlCommand("INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza) " +
                        "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)", con);
                    cpdetacreedor.Parameters.AddWithValue("?CUENXPAG", cuenxpag);
                    cpdetacreedor.Parameters.AddWithValue("?PROVEEDOR", "000001");
                    cpdetacreedor.Parameters.AddWithValue("?FECHA", fechActual.ToString("yyyy-MM-dd"));
                    cpdetacreedor.Parameters.AddWithValue("?TIPO_DOC", "COM");
                    cpdetacreedor.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
                    cpdetacreedor.Parameters.AddWithValue("?Cargo_ab", "C");
                    cpdetacreedor.Parameters.AddWithValue("?IMPORTE", abono);
                    cpdetacreedor.Parameters.AddWithValue("?MONEDA", "MN");
                    cpdetacreedor.Parameters.AddWithValue("?TIP_CAM", "1");
                    cpdetacreedor.Parameters.AddWithValue("?COMPRA", compra);
                    cpdetacreedor.Parameters.AddWithValue("?COBRADOR", "");
                    cpdetacreedor.Parameters.AddWithValue("?OBSERV", "");
                    cpdetacreedor.Parameters.AddWithValue("?CONTAB", "");
                    cpdetacreedor.Parameters.AddWithValue("?ABONO", "");
                    cpdetacreedor.Parameters.AddWithValue("?USUARIO", usuario);
                    cpdetacreedor.Parameters.AddWithValue("?USUFECHA", fechActual.ToString("yyyy-MM-dd"));
                    cpdetacreedor.Parameters.AddWithValue("?USUHORA", fechActual.ToString("HH:mm:ss"));
                    cpdetacreedor.Parameters.AddWithValue("?ORDEN", "0");
                    cpdetacreedor.Parameters.AddWithValue("?poliza", "");
                    cpdetacreedor.ExecuteNonQuery();

              




                    //INSERTAR EL ABONO al EN LA TABLA PAGOS
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO pagos(Abono,Proveedor, tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                        "VALUES(?Abono,?Proveedor,?tipo_doc,?No_referen,?Importe,?Moneda,?TC,ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)", con);
                    cmd.Parameters.AddWithValue("?Abono", consec);
                    cmd.Parameters.AddWithValue("?Proveedor", TB_proveedor.Text);
                    cmd.Parameters.AddWithValue("?tipo_doc", TB_cod.Text);
                    cmd.Parameters.AddWithValue("?No_referen", TB_referencia.Text);
                    cmd.Parameters.AddWithValue("?Importe", abono);
                    cmd.Parameters.AddWithValue("?Moneda", "MN");
                    cmd.Parameters.AddWithValue("?TC", "1");
                    cmd.Parameters.AddWithValue("?ImportBase", abono);
                    cmd.Parameters.AddWithValue("?Cobrar", "");
                    cmd.Parameters.AddWithValue("?Banco", "");
                    cmd.Parameters.AddWithValue("?Fecha_dep", fechActual.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?Autorizado", "0");
                    cmd.Parameters.AddWithValue("?Por_apli", "0");
                    cmd.Parameters.AddWithValue("?Aplicado", "0");
                    cmd.Parameters.AddWithValue("?Observ", "");
                    cmd.Parameters.AddWithValue("?Concepto", "PROV");
                    cmd.Parameters.AddWithValue("?Usuario", usuario);
                    cmd.Parameters.AddWithValue("?UsuFecha", fechActual.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?UsuHora", fechActual.ToString("HH:mm:ss"));
                    cmd.ExecuteNonQuery();


                    //INSERTAR EL REGISTRO DEL PAGO EN LA TABLA CUENXPDET
                    MySqlCommand cuenxpdet = new MySqlCommand("INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza) " +
                        "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)", con);
                    cuenxpdet.Parameters.AddWithValue("?CUENXPAG", TB_cxp.Text);
                    cuenxpdet.Parameters.AddWithValue("?PROVEEDOR", TB_proveedor.Text);
                    cuenxpdet.Parameters.AddWithValue("?FECHA", fechActual.ToString("yyyy-MM-dd"));
                    cuenxpdet.Parameters.AddWithValue("?TIPO_DOC", TB_cod.Text);
                    cuenxpdet.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
                    cuenxpdet.Parameters.AddWithValue("?Cargo_ab", "A");
                    cuenxpdet.Parameters.AddWithValue("?IMPORTE", abono);
                    cuenxpdet.Parameters.AddWithValue("?MONEDA", "MN");
                    cuenxpdet.Parameters.AddWithValue("?TIP_CAM", "1");
                    cuenxpdet.Parameters.AddWithValue("?COMPRA", CB_cxpag.SelectedItem.ToString());
                    cuenxpdet.Parameters.AddWithValue("?COBRADOR", "");
                    cuenxpdet.Parameters.AddWithValue("?OBSERV", idAbono);
                    cuenxpdet.Parameters.AddWithValue("?CONTAB", "");
                    cuenxpdet.Parameters.AddWithValue("?ABONO", consec);
                    cuenxpdet.Parameters.AddWithValue("?USUARIO", usuario);
                    cuenxpdet.Parameters.AddWithValue("?USUFECHA", fechActual.ToString("yyyy-MM-dd"));
                    cuenxpdet.Parameters.AddWithValue("?USUHORA", fechActual.ToString("HH:mm:ss"));
                    cuenxpdet.Parameters.AddWithValue("?ORDEN", "0");
                    cuenxpdet.Parameters.AddWithValue("?poliza", "");
                    cuenxpdet.ExecuteNonQuery();

                    //ACTUALIZAR EL CONSECUTIVO DE LOS ABONOS EN LA TABLA CONSEC
                    MySqlCommand actualizarConsec = new MySqlCommand("UPDATE consec SET Consec ='" + consec + "'" + " where Dato ='ABONOPROV'", con);
                    actualizarConsec.ExecuteNonQuery();

                

                    //OBTENGO EL SALDO DE LA COMPRA
                    double saldo = 0;
                    MySqlCommand saldoCompra = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE COMPRA='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR="+TB_proveedor.Text, con);
                    MySqlDataReader salCompra = saldoCompra.ExecuteReader();
                    while (salCompra.Read())
                    {
                        saldo = Convert.ToDouble(salCompra["SALDO"].ToString());
                    }
                    salCompra.Close();

                    double pago = Convert.ToDouble(abono);
                    double nuevoSaldo = saldo - pago;

                    //AFECTAR EL SALDO DE LA COMPRA (RESTARLE EL ABONO QUE SE APLICÓ)
                    MySqlCommand pagar = new MySqlCommand("UPDATE cuenxpag SET SALDO ='" + nuevoSaldo + "' WHERE COMPRA='" + CB_cxpag.SelectedItem.ToString() + "' and PROVEEDOR='" + TB_proveedor.Text + "'", con);
                    pagar.ExecuteNonQuery();

                }
                else
                {

                    if (CB_tipodoc.SelectedItem.ToString().Equals("DESCUENTO")|| CB_tipodoc.SelectedItem.ToString().Equals("DEVOLUCION") || CB_tipodoc.SelectedItem.ToString().Equals("AJUSTES"))
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO pagos(Abono,Proveedor, tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                           "VALUES(?Abono,?Proveedor,?tipo_doc,?No_referen,?Importe,?Moneda,?TC,ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)", con);
                        cmd.Parameters.AddWithValue("?Abono", consec);
                        cmd.Parameters.AddWithValue("?Proveedor", TB_proveedor.Text);
                        cmd.Parameters.AddWithValue("?tipo_doc", TB_cod.Text);
                        cmd.Parameters.AddWithValue("?No_referen", TB_referencia.Text);
                        cmd.Parameters.AddWithValue("?Importe", abono);
                        cmd.Parameters.AddWithValue("?Moneda", "MN");
                        cmd.Parameters.AddWithValue("?TC", "1");
                        cmd.Parameters.AddWithValue("?ImportBase", abono);
                        cmd.Parameters.AddWithValue("?Cobrar", "");
                        cmd.Parameters.AddWithValue("?Banco", "");
                        cmd.Parameters.AddWithValue("?Fecha_dep", fechActual.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?Autorizado", "0");
                        cmd.Parameters.AddWithValue("?Por_apli", "0");
                        cmd.Parameters.AddWithValue("?Aplicado", "0");
                        cmd.Parameters.AddWithValue("?Observ", "");
                        cmd.Parameters.AddWithValue("?Concepto", "PROV");
                        cmd.Parameters.AddWithValue("?Usuario", usuario);
                        cmd.Parameters.AddWithValue("?UsuFecha", fechActual.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?UsuHora", fechActual.ToString("HH:mm:ss"));
                        cmd.ExecuteNonQuery();


                        //INSERTAR EL REGISTRO DEL PAGO EN LA TABLA CUENXPDET
                        MySqlCommand cuenxpdet = new MySqlCommand("INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza) " +
                            "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)", con);
                        cuenxpdet.Parameters.AddWithValue("?CUENXPAG", TB_cxp.Text);
                        cuenxpdet.Parameters.AddWithValue("?PROVEEDOR", TB_proveedor.Text);
                        cuenxpdet.Parameters.AddWithValue("?FECHA", fechActual.ToString("yyyy-MM-dd"));
                        cuenxpdet.Parameters.AddWithValue("?TIPO_DOC", TB_cod.Text);
                        cuenxpdet.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
                        cuenxpdet.Parameters.AddWithValue("?Cargo_ab", "A");
                        cuenxpdet.Parameters.AddWithValue("?IMPORTE", abono);
                        cuenxpdet.Parameters.AddWithValue("?MONEDA", "MN");
                        cuenxpdet.Parameters.AddWithValue("?TIP_CAM", "1");
                        cuenxpdet.Parameters.AddWithValue("?COMPRA", CB_cxpag.SelectedItem.ToString());
                        cuenxpdet.Parameters.AddWithValue("?COBRADOR", "");
                        cuenxpdet.Parameters.AddWithValue("?OBSERV", "");
                        cuenxpdet.Parameters.AddWithValue("?CONTAB", "");
                        cuenxpdet.Parameters.AddWithValue("?ABONO", consec);
                        cuenxpdet.Parameters.AddWithValue("?USUARIO", usuario);
                        cuenxpdet.Parameters.AddWithValue("?USUFECHA", fechActual.ToString("yyyy-MM-dd"));
                        cuenxpdet.Parameters.AddWithValue("?USUHORA", fechActual.ToString("HH:mm:ss"));
                        cuenxpdet.Parameters.AddWithValue("?ORDEN", "0");
                        cuenxpdet.Parameters.AddWithValue("?poliza", "");
                        cuenxpdet.ExecuteNonQuery();

                        //ACTUALIZAR EL CONSECUTIVO DE LOS ABONOS EN LA TABLA CONSEC
                        MySqlCommand actualizarConsec = new MySqlCommand("UPDATE consec SET Consec ='" + consec + "'" + " where Dato ='ABONOPROV'", con);
                        actualizarConsec.ExecuteNonQuery();

                    

                        //OBTENGO EL SALDO DE LA COMPRA
                        double saldo = 0;
                        MySqlCommand saldoCompra = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE COMPRA='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR='"+TB_proveedor.Text+"'", con);
                        MySqlDataReader salCompra = saldoCompra.ExecuteReader();
                        while (salCompra.Read())
                        {
                            saldo = Convert.ToDouble(salCompra["SALDO"].ToString());
                        }
                        salCompra.Close();

                        double pago = Convert.ToDouble(abono);
                        double nuevoSaldo = saldo - pago;

                        //AFECTAR EL SALDO DE LA COMPRA (RESTARLE EL ABONO QUE SE APLICÓ)
                        MySqlCommand pagar = new MySqlCommand("UPDATE cuenxpag SET SALDO ='" + nuevoSaldo + "' WHERE COMPRA='" + CB_cxpag.SelectedItem.ToString() + "' and PROVEEDOR='" + TB_proveedor.Text + "'", con);
                        pagar.ExecuteNonQuery();

                    }
                    else// SI EL TIPO DE PAGO ES DEPOSITO/EFECTIVO O EFECTIVO
                    {


                 

                        //ABONOS CON EFECTIVO DE TIENDAS
                        //INSERTAR ABONO EN TABLA FLUJO

                        if (CHK_va.Checked == true)
                        {
                             aplicarRetiroVA(Convert.ToString(idAbono));
                        }

                        if (CHK_re.Checked == true)
                        {
                            aplicarRetiroRE(Convert.ToString(idAbono));
                        }

                        if (CHK_co.Checked == true)
                        {
                           aplicarRetiroCO(Convert.ToString(idAbono));
                        }

                        if (CHK_ve.Checked == true)
                        {
                            aplicarRetiroVE(Convert.ToString(idAbono));
                        }

                        //if (CHK_pre.Checked == true)
                        //{
                        //    aplicarRetiroPRE(Convert.ToString(idAbono));
                        //}




                        //INSERTAR EL ABONO EN LA TABLA PAGOS
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO pagos(Abono,Proveedor, tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                            "VALUES(?Abono,?Proveedor,?tipo_doc,?No_referen,?Importe,?Moneda,?TC,ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)", con);
                        cmd.Parameters.AddWithValue("?Abono", consec);
                        cmd.Parameters.AddWithValue("?Proveedor", TB_proveedor.Text);
                        cmd.Parameters.AddWithValue("?tipo_doc", TB_cod.Text);
                        cmd.Parameters.AddWithValue("?No_referen", TB_referencia.Text);
                        cmd.Parameters.AddWithValue("?Importe", abono);
                        cmd.Parameters.AddWithValue("?Moneda", "MN");
                        cmd.Parameters.AddWithValue("?TC", "1");
                        cmd.Parameters.AddWithValue("?ImportBase", abono);
                        cmd.Parameters.AddWithValue("?Cobrar", "");
                        cmd.Parameters.AddWithValue("?Banco", "");
                        cmd.Parameters.AddWithValue("?Fecha_dep", fechActual.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?Autorizado", "0");
                        cmd.Parameters.AddWithValue("?Por_apli", "0");
                        cmd.Parameters.AddWithValue("?Aplicado", "0");
                        cmd.Parameters.AddWithValue("?Observ", "");
                        cmd.Parameters.AddWithValue("?Concepto", "PROV");
                        cmd.Parameters.AddWithValue("?Usuario", usuario);
                        cmd.Parameters.AddWithValue("?UsuFecha", fechActual.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?UsuHora", fechActual.ToString("HH:mm:ss"));
                        cmd.ExecuteNonQuery();


                        //INSERTAR EL REGISTRO DEL PAGO EN LA TABLA CUENXPDET
                        MySqlCommand cuenxpdet = new MySqlCommand("INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza) " +
                            "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)", con);
                        cuenxpdet.Parameters.AddWithValue("?CUENXPAG", TB_cxp.Text);
                        cuenxpdet.Parameters.AddWithValue("?PROVEEDOR", TB_proveedor.Text);
                        cuenxpdet.Parameters.AddWithValue("?FECHA", fechActual.ToString("yyyy-MM-dd"));
                        cuenxpdet.Parameters.AddWithValue("?TIPO_DOC", TB_cod.Text);
                        cuenxpdet.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
                        cuenxpdet.Parameters.AddWithValue("?Cargo_ab", "A");
                        cuenxpdet.Parameters.AddWithValue("?IMPORTE", abono);
                        cuenxpdet.Parameters.AddWithValue("?MONEDA", "MN");
                        cuenxpdet.Parameters.AddWithValue("?TIP_CAM", "1");
                        cuenxpdet.Parameters.AddWithValue("?COMPRA", CB_cxpag.SelectedItem.ToString());
                        cuenxpdet.Parameters.AddWithValue("?COBRADOR", "");
                        cuenxpdet.Parameters.AddWithValue("?OBSERV", idAbono);
                        cuenxpdet.Parameters.AddWithValue("?CONTAB", "");
                        cuenxpdet.Parameters.AddWithValue("?ABONO", consec);
                        cuenxpdet.Parameters.AddWithValue("?USUARIO", usuario);
                        cuenxpdet.Parameters.AddWithValue("?USUFECHA", fechActual.ToString("yyyy-MM-dd"));
                        cuenxpdet.Parameters.AddWithValue("?USUHORA", fechActual.ToString("HH:mm:ss"));
                        cuenxpdet.Parameters.AddWithValue("?ORDEN", "0");
                        cuenxpdet.Parameters.AddWithValue("?poliza", "");
                        cuenxpdet.ExecuteNonQuery();

                        if ((CB_tipodoc.SelectedItem.ToString().Equals("EFECTIVO")|| CB_tipodoc.SelectedItem.ToString().Equals("DEPOSITO/EFECTIVO")) && CHX_bancos.Checked)
                        {

                            decimal d = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                            string cadena = d.ToString("G0");
                            double cantidad = Convert.ToDouble(cadena);

                            //double cantidad = Convert.ToDouble(TB_abono.Text);
                            MySqlConnection bo = BDConexicon.BodegaOpen();
                            MySqlCommand cuenta = new MySqlCommand("INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,ref_gastoexterno,suc_pago) VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?ref_gastoexterno,?suc_pago) ", bo);
                            cuenta.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                            cuenta.Parameters.AddWithValue("?mov", "EFECTIVO");
                            cuenta.Parameters.AddWithValue("?ie", "E");
                            cuenta.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                            cuenta.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                            cuenta.Parameters.AddWithValue("?pagara", CB_persona.SelectedItem.ToString());
                            cuenta.Parameters.AddWithValue("?cantidad", cantidad);
                            cuenta.Parameters.AddWithValue("?fecha", fecha2.ToString("yyyy-MM-dd"));
                            cuenta.Parameters.AddWithValue("?hora", fecha2.ToString("HH:mm:ss"));
                            cuenta.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
                            cuenta.Parameters.AddWithValue("?suc_pago", CB_sucursal.SelectedItem.ToString());
                            cuenta.ExecuteNonQuery();

                            MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                            desglose.Parameters.AddWithValue("?importe", cantidad);
                            desglose.Parameters.AddWithValue("?fecha_pago", fecha2.ToString("yyyy-MM-dd"));
                            desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                            desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                            desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                            desglose.Parameters.AddWithValue("?idabono", idAbono);
                            desglose.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                            desglose.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                            desglose.Parameters.AddWithValue("?clientebancario", TB_anombrede.Text);
                            desglose.ExecuteNonQuery();


//-------------------------         // actualizar consecutivo id abono para desglose abono
                            try
                            {
                                int id = Convert.ToInt32(idAbono);
                                id++;
                                MySqlConnection bodega = BDConexicon.BodegaOpen();
                                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                                actualizaIDabono.ExecuteNonQuery();
                                bodega.Close();
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show("[SPEI] Error al actualizar el consecutivo de consecAbono de tabla consec: " + ex);
                            }
                        }



                        //ACTUALIZAR EL CONSECUTIVO DE LOS ABONOS EN LA TABLA CONSEC
                        MySqlCommand actualizarConsec = new MySqlCommand("UPDATE consec SET Consec ='" + consec + "'" + " where Dato ='ABONOPROV'", con);
                        actualizarConsec.ExecuteNonQuery();



                        //OBTENGO EL SALDO DE LA COMPRA
                        double saldo = 0;
                        MySqlCommand saldoCompra = new MySqlCommand("SELECT SALDO FROM cuenxpag WHERE COMPRA='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR='"+ TB_proveedor.Text+"'", con);
                        MySqlDataReader salCompra = saldoCompra.ExecuteReader();
                        while (salCompra.Read())
                        {
                            saldo = Convert.ToDouble(salCompra["SALDO"].ToString());
                        }
                        salCompra.Close();

                        double pago = Convert.ToDouble(abono);
                        double nuevoSaldo = saldo - pago;

                        //AFECTAR EL SALDO DE LA COMPRA (RESTARLE EL ABONO QUE SE APLICÓ)
                        MySqlCommand pagar = new MySqlCommand("UPDATE cuenxpag SET SALDO ='" + nuevoSaldo + "' WHERE COMPRA='" + CB_cxpag.SelectedItem.ToString() + "' and PROVEEDOR='" + TB_proveedor.Text + "'", con);
                        pagar.ExecuteNonQuery();


                        //INSERTAR ABONO EN TABLA FLUJO
                      

                    }


                }
                auditoria();
            }



            //TRAER EL NUEVO SALDO DE LA COMPRA TRAS REALIZAR EL ABONO
            decimal digito2 = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string saldocompra = digito2.ToString("G0");

            decimal digito3 = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string abonocompra = digito3.ToString("G0");

            double saldoComActual = Convert.ToDouble(saldocompra);
            double abonoCom = Convert.ToDouble(abonocompra);
            double nuevoSaldoCom = saldoComActual - abonoCom;

            TB_saldocompra.Text = String.Format("{0:0.##}", nuevoSaldoCom.ToString("C"));

            decimal digito4 = decimal.Parse(TB_saldo_proveedor.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string saldoprov = digito4.ToString("G0");

            double saldoActualProv = Convert.ToDouble(saldoprov);

            double nuevoSaldoProv = saldoActualProv - abonoCom;

            TB_saldo_proveedor.Text = String.Format("{0:0.##}", nuevoSaldoProv.ToString("C"));
           

            if (TB_cod.Text.Equals("SPEI"))
            {
                decimal pago = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string abonoSPEI = pago.ToString("G0");
                double spei = Convert.ToDouble(abonoSPEI);

                decimal saldoCuenta = decimal.Parse(TB_saldocuenta.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string saldoC = saldoCuenta.ToString("G0");

                double saldoActualCuenta = Convert.ToDouble(saldoC);
                double saldoNuevoCuenta = saldoActualCuenta - spei;


                TB_saldocuenta.Text = String.Format("{0:0.##}", saldoNuevoCuenta.ToString("C"));
            }

            con.Close();

            //LIMPIAR ELEMENTOS
            TB_pagoVA.Text = "";
            TB_pagoRE.Text = "";
            TB_pagoCO.Text = "";
            TB_pagoVE.Text = "";
            //TB_pagoPRE.Text = "";

            TB_referencia.Text = "";
            TB_abono.Text = "";
            //CB_sucursal.SelectedIndex = 0;
            //CB_cxpag.SelectedIndex = 0;
            //CB_banco.SelectedIndex = 0;
            //CB_cuenta.SelectedIndex = 0;
            //CB_persona.SelectedIndex = 0;
            CHK_va.Checked = false;
            CHK_re.Checked = false;
            CHK_co.Checked = false;
            CHK_ve.Checked = false;
            //CHK_pre.Checked = false;

            MessageBox.Show("ABONO APLICADO");
           
        }

        //BOTON PAGAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (CB_tipodoc.SelectedItem.Equals("SPEI"))
            {
                if (CB_sucursal.SelectedIndex == 0 || CB_cxpag.SelectedIndex == 0 || CB_banco_osmart.SelectedIndex == 0 || CB_cuenta_osmart.SelectedIndex == 0)
                {
                    MessageBox.Show("REVISAR QUE LOS DATOS SUCURSAL, BANCO OSMART,CUENTA OSMART Y LA COMPRA NO ESTEN VACIOS");
                }
                else
                {
                    AplicarPago();
                }
               
            }
            else
            {
                if (CB_tipodoc.SelectedItem.Equals("AJUSTES"))
                {
                    if (TB_cod.Text.Equals("") || CB_sucursal.SelectedIndex == 0 || CB_cxpag.SelectedIndex == 0 || TB_referencia.Text.Equals("") || TB_abono.Text.Equals(""))
                    {
                        MessageBox.Show("REVISA QUE LOS CAMPOS SUCURSA, COMPRA, REFEENCIA O ABONO NO ESTEN VACIOS");
                    }
                    else
                    {
                        AplicarPago();
                    }
                }
                else
                {

                    if (TB_cod.Text.Equals("") || CB_sucursal.SelectedIndex == 0 || CB_cxpag.SelectedIndex == 0 || CB_banco.SelectedIndex == 0 || CB_banco.SelectedIndex == -1 || CB_cuenta.SelectedIndex == 0 || CB_cuenta.SelectedIndex == -1 || CB_persona.SelectedIndex == 0 || CB_persona.SelectedIndex == -1 || TB_referencia.Text.Equals("") || TB_abono.Text.Equals(""))
                    {
                        MessageBox.Show("REVISAR QUE NO QUEDE NINGUN DATO SIN CAPTURAR");
                    }
                    else
                    {
                        if (TB_proveedor.Text.Equals("000001") && CB_tipodoc.SelectedItem.Equals("ACREEDOR"))
                        {
                            MessageBox.Show("No puedes pagarle al acreedor con su propio dinero");
                        }
                        else
                        {
                            AplicarPago();

                        }
                    }
                }
               
               


            }

            


        }

        //BOTON TOMAR EFECTIVO
        private void button3_Click(object sender, EventArgs e)
        {
            string va = "";
            string re = "";
            string co = "";
            string ve = "";

            string pre = "";

            double efeva = 0;
            double efere = 0;
            double efeco = 0;
            double efeve = 0;

            double efepre = 0;


            //QUITO EL FORMATO DE MONEDA DE LAS CAJAS DE TEXTO DEL EFECTIVO DISPONIBLE EN TIENDAS
            try
            {
                decimal digito = decimal.Parse(TB_efevallarta.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                va = digito.ToString("G0");

                decimal digito2 = decimal.Parse(TB_eferena.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                re = digito2.ToString("G0");

                decimal digito3 = decimal.Parse(TB_efecoloso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                co = digito3.ToString("G0");

                decimal digito4 = decimal.Parse(TB_efevelazquez.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                ve = digito4.ToString("G0");

                //decimal digito5 = decimal.Parse(TB_efepregot.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                //pre = digito5.ToString("G0");

                //GUARDO EL EFECTIVO DISPONIBLE EN TIENDAS EN ESTAS VARIABLES

                efeva = Convert.ToDouble(va);
                efere = Convert.ToDouble(re);
                efeco = Convert.ToDouble(co);
                efeve = Convert.ToDouble(ve);
                //efepre = Convert.ToDouble(pre);

            }

            catch (Exception ex)

            {

                MessageBox.Show("CALCULA EL EFECTIVO QUE HAY DISPONIBLE EN LAS TIENDAS");
            }




            //GUARDO LA CANTIDAD QUE TOMA DE CADA TIENDA
            double pagoVA = 0;
            double pagoRE = 0;
            double pagoCO = 0;
            double pagoVE = 0;
            double pagoPRE = 0;


            if (!TB_pagoVA.Text.Equals(""))
            {
                pagoVA = Convert.ToDouble(TB_pagoVA.Text);
            }

            if (!TB_pagoRE.Text.Equals(""))
            {
                pagoRE = Convert.ToDouble(TB_pagoRE.Text);
            }

            if (!TB_pagoCO.Text.Equals(""))
            {
                pagoCO = Convert.ToDouble(TB_pagoCO.Text);
            }

            if (!TB_pagoVE.Text.Equals(""))
            { 
                pagoVE = Convert.ToDouble(TB_pagoVE.Text);
            }

            //if (!TB_pagoPRE.Text.Equals(""))
            //{
            //    pagoPRE = Convert.ToDouble(TB_pagoPRE.Text);
            //}
            //SE REALIZAN LAS OPERACIONES
            double sumaPago = pagoVA + pagoRE + pagoCO + pagoVE + pagoPRE;
            double totalVA = efeva - pagoVA;
            double totalRE = efere - pagoRE;
            double totalCO = efeco - pagoCO;
            double totalVE = efeve - pagoVE;
            //double totalPRE = efepre - pagoPRE;

            TB_efevallarta.Text = String.Format("{0:0.##}", totalVA.ToString("C"));
            TB_eferena.Text = String.Format("{0:0.##}", totalRE.ToString("C"));
            TB_efecoloso.Text = String.Format("{0:0.##}", totalCO.ToString("C"));
            TB_efevelazquez.Text = String.Format("{0:0.##}", totalVE.ToString("C"));
            //TB_efepregot.Text = String.Format("{0:0.##}", totalPRE.ToString("C"));

            TB_abono.Text = String.Format("{0:0.##}" ,sumaPago.ToString("C"));

            decimal aux = 0;
            if (TB_saldocompra.Text.Equals(""))
            {
                aux = 0;
            }
            else
            {
                aux = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            }
            
           double saldoComp = Convert.ToDouble(aux.ToString("G0"));
            double saldoNuevoComp = saldoComp - sumaPago;
            TB_abonoaplicado.Text = String.Format("{0:0.##}", saldoNuevoComp.ToString("C"));


            sumaPago = 0; totalVA = 0; totalRE = 0; totalCO = 0; totalVE = 0; /*totalPRE = 0;*/
            efeva = 0; efere = 0; efeco = 0; efeve = 0; efepre = 0;
            pagoVA = 0; pagoRE = 0;pagoCO = 0;pagoVE = 0;pagoPRE = 0;
            //SE VERIFICA SI SE COLOCO ALGUNA CANTIDAD EN LOS TEXTBOX PARA TOMAR EFECTIVO SI ES ASI, SE MARCA EL CHECKBOX CORRESPONDIENTE
            //PARA QUE EL SISTEMA SEPA A QUE TIENDA HARA LA INSERCION EN LA TABLA FLUJO, MAS ADELANTE
            if (!TB_pagoVA.Text.Equals(""))
            {
                CHK_va.Checked = true;
            }

            if (!TB_pagoRE.Text.Equals(""))
            {
                CHK_re.Checked = true;
            }

            if (!TB_pagoCO.Text.Equals(""))
            {
                CHK_co.Checked = true;
            }

            if (!TB_pagoVE.Text.Equals(""))
            {
                CHK_ve.Checked = true;
            }

            //if (!TB_pagoPRE.Text.Equals(""))
            //{
            //    CHK_pre.Checked = true;
            //}
        }



        //############################## INSERTA EL DINERO TOMADO DEL EFECTIVO DISPOBIBLE EN TIENDAS EN LA TABLA FLUJO ###############################
        public int  aplicarRetiroVA(string idabono)
        {

            int consecutivoFlujo = 0;

            if (CHK_respaldo.Checked==true)
            {
               
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;
                DateTime fecha = DT_fecha.Value;
                DateTime fechActual = DateTime.Now;
                double retiro = Convert.ToDouble(TB_pagoVA.Text);
                string mesRespaldo = MesRespaldo(mes);
                consecutivoFlujo = ConsecFLujo("VALLARTA");
                MySqlConnection conResp = BDConexicon.RespaldoVA(mesRespaldo, año);
                
                MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                   "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", conResp);
                flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
                flujo.Parameters.AddWithValue("?ABONO", "0");
                flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
                flujo.Parameters.AddWithValue("?ING_EG", "E");
                flujo.Parameters.AddWithValue("?IMPORTE", retiro);
                flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?HORA", "");
                flujo.Parameters.AddWithValue("?MONEDA", "MN");
                flujo.Parameters.AddWithValue("?ESTACION", "ESTACION01");
                flujo.Parameters.AddWithValue("?USUARIO", usuario);
                flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?USUHORA", "");
                flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
                flujo.Parameters.AddWithValue("?Venta", "0");
                flujo.Parameters.AddWithValue("?Corte", "0");
                flujo.Parameters.AddWithValue("?tipo_cam", "1");
                flujo.Parameters.AddWithValue("?Cargo", "0");
                flujo.Parameters.AddWithValue("?concepto2", "RPPP");
                flujo.Parameters.AddWithValue("?banco", "");
                flujo.Parameters.AddWithValue("?cheque", "");
                flujo.Parameters.AddWithValue("?verificado", "0");
                flujo.ExecuteNonQuery();

                //ACTUALIZAR CONSECUTIVO DE FLUJO
                MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", conResp);
                consec.ExecuteNonQuery();


                MySqlConnection con = BDConexicon.VallartaOpen();
                MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                decimal digito = decimal.Parse(TB_pagoVA.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string cantidad = digito.ToString("G0");
                desglose.Parameters.AddWithValue("?importe", Convert.ToDouble(cantidad));
                desglose.Parameters.AddWithValue("?fecha_pago", fechActual.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                desglose.Parameters.AddWithValue("?idabono", idabono);
                desglose.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?clientebancario", TB_anombrede.Text);
                desglose.ExecuteNonQuery();


                int id = Convert.ToInt32(idabono);
                id++;
                MySqlConnection bodega = BDConexicon.BodegaOpen();
                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                actualizaIDabono.ExecuteNonQuery();
                bodega.Close();


                if (TB_proveedor.Text.Equals("000001"))
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                else
                {

                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    if (esAjuste==false)//si se esta aplicando un ajuste(esajuste=true) desde el boton ajuste, no debe insertarse nada en el atabla reporte_pagoproveedores, si es cualquier otro pago(esAjuste=false) si se debe guardar la info en esa tabla
                    {
                        reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                        reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?monto", retiro);
                        reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                        reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                        reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                        reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                        reporte.Parameters.AddWithValue("?idabono", idabono);
                        reporte.ExecuteNonQuery();
                    }
                   
                    
                   
                }
                con.Close();
                conResp.Close();

            }
            else
            {

               consecutivoFlujo = ConsecFLujo("VALLARTA");
                DateTime fecha = DT_fecha.Value;
                DateTime fechaActual = DateTime.Now;
                double retiro = Convert.ToDouble(TB_pagoVA.Text);
               
                MySqlConnection con = BDConexicon.VallartaOpen();

                MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                    "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
                flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
                flujo.Parameters.AddWithValue("?ABONO", "0");
                flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
                flujo.Parameters.AddWithValue("?ING_EG", "E");
                flujo.Parameters.AddWithValue("?IMPORTE", retiro);
                flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?HORA", "");
                flujo.Parameters.AddWithValue("?MONEDA", "MN");
                flujo.Parameters.AddWithValue("?ESTACION", "ESTACION01");
                flujo.Parameters.AddWithValue("?USUARIO", usuario);
                flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?USUHORA", "");
                flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
                flujo.Parameters.AddWithValue("?Venta", "0");
                flujo.Parameters.AddWithValue("?Corte", "0");
                flujo.Parameters.AddWithValue("?tipo_cam", "1");
                flujo.Parameters.AddWithValue("?Cargo", "0");
                flujo.Parameters.AddWithValue("?concepto2", "RPPP");
                flujo.Parameters.AddWithValue("?banco", "");
                flujo.Parameters.AddWithValue("?cheque", "");
                flujo.Parameters.AddWithValue("?verificado", "0");
                flujo.ExecuteNonQuery();

               


               //ACTUALIZAR CONSECUTIVO DE FLUJO
               MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
                consec.ExecuteNonQuery();

                //INSERTAR REGISTRO EN TABLA rd_desglose_abonos
                MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);

                if (CHX_bancos.Checked==true)
                {
                    decimal digito = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    string cantidad = digito.ToString("G0");
                    desglose.Parameters.AddWithValue("?importe", Convert.ToDouble(cantidad));
                    desglose.Parameters.AddWithValue("?fecha_pago", fechaActual.ToString("yyyy-MM-dd"));
                    desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    desglose.Parameters.AddWithValue("?tipo", "AJ");
                    desglose.Parameters.AddWithValue("?idabono", idabono);
                    desglose.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                    desglose.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                    desglose.Parameters.AddWithValue("?clientebancario",TB_anombrede.Text);
                    desglose.ExecuteNonQuery();
                }
                else
                {
                    desglose.Parameters.AddWithValue("?importe", retiro);
                    desglose.Parameters.AddWithValue("?fecha_pago", fechaActual.ToString("yyyy-MM-dd"));
                    desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    if (esAjuste==true)
                    {
                        desglose.Parameters.AddWithValue("?tipo","AJ");
                    }
                    else
                    {
                        desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                    }
               
                    desglose.Parameters.AddWithValue("?idabono", idabono);
                    desglose.Parameters.AddWithValue("?banco", "");
                    desglose.Parameters.AddWithValue("?cuenta", "");
                    desglose.Parameters.AddWithValue("?clientebancario", "");
                    desglose.ExecuteNonQuery();
                }
               

               

                DateTime fechActual = DateTime.Now;
                if (TB_proveedor.Text.Equals("000001"))
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia)", con);
                    if (esAjuste == false)//si se esta aplicando un ajuste(esajuste=true) desde el boton ajuste, no debe insertarse nada en el atabla reporte_pagoproveedores, si es cualquier otro pago(esAjuste=false) si se debe guardar la info en esa tabla
                    {
                        reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                        reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?monto", retiro);
                        reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                        reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                        reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                        reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                        reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                        reporte.Parameters.AddWithValue("?idabono", idabono);
                        reporte.ExecuteNonQuery();
                    }
                }
                con.Close();

                int id = Convert.ToInt32(idabono);
                id++;
                MySqlConnection bodega = BDConexicon.BodegaOpen();
                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                actualizaIDabono.ExecuteNonQuery();
                bodega.Close();
            }


          

            return consecutivoFlujo;
        }

        public int aplicarRetiroRE(string idabono)
        {
            int consecutivoFlujo = 0;
            if (CHK_respaldo.Checked==true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;
                DateTime fecha = DT_fecha.Value;
                DateTime fechActual = DateTime.Now;
                double retiro = Convert.ToDouble(TB_pagoRE.Text);
                string mesRespaldo = MesRespaldo(mes);
                consecutivoFlujo = ConsecFLujo("RENA");
                MySqlConnection conResp = BDConexicon.RespaldoRE(mesRespaldo, año);

                MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                   "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", conResp);
                flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
                flujo.Parameters.AddWithValue("?ABONO", "0");
                flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
                flujo.Parameters.AddWithValue("?ING_EG", "E");
                flujo.Parameters.AddWithValue("?IMPORTE", retiro);
                flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?HORA", "");
                flujo.Parameters.AddWithValue("?MONEDA", "MN");
                flujo.Parameters.AddWithValue("?ESTACION", "ESTACION01");
                flujo.Parameters.AddWithValue("?USUARIO", usuario);
                flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?USUHORA", "");
                flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
                flujo.Parameters.AddWithValue("?Venta", "0");
                flujo.Parameters.AddWithValue("?Corte", "0");
                flujo.Parameters.AddWithValue("?tipo_cam", "1");
                flujo.Parameters.AddWithValue("?Cargo", "0");
                flujo.Parameters.AddWithValue("?concepto2", "RPPP");
                flujo.Parameters.AddWithValue("?banco", "");
                flujo.Parameters.AddWithValue("?cheque", "");
                flujo.Parameters.AddWithValue("?verificado", "0");
                flujo.ExecuteNonQuery();

                //ACTUALIZAR CONSECUTIVO DE FLUJO
                MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", conResp);
                consec.ExecuteNonQuery();

                MySqlConnection con = BDConexicon.RenaOpen();
                MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                decimal digito = decimal.Parse(TB_pagoRE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string cantidad = digito.ToString("G0");
                desglose.Parameters.AddWithValue("?importe", Convert.ToDouble(cantidad));
                desglose.Parameters.AddWithValue("?fecha_pago", fechActual.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                desglose.Parameters.AddWithValue("?idabono", idabono);
                desglose.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?clientebancario", TB_anombrede.Text);
                desglose.ExecuteNonQuery();


               
               
                if (TB_proveedor.Text.Equals("000001"))
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                con.Close();
                conResp.Close();

            }
            else
            {
                DateTime fecha = DT_fecha.Value;
                double retiro = Convert.ToDouble(TB_pagoRE.Text);
                DateTime fechaActual = DateTime.Now;
                MySqlConnection con = BDConexicon.RenaOpen();
                consecutivoFlujo = ConsecFLujo("RENA" +
                    "");
                MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                    "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
                flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
                flujo.Parameters.AddWithValue("?ABONO", "0");
                flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
                flujo.Parameters.AddWithValue("?ING_EG", "E");
                flujo.Parameters.AddWithValue("?IMPORTE", retiro);
                flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?HORA", "");
                flujo.Parameters.AddWithValue("?MONEDA", "MN");
                flujo.Parameters.AddWithValue("?ESTACION", "");
                flujo.Parameters.AddWithValue("?USUARIO", usuario);
                flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?USUHORA", "");
                flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
                flujo.Parameters.AddWithValue("?Venta", "0");
                flujo.Parameters.AddWithValue("?Corte", "1");
                flujo.Parameters.AddWithValue("?tipo_cam", "1");
                flujo.Parameters.AddWithValue("?Cargo", "0");
                flujo.Parameters.AddWithValue("?concepto2", "RPPP");
                flujo.Parameters.AddWithValue("?banco", "");
                flujo.Parameters.AddWithValue("?cheque", "");
                flujo.Parameters.AddWithValue("?verificado", "0");
                flujo.ExecuteNonQuery();


                //ACTUALIZAR CONSECUTIVO DE FLUJO
                MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
                consec.ExecuteNonQuery();

                //INSERTAR REGISTRO EN TABLA rd_desglose_abonos
                MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                desglose.Parameters.AddWithValue("?importe", retiro);
                desglose.Parameters.AddWithValue("?fecha_pago", fechaActual.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                desglose.Parameters.AddWithValue("?idabono", idabono);
                desglose.Parameters.AddWithValue("?banco", "");
                desglose.Parameters.AddWithValue("?cuenta", "");
                desglose.Parameters.AddWithValue("?clientebancario", "");
                desglose.ExecuteNonQuery();

                int id = Convert.ToInt32(idabono);
                id++;
                MySqlConnection bodega = BDConexicon.BodegaOpen();
                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                actualizaIDabono.ExecuteNonQuery();
                bodega.Close();

                DateTime fechActual = DateTime.Now;
                if (TB_proveedor.Text.Equals("000001"))
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                con.Close();
            }

            return consecutivoFlujo;
        }

        public int aplicarRetiroCO(string idabono)
        {
            int consecutivoFlujo = 0;
            if (CHK_respaldo.Checked==true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;
                DateTime fecha = DT_fecha.Value;
                DateTime fechActual = DateTime.Now;
                double retiro = Convert.ToDouble(TB_pagoCO.Text);
                string mesRespaldo = MesRespaldo(mes);
                consecutivoFlujo = ConsecFLujo("COLOSO");
                MySqlConnection conResp = BDConexicon.RespaldoCO(mesRespaldo, año);

                MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                   "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", conResp);
                flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
                flujo.Parameters.AddWithValue("?ABONO", "0");
                flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
                flujo.Parameters.AddWithValue("?ING_EG", "E");
                flujo.Parameters.AddWithValue("?IMPORTE", retiro);
                flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?HORA", "");
                flujo.Parameters.AddWithValue("?MONEDA", "MN");
                flujo.Parameters.AddWithValue("?ESTACION", "ESTACION01");
                flujo.Parameters.AddWithValue("?USUARIO", usuario);
                flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?USUHORA", "");
                flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
                flujo.Parameters.AddWithValue("?Venta", "0");
                flujo.Parameters.AddWithValue("?Corte", "0");
                flujo.Parameters.AddWithValue("?tipo_cam", "1");
                flujo.Parameters.AddWithValue("?Cargo", "0");
                flujo.Parameters.AddWithValue("?concepto2", "RPPP");
                flujo.Parameters.AddWithValue("?banco", "");
                flujo.Parameters.AddWithValue("?cheque", "");
                flujo.Parameters.AddWithValue("?verificado", "0");
                flujo.ExecuteNonQuery();

                //ACTUALIZAR CONSECUTIVO DE FLUJO
                MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", conResp);
                consec.ExecuteNonQuery();

                MySqlConnection con = BDConexicon.ColosoOpen();
                MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                decimal digito = decimal.Parse(TB_pagoRE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string cantidad = digito.ToString("G0");
                desglose.Parameters.AddWithValue("?importe", Convert.ToDouble(cantidad));
                desglose.Parameters.AddWithValue("?fecha_pago", fechActual.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                desglose.Parameters.AddWithValue("?idabono", idabono);
                desglose.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?clientebancario", TB_anombrede.Text);
                desglose.ExecuteNonQuery();

                int id = Convert.ToInt32(idabono);
                id++;
                MySqlConnection bodega = BDConexicon.BodegaOpen();
                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                actualizaIDabono.ExecuteNonQuery();
                bodega.Close();


                if (TB_proveedor.Text.Equals("000001"))
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                con.Close();
                conResp.Close();
            }
            else
            {

                DateTime fecha = DT_fecha.Value;
                double retiro = Convert.ToDouble(TB_pagoCO.Text);
                DateTime fechaActual = DateTime.Now;
                MySqlConnection con = BDConexicon.ColosoOpen();
                consecutivoFlujo = ConsecFLujo("COLOSO");
                MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                    "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
                flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
                flujo.Parameters.AddWithValue("?ABONO", "0");
                flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
                flujo.Parameters.AddWithValue("?ING_EG", "E");
                flujo.Parameters.AddWithValue("?IMPORTE", retiro);
                flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?HORA", "");
                flujo.Parameters.AddWithValue("?MONEDA", "MN");
                flujo.Parameters.AddWithValue("?ESTACION", "");
                flujo.Parameters.AddWithValue("?USUARIO", usuario);
                flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?USUHORA", "");
                flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
                flujo.Parameters.AddWithValue("?Venta", "0");
                flujo.Parameters.AddWithValue("?Corte", "1");
                flujo.Parameters.AddWithValue("?tipo_cam", "1");
                flujo.Parameters.AddWithValue("?Cargo", "0");
                flujo.Parameters.AddWithValue("?concepto2", "RPPP");
                flujo.Parameters.AddWithValue("?banco", "");
                flujo.Parameters.AddWithValue("?cheque", "");
                flujo.Parameters.AddWithValue("?verificado", "0");
                flujo.ExecuteNonQuery();

                //ACTUALIZAR CONSECUTIVO DE FLUJO
                MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
                consec.ExecuteNonQuery();

                //INSERTAR REGISTRO EN TABLA rd_desglose_abonos
                MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                desglose.Parameters.AddWithValue("?importe", retiro);
                desglose.Parameters.AddWithValue("?fecha_pago", fechaActual.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                desglose.Parameters.AddWithValue("?idabono", idabono);
                desglose.Parameters.AddWithValue("?banco", "");
                desglose.Parameters.AddWithValue("?cuenta", "");
                desglose.Parameters.AddWithValue("?clientebancario","");
                desglose.ExecuteNonQuery();

                int id = Convert.ToInt32(idabono);
                id++;
                MySqlConnection bodega = BDConexicon.BodegaOpen();
                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                actualizaIDabono.ExecuteNonQuery();
                bodega.Close();


                DateTime fechActual = DateTime.Now;
                if (TB_proveedor.Text.Equals("000001"))
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                con.Close();
            }

            return consecutivoFlujo;
        }

        public int aplicarRetiroVE(string idabono)
        {

            int consecutivoFlujo = 0;
            if (CHK_respaldo.Checked==true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;
                DateTime fecha = DT_fecha.Value;
                DateTime fechActual = DateTime.Now;
                double retiro = Convert.ToDouble(TB_pagoVE.Text);
                string mesRespaldo = MesRespaldo(mes);
                consecutivoFlujo = ConsecFLujo("VELAZQUEZ");
                MySqlConnection conResp = BDConexicon.RespaldoVE(mesRespaldo, año);

                MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                   "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", conResp);
                flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
                flujo.Parameters.AddWithValue("?ABONO", "0");
                flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
                flujo.Parameters.AddWithValue("?ING_EG", "E");
                flujo.Parameters.AddWithValue("?IMPORTE", retiro);
                flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?HORA", "");
                flujo.Parameters.AddWithValue("?MONEDA", "MN");
                flujo.Parameters.AddWithValue("?ESTACION", "ESTACION01");
                flujo.Parameters.AddWithValue("?USUARIO", usuario);
                flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?USUHORA", "");
                flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
                flujo.Parameters.AddWithValue("?Venta", "0");
                flujo.Parameters.AddWithValue("?Corte", "0");
                flujo.Parameters.AddWithValue("?tipo_cam", "1");
                flujo.Parameters.AddWithValue("?Cargo", "0");
                flujo.Parameters.AddWithValue("?concepto2", "RPPP");
                flujo.Parameters.AddWithValue("?banco", "");
                flujo.Parameters.AddWithValue("?cheque", "");
                flujo.Parameters.AddWithValue("?verificado", "0");
                flujo.ExecuteNonQuery();

                //ACTUALIZAR CONSECUTIVO DE FLUJO
                
                MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", conResp);
                consec.ExecuteNonQuery();

                MySqlConnection con = BDConexicon.VelazquezOpen();
                MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                decimal digito = decimal.Parse(TB_pagoVE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string cantidad = digito.ToString("G0");
                desglose.Parameters.AddWithValue("?importe", Convert.ToDouble(cantidad));
                desglose.Parameters.AddWithValue("?fecha_pago", fechActual.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                desglose.Parameters.AddWithValue("?idabono", idabono);
                desglose.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?clientebancario", TB_anombrede.Text);
                desglose.ExecuteNonQuery();

                int id = Convert.ToInt32(idabono);
                id++;
                MySqlConnection bodega = BDConexicon.BodegaOpen();
                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                actualizaIDabono.ExecuteNonQuery();
                bodega.Close();



                if (TB_proveedor.Text.Equals("000001"))
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                con.Close();
                conResp.Close();
            }
            else
            {
                DateTime fecha = DT_fecha.Value;
                double retiro = Convert.ToDouble(TB_pagoVE.Text);
                DateTime fechaActual = DateTime.Now;
                MySqlConnection con = BDConexicon.VelazquezOpen();
                consecutivoFlujo = ConsecFLujo("VELAZQUEZ");
                MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                    "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
                flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
                flujo.Parameters.AddWithValue("?ABONO", "0");
                flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
                flujo.Parameters.AddWithValue("?ING_EG", "E");
                flujo.Parameters.AddWithValue("?IMPORTE", retiro);
                flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?HORA", "");
                flujo.Parameters.AddWithValue("?MONEDA", "MN");
                flujo.Parameters.AddWithValue("?ESTACION", "");
                flujo.Parameters.AddWithValue("?USUARIO", usuario);
                flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                flujo.Parameters.AddWithValue("?USUHORA", "");
                flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
                flujo.Parameters.AddWithValue("?Venta", "0");
                flujo.Parameters.AddWithValue("?Corte", "0");
                flujo.Parameters.AddWithValue("?tipo_cam", "1");
                flujo.Parameters.AddWithValue("?Cargo", "0");
                flujo.Parameters.AddWithValue("?concepto2", "RPPP");
                flujo.Parameters.AddWithValue("?banco", "");
                flujo.Parameters.AddWithValue("?cheque", "");
                flujo.Parameters.AddWithValue("?verificado", "0");
                flujo.ExecuteNonQuery();

                //ACTUALIZAR CONSECUTIVO DE FLUJO
                MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
                consec.ExecuteNonQuery();

                //INSERTAR REGISTRO EN TABLA rd_desglose_abonos
                MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
                desglose.Parameters.AddWithValue("?importe", retiro);
                desglose.Parameters.AddWithValue("?fecha_pago", fechaActual.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
                desglose.Parameters.AddWithValue("?idabono", idabono);
                desglose.Parameters.AddWithValue("?banco", "");
                desglose.Parameters.AddWithValue("?cuenta", "");
                desglose.Parameters.AddWithValue("?clientebancario", "");
                desglose.ExecuteNonQuery();

                int id = Convert.ToInt32(idabono);
                id++;
                MySqlConnection bodega = BDConexicon.BodegaOpen();
                MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
                actualizaIDabono.ExecuteNonQuery();
                bodega.Close();

                DateTime fechActual = DateTime.Now;
                if (TB_proveedor.Text.Equals("000001"))
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                else
                {
                    MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
                    reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
                    reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?monto", retiro);
                    reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                    reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                    reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
                    reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                    reporte.Parameters.AddWithValue("?idabono", idabono);
                    reporte.ExecuteNonQuery();
                }
                con.Close();
            }

            return consecutivoFlujo;
        }

        //public void aplicarRetiroPRE(string idabono)
        //{
        //    if (CHK_respaldo.Checked==true)
        //    {
        //        int mes = DT_fecha.Value.Month;
        //        int año = DT_fecha.Value.Year;
        //        DateTime fecha = DT_fecha.Value;
        //        double retiro = Convert.ToDouble(TB_pagoPRE.Text);
        //        string mesRespaldo = MesRespaldo(mes);
        //        int consecutivoFlujo = ConsecFLujo("PREGOT");
        //        MySqlConnection conResp = BDConexicon.RespaldoPRE(mesRespaldo, año);

        //        MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
        //           "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", conResp);
        //        flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
        //        flujo.Parameters.AddWithValue("?ABONO", "0");
        //        flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
        //        flujo.Parameters.AddWithValue("?ING_EG", "E");
        //        flujo.Parameters.AddWithValue("?IMPORTE", retiro);
        //        flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
        //        flujo.Parameters.AddWithValue("?HORA", "");
        //        flujo.Parameters.AddWithValue("?MONEDA", "MN");
        //        flujo.Parameters.AddWithValue("?ESTACION", "ESTACION01");
        //        flujo.Parameters.AddWithValue("?USUARIO", usuario);
        //        flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
        //        flujo.Parameters.AddWithValue("?USUHORA", "");
        //        flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
        //        flujo.Parameters.AddWithValue("?Venta", "0");
        //        flujo.Parameters.AddWithValue("?Corte", "0");
        //        flujo.Parameters.AddWithValue("?tipo_cam", "1");
        //        flujo.Parameters.AddWithValue("?Cargo", "0");
        //        flujo.Parameters.AddWithValue("?concepto2", "RPPP");
        //        flujo.Parameters.AddWithValue("?banco", "");
        //        flujo.Parameters.AddWithValue("?cheque", "");
        //        flujo.Parameters.AddWithValue("?verificado", "0");
        //        flujo.ExecuteNonQuery();

        //        //ACTUALIZAR CONSECUTIVO DE FLUJO
        //        MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", conResp);
        //        consec.ExecuteNonQuery();



        //        MySqlConnection con = BDConexicon.Papeleria1Open();
        //        DateTime fechActual = DateTime.Now;
        //        if (TB_proveedor.Text.Equals("000001"))
        //        {
        //            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
        //            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
        //            reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
        //            reporte.Parameters.AddWithValue("?monto", retiro);
        //            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
        //            reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
        //            reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
        //            reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
        //            reporte.Parameters.AddWithValue("?idabono", idabono);

        //            reporte.ExecuteNonQuery();
        //        }
        //        else
        //        {
        //            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
        //            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
        //            reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?monto", retiro);
        //            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
        //            reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
        //            reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
        //            reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
        //            reporte.Parameters.AddWithValue("?idabono", idabono);

        //            reporte.ExecuteNonQuery();
        //        }
        //        con.Close();
        //        conResp.Close();
        //    }
        //    else
        //    {
        //        DateTime fecha = DT_fecha.Value;
        //        double retiro = Convert.ToDouble(TB_pagoPRE.Text);
        //        DateTime fechaActual = DateTime.Now;
        //        MySqlConnection con = BDConexicon.Papeleria1Open();
        //        int consecutivoFlujo = ConsecFLujo("PREGOT");
        //        MySqlCommand flujo = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
        //            "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
        //        flujo.Parameters.AddWithValue("?FLUJO", consecutivoFlujo);
        //        flujo.Parameters.AddWithValue("?ABONO", "0");
        //        flujo.Parameters.AddWithValue("?CONCEPTO", "RPPP");
        //        flujo.Parameters.AddWithValue("?ING_EG", "E");
        //        flujo.Parameters.AddWithValue("?IMPORTE", retiro);
        //        flujo.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
        //        flujo.Parameters.AddWithValue("?HORA", "");
        //        flujo.Parameters.AddWithValue("?MONEDA", "MN");
        //        flujo.Parameters.AddWithValue("?ESTACION", "");
        //        flujo.Parameters.AddWithValue("?USUARIO", usuario);
        //        flujo.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
        //        flujo.Parameters.AddWithValue("?USUHORA", "");
        //        flujo.Parameters.AddWithValue("?Modulo", "PAGOS");
        //        flujo.Parameters.AddWithValue("?Venta", "0");
        //        flujo.Parameters.AddWithValue("?Corte", "1");
        //        flujo.Parameters.AddWithValue("?tipo_cam", "1");
        //        flujo.Parameters.AddWithValue("?Cargo", "0");
        //        flujo.Parameters.AddWithValue("?concepto2", "RPPP");
        //        flujo.Parameters.AddWithValue("?banco", "");
        //        flujo.Parameters.AddWithValue("?cheque", "");
        //        flujo.Parameters.AddWithValue("?verificado", "0");
        //        flujo.ExecuteNonQuery();

        //        //ACTUALIZAR CONSECUTIVO DE FLUJO
        //        MySqlCommand consec = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecutivoFlujo + "' WHERE Dato='flujo'", con);
        //        consec.ExecuteNonQuery();

        //        //INSERTAR REGISTRO EN TABLA rd_desglose_abonos
        //        MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", con);
        //        desglose.Parameters.AddWithValue("?importe", retiro);
        //        desglose.Parameters.AddWithValue("?fecha_pago", fechaActual.ToString("yyyy-MM-dd"));
        //        desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
        //        desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
        //        desglose.Parameters.AddWithValue("?tipo", TB_cod.Text);
        //        desglose.Parameters.AddWithValue("?idabono", idabono);
        //        desglose.Parameters.AddWithValue("?banco", "");
        //        desglose.Parameters.AddWithValue("?cuenta", "");
        //        desglose.Parameters.AddWithValue("?clientebancario", "");
        //        desglose.ExecuteNonQuery();

        //        int id = Convert.ToInt32(idabono);
        //        id++;
        //        MySqlConnection bodega = BDConexicon.BodegaOpen();
        //        MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + id + " WHERE Dato='consecAbono'", bodega);
        //        actualizaIDabono.ExecuteNonQuery();
        //        bodega.Close();

        //        DateTime fechActual = DateTime.Now;
        //        if (TB_proveedor.Text.Equals("000001"))
        //        {
        //            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
        //            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
        //            reporte.Parameters.AddWithValue("?pagarA", "PAGO A ACREEDOR");
        //            reporte.Parameters.AddWithValue("?monto", retiro);
        //            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
        //            reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
        //            reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
        //            reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
        //            reporte.Parameters.AddWithValue("?idabono", idabono);

        //            reporte.ExecuteNonQuery();
        //        }
        //        else
        //        {
        //            MySqlCommand reporte = new MySqlCommand("INSERT INTO rd_rep_pagoproveedores(nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,tipo_pago,referencia,idabono)VALUES(?nombreprov,?pagarA,?monto,?banco,?cuenta,?fecha,?fecha_efe,?tienda,?compra,?tipo_pago,?referencia,?idabono)", con);
        //            reporte.Parameters.AddWithValue("?nombreprov", TB_nombre.Text);
        //            reporte.Parameters.AddWithValue("?pagarA", CB_persona.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?monto", retiro);
        //            reporte.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?fecha", fechActual.ToString("yyyy-MM-dd"));
        //            reporte.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
        //            reporte.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
        //            reporte.Parameters.AddWithValue("?tipo_pago", TB_cod.Text);
        //            reporte.Parameters.AddWithValue("?referencia", TB_referencia.Text);
        //            reporte.Parameters.AddWithValue("?idabono", idabono);

        //            reporte.ExecuteNonQuery();
        //        }
        //        con.Close();
        //    }
        //}
        //##########################################################################################################################################


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        //############################## EVENTOS DE COMBOBOX ###############################################
        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MySqlConnection con = BDConexicon.BodegaOpen();
            //try
            //{
            //    MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR FROM proveed WHERE NOMBRE ='"+CB_proveedor.SelectedItem.ToString()+"'", con);
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        TB_proveedor.Text=dr["PROVEEDOR"].ToString();
            //    }
            //    dr.Close();
            //}
            //catch (Exception ex)
            //{


            //}
            //con.Close();
        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {


            string sucursal = ""; 
            MySqlConnection con = null;
            CB_cxpag.Items.Clear();
            CB_cxpag.Items.Add("");
            TB_saldocompra.Text = "";
            CB_cxpag.SelectedIndex = -1;
            //CB_banco_osmart.Items.Clear();
            //CB_banco_osmart.Items.Add("");
            //CB_banco_osmart.SelectedIndex = 0;

            TB_cxp.Text = "";
            sucursal = Convert.ToString(CB_sucursal.SelectedItem.ToString());

            //if (CB_tipodoc.SelectedItem.Equals("SPEI"))
            //{
            //    BancosOsmart();
            //    sucursal = CB_sucCompra.SelectedItem.ToString();//error
            //}
            //else
            //{
            //    
            //}

            if (sucursal.Equals("BODEGA"))
            {
               
                con = BDConexicon.BodegaOpen();

                try
                {
                    //"SELECT CUENXPAG FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "' AND SALDO>1 OR SALDO<0"
                  
                    MySqlCommand cmd = new MySqlCommand("SELECT COMPRA FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                       
                       
                            CB_cxpag.Items.Add(dr["COMPRA"].ToString());
                        
                        
                       
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }

                

                con.Close();
            }

            if (sucursal.Equals("VALLARTA"))
            {
               
                try
                {
                    con = BDConexicon.VallartaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT COMPRA FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["COMPRA"].ToString());
                    }

                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }

                

                con.Close();
            }

            if (sucursal.Equals("RENA"))
            {
                

                try
                {
                    con = BDConexicon.RenaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT COMPRA FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["COMPRA"].ToString());
                        
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }

               

                con.Close();
            }

            if (sucursal.Equals("COLOSO"))
            {
               

                try
                {
                    con = BDConexicon.ColosoOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT COMPRA FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["COMPRA"].ToString());
                        
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }

                

                con.Close();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
               

                try
                {
                    con = BDConexicon.VelazquezOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT COMPRA FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CB_cxpag.Items.Add(dr["COMPRA"].ToString());
                       
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }

               

                con.Close();
            }

            //if (sucursal.Equals("PREGOT"))
            //{
                

            //    try
            //    {
            //        con = BDConexicon.Papeleria1Open();
            //        MySqlCommand cmd = new MySqlCommand("SELECT COMPRA FROM cuenxpag WHERE PROVEEDOR ='" + TB_proveedor.Text + "'", con);
            //        MySqlDataReader dr = cmd.ExecuteReader();

            //        while (dr.Read())
            //        {
            //            CB_cxpag.Items.Add(dr["COMPRA"].ToString());
                      
            //        }
            //        dr.Close();
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show("ERROR de conexión: " + ex);
            //    }

               

            //    con.Close();
            //}


        }


        public double CalcularSaldoCompra(string sucursal)
        {


            double cargo = 0;
            double abono = 0;
            double saldo = 0;
            MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
            string query = "SELECT Cargo_ab,importe FROM cuenxpdet WHERE COMPRA='"+ CB_cxpag.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["Cargo_ab"].ToString().Equals("C"))
                {
                    cargo += Convert.ToDouble(dr["importe"].ToString());
                }

                if (dr["Cargo_ab"].ToString().Equals("A"))
                {
                    abono += Convert.ToDouble(dr["importe"].ToString());
                }
            }

            saldo = cargo - abono;

            return saldo;
        }

        private void CB_cxpag_SelectedIndexChanged(object sender, EventArgs e)
        {

            TB_cxp.Text = "";
            TB_saldocompra.Text = "";
            TB_abonoaplicado.Text = "";
            string sucursal = "";
            if (CB_tipodoc.Equals("SPEI"))
            {
                sucursal = CB_sucBanco.SelectedItem.ToString();
            }
            else
            {
                sucursal = CB_sucursal.SelectedItem.ToString();
            }

           
            MySqlConnection con = null;

            double saldocompra = 0;
            if (sucursal.Equals("BODEGA"))
            {

               
                try
                {
                    con = BDConexicon.BodegaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG,SALDO FROM cuenxpag WHERE COMPRA ='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR ='"+TB_proveedor.Text+"'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                  
                    while (dr.Read())
                    {
                        TB_cxp.Text = dr["CUENXPAG"].ToString();
                        saldocompra = Convert.ToDouble(dr["SALDO"].ToString());
                        //TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                    }
                    dr.Close();
                    saldocompra = CalcularSaldoCompra("BODEGA");
                    TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("VALLARTA"))
            {
                try
                {
                    con = BDConexicon.VallartaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG,SALDO FROM cuenxpag WHERE COMPRA ='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_cxp.Text = dr["CUENXPAG"].ToString();
                        saldocompra = Convert.ToDouble(dr["SALDO"].ToString());
                        //TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                    }
                    dr.Close();
                    saldocompra = CalcularSaldoCompra("VALLARTA");
                    TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("RENA"))
            {
                try
                {
                    con = BDConexicon.RenaOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG,SALDO FROM cuenxpag WHERE COMPRA ='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_cxp.Text = dr["CUENXPAG"].ToString();
                        saldocompra = Convert.ToDouble(dr["SALDO"].ToString());
                        //TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                    }
                    dr.Close();
                    saldocompra = CalcularSaldoCompra("RENA");
                    TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("COLOSO"))
            {
                try
                {
                    con = BDConexicon.ColosoOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG,SALDO FROM cuenxpag WHERE COMPRA ='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_cxp.Text = dr["CUENXPAG"].ToString();
                        saldocompra = Convert.ToDouble(dr["SALDO"].ToString());
                        //TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                    }
                    dr.Close();
                    saldocompra = CalcularSaldoCompra("COLOSO");
                    TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                try
                {
                    con = BDConexicon.VelazquezOpen();
                    MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG,SALDO FROM cuenxpag WHERE COMPRA ='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR ='" + TB_proveedor.Text + "'", con);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        TB_cxp.Text = dr["CUENXPAG"].ToString();
                        saldocompra = Convert.ToDouble(dr["SALDO"].ToString());
                        //TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                    }
                    dr.Close();
                    saldocompra = CalcularSaldoCompra("VELAZQUEZ");
                    TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR de conexión: " + ex);
                }
                con.Close();
            }

            //if (sucursal.Equals("PREGOT"))
            //{
            //    try
            //    {
            //        con = BDConexicon.Papeleria1Open();
            //        MySqlCommand cmd = new MySqlCommand("SELECT CUENXPAG,SALDO FROM cuenxpag WHERE COMPRA ='" + CB_cxpag.SelectedItem.ToString() + "' AND PROVEEDOR ='" + TB_proveedor.Text + "'", con);
            //        MySqlDataReader dr = cmd.ExecuteReader();

            //        while (dr.Read())
            //        {
            //            TB_cxp.Text = dr["CUENXPAG"].ToString();
            //            saldocompra = Convert.ToDouble(dr["SALDO"].ToString());
            //            //TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
            //        }
            //        dr.Close();
            //        saldocompra = CalcularSaldoCompra("PREGOT");
            //        TB_saldocompra.Text = String.Format("{0:0.##}", saldocompra.ToString("C"));
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show("ERROR de conexión: " + ex);
            //    }
            //    con.Close();
            //}


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TB_saldocompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TB_abono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_cod_TextChanged(object sender, EventArgs e)
        {

        }


        //TRAE LA CUENTA BANCARIA DEL BANCO SELECCIONADO REGISTRADO A UNA SUCURSAL
        private void CB_banco_osmart_SelectedIndexChanged(object sender, EventArgs e)
        {

            CB_cuenta_osmart.Items.Clear();
            CB_cuenta_osmart.Items.Add("");
            CB_cuenta_osmart.SelectedIndex = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT cuenta FROM rd_bancos_osmart WHERE banco='" + CB_banco_osmart.SelectedItem.ToString() + "' and tienda='"+ CB_sucBanco.SelectedItem.ToString()+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_cuenta_osmart.Items.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CB_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CB_persona.Items.Clear();
            CB_persona.Items.Add("");
            if (CB_cuenta.SelectedItem.ToString().Equals("EFECTIVO"))
            {
                
                CB_persona.Items.Add("EFECTIVO");
                CB_persona.SelectedIndex=1;
            }
            else
            {

                MySqlConnection con = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand("SELECT pagara FROM rd_cuentas_bancarias WHERE cuenta='" + CB_cuenta.SelectedItem.ToString() + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_persona.Items.Add(dr["pagara"].ToString());
                }
                dr.Close();
                con.Close();
            }
        }

        private void CB_cuenta_osmart_SelectedIndexChanged(object sender, EventArgs e)
        {

            TB_anombrede.Text = "";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT h.mov as movimiento,h.ie as ie,h.cantidad as cant FROM rd_historial_saldobancos h INNER JOIN rd_bancos_osmart b ON h.cuenta = b.cuenta " +
                "WHERE b.cuenta ='" + CB_cuenta_osmart.SelectedItem.ToString() + "'", con);

            MySqlDataReader dr = cmd.ExecuteReader();

            double suma = 0;
            double resta = 0;

            while (dr.Read())
            {

                if (dr["ie"].ToString().Equals("I"))
                {
                    suma += Convert.ToDouble(dr["cant"].ToString());
                }

                if (dr["ie"].ToString().Equals("E"))
                {
                    resta += Convert.ToDouble(dr["cant"].ToString());
                }

            }

            double saldo = suma - resta;
            TB_saldocuenta.Text = String.Format("{0:0.##}", saldo.ToString("C"));

            dr.Close();

            MySqlCommand cmd2 = new MySqlCommand("SELECT clientebancario FROM rd_bancos_osmart WHERE cuenta='" + CB_cuenta_osmart.SelectedItem.ToString() + "'", con);
            MySqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                TB_anombrede.Text = dr2["clientebancario"].ToString();
            }
            dr2.Close();
            con.Close();
        }

        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_banco.SelectedItem.ToString().Equals("EFECTIVO"))
            {
                CB_cuenta.Items.Add("");
                CB_cuenta.Items.Add("EFECTIVO");
                CB_cuenta.SelectedIndex = 1;
            }
            else
            {
                CB_cuenta.Items.Add("");
            }
           


      
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand("SELECT cuenta FROM rd_cuentas_bancarias WHERE banco='"+CB_banco.SelectedItem.ToString()+"' AND fk_proveedor='"+ TB_proveedor.Text+"'", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_cuenta.Items.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            con.Close();

            
        }

        private void CB_persona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       

        //################################################################################################

  

        //Devuelve el mes
        public string MesRespaldo(int mes)
        {
            string mesRespaldo = "";

            if (mes == 1)
            {
                mesRespaldo = "ENE";
            }
            if (mes == 2)
            {
                mesRespaldo = "FEB";
            }
            if (mes == 3)
            {
                mesRespaldo = "MAR";
            }
            if (mes == 4)
            {
                mesRespaldo = "ABR";
            }
            if (mes == 5)
            {
                mesRespaldo = "MAY";
            }
            if (mes == 6)
            {
                mesRespaldo = "JUN";
            }
            if (mes == 7)
            {
                mesRespaldo = "JUL";
            }
            if (mes == 8)
            {
                mesRespaldo = "AGO";
            }
            if (mes == 9)
            {
                mesRespaldo = "SEP";
            }
            if (mes == 10)
            {
                mesRespaldo = "OCT";
            }
            if (mes == 11)
            {
                mesRespaldo = "NOV";
            }
            if (mes == 12)
            {
                mesRespaldo = "DIC";
            }
            return mesRespaldo;
        }

        private void CHX_bancos_CheckedChanged(object sender, EventArgs e)
        {
            if (CHX_bancos.Checked)
            {
                CB_sucBanco.Enabled = true;
                CB_banco_osmart.Enabled = true;
                CB_cuenta_osmart.Enabled = true;
                TB_saldocuenta.Enabled = true;
                TB_anombrede.Enabled = true;
            }
            else
            {
                CB_sucBanco.Enabled = false;
                CB_banco_osmart.Enabled = false;
                CB_cuenta_osmart.Enabled = false;
                TB_saldocuenta.Enabled = false;
                TB_anombrede.Enabled = false;
            }

        }


        bool esAjuste = false;
        private void BT_ajuste_Click(object sender, EventArgs e)
        {
            esAjuste = true;
            int idAbono = ConsecAbono();
            int consec = ConsecAbonos();            
            DateTime fecha = DT_fecha.Value;
            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());

          
            decimal digito = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string cantidad = digito.ToString("G0");

            //INSERTA EL AJUSTE EN LA TABLA PAGOS
            MySqlCommand cmd = new MySqlCommand("INSERT INTO pagos(Abono,Proveedor, tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                           "VALUES(?Abono,?Proveedor,?tipo_doc,?No_referen,?Importe,?Moneda,?TC,ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)", conexion);
            cmd.Parameters.AddWithValue("?Abono", consec);
            cmd.Parameters.AddWithValue("?Proveedor", TB_proveedor.Text);
            cmd.Parameters.AddWithValue("?tipo_doc", "AJ");
            cmd.Parameters.AddWithValue("?No_referen", TB_referencia.Text);
            cmd.Parameters.AddWithValue("?Importe", Convert.ToDouble(cantidad));
            cmd.Parameters.AddWithValue("?Moneda", "MN");
            cmd.Parameters.AddWithValue("?TC", "1");
            cmd.Parameters.AddWithValue("?ImportBase", TB_abono.Text);
            cmd.Parameters.AddWithValue("?Cobrar", "");
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




           


            //INSERTAR EL AJUSTE EN LA TABLA CUENXPDET
            string query = "INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza) " +
                            "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)";
            MySqlCommand cuenxpdet = new MySqlCommand(query, conexion);
            cuenxpdet.Parameters.AddWithValue("?CUENXPAG", TB_cxp.Text);
            cuenxpdet.Parameters.AddWithValue("?PROVEEDOR", TB_proveedor.Text);
            cuenxpdet.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            cuenxpdet.Parameters.AddWithValue("?TIPO_DOC","AJ");
            cuenxpdet.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
            cuenxpdet.Parameters.AddWithValue("?Cargo_ab", "A");
            cuenxpdet.Parameters.AddWithValue("?IMPORTE", Convert.ToDouble(cantidad));
            cuenxpdet.Parameters.AddWithValue("?MONEDA", "MN");
            cuenxpdet.Parameters.AddWithValue("?TIP_CAM", "1");
            cuenxpdet.Parameters.AddWithValue("?COMPRA", CB_cxpag.SelectedItem.ToString());
            cuenxpdet.Parameters.AddWithValue("?COBRADOR", "");
            cuenxpdet.Parameters.AddWithValue("?OBSERV", idAbono);
            cuenxpdet.Parameters.AddWithValue("?CONTAB", "");
            cuenxpdet.Parameters.AddWithValue("?ABONO", consec);
            cuenxpdet.Parameters.AddWithValue("?USUARIO", usuario);
            cuenxpdet.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            cuenxpdet.Parameters.AddWithValue("?USUHORA", fecha.ToString("HH:mm:ss"));
            cuenxpdet.Parameters.AddWithValue("?ORDEN", "0");
            cuenxpdet.Parameters.AddWithValue("?poliza", "");
            cuenxpdet.ExecuteNonQuery();



            //INSERTAR EL AJUSTE EN LA TABLA RD_DESGLOSE_ABONO
            MySqlCommand desglose = new MySqlCommand("INSERT INTO rd_desglose_abonos(importe,fecha_pago,fecha_efe,compra,tipo,idabono,banco,cuenta,clientebancario) VALUES(?importe,?fecha_pago,?fecha_efe,?compra,?tipo,?idabono,?banco,?cuenta,?clientebancario)", conexion);
            MySqlConnection bo = BDConexicon.BodegaOpen();
            if (CHX_bancos.Checked==true)
            {
                double importe = Convert.ToDouble(TB_abono.Text);


                MySqlCommand cuenta = new MySqlCommand("INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,ref_gastoexterno,suc_pago) VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?ref_gastoexterno,?suc_pago) ", bo);
                cuenta.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                cuenta.Parameters.AddWithValue("?mov", "EFECTIVO");
                cuenta.Parameters.AddWithValue("?ie", "E");
                cuenta.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                cuenta.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                cuenta.Parameters.AddWithValue("?pagara", TB_anombrede.Text);
                cuenta.Parameters.AddWithValue("?cantidad", importe);
                cuenta.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                cuenta.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
                cuenta.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
                cuenta.Parameters.AddWithValue("?suc_pago", CB_sucursal.SelectedItem.ToString());
                cuenta.ExecuteNonQuery();


          
                desglose.Parameters.AddWithValue("?importe", importe);
                desglose.Parameters.AddWithValue("?fecha_pago", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?fecha_efe", fecha.ToString("yyyy-MM-dd"));
                desglose.Parameters.AddWithValue("?compra", CB_cxpag.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?tipo", "AJ");
                desglose.Parameters.AddWithValue("?idabono", idAbono);
                desglose.Parameters.AddWithValue("?banco", CB_banco_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?cuenta", CB_cuenta_osmart.SelectedItem.ToString());
                desglose.Parameters.AddWithValue("?clientebancario", TB_anombrede.Text);
                desglose.ExecuteNonQuery();


            }
           


                //INSERTAR ABONO EN TABLA FLUJO

                if (CHK_va.Checked == true)
                {
                    aplicarRetiroVA(Convert.ToString(idAbono));
                }

                if (CHK_re.Checked == true)
                {
                    aplicarRetiroRE(Convert.ToString(idAbono));
                }

                if (CHK_co.Checked == true)
                {
                    aplicarRetiroCO(Convert.ToString(idAbono));
                }

                if (CHK_ve.Checked == true)
                {
                    aplicarRetiroVE(Convert.ToString(idAbono));
                }
            



            //ACTUALIZAR EL CONSECUTIVO DE LOS ABONOS EN LA TABLA CONSEC
            MySqlCommand actualizarConsec = new MySqlCommand("UPDATE consec SET Consec ='" + consec + "'" + " where Dato ='ABONOPROV'", conexion);
            actualizarConsec.ExecuteNonQuery();

            idAbono++;
            MySqlCommand actualizaIDabono = new MySqlCommand("UPDATE consec SET Consec=" + idAbono + " WHERE Dato='consecAbono'", bo);
            actualizaIDabono.ExecuteNonQuery();

            bo.Close();



            //LIMPIAR ELEMENTOS
            TB_pagoVA.Text = "";
            TB_pagoRE.Text = "";
            TB_pagoCO.Text = "";
            TB_pagoVE.Text = "";
           

            TB_referencia.Text = "";
            TB_abono.Text = "";
            //CB_sucursal.SelectedIndex = 0;
            //CB_cxpag.SelectedIndex = 0;
            //CB_banco.SelectedIndex = 0;
            //CB_cuenta.SelectedIndex = 0;
            //CB_persona.SelectedIndex = 0;
            CHK_va.Checked = false;
            CHK_re.Checked = false;
            CHK_co.Checked = false;
            CHK_ve.Checked = false;
       

            conexion.Close();
            auditoria();
            MessageBox.Show("Se ha aplicado el ajuste en la compra");
        }

        private void TB_abono_KeyDown(object sender, KeyEventArgs e)
        {
           



        }

        private void Abonos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                decimal digito = decimal.Parse(TB_pagoVA.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string Retirova = digito.ToString("G0");

                decimal digito2 = decimal.Parse(TB_pagoRE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string Retirore = digito2.ToString("G0");

                decimal digito3 = decimal.Parse(TB_pagoVE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string Retirove = digito3.ToString("G0");

                decimal digito4 = decimal.Parse(TB_pagoCO.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string Retiroco = digito4.ToString("G0");

                double sumaTotal = Convert.ToDouble(Retirova) + Convert.ToDouble(Retirore) + Convert.ToDouble(Retirove) + Convert.ToDouble(Retiroco);

                TB_abono.Text = Convert.ToString(sumaTotal);
            }
        }

        private void Abonos_Enter(object sender, EventArgs e)
        {
            decimal digito = decimal.Parse(TB_pagoVA.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string Retirova = digito.ToString("G0");

            decimal digito2 = decimal.Parse(TB_pagoRE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string Retirore = digito2.ToString("G0");

            decimal digito3 = decimal.Parse(TB_pagoVE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string Retirove = digito3.ToString("G0");

            decimal digito4 = decimal.Parse(TB_pagoCO.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string Retiroco = digito4.ToString("G0");

            double sumaTotal = Convert.ToDouble(Retirova) + Convert.ToDouble(Retirore) + Convert.ToDouble(Retirove) + Convert.ToDouble(Retiroco);

            TB_abono.Text = Convert.ToString(sumaTotal);
        }



        #region ENTER PARA SUMAR DINERO DE TIENDAS
        private void TB_pagoVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                //string Retirova = ""; string Retirove = "";
                //string Retirore = ""; string Retiroco = "";
                //if (string.IsNullOrEmpty(TB_pagoVA.Text))
                //{
                //    Retirova = "0";
                //}
                //else
                //{
                //    decimal digito = decimal.Parse(TB_pagoVA.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                //    Retirova = digito.ToString("G0");
                //}


                //if (string.IsNullOrEmpty(TB_pagoRE.Text))
                //{
                //    Retirore = "0";
                //}
                //else
                //{
                //    decimal digito2 = decimal.Parse(TB_pagoRE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                //    Retirore = digito2.ToString("G0");
                //}

                //if (string.IsNullOrEmpty(TB_pagoVE.Text))
                //{
                //    Retirove = "0";
                //}
                //else
                //{
                //    decimal digito3 = decimal.Parse(TB_pagoVE.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                //    Retirove = digito3.ToString("G0");

                //}

                //if (string.IsNullOrEmpty(TB_pagoCO.Text))
                //{
                //    Retiroco = "0";
                //}
                //else
                //{
                //    decimal digito4 = decimal.Parse(TB_pagoCO.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                //    Retiroco = digito4.ToString("G0");

                //}

                string va = "";
                string re = "";
                string co = "";
                string ve = "";

                double efeva = 0;
                double efere = 0;
                double efeco = 0;
                double efeve = 0;

                double efepre = 0;


                //QUITO EL FORMATO DE MONEDA DE LAS CAJAS DE TEXTO DEL EFECTIVO DISPONIBLE EN TIENDAS
                try
                {
                    decimal digito = decimal.Parse(TB_efevallarta.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    va = digito.ToString("G0");

                    decimal digito2 = decimal.Parse(TB_eferena.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    re = digito2.ToString("G0");

                    decimal digito3 = decimal.Parse(TB_efecoloso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    co = digito3.ToString("G0");

                    decimal digito4 = decimal.Parse(TB_efevelazquez.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    ve = digito4.ToString("G0");

                    //decimal digito5 = decimal.Parse(TB_efepregot.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //pre = digito5.ToString("G0");

                    //GUARDO EL EFECTIVO DISPONIBLE EN TIENDAS EN ESTAS VARIABLES

                    efeva = Convert.ToDouble(va);
                    efere = Convert.ToDouble(re);
                    efeco = Convert.ToDouble(co);
                    efeve = Convert.ToDouble(ve);
                    //efepre = Convert.ToDouble(pre);

                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    MessageBox.Show("CALCULA EL EFECTIVO QUE HAY DISPONIBLE EN LAS TIENDAS");
                }




                //GUARDO LA CANTIDAD QUE TOMA DE CADA TIENDA
                double pagoVA = 0;
                double pagoRE = 0;
                double pagoCO = 0;
                double pagoVE = 0;
                double pagoPRE = 0;


                if (!TB_pagoVA.Text.Equals(""))
                {
                    pagoVA = Convert.ToDouble(TB_pagoVA.Text);
                }

                if (!TB_pagoRE.Text.Equals(""))
                {
                    pagoRE = Convert.ToDouble(TB_pagoRE.Text);
                }

                if (!TB_pagoCO.Text.Equals(""))
                {
                    pagoCO = Convert.ToDouble(TB_pagoCO.Text);
                }

                if (!TB_pagoVE.Text.Equals(""))
                {
                    pagoVE = Convert.ToDouble(TB_pagoVE.Text);
                }

                //if (!TB_pagoPRE.Text.Equals(""))
                //{
                //    pagoPRE = Convert.ToDouble(TB_pagoPRE.Text);
                //}
                //SE REALIZAN LAS OPERACIONES
                double sumaPago = pagoVA + pagoRE + pagoCO + pagoVE + pagoPRE;
                double totalVA = efeva - pagoVA;
                double totalRE = efere - pagoRE;
                double totalCO = efeco - pagoCO;
                double totalVE = efeve - pagoVE;
                //double totalPRE = efepre - pagoPRE;

                TB_efevallarta.Text = String.Format("{0:0.##}", totalVA.ToString("C"));
                TB_eferena.Text = String.Format("{0:0.##}", totalRE.ToString("C"));
                TB_efecoloso.Text = String.Format("{0:0.##}", totalCO.ToString("C"));
                TB_efevelazquez.Text = String.Format("{0:0.##}", totalVE.ToString("C"));
                //TB_efepregot.Text = String.Format("{0:0.##}", totalPRE.ToString("C"));

                TB_abono.Text = String.Format("{0:0.##}", sumaPago.ToString("C"));

                decimal aux = 0;
                if (TB_saldocompra.Text.Equals(""))
                {
                    aux = 0;
                }
                else
                {
                    aux = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                }

                double saldoComp = Convert.ToDouble(aux.ToString("G0"));
                double saldoNuevoComp = saldoComp - sumaPago;
                TB_abonoaplicado.Text = String.Format("{0:0.##}", saldoNuevoComp.ToString("C"));


                sumaPago = 0; totalVA = 0; totalRE = 0; totalCO = 0; totalVE = 0; /*totalPRE = 0;*/
                efeva = 0; efere = 0; efeco = 0; efeve = 0; efepre = 0;
                pagoVA = 0; pagoRE = 0; pagoCO = 0; pagoVE = 0; pagoPRE = 0;
                //SE VERIFICA SI SE COLOCO ALGUNA CANTIDAD EN LOS TEXTBOX PARA TOMAR EFECTIVO SI ES ASI, SE MARCA EL CHECKBOX CORRESPONDIENTE
                //PARA QUE EL SISTEMA SEPA A QUE TIENDA HARA LA INSERCION EN LA TABLA FLUJO, MAS ADELANTE
                if (!TB_pagoVA.Text.Equals(""))
                {
                    CHK_va.Checked = true;
                }

                if (!TB_pagoRE.Text.Equals(""))
                {
                    CHK_re.Checked = true;
                }

                if (!TB_pagoCO.Text.Equals(""))
                {
                    CHK_co.Checked = true;
                }

                if (!TB_pagoVE.Text.Equals(""))
                {
                    CHK_ve.Checked = true;
                }

                //if (!TB_pagoPRE.Text.Equals(""))
                //{
                //    CHK_pre.Checked = true;
                //}

                //double sumaTotal = pagoVA + pagoRE + pagoVE + pagoCO;

                //TB_abono.Text = Convert.ToString(sumaTotal);
                button2.Focus();
            }
        }

        private void TB_pagoRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string va = "";
                string re = "";
                string co = "";
                string ve = "";
#pragma warning disable CS0219 // La variable 'pre' está asignada pero su valor nunca se usa
                string pre = "";
#pragma warning restore CS0219 // La variable 'pre' está asignada pero su valor nunca se usa
                double efeva = 0;
                double efere = 0;
                double efeco = 0;
                double efeve = 0;
#pragma warning disable CS0219 // La variable 'efepre' está asignada pero su valor nunca se usa
                double efepre = 0;
#pragma warning restore CS0219 // La variable 'efepre' está asignada pero su valor nunca se usa

                //QUITO EL FORMATO DE MONEDA DE LAS CAJAS DE TEXTO DEL EFECTIVO DISPONIBLE EN TIENDAS
                try
                {
                    decimal digito = decimal.Parse(TB_efevallarta.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    va = digito.ToString("G0");

                    decimal digito2 = decimal.Parse(TB_eferena.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    re = digito2.ToString("G0");

                    decimal digito3 = decimal.Parse(TB_efecoloso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    co = digito3.ToString("G0");

                    decimal digito4 = decimal.Parse(TB_efevelazquez.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    ve = digito4.ToString("G0");

                    //decimal digito5 = decimal.Parse(TB_efepregot.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //pre = digito5.ToString("G0");

                    //GUARDO EL EFECTIVO DISPONIBLE EN TIENDAS EN ESTAS VARIABLES

                    efeva = Convert.ToDouble(va);
                    efere = Convert.ToDouble(re);
                    efeco = Convert.ToDouble(co);
                    efeve = Convert.ToDouble(ve);
                    //efepre = Convert.ToDouble(pre);

                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    MessageBox.Show("CALCULA EL EFECTIVO QUE HAY DISPONIBLE EN LAS TIENDAS");
                }




                //GUARDO LA CANTIDAD QUE TOMA DE CADA TIENDA
                double pagoVA = 0;
                double pagoRE = 0;
                double pagoCO = 0;
                double pagoVE = 0;
                double pagoPRE = 0;


                if (!TB_pagoVA.Text.Equals(""))
                {
                    pagoVA = Convert.ToDouble(TB_pagoVA.Text);
                }

                if (!TB_pagoRE.Text.Equals(""))
                {
                    pagoRE = Convert.ToDouble(TB_pagoRE.Text);
                }

                if (!TB_pagoCO.Text.Equals(""))
                {
                    pagoCO = Convert.ToDouble(TB_pagoCO.Text);
                }

                if (!TB_pagoVE.Text.Equals(""))
                {
                    pagoVE = Convert.ToDouble(TB_pagoVE.Text);
                }

                //if (!TB_pagoPRE.Text.Equals(""))
                //{
                //    pagoPRE = Convert.ToDouble(TB_pagoPRE.Text);
                //}
                //SE REALIZAN LAS OPERACIONES
                double sumaPago = pagoVA + pagoRE + pagoCO + pagoVE + pagoPRE;
                double totalVA = efeva - pagoVA;
                double totalRE = efere - pagoRE;
                double totalCO = efeco - pagoCO;
                double totalVE = efeve - pagoVE;
                //double totalPRE = efepre - pagoPRE;

                TB_efevallarta.Text = String.Format("{0:0.##}", totalVA.ToString("C"));
                TB_eferena.Text = String.Format("{0:0.##}", totalRE.ToString("C"));
                TB_efecoloso.Text = String.Format("{0:0.##}", totalCO.ToString("C"));
                TB_efevelazquez.Text = String.Format("{0:0.##}", totalVE.ToString("C"));
                //TB_efepregot.Text = String.Format("{0:0.##}", totalPRE.ToString("C"));

                TB_abono.Text = String.Format("{0:0.##}", sumaPago.ToString("C"));

                decimal aux = 0;
                if (TB_saldocompra.Text.Equals(""))
                {
                    aux = 0;
                }
                else
                {
                    aux = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                }

                double saldoComp = Convert.ToDouble(aux.ToString("G0"));
                double saldoNuevoComp = saldoComp - sumaPago;
                TB_abonoaplicado.Text = String.Format("{0:0.##}", saldoNuevoComp.ToString("C"));


                sumaPago = 0; totalVA = 0; totalRE = 0; totalCO = 0; totalVE = 0; /*totalPRE = 0;*/
                efeva = 0; efere = 0; efeco = 0; efeve = 0; efepre = 0;
                pagoVA = 0; pagoRE = 0; pagoCO = 0; pagoVE = 0; pagoPRE = 0;
                //SE VERIFICA SI SE COLOCO ALGUNA CANTIDAD EN LOS TEXTBOX PARA TOMAR EFECTIVO SI ES ASI, SE MARCA EL CHECKBOX CORRESPONDIENTE
                //PARA QUE EL SISTEMA SEPA A QUE TIENDA HARA LA INSERCION EN LA TABLA FLUJO, MAS ADELANTE
                if (!TB_pagoVA.Text.Equals(""))
                {
                    CHK_va.Checked = true;
                }

                if (!TB_pagoRE.Text.Equals(""))
                {
                    CHK_re.Checked = true;
                }

                if (!TB_pagoCO.Text.Equals(""))
                {
                    CHK_co.Checked = true;
                }

                if (!TB_pagoVE.Text.Equals(""))
                {
                    CHK_ve.Checked = true;
                }
                button2.Focus();
            }
        }

        private void TB_pagoVE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                string va = "";
                string re = "";
                string co = "";
                string ve = "";
#pragma warning disable CS0219 // La variable 'pre' está asignada pero su valor nunca se usa
                string pre = "";
#pragma warning restore CS0219 // La variable 'pre' está asignada pero su valor nunca se usa
                double efeva = 0;
                double efere = 0;
                double efeco = 0;
                double efeve = 0;
#pragma warning disable CS0219 // La variable 'efepre' está asignada pero su valor nunca se usa
                double efepre = 0;
#pragma warning restore CS0219 // La variable 'efepre' está asignada pero su valor nunca se usa

                //QUITO EL FORMATO DE MONEDA DE LAS CAJAS DE TEXTO DEL EFECTIVO DISPONIBLE EN TIENDAS
                try
                {
                    decimal digito = decimal.Parse(TB_efevallarta.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    va = digito.ToString("G0");

                    decimal digito2 = decimal.Parse(TB_eferena.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    re = digito2.ToString("G0");

                    decimal digito3 = decimal.Parse(TB_efecoloso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    co = digito3.ToString("G0");

                    decimal digito4 = decimal.Parse(TB_efevelazquez.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    ve = digito4.ToString("G0");

                    //decimal digito5 = decimal.Parse(TB_efepregot.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //pre = digito5.ToString("G0");

                    //GUARDO EL EFECTIVO DISPONIBLE EN TIENDAS EN ESTAS VARIABLES

                    efeva = Convert.ToDouble(va);
                    efere = Convert.ToDouble(re);
                    efeco = Convert.ToDouble(co);
                    efeve = Convert.ToDouble(ve);
                    //efepre = Convert.ToDouble(pre);

                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    MessageBox.Show("CALCULA EL EFECTIVO QUE HAY DISPONIBLE EN LAS TIENDAS");
                }




                //GUARDO LA CANTIDAD QUE TOMA DE CADA TIENDA
                double pagoVA = 0;
                double pagoRE = 0;
                double pagoCO = 0;
                double pagoVE = 0;
                double pagoPRE = 0;


                if (!TB_pagoVA.Text.Equals(""))
                {
                    pagoVA = Convert.ToDouble(TB_pagoVA.Text);
                }

                if (!TB_pagoRE.Text.Equals(""))
                {
                    pagoRE = Convert.ToDouble(TB_pagoRE.Text);
                }

                if (!TB_pagoCO.Text.Equals(""))
                {
                    pagoCO = Convert.ToDouble(TB_pagoCO.Text);
                }

                if (!TB_pagoVE.Text.Equals(""))
                {
                    pagoVE = Convert.ToDouble(TB_pagoVE.Text);
                }

                //if (!TB_pagoPRE.Text.Equals(""))
                //{
                //    pagoPRE = Convert.ToDouble(TB_pagoPRE.Text);
                //}
                //SE REALIZAN LAS OPERACIONES
                double sumaPago = pagoVA + pagoRE + pagoCO + pagoVE + pagoPRE;
                double totalVA = efeva - pagoVA;
                double totalRE = efere - pagoRE;
                double totalCO = efeco - pagoCO;
                double totalVE = efeve - pagoVE;
                //double totalPRE = efepre - pagoPRE;

                TB_efevallarta.Text = String.Format("{0:0.##}", totalVA.ToString("C"));
                TB_eferena.Text = String.Format("{0:0.##}", totalRE.ToString("C"));
                TB_efecoloso.Text = String.Format("{0:0.##}", totalCO.ToString("C"));
                TB_efevelazquez.Text = String.Format("{0:0.##}", totalVE.ToString("C"));
                //TB_efepregot.Text = String.Format("{0:0.##}", totalPRE.ToString("C"));

                TB_abono.Text = String.Format("{0:0.##}", sumaPago.ToString("C"));

                decimal aux = 0;
                if (TB_saldocompra.Text.Equals(""))
                {
                    aux = 0;
                }
                else
                {
                    aux = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                }

                double saldoComp = Convert.ToDouble(aux.ToString("G0"));
                double saldoNuevoComp = saldoComp - sumaPago;
                TB_abonoaplicado.Text = String.Format("{0:0.##}", saldoNuevoComp.ToString("C"));


                sumaPago = 0; totalVA = 0; totalRE = 0; totalCO = 0; totalVE = 0; /*totalPRE = 0;*/
                efeva = 0; efere = 0; efeco = 0; efeve = 0; efepre = 0;
                pagoVA = 0; pagoRE = 0; pagoCO = 0; pagoVE = 0; pagoPRE = 0;
                //SE VERIFICA SI SE COLOCO ALGUNA CANTIDAD EN LOS TEXTBOX PARA TOMAR EFECTIVO SI ES ASI, SE MARCA EL CHECKBOX CORRESPONDIENTE
                //PARA QUE EL SISTEMA SEPA A QUE TIENDA HARA LA INSERCION EN LA TABLA FLUJO, MAS ADELANTE
                if (!TB_pagoVA.Text.Equals(""))
                {
                    CHK_va.Checked = true;
                }

                if (!TB_pagoRE.Text.Equals(""))
                {
                    CHK_re.Checked = true;
                }

                if (!TB_pagoCO.Text.Equals(""))
                {
                    CHK_co.Checked = true;
                }

                if (!TB_pagoVE.Text.Equals(""))
                {
                    CHK_ve.Checked = true;
                }

                button2.Focus();
            }
        }

        private void TB_pagoCO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                string va = "";
                string re = "";
                string co = "";
                string ve = "";
#pragma warning disable CS0219 // La variable 'pre' está asignada pero su valor nunca se usa
                string pre = "";
#pragma warning restore CS0219 // La variable 'pre' está asignada pero su valor nunca se usa
                double efeva = 0;
                double efere = 0;
                double efeco = 0;
                double efeve = 0;
#pragma warning disable CS0219 // La variable 'efepre' está asignada pero su valor nunca se usa
                double efepre = 0;
#pragma warning restore CS0219 // La variable 'efepre' está asignada pero su valor nunca se usa

                //QUITO EL FORMATO DE MONEDA DE LAS CAJAS DE TEXTO DEL EFECTIVO DISPONIBLE EN TIENDAS
                try
                {
                    decimal digito = decimal.Parse(TB_efevallarta.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    va = digito.ToString("G0");

                    decimal digito2 = decimal.Parse(TB_eferena.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    re = digito2.ToString("G0");

                    decimal digito3 = decimal.Parse(TB_efecoloso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    co = digito3.ToString("G0");

                    decimal digito4 = decimal.Parse(TB_efevelazquez.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    ve = digito4.ToString("G0");

                    //decimal digito5 = decimal.Parse(TB_efepregot.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    //pre = digito5.ToString("G0");

                    //GUARDO EL EFECTIVO DISPONIBLE EN TIENDAS EN ESTAS VARIABLES

                    efeva = Convert.ToDouble(va);
                    efere = Convert.ToDouble(re);
                    efeco = Convert.ToDouble(co);
                    efeve = Convert.ToDouble(ve);
                    //efepre = Convert.ToDouble(pre);

                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    MessageBox.Show("CALCULA EL EFECTIVO QUE HAY DISPONIBLE EN LAS TIENDAS");
                }




                //GUARDO LA CANTIDAD QUE TOMA DE CADA TIENDA
                double pagoVA = 0;
                double pagoRE = 0;
                double pagoCO = 0;
                double pagoVE = 0;
                double pagoPRE = 0;


                if (!TB_pagoVA.Text.Equals(""))
                {
                    pagoVA = Convert.ToDouble(TB_pagoVA.Text);
                }

                if (!TB_pagoRE.Text.Equals(""))
                {
                    pagoRE = Convert.ToDouble(TB_pagoRE.Text);
                }

                if (!TB_pagoCO.Text.Equals(""))
                {
                    pagoCO = Convert.ToDouble(TB_pagoCO.Text);
                }

                if (!TB_pagoVE.Text.Equals(""))
                {
                    pagoVE = Convert.ToDouble(TB_pagoVE.Text);
                }

                //if (!TB_pagoPRE.Text.Equals(""))
                //{
                //    pagoPRE = Convert.ToDouble(TB_pagoPRE.Text);
                //}
                //SE REALIZAN LAS OPERACIONES
                double sumaPago = pagoVA + pagoRE + pagoCO + pagoVE + pagoPRE;
                double totalVA = efeva - pagoVA;
                double totalRE = efere - pagoRE;
                double totalCO = efeco - pagoCO;
                double totalVE = efeve - pagoVE;
                //double totalPRE = efepre - pagoPRE;

                TB_efevallarta.Text = String.Format("{0:0.##}", totalVA.ToString("C"));
                TB_eferena.Text = String.Format("{0:0.##}", totalRE.ToString("C"));
                TB_efecoloso.Text = String.Format("{0:0.##}", totalCO.ToString("C"));
                TB_efevelazquez.Text = String.Format("{0:0.##}", totalVE.ToString("C"));
                //TB_efepregot.Text = String.Format("{0:0.##}", totalPRE.ToString("C"));

                TB_abono.Text = String.Format("{0:0.##}", sumaPago.ToString("C"));

                decimal aux = 0;
                if (TB_saldocompra.Text.Equals(""))
                {
                    aux = 0;
                }
                else
                {
                    aux = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                }

                double saldoComp = Convert.ToDouble(aux.ToString("G0"));
                double saldoNuevoComp = saldoComp - sumaPago;
                TB_abonoaplicado.Text = String.Format("{0:0.##}", saldoNuevoComp.ToString("C"));


                sumaPago = 0; totalVA = 0; totalRE = 0; totalCO = 0; totalVE = 0; /*totalPRE = 0;*/
                efeva = 0; efere = 0; efeco = 0; efeve = 0; efepre = 0;
                pagoVA = 0; pagoRE = 0; pagoCO = 0; pagoVE = 0; pagoPRE = 0;
                //SE VERIFICA SI SE COLOCO ALGUNA CANTIDAD EN LOS TEXTBOX PARA TOMAR EFECTIVO SI ES ASI, SE MARCA EL CHECKBOX CORRESPONDIENTE
                //PARA QUE EL SISTEMA SEPA A QUE TIENDA HARA LA INSERCION EN LA TABLA FLUJO, MAS ADELANTE
                if (!TB_pagoVA.Text.Equals(""))
                {
                    CHK_va.Checked = true;
                }

                if (!TB_pagoRE.Text.Equals(""))
                {
                    CHK_re.Checked = true;
                }

                if (!TB_pagoCO.Text.Equals(""))
                {
                    CHK_co.Checked = true;
                }

                if (!TB_pagoVE.Text.Equals(""))
                {
                    CHK_ve.Checked = true;
                }

                button2.Focus();
            }
        }



        #endregion



        //EJECUTA EL MÉTODO BancosOsmart
        private void CB_sucBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            BancosOsmart();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void TB_cxp_TextChanged(object sender, EventArgs e)
        {

        }



        private void TB_abono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_abono.Text.Equals(""))
            {
                decimal digito = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                double saldo = Convert.ToDouble(digito.ToString("G0"));

                double abono = 0;
                double abonoAplicado = saldo - abono;

                TB_abonoaplicado.Text = String.Format("{0:0.##}", abonoAplicado.ToString("C"));
            }
            else
            {

                decimal digito = decimal.Parse(TB_saldocompra.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                double saldo = Convert.ToDouble(digito.ToString("G0"));


                decimal digito2 = decimal.Parse(TB_abono.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                double abono = Convert.ToDouble(digito2.ToString("G0"));
                double abonoAplicado = saldo - abono;

                TB_abonoaplicado.Text = String.Format("{0:0.##}", abonoAplicado.ToString("C"));
            }

            }
        }

 

        public void Traerefectivo()
        {
            TB_efevallarta.Text = "";
            TB_eferena.Text = "";
            TB_efecoloso.Text = "";
            TB_efevelazquez.Text = "";
            //TB_efepregot.Text = "";
            try
            {

                if (CHX_bd_va.Checked)
                {
                    EfectivoVA();
                }
              
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                LB_va.ForeColor = Color.Red;
            }

            try
            {
                if (CHX_bd_re.Checked)
                {
                    EfectivoRE();
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                LB_re.ForeColor = Color.Red;
            }

            try
            {
                if(CHX_bd_co.Checked)
                {
                    EfectivoCO();
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                LB_co.ForeColor = Color.Red;
            }

            try
            {
              if(CHX_bd_ve.Checked)
                {
                    EfectivoVE();
                }

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                LB_ve.ForeColor = Color.Red;
            }

            //try
            //{

            //    if (CHX_bd_pre.Checked)
            //    {
            //        EfectivoPRE();
            //    }

            //}
            //catch (Exception ex)
            //{
            //    LB_pre.ForeColor = Color.Red;
            //}

            //if (cont > 0)
            //{
            //    MessageBox.Show("EL EFECTIVO AUN NO ESTÁ DISPONIBLE EN: " + mensaje);
            //}


        }

        //EJECUTA LOS METODOS DE EFECTIVO
        public void button1_Click(object sender, EventArgs e)
        {
            TB_pagoVA.Text = "";
            TB_pagoRE.Text = "";
            TB_pagoCO.Text = "";
            TB_pagoVE.Text = "";
            //TB_pagoPRE.Text = "";
            TB_abono.Text = "";
            TB_abonoaplicado.Text = "";
            CHK_va.Checked = false;
            CHK_re.Checked = false;
            CHK_co.Checked = false;
            CHK_ve.Checked = false;
            //CHK_pre.Checked = false;

            Traerefectivo();

        }


        //############### LOS METODOS DE EFECTIVO TRAEN EL EFECTIVO DISPONIBLE EN LAS TIENDAS ###################################################
        public void EfectivoVA()
        {

            efeVA = 0;
            if (CHK_respaldo.Checked == true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);

                LB_va.ForeColor = Color.Black;
                double retiroVA = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, " +
                    "flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where  fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RespaldoVA(mesRespaldo,año);

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_va.ForeColor = Color.DarkGreen;
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") ||concepto.Equals("ALBR") || concepto.Equals("CCDIS") || concepto.Equals("CINO") || concepto.Equals("CGRAL") || concepto.Equals("FNZAS") || concepto.Equals("CCDMX") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                        {
                            retiroVA += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeVA = Convert.ToDouble(dr["Importe"].ToString());
                        }


                    }

                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_va.ForeColor = Color.Red;
                    TB_efevallarta.Text = "$0.00";
                }

                double disponible = efeVA - retiroVA;
                TB_efevallarta.Text = String.Format("{0:0.##}", disponible.ToString("C"));
                con.Close();
            }
            else
            {
                LB_va.ForeColor = Color.Black;
                double retiroVA = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, " +
                    "flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where  fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.VallartaOpen();


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_va.ForeColor = Color.DarkGreen;
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CCDIS") || concepto.Equals("CINO") || concepto.Equals("CGRAL") || concepto.Equals("FNZAS") || concepto.Equals("CCDMX") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                        {
                            retiroVA += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeVA = Convert.ToDouble(dr["Importe"].ToString());
                        }


                    }

                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_va.ForeColor = Color.Red;
                    TB_efevallarta.Text = "$0.00";
                }

                double disponible = efeVA - retiroVA;
                TB_efevallarta.Text = String.Format("{0:0.##}", disponible.ToString("C"));


                con.Close();
            }



            
        }

        public void EfectivoRE()
        {
            efeRE = 0;
            if (CHK_respaldo.Checked == true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);

                LB_re.ForeColor = Color.Black;
                DateTime fecha = DT_fecha.Value;
                double retiroRE = 0;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RespaldoRE(mesRespaldo,año);


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_re.ForeColor = Color.DarkGreen;

                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CCDIS") || concepto.Equals("CINO") || concepto.Equals("CGRAL") || concepto.Equals("FNZAS") || concepto.Equals("CCDMX") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                        {
                            retiroRE += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeRE = Convert.ToDouble(dr["Importe"].ToString());
                        }

                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " RENA ";
                    //}
                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_re.ForeColor = Color.Red;
                    TB_eferena.Text = "$0.00";
                }

                double disponible = efeRE - retiroRE;
                TB_eferena.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();

            }
            else
            {
                LB_re.ForeColor = Color.Black;
                DateTime fecha = DT_fecha.Value;
                double retiroRE = 0;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RenaOpen();


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_re.ForeColor = Color.DarkGreen;

                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CCDIS") || concepto.Equals("CINO") || concepto.Equals("CGRAL") || concepto.Equals("FNZAS") || concepto.Equals("CCDMX") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                        {
                            retiroRE += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeRE = Convert.ToDouble(dr["Importe"].ToString());
                        }

                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " RENA ";
                    //}
                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_re.ForeColor = Color.Red;
                    TB_eferena.Text = "$0.00";
                }

                double disponible = efeRE - retiroRE;
                TB_eferena.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();
            }



              
        }

        public void EfectivoCO()
        {
            efeCO = 0;
            if (CHK_respaldo.Checked == true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);

                LB_co.ForeColor = Color.Black;
                double retiroCO = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RespaldoCO(mesRespaldo,año);


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_co.ForeColor = Color.DarkGreen;
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CCDIS") || concepto.Equals("CINO") || concepto.Equals("CGRAL") || concepto.Equals("FNZAS") || concepto.Equals("CCDMX") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                        {
                            retiroCO += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeCO = Convert.ToDouble(dr["Importe"].ToString());
                        }


                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " COLOSO ";
                    //}
                    dr.Close();
                }

                catch (Exception ex)

                {

                    LB_co.ForeColor = Color.Red;
                    TB_efecoloso.Text = "$0.00";
                }
                double disponible = efeCO - retiroCO;
                TB_efecoloso.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();

            }
            else
            {

                LB_co.ForeColor = Color.Black;
                double retiroCO = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.ColosoOpen();


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_co.ForeColor = Color.DarkGreen;
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CCDIS") || concepto.Equals("CINO") || concepto.Equals("CGRAL") || concepto.Equals("FNZAS") || concepto.Equals("CCDMX") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                        {
                            retiroCO += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeCO = Convert.ToDouble(dr["Importe"].ToString());
                        }


                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " COLOSO ";
                    //}
                    dr.Close();
                }

                catch (Exception ex)

                {

                    LB_co.ForeColor = Color.Red;
                    TB_efecoloso.Text = "$0.00";
                }
                double disponible = efeCO - retiroCO;
                TB_efecoloso.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();
            }



        }

        public void EfectivoVE()
        {
            efeVE = 0;
            if (CHK_respaldo.Checked == true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);

                LB_ve.ForeColor = Color.Black;
                double retiroVE = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RespaldoVE(mesRespaldo,año);


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_ve.ForeColor = Color.DarkGreen;

                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CCDIS") || concepto.Equals("CINO") || concepto.Equals("CGRAL") || concepto.Equals("FNZAS") || concepto.Equals("CCDMX") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                        {
                            retiroVE += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeVE = Convert.ToDouble(dr["Importe"].ToString());
                        }

                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " VELAZQUEZ ";
                    //}
                    dr.Close();
                }

                catch (Exception ex)

                {

                    LB_ve.ForeColor = Color.Red;
                    TB_efevelazquez.Text = "$0.00";
                }

                double disponible = efeVE - retiroVE;
                TB_efevelazquez.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();

            }
            else
            {
                LB_ve.ForeColor = Color.Black;
                double retiroVE = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.VelazquezOpen();


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_ve.ForeColor = Color.DarkGreen;

                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CCDIS") || concepto.Equals("CINO") || concepto.Equals("CGRAL") || concepto.Equals("FNZAS") || concepto.Equals("CCDMX") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                        {
                            retiroVE += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeVE = Convert.ToDouble(dr["Importe"].ToString());
                        }

                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " VELAZQUEZ ";
                    //}
                    dr.Close();
                }

                catch (Exception ex)

                {

                    LB_ve.ForeColor = Color.Red;
                    TB_efevelazquez.Text = "$0.00";
                }

                double disponible = efeVE - retiroVE;
                TB_efevelazquez.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();
            }



              
        }

        //public void EfectivoPRE()
        //{


        //    if (CHK_respaldo.Checked == true)
        //    {
        //        int mes = DT_fecha.Value.Month;
        //        int año = DT_fecha.Value.Year;

        //        string mesRespaldo = MesRespaldo(mes);

        //        LB_pre.ForeColor = Color.Black;
        //        double retiroPRE = 0;
        //        DateTime fecha = DT_fecha.Value;
        //        string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
        //        "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";


        //        MySqlConnection con = null;

        //        try
        //        {
        //            con = BDConexicon.RespaldoPRE(mesRespaldo,año);
        //            MySqlCommand cmd = new MySqlCommand(query, con);
        //            MySqlDataReader dr = cmd.ExecuteReader();

        //            if (dr.HasRows)
        //            {
        //                while (dr.Read())
        //                {
        //                    LB_pre.ForeColor = Color.DarkGreen;

        //                    string concepto = dr["concepto2"].ToString();
        //                    if (concepto.Equals("RPPP") || concepto.Equals("RBAN"))
        //                    {
        //                        retiroPRE += Convert.ToDouble(dr["Importe"].ToString());
        //                    }

        //                    if (concepto.Equals("Retir"))
        //                    {
        //                        efePRE = Convert.ToDouble(dr["Importe"].ToString());
        //                    }

        //                }
        //            }
        //            else
        //            {
        //                efePRE = 0;
        //                retiroPRE = 0;
        //            }


        //            dr.Close();
        //        }
        //        catch (Exception ex)
        //        {

        //            LB_pre.ForeColor = Color.Red;
        //            TB_efepregot.Text = "$0.00";
        //        }
        //        double disponible = efePRE - retiroPRE;
        //        TB_efepregot.Text = String.Format("{0:0.##}", disponible.ToString("C"));

        //        con.Close();

        //    }
        //    else
        //    {

        //        LB_pre.ForeColor = Color.Black;
        //        double retiroPRE = 0;
        //        DateTime fecha = DT_fecha.Value;
        //        string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
        //        "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";


        //        MySqlConnection con = null;

        //        try
        //        {
        //            con = BDConexicon.Papeleria1Open();
        //            MySqlCommand cmd = new MySqlCommand(query, con);
        //            MySqlDataReader dr = cmd.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                LB_pre.ForeColor = Color.DarkGreen;

        //                string concepto = dr["concepto2"].ToString();
        //                if (concepto.Equals("RPPP") || concepto.Equals("RBAN"))
        //                {
        //                    retiroPRE += Convert.ToDouble(dr["Importe"].ToString());
        //                }

        //                if (concepto.Equals("Retir"))
        //                {
        //                    efePRE = Convert.ToDouble(dr["Importe"].ToString());
        //                }

        //            }
        //            //else
        //            //{
        //            //    cont++;
        //            //    mensaje += " PREGOT ";
        //            //}
        //            dr.Close();
        //        }
        //        catch (Exception ex)
        //        {

        //            LB_pre.ForeColor = Color.Red;
        //            TB_efepregot.Text = "$0.00";
        //        }
        //        double disponible = efePRE - retiroPRE;
        //        TB_efepregot.Text = String.Format("{0:0.##}", disponible.ToString("C"));

        //        con.Close();
        //    }





        //}
        //######################################################################################################################################


        public void RegistrarAccesos(string modulo)
        {
            string query = "INSERT INTO rd_log_acceso_modulos(usuario,fecha,hora,ip,nombre_equipo,modulo)VALUES(?usuario,?fecha,?hora,?ip,?nombre_equipo,?modulo)";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            DateTime fecha = DateTime.Now;
            string nombre_equipo = Environment.MachineName;

            IPHostEntry host;
            string ip = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in host.AddressList)
            {
                if (IP.AddressFamily.ToString() == "InterNetwork")
                {
                    ip = IP.ToString();
                }
            }

            cmd.Parameters.AddWithValue("?usuario", usuario);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?ip", ip);
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?modulo", modulo);
            cmd.ExecuteNonQuery();
        }

        //TRAE LOS BANCOS DE LA EMPRESA
        public void BancosOsmart()
        {

            CB_banco_osmart.Items.Clear();
            CB_banco_osmart.Items.Add("");
            CB_banco_osmart.SelectedIndex = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            //TRAE LOS BANCOS SIN REPETIR QUE ESTAN REGISTRADOS EN LA SUCURSAL SELECCIONADA
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT banco FROM rd_bancos_osmart where tienda ='"+CB_sucBanco.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_banco_osmart.Items.Add(dr["banco"].ToString());
            }

            dr.Close();
            con.Close();
        }

        private void Porpagar_Load(object sender, EventArgs e)
        {
            
            TB_nombre.Text = nombre;
            TB_proveedor.Text = proveedor;
            TB_saldo_proveedor.Text = String.Format("{0:0.##}", saldo.ToString("C"));
            Bancos();
            
            if (TB_proveedor.Text.Equals("000001"))
            {
               
                //CB_persona.Enabled = false;
                //CB_banco.Enabled = false;
                //CB_cuenta.Enabled = false;

                CB_banco.Items.Clear();

                CB_banco.Items.Add("");
                CB_banco.Items.Add("");
                CB_banco.Items.Add("EFECTIVO");
                CB_banco.SelectedIndex = 2;
                //CB_cuenta.Items.Add("");
                //CB_cuenta.Items.Add("EFECTIVO");
                CB_cuenta.SelectedIndex = 1;
                CB_persona.Items.Add("");
         
                CB_persona.SelectedIndex = 1;
            }




            string modulo = this.Name;
            RegistrarAccesos(modulo);




        }

        public void estadoChecks(int va,int re,int ve,int co)
        {

            
            if (va==1)
            {
                CHX_bd_va.Checked = true;
            }
            else
            {
                CHX_bd_va.Checked = false;
            }


            if (re == 1)
            {
                CHX_bd_re.Checked = true;
            }
            else
            {
                CHX_bd_re.Checked = false;
            }


            if (ve== 1)
            {
                CHX_bd_ve.Checked = true;
            }
            else
            {
                CHX_bd_ve.Checked = false;
            }


            if (co == 1)
            {
                CHX_bd_co.Checked = true;
            }
            else
            {
                CHX_bd_co.Checked = false;
            }


            //if (pre == 1)
            //{
            //    CHX_bd_pre.Checked = true;
            //}
            //else
            //{
            //    CHX_bd_pre.Checked = false;
            //}
        }

        public void auditoria()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "INSERT INTO rd_log_abonos(nombre_equipo,ip,usuario,fecha_abono,hora,fecha_efectivo,dinero_va,dinero_re,dinero_ve,dinero_co,abono,fk_proveedor,banco_prov,num_cuenta_prov,cliente_bancario,tipo_pago,sucursal_compra,sucursal_cuenta_osmart,banco_osmart,cuenta_osmart,cliente_bancario_osmart,num_compra,referencia)" +
                "VALUES(?nombre_equipo,?ip,?usuario,?fecha_abono,?hora,?fecha_efectivo,?dinero_va,?dinero_re,?dinero_ve,?dinero_co,?abono,?fk_proveedor,?banco_prov,?num_cuenta_prov,?cliente_bancario,?tipo_pago,?sucursal_compra,?sucursal_cuenta_osmart,?banco_osmart,?cuenta_osmart,?cliente_bancario_osmart,?num_compra,?referencia)";
            MySqlCommand cmd = new MySqlCommand(query,conexion);

            string nombreEquipo = Environment.MachineName;


            IPHostEntry host;
            string ip= "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in host.AddressList)
            {
                if (IP.AddressFamily.ToString() == "InterNetwork")
                {
                    ip = IP.ToString();
                }
            }

            DateTime fecha = DateTime.Now;
            DateTime fechaAbono = DT_fecha.Value;

            double va = 0, re = 0, ve = 0, co = 0;

            if (TB_pagoVA.Text.Equals(""))
            {
                va = 0;
            }
            else
            {
                va = Convert.ToDouble(TB_pagoVA.Text);
            }


            if (TB_pagoRE.Text.Equals(""))
            {
                re = 0;
            }
            else
            {
                re = Convert.ToDouble(TB_pagoRE.Text);
            }

            if (TB_pagoVE.Text.Equals(""))
            {
                ve = 0;
            }
            else
            {
                ve = Convert.ToDouble(TB_pagoVE.Text);
            }


            if (TB_pagoCO.Text.Equals(""))
            {
                co = 0;
            }
            else
            {
                co = Convert.ToDouble(TB_pagoCO.Text);
            }



            
            if (CHX_bancos.Checked == true)
            {
                cmd.Parameters.AddWithValue("?nombre_equipo", nombreEquipo);
                cmd.Parameters.AddWithValue("?ip", ip);
                cmd.Parameters.AddWithValue("?usuario", usuario);
                cmd.Parameters.AddWithValue("?fecha_abono", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("?fecha_efectivo", fechaAbono.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?dinero_va", TB_pagoVA.Text);
                cmd.Parameters.AddWithValue("?dinero_re", TB_pagoRE.Text);
                cmd.Parameters.AddWithValue("?dinero_ve", TB_pagoVE.Text);
                cmd.Parameters.AddWithValue("?dinero_co", TB_pagoCO.Text);
                cmd.Parameters.AddWithValue("?abono", va+re+ve+co);
                cmd.Parameters.AddWithValue("?fk_proveedor", TB_proveedor.Text);
                cmd.Parameters.AddWithValue("?banco_prov", CB_banco.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?num_cuenta_prov", CB_cuenta.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?cliente_bancario", CB_persona.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?tipo_pago", CB_tipodoc.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?sucursal_compra", CB_sucursal.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?sucursal_cuenta_osmart", CB_sucBanco.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?banco_osmart", CB_banco_osmart.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?cuenta_osmart", CB_cuenta_osmart.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?cliente_bancario_osmart", TB_anombrede.Text);
                cmd.Parameters.AddWithValue("?num_compra", CB_cxpag.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.Parameters.AddWithValue("?nombre_equipo", nombreEquipo);
                cmd.Parameters.AddWithValue("?ip", ip);
                cmd.Parameters.AddWithValue("?usuario", usuario);
                cmd.Parameters.AddWithValue("?fecha_abono", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("?fecha_efectivo", fechaAbono.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?dinero_va", TB_pagoVA.Text);
                cmd.Parameters.AddWithValue("?dinero_re", TB_pagoRE.Text);
                cmd.Parameters.AddWithValue("?dinero_ve", TB_pagoVE.Text);
                cmd.Parameters.AddWithValue("?dinero_co", TB_pagoCO.Text);
                cmd.Parameters.AddWithValue("?abono", va + re + ve + co);
                cmd.Parameters.AddWithValue("?fk_proveedor", TB_proveedor.Text);
                cmd.Parameters.AddWithValue("?banco_prov", CB_banco.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?num_cuenta_prov", CB_cuenta.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?cliente_bancario", CB_persona.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?tipo_pago", CB_tipodoc.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?sucursal_compra", CB_sucursal.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?sucursal_cuenta_osmart", "");
                cmd.Parameters.AddWithValue("?banco_osmart", "");
                cmd.Parameters.AddWithValue("?cuenta_osmart", "");
                cmd.Parameters.AddWithValue("?cliente_bancario_osmart", "");
                cmd.Parameters.AddWithValue("?num_compra", CB_cxpag.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                cmd.ExecuteNonQuery();
            }
            



        }
    }
}
