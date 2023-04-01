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
    public partial class frm_agregarEmpleado : Form
    {
        public frm_agregarEmpleado()
        {
            InitializeComponent();
        }
        MySqlConnection conex;
        string usuario = "SISTEMAS";
        string id;

        //BOTONES
        #region
        private void button2_Click(object sender, EventArgs e)
        {
            conex = BDConexicon.BodegaOpen();

            Empleado.consultaEmpleados(BDConexicon.BodegaOpen(), dgvEmpleados);
            conex.Close();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        #endregion

        //ACCESO A BD
        #region
        public void buscaDatos4()
        {
            try
            {


                //limpiaTiendas();

                MySqlCommand cmd = new MySqlCommand("SELECT id_consec,id_empleado, id_checador, nombres, apellido_pa, apellido_ma,salario,rol,fk_patron FROM rd_empleados  WHERE nombres LIKE '%" + tbFiltro.Text + "%' ", conex);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt3 = new System.Data.DataTable();

                double salario;

                adaptador.Fill(dt3);

                dgvEmpleados.Rows.Clear();

                foreach (DataRow item in dt3.Rows)
                {
                    int n = dgvEmpleados.Rows.Add();
                    salario = 0;
                    dgvEmpleados.Rows[n].Cells[0].Value = item["id_consec"].ToString();
                    dgvEmpleados.Rows[n].Cells[1].Value = item["id_empleado"].ToString();
                    dgvEmpleados.Rows[n].Cells[2].Value = item["id_checador"].ToString();
                    dgvEmpleados.Rows[n].Cells[3].Value = item["nombres"].ToString();
                    dgvEmpleados.Rows[n].Cells[4].Value = item["apellido_pa"].ToString();
                    dgvEmpleados.Rows[n].Cells[5].Value = item["apellido_ma"].ToString();

                    salario = Convert.ToDouble(item["salario"]);
                    dgvEmpleados.Rows[n].Cells[6].Value = item["salario"].ToString();
                    dgvEmpleados.Rows[n].Cells[7].Value = salario.ToString("C");

                    dgvEmpleados.Rows[n].Cells[8].Value = item["rol"].ToString();
                    dgvEmpleados.Rows[n].Cells[9].Value = item["fk_patron"].ToString();


                }

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

            }
        }

        public void actualizar()
        {
            lblVa.Text = "---";
            lblRe.Text = "---";
            lblCo.Text = "---";
            lblVL.Text = "---";
            btGuardar.Enabled = false;
            Empleado oEmpleado = new Empleado();

            oEmpleado.id_empleado = tb_idEmpleado.Text;
            oEmpleado.id_checador = tb_IdChecador.Text;
            oEmpleado.nombres = tb_Nombre.Text;
            oEmpleado.apellido_pa = tb_Apa.Text;
            oEmpleado.apellido_ma = tb_Ama.Text;
            oEmpleado.salario = Convert.ToDouble(tb_Salario.Text);
            oEmpleado.usuario = usuario;
            oEmpleado.rol = cbRol.SelectedValue.ToString();
            oEmpleado.id_consec = id;
            bool flag;

            try
            {
                conex = BDConexicon.BodegaOpen();
                flag = oEmpleado.actualizar(conex);
                conex.Close();



                if (flag)
                {
                    lblBo.Text = "OK";
                    lblBo.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblBo.Text = "NA";
                    lblBo.ForeColor = Color.Red;

                }


            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblBo.Text = "NA";
                lblBo.ForeColor = Color.Red;
            }





            try
            {
                conex = BDConexicon.VallartaOpen();
                flag = oEmpleado.actualizar(conex);
                conex.Close();


                if (flag)
                {
                    lblVa.Text = "OK";
                    lblVa.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblVa.Text = "NA";
                    lblVa.ForeColor = Color.Red;

                }


            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblVa.Text = "NA";
                lblVa.ForeColor = Color.Red;
            }




            try
            {
                conex = BDConexicon.RenaOpen();
                flag = oEmpleado.actualizar(conex);
                conex.Close();


                if (flag)
                {
                    lblRe.Text = "OK";
                    lblRe.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblRe.Text = "NA";
                    lblRe.ForeColor = Color.Red;
                }


            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblRe.Text = "NA";
                lblRe.ForeColor = Color.Red;
            }




            try
            {
                conex = BDConexicon.ColosoOpen();
                flag = oEmpleado.actualizar(conex);
                conex.Close();


                if (flag)
                {
                    lblCo.Text = "OK";
                    lblCo.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblCo.Text = "NA";
                    lblCo.ForeColor = Color.Red;

                }



            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblCo.Text = "NA";
                lblCo.ForeColor = Color.Red;
            }




            try
            {
                conex = BDConexicon.VelazquezOpen();
                flag = oEmpleado.actualizar(conex);
                conex.Close();


                if (flag)
                {
                    lblVL.Text = "OK";
                    lblVL.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblVL.Text = "NA";
                    lblVL.ForeColor = Color.Red;
                }



            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblVL.Text = "NA";
                lblVL.ForeColor = Color.Red;
            }

            limpiar();
            btGuardar.Enabled = true;
        }

        public void guardar()
        {
            lblVa.Text = "---";
            lblRe.Text = "---";
            lblCo.Text = "---";
            lblVL.Text = "---";
            btGuardar.Enabled = false;
            Empleado oEmpleado = new Empleado();

            oEmpleado.id_empleado = tb_idEmpleado.Text;
            oEmpleado.id_checador = tb_IdChecador.Text;
            oEmpleado.nombres = tb_Nombre.Text;
            oEmpleado.apellido_pa = tb_Apa.Text;
            oEmpleado.apellido_ma = tb_Ama.Text;

            if (string.IsNullOrEmpty(tb_Salario.Text))
            {
                oEmpleado.salario = 1;
            }
            else
            {
                oEmpleado.salario = Convert.ToDouble(tb_Salario.Text);

            }
            
            oEmpleado.usuario = usuario;
            oEmpleado.rol = cbRol.SelectedValue.ToString();
            oEmpleado.patron = cbPatron.SelectedValue.ToString();
            bool flag;


            try
            {
                conex = BDConexicon.BodegaOpen();
                flag = oEmpleado.guardar1(conex);
                conex.Close();



                if (flag)
                {
                    lblBo.Text = "OK";
                    lblBo.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblBo.Text = "NA";
                    lblBo.ForeColor = Color.Red;

                }


            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblBo.Text = "NA";
                lblBo.ForeColor = Color.Red;
            }





            try
            {
                conex = BDConexicon.VallartaOpen();
                flag = oEmpleado.guardar2(conex);
                conex.Close();


                if (flag)
                {
                    lblVa.Text = "OK";
                    lblVa.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblVa.Text = "NA";
                    lblVa.ForeColor = Color.Red;

                }


            }
            catch (Exception er)
            {
                lblVa.Text = "NA";
                lblVa.ForeColor = Color.Red;
                MessageBox.Show("" + er.Message);
            }




            try
            {
                conex = BDConexicon.RenaOpen();
                flag = oEmpleado.guardar2(conex);
                conex.Close();


                if (flag)
                {
                    lblRe.Text = "OK";
                    lblRe.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblRe.Text = "NA";
                    lblRe.ForeColor = Color.Red;
                }


            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblRe.Text = "NA";
                lblRe.ForeColor = Color.Red;
            }




            try
            {
                conex = BDConexicon.ColosoOpen();
                flag = oEmpleado.guardar2(conex);
                conex.Close();


                if (flag)
                {
                    lblCo.Text = "OK";
                    lblCo.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblCo.Text = "NA";
                    lblCo.ForeColor = Color.Red;

                }



            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblCo.Text = "NA";
                lblCo.ForeColor = Color.Red;
            }




            try
            {
                conex = BDConexicon.VelazquezOpen();
                flag = oEmpleado.guardar2(conex);
                conex.Close();


                if (flag)
                {
                    lblVL.Text = "OK";
                    lblVL.ForeColor = Color.DarkGreen;

                }
                else
                {
                    lblVL.Text = "NA";
                    lblVL.ForeColor = Color.Red;
                }



            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblVL.Text = "NA";
                lblVL.ForeColor = Color.Red;
            }

            limpiar();
            btGuardar.Enabled = true;

        }
        #endregion


        //UTILERIAS FORMULARIO
        #region
        public void limpiar()
        {
            tb_IdChecador.Text = "";
            tb_idEmpleado.Text = "";
            tb_Nombre.Text = "";
            tb_Apa.Text = "";
            tb_Ama.Text = "";
            tb_Salario.Text = "";
          

        }

        #endregion

        //EVENTOS FORMULARIO
        #region
        private void frm_agregarEmpleado_Load(object sender, EventArgs e)
        {
            ComboBoxRellenaOsmart.rellenaRolTrabajo(BDConexicon.BodegaOpen(), cbRol);
            ComboBoxRellenaOsmart.rellenaPatron(BDConexicon.BodegaOpen(), cbPatron);
        }

        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            conex = BDConexicon.BodegaOpen();
            buscaDatos4();
            conex.Close();
        }

        private void ckbNuevoEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            limpiar();
            btGuardar.Enabled = true;
            btActualizar.Enabled = false;
        }


        #endregion

        private void tb_idEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            TexBoxEvent.numberKeyPress(e);
        }

        private void tb_IdChecador_KeyPress(object sender, KeyPressEventArgs e)
        {
            TexBoxEvent.numberKeyPress(e);
        }

        private void tb_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            TexBoxEvent.textKeyPress(e);
        }

        private void tb_Apa_KeyPress(object sender, KeyPressEventArgs e)
        {
            TexBoxEvent.textKeyPress(e);
        }

        private void tb_Ama_KeyPress(object sender, KeyPressEventArgs e)
        {
            TexBoxEvent.textKeyPress(e);
        }

        private void tb_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            TexBoxEvent.moneyKeyPress(e);
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
#pragma warning disable CS0168 // La variable 'salario' se ha declarado pero nunca se usa
                double salario;
#pragma warning restore CS0168 // La variable 'salario' se ha declarado pero nunca se usa
                ckbNuevoEmpleado.Checked = false;
                btGuardar.Enabled = false;
                btActualizar.Enabled = true;

                id = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_idEmpleado.Text = dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString();
                tb_IdChecador.Text = dgvEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_Nombre.Text = dgvEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_Apa.Text = dgvEmpleados.Rows[e.RowIndex].Cells[4].Value.ToString();
                tb_Ama.Text = dgvEmpleados.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbRol.SelectedValue = dgvEmpleados.Rows[e.RowIndex].Cells[8].Value;
                cbPatron.SelectedValue = dgvEmpleados.Rows[e.RowIndex].Cells[9].Value;
                tb_Salario.Text = dgvEmpleados.Rows[e.RowIndex].Cells[6].Value.ToString();

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
        }
    }
}
