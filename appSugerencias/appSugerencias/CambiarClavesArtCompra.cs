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
    public partial class CambiarClavesArtCompra : Form
    {
        public DataTable articulos = new DataTable();
        string compra = "",sucursal="";
        string usuario = "";

        public CambiarClavesArtCompra(string usuario,DataTable _articulos,string _compra,string _sucursal)
        {
            articulos.Columns.Add("ARTICULO", typeof(string));
            articulos.Columns.Add("DESCRIPCION", typeof(string));
            articulos = _articulos;
            compra = _compra;
            sucursal = _sucursal;
            this.usuario = usuario;
            InitializeComponent();
          
        }


       
        private void CambiarClavesArtCompra_Load(object sender, EventArgs e)
        {
            DG_articulos.Columns["CLAVE"].Width = 90;
            DG_articulos.Columns["DESCRIPCION"].Width = 250;
            DG_cambioClave.Columns["ARTICULO"].Width = 90;
            DG_cambioClave.Columns["DESCRIP"].Width = 250;
            TB_compra.Text = compra;
           

            for (int i = 0; i < articulos.Rows.Count; i++)
            {
                DG_articulos.Rows.Add(articulos.Rows[i][0], articulos.Rows[i][1]);
            }
        }

        private void DG_articulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string clave = "", descrip = "";

            clave = Convert.ToString(DG_articulos.Rows[e.RowIndex].Cells[0].Value);
            descrip = Convert.ToString(DG_articulos.Rows[e.RowIndex].Cells[1].Value);

            DG_cambioClave.Rows.Add(clave,descrip,"");
        }


        private void BT_actualizar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("CLAVE_INICIAL",typeof(string));
            dt.Columns.Add("CAMBIO_CLAVE", typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));



            MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = null;
            string query = "";
            for (int i = 0; i < DG_cambioClave.Rows.Count; i++)
            {
                dt.Rows.Add(DG_cambioClave.Rows[i].Cells[0].Value.ToString(), DG_cambioClave.Rows[i].Cells[2].Value.ToString(), DG_cambioClave.Rows[i].Cells[1].Value.ToString());
                query = "UPDATE partcomp SET ARTICULO ='"+Convert.ToString(DG_cambioClave.Rows[i].Cells[2].Value) +"' WHERE ARTICULO='"+ Convert.ToString(DG_cambioClave.Rows[i].Cells[0].Value) + "' AND COMPRA='"+TB_compra.Text+"'";
                cmd = new MySqlCommand(query,conexion);
                cmd.ExecuteNonQuery();
            }
            conexion.Close();
            Auditoria.Aditoria_cambio_clave_devolucion(usuario,TB_compra.Text,dt);//auditoria
            MessageBox.Show("Se han actualizado las claves de productos de la compra "+TB_compra.Text);
        }
    }
}
