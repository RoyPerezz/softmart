using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class frm_CreaGastosExterno : Form
    {
        public frm_CreaGastosExterno()
        {
            InitializeComponent();
        }

        string tipo_gasto = "";
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbGastos.CharacterCasing = CharacterCasing.Upper;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {

                if (RB_tienda.Checked==true)
                {
                    tipo_gasto = "TIENDA";
                }

                if (RB_general.Checked==true)
                {
                    tipo_gasto = "GENERAL";
                }

                GastoExterno ge = new GastoExterno()
                {
                    Nombre_Gasto = tbGastos.Text,
                    Concepto_gral = CB_concepto_gral.SelectedItem.ToString(),
                    Tipo_gasto_ex = tipo_gasto
                };

                GastoExternoController.CrearGastoExterno(ge);
                MessageBox.Show("Datos Guardados con Exito");
                dgvGastos.Rows.Clear();
                consultaGastos();
                tbGastos.Text = "";
            }catch(Exception er)
            {
                MessageBox.Show("Error"+er.Message);
            }


        }

        public void consultaGastos()
        {
            try
            {
                MySqlConnection con = BDConexicon.BodegaOpen();

                //string cadena = definemes(cbMeses.SelectedValue.ToString(), cbYear.Text);

                string comando;
                comando = "";
                
             
                    comando = "SELECT * from rd_gastos_externos order by id_gasto desc ";
                

                MySqlCommand cmd = new MySqlCommand(comando, con);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();



                adaptador.Fill(dt);

                dgvGastos.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvGastos.Rows.Add();

                    dgvGastos.Rows[n].Cells[0].Value = item["id_gasto"].ToString();
                    dgvGastos.Rows[n].Cells[1].Value = item["nombre_gasto"].ToString();
                    dgvGastos.Rows[n].Cells[2].Value = item["concepto_gral"].ToString();
                    dgvGastos.Rows[n].Cells[3].Value = item["tipo_gasto_ex"].ToString();

                }


                //exportaGastos();

                //dgvGastos.Rows.Clear();


            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e.Message);
            }
        }




        private void frm_CreaGastosExterno_Load(object sender, EventArgs e)
        {
            consultaGastos();
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

        private void CB_concepto_gral_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvGastos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            GastoExterno ge = new GastoExterno()
            {
                Id = Convert.ToInt32(dgvGastos.Rows[e.RowIndex].Cells[0].Value.ToString()),
                Nombre_Gasto = dgvGastos.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Concepto_gral = dgvGastos.Rows[e.RowIndex].Cells[2].Value.ToString(),
                Tipo_gasto_ex = dgvGastos.Rows[e.RowIndex].Cells[3].Value.ToString()

            };

            frm_ModificarConceptoGastoExterno modificarGEX = new frm_ModificarConceptoGastoExterno(ge);
            modificarGEX.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultaGastos();
        }
    }
}
