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
    public partial class frm_VerificaExistenciaSuc : Form
    {
        public frm_VerificaExistenciaSuc()
        {
            InitializeComponent();
           
        }

        public frm_VerificaExistenciaSuc(string articulo,string descripcion)
        {
            InitializeComponent();
            TB_articulo.Text = articulo;
            TB_desc.Text=descripcion;
            ConsultaTiendas();
        }
        public void ConsultaTiendas()
        {
            if (chkCEDIS.Checked == true)
            {
                tbCEDIS.Text= ConsultaExistencia(TB_articulo.Text.Trim(), BDConexicon.BodegaOpen());
            }

            if (chkVallarta.Checked == true)
            {
                tbVallarta.Text= ConsultaExistencia(TB_articulo.Text.Trim(), BDConexicon.VallartaOpen());
            }

            if (chkRena.Checked == true)
            {
                tbRena.Text= ConsultaExistencia(TB_articulo.Text.Trim(), BDConexicon.RenaOpen());
            }

            if (chkVelazquez.Checked == true)
            {
                tbVelazquez.Text= ConsultaExistencia(TB_articulo.Text.Trim(), BDConexicon.VelazquezOpen());
            }

            if (chkColoso.Checked == true)
            {
                tbColoso.Text= ConsultaExistencia(TB_articulo.Text.Trim(), BDConexicon.ColosoOpen());
            }
        }
        private void BTN_aceptar_Click(object sender, EventArgs e)
        {
            if (TB_articulo.Text.Equals(""))
            {
                MessageBox.Show("Ingresa un artículo");
            }
            else
            {
                ConsultaTiendas();

            }
        }

        public string ConsultaExistencia(string articulo,MySqlConnection con)
        {
            string existencia = "0";
            try
            {
                MySqlCommand cmdr = new MySqlCommand("SELECT EXISTENCIA FROM prods WHERE ARTICULO=?ARTICULO", con);
                cmdr.Parameters.AddWithValue("?ARTICULO", articulo);
                MySqlDataReader dr = cmdr.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        existencia= dr["EXISTENCIA"].ToString();
                    }
                }
                return existencia;
            }
            catch(Exception er)
            { return "0"; }

        }
    }
}
