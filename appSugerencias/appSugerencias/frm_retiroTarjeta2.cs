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
    public partial class frm_retiroTarjeta2 : Form
    {
        string Caja;
        public frm_retiroTarjeta2()
        {
            InitializeComponent();
        }
        public frm_retiroTarjeta2(string caja)
        {
            InitializeComponent();
            Caja = caja;
        }
        MySqlConnection conex;

        public void consultar()
        {
            double importe;
            MySqlCommand cmd = new MySqlCommand("SELECT ventas.NO_REFEREN,flujo.IMPORTE, flujo.FECHA,flujo.HORA FROM flujo INNER JOIN ventas ON flujo.Venta=ventas.VENTA WHERE flujo.concepto2='TAR' AND flujo.Corte='0' AND flujo.ESTACION='"+Caja+ "' ORDER BY NO_REFEREN ASC", conex);

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
                importe= Convert.ToDouble( item["IMPORTE"].ToString());
                dgvTicket.Rows[n].Cells[0].Value = item["NO_REFEREN"].ToString();
                dgvTicket.Rows[n].Cells[1].Value = importe.ToString("C"); 
                dgvTicket.Rows[n].Cells[2].Value = item["HORA"].ToString();
                dgvTicket.Rows[n].Cells[3].Value = item["FECHA"].ToString();
                

            }

           
        }

        private void frm_retiroTarjeta2_Load(object sender, EventArgs e)
        {
            try
            {
                conex = BDConexicon.conectar();
                consultar();
                conex.Close();
            }catch(Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvTicket_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ticket;
                ticket = Convert.ToString(dgvTicket.Rows[dgvTicket.CurrentRow.Index].Cells[0].Value);

                InterfaceComunicacion con = this.Owner as InterfaceComunicacion;

                con.SetTicket(ticket);
                this.Close();
            }catch(Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
            

        }
    }
}
