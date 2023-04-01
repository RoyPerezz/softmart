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
    public partial class RegistrarConceptoEgreso : Form
    {
        string usuario = "";
        public RegistrarConceptoEgreso(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void BT_registrar_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            ConceptosEgreso egreso = new ConceptosEgreso()
            {
                Concepto = TB_clave.Text,
                Descripcion = TB_conceptoDetalle.Text,
                Presup = 0,
                Saldo = 0,
                Usuario = usuario,
                Fecha = fecha,
                Hora = fecha.ToString("HH:mm:ss"),
                Cuenta ="",
                ConceptoGral = CB_conceptoGral.SelectedItem.ToString(),
                TipoGasto = CB_tipo_gasto.SelectedItem.ToString()

                


            };


            try
            {
                TipoGastosController.RegistrarConceptoEgreso(egreso);
                MessageBox.Show("Se ha guardado el nuevo concepto de egreso");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar el concepto de egreso: "+ex);
            }
          
        }

        private void RegistrarConceptoEgreso_Load(object sender, EventArgs e)
        {

        }

        private void CB_tipo_gasto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_conceptoGral.Items.Clear();
            CB_conceptoGral.Text = "";
            string tipo_gasto = CB_tipo_gasto.SelectedItem.ToString();
            string query = "";
            MySqlConnection con = BDConexicon.conectar();
            if (tipo_gasto.Equals("TIENDA"))
            {
                query = "select descripcion from rd_conceptos_grales where tipo_concepto='TIENDA'";
              
                MySqlCommand cmd = new MySqlCommand(query,con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_conceptoGral.Items.Add(dr["descripcion"].ToString());
                }
                dr.Close();
                con.Close();
            }

            if (tipo_gasto.Equals("GENERAL"))
            {
                query = "select descripcion from rd_conceptos_grales where tipo_concepto='GENERAL'";
               
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_conceptoGral.Items.Add(dr["descripcion"].ToString());
                }
                dr.Close();
                con.Close();
            }
        }
    }
}
