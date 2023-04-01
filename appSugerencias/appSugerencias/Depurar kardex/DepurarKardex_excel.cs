using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Depurar_kardex
{
    public partial class DepurarKardex_excel : Form
    {

        DataTable dt;
        int progreso = 20;
        public DepurarKardex_excel(DataTable dt)
        {

            this.dt = dt;
            InitializeComponent();
        }

        private void DepurarKardex_excel_Load(object sender, EventArgs e)
        {
          

            DG_tabla.DataSource = dt;
            DG_tabla.Columns[1].Width = 400;
        }





        #region METODOS
        public void EliminarCedis()
        {
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = null;
                MySqlCommand cmd2 = null;
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    cmd = new MySqlCommand("delete from prods where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd.ExecuteNonQuery();

                    cmd2 = new MySqlCommand("delete from movsinv where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd2.ExecuteNonQuery();
                }

                TB_ce.BackColor = Color.Green;
                PB_progreso.Value += progreso;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                TB_ce.BackColor = Color.Red;

            }
        }

        public void EliminarVallarta()
        {
            try
            {
                MySqlConnection conexion = BDConexicon.VallartaOpen();
                MySqlCommand cmd = null;
                MySqlCommand cmd2 = null;
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    cmd = new MySqlCommand("delete from prods where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd.ExecuteNonQuery();

                    cmd2 = new MySqlCommand("delete from movsinv where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd2.ExecuteNonQuery();
                }

                TB_va.BackColor = Color.Green;
                PB_progreso.Value += progreso;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                TB_va.BackColor = Color.Red;

            }


        }

        public void EliminarRena()
        {
            try
            {
                MySqlConnection conexion = BDConexicon.RenaOpen();
                MySqlCommand cmd = null;
                MySqlCommand cmd2 = null;
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    cmd = new MySqlCommand("delete from prods where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd.ExecuteNonQuery();

                    cmd2 = new MySqlCommand("delete from movsinv where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd2.ExecuteNonQuery();
                }

                TB_re.BackColor = Color.Green;
                PB_progreso.Value += progreso;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                TB_re.BackColor = Color.Red;

            }
           
        }


        public void EliminarVelazquez()
        {
            try
            {
                MySqlConnection conexion = BDConexicon.VelazquezOpen();
                MySqlCommand cmd = null;
                MySqlCommand cmd2 = null;
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    cmd = new MySqlCommand("delete from prods where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd.ExecuteNonQuery();

                    cmd2 = new MySqlCommand("delete from movsinv where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd2.ExecuteNonQuery();
                }

                TB_ve.BackColor = Color.Green;
                PB_progreso.Value += progreso;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                TB_ve.BackColor = Color.Red;

            }

        }

        public void EliminarColoso()
        {
            try
            {
                MySqlConnection conexion = BDConexicon.ColosoOpen();
                MySqlCommand cmd = null;
                MySqlCommand cmd2 = null;
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    cmd = new MySqlCommand("delete from prods where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd.ExecuteNonQuery();

                    cmd2 = new MySqlCommand("delete from movsinv where articulo='" + DG_tabla.Rows[i].Cells[0].Value.ToString() + "'", conexion);
                    cmd2.ExecuteNonQuery();
                }

                TB_co.BackColor = Color.Green;
                PB_progreso.Value += progreso;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                TB_co.BackColor = Color.Red;

            }

        }

        #endregion
        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            EliminarCedis();
            EliminarVallarta();
            EliminarRena();
            EliminarVelazquez();
            EliminarColoso();

            MessageBox.Show("Terminado");
        }
    }
}
