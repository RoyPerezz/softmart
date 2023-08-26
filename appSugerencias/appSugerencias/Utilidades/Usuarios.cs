using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Utilidades
{
    public class Usuarios
    {

        
        public static string AreaTrabajo(string usuario,string sucursal)
        {
            string area = "";
            string query = "SELECT area FROM usuarios WHERE usuario='"+usuario+"'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                area = dr["area"].ToString();
            }
            dr.Read();
            con.Close();
            return area;
        }
    }
}
