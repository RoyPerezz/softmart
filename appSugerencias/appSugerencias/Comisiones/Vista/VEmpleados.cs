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
    public partial class VEmpleados : Form
    {
        private bool EsNuevo = false;       // Registro nuevo
        private bool EsEditar = false;      // Registro modificado
        private int varvalidacampos = 0;
        List<MEmpleados> listaEmpleado = new List<MEmpleados>();
        List<MRol> listaRoles = new List<MRol>();
        public VEmpleados()
        {
            InitializeComponent();
            dgvEmpleados.DataSource = CEmpleado.CMostrarEmpleados2(MSesion.GetConexion());
            listaRoles = CRol.CMostrarRoles(MSesion.GetConexion());

            cbRol.DisplayMember = "Rol";
            cbRol.ValueMember = "Id";
            cbRol.DataSource = listaRoles.ToList();
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
            tbCodigo.ReadOnly = !valor;
            tbNombre.ReadOnly = !valor;
            cbRol.Enabled = valor;
        }

        private void LimpiarTbx()
        {
            tbCodigo.Text = string.Empty;
            tbNombre.Text = string.Empty;
            cbRol.SelectedValue = 0;
        }

        // Validar campos llenos
        private int ValidaCampos()
        {
            eprError.Clear();
            varvalidacampos = 0;
            if (this.tbCodigo.Text == string.Empty)
            { eprError.SetError(tbCodigo, "Ingrese el número de empleado"); varvalidacampos++; }

            if (this.tbNombre.Text == string.Empty)
            { eprError.SetError(tbNombre, "Ingrese el nombre del empleado"); varvalidacampos++; }


            else { varvalidacampos--; }

            return varvalidacampos;
        }
        private void AgregarEmpleado()
        {
            string resultado = "";
            if (cbRol.Text == "CAJAS")
            {
                resultado = CEmpleado.CAgregarEmpleado(tbCodigo.Text.Trim(),
                                                                   tbNombre.Text.Trim().ToUpper(),
                                                                   tbUsuario.Text.Trim().ToUpper(),
                                                                   Convert.ToInt32(cbRol.SelectedValue.ToString()),
                                                                   MSesion.GetConexion()
                                );
            }
            else
            {
                resultado = CEmpleado.CAgregarEmpleado(tbCodigo.Text.Trim(),
                                                   tbNombre.Text.Trim().ToUpper(),
                                                   null,
                                                   Convert.ToInt32(cbRol.SelectedValue.ToString()),
                                                   MSesion.GetConexion()
                );
            }


            if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            else this.MensajeError(resultado);
        }

        // Modificar empleados
        private void ModificarEmpleado()
        {

            string resultado = "";
            if (cbRol.Text == "CAJAS")
            {
                resultado = CEmpleado.CModificaEmpleado(tbCodigo.Text.Trim(),
                                                 tbNombre.Text.Trim().ToUpper(),
                                                 tbUsuario.Text.Trim().ToUpper(),
                                                 Convert.ToInt32(cbRol.SelectedValue.ToString()),
                                                 MSesion.GetConexion()
              );

            }
            else
            {
                resultado = CEmpleado.CModificaEmpleado(tbCodigo.Text.Trim(),
                                                tbNombre.Text.Trim().ToUpper(),
                                                null,
                                                Convert.ToInt32(cbRol.SelectedValue.ToString()),
                                                MSesion.GetConexion()
             );
            }

            if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            else this.MensajeError(resultado);
        }

        // Consultar empleado
        private void BuscarEmpleado()
        {

            listaEmpleado = CEmpleado.CConsultaEmpleado(tbBuscar.Text.Trim(), MSesion.GetConexion());
            dgvEmpleados.DataSource = listaEmpleado.ToList();
            dgvEmpleados.Columns[2].Visible = false;
            dgvEmpleados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEmpleados.Columns[3].Width = 150;
            dgvEmpleados.Columns["Conex"].Visible = false;


        }
        // Eliminar empleados
        private void EliminarEmpleado()
        {

            string resultado = "";
            resultado = CEmpleado.CEliminaEmpleado(tbCodigo.Text.Trim(),
                                                  MSesion.GetConexion()
               );

            if (resultado.Equals("ok")) this.MensajeOK("Se ingreso correctamente el registro");
            else this.MensajeError(resultado);
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

        private void VEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                btGuardar.Enabled = false;
                btCancelar.Enabled = false;
                //listaEmpleado = CEmpleado.CMostrarEmpleados2(BDConexicon.conectar());
                //dgvEmpleados.DataSource = listaEmpleado.ToList();


                //dgvEmpleados.Columns[2].Visible = false;
                dgvEmpleados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvEmpleados.Columns[3].Width = 150;
                //dgvEmpleados.Columns[2].Visible = false;

                //dgvEmpleados.Columns[6].Visible = true;
                //dgvEmpleados.Columns[7].Visible = false;

                //RellenarComboBox.rellenaRolTrabajo(BDconexion.conectar(), cbRol);

            }
            catch (Exception er)
            {
                MessageBox.Show("Error al Iniciar: " + er.Message);
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            EsNuevo = true;
            EsEditar = false;
            HabilitarBtn();
            HabilitarTbx(true);
            tbCodigo.Focus();
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
            if (!this.tbCodigo.Text.Equals(""))
            {
                this.EsEditar = true;
                this.HabilitarBtn();
                this.HabilitarTbx(true);
                //this.ckbModificaSucursal.Enabled = true;
            }
            else this.MensajeError("Seleccione el rol a modificar");
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (!this.tbCodigo.Text.Equals(""))
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea dar de baja al empleado", "Baja empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    EliminarEmpleado();
                }
            }
            else this.MensajeError("Seleccione el empleado a dar de baja");
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (!this.tbBuscar.Text.Equals(""))
            {
                BuscarEmpleado();
            }
            else this.MensajeError("Escriba nombre del empleado");
        }

        private void dgvEmpleados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.tbCodigo.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["codigo"].Value);
            this.tbNombre.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["nombre"].Value);
            cbRol.SelectedValue = Convert.ToInt32(this.dgvEmpleados.CurrentRow.Cells["rol"].Value);

            //MessageBox.Show("SelectedValue"+ cbRol.SelectedValue.ToString());
            //MessageBox.Show("SelectedText" + cbRol.SelectedText.ToString());
            //MessageBox.Show("SelectedItem" + cbRol.SelectedItem.ToString());


            if (cbRol.Text == "CAJAS")
            {
                lblUsuario.Visible = true;
                tbUsuario.Visible = true;
                this.tbUsuario.Text = Convert.ToString(this.dgvEmpleados.CurrentRow.Cells["usuario"].Value);
            }
            else
            {
                lblUsuario.Visible = false;
                tbUsuario.Visible = false;
            }
        }

        private void cbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbRol.Text == "CAJAS")
            {
                lblUsuario.Visible = true;
                tbUsuario.Visible = true;

            }
            else
            {
                lblUsuario.Visible = false;
                tbUsuario.Visible = false;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCampos();
                if (varvalidacampos >= 0) MensajeError("Faltan ingresar algunos datos, serán remarcados");
                else
                {
                    if (this.EsNuevo == true) AgregarEmpleado();
                    else ModificarEmpleado();

                    EsNuevo = false;
                    EsEditar = false;
                    HabilitarBtn();

                    LimpiarTbx();

                    dgvEmpleados.DataSource = CEmpleado.CMostrarEmpleados2(MSesion.GetConexion());
                    listaRoles = CRol.CMostrarRoles(MSesion.GetConexion());


                    dgvEmpleados.Columns[2].Visible = false;
                    dgvEmpleados.Columns[1].Width = 180;
                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message + er.StackTrace);
            }
        }
    }
}
