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
    public partial class ModificarGastoExternoPago : Form
    {
        public ModificarGastoExternoPago()
        {
            InitializeComponent();
        }

        int idGastoExterno = 0;
        string tipo_gasto = "";

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            tipo_gasto = "TIENDA";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }
        }

        private void RB_general_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            tipo_gasto = "GENERAL";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }
        }

        private void CB_concepto_gral_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGastos.Items.Clear();
            cbGastos.Text = "";
            List<GastoExterno> lista = GastoExternoController.ConceptosDetalle(CB_concepto_gral.SelectedItem.ToString(), tipo_gasto);

            foreach (var item in lista)
            {
                cbGastos.Items.Add(item.Nombre_Gasto);



            }
        }

        private void cbGastos_SelectedIndexChanged(object sender, EventArgs e)
        {
            idGastoExterno = GastoExternoController.ObtenerIDGastoExterno(cbGastos.SelectedItem.ToString(),
                                                                         CB_concepto_gral.SelectedItem.ToString(),
                                                                         tipo_gasto);
        }


        public void BuscarPagos()
        {
            DG_tabla.Rows.Clear();
            string sucursal = CB_sucursal.SelectedItem.ToString();
            string conceptoGral = CB_concepto_gral.SelectedItem.ToString();
            string conceptoDetalle = cbGastos.SelectedItem.ToString();
            DateTime fecha = DT_fecha.Value;
            List<GastoExternoPago> lista = GastoExternoController.BuscarGastoExterno(sucursal, tipo_gasto, conceptoGral, conceptoDetalle, fecha);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Id, item.TipoGasto, item.ConceptoGral, item.ConceptoDetalle, item.Importe, item.Observacion);
            }
        }
        private void BT_buscar_Click(object sender, EventArgs e)
        {
            BuscarPagos();
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LB_id.Text = DG_tabla.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            TB_importe.Text = DG_tabla.Rows[e.RowIndex].Cells["IMPORTE"].Value.ToString();
            TB_referencia.Text = DG_tabla.Rows[e.RowIndex].Cells["REFERENCIA"].Value.ToString();
            string tipo_gasto = DG_tabla.Rows[e.RowIndex].Cells["TIPOGASTO"].Value.ToString();
            string conceptoGral = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTOGRAL"].Value.ToString();
            string conceptoDetalle = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTODETALLE"].Value.ToString();

            if (tipo_gasto.Equals("TIENDA"))
            {
                RB_tienda_modificacion.Checked=true;
                RB_general_modificacion.Checked = false;
            }
            else if(tipo_gasto.Equals("GENERAL"))
            {

                RB_general_modificacion.Checked = true;
                RB_tienda_modificacion.Checked = false;

            }

            CB_concepto_gral_modificacion.Text = conceptoGral;
            CB_concepto_detalle_modificacion.Text = conceptoDetalle;
        }

        private void RB_tienda_modificacion_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral_modificacion.Items.Clear();
            CB_concepto_gral_modificacion.Text = "";
            CB_concepto_detalle_modificacion.Items.Clear();
            CB_concepto_detalle_modificacion.Text = "";
            tipo_gasto = "TIENDA";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral_modificacion.Items.Add(item.ConceptoGral);
            }
        }

        private void RB_general_modificacion_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral_modificacion.Items.Clear();
            CB_concepto_gral_modificacion.Text = "";
            CB_concepto_detalle_modificacion.Items.Clear();
            CB_concepto_detalle_modificacion.Text = "";
            tipo_gasto = "GENERAL";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral_modificacion.Items.Add(item.ConceptoGral);
            }
        }

        private void CB_concepto_gral_modificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_concepto_detalle_modificacion.Items.Clear();
            CB_concepto_detalle_modificacion.Text = "";
            List<GastoExterno> lista = GastoExternoController.ConceptosDetalle(CB_concepto_gral_modificacion.SelectedItem.ToString(), tipo_gasto);

            foreach (var item in lista)
            {
                CB_concepto_detalle_modificacion.Items.Add(item.Nombre_Gasto);



            }
        }

        public void Limpiar()
        {
            RB_tienda_modificacion.Checked = false;
            RB_general_modificacion.Checked = false;
            CB_concepto_gral_modificacion.Text = "";
            CB_concepto_detalle_modificacion.Text = "";
            TB_referencia.Text = "";
            TB_importe.Text = "";
        }
        private void BT_modificar_Click(object sender, EventArgs e)
        {
            string sucursal = CB_sucursal.SelectedItem.ToString();
            GastoExternoPago gep = new GastoExternoPago()
            {
                Id = Convert.ToInt32(LB_id.Text),
                TipoGasto = tipo_gasto,
                ConceptoGral = CB_concepto_gral_modificacion.Text,
                ConceptoDetalle = CB_concepto_detalle_modificacion.Text,
                Importe = Convert.ToDouble(TB_importe.Text),
                Observacion = TB_referencia.Text
            };

            PagoGastoExternoController.ModificarPagoGastoExterno(gep,sucursal);
            BuscarPagos();
            Limpiar();
            MessageBox.Show("Se ha modificado el pago");
        }

        private void CB_concepto_detalle_modificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
