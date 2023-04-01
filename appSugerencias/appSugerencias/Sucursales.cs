using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class Sucursales
    {

        private static DataTable sucursales = new DataTable();

        public Sucursales()
        {
         
        }

        public static string IdentificarSucursal()
        {
            string sucursal = "";
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT EMPRESA FROM econfig";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                sucursal = dr["EMPRESA"].ToString();
            }
            dr.Close();
            conexion.Close();

            if (sucursal.Equals("BODEGA"))
            {
                sucursal = "BODEGA";
            }

            if (sucursal.Equals("OSMART VALLARTA"))
            {
                sucursal = "VALLARTA";
            }

            if (sucursal.Equals("OSMART RENACIMIENTO"))
            {
                sucursal = "RENA";
            }


            if (sucursal.Equals("OSMART VELAZQUEZ"))
            {
                sucursal = "VELAZQUEZ";
            }

            if (sucursal.Equals("OSMART COLOSO"))
            {
                sucursal = "COLOSO";
            }

            return sucursal;
        }

        public static DataTable ObtenerSucursales()
        {
            sucursales.Columns.Clear();
            sucursales.Columns.Add("SUC_AB", typeof(string));
            sucursales.Columns.Add("DESCRIPCION", typeof(string));
            sucursales.Columns.Add("IP", typeof(string));

            sucursales.Rows.Clear();
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "Select * from rd_sucursales where activo=1";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sucursales.Rows.Add(dr["suc_ab"].ToString(),dr["descripcion"].ToString(),dr["direccion_ip"].ToString());
            }
            dr.Close();
            conexion.Close();
            return sucursales;
        }
    }
}
