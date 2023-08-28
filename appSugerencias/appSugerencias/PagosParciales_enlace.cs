using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class PagosParciales_enlace : Form
    {


        string enlace = "";
        DataTable dt;
        string usuario = "",referencia="",compra="",sucursal="",sucursalCuenta="",importe="",cantidad="";
    
        private void CB_patron_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_bancos.Items.Clear();
            CB_bancos.Text = "";
            CB_cuenta_bancaria.Items.Clear();
            CB_cuenta_bancaria.Text = "";
            string query = "select distinct banco from rd_bancos_osmart where clientebancario='"+CB_patron.SelectedItem.ToString()+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_bancos.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
        }

        private void CB_bancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_cuenta_bancaria.Items.Clear();
            CB_cuenta_bancaria.Text = "";
            string query = "select distinct cuenta,tienda from rd_bancos_osmart where clientebancario='" + CB_patron.SelectedItem.ToString() + "' and banco='"+CB_bancos.SelectedItem.ToString()+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_cuenta_bancaria.Items.Add(dr["cuenta"].ToString());
                sucursalCuenta = dr["tienda"].ToString();
            }
            dr.Close();
        }

        public PagosParciales_enlace(string enlace, DataTable dt, string usuario, string importe, string referencia, string compra, string sucursal)
        {
            this.enlace = enlace;
            this.dt = dt;
            this.usuario = usuario;
            this.importe = importe;
            this.referencia = referencia;
            this.compra = compra;
            this.sucursal = sucursal;
            InitializeComponent();
        }

        private void PagosParciales_enlace_Load(object sender, EventArgs e)
        {
            DG_tabla.DataSource = dt;
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";

            if (!compra.Equals(""))
            {
                TB_compra.Text = compra;
                TB_sucursal.Text = sucursal;
                TB_importe.Text = importe;
                TB_referencia.Text = referencia;


                decimal digito = decimal.Parse(TB_importe.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                cantidad= digito.ToString("G0");

            }

            string query = "select patron from rd_patrones_tiendas where activo=1";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_patron.Items.Add(dr["patron"].ToString());
                
            }
            dr.Close();
        }

        private void BT_abrir_enlace_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(enlace);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("Error al abrir enlace");

            }
        }


        public void Limpiar()
        {
            TB_compra.Text = "";
            TB_sucursal.Text = "";
            TB_importe.Text = "";
            TB_referencia.Text = "";

            CB_patron.Text = "";
            
            CB_bancos.Text = "";
           
            CB_cuenta_bancaria.Text = "";
        }
        private void BT_guardar_SPEI_Click(object sender, EventArgs e)
        {
            if (TB_referencia.Text.Equals(""))
            {
                MessageBox.Show("Captura una referencia");

            }
            else if(CB_patron.Text.Equals(""))
            {
                MessageBox.Show("Debes seleccionar un cliente bancario");
            }
            
            else if(CB_bancos.Text.Equals(""))
            {
                MessageBox.Show("Debes seleccionar un banco");
            }
            else if(CB_cuenta_bancaria.Text.Equals(""))
            {
                MessageBox.Show("Debes seleccionar una cuenta bancaria");
            }
            else
            {
                try
                {
                    string cuenxpag = "";
                    string proveedor = "";
                    int abono = 0;
                    int idDesglose = 0;

                    string dato = "";
                    DateTime fecha = DateTime.Now;





                    MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);

                    string query2 = "SELECT * FROM CUENXPDET WHERE COMPRA ='" + TB_compra.Text + "'";
                    MySqlCommand cmd0 = new MySqlCommand(query2, con);
                    MySqlDataReader dr = cmd0.ExecuteReader();
                    while (dr.Read())
                    {
                        cuenxpag = dr["cuenxpag"].ToString();
                        proveedor = dr["proveedor"].ToString();
                    }

                    dr.Close();


                    abono = Consec.ConsecutivoAbono(sucursal);
                    idDesglose = Consec.ConsecAbono(sucursal);
                    if (sucursal.Equals("BODEGA"))
                    {
                        dato = "Abonoprov";
                    }
                    else
                    {
                        dato = "ABONOPROV";
                    }



                    string compra = TB_compra.Text;
                    //double importe = Convert.ToDouble(TB_importe.Text);
                    string referencia = TB_referencia.Text;

                    string query = "INSERT INTO CUENXPDET(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza)" +
                        "VALUES(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)";
                    abono++;
                    idDesglose++;
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?CUENXPAG", cuenxpag);
                    cmd.Parameters.AddWithValue("?PROVEEDOR", proveedor);
                    cmd.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?TIPO_DOC", "SPE");
                    cmd.Parameters.AddWithValue("?NO_REFEREN", referencia);
                    cmd.Parameters.AddWithValue("?Cargo_ab", "A");
                    cmd.Parameters.AddWithValue("?IMPORTE", Convert.ToDouble(cantidad));
                    cmd.Parameters.AddWithValue("?MONEDA", "MN");
                    cmd.Parameters.AddWithValue("?TIP_CAM", "1");
                    cmd.Parameters.AddWithValue("?COMPRA", compra);
                    cmd.Parameters.AddWithValue("?COBRADOR", "");
                    cmd.Parameters.AddWithValue("?OBSERV", idDesglose);
                    cmd.Parameters.AddWithValue("?CONTAB", "0");
                    cmd.Parameters.AddWithValue("?ABONO", abono);
                    cmd.Parameters.AddWithValue("?USUARIO", usuario);
                    cmd.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("?USUHORA", fecha.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("?ORDEN", "0");
                    cmd.Parameters.AddWithValue("?poliza", "0");
                    //cmd.ExecuteNonQuery();


                    //actualizar consecutivo de abono
                    MySqlCommand actualizar = new MySqlCommand("UPDATE CONSEC SET Consec=" + abono + " WHERE Dato='" + dato + "'", con);
                    actualizar.ExecuteNonQuery();



                    //actualizar consecutivo de desglose de abono
                    MySqlCommand actualizar2 = new MySqlCommand("UPDATE CONSEC SET Consec=" + idDesglose + " WHERE Dato='consecAbono'", con);
                    actualizar2.ExecuteNonQuery();
                    con.Close();



                    string query3 = "INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ref_gastoexterno,suc_pago,fk_flujo)" +
                        "VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ref_gastoexterno,?suc_pago,?fk_flujo)";
                    MySqlConnection conBO = BDConexicon.BodegaOpen();
                    MySqlCommand cmd3 = new MySqlCommand(query3, conBO);
                    cmd3.Parameters.AddWithValue("?tienda", sucursalCuenta);
                    cmd3.Parameters.AddWithValue("?mov", "SPEI");
                    cmd3.Parameters.AddWithValue("?ie", "E");
                    cmd3.Parameters.AddWithValue("?banco", CB_bancos.SelectedItem.ToString());
                    cmd3.Parameters.AddWithValue("?cuenta", CB_cuenta_bancaria.SelectedItem.ToString());
                    cmd3.Parameters.AddWithValue("?pagara", CB_patron.SelectedItem.ToString());
                    cmd3.Parameters.AddWithValue("?cantidad", Convert.ToDouble(cantidad));
                    cmd3.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                    cmd3.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:ss"));
                    cmd3.Parameters.AddWithValue("?fk_gastoexterno", "");
                    cmd3.Parameters.AddWithValue("?ref_gastoexterno", "");
                    cmd3.Parameters.AddWithValue("?suc_pago", TB_sucursal.Text);
                    cmd3.Parameters.AddWithValue("?fk_flujo", "");

                    cmd.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();

                    conBO.Close();
                    Limpiar();
                    MessageBox.Show("Se ha registrado el SPEI ");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al aplicar SPEI: " + ex);
                }


            }
           
        }
    }
}
