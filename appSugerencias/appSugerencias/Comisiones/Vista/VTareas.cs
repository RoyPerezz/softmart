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

namespace appSugerencias.Comisiones.Vista
{
    public partial class VTareas : Form
    {
        private bool EsNuevo = false;       // Registro nuevo
        private bool EsEditar = false;      // Registro modificado
        private int varvalidacampos = 0;
        private int IdRol = 0;
        private int IdTarea = 0;
        const int diasTopeSemanal = 6;
        List<MRol> listaRoles = new List<MRol>();
        public VTareas()
        {
            InitializeComponent();
            dgvTareas.RowHeadersVisible = false;
        }

        private void HabilitarBtn()
        {
            if (this.EsNuevo || this.EsEditar)
            {
                HabilitarTbx(true);
                btNuevo.Enabled = false;
                btModificar.Enabled = false;
                btEliminar.Enabled = false;
                btBuscar.Enabled = false;
                //btImprimir.Enabled = false;
                btGuardar.Enabled = true;
                btCancelar.Enabled = true;
            }
            else
            {
                HabilitarTbx(false);
                btNuevo.Enabled = true;
                btModificar.Enabled = true;
                btEliminar.Enabled = true;
                btBuscar.Enabled = true;
                //btImprimir.Enabled = true;
                btGuardar.Enabled = false;
                btCancelar.Enabled = false;
            }
        }

        private void HabilitarTbx(bool valor)
        {
            //tbCodigo.ReadOnly = !valor;
            tbDescripcion.ReadOnly = !valor;
            //cbRol.Enabled = valor;
        }

        private void LimpiarTbx()
        {
            //tbRol.Text = string.Empty;
            tbDescripcion.Text = string.Empty;
            //cbRol.SelectedValue = 0;
            nudTopeDiario.Value = 0;
            nudTopeSemanal.Value = 0;
        }

        // Validar campos llenos
        private int ValidaCampos()
        {
            eprError.Clear();
            varvalidacampos = 0;
            //if (this.tbCodigo.Text == string.Empty)
            //{ eprError.SetError(tbCodigo, "Ingrese el número de empleado"); varvalidacampos++; }

            if (this.tbDescripcion.Text == string.Empty)
            { eprError.SetError(tbDescripcion, "Ingrese el nombre del empleado"); varvalidacampos++; }


            else { varvalidacampos--; }

            return varvalidacampos;
        }

        private void VTareas_Load(object sender, EventArgs e)
        {
            try
            {
                btGuardar.Enabled = false;
                btCancelar.Enabled = false;
                listaRoles = CRol.CMostrarRoles(MSesion.GetConexion());
                cbRol.DisplayMember = "Rol";
                cbRol.ValueMember = "Id";
                cbRol.DataSource = listaRoles.ToList();
                dgvTareas.Columns[0].Visible = false;
                //nudTopeDiario.Value = 15;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Iniciar: " + er.Message);
            }
}

        private void btBuscar_Click(object sender, EventArgs e)
        {
            dgvTareas.DataSource = null;
            IdRol = Convert.ToInt32(cbRol.SelectedValue.ToString());
            tbRol.Text = cbRol.Text;
            dgvTareas.DataSource = CTarea.CMostrarTareas(IdRol, MSesion.GetConexion());
            dgvTareas.Columns["idtarea"].Visible = false;
            dgvTareas.Columns["idrol"].Visible = false;
            dgvTareas.Columns["DESCRIPCION"].Width = 350;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            EsNuevo = true;
            EsEditar = false;
            HabilitarBtn();
            HabilitarTbx(true);
            tbDescripcion.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.EsEditar = false;
            this.EsNuevo = false;
            this.HabilitarBtn();
            this.HabilitarTbx(false);
            this.LimpiarTbx();
            this.eprError.Clear();
        }
        // Mensaje de OK
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SiiAsistencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Agregar Tarea
        private void AgregarTarea()
        {
            string resultado = "";
            resultado = CTarea.CAgregarTarea(IdRol,
                                                    tbDescripcion.Text.Trim().ToUpper(),
                                                   Convert.ToInt32(nudTopeDiario.Value),
                                                   Convert.ToInt32(nudTopeSemanal.Value),
                                                   MSesion.GetConexion()
                );

            if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            else this.MensajeError(resultado);
        }

