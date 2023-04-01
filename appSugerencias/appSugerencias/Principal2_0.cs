using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using appSugerencias.Cajas.Cajeras.Vista;
using appSugerencias.Cajas.Enc_Cajas.Vista;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos.Vistas;
using appSugerencias.Gastos_Externos.Modelo;
using appSugerencias.Gastos_Externos.Vistas;
using appSugerencias.GastosCedis.Vistas;
using appSugerencias.Piso_de_venta.Vista;
using appSugerencias.ReportesCCTV;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class Principal2_0 : Form
    {

        string Usuario = "";
        string Area;
        string Estacion;
        


        public Principal2_0()
        {
            InitializeComponent();
        }


        public Principal2_0(string usuario, string area)
        {
           
            InitializeComponent();
            Usuario = usuario;
            Area = area;
            Estacion = BDConexicon.optieneEstacion();
            lblEstacion.Text = Estacion;
            lblUsuario.Text = Usuario;
            
        }
        

        public  void RegistrarAccesos(string modulo)
        {
            string query = "INSERT INTO rd_log_acceso_modulos(usuario,fecha,hora,ip,nombre_equipo,modulo)VALUES(?usuario,?fecha,?hora,?ip,?nombre_equipo,?modulo)";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            DateTime fecha = DateTime.Now;
            string nombre_equipo = Environment.MachineName;

            IPHostEntry host;
            string ip = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in host.AddressList)
            {
                if (IP.AddressFamily.ToString() == "InterNetwork")
                {
                    ip = IP.ToString();
                }
            }

            cmd.Parameters.AddWithValue("?usuario",Usuario);
            cmd.Parameters.AddWithValue("?fecha",fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:dd"));
            cmd.Parameters.AddWithValue("?ip",ip);
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?modulo", modulo);
            cmd.ExecuteNonQuery();
        }
        

        private void Principal2_0_Load(object sender, EventArgs e)
        {
            string IP = BDConexicon.optieneIp();
            string BD = BDConexicon.optieneBd();
#pragma warning disable CS0168 // La variable 'area' se ha declarado pero nunca se usa
            string area;
#pragma warning restore CS0168 // La variable 'area' se ha declarado pero nunca se usa

            lblBD.Text = BD;
            lblIP.Text = IP;

            if(Area=="SISTEMAS")
            {
                sistemasToolStripMenuItem.Enabled = true;
            }
            else
            {
                sistemasToolStripMenuItem.Enabled = false;
            }


            try
            {

                MySqlConnection con = BDConexicon.conectar();

                MySqlCommand cmd = new MySqlCommand("select * from rd_modulos where usuario =?usuario", con);
                cmd.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = Usuario;

                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();
                if (mdr.Read())
                {
                    //SI SE REQUIERE DAR PERMISOS A CIERTO USUARIO SE TIENE QUE AUTORIZAR ACCESO AL MODULO PADRE Y POSTERIROR AL MODULO HIJO
                    //MODULOS MENU

                    if (mdr.GetInt32("mod_gastos")==1)
                    {
                        gastosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        gastosToolStripMenuItem.Enabled = false;
                    }
                    if (mdr.GetInt32("mod_cajas") == 1)
                    {
                        cajasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cajasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_pisoVenta") == 1)
                    {
                        pisoVentaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        pisoVentaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_bodega") == 1)
                    {
                        bodegaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        bodegaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_compras") == 1)
                    {
                        comprasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        comprasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_cuentasxpagar") == 1)
                    {
                        cuentasPPagarToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cuentasPPagarToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_contabilidad") == 1)
                    {
                        contabilidadToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        contabilidadToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_finanzas") == 1)
                    {
                        finanzasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        finanzasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_nominas") == 1)
                    {
                        nominaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        nominaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_super") == 1)
                    {
                        supervicionToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        supervicionToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_gerencia") == 1)
                    {
                        gerenciaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        gerenciaToolStripMenuItem.Enabled = false;
                    }


                    //SUB-MENUS
                    if (mdr.GetInt32("Existencias") == 1)
                    {
                        existenciasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        existenciasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("CapturaAsistencia") == 1)
                    {
                        capturaAsistenciaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        capturaAsistenciaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("cajas_comisiones") == 1)
                    {
                        comisionesToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        comisionesToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("Sugerencias") == 1)
                    {
                        sugerenciasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        sugerenciasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("Retiros") == 1)
                    {
                        cobroTarjetaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cobroTarjetaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("Etiquetas") == 1)
                    {
                        etiquetasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        etiquetasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("cajas_reportes") == 1)
                    {
                        reportesToolStripMenuItem1.Enabled = true;
                    }
                    else
                    {
                        reportesToolStripMenuItem1.Enabled = false;
                    }

                    if (mdr.GetInt32("VentasEnCajas") == 1)
                    {
                        ventasEnCajaToolStripMenuItem.Enabled = true;
                        ventasEnCajaToolStripMenuItem1.Enabled = true;
                    }
                    else
                    {
                        ventasEnCajaToolStripMenuItem.Enabled = false;
                        ventasEnCajaToolStripMenuItem1.Enabled = false;
                    }

                    if (mdr.GetInt32("RepGastosxDia") == 1)
                    {
                        gastosPDíaToolStripMenuItem1.Enabled = true;
                    }
                    else
                    {
                        gastosPDíaToolStripMenuItem1.Enabled = false;
                    }

                    if (mdr.GetInt32("PisoVenta_Gerente") == 1)
                    {
                        pisoVentaGerente_toolStripmenu.Enabled = true;
                    }
                    else
                    {
                        pisoVentaGerente_toolStripmenu.Enabled = false;
                    }

                    if (mdr.GetInt32("CotizacionTraspaso") == 1)
                    {
                        crearTraspasoToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        crearTraspasoToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("TraspasoTiendas") == 1)
                    {
                        aplicarTraspasoToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        aplicarTraspasoToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_Surtidor") == 1)
                    {
                        cEDISToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cEDISToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("ArticulosSinVender") == 1)
                    {
                        artSinMovimientoToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        artSinMovimientoToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("bodega_empleados") == 1)
                    {
                        calificarEmpleadosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        calificarEmpleadosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_Compras") == 1)
                    {
                        cargarCompraToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cargarCompraToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("GenClaves") == 1)
                    {
                        generadorDeClavesToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        generadorDeClavesToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("Concentrador") == 1)
                    {
                        toolStripMenuItem1.Enabled = true;
                    }
                    else
                    {
                        toolStripMenuItem1.Enabled = false;
                    }

                    if (mdr.GetInt32("ArticulosSinVender") == 1)
                    {
                        artSinVenderToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        artSinVenderToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("DevolucionesCompras") == 1)
                    {
                        devolucionesToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        devolucionesToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("PorcentajeUnidadesVend") == 1)
                    {
                        porcentajeDeUnidadesVendidasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        porcentajeDeUnidadesVendidasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("Rep_compras_prov_depto") == 1)
                    {
                        totalDeCompaPorProveedorToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        totalDeCompaPorProveedorToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("StockLineaProv") == 1)
                    {
                        stockDeLineasPorProveedorToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        stockDeLineasPorProveedorToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("AgregarMaximos") == 1)
                    {
                        maximosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        maximosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_pedido") == 1)
                    {
                        pedidosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        pedidosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("CuentasXPagar") == 1)
                    {
                        estadoDeCuentaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        estadoDeCuentaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("VentasTarjeta") == 1)
                    {
                        
                        ventasConTarjetaToolStripMenuItem.Enabled = true;
                        reporteVouchersToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        ventasConTarjetaToolStripMenuItem.Enabled = false;
                        reporteVouchersToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_GastosExternos") == 1)
                    {
                        gastosExternosToolStripMenuItem.Enabled = true;
                        gastosExternosToolStripMenuItem1.Enabled = true;
                    }
                    else
                    {
                        gastosExternosToolStripMenuItem.Enabled = false;
                        gastosExternosToolStripMenuItem1.Enabled = false;
                    }

                    if (mdr.GetInt32("ctasxpagar_pagos_progra") == 1)
                    {
                        pagosProgramadosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        pagosProgramadosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("Rep_saldos_prov") == 1)
                    {
                        reporteGeneralToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        reporteGeneralToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("Rep_OrdenesCompras") == 1)
                    {
                        ordenesDeCompraToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        ordenesDeCompraToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("Rep_cuentas_osmart") == 1)
                    {
                        CP_estado_cuenta.Enabled = true;
                        eco_finanzas.Enabled = true;
                    }
                    else
                    {
                        CP_estado_cuenta.Enabled = false;
                        eco_finanzas.Enabled = false;
                    }

                    if (mdr.GetInt32("CuentasBancarias") == 1)
                    {
                        cuentasBancariasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cuentasBancariasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("ProveedorServicios") == 1)
                    {
                        proveedoresDeServiciosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        proveedoresDeServiciosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("CuentasBancariasOS") == 1)
                    {
                        cuentasBancariasOsmartToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cuentasBancariasOsmartToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("EfectivoDisponible") == 1)
                    {
                        efectivoDis_finanzas.Enabled = true;
                    }
                    else
                    {
                        efectivoDis_finanzas.Enabled = false;
                    }

                    if (mdr.GetInt32("VentasXLinea") == 1)
                    {
                        ventasxLinea_Finanzas.Enabled = true;
                    }
                    else
                    {
                        ventasxLinea_Finanzas.Enabled = false;
                    }

                    if (mdr.GetInt32("Rep_pagoproveedores_Finanzas") == 1)
                    {
                        repPagoProveedoresToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        repPagoProveedoresToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_ventasxhora") == 1)
                    {
                        ventasxHora_Supervicion.Enabled = true;
                    }
                    else
                    {
                        ventasxHora_Supervicion.Enabled = false;
                    }

                    if (mdr.GetInt32("supervision_comisiones") == 1)
                    {
                        comisionesToolStripMenuItem1.Enabled = true;
                    }
                    else
                    {
                        comisionesToolStripMenuItem1.Enabled = false;
                    }

                    if (mdr.GetInt32("IntercambioMercancia") == 1)
                    {
                        intercambioDeMercanciaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        intercambioDeMercanciaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("VentasXTienda2") == 1)
                    {
                        ventasPTiendaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        ventasPTiendaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("ExProductosProveedor") == 1)
                    {
                        existenciaPProveedorToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        existenciaPProveedorToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("VentasLineaCosto") ==1)
                    {
                        ventasPorLineaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        ventasPorLineaToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("UVendidasProveedor") ==1)
                    {
                        uVendidasPorProveedorToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        uVendidasPorProveedorToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("FechaLlegadaMerc") == 1)
                    {
                        fechaDeLlegadaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        fechaDeLlegadaToolStripMenuItem.Enabled = false;
                    }
                    if (mdr.GetInt32("ValorDeInventario")==1)
                    {
                        valorDelInventarioToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        valorDelInventarioToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_costos")==1)
                    {
                        estadoDeResultadosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        estadoDeResultadosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_CreaGastosExterno")==1)
                    {
                        crearConceptoToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        crearConceptoToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_GastosExternos") == 1)
                    {
                        registrarConceptoExternoToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        registrarConceptoExternoToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("RetirarEfectivoTiendas")==1)
                    {
                        despositoACuentasOsmartToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        despositoACuentasOsmartToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("frm_ventasxhora")==1)
                    {
                        transaccionesPTiempoToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        transaccionesPTiempoToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("ModificarDatosCompra") == 1)
                    {
                        modificarDatosDeCompraToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        modificarDatosDeCompraToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("mod_monitoreo") == 1)
                    {
                        monitoreoToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        monitoreoToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("capturarIndicenciaCCTV") ==1)
                    {
                        capturarIncidenciasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        capturarIncidenciasToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("reporteCCTV") == 1)
                    {
                        crearReporteToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        crearReporteToolStripMenuItem.Enabled = false;
                    }
                    if (mdr.GetInt32("CrearStockCompra")==1)
                    {
                        crearStockToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        crearStockToolStripMenuItem.Enabled = false;
                    }
                    if (mdr.GetInt32("BuscarStockCompra")==1)
                    {
                        buscarStockToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        buscarStockToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("ReporteTraspasos")==1)
                    {
                        reporteTraspasoToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        reporteTraspasoToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("DepurarKarex") ==1)
                    {
                        depurarKardexToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        depurarKardexToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("RegistroProveedores")==1)
                    {
                        registrarProveedoresToolStripMenuItem.Enabled=true;
                    }
                    else
                    {
                        registrarProveedoresToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("CantidadFacturar") == 1)
                    {
                        cantidadAFacturarToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cantidadAFacturarToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("ReporteBauchers") ==1)
                    {
                        reporteTikectsTarjetasToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        reporteTikectsTarjetasToolStripMenuItem.Enabled = false;

                    }

                    if (mdr.GetInt32("ReporteCorteZ")==1)
                    {
                        reporteCorteZToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        reporteCorteZToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("CargarGastos")==1)
                    {
                        cargarGastosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        cargarGastosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("RevisionGastos") == 1)
                    {
                        revisionGastosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        revisionGastosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("ResumenGastos")==1)
                    {
                        resumenDeGastosToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        resumenDeGastosToolStripMenuItem.Enabled = false;
                    }

                    if (mdr.GetInt32("retirosDeCaja")==1)
                    {
                        retiroDeCajaToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        retiroDeCajaToolStripMenuItem.Enabled = false;
                    }

                }
                else
                {
                    cajasToolStripMenuItem.Enabled = false;
                    pisoVentaToolStripMenuItem.Enabled = false;
                    bodegaToolStripMenuItem.Enabled = false;
                    comprasToolStripMenuItem.Enabled = false;
                    cuentasPPagarToolStripMenuItem.Enabled = false;
                    contabilidadToolStripMenuItem.Enabled = false;
                    finanzasToolStripMenuItem.Enabled = false;
                    nominaToolStripMenuItem.Enabled = false;
                    supervicionToolStripMenuItem.Enabled = false;
                    gerenciaToolStripMenuItem.Enabled = false;
                    micelaniaToolStripMenuItem.Enabled = false;
                    monitoreoToolStripMenuItem.Enabled = false;


                }

                mdr.Close();
                con.Close();
            }catch(Exception er)
            {
                MessageBox.Show("Error en Permisos: "+ er.Message);

                cajasToolStripMenuItem.Enabled = false;
                pisoVentaToolStripMenuItem.Enabled = false;
                bodegaToolStripMenuItem.Enabled = false;
                comprasToolStripMenuItem.Enabled = false;
                cuentasPPagarToolStripMenuItem.Enabled = false;
                contabilidadToolStripMenuItem.Enabled = false;
                finanzasToolStripMenuItem.Enabled = false;
                nominaToolStripMenuItem.Enabled = false;
                supervicionToolStripMenuItem.Enabled = false;
                gerenciaToolStripMenuItem.Enabled = false;
                micelaniaToolStripMenuItem.Enabled = false;
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Principal2_0_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }


        //EVENTOS CLICK MENU
        #region


        #region GASTOS
        private void resumenDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ResumenGastos);

            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            frm = new ResumenGastos(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU MICELANIA
        #region
        //EXISTENCIAS
        private void existenciaPProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Existencias);
           
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            frm = new Existencias(Usuario, Area);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        //CAPTURA ASISTENCIA
        private void capturaAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_CapturaAsistencia);

            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            frm = new frm_CapturaAsistencia();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void existenciaPProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExProductosProveedor);

            if (frm3 != null)
            {
                //si la instancia existe la pongo en primer plano
                frm3.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm3 = new ExProductosProveedor();
            string modulo = frm3.Name;
            RegistrarAccesos(modulo);
            frm3.Show();
        }

        private void existenciaPLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_existXlinea);
           
            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new form_existXlinea();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void multiKardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_KardexMulti);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_KardexMulti();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU CAJAS
        #region
        private void retiroDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RegistroEgresos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RegistroEgresos(lblUsuario.Text, lblEstacion.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void cargarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GastosEncCajasView);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva

            //frm = new GastosEncCajasView();
            //frm.Show();
            GastosEncCajasView fac = new GastosEncCajasView(lblUsuario.Text);
            string modulo = fac.Name;
            RegistrarAccesos(modulo);
            fac.Show();
        }


        private void cantidadAFacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CantidadFacturar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva

            //frm = new Sugerencias();
            //frm.Show();
            CantidadFacturar fac = new CantidadFacturar(lblUsuario.Text);
            string modulo =fac.Name;
            RegistrarAccesos(modulo);
            fac.Show();
        }

        //SUGERENCIAS
        private void sugerenciasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Sugerencias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva

            //frm = new Sugerencias();
            //frm.Show();
            Sugerencias sug = new Sugerencias();
            sug.LB_cajera.Text = lblUsuario.Text;
            string modulo = sug.Name;
            RegistrarAccesos(modulo);
            sug.Show();
        }
       

        //COBRO TARJETA
        private void cobroTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Retiros);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            //frm = new Rep_CajaGral();
            //frm.Show();

            Retiros r = new Retiros(lblUsuario.Text, lblEstacion.Text);
            string modulo = r.Name;
            RegistrarAccesos(modulo);
            r.Show();
        }

        //ETIQUETAS
        private void etiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    //se localiza el formulario buscandolo entre los forms abiertos 
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Etiquetas);

            //if (frm != null)
            //{
            //    //si la instancia existe la pongo en primer plano
            //    frm.BringToFront();
            //    return;
            //}

            //Etiquetas et = new Etiquetas();
            //et.LB_cajera.Text = lblUsuario.Text;
            //string modulo = et.Name;
            //RegistrarAccesos(modulo);
            //et.Show();
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RegistroIncidenciaEtiqueta);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            frm = new RegistroIncidenciaEtiqueta(lblUsuario.Text, lblEstacion.Text);
            frm.Show();
        }

        //SUGERENCIAS
        private void sugerenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteSug);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteSug();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }


        private void etiquetasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepEtiquetas);

            //if (frm != null)
            //{
            //    //si la instancia existe la pongo en primer plano
            //    frm.BringToFront();
            //    return;
            //}

            ////sino existe la instancia se crea una nueva
            //frm = new RepEtiquetas();
            //string modulo = frm.Name;
            //RegistrarAccesos(modulo);
            //frm.Show();
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ListadoIncidenciasEtiquetas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ListadoIncidenciasEtiquetas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        //PAGO PROVEEDORES
        private void pagoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagoproveedores);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
               
                return;
            }

            //sino existe la instancia se crea una nueva
            //frm = new Rep_pagoproveedores();
            //frm.Show();
            Rep_pagoproveedores rep = new Rep_pagoproveedores(lblUsuario.Text);
            string modulo = rep.Name;
            RegistrarAccesos(modulo);
            rep.Show();
        }

        private void ventasEnCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasEnCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasEnCajas(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void gastosPDíaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepGastosxDia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepGastosxDia(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Calificacionescs);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Calificacionescs();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calculoComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PagoComisiones);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new PagoComisiones();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificarDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesVerificadores);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesVerificadores();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteComVerif);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteComVerif();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificarDíaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarHosstess);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarHosstess();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reportePaqueteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_comisionesPaq);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_comisionesPaq();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void pagosEnCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PagosEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new PagosEncCajas(lblUsuario.Text,lblIP.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU GERENTE
        #region
        private void altaBajaAsesoraVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is registroAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new registroAsesoras();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void comisionesDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesAsesoras();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void totalComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TotalComisionesAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new TotalComisionesAsesoras(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU BODEGA
        #region
        private void crearTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CotizacionTraspaso);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CotizacionTraspaso(Usuario);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();

        }

        private void aplicarTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TraspasoTiendas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new TraspasoTiendas(Usuario);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteTraspasos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteTraspasos();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void cEDISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_Surtidor);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_Surtidor(Usuario);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void artSinMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ArticulosSinVender);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ArticulosSinVender();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AltaEmpBodega);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new AltaEmpBodega();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalifBodega);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalifBodega();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calculoDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesBod);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesBod();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void eliminarCalificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EliminarCalifBod);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EliminarCalifBod();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void programarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Programar_Pago);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Programar_Pago(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteDePagosProgramadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagosprogramados);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagosprogramados(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void modificarEliminarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Modificar_pago);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Modificar_pago();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU COMPRAS
        #region

        private void registrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CrearProveedor);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
               
            }

            //sino existe la instancia se crea una nueva
            frm = new CrearProveedor();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void depurarKardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is DepurarKardex);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new DepurarKardex();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is KardexArticulos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new KardexArticulos();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void cargarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_Compras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_Compras(Usuario);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void generadorDeClavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GenClaves);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new GenClaves();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Concentrador);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Concentrador();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void artSinVenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ArticulosSinVender);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ArticulosSinVender();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is DevolucionesCompras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new DevolucionesCompras(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void porcentajeDeUnidadesVendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PorcentajeUnidadesVend);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new PorcentajeUnidadesVend();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void totalDeCompaPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_compras_prov_depto);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_compras_prov_depto();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void stockDeLineasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is StockLineaProv);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new StockLineaProv();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void maximosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AgregarMaximos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new AgregarMaximos();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_pedido);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_pedido(Usuario, Area);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }


        private void ventasPorLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasLineaProv);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasLineaProv();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void uVendidasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is UnidadesVendidasProveedor);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new UnidadesVendidasProveedor();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void modificarDatosDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ModificarCompra);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ModificarCompra();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void crearStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is StockOrdenCompra);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new StockOrdenCompra(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void buscarStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is OrdenStockCompra);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new OrdenStockCompra();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU CUENTAS X PAGAR
        #region

        private void crearConceptoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_CreaGastosExterno);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_CreaGastosExterno();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void generarPagoExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_GastosExternos(Usuario);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void reporteIncongruenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Incongruencias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Incongruencias();

            frm.Show();
        }
        private void reporteDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteGastos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteGastos();
         
            frm.Show();
        }
        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasXPagar(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void ventasConTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasTarjeta);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasTarjeta(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void gastosExternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_OrdenesCompras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_OrdenesCompras();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_saldos_prov);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_saldos_prov();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void estadoDeCuentasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cuentas_osmart);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cuentas_osmart(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasBancarias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasBancarias(Usuario);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void proveedoresDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ProveedorServicios);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ProveedorServicios(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void cuentasBancariasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasBancariasOS);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasBancariasOS(Usuario);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU CONTABILIDAD
        #region


        private void totalDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteCorteZ);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteCorteZ();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteDeVentasPorTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteXTicket);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteXTicket();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void reporteCorteZToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void reporteVouchersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasTarjeta);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasTarjeta(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void panelFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PanelFacturas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new PanelFacturas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteTikectsTarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Caja1Tarjetas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Caja1Tarjetas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU FINANZAS
        #region
        private void registrarPersonaQueGeneraGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RegistrarPersonaGeneraGasto);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RegistrarPersonaGeneraGasto();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void listaDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ListaGastosFinanzas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ListaGastosFinanzas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void registrarGastoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CapturaGastoFinanzas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            GastoExterno ge = new GastoExterno()
            {
                Id = 0,
                Foto1 = "",
                Foto2 = "",
                Fecha = DateTime.Now
            };
            frm = new CapturaGastoFinanzas(ge,lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void efectivoDispponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EfectivoDisponible);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EfectivoDisponible();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void ventasEnCajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasEnCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasEnCajas(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void gastosExternosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_GastosExternos(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void ventasPLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasXLinea);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasXLinea();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void repPagoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagoproveedores_Finanzas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagoproveedores_Finanzas(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void estadoDeCuentasOsmartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cuentas_osmart);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cuentas_osmart(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU NOMINA
        #region

        private void altaDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_agregarEmpleado);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_agregarEmpleado();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ReporteAsistencia);

            if (frm != null)
            {
                frm.BringToFront();
                return;
            }

            frm = new frm_ReporteAsistencia();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU GERENCIA
        #region

        private void gastosFinanzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteGastosFinanzas_Gerencia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteGastosFinanzas_Gerencia();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void ventasPTiendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasXTienda2);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasXTienda2();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void ventasPLineaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasXLinea);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasXLinea();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void pagoAProveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagoproveedores_Finanzas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagoproveedores_Finanzas(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void gastosPDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepGastosxDia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepGastosxDia(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void ventasConTarjetaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasTarjeta);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasTarjeta(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void estadoDeCuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasXPagar(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void saldoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_saldos_prov);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_saldos_prov();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void despositosACuentasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RetirarEfectivoTiendas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RetirarEfectivoTiendas(lblUsuario.Text,lblEstacion.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void estadoDeCuentaOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cuentas_osmart);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cuentas_osmart(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void efectivoDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EfectivoDisponible);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EfectivoDisponible();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void pagoEfectivoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pagos_efe_enc_cajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Pagos_efe_enc_cajas(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void solictudDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagosprogramados);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagosprogramados(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void crearCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CorteZ);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CorteZ();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void buscarCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is BuscarCortez);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new BuscarCortez();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void valorDelInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ValorInventario);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ValorInventario();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void estadoDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_costos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_costos();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void crearConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_CreaGastosExterno);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_CreaGastosExterno();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void registrarConceptoExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_GastosExternos();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void despositoACuentasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RetirarEfectivoTiendas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RetirarEfectivoTiendas(lblUsuario.Text,lblEstacion.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void transaccionesPTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ventasxhora);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_ventasxhora();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        //MENU SUPERVICION
        #region
        private void ventasPHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ventasxhora);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_ventasxhora();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void intercambioDeMercanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is IntercambioMercancia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new IntercambioMercancia(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void ventasPTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasXTienda2);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasXTienda2();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void registroDeJefesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RegistroJefe);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RegistroJefe();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificarGerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarGte);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarGte();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_comisiones_gtes);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_comisiones_gtes();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificarEncCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarEncCajas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void repComisionesEncDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesEncCajas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificarJefeDeAlamacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarJefeAlmacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarJefeAlmacen(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_comisionesJefeAlmacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_comisionesJefeAlmacen();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarCubres);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarCubres();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void calificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarCubreEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarCubreEncCajas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cubreEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cubreEncCajas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void calificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarCubreAlmacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarCubreAlmacen();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_ComCubreJefeAlmacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_ComCubreJefeAlmacen();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }


        private void calificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarJefeAlmacenCedis);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarJefeAlmacenCedis();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }


        private void reporteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesJefeAlmacenCedis);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesJefeAlmacenCedis();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void fechaDeLlegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FechaLlegada);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new FechaLlegada();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteCubreGerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepComisionCubre);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepComisionCubre();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void reporteCubreEncCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cubreEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cubreEncCajas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }


        #endregion

        #region MONITOREO

        private void capturarIncidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CapturarIncidenciaCCTV);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CapturarIncidenciaCCTV(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void crearReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteCCTV);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteCCTV(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        #region GASTOS

        private void revisionEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RevisionIncidenciasEtiquetas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RevisionIncidenciasEtiquetas();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        private void revisionGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GastosView);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new GastosView(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
        #endregion

        #endregion





        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void calificarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagosProgramadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void respDeSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void permisosModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_PermisosModulos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_PermisosModulos();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void modificaTicektVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_modificaTicket);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_modificaTicket(lblUsuario.Text);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeGastosExternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteGastosExternos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteGastosExternos();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void registrarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GastosAlmacenCedis);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            GastoAlmacenCedis ac = new GastoAlmacenCedis();
            ac.ConceptoGral = "";
            ac.Actualizar = false;
            ac.Usuario = lblUsuario.Text;
            frm = new GastosAlmacenCedis(ac);
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void listarModificarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ListadoGastosCedis);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ListadoGastosCedis();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void articulosConExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteArticulosExistencia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteArticulosExistencia();
            string modulo = frm.Name;
            RegistrarAccesos(modulo);
            frm.Show();
        }
    }
}
