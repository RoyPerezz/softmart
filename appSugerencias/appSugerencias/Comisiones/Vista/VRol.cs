using appSugerencias.Comisiones.Controlador;
using appSugerencias.Comisiones.Modelo;
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
    public partial class VRol : Form
    {
        private bool EsNuevo = false;       // Registro nuevo
        private bool EsEditar = false;      // Registro modificado
        private int varvalidacampos = 0;
        private int idMod = 0;
        List<MRol> listaRoles = new List<MRol>();

        public VRol()
        {
            InitializeComponent();
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
            tbRol.ReadOnly = !valor;
            //cbRol.Enabled = valor;
        }

        private void LimpiarTbx()
        {
            //tbCodigo.Text = string.Empty;
            tbRol.Text = string.Empty;
            chkBCalificaxSemana.Checked = false;
            //cbRol.SelectedValue = 0;
        }

        // Validar campos llenos
        private int ValidaCampos()
        {
            eprError.Clear();
            varvalidacampos = 0;
            //if (this.tbCodigo.Text == string.Empty)
            //{ eprError.SetError(tbCodigo, "Ingrese el número de empleado"); varvalidacampos++; }

            if (this.tbRol.Text == string.Empty)
            { eprError.SetError(tbRol, "Ingrese el nombre del empleado"); varvalidacampos++; }


            else { varvalidacampos--; }

            return varvalidacampos;
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
        private void AgregarRol()
        {
            string resultado = "";
            resultado = CRol.CAgregarRol(tbRol.Text.Trim().ToUpper(),
                                         chkBCalificaxSemana.Checked,
                                         MSesion.GetConexion()
                );

            if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            else this.MensajeError(resultado);
        }

        // Modificar empleados
        private void ModificarRol()
        {

            string resultado = "";
            resultado = CRol.CModificaRol(idMod,
                                           tbRol.Text.Trim().ToUpper(),
                                           chkBCalificaxSemana.Checked,
                                           MSesion.GetConexion()
               );

            if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            else this.MensajeError(resultado);
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            EsNuevo = true;
            EsEditar = false;
            HabilitarBtn();
            HabilitarTbx(true);
            LimpiarTbx();
            tbRol.Focus();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCampos();
                if (varvalidacampos >= 0) MensajeError("Faltan ingresar algunos datos, serán remarcados");
                else
                {
                    if (this.EsNuevo == true) AgregarRol();
                    else ModificarRol();

                    EsNuevo = false;
                    EsEditar = false;
                    HabilitarBtn();

                    LimpiarTbx();

                    listaRoles = CRol.CMostrarRoles(MSesion.GetConexion());
                    dgvRoles.DataSource = listaRoles.ToList();
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message + er.StackTrace);
            }
        }

        private void VRol_Load(object sender, EventArgs e)
        {
            try
            {
                btGuardar.Enabled = false;
                btCancelar.Enabled = false;
                listaRoles = CRol.CMostrarRoles(MSesion.GetConexion());
                dgvRoles.DataSource = listaRoles.ToList();
                dgvRoles.Columns[0].Visible = false;
                dgvRoles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvRoles.Columns[2].Visible = false;

                dgvRoles.Columns[3].Visible = false;
                dgvRoles.Columns[4].Visible = false;
                dgvRoles.Columns[1].Width = 280;


            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Iniciar: " + er.Message);
            }
        }

        private void dgvRoles_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.tbRol.Text = Convert.ToString(this.dgvRoles.CurrentRow.Cells["Rol"].Value);
            idMod = Convert.ToInt32(this.dgvRoles.CurrentRow.Cells["Id"].Value);
            chkBCalificaxSemana.Checked = Convert.ToBoolean(this.dgvRoles.CurrentRow.Cells["calificaxsemana"].Value);
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

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (!this.tbRol.Text.Equals(""))
            {
                this.EsEditar = true;
                this.HabilitarBtn();
                this.HabilitarTbx(true);

            }
            else this.MensajeError("Seleccione el rol a modificar");

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!this.tbBuscar.Text.Equals(""))
            {
                BuscarRol();
            }
            else this.MensajeError("Escriba nombre del empleado");
        }

        private void BuscarRol()
        {


            listaRoles = CRol.CConsultarRoles(tbBuscar.Text, MSesion.GetConexion());
            dgvRoles.DataSource = listaRoles.ToList();
        }

        private void Acciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
