using appSugerencias.Comisiones.Controlador;
using appSugerencias.Comisiones.Modelo;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace appSugerencias.Comisiones.Vista
{

    public partial class VCalificar : Form
    {
        private bool EsNuevo = false;       // Registro nuevo
        private bool EsEditar = false;      // Registro modificado
        private int varvalidacampos = 0;
        private int IdRol = 0;
        private int IdTarea = 0;
        List<MRol> listaRoles = new List<MRol>();
        List<MEmpleados> ListEmpleados = new List<MEmpleados>();
        System.Data.DataTable dtCalificaciones = new System.Data.DataTable();
        System.Data.DataTable dtAuxiliar = new System.Data.DataTable();
        System.Data.DataTable dtRevisarCalificacion = new System.Data.DataTable();
        
        public VCalificar()
        {
            InitializeComponent();
            MostrarFechas();
            MostrarFechasReporte();
            MostrarFechasReporte2();
        }

        private void VCalificar_Load(object sender, EventArgs e)
        {
            try
            {
                listaRoles = CRol.CMostrarRoles(BDConexicon.conectar());
                cbRol.DisplayMember = "Rol";
                cbRol.ValueMember = "Id";
                cbRol.DataSource = listaRoles.ToList();

                cbRolReporte.DisplayMember = "Rol";
                cbRolReporte.ValueMember = "Id";
                cbRolReporte.DataSource = listaRoles.ToList();

                btEditarCalif.Enabled = false;
                btGenerarReporte.Enabled = false;
            }catch(Exception er)
            {
                MessageBox.Show("Error al Iniciar: " + er.Message);
            }
            
        }

        public void MostrarFechas()
        {
            DateTime fecha1 = dtpFechaInicial.Value;
            DateTime fecha2 = dtpFechaInicial.Value;
            bool califXSemana = DefineCalifXSemana();
            if (califXSemana)
            {
                fecha2 = fecha2.AddDays(6);
                dtpFechaFin.Value = fecha2.Date;
            }
            else
            {
                dtpFechaFin.Value = fecha2.Date;
            }

            lbFechas.Text = $"Del {fecha1.ToString("D")} al {fecha2.ToString("D")}";
        }

        public void MostrarFechasReporte()
        {
            DateTime fecha1 = dtpFechaRevision.Value;
            DateTime fecha2 = dtpFechaRevision.Value;
            //bool califXSemana = DefineCalifXSemana();
            if (ckbSemana.Checked)
            {
                fecha2 = fecha2.AddDays(6);
                //dtpFechaFin.Value = fecha2.Date;
            }


            lbFechasReporte.Text = $"Del {fecha1.ToString("D")} al {fecha2.ToString("D")}";
        }

        public void MostrarFechasReporte2()
        {
            DateTime fecha1 = dtpFechaReporte.Value;
            DateTime fecha2 = dtpFechaReporte.Value;

            fecha2 = fecha2.AddDays(6);
            lblFechaReporte2.Text = $"Del {fecha1.ToString("D")} al {fecha2.ToString("D")}";
        }

        public bool DefineCalifXSemana()
        {
            //Revisamos si el rol se califica por semana

            bool semana = false;
            foreach (var role in listaRoles)
            {
                if (role.Id == Convert.ToInt32(cbRol.SelectedValue))
                {

                    if (Convert.ToBoolean(role.CalificaXSemana))
                    {

                        semana = true;
                    }
                    else
                    {
                        semana = false;
                    }

                    break;
                }
            }
            return semana;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarFechas();
                int calificacion, score, calif;
                string columnaTopeAMostrar;
                string columnaTopeAOcultar;
                bool califXSemana = DefineCalifXSemana();
                System.Data.DataTable dtTareas = new System.Data.DataTable();
                System.Data.DataTable dtEmpleados = new System.Data.DataTable();
                if (califXSemana)
                {
                    columnaTopeAMostrar = "TOPE SEMANAL";
                    columnaTopeAOcultar = "TOPE DIARIO";
                }
                else
                {
                    columnaTopeAMostrar = "TOPE DIARIO";
                    columnaTopeAOcultar = "TOPE SEMANAL";
                }

                if (dtCalificaciones.Columns.Count > 0)
                {
                    for (int i = dtCalificaciones.Columns.Count - 1; i >= 0; i--)
                    {

                        dtCalificaciones.Columns.RemoveAt(i);

                    }

                    for (int i = dtCalificaciones.Rows.Count - 1; i >= 0; i--)
                    {

                        dtCalificaciones.Rows.RemoveAt(i);

                    }
                }

                dtCalificaciones.Columns.Add("idtarea", typeof(String));
                dtCalificaciones.Columns.Add("DESCRIPCION", typeof(String));
                dtCalificaciones.Columns.Add("TOPE DIARIO", typeof(String));
                dtCalificaciones.Columns.Add("TOPE SEMANAL", typeof(String));



                IdRol = Convert.ToInt32(cbRol.SelectedValue.ToString());
                dtTareas = CTarea.CMostrarTareas(IdRol, MSesion.GetConexion());
                dtEmpleados = CEmpleado.CMostrarEmpleados2(MSesion.GetConexion());
                //dgvCalificaciones.DataSource = CTarea.CMostrarTareas(IdRol, BDConexicon.conectar());
                ListEmpleados.Clear();
                foreach (DataRow row in dtTareas.Rows)
                {
                    dtCalificaciones.Rows.Add(row["idtarea"].ToString(), row["DESCRIPCION"].ToString(), row["TOPE DIARIO"].ToString(), row["TOPE SEMANAL"].ToString());
                }
                foreach (DataRow row in dtEmpleados.Rows)
                {
                    if (Convert.ToInt32(row["rol"].ToString()) == Convert.ToInt32(cbRol.SelectedValue))
                    {

                        MEmpleados oEmpleado = new MEmpleados();
                        oEmpleado.Codigo = row["codigo"].ToString();
                        oEmpleado.Nombre = row["nombre"].ToString();
                        //Agregamos los empleados que conforman la tabla a calificar
                        ListEmpleados.Add(oEmpleado);


                        dtCalificaciones.Columns.Add(row["nombre"].ToString(), typeof(String));

                    }


                }
                score = 0;
                foreach (var empleado in ListEmpleados)
                {
                    score = 0;
                    for (int i = 0; i < dtCalificaciones.Rows.Count; i++)
                    {
                        calificacion = Convert.ToInt32(dtCalificaciones.Rows[i][columnaTopeAMostrar].ToString());
                        score = score + calificacion;
                        empleado.Score = empleado.Score + calificacion / 2;
                        dtCalificaciones.Rows[i][empleado.Nombre] = calificacion / 2;
                    }

                }



                if (califXSemana)
                {
                    dtCalificaciones.Rows.Add(-1, "TOTAL", 0, score);
                }
                else
                {
                    dtCalificaciones.Rows.Add(-1, "TOTAL", score);
                }
                int x = dtCalificaciones.Rows.Count - 1;
                foreach (var empleado in ListEmpleados)
                {
                    dtCalificaciones.Rows[x][empleado.Nombre] = empleado.Score;
                }


                dgvCalificaciones.DataSource = null;
                dgvCalificaciones.DataSource = dtCalificaciones;
                dgvCalificaciones.Columns["idtarea"].Visible = false;
                dgvCalificaciones.Columns[columnaTopeAOcultar].Visible = false;
                dgvCalificaciones.Columns["DESCRIPCION"].Width = 350;
                dgvCalificaciones.Columns["DESCRIPCION"].Frozen = true;
                dgvCalificaciones.Columns[columnaTopeAMostrar].Frozen = true;

                foreach (DataGridViewColumn Col in dgvCalificaciones.Columns)
                {
                    Col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                if (dtCalificaciones.Columns.Count > 2)
                    btGuardar.Enabled = true;
                else
                    btGuardar.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Iniciar: " + er.Message);
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int calificacion, tope;
            bool error = false;
            string resultado = "";

            try
            {
                foreach (var empleados in ListEmpleados)
                {
                    for (int i = 0; i < dgvCalificaciones.Rows.Count; i++)
                    {

                        tope = Convert.ToInt32(dgvCalificaciones.Rows[i].Cells["TOPE DIARIO"].Value.ToString());
                        calificacion = Convert.ToInt32(dgvCalificaciones.Rows[i].Cells[empleados.Nombre].Value.ToString());
                        if (calificacion > tope)
                        {
                            error = true;
                            dgvCalificaciones.Rows[i].Cells[empleados.Nombre].Style.BackColor = Color.Red;
                            break;
                        }



                    }

                }

                if (error)
                {
                    MessageBox.Show("Calificacion con error");
                }
                else
                {
                    foreach (var empleados in ListEmpleados)
                    {
                        for (int i = 0; i < dgvCalificaciones.Rows.Count; i++)
                        {

                            tope = Convert.ToInt32(dgvCalificaciones.Rows[i].Cells["TOPE DIARIO"].Value.ToString());
                            calificacion = Convert.ToInt32(dgvCalificaciones.Rows[i].Cells[empleados.Nombre].Value.ToString());
                            if (calificacion > tope)
                            {
                                error = true;
                                dgvCalificaciones.Rows[i].Cells[empleados.Nombre].Style.BackColor = Color.Red;
                                break;
                            }

                            resultado = CCalificacion.CAgregarCalificacion(Convert.ToInt32(dgvCalificaciones.Rows[i].Cells["idtarea"].Value.ToString()),
                                                                Convert.ToInt32(cbRol.SelectedValue.ToString()),
                                                                empleados.Codigo,
                                                                Convert.ToInt32(dgvCalificaciones.Rows[i].Cells[empleados.Nombre].Value.ToString()),
                                                                dtpFechaInicial.Value,
                                                                dtpFechaFin.Value,
                                                                MSesion.GetConexion()
                                                                );



                        }

                    }
                }
                if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");

            }
            catch (Exception er)
            {
                this.MensajeError("No se guardaron los datos");
            }

        }

        //******************************  Revision calificaciones

        public void MostrarCalificaciones(string codigo, DateTime fechaAux)
        {
            btEditarCalif.Enabled = true;
            //DateTime fechaInicio = dtpFechaRevision.Value;
            DateTime fechaInicio = fechaAux;
            DateTime fechaFin = fechaInicio;

            if (ckbSemana.Checked)
            {
                fechaFin = fechaFin.AddDays(6);


            }




            if (dtRevisarCalificacion.Columns.Count > 0)
            {
                for (int i = dtRevisarCalificacion.Columns.Count - 1; i >= 0; i--)
                {

                    dtRevisarCalificacion.Columns.RemoveAt(i);

                }

                for (int i = dtRevisarCalificacion.Rows.Count - 1; i >= 0; i--)
                {

                    dtRevisarCalificacion.Rows.RemoveAt(i);

                }
            }
            dtRevisarCalificacion.Columns.Add("NOMBRE", typeof(String));
            dtRevisarCalificacion.Columns.Add("TAREA", typeof(String));
            dtRevisarCalificacion.Columns.Add("CALIFICACION", typeof(String));
            dtRevisarCalificacion.Columns.Add("TOPE DIARIO", typeof(String));
            dtRevisarCalificacion.Columns.Add("TOPE SEMANAL", typeof(String));
            dtRevisarCalificacion.Columns.Add("ROL", typeof(String));
            dtRevisarCalificacion.Columns.Add("idcalificacion", typeof(String));
            dtRevisarCalificacion.Columns.Add("idtarea", typeof(String));
            dtRevisarCalificacion.Columns.Add("idrol", typeof(String));
            dtRevisarCalificacion.Columns.Add("idempleado", typeof(String));

            dtRevisarCalificacion.Columns.Add("fechainicio", typeof(String));
            dtRevisarCalificacion.Columns.Add("fechafin", typeof(String));



            dtAuxiliar = CCalificacion.CMostrarCalificacion(codigo, fechaInicio, fechaFin, MSesion.GetConexion());

            foreach (DataRow row in dtAuxiliar.Rows)
            {
                dtRevisarCalificacion.Rows.Add(row["nombre"].ToString(),
                                          row["descripcion"].ToString(),
                                          row["calificacion"].ToString(),
                                          row["topediario"].ToString(),
                                          row["topesemanal"].ToString(),
                                          row["nombre_rol"].ToString(),
                                          row["idcalificacion"].ToString(),
                                          row["idtarea"].ToString(),
                                          row["idrol"].ToString(),
                                          row["idempleado"].ToString(),
                                          row["fechainicio"].ToString(),
                                          row["fechafin"].ToString()
                                         );
            }

            dgvRevisarTareas.DataSource = null;
            dgvRevisarTareas.DataSource = dtRevisarCalificacion;

            dgvRevisarTareas.Columns["idcalificacion"].Visible = false;
            dgvRevisarTareas.Columns["idtarea"].Visible = false;
            dgvRevisarTareas.Columns["idrol"].Visible = false;
            dgvRevisarTareas.Columns["idempleado"].Visible = false;
            dgvRevisarTareas.Columns["fechainicio"].Visible = false;
            dgvRevisarTareas.Columns["fechafin"].Visible = false;
            dgvRevisarTareas.Columns["NOMBRE"].Width = 350;
            dgvRevisarTareas.Columns["TAREA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (ckbSemana.Checked)
            {

                dgvRevisarTareas.Columns["TOPE SEMANAL"].Visible = true;
                dgvRevisarTareas.Columns["TOPE DIARIO"].Visible = false;
            }
            else
            {
                dgvRevisarTareas.Columns["TOPE SEMANAL"].Visible = false;
            }

            dgvRevisarTareas.Columns["NOMBRE"].Visible = false;
            dgvRevisarTareas.Columns["ROL"].Visible = false;

        }
        public void MostrarSumaCalificiaciones()
        {
            btEditarCalif.Enabled = false;
            DateTime fechaInicio = dtpFechaRevision.Value;
            DateTime fechaFin = fechaInicio;

            if (ckbSemana.Checked)
            {
                fechaFin = fechaFin.AddDays(6);

            }
            dtAuxiliar = CCalificacion.CMostrarSumaCalificacion(fechaInicio, fechaFin, MSesion.GetConexion());
            dgvRevisionCalif.DataSource = null;
            dgvRevisionCalif.DataSource = dtAuxiliar;
            dgvRevisionCalif.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRevisionCalif.Columns["codigo"].Visible = false;
            dgvRevisionCalif.Columns["fechaInicio"].Visible = false;
            dgvRevisionCalif.Columns["TOPE DIARIO"].Visible = false;
            dgvRevisionCalif.Columns["TOPE SEMANAL"].Visible = false;


        }

        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            MostrarFechas();
        }

        private void btEditarCalif_Click(object sender, EventArgs e)
        {
            if (dgvRevisionCalif.Rows.Count > 0)
            {
                try
                {
                    string resultado = "";
                    for (int i = 0; i < dgvRevisionCalif.Rows.Count; i++)
                    {
                        resultado = CCalificacion.CModificarCalificacion(Convert.ToInt32(dgvRevisionCalif.Rows[i].Cells["idcalificacion"].Value.ToString()),
                                                             dgvRevisionCalif.Rows[i].Cells["idempleado"].Value.ToString(),
                                                             Convert.ToInt32(dgvRevisionCalif.Rows[i].Cells["calificacion"].Value.ToString()),
                                                             Convert.ToDateTime(dgvRevisionCalif.Rows[i].Cells["fechainicio"].Value.ToString()),
                                                             MSesion.GetConexion()

                        );
                    }
                    if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
                    MostrarSumaCalificiaciones();
                }
                catch (Exception er)
                {
                    this.MensajeError("No se guardaron los datos");
                }
            }
            else
            {

            }
        }

        private void dtpFechaRevision_ValueChanged(object sender, EventArgs e)
        {
            MostrarFechasReporte();
        }

        private void ckbSemana_CheckedChanged(object sender, EventArgs e)
        {
            MostrarFechasReporte();
        }

        private void ActualizaColumnaScore()
        {
            int score = 0;

            foreach (var empleado in ListEmpleados)
            {

                for (int i = 0; i < dgvCalificaciones.Rows.Count - 1; i++)
                {

                    if (dgvCalificaciones.Rows[i].Cells[empleado.Nombre].Value != null)
                    {
                        if (dgvCalificaciones.Rows[i].Cells[empleado.Nombre].Value.ToString().Length != 0)
                        {
                            score += int.Parse(dgvCalificaciones.Rows[i].Cells[empleado.Nombre].Value.ToString());
                        }
                    }
                }

                dgvCalificaciones.Rows[dgvCalificaciones.Rows.Count - 1].Cells[empleado.Nombre].Value = score;
                score = 0;
            }
            //int x = dgvCalificaciones.Rows.Count - 1;
            //foreach (var empleado in ListEmpleados)
            //{
            //    dgvCalificaciones.Rows[3].Cells[empleado.Nombre].Value = 100;
            //}

        }

        private void dgvCalificaciones_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            ActualizaColumnaScore();
        }

        // Mostrar mensaje de OK
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ImprimeReporteSumaMonto()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            excel.Range["A1:A1000"].NumberFormat = "@";

            int indiceFila = 2;

            excel.Range["A1:A1000"].NumberFormat = "@";

            excel.Cells[1, "A"] = "Monto";
            excel.Cells[1, "B"] = "Nombre";
            excel.Cells[1, "C"] = "Rol";
            for (int i = 0; i < dgvReporte.Rows.Count; i++)
            {
                excel.Cells[indiceFila, "A"] = dgvReporte.Rows[i].Cells["MONTO"].Value.ToString();
                excel.Cells[indiceFila, "B"] = dgvReporte.Rows[i].Cells["NOMBRE"].Value.ToString();
                excel.Cells[indiceFila, "C"] = dgvReporte.Rows[i].Cells["ROL"].Value.ToString();
                indiceFila++;
            }

            excel.Visible = true;
        }

        private void dtpFechaReporte_ValueChanged(object sender, EventArgs e)
        {
            MostrarFechasReporte2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //btEditarCalif.Enabled = false;
            DateTime fechaInicio = dtpFechaReporte.Value;
            DateTime fechaFin = fechaInicio;

            fechaFin = fechaFin.AddDays(6);
            IdRol = Convert.ToInt32(cbRolReporte.SelectedValue.ToString());

            dtAuxiliar = CCalificacion.CMostrarSumaCalificacionXRol(fechaInicio, fechaFin, IdRol, MSesion.GetConexion());
            dgvReporte.DataSource = null;
            dgvReporte.DataSource = dtAuxiliar;
            dgvReporte.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReporte.Columns["ROL"].Width = 180;
            dgvReporte.Columns["TOPE DIARIO"].Visible = false;
            dgvReporte.Columns["TOPE SEMANAL"].Visible = false;

            if (dgvReporte.Rows.Count > 0)
            {
                btGenerarReporte.Enabled = true;
            }
            else
            {
                btGenerarReporte.Enabled = false;
            }
        }

        private void btGenerarReporte_Click(object sender, EventArgs e)
        {
            var excelApp = new Excel.Application();

            excelApp.Workbooks.Add();

            Excel._Worksheet worksheet = (_Worksheet)excelApp.ActiveSheet;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            int indiceFila = 2;
            int monto;
            dtAuxiliar.DefaultView.Sort = "NOMBRE";
            dtAuxiliar = dtAuxiliar.DefaultView.ToTable();
            worksheet.Cells[1, "A"] = "NOMBRE";
            worksheet.Cells[1, "B"] = "ROL";
            worksheet.Cells[1, "C"] = "MONTO";
            worksheet.Cells[1, "D"] = "FIRMA";
            worksheet.Cells[1, "E"] = "OBSERVACION";


            foreach (DataRow row in dtAuxiliar.Rows)
            {
                worksheet.Cells[indiceFila, "A"] = row["NOMBRE"];
                worksheet.Cells[indiceFila, "B"] = row["ROL"];

                monto = Convert.ToInt32(row["MONTO"].ToString());
                worksheet.Cells[indiceFila, "C"] = monto.ToString("C");
                worksheet.Cells[indiceFila, "D"] = "";
                worksheet.Cells[indiceFila, "E"] = "";
                indiceFila++;
            }


            //Contraseña del archivo
            //worksheet.Protect("DaNxD");


            excelApp.Visible = true;
        }

        private void dgvRevisionCalif_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = dgvRevisionCalif.Rows[e.RowIndex].Cells[0].Value.ToString();
            DateTime fechaAux = Convert.ToDateTime(dgvRevisionCalif.Rows[e.RowIndex].Cells[1].Value.ToString());

            lblCodigo.Text = codigo;
            lblNombre.Text = dgvRevisionCalif.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
            MostrarCalificaciones(codigo, fechaAux);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarSumaCalificiaciones();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}
