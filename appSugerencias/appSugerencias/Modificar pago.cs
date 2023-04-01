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
    public partial class Modificar_pago : Form
    {
        public Modificar_pago()
        {
            InitializeComponent();
        }

        string proveedor = "";
        int registro = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CB_proveedores.Items.Clear();
            CB_proveedores.Text = "";
            if (RB_prov_merc.Checked)
            {
                Limpiar();
                try
                {
                    MySqlConnection conexion = BDConexicon.BodegaOpen();
                    string query = "SELECT nombre FROM proveed order by nombre";
                    MySqlCommand cmd = new MySqlCommand(query,conexion);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CB_proveedores.Items.Add(dr["nombre"].ToString());
                    }
                    dr.Close();
                    conexion.Close();
                }

                catch (Exception ex)

                {

                    
                }
                
            }
        }

        private void RB_prov_serv_CheckedChanged(object sender, EventArgs e)
        {
            CB_proveedores.Items.Clear();
            CB_proveedores.Text = "";
            if (RB_prov_serv.Checked)
            {
                Limpiar();
                try
                {
                    MySqlConnection conexion = BDConexicon.BodegaOpen();
                    string query = "SELECT nombre FROM rd_proveedor_servicios";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CB_proveedores.Items.Add(dr["nombre"].ToString());
                    }
                    dr.Close();
                    conexion.Close();
                }

                catch (Exception ex)

                {


                }

            }
        }

        public void ObtenerClaveProveedor()
        {
            if (RB_prov_merc.Checked)
            {


                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT proveedor FROM proveed WHERE nombre='" + CB_proveedores.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    proveedor = Convert.ToString(dr["proveedor"].ToString());
                }
                dr.Close();
                conexion.Close();
            }


            if (RB_prov_serv.Checked)
            {


                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT idprov FROM rd_proveedor_servicios WHERE nombre='" + CB_proveedores.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    proveedor = Convert.ToString(dr["idprov"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
        }

        private void CB_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            //if (RB_prov_merc.Checked)
            //{
                
               
            //    MySqlConnection conexion = BDConexicon.BodegaOpen();
            //    string query = "SELECT proveedor FROM proveed WHERE nombre='"+CB_proveedores.Text+"'";
            //    MySqlCommand cmd = new MySqlCommand(query, conexion);
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        proveedor = Convert.ToString(dr["proveedor"].ToString());
            //    }
            //    dr.Close();
            //    conexion.Close();
            //}


            //if (RB_prov_serv.Checked)
            //{
               
              
            //    MySqlConnection conexion = BDConexicon.BodegaOpen();
            //    string query = "SELECT idprov FROM rd_proveedor_servicios WHERE nombre='" + CB_proveedores.Text + "'";
            //    MySqlCommand cmd = new MySqlCommand(query, conexion);
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        proveedor = Convert.ToString(dr["idprov"].ToString());
            //    }
            //    dr.Close();
            //    conexion.Close();
            //}
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            //CB_proveedores.Items.Clear();
            DG_tabla.Rows.Clear();
            TB_fecha_prog.Text = "";
            TB_fecha_venc.Text = "";
            TB_sucursal.Text ="";
            TB_rfc.Text ="";
            TB_compra.Text = "";
            TB_enlace.Text = "";
            TB_banco.Text = "";
            TB_cuenta.Text ="";
            TB_cliente.Text ="";
            TB_tipo.Text = "";
            TB_patron.Text = "";
            TB_importe.Text = "";
            TB_concepto.Text = "";
            TB_factura.Text = "";
            TB_registro.Text = "";
            TB_iva.Text = "";
            proveedor = "";
            registro = 0;
            //CB_proveedores.Items.Insert(0, "");
            //CB_proveedores.SelectedIndex = 0;

        }
    

        public void BuscarPago()
        {
            ObtenerClaveProveedor();
            DG_tabla.Rows.Clear();
            DateTime fecha = DT_fecha.Value;
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT * FROM  rd_programar_pago WHERE proveedor='"+proveedor+"' AND fecha_venc='"+fecha.ToString("yyyy-MM-dd")+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["fecha_programada"].ToString(), dr["fecha_venc"].ToString(), dr["sucursal"].ToString(), dr["rfc"].ToString(), dr["compra"].ToString(), dr["enlace"].ToString(), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["clientebancario"].ToString(), dr["tipo_pago"].ToString(), dr["patron"].ToString(), dr["importe"].ToString(), dr["iva"].ToString(),dr["concepto"].ToString(), dr["factura"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            else
            {
                MessageBox.Show("No hay pagos programados para el proveedor seleccionado en la fecha indicada");
            }
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {

            if ((RB_prov_merc.Checked==false && RB_prov_serv.Checked==false) || CB_proveedores.SelectedIndex==-1)
            {
                MessageBox.Show("Debes seleccionar un proveedor para realizar la busqueda");
            }
            else
            {
                BuscarPago();
            }
           
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            registro = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells["ID"].Value);
            TB_registro.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["ID"].Value);
            TB_fecha_prog.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["FECHA_PRO"].Value);
            TB_fecha_venc.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["FECHA_VEN"].Value);
            TB_sucursal.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["SUCURSAL"].Value);
            TB_rfc.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["RFC"].Value);
            TB_compra.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["COMPRA"].Value);
            TB_enlace.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["ENLACE"].Value);
            TB_banco.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["BANCO"].Value);
            TB_cuenta.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["CUENTA"].Value);
            TB_cliente.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["CLIENTE"].Value);
            TB_tipo.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["TIPO"].Value);
            TB_patron.Text =  Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["PATRON"].Value);
            TB_importe.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["IMPORTE"].Value);
            TB_iva.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["IVA"].Value);
            TB_concepto.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["CONCEPTO"].Value);
            TB_factura.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["FACTURA"].Value);
        }

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void ModificarPago()
        {
            DateTime fechaProgramada = Convert.ToDateTime(TB_fecha_prog.Text);
            DateTime fechaVencimiento = Convert.ToDateTime(TB_fecha_venc.Text);
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "UPDATE rd_programar_pago SET fecha_programada='"+fechaProgramada.ToString("yyyy-MM-dd")+"', fecha_venc='"+fechaVencimiento.ToString("yyyy-MM-dd")+"', sucursal='"+TB_sucursal.Text+"', rfc='"+TB_rfc.Text+"', compra='"+TB_compra.Text+"',enlace='"+TB_enlace.Text+"', banco='"+TB_banco.Text+"',cuenta='"+TB_cuenta.Text+"', clientebancario='"+TB_cliente.Text+"',tipo_pago='"+TB_tipo.Text+"',patron='"+TB_patron.Text+"',importe='"+TB_importe.Text+"',iva='"+TB_iva.Text+"',concepto='"+TB_concepto.Text+"',factura='"+TB_factura.Text+"' WHERE idreg='"+registro+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Pago modificado exitosamente");
            Limpiar();
            //RB_prov_merc.Checked = false;
            //RB_prov_serv.Checked = false;
            //CB_proveedores.SelectedIndex = -1;
        }


        private void BT_modificar_Click(object sender, EventArgs e)
        {

            if (TB_fecha_venc.Text.Equals(""))
            {
                MessageBox.Show("Selecciona un pago programado para modificar");
            }
            else
            {
                ModificarPago();
            }
           
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void EliminarPago()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "DELETE FROM rd_programar_pago WHERE idreg='"+registro+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Pago programado, eliminado");
            Limpiar();
            RB_prov_merc.Checked = false;
            RB_prov_serv.Checked = false;
            CB_proveedores.SelectedIndex = -1;
        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            if (TB_fecha_venc.Text.Equals(""))
            {
                MessageBox.Show("Selecciona un pago programado para eliminar");
            }
            else
            {
                EliminarPago();
            }
        }

        private void Modificar_pago_Load(object sender, EventArgs e)
        {

        }
    }
}
