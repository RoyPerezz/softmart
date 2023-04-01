using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    public static class Kardex
    {
        public static DataTable BuscarLineas()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("LINEAS",typeof(string));
            string query = "SELECT Linea FROM lineas order by Linea";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dt.Rows.Add(dr["Linea"].ToString());
            }
            dr.Read();
            conexion.Close();
            return dt;
        }


        public static DataTable KardexArticulo(string articulo, string f_inicio, string f_fin,string sucursal)
        {
            DataTable kardex = new DataTable();

            //kardex.Columns.Add("USUARIO",typeof(string));
            //kardex.Columns.Add("TIPO MOV", typeof(string));
            //kardex.Columns.Add("REFERENCIA", typeof(string));
            //kardex.Columns.Add("MOVIMIENTO", typeof(string));
            //kardex.Columns.Add("FECHA", typeof(string));
            //kardex.Columns.Add("ENT SAL", typeof(string));
            //kardex.Columns.Add("CANTIDAD", typeof(string));
            //kardex.Columns.Add("EXISTENCIA", typeof(string));
            //kardex.Columns.Add("COSTO", typeof(string));
            //kardex.Columns.Add("ALM", typeof(string));
   
            string query = "select movsinv.usuario AS USUARIO, movsinv.tipo_movim AS TIPO, movsinv.no_referen AS REFERENCIA, movsinv.f_movim as FECHA, movsinv.ent_sal AS 'E/S',movsinv.cantidad AS CANTIDAD, movsinv.existencia AS EXISTENCIA, movsinv.costo AS COSTO " +
                "" +
                "FROM movsinv INNER JOIN prods ON movsinv.articulo = prods.articulo " +
                "WHERE movsinv.consec > 0 and movsinv.ARTICULO = '"+articulo+"' AND F_MOVIM between '"+f_inicio+"' and '"+f_fin+"'";

            MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(kardex);
            conexion.Close();
            return kardex;
        }


    }
}
