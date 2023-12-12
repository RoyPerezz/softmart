using appSugerencias.Cuentas_Bancarias.Controlador;
using appSugerencias.Cuentas_Bancarias.Modelo;
using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
using appSugerencias.Ventas.Controlador;
using appSugerencias.Ventas.Modelo;
using appSugerencias.Ventas.Vistas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class ResumenGastos : Form
    {
        string usuario = "";
        public ResumenGastos(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }



        public void EgresosTienda()
        {
            bool respaldo;
            if (CBX_respaldo.Checked == true)
            {
                respaldo = true;
            }
            else
            {
                respaldo = false;
            }


            double egreso = 0,gastos=0,proveedores=0,bancos=0;

            double retiro = 0;
            DG_tabla.Rows.Clear();
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime fecha = DT_fecha.Value;
            GastosController gc = new GastosController();
            List<Gasto> lista = gc.GastosTienda(sucursal,fecha,respaldo);
           
            List<Gasto> aux = new List<Gasto>();
            ArrayList dev = new ArrayList();
            double dv = 0;
            int indice = 0;
            int indiceEgresos = indice + 1;
            int indiceIngresos = 1;
            double ingreso = 0,totalIngreso=0;
            double retirosEfectivo = 0;

            double retir = 0;

            double ban = 0;
            double devCL = 0;
            double cajaGral = 0, acree = 0,accrDiversos=0,finanzas=0,albergue=0,comprasInocencio=0,comprasCDMX=0, gastosPerla=0,ccdis=0,totalGastosCedis=0;


            if (sucursal.Equals("CEDIS"))//Si el usuario elige CEDIS
            {
                List<GastoAlmacenCedis> listaGastosCedis = GastosAlmacenCedisController.BuscarGastos(fecha);
                DG_tabla.Rows.Add("GASTOS DE CEDIS", "", "", "");
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["IMPORTE_EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["TOTAL_EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.ForeColor = Color.White;

                foreach (var item in listaGastosCedis)
                {
                    DG_tabla.Rows.Add(item.ConceptoGral,item.ConceptoDetalle, item.Importe, "", "", "", "", "", item.Clave);
                    totalGastosCedis += item.Importe;
                }
                DG_tabla.Rows.Add("TOTALES","", "", totalGastosCedis, "", "", "", "");
                int filas = DG_tabla.Rows.Count;
                DG_tabla.Rows[filas - 1].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                DG_tabla.Rows[filas - 1].DefaultCellStyle.ForeColor = Color.White;

            }else if (sucursal.Equals("FINANZAS"))//Si el usuario elige Finanzas
            {
                DateTime inicio = DT_fecha.Value;
                DateTime fin = DT_fecha.Value;
                List<GastoExterno> listaFinanzas = GastoFinanzasController.BuscarGastos(inicio, fin);

                DG_tabla.Rows.Add("GASTOS FINANZAS", "", "", "");
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["IMPORTE_EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["TOTAL_EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.ForeColor = Color.White;

                foreach (var item in listaFinanzas)
                {
                    DG_tabla.Rows.Add(item.Concepto_gral,item.ConceptoDetalle, item.Importe, "", "", "", "", "", "");
                    totalGastosCedis += item.Importe;
                }

                DG_tabla.Rows.Add("TOTALES", "", totalGastosCedis, "", "", "", "");
                int filas = DG_tabla.Rows.Count;
                DG_tabla.Rows[filas - 1].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                DG_tabla.Rows[filas - 1].DefaultCellStyle.ForeColor = Color.White;
            }
            else//si el usuario elige cualquiera de las 4 tiendas
            {
                #region EGRESOS

                DG_tabla.Rows.Add("GASTOS DE TIENDA", "", "", "");
                DG_tabla.Rows[0].Cells["CONCEPTO_GRAL"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["IMPORTE_EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["TOTAL_EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[0].Cells["EGRESOS"].Style.ForeColor = Color.White;
                DG_tabla.Rows[0].Cells["CONCEPTO_GRAL"].Style.ForeColor = Color.White;
                foreach (var item in lista)
                {


                    if (item.Concepto.Equals("DEV"))
                    {
                        dv += item.Importe;
                    }

                    if (item.Concepto.Equals("DEVCL"))
                    {
                        devCL += item.Importe;
                    }

                    if (item.Concepto.Equals("RPPP") || item.Concepto.Equals("RBAN") || item.Concepto.Equals("CCDMX") || item.Concepto.Equals("CGRAL") || item.Concepto.Equals("ACCR") || item.Concepto.Equals("FNZAS") || item.Concepto.Equals("ALBR") || item.Concepto.Equals("CINO") || item.Concepto.Equals("GMGP") || item.Concepto.Equals("CCDIS"))
                    {


                        Gasto gasto = new Gasto()
                        {
                            Id = Convert.ToInt32(item.Id),
                            Concepto = item.Concepto,
                            Descripcion = item.Descripcion,

                            Importe = item.Importe

                        };

                        if (item.Concepto.Equals("RPPP"))
                        {
                            proveedores += item.Importe;
                        }

                        if (item.Concepto.Equals("CGRAL"))
                        {
                            cajaGral += item.Importe;
                        }

                        if (item.Concepto.Equals("ACCR"))
                        {
                            accrDiversos += item.Importe;
                        }
                        if (item.Concepto.Equals("ACR"))
                        {
                            acree += item.Importe;
                        }


                        if (item.Concepto.Equals("CCDMX"))
                        {
                            comprasCDMX += item.Importe;
                        }

                        if (item.Concepto.Equals("FNZAS"))
                        {
                            finanzas += item.Importe;
                        }

                        if (item.Concepto.Equals("ALBR"))
                        {
                            albergue += item.Importe;
                        }


                        if (item.Concepto.Equals("CINO"))
                        {
                            comprasInocencio += item.Importe;
                        }

                        if (item.Concepto.Equals("GMGP"))
                        {
                            gastosPerla += item.Importe;
                        }
                        if (item.Concepto.Equals("CCDIS"))
                        {
                            ccdis += item.Importe;
                        }

                        if (item.Concepto.Equals("RBAN"))
                        {
                            ban += item.Importe;
                        }

                        //if (item.Concepto.Equals("RBAN")|| item.Concepto.Equals("CCDMX") || item.Concepto.Equals("CGRAL") || item.Concepto.Equals("ACCR") || item.Concepto.Equals("FNZAS") || item.Concepto.Equals("ALBR") || item.Concepto.Equals("CINO")||item.Concepto.Equals("GMGP") || item.Concepto.Equals("ACR"))
                        //{
                        //    bancos += item.Importe;
                        //}
                        //egreso += item.Importe;
                        bancos = cajaGral + acree + accrDiversos + finanzas + albergue + comprasInocencio + comprasCDMX + ban + ccdis;
                        aux.Add(gasto);

                    }
                    else
                    {


                        if (item.Concepto.Equals("Retir"))
                        {
                            retirosEfectivo += item.Importe;
                            gastos += retiro;

                            //retirosEfectivo = item.Importe - proveedores - bancos;
                            //retirosEfectivo +=proveedores - bancos;
                            //retir = proveedores + bancos;
                            // DG_tabla.Rows.Add(item.Descripcion, retiro, "", "", "", "", "");
                        }
                        else
                        {
                            if (item.Concepto.Equals("DEV") || item.Concepto.Equals("DEVCL"))// aqui estaba devcl para que cuadre-----------------------------------------------------------------------------------------------------------------------
                            {

                            }
                            else
                            {
                                gastos += item.Importe;
                                DG_tabla.Rows.Add(item.ConceptoGral, item.Descripcion + " " + item.Tipo_egreso, item.Importe, "", "", "", "", "", item.Concepto);

                            }
                            //gastos += item.Importe;
                            //DG_tabla.Rows.Add(item.ConceptoGral, item.Descripcion + " " + item.Tipo_egreso, item.Importe, "", "", "", "", "", item.Concepto);



                        }
                        indice++;
                    }
                }

                int fila = DG_tabla.Rows.Count;
                double efectivoSinUsar = 0;
                efectivoSinUsar = retirosEfectivo - (proveedores + bancos);
                DG_tabla.Rows[fila - 1].Cells["TOTAL_EGRESOS"].Value = gastos +devCL;//TOTAL DE GASTOS DE TIENDA
                DG_tabla.Rows.Add("RETIROS DE EFECTIVO", "", "", efectivoSinUsar, "", "", "", "");//TOTAL DEL EFECTIVO DISPONIBLE

                fila = DG_tabla.Rows.Count;
                DG_tabla.Rows[fila - 1].Cells["CONCEPTO_GRAL"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[fila - 1].Cells["CONCEPTO_GRAL"].Style.ForeColor = Color.White;
                DG_tabla.Rows[fila - 1].Cells["EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[fila - 1].Cells["IMPORTE_EGRESOS"].Style.BackColor = Color.DodgerBlue;
                DG_tabla.Rows[fila - 1].Cells["IMPORTE_EGRESOS"].Style.ForeColor = Color.White;
                DG_tabla.Rows[fila - 1].Cells["TOTAL_EGRESOS"].Style.BackColor = Color.DodgerBlue;

                foreach (var item in aux)
                {

                    DG_tabla.Rows.Add("",item.Descripcion, item.Importe, "", "", "", "", "", item.Concepto);
                    indiceEgresos++;
                }

                fila = DG_tabla.Rows.Count;


                //DG_tabla.Rows[indiceEgresos+indice].Cells["TOTAL_EGRESOS"].Value = retirosEfectivo + proveedores + bancos;


                //################# SE CALCULA EL TOTAL DEL EGRESO DEL EFECTIVO DISPONIBLE
                if (proveedores == 0 && bancos == 0 && gastosPerla == 0)
                {
                    DG_tabla.Rows[fila - 1].Cells["TOTAL_EGRESOS"].Value = efectivoSinUsar;
                }
                else
                {
                    double EfeDispoible = proveedores + bancos + gastosPerla;

                    DG_tabla.Rows[fila - 1].Cells["TOTAL_EGRESOS"].Value = EfeDispoible;
                }
                //#########################################################################





                #endregion

                #region INGRESOS
                double venta = VentaController.VentaDia(sucursal, fecha, respaldo);
                DG_tabla.Rows[1].Cells["INGRESOS"].Value = "VENTA DEL DIA";
                DG_tabla.Rows[1].Cells["IMPORTE_INGRESOS"].Value = venta;

                List<Ingreso> ingresos = VentaController.OtrosIngresos(sucursal, fecha, respaldo);

                foreach (var item in ingresos)
                {
                    indiceIngresos++;
                    DG_tabla.Rows[indiceIngresos].Cells["INGRESOS"].Value = item.Descripcion;
                    DG_tabla.Rows[indiceIngresos].Cells["IMPORTE_INGRESOS"].Value = item.Importe;
                    DG_tabla.Rows[indiceIngresos].Cells["CLAVE_INGRESO"].Value = item.Concepto;
                    ingreso += item.Importe;
                }


                if (dv > 0)
                {
                    DG_tabla.Rows[++indiceIngresos].Cells["INGRESOS"].Value = "DEVOLUCION (CANCELACION)";
                    DG_tabla.Rows[indiceIngresos].Cells["CLAVE_INGRESO"].Value = "DEV";
                    DG_tabla.Rows[indiceIngresos].Cells["IMPORTE_INGRESOS"].Value = dv;
                }

                if (devCL > 0)
                {
                    DG_tabla.Rows[++indiceIngresos].Cells["INGRESOS"].Value = "DEVOLUCION CLIENTE";
                    DG_tabla.Rows[indiceIngresos].Cells["CLAVE_INGRESO"].Value = "DEVCL";
                    DG_tabla.Rows[indiceIngresos].Cells["IMPORTE_INGRESOS"].Value = devCL;
                }

                totalIngreso = (ingreso + venta);
                DG_tabla.Rows[indiceIngresos].Cells["TOTAL_INGRESOS"].Value = totalIngreso;
                #endregion

                //##############  SUMA DE TODO EL EGRESO ##################################################
                double total_Egreso = 0;
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {


                    if (string.IsNullOrEmpty(DG_tabla.Rows[i].Cells["TOTAL_EGRESOS"].Value.ToString()))
                    {

                    }
                    else
                    {
                        total_Egreso += Convert.ToDouble(DG_tabla.Rows[i].Cells["TOTAL_EGRESOS"].Value);
                    }

                }
                //############################################################################################

                double diferencia = total_Egreso - totalIngreso;// SE CALCULA LA DIFERENCIA
                DG_tabla.Rows.Add("TOTALES", "", "", total_Egreso, "", "", totalIngreso, diferencia);
                int filas = DG_tabla.Rows.Count;
               
                DG_tabla.Rows[filas - 1].DefaultCellStyle.BackColor = Color.Black;
                DG_tabla.Rows[filas - 1].DefaultCellStyle.ForeColor = Color.White;
            }





    

          
           

            DG_tabla.Columns["IMPORTE_EGRESOS"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["TOTAL_EGRESOS"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPORTE_INGRESOS"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["TOTAL_INGRESOS"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["DIFERENCIA"].DefaultCellStyle.Format = "C2";


        }
        private void BT_egresos_Click(object sender, EventArgs e)
        {

            if (CB_sucursal.SelectedIndex==-1)
            {
                MessageBox.Show("Selecciona una sucursal");
            }else
            {

                
                EgresosTienda();
            }
        }

        private void BT_gastos_Click(object sender, EventArgs e)
        {

            if (CB_sucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una sucursal");
            }
            else
            {
                string sucursal = CB_sucursal.SelectedItem.ToString();
                DateTime fecha = DT_fecha.Value;
                bool respaldo = false;
                if (CBX_respaldo.Checked == true)
                {
                    respaldo = true;
                }
                
                    AprobacionGastos aprobacion = new AprobacionGastos(sucursal, fecha, respaldo);
                    aprobacion.Show();
                
               

                
            }

            
        }

        private void ResumenGastos_Load(object sender, EventArgs e)
        {

        }




       
        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            bool check = false;
            if (CBX_respaldo.Checked == true)
            {
                check = true;
            }
            DateTime fecha = DT_fecha.Value;
            string sucursal = CB_sucursal.SelectedItem.ToString();

            if (DG_tabla.Rows[e.RowIndex].Cells["EGRESOS"].Selected)
            {




                if (sucursal.Equals("CEDIS"))
                {
                    string conceptoGral = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTO_GRAL"].Value.ToString();

                    DesgloseEgresos de = new DesgloseEgresos("", conceptoGral, "", "GENERAL", fecha, sucursal, check);
                    de.Show();

                }else if(sucursal.Equals("FINANZAS"))
                {
                    string conceptoGral = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTO_GRAL"].Value.ToString();

                    DesgloseEgresos de = new DesgloseEgresos("", conceptoGral, "", "GENERAL", fecha, sucursal, check);
                    de.Show();
                }
                else
                {

                    string clave = DG_tabla.Rows[e.RowIndex].Cells["CLAVE"].Value.ToString();







                    GastosController gc = new GastosController();
                    List<Gasto> lista = gc.DetalleConcetoEgreso(clave);
                    string conceptoGral = "", conceptoDetalle = "", tipo_gasto = "";
                    foreach (var item in lista)
                    {
                        conceptoGral = item.Concepto;
                        conceptoDetalle = item.Descripcion;
                        tipo_gasto = item.Tipo_egreso;
                    }
                    DesgloseEgresos de = new DesgloseEgresos(clave, conceptoGral, conceptoDetalle, tipo_gasto, fecha, sucursal, check);
                    de.Show();
                }

               
            }else if(DG_tabla.Rows[e.RowIndex].Cells["INGRESOS"].Selected)
            {

                var esNull = DG_tabla.Rows[e.RowIndex].Cells["CLAVE_INGRESO"].Value;
                string clave = "";
                if (esNull==null)
                {
                    clave = "";
                }
                else
                {
                    clave = DG_tabla.Rows[e.RowIndex].Cells["CLAVE_INGRESO"].Value.ToString();

                   
                }
             
               

                DesgloseIngreso di = new DesgloseIngreso(clave,fecha,sucursal,check);
                di.Show();
            }

           
            
          

        }

        private void DT_fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (CB_sucursal.Text.Equals(""))
            {
                MessageBox.Show("Selecciona la sucursal");
            }
            else
            {

                //Evita que la vista de agregar foto se abra mas de una vez
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GastosXAprobar);

                if (frm != null)
                {
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }
                else
                {
                    GastosXAprobar aprobar = new GastosXAprobar(CB_sucursal.SelectedItem.ToString());
                    aprobar.Show();
                }
              

            }

        }

        private void BT_gastos_finanzas_Click(object sender, EventArgs e)
        {
            AprobacionGastosGeneral agg = new AprobacionGastosGeneral();
            agg.Show();
        }
    }
}
