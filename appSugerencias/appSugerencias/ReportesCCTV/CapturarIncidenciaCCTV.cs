using appSugerencias.ReportesCCTV;
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
    public partial class CapturarIncidenciaCCTV : Form
    {
        string usuario = "";

        public CapturarIncidenciaCCTV(string user)
        {
            usuario = user;
            InitializeComponent();
        }


        public void ObtenerConceptosCCTV()
        {
            CB_concepto.Items.Clear();
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT concepto FROM rd_conceptoscctv";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_concepto.Items.Add(dr["concepto"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        public void GuardarIncidencia()
        {

            if (CB_sucursal.SelectedIndex==-1)
            {
                MessageBox.Show("Selecciona una sucursal");
            }
            else if (CB_concepto.SelectedIndex==-1)
            {
                MessageBox.Show("Selecciona un concepto");
            }
            else
            {
                DateTime fecha = DT_fecha.Value;

                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "insert into rd_reporte_cctv(sucursal,concepto,descripcion,fecha,hora,usuario) VALUES(?sucursal,?concepto,?descripcion,?fecha,?hora,?usuario)";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?concepto", CB_concepto.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?descripcion", TB_descripcion.Text);
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("?usuario", usuario);
                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("La incidencia se ha gurdado correctamente");
            }
        }

        private void CapturarIncidenciaCCTV_Load(object sender, EventArgs e)
        {
            ObtenerConceptosCCTV();
        }

        public void Limpiar()
        {
            CB_sucursal.SelectedIndex = -1;
            CB_concepto.SelectedIndex = -1;
            TB_descripcion.Text = "";
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            GuardarIncidencia();
            Limpiar();
        }


        //abre ventata para crear concepto
        private void button2_Click(object sender, EventArgs e)
        {
            CrearConceptoIncidenciaCCTV concepto = new CrearConceptoIncidenciaCCTV();
            concepto.Show(); ;
        }


        //VUELVE A LLENAR EL COMBOBOX CON LOS CONCEPTOS
        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerConceptosCCTV();
        }
    }
}
