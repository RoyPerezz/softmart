using appSugerencias.Cuentas_Bancarias.Controlador;
using appSugerencias.Cuentas_Bancarias.Modelo;
using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class DesgloseEgresos : Form
    {

        string concepto = "", sucursal = "", conceptoGral="", conceptoDetalle="", tipo_gasto="";
        DateTime fecha;
#pragma warning disable CS0414 // El campo 'DesgloseEgresos.flujo' está asignado pero su valor nunca se usa
        int flujo = 0;
#pragma warning restore CS0414 // El campo 'DesgloseEgresos.flujo' está asignado pero su valor nunca se usa
        bool check = false;
        public DesgloseEgresos(string concepto,string conceptoGral, string conceptoDetalle, string tipo_gasto ,DateTime fecha,string sucursal, bool check)
        {
            this.concepto = concepto;
            this.fecha = fecha;
            this.sucursal = sucursal;
            this.conceptoGral = conceptoGral;
            this.conceptoDetalle = conceptoDetalle;
            this.tipo_gasto = tipo_gasto;
            
            this.check = check;
            InitializeComponent();
        }


        
        private void DesgloseEgresos_Load(object sender, EventArgs e)
        {
            double total = 0;
            if (sucursal.Equals("CEDIS"))
            {
                DataTable dt = new DataTable();
                dt = GastosAlmacenCedisController.DesgloseGastos(conceptoGral, fecha);


                DG_tabla.DataSource = dt;

                foreach (DataRow item in dt.Rows)
                {
                    total += Convert.ToDouble(item["IMPORTE"].ToString());
                }
                LB_total.Text = total.ToString("C2");
                DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
            }else if(sucursal.Equals("FINANZAS"))
            {
                DataTable dt  = GastoFinanzasController.DesgloseGastosFinanzas(conceptoGral,fecha);
                DG_tabla.DataSource = dt;

                foreach (DataRow item in dt.Rows)
                {
                    total += Convert.ToDouble(item["IMPORTE"].ToString());
                }
                LB_total.Text = total.ToString("C2");
                DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
            }
            else
            {
               
                DataTable dt = new DataTable();
                CuentasController cc = new CuentasController();
                string nombre = "";
                if (concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CCDMX") || concepto.Equals("CGRAL") || concepto.Equals("CINO") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("ACR"))
                {

                    dt = cc.DesgloseDepositoCuentaOsmart(concepto, sucursal, fecha, check);
                    DG_tabla.DataSource = dt;
                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        nombre = DG_tabla.Columns[i].Name;
                        total += Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE"].Value);
                    }
                    LB_total.Text = total.ToString("C2");
                    DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
                    DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                }
                else if (concepto.Equals("RPPP"))
                {


                    LB_etiqueta_tipoEgreso.Visible = false;
                    LB_etiqueta_conceptoGral.Visible = false;
                    LB_etiqueta_conceptoDetalle.Visible = false;
                    LB_tipoEgreso.Visible = false;
                    LB_gral.Visible = false;
                    LB_detalle.Visible = false;

                    dt = cc.DesglosePagoAProveedores(sucursal, fecha, check);
                    DG_tabla.DataSource = dt;



                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        total += Convert.ToDouble(DG_tabla.Rows[i].Cells["MONTO"].Value);
                    }
                    LB_total.Text = total.ToString("C2");

                    DG_tabla.Columns["MONTO"].DefaultCellStyle.Format = "C2";
                    DG_tabla.Columns["MONTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    DG_tabla.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DG_tabla.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DG_tabla.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DG_tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                else
                {
                    LB_tipoEgreso.Text = tipo_gasto;
                    LB_gral.Text = conceptoGral;
                    LB_detalle.Text = conceptoDetalle;
                    GastosController gc = new GastosController();
                    List<Gasto> lista = gc.DesgloseEgresos(concepto, fecha, sucursal, check);
                    //DataTable dt = new DataTable();
                    dt.Columns.Add("FLUJO", typeof(int));
                    dt.Columns.Add("IMPORTE", typeof(double));
                    dt.Columns.Add("DESCRIPCION DETALLADA", typeof(string));

                    foreach (var item in lista)
                    {
                        dt.Rows.Add(item.Id, item.Importe, item.Detalle);
                    }

                    DG_tabla.DataSource = dt;

                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        total += Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE"].Value);
                    }
                    LB_total.Text = total.ToString("C2");
                    DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
                    DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                }


            }



        }
    }
}