        // Modificar empleados
        private void ModificarTarea()
        {

            string resultado = "";
            resultado = CTarea.CModificarTarea(IdTarea,
                                                  tbDescripcion.Text.Trim().ToUpper(),
                                                  Convert.ToInt32(nudTopeDiario.Value),
                                                  Convert.ToInt32(nudTopeSemanal.Value),
                                                  MSesion.GetConexion()
               );

            if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            else this.MensajeError(resultado);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCampos();
                if (varvalidacampos >= 0) MensajeError("Faltan ingresar algunos datos, serán remarcados");
                else
                {
                    if (this.EsNuevo == true) AgregarTarea();
                    else ModificarTarea();

                    EsNuevo = false;
                    EsEditar = false;
                    HabilitarBtn();

                    LimpiarTbx();

                    //IdRol = Convert.ToInt32(cbRol.SelectedValue.ToString());
                    //tbRol.Text = cbRol.Text;
                    dgvTareas.DataSource = CTarea.CMostrarTareas(IdRol, MSesion.GetConexion());
                    dgvTareas.Columns["idtarea"].Visible = false;
                    dgvTareas.Columns["idrol"].Visible = false;
                    dgvTareas.Columns["DESCRIPCION"].Width = 350;
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message + er.StackTrace);
            }
        }

        private void dgvTareas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //this.tbCodigo.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["codigo"].Value);
            this.tbDescripcion.Text = Convert.ToString(this.dgvTareas.CurrentRow.Cells["DESCRIPCION"].Value);
            IdTarea = Convert.ToInt32(this.dgvTareas.CurrentRow.Cells["idtarea"].Value);
            nudTopeDiario.Value = Convert.ToInt32(this.dgvTareas.CurrentRow.Cells["TOPE DIARIO"].Value);
            nudTopeSemanal.Value = Convert.ToInt32(this.dgvTareas.CurrentRow.Cells["TOPE SEMANAL"].Value);
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (!this.tbDescripcion.Text.Equals(""))
            {
                this.EsEditar = true;
                this.HabilitarBtn();
                this.HabilitarTbx(true);

            }
            else this.MensajeError("Seleccione el rol a modificar");
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.Rows.Count > 0)
            {
                try
                {
                    DialogResult DialogoOpcion;
                    DialogoOpcion = MessageBox.Show("¿Desea eliminar las tareas marcadas?", "Comisiones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    string resultado = "";
                    if (DialogoOpcion == DialogResult.OK)
                    {
                        string codigo;

                        resultado = "";
                        foreach (DataGridViewRow row in dgvTareas.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                codigo = Convert.ToString(row.Cells[1].Value);
                                resultado = CTarea.CEliminaTarea(Convert.ToInt32(codigo), MSesion.GetConexion());

                                if (resultado.Equals("ok")) this.MensajeOK("Sub Area eliminada correctamente");
                                else this.MensajeError(resultado);
                            }
                        }

                        //MostrarSubAreas();
                        cbxEliminar.Checked = false;
                    }

                }
                catch (Exception er) { MessageBox.Show(er.Message + er.StackTrace); }
            }
            else { MensajeError("No hay tareas seleccionadas"); }
        }

        private void cbxEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEliminar.Checked)
            {
                this.dgvTareas.Columns[0].Visible = true;
                LimpiarTbx();
                btNuevo.Enabled = false;
                btModificar.Enabled = false;
                //btnImprimir.Enabled = false;

            }
            else
            {
                this.dgvTareas.Columns[0].Visible = false;
                HabilitarBtn();
            }
        }

        public int TopeSemanal(int valor)
        {
            if(valor> 0)
            {
                valor = valor * diasTopeSemanal;
                return valor;
            }
            else
            {
                return 0;
            }
           
        }

        private void nudTopeDiario_ValueChanged(object sender, EventArgs e)
        {
          nudTopeSemanal.Value= TopeSemanal(Convert.ToInt32(nudTopeDiario.Value));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
