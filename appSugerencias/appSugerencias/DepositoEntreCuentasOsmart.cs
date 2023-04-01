using MySql.Data.MySqlClient;
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
    public partial class DepositoEntreCuentasOsmart : Form
    {

        string fecha = "", cliente = "",banco="",cuenta="",tienda="",suc_pago,mov="";
        double deposito = 0;
        public DepositoEntreCuentasOsmart(string fecha, string cliente, double deposito,string banco,string cuenta,string tienda,string suc_pago,string mov)
        {
            this.fecha = fecha;
            this.cliente = cliente;
            this.deposito = deposito;
            this.banco = banco;
            this.cuenta = cuenta;
            this.tienda = tienda;
            this.suc_pago = suc_pago;
            this.mov = mov;
            InitializeComponent();
        }


        
        MySqlConnection con = null;



        public void depositarAotraCuenta()
        {
            DateTime fecha = Convert.ToDateTime(TB_fecha.Text);
            double cantidad = Convert.ToDouble(TB_deposito.Text);
            //string query = "UPDATE rd_historial_saldobancos SET banco='"+CB_banco.SelectedItem.ToString()+"', cuenta='"+ TB_cuenta_destino.Text+"',pagara='"+CB_cliente_bancario.SelectedItem.ToString()+"'" +
            //    "WHERE banco='"+TB_banco_origen.Text+"' and cuenta='"+TB_cuenta_origen.Text+ "' and pagara='" + TB_cliente_origen.Text+ "' and cantidad="+cantidad+" and fecha='" + fecha.ToString("yyyy-MM-dd")+"'";

            string query = "INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ref_gastoexterno,suc_pago)" +
                "VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ref_gastoexterno,?suc_pago)";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?tienda",tienda);
            cmd.Parameters.AddWithValue("?mov", "AJ");
            cmd.Parameters.AddWithValue("?ie", "E");
            cmd.Parameters.AddWithValue("?banco",TB_banco_origen.Text);
            cmd.Parameters.AddWithValue("?cuenta", TB_cuenta_origen.Text);
            cmd.Parameters.AddWithValue("?pagara", TB_cliente_origen.Text);
            cmd.Parameters.AddWithValue("?cantidad", TB_deposito.Text);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:MM:SS"));
            cmd.Parameters.AddWithValue("?fk_gastoexterno", "0");
            cmd.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
            cmd.Parameters.AddWithValue("?suc_pago", "");
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand(query, con);

            cmd2.Parameters.AddWithValue("?tienda", tienda);
            cmd2.Parameters.AddWithValue("?mov", mov);
            cmd2.Parameters.AddWithValue("?ie", "I");
            cmd2.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?cuenta", TB_cuenta_destino.Text);
            cmd2.Parameters.AddWithValue("?pagara", CB_cliente_bancario.SelectedItem.ToString()); ;
            cmd2.Parameters.AddWithValue("?cantidad", TB_deposito.Text);
            cmd2.Parameters.AddWithValue("?fecha", fecha.ToString("yyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?hora", fecha.ToString("HH:MM:SS"));
            cmd2.Parameters.AddWithValue("?fk_gastoexterno", "0");
            cmd2.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
            cmd2.Parameters.AddWithValue("?suc_pago", "");

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Se ha depositado el dinero");
        }
        private void BT_depositar_Click(object sender, EventArgs e)
        {
            depositarAotraCuenta();
        }

        private void CB_cliente_bancario_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_banco.Items.Clear();
            TB_cuenta_destino.Text = "";
            string query = "select banco from rd_bancos_osmart where clientebancario='"+CB_cliente_bancario.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_banco.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
            CB_banco.SelectedIndex = -1;
            CB_banco.Text = "";
        }

        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_cuenta_destino.Text = "";
            string query = "select cuenta from rd_bancos_osmart where clientebancario='" + CB_cliente_bancario.SelectedItem.ToString() + "' and banco='"+CB_banco.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_cuenta_destino.Text =   dr["cuenta"].ToString();
            }
            dr.Close();
        }

        public void CuentasOsmart()
        {
             con = BDConexicon.BodegaOpen();
            string query = "SELECT distinct clientebancario FROM rd_bancos_osmart";
           
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                CB_cliente_bancario.Items.Add(dr["clientebancario"].ToString());
              
            }
            dr.Close();
            
        }
        private void DepositoEntreCuentasOsmart_Load(object sender, EventArgs e)
        {

            TB_cuenta_origen.Text = cuenta;
            TB_fecha.Text = fecha;
            TB_deposito.Text = deposito.ToString();
            TB_banco_origen.Text = banco;
            TB_cliente_origen.Text = cliente;
            CuentasOsmart();
        }
    }
}
