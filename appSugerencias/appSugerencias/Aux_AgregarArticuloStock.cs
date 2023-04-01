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
    public partial class Aux_AgregarArticuloStock : Form
    {
        // ESTE FORM ES UN FORM AXULIAR DEL MODULO STOCKORDENCOMPRA SIRVE PARA SELECCIONAR UN ARTICULO DE UNA LISTA Y MANDARLO AL MODULO STOCKORDENCOMPRA
        string clave = "";
        string articulo = "";
        public Aux_AgregarArticuloStock(string _clave)
        {
            InitializeComponent();
            clave = _clave;
        }

        private void Aux_AgregarArticuloStock_Load(object sender, EventArgs e)
        {
            DG_tabla.Columns["DESCRIPCION"].Width = 250;

            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT articulo,descrip FROM prods where articulo like'%"+clave+"%'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_tabla.Rows.Add(dr["articulo"].ToString(),dr["descrip"].ToString());
            }

            dr.Close();
            conexion.Close();
        }

       
        private void DG_tabla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StockOrdenCompra stock = Owner as StockOrdenCompra;
                stock.TB_articulo.Text = articulo;
                this.Close();
            }
        }


        private void DG_tabla_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            // articulo = DG_tabla.CurrentRow.Cells[0].Value.ToString();
        }

        private void DG_tabla_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                articulo = DG_tabla.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            catch (Exception ex)

            {

              
            }
            
        }
    }
}
