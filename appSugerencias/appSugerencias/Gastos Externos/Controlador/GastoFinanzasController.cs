using appSugerencias.Gastos_Externos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos_Externos.Controlador
{
    class GastoFinanzasController
    {


        public static void ActualizarEstado(int estado,int id)
        {
            string query = "UPDATE rd_gastos_finanzas SET revisado="+estado+" WHERE id="+id+"";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();

        }
        public static List<GastoExterno> BuscarGastoFinanzasXConceptoDetalle(string conceptoGral,string conceptoDetalle, DateTime inicio, DateTime fin)
        {
            List<GastoExterno> lista = new List<GastoExterno>();
            string query = "select * from rd_gastos_finanzas where concepto_gral='" + conceptoGral + "'and concepto_detalle='"+ conceptoDetalle + "' and fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoExterno ge = new GastoExterno()
                {
                    Folio = dr["folio"].ToString(),
                    Tipo_gasto_ex = "GENERAL",
                    Concepto_gral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["concepto_detalle"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    NumAutorizacion = dr["num_autorizacion"].ToString()
                };

                lista.Add(ge);
            }
            return lista;
        }
        public static List<GastoExterno> BuscarGastoFinanzasXConceptoGral(string conceptoGral, DateTime inicio, DateTime fin)
        {
            List<GastoExterno> lista = new List<GastoExterno>();
            string query = "select * from rd_gastos_finanzas where concepto_gral='"+conceptoGral+"' and fecha between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoExterno ge = new GastoExterno()
                {
                    Folio = dr["folio"].ToString(),
                    Tipo_gasto_ex = "GENERAL",
                    Concepto_gral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["concepto_detalle"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    NumAutorizacion = dr["num_autorizacion"].ToString()
                };

                lista.Add(ge);
            }
            return lista;
        }

        public static DataTable DesgloseGastosFinanzas(string conceptoGral, DateTime fecha)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CONCEPTOGRAL", typeof(string));
            dt.Columns.Add("CONCEPTODETALLE", typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("IMPORTE", typeof(double));
            string query = "SELECT concepto_gral,concepto_detalle,descripcion,importe " +
                "FROM rd_gastos_finanzas WHERE concepto_gral='" + conceptoGral + "' AND fecha='" + fecha.ToString("yyyy-MM-dd") + "' ";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["concepto_gral"].ToString(), dr["concepto_detalle"].ToString(), dr["descripcion"].ToString(), Convert.ToDouble(dr["importe"].ToString()));
            }
            dr.Close();
            con.Close();

            return dt;
        }

        public static void ModificarPersonaQueGeneraGastos(string nombre,int id)
        {
            string query = "UPDATE rd_persona_gasto_externo SET nombre ='"+nombre+"' WHERE id ="+id+"";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }

        public static void EliminarPersonaQueGeneraGastos( int id)
        {
            string query = "DELETE FROM rd_persona_gasto_externo WHERE id =" + id + "";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        public static void RegistrarPersonaQueGeneranGastos(string nombre)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "INSERT INTO rd_persona_gasto_externo(nombre) VALUES(?nombre)";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?nombre",nombre);
            cmd.ExecuteNonQuery();
        }

        public static DataTable BuscarNombreExactoGeneraGasto(string nombre)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("NOMBRE", typeof(string));
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "select * from rd_persona_gasto_externo WHERE nombre ='" + nombre + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["id"].ToString(), dr["nombre"].ToString());
            }

            dr.Close();

            con.Close();

            return dt;
        }
        public static DataTable BuscarPersonaGeneraGasto(string nombre)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID",typeof(string));
            dt.Columns.Add("NOMBRE", typeof(string));
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "select * from rd_persona_gasto_externo WHERE nombre like '%"+nombre+"%'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["id"].ToString(),dr["nombre"].ToString());
            }

            dr.Close();

            con.Close();

            return dt;
        }
        public static void GuardarGasto(GastoExterno ge)
        {
            string query = "INSERT INTO rd_gastos_finanzas(fecha,importe,folio,persona,concepto_gral,concepto_detalle,descripcion,foto1,nombre1,foto2,nombre2,estado_aprobacion,comentario_aprobacion,num_autorizacion,revisado)VALUES(?fecha,?importe,?folio,?persona,?concepto_gral,?concepto_detalle,?descripcion,?foto1,?nombre1,?foto2,?nombre2,?estado_aprobacion,?comentario_aprobacion,?num_autorizacion,?revisado)";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?fecha",ge.Fecha);
            cmd.Parameters.AddWithValue("?importe", ge.Importe);
            cmd.Parameters.AddWithValue("?folio", ge.Folio);
            cmd.Parameters.AddWithValue("?persona", ge.PersonaGeneraGasto);
            cmd.Parameters.AddWithValue("?concepto_gral", ge.Concepto_gral);
            cmd.Parameters.AddWithValue("?concepto_detalle", ge.ConceptoDetalle);
            cmd.Parameters.AddWithValue("?descripcion", ge.Descripcion);
            cmd.Parameters.AddWithValue("?foto1", ge.Foto1);
            cmd.Parameters.AddWithValue("?nombre1", ge.NombreFoto1);
            cmd.Parameters.AddWithValue("?foto2", ge.Foto2);
            cmd.Parameters.AddWithValue("?nombre2", ge.NombreFoto2);
            cmd.Parameters.AddWithValue("?estado_aprobacion","EN REVISION");
            cmd.Parameters.AddWithValue("?comentario_aprobacion", "");
            cmd.Parameters.AddWithValue("?num_autorizacion", "0");
            cmd.Parameters.AddWithValue("?revisado", 0);
            cmd.ExecuteNonQuery();

        }

        public static void ModificarGasto(GastoExterno ge)
        {
            string query = "UPDATE rd_gastos_finanzas SET fecha='" + ge.Fecha.ToString("yyyy-MM-dd") + "', importe="+ge.Importe+",folio='"+ge.Folio+"', persona='"+ge.PersonaGeneraGasto+"'," +
                " concepto_gral='"+ge.Concepto_gral+"',concepto_detalle ='"+ge.ConceptoDetalle+"' ,descripcion='"+ge.Descripcion+"', foto1='"+ge.Foto1+"', nombre1='"+ge.NombreFoto1+"',foto2='"+ge.Foto2+"', nombre2='"+ge.NombreFoto2+"',estado_aprobacion='"+ge.EstadoAprobacion+"' WHERE id="+ge.Id+"";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }

        public static void EliminarGasto(int id)
        {
            string query = "DELETE FROM rd_gastos_finanzas WHERE id ="+id+"";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public static List<GastoExterno> BuscarGastos(DateTime inicio,DateTime fin)
        {
            List<GastoExterno> lista = new List<GastoExterno>();
            string query = "SELECT concepto_gral, sum(importe) as importe,concepto_detalle FROM rd_gastos_finanzas WHERE fecha BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+ "' group by concepto_gral";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoExterno ge = new GastoExterno()
                {
                    //Id = Convert.ToInt32(dr["id"].ToString()),
                    //Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    //Folio = dr["folio"].ToString(),
                    //PersonaGeneraGasto = dr["persona"].ToString(),
                    Concepto_gral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["concepto_detalle"].ToString(),
                    //Descripcion = dr["descripcion"].ToString(),
                    //Foto1 = dr["foto1"].ToString(),
                    //NombreFoto1 = dr["nombre1"].ToString(),
                    //NombreFoto2 = dr["nombre2"].ToString(),
                    //Foto2 = dr["foto2"].ToString(),
                    //EstadoAprobacion = dr["estado_aprobacion"].ToString(),
                    //ComentarioAprobacion = dr["comentario_aprobacion"].ToString(),
                    //NumAutorizacion = dr["num_autorizacion"].ToString()

                };

                lista.Add(ge);
            }

            return lista;
        }

        public static List<GastoExterno> ListaGastos(DateTime inicio, DateTime fin)
        {
            List<GastoExterno> lista = new List<GastoExterno>();
            string query = "SELECT *  FROM rd_gastos_finanzas WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "' order by fecha";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoExterno ge = new GastoExterno()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Folio = dr["folio"].ToString(),
                    PersonaGeneraGasto = dr["persona"].ToString(),
                    Concepto_gral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["concepto_detalle"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Foto1 = dr["foto1"].ToString(),
                    NombreFoto1 = dr["nombre1"].ToString(),
                    NombreFoto2 = dr["nombre2"].ToString(),
                    Foto2 = dr["foto2"].ToString(),
                    EstadoAprobacion = dr["estado_aprobacion"].ToString(),
                    ComentarioAprobacion = dr["comentario_aprobacion"].ToString(),
                    NumAutorizacion = dr["num_autorizacion"].ToString(),
                    Revisado = Convert.ToInt32(dr["revisado"].ToString())

                };

                lista.Add(ge);
            }

            return lista;
        }
    }
}
