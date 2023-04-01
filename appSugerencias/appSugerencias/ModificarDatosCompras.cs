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
    public partial class ModificarDatosCompras : Form
    {
        public ModificarDatosCompras()
        {
            InitializeComponent();
        }


        public DataTable Compras()
        {
            

            MySqlConnection conexion = BDConexicon.VallartaOpen();
            string query = "select compra,FACTURA from cuenxpag";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Columns.Add("COMPRA",typeof(string));
            dt.Columns.Add("FACTURA", typeof(string));
            ad.Fill(dt);

            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Compras();
            string compra = "";
            string factura = "";

            MySqlConnection conexion = BDConexicon.VallartaOpen();

            MySqlCommand cmd = null; 


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                compra = dt.Rows[i]["COMPRA"].ToString();
                factura = dt.Rows[i]["FACTURA"].ToString();

                cmd =  new MySqlCommand("UPDATE cuenxpdet SET NO_REFEREN='"+factura+"' WHERE COMPRA='"+compra+"'", conexion);
                cmd.ExecuteNonQuery();
            }

            conexion.Close();
            MessageBox.Show("Terminó");

        }
    }
}
