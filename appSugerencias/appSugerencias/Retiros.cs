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
    public partial class Retiros : Form, InterfaceComunicacion
    {


        double importe = 0;
        string venta = "";

        public Retiros(string usuario, string estacion)
        {
            InitializeComponent();
            LB_usuario.Text = usuario;
            LB_estacion.Text = estacion;
        }

        public void SetArticulo(string articulo)
        {

        }
        public void SetTicket(string ticket)
        {
            tbTiket.Text = ticket;
            buscarTicket();

        }
        private void Retiros_Load(object sender, EventArgs e)
        {

        }

        //TRAE EL CONSECUTIVO DE FLUJO
        public int ConsecFlujo()
        {

            int consec = 1;
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='flujo'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                consec += consec = Convert.ToInt32(dr["Consec"].ToString());
            }

            return consec;
        }


        //INSERTA EL IMPORTE DE LA TARJETA EN FLUJO
        public void AfectarFlujo()
        {

            DateTime fecha = DateTime.Now;



            try
            {
                importe = Convert.ToDouble(TB_importe.Text);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("Verifica el formato del importe");
            }

            int consecFlujo = ConsecFlujo();
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO flujo(FLUJO,ABONO,CONCEPTO,ING_EG,IMPORTE,FECHA,HORA,MONEDA,ESTACION,USUARIO,USUFECHA,USUHORA,Modulo,Venta,Corte,tipo_cam,Cargo,concepto2,banco,cheque,verificado)" +
                "VALUES(?FLUJO,?ABONO,?CONCEPTO,?ING_EG,?IMPORTE,?FECHA,?HORA,?MONEDA,?ESTACION,?USUARIO,?USUFECHA,?USUHORA,?Modulo,?Venta,?Corte,?tipo_cam,?Cargo,?concepto2,?banco,?cheque,?verificado)", con);
            cmd.Parameters.AddWithValue("?FLUJO", consecFlujo);
            cmd.Parameters.AddWithValue("?ABONO", "0");
            cmd.Parameters.AddWithValue("?CONCEPTO", "TARJ");
            cmd.Parameters.AddWithValue("?ING_EG", "E");
            cmd.Parameters.AddWithValue("?IMPORTE", importe);
            cmd.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?HORA", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?MONEDA", "MN");
            cmd.Parameters.AddWithValue("?ESTACION", LB_estacion.Text);
            cmd.Parameters.AddWithValue("?USUARIO", LB_usuario.Text);
            cmd.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?USUHORA", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?Modulo", "PT");
            cmd.Parameters.AddWithValue("?Venta", venta);
            cmd.Parameters.AddWithValue("?Corte", "0");
            cmd.Parameters.AddWithValue("?tipo_cam", "1");
            cmd.Parameters.AddWithValue("?Cargo", "0");
            cmd.Parameters.AddWithValue("?Concepto2", "TARJ");
            cmd.Parameters.AddWithValue("?banco", "");
            cmd.Parameters.AddWithValue("?cheque", "");
            cmd.Parameters.AddWithValue("?verificado", "0");
            cmd.ExecuteNonQuery();

            MySqlCommand update = new MySqlCommand("UPDATE CONSEC SET Consec='" + consecFlujo + "' WHERE Dato='flujo'", con);
            update.ExecuteNonQuery();



            con.Close();


        }

        public bool RevisaTarjetaAnterior()
        {
            string numero;
            try
            {
                importe = Convert.ToDouble(TB_importe.Text);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("Verifica el formato del importe");
            }
            numero = buscaVenta();
            MySqlConnection conex = BDConexicon.conectar();
            string comando;
            comando = "SELECT * FROM flujo WHERE CONCEPTO='TARJ' AND ING_EG='E' AND Corte='0' AND ESTACION='" + LB_estacion.Text + "' AND Venta='" + numero + "'";

            MySqlCommand cmd = new MySqlCommand(comando, conex);


            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();



            if (mdr.Read())
            {


                conex.Close();
                return true;

            }
            else
            {

                conex.Close();
                return false;

            }

        }

        public void AfectarHistorialTarj()
        {
            DateTime fecha = DateTime.Now;
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_historial_tarj(operacion,importe,estacion,usuario,fecha,hora,estado)VALUES(?operacion,?importe,?estacion,?usuario,?fecha,?hora,?estado)", con);
            cmd.Parameters.AddWithValue("?operacion", TB_num_op.Text);
            cmd.Parameters.AddWithValue("?importe", importe);
            cmd.Parameters.AddWithValue("?estacion", LB_estacion.Text);
            cmd.Parameters.AddWithValue("?usuario", LB_usuario.Text);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
            cmd.Parameters.AddWithValue("?estado", "0");
            cmd.ExecuteNonQuery();

            con.Close();
        }


        private void BT_aplicar_Click(object sender, EventArgs e)
        {
            bool flag;


            try
            {
                if (TB_num_op.Text.Equals("") || TB_importe.Text.Equals(""))
                {
                    MessageBox.Show("Coloque el número de operacion y el importe");
                }
                else
                {
                    flag = RevisaTarjetaAnterior();
                    if (flag)
                    {
                        MessageBox.Show("Esta tarjeta ya se dio de baja");
                    }
                    else
                    {



                        BT_aplicar.Enabled = false;

                        AfectarFlujo();
                        AfectarHistorialTarj();

                        LB_operacion.Text = TB_num_op.Text;
                        double importe = Convert.ToDouble(TB_importe.Text);
                        LB_importe.Text = String.Format("{0:0.##}", importe.ToString("C"));
                        lblTicket.Text = tbTiket.Text;
                        TB_num_op.Text = "";
                        TB_importe.Text = "";
                        tbTiket.Text = "";
                        tbTiket.Focus();
                        checkPago.Checked = false;
                        MessageBox.Show("Acción realizada con éxito");
                        BT_aplicar.Enabled = true;


                    }

                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }


        }

        public string buscaVenta()
        {
            string numero = "";

            MySqlConnection conex = BDConexicon.conectar();
            string comando;
            comando = "SELECT VENTA FROM ventas WHERE TIPO_DOC='REM'  AND NO_REFEREN='" + tbTiket.Text + "' AND Caja='" + LB_estacion.Text + "'";
            MySqlCommand cmd = new MySqlCommand(comando, conex);


            MySqlDataReader mdr;
            mdr = cmd.ExecuteReader();

            if (mdr.Read())
            {

                numero = mdr.GetString("VENTA");
                venta = numero;
                conex.Close();
                return numero;
            }
            else
            {
                conex.Close();
                return "0";
            }

        }

        public void buscarTicket()
        {
            string comando;
            string numero;

            MySqlConnection conex = BDConexicon.conectar();

            numero = buscaVenta();
            comando = "SELECT IMPORTE FROM flujo  WHERE Corte=0 AND concepto2='TAR' AND Venta='" + numero + "'";
            MySqlCommand cmd1 = new MySqlCommand(comando, conex);


            MySqlDataReader mdr1;
            mdr1 = cmd1.ExecuteReader();


            if (mdr1.Read())
            {

                TB_importe.Text = mdr1.GetString("IMPORTE");
                TB_num_op.Focus();
                conex.Close();


            }
            else
            {
                MessageBox.Show("Tarjeta no encontrada");
                conex.Close();


            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {

                    buscarTicket();


                }
                else
                {
                    TexBoxEvent.numberKeyPress(e);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPago.Checked == true)
            {
                TB_importe.Enabled = true;
            }
            else
            {
                TB_importe.Enabled = false;
            }
        }

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            tbTiket.Text = "";
            TB_importe.Text = "";
            TB_num_op.Text = "";
            venta = "";
            tbTiket.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            frm_retiroTarjeta2 hijo = new frm_retiroTarjeta2(LB_estacion.Text);
            hijo.Show(this);
        }
    }
}
