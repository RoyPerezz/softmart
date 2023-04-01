using appSugerencias.Reporte_Auditoria;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ReporteAuditoria : Form
    {
        MySqlConnection conexion = null;
        string sucursales = "";
        public ReporteAuditoria()
        {
           
            InitializeComponent();
            conexion = BDConexicon.BodegaOpen();
            string consulta = "SELECT modulo FROM rd_lista_modulos_softmart ORDER BY modulo";
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_modulo.Items.Add(dr["modulo"].ToString());
            }
            dr.Close();
        }

        public DataTable Datos()
        {

            DataTable dt = new DataTable();
            string modulo = CB_modulo.SelectedItem.ToString();
            string columnas = "";
            string consulta = "";
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlDataReader dr = null;
            MySqlCommand cmd = null;

            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursales.SelectedItem.ToString());
            if (modulo.Equals("ABONOS"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_abonos FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_abonos WHERE fecha_abono BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                 cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["usuario"].ToString(), dr["fecha_abono"].ToString(), dr["hora"].ToString(),
                        dr["fecha_efectivo"].ToString(), dr["dinero_va"].ToString(), dr["dinero_re"].ToString(), dr["dinero_ve"].ToString(), dr["dinero_co"].ToString(),dr["abono"].ToString(),
                        dr["fk_proveedor"].ToString(), dr["banco_prov"].ToString(), dr["num_cuenta_prov"].ToString(), dr["cliente_bancario"].ToString(), dr["tipo_pago"].ToString(), dr["sucursal_compra"].ToString(),
                        dr["sucursal_cuenta_osmart"].ToString(), dr["banco_osmart"].ToString(), dr["cuenta_osmart"].ToString(), dr["cliente_bancario_osmart"].ToString(), dr["num_compra"].ToString(), dr["referencia"].ToString());

                }
                dr.Close();


            }


            if (modulo.Equals("AJUSTES CUENTAS OSMART"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_abonos FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_ajustes_cuentas_osmart WHERE fecha_mov BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["fecha_mov"].ToString(), dr["fecha_registro"].ToString(), dr["hora"].ToString(), dr["ip"].ToString(), dr["nombre_equipo"].ToString(),
                      dr["sucursal_cuenta"].ToString(), dr["banco_osmart"].ToString());

                }
                dr.Close();


            }

            if (modulo.Equals("CAMBIAR CONCEPTO DE EGRESO"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_cambio_concepto_egreso FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_cambio_concepto_egreso WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(),dr["caja"].ToString(),
                    dr["fecha_egreso"].ToString(), dr["concepto"].ToString(), dr["descripcion"].ToString(), dr["importe"].ToString(), dr["concepto_cambio"].ToString(), dr["descripcion_cambio"].ToString());

                }
                dr.Close();


            }


            if (modulo.Equals("CAMBIO CLAVE ARTICULOS"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_cambio_claves_dev FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_cambio_claves_dev WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(),dr["hora"].ToString(), dr["clave_inicial"].ToString(),
                     dr["clave_inicial"].ToString(), dr["cambio_clave"].ToString(), dr["descripcion"].ToString(), dr["fk_compra"].ToString());

                }
                dr.Close();


            }

            if (modulo.Equals("CANTIDAD A FACTURAR"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_cantidad_facturacion FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_cantidad_facturacion WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(), dr["fecha_venta"].ToString(),
                    dr["deposito_ventanilla"].ToString(), dr["sucursal"].ToString());

                }
                dr.Close();


            }

            // este modulo contiene info en dos tablas
            if (modulo.Equals("COTIZACION TRASPASO"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_cotizacion_traspaso FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_cotizacion_traspaso WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add("",dr["folio"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(),
                        dr["tienda_origen"].ToString(), dr["tienda_destino"].ToString(), dr["motivo"].ToString());

                }
                dr.Close();


            }

            if (modulo.Equals("DEPOSITOS DE PROVEEDOR A PROVEEDOR"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_depositar_de_proveedor_a_proveedor FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_depositar_de_proveedor_a_proveedor WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(),
                        dr["proveedor_deposita"].ToString(), dr["proveedor_recibe"].ToString(), dr["tipo_pago"].ToString(), dr["importe"].ToString(), dr["referencia"].ToString(), dr["fecha_deposito"].ToString());

                }
                dr.Close();


            }

            // este modulo contiene info en dos tablas
            if (modulo.Equals("DEVOLUCION DE COMPRA"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_devolucion_compra FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_devolucion_compra WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(),
                        dr["sucursal_compra"].ToString(), dr["fk_proveedor"].ToString(), dr["compra"].ToString(), dr["factura"].ToString(), dr["importe_compra"].ToString(), dr["dev_parcial"].ToString(), dr["dev_total"].ToString(),
                        dr["importe_devolucion"].ToString(), dr["observacion"].ToString());

                }
                dr.Close();


            }

            if (modulo.Equals("MODIFICAR TIPO DE VENTA"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_modificar_tipo_venta FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_modificar_tipo_venta WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(),
                        dr["cajera"].ToString(), dr["no_venta"].ToString(), dr["ticket"].ToString(), dr["importe"].ToString(), dr["tipo_venta_original"].ToString(), dr["tipo_venta_cambio"].ToString(), dr["fecha_venta"].ToString(),
                        dr["hora_venta"].ToString());

                }
                dr.Close();


            }


            if (modulo.Equals("PAGO EN EFECTIVO ENC DE CAJAS"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_pagos_efectivo_enc_cajas FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_pagos_efectivo_enc_cajas WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(),
                        dr["beneficiario"].ToString(), dr["importe"].ToString(), dr["referencia"].ToString(), dr["fecha_transferencia"].ToString());

                }
                dr.Close();


            }
            

            if (modulo.Equals("REGISTRO DE ACCESO"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_acceso_modulos FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_acceso_modulos WHERE FECHA BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"'";

                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(), dr["ip"].ToString(), dr["nombre_equipo"].ToString(), dr["modulo"].ToString());

                }
                dr.Close();
            }

            if (modulo.Equals("REGISTRO DE CUENTAS BANCARIAS OSMART"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_cuentas_bancarias_osmart FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_cuentas_bancarias_osmart WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(),
                        dr["banco"].ToString(), dr["cuenta"].ToString(), dr["cliente_bancario"].ToString(), dr["sucursal"].ToString());

                }
                dr.Close();


            }

            if (modulo.Equals("REGISTRO DE CUENTAS DE PROVEEDORES"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_cuentas_bancarias_prov FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_cuentas_bancarias_prov WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(),
                        dr["fk_proveedor"].ToString(), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["cliente_bancario"].ToString());

                }
                dr.Close();


            }

            if (modulo.Equals("RETIRO DE EFECTIVO DE LAS TIENDAS"))
            {
                columnas = "SHOW COLUMNS FROM rd_log_retiro_efectivo_a_cuentas_osmart FROM MyBusinessDelta";
                consulta = "SELECT * FROM rd_log_retiro_efectivo_a_cuentas_osmart WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
                cmd = new MySqlCommand(columnas, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Columns.Add(dr["Field"].ToString(), typeof(string));

                }
                dr.Close();

                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["id"].ToString(), dr["usuario"].ToString(), dr["nombre_equipo"].ToString(), dr["ip"].ToString(), dr["fecha"].ToString(), dr["hora"].ToString(),
                        dr["retiro_va"].ToString(), dr["retiro_re"].ToString(), dr["retiro_ve"].ToString(),dr["retiro_co"].ToString(), dr["sucursal_cuenta"].ToString(), dr["banco"].ToString(),
                        dr["cuenta"].ToString(), dr["cliente_bancario"].ToString(), dr["importe"].ToString(), dr["referencia"].ToString(), dr["saldo"].ToString(), dr["fecha_retiro"].ToString());

                }
                dr.Close();


            }

            DG_tabla.DataSource = dt;
            DG_tabla.Columns[0].Visible = false;

            return dt;
            
        }

        private void BT_reporte_Click(object sender, EventArgs e)
        {
          Datos();
            
        }

        private void CB_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string consulta = "select sucursal from rd_lista_modulos_softmart where modulo ='"+CB_modulo.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(consulta,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sucursales = dr["sucursal"].ToString();
            }
            if (sucursales.Equals("CEDIS"))
            {
                CB_sucursales.Items.Clear();
                CB_sucursales.Items.Add("CEDIS");
            }
            if (sucursales.Equals("TIENDAS"))
            {
                CB_sucursales.Items.Clear();

                CB_sucursales.Items.Add("VALLARTA");
                CB_sucursales.Items.Add("RENA");
                CB_sucursales.Items.Add("VELAZQUEZ");
                CB_sucursales.Items.Add("COLOSO");
            }
            if (sucursales.Equals("TIENDAS Y CEDIS"))
            {
                CB_sucursales.Items.Clear();

                CB_sucursales.Items.Add("CEDIS");
                CB_sucursales.Items.Add("VALLARTA");
                CB_sucursales.Items.Add("RENA");
                CB_sucursales.Items.Add("VELAZQUEZ");
                CB_sucursales.Items.Add("COLOSO");
            }
            dr.Close();
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CB_modulo.SelectedItem.ToString().Equals("COTIZACION TRASPASO"))
            {
                string modulo = CB_modulo.SelectedItem.ToString();
                string sucursal = CB_sucursales.SelectedItem.ToString();
                string folio = DG_tabla.Rows[e.RowIndex].Cells["folio"].Value.ToString();
                string usuario = DG_tabla.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                string nombre_equipo = DG_tabla.Rows[e.RowIndex].Cells["nombre_equipo"].Value.ToString();
                string ip = DG_tabla.Rows[e.RowIndex].Cells["ip"].Value.ToString();
                string fecha = DG_tabla.Rows[e.RowIndex].Cells["fecha"].Value.ToString();
                string hora = DG_tabla.Rows[e.RowIndex].Cells["hora"].Value.ToString();
                string origen = DG_tabla.Rows[e.RowIndex].Cells["tienda_origen"].Value.ToString();
                string destino = DG_tabla.Rows[e.RowIndex].Cells["tienda_destino"].Value.ToString();
                string motivo = DG_tabla.Rows[e.RowIndex].Cells["motivo"].Value.ToString();

                Rep_aux_auditoria auxiliar = new Rep_aux_auditoria();
                auxiliar.ArticulosCotizacion(modulo,sucursal,folio,usuario,nombre_equipo,ip, fecha, hora,origen, destino,motivo);
                auxiliar.Show();
            }

            if (CB_modulo.SelectedItem.ToString().Equals("DEVOLUCION DE COMPRA"))
            {
                string modulo = CB_modulo.SelectedItem.ToString();
                string sucursal = CB_sucursales.SelectedItem.ToString();
                //string folio = DG_tabla.Rows[e.RowIndex].Cells["folio"].Value.ToString();
                string usuario = DG_tabla.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                string nombre_equipo = DG_tabla.Rows[e.RowIndex].Cells["nombre_equipo"].Value.ToString();
                string ip = DG_tabla.Rows[e.RowIndex].Cells["ip"].Value.ToString();
                string fecha = DG_tabla.Rows[e.RowIndex].Cells["fecha"].Value.ToString();
                string hora = DG_tabla.Rows[e.RowIndex].Cells["hora"].Value.ToString();
                string sucursal_compra = DG_tabla.Rows[e.RowIndex].Cells["sucursal_compra"].Value.ToString();
                string fk_proveedor = DG_tabla.Rows[e.RowIndex].Cells["fk_proveedor"].Value.ToString();
                string compra = DG_tabla.Rows[e.RowIndex].Cells["compra"].Value.ToString();
                string factura = DG_tabla.Rows[e.RowIndex].Cells["factura"].Value.ToString();
                string importe_compra = DG_tabla.Rows[e.RowIndex].Cells["importe_compra"].Value.ToString();
                string dev_parcial = DG_tabla.Rows[e.RowIndex].Cells["dev_parcial"].Value.ToString();
                string dev_total = DG_tabla.Rows[e.RowIndex].Cells["dev_total"].Value.ToString();
                string importe_devolucion = DG_tabla.Rows[e.RowIndex].Cells["importe_devolucion"].Value.ToString();
                string observacion = DG_tabla.Rows[e.RowIndex].Cells["observacion"].Value.ToString();




                Rep_aux_auditoria auxiliar = new Rep_aux_auditoria();
                auxiliar.ArticulosDevolucionCompra(modulo,sucursal,usuario,nombre_equipo,ip,fecha,hora,sucursal_compra,fk_proveedor,compra,factura,importe_compra,dev_parcial,dev_total,importe_devolucion,observacion);
                auxiliar.Show();
            }
        }

        private void ReporteAuditoria_Load(object sender, EventArgs e)
        {

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);




            int indiceColumna = 0;



            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;

                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_tabla.Columns)
                {
                    indiceColumna++;



                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }


            //excel.Cells.Range["B6:M36"].NumberFormat = "$#,##0.00";


            excel.Visible = true;
        }
    }
}
