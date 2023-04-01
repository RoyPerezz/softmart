using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos.Vistas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Controlador
{
    class GastosAlmacenCedisController
    {
        public static void RegistrarGasto(GastoAlmacenCedis ac)
        {
            string query = "INSERT INTO rd_gastos_almacen_cedis(concepto_gral,concepto_detalle,descripcion_detallada,importe,fecha,folio_salida,folio_aprobacion,imagen1,nombreFoto1,imagen2,nombreFoto2,estado_revision,estado_aprobacion,comRevision,comSRA,usuario)" +
                "VALUES(?concepto_gral,?concepto_detalle,?descripcion_detallada,?importe,?fecha,?folio_salida,?folio_aprobacion,?imagen1,?nombreFoto1,?imagen2,?nombreFoto2,?estado_revision,?estado_aprobacion,?comRevision,?comSRA,?usuario)";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?concepto_gral",ac.ConceptoGral);
            cmd.Parameters.AddWithValue("?concepto_detalle", ac.ConceptoDetalle);
            cmd.Parameters.AddWithValue("?descripcion_detallada", ac.DescripcionDetallada);
            cmd.Parameters.AddWithValue("?importe", ac.Importe);
            cmd.Parameters.AddWithValue("?fecha", ac.Fecha);
            cmd.Parameters.AddWithValue("?folio_salida", ac.FolioSalida);
            cmd.Parameters.AddWithValue("?folio_aprobacion","0");
            cmd.Parameters.AddWithValue("?imagen1", ac.Imagen1);
            cmd.Parameters.AddWithValue("?nombreFoto1", ac.NombreFoto);
            cmd.Parameters.AddWithValue("?imagen2", ac.Imagen2);
            cmd.Parameters.AddWithValue("?nombreFoto2", ac.NombreFoto2);
            cmd.Parameters.AddWithValue("?estado_revision","SIN REVISAR");
            cmd.Parameters.AddWithValue("?estado_aprobacion", "EN REVISION");
            cmd.Parameters.AddWithValue("?comRevision", "");
            cmd.Parameters.AddWithValue("?comSRA", "");
            cmd.Parameters.AddWithValue("?usuario", ac.Usuario);
            cmd.ExecuteNonQuery();
        }

        public static void ModificarGasto(GastoAlmacenCedis ac)
        {
            string query = "UPDATE rd_gastos_almacen_cedis SET concepto_gral='"+ac.ConceptoGral+"', concepto_detalle='"+ac.ConceptoDetalle+"', descripcion_detallada='"+ac.DescripcionDetallada+"'," +
                "importe='"+ac.Importe+"',fecha='"+ac.Fecha.ToString("yyyy-MM-dd")+"',folio_salida='"+ac.FolioSalida+"',imagen1='"+ac.Imagen1+"',nombreFoto1='"+ac.NombreFoto+"', imagen2='"+ac.Imagen2+"',nombreFoto2='"+ac.NombreFoto2+"',estado_revision='"+ac.EstadoRevision+"' WHERE id='"+ac.Id+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }
        public static List<GastoAlmacenCedis> BuscarGastos(DateTime inicio,DateTime fin)
        {
            List<GastoAlmacenCedis> lista = new List<GastoAlmacenCedis>();

            string query = "SELECT * FROM rd_gastos_almacen_cedis WHERE fecha BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"' ORDER BY id";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoAlmacenCedis gac = new GastoAlmacenCedis()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    ConceptoGral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["concepto_detalle"].ToString(),
                    DescripcionDetallada = dr["descripcion_detallada"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    FolioAprobacion = dr["folio_aprobacion"].ToString(),
                    FolioSalida = dr["folio_salida"].ToString(),
                    Imagen1 = dr["imagen1"].ToString(),
                    NombreFoto = dr["nombreFoto1"].ToString(),
                    Imagen2 = dr["imagen2"].ToString(),
                    NombreFoto2 = dr["nombreFoto2"].ToString(),
                    EstadoRevision = dr["estado_revision"].ToString(),
                    EstadoAprobacion = dr["estado_aprobacion"].ToString(),
                    ComRevision = dr["comRevision"].ToString(),
                    ComSra = dr["comSRA"].ToString(),
                    Usuario = dr["usuario"].ToString()
                    

                };

                lista.Add(gac);
            }


            return lista;
        }

        public static List<GastoAlmacenCedis> BuscarGastos(DateTime inicio)
        {
            List<GastoAlmacenCedis> lista = new List<GastoAlmacenCedis>();

            //string query = "SELECT gac.id,con.concepto as concepto,gac.concepto_gral, sum(gac.importe) importe, fecha " +
            //    "FROM rd_gastos_almacen_cedis gac  inner join conegre con " +
            //    "on gac.concepto_gral = con.DESCRIP WHERE con.TIPO_GASTO = 'GENERAL'and gac.fecha = '" + inicio.ToString("yyyy-MM-dd") + "'  group by gac.concepto_gral";

            string query ="select id,concepto_gral,sum(importe) as importe,fecha,concepto_detalle from rd_gastos_almacen_cedis where fecha = '"+inicio.ToString("yyyy-MM-dd")+"' group by concepto_gral";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoAlmacenCedis gac = new GastoAlmacenCedis()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    //Clave = dr["concepto"].ToString(),
                    ConceptoGral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["concepto_detalle"].ToString(),
                    //DescripcionDetallada = dr["descripcion_detallada"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    //FolioAprobacion = dr["folio_aprobacion"].ToString(),
                    //FolioSalida = dr["folio_salida"].ToString(),
                    //Imagen1 = dr["imagen1"].ToString(),
                    //NombreFoto = dr["nombreFoto1"].ToString(),
                    //Imagen2 = dr["imagen2"].ToString(),
                    //NombreFoto2 = dr["nombreFoto2"].ToString(),
                    //EstadoRevision = dr["estado_revision"].ToString(),
                    //EstadoAprobacion = dr["estado_aprobacion"].ToString(),
                    //ComRevision = dr["comRevision"].ToString(),
                    //ComSra = dr["comSRA"].ToString(),
                    //Usuario = dr["usuario"].ToString()


                };

                lista.Add(gac);
            }


            return lista;
        }

        public  static List<GastoAlmacenCedis> BuscarGastoXConceptoGral(string conceptoGral,DateTime inicio,DateTime fin)
        {
            List<GastoAlmacenCedis> lista = new List<GastoAlmacenCedis>();
            string query = "SELECT * FROM rd_gastos_almacen_cedis " +
                "WHERE concepto_gral='"+conceptoGral+"' AND fecha between '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoAlmacenCedis gac = new GastoAlmacenCedis()
                {
                    FolioSalida = dr["folio_salida"].ToString(),
                    ConceptoGral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["concepto_detalle"].ToString(),
                    DescripcionDetallada = dr["descripcion_detallada"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    FolioAprobacion = dr["folio_aprobacion"].ToString()
                };

                lista.Add(gac);
            }

            return lista;
        }

        public static List<GastoAlmacenCedis> BuscarGastoXConceptoDetalle(string conceptoGral,string conceptoDetalle ,DateTime inicio, DateTime fin)
        {
            List<GastoAlmacenCedis> lista = new List<GastoAlmacenCedis>();
            string query = "SELECT * FROM rd_gastos_almacen_cedis " +
                "WHERE concepto_gral='" + conceptoGral + "' and concepto_detalle='"+conceptoDetalle+"' AND fecha between '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoAlmacenCedis gac = new GastoAlmacenCedis()
                {
                    FolioSalida = dr["folio_salida"].ToString(),
                    ConceptoGral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["concepto_detalle"].ToString(),
                    DescripcionDetallada = dr["descripcion_detallada"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    FolioAprobacion = dr["folio_aprobacion"].ToString()
                };

                lista.Add(gac);
            }

            return lista;
        }
        public static DataTable GastosPorCorregir()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FECHA",typeof(string));
            dt.Columns.Add("NUMERO", typeof(int));
            List<GastoAlmacenCedis> lista = new List<GastoAlmacenCedis>();
            string query = "SELECT fecha, count(id) as id FROM rd_gastos_almacen_cedis WHERE estado_revision='CORREGIR' group by fecha";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["fecha"].ToString(),dr["id"].ToString());
            }
            dr.Close();
            con.Close();
            return dt;
        }

        public static DataTable GastosRechazados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FECHA", typeof(string));
            dt.Columns.Add("NUMERO", typeof(int));
            List<GastoAlmacenCedis> lista = new List<GastoAlmacenCedis>();
            string query = "SELECT fecha, count(id) as id FROM rd_gastos_almacen_cedis WHERE estado_aprobacion='RECHAZADO' group by fecha";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["fecha"].ToString(), dr["id"].ToString());
            }
            dr.Close();
            con.Close();
            return dt;
        }

        public static DataTable DesgloseGastos(string conceptoGral,DateTime fecha)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CONCEPTOGRAL",typeof(string));
            dt.Columns.Add("CONCEPTODETALLE", typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("IMPORTE", typeof(double));
            string query= "SELECT concepto_gral,concepto_detalle,descripcion_detallada,importe " +
                "FROM rd_gastos_almacen_cedis WHERE concepto_gral='"+conceptoGral+"' AND fecha='"+fecha.ToString("yyyy-MM-dd")+"'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["concepto_gral"].ToString(),dr["concepto_detalle"].ToString(),dr["descripcion_detallada"].ToString(),Convert.ToDouble(dr["importe"].ToString()));
            }
            dr.Close();
            con.Close();

            return dt;
        }

       

        public static void ActualizarEstadoAprobacion(string estadoAprobacion,string numAprobacion,string comSRA ,int id)
        {
            string query = "UPDATE rd_gastos_almacen_cedis SET estado_aprobacion='"+estadoAprobacion+"', folio_aprobacion='"+numAprobacion+"',comSRA='"+comSRA+"' WHERE id="+id+"";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }

        public static void ActualizarEstadoAprobacionFinanzas(string estadoAprobacion, string numAprobacion, string comSRA, int id)
        {
            string query = "UPDATE rd_gastos_finanzas SET estado_aprobacion='" + estadoAprobacion + "', num_autorizacion='" + numAprobacion + "',comentario_aprobacion='" + comSRA + "' WHERE id=" + id + "";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
    }
}
