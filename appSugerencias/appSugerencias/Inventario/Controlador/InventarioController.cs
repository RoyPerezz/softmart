using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Inventario.Controlador
{
    public class InventarioController
    {
        public static DataTable ValorInventarioLinea(string linea, string sucursal)
        {
            DataTable costo = new DataTable();
            costo.Columns.Add("linea", typeof(string));
            costo.Columns.Add("precio mayoreo", typeof(double));
            costo.Columns.Add("costo", typeof(double));
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);

            return costo;
        }

        public static double InventarioAlMayoreo(string sucursal,string linea)
        {
            double total = 0;
            try
            {
                MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
                string query = "SELECT sum(prods.existencia * prods.PRECIO2) AS `mayoreo` FROM prods" +
                    " WHERE prods.articulo <> 'SYS' and prods.EXISTENCIA > 0 and prods.linea ='"+linea+"' ";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total = Convert.ToDouble(dr["mayoreo"].ToString());
                }
                dr.Close();
                conexion.Close();


            }

            catch (Exception ex)

            {
                Console.WriteLine("" + ex);
            }
            return total;
        }

        public static  double InventarioAlCosto(string sucursal,string linea)
        {
            double total = 0;
            try
            {
                MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
                string query = "SELECT sum(prods.existencia * prods.costo_u) AS `costo` FROM prods WHERE prods.articulo <> 'SYS' and prods.EXISTENCIA > 0 and prods.linea ='"+linea+"' ORDER BY prods.descrip";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total = Convert.ToDouble(dr["costo"].ToString());
                }
                dr.Close();
                conexion.Close();
                

            }

            catch (Exception ex)

            {
              
                
            }

            return total;
        }
    }
}
