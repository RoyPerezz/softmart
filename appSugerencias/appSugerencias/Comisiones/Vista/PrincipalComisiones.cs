using appSugerencias.Comisiones.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Comisiones.Vista
{
    public partial class PrincipalComisiones : Form
    {
        public PrincipalComisiones()
        {
            InitializeComponent();
            customizeDesing();
            //MSesion.SetDatos("SISTEMAS", "ADMIN", BDConexicon.VallartaOpen());
            MSesion.SetConexion(BDConexicon.VallartaOpen());
            ComboBoxRellenaOsmart.rellenaSucursalEIP(MSesion.GetConexion(), cbSucursales);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new VEmpleados());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new VRol());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new VTareas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new VCalificar());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void customizeDesing()
        {
            //panelCalificacionesSubMenu.Visible = false;
        }

        private void PrincipalComisiones_Load(object sender, EventArgs e)
        {
            MSesion.SetConexion(BDConexicon.VallartaOpen());
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            string host = cbSucursales.SelectedValue.ToString();
            Ping ping = new Ping();
            lblStatus.Text = "---";
            lblSucursal.Text = "Sucursal";

            if (host == "192.168.1.2")
            {
                lblSucursal.Text = "VALLARTA";
                PingReply reply = ping.Send(host);
                if (reply.Status == IPStatus.Success)
                {

                    lblStatus.Text = "CONECTADO";
                    lblStatus.ForeColor = Color.Green;
                    MSesion.SetConexion(BDConexicon.VallartaOpen());
                }
                else
                {

                    lblStatus.Text = "NO CONECTADO";
                    lblStatus.ForeColor = Color.Red;
                }

            }
            else if (host == "192.168.2.2")
            {
                lblSucursal.Text = "RENA";
                PingReply reply = ping.Send(host);
                if (reply.Status == IPStatus.Success)
                {
                    lblStatus.Text = "CONECTADO";
                    lblStatus.ForeColor = Color.Green;
                    MSesion.SetConexion(BDConexicon.RenaOpen());
                }
                else
                {
                    lblStatus.Text = "NO CONECTADO";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            else if (cbSucursales.SelectedValue.ToString() == "CO")
            {

            }
            else if (cbSucursales.SelectedValue.ToString() == "VL")
            {

            }
            else if (cbSucursales.SelectedValue.ToString() == "CEDIS")
            {

            }
        }

        //private void hideSubMenu()
        //{
        //    if (panelCalificacionesSubMenu.Visible == true)
        //        panelCalificacionesSubMenu.Visible = false;
        //}

        //private void ShowSubMenu(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        hideSubMenu();
        //        subMenu.Visible = true;
        //    }
        //    else
        //    {
        //        subMenu.Visible = false;
        //    }
        //}
    }
}
