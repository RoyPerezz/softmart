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
    public partial class ReporteFaltas : Form
    {
        public ReporteFaltas()
        {
            InitializeComponent();
        }

        private void ReporteFaltas_Load(object sender, EventArgs e)
        {

            //lleno el combobox con las sucursales
            DataTable sucursales = Sucursales.ObtenerSucursales();

            foreach (DataRow row in sucursales.Rows)
            {
                CB_sucursal.Items.Add(row["descripcion"].ToString());
            }

            //lleno el combobox con las areas

            MySqlConnection conexion = BDConexicon.conectar();
            string query = "select distinct area from rd_areas";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_areas.Items.Add(dr["area"].ToString());
            }
            dr.Close();
            conexion.Close();
        }
    }
}
