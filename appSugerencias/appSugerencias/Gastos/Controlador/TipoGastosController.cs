using appSugerencias.Gastos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Controlador
{
   class TipoGastosController
    {


        public static string ClaveConceptoDetalle(string conceptoDetalle,string tipo)
        {
            string clave = "";
            string query = "SELECT " +
                "               concepto " +
                "           FROM conegre " +
                "           WHERE descrip ='"+conceptoDetalle+"' AND tipo_gasto='"+tipo+"'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clave = dr["concepto"].ToString();
            }
            dr.Close();
            con.Close();

            return clave;
        }
        public static void RegistrarConceptoEgreso(ConceptosEgreso egreso)
        {
           
            string query = "INSERT INTO conegre(CONCEPTO,DESCRIP,PRESUP,SALDO,USUARIO,USUFECHA,USUHORA,cuenta,CONCEPTOGRAL,TIPO_GASTO)" +
                "VALUES(?CONCEPTO,?DESCRIP,?PRESUP,?SALDO,?USUARIO,?USUFECHA,?USUHORA,?cuenta,?CONCEPTOGRAL,?TIPO_GASTO)";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?CONCEPTO",egreso.Concepto);
            cmd.Parameters.AddWithValue("?DESCRIP",egreso.Descripcion);
            cmd.Parameters.AddWithValue("?PRESUP", egreso.Presup);
            cmd.Parameters.AddWithValue("?SALDO", egreso.Saldo);
            cmd.Parameters.AddWithValue("?USUARIO", egreso.Usuario);
            cmd.Parameters.AddWithValue("?USUFECHA", egreso.Fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?USUHORA", egreso.Hora);
            cmd.Parameters.AddWithValue("?cuenta", egreso.Cuenta);
            cmd.Parameters.AddWithValue("?CONCEPTOGRAL", egreso.ConceptoGral);
            cmd.Parameters.AddWithValue("?TIPO_GASTO", egreso.TipoGasto);
            cmd.ExecuteNonQuery();
            
        }

        public static List<Egreso> ConceptosGrales(string tipo)
        {
            List<Egreso> lista = new List<Egreso>();
            string query = "SELECT DISTINCT cg.concepto,con.CONCEPTOGRAL FROM conegre con inner join rd_conceptos_grales cg on con.CONCEPTOGRAL = cg.descripcion WHERE cg.tipo_concepto = '" + tipo+"' AND con.TIPO_CONCEPTO='USO TIENDA' ORDER BY con.CONCEPTOGRAL";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Egreso egreso = new Egreso()
                {
                    ConceptoGral = dr["CONCEPTOGRAL"].ToString()
                };
                lista.Add(egreso);
            }

            return lista;
        }

        public static List<Egreso> ConceptosGralesEgresosCaja(string tipo)
        {
            List<Egreso> lista = new List<Egreso>();
            string query = "SELECT DISTINCT cg.concepto,con.CONCEPTOGRAL FROM conegre con inner join rd_conceptos_grales cg on con.CONCEPTOGRAL = cg.descripcion WHERE cg.tipo_concepto = '" + tipo + "' AND con.TIPO_CONCEPTO='USO TIENDA' ORDER BY con.CONCEPTOGRAL";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Egreso egreso = new Egreso()
                {
                    ConceptoGral = dr["CONCEPTOGRAL"].ToString()
                };
                lista.Add(egreso);
            }

            return lista;
        }



        public static List<Egreso> ConceptoDetalle(string conceptoGral,string tipoGasto)
        {

            List<Egreso> lista = new List<Egreso>();
            string query = "SELECT CONCEPTO,DESCRIP FROM conegre WHERE CONCEPTOGRAL='" + conceptoGral + "' and TIPO_GASTO='"+tipoGasto+"' and TIPO_CONCEPTO='USO TIENDA' ORDER BY DESCRIP";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Egreso egreso = new Egreso()
                {
                    Clave = dr["CONCEPTO"].ToString(),
                    ConceptoDetalle = dr["DESCRIP"].ToString()
                };
                lista.Add(egreso);
            }

            return lista;
        }

        public static List<Egreso> ConceptoDetalleFinanzas(string conceptoGral, string tipoGasto)
        {

            List<Egreso> lista = new List<Egreso>();
            string query = "SELECT CONCEPTO,DESCRIP FROM conegre WHERE CONCEPTOGRAL='" + conceptoGral + "' and TIPO_GASTO='" + tipoGasto + "' and TIPO_CONCEPTO in ('USO TIENDA','FINANZAS') ORDER BY DESCRIP";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Egreso egreso = new Egreso()
                {
                    Clave = dr["CONCEPTO"].ToString(),
                    ConceptoDetalle = dr["DESCRIP"].ToString()
                };
                lista.Add(egreso);
            }

            return lista;
        }


        public static int ConsecutivoFlujo()
        {
            int flujo = 0;
            string query = "select Consec from consec where Dato ='flujo'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                flujo = Convert.ToInt32(dr["Consec"].ToString());
                flujo++;
            }
            dr.Close();
            con.Close();
            return flujo;
        }

        public static void ActualizarConsecFlujo(int consec)
        {
            string query = "UPDATE consec SET Consec="+consec+" WHERE Dato='flujo'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }

        public static void RegistroEgreso(Egreso egreso) 
        {
            
            
               
                string query = "INSERT INTO FLUJO(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
               "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)";
                MySqlConnection con = BDConexicon.conectar();
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("?FLUJO", egreso.Flujo);
                cmd.Parameters.AddWithValue("?ABONO", egreso.Abono);
                cmd.Parameters.AddWithValue("?CONCEPTO", egreso.Clave);
                cmd.Parameters.AddWithValue("?ING_EG", egreso.IE);
                cmd.Parameters.AddWithValue("?IMPORTE", egreso.Importe);
                cmd.Parameters.AddWithValue("?FECHA", egreso.Fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?HORA", egreso.Hora);
                cmd.Parameters.AddWithValue("?MONEDA", egreso.Moneda);
                cmd.Parameters.AddWithValue("?ESTACION", egreso.Estacion);
                cmd.Parameters.AddWithValue("?USUARIO", egreso.Usuario);
                cmd.Parameters.AddWithValue("?USUFECHA", egreso.Fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?USUHORA", egreso.Hora);
                cmd.Parameters.AddWithValue("?Modulo", egreso.Modulo);
                cmd.Parameters.AddWithValue("?Venta", egreso.Venta);
                cmd.Parameters.AddWithValue("?Corte", egreso.Corte);
                cmd.Parameters.AddWithValue("?tipo_cam", egreso.Tipo_cam);
                cmd.Parameters.AddWithValue("?Cargo", egreso.Cargo);
                cmd.Parameters.AddWithValue("?concepto2", egreso.Concepto2);
                cmd.Parameters.AddWithValue("?banco", egreso.Banco);
                cmd.Parameters.AddWithValue("?cheque", egreso.Cheque);
                cmd.Parameters.AddWithValue("?verificado", egreso.Verificado);              
                cmd.ExecuteNonQuery();

                ActualizarConsecFlujo(egreso.Flujo);
            

           
        }
    }
}
