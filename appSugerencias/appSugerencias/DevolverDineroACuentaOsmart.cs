using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class DevolverDineroACuentaOsmart : Form
    {


        string nombre = "", proveedor = "", compra = "";
        string importe = "",usuario="",sucursal="";



        public DevolverDineroACuentaOsmart(string nombre, string proveedor, string compra, string importe, string usuario,string sucursal)
        {

            this.nombre = nombre;
            this.proveedor = proveedor;
            this.compra = compra;
            this.importe = importe;
            this.usuario = usuario;
            this.sucursal = sucursal;
            InitializeComponent();
        }


        private void CHX_importe_CheckedChanged(object sender, EventArgs e)
        {
            if (CHX_importe.Checked==true)
            {
                decimal digito = decimal.Parse(TB_importeComp.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string cantidad = digito.ToString("G0");

                TB_importe.Text = cantidad;
            }

            if (CHX_importe.Checked == false)
            {
                TB_importe.Text  ="0";
            }
        }

        private void TB_importe_TextChanged(object sender, EventArgs e)
        {
            //double texto = Convert.ToDouble(TB_importe.Text.ToString());
            //TB_importe.Text = texto.ToString("C2");
        }



        //evento de CB_sucursal_banco
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            CB_banco.Items.Clear();
            //CB_banco.SelectedIndex = 0;
            CB_cuentaOsmart.Items.Clear();
            //CB_cuentaOsmart.SelectedIndex = 0;
            TB_cliente.Text = "";


            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT DISTINCT banco FROM rd_bancos_osmart WHERE tienda ='"+CB_sucursal_banco.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_banco.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_cuentaOsmart.Items.Clear();
            TB_cliente.Text = "";
            //CB_cuentaOsmart.SelectedIndex = 0;
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT DISTINCT cuenta FROM rd_bancos_osmart WHERE tienda ='" + CB_sucursal_banco.SelectedItem.ToString() + "' and banco='"+ CB_banco.SelectedItem.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_cuentaOsmart.Items.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void CB_cuentaOsmart_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_cliente.Text = "";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT DISTINCT clientebancario FROM rd_bancos_osmart WHERE tienda ='" + CB_sucursal_banco.SelectedItem.ToString() + "' and banco='" + CB_banco.SelectedItem.ToString() +"' and cuenta ='"+CB_cuentaOsmart.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_cliente.Text = dr["clientebancario"].ToString();
            }
            dr.Close();
            conexion.Close();
        }

        public int ConsecAbono(MySqlConnection conexion)
        {
            int consec = 1;
        
            string query = "SELECT Consec FROM consec WHERE Dato='Abonoprov'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consec += Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            //conexion.Close();

            return consec;
        }

        public string Cuenxpag(string compra,MySqlConnection conexion)
        {
            string cuenta = "";

            string query = "SELECT cuenxpag from cuenxpag where compra ='"+compra+"'";
           
            MySqlCommand cmd = new MySqlCommand(query,conexion);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cuenta = Convert.ToString(dr["cuenxpag"].ToString());
            }
            dr.Close();
            return cuenta;
        }

        private void BT_depositar_Click(object sender, EventArgs e)
        {


            if (TB_importe.Text.Equals("") || TB_importe.Text.Equals("0"))
            {
                MessageBox.Show("CAPTURE EL IMPORTE");
            }
            else if(TB_referencia.Text.Equals(""))
            {
                MessageBox.Show("CAPTURE LA REFERENCIA");

            }
            else
            {
                DateTime fecha = DateTime.Now;
                string cuenxpdet = "INSERT INTO cuenxpdet(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza)" +
                    "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)";

                string pagos = "INSERT INTO PAGOS(Abono,Proveedor,Tipo_doc,No_referen,Importe,Moneda,TC,ImportBase,Cobrar,Banco,Fecha_dep,Autorizado,Por_apli,Aplicado,Observ,Concepto,Usuario,UsuFecha,UsuHora)" +
                    "VALUES(?Abono,?Proveedor,?Tipo_doc,?No_referen,?Importe,?Moneda,?TC,?ImportBase,?Cobrar,?Banco,?Fecha_dep,?Autorizado,?Por_apli,?Aplicado,?Observ,?Concepto,?Usuario,?UsuFecha,?UsuHora)";

                string historial = "INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ref_gastoexterno,suc_pago)VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ref_gastoexterno,?suc_pago)";


              

              
                MySqlConnection conexion = null;

                if (TB_sucursal.Text.Equals("BODEGA"))
                {
                    conexion = BDConexicon.BodegaOpen();
                }

                if (TB_sucursal.Text.Equals("VALLARTA"))
                {
                    conexion = BDConexicon.VallartaOpen();
                }


                if (TB_sucursal.Text.Equals("RENA"))
                {
                    conexion = BDConexicon.RenaOpen();
                }

                if (TB_sucursal.Text.Equals("COLOSO"))
                {
                    conexion = BDConexicon.ColosoOpen();
                }

                if (TB_sucursal.Text.Equals("VELAZQUEZ"))
                {
                    conexion = BDConexicon.VelazquezOpen();
                }

                if (CHX_deposito_sinprov.Checked == true)
                {

                    MySqlConnection con = BDConexicon.BodegaOpen();
                    //INSERTAR EN TABLA RD_HISTORIAL_SALDOBANCOS
                    MySqlCommand cmd3 = new MySqlCommand(historial, con);
                    cmd3.Parameters.AddWithValue("?tienda", TB_sucursal.Text);
                    cmd3.Parameters.AddWithValue("?mov", TB_mov.Text);
                    cmd3.Parameters.AddWithValue("?ie", "I");
                    cmd3.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
                    cmd3.Parameters.AddWithValue("?cuenta", CB_cuentaOsmart.SelectedItem.ToString());
                    cmd3.Parameters.AddWithValue("?pagara", TB_cliente.Text);
                    cmd3.Parameters.AddWithValue("?cantidad", Convert.ToDouble(TB_importe.Text));
                    cmd3.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    cmd3.Parameters.AddWithValue("?hora", fecha.Hour);
                    cmd3.Parameters.AddWithValue("?fk_gastoexterno", "");
                    cmd3.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
                    cmd3.Parameters.AddWithValue("?suc_pago", CB_sucursal_banco.SelectedItem.ToString());
                    cmd3.ExecuteNonQuery();

                   
                    con.Close();
                    MessageBox.Show("SE REALIZÓ EL DEPÓSITO A LA CUENTA " + CB_cuentaOsmart.SelectedItem.ToString() + " CON ÉXITO");
                }
                else
                {


                    int abono = ConsecAbono(conexion);
                    string cuenxpag = Cuenxpag(TB_compra.Text, conexion);

                    //INSERTAR EN TABLA PAGOS
                    MySqlCommand cmd2 = new MySqlCommand(pagos, conexion);
                    cmd2.Parameters.AddWithValue("?Abono", abono);
                    cmd2.Parameters.AddWithValue("?Proveedor", TB_proveedor.Text);
                    cmd2.Parameters.AddWithValue("?Tipo_doc", "DEV");
                    cmd2.Parameters.AddWithValue("?No_referen", TB_referencia.Text);
                    cmd2.Parameters.AddWithValue("?Importe", TB_importe.Text);
                    cmd2.Parameters.AddWithValue("?Moneda", "MN");
                    cmd2.Parameters.AddWithValue("?TC", "1");
                    cmd2.Parameters.AddWithValue("?ImportBase", "");
                    cmd2.Parameters.AddWithValue("?Cobrar", "0");
                    cmd2.Parameters.AddWithValue("?Banco", "");
                    cmd2.Parameters.AddWithValue("?Fecha_dep", fecha.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("?Autorizado", "0");
                    cmd2.Parameters.AddWithValue("?Por_apli", "0");
                    cmd2.Parameters.AddWithValue("?Aplicado", "0");
                    cmd2.Parameters.AddWithValue("?Observ", "");
                    cmd2.Parameters.AddWithValue("?Concepto", "CUENTA");
                    cmd2.Parameters.AddWithValue("?Usuario", usuario);
                    cmd2.Parameters.AddWithValue("?UsuFecha", fecha.ToString("yyyy-MM-dd"));
                    cmd2.Parameters.AddWithValue("?UsuHora", fecha.Hour);
                    cmd2.ExecuteNonQuery();

                    //INSERTAR EN TABLA CUENXPDET
                    MySqlCommand cmd1 = new MySqlCommand(cuenxpdet, conexion);
                    cmd1.Parameters.AddWithValue("?CUENXPAG", cuenxpag);
                    cmd1.Parameters.AddWithValue("?PROVEEDOR", TB_proveedor.Text);
                    cmd1.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                    cmd1.Parameters.AddWithValue("?TIPO_DOC", "DV");
                    cmd1.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
                    cmd1.Parameters.AddWithValue("?Cargo_ab", "C");
                    cmd1.Parameters.AddWithValue("?IMPORTE", Convert.ToDouble(TB_importe.Text));
                    cmd1.Parameters.AddWithValue("?MONEDA", "MN");
                    cmd1.Parameters.AddWithValue("?TIP_CAM", "1");
                    cmd1.Parameters.AddWithValue("?COMPRA", TB_compra.Text);
                    cmd1.Parameters.AddWithValue("?COBRADOR", "");
                    cmd1.Parameters.AddWithValue("?OBSERV", "");
                    cmd1.Parameters.AddWithValue("?CONTAB", "");
                    cmd1.Parameters.AddWithValue("?ABONO", abono);
                    cmd1.Parameters.AddWithValue("?USUARIO", usuario);
                    cmd1.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                    cmd1.Parameters.AddWithValue("?USUHORA", fecha.Hour);
                    cmd1.Parameters.AddWithValue("?ORDEN", "0");
                    cmd1.Parameters.AddWithValue("?poliza", "");
                    cmd1.ExecuteNonQuery();


                    string query = "UPDATE consec SET Consec=" + abono + " WHERE Dato ='ABONOPROV'";
                    MySqlCommand actualizarAbono = new MySqlCommand(query, conexion);
                    actualizarAbono.ExecuteNonQuery();

                    MySqlConnection con = BDConexicon.BodegaOpen();
                    //INSERTAR EN TABLA RD_HISTORIAL_SALDOBANCOS
                    MySqlCommand cmd3 = new MySqlCommand(historial, con);
                    cmd3.Parameters.AddWithValue("?tienda", TB_sucursal.Text);
                    cmd3.Parameters.AddWithValue("?mov", TB_mov.Text);
                    cmd3.Parameters.AddWithValue("?ie", "I");
                    cmd3.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
                    cmd3.Parameters.AddWithValue("?cuenta", CB_cuentaOsmart.SelectedItem.ToString());
                    cmd3.Parameters.AddWithValue("?pagara", TB_cliente.Text);
                    cmd3.Parameters.AddWithValue("?cantidad", Convert.ToDouble(TB_importe.Text));
                    cmd3.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    cmd3.Parameters.AddWithValue("?hora", fecha.Hour);
                    cmd3.Parameters.AddWithValue("?fk_gastoexterno", "");
                    cmd3.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
                    cmd3.Parameters.AddWithValue("?suc_pago", CB_sucursal_banco.SelectedItem.ToString());
                    cmd3.ExecuteNonQuery();

                    conexion.Close();
                    con.Close();
                    MessageBox.Show("SE REALIZÓ EL DEPÓSITO A LA CUENTA " + CB_cuentaOsmart.SelectedItem.ToString() + " CON ÉXITO");

                }




            }

        }



        private void DevolverDineroACuentaOsmart_Load(object sender, EventArgs e)
        {
            TB_nombreProv.Text = nombre;
            TB_proveedor.Text = proveedor;
            TB_compra.Text = compra;
            TB_importeComp.Text = Convert.ToString(importe);
            TB_sucursal.Text = sucursal;
            TB_importe.Text = "0";
        }
    }
}
