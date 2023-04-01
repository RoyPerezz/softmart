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
    public partial class frm_ReporteAsistencia : Form
    {
        public frm_ReporteAsistencia()
        {
            InitializeComponent();
        }
        MySqlConnection conex;
        DateTime fechaInicio;
        DateTime fechaFin;
        string idEmpleado;

        //BOTONES
        #region

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                conex = BDConexicon.BodegaOpen();
                busquedaRegistros(1, "");
                conex.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error :" + er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conex = BDConexicon.BodegaOpen();
                busquedaRegistros(3, cbTienda.SelectedValue.ToString());
                conex.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error :" + er.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conex = BDConexicon.BodegaOpen();
                busquedaRegistros(2, cbPatron.SelectedValue.ToString());
                conex.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error :" + er.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conex = BDConexicon.BodegaOpen();
                busquedaxEmpleado();
                conex.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show("Error :" + er.Message);
            }
        }
        #endregion


        //ACESSO A BD
        #region

        public void busquedaRegistros(int opcion, string valorBusqueda)
        {

            try
            {
                fechaInicio = dtInicio.Value.Date;
                fechaFin = dtFin.Value.Date;

                tbFiltro.Text = "";
                dgvEmpleados.Rows.Clear();

                lblNombre.Text = "---";
                lblApa.Text = "---";
                lblAma.Text = "---";
                string comando = "";

                if (opcion == 1)
                {
                    comando = "SELECT rd_asistencia.fecha,rd_asistencia.estatus,rd_empleados.nombres,rd_empleados.apellido_pa,rd_empleados.apellido_ma,tienda,area " +
                    " FROM rd_asistencia INNER JOIN rd_empleados ON rd_empleados.id_consec = rd_asistencia.fk_empleado" +
                    " WHERE fecha BETWEEN '" + fechaInicio.ToString("yyyy-MM-dd") + "' AND '" + fechaFin.ToString("yyyy-MM-dd") + "'";

                }
                else if (opcion == 2)
                {
                    comando = "SELECT rd_asistencia.fecha,rd_asistencia.estatus,rd_empleados.nombres,rd_empleados.apellido_pa,rd_empleados.apellido_ma,tienda,area " +
                   " FROM rd_asistencia INNER JOIN rd_empleados ON rd_empleados.id_consec = rd_asistencia.fk_empleado" +
                   " WHERE fk_patron='" + valorBusqueda + "'AND fecha BETWEEN '" + fechaInicio.ToString("yyyy-MM-dd") + "' AND '" + fechaFin.ToString("yyyy-MM-dd") + "'";

                }
                else if (opcion == 3)
                {
                    comando = "SELECT rd_asistencia.fecha,rd_asistencia.estatus,rd_empleados.nombres,rd_empleados.apellido_pa,rd_empleados.apellido_ma,tienda,area " +
                    " FROM rd_asistencia INNER JOIN rd_empleados ON rd_empleados.id_consec = rd_asistencia.fk_empleado" +
                    " WHERE tienda='" + valorBusqueda + "'AND fecha BETWEEN '" + fechaInicio.ToString("yyyy-MM-dd") + "' AND '" + fechaFin.ToString("yyyy-MM-dd") + "'";


                }



                MySqlCommand cmd = new MySqlCommand(comando, conex);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt3 = new System.Data.DataTable();



                adaptador.Fill(dt3);

                dgvReporte.Rows.Clear();

                foreach (DataRow item in dt3.Rows)
                {
                    int n = dgvReporte.Rows.Add();

                    dgvReporte.Rows[n].Cells[0].Value = Convert.ToDateTime(item["fecha"]).ToString("dd-MM-yyyy");
                    dgvReporte.Rows[n].Cells[1].Value = item["estatus"].ToString();
                    dgvReporte.Rows[n].Cells[2].Value = item["nombres"].ToString();
                    dgvReporte.Rows[n].Cells[3].Value = item["apellido_pa"].ToString();
                    dgvReporte.Rows[n].Cells[4].Value = item["apellido_ma"].ToString();
                    dgvReporte.Rows[n].Cells[5].Value = item["tienda"].ToString();
                    dgvReporte.Rows[n].Cells[6].Value = item["area"].ToString();


                }

                calculaAsistencia();
                calculaDepas();
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
        }


        public void busquedaxEmpleado()
        {
            try
            {
                fechaInicio = dtInicio.Value.Date;
                fechaFin = dtFin.Value.Date;

                string comando = "SELECT fecha, estatus " +
                    " FROM rd_asistencia " +
                    " WHERE fk_empleado='" + idEmpleado + "' AND fecha BETWEEN '" + fechaInicio.ToString("yyyy-MM-dd") + "' AND '" + fechaFin.ToString("yyyy-MM-dd") + "'";

                //MessageBox.Show(comando);
                MySqlCommand cmd = new MySqlCommand(comando, conex);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt3 = new System.Data.DataTable();



                adaptador.Fill(dt3);

                dgvReporte.Rows.Clear();

                foreach (DataRow item in dt3.Rows)
                {
                    int n = dgvReporte.Rows.Add();

                    dgvReporte.Rows[n].Cells[0].Value = Convert.ToDateTime(item["fecha"]).ToString("dd-MM-yyyy");
                    dgvReporte.Rows[n].Cells[1].Value = item["estatus"].ToString();
                    dgvReporte.Rows[n].Cells[2].Value = lblNombre.Text;
                    dgvReporte.Rows[n].Cells[3].Value = lblApa.Text;
                    dgvReporte.Rows[n].Cells[4].Value = lblAma.Text;


                }

                calculaAsistencia();

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
        }

        public void consultaEmpleados()
        {
            try
            {




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
        public void calculaDepas()
        {
            int iter, cajas, bodega, pisov;
            cajas = 0;
            bodega = 0;
            pisov = 0;
            iter = 0;

            for (int i = 0; i < dgvReporte.Rows.Count; i++)
            {

                if (dgvReporte.Rows[i].Cells[6].Value.ToString() == "CAJAS")
                {
                    cajas = cajas + 1;
                }
                else if (dgvReporte.Rows[i].Cells[6].Value.ToString() == "BODEGA")
                {
                    bodega = bodega + 1;
                }
                else if (dgvReporte.Rows[i].Cells[6].Value.ToString() == "PISO VENTA")
                {
                    pisov = pisov + 1;
                }
                else
                {
                    iter = iter++;
                }
            }

            lblCajas.Text = cajas.ToString();
            lblPisoVenta.Text = pisov.ToString();
            lblBodega.Text = bodega.ToString();

        }
        public void calculaAsistencia()
        {
            int A, D, V, I, PE, F;
            A = 0;
            D = 0;
            V = 0;
            I = 0;
            F = 0;
            PE = 0;


            for (int i = 0; i < dgvReporte.Rows.Count; i++)
            {

                if (dgvReporte.Rows[i].Cells[1].Value.ToString() == "A")
                {
                    A = A + 1;
                }
                if (dgvReporte.Rows[i].Cells[1].Value.ToString() == "P")
                {
                    A = A + 1;
                }
                else if (dgvReporte.Rows[i].Cells[1].Value.ToString() == "D")
                {
                    D = D + 1;

                }
                else if (dgvReporte.Rows[i].Cells[1].Value.ToString() == "V")
                {
                    V = V + 1;
                }
                else if (dgvReporte.Rows[i].Cells[1].Value.ToString() == "I")
                {
                    I = I + 1;

                }
                else if (dgvReporte.Rows[i].Cells[1].Value.ToString() == "PE")
                {
                    PE = PE + 1;
                }
                else if (dgvReporte.Rows[i].Cells[1].Value.ToString() == "F")
                {
                    F = F + 1;
                }



            }

            lblAsistencia.Text = A.ToString();
            lblDescanso.Text = D.ToString();
            lblVaca.Text = V.ToString();
            lblIncapacidad.Text = I.ToString();
            lblPermiso.Text = PE.ToString();
            lblFalta.Text = F.ToString();

        }
        #endregion


        //EVENTOS FORMULARIO
        #region
        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conex = BDConexicon.BodegaOpen();
                consultaEmpleados();

                conex.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }

        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idEmpleado = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();

                lblNombre.Text = dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblApa.Text = dgvEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblAma.Text = dgvEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {


            }
        }

        private void frm_ReporteAsistencia_Load(object sender, EventArgs e)
        {
            ComboBoxRellenaOsmart.rellenaSucursal(BDConexicon.BodegaOpen(), cbTienda);
            ComboBoxRellenaOsmart.rellenaPatron(BDConexicon.BodegaOpen(), cbPatron);
        }

        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            Exportar.Excel(dgvReporte);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_PlantillaXSucursal);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_PlantillaXSucursal();
            frm.Show();
        }
    }
}
