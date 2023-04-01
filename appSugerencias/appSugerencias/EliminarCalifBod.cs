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
    public partial class EliminarCalifBod : Form
    {
        public EliminarCalifBod()
        {
            InitializeComponent();
        }

        //OBTIENE LOS NOMBRES DE LOS EMPLEADOS DE BODEGA DE LA SUCURSAL
        public void Empleados()
        {
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT nombre FROM rd_alta_empbodega";
            MySqlCommand cmd = new MySqlCommand(query,conexion);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_empleados.Items.Add(dr["nombre"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void EliminarCalifBod_Load(object sender, EventArgs e)
        {
            Empleados();
            DG_tabla.Enabled = false;
            BT_eliminarCalifEtiquetador.Enabled = false;
            TB_registro.Enabled = false;
        }


        //EVENTO DEL COMBOBOX QUE TRAE EL ID DEL EMPLEADO SELECCIONADO
        private void CB_empleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT idemp,puesto FROM rd_alta_empbodega WHERE nombre ='"+CB_empleados.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);

            string puesto = "";
            


            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_idemp.Text = dr["idemp"].ToString();
                puesto = dr["puesto"].ToString();
            }
            dr.Close();
            conexion.Close();

            if (puesto.Equals("ETIQUETADOR"))
            {
                DG_tabla.Enabled = true;
                BT_eliminarCalifEtiquetador.Enabled = true;
                TB_registro.Enabled = true;
            }

            if (puesto.Equals("BODEGUERO")||puesto.Equals("CUBRE"))
            {
                DG_tabla.Enabled = false;
                BT_eliminarCalifEtiquetador.Enabled = false;
                TB_registro.Enabled = false;
            }
        }

        //ELIMINA LA CALIFICACION DEL EMPLEADO EN LA FECHA SELECCIONADA
        public void EliminarCalificacion()
        {
            DateTime fecha = DT_fecha.Value;
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "DELETE FROM rd_calif_emp_bodega WHERE idempleado='"+TB_idemp.Text+"' AND fecha='"+fecha.ToString("yyyy-MM-dd")+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha eliminado la calificacion de la fecha "+ fecha.ToString("yyyy-MM-dd")+"");
        }

        //BOTON ELIMINAR, QUE EJECUTA EL METODO ELIMINAR CALIFICACION
        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            if (TB_idemp.Text.Equals(""))
            {
                MessageBox.Show("Debes elegir a un empleado");
            }
            else
            {
                EliminarCalificacion();
            }
           
        }

        private void BT_califEtiquetador_Click(object sender, EventArgs e)
        {
            DateTime fecha = DT_fecha.Value;
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT idreg,idempleado,descarga,cajasurtida,totalEtiquetador FROM rd_calif_emp_bodega WHERE idempleado ='" + TB_idemp.Text + "' and  fecha='"+fecha.ToString("yyy-MM-dd")+"'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            double descarga = 0;
            double cajasurtida = 0;
            double total = 0;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                descarga = Convert.ToDouble(dr["descarga"].ToString());
                cajasurtida = Convert.ToDouble(dr["cajasurtida"].ToString());
                total = Convert.ToDouble(dr["totalEtiquetador"].ToString());
                DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["idempleado"].ToString(), String.Format("{0:0.##}", descarga.ToString("C")), String.Format("{0:0.##}",cajasurtida.ToString("C")), String.Format("{0:0.##}", total.ToString("C")));
            }
            dr.Close();
            conexion.Close();
        }

        private void BT_eliminarCalifEtiquetador_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "DELETE FROM rd_calif_emp_bodega WHERE idreg='"+TB_registro.Text+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se eliminó la calificación del etiquetador");
            DG_tabla.Rows.Clear();
            TB_registro.Text = "";

            
        }
    }
}
