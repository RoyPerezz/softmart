using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class frm_modificaTicket : Form
    {
        MySqlConnection conex;
#pragma warning disable CS0169 // El campo 'frm_modificaTicket.importeNuevo' nunca se usa
        string Usuario, importeAnterior, importeNuevo;
#pragma warning restore CS0169 // El campo 'frm_modificaTicket.importeNuevo' nunca se usa
       
        public frm_modificaTicket(string usuario)
        {
            InitializeComponent();
            Usuario = usuario;
        }

        public void limpiar()
        {
            dgvTicket.Rows.Clear();
            lblVenta.Text = "";
            tbTicket.Text = "";
            tbTipo.Text = "";
            tbGuardarImporte.Text = "";
            tbCaja.Text = "";
        }
        //##################################  ###########################################
        public void tiendaImporte(string tienda)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente desea Cambiar el importe seleccionado", "Modificar Importe", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion == DialogResult.OK)
            {
                if (tienda == "BODEGA")
                {
                    conex = BDConexicon.BodegaOpen();
                    actualizar();
                    conex.Close();
                }
                else if (tienda == "VALLARTA")
                {
                    conex = BDConexicon.VallartaOpen();
                    actualizar();
                    conex.Close();
                }
                else if (tienda == "RENA")
                {
                    conex = BDConexicon.RenaOpen();
                    actualizar();
                    conex.Close();
                }
                else if (tienda == "VELAZQUEZ")
                {
                    conex = BDConexicon.VelazquezOpen();
                    actualizar();
                    conex.Close();
                }
                else if (tienda == "COLOSO")
                {
                    conex = BDConexicon.ColosoOpen();
                    actualizar();
                    conex.Close();
                }
                else if (tienda == "PREGOT")
                {
                    conex = BDConexicon.Papeleria1Open();
                    actualizar();
                    conex.Close();
                }

                lblVenta.Text = "";
                tbTicket.Text = "";
                tbTipo.Text = "";
                tbGuardarImporte.Text = "";
                tbCaja.Text = "";


            }

            


        }
        //########## CIERRE ############

        //##################################  ###########################################
        public void tiendaConsulta(string tienda)
        {
            if (tienda == "BODEGA")
            {
                conex = BDConexicon.BodegaOpen();
                consultaCajas();
                conex.Close();
            }
            else if (tienda == "VALLARTA")
            {
                conex = BDConexicon.VallartaOpen();
                consultaCajas();
                conex.Close();
            }
            else if (tienda == "RENA")
            {
                conex = BDConexicon.RenaOpen();
                consultaCajas();
                conex.Close();
            }
            else if (tienda == "VELAZQUEZ")
            {
                conex = BDConexicon.VelazquezOpen();
                consultaCajas();
                conex.Close();
            }
            else if (tienda == "COLOSO")
            {
                conex = BDConexicon.ColosoOpen();
                consultaCajas();
                conex.Close();
            }
            else if (tienda == "PREGOT")
            {
                conex = BDConexicon.Papeleria1Open();
                consultaCajas();
                conex.Close();
            }


        }
        //########## CIERRE ############

        //##################################  ###########################################
        public void tiendaConsultaImporte(string tienda)
        {
            if (tienda == "BODEGA")
            {
                conex = BDConexicon.BodegaOpen();
                consultaImporte();
                conex.Close();
            }
            else if (tienda == "VALLARTA")
            {
                conex = BDConexicon.VallartaOpen();
                consultaImporte();
                conex.Close();
            }
            else if (tienda == "RENA")
            {
                conex = BDConexicon.RenaOpen();
                consultaImporte();
                conex.Close();
            }
            else if (tienda == "VELAZQUEZ")
            {
                conex = BDConexicon.VelazquezOpen();
                consultaImporte();
                conex.Close();
            }
            else if (tienda == "COLOSO")
            {
                conex = BDConexicon.ColosoOpen();
                consultaImporte();
                conex.Close();
            }
            else if (tienda == "PREGOT")
            {
                conex = BDConexicon.Papeleria1Open();
                consultaImporte();
                conex.Close();
            }


        }
        //########## CIERRE ############

        private void frm_modificaTicket_Load(object sender, EventArgs e)
        {
            ComboBoxRellenaOsmart.rellenaSucursal(BDConexicon.conectar(), cbSucursal);
        }

        public void consultaImporte()
        {
#pragma warning disable CS0219 // La variable 'importe' está asignada pero su valor nunca se usa
            double importe;
#pragma warning restore CS0219 // La variable 'importe' está asignada pero su valor nunca se usa
            string comando;
            comando = "SELECT flujo.FLUJO,ventas.NO_REFEREN,flujo.IMPORTE, flujo.FECHA,flujo.HORA,flujo.ESTACION,flujo.concepto2,flujo.ING_EG FROM flujo INNER JOIN ventas ON flujo.Venta=ventas.VENTA WHERE  flujo.Corte='0' AND flujo.IMPORTE='" + tbImporte.Text + "' ORDER BY NO_REFEREN ASC";
            MySqlCommand cmd = new MySqlCommand(comando, conex);
            //MessageBox.Show(comando);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            //lblConexion.Text = "Conectado";
            //lblConexion.ForeColor = Color.DarkGreen;

            adaptador.Fill(dt);

            dgvTicket.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                importe = 0;
                int n = dgvTicket.Rows.Add();
                //importe = Convert.ToDouble(item["IMPORTE"].ToString());
                dgvTicket.Rows[n].Cells[0].Value = item["FLUJO"].ToString();
                dgvTicket.Rows[n].Cells[1].Value = item["NO_REFEREN"].ToString();
                //dgvTicket.Rows[n].Cells[2].Value = importe.ToString("C");
                dgvTicket.Rows[n].Cells[2].Value = item["IMPORTE"].ToString();
                dgvTicket.Rows[n].Cells[3].Value = item["ING_EG"].ToString();
                dgvTicket.Rows[n].Cells[4].Value = item["concepto2"].ToString();
                dgvTicket.Rows[n].Cells[5].Value = item["HORA"].ToString();
                dgvTicket.Rows[n].Cells[6].Value = item["ESTACION"].ToString();
                dgvTicket.Rows[n].Cells[7].Value = item["FECHA"].ToString();


            }


        }

        public void consultaCajas()
        {
#pragma warning disable CS0219 // La variable 'importe' está asignada pero su valor nunca se usa
            double importe;
#pragma warning restore CS0219 // La variable 'importe' está asignada pero su valor nunca se usa
            string comando;
            comando = "SELECT flujo.FLUJO,ventas.NO_REFEREN,flujo.IMPORTE, flujo.FECHA,flujo.HORA, flujo.ESTACION, flujo.concepto2,flujo.ING_EG FROM flujo INNER JOIN ventas ON flujo.Venta=ventas.VENTA WHERE  flujo.Corte='0' AND flujo.ESTACION='" + cbCaja.Text + "' ORDER BY NO_REFEREN ASC";
            MySqlCommand cmd = new MySqlCommand(comando, conex);
           //MessageBox.Show(comando);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            //lblConexion.Text = "Conectado";
            //lblConexion.ForeColor = Color.DarkGreen;

            adaptador.Fill(dt);

            dgvTicket.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                importe = 0;
                int n = dgvTicket.Rows.Add();
                //importe = Convert.ToDouble(item["IMPORTE"].ToString());
                dgvTicket.Rows[n].Cells[0].Value = item["FLUJO"].ToString();
                dgvTicket.Rows[n].Cells[1].Value = item["NO_REFEREN"].ToString();
                //dgvTicket.Rows[n].Cells[2].Value = importe.ToString("C");
                dgvTicket.Rows[n].Cells[2].Value = item["IMPORTE"].ToString();
                dgvTicket.Rows[n].Cells[3].Value = item["ING_EG"].ToString();
                dgvTicket.Rows[n].Cells[4].Value = item["concepto2"].ToString();
                dgvTicket.Rows[n].Cells[5].Value = item["HORA"].ToString();
                dgvTicket.Rows[n].Cells[6].Value = item["ESTACION"].ToString();
                dgvTicket.Rows[n].Cells[7].Value = item["FECHA"].ToString();


            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                tiendaConsulta(cbSucursal.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                tiendaConsultaImporte(cbSucursal.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void dgvTicket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            importeAnterior= dgvTicket.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblVenta.Text= dgvTicket.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbTicket.Text=dgvTicket.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbTipo.Text=dgvTicket.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbGuardarImporte.Text= dgvTicket.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbCaja.Text= dgvTicket.Rows[e.RowIndex].Cells[6].Value.ToString();
           
        }

        private void cbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiar();
        }

        public void actualizar()
        {
          
            MySqlCommand cmdR = new MySqlCommand("UPDATE flujo SET IMPORTE=?IMPORTE WHERE FLUJO=?FLUJO", conex);
            cmdR.Parameters.Add("?IMPORTE", MySqlDbType.VarChar).Value = tbGuardarImporte.Text;
            cmdR.Parameters.Add("?FLUJO", MySqlDbType.VarChar).Value =lblVenta.Text;
            cmdR.ExecuteNonQuery();
            

            MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_eventos (modulo,fecha,mensaje) VALUES ('frm_modificaTicket',?fecha,?mensaje)", conex);
            cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = DateTime.Now.ToString("dd-MM-yyyy");
            cmd.Parameters.Add("?mensaje", MySqlDbType.VarChar).Value ="VENTA: "+lblVenta.Text+" SE MODIFICA IMPORTE ANTERIOR: $"+importeAnterior+" POR NUEVO: $"+tbGuardarImporte.Text+" | MODIFICADO POR USUARIO: "+Usuario;
            cmd.ExecuteNonQuery();


        }
        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                tiendaImporte(cbSucursal.Text);

            }
            catch(Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }
    }
}
