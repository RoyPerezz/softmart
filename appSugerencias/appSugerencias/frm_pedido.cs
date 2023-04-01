﻿using System;
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
    public partial class frm_pedido : Form
    {
        string usuarioMyB;
        string Area;

        public frm_pedido()
        {
            InitializeComponent();
        }

        public frm_pedido(string usuario,string area)
        {
            InitializeComponent();
            usuarioMyB = usuario;
            Area = area;
        }

        MySqlConnection Conex = BDConexicon.BodegaOpen();


        private void frm_pedido_Load(object sender, EventArgs e)
        {
            dgvPedidos.Columns[3].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            busqueda();
           
        }

        public void prueba()
        {
            string comando = "SELECT * FROM rd_pedido ";
            string comando2 = "";
            string cadena = "";

            if (cbFiltro2.Text.Trim() != "")
            {

                if (cbFiltro.Text == "ESTADO")
                {
                    comando2 = " WHERE estatus LIKE '%" + cbFiltro2.Text + "%'";

                }
                else if (cbFiltro.Text == "PROVEEDOR")
                {
                    comando2 = " WHERE proveedor LIKE '%" + cbFiltro2.Text + "%'";

                }



            }

            cadena = comando + comando2;
            MessageBox.Show(cadena);

        }

        public void busqueda()
        {
            
            string comando = "SELECT id_pedido,titulo_pedido,fecha,periodo,area,proveed.NOMBRE,link_pedido,estatus,cotiz,nota,guia,comprobante_pago,forma_pago,tipo_pago,observaciones FROM rd_pedido INNER JOIN proveed ON rd_pedido.proveedor = proveed.PROVEEDOR";
            // MySqlCommand cmd = new MySqlCommand("SELECT rd_traspaso.idtraspaso,rd_traspaso.estatus FROM rd_pedido   where rd_traspaso.fecha between '" + inicio + "'" + " and '" + fin + "' ", conex_pedido);

            MySqlCommand cmd = new MySqlCommand(comando, Conex);


            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

            //lblConexion.Text = "Conectado";
            //lblConexion.ForeColor = Color.DarkGreen;

            adaptador.Fill(dt);

            dgvPedidos.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvPedidos.Rows.Add();

                dgvPedidos.Rows[n].Cells[0].Value = item["id_pedido"].ToString();
                dgvPedidos.Rows[n].Cells[1].Value = item["titulo_pedido"].ToString();
                dgvPedidos.Rows[n].Cells[2].Value = item["fecha"].ToString();
                dgvPedidos.Rows[n].Cells[3].Value = item["periodo"].ToString();
                dgvPedidos.Rows[n].Cells[4].Value = item["area"].ToString();
                dgvPedidos.Rows[n].Cells[5].Value = item["NOMBRE"].ToString();
                dgvPedidos.Rows[n].Cells[6].Value = item["link_pedido"].ToString();
                dgvPedidos.Rows[n].Cells[7].Value = item["estatus"].ToString();
                dgvPedidos.Rows[n].Cells[8].Value = item["cotiz"].ToString();
                dgvPedidos.Rows[n].Cells[9].Value = item["nota"].ToString();
                dgvPedidos.Rows[n].Cells[10].Value = item["guia"].ToString();
                dgvPedidos.Rows[n].Cells[11].Value = item["comprobante_pago"].ToString();
                dgvPedidos.Rows[n].Cells[12].Value = item["forma_pago"].ToString();
                dgvPedidos.Rows[n].Cells[13].Value = item["tipo_pago"].ToString();
                dgvPedidos.Rows[n].Cells[14].Value = item["observaciones"].ToString();

            }

            Conex.Close();
        }


        public void busquedaFiltros()
        {
            if (cbFiltro.Text != "" )
            {
                string comando = "";

                if (cbFiltro.Text == "ESTADO")
                {
                    comando = "SELECT id_pedido,titulo_pedido,fecha,periodo,area,proveed.NOMBRE,link_pedido,estatus,cotiz,nota,guia,comprobante_pago,forma_pago,tipo_pago,observaciones FROM rd_pedido INNER JOIN proveed ON rd_pedido.proveedor = proveed.PROVEEDOR WHERE estatus='" + cbFiltro2.Text + "'";

                }

                if (cbFiltro.Text == "PROVEEDOR")
                {

                    comando = "SELECT id_pedido,titulo_pedido,fecha,periodo,area,proveed.NOMBRE,link_pedido,estatus,cotiz,nota,guia,comprobante_pago,forma_pago,tipo_pago,observaciones FROM rd_pedido INNER JOIN proveed ON rd_pedido.proveedor = proveed.PROVEEDOR WHERE rd_pedido.proveedor='" + cbFiltro2.SelectedValue.ToString() + "'";


                }


                if (cbFiltro.Text == "AREA")
                {

                    comando = "SELECT id_pedido,titulo_pedido,fecha,periodo,area,proveed.NOMBRE,link_pedido,estatus,cotiz,nota,guia,comprobante_pago,forma_pago,tipo_pago,observaciones FROM rd_pedido INNER JOIN proveed ON rd_pedido.proveedor = proveed.PROVEEDOR WHERE rd_pedido.area='" + cbFiltro2.Text + "'";


                }

                

                
                // string comando = "SELECT id_pedido,titulo_pedido,fecha,periodo,area,proveed.NOMBRE,link_pedido,estatus,cotiz,nota,guia,comprobante_pago,forma_pago,tipo_pago,observaciones FROM rd_pedido INNER JOIN proveed ON rd_pedido.proveedor = proveed.PROVEEDOR";
                // MySqlCommand cmd = new MySqlCommand("SELECT rd_traspaso.idtraspaso,rd_traspaso.estatus FROM rd_pedido   where rd_traspaso.fecha between '" + inicio + "'" + " and '" + fin + "' ", conex_pedido);

                MySqlCommand cmd = new MySqlCommand(comando, Conex);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();

                //lblConexion.Text = "Conectado";
                //lblConexion.ForeColor = Color.DarkGreen;

                adaptador.Fill(dt);

                dgvPedidos.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvPedidos.Rows.Add();

                    dgvPedidos.Rows[n].Cells[0].Value = item["id_pedido"].ToString();
                    dgvPedidos.Rows[n].Cells[1].Value = item["titulo_pedido"].ToString();
                    dgvPedidos.Rows[n].Cells[2].Value = item["fecha"].ToString();
                    dgvPedidos.Rows[n].Cells[3].Value = item["periodo"].ToString();
                    dgvPedidos.Rows[n].Cells[4].Value = item["area"].ToString();
                    dgvPedidos.Rows[n].Cells[5].Value = item["NOMBRE"].ToString();
                    dgvPedidos.Rows[n].Cells[6].Value = item["link_pedido"].ToString();
                    dgvPedidos.Rows[n].Cells[7].Value = item["estatus"].ToString();
                    dgvPedidos.Rows[n].Cells[8].Value = item["cotiz"].ToString();
                    dgvPedidos.Rows[n].Cells[9].Value = item["nota"].ToString();
                    dgvPedidos.Rows[n].Cells[10].Value = item["guia"].ToString();
                    dgvPedidos.Rows[n].Cells[11].Value = item["comprobante_pago"].ToString();
                    dgvPedidos.Rows[n].Cells[12].Value = item["forma_pago"].ToString();
                    dgvPedidos.Rows[n].Cells[13].Value = item["tipo_pago"].ToString();
                    dgvPedidos.Rows[n].Cells[14].Value = item["observaciones"].ToString();

                }

                Conex.Close();
            }
            else
            {
                MessageBox.Show("Seleccione los filtros 1 y 2");
            }
            
        }







        private void button1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_nuevo_pedido);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_nuevo_pedido(usuarioMyB,Area,1, "");
            frm.Show();

        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string idpedido = dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString();

                //VARIABLES.intpedido= Convert.ToInt32( dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
                //VARIABLES.titulo_pedido = dgvPedidos.Rows[e.RowIndex].Cells[1].Value.ToString();

                //VARIABLES.area = dgvPedidos.Rows[e.RowIndex].Cells[4].Value.ToString();
                //VARIABLES.proveedor = dgvPedidos.Rows[e.RowIndex].Cells[5].Value.ToString();
                //VARIABLES.link_pedido = dgvPedidos.Rows[e.RowIndex].Cells[6].Value.ToString();
                //VARIABLES.cotiz = dgvPedidos.Rows[e.RowIndex].Cells[8].Value.ToString();
                //VARIABLES.nota = dgvPedidos.Rows[e.RowIndex].Cells[9].Value.ToString();
                //VARIABLES.guia = dgvPedidos.Rows[e.RowIndex].Cells[10].Value.ToString();
                //VARIABLES.comprobante_pago = dgvPedidos.Rows[e.RowIndex].Cells[11].Value.ToString();
                //VARIABLES.tipo_pago = dgvPedidos.Rows[e.RowIndex].Cells[12].Value.ToString();
                //VARIABLES.forma_pago = dgvPedidos.Rows[e.RowIndex].Cells[13].Value.ToString();
                //VARIABLES.observaciones = dgvPedidos.Rows[e.RowIndex].Cells[14].Value.ToString();



                frm_nuevo_pedido hijo = new frm_nuevo_pedido(usuarioMyB,Area,2, idpedido);
                hijo.Show(this);
                // MessageBox.Show(idpedido.ToString());
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxArea.Checked == true)
            {
                dgvPedidos.Columns[4].Visible = false;
            }
            else if (cBoxArea.Checked == false)
            {
                dgvPedidos.Columns[4].Visible = true;
            }

        }

        private void cbFiltro_TextChanged(object sender, EventArgs e)
        {
            

            if (cbFiltro.Text == "ESTADO")
            {
                //cbFiltro2.Text = "1";
                llenaComboBoxEstado();
            }
            else if (cbFiltro.Text == "PROVEEDOR")
            {

                llenaComboProveedor();

            }

            else if (cbFiltro.Text == "AREA")
            {

                llenaComboArea();

            }

            Conex.Close();
        }

        public void llenaComboArea()
        {
            cbFiltro2.DataSource = null;
            

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_pedido_area", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbFiltro2.ValueMember = "idarea";
            cbFiltro2.DisplayMember = "area";
            cbFiltro2.DataSource = dt1;
            Conex.Close();
        }

        public void llenaComboProveedor()
        {
            cbFiltro2.DataSource = null;

            
            MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE FROM proveed ", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbFiltro2.ValueMember = "PROVEEDOR";
            cbFiltro2.DisplayMember = "NOMBRE";
            cbFiltro2.DataSource = dt1;
            Conex.Close();
        }


        public void llenaComboBoxEstado()
        {
            cbFiltro2.DataSource = null;

            
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_pedido_estado", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            mysqladap.Fill(dt);

            cbFiltro2.ValueMember = "idestado";
            cbFiltro2.DisplayMember = "estado";
            cbFiltro2.DataSource = dt;
            Conex.Close();
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            busquedaFiltros();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_pedido_almacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_pedido_almacen();
            frm.Show();
        }
    }
}
