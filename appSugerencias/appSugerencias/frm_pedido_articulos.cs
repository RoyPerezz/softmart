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
    public partial class frm_pedido_articulos : Form
    {
        public frm_pedido_articulos()
        {
            InitializeComponent();
        }

        MySqlConnection Conex;
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.ColumnaSurtir' está asignado pero su valor nunca se usa
        int ColumnaSurtir = 6;
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.ColumnaSurtir' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.exisVl' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.exisCo' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.exisVa' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.exisPm' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.exisRe' está asignado pero su valor nunca se usa
        int exisVa = 7, exisRe = 9, exisCo = 11, exisVl = 13, exisPm = 15;
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.exisRe' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.exisPm' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.exisVa' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.exisCo' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.exisVl' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.surteRe' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.surteVl' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.surteCo' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.surtePm' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_pedido_articulos.surteVa' está asignado pero su valor nunca se usa
        int surteVa = 8, surteRe = 10, surteCo = 12, surteVl = 14, surtePm = 16;
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.surteVa' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.surtePm' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.surteCo' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.surteVl' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_pedido_articulos.surteRe' está asignado pero su valor nunca se usa

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            
            if (tbFiltro.Text == "")
            {
                cbProveedor.SelectedIndex = -1;
                //DG_cuentas.DataSource = null;
            }
            else
            {
                int index = cbProveedor.FindString(tbFiltro.Text.ToUpper());
                cbProveedor.SelectedIndex = index;

            }
        }

#pragma warning disable CS0169 // El campo 'frm_pedido_articulos.verificar' nunca se usa
        bool verificar;
#pragma warning restore CS0169 // El campo 'frm_pedido_articulos.verificar' nunca se usa

        private void frm_pedido_articulos_Load(object sender, EventArgs e)
        {
            Conex = BDConexicon.BodegaOpen();
            llenaComboProveedor();
            Conex.Close();

        }

        public void llenaComboProveedor()
        {
            cbProveedor.DataSource = null;



            MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE FROM proveed ", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbProveedor.ValueMember = "PROVEEDOR";
            cbProveedor.DisplayMember = "NOMBRE";
            cbProveedor.DataSource = dt1;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conex = BDConexicon.BodegaOpen();
                busqueda();
                Conex.Close();

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Sin conexion a Bodega");
            }

        }


        public void busqueda()
        {
            string comando = "SELECT ARTICULO,DESCRIP,EXISTENCIA FROM prods WHERE  fabricante='" + cbProveedor.Text.ToString() + "'";

            MySqlCommand cmd = new MySqlCommand(comando, Conex);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();



            adapter.Fill(dt);

            dgvSurtidor.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvSurtidor.Rows.Add();
                dgvSurtidor.Rows[n].Cells[0].Value = n + 1;
                dgvSurtidor.Rows[n].Cells[1].Value = item["ARTICULO"].ToString();
                dgvSurtidor.Rows[n].Cells[2].Value = item["DESCRIP"].ToString();
                dgvSurtidor.Rows[n].Cells[3].Value = item["EXISTENCIA"].ToString();
                //dgvSurtidor.Rows[n].Cells[4].Value = item["Peso"].ToString();
                //if (Convert.ToInt32(item["Peso"].ToString()) == 0)
                //{
                //    dgvSurtidor.Rows[n].Cells[5].Value = "N/A";
                //}
                //else
                //{
                //    dgvSurtidor.Rows[n].Cells[5].Value = Convert.ToDouble(item["EXISTENCIA"].ToString()) / Convert.ToDouble(item["Peso"].ToString());
                //}

            }



        }



    }
}
