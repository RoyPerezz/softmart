using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ModificarDatosDev : Form
    {

        string sucursal = "";
        string compra = "";
        string factura = "";
        string observacion = "";

        public ModificarDatosDev(string sucursal,string compra,string factura,string observacion)
        {
            this.sucursal = sucursal;
            this.compra = compra;
            this.factura = factura;
            this.observacion = observacion;
            InitializeComponent();
        }

        public void Proveedores()
        {
            Proveedor prov = new Proveedor();
            ArrayList proveedores = prov.Proveedores();

            foreach (var item in proveedores)
            {
                CB_proveedores.Items.Add(item.ToString());
            }
        }

        private void ModificarDatosDev_Load(object sender, EventArgs e)
        {
            TB_sucursal.Text = sucursal;
            TB_compra.Text = compra;
            TB_factura.Text = factura;
            TB_observacion.Text = observacion;
            Proveedores();
        }

        private void CB_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor();
            string id = prov.IdProveedor(CB_proveedores.SelectedItem.ToString());
            TB_idProv.Text = id;
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.ConexionSucursal(TB_sucursal.Text);
            try
            {
                string compra = "update compras set FACTURA ='" + factura + "', PROVEEDOR='" + TB_idProv.Text + "', OBSERV='" + TB_observacion.Text + "' where COMPRA='" + TB_compra.Text + "'";
                MySqlCommand cmd = new MySqlCommand(compra, conexion);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en tabla compras " +ex);
            }

            try
            {
                string cuenxpag = "update cuenxpag set PROVEEDOR='" + TB_idProv.Text + "', FACTURA='" + TB_factura.Text + "' WHERE COMPRA='" + TB_compra.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(cuenxpag, conexion);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en tabla cuenxpag " + ex);
            }

            try
            {
                string cuenxpdet = "update cuenxpdet set proveedor='" + TB_idProv.Text + "', NO_REFEREN='" + TB_factura.Text + "' WHERE COMPRA='" + TB_compra.Text + "'";
                MySqlCommand cmd3 = new MySqlCommand(cuenxpdet, conexion);
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en tabla cuenxpdet " + ex);

            }

            conexion.Close();
            MessageBox.Show("Se han modificado los datos");

        }
    }
}
