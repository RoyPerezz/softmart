using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;

namespace appSugerencias
{
    class Auditoria
    {



        #region VARIABLES
        public string usuario = "";
        #endregion

        #region UTILERIAS


        public static string NombreEquipo()
        {


            return Environment.MachineName;
        }

        public static string DirIp()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }

            return localIP;
        }

        public static void RegistrarAccesos(string modulo, string usuario)
        {
            string query = "INSERT INTO rd_log_acceso_modulos(usuario,fecha,hora,ip,nombre_equipo,modulo)VALUES(?usuario,?fecha,?hora,?ip,?nombre_equipo,?modulo)";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            DateTime fecha = DateTime.Now;
            string nombre_equipo = NombreEquipo();

            string ip = DirIp();

            cmd.Parameters.AddWithValue("?usuario", usuario);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:dd"));
            cmd.Parameters.AddWithValue("?ip", ip);
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?modulo", modulo);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region ADMINISTRACIÓN GENERAL

        public static void Auditoria_AjusteCuentasOS(string usuario, string fechaMov, string sucursal, string banco, string cuenta, string cliente_bancario, double cantidad, string movimiento, string referencia)
        {

            DateTime fecha = DateTime.Now;

            string nombre_equipo = NombreEquipo();
            string ip = DirIp();

            string query = "INSERT INTO rd_log_ajustes_cuentas_osmart(usuario,fecha_mov,fecha_registro,hora,nombre_equipo,ip,sucursal_cuenta,banco_osmart,cuenta_osmart,cliente_bancario,cantidad,movimiento,referencia)" +
                "VALUES(?usuario,?fecha_mov,?fecha_registro,?hora,?nombre_equipo,?ip,?sucursal_cuenta,?banco_osmart,?cuenta_osmart,?cliente_bancario,?cantidad,?movimiento,?referencia)";

            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, conexion);




            cmd.Parameters.AddWithValue("?usuario", usuario);
            cmd.Parameters.AddWithValue("?fecha_mov", fechaMov);
            cmd.Parameters.AddWithValue("?fecha_registro", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));

            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?ip", ip);
            cmd.Parameters.AddWithValue("?sucursal_cuenta", sucursal);
            cmd.Parameters.AddWithValue("?banco_osmart", banco);
            cmd.Parameters.AddWithValue("?cuenta_osmart", cuenta);
            cmd.Parameters.AddWithValue("?cliente_bancario", cliente_bancario);
            cmd.Parameters.AddWithValue("?cantidad", cantidad);
            cmd.Parameters.AddWithValue("?movimiento", movimiento);
            cmd.Parameters.AddWithValue("?referencia", referencia);
            cmd.ExecuteNonQuery();



        }

        public static void Auditoria_cantidad_facturar(string usuario, string fecha_venta, double deposito,string sucursal)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            DateTime fecha = DateTime.Now;
            string consulta = "select fecha_venta from rd_log_cantidad_facturacion where fecha_venta='" + fecha_venta + "' and sucursal='"+sucursal+"'";
            bool existe = false;
            MySqlCommand cmd0 = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd0.ExecuteReader();
            if (dr.Read())
            {
                existe = true;
            }

            dr.Close();

           




            if (existe == true)
            {
                string query = "UPDATE rd_log_cantidad_facturacion SET fecha='" + fecha.ToString("yyyy-MM-dd") + "', deposito_ventanilla=" + deposito + " where fecha_venta='" + fecha_venta + "' and sucursal='"+sucursal+"'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string query2 = "INSERT INTO rd_log_cantidad_facturacion(usuario,nombre_equipo,ip,fecha,hora,fecha_venta,deposito_ventanilla,sucursal)" +
                "VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?fecha_venta,?deposito_ventanilla,?sucursal)";

                MySqlCommand cmd2 = new MySqlCommand(query2, con);


                string nombre_equipo = NombreEquipo();
                string ip = DirIp();
                cmd2.Parameters.AddWithValue("?usuario", usuario);
                cmd2.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
                cmd2.Parameters.AddWithValue("?ip", ip);
                cmd2.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
                cmd2.Parameters.AddWithValue("?fecha_venta", fecha_venta);
                cmd2.Parameters.AddWithValue("?deposito_ventanilla", deposito);
                cmd2.Parameters.AddWithValue("?sucursal", sucursal);
                cmd2.ExecuteNonQuery();
            }


        }

        public static void Auditoria_Depositar_de_Proveedor_a_Proveedor(string usuario,string proveedor1, string proveedor2,string tipo_pago,double importe,string referencia,string fechaDeposito)
        {
            string query = "INSERT INTO rd_log_depositar_de_proveedor_a_proveedor(usuario,nombre_equipo,ip,fecha,hora,proveedor_deposita,proveedor_recibe,tipo_pago,importe,referencia,fecha_deposito)" +
                "VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?proveedor_deposita,?proveedor_recibe,?tipo_pago,?importe,?referencia,?fecha_deposito)";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            DateTime fecha = DateTime.Now;
          


            string nombre_equipo = NombreEquipo();
            string ip = DirIp();
            cmd.Parameters.AddWithValue("?usuario",usuario);
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?ip",ip);
            cmd.Parameters.AddWithValue("?fecha",fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?proveedor_deposita", proveedor1);
            cmd.Parameters.AddWithValue("?proveedor_recibe", proveedor2);
            cmd.Parameters.AddWithValue("?tipo_pago", tipo_pago);
            cmd.Parameters.AddWithValue("?importe", importe);
            cmd.Parameters.AddWithValue("?referencia", referencia);
            cmd.Parameters.AddWithValue("?fecha_deposito", fechaDeposito);
            cmd.ExecuteNonQuery();



        }

        public static void Auditoria_Retiro_Efectivo_Tiendas(string usuario,double retiro_va,double retiro_re,double retiro_ve, double retiro_co,string sucursal_cuenta,string banco,string cuenta, string cliente_bancario,double importe,double saldo,string fecha_retiro)
        {
            string query = "INSERT INTO rd_log_retiro_efectivo_a_cuentas_osmart(usuario,nombre_equipo,ip,fecha,hora,retiro_va,retiro_re,retiro_ve,retiro_co,sucursal_cuenta,banco,cuenta,cliente_bancario,importe,referencia,saldo,fecha_retiro)" +
                "VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?retiro_va,?retiro_re,?retiro_ve,?retiro_co,?sucursal_cuenta,?banco,?cuenta,?cliente_bancario,?importe,?referencia,?saldo,?fecha_retiro)";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            DateTime fecha = DateTime.Now;
            string nombre_equipo = NombreEquipo();
            string ip = DirIp();
            cmd.Parameters.AddWithValue("?usuario",usuario);
        }

        #endregion

        #region CUENTAS POR PAGAR
        public static void Auditoria_cuentas_bancarias_proveedores(string usuario,string proveedor, string banco,string cuenta,string cliente_bancario)
        {
            string query = "INSERT INTO rd_log_cuentas_bancarias_prov(usuario,nombre_equipo,ip,fecha,hora,fk_proveedor,banco,cuenta,cliente_bancario)" +
                "VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?fk_proveedor,?banco,?cuenta,?cliente_bancario)";
            MySqlConnection con = BDConexicon.BodegaOpen();
            DateTime fecha = DateTime.Now;
            string nombre_equipo = NombreEquipo();
            string ip = DirIp();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?usuario",usuario);
            cmd.Parameters.AddWithValue("?nombre_equipo",nombre_equipo);
            cmd.Parameters.AddWithValue("?ip",ip);
            cmd.Parameters.AddWithValue("?fecha",fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora",fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?fk_proveedor", proveedor);
            cmd.Parameters.AddWithValue("?banco",banco);
            cmd.Parameters.AddWithValue("?cuenta",cuenta);
            cmd.Parameters.AddWithValue("?cliente_bancario",cliente_bancario);
            cmd.ExecuteNonQuery();
        }

        public static void Auditoria_cuentas_bancarias_osmart(string usuario, string sucursal, string banco, string cuenta, string cliente_bancario)
        {

            string query = "INSERT INTO rd_log_cuentas_bancarias_osmart(usuario,nombre_equipo,ip,fecha,hora,banco,cuenta,cliente_bancario,sucursal)" +
                "VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?banco,?cuenta,?cliente_bancario,?sucursal)";
            MySqlConnection con = BDConexicon.BodegaOpen();
            DateTime fecha = DateTime.Now;
            string nombre_equipo = NombreEquipo();
            string ip = DirIp();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?usuario", usuario);
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?ip", ip);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?banco", banco);
            cmd.Parameters.AddWithValue("?cuenta", cuenta);
            cmd.Parameters.AddWithValue("?cliente_bancario", cliente_bancario);
            cmd.Parameters.AddWithValue("?sucursal", sucursal);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region COMPRAS
        public static void Auditoria_devolucion_compra(string usuario, string sucursal, string proveedor, string compra, string factura, double importeCompra, char dev_parcial, char dev_total, double importe_devolucion, string observacion, DataTable dt)
        {
            string query = "INSERT INTO rd_log_devolucion_compra(usuario,fecha,hora,nombre_equipo,ip,sucursal_compra,fk_proveedor,compra,factura,importe_compra,dev_parcial,dev_total,importe_devolucion,observacion)" +
                "VALUES(?usuario,?fecha,?hora,?nombre_equipo,?ip,?sucursal_compra,?fk_proveedor,?compra,?factura,?importe_compra,?dev_parcial,?dev_total,?importe_devolucion,?observacion)";
            DateTime fecha = DateTime.Now;
            string nombre_Equipo = NombreEquipo();
            string ip = DirIp();

            string consulta = "select max(id) as id from rd_log_devolucion_compra";

            string query2 = "INSERT INTO rd_log_articulos_dev_compra(fk_id_devolucion,compra,articulo,descripcion,precio,cantidad,descuento,impuesto,costo_u,importe)VALUES(?fk_id_devolucion,?compra,?articulo,?descripcion,?precio,?cantidad,?descuento,?impuesto,?costo_u,?importe)";

            //######################### guarda la actividad al realizar una devolucion ###############################################
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = null;
            cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("?usuario", usuario);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_Equipo);
            cmd.Parameters.AddWithValue("?ip", ip);
            cmd.Parameters.AddWithValue("?sucursal_compra", sucursal);
            cmd.Parameters.AddWithValue("?fk_proveedor", proveedor);
            cmd.Parameters.AddWithValue("?compra", compra);
            cmd.Parameters.AddWithValue("?factura", factura);
            cmd.Parameters.AddWithValue("?importe_compra", importeCompra);
            cmd.Parameters.AddWithValue("?dev_parcial", dev_parcial);
            cmd.Parameters.AddWithValue("?dev_total", dev_total);
            cmd.Parameters.AddWithValue("?importe_devolucion", importe_devolucion);
            cmd.Parameters.AddWithValue("?observacion", observacion);
            cmd.ExecuteNonQuery();


            // ########################## obtiene el id de la ultima devolucion realizada #################################
            cmd = new MySqlCommand(consulta, conexion);
            string id = "";
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = dr["id"].ToString();
            }
            dr.Close();


            //##################### inserta los articulos que participaron en la devolucion ##############################

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmd = new MySqlCommand(query2, conexion);
                cmd.Parameters.AddWithValue("?fk_id_devolucion", id);
                cmd.Parameters.AddWithValue("?compra", compra);
                cmd.Parameters.AddWithValue("?articulo", dt.Rows[i][0].ToString());
                cmd.Parameters.AddWithValue("?descripcion", dt.Rows[i][1].ToString());
                cmd.Parameters.AddWithValue("?precio", dt.Rows[i][2].ToString());
                cmd.Parameters.AddWithValue("?cantidad", dt.Rows[i][4].ToString());
                cmd.Parameters.AddWithValue("?descuento", dt.Rows[i][6].ToString());
                cmd.Parameters.AddWithValue("?impuesto", dt.Rows[i][5].ToString());
                cmd.Parameters.AddWithValue("?costo_u", dt.Rows[i][3].ToString());
                cmd.Parameters.AddWithValue("?importe", dt.Rows[i][7].ToString());
                cmd.ExecuteNonQuery();

            }


        }

        public static void Aditoria_cambio_clave_devolucion(string usuario, string compra, DataTable dt)
        {
            string query = "INSERT INTO rd_log_cambio_claves_dev(usuario,nombre_equipo,ip,fecha,hora,clave_inicial,cambio_clave,descripcion,fk_compra) VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?clave_inicial,?cambio_clave,?descripcion,?fk_compra)";
            string nombre_equipo = NombreEquipo();
            string ip = DirIp();
            DateTime fecha = DateTime.Now;
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = null;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?usuario", usuario);
                cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
                cmd.Parameters.AddWithValue("?ip", ip);
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("?clave_inicial", dt.Rows[i][0].ToString());
                cmd.Parameters.AddWithValue("?cambio_clave", dt.Rows[i][1].ToString());
                cmd.Parameters.AddWithValue("?descripcion", dt.Rows[i][2].ToString());
                cmd.Parameters.AddWithValue("?fk_compra", compra);
                cmd.ExecuteNonQuery();
            }







        }
        #endregion


        #region CAJAS

        public static void Auditoria_cambio_concepto_egreso(string usuario,string caja,string fecha_egreso, string concepto,string descripcion,double importe,string concepto_cambio,string descripcion_cambio)
        {
            string query = "INSERT INTO rd_log_cambio_concepto_egreso(usuario,nombre_equipo,ip,fecha,hora,caja,fecha_egreso,concepto,descripcion,importe,concepto_cambio,descripcion_cambio)" +
                "VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?caja,?fecha_egreso,?concepto,?descripcion,?importe,?concepto_cambio,?descripcion_cambio)";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            DateTime fecha = DateTime.Now;
            string nombre_equipo = NombreEquipo();
            string ip = DirIp();
            cmd.Parameters.AddWithValue("?usuario",usuario);
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?ip",ip);
            cmd.Parameters.AddWithValue("?fecha",fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora",fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?caja", caja);
            cmd.Parameters.AddWithValue("?fecha_egreso", fecha_egreso);
            cmd.Parameters.AddWithValue("?concepto",concepto);
            cmd.Parameters.AddWithValue("?descripcion",descripcion);
            cmd.Parameters.AddWithValue("?importe",importe);
            cmd.Parameters.AddWithValue("?concepto_cambio",concepto_cambio);
            cmd.Parameters.AddWithValue("?descripcion_cambio", descripcion_cambio);
            cmd.ExecuteNonQuery();



        }

        public static void Auditoria_modificar_tipo_venta(string usuario,string cajera,string venta,string ticket, double importe, string tipoVentaOriginal, string tipoVentaCambio,string fecha_venta, string hora_venta)
        {
            string query = "INSERT INTO rd_log_modificar_tipo_venta(usuario,nombre_equipo,ip,fecha,hora,cajera,no_venta,ticket,importe,tipo_venta_original,tipo_venta_cambio,fecha_venta,hora_venta)" +
                "VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?cajera,?no_venta,?ticket,?importe,?tipo_venta_original,?tipo_venta_cambio,?fecha_venta,?hora_venta)";
            MySqlConnection conexion = BDConexicon.conectar();
            DateTime fechaActual = DateTime.Now;
            string nombre_equipo = NombreEquipo();
            string ip = DirIp();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.Parameters.AddWithValue("?usuario",usuario);
           
            cmd.Parameters.AddWithValue("?nombre_equipo",nombre_equipo);
            cmd.Parameters.AddWithValue("?ip",ip);
            cmd.Parameters.AddWithValue("?fecha",fechaActual.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora",fechaActual.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?cajera", cajera);
            
            cmd.Parameters.AddWithValue("?no_venta",venta);
            cmd.Parameters.AddWithValue("?ticket",ticket);
            cmd.Parameters.AddWithValue("?importe",importe);
            cmd.Parameters.AddWithValue("?tipo_venta_original",tipoVentaOriginal);
            cmd.Parameters.AddWithValue("?tipo_venta_cambio",tipoVentaCambio);
            cmd.Parameters.AddWithValue("?fecha_venta",Convert.ToDateTime(fecha_venta).ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora_venta",hora_venta);
            cmd.ExecuteNonQuery();
        }

        public static void Auditoria_Pago_en_Efectivo_Enc_Cajas(string usuario,string fecha_transferencia,string beneficiario, double importe,string referencia)
        {
            string query = "INSERT INTO rd_log_pagos_efectivo_enc_cajas(usuario,nombre_equipo,ip,fecha,hora,beneficiario,importe,referencia,fecha_transferencia)" +
                "VALUES(?usuario,?nombre_equipo,?ip,?fecha,?hora,?beneficiario,?importe,?referencia,?fecha_transferencia)";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            DateTime fechaActual = DateTime.Now;
            string nombre_equipo = NombreEquipo();
            string ip = DirIp();
            cmd.Parameters.AddWithValue("?usuario",usuario);
            cmd.Parameters.AddWithValue("?nombre_equipo",nombre_equipo);
            cmd.Parameters.AddWithValue("?ip", ip);
            cmd.Parameters.AddWithValue("?fecha", fechaActual.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fechaActual.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?beneficiario", beneficiario);
            cmd.Parameters.AddWithValue("?importe", importe);
            cmd.Parameters.AddWithValue("?referencia", referencia);
            cmd.Parameters.AddWithValue("?fecha_transferencia", fecha_transferencia);
            cmd.ExecuteNonQuery();










        }
        #endregion

        #region BODEGA

        public static void Auditoria_cotizacion_traspasos(int folio,string usuario,string origen, string destino,string motivo,DataTable dt)
        {

            DateTime fecha_traspaso = DateTime.Now;

            string consulta = "SELECT MAX(folio) as folio FROM rd_log_cotizacion_traspaso";
            string query = "INSERT INTO rd_log_cotizacion_traspaso(folio,usuario,nombre_equipo,ip,fecha,hora,tienda_origen,tienda_destino,motivo)" +
                "VALUES(?folio,?usuario,?nombre_equipo,?ip,?fecha,?hora,?tienda_origen,?tienda_destino,?motivo)";

            string query2 = "INSERT INTO rd_log_cotizacion_traspaso_articulos(fk_log_cotizacion,articulo,descripcion,existencia,cantidad)VALUES(?fk_log_cotizacion,?articulo,?descripcion,?existencia,?cantidad)";

            MySqlConnection con = BDConexicon.conectar();

            string nombre_equipo = NombreEquipo();
            string ip = DirIp();

            // SE GUARDA EL ENCABEZADO DE LA COTIZACION TRASPASO EN  rd_log_cotizacion_traspaso
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?folio", folio.ToString());
            cmd.Parameters.AddWithValue("?usuario",usuario);
            cmd.Parameters.AddWithValue("?nombre_equipo",nombre_equipo);
            cmd.Parameters.AddWithValue("?ip",ip);
            cmd.Parameters.AddWithValue("?fecha", fecha_traspaso.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha_traspaso.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?tienda_origen", origen);
            cmd.Parameters.AddWithValue("?tienda_destino", destino);
            cmd.Parameters.AddWithValue("?motivo", motivo);
            cmd.ExecuteNonQuery();


            //SE OBTIENE EL ID DE rd_log_cotizacion_traspaso
            int fk_folio=0;
            MySqlCommand cmd1 = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                fk_folio = Convert.ToInt32(dr["folio"].ToString());
            }
            dr.Close();

            //SE GUARDA LOS ARTICULOS DE LA COTIZACION EN rd_log_cotizacion_traspaso_articulos
            MySqlCommand cmd2 = null;
            foreach (DataRow item in dt.Rows)
            {
                cmd2 = new MySqlCommand(query2,con);
                cmd2.Parameters.AddWithValue("?fk_log_cotizacion", fk_folio);
                cmd2.Parameters.AddWithValue("?articulo",item["ARTICULO"].ToString());
                cmd2.Parameters.AddWithValue("?descripcion", item["DESCRIPCION"].ToString());
                cmd2.Parameters.AddWithValue("existencia", item["EXISTENCIA"].ToString());
                cmd2.Parameters.AddWithValue("cantidad", item["CANTIDAD"].ToString());
                cmd2.ExecuteNonQuery();
            }

            con.Close();
        }
        #endregion

    }
}
