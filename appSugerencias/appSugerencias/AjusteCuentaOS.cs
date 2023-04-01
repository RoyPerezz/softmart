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
    public partial class AjusteCuentaOS : Form
    {

        string usuario = "";
        public AjusteCuentaOS(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }






        #region METODOS
        private void AjusteCuentaOS_Load(object sender, EventArgs e)
        {
            Sucursales();
        }

        public void Sucursales()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT descripcion FROM rd_sucursales WHERE activo=1";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_sucursal.Items.Add(dr["descripcion"].ToString());
            }
            dr.Close();
            conexion.Close();

        }

        public void Limpiar()
        {
            CB_sucursal.Text = "";
            CB_banco.Text = "";
            CB_cuenta.Text = "";
            TB_cliente.Text = "";
            TB_importe.Text = "";
            TB_referencia.Text = "";
        }
        public void Aplicar()
        {

            DateTime fecha = DT_fecha.Value;

            string ie = "";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ref_gastoexterno,suc_pago)VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ref_gastoexterno,?suc_pago)";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.Parameters.AddWithValue("?tienda",CB_sucursal.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?mov", "AJUSTE");
            if (RB_ingreso.Checked==true)
            {
                ie = "I";
            }

            if (RB_egreso.Checked==true)
            {
                ie = "E";
            }
            cmd.Parameters.AddWithValue("?ie",ie);

            cmd.Parameters.AddWithValue("?banco",CB_banco.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?pagara", TB_cliente.Text);
            cmd.Parameters.AddWithValue("?cantidad", TB_importe.Text);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:MM:SS"));
            cmd.Parameters.AddWithValue("?fk_gastoexterno", 0);
            cmd.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
            cmd.Parameters.AddWithValue("?suc_pago", "");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha aplicado el ajuste correctamente");

            string movimiento = "";
            if (RB_ingreso.Checked==true)
            {
                movimiento = "I";
            }

            if (RB_egreso.Checked == true)
            {
                movimiento = "E";
            }


            Auditoria.Auditoria_AjusteCuentasOS(usuario, fecha.ToString("yyyy-MM-dd"), CB_sucursal.SelectedItem.ToString(), CB_banco.SelectedItem.ToString(),CB_cuenta.SelectedItem.ToString(),TB_cliente.Text,Convert.ToDouble(TB_importe.Text),movimiento,TB_referencia.Text);
            Limpiar();

        }
        #endregion


        #region EVENTOS
        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_banco.Items.Clear();
            CB_banco.Text = "";
            CB_cuenta.Items.Clear();
            CB_cuenta.Text = "";
            TB_cliente.Text = "";

            string sucursal = CB_sucursal.SelectedItem.ToString();

            if (sucursal.Equals("CEDIS"))
            {
                sucursal = "BODEGA";
            }
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT distinct banco FROM rd_bancos_osmart WHERE tienda ='"+sucursal+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_banco.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
            conexion.Close();
        }
        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_cuenta.Items.Clear();
            CB_cuenta.Text = "";
            TB_cliente.Text = "";


            string sucursal = CB_sucursal.SelectedItem.ToString();

            if (sucursal.Equals("CEDIS"))
            {
                sucursal = "BODEGA";
            }
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT distinct cuenta FROM rd_bancos_osmart WHERE tienda ='" + sucursal + "' and banco ='"+CB_banco.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_cuenta.Items.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void CB_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_cliente.Text = "";
            string sucursal = CB_sucursal.SelectedItem.ToString();

            if (sucursal.Equals("CEDIS"))
            {
                sucursal = "BODEGA";
            }
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT distinct clientebancario FROM rd_bancos_osmart WHERE tienda ='" + sucursal + "' and banco ='" + CB_banco.SelectedItem.ToString() + "' and cuenta='"+CB_cuenta.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_cliente.Text = dr["clientebancario"].ToString();
            }
            dr.Close();
            conexion.Close();
        }


        #endregion


        #region BOTONES
        private void BT_aplicar_Click(object sender, EventArgs e)
        {

            if (CB_sucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona la sucursal");
            }
            else if (CB_banco.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona el banco");
            }
            else if (CB_cuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona la cuenta");

            }

            else if (RB_ingreso.Checked == false && RB_egreso.Checked == false)
            {
                MessageBox.Show("Selecciona si el ajuste es un ingreso o un egreso");
            }
            else if (TB_cliente.Text.Equals(""))
            {
                MessageBox.Show("La cuenta bancaria debe incluir un cliente bancario");
            }
          
            else if (TB_importe.Text.Equals(""))
            {
                MessageBox.Show("Captura el importe del ajuste");
            }
            else if (TB_referencia.Text.Equals(""))
            {
                MessageBox.Show("Captura una referencia para el ajuste");
            }
            else
            {
                Aplicar();
            }

           
        }
        #endregion

        
    }


}
