using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class frm_PermisosModulos : Form
    {
        public frm_PermisosModulos()
        {
            InitializeComponent();
        }

        MySqlConnection conex;
        string Usuario;

        private void frm_PermisosModulos_Load(object sender, EventArgs e)
        {
            ComboBoxRellenaOsmart.rellenaSucursal(BDConexicon.conectar(), cbTiendas);

            conex = BDConexicon.conectar();
            buscarModulos();
            limpiarPermisos();
            conex.Close();
        }
        public void limpiarPermisos()
        {
            for (int i = 0; i < dgvModulos.RowCount; i++)
            {
                dgvModulos.Rows[i].Cells[2].Value = false;
            }
        }
        public void buscarModulos()
        {

            try
            {


                

                MySqlCommand cmd = new MySqlCommand("SELECT nombreModulo,descripcion FROM rd_modulosList WHERE activo=1  ORDER BY descripcion ASC ", conex);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();



                adaptador.Fill(dt);

                dgvModulos.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvModulos.Rows.Add();

                    dgvModulos.Rows[n].Cells[0].Value = item["nombreModulo"].ToString();
                    dgvModulos.Rows[n].Cells[1].Value = item["descripcion"].ToString();
                    


                }

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

            }

        }

        public void consulta()
        {
            
           
            try
            {

               

                MySqlCommand cmd = new MySqlCommand("select * from rd_modulos where usuario =?usuario", conex);
                cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = Usuario;

                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    //SI SE REQUIERE DAR PERMISOS A CIERTO USUARIO SE TIENE QUE AUTORIZAR ACCESO AL MODULO PADRE Y POSTERIROR AL MODULO HIJO
                    //MODULOS MENU
                    
                   

                    for (int i = 0; i < dgvModulos.RowCount; i++)
                    {

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_cajas")
                        {
                            if (mdr.GetInt32("mod_cajas") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_pisoVenta")
                        {
                            if (mdr.GetInt32("mod_pisoVenta") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_bodega")
                        {
                            if (mdr.GetInt32("mod_bodega") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_compras")
                        {
                            if (mdr.GetInt32("mod_compras") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_cuentasxpagar")
                        {
                            if (mdr.GetInt32("mod_cuentasxpagar") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_contabilidad")
                        {
                            if (mdr.GetInt32("mod_contabilidad") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_finanzas")
                        {
                            if (mdr.GetInt32("mod_finanzas") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_nominas")
                        {
                            if (mdr.GetInt32("mod_nominas") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_super")
                        {
                            if (mdr.GetInt32("mod_super") == 1)
                            {

                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;

                            }


                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString()== "CapturaAsistencia")
                        {
                            if (mdr.GetInt32("CapturaAsistencia") == 1)
                            {
                               
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                                
                            }

                           
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "cajas_comisiones")
                        {
                            if (mdr.GetInt32("cajas_comisiones") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true; 
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Sugerencias")
                        {
                            if (mdr.GetInt32("Sugerencias") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true; 
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Retiros")
                        {
                            if (mdr.GetInt32("Retiros") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Etiquetas")
                        {
                            if (mdr.GetInt32("Etiquetas") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "cajas_reportes")
                        {
                            if (mdr.GetInt32("cajas_reportes") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasEnCajas")
                        {
                            if (mdr.GetInt32("VentasEnCajas") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "RepGastosxDia")
                        {
                            if (mdr.GetInt32("RepGastosxDia") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "PisoVenta_Gerente")
                        {
                            if (mdr.GetInt32("PisoVenta_Gerente") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CotizacionTraspaso")
                        {
                            if (mdr.GetInt32("CotizacionTraspaso") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "TraspasoTiendas")
                        {
                            if (mdr.GetInt32("TraspasoTiendas") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_Surtidor")
                        {
                            if (mdr.GetInt32("frm_Surtidor") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true; 
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ArticulosSinVender")
                        {
                            if (mdr.GetInt32("ArticulosSinVender") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "bodega_empleados")
                        {
                            if (mdr.GetInt32("bodega_empleados") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_Compras")
                        {
                            if (mdr.GetInt32("frm_Compras") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "GenClaves")
                        {

                            if (mdr.GetInt32("GenClaves") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Concentrador")
                        {
                            if (mdr.GetInt32("Concentrador") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false; 
                            }
                        }

                        //if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Concentrador")
                        //{
                        //    if (mdr.GetInt32("Concentrador") == 1)
                        //    {
                        //        dgvModulos.Rows[i].Cells[2].Value = true;
                        //    }
                        //    else
                        //    {
                        //        dgvModulos.Rows[i].Cells[2].Value = false;
                        //    }
                        //}

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ArticulosSinVender")
                        {
                            if (mdr.GetInt32("ArticulosSinVender") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "DevolucionesCompras")
                        {
                            if (mdr.GetInt32("DevolucionesCompras") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "PorcentajeUnidadesVend")
                        {

                            if (mdr.GetInt32("PorcentajeUnidadesVend") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_compras_prov_depto")
                        {
                            if (mdr.GetInt32("Rep_compras_prov_depto") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "StockLineaProv")
                        {
                            if (mdr.GetInt32("StockLineaProv") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "AgregarMaximos")
                        {
                            if (mdr.GetInt32("AgregarMaximos") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_pedido")
                        {
                            if (mdr.GetInt32("frm_pedido") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CuentasXPagar")
                        {
                            if (mdr.GetInt32("CuentasXPagar") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasTarjeta")
                        {
                            if (mdr.GetInt32("VentasTarjeta") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_GastosExternos")
                        {
                            if (mdr.GetInt32("frm_GastosExternos") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ctasxpagar_pagos_progra")
                        {
                            if (mdr.GetInt32("ctasxpagar_pagos_progra") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_saldos_prov")
                        {
                            if (mdr.GetInt32("Rep_saldos_prov") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_OrdenesCompras")
                        {
                            if (mdr.GetInt32("Rep_OrdenesCompras") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_cuentas_osmart")
                        {
                            if (mdr.GetInt32("Rep_cuentas_osmart") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CuentasBancarias")
                        {
                            if (mdr.GetInt32("CuentasBancarias") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ProveedorServicios")
                        {
                            if (mdr.GetInt32("ProveedorServicios") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CuentasBancariasOS")
                        {
                            if (mdr.GetInt32("CuentasBancariasOS") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "EfectivoDisponible")
                        {
                            if (mdr.GetInt32("EfectivoDisponible") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasXLinea")
                        {
                            if (mdr.GetInt32("VentasXLinea") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_pagoproveedores_Finanzas")
                        {
                            if (mdr.GetInt32("Rep_pagoproveedores_Finanzas") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_ventasxhora")
                        {
                            if (mdr.GetInt32("frm_ventasxhora") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "supervision_comisiones")
                        {
                            if (mdr.GetInt32("supervision_comisiones") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true; 
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "IntercambioMercancia")
                        {
                            if (mdr.GetInt32("IntercambioMercancia") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasXTienda2")
                        {
                            if (mdr.GetInt32("VentasXTienda2") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ExProductosProveedor")
                        {
                            if (mdr.GetInt32("ExProductosProveedor") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_ventasxhora")
                        {
                            if (mdr.GetInt32("frm_ventasxhora") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Pagos_efe_enc_cajas")
                        {
                            if (mdr.GetInt32("Pagos_efe_enc_cajas") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasLineaProv")
                        {
                            if (mdr.GetInt32("VentasLineaProv") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "UnidadesVendidasProveedor")
                        {
                            if (mdr.GetInt32("UnidadesVendidasProveedor") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_pedido_almacen")
                        {
                            if (mdr.GetInt32("frm_pedido_almacen") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "form_existXlinea")
                        {
                            if (mdr.GetInt32("form_existXlinea") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_costos")
                        {
                            if (mdr.GetInt32("frm_costos") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_CreaGastosExterno")
                        {
                            if (mdr.GetInt32("frm_CreaGastosExterno") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CorteZ")
                        {
                            if (mdr.GetInt32("CorteZ") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "BuscarCortez")
                        {
                            if (mdr.GetInt32("BuscarCortez") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_pagoproveedores")
                        {
                            if (mdr.GetInt32("Rep_pagoproveedores") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }

                        

                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "RetirarEfectivoTiendas")
                        {
                            if (mdr.GetInt32("RetirarEfectivoTiendas") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }


                        if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "PagosEnCaja")
                        {
                            if (mdr.GetInt32("PagosEnCaja") == 1)
                            {
                                dgvModulos.Rows[i].Cells[2].Value = true;
                            }
                            else
                            {
                                dgvModulos.Rows[i].Cells[2].Value = false;
                            }
                        }


                    }
                    

                    

                    

                   



                }
               

                mdr.Close();
                
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta();

           
        }

        public int convierte(string valor)
        {
            bool check = Convert.ToBoolean(valor);

            if (check)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public void guardarPermisos()
        {
            try
            {
                MySqlCommand cmdR = new MySqlCommand("update rd_modulos set mod_cajas=?mod_cajas,mod_pisoVenta=?mod_pisoVenta,mod_bodega=?mod_bodega,mod_compras=?mod_compras,mod_cuentasxpagar=?mod_cuentasxpagar,mod_contabilidad=?mod_contabilidad,mod_finanzas=?mod_finanzas,mod_nominas=?mod_nominas,mod_super=?mod_super," +
                                                     "cajas_comisiones=?cajas_comisiones,Sugerencias=?sugerencias,Retiros=?retiros,Etiquetas=?etiquetas,cajas_reportes=?cajas_reportes,VentasEnCajas=?ventas_cajas,RepGastosxDia=?repgastosxdia," +
                                                     "bodega_empleados=?bodega_empleados, CotizacionTraspaso=?CotizacionTraspaso,frm_Surtidor=?frm_Surtidor,TraspasoTiendas=?TraspasoTiendas, PorcentajeUnidadesVend=?PorcentajeUnidadesVend," +
                                                     "ArticulosSinVender=?ArticulosSinVender, PorcentajeUnidadesVend=?PorcentajeUnidadesVend, VentasLineaProv=?VentasLineaProv,UnidadesVendidasProveedor=?UnidadesVendidasProveedor,AgregarMaximos=?AgregarMaximos,frm_Compras=?frm_Compras,Concentrador=?Concentrador,DevolucionesCompras=?DevolucionesCompras,ExProductosProveedor=?ExProductosProveedor,GenClaves=?GenClaves,frm_pedido=?frm_pedido, frm_pedido_almacen=?frm_pedido_almacen,PorcentajeUnidadesVend=?PorcentajeUnidadesVend,Rep_compras_prov_depto=?Rep_compras_prov_depto,StockLineaProv=?StockLineaProv," +
                                                     "VentasTarjeta=?VentasTarjeta, CuentasBancarias=?CuentasBancarias,CuentasBancariasOS=?CuentasBancariasOS,CuentasXPagar=?CuentasXPagar,frm_GastosExternos=?frm_GastosExternos,Rep_OrdenesCompras=?Rep_OrdenesCompras,ctasxpagar_pagos_progra=?ctasxpagar_pagos_progra,ProveedorServicios=?ProveedorServicios,Rep_saldos_prov=?Rep_saldos_prov, Rep_cuentas_osmart=?Rep_cuentas_osmart," +
                                                     "EfectivoDisponible=?EfectivoDisponible, Rep_pagoproveedores_Finanzas=?Rep_pagoproveedores_Finanzas, VentasXLinea=?VentasXLinea, form_existXlinea=?form_existXlinea, VentasXTienda2=?VentasXTienda2,frm_costos=?frm_costos, frm_CreaGastosExterno=?frm_CreaGastosExterno,CorteZ=?CorteZ, BuscarCortez=?BuscarCortez, Rep_pagoproveedores=?Rep_pagoproveedores,RetirarEfectivoTiendas=?RetirarEfectivoTiendas,CapturaAsistencia=?CapturaAsistencia,PisoVenta_Gerente=?PisoVenta_Gerente, IntercambioMercancia=?IntercambioMercancia, supervision_comisiones=?supervision_comisiones, frm_ventasxhora=?frm_ventasxhora, " +
                                                     "Pagos_efe_enc_cajas=?Pagos_efe_enc_cajas,PagosEnCaja=?PagosEnCaja  where usuario= '"+Usuario+"'", conex);

                for (int i = 0; i < dgvModulos.RowCount; i++)
                {

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_cajas")
                    {

                        cmdR.Parameters.Add("?mod_cajas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }
                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_pisoVenta")
                    {

                        cmdR.Parameters.Add("?mod_pisoVenta", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }
                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_bodega")
                    {

                        cmdR.Parameters.Add("?mod_bodega", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }
                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_compras")
                    {

                        cmdR.Parameters.Add("?mod_compras", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }
                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_cuentasxpagar")
                    {

                        cmdR.Parameters.Add("?mod_cuentasxpagar", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_contabilidad")
                    {

                        cmdR.Parameters.Add("?mod_contabilidad", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_finanzas")
                    {

                        cmdR.Parameters.Add("?mod_finanzas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_nominas")
                    {

                        cmdR.Parameters.Add("?mod_nominas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "mod_super")
                    {

                        cmdR.Parameters.Add("?mod_super", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "cajas_comisiones")
                    {

                        cmdR.Parameters.Add("?cajas_comisiones", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }
                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Sugerencias")
                    {

                        cmdR.Parameters.Add("?sugerencias", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }
                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Retiros")
                    {

                        cmdR.Parameters.Add("?retiros", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Etiquetas")
                    {

                        cmdR.Parameters.Add("?etiquetas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "cajas_reportes")
                    {

                        cmdR.Parameters.Add("?cajas_reportes", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasEnCajas")
                    {

                        cmdR.Parameters.Add("?ventas_cajas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "RepGastosxDia")
                    {

                        cmdR.Parameters.Add("?repgastosxdia", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "bodega_empleados")
                    {

                        cmdR.Parameters.Add("?bodega_empleados", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CotizacionTraspaso")
                    {

                        cmdR.Parameters.Add("?CotizacionTraspaso", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_Surtidor")
                    {

                        cmdR.Parameters.Add("?frm_Surtidor", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "TraspasoTiendas")
                    {

                        cmdR.Parameters.Add("?TraspasoTiendas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ArticulosSinVender")
                    {

                        cmdR.Parameters.Add("?ArticulosSinVender", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "PorcentajeUnidadesVend")
                    {

                        cmdR.Parameters.Add("?PorcentajeUnidadesVend", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasLineaProv")
                    {

                        cmdR.Parameters.Add("?VentasLineaProv", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "UnidadesVendidasProveedor")
                    {

                        cmdR.Parameters.Add("?UnidadesVendidasProveedor", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "AgregarMaximos")
                    {

                        cmdR.Parameters.Add("?AgregarMaximos", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_Compras")
                    {

                        cmdR.Parameters.Add("?frm_Compras", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Concentrador")
                    {

                        cmdR.Parameters.Add("?Concentrador", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "DevolucionesCompras")
                    {

                        cmdR.Parameters.Add("?DevolucionesCompras", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ExProductosProveedor")
                    {

                        cmdR.Parameters.Add("?ExProductosProveedor", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "GenClaves")
                    {

                        cmdR.Parameters.Add("?GenClaves", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_pedido")
                    {

                        cmdR.Parameters.Add("?frm_pedido", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_pedido_almacen")
                    {

                        cmdR.Parameters.Add("?frm_pedido_almacen", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    //if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "PorcentajeUnidadesVend")
                    //{

                    //    cmdR.Parameters.Add("?PorcentajeUnidadesVend", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    //}

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_compras_prov_depto")
                    {

                        cmdR.Parameters.Add("?Rep_compras_prov_depto", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "StockLineaProv")
                    {

                        cmdR.Parameters.Add("?StockLineaProv", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasTarjeta")
                    {

                        cmdR.Parameters.Add("?VentasTarjeta", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CuentasBancarias")
                    {

                        cmdR.Parameters.Add("?CuentasBancarias", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CuentasBancariasOS")
                    {

                        cmdR.Parameters.Add("?CuentasBancariasOS", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CuentasXPagar")
                    {

                        cmdR.Parameters.Add("?CuentasXPagar", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_GastosExternos")
                    {

                        cmdR.Parameters.Add("?frm_GastosExternos", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_OrdenesCompras")
                    {

                        cmdR.Parameters.Add("?Rep_OrdenesCompras", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ctasxpagar_pagos_progra")
                    {

                        cmdR.Parameters.Add("?ctasxpagar_pagos_progra", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "ProveedorServicios")
                    {

                        cmdR.Parameters.Add("?ProveedorServicios", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_saldos_prov")
                    {

                        cmdR.Parameters.Add("?Rep_saldos_prov", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_cuentas_osmart")
                    {

                        cmdR.Parameters.Add("?Rep_cuentas_osmart", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "EfectivoDisponible")
                    {

                        cmdR.Parameters.Add("?EfectivoDisponible", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_pagoproveedores_Finanzas")
                    {

                        cmdR.Parameters.Add("?Rep_pagoproveedores_Finanzas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasXLinea")
                    {

                        cmdR.Parameters.Add("?VentasXLinea", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }



                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "form_existXlinea")
                    {

                        cmdR.Parameters.Add("?form_existXlinea", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "VentasXTienda2")
                    {

                        cmdR.Parameters.Add("?VentasXTienda2", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_costos")
                    {

                        cmdR.Parameters.Add("?frm_costos", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_CreaGastosExterno")
                    {

                        cmdR.Parameters.Add("?frm_CreaGastosExterno", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CorteZ")
                    {

                        cmdR.Parameters.Add("?CorteZ", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "BuscarCortez")
                    {

                        cmdR.Parameters.Add("?BuscarCortez", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Rep_pagoproveedores")
                    {

                        cmdR.Parameters.Add("?Rep_pagoproveedores", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "RetirarEfectivoTiendas")
                    {

                        cmdR.Parameters.Add("?RetirarEfectivoTiendas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "CapturaAsistencia")
                    {

                        cmdR.Parameters.Add("?CapturaAsistencia", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "PisoVenta_Gerente")
                    {

                        cmdR.Parameters.Add("?PisoVenta_Gerente", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());


                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "IntercambioMercancia")
                    {

                        cmdR.Parameters.Add("?IntercambioMercancia", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "supervision_comisiones")
                    {

                        cmdR.Parameters.Add("?supervision_comisiones", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "frm_ventasxhora")
                    {

                        cmdR.Parameters.Add("?frm_ventasxhora", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }

                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "Pagos_efe_enc_cajas")
                    {

                        cmdR.Parameters.Add("?Pagos_efe_enc_cajas", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }
                    if (dgvModulos.Rows[i].Cells[0].Value.ToString() == "PagosEnCaja")
                    {

                        cmdR.Parameters.Add("?PagosEnCaja", MySqlDbType.VarChar).Value = convierte(dgvModulos.Rows[i].Cells[2].Value.ToString());

                    }


                }

                cmdR.ExecuteNonQuery();
            }catch(Exception er)
            {
                MessageBox.Show("Error: "+ er.Message);
            }
        }

        public void guardar()
        {

            int opcion = 0;
            MySqlCommand cmd = new MySqlCommand("SELECT usuario FROM rd_modulos WHERE usuario=?usuario", conex);
            cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = Usuario;
            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();

            if (mdr.Read())
            {
                //update
                opcion = 1;

            }
            else
            {
                //insert
                opcion = 2;
            }

            mdr.Close();

            if (opcion == 1)
            {

                guardarPermisos();


            }
            else if (opcion == 2)
            {
                MySqlCommand cmdR = new MySqlCommand("INSERT INTO rd_modulos (usuario, mod_cajas, mod_pisoVenta, mod_bodega, mod_compras, mod_cuentasxpagar, mod_contabilidad, mod_finanzas, mod_nominas, mod_super, mod_gerencia, Existencias, CapturaAsistencia, CotizacionTraspaso, TraspasoTiendas, frm_pedido_almacen, frm_Surtidor, frm_GastosExternos, bodega_empleados, frm_Compras, GenClaves, Concentrador, Sugerencias, form_existXlinea, ArticulosSinVender, DevolucionesCompras, PorcentajeUnidadesVend, Rep_compras_prov_depto, VentasLineaProv, UnidadesVendidasProveedor, StockLineaProv, AgregarMaximos, cajas_comisiones, ExProductosProveedor, Retiros, Etiquetas, Rep_pagoproveedores, RepGastosxDia, cajas_reportes, VentasEnCajas, PagosEnCaja, PisoVenta_Gerente, frm_pedido, CuentasXPagar, Rep_saldos_prov, VentasTarjeta, Rep_cuentas_osmart, ctasxpagar_pagos_progra, Rep_OrdenesCompras, Rep_pagoproveedores_Finanzas, EfectivoDisponible, VentasXLinea, VentasXTienda2, frm_costos, frm_CreaGastosExterno, RetirarEfectivoTiendas, CuentasBancarias, ProveedorServicios, Pagos_efe_enc_cajas, CorteZ, BuscarCortez, frm_ventasxhora, supervision_comisiones, IntercambioMercancia, CuentasBancariasOS, VentasLineaCosto, UVendidasProveedor, FechaLlegadaMerc) VALUES (?usuario, '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0')", conex);
                cmdR.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = Usuario;
                cmdR.ExecuteNonQuery();
                guardarPermisos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conex = BDConexicon.BodegaOpen();
                guardar();
                conex.Close();
                lblCEDIS.Text = "OK";
                lblCEDIS.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er){
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa

                lblCEDIS.Text = "NA";
                lblCEDIS.ForeColor = Color.Red;
            }

            try
            {
                conex = BDConexicon.VallartaOpen();
                guardar();
                conex.Close();
                lblVA.Text = "OK";
                lblVA.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

                lblVA.Text = "NA";
                lblVA.ForeColor = Color.Red;
            }

            try
            {
                conex = BDConexicon.RenaOpen();
                guardar();
                conex.Close();
                lblRE.Text = "OK";
                lblRE.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

                lblRE.Text = "NA";
                lblRE.ForeColor = Color.Red;
            }

            try
            {
                conex = BDConexicon.ColosoOpen();
                guardar();
                conex.Close();
                lblCO.Text = "OK";
                lblCO.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

                lblCO.Text = "NA";
                lblCO.ForeColor = Color.Red;
            }

            try
            {
                conex = BDConexicon.VelazquezOpen();
                guardar();
                conex.Close();
                lblVL.Text = "OK";
                lblVL.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

                lblVL.Text = "NA";
                lblVL.ForeColor = Color.Red;
            }


        }

        //public void consultaUsuario()
        //{
            

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
           
        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBALL.Checked)
            {
                for (int i = 0; i < dgvModulos.RowCount; i++)
                {
                    dgvModulos.Rows[i].Cells[2].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvModulos.RowCount; i++)
                {
                    dgvModulos.Rows[i].Cells[2].Value = false;
                }
            }
        }

        public void selectDatos()
        {
            try
            {




                MySqlCommand cmd = new MySqlCommand("SELECT USUARIO,NOMBRE,AREA FROM usuarios ORDER BY USUARIO ASC  ", conex);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();



                adaptador.Fill(dt);

                dgvEmpleados.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvEmpleados.Rows.Add();

                    dgvEmpleados.Rows[n].Cells[0].Value = item["USUARIO"].ToString();
                    dgvEmpleados.Rows[n].Cells[1].Value = item["NOMBRE"].ToString();
                    dgvEmpleados.Rows[n].Cells[2].Value = item["AREA"].ToString();



                }

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

            }
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (cbTiendas.SelectedValue.ToString() == "CEDIS")
            {
                try
                {
                    conex=BDConexicon.BodegaOpen();
                    selectDatos();
                    conex.Close();
                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                   
                }

            }
            else if (cbTiendas.SelectedValue.ToString() == "VA")
            {
                try
                {
                    conex=BDConexicon.VallartaOpen();
                    selectDatos();
                    conex.Close();
                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                   
                }

            }
            else if (cbTiendas.SelectedValue.ToString() == "RE")
            {
                try
                {
                   conex= BDConexicon.RenaOpen();
                    selectDatos();
                    conex.Close();
                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                   
                }


            }
            else if (cbTiendas.SelectedValue.ToString() == "CO")
            {

                try
                {
                    conex=BDConexicon.ColosoOpen();
                    selectDatos();
                    conex.Close();
                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                    
                }

            }
            else if (cbTiendas.SelectedValue.ToString() == "VL")
            {

                try
                {
                    conex=BDConexicon.VelazquezOpen();
                    selectDatos();
                    conex.Close();
                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                  
                }

            }

            

        }

        public void limpiarSucursales()
        {
            lblCEDIS.Text = "---";
            lblVA.Text = "---";
            lblRE.Text = "---";
            lblCO.Text = "---";
            lblVL.Text = "---";

        }
             
        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiarPermisos();
            Usuario = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblUsuario.Text = Usuario;
            limpiarSucursales();
            conex= BDConexicon.conectar();
            consulta();
            conex.Close();
        }
    }
}
