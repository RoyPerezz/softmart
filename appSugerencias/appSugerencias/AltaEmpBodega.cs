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
    public partial class AltaEmpBodega : Form
    {
        public AltaEmpBodega()
        {
            InitializeComponent();
        }

        string id = "", nombre = "", puesto = "";
        public void Limpiar()
        {
            TB_nombre.Text = "";
        
            CB_puesto.Items.Clear();
            CB_puesto.Items.Add("");
            CB_puesto.Items.Add("BODEGUERO");
            CB_puesto.Items.Add("ETIQUETADOR");
            CB_puesto.Items.Add("CUBRE");
            CB_puesto.SelectedIndex = 0;
            DG_tabla.Rows.Clear();
        }


      
        public void RegistrarEmpleado()
        {
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "INSERT INTO rd_alta_empbodega(nombre,puesto)VALUES(?nombre,?puesto)";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("?nombre", TB_nombre.Text);
           
            cmd.Parameters.AddWithValue("?puesto", CB_puesto.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("Empleado registrado");
        }

        public void BuscarEmpleado()
        {

            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT idemp,nombre,puesto FROM rd_alta_empbodega where nombre like '%"+TB_nombre.Text+"%'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                DG_tabla.Rows.Add(dr["idemp"].ToString(),dr["nombre"].ToString(),dr["puesto"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        public void EditarEmpleado()
        {
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "UPDATE  rd_alta_empbodega SET nombre='" + TB_nombre.Text + "', puesto='" + CB_puesto.SelectedItem.ToString() + "' WHERE idemp="+id+"";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("Empleado actualizado");

        }

        public void EliminarEmpleado()
        {
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "DELETE FROM rd_alta_empbodega WHERE idemp="+id+"";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            Limpiar();
            MessageBox.Show("El empleado ha sido eliminado");

        }
        private void BT_registrar_Click(object sender, EventArgs e)
        {


            if (TB_nombre.Text.Equals("")||CB_puesto.SelectedIndex==-1)
            {
                MessageBox.Show("Debes capturar el nombre y el puesto del empleado");
            }
            else
            {
                RegistrarEmpleado();
            }
           
        }

        private void AltaEmpBodega_Load(object sender, EventArgs e)
        {

        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_modificar_Click(object sender, EventArgs e)
        {
            EditarEmpleado();
        }

        private void DG_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             id = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells[0].Value);
           nombre = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells[1].Value);
             puesto = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells[2].Value);

            TB_nombre.Text = nombre;
            CB_puesto.SelectedItem = puesto;

        }
    }
}
