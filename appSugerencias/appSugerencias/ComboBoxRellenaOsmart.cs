using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace appSugerencias
{
    class ComboBoxRellenaOsmart
    {
        //
        public static void rellenaSucursal(MySqlConnection Conex, ComboBox combo)
        {
            combo.DataSource = null;


            MySqlCommand cmd = new MySqlCommand("SELECT suc_ab,descripcion  FROM rd_sucursales WHERE activo=1", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            combo.ValueMember = "suc_ab";
            combo.DisplayMember = "descripcion";
            combo.DataSource = dt1;
            Conex.Close();

        }

        public static void rellenaPatron(MySqlConnection Conex, ComboBox combo)
        {
            combo.DataSource = null;


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_patron", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            combo.ValueMember = "id";
            combo.DisplayMember = "patron";
            combo.DataSource = dt1;
            Conex.Close();

        }

        public static void rellenaRolTrabajo(MySqlConnection Conex, ComboBox combo)
        {
            combo.DataSource = null;


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_rol", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            combo.ValueMember = "id";
            combo.DisplayMember = "rol";
            combo.DataSource = dt1;
            Conex.Close();

        }

    }
}
