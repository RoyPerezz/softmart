using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using MySql.Data.MySqlClient;
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
    public partial class ModificarGasto : Form
    {
        int ticket =0;
        string tipo_gasto = "", concepto_gral = "", concepto_detalle = "", claveConcepto="",sucursal="";
        DateTime fecha;
        DataTable conDetalle;
        double importe = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = null;
            MySqlConnection conFlujo = null;
            MySqlCommand cmd = null,cmd2= null;


            try
            {
                if (CBX_respaldo.Checked==true)                    
                {
                    string mes = FormatoFecha.Mes(fecha.Month);
                    conFlujo = BDConexicon.RespMultiSuc(sucursal,mes,fecha.Year);
                }else
                {
                    conFlujo = BDConexicon.ConexionSucursal(sucursal);
                }

                con = BDConexicon.ConexionSucursal(sucursal);
                string conceptoGral = CB_concepto_gral.SelectedItem.ToString();
                string conceptoDetalle = CB_concepto_detalle.SelectedItem.ToString();
                string query = "UPDATE rd_auditoria_gastos SET concepto='"+ conceptoGral + "',descripcion='"+ conceptoDetalle + "',claveEgreso='"+claveConcepto+"' WHERE ticket='" + LB_ticket.Text+"'";
                string query2 = "UPDATE FLUJO SET CONCEPTO='"+ claveConcepto+"', CONCEPTO2='"+ claveConcepto+"' WHERE FLUJO ='"+ LB_ticket.Text +"'";
                cmd = new MySqlCommand(query,con);
                cmd2 = new MySqlCommand(query2,conFlujo);




                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Se ha modificado el gasto");
            }
            catch ( Exception ex)
            {

                MessageBox.Show("Ha ocurrido una excepción a la hora de modificar el gasto: "+ex);
            }
        }

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {

            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            CB_concepto_detalle.Text = "";
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
            CB_concepto_detalle.Text = "";
            tipo_gasto = "GENERAL";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }
        }

        private void CB_concepto_gral_SelectedIndexChanged(object sender, EventArgs e)
        {

            CB_concepto_detalle.Items.Clear();
            CB_concepto_detalle.Text = "";

            string conceptGral = CB_concepto_gral.SelectedItem.ToString();

            List<Egreso> conceptosDetalle = TipoGastosController.ConceptoDetalle(conceptGral, tipo_gasto);
            conDetalle = new DataTable();
            conDetalle.Columns.Add("CONCEPTO", typeof(string));
            conDetalle.Columns.Add("DESCRIPCION", typeof(string));
            foreach (var item in conceptosDetalle)
            {
                CB_concepto_detalle.Items.Add(item.ConceptoDetalle);
                conDetalle.Rows.Add(item.Clave, item.ConceptoDetalle);
            }
        }

        private void CB_concepto_detalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < conDetalle.Rows.Count; i++)
            {
                if (CB_concepto_detalle.SelectedItem.ToString().Equals(conDetalle.Rows[i]["DESCRIPCION"].ToString()))
                {
                    claveConcepto = conDetalle.Rows[i]["CONCEPTO"].ToString();
                }
            }
        }

        public ModificarGasto(int ticket, string tipo_gasto, string concepto_gral, string concepto_detalle, string sucursal, DateTime fecha,double importe)
        {
            this.ticket = ticket;
            this.tipo_gasto = tipo_gasto;
            this.concepto_gral = concepto_gral;
            this.concepto_detalle = concepto_detalle;
            this.sucursal = sucursal;
            this.fecha = fecha;
            this.importe = importe;
            
            InitializeComponent();
        }

        private void ModificarGasto_Load(object sender, EventArgs e)
        {
            LB_ticket.Text = ticket.ToString();
            LB_tipo_gasto.Text = tipo_gasto;
            LB_concepto_gral.Text = concepto_gral;
            LB_concepto_detalle.Text = concepto_detalle;
            LB_importe.Text = importe.ToString("C2");
            LB_fecha.Text = fecha.ToString("yyyy-MM-dd");
         }
    }
}
