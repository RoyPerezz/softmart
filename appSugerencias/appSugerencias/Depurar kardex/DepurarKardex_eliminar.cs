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
    public partial class DepurarKardex_eliminar : Form
    {
        string articulo = "", descripcion = "";
#pragma warning disable CS0414 // El campo 'DepurarKardex_eliminar.va' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'DepurarKardex_eliminar.co' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'DepurarKardex_eliminar.re' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'DepurarKardex_eliminar.ce' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'DepurarKardex_eliminar.ve' está asignado pero su valor nunca se usa
        bool ce = false, va = false, re = false, ve = false, co = false;
#pragma warning restore CS0414 // El campo 'DepurarKardex_eliminar.ve' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'DepurarKardex_eliminar.ce' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'DepurarKardex_eliminar.re' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'DepurarKardex_eliminar.co' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'DepurarKardex_eliminar.va' está asignado pero su valor nunca se usa
        public DepurarKardex_eliminar(string articulo,string descripcion)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.descripcion = descripcion;
            this.Text = "Eliminar " + articulo + "  " + descripcion;
            
        }

        private void BT_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepurarKardex_eliminar_Load(object sender, EventArgs e)
        {
           
        }



        public void EliminarDeCedis()
        {
            string consulta = "delete from prods where articulo ='" + articulo + "'";
            string consulta2 = "delete from movsinv where articulo='" + articulo + "'";
            MySqlConnection conCE = BDConexicon.BodegaOpen();
        

            try
            {
                MySqlCommand cmdCE = new MySqlCommand(consulta, conCE);
                cmdCE.ExecuteNonQuery();

                MySqlCommand cmdCE2 = new MySqlCommand(consulta2, conCE);
                cmdCE2.ExecuteNonQuery();
                TB_ce.BackColor = Color.Green;

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                TB_ce.BackColor = Color.Red;
                
            }

            conCE.Close();
        }

        public void EliminarDeVallarta()
        {
            string consulta = "delete from prods where articulo ='" + articulo + "'";
            string consulta2 = "delete from movsinv where articulo='" + articulo + "'";
            MySqlConnection conVA = BDConexicon.VallartaOpen();
        
            try
            {
                MySqlCommand cmdVA = new MySqlCommand(consulta, conVA);
                cmdVA.ExecuteNonQuery();

                MySqlCommand cmdVA2 = new MySqlCommand(consulta2, conVA);
                cmdVA2.ExecuteNonQuery();
                TB_va.BackColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                TB_va.BackColor = Color.Red;
               
            }

            conVA.Close();
        }

        public void EliminarDeRena()
        {
            string consulta = "delete from prods where articulo ='" + articulo + "'";
            string consulta2 = "delete from movsinv where articulo='" + articulo + "'";
            MySqlConnection conRE = BDConexicon.RenaOpen();
            
            try
            {
                MySqlCommand cmdRE = new MySqlCommand(consulta, conRE);
                cmdRE.ExecuteNonQuery();

                MySqlCommand cmdRE2 = new MySqlCommand(consulta2, conRE);
                cmdRE2.ExecuteNonQuery();
                TB_re.BackColor = Color.Green;

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                TB_re.BackColor = Color.Red;
               
            }

            conRE.Close();
        }

        public void EliminarDeVelazquez()
        {
            string consulta = "delete from prods where articulo ='" + articulo + "'";
            string consulta2 = "delete from movsinv where articulo='" + articulo + "'";
            MySqlConnection conVE = BDConexicon.VelazquezOpen();
            
            try

            {
                MySqlCommand cmdVE = new MySqlCommand(consulta, conVE);
                cmdVE.ExecuteNonQuery();

                MySqlCommand cmdVE2 = new MySqlCommand(consulta2, conVE);
                cmdVE2.ExecuteNonQuery();
                TB_ve.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                TB_ve.BackColor = Color.Red;
                MessageBox.Show("Error al tratar de eliminar artículo de la tabla movsinv " + ex);
            }

            conVE.Close();
        }


        public void EliminarDeColoso()
        {
            string consulta = "delete from prods where articulo ='" + articulo + "'";
            string consulta2 = "delete from movsinv where articulo='" + articulo + "'";
            MySqlConnection conCO = BDConexicon.ColosoOpen();
          

            try
            {
                MySqlCommand cmdCO = new MySqlCommand(consulta, conCO);
                cmdCO.ExecuteNonQuery();


                MySqlCommand cmdCO2 = new MySqlCommand(consulta2, conCO);
                cmdCO2.ExecuteNonQuery();
                TB_co.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                TB_co.BackColor = Color.Red;
                MessageBox.Show("Error al tratar de eliminar artículo de la tabla movsinv " + ex);
            }

            conCO.Close();
        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            EliminarDeCedis();
            EliminarDeVallarta();
            EliminarDeRena();
            EliminarDeVelazquez();
            EliminarDeColoso();

            
        }
    }
}
