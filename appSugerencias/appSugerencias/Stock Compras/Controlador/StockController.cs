using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Stock_Compras.Controlador
{
    public class StockController
    {
        public static List<string> BuscarStocks(string proveedor)
        {
            List<string> stocks = new List<string>();

            string consulta = "SELECT descripcion" +
                "              FROM rd_stock_compra" +
                "              WHERE proveedor ='"+proveedor+"'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                stocks.Add(dr["descripcion"].ToString());
            }
            dr.Close();
            con.Close();

            return stocks;
        }

        public static List<string> ListaProveedores()
        {
            List<string> proveedores = new List<string>();

          
            string consulta = "SELECT proveedor,nombre" +
                "              FROM proveed" +
                "              ORDER BY nombre";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                proveedores.Add(dr["nombre"].ToString());
            }
            dr.Close();
            con.Close();

            return proveedores;

        }

        public static string ClaveProveedor(string nombre)
        {
            string clave = "";
            string consulta = "SELECT proveedor" +
                "              FROM proveed" +
                "              WHERE nombre ='"+nombre+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clave = dr["proveedor"].ToString();
            }
            dr.Close();
            con.Close();
            return clave;
        }
    }
}
