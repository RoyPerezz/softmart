using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Utilidades
{
    public class Catalogos
    {

        public static List<string> CatalogoClavesLineas()
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            List<string> lineas = new List<string>();
            string query = "SELECT linea" +
                "           FROM lineas" +
                "           ORDER BY linea";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lineas.Add(dr["linea"].ToString());
            }
            dr.Close();
            con.Close();
            return lineas;
        }

        public static string ClaveLinea(string nombreLinea)
        {
            string clavelinea = "";
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "SELECT linea" +
                "           FROM lineas" +
                "           WHERE Descrip='"+nombreLinea+"'";

            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clavelinea = dr["linea"].ToString();
            }
            dr.Close();
            con.Close();
            return clavelinea;
        }
        public static List<string> CatalogoLineas()
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            List<string> lineas = new List<string>();
            string query = "SELECT Descrip" +
                "           FROM lineas" +
                "           ORDER BY Descrip";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lineas.Add(dr["Descrip"].ToString());
            }
            dr.Close();
            con.Close();
            return lineas;
        }

        public static List<string> CatalogoNombreFabricantes()
        {
            MySqlConnection con = BDConexicon.VallartaOpen();
            List<string> proveedores = new List<string>();
            string query = "SELECT distinct fabricante" +
                "           FROM prods" +
                "           ORDER BY fabricante";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                proveedores.Add(dr["fabricante"].ToString());
            }
            dr.Close();
            con.Close();
            return proveedores;
        }

    }
}
