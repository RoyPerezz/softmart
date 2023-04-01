using appSugerencias.Ventas.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Ventas.Controlador
{
    class VentaController
    {

        public static double VentaDia(string sucursal, DateTime fecha,bool respaldo)
        {
            double totalVenta = 0;
            double venta=0, Nventa=0;
            MySqlConnection con = null;

            int m = fecha.Month;
            int año = fecha.Year;

            string mes = FormatoFecha.Mes(m);
            if (respaldo == true)
            {
                con = BDConexicon.RespMultiSuc(sucursal, mes, año); ;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }
            string query1 = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`," +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As `Impuesto`" +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "'  AND partvta.impuesto > 0 ";


            string nventa = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`    " +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND partvta.impuesto = 0";

            MySqlCommand cmd = new MySqlCommand(query1,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                venta = Convert.ToDouble(dr["Importe"].ToString()) + Convert.ToDouble(dr["Impuesto"].ToString());
               
            }
            dr.Close();


            MySqlCommand cmd2 = new MySqlCommand(nventa,con);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                if (dr2["Importe"].ToString().Equals(""))
                {
                    Nventa = 0;
                }
                else
                {
                    Nventa = Convert.ToDouble(dr2["Importe"].ToString());
                }
               
            }
            dr2.Close();
            con.Close();
            totalVenta = venta + Nventa;
            return totalVenta;
        }

        public static List<Ingreso> OtrosIngresos(string sucursal,DateTime fecha,bool respaldo)
        {
            List<Ingreso> ingresos = new List<Ingreso>();
            string query = "select coningre.CONCEPTO,coningre.DESCRIP AS DESCRIPCION ,SUM(flujo.IMPORTE) AS IMPORTE from flujo INNER JOIN coningre ON coningre.CONCEPTO = flujo.CONCEPTO " +
                "where flujo.ING_EG = 'I' AND flujo.CONCEPTO <> 'CLIEN'   AND fecha='" + fecha.ToString("yyyy-MM-dd")+ "'  GROUP BY coningre.DESCRIP";

            MySqlConnection con = null;
            int m = fecha.Month;
            int año = fecha.Year;

            string mes = FormatoFecha.Mes(m);
            if (respaldo == true)
            {
                con = BDConexicon.RespMultiSuc(sucursal, mes, año); ;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ingreso ingreso = new Ingreso()
                {
                   

                    Concepto = dr["CONCEPTO"].ToString(),
                    Descripcion = dr["DESCRIPCION"].ToString(),
                    Importe = Convert.ToDouble(dr["IMPORTE"].ToString()),
                };

                ingresos.Add(ingreso);
            }
            return ingresos;
        }

        public static List<Ingreso> OtrosIngresos(string sucursal, DateTime inicio,DateTime fin, bool respaldo)
        {
            List<Ingreso> ingresos = new List<Ingreso>();
            string query = "select coningre.CONCEPTO,coningre.DESCRIP AS DESCRIPCION ,SUM(flujo.IMPORTE) AS IMPORTE from flujo INNER JOIN coningre ON coningre.CONCEPTO = flujo.CONCEPTO " +
                "where flujo.ING_EG = 'I' AND flujo.CONCEPTO <> 'CLIEN'   AND fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '"+ fin.ToString("yyyy-MM-dd") + "' GROUP BY coningre.DESCRIP";

            MySqlConnection con = null;
            int m = inicio.Month;
            int año = inicio.Year;

            string mes = FormatoFecha.Mes(m);
            if (respaldo == true)
            {
                con = BDConexicon.RespMultiSuc(sucursal, mes, año); ;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ingreso ingreso = new Ingreso()
                {


                    Concepto = dr["CONCEPTO"].ToString(),
                    Descripcion = dr["DESCRIPCION"].ToString(),
                    Importe = Convert.ToDouble(dr["IMPORTE"].ToString()),
                };

                ingresos.Add(ingreso);
            }
            return ingresos;
        }


        public static List<Ingreso> BuscarIngreso(string sucursal,DateTime fecha, string clave, bool respaldo)

        {
            List<Ingreso> ingreso = new List<Ingreso>();
            string query = "SELECT  flujo.CONCEPTO, coningre.DESCRIP, flujo.IMPORTE " +
                "FROM flujo INNER JOIN coningre ON flujo.CONCEPTO = coningre.CONCEPTO WHERE flujo.CONCEPTO='"+clave+"' AND flujo.FECHA='"+fecha.ToString("yyyy-MM-dd")+"'";

            MySqlConnection con = null;
            int m = fecha.Month;
            int año = fecha.Year;

            string mes = FormatoFecha.Mes(m);
            if (respaldo == true)
            {
                con = BDConexicon.RespMultiSuc(sucursal, mes, año); ;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Ingreso ing = new Ingreso()
                {
                    Concepto = dr["CONCEPTO"].ToString(),
                    Descripcion = dr["DESCRIP"].ToString(),
                    Importe = Convert.ToDouble(dr["IMPORTE"].ToString())
                };

                ingreso.Add(ing);
            }

            return ingreso;
        }


        public static ArrayList Devoluciones(string sucursal, DateTime inicio, DateTime fin, bool check)
        {
            MySqlConnection con = null;
            ArrayList dev = new ArrayList();
            if (check == true)
            {
                string mes = FormatoFecha.Mes(inicio.Month);
                con = BDConexicon.RespMultiSuc(sucursal, mes, inicio.Year);
                check = true;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }


            string query = "SELECT * FROM ventas WHERE TIPO_DOC='DV' AND F_EMISION between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr =  cmd.ExecuteReader();
            while (dr.Read())
            {
                dev.Add(dr["ventas"].ToString());
            }
            dr.Close();
            return dev;
        }

        public static List<VentasXTicket> Ventas(string sucursal,DateTime inicio,DateTime fin,bool check)
        {

            ArrayList fechas = new ArrayList();

            string aux = "";
            for (DateTime dia = inicio; dia <= fin; dia = dia.AddDays(1))
            {
                aux = Convert.ToString(dia.ToShortDateString());
                fechas.Add(aux);
            }

           

           
            
            //DateTime VentasCaja2 = Convert.ToDateTime("2022-12-21");
            List<VentasXTicket> lista = new List<VentasXTicket>();
            //string query = "SELECT * FROM ventas where F_EMISION BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"' and CAJA = 'CAJA1' order by USUFECHA,USUHORA";
            //string query2 = "SELECT * FROM ventas where F_EMISION BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' and CAJA = 'CAJA2' order by USUFECHA,USUHORA";


           
            MySqlConnection con = null;
            if (check== true)
            {
                string mes = FormatoFecha.Mes(inicio.Month);
                con = BDConexicon.RespMultiSuc(sucursal, mes, inicio.Year);
                check = true;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            DateTime fechaConsulta;

            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            for (int i = 0; i < fechas.Count; i++)
            {
                fechaConsulta = Convert.ToDateTime(fechas[i].ToString());
                if ( fechaConsulta >= Convert.ToDateTime("2022-12-21"))
                {
                    cmd = new MySqlCommand("SELECT * FROM ventas where F_EMISION ='" + Convert.ToDateTime(fechas[i].ToString()).ToString("yyyy-MM-dd") + "' and CAJA = 'CAJA1'  order by USUFECHA,USUHORA", con);
                }
                else
                {
                    cmd = new MySqlCommand("SELECT * FROM ventas where F_EMISION ='" + Convert.ToDateTime(fechas[i].ToString()).ToString("yyyy-MM-dd") + "' and CAJA IN ('CAJA1','CAJA2')  order by USUFECHA,USUHORA", con);
                }


                
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    VentasXTicket venta = new VentasXTicket()
                    {
                        Venta = Convert.ToInt32(dr["VENTA"].ToString()),
                        Tipo_Doc = dr["TIPO_DOC"].ToString(),
                        No_referen = Convert.ToInt32(dr["NO_REFEREN"].ToString()),
                        F_Emision = Convert.ToDateTime(dr["F_EMISION"].ToString()),
                        UsuHora = dr["USUHORA"].ToString(),
                        Usuario = dr["USUARIO"].ToString(),
                        Importe = Convert.ToDouble(dr["IMPORTE"].ToString()),
                        Impuesto = Convert.ToDouble(dr["IMPUESTO"].ToString()),
                        Caja = dr["CAJA"].ToString(),
                        ventaDev = dr["OrigenDev"].ToString()


                    };
                    lista.Add(venta);

                   
                }
                dr.Close();
            }

            
            
           


            return lista;
        }

        public static DataTable IngresosIncongruencia(string sucursal,DateTime inicio,DateTime fin,bool check)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CONCEPTO",typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("IMPORTE", typeof(double));
            dt.Columns.Add("FECHA", typeof(string));

            string query = "select coningre.CONCEPTO,coningre.DESCRIP,SUM(flujo.IMPORTE) AS IMPORTE,flujo.FECHA " +
                "from coningre inner join flujo on coningre.CONCEPTO=flujo.CONCEPTO " +
                "WHERE flujo.FECHA between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"' and flujo.CONCEPTO IN ('SOBRA','COMIE','COMID') GROUP BY coningre.CONCEPTO,flujo.FECHA";
            MySqlConnection con = null;
            MySqlDataReader dr = null;
            string mes = FormatoFecha.Mes(inicio.Month);

            if (check == true)
            {
                con = BDConexicon.RespMultiSuc(sucursal,mes,inicio.Year);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            MySqlCommand cmd = new MySqlCommand(query,con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["CONCEPTO"].ToString(),dr["DESCRIP"].ToString(),Convert.ToDouble(dr["IMPORTE"].ToString()),dr["FECHA"].ToString());
            }
            dr.Close();

            return dt;
        }

        public static DataTable Sobrantes(string sucursal, DateTime inicio, DateTime fin, bool check)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CONCEPTO",typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("IMPORTE", typeof(double));
            dt.Columns.Add("FECHA", typeof(string));
            dt.Columns.Add("CAJA", typeof(string));
            dt.Columns.Add("CAJERA", typeof(string));
            dt.Columns.Add("TICKET", typeof(string));
            dt.Rows.Clear();
            int m = 0;
            string mes = "";
            string query = "SELECT coningre.CONCEPTO,coningre.DESCRIP,flujo.IMPORTE,flujo.FECHA,flujo.ESTACION,flujo.USUARIO,flujo.FLUJO FROM coningre INNER JOIN flujo ON coningre.CONCEPTO = flujo.CONCEPTO " +
                "WHERE flujo.FECHA BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"' AND (coningre.CONCEPTO='SOBRA' OR coningre.CONCEPTO LIKE 'SBR%') ";
            MySqlConnection con = null;
            if (check == true)
            {
                m = inicio.Month;
                mes = FormatoFecha.Mes(m);
                con = BDConexicon.RespMultiSuc(sucursal,mes,inicio.Year);
            }else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["CONCEPTO"].ToString(), dr["DESCRIP"].ToString(),dr["IMPORTE"].ToString(), dr["FECHA"].ToString(), dr["ESTACION"].ToString(), dr["USUARIO"].ToString(), dr["FLUJO"].ToString());
            }
            dr.Close();
            return dt;
        }
    }
}
