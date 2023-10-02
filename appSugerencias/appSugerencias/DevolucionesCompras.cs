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
    public partial class DevolucionesCompras : Form
    {

        string usuario = "";
        public DevolucionesCompras(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        DataTable artCompra = new DataTable();
        List<string> artDevolucion = new List<string>();

        private void DevolucionesCompras_Load(object sender, EventArgs e)
        {


            Proveedor p = new Proveedor();
            ArrayList proveedores = p.Proveedores();
            for (int i = 0; i < proveedores.Count; i++)
            {
                CB_proveedores.Items.Add(proveedores[i]);
            }

            //DG_tabla.Columns["ARTICULO"].Width = 130;
            //DG_tabla.Columns["DESCRIPCION"].Width = 270;
           
        }

        private void CB_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*************TRAE EL ID DEL PROVEEDOR SELECCIONADO
            CB_compra.Items.Clear();

            try
            {
                MySqlConnection con = BDConexicon.conectar();
                string query = "SELECT PROVEEDOR FROM proveed WHERE nombre ='" + CB_proveedores.Text+ "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_proveedor.Text = dr["PROVEEDOR"].ToString();
                }
                dr.Close();
                con.Close();
                //******************************************************
                
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                //MessageBox.Show("Excepcion controlada: Error en el evento del combobox de proveedores "+ex);
            }

            try
            {
                //************** LLENA EL COMBOBOX CB_compra **********
                MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                string queryCompras = "SELECT COMPRA FROM COMPRAS WHERE PROVEEDOR='" + TB_proveedor.Text + "' ";
                MySqlCommand comando = new MySqlCommand(queryCompras, conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CB_compra.Items.Add(reader["COMPRA"].ToString());
                }
                reader.Close();
                conexion.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                //MessageBox.Show("Excepcion controlada: Error en el evento del combobox de compras "+ex);
            }
            //*****************************************************
        }

        private void CB_compra_SelectedIndexChanged(object sender, EventArgs e)
        {
            //******************************************************

          


            double impuesto = 0;
            double importe = 0;
            double impFactura = 0;
            try
            {
                MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                string queryCompras = "SELECT  FACTURA,IMPORTE,IMPUESTO FROM COMPRAS WHERE COMPRA ='" + CB_compra.Text + "' and PROVEEDOR='" + TB_proveedor.Text + "'";
                MySqlCommand comando = new MySqlCommand(queryCompras, conexion);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    TB_factura.Text = reader["FACTURA"].ToString();
                    importe = Convert.ToDouble(reader["IMPORTE"].ToString());
                    impuesto = Convert.ToDouble(reader["IMPUESTO"].ToString());

                }
                impFactura = importe + impuesto;
                TB_importe.Text = String.Format("{0:0.##}", impFactura.ToString("C"));
                reader.Close();
                conexion.Close();
            }

            catch (Exception ex)

            {

                //MessageBox.Show("Excepcion Controlada: Problema con el evento del combobox de compra  "+ex);
            }
            //******************************************************
        }

        private void BT_devolver_Click(object sender, EventArgs e)
        {
            if (CHK_parcial.Checked==true)
            {
                if (TB_importeTotal2.Text.Equals(""))
                {
                    MessageBox.Show("Calcula el importe de la devolución parcial");
                }
                else
                {
                    Devolucion();
                }
            }
            else
            {
                if (TB_importeTotal.Text.Equals(""))
                {
                    MessageBox.Show("Debes seleccionar una compra para aplicar una devolución");
                }
                else
                {
                    Devolucion();
                }
            }
          
        }


        //OBTIENE Y RETORNA EL CONSECUTIVO DE LOS ABONOS
        public int ConsecAbonos()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
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

        //OBTIENE Y RETORNA EL CONSECUTIVO DE MOVSINV
        public int ConsecMovsinv()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='movsinv'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de movsinv " + ex);
            }
          


            return consec;

        }


        //OBTIENE Y RETORNA EL CONSECUTIVO DEL MOV. DEVOLUCION DE COMPRA
        public int ConsecDevcomp()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='devcomp'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de devcomp " + ex);
            }



            return consec;

        }

        //OBTIENE Y RETORNA EL CONSECUTIVO  DE COMPRA
        public int ConsecCompra()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='Compra'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de compra " + ex);
            }



            return consec;

        }

        //OBTIENE Y RETORNA EL CONSECUTIVO DE PARTCOMPRA
        public int ConsecPartCompra()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='partcomp'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de compra " + ex);
            }



            return consec;
        }

      
         //RECALCULO DE EXISTENCIA
         public void RecalcularExistencia()
        {

            int entradas = 0;
            int salidas = 0;
            int ex = 0;
            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());

            MySqlDataReader drRec = null;
            for (int i = 0; i < artDevolucion.Count; i++)
            {
                string query = "SELECT ENT_SAL,CANTIDAD FROM MOVSINV WHERE ARTICULO='" + artDevolucion[i] + "'";
                MySqlCommand recalculo = new MySqlCommand(query, conexion);
                drRec = recalculo.ExecuteReader();
                while (drRec.Read())
                {
                    if (drRec["ENT_SAL"].ToString().Equals("E"))
                    {
                        entradas += Convert.ToInt32(drRec["CANTIDAD"].ToString());
                    }


                    if (drRec["ENT_SAL"].ToString().Equals("S"))
                    {
                        salidas += Convert.ToInt32(drRec["CANTIDAD"].ToString());
                    }
                }
                drRec.Close();
                ex = entradas - salidas;

                string actualizarExistencia = "UPDATE PRODS SET EXISTENCIA =" + ex + " WHERE ARTICULO='" + artDevolucion[i] + "'";

                MySqlCommand actualizar = new MySqlCommand(actualizarExistencia, conexion);
                actualizar.ExecuteNonQuery();
                ex = 0; entradas = 0; salidas = 0;
            }
        }


        //REALIZA LA DEVOLUCION DE LA COMPRA
        public void Devolucion()
        {
           
            
            DateTime fecha = DateTime.Now;
            string cuenpag = "";
            string impDev = "";
            int compra = 0;
            int comp = 0;
            try
            {
                MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());


                //SE INSERTA LA DEVOLUCION DE LA COMPRA EN LA TABLA COMPRA
                compra = ConsecCompra();
                int devComp = ConsecDevcomp();
                MySqlCommand devCompra = new MySqlCommand("INSERT INTO compras(COMPRA,OCUPADO,TIPO_DOC,FACTURA,F_EMISION,F_VENC,PROVEEDOR,IMPORTE,DESCUENTO,IMPUESTO,COSTO,ALMACEN,ESTADO,OBSERV,TIPO_CAM,MONEDA,DESC1,DESC2,DESC3,DESC4,DESC5,DATOS,DESGLOSE,CUENXPAG,USUARIO,USUFECHA,USUHORA,Exportado,No_referen,vencimiento,DeCompra,donativo,compraconfirmada,devolucionconfirmada,poliza,impuesto_poliza)" +
                    "VALUES(?COMPRA,?OCUPADO,?TIPO_DOC,?FACTURA,?F_EMISION,?F_VENC,?PROVEEDOR,?IMPORTE,?DESCUENTO,?IMPUESTO,?COSTO,?ALMACEN,?ESTADO,?OBSERV,?TIPO_CAM,?MONEDA,?DESC1,?DESC2,?DESC3,?DESC4,?DESC5,?DATOS,?DESGLOSE,?CUENXPAG,?USUARIO,?USUFECHA,?USUHORA,?Exportado,?No_referen,?vencimiento,?DeCompra,?donativo,?compraconfirmada,?devolucionconfirmada,?poliza,?impuesto_poliza)", conexion);
                devCompra.Parameters.AddWithValue("?COMPRA",compra);
                devCompra.Parameters.AddWithValue("?OCUPADO","0");
                devCompra.Parameters.AddWithValue("?TIPO_DOC", "DV");
                comp = compra - 1;
                devCompra.Parameters.AddWithValue("?FACTURA", "DEVOLUCION DE LA COMPRA "+comp);
                devCompra.Parameters.AddWithValue("?F_EMISION", fecha.ToString("yyy-MM-dd"));
                devCompra.Parameters.AddWithValue("?F_VENC", "");
                devCompra.Parameters.AddWithValue("?PROVEEDOR",TB_proveedor.Text);
                if (CHK_parcial.Checked == false)
                {
                    decimal digito = decimal.Parse(TB_importeTotal.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    impDev = digito.ToString("G0");
                    devCompra.Parameters.AddWithValue("?IMPORTE", impDev);
                }
                else
                {
                    decimal digito = decimal.Parse(TB_importeTotal2.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    impDev = digito.ToString("G0");
                    devCompra.Parameters.AddWithValue("?IMPORTE",impDev);
                }
                devCompra.Parameters.AddWithValue("?DESCUENTO","0");
                devCompra.Parameters.AddWithValue("?IMPUESTO","0");
                devCompra.Parameters.AddWithValue("?COSTO", "0");
                devCompra.Parameters.AddWithValue("?ALMACEN", "1");
                devCompra.Parameters.AddWithValue("?ESTADO", "CO");
                devCompra.Parameters.AddWithValue("?OBSERV", TB_observacion.Text);
                devCompra.Parameters.AddWithValue("?TIPO_CAM","1");
                devCompra.Parameters.AddWithValue("?MONEDA", "MN");
                devCompra.Parameters.AddWithValue("?DESC1","0");
                devCompra.Parameters.AddWithValue("?DESC2", "0");
                devCompra.Parameters.AddWithValue("?DESC3", "0");
                devCompra.Parameters.AddWithValue("?DESC4", "0");
                devCompra.Parameters.AddWithValue("?DESC5", "0");
                devCompra.Parameters.AddWithValue("?DATOS",CB_proveedores.SelectedItem.ToString());
                devCompra.Parameters.AddWithValue("?DESGLOSE", "0");
                devCompra.Parameters.AddWithValue("?CUENXPAG", "0");
                devCompra.Parameters.AddWithValue("?USUARIO", usuario);
                devCompra.Parameters.AddWithValue("?USUFECHA",fecha.ToString("yyyy-MM-dd"));
                devCompra.Parameters.AddWithValue("?USUHORA",fecha.ToString("HH:mm:ss"));
                devCompra.Parameters.AddWithValue("?Exportado", "");
                devCompra.Parameters.AddWithValue("?No_referen", devComp);
                devCompra.Parameters.AddWithValue("?vencimiento", fecha.ToString("yyyy-MM-dd"));
                devCompra.Parameters.AddWithValue("?Decompra",CB_compra.SelectedItem.ToString());
                devCompra.Parameters.AddWithValue("?donativo",0);
                devCompra.Parameters.AddWithValue("?compraconfirmada",0);
                devCompra.Parameters.AddWithValue("?devolucionconfirmada", 0);
                devCompra.Parameters.AddWithValue("?poliza",0);//checar
                devCompra.Parameters.AddWithValue("?impuesto_poliza", 0);
                devCompra.ExecuteNonQuery();


                //ACTUALIZA CONSECUTIVO DE COMPRA
                MySqlCommand consecCompra = new MySqlCommand("UPDATE consec SET CONSEC=" + compra + " WHERE Dato='Compra'", conexion);
                consecCompra.ExecuteNonQuery();



                int abono = ConsecAbonos();//SE OBTIENE EL CONSECUTIVO DE ABONOS

                //OBTIENE LA CUENTA POR PAGAR DE LA COMPRA
                MySqlCommand cuenxpag = new MySqlCommand("SELECT CUENXPAG FROM CUENXPAG WHERE COMPRA='" + CB_compra.SelectedItem.ToString() + "' AND PROVEEDOR='" + TB_proveedor.Text + "'", conexion);
                MySqlDataReader dr = cuenxpag.ExecuteReader();
                while (dr.Read())
                {
                    cuenpag = dr["CUENXPAG"].ToString();
                }
                dr.Close();


                //INSERTA LA DEVOLUCION EN LA TABLA PAGOS
                MySqlCommand cmdPago = new MySqlCommand("INSERT INTO PAGOS(Abono,Proveedor,Tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                        "VALUES(?Abono,?Proveedor,?Tipo_doc,?No_referen,?Importe,?Moneda,?TC,?ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)", conexion);
                cmdPago.Parameters.AddWithValue("?Abono", abono);
                cmdPago.Parameters.AddWithValue("?Proveedor", TB_proveedor.Text);
                cmdPago.Parameters.AddWithValue("?Tipo_doc", "DEV");
                cmdPago.Parameters.AddWithValue("?No_referen", TB_factura.Text);

                //SI LA DEVOLUCION ES TOTAL TOMARA EL IMPORTE DE TB_importeTotal, SI ES PARCIAL, TOMARÁ EL IMPORTE DE TB_importeTotal2
                if (CHK_parcial.Checked == false)
                {
                    decimal digito = decimal.Parse(TB_importeTotal.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    impDev = digito.ToString("G0");
                    cmdPago.Parameters.AddWithValue("?Importe", impDev);
                }
                else
                {
                    decimal digito = decimal.Parse(TB_importeTotal2.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                   impDev = digito.ToString("G0");
                    cmdPago.Parameters.AddWithValue("?Importe", impDev);
                }
                cmdPago.Parameters.AddWithValue("?MONEDA", "MN");
                cmdPago.Parameters.AddWithValue("?TC", "1");
                cmdPago.Parameters.AddWithValue("?ImportBase", "");
                cmdPago.Parameters.AddWithValue("?Cobrar", "");
                cmdPago.Parameters.AddWithValue("?Banco", "");
                cmdPago.Parameters.AddWithValue("?Fecha_dep", fecha.ToString("yyyy-MM-dd"));
                cmdPago.Parameters.AddWithValue("?Autorizado", "0");
                cmdPago.Parameters.AddWithValue("?Por_apli", "0");
                cmdPago.Parameters.AddWithValue("?Aplicado", "0");
                cmdPago.Parameters.AddWithValue("?Observ", "");
                cmdPago.Parameters.AddWithValue("?Concepto", "PROV");
                cmdPago.Parameters.AddWithValue("?Usuario", usuario);
                cmdPago.Parameters.AddWithValue("?UsuFecha", fecha.ToString("yyyy-MM-dd"));
                cmdPago.Parameters.AddWithValue("?UsuHora", fecha.ToString("HH:mm:ss"));
                cmdPago.ExecuteNonQuery();

                //ACTUALIZAR EL CONSECUTIVO DE ABONO EN LA TABLA CONSEC
                MySqlCommand updateAbono = new MySqlCommand("UPDATE CONSEC SET Consec='" + abono + "' WHERE Dato='ABONOPROV'", conexion);
                updateAbono.ExecuteNonQuery();


                //SE INSERTA LA DEVOLUCION EN LA TABLA CUENXPDET
                MySqlCommand cmdCuenxpdet = new MySqlCommand("INSERT INTO cuenxpdet(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza)" +
                   "values(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)", conexion);
                cmdCuenxpdet.Parameters.AddWithValue("?CUENXPAG", cuenpag);
                cmdCuenxpdet.Parameters.AddWithValue("?PROVEEDOR", TB_proveedor.Text);
                cmdCuenxpdet.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                cmdCuenxpdet.Parameters.AddWithValue("?TIPO_DOC", "DEV");
                cmdCuenxpdet.Parameters.AddWithValue("?NO_REFEREN", TB_factura.Text);
                cmdCuenxpdet.Parameters.AddWithValue("?Cargo_ab", "A");

                //SI LA DEVOLUCION ES TOTAL TOMARA EL IMPORTE DE TB_importeTotal, SI ES PARCIAL, TOMARÁ EL IMPORTE DE TB_importeTotal2
                if (CHK_parcial.Checked == false)
                {
                    decimal digito = decimal.Parse(TB_importeTotal.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    impDev = digito.ToString("G0");
                    cmdCuenxpdet.Parameters.AddWithValue("?IMPORTE", impDev);
                }
                else
                {
                    decimal digito = decimal.Parse(TB_importeTotal2.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                     impDev = digito.ToString("G0");
                    cmdCuenxpdet.Parameters.AddWithValue("?IMPORTE", impDev);
                }

                cmdCuenxpdet.Parameters.AddWithValue("?MONEDA", "MN");
                cmdCuenxpdet.Parameters.AddWithValue("?TIP_CAM", "1");
                cmdCuenxpdet.Parameters.AddWithValue("?COMPRA", CB_compra.SelectedItem.ToString());
                cmdCuenxpdet.Parameters.AddWithValue("?COBRADOR", "");
                cmdCuenxpdet.Parameters.AddWithValue("?OBSERV", "");
                cmdCuenxpdet.Parameters.AddWithValue("?CONTAB", "");
                cmdCuenxpdet.Parameters.AddWithValue("?ABONO", abono);
                cmdCuenxpdet.Parameters.AddWithValue("?USUARIO", usuario);
                cmdCuenxpdet.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                cmdCuenxpdet.Parameters.AddWithValue("?USUHORA", fecha.ToString("HH:mm:ss"));
                cmdCuenxpdet.Parameters.AddWithValue("?ORDEN", "0");
                cmdCuenxpdet.Parameters.AddWithValue("?poliza", "0");
                cmdCuenxpdet.ExecuteNonQuery();

                //AFECTAR EL SALDO DE LA CUENTA POR PAGAR
                double saldo = 0;
                MySqlCommand obtieneSaldo = new MySqlCommand("SELECT saldo FROM cuenxpag WHERE compra='" + CB_compra.SelectedItem.ToString() + "' AND PROVEEDOR='" + TB_proveedor.Text + "'", conexion);
                MySqlDataReader drSaldo = obtieneSaldo.ExecuteReader();
                while (drSaldo.Read())
                {
                    saldo = Convert.ToDouble(drSaldo["saldo"].ToString());
                }
                drSaldo.Close();
                double importe = Convert.ToDouble(impDev);
                double saldoActual = saldo - importe;
                MySqlCommand actualizarSaldo = new MySqlCommand("UPDATE cuenxpag SET saldo=" + saldoActual + " WHERE compra='" + CB_compra.SelectedItem.ToString() + "' AND PROVEEDOR='" + TB_proveedor.Text + "'", conexion);
                actualizarSaldo.ExecuteNonQuery();


                //INSERTA SALIDA DE CADA ARTICULO, SI SE SELECCIONA UNA DEVOLCION PARCIAL, TOMARÁ LOS DATOS DE DG_DEVOLUCION, SI NO, TOMARÁ LOS DATOS DE DG_TABLA
                string articulo = "";
                int cantidad = 0;
                string descripcion = "";
                double costo = 0;
                int existencia = 0;
                double precio = 0;
                int salida = 0;
                int impuesto = 0;

                InventarioFisico inv = null;

                MySqlDataReader drRec = null;

                if (CHK_parcial.Checked == false)
                {


                    // SE INSERTAN LOS DATOS EN EL CARDEX DEL ARTICULO, OSEA LA TABLA MOVSINV
                    int consecMovsinv = ConsecMovsinv();
                    int nuevoConsecutivo = consecMovsinv + Convert.ToInt32(DG_tabla.Rows.Count);

                    MySqlCommand actualizaMovsinv = new MySqlCommand("UPDATE consec SET CONSEC=" + nuevoConsecutivo + " WHERE Dato='movsinv'", conexion);
                    actualizaMovsinv.ExecuteNonQuery();


                    MySqlDataReader drExistencia = null;
                    for (int i = 0; i < DG_tabla.RowCount; i++)
                    {
                        articulo = Convert.ToString(DG_tabla.Rows[i].Cells["ARTICULO"].Value);
                        cantidad = Convert.ToInt32(DG_tabla.Rows[i].Cells["CANTIDAD"].Value);
                        impuesto = Convert.ToInt32(DG_tabla.Rows[i].Cells["IMPUESTO"].Value);
                        costo = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_U"].Value);
                        precio = Convert.ToDouble(DG_tabla.Rows[i].Cells["PRECIO"].Value);
                        descripcion = Convert.ToString(DG_tabla.Rows[i].Cells["DESCRIP"].Value);

                        //SE INSERTAN LOS ARTICULOS DE LA DEV DE LA COMPRA
                        MySqlCommand partCompra = new MySqlCommand("INSERT INTO partcomp(COMPRA,TIPO_DOC,NO_REFEREN,ARTICULO,CANTIDAD,PRECIO,DESCUENTO,IMPUESTO,OBSERV,PARTIDA,ID_ENTRADA,Usuario,UsuFecha,UsuHora,PRCANTIDAD,PRDESCRIP,CLAVEADD,DescuentoAdicional,donativo,costoadic,descuento1,descuento2,descuento3,descuento4,descuento5,descuento6,descuento7,descuento8,descuento9,descuento10) " +
                            "VALUES(?COMPRA,?TIPO_DOC,?NO_REFEREN,?ARTICULO,?CANTIDAD,?PRECIO,?DESCUENTO,?IMPUESTO,?OBSERV,?PARTIDA,?ID_ENTRADA,?Usuario,?UsuFecha,?UsuHora,?PRCANTIDAD,?PRDESCRIP,?CLAVEADD,?DescuentoAdicional,?donativo,?costoadic,?descuento1,?descuento2,?descuento3,?descuento4,?descuento5,?descuento6,?descuento7,?descuento8,?descuento9,?descuento10)",conexion);
                        partCompra.Parameters.AddWithValue("?COMPRA", compra);
                        partCompra.Parameters.AddWithValue("?TIPO_DOC", "DV");
                        partCompra.Parameters.AddWithValue("?NO_REFEREN", compra);
                        partCompra.Parameters.AddWithValue("?ARTICULO", articulo);
                        salida = cantidad - (cantidad * 2);
                        partCompra.Parameters.AddWithValue("?CANTIDAD", salida);
                        partCompra.Parameters.AddWithValue("?PRECIO",precio);
                        partCompra.Parameters.AddWithValue("?DESCUENTO",0);
                        partCompra.Parameters.AddWithValue("?IMPUESTO", impuesto);
                        partCompra.Parameters.AddWithValue("?OBSERV", descripcion);
                        partCompra.Parameters.AddWithValue("?PARTIDA",0);
                        int id_entrada = ConsecPartCompra();
                        partCompra.Parameters.AddWithValue("?ID_ENTRADA",id_entrada);
                        partCompra.Parameters.AddWithValue("?USUARIO",usuario);
                        partCompra.Parameters.AddWithValue("?UsuFecha", fecha.ToString("yyyy-MM-dd"));
                        partCompra.Parameters.AddWithValue("?UsuHora", fecha.ToString("HH:mm:ss"));
                        partCompra.Parameters.AddWithValue("?PRCANTIDAD", "");
                        partCompra.Parameters.AddWithValue("?PRDESCRIP", "");
                        partCompra.Parameters.AddWithValue("?CLAVEADD", "");
                        partCompra.Parameters.AddWithValue("?DescuentoAdicional",0);
                        partCompra.Parameters.AddWithValue("?donativo",0);
                        partCompra.Parameters.AddWithValue("?costoadic", 0);
                        partCompra.Parameters.AddWithValue("?descuento1", 0);
                        partCompra.Parameters.AddWithValue("?descuento2", 0);
                        partCompra.Parameters.AddWithValue("?descuento3", 0);
                        partCompra.Parameters.AddWithValue("?descuento4", 0);
                        partCompra.Parameters.AddWithValue("?descuento5", 0);
                        partCompra.Parameters.AddWithValue("?descuento6", 0);
                        partCompra.Parameters.AddWithValue("?descuento7", 0);
                        partCompra.Parameters.AddWithValue("?descuento8", 0);
                        partCompra.Parameters.AddWithValue("?descuento9", 0);
                        partCompra.Parameters.AddWithValue("?descuento10", 0);
                        partCompra.ExecuteNonQuery();



                        //ACTUALIZA EL CONSECUTIVO DE PART COMPRA
                        MySqlCommand consecPartCompra = new MySqlCommand("UPDATE consec SET CONSEC=" + id_entrada + " WHERE Dato='partcomp'", conexion);
                        consecPartCompra.ExecuteNonQuery();

                       

                        // ############## EXISTENCIA DEL ALMACEN ##############################################################################
                        MySqlCommand existenciaArt = new MySqlCommand("select existencia from movsinv where articulo='" + articulo + "' order by consec desc limit 1", conexion);
                        drExistencia = existenciaArt.ExecuteReader();
                        while (drExistencia.Read())
                        {
                            existencia = Convert.ToInt32(drExistencia["existencia"].ToString());
                        }
                        drExistencia.Close();
                        existencia = existencia - cantidad;
                        //##############################################################################################################
                        MySqlCommand movsinv = new MySqlCommand("INSERT INTO movsinv(CONSEC,OPERACION,MOVIMIENTO,ENT_SAL,TIPO_MOVIM,NO_REFEREN,ARTICULO,F_MOVIM,CANTIDAD,COSTO,EXISTENCIA,VALOR,ALMACEN,EXIST_ALM,PRECIO_VTA,POR_COSTEA,PARTIDA,Cerrado,Usuario,UsuFecha,UsuHora,CLAVEADD,PRCANTIDAD,ID_SALIDA,ID_ENTRADA,REORDENA,inicial,exportado,verificado,inventariofisico,donativo,precio_vta_original,costopromedio,poliza)" +
                            "VALUES(?CONSEC,?OPERACION,?MOVIMIENTO,?ENT_SAL,?TIPO_MOVIM,?NO_REFEREN,?ARTICULO,?F_MOVIM,?CANTIDAD,?COSTO,?EXISTENCIA,?VALOR,?ALMACEN,?EXIST_ALM,?PRECIO_VTA,?POR_COSTEA,?PARTIDA,?Cerrado,?Usuario,?UsuFecha,?UsuHora,?CLAVEADD,?PRCANTIDAD,?ID_SALIDA,?ID_ENTRADA,?REORDENA,?inicial,?exportado,?verificado,?inventariofisico,?donativo,?precio_vta_original,?costopromedio,?poliza);",conexion );
                        movsinv.Parameters.AddWithValue("?CONSEC", consecMovsinv);
                        movsinv.Parameters.AddWithValue("?OPERACION", "DC");
                        movsinv.Parameters.AddWithValue("?MOVIMIENTO", devComp);
                        movsinv.Parameters.AddWithValue("?ENT_SAL", "S");
                        movsinv.Parameters.AddWithValue("?TIPO_MOVIM", "DC-");
                        movsinv.Parameters.AddWithValue("?NO_REFEREN", CB_compra.SelectedItem.ToString());
                        movsinv.Parameters.AddWithValue("?ARTICULO", articulo);
                        movsinv.Parameters.AddWithValue("?f_MOVIM", fecha.ToString("yyyy-MM-dd"));
                        movsinv.Parameters.AddWithValue("?CANTIDAD", cantidad);
                        movsinv.Parameters.AddWithValue("?COSTO", costo);
                        movsinv.Parameters.AddWithValue("?EXISTENCIA", existencia);
                        movsinv.Parameters.AddWithValue("?VALOR", "0");
                        movsinv.Parameters.AddWithValue("?ALMACEN", "1");
                        movsinv.Parameters.AddWithValue("?EXIST_ALM", existencia);
                        movsinv.Parameters.AddWithValue("?PRECIO_VTA", precio);
                        movsinv.Parameters.AddWithValue("?POR_COSTEA", "0");
                        movsinv.Parameters.AddWithValue("?PARTIDA", "0");
                        movsinv.Parameters.AddWithValue("?Cerrado", "0");
                        movsinv.Parameters.AddWithValue("?Usuario", usuario);
                        movsinv.Parameters.AddWithValue("UsuFecha", fecha.ToString("yyyy-MM-dd"));
                        movsinv.Parameters.AddWithValue("?UsuHora", fecha.ToString("HH:mm:ss"));
                        movsinv.Parameters.AddWithValue("?CLAVEADD", "0");
                        movsinv.Parameters.AddWithValue("?PRCANTIDAD", "0");
                        movsinv.Parameters.AddWithValue("?ID_SALIDA", "0");
                        movsinv.Parameters.AddWithValue("?ID_ENTRADA", "0");
                        movsinv.Parameters.AddWithValue("?REORDENA", "0");
                        movsinv.Parameters.AddWithValue("?inicial", "0");
                        movsinv.Parameters.AddWithValue("?exportado", "0");
                        movsinv.Parameters.AddWithValue("?verificado", "0");
                        movsinv.Parameters.AddWithValue("?inventariofisico", "0");
                        movsinv.Parameters.AddWithValue("?donativo", "0");
                        movsinv.Parameters.AddWithValue("?precio_vta_original", "0");
                        movsinv.Parameters.AddWithValue("?costopromedio", "0");
                        movsinv.Parameters.AddWithValue("?poliza", "");
                        movsinv.ExecuteNonQuery();



                        consecMovsinv++;



                         MySqlCommand actualizaDevComp = new MySqlCommand("UPDATE consec SET CONSEC='" + devComp + "' WHERE Dato='devcomp'", conexion);
                        actualizaDevComp.ExecuteNonQuery();
                        // RECALCULAR ###################################################################################################################
                        //string query = "SELECT ENT_SAL,EXISTENCIA FROM MOVSINV WHERE ARTICULO='" + articulo + "'";
                        //int entradas = 0;
                        //int salidas = 0;
                        //int ex = 0;

                        
                        //MySqlCommand recalculo = new MySqlCommand(query, conexion);
                        // drRec = recalculo.ExecuteReader();
                        //while (drRec.Read())
                        //{
                        //    if (drRec["ENT_SAL"].ToString().Equals("E"))
                        //    {
                        //        entradas = Convert.ToInt32(drRec["EXISTENCIA"].ToString());
                        //    }


                        //    if (drRec["ENT_SAL"].ToString().Equals("S"))
                        //    {
                        //        salidas = Convert.ToInt32(drRec["EXISTENCIA"].ToString());
                        //    }
                        //}
                        //drRec.Close();
                        //ex = entradas - salidas;

                        //string actualizarExistencia = "UPDATE PRODS SET EXISTENCIA =" + existencia + " WHERE ARTICULO='" + articulo + "'";

                        //MySqlCommand actualizar = new MySqlCommand(actualizarExistencia, conexion);
                        //actualizar.ExecuteNonQuery();

                        //###############################################################################################################################
                        artDevolucion.Add(articulo);//lista de articulos que se forman parte de la devolucion
                    }
                    RecalcularExistencia();
                    MessageBox.Show("Se Realizó la devolución de la compra " + CB_compra.SelectedItem.ToString() + " de "+CB_proveedores.SelectedItem.ToString()+" exitosamente");
                    consecMovsinv = 0;
                }
                else
                {

                    int consecMovsinv = ConsecMovsinv();
                    int nuevoConsecutivo = consecMovsinv + Convert.ToInt32(DG_devolucion.Rows.Count);

                    MySqlCommand actualizaMovsinv = new MySqlCommand("UPDATE consec SET CONSEC=" + nuevoConsecutivo + " WHERE Dato='movsinv'", conexion);
                    actualizaMovsinv.ExecuteNonQuery();


                    MySqlDataReader drExistencia = null;
                    for (int i = 0; i < DG_devolucion.RowCount; i++)
                    {
                       
                        articulo = Convert.ToString(DG_devolucion.Rows[i].Cells["ARTICULO"].Value);
                        cantidad = Convert.ToInt32(DG_devolucion.Rows[i].Cells["CANTIDAD"].Value);
                        impuesto = Convert.ToInt32(DG_devolucion.Rows[i].Cells["IMPUESTO"].Value);
                        costo = Convert.ToDouble(DG_devolucion.Rows[i].Cells["COSTO_U"].Value);
                        precio = Convert.ToDouble(DG_devolucion.Rows[i].Cells["PRECIO"].Value);
                        descripcion = Convert.ToString(DG_devolucion.Rows[i].Cells["DESCRIPCION"].Value);

                        //SE INSERTAN LOS ARTICULOS DE LA DEV DE LA COMPRA
                        MySqlCommand partCompra = new MySqlCommand("INSERT INTO partcomp(COMPRA,TIPO_DOC,NO_REFEREN,ARTICULO,CANTIDAD,PRECIO,DESCUENTO,IMPUESTO,OBSERV,PARTIDA,ID_ENTRADA,Usuario,UsuFecha,UsuHora,PRCANTIDAD,PRDESCRIP,CLAVEADD,DescuentoAdicional,donativo,costoadic,descuento1,descuento2,descuento3,descuento4,descuento5,descuento6,descuento7,descuento8,descuento9,descuento10) " +
                            "VALUES(?COMPRA,?TIPO_DOC,?NO_REFEREN,?ARTICULO,?CANTIDAD,?PRECIO,?DESCUENTO,?IMPUESTO,?OBSERV,?PARTIDA,?ID_ENTRADA,?Usuario,?UsuFecha,?UsuHora,?PRCANTIDAD,?PRDESCRIP,?CLAVEADD,?DescuentoAdicional,?donativo,?costoadic,?descuento1,?descuento2,?descuento3,?descuento4,?descuento5,?descuento6,?descuento7,?descuento8,?descuento9,?descuento10)", conexion);
                        partCompra.Parameters.AddWithValue("?COMPRA", compra);
                        partCompra.Parameters.AddWithValue("?TIPO_DOC", "DV");
                        partCompra.Parameters.AddWithValue("?NO_REFEREN", compra);
                        partCompra.Parameters.AddWithValue("?ARTICULO", articulo);
                        salida = cantidad - (cantidad * 2);
                        partCompra.Parameters.AddWithValue("?CANTIDAD", salida);
                        partCompra.Parameters.AddWithValue("?PRECIO", precio);
                        partCompra.Parameters.AddWithValue("?DESCUENTO", 0);
                        partCompra.Parameters.AddWithValue("?IMPUESTO", impuesto);
                        partCompra.Parameters.AddWithValue("?OBSERV", descripcion);
                        partCompra.Parameters.AddWithValue("?PARTIDA", 0);
                        int id_entrada = ConsecPartCompra();
                        partCompra.Parameters.AddWithValue("?ID_ENTRADA", id_entrada);
                        partCompra.Parameters.AddWithValue("?USUARIO", usuario);
                        partCompra.Parameters.AddWithValue("?UsuFecha", fecha.ToString("yyyy-MM-dd"));
                        partCompra.Parameters.AddWithValue("?UsuHora", fecha.ToString("HH:mm:ss"));
                        partCompra.Parameters.AddWithValue("?PRCANTIDAD", "");
                        partCompra.Parameters.AddWithValue("?PRDESCRIP", "");
                        partCompra.Parameters.AddWithValue("?CLAVEADD", "");
                        partCompra.Parameters.AddWithValue("?DescuentoAdicional", 0);
                        partCompra.Parameters.AddWithValue("?donativo", 0);
                        partCompra.Parameters.AddWithValue("?costoadic", 0);
                        partCompra.Parameters.AddWithValue("?descuento1", 0);
                        partCompra.Parameters.AddWithValue("?descuento2", 0);
                        partCompra.Parameters.AddWithValue("?descuento3", 0);
                        partCompra.Parameters.AddWithValue("?descuento4", 0);
                        partCompra.Parameters.AddWithValue("?descuento5", 0);
                        partCompra.Parameters.AddWithValue("?descuento6", 0);
                        partCompra.Parameters.AddWithValue("?descuento7", 0);
                        partCompra.Parameters.AddWithValue("?descuento8", 0);
                        partCompra.Parameters.AddWithValue("?descuento9", 0);
                        partCompra.Parameters.AddWithValue("?descuento10", 0);
                        partCompra.ExecuteNonQuery();



                        //ACTUALIZA EL CONSECUTIVO DE PART COMPRA
                        MySqlCommand consecPartCompra = new MySqlCommand("UPDATE consec SET CONSEC=" + id_entrada + " WHERE Dato='partcomp'", conexion);
                        consecPartCompra.ExecuteNonQuery();

                        // SE INSERTAN LOS DATOS EN EL CARDEX DEL ARTICULO, OSEA LA TABLA MOVSINV
                        //int consecMovsinv = ConsecMovsinv();



                        MySqlCommand existenciaArt = new MySqlCommand("select existencia from movsinv where articulo='" + articulo + "' order by consec desc limit 1", conexion);
                        drExistencia = existenciaArt.ExecuteReader();
                        while (drExistencia.Read())
                        {
                            existencia = Convert.ToInt32(drExistencia["existencia"].ToString());
                        }
                        drExistencia.Close();
                        existencia = existencia - cantidad;
                        MySqlCommand movsinv = new MySqlCommand("INSERT INTO movsinv(CONSEC,OPERACION,MOVIMIENTO,ENT_SAL,TIPO_MOVIM,NO_REFEREN,ARTICULO,F_MOVIM,CANTIDAD,COSTO,EXISTENCIA,VALOR,ALMACEN,EXIST_ALM,PRECIO_VTA,POR_COSTEA,PARTIDA,Cerrado,Usuario,UsuFecha,UsuHora,CLAVEADD,PRCANTIDAD,ID_SALIDA,ID_ENTRADA,REORDENA,inicial,exportado,verificado,inventariofisico,donativo,precio_vta_original,costopromedio,poliza)" +
                            "VALUES(?CONSEC,?OPERACION,?MOVIMIENTO,?ENT_SAL,?TIPO_MOVIM,?NO_REFEREN,?ARTICULO,?F_MOVIM,?CANTIDAD,?COSTO,?EXISTENCIA,?VALOR,?ALMACEN,?EXIST_ALM,?PRECIO_VTA,?POR_COSTEA,?PARTIDA,?Cerrado,?Usuario,?UsuFecha,?UsuHora,?CLAVEADD,?PRCANTIDAD,?ID_SALIDA,?ID_ENTRADA,?REORDENA,?inicial,?exportado,?verificado,?inventariofisico,?donativo,?precio_vta_original,?costopromedio,?poliza);", conexion);
                        movsinv.Parameters.AddWithValue("?CONSEC", consecMovsinv);
                        movsinv.Parameters.AddWithValue("?OPERACION", "DC");
                        movsinv.Parameters.AddWithValue("?MOVIMIENTO", devComp);
                        movsinv.Parameters.AddWithValue("?ENT_SAL", "S");
                        movsinv.Parameters.AddWithValue("?TIPO_MOVIM", "DC-");
                        movsinv.Parameters.AddWithValue("?NO_REFEREN", CB_compra.SelectedItem.ToString());
                        movsinv.Parameters.AddWithValue("?ARTICULO", articulo);
                        movsinv.Parameters.AddWithValue("?f_MOVIM", fecha.ToString("yyyy-MM-dd"));
                        movsinv.Parameters.AddWithValue("?CANTIDAD", cantidad);
                        movsinv.Parameters.AddWithValue("?COSTO", costo);
                        movsinv.Parameters.AddWithValue("?EXISTENCIA", existencia);
                        movsinv.Parameters.AddWithValue("?VALOR", "0");
                        movsinv.Parameters.AddWithValue("?ALMACEN", "1");
                        movsinv.Parameters.AddWithValue("?EXIST_ALM", existencia);
                        movsinv.Parameters.AddWithValue("?PRECIO_VTA", precio);
                        movsinv.Parameters.AddWithValue("?POR_COSTEA", "0");
                        movsinv.Parameters.AddWithValue("?PARTIDA", "0");
                        movsinv.Parameters.AddWithValue("?Cerrado", "0");
                        movsinv.Parameters.AddWithValue("?Usuario", usuario);
                        movsinv.Parameters.AddWithValue("UsuFecha", fecha.ToString("yyyy-MM-dd"));
                        movsinv.Parameters.AddWithValue("?UsuHora", fecha.ToString("HH:mm:ss"));
                        movsinv.Parameters.AddWithValue("?CLAVEADD", "0");
                        movsinv.Parameters.AddWithValue("?PRCANTIDAD", "0");
                        movsinv.Parameters.AddWithValue("?ID_SALIDA", "0");
                        movsinv.Parameters.AddWithValue("?ID_ENTRADA", "0");
                        movsinv.Parameters.AddWithValue("?REORDENA", "0");
                        movsinv.Parameters.AddWithValue("?inicial", "0");
                        movsinv.Parameters.AddWithValue("?exportado", "0");
                        movsinv.Parameters.AddWithValue("?verificado", "0");
                        movsinv.Parameters.AddWithValue("?inventariofisico", "0");
                        movsinv.Parameters.AddWithValue("?donativo", "0");
                        movsinv.Parameters.AddWithValue("?precio_vta_original", "0");
                        movsinv.Parameters.AddWithValue("?costopromedio", "0");
                        movsinv.Parameters.AddWithValue("?poliza", "");
                        movsinv.ExecuteNonQuery();



                        consecMovsinv++;
                        //MySqlCommand actualizaMovsinv = new MySqlCommand("UPDATE consec SET CONSEC=" + consecMovsinv + " WHERE Dato='movsinv'", conexion);
                        //actualizaMovsinv.ExecuteNonQuery();

                        MySqlCommand actualizaDevComp = new MySqlCommand("UPDATE consec SET CONSEC='" + devComp + "' WHERE Dato='devcomp'", conexion);
                        actualizaDevComp.ExecuteNonQuery();
                        // RECALCULAR ###################################################################################################################
                        //string query = "SELECT ENT_SAL,EXISTENCIA FROM MOVSINV WHERE ARTICULO='" + articulo + "'";
                        //int entradas = 0;
                        //int salidas = 0;
                        //int ex = 0;


                        //MySqlCommand recalculo = new MySqlCommand(query, conexion);
                        //drRec = recalculo.ExecuteReader();
                        //while (drRec.Read())
                        //{
                        //    if (drRec["ENT_SAL"].ToString().Equals("E"))
                        //    {
                        //        entradas = Convert.ToInt32(drRec["EXISTENCIA"].ToString());
                        //    }


                        //    if (drRec["ENT_SAL"].ToString().Equals("S"))
                        //    {
                        //        salidas = Convert.ToInt32(drRec["EXISTENCIA"].ToString());
                        //    }
                        //}
                        //drRec.Close();
                        //ex = entradas - salidas;

                        //string actualizarExistencia = "UPDATE PRODS SET EXISTENCIA =" + existencia + " WHERE ARTICULO='" + articulo + "'";

                        //MySqlCommand actualizar = new MySqlCommand(actualizarExistencia, conexion);
                        //actualizar.ExecuteNonQuery();

                        //###############################################################################################################################
                        artDevolucion.Add(articulo);



                    }
                    RecalcularExistencia();

                    char total, parcial;
                    double importeDev = 0;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("ARTICULO",typeof(string));
                    dt.Columns.Add("DESCRIPCION", typeof(string));
                    dt.Columns.Add("PRECIO", typeof(string));
                    dt.Columns.Add("COSTO_U", typeof(string));
                    dt.Columns.Add("CANTIDAD", typeof(string));
                    dt.Columns.Add("IMPUESTO", typeof(string));
                    dt.Columns.Add("DESCUENTO", typeof(string));
                   

                    dt.Columns.Add("IMPORTE", typeof(string));


                    //Auditoria###############################################################################################
                    decimal digito = 0;
                    string texto = "";
                    if (CHK_parcial.Checked==true)
                    {
                       
                        parcial = '1';
                        total = '0';

                        if (TB_importeTotal2.Text.Equals(""))
                        {
                            importeDev = 0;
                        }
                        else
                        {
                            digito = decimal.Parse(TB_importeTotal2.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                            texto = digito.ToString("G0");
                            importeDev = Convert.ToDouble(texto);
                        }
                       
                        for (int i = 0; i < DG_devolucion.Rows.Count; i++)
                        {
                            dt.Rows.Add(DG_devolucion.Rows[i].Cells[0].Value.ToString(), DG_devolucion.Rows[i].Cells[1].Value.ToString(), DG_devolucion.Rows[i].Cells[2].Value.ToString(), DG_devolucion.Rows[i].Cells[3].Value.ToString(), DG_devolucion.Rows[i].Cells[4].Value.ToString(), DG_devolucion.Rows[i].Cells[5].Value.ToString(), DG_devolucion.Rows[i].Cells[6].Value.ToString(), DG_devolucion.Rows[i].Cells[7].Value.ToString());
                        }
                    }
                    else
                    {
                        parcial = '0';
                        total = '1';
                        if (TB_importeTotal.Text.Equals(""))
                        {
                            importeDev = 0;
                        }
                        else
                        {
                            digito = decimal.Parse(TB_importeTotal.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                            texto = digito.ToString("G0");
                            importeDev = Convert.ToDouble(texto);
                             
                        }
                        for (int i = 0; i < DG_tabla.Rows.Count; i++)
                        {
                            dt.Rows.Add(DG_tabla.Rows[i].Cells[0].Value.ToString(), DG_tabla.Rows[i].Cells[1].Value.ToString(), DG_tabla.Rows[i].Cells[2].Value.ToString(), DG_tabla.Rows[i].Cells[6].Value.ToString(), DG_tabla.Rows[i].Cells[3].Value.ToString(), DG_tabla.Rows[i].Cells[5].Value.ToString(), DG_tabla.Rows[i].Cells[4].Value.ToString(), DG_tabla.Rows[i].Cells[7].Value.ToString());
                        }
                    }

                    digito = decimal.Parse(TB_importe.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    texto = digito.ToString("G0");
                    double importeCompra = Convert.ToDouble(texto);

                    Auditoria.Auditoria_devolucion_compra(usuario,CB_sucursal.SelectedItem.ToString(),TB_proveedor.Text,CB_compra.SelectedItem.ToString(),TB_factura.Text, importeCompra, parcial,total, importeDev,TB_observacion.Text,dt);
                    //####################################################################################################################################################################################################################################################################################################################
                    MessageBox.Show("Se Realizó la devolución de la compra " + CB_compra.SelectedItem.ToString() + " de  "+CB_proveedores.SelectedItem.ToString()+" exitosamente");
                    consecMovsinv = 0;
                }

                conexion.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al generar la devolución:  " + ex);
            }

            artCompra.Clear();
            DG_devolucion.Rows.Clear();
            TB_importeTotal.Text = "";
            TB_importeTotal2.Text = "";
            TB_dgFiltro.Text = "";
        }

        //TRAE LOS PRODUCTOS QUE SON PARTE DE LA COMPRA Y LOS MUESTRA EN EL DATAGRIDVIEW DG_tabla
        private void BT_compra_Click(object sender, EventArgs e)
        {
            if (CB_compra.SelectedIndex==-1)
            {
                MessageBox.Show("Debes elegir una compra");
            }
            else
            {
                CHK_parcial.Checked = false;
                artCompra.Clear();
                DG_devolucion.Rows.Clear();
                TB_importeTotal2.Text = "";
                TB_observacion.Text = "";
                Compras com = new Compras();

                artCompra = com.ArticulosCompra(CB_compra.SelectedItem.ToString(), CB_sucursal.SelectedItem.ToString());
                artCompra.Columns.Add("IMPORTE", typeof(double));
                double precio = 0;
                int cantidad = 0;
                double descuento = 0;
                double importe = 0;
                double impuesto = 0;
                double bruto = 0;
                double costoU = 0;
                foreach (DataRow row in artCompra.Rows)
                {
                    //precio = Convert.ToDouble(row["PRECIO"].ToString());    //COMENTÉ ESTE CODIGO
                    costoU = Convert.ToDouble(row["COSTO_U"].ToString());      //AGREGUE ESTE
                    descuento = Convert.ToDouble(row["DESCUENTO"].ToString());
                    cantidad = Convert.ToInt32(row["CANTIDAD"].ToString());
                    impuesto = Convert.ToDouble(row["IMPUESTO"].ToString());
                    //row["IMPORTE"] = ((precio - (precio * (descuento / 100))) * cantidad)+(precio*(impuesto/100));
                    //bruto = precio * cantidad;     //COMENTE ESTE CODIGO
                    bruto = costoU * cantidad;        //CAMBIE PRECIO X COSTOU
                    row["IMPORTE"] = bruto + (bruto * (impuesto / 100));
                    importe += Convert.ToDouble(row["IMPORTE"].ToString());
                    TB_importeTotal.Text = String.Format("{0:0.##}", importe.ToString("C"));
                }
                DG_tabla.DataSource = artCompra;
            }

        }


        //FILTRA DEL DATAGRID DG_tabla por articulo
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataView view = artCompra.DefaultView;
            view.RowFilter = string.Empty;
            view.RowFilter = "ARTICULO" + " LIKE '%" + TB_dgFiltro.Text + "%'";
            DG_tabla.DataSource = view;
        }

        private void DG_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string articulo = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["ARTICULO"].Value);
            string descripcion = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["DESCRIP"].Value);
            double precio = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["PRECIO"].Value);
            double impuesto = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["IMPUESTO"].Value);
            double costo= Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["COSTO_U"].Value);
            DG_devolucion.Rows.Add(articulo,descripcion,precio,costo,"",impuesto,0,"");
        }

        private void CHK_parcial_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_parcial.Checked == true)
            {
                DG_devolucion.Enabled = true;
            }

            if (CHK_parcial.Checked == false)
            {
                DG_devolucion.Enabled = false;
            }
        }

        private void DG_devolucion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int cantidad2 = 0;
                double costo = Convert.ToDouble(DG_devolucion.Rows[e.RowIndex].Cells["COSTO_U"].Value);
                int cantidad = Convert.ToInt32(DG_devolucion.Rows[e.RowIndex].Cells["CANTIDAD"].Value);
                string articulo = Convert.ToString(DG_devolucion.Rows[e.RowIndex].Cells["ARTICULO"].Value);
                double impuesto = Convert.ToDouble(DG_devolucion.Rows[e.RowIndex].Cells["IMPUESTO"].Value);
                double descuento = Convert.ToDouble(DG_devolucion.Rows[e.RowIndex].Cells["DESC"].Value);

                for (int i = 0; i < DG_tabla.RowCount; i++)
                {
                    if (articulo.Equals(DG_tabla.Rows[i].Cells["ARTICULO"].Value))
                    {
                        cantidad2 = Convert.ToInt32(DG_tabla.Rows[i].Cells["CANTIDAD"].Value);
                        break;
                    }
                }

                if (cantidad >cantidad2)
                {
                    MessageBox.Show("La cantidad que capturaste es mayor a la cantidad reflejada en la compra");
                }
                else
                {
                    double bruto = costo * cantidad;
                    impuesto = impuesto / 100;
                    double importe = 0;

                    if (descuento==0)
                    {
                         importe = (bruto + (bruto * impuesto));
                    }
                    else
                    {
                        importe = (bruto + (bruto * impuesto))-(((bruto + (bruto * impuesto))*descuento)/100);
                    }
                    

                    DG_devolucion.Rows[e.RowIndex].Cells["IMPORTE"].Value = importe;
                    importe = 0;impuesto = 0;bruto = 0;costo = 0;cantidad = 0;descuento = 0;
                }

             
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa el formato de los datos que insertaste "+ex);
            }
        }

        private void BT_quitar_Click(object sender, EventArgs e)
        {
            try
            {
                DG_devolucion.Rows.Remove(DG_devolucion.CurrentRow);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("No existen filas en el datagridview");
            }
        }

        private void BT_calcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            for (int i = 0; i < DG_devolucion.Rows.Count; i++)
            {
                total += Convert.ToDouble(DG_devolucion.Rows[i].Cells["IMPORTE"].Value);

            }
            TB_importeTotal2.Text = String.Format("{0:0.##}", total.ToString("C"));
            total = 0;
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_importe.Text = "";
            TB_factura.Text = "";
            CB_compra.SelectedIndex = -1;
            TB_proveedor.Text = "";
            CB_proveedores.SelectedIndex = -1;

            artCompra.Clear();
            DG_devolucion.Rows.Clear();
            TB_importeTotal.Text = "";
            TB_importeTotal2.Text = "";
            TB_dgFiltro.Text = "";


        }

        private void DG_devolucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void BT_cambiarClaves_Click(object sender, EventArgs e)
        {
            if (CB_compra.SelectedIndex ==-1)
            {
                MessageBox.Show("Debes seleccionar una compra");
            }
            else
            {
                DataTable articulos = new DataTable();
                articulos.Columns.Add("ARTICULO", typeof(string));
                articulos.Columns.Add("DESCRIPCION", typeof(string));




                for (int i = 0; i < DG_tabla.RowCount; i++)
                {
                    articulos.Rows.Add(Convert.ToString(DG_tabla.Rows[i].Cells[0].Value), Convert.ToString(DG_tabla.Rows[i].Cells[1].Value));
                }
                CambiarClavesArtCompra cambiarClaves = new CambiarClavesArtCompra(usuario,articulos, CB_compra.SelectedItem.ToString(), CB_sucursal.SelectedItem.ToString());
                cambiarClaves.Show();
            }
        }

        private void BT_CambiarProveedor_Click(object sender, EventArgs e)
        {
            ModificarDatosDev modDev = new ModificarDatosDev(CB_sucursal.SelectedItem.ToString(),CB_compra.SelectedItem.ToString(),TB_factura.Text,TB_observacion.Text);
            modDev.Show();
        }
    }
}
