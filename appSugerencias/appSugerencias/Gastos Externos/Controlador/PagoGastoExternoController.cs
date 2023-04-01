using appSugerencias.Gastos_Externos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos_Externos.Controlador
{
    public class PagoGastoExternoController
    {




         public static void InsertarPagoGastoExterno(string sucursal, GastoExternoPago gep)
        {
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            string query = "INSERT INTO rd_gastos_externos_pagos(fecha,hora,importe,id_gasto_externo,nombre_gasto,concepto_gral,tipo_gasto,usuario,fecha_creacion,observacion)VALUES(?fecha,?hora,?importe,?id_gasto_externo,?nombre_gasto,?concepto_gral,?tipo_gasto,?usuario,?fecha_creacion,?observacion)";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?fecha",gep.Fecha);
            cmd.Parameters.AddWithValue("?hora", gep.Hora);
            cmd.Parameters.AddWithValue("?importe", gep.Importe/4);
            cmd.Parameters.AddWithValue("?id_gasto_externo", gep.IdGastoExterno);
            cmd.Parameters.AddWithValue("?nombre_gasto", gep.ConceptoDetalle);
            cmd.Parameters.AddWithValue("?concepto_gral", gep.ConceptoGral);
            cmd.Parameters.AddWithValue("?tipo_gasto", gep.TipoGasto);
            cmd.Parameters.AddWithValue("?usuario", gep.Usuario);
            cmd.Parameters.AddWithValue("?fecha_creacion", gep.FechaCreacion);
            cmd.Parameters.AddWithValue("?observacion", gep.Observacion);
            cmd.ExecuteNonQuery();


        }
        public static void ModificarPagoGastoExterno(GastoExternoPago gep, string sucursal)
        {
            string query = "UPDATE rd_gastos_externos_pagos SET tipo_gasto='" + gep.TipoGasto + "', concepto_gral='" + gep.ConceptoGral + "', nombre_gasto='" + gep.ConceptoDetalle + "', importe=" + gep.Importe + ", observacion='" + gep.Observacion + "'" +
                "WHERE id_gasto=" + gep.Id + "";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

        }

        public static List<GastoExternoPago> BuscarTodosPagos(string sucursal, DateTime inicio, DateTime fin)
        {
            List<GastoExternoPago> lista = new List<GastoExternoPago>();
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            string query = "SELECT * FROM rd_gastos_externos_pagos WHERE fecha between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
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
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Observacion = dr["observacion"].ToString()
                };

                lista.Add(gep);
            }
            dr.Close();


            return lista;
        }

        public static List<GastoExternoPago> BuscarPagosXTipoGasto(string sucursal,string tipo_gasto, DateTime inicio, DateTime fin)
        {
            List<GastoExternoPago> lista = new List<GastoExternoPago>();
            string query = "SELECT * FROM rd_gastos_externos_pagos WHERE tipo_gasto='"+tipo_gasto+ "' and fecha between '"+inicio.ToString("yyyy-MM-dd")+"' AND '" + fin.ToString("yyyy-MM-dd")+"'";
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
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Observacion = dr["observacion"].ToString()

                };

                lista.Add(gep);
            }
            return lista;
        }

        public static List<GastoExternoPago> BuscarPagoXConceptoGral(string sucursal, string tipo_gasto,string conceptoGral ,DateTime inicio, DateTime fin)
        {
            List<GastoExternoPago> lista = new List<GastoExternoPago>();
            string query = "SELECT * FROM rd_gastos_externos_pagos WHERE tipo_gasto='" + tipo_gasto + "' and concepto_gral='"+ conceptoGral + "' AND  fecha between '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
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
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Observacion = dr["observacion"].ToString()

                };

                lista.Add(gep);
            }
            return lista;
        }

        public static List<GastoExternoPago> BuscarPagoXConceptoDetalle(string sucursal, string tipo_gasto, string conceptoGral,string conceptoDetalle, DateTime inicio, DateTime fin)
        {
            List<GastoExternoPago> lista = new List<GastoExternoPago>();
            string query = "SELECT * FROM rd_gastos_externos_pagos WHERE tipo_gasto='" + tipo_gasto + "' AND concepto_gral='" + conceptoGral + "' AND nombre_gasto='"+ conceptoDetalle + "' AND fecha between '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
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
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Observacion = dr["observacion"].ToString()

                };

                lista.Add(gep);
            }
            return lista;
        }
    }
}

