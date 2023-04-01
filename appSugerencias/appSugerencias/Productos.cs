using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class Productos
    {
        public string articulo { get; set; }
        public double existenciaRec { get; set; }

        public  DataTable ArticulosPorLinea(string linea)
        {
            string query = "SELECT articulo,descrip,precio1,precio2 FROM prods WHERE linea ='"+linea+"'";
            DataTable dt = new DataTable();
            dt.Columns.Add("ARTICULO",typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("MENUDEO", typeof(double));
            dt.Columns.Add("MAYOREO", typeof(double));

            MySqlConnection conexion = BDConexicon.BodegaOpen();
             MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["articulo"].ToString(),dr["descrip"].ToString(),Convert.ToDouble(dr["precio1"].ToString()),Convert.ToDouble(dr["precio2"].ToString()));
            }
            dr.Close();
            conexion.Close();

            return dt;
        }

        public DataTable ExistenciaVa(string linea)
        {
            DataTable existencia = new DataTable();

            existencia.Columns.Add("ARTICULO", typeof(string));
            existencia.Columns.Add("EXISTENCIA", typeof(int));
            string query = "SELECT articulo,existencia FROM prods WHERE linea ='"+linea+"'";
            MySqlConnection con = BDConexicon.VallartaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string articulo = dr["articulo"].ToString();
                int exis = Convert.ToInt32(dr["existencia"].ToString());
                existencia.Rows.Add(dr["articulo"].ToString(),dr["existencia"].ToString());
            }
            dr.Close();
            con.Close();
            return existencia;
        }

        public int ExistenciaXTienda(string articulo,string tienda)
        {
            int existencia = 0;

            
            string query = "SELECT articulo,existencia FROM prods WHERE articulo ='" + articulo + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(tienda);


            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
              
                existencia = Convert.ToInt32(dr["existencia"].ToString());
               
            }
            dr.Close();
            con.Close();
            return existencia;
        }

        public DataTable ExistenciaRe(string linea)
        {
            DataTable existencia = new DataTable();

            existencia.Columns.Add("ARTICULO", typeof(string));
            existencia.Columns.Add("EXISTENCIA", typeof(int));
            string query = "SELECT articulo,existencia FROM prods WHERE linea ='" + linea + "'";
            MySqlConnection con = BDConexicon.RenaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                existencia.Rows.Add(dr["articulo"].ToString(), dr["existencia"].ToString());
            }
            dr.Close();
            con.Close();
            return existencia;
        }

        public DataTable ExistenciaVe(string linea)
        {
            DataTable existencia = new DataTable();

            existencia.Columns.Add("ARTICULO", typeof(string));
            existencia.Columns.Add("EXISTENCIA", typeof(int));
            string query = "SELECT articulo,existencia FROM prods WHERE linea ='" + linea + "'";
            MySqlConnection con = BDConexicon.VelazquezOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                existencia.Rows.Add(dr["articulo"].ToString(), dr["existencia"].ToString());
            }
            dr.Close();
            con.Close();
            return existencia;
        }

        public DataTable ExistenciaCo(string linea)
        {
            DataTable existencia = new DataTable();

            existencia.Columns.Add("ARTICULO", typeof(string));
            existencia.Columns.Add("EXISTENCIA", typeof(int));
            string query = "SELECT articulo,existencia FROM prods WHERE linea ='" + linea + "'";
            MySqlConnection con = BDConexicon.ColosoOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                existencia.Rows.Add(dr["articulo"].ToString(), dr["existencia"].ToString());
            }
            dr.Close();
            con.Close();
            return existencia;
        }
    }
}
