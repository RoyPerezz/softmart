using appSugerencias.Cuentas_Bancarias.Modelo;
using appSugerencias.Gastos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Cuentas_Bancarias.Controlador
{
    class CuentasController
    {


        public static void RegistrarIngresoEgreso(CuentaBancariaOsmart cbo,string sucursal)
        {
            string query = "INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ref_gastoexterno,suc_pago,fk_flujo)VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ref_gastoexterno,?suc_pago,?fk_flujo)";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?tienda",cbo.SucursalCuenta);
            cmd.Parameters.AddWithValue("?mov",cbo.Mov);
            cmd.Parameters.AddWithValue("?ie", cbo.IE);
            cmd.Parameters.AddWithValue("?banco",cbo.Banco);
            cmd.Parameters.AddWithValue("?cuenta",cbo.Cuenta);
            cmd.Parameters.AddWithValue("?pagara",cbo.ClienteBancario);
            cmd.Parameters.AddWithValue("?cantidad",cbo.Importe/4);
            cmd.Parameters.AddWithValue("?fecha",cbo.Fecha);
            cmd.Parameters.AddWithValue("?hora",cbo.Hora);
            cmd.Parameters.AddWithValue("?fk_gastoexterno","0");
            cmd.Parameters.AddWithValue("?ref_gastoexterno",cbo.Ref_GastoExterno);
            cmd.Parameters.AddWithValue("?suc_pago", sucursal);
            cmd.Parameters.AddWithValue("?fk_flujo", cbo.FK_flujo);
            cmd.ExecuteNonQuery();

        }
        public List<CuentaBancariaOsmart> CuentaBancaria(int flujo)
        {
            List<CuentaBancariaOsmart> lista = new List<CuentaBancariaOsmart>();
            string query = "SELECT * FROM rd_historial_saldobancos WHERE fk_flujo='" + flujo+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CuentaBancariaOsmart cuenta = new CuentaBancariaOsmart()
                {
                    SucursalCuenta = dr["tienda"].ToString(),
                    Banco = dr["banco"].ToString(),
                    Cuenta = dr["cuenta"].ToString(),
                    ClienteBancario = dr["pagara"].ToString(),
                    Importe = Convert.ToDouble(dr["cantidad"].ToString()),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Suc_pago = dr["suc_pago"].ToString()
                };

                lista.Add(cuenta);
            }


            return lista;
        }

        public DataTable DesgloseDepositoCuentaOsmart(string concepto,string sucursal, DateTime fecha, bool check)
        {
            DataTable dt = new DataTable();

            MySqlConnection con = null;
            List<CuentaBancariaOsmart> listaCuenta = new List<CuentaBancariaOsmart>();
            List<Gasto> listaGasto = new List<Gasto>();
            dt.Columns.Add("SUCURSAL DE LA CUENTA", typeof(string));
            dt.Columns.Add("BANCO", typeof(string));
            dt.Columns.Add("CUENTA", typeof(string));
            dt.Columns.Add("CLIENTE BANCARIO", typeof(string));
            dt.Columns.Add("IMPORTE", typeof(double));
            dt.Columns.Add("FECHA", typeof(string));
            dt.Columns.Add("SUCURSAL DE PAGO", typeof(string));
            dt.Columns.Add("FLUJO", typeof(string));

            if (check == true)
            {
                int m = fecha.Month;
                int año = fecha.Year;

                string mes = FormatoFecha.Mes(m);

                con = BDConexicon.RespMultiSuc(sucursal, mes, año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }
            string query = "select flujo,concepto,importe,fecha " +
                "from flujo " +
                "where concepto ='" + concepto + "' and fecha = '" + fecha.ToString("yyyy-MM-dd") + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Id = Convert.ToInt32(dr["flujo"].ToString()),
                    Concepto = dr["concepto"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Importe = Convert.ToDouble(dr["importe"].ToString())

                };

                listaGasto.Add(gasto);
            }
            dr.Close();

            for (int i = 0; i < listaGasto.Count; i++)
            {
                dt.Rows.Add("", "", "", "", listaGasto[i].Importe, listaGasto[i].Fecha.ToString("yyyy-MM-dd"), "", listaGasto[i].Id);
            }


            int flujo = 0;
            int fk_flujo = 0;
            
            MySqlCommand cmd2 = null;
            MySqlDataReader dr2 = null;
            MySqlConnection conBo = BDConexicon.BodegaOpen();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                flujo = Convert.ToInt32(dt.Rows[i]["FLUJO"].ToString());
                cmd2 = new MySqlCommand("SELECT * FROM rd_historial_saldobancos WHERE fk_flujo =" + flujo + "", conBo);
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    fk_flujo = Convert.ToInt32(dr2["fk_flujo"].ToString());
                    if (flujo == fk_flujo)
                    {
                        dt.Rows[i]["SUCURSAL DE LA CUENTA"] = dr2["tienda"].ToString();
                        dt.Rows[i]["BANCO"] = dr2["banco"].ToString();
                        dt.Rows[i]["CUENTA"] = dr2["cuenta"].ToString();
                        dt.Rows[i]["CLIENTE BANCARIO"] = dr2["pagara"].ToString();
                        dt.Rows[i]["SUCURSAL DE PAGO"] = dr2["suc_pago"].ToString();

                    }
                }
                dr2.Close();
            }




            return dt;
        }

        public DataTable DesglosePagoAProveedores(string sucursal,DateTime fecha,bool check)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PROVEEDOR",typeof(string));
            dt.Columns.Add("BANCO", typeof(string));
            dt.Columns.Add("CUENTA", typeof(string));
            dt.Columns.Add("MONTO", typeof(double));
            dt.Columns.Add("FECHA DEPOSITO", typeof(string));
            dt.Columns.Add("FECHA EFECTIVO", typeof(string));
            dt.Columns.Add("NUM COMPRA", typeof(string));

            MySqlConnection con = null;
            if (check == true)
            {
                int m = fecha.Month;
                int año = fecha.Year;

                string mes = FormatoFecha.Mes(m);

                con = BDConexicon.RespMultiSuc(sucursal, mes, año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            DateTime fecha_dep, fecha_efe;
            double monto = 0;

            string query = "SELECT nombreprov,banco,cuenta,monto,fecha,fecha_efe,compra FROM rd_rep_pagoproveedores WHERE fecha_efe='"+fecha.ToString("yyyy-MM-dd")+"' AND   (compra <> null  or compra <> ' ')";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                fecha_dep = Convert.ToDateTime(dr["fecha"].ToString());
                fecha_efe = Convert.ToDateTime(dr["fecha_efe"].ToString());
                monto = Convert.ToDouble(dr["monto"].ToString());
                dt.Rows.Add(dr["nombreprov"].ToString(), dr["banco"].ToString(), dr["cuenta"].ToString(),monto ,fecha_dep.ToString("yyyy-MM-dd"), fecha_efe.ToString("yyyy-MM-dd"), dr["compra"].ToString());
            }
            dr.Close();
            return dt;
        }
    }
  
}
