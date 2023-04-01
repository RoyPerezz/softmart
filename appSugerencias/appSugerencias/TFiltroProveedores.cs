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
    public partial class TFiltroProveedores : Form
    {

        string nombre = "";
        string proveedor = "";
        public TFiltroProveedores(string nombre)
        {
            this.nombre = nombre;
            InitializeComponent();
        }

        public void ObtenerProveedores()
        {
            string query = "SELECT proveedor,nombre FROM proveed WHERE nombre like '%"+nombre+"%'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_tabla.Rows.Add(dr["proveedor"].ToString(),dr["nombre"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void DG_tabla_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void DG_tabla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void TFiltroProveedores_Load(object sender, EventArgs e)
        {
            DG_tabla.Columns["NOMBRE"].Width = 300;
            ObtenerProveedores();
        }

        private void DG_tabla_KeyDown_1(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    CuentasXPagar filtro = Owner as CuentasXPagar;
                    //filtro.TB_filtro.Text = proveedor;
                filtro.CB_proveedor.SelectedItem = proveedor;
                filtro.CB_proveedor.Focus();
                    this.Close();
                }
            
        }

        private void DG_tabla_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                proveedor = DG_tabla.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }
    }
}
