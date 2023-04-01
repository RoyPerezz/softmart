using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos_Externos.Vistas
{
    public partial class ReporteGastosExternos : Form
    {
        public object PagosGastoExternoController { get; private set; }

        public ReporteGastosExternos()
        {
            InitializeComponent();
        }

        private void ReporteGastosExternos_Load(object sender, EventArgs e)
        {
            RB_todos.Checked = true;
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
           
            List<GastoExternoPago> lista = new List<GastoExternoPago>();

            if (RB_todos.Checked == true)//busca todos los pagos a gastos externos
            {
                lista = PagoGastoExternoController.BuscarTodosPagos(sucursal, inicio, fin);


                foreach (var item in lista)
                {
                    DG_tabla.Rows.Add(item.Id, item.TipoGasto, item.ConceptoGral, item.ConceptoDetalle, item.Importe.ToString("C2"), item.Observacion, item.Fecha.ToString("yyyy-MM-dd"));
                }
            }else if(RB_general_todos.Checked==true || RB_tienda_todos.Checked == true)//busca todos los pagos de acuerdo a su tipo, si son de TIENDA O GENERAL
            {
                string tipo = "";

                if (RB_general_todos.Checked == true)
                {
                    tipo = "GENERAL";

                }

                if (RB_tienda_todos.Checked == true)
                {
                    tipo = "TIENDA";

                }

                lista = PagoGastoExternoController.BuscarPagosXTipoGasto(sucursal,tipo,inicio,fin);
                foreach (var item in lista)
                {
                    DG_tabla.Rows.Add(item.Id, item.TipoGasto, item.ConceptoGral, item.ConceptoDetalle, item.Importe.ToString("C2"), item.Observacion, item.Fecha.ToString("yyyy-MM-dd"));
                }


            }
            else if(RB_tienda.Checked==true)
            {
                string conceptoGral = CB_concepto_gral.SelectedItem.ToString();
                

                if ((RB_general.Checked == true || RB_tienda.Checked == true) && !CB_concepto_gral.Text.Equals("") && cbGastos.Text.Equals(""))
                {
                   
                   
                    lista = PagoGastoExternoController.BuscarPagoXConceptoGral(sucursal,"TIENDA", conceptoGral,inicio,fin);
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.Id, item.TipoGasto, item.ConceptoGral, item.ConceptoDetalle, item.Importe.ToString("C2"), item.Observacion, item.Fecha.ToString("yyyy-MM-dd"));
                    }
                }
                else
                {
                    string concepto_detalle = cbGastos.SelectedItem.ToString();
                    lista = PagoGastoExternoController.BuscarPagoXConceptoDetalle(sucursal, "TIENDA", conceptoGral, concepto_detalle, inicio, fin);
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.Id, item.TipoGasto, item.ConceptoGral, item.ConceptoDetalle, item.Importe.ToString("C2"), item.Observacion, item.Fecha.ToString("yyyy-MM-dd"));
                    }
                }

            }else if(RB_general.Checked==true)
            {
                string conceptoGral = CB_concepto_gral.SelectedItem.ToString();
               
                if ((RB_general.Checked == true || RB_tienda.Checked == true) && !CB_concepto_gral.Text.Equals("") && cbGastos.Text.Equals(""))
                {
                   
                    lista = PagoGastoExternoController.BuscarPagoXConceptoGral(sucursal, "GENERAL", conceptoGral, inicio, fin);
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.Id, item.TipoGasto, item.ConceptoGral, item.ConceptoDetalle, item.Importe.ToString("C2"), item.Observacion, item.Fecha.ToString("yyyy-MM-dd"));
                    }
                }
                else
                {
                    string concepto_detalle = cbGastos.SelectedItem.ToString();
                    lista = PagoGastoExternoController.BuscarPagoXConceptoDetalle(sucursal, "GENERAL", conceptoGral, concepto_detalle, inicio, fin);
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.Id, item.TipoGasto, item.ConceptoGral, item.ConceptoDetalle, item.Importe.ToString("C2"), item.Observacion, item.Fecha.ToString("yyyy-MM-dd"));
                    }
                }
            }
           
        }

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            List<Egreso> lista = TipoGastosController.ConceptosGrales("TIENDA");

            foreach (var item in lista)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral.ToString());
            }
        }

        private void RB_general_CheckedChanged(object sender, EventArgs e)
        {

            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            List<Egreso> lista = TipoGastosController.ConceptosGrales("GENERAL");

            foreach (var item in lista)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral.ToString());
            }
        }

        private void CB_concepto_gral_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = "";
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            if (RB_general.Checked == true)
            {
                tipo = "GENERAL";

            }

            if (RB_tienda.Checked == true)
            {
                tipo = "TIENDA";

            }
            List<GastoExterno> lista = GastoExternoController.ConceptosDetalle(CB_concepto_gral.SelectedItem.ToString(), tipo);

            foreach (var item in lista)
            {
                cbGastos.Items.Add(item.Nombre_Gasto);



            }
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

                if (row.Visible == true)
                {
                    indiceFila++;
                    indiceColumna = 0;

                    foreach (DataGridViewColumn col in DG_tabla.Columns)
                    {
                        indiceColumna++;


                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;




                    }

                }

            excel.Range["C6:C100"].NumberFormat = "$#,##0.00";
          
            excel.Visible = true;
        }

    }
}
    

