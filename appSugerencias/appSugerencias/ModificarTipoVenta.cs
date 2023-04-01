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
    public partial class ModificarTipoVenta : Form
    {
        string venta="",ticket="",fecha="",hora="", usuario="",tipoVenta="";
        string usuarioModificador,sucursal,usuarioAuditoria;
        DateTime fechaVenta;
       
        double importe = 0;
        public ModificarTipoVenta(string usuario,string venta,string ticket,double importe,string fecha, string hora, string cajera,string tipoVenta,string user, string sucursal, DateTime fechaVenta)
        {
            this.venta = venta;
            this.ticket = ticket;
            this.importe = importe;
            this.fecha = fecha;
            this.hora = hora;
            this.usuario = cajera;
            this.tipoVenta = tipoVenta;
            usuarioModificador = user;
            this.sucursal = sucursal;
            this.fechaVenta = fechaVenta;
            usuarioAuditoria = usuario;
            InitializeComponent();
        }

        private void ModificarTipoVenta_Load(object sender, EventArgs e)
        {
            TB_venta.Text = venta;
            TB_tickect.Text = ticket;
            TB_importe.Text = Convert.ToString(importe);
            TB_fecha.Text = fecha;
            TB_hora.Text = hora;
            TB_usuario.Text = usuario;
            TB_tipoVenta.Text = tipoVenta;

        }

        private void BT_tarjeta_Click(object sender, EventArgs e)
        {

            DateTime fecha = DateTime.Now;
            string tipo = "";
            if (CB_tipo_venta.SelectedItem.ToString().Equals("EFECTIVO"))
            {
                tipo = "EFE";
            }
            if (CB_tipo_venta.SelectedItem.ToString().Equals("TARJETA"))
            {
                tipo = "TAR";
            }


            MySqlConnection conexion = BDConexicon.conectar();
            string query = "UPDATE flujo SET CONCEPTO2='"+tipo+"' WHERE VENTA="+venta+" and CONCEPTO2<>'CAM' AND ING_EG='I'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.ExecuteNonQuery();


            string query2 = "INSERT into rd_eventos(modulo,fecha,mensaje)VALUES(?modulo,?fecha,?mensaje)";
            MySqlCommand cmd2 = new MySqlCommand(query2,conexion);
            cmd2.Parameters.AddWithValue("?modulo","VentasEnCajas/ModificarTipoVenta");
            cmd2.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?mensaje", "Se modifico la venta:" +venta+ " realizada en " +sucursal+" el dia " +fechaVenta+ " de "+tipoVenta+ " a "+tipo+" por el usuario: "+usuarioModificador+"");
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Se ha modificado el tipo de venta del tikect "+TB_tickect+"' de "+TB_tipoVenta.Text+"' a "+tipo);

            //Auditoria
            Auditoria.Auditoria_modificar_tipo_venta(usuarioAuditoria, TB_usuario.Text,TB_venta.Text,TB_tickect.Text,Convert.ToDouble(TB_importe.Text),TB_tipoVenta.Text,CB_tipo_venta.SelectedItem.ToString(),TB_fecha.Text,TB_hora.Text);
        }

    }
}
