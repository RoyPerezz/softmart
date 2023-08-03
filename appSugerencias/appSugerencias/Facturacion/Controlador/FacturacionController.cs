using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Facturacion.Controlador
{
    public class FacturacionController
    {
       

        public static double CalcularTotalVenta(DateTime fecha,string sucursal)
        {
            string query = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`," +
               "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As `Impuesto`" +
               "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND ventas.caja = 'CAJA1' AND partvta.impuesto > 0 ";

            
            string nventa = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`    " +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND partvta.impuesto = 0 AND ventas.caja = 'CAJA1'";

            double importe = 0,impuesto=0,ventaTotal=0,Nventa=0;
           
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                if (DBNull.Value.Equals(dt.Rows[i]["Importe"].ToString()) || dt.Rows[i]["Importe"].ToString().Equals(""))
                {
                    importe = 0;
                }
                else
                {
                    importe += Convert.ToDouble(dt.Rows[i]["Importe"].ToString());
                }

                if (DBNull.Value.Equals(dt.Rows[i]["Impuesto"].ToString()) || dt.Rows[i]["Importe"].ToString().Equals(""))
                {
                    impuesto = 0;
                }
                else
                {
                    impuesto += Convert.ToDouble(dt.Rows[i]["Impuesto"].ToString());
                }
                //ventaTotal2 = importe + impuesto;


               
                ventaTotal = importe + impuesto;


                MySqlCommand cmd2 = new MySqlCommand(nventa, con);
                MySqlDataReader dr = cmd2.ExecuteReader();



                while (dr.Read())
                {
                    if (DBNull.Value.Equals(dr["Importe"].ToString()) || dr["Importe"].ToString().Equals(""))
                    {
                        Nventa = 0;
                    }
                    else
                    {
                        Nventa = Convert.ToDouble(dr["Importe"].ToString());
                    }
                }

                dr.Close();

                ventaTotal += Nventa;
                
            }

            return ventaTotal;
        }


        public static double VentaTotal(DateTime fecha, MySqlConnection con)
        {
            double ventaTotal = 0;
            try
            {
                


                string query2 = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`," +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As `Impuesto`" +
                    "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND ventas.caja = 'CAJA1' AND partvta.impuesto > 0 ";



                string nventa = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`    " +
                    "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND partvta.impuesto = 0 AND ventas.caja = 'CAJA1'";

               
                double importe = 0, impuesto = 0, Nventa = 0;

                MySqlCommand cmd = new MySqlCommand(query2, con);
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    importe += Convert.ToDouble(dt.Rows[i]["importe"].ToString());
                    impuesto += Convert.ToDouble(dt.Rows[i]["impuesto"].ToString());
                    //ventaTotal += Convert.ToDouble(dt.Rows[i]["Total"].ToString());
                    ventaTotal = importe + impuesto;
                }

                MySqlCommand cmd2 = new MySqlCommand(nventa, con);
                MySqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    if (DBNull.Value.Equals(dr2["Importe"].ToString()) || dr2["Importe"].ToString().Equals(""))
                    {
                        Nventa = 0;
                    }
                    else
                    {
                        Nventa = Convert.ToDouble(dr2["Importe"].ToString());
                    }
                }
                dr2.Close();

                ventaTotal += Nventa;



            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:" + ex);
            }





            return ventaTotal;

        }
        public static double CalcularTotalEfectivo(DateTime fecha,string sucursal,string mes,int año,bool respaldo)
        {
            double total = 0;
            double cambio = 0;
            double ventaEfectivo = 0;
            double devEFE = 0;
            string consulta = " SELECT SUM( Importe ) As `Ingreso`, flujo.concepto2, coningre.descrip " +
                "FROM flujo INNER JOIN coningre ON flujo.concepto = coningre.concepto " +
                "WHERE (estacion = 'CAJA1') AND ing_eg = 'I' AND FECHA='" + fecha.ToString("yyyy-MM-dd") + "' AND flujo.concepto2 = 'EFE' AND moneda = 'MN' GROUP BY flujo.concepto2";

            string consulta2 = " SELECT SUM( Importe ) As `Egreso`, flujo.concepto, conegre.descrip " +
                "FROM flujo INNER JOIN conegre ON flujo.concepto = conegre.concepto " +
                "WHERE (estacion = 'CAJA1' ) AND ing_eg = 'E' AND FECHA='" + fecha.ToString("yyyy-MM-dd") + "'AND flujo.concepto2 = 'CAM' AND moneda = 'MN' GROUP BY flujo.concepto";


            string devoluciones = "SELECT ventas.importe ,ventas.impuesto , ventas.OrigenDev,flujo.concepto2 " +
                "FROM ventas inner join flujo on ventas.OrigenDev = flujo.venta " +
                "where ventas.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "' and ventas.TIPO_DOC = 'DV' AND(ventas.CAJA = 'CAJA1') GROUP BY ventas.OrigenDev";

           

            MySqlConnection con = null;

            if (respaldo== true)
            {

                
                con = BDConexicon.RespMultiSuc(sucursal, mes, año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }


            MySqlDataReader dr = null;
            MySqlCommand cmd = null;
            cmd = new MySqlCommand(consulta, con);
          dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                total = Convert.ToDouble(dr["Ingreso"].ToString());
            }
            dr.Close();

            cmd = new MySqlCommand(consulta2, con);
            //MySqlDataReader dr2 = cmd2.ExecuteReader();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cambio = Convert.ToDouble(dr["Egreso"].ToString());
            }
            dr.Close();

            cmd = new MySqlCommand(devoluciones, con);
            //MySqlDataReader dr2 = cmd2.ExecuteReader();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["concepto2"].ToString().Equals("EFE"))
                {
                    devEFE += Convert.ToDouble(dr["importe"].ToString()) + Convert.ToDouble(dr["impuesto"].ToString());
                }

            }
            dr.Close();
            ventaEfectivo = total - cambio- devEFE;
            return ventaEfectivo;
        }

        public static double CalcularTotalTarjetas(DateTime fecha, string sucursal, string mes, int año, bool respaldo)
        {
            double ventaTarjetas = 0;
            string query = "select sum(importe) as tarjetas from flujo where concepto2 ='TAR' AND FECHA ='" + fecha.ToString("yyyy-MM-dd") + "' AND ESTACION='CAJA1'";

            string consulta = "SELECT ventas.importe ,ventas.impuesto , ventas.OrigenDev,flujo.concepto2 " +
                "FROM ventas inner join flujo on ventas.OrigenDev = flujo.venta " +
                "where ventas.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "' and ventas.TIPO_DOC = 'DV' AND(ventas.CAJA = 'CAJA1') GROUP BY ventas.OrigenDev";

            double devTAR = 0;
            MySqlConnection con = null;
           
            if (respaldo == true)
            {


                con = BDConexicon.RespMultiSuc(sucursal, mes, año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            cmd = new MySqlCommand(query, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (dr["tarjetas"].ToString().Equals(""))
                {
                    ventaTarjetas = 0;
                }
                else
                {
                    ventaTarjetas = Convert.ToDouble(dr["tarjetas"].ToString());
                }

            }
            dr.Close();

           cmd = new MySqlCommand(consulta, con);
           dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //devoluciones.Rows.Add(dr["total"].ToString(),dr["OrigenDev"].ToString(),dr["concepto2"].ToString());



                if (dr["concepto2"].ToString().Equals("TAR"))
                {
                    devTAR += Convert.ToDouble(dr["importe"].ToString()) + Convert.ToDouble(dr["impuesto"].ToString());
                }




            }




            return ventaTarjetas - devTAR;

        }

        public static double CalcularFacturacionEfectivo(DateTime fecha, string sucursal, string mes, int año, bool respaldo, ArrayList ventasEfectivo)
        {
            MySqlConnection con = null;
            if (respaldo == true)
            {

               
                con = BDConexicon.RespMultiSuc(sucursal, mes,año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            double total = 0;
            for (int i = 0; i < ventasEfectivo.Count; i++)
            {
                cmd = new MySqlCommand("select total from facturacion where no_ticket ='" + ventasEfectivo[i].ToString() + "'  and rfccliente<>'XAXX010101000'", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //total += Convert.ToDouble(dr["total"].ToString());
                }
                dr.Close();
            }



            con.Close();
            return total;
        }

       public static double CalcularDepositoDeCliente(DateTime fecha,string sucursal,string patron)
        {
            double depositoCliente = 0;
            string consulta = "select sum(importe) as deposito from rd_pagos_enc_cajas where nomprov='" + patron + "' and fecha_pago = '" + fecha.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["deposito"].ToString().Equals(""))
                {
                    depositoCliente = 0;
                }
                else
                {
                    depositoCliente += Convert.ToDouble(dr["deposito"].ToString());
                }
            }
            dr.Close();
            con.Close();

            return depositoCliente;
        }

        public static double ObtenerDepositoVentanilla(DateTime fecha, string sucursal)
        {
            double deposito = 0;



            return deposito;
        }

    }
}
