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
    public partial class frm_CapturaAsistenciaRevisar : Form
    {
        public frm_CapturaAsistenciaRevisar()
        {
            InitializeComponent();
        }
        MySqlConnection conex;
        DateTime fecha;
        string idEmpleado=null;

        private void frm_CapturaAsistenciaRevisar_Load(object sender, EventArgs e)
        {
            conex = BDConexicon.BodegaOpen();
            fecha = dt_time.Value.Date;
            consultar();
            conex.Close();
        }

        public void consultar()
        {
            string sucursal;
            sucursal = DefineTiendaIP.defineTienda();
           
            //MessageBox.Show(fecha.ToString("yyyy-MM-dd"));
            string comando;
            comando = "SELECT rd_asistencia.id,rd_asistencia.fecha,rd_asistencia.estatus,rd_empleados.nombres,rd_empleados.apellido_pa,rd_empleados.apellido_ma,tienda,area " +
                    " FROM rd_asistencia INNER JOIN rd_empleados ON rd_empleados.id_consec = rd_asistencia.fk_empleado" +
                    " WHERE fecha ='"+fecha.ToString("yyyy-MM-dd")+"' AND tienda='"+sucursal+"'";

            MySqlCommand cmd = new MySqlCommand(comando, conex);


            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt3 = new System.Data.DataTable();



            adaptador.Fill(dt3);

            dgvEmpleados.Rows.Clear();

            foreach (DataRow item in dt3.Rows)
            {
                int n = dgvEmpleados.Rows.Add();

                dgvEmpleados.Rows[n].Cells[0].Value = item["id"].ToString();
                dgvEmpleados.Rows[n].Cells[1].Value = Convert.ToDateTime(item["fecha"]).ToString("dd-MM-yyyy");
                dgvEmpleados.Rows[n].Cells[2].Value = item["estatus"].ToString();
                dgvEmpleados.Rows[n].Cells[3].Value = item["nombres"].ToString();
                dgvEmpleados.Rows[n].Cells[4].Value = item["apellido_pa"].ToString();
                dgvEmpleados.Rows[n].Cells[5].Value = item["apellido_ma"].ToString();
                dgvEmpleados.Rows[n].Cells[6].Value = item["area"].ToString();
                


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fecha = DateTime.Now.Date;
            conex = BDConexicon.BodegaOpen();
            fecha = dt_time.Value.Date;
            consultar();
            conex.Close();
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fecha = DateTime.Now.Date;
            try
            {
                if(dgvEmpleados.Rows[e.RowIndex].Cells[1].Value.ToString()==fecha.ToString("dd-MM-yyyy"))
                {
                    lblEmpleado.Text = dgvEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + dgvEmpleados.Rows[e.RowIndex].Cells[4].Value.ToString() + " " + dgvEmpleados.Rows[e.RowIndex].Cells[5].Value.ToString();
                    idEmpleado = dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();

                }
                



            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idEmpleado))
            {
                MessageBox.Show("Seleccione un Empleado y/o día valido");
            }
            else
            {
                conex = BDConexicon.BodegaOpen();
                //MessageBox.Show(idEmpleado);
                MySqlCommand cmdR = new MySqlCommand("DELETE FROM rd_asistencia  WHERE id=?id", conex);
                cmdR.Parameters.Add("?id", MySqlDbType.VarChar).Value = idEmpleado;
                cmdR.ExecuteNonQuery();
                conex.Close();
                lblEmpleado.Text = "---";
                idEmpleado = null;

                fecha = DateTime.Now.Date;
                conex = BDConexicon.BodegaOpen();
                fecha = dt_time.Value.Date;
                consultar();
                conex.Close();
            }
            
        }
    }
}
