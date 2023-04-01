using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
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
    public partial class ConceptoEgreso : Form
    {
        string usuario = "";
        string concepto = "", descripcion = "";
        double importe = 0;
        public ConceptoEgreso(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }



        public string DescripcionEgreso(string concepto)
        {
            string descripcion = "";
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "Select descrip from conegre where concepto='"+concepto+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                descripcion = dr["descrip"].ToString();
            }
            dr.Close();
            conexion.Close();


            return descripcion;
        }

        public void BuscarEgresos()
        {
            if (CB_caja.Text.Equals(""))
            {
                MessageBox.Show("Selecciona una caja");
            }
            else
            {
                try
                {
                    double importe = 0;
                    DG_tabla.Rows.Clear();
                    DateTime fecha = DT_fecha.Value;
                    MySqlConnection conexion = BDConexicon.conectar();
                    string query = "select * from flujo where estacion='" + CB_caja.SelectedItem.ToString() + "' and fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND ING_EG='E'" +
                        "AND CONCEPTO<>'CAM' AND CONCEPTO<>'RETIR' AND CONCEPTO<>'TARJ' AND CONCEPTO<>'CORTZ' AND CONCEPTO<>'RBAN' AND CONCEPTO<>'RPPP'";
                    string descrip = "";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {



                        descrip = DescripcionEgreso(dr["CONCEPTO"].ToString());
                        importe = Convert.ToDouble(dr["IMPORTE"].ToString());
                        DG_tabla.Rows.Add(dr["FLUJO"].ToString(), dr["CONCEPTO"].ToString(), descrip, importe, dr["FECHA"].ToString(), dr["HORA"].ToString());



                    }

                    DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
                    dr.Close();
                    conexion.Close();
                }

                catch (Exception ex)

                {
                    MessageBox.Show("Error al traer los egresos de la caja");
                }
            }
        }

        private void BT_egresos_Click(object sender, EventArgs e)
        {
            BuscarEgresos();
        }

        private void DG_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           TB_flujo.Text = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["FLUJO"].Value);
            concepto = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTO"].Value.ToString();
            descripcion = DG_tabla.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString();
            importe = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["IMPORTE"].Value.ToString());

            string query = "SELECT CONCEPTOGRAL,DESCRIP FROM CONEGRE WHERE CONCEPTO ='"+concepto+"'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_concepto_gral.Text = dr["CONCEPTOGRAL"].ToString();
                TB_concepto_detalle.Text=dr["DESCRIP"].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void ConceptoEgreso_Load(object sender, EventArgs e)
        {

            RB_imprimir_caja.Checked = true;
            PB_logo.SizeMode = PictureBoxSizeMode.StretchImage;

            DG_tabla.Columns["DESCRIPCION"].Width = 250;

            //cargar la descripcion de los conceptos en el combobox
            //MySqlConnection conexion = BDConexicon.conectar();
            //string query = "select CONCEPTOGRAL from conegre";
            //MySqlCommand cmd = new MySqlCommand(query, conexion);
            //MySqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    CB_gral.Items.Add(dr["DESCRIP"].ToString());
            //}

            //dr.Close();
            //conexion.Close();

          


         

           
        }

        private void CB_gral_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    MySqlConnection conexion = BDConexicon.conectar();
            //    string query = "select descrip from conegre WHERE CONCEPTOGRAL='" + CB_gral.SelectedItem.ToString() + "'";
            //    MySqlCommand cmd = new MySqlCommand(query, conexion);
            //    MySqlDataReader dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        CB_detalle.Items.Add( dr["CONCEPTO"].ToString());
            //    }
            //    dr.Close();
            //    conexion.Close();
            //}

            //catch (Exception ex)

            //{

                
            //}
        }


        public void  Limpiar()
        {
            try
            {
                TB_flujo.Text = "";
                TB_concepto.Text = "";
                TB_concepto_gral.Text = "";
                TB_concepto_detalle.Text = "";
                //CB_descripcion.SelectedIndex = -1;
                
            }

            catch (Exception ex)

            {

                
            }
        }

        public string ObtenerDescripcionDetalle(string concepto)
        {
            string concepto_detalle = "";

            string query = "select descrip from conegre where concepto='" + concepto + "'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                concepto_detalle = dr["descrip"].ToString();
            }
            return concepto_detalle;
        }

        public string Sucursal()
        {
            string sucursal = "";
            string query = "select empresa from econfig";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sucursal = dr["empresa"].ToString();
            }
            return sucursal;
        }
        private void BT_imprimir_Click(object sender, EventArgs e)
        {

            if (TB_flujo.Text.Equals(""))
            {
                MessageBox.Show("Selecciona un egreso");
            }
            else
            {
                Egreso egreso = null;
                DateTime fecha = DateTime.Now;
                string query = "select * from flujo where FLUJO =" + Convert.ToInt32(TB_flujo.Text) + "";
                MySqlConnection con = BDConexicon.conectar();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    egreso = new Egreso()
                    {
                        Flujo = Convert.ToInt32(dr["flujo"].ToString()),
                        Usuario = dr["usuario"].ToString(),
                        Estacion = dr["estacion"].ToString(),
                        Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                        Hora = dr["hora"].ToString(),
                        Clave = dr["concepto"].ToString(),
                        ConceptoDetalle = ObtenerDescripcionDetalle(dr["concepto"].ToString()),
                        Importe = Convert.ToDouble(dr["importe"].ToString())
                    };
                }

                Ticket ticket = new Ticket();
                ticket.Logo = PB_logo.Image;
                ticket.Sucursal = Sucursal();
                ticket.Usuario = egreso.Usuario;
                ticket.Estacion = egreso.Estacion;
                ticket.Flujo = egreso.Flujo.ToString();
                ticket.Fecha = egreso.Fecha.ToString("dd-MM-yyyy");
                ticket.Hora = egreso.Hora;
                ticket.Clave = egreso.Clave;
                ticket.ConceptoDetalle = egreso.ConceptoDetalle;
                ticket.Importe = egreso.Importe;


                if (RB_imprimir_caja.Checked == true)
                {
                    ticket.Imprimir(ticket);
                }

                if (RB_reimprimir_enc_cajas.Checked == true)
                {
                    ticket.ReImprimir(ticket, CB_impresoras.Text);
                }
            }
           
        }

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {
            CB_gral.Items.Clear();
            CB_gral.Text = "";
            CB_detalle.Items.Clear();
            CB_detalle.Text = "";
            TB_concepto.Text = "";
            List<Egreso> lista = TipoGastosController.ConceptosGrales("TIENDA");

            foreach (var item in lista)
            {
                CB_gral.Items.Add(item.ConceptoGral.ToString());
            }
        }

        private void RB_general_CheckedChanged(object sender, EventArgs e)
        {
            CB_gral.Items.Clear();
            CB_gral.Text = "";
            CB_detalle.Items.Clear();
            CB_detalle.Text = "";
            TB_concepto.Text = "";
            List<Egreso> lista = TipoGastosController.ConceptosGrales("GENERAL");

            foreach (var item in lista)
            {
                CB_gral.Items.Add(item.ConceptoGral.ToString());
            }
        }

        private void CB_gral_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            try
            {
                string tipoGasto = "";

                if (RB_tienda.Checked == true)
                {
                    tipoGasto = "TIENDA";
                }

                if (RB_general.Checked == true)
                {
                    tipoGasto = "GENERAL";
                }

                TB_concepto.Text = "";
                CB_detalle.Items.Clear();
                CB_detalle.Text = "";
                string conceptoGral = CB_gral.SelectedItem.ToString();
                List<Egreso> lista = TipoGastosController.ConceptoDetalle(conceptoGral, tipoGasto);
                foreach (var item in lista)
                {
                    CB_detalle.Items.Add(item.ConceptoDetalle.ToString());
                }
            }

            catch (Exception ex)

            {
                MessageBox.Show("eRROR"+ex);

            }
        }

        private void CB_detalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoGasto = "";

            TB_concepto.Text = "";
            if (RB_tienda.Checked == true)
            {
                tipoGasto = "TIENDA";
            }

            if (RB_general.Checked == true)
            {
                tipoGasto = "GENERAL";
            }

            TB_concepto.Text = TipoGastosController.ClaveConceptoDetalle(CB_detalle.Text,tipoGasto);
        }

        private void RB_imprimir_caja_CheckedChanged(object sender, EventArgs e)
        {
            CB_impresoras.Enabled = false;
            CB_impresoras.Text = "";
        }

        private void RB_reimprimir_enc_cajas_CheckedChanged(object sender, EventArgs e)
        {
            CB_impresoras.Items.Clear();
            CB_impresoras.Enabled = true;
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                CB_impresoras.Items.Add(printer);
            }
        }

        //BOTON PARA ACTUALIZAR EL CONCEPTO DEL EGRESO/GASTO
        private void button1_Click(object sender, EventArgs e)
        {
            if (TB_flujo.Text.Equals(""))
            {
                MessageBox.Show("Selecciona un egreso");
            }
            else
            {
                DateTime fecha = DT_fecha.Value;
                try
                {
                    string query = "UPDATE flujo SET CONCEPTO='" + TB_concepto.Text + "', CONCEPTO2='" + TB_concepto.Text + "' WHERE FLUJO='" + TB_flujo.Text + "'";
                    MySqlConnection conexion = BDConexicon.conectar();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();
                    BuscarEgresos();
                    Auditoria.Auditoria_cambio_concepto_egreso(usuario, CB_caja.SelectedItem.ToString(), fecha.ToString("yyyy-MM-dd"), concepto, descripcion, importe, CB_gral.SelectedItem.ToString(), TB_concepto.Text);
                    Limpiar();

                    MessageBox.Show("Se ha actualizado el concepto del gasto/egreso");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al modificar el concepto del gasto/egreso: " + ex);
                }
            }
        }
    }
}
