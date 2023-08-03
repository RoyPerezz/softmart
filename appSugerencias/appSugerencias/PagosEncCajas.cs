using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class PagosEncCajas : Form
    {

        string usuario = "";//GUARDA EL USUARIO QUE HA INGRESO AL SISTEMA
        string ip = "";//GUARDA LA IP CONFIGURADA PARA LA CONEXION

        public PagosEncCajas(string usuario,string ip)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.ip = ip;
        }

        private void PagosEncCajas_Load(object sender, EventArgs e)
        {

            DT_fecha.Visible = false;
            //CARGAR LISTA DE PROVEEDORES EN EL COMBOBOX
            Proveedor p = new Proveedor();
            ArrayList proveedores = p.Proveedores();

            for (int i = 0; i < proveedores.Count; i++)
            {
                CB_proveedor.Items.Add(proveedores[i]);
            }


            //******************LLENA COMBOBOX CB_transferencia CON LOS NOMBRES DE LOS CLIENTES BANCARIOS CORRESPONDIENTES A LA SUCURSAL
            string tienda = "";
            if (ip.Equals("192.168.5.2"))
            {
                tienda = "VALLARTA";
            }

            if (ip.Equals("192.168.2.2"))
            {
                tienda = "RENA";
            }

            if (ip.Equals("192.168.3.2"))
            {
                tienda = "COLOSO";
            }

            if (ip.Equals("192.168.4.2"))
            {
                tienda = "VELAZQUEZ";
            }

            if (ip.Equals("192.168.6.2"))
            {
                tienda = "PREGOT";
            }

            string query = "SELECT DISTINCT clientebancario FROM rd_bancos_osmart WHERE tienda='"+tienda+"'";
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_transferencia.Items.Add(dr["clientebancario"].ToString());
                }
                dr.Close();
                conexion.Close();
                CB_transferencia.Items.Add("COMPRAS");
                CB_transferencia.Items.Add("DONACIONES ALBERGUE");
                CB_transferencia.Items.Add("PANAMERICANA");


            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("ERROR al traer los clientes bancarios de las cuentas osmart, revisa conexion con el servidor de bodega general.");
            }
            //******************************************************************************

        }

        public void Limpiar()
        {
            TB_filtro.Text = "";
            CB_proveedor.SelectedIndex = -1;
            TB_importe.Text = "";
            TB_referencia.Text = "";
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            //DEPENDIENDO DE LA IP SERÁ EL NOMBRE DE LA SUCURSAL
            string tienda = "";
            if (ip.Equals("192.168.5.2"))
            {
                tienda = "VALLARTA";
            }

            if (ip.Equals("192.168.2.2"))
            {
                tienda = "RENA";
            }

            if (ip.Equals("192.168.3.2"))
            {
                tienda = "COLOSO";
            }

            if (ip.Equals("192.168.4.2"))
            {
                tienda = "VELAZQUEZ";
            }

            if (ip.Equals("192.168.6.2"))
            {
                tienda = "PREGOT";
            }


            //INSERTA LOS REGISTROS CAPTURADOS EN EL FORMULARIO
            DateTime fecha = DateTime.Now;
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "INSERT INTO rd_pagos_enc_cajas(nomprov,importe,referencia,realizo,fecha_pago,tienda,check_gral)VALUES(?nomprov,?importe,?referencia,?realizo,?fecha_pago,?tienda,?check_gral)";
            double importe = 0;
            importe = Convert.ToDouble(TB_importe.Text);

            if (CHK_transferencia.Checked==true)
            {

                fecha = DT_fecha.Value;
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("?nomprov", CB_transferencia.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?importe", importe);
                cmd.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                cmd.Parameters.AddWithValue("?realizo", usuario);
                cmd.Parameters.AddWithValue("?fecha_pago", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?tienda", tienda);
                cmd.Parameters.AddWithValue("?check_gral", "0");
                cmd.ExecuteNonQuery();
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("?nomprov", CB_proveedor.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?importe", importe);
                cmd.Parameters.AddWithValue("?referencia", TB_referencia.Text);
                cmd.Parameters.AddWithValue("?realizo", usuario);
                cmd.Parameters.AddWithValue("?fecha_pago", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?tienda", tienda);
                cmd.Parameters.AddWithValue("?check_gral", "0");
                cmd.ExecuteNonQuery();
            }

          
            MessageBox.Show("Registro Guardado");

            if (CHK_transferencia.Checked==true)
            {
                Auditoria.Auditoria_Pago_en_Efectivo_Enc_Cajas(usuario, fecha.ToString("yyyy-MM-dd"),CB_transferencia.SelectedItem.ToString(),Convert.ToDouble(TB_importe.Text),TB_referencia.Text);
            }else
            {
                Auditoria.Auditoria_Pago_en_Efectivo_Enc_Cajas(usuario, fecha.ToString("yyyy-MM-dd"), CB_proveedor.SelectedItem.ToString(), Convert.ToDouble(TB_importe.Text), TB_referencia.Text);
            }
            Limpiar();
            conexion.Close();

        }

        //SIRVE PARA FILTRAR EL COMBOBOX PROVEEDORES, Y ENCONTRAR EL PROVEEDOR MAS RAPIDO
        private void TB_filtro_TextChanged(object sender, EventArgs e)
        {

            if (TB_filtro.Text == "")
            {
                CB_proveedor.SelectedIndex = -1;
            
            }
            else
            {
                int index = CB_proveedor.FindString(TB_filtro.Text.ToUpper());
                CB_proveedor.SelectedIndex = index;

            }
        }

        private void CHK_transferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_transferencia.Checked==true)
            {
                LB_etiqueta.Visible = true;
                CB_transferencia.Visible = true;
                CB_proveedor.Enabled = false;
                TB_filtro.Enabled = false;
                DT_fecha.Visible = true;
            }
            else
            {
                LB_etiqueta.Visible = false;
                CB_transferencia.Visible = false;
                CB_proveedor.Enabled = true;
                TB_filtro.Enabled = true;
                DT_fecha.Visible = false;
            }
        }

        private void CB_transferencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BT_reporte_Click(object sender, EventArgs e)
        {
            Pagos_efe_enc_cajas historial = new Pagos_efe_enc_cajas(usuario);
            string modulo = historial.Name;
            RegistrarAccesos(modulo);
            historial.Show();
        }

        public void RegistrarAccesos(string modulo)
        {
            string query = "INSERT INTO rd_log_acceso_modulos(usuario,fecha,hora,ip,nombre_equipo,modulo)VALUES(?usuario,?fecha,?hora,?ip,?nombre_equipo,?modulo)";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            DateTime fecha = DateTime.Now;
            string nombre_equipo = Environment.MachineName;

            IPHostEntry host;
            string ip = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in host.AddressList)
            {
                if (IP.AddressFamily.ToString() == "InterNetwork")
                {
                    ip = IP.ToString();
                }
            }

            cmd.Parameters.AddWithValue("?usuario", usuario);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:dd"));
            cmd.Parameters.AddWithValue("?ip", ip);
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?modulo", modulo);
            cmd.ExecuteNonQuery();
        }

    }
}
