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

namespace appSugerencias
{
    public partial class frm_ModificarConceptoGastoExterno : Form
    {
        GastoExterno ge;
        string tipo_gasto="";
        public frm_ModificarConceptoGastoExterno(GastoExterno ge)
        {
            this.ge = ge;
            InitializeComponent();
        }


        //Botón modificar
        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                DialogResult respuesta = MessageBox.Show("¿Estás seguro que deseas eliminar el concepto de gasto externo?", "Eliminar gasto externo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    ge.Concepto_gral = CB_concepto_gral.SelectedItem.ToString();
                    ge.Nombre_Gasto = tbGastos.Text;
                    ge.Tipo_gasto_ex = tipo_gasto;
                    GastoExternoController.ModificarGastoExterno(ge);
                    MessageBox.Show("Se ha modificado el gasto");
                    this.Close();
                }else
                {
                    this.Close();
                }
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar el gasto: "+ex);
                this.Close();
            }
        }

        private void frm_ModificarConceptoGastoExterno_Load(object sender, EventArgs e)
        {
            LB_modificar_id.Text = ge.Id.ToString();
            LB_modificar_concepto_gral.Text = ge.Concepto_gral;
            LB_modificar_concepto_detalle.Text = ge.Nombre_Gasto;
            LB_modificar_tipo_gasto.Text = ge.Tipo_gasto_ex;

            LB_eliminar_id.Text = ge.Id.ToString();
            LB_eliminar_concepto_gral.Text = ge.Concepto_gral;
            LB_eliminar_concepto_detalle.Text = ge.Nombre_Gasto;
            LB_eliminar_tipo_gasto.Text = ge.Tipo_gasto_ex;
        }

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";

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

            tipo_gasto = "GENERAL";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }
        }

        private void BT_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {



                DialogResult respuesta = MessageBox.Show("¿Estás seguro que deseas eliminar el concepto de gasto externo?","Eliminar gasto externo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                if (respuesta == DialogResult.OK)
                {
                    GastoExternoController.EliminarGastoExterno(ge.Id);
                    MessageBox.Show("Se ha eliminado el gasto externo");
                    this.Close();
                }else
                {
                    this.Close();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el gasto externo: "+ex);
                this.Close();
            }
        }
    }
}
