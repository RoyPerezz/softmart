using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace appSugerencias
{
    public partial class frm_pedido_almacen : Form
    {
        MySqlConnection Conex;
        public frm_pedido_almacen()
        {
            InitializeComponent();
        }

        private void frm_pedido_almacen_Load(object sender, EventArgs e)
        {
            try
            {
                Conex = BDConexicon.BodegaOpen();
                busquedaReporte();
                Conex.Close();

            }
            catch(Exception er)
            {
                MessageBox.Show("Conexion no Disponible: " + er.Message);
            }
            
        }


        public static string optieneIp()
        {
            TextReader IP;
            IP = new StreamReader("IP.txt");
            string ipn = IP.ReadLine();
            IP.Close();
            return ipn;
        }


        public void busquedaReporte()
        {

            string IP = optieneIp();
            string tienda = "";
            string tiendaBD = "";
            if (IP == "192.168.1.2")
            {
                tienda = "VA";
                tiendaBD = "rd_pedido.va";
            }
            else if (IP == "192.168.2.2")
            {
                tienda = "RE";
                tiendaBD = "rd_pedido.re";
            }
            else if (IP == "192.168.3.2")
            {
                tienda = "CO";
                tiendaBD = "rd_pedido.co";
            }
            else if (IP == "192.168.4.2")
            {
                tienda = "VL";
                tiendaBD = "rd_pedido.vl";
            }
            else if (IP == "192.168.6.2")
            {
                tienda = "PM";
                tiendaBD = "rd_pedido.pm";
            }
            if (IP == "192.168.0.190")
            {
                tienda = "VA";
                tiendaBD = "rd_pedido.va";
            }


            string comando = "SELECT * FROM rd_pedido_reportes INNER JOIN rd_pedido ON rd_pedido_reportes.fk_idpedido = rd_pedido.id_pedido WHERE "+tiendaBD+ " = '1' AND rd_pedido.estatus='CARGADO-SISTEMA' AND rd_pedido_reportes.tienda = '" + tienda+"'";
            
            MySqlCommand cmd = new MySqlCommand(comando, Conex);


            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();



            adaptador.Fill(dt);

            dgvReportes.Rows.Clear();



            foreach (DataRow item in dt.Rows)
            {
                int n = dgvReportes.Rows.Add();
                bool almacen = false, piso = false, reporte = false;

                if (item["almacen"].ToString() == "1")
                {
                    almacen = true;
                }

                if (item["piso_venta"].ToString() == "1")
                {
                    piso = true;
                }

                if (item["reporte"].ToString() == "1")
                {
                    reporte = true;
                }



                dgvReportes.Rows[n].Cells[0].Value = item["id"].ToString();
                dgvReportes.Rows[n].Cells[1].Value = item["fk_idpedido"].ToString();
                dgvReportes.Rows[n].Cells[2].Value = item["titulo_pedido"].ToString();
                dgvReportes.Rows[n].Cells[3].Value = item["link_pedido"].ToString();
                dgvReportes.Rows[n].Cells[4].Value = almacen;
                dgvReportes.Rows[n].Cells[5].Value = piso;
                dgvReportes.Rows[n].Cells[6].Value = reporte;


            }

           
        }

        public void actualizaReportes()
        {
            foreach (DataGridViewRow item in dgvReportes.Rows)
            {
               
                int almacen = 0, piso = 0, reporte = 0;

                if (Convert.ToBoolean(item.Cells[4].Value))
                {
                    almacen = 1;
                }

                if (Convert.ToBoolean(item.Cells[5].Value))
                {
                    piso = 1;
                }

                if (Convert.ToBoolean(item.Cells[6].Value))
                {
                    reporte = 1;
                }


               
                    MySqlCommand cmd = new MySqlCommand("UPDATE rd_pedido_reportes SET almacen='"+almacen+ "',piso_venta='" + piso + "', reporte='" + reporte + "' WHERE  id='" + item.Cells[0].Value.ToString() + "'", Conex);
                  
                  
                    cmd.ExecuteNonQuery();


               

            }
            //selectDatos();
            busquedaReporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conex = BDConexicon.BodegaOpen();
                actualizaReportes();
                Conex.Close();

            }catch(Exception er)
            {
                MessageBox.Show("Conexion no Disponible" + er.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void dgvReportes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvReportes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }
        public void url(DataGridViewCellEventArgs e)
        {
            var url = dgvReportes.Rows[e.RowIndex].Cells[3].Value.ToString();
            System.Diagnostics.Process.Start(url);
        }

        private void dgvReportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsANonHeaderLinkCell(e))
            {
                url(e);
            }
        }

        private bool IsANonHeaderLinkCell(DataGridViewCellEventArgs cellEvent)
        {
            if (dgvReportes.Columns[cellEvent.ColumnIndex] is
                DataGridViewLinkColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return false; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
