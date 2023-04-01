using appSugerencias.Piso_de_venta.Modelo;
using appSugerencias.Utilidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Piso_de_venta.Controladores
{
    class PisoVentaController
    {

        public PisoVentaController()
        {
           

        }
        public static List<Articulo> ArticulosConExistencia(string linea)
        {
            List<Articulo> lista = new List<Articulo>();
            string query = "SELECT articulo," +
                "                  descrip," +
                "                  precio1," +
                "                  precio2," +
                "                  existencia" +
                "           FROM prods" +
                "           WHERE linea ='"+linea+"' AND existencia > 0" +
                "           ORDER BY articulo desc";

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Articulo articulos = new Articulo()
                {
                    Clave = dr["articulo"].ToString(),
                    Descripcion = dr["descrip"].ToString(),
                    PrecioMenudeo = Convert.ToDouble(dr["precio1"].ToString()),
                    PrecioMayoreo = Convert.ToDouble(dr["precio2"].ToString()),
                    Existencia = Convert.ToInt32(dr["existencia"].ToString())
                };
                lista.Add(articulos);
            }
            dr.Close();
            con.Close();
            return lista;
        }

        public static List<Articulo> Lineas()
        {
            List<Articulo> lineas = new List<Articulo>();
            string query = "SELECT linea,descrip FROM lineas order by descrip";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Articulo linea = new Articulo()
                {
                    Linea = dr["linea"].ToString(),
                    LineaDescrip = dr["descrip"].ToString()
                };

                lineas.Add(linea);
            }
            dr.Close();
            con.Close();
            return lineas;

        }

        public static string Clavelinea(string linea)
        {
            string claveLinea = "";
            string query = "SELECT linea " +
                "           FROM lineas " +
                "           WHERE descrip='"+linea+"'";

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                claveLinea = dr["linea"].ToString();
            }
            dr.Close();
            con.Close();
            return claveLinea;
        }

        
    }
}
