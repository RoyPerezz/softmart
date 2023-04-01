using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace appSugerencias
{
    public partial class frm_KardexMulti : Form
    {
        public frm_KardexMulti()
        {
            InitializeComponent();
        }

#pragma warning disable CS0414 // El campo 'frm_KardexMulti.limite' está asignado pero su valor nunca se usa
        string limite = "50";
#pragma warning restore CS0414 // El campo 'frm_KardexMulti.limite' está asignado pero su valor nunca se usa
        MySqlConnection con;

        public void limpiarDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        public void buscaProducto()
        {
            con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT DESCRIP FROM prods WHERE articulo='" + tbArticulo.Text + "'", con);
            MySqlDataReader rd = cmd.ExecuteReader();
         


            if (rd.Read())
            {
                lblArticulo.Text = rd["DESCRIP"].ToString();

                if (ckbVA.Checked)
                {
                    try
                    {
                        con = BDConexicon.VallartaOpen();
                        selectDatos(cbLimit.Text, dgvArticulosVA);
                        con.Close();
                        lblVA.Text = "OK";
                        lblVA.ForeColor = Color.Green;
                    }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    {
                        lblVA.Text = "N/A";
                        lblVA.ForeColor = Color.Red;
                    }
                    
                }

                if (ckbRE.Checked)
                {
                    try
                    {
                        con = BDConexicon.RenaOpen();
                        selectDatos(cbLimit.Text, dgvArticulosRE);
                        con.Close();
                        lblRE.Text = "OK";
                        lblRE.ForeColor = Color.Green;

                    }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    {
                        lblRE.Text = "N/A";
                        lblRE.ForeColor = Color.Red;
                    }
                    
                }

                if (ckbCO.Checked)
                {
                    try
                    {
                        con = BDConexicon.ColosoOpen();
                        selectDatos(cbLimit.Text, dgvArticulosCO);
                        con.Close();
                        lblCO.Text = "OK";
                        lblCO.ForeColor = Color.Green;
                    }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    catch(Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    {
                        lblCO.Text = "N/A";
                        lblCO.ForeColor = Color.Red;
                    }
                    
                }

                if (ckbVL.Checked)
                {
                    try
                    {
                        con = BDConexicon.VelazquezOpen();
                        selectDatos(cbLimit.Text, dgvArticulosVL);
                        con.Close();
                        lblVL.Text = "OK";
                        lblVL.ForeColor = Color.Green;
                    }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    catch(Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    {
                        lblVL.Text = "N/A";
                        lblVL.ForeColor = Color.Red;
                    }
                   
                }

                if (ckbBO.Checked)
                {
                    try
                    {
                        con = BDConexicon.BodegaOpen();
                        selectDatos(cbLimit.Text, dgvArticulosBO);
                        con.Close();
                        lblCEDIS.Text = "OK";
                        lblCEDIS.ForeColor = Color.Green;
                    }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    catch(Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    {
                        lblCEDIS.Text = "N/A";
                        lblCEDIS.ForeColor = Color.Red;
                    }
                    
                }

                if (ckbPM.Checked)
                {
                    try
                    {
                        con = BDConexicon.Papeleria1Open();
                        selectDatos(cbLimit.Text, dgvArticulosPM);
                        con.Close();
                        lblPM.Text = "OK";
                        lblPM.ForeColor = Color.Green;
                    }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    catch(Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                    {
                        lblPM.Text = "N/A";
                        lblPM.ForeColor = Color.Red;
                    }
                    
                }

            }
            else
            {
                lblArticulo.Text = "No existe el producto";
            }
            con.Close();
        }


        public void selectDatos(string limit, DataGridView dgv)
        {



          
       
            string comando;
            string LIMIT= "LIMIT "+ limit;

            if (limit == "ALL")
            {
                comando = "SELECT TIPO_MOVIM,NO_REFEREN,F_MOVIM,ENT_SAL, CANTIDAD, EXISTENCIA from movsinv WHERE articulo='" + tbArticulo.Text + "' ORDER BY consec desc ";


            }
            else
            {
                comando = "SELECT TIPO_MOVIM,NO_REFEREN,F_MOVIM,ENT_SAL, CANTIDAD, EXISTENCIA from movsinv WHERE articulo='" + tbArticulo.Text + "' ORDER BY consec desc LIMIT " + limit;

            }


           

            MySqlCommand cmd = new MySqlCommand(comando, con);

            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();


            adaptador.Fill(dt);

            dgv.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgv.Rows.Add();

         

                dgv.Rows[n].Cells[0].Value = item["TIPO_MOVIM"].ToString();
                dgv.Rows[n].Cells[1].Value = item["NO_REFEREN"].ToString();
                dgv.Rows[n].Cells[2].Value = item["F_MOVIM"].ToString();
                dgv.Rows[n].Cells[3].Value = item["ENT_SAL"].ToString();
                if (item["ENT_SAL"].ToString() == "S")
                {
                    dgv.Rows[n].Cells[4].Value = "-" + item["CANTIDAD"].ToString();
                }
                else
                {
                    dgv.Rows[n].Cells[4].Value = item["CANTIDAD"].ToString();
                }

                dgv.Rows[n].Cells[5].Value = item["EXISTENCIA"].ToString();

            }







            con.Close();
        }
        //########## CIERRE ############


       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbArticulo.Text))
            {
                MessageBox.Show("Inserte un codigo de articulo");
            }
            else
            {
                lblVA.Text = "---";
                lblRE.Text = "---";
                lblCO.Text = "---";
                lblVL.Text = "---";
                lblCEDIS.Text = "---";

                limpiarDataGrid(dgvArticulosVA);
                limpiarDataGrid(dgvArticulosRE);
                limpiarDataGrid(dgvArticulosCO);
                limpiarDataGrid(dgvArticulosVL);
                limpiarDataGrid(dgvArticulosBO);
                limpiarDataGrid(dgvArticulosPM);

                buscaProducto();

                

            }
          
        }

        private void frm_KardexMulti_Load(object sender, EventArgs e)
        {
            cbLimit.SelectedIndex = 0;
        }

        private void dgvArticulosPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
