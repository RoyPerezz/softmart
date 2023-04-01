using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.ReportesCCTV
{
    public partial class CrearConceptoIncidenciaCCTV : Form
    {
        public CrearConceptoIncidenciaCCTV()
        {
            InitializeComponent();
        }

        

        private void BT_crearConcepto_Click(object sender, EventArgs e)
        {
            if (TB_concepto.Text.Equals(""))
            {
                MessageBox.Show("Debe escribir el concepto, antes de presionar el botón Crear");
            }
            else
            {
                DateTime fecha = DateTime.Now;
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "INSERT INTO rd_conceptoscctv(concepto,fecha) VALUES(?concepto,?fecha)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("?concepto", TB_concepto.Text);
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha creado el concepto");
                conexion.Close();
                TB_concepto.Text = "";
            }
        }
    }
}
