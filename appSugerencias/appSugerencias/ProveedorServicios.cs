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
    public partial class ProveedorServicios : Form
    {

        string usuario = "";

        public ProveedorServicios(string usuario)
        {
            InitializeComponent();
            this.usuario = "";
        }


        public void Limpiar()
        {
            TB_id.Text = "";
            TB_nombre.Text = "";
            //TB_cuenta.Text = "";
            //CB_banco.SelectedIndex = -1;
            TB_rfc.Text = "";
            //TB_beneficiario.Text = "";
            DG_tabla.Rows.Clear();
        }

        public void Bancos()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select banco from rd_bancos order by banco";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_banco.Items.Add(dr["banco"]);
            }

            dr.Close();
            conexion.Close();
        }


        public void Proveedores()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT nombre FROM rd_proveedor_servicios";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_proveedor.Items.Add(dr["nombre"].ToString());
            }
            dr.Close();
            conexion.Close();
        }
        private void ProveedorServicios_Load(object sender, EventArgs e)
        {

            CB_banco.Items.Add("");
            DG_tabla.Columns["NOMBRE"].Width = 250;
           
           
            DG_tabla.Columns["RFC"].Width = 130;
           
            Bancos();
            Proveedores();
        }



        public void RegistroProveedor()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "INSERT INTO rd_proveedor_servicios(nombre,banco,cuenta,rfc,beneficiario,usuario)VALUES(?nombre,?banco,?cuenta,?rfc,?beneficiario,?usuario)";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.Parameters.AddWithValue("?nombre",TB_nombre.Text);
            //cmd.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?banco","");
            //cmd.Parameters.AddWithValue("?cuenta",TB_cuenta.Text);
            cmd.Parameters.AddWithValue("?cuenta","");
            cmd.Parameters.AddWithValue("?rfc", TB_rfc.Text);
            //cmd.Parameters.AddWithValue("?beneficiario", TB_beneficiario.Text);
            cmd.Parameters.AddWithValue("?beneficiario","");
            cmd.Parameters.AddWithValue("?usuario",usuario);
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("EL proveedor se ha registrado");
        }

        public void RegistrarCuentaBancaria()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "INSERT INTO rd_cuentas_prov_serv(proveedor,banco,cuenta,beneficiario) VALUES(?proveedor,?banco,?cuenta,?beneficiario)";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.Parameters.AddWithValue("proveedor",TB_proveedor.Text);
            cmd.Parameters.AddWithValue("banco", CB_banco.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("cuenta", TB_cuenta.Text);
            cmd.Parameters.AddWithValue("beneficiario",TB_beneficiario.Text);
            cmd.ExecuteNonQuery();

            CB_banco.SelectedIndex = -1;
            TB_cuenta.Text = "";
            TB_beneficiario.Text = "";
            MessageBox.Show("Se ha registrado la cuenta bancaria para el proveedor "+CB_proveedor.SelectedItem.ToString()+"");
        }

        private void BT_agregar_Click(object sender, EventArgs e)
        {

            if (TB_nombre.Text.Equals("")||TB_rfc.Text.Equals(""))
            {
                MessageBox.Show("Debes capturar todos los datos del proveedor para poder registrarlo");
            }
            else
            {
                RegistroProveedor();
            }

            
        }


        public void BuscarProveedor()
        {

            DG_tabla.Rows.Clear();
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT idprov,nombre,rfc FROM rd_proveedor_servicios WHERE nombre like '%" + TB_nombre.Text+ "%'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_tabla.Rows.Add(dr["idprov"].ToString(),dr["nombre"].ToString(), dr["rfc"].ToString());
            }
            dr.Close();
            conexion.Close();
        }


        private void BT_buscar_Click(object sender, EventArgs e)
        {
            BuscarProveedor();
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_id.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["ID"].Value);
            TB_nombre.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["NOMBRE"].Value);
            //CB_banco.SelectedItem =  Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["BANCO"].Value);
            //TB_cuenta.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["CUENTA"].Value);
            //TB_beneficiario.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["BENEFICIARIO"].Value);
            TB_rfc.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["RFC"].Value);
        }


        public void ModificarProveedor()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "UPDATE rd_proveedor_servicios SET nombre='"+TB_nombre.Text+"', rfc='"+TB_rfc.Text+"' WHERE idprov='"+TB_id.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("El registro se ha actualizado");
        }


        private void BT_modificar_Click(object sender, EventArgs e)
        {
            ModificarProveedor();
        }

        public void EliminarProveedor()
        {

            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "DELETE FROM rd_proveedor_servicios WHERE idprov='"+TB_id.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("Se ha eliminado el proveedor");
        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TB_cuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_cuenta_Click(object sender, EventArgs e)
        {
            RegistrarCuentaBancaria();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT idprov FROM rd_proveedor_servicios WHERE nombre='"+CB_proveedor.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                TB_proveedor.Text = dr["idprov"].ToString();
            }
            dr.Close();
            conexion.Close();
        }


        public void BuscarCuenta()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT id,proveedor,banco,cuenta,beneficiario FROM rd_cuentas_prov_serv WHERE cuenta like '%"+TB_cuenta.Text+"%'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_cuentas.Rows.Add(dr["id"].ToString(),dr["proveedor"].ToString(),dr["banco"].ToString(),dr["cuenta"].ToString(),dr["beneficiario"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void BT_buscar_cuenta_Click(object sender, EventArgs e)
        {
            BuscarCuenta();
        }

        private void DG_cuentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells["IDREG"].Value);
            string proveedor = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells["PROVEEDOR"].Value);
            string banco = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells["BANCO"].Value);
            string cuenta = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells["CUENTA"].Value);
            string beneficiario = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells["BENEFICIARIO"].Value);

            TB_idreg.Text = id;
            TB_proveedor.Text = proveedor;
            CB_banco.SelectedItem = banco;
            TB_cuenta.Text = cuenta;
            TB_beneficiario.Text = beneficiario;
        }


        public void ModificarCuenta()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "UPDATE rd_cuentas_prov_serv SET proveedor=?proveedor, banco=?banco,cuenta=?cuenta,beneficiario=?beneficiario WHERE id='"+TB_idreg.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.Parameters.AddWithValue("?proveedor",TB_proveedor.Text);
            cmd.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("?cuenta", TB_cuenta.Text);
            cmd.Parameters.AddWithValue("?beneficiario", TB_beneficiario.Text);
            cmd.ExecuteNonQuery();
            TB_idreg.Text = "";
            TB_proveedor.Text = "";
            CB_banco.SelectedIndex = -1;
            TB_cuenta.Text = "";
            TB_beneficiario.Text = "";
            DG_cuentas.Rows.Clear();
            MessageBox.Show("Registro de cuenta bancaria "+TB_cuenta.Text+ "modificado");
            

        }
        private void BT_modificar_cuenta_Click(object sender, EventArgs e)
        {
            ModificarCuenta();
        }

        public void EliminarCuenta()
        {

            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "DELETE FROM rd_cuentas_prov_serv WHERE id='"+TB_idreg.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            TB_idreg.Text = "";
            TB_proveedor.Text = "";
            CB_banco.SelectedIndex = -1;
            TB_cuenta.Text = "";
            TB_beneficiario.Text = "";
            DG_cuentas.Rows.Clear();
            MessageBox.Show("Se eliminó la cuenta bancaria " + TB_cuenta.Text +"");
        }

        private void BT_eliminar_cuenta_Click(object sender, EventArgs e)
        {
            EliminarCuenta();
        }
    }
}
