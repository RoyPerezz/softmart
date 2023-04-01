using appSugerencias.Gastos_Externos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos_Externos.Controlador
{
    class GastoExternoController
    {

        public static void CrearGastoExterno(GastoExterno ge )
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmdR = new MySqlCommand("INSERT INTO  rd_gastos_externos (nombre_gasto,concepto_gral,tipo_gasto_ex) VALUES (?nombre_gasto,?concepto_gral,?tipo_gasto_ex)", con);

            cmdR.Parameters.AddWithValue("?nombre_gasto", ge.Nombre_Gasto);
            cmdR.Parameters.AddWithValue("?concepto_gral", ge.Concepto_gral);
            cmdR.Parameters.AddWithValue("?tipo_gasto_ex", ge.Tipo_gasto_ex);
            cmdR.ExecuteNonQuery();
            con.Close();
        }
        public static void ModificarGastoExterno(GastoExterno ge)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "UPDATE rd_gastos_externos SET nombre_gasto='"+ge.Nombre_Gasto+"',concepto_gral='"+ge.Concepto_gral+"',tipo_gasto_ex='"+ge.Tipo_gasto_ex+"' WHERE id_gasto="+ge.Id+"";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }

        public static void EliminarGastoExterno(int id)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "DELETE FROM rd_gastos_externos WHERE id_gasto=" +id + "";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public static List<GastoExterno> ConceptosDetalle(string conceptogral, string tipo_gasto)
        {
            List<GastoExterno> lista = new List<GastoExterno>();
            string query = "SELECT * FROM rd_gastos_externos WHERE concepto_gral='" + conceptogral + "' AND tipo_gasto_ex='" + tipo_gasto + "'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoExterno ge = new GastoExterno()
                {
                    Nombre_Gasto = dr["nombre_gasto"].ToString()
                };

                lista.Add(ge);
            }
            dr.Close();

            return lista;
        }

        public static int ObtenerIDGastoExterno(string conceptoDetalle,string conceptoGral,string tipo_gasto)
        {
            int id = 0;

            string query = "SELECT id_gasto FROM rd_gastos_externos WHERE nombre_gasto='"+conceptoDetalle+ "' and concepto_gral='"+conceptoGral+"' and tipo_gasto_ex='"+tipo_gasto+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt32(dr["id_gasto"].ToString());
            }
            dr.Close();
            return id;
        }

        public static List<GastoExternoPago> BuscarGastoExterno(string sucursal,string tipo_gasto,string concepto_gral,string concepto_detalle,DateTime fecha)
        {
            List<GastoExternoPago> lista = new List<GastoExternoPago>();
            string query = "SELECT id_gasto,tipo_gasto,concepto_gral,nombre_gasto,importe,observacion,usuario" +
                "           FROM rd_gastos_externos_pagos " +
                "           WHERE tipo_gasto='"+tipo_gasto+"' AND concepto_gral='"+concepto_gral+"' AND nombre_gasto='"+ concepto_detalle+"' AND fecha='"+fecha.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GastoExternoPago gep = new GastoExternoPago()
                {
                    Id = Convert.ToInt32(dr["id_gasto"].ToString()),
                    TipoGasto = dr["tipo_gasto"].ToString(),
                    ConceptoGral = dr["concepto_gral"].ToString(),
                    ConceptoDetalle = dr["nombre_gasto"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Observacion = dr["observacion"].ToString(),
                    Usuario = dr["usuario"].ToString()

                };
                lista.Add(gep);
            }

            return lista;
        }

        

    }
}
