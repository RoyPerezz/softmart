using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class Nombre_proveedor_pagos_programados : Form
    {
        public Nombre_proveedor_pagos_programados()
        {
            InitializeComponent();
        }

        DataTable dt;
        public DataTable nombreProveedor()
        {
            DataTable dt = new DataTable();
            string nombre = "";
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "select  * from rd_proveedor_servicios  ";
            MySqlCommand cmd2 = new MySqlCommand(query, con);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd2);
            ad.Fill(dt);

            return dt;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "select  * from rd_programar_pago where nombre_prov='' ";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            string proveedor = "";
            while (dr.Read())
            {
                
                DG_tabla.Rows.Add(dr["idreg"].ToString(),dr["fecha_programada"].ToString(), dr["fecha_venc"].ToString(), dr["sucursal"].ToString(),dr["proveedor"].ToString(),"");
            }
            dr.Close();

            string provedorDT = "";
            string proveedorTabla = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                provedorDT = dt.Rows[i]["idprov"].ToString();

                for (int j = 0; j < DG_tabla.Rows.Count; j++)
                {
                    proveedorTabla = DG_tabla.Rows[j].Cells["proveedor"].Value.ToString();

                    if (provedorDT.Equals(proveedorTabla))
                    {
                        DG_tabla.Rows[j].Cells["nombre"].Value = dt.Rows[i]["nombre"].ToString();
                    }
                }
            }
        }

        private void Nombre_proveedor_pagos_programados_Load(object sender, EventArgs e)
        {
           dt =  nombreProveedor();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = null;
            MySqlConnection con = BDConexicon.BodegaOpen();
            string nombre = "";
            int id = 0;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                nombre = DG_tabla.Rows[i].Cells["nombre"].Value.ToString();
                id = Convert.ToInt32(DG_tabla.Rows[i].Cells["id"].Value.ToString());
                cmd = new MySqlCommand("update rd_programar_pago set nombre_prov='"+nombre+"' where idreg="+id+"",con);
                cmd.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Se han actualizado los registros");
        }
    }
}
