using appSugerencias.Cajas.Cajeras.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Cajas.Cajeras.Controlador
{
    class IncidenciasEtiquetasController
    {
        public static void Registrar(IncidenciaEtiqueta ie)
        {
            string query = "INSERT INTO rd_etiquetas_para_corregir(articulo,descripcion,fecha,usuario,caja,incidencia,estado,ruta_foto,nombre_foto)VALUES(?articulo,?descripcion,?fecha,?usuario,?caja,?incidencia,?estado,?ruta_foto,?nombre_foto)";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("?articulo", ie.Articulo);
            cmd.Parameters.AddWithValue("?descripcion", ie.Descripcion);
            cmd.Parameters.AddWithValue("?fecha", ie.Fecha);
            cmd.Parameters.AddWithValue("?usuario", ie.Usuario);
            cmd.Parameters.AddWithValue("?caja", ie.Caja);
            cmd.Parameters.AddWithValue("?incidencia", ie.Incidencia);
            cmd.Parameters.AddWithValue("?estado", ie.Estado);
            cmd.Parameters.AddWithValue("?ruta_foto", ie.RutaFoto);
            cmd.Parameters.AddWithValue("?nombre_foto", ie.NombreFoto);
            cmd.ExecuteNonQuery();
        }

        public static List<IncidenciaEtiqueta> ListadoIncidencias(DateTime inicio, DateTime fin)
        {
            List<IncidenciaEtiqueta> lista = new List<IncidenciaEtiqueta>();
            string query = "SELECT * FROM rd_etiquetas_para_corregir WHERE fecha between '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IncidenciaEtiqueta ie = new IncidenciaEtiqueta()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    Articulo = dr["articulo"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Usuario = dr["usuario"].ToString(),
                    Caja = dr["caja"].ToString(),
                    RutaFoto = dr["ruta_foto"].ToString(),
                    NombreFoto = dr["nombre_foto"].ToString(),
                    Estado = Convert.ToInt32(dr["estado"].ToString()),
                    Incidencia = dr["incidencia"].ToString()
                    
                    
                };

                lista.Add(ie);
            }

            return lista;

        }

        public static List<IncidenciaEtiqueta> ListadoIncidenciasXSucursal(string sucursal,DateTime inicio, DateTime fin)
        {
            List<IncidenciaEtiqueta> lista = new List<IncidenciaEtiqueta>();
            string query = "SELECT * FROM rd_etiquetas_para_corregir WHERE fecha between '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IncidenciaEtiqueta ie = new IncidenciaEtiqueta()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    Articulo = dr["articulo"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Usuario = dr["usuario"].ToString(),
                    Caja = dr["caja"].ToString(),
                    RutaFoto = dr["ruta_foto"].ToString(),
                    NombreFoto = dr["nombre_foto"].ToString(),
                    Estado = Convert.ToInt32(dr["estado"].ToString()),
                    Incidencia = dr["incidencia"].ToString()


                };

                lista.Add(ie);
            }

            return lista;

        }

        public static string  BuscarArticuloExacto(string articulo)
        {
            string descripcion = "";
            string query = "SELECT descrip FROM prods WHERE articulo ='"+articulo+"'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                descripcion = dr["descrip"].ToString();
            }
            dr.Close();
            con.Close();
            return descripcion;
        }

        public static DataTable BuscarArticulosCoincidencia(string articulo)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ARTICULO",typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));

            string query = "SELECT articulo,descrip FROM prods WHERE articulo like '%"+articulo+"%'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["articulo"].ToString(),dr["descrip"].ToString());

            }
            dr.Close();
            con.Close();

            return dt;
        }

        public static List<IncidenciaEtiqueta> BuscarIncidencias()
        {
            List<IncidenciaEtiqueta> lista = new List<IncidenciaEtiqueta>();
            string query = "SELECT incidencia FROM rd_incidencias_etiquetas";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IncidenciaEtiqueta ie = new IncidenciaEtiqueta()
                {
                    Incidencia = dr["incidencia"].ToString()
                };
                lista.Add(ie);
            }

            return lista;
        }

        public static void GuardarFotoEtiqueta(string ruta,string nombre,int id)
        {
            string query = "UPDATE rd_etiquetas_para_corregir SET ruta_foto ='" + ruta + "', nombre_foto ='"+nombre+"' WHERE id ="+id+"";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
            
        }

        public static void ActualizarEstadoincidenciaEtiqueta(int estado,int id,string sucursal)
        {
            string query= "UPDATE rd_etiquetas_para_corregir SET estado="+estado+" WHERE id= "+id + "";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }

        public static void EliminarIncidencia(int id)
        {
            string query = "DELETE FROM rd_etiquetas_para_corregir WHERE id ="+id+"";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();

        }
    }
}
