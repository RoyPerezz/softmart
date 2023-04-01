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
    public partial class frm_CapturaAsistencia : Form
    {
        public frm_CapturaAsistencia()
        {
            InitializeComponent();
        }

        MySqlConnection conex;
        byte diaSemana;
        string tienda;
        string idEmpleado;
        string area;



        //BOTONES
        #region
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conex = BDConexicon.BodegaOpen();
                agregar();
                conex.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error con el servidor :" + er.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvCargaEmpleados.RowCount - 1 > 0)
            {
                dgvCargaEmpleados.Rows.RemoveAt(dgvCargaEmpleados.CurrentRow.Index);

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string valor = idEmpleado;
            int flag = 1;
            try
            {
                foreach (DataGridViewRow row in dgvCargaEmpleados.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(valor))
                    {
                        flag = 0;
                        MessageBox.Show("Empleado duplicado");
                    }
                }
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
            if (tbPersona.Text != "")
            {
                if (tbArea.Text != "")
                {
                    if (flag == 1)
                    {
                        dgvCargaEmpleados.Rows.Add();

                        int n = dgvCargaEmpleados.RowCount - 1;

                        dgvCargaEmpleados.Rows[n].Cells[0].Value = idEmpleado;
                        dgvCargaEmpleados.Rows[n].Cells[1].Value = tbPersona.Text;


                        dgvCargaEmpleados.Rows[n].Cells[2].Value = tbArea.Text;
                        dgvCargaEmpleados.Rows[n].Cells[4].Value = area;

                        if (diaSemana == 0)
                        {
                            if (tbValor.Text != "A")
                            {
                                dgvCargaEmpleados.Rows[n].Cells[3].Value = tbValor.Text;
                            }
                            else
                            {

                                dgvCargaEmpleados.Rows[n].Cells[3].Value = "P";
                            }

                        }
                        else
                        {
                            dgvCargaEmpleados.Rows[n].Cells[3].Value = tbValor.Text;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Asigne un area");

                }

            }
            else
            {
                MessageBox.Show("Seleccione un Empleado");
            }
        }
        #endregion
        //ACCESO BD
        #region

        public void agregar()
        {

            try
            {
                MySqlCommand cmd2 = new MySqlCommand("insert into rd_asistencia(fecha,estatus,fk_empleado,tienda,area_tienda,area) values(?fecha,?estatus,?fk_empleado,?tienda,?area_tienda,?area)", conex);

                for (int i = 0; i < dgvCargaEmpleados.Rows.Count; i++)
                {

                    cmd2.Parameters.Clear();
                    cmd2.Parameters.AddWithValue("?fecha", DateTime.Now.ToString("yyy-MM-dd"));

                    cmd2.Parameters.AddWithValue("?estatus", dgvCargaEmpleados.Rows[i].Cells[3].Value.ToString());


                    cmd2.Parameters.AddWithValue("?fk_empleado", dgvCargaEmpleados.Rows[i].Cells[0].Value.ToString());
                    cmd2.Parameters.AddWithValue("?tienda", tienda);
                    cmd2.Parameters.AddWithValue("?area", dgvCargaEmpleados.Rows[i].Cells[4].Value.ToString());
                    cmd2.Parameters.AddWithValue("?area_tienda", dgvCargaEmpleados.Rows[i].Cells[2].Value.ToString());

                    cmd2.ExecuteNonQuery();

                }


                MessageBox.Show("Datos agregados");
                dgvCargaEmpleados.Rows.Clear();
                tbPersona.Clear();
                tbArea.Clear();
                tbValor.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex);
            }

        }

        public void buscaAreaCaja()
        {

            try
            {


                //limpiaTiendas();

                MySqlCommand cmd = new MySqlCommand("SELECT area_tienda,area FROM rd_areas  WHERE area='CAJAS' OR area='APOYO' OR area='HOSTESS' OR area='VERIFICADOR'", conex);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();



                adaptador.Fill(dt);

                dgvCajas.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvCajas.Rows.Add();

                    dgvCajas.Rows[n].Cells[0].Value = item["area_tienda"].ToString();
                    dgvCajas.Rows[n].Cells[1].Value = item["area"].ToString();


                }

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

            }

        }

        public void buscaAreaPiso(string tienda)
        {
            string comando = "SELECT area_tienda,area FROM rd_areas  WHERE area='PISO VENTA '"+ addSucursal();

            try
            {


                //limpiaTiendas();

                MySqlCommand cmd1 = new MySqlCommand(comando, conex);

                MySqlDataAdapter adaptador1 = new MySqlDataAdapter(cmd1);
                System.Data.DataTable dt1 = new System.Data.DataTable();



                adaptador1.Fill(dt1);

                dgvArea.Rows.Clear();

                foreach (DataRow item in dt1.Rows)
                {
                    int n = dgvArea.Rows.Add();

                    dgvArea.Rows[n].Cells[0].Value = item["area_tienda"].ToString();
                    dgvArea.Rows[n].Cells[1].Value = item["area"].ToString();


                }

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

            }

        }
        public string addSucursal()
        {
            string cmd_sucursal="";

            if (tienda == "VA")
            {
                cmd_sucursal = " AND sucursal='VA'";

            }
            else if (tienda == "RE")
            {
                cmd_sucursal = " AND sucursal='RE'";
            }
            else if (tienda == "CO")
            {
                cmd_sucursal = " AND sucursal='CO'";
            }
            else if (tienda == "VL")
            {
                cmd_sucursal = " AND sucursal='VL'";
            }
            else
            {
                cmd_sucursal = " AND sucursal='CEDIS'";
            }

            return cmd_sucursal;
        }
        public void buscaAreaBodega(string tienda)
        {
            string comando;
            

            

            comando = "SELECT area_tienda,area FROM rd_areas  WHERE area='BODEGA '"+ addSucursal() + " OR area='ETIQUETADOR' ";
            try
            {


                //limpiaTiendas();

                MySqlCommand cmd = new MySqlCommand(comando, conex);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt3 = new System.Data.DataTable();



                adaptador.Fill(dt3);

                dgvBodega.Rows.Clear();

                foreach (DataRow item in dt3.Rows)
                {
                    int n = dgvBodega.Rows.Add();

                    dgvBodega.Rows[n].Cells[0].Value = item["area_tienda"].ToString();
                    dgvBodega.Rows[n].Cells[1].Value = item["area"].ToString();


                }

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

            }

        }

        public void buscaOtros()
        {
            try
            {


                //limpiaTiendas();

                MySqlCommand cmd = new MySqlCommand("SELECT area_tienda,area FROM rd_areas  WHERE area='OTROS' OR area='APOYO' ", conex);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt3 = new System.Data.DataTable();



                adaptador.Fill(dt3);

                dgvOtros.Rows.Clear();

                foreach (DataRow item in dt3.Rows)
                {
                    int n = dgvOtros.Rows.Add();

                    dgvOtros.Rows[n].Cells[0].Value = item["area_tienda"].ToString();
                    dgvOtros.Rows[n].Cells[1].Value = item["area"].ToString();


                }

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

            }

        }

        public void buscaDatos4()
        {
            try
            {


                //limpiaTiendas();

                MySqlCommand cmd = new MySqlCommand("SELECT id_consec,nombres,apellido_pa,apellido_ma FROM rd_empleados WHERE nombres LIKE '%" + tbFiltro.Text + "%' ", conex);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt3 = new System.Data.DataTable();



                adaptador.Fill(dt3);

                dgvEmpleados.Rows.Clear();

                foreach (DataRow item in dt3.Rows)
                {
                    int n = dgvEmpleados.Rows.Add();

                    dgvEmpleados.Rows[n].Cells[0].Value = item["id_consec"].ToString();
                    dgvEmpleados.Rows[n].Cells[1].Value = item["nombres"].ToString();
                    dgvEmpleados.Rows[n].Cells[2].Value = item["apellido_pa"].ToString();
                    dgvEmpleados.Rows[n].Cells[3].Value = item["apellido_ma"].ToString();


                }

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {

            }

        }


        #endregion

        //UTILERIAS FORMULARIO
        #region

        public void falseValor()
        {
            rbFalta.Checked = false;
            rbVacaciones.Checked = false;
            rbIncapacidad.Checked = false;
            rbPermiso.Checked = false;
            rbDescanso.Checked = false;
            rbFalta.Checked = false;
        }

        public void falseEncargados()
        {
            rbGerente.Checked = false;
            rbEncCaja.Checked = false;
            rbEncBodega.Checked = false;

        }

        #endregion

        //EVENTOS FORMULARIO
        #region

        //Eventos double click  para agregar  los data grid
        private void dgvCajas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbArea.Text = dgvCajas.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbValor.Text = "A";


                area = dgvCajas.Rows[e.RowIndex].Cells[1].Value.ToString();

                falseEncargados();
                falseValor();

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
        }

        private void dgvArea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbArea.Text = dgvArea.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbValor.Text = "A";

                area = dgvArea.Rows[e.RowIndex].Cells[1].Value.ToString();

                falseEncargados();
                falseValor();

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
        }

        private void dgvBodega_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbArea.Text = dgvBodega.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbValor.Text = "A";

                area = dgvBodega.Rows[e.RowIndex].Cells[1].Value.ToString();

                falseEncargados();
                falseValor();

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
        }

        private void dgvOtros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbArea.Text = dgvOtros.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbValor.Text = "A";

            area = dgvOtros.Rows[e.RowIndex].Cells[1].Value.ToString();

            falseEncargados();
            falseValor();
        }
        //CUANDO CAMBIA EL TEXTO DEL TEXT BOX
        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conex = BDConexicon.conectar();
                buscaDatos4();
                conex.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al conectar: " + er.Message);
            }
        }

        //DOUBLE CLICK DE DATA GRID
        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbPersona.Text = dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dgvEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dgvEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString();
                //lblid.Text = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
                idEmpleado = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();



            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
        }
        //Eventos de check box
        private void rbDescanso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDescanso.Checked)
            {
                tbArea.Text = "NA";
                tbValor.Text = "D";
                area = "NA";
                falseEncargados();
            }
        }

        private void rbVacaciones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVacaciones.Checked)
            {
                tbArea.Text = "NA";
                tbValor.Text = "V";
                area = "NA";
                falseEncargados();
            }
        }

        private void rbIncapacidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIncapacidad.Checked)
            {
                tbArea.Text = "NA";
                tbValor.Text = "I";
                area = "NA";
                falseEncargados();
            }
        }

        private void rbPermiso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPermiso.Checked)
            {
                tbArea.Text = "NA";
                tbValor.Text = "PE";
                area = "NA";
                falseEncargados();
            }
        }

        private void rbFalta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFalta.Checked)
            {
                tbArea.Text = "NA";
                tbValor.Text = "F";
                area = "NA";
                falseEncargados();
            }
        }

        private void rbGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGerente.Checked)
            {
                tbArea.Text = "GERENTE";
                tbValor.Text = "A";
                area = "NA";
                falseValor();
            }
        }

        private void rbEncCaja_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEncCaja.Checked)
            {
                tbArea.Text = "ENC CAJA";
                tbValor.Text = "A";
                area = "NA";
                falseValor();
            }
        }

        private void rbEncBodega_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEncBodega.Checked)
            {
                tbArea.Text = "ENC BODEGA";
                tbValor.Text = "A";
                area = "NA";
                falseValor();
            }
        }

        //LOAD
        private void frm_CapturaAsistencia_Load(object sender, EventArgs e)
        {
            DateTime Fecha;
            Fecha = DateTime.Now;
            //Fecha = Convert.ToDateTime("04-08-2021");

            lblFecha.Text = Fecha.ToString("dd/MM/yyyy");




            diaSemana = (byte)Fecha.DayOfWeek;

            tienda = DefineTiendaIP.defineTienda();
            //tienda = "VA";
            //lblId.Text = tienda;


            conex = BDConexicon.conectar();
            buscaAreaCaja();
            buscaAreaPiso(tienda);
            buscaAreaBodega(tienda);
            buscaOtros();


            conex.Close();
        }










        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_CapturaAsistenciaRevisar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_CapturaAsistenciaRevisar();
            frm.Show();
        }
    }
}
