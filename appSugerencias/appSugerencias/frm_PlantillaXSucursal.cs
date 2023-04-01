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
    public partial class frm_PlantillaXSucursal : Form
    {
        public frm_PlantillaXSucursal()
        {
            InitializeComponent();
        }

        MySqlConnection Conex;

        private void frm_PlantillaXSucursal_Load(object sender, EventArgs e)
        {
            dgvAreas.Rows.Add();
            dgvAreas.Rows[0].Cells[0].Value = "Cajeras";
            dgvAreas.Rows.Add();
            dgvAreas.Rows[1].Cells[0].Value = "Verificadores";
            dgvAreas.Rows.Add();
            dgvAreas.Rows[2].Cells[0].Value = "Hostess";
            dgvAreas.Rows.Add();
            dgvAreas.Rows[3].Cells[0].Value = "Piso de Venta";
            dgvAreas.Rows.Add();
            dgvAreas.Rows[4].Cells[0].Value = "Bodegueros";
            dgvAreas.Rows.Add();
            dgvAreas.Rows[5].Cells[0].Value = "Etiquetadores";
        }

        public void Consulta()
        {
            DateTime fecha=dt_fecha.Value.Date;


           
            string comando;
            string suc="";
            for (int i = 1; i < dgvAreas.ColumnCount; i++)
            {
                if (i == 1)
                {
                    suc = "VA";
                }
                else if (i == 2)
                {
                    suc = "RE";
                }
                else if (i == 3)
                {
                    suc = "CO";
                }
                else if(i==4)
                {
                    suc = "VL";
                }
                else if (i == 5)
                {
                    suc = "CEDIS";
                }
                comando = "SELECT COUNT(fk_empleado) AS cajera FROM rd_asistencia WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND tienda='"+suc+"' AND area='CAJAS'";
                MySqlCommand cmdr = new MySqlCommand(comando, Conex);
                MySqlDataReader dr_vc = cmdr.ExecuteReader();

                while (dr_vc.Read())
                {
                    dgvAreas.Rows[0].Cells[i].Value = dr_vc["cajera"].ToString();
                }
                dr_vc.Close();

                comando = "SELECT COUNT(fk_empleado) AS VERIFICA FROM rd_asistencia WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND tienda='" + suc + "' AND area='VERIFICADOR'";
                MySqlCommand cmdr_vv = new MySqlCommand(comando, Conex);
                MySqlDataReader dr_vv = cmdr_vv.ExecuteReader();

                while (dr_vv.Read())
                {
                    dgvAreas.Rows[1].Cells[i].Value = dr_vv["VERIFICA"].ToString();
                }
                dr_vv.Close();

                comando = "SELECT COUNT(fk_empleado) AS hostess FROM rd_asistencia WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND tienda='" + suc + "' AND area='HOSTESS'";
                MySqlCommand cmd_vh = new MySqlCommand(comando, Conex);

                MySqlDataReader dr_vh = cmd_vh.ExecuteReader();

                while (dr_vh.Read())
                {
                    dgvAreas.Rows[2].Cells[i].Value = dr_vh["hostess"].ToString();
                }
                dr_vh.Close();

                comando = "SELECT COUNT(fk_empleado) AS piso FROM rd_asistencia WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND tienda='" + suc + "' AND area='PISO VENTA'";
                MySqlCommand cmd_vp = new MySqlCommand(comando, Conex);

                MySqlDataReader dr_vp = cmd_vp.ExecuteReader();

                while (dr_vp.Read())
                {
                    dgvAreas.Rows[3].Cells[i].Value = dr_vp["piso"].ToString();
                }
                dr_vp.Close();

                comando = "SELECT COUNT(fk_empleado) AS bodega FROM rd_asistencia WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND tienda='" + suc + "' AND area='BODEGA'";
                MySqlCommand cmd_vb = new MySqlCommand(comando, Conex);

                MySqlDataReader dr_vb = cmd_vb.ExecuteReader();

                while (dr_vb.Read())
                {
                    dgvAreas.Rows[4].Cells[i].Value = dr_vb["bodega"].ToString();
                }
                dr_vb.Close();

                comando = "SELECT COUNT(fk_empleado) AS etiquetador FROM rd_asistencia WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND tienda='" + suc + "' AND area='ETIQUETADOR'";
                MySqlCommand cmd_ve = new MySqlCommand(comando, Conex);

                MySqlDataReader dr_ve = cmd_ve.ExecuteReader();

                while (dr_ve.Read())
                {
                    dgvAreas.Rows[5].Cells[i].Value = dr_ve["etiquetador"].ToString();
                }
                dr_ve.Close();

                

            }
             

     






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conex = BDConexicon.BodegaOpen();
            Consulta();
            Conex.Close();
        }
    }
}
