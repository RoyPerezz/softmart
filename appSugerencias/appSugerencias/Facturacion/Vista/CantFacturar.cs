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
        int depositado = 0;
        int estado = 0;
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
                string m = AcortarMes(mes);

                con = BDConexicon.RespMultiSuc(sucursalSeleccionada, m, año);
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


        public double DepositoVentanilla(DateTime fecha,string sucursal)
        {

           
          


            double deposito = 0;
            
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {

              
                    con = BDConexicon.ConexionSucursal(sucursal);
                




            }
            else
            {
                con = BDConexicon.conectar();
            }
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            DataGridViewCheckBoxCell check = null;


                check = new DataGridViewCheckBoxCell();
              
                cmd = new MySqlCommand("select fecha,importe,estado,depositado from rd_deposito_ventanilla where fecha='" + fecha.ToString("yyyy-MM-dd") + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //DG_tabla.Rows[i].Cells["DEPOSITO_VENTANILLA"].Value = Convert.ToDouble(dr["importe"].ToString());
                    deposito= Convert.ToDouble(dr["importe"].ToString());
                    depositado = Convert.ToInt32(dr["depositado"].ToString());
                    estado = Convert.ToInt32(dr["estado"].ToString());


            }
                dr.Close();
            

            return deposito;


        }

        public bool FechaExiste(DateTime fecha)
        {
            bool respuesta = false;
            
            string consulta = "select * from rd_deposito_ventanilla where fecha='´" + fecha.ToString("yyyy-MM-dd") + "'";
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

            if (dr.HasRows)
            {
                respuesta = true;
            }

            dr.Close();

            return respuesta;
        }


        public int FacturaGlobalHecha()
        {
            int estado = 0;
            string query = "SELECT ";
            return estado;
        }

        public string AcortarMes(string mes)
        {
            string m = "";

            if (mes.Equals("ENERO"))
            {
                m = "ENE";
            }else if(mes.Equals("FEBRERO"))
            {
                m = "FEB";
            
             }else if(mes.Equals("MARZO"))
            {
                m = "MAR";
            }
            else if(mes.Equals("ABRIL"))
            {
                m = "ABR";
            }
            else if (mes.Equals("MAYO"))
            {
                m = "MAY";
            }
            else if (mes.Equals("JUNIO"))
            {
                m = "JUN";
            }
            else if (mes.Equals("JULIO"))
            {
                m = "JUL";
            }
            else if (mes.Equals("AGOSTO"))
            {
                m = "AGO";
            }
            else if (mes.Equals("SEPTIEMBRE"))
            {
                m = "SEP";
            }
            else if (mes.Equals("OCTUBRE"))
            {
                m = "OCT";
            }
            else if (mes.Equals("NOVIEMBRE"))
            {
                m = "NOV";
            }
            else if (mes.Equals("DICIEMBRE"))
            {
                m = "DEC";
            }
            return m;
        }
        private void BT_buscar_Click(object sender, EventArgs e)
        {


            DG_tabla.Rows.Clear();
            double  totalFacturaCliente = 0, FacturaGlobal = 0, efectivo = 0, tarjeta = 0,depositoCliente=0,depositoVentanilla=0,depositoPana=0;
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

            string m = "";

            //Se toma la conexión a base de datos actual o de mes pasado,si se seleccionó la casilla de respaldo o no.
            if (CBX_mes_anterior.Checked==true)
            {

                m = AcortarMes(mes);

                con = BDConexicon.RespMultiSuc(sucursalSeleccionada,m,año);
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
                
                DG_tabla.Rows.Add(fecha.ToString("yyyy-MM-dd"),0,0);
            }


            bool checkDepositado = false;
           
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                bool valor = false;
                FechaTabla = Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value);
                //ventaTotal = FacturacionController.CalcularTotalVenta(FechaTabla,sucursalSeleccionada);
               m = AcortarMes(mes);
                ventasTarjetas = FacturacionController.CalcularTotalTarjetas(FechaTabla,sucursalSeleccionada,m,año,respaldo);
                ventaEfectivo = FacturacionController.CalcularTotalEfectivo(FechaTabla,sucursalSeleccionada,m,año,respaldo);
                //factEFE = FacturacionController.CalcularFacturacionEfectivo(FechaTabla,sucursalSeleccionada,mes,año,respaldo, ventasEfectivo);

                //if (ventaEfectivo == 0 && ventasTarjetas == 0)
                //{
                //    break;
                //}


                totalFacturaCliente = TotalFacturacionCliente(FechaTabla,sucursalSeleccionada);
                depositoCliente = FacturacionController.CalcularDepositoDeCliente(FechaTabla,sucursalSeleccionada,LB_patron.Text);
                FacturaGlobal = (ventaEfectivo + ventasTarjetas) - totalFacturaCliente;
                depositoVentanilla = DepositoVentanilla(FechaTabla,sucursalSeleccionada);

                depositoPana = (ventaEfectivo + ventasTarjetas) - ventasTarjetas - depositoCliente - depositoVentanilla;


                DG_tabla.Rows[i].Cells["TOTAL_VENTA"].Value = (ventaEfectivo + ventasTarjetas);
                DG_tabla.Rows[i].Cells["DEPOSITO_VENTANILLA"].Value = depositoVentanilla;
                DG_tabla.Rows[i].Cells["DEPOSITO_CLIENTE"].Value = depositoCliente;
                DG_tabla.Rows[i].Cells["DEPOSITO_PANA"].Value = depositoPana;

                if (depositado == 1)
                {
                    DG_tabla.Rows[i].Cells["DEPOSITADO"].Value = true;
                    DG_tabla.Rows[i].Cells["DEPOSITO_PANA"].Style.ForeColor = Color.White;
                    DG_tabla.Rows[i].Cells["DEPOSITO_PANA"].Style.BackColor = Color.Red;
                }else
                {
                    DG_tabla.Rows[i].Cells["DEPOSITADO"].Value = false;
                }

                if (estado==1)
                {
                    DG_tabla.Rows[i].Cells["FACTURA_ELABORADA"].Value = true;
                }
                else
                {
                    DG_tabla.Rows[i].Cells["FACTURA_ELABORADA"].Value = false;
                }
                
                

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

              

                DG_tabla.Columns["TOTAL_VENTA"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["DEPOSITO_VENTANILLA"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["DEPOSITO_CLIENTE"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["DEPOSITO_PANA"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["VENTAS_EFECTIVO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["BAUCHER"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["FACT_EFE"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["FACT_TAR"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["TOTAL_FACTURADO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["FACTURA_GLOBAL"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["EFECTIVO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["TARJETA"].DefaultCellStyle.Format = "C2";
                factTar = 0; factEFE = 0; ventasTarjetas=0; ventaEfectivo = 0; totalFacturaCliente = 0; FacturaGlobal = 0; depositoVentanilla=0;
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
            string area = AreaTrabajo();
            string consulta = "select EMPRESA from econfig";
            string sucursal = "";
            string tienda = "";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sucursal = dr["EMPRESA"].ToString();
            }
            dr.Close();

            if (area.Equals("SISTEMAS") || area.Equals("CXPAGAR") || area.Equals("ADMON GRAL") || area.Equals("CONTAB") || area.Equals("SOPORTE") || area.Equals("FINANZAS"))
            {
                //CB_sucursal.Visible = true;
                //CB_sucursal.Items.Add("VALLARTA");
                //CB_sucursal.Items.Add("RENA");
                //CB_sucursal.Items.Add("VELAZQUEZ");
                //CB_sucursal.Items.Add("COLOSO");
                RB_va.Enabled = true;
                RB_re.Enabled = true;
                RB_ve.Enabled = true;
                RB_co.Enabled = true;
                DG_tabla.Columns["DEPOSITADO"].Visible = true;
            }
            else
            {
                //CB_sucursal.Visible = false;
                DG_tabla.Columns["DEPOSITADO"].Visible = false;
                if (sucursal.Equals("OSMART VALLARTA"))
                {
                    RB_va.Enabled = true;
                    RB_va.Checked = true;
                    RB_re.Enabled = false;
                    RB_ve.Enabled = false;
                    RB_co.Enabled = false;
                    tienda = "VALLARTA";
                }

                if (sucursal.Equals("OSMART RENACIMIENTO"))
                {
                    RB_va.Enabled = false;
                    RB_re.Enabled = true;
                    RB_re.Checked = true;
                    RB_ve.Enabled = false;
                    RB_co.Enabled = false;
                    tienda = "RENA";
                }

                if (sucursal.Equals("OSMART VELAZQUEZ"))

                {
                    RB_va.Enabled = false;
                    RB_re.Enabled = false;
                    RB_ve.Enabled = true;
                    RB_ve.Checked = true;
                    RB_co.Enabled = false;
                    tienda = "VELAZQUEZ";
                }

                if (sucursal.Equals("OSMART COLOSO"))
                {
                    RB_va.Enabled = false;
                    RB_re.Enabled = false;
                    RB_ve.Enabled = false;
                    RB_co.Enabled = true;
                    RB_co.Checked = true;
                    tienda = "COLOSO";
                }
            }

        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            
            DateTime fecha;
            bool existe = false;
            double importe = 0;
            bool estado = false;
            bool depositado = false;
            int valor = 0, valor1 = 0;
            string consulta = "INSERT INTO rd_deposito_ventanilla(fecha,importe,usuario,depositado)VALUES(?fecha,?importe,?usuario,?depositado)";




            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            string empresa = "";
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {


              
                    con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
              

            }
            else
            {

               
                    con = BDConexicon.conectar();
                

            }
            MySqlCommand cmd = null;

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                fecha = Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value.ToString());
                
                importe = Convert.ToDouble(DG_tabla.Rows[i].Cells["DEPOSITO_VENTANILLA"].Value.ToString());

                estado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["FACTURA_ELABORADA"].Value);
                depositado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["DEPOSITADO"].Value);
                valor = 0;

                if (estado == true)
                {
                    valor = 1;
                }

                if (estado == false)
                {
                    valor = 0;
                }

                if (depositado == true)
                {
                    valor1 = 1;
                }

                if (depositado == false)
                {
                    valor1 = 0;
                }

               



                existe = FechaExiste(fecha);
                if (existe == true)
                {
                    MySqlCommand actualizar = new MySqlCommand("UPDATE rd_deposito_ventanilla SET importe=" + importe + ", estado=" + valor + ", depositado=" + valor1 + " WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "'", con);
                    actualizar.ExecuteNonQuery();


                }
                else
                {
                    cmd = new MySqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("?fecha", Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value.ToString()));
                    cmd.Parameters.AddWithValue("?importe", DG_tabla.Rows[i].Cells["DEPOSITO_VENTANILLA"].Value.ToString());
                    cmd.Parameters.AddWithValue("?usuario", usuario);
                    cmd.Parameters.AddWithValue("?depositado", valor1);
                    cmd.ExecuteNonQuery();
                }




                //Solo se guarda si el usuario es del depto. de sistemas, cuentas por pagar o administracion gral, ya que las enc de cajas solo marcan que ya hicieron la factura global
                if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL"))
                {
                    Auditoria.Auditoria_cantidad_facturar(usuario, fecha.ToString("yyyy-MM-dd"), importe, sucursalSeleccionada);
                }


            }
            con.Close();
            MessageBox.Show("Se han guardado los cambios");
        }

        private void colorDeposito(DataGridView datagrid)
        {
            foreach (DataGridViewRow row in datagrid.Rows)
            {

                if (Convert.ToBoolean(datagrid.Rows[row.Index].Cells["DEPOSITADO"].Value) == true)
                {

                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.ForeColor = Color.White;
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.BackColor = Color.Red;
                }
                else if (Convert.ToBoolean(datagrid.Rows[row.Index].Cells[12].Value) == true)
                {
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.ForeColor = Color.Black;
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.BackColor = Color.Yellow;
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.SelectionBackColor = Color.SeaGreen;

                }
                else
                {
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.ForeColor = Color.Black;
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.BackColor = Color.White;
                }




            }
        }

        private void colorFila(DataGridView datagrid)
        {
            foreach (DataGridViewRow row in datagrid.Rows)
            {
                if (Convert.ToBoolean(datagrid.Rows[row.Index].Cells["FACTURA_ELABORADA"].Value) == true)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                }






            }
        }

        private void DG_tabla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            colorDeposito(DG_tabla);
            colorFila(DG_tabla);

        }

        private void button1_Click(object sender, EventArgs e)
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


            excel.Cells.Range["B6:M36"].NumberFormat = "$#,##0.00";


            excel.Visible = true;
        }

        private void CB_año_SelectedIndexChanged(object sender, EventArgs e)
        {
            año = Convert.ToInt32(CB_año.Text);
        }
        #endregion

    }
}
