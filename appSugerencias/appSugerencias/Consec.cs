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

        public static int ConsecMovsinv(string sucursal)
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='movsinv'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
            dr.Close();
            con.Close();
            


            return consec;

        }

        public static int ConsecCompra(string sucursal)
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='Compra'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                consec += consec = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            con.Close();



            return consec;
        }

        public static int ConsecPartcomp(string sucursal)
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='partcomp'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                consec += consec = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            con.Close();

            return consec;
        }

        public static int ConsecCuentasXPagar(string sucursal)
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM consec WHERE Dato='cuenxpag'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                consec += consec = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            con.Close();

            return consec;
        }
    }
}
