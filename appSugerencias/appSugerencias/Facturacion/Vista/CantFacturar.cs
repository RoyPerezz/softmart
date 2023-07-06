using appSugerencias.Facturacion.Controlador;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class CantFacturar : Form
    {
        string usuario = "";
        public CantFacturar(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        #region VARIABLES
        ArrayList facturasEfe = new ArrayList();
        ArrayList facturasTar = new ArrayList();

        ArrayList ventasFacturadas = new ArrayList();
        DateTime PrimerDiaDelMes;
        DateTime UltimoDiaDelMes;
        string sucursalSeleccionada = "";
        string mes = "";
        int año = 0;
        double factEFE = 0, factTar = 0;
        string patron = "";
        #endregion

        public string AreaTrabajo()
        {
            string area = "";

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT area from usuarios WHERE usuario ='" + usuario + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                area = dr["area"].ToString();
            }
            dr.Close();
            con.Close();
            return area;
        }


        public double TotalFacturacion(DateTime fecha)
        {
            
            double facturacion = 0;
            string consulta = "select total, no_ticket  from facturacion where fecha BETWEEN '" + fecha.ToString("yyyy-MM-dd 00:00:00") + "' and '" + fecha.ToString("yyyy-MM-dd 23:59:59") + "' and rfccliente <> 'XAXX010101000'";
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            else
            {
                con = BDConexicon.conectar();
            }
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                if (dr["total"].ToString().Equals(""))
                {
                    facturacion = 0;
                }
                else
                {
                    facturacion += Convert.ToDouble(dr["total"].ToString());
                    ventasFacturadas.Add(dr["no_ticket"].ToString());
                }

            }

            SepararFacturas(ventasFacturadas,mes,año);// este metodo separa las ventas facturas, en efectivo y tarjeta
            dr.Close();
            con.Close();
            return facturacion;
        }

        public void SepararFacturas(ArrayList ventasFacturadas,string mes,int año)
        {
            MySqlConnection con = null;
           
            if (CBX_mes_anterior.Checked == true)
            {

               
                con = BDConexicon.RespMultiSuc(sucursalSeleccionada, mes, año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            for (int i = 0; i < ventasFacturadas.Count; i++)
            {
                cmd = new MySqlCommand("select concepto2 from flujo where venta ='" + ventasFacturadas[i] + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["concepto2"].ToString().Equals("EFE"))
                    {
                        facturasEfe.Add(ventasFacturadas[i].ToString());
                    }

                    if (dr["concepto2"].ToString().Equals("TAR"))
                    {
                        facturasTar.Add(ventasFacturadas[i].ToString());
                    }


                }
                dr.Close();
            }
        }


        public double TotalFacturacionCliente(DateTime fecha,string sucursal)
        {
            double total = 0;

            string query = "select facturacion.rfccliente,facturacion.razonsocial,facturacion.importe,facturacion.iva,facturacion.total,facturacion.estatus,facturacion.no_ticket,flujo.concepto2 " +
                "from facturacion inner join flujo on facturacion.no_ticket = flujo.venta where facturacion.fecha ='"+fecha.ToString("yyyy-MM-dd")+"' and concepto2 IN('TAR', 'EFE')";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["concepto2"].ToString().Equals("TAR"))
                {
                    factTar += Convert.ToDouble(dr["total"].ToString());
                    total += Convert.ToDouble(dr["total"].ToString());

                }
                else if(dr["concepto2"].ToString().Equals("EFE"))
                {
                    factEFE += Convert.ToDouble(dr["total"].ToString());
                    total += Convert.ToDouble(dr["total"].ToString());
                }
            }
            dr.Close();
            con.Close();
            return total;
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {


            DG_tabla.Rows.Clear();
            double  totalFacturaCliente = 0, FacturaGlobal = 0, efectivo = 0, tarjeta = 0;
            ArrayList ventasEfectivo = new ArrayList();
            DateTime FechaTabla;
            DateTime date = DateTime.Now;
            int numMes = FormatoFecha.NumMes(mes);
            //Asi obtenemos el primer dia del mes actual
            PrimerDiaDelMes = new DateTime(Convert.ToInt32(CB_año.Text), numMes, 1);
            UltimoDiaDelMes = PrimerDiaDelMes.AddMonths(1).AddDays(-1);
            MySqlConnection con = null;
            bool respaldo = false;
            double ventaTotal = 0,ventaEfectivo =0,ventasTarjetas=0;

            //Se toma la conexión a base de datos actual o de mes pasado,si se seleccionó la casilla de respaldo o no.
            if (CBX_mes_anterior.Checked==true)
            {
                con = BDConexicon.RespMultiSuc(sucursalSeleccionada,mes,año);
                respaldo = true;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }




            //for (DateTime fecha = PrimerDiaDelMes; fecha <= UltimoDiaDelMes; fecha = fecha.AddDays(1))             
            //{
            //    ventaTotal = FacturacionController.CalcularTotalVenta(fecha, sucursalSeleccionada);
            //    if (ventaTotal==0)
            //    {
            //        break;
            //    }
            //    DG_tabla.Rows.Add(fecha.ToString("yyyy-MM-dd"), ventaTotal);
            //}

            for (DateTime fecha = PrimerDiaDelMes; fecha <= UltimoDiaDelMes; fecha = fecha.AddDays(1))
            {
                
                DG_tabla.Rows.Add(fecha.ToString("yyyy-MM-dd"),0);
            }

          

            
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                FechaTabla = Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value);
                //ventaTotal = FacturacionController.CalcularTotalVenta(FechaTabla,sucursalSeleccionada);
                ventasTarjetas = FacturacionController.CalcularTotalTarjetas(FechaTabla,sucursalSeleccionada,mes,año,respaldo);
                ventaEfectivo = FacturacionController.CalcularTotalEfectivo(FechaTabla,sucursalSeleccionada,mes,año,respaldo);
                //factEFE = FacturacionController.CalcularFacturacionEfectivo(FechaTabla,sucursalSeleccionada,mes,año,respaldo, ventasEfectivo);
                totalFacturaCliente = TotalFacturacionCliente(FechaTabla,sucursalSeleccionada);

                FacturaGlobal = (ventaEfectivo + ventasTarjetas) - totalFacturaCliente;

                

                DG_tabla.Rows[i].Cells["TOTAL_VENTA"].Value = (ventaEfectivo + ventasTarjetas);
                DG_tabla.Rows[i].Cells["VENTAS_EFECTIVO"].Value = ventaEfectivo;
                DG_tabla.Rows[i].Cells["BAUCHER"].Value = ventasTarjetas;
                DG_tabla.Rows[i].Cells["TOTAL_FACTURADO"].Value = totalFacturaCliente;
                DG_tabla.Rows[i].Cells["FACT_EFE"].Value = factEFE;
                DG_tabla.Rows[i].Cells["FACT_TAR"].Value = factTar;
                DG_tabla.Rows[i].Cells["FACTURA_GLOBAL"].Value = FacturaGlobal;
                ventaEfectivo = ventaEfectivo - factEFE;
                ventasTarjetas = ventasTarjetas - factTar;
                DG_tabla.Rows[i].Cells["EFECTIVO"].Value = (ventaEfectivo/1.16);
                DG_tabla.Rows[i].Cells["TARJETA"].Value = (ventasTarjetas/1.16);

                if (ventaEfectivo==0 && ventasTarjetas==0)
                {
                    break;
                }

                DG_tabla.Columns["TOTAL_VENTA"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["VENTAS_EFECTIVO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["BAUCHER"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["FACT_EFE"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["FACT_TAR"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["TOTAL_FACTURADO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["FACTURA_GLOBAL"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["EFECTIVO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["TARJETA"].DefaultCellStyle.Format = "C2";
                factTar = 0; factEFE = 0; ventasTarjetas=0; ventaEfectivo = 0; totalFacturaCliente = 0; FacturaGlobal = 0;
            }
            ventasFacturadas.Clear();
            facturasEfe.Clear();
            facturasTar.Clear();
        }


        #region EVENTOS
        private void CB_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mes = CB_mes.Text;
        }

        private void RB_va_CheckedChanged(object sender, EventArgs e)
        {
            sucursalSeleccionada = "VALLARTA";
           LB_patron.Text = "MARICELA LOPEZ LORENZO";
        }

        private void RB_re_CheckedChanged(object sender, EventArgs e)
        {
            sucursalSeleccionada = "RENA";
            LB_patron.Text = "GEORGINA LAGUNAS ESCOBEDO";
        }

        private void RB_ve_CheckedChanged(object sender, EventArgs e)
        {
            sucursalSeleccionada = "VELAZQUEZ";
            LB_patron.Text = "MIGUEL ANGEL REZA FLORES";
        }

        private void RB_co_CheckedChanged(object sender, EventArgs e)
        {
            sucursalSeleccionada = "COLOSO";
            LB_patron.Text = "DANIELA LOPEZ RAMIREZ";
        }

        private void CantFacturar_Load(object sender, EventArgs e)
        {

        }

        private void CB_año_SelectedIndexChanged(object sender, EventArgs e)
        {
            año = Convert.ToInt32(CB_año.Text);
        }
        #endregion

    }
}
