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
