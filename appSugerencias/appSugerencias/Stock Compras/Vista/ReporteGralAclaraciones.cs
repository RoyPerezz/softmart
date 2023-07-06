using appSugerencias.Stock_Compras.Controlador;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Stock_Compras.Vista
{
    public partial class ReporteGralAclaraciones : Form
    {
        public ReporteGralAclaraciones()
        {
            InitializeComponent();
        }

        string proveedor = ""; //almacena el codigo del proveedor seleccionado

        private void ReporteGralAclaraciones_Load(object sender, EventArgs e)
        {
            List<string> lista = StockController.ListaProveedores();

            //for (int i = 0; i < lista.Count; i++)
            //{
                CB_proveedor.DataSource = lista;
            //}

              
            
        }

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_id.Text = StockController.ClaveProveedor(CB_proveedor.Text); //Clave del proveedor
            List<string> stocks = StockController.BuscarStocks(TB_id.Text);
            CB_stock.DataSource = stocks;
          
        }

        private void CB_proveedor_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void CB_proveedor_DisplayMemberChanged(object sender, EventArgs e)
        {
            proveedor = CB_proveedor.SelectedValue.ToString();
            TB_id.Text = proveedor;
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DG_tabla.Rows.Clear();
            string query = "SELECT" +
                "                idreg," +
                "                modelo," +
                "                claveProducto," +
                "                descripcion," +
                "                pzxpaq," +
                "                costoxpaq," +
                "                costoxpz" +
                "          FROM rd_detalle_stock_compra" +
                "          WHERE fk_stock='"+TB_idStock.Text+"'" +
                "          ORDER BY idreg";


            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_tabla.Rows.Add(dr["idreg"].ToString(),dr["modelo"].ToString(),dr["claveProducto"].ToString(),dr["descripcion"].ToString(),dr["pzxpaq"].ToString(),dr["costoxpaq"].ToString(),dr["costoxpz"].ToString(),0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);
            }
            dr.Close();
            con.Close();
        }

        private void CB_stock_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT idreg" +
                "           FROM rd_stock_compra" +
                "           WHERE descripcion='"+CB_stock.Text+"'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_idStock.Text = dr["idreg"].ToString();
            }
            dr.Close();
            con.Close();
        }
    }
}
