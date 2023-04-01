﻿using MySql.Data.MySqlClient;
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
    public partial class CuentasBancarias : Form
    {

        string usuario = "";
        public CuentasBancarias(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }


        public void Proveedores()
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            string consulta = "SELECT PROVEEDOR, NOMBRE FROM PROVEED ORDER BY NOMBRE";
            

            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_proveedor.Items.Add(dr["NOMBRE"]);
                }
                dr.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("NO HAY CONEXION CON EL SERVIDOR DE BODEGA GRAL.");
            }
            
            con.Close();
            
        }

        public void Limpiar()
        {
            TB_filtro.Text = "";
            //TB_proveedor.Text = "";
            TB_cuenta.Text = "";
            TB_anombrede.Text = "";
            CB_banco.SelectedIndex = -1;
            DG_cuentas.Rows.Clear();
            TB_id.Text = "";
        }

        public void Bancos()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "select banco from rd_bancos order by banco";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_banco.Items.Add(dr["banco"]);
            }

            dr.Close();
            conexion.Close();
        }

        private void CuentasBancarias_Load(object sender, EventArgs e)
        {

            Proveedores();
            Bancos();
            DG_cuentas.Columns["ID"].Width = 45;
            //DG_cuentas.Columns["PROVEEDOR"].Width = 70;
            DG_cuentas.Columns["BANCO"].Width = 140;
            DG_cuentas.Columns["CUENTA_BANCARIA"].Width = 140;
            //DG_cuentas.Columns["CLIENTE"].Width = 200;
        }

        private void BT_agregar_Click(object sender, EventArgs e)
        {

            int banco = CB_banco.SelectedIndex;
            string proveedor = TB_proveedor.Text;
            string cuenta = TB_cuenta.Text;
            string cliente = TB_anombrede.Text;
            if (banco == -1||proveedor.Equals("")||cuenta.Equals(""))
            {
                MessageBox.Show("CAPTURA LOS DATOS");
            }
            else
            {

                DG_cuentas.Rows.Add(usuario,TB_proveedor.Text, CB_banco.SelectedItem.ToString(), TB_cuenta.Text,cliente);
                CB_banco.SelectedIndex = 0;
                TB_cuenta.Text = "";
            }

        }

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR FROM PROVEED WHERE NOMBRE='" + CB_proveedor.SelectedItem.ToString() + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_proveedor.Text = dr["PROVEEDOR"].ToString();
                }
                dr.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                
            }
            con.Close();
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();

            if (TB_id.Text.Equals(""))
            {
                try
                {
                   
                    for (int i = 0; i < DG_cuentas.Rows.Count; i++)
                    {
                        MySqlCommand cmd1 = new MySqlCommand("INSERT INTO rd_cuentas_bancarias(fk_proveedor,banco,cuenta,pagara) VALUES(?fk_proveedor,?banco,?cuenta,?pagara)", con);
                        cmd1.Parameters.Clear();
                        cmd1.Parameters.AddWithValue("?fk_proveedor", Convert.ToString(DG_cuentas.Rows[i].Cells[1].Value));
                        cmd1.Parameters.AddWithValue("?banco", Convert.ToString(DG_cuentas.Rows[i].Cells[2].Value));
                        cmd1.Parameters.AddWithValue("?cuenta", Convert.ToString(DG_cuentas.Rows[i].Cells[3].Value));
                        cmd1.Parameters.AddWithValue("?pagara", Convert.ToString(DG_cuentas.Rows[i].Cells[4].Value));
                        cmd1.ExecuteNonQuery();
                        Auditoria.Auditoria_cuentas_bancarias_proveedores(usuario, Convert.ToString(DG_cuentas.Rows[i].Cells[1].Value), Convert.ToString(DG_cuentas.Rows[i].Cells[2].Value), Convert.ToString(DG_cuentas.Rows[i].Cells[3].Value), Convert.ToString(DG_cuentas.Rows[i].Cells[4].Value));
                    }

                    Limpiar();
                    MessageBox.Show("SE HAN GUARDADO LAS CUENTAS BANCARIAS DEL PROVEEDOR");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR AL GUARDAR REGISTROS: " + ex);
                }
            }
            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE rd_cuentas_bancarias SET banco='" + CB_banco.SelectedItem.ToString() + "', cuenta='" + TB_cuenta.Text + "',pagara='"+ TB_anombrede.Text+"' WHERE id='" + TB_id.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    Limpiar();
                    MessageBox.Show("SE HAN MODIFICADO LOS DATOS");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR AL MODIFICAR REGISTROS: " + ex);

                }
            }


         

          
               
              
          
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_cuentas.Rows.Clear();
            MySqlConnection con = BDConexicon.BodegaOpen();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_cuentas_bancarias WHERE fk_proveedor='"+TB_proveedor.Text+"'",con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DG_cuentas.Rows.Add(dr["id"].ToString(), dr["fk_proveedor"].ToString(), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["pagara"].ToString());
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("NO HAY CUENTAS BANCARIAS REGISTRADAS");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR: "+ex);

            }
            
            con.Close();
        }

        private void TB_filtro_TextChanged(object sender, EventArgs e)
        {
            if (TB_filtro.Text == "")
            {
                CB_proveedor.SelectedIndex = -1;
                DG_cuentas.DataSource = null;
            }
            else
            {
                int index = CB_proveedor.FindString(TB_filtro.Text.ToUpper());
                CB_proveedor.SelectedIndex = index;

            }
        }

        private void DG_cuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_id.Text = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[0].Value);
            CB_banco.SelectedItem = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[2].Value);
            TB_cuenta.Text = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[3].Value);
            TB_anombrede.Text = Convert.ToString(DG_cuentas.Rows[e.RowIndex].Cells[4].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DG_cuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM rd_cuentas_bancarias WHERE id='"+TB_id.Text+"'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro eliminado");

            CB_banco.SelectedIndex = 0;
            TB_cuenta.Text = "";
            TB_anombrede.Text = "";
        }

        
    }
}
