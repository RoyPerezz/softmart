using appSugerencias.Gastos_Externos.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos_Externos.Vistas
{
    public partial class RegistrarPersonaGeneraGasto : Form
    {
        public RegistrarPersonaGeneraGasto()
        {
            InitializeComponent();
        }

        private void RegistrarPersonaGeneraGasto_Load(object sender, EventArgs e)
        {
            DG_tabla.Columns["ID"].Width = 80;
        }

        private void BT_registrar_Click(object sender, EventArgs e)
        {
            if (TB_nombre.Text.Equals(""))
            {
                MessageBox.Show("Debes escribir un nombre");
            }
            else
            {
                GastoFinanzasController.RegistrarPersonaQueGeneranGastos(TB_nombre.Text);
                BuscarPersona();
                MessageBox.Show("Se ha registrado la persona correctamente");
                TB_nombre.Text = "";
            }
           
        }


        public void BuscarPersona()
        {
            DataTable dt = GastoFinanzasController.BuscarNombreExactoGeneraGasto(TB_nombre.Text);
           
            foreach (DataRow item in dt.Rows)
            {
                DG_tabla.Rows.Add(item["ID"].ToString(), item["NOMBRE"].ToString());
            }
        }


        public void BuscarPersonaCoincidencia()
        {
            DataTable dt = GastoFinanzasController.BuscarPersonaGeneraGasto(TB_buscar_nombre.Text);
            DG_tabla.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                DG_tabla.Rows.Add(item["ID"].ToString(), item["NOMBRE"].ToString());
            }
        }
        private void Buscar_Click(object sender, EventArgs e)
        {
            BuscarPersonaCoincidencia();
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_modificar_nombre.Text = DG_tabla.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
            TB_id.Text = DG_tabla.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void BT_modificar_Click(object sender, EventArgs e)
        {
            GastoFinanzasController.ModificarPersonaQueGeneraGastos(TB_modificar_nombre.Text,Convert.ToInt32(TB_id.Text));
            TB_id.Text = "";
            TB_modificar_nombre.Text = "";
            BuscarPersonaCoincidencia();
            MessageBox.Show("Se ha modificado el registro");
        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            GastoFinanzasController.EliminarPersonaQueGeneraGastos(Convert.ToInt32(TB_id.Text));
            TB_id.Text = "";
            TB_modificar_nombre.Text = "";
            BuscarPersonaCoincidencia();
            MessageBox.Show("Se ha eliminado el registro");
        }
    }
}
