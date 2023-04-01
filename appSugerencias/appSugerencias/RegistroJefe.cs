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
    public partial class RegistroJefe : Form
    {
        public RegistroJefe()
        {
            InitializeComponent();
        }


        int id = 0;
        public void Limpiar()
        {
            id = 0;
            CB_puesto.SelectedIndex = -1;
            CB_sucursal.SelectedIndex = -1;
            TB_nombre.Text = "";
            TB_apellidos.Text = "";
            DG_tabla.Rows.Clear();
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
           

            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "INSERT INTO rd_registro_jefes(nombre,apellidos,puesto,tienda)VALUES(?nombre,?apellidos,?puesto,?tienda)";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.Parameters.AddWithValue("?nombre",TB_nombre.Text);
                cmd.Parameters.AddWithValue("?apellidos", TB_apellidos.Text);
                cmd.Parameters.AddWithValue("?puesto",CB_puesto.SelectedItem.ToString() );
                cmd.Parameters.AddWithValue("?tienda", CB_sucursal.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("Se ha registrado al jefe correctamente");
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL REGISTRAR AL JEFE EN LA BD "+ex);
            }
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT * FROM rd_registro_jefes WHERE nombre='" + TB_nombre.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    DG_tabla.Rows.Add(dr["id"].ToString(), dr["nombre"].ToString(), dr["apellidos"].ToString(), dr["puesto"].ToString(), dr["tienda"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al buscar jefe "+ex);
            }
        }

        private void DG_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells["ID"].Value);
            TB_nombre.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["NOMBRE"].Value);
            TB_apellidos.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["APELLIDOS"].Value);
            CB_puesto.SelectedItem = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["PUESTO"].Value);
            CB_sucursal.SelectedItem = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["tienda"].Value);
        }

        private void BT_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "UPDATE rd_registro_jefes SET nombre='" + TB_nombre.Text + "',apellidos='" + TB_apellidos.Text + "',puesto='" + CB_puesto.SelectedItem.ToString() + "',tienda='"+CB_sucursal.SelectedItem.ToString()+"' WHERE id='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("El registro ha sido actualizado");
                Limpiar();
            }
            catch (Exception ex)
            {


                MessageBox.Show("Error al modificar jefe " + ex);
            }
        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "DELETE FROM rd_registro_jefes WHERE id='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                Limpiar();
                MessageBox.Show("El registro ha sido eliminado");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar jefe " + ex);
            }
        }
    }
}
