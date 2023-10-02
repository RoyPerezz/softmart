using appSugerencias.Stock_Compras.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Stock_Compras.Controlador
{
    public class CompraController
    {
        public static List<string> ListaProveedores()
        {
            List<string> proveedores = new List<string>();


            string consulta = "SELECT proveedor,nombre" +
                "              FROM proveed" +
                "              ORDER BY nombre";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                proveedores.Add(dr["nombre"].ToString());
            }
            dr.Close();
            con.Close();

            return proveedores;

        }

        public static List<string> BuscarStocks(string proveedor)
        {
            List<string> stocks = new List<string>();

            string consulta = "SELECT descripcion" +
                "              FROM rd_stock_compra" +
                "              WHERE proveedor ='" + proveedor + "'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                stocks.Add(dr["descripcion"].ToString());
            }
            dr.Close();
            con.Close();

            return stocks;
        }

        public static string ClaveProveedor(string nombre)
        {
            string clave = "";
            string consulta = "SELECT proveedor" +
                "              FROM proveed" +
                "              WHERE nombre ='" + nombre + "'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clave = dr["proveedor"].ToString();
            }
            dr.Close();
            con.Close();
            return clave;
        }


        public static int IdStockCompra(string stock)
        {
            int id = 0;
            string query = "SELECT idreg" +
                "           FROM rd_stock_compra" +
                "           WHERE descripcion='" + stock + "'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id= Convert.ToInt32(dr["idreg"].ToString());
            }
            dr.Close();
            con.Close();

            return id;
        }
        public static List<Compra> BuscarDatosCompra(int id_stock)
        {
            List<Compra> compra = new List<Compra>();
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "SELECT claveProducto," +
                "                  descripcion," +
                "                   costoxpz," +
                "                   precio_mayoreo," +
                "                   precio_menudeo," +
                "                   departamento," +
                "                   ped_va," +
                "                   ped_re," +
                "                   ped_ve," +
                "                   ped_co," +
                "                   ped_ce" +
                "           FROM rd_detalle_stock_compra" +
                "           WHERE fk_stock="+id_stock+"";
            Compra ArticulosCompra = null;
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ArticulosCompra = new Compra()
                {
                    ClaveProducto = dr["claveProducto"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Costo = Convert.ToDouble(dr["costoxpz"].ToString()),
                    Precio_mayoreo = Convert.ToDouble(dr["precio_mayoreo"].ToString()),
                    Precio_menudo = Convert.ToDouble(dr["precio_menudeo"].ToString()),
                    Linea = dr["departamento"].ToString(),
                    CantidadVA = Convert.ToInt32(dr["ped_va"]),
                    CantidadRE = Convert.ToInt32(dr["ped_re"]),
                    CantidadVE = Convert.ToInt32(dr["ped_ve"]),
                    CantidadCO = Convert.ToInt32(dr["ped_co"]),
                    CantidadBO = Convert.ToInt32(dr["ped_ce"]),
                };
                compra.Add(ArticulosCompra);
            }


            return compra;
        }

        public static List<Compra> ValoresEncabezado(string stock)
        {
            List<Compra> lista = new List<Compra>();
            Compra compra = null;
            string query = "SELECT folio," +
                "                  descuento," +
                "                  utilidad" +
                "          FROM rd_stock_compra" +
                "          WHERE idreg='"+stock+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                compra = new Compra()
                {
                    Folio = dr["folio"].ToString(),
                    Descuento = Convert.ToInt32(dr["descuento"].ToString()),
                    Utilidad = Convert.ToInt32(dr["utilidad"].ToString())
                };
                lista.Add(compra);
            }

            dr.Close();
            con.Close();
            return lista;

        }
    }
}
