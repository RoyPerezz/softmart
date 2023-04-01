using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    public class Consec
    {


        //COSECUTIVO DE ABONO
        public static int ConsecutivoAbono(string sucursal)
        {

            
            int consecutivo = 0;
            string query = "";


            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            if (sucursal.Equals("BODEGA"))
            {
                query = "SELECT Consec FROM Consec WHERE Dato='Abonoprov'";
                
            }
            else
            {
                query = "SELECT Consec FROM Consec WHERE Dato='ABONOPROV'";
            }
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consecutivo = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            return consecutivo;
        }


        //CONSECUTIVO DE DESGLOSE DE ABONOS
        public static int ConsecAbono(string sucursal)
        {
            int consec = 0;
            MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
            string query = "SELECT Consec FROM consec WHERE Dato='consecAbono'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consec = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            conexion.Close();

            return consec;
        }

    }
}
