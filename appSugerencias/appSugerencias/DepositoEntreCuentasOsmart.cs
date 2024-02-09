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
    public partial class DepositoEntreCuentasOsmart : Form
    {

        string  cliente = "",banco="",cuenta="",tienda="",suc_pago,mov="",usuario="";
        DateTime fecha;
        double deposito = 0,saldo=0;
        int id = 0;
        public DepositoEntreCuentasOsmart(int id,string fecha, string cliente, double deposito,string banco,string cuenta,string tienda,string suc_pago,string mov,string usuario)
        {
            this.fecha = Convert.ToDateTime(fecha);
            this.cliente = cliente;
            this.deposito = deposito;
            this.banco = banco;
            this.cuenta = cuenta;
            this.tienda = tienda;
            this.suc_pago = suc_pago;
            this.id = id;
            this.usuario = usuario;
            this.mov = mov;
            InitializeComponent();
        }


        
        MySqlConnection con = null;



        public void depositarAotraCuenta()
        {
            DateTime fecha = Convert.ToDateTime(TB_fecha.Text);
            double cantidad = Convert.ToDouble(TB_deposito.Text);
            //string query = "UPDATE rd_historial_saldobancos SET banco='"+CB_banco.SelectedItem.ToString()+"', cuenta='"+ TB_cuenta_destino.Text+"',pagara='"+CB_cliente_bancario.SelectedItem.ToString()+"'" +
            //    "WHERE banco='"+TB_banco_origen.Text+"' and cuenta='"+TB_cuenta_origen.Text+ "' and pagara='" + TB_cliente_origen.Text+ "' and cantidad="+cantidad+" and fecha='" + fecha.ToString("yyyy-MM-dd")+"'";

            string query = "INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ref_gastoexterno,suc_pago)" +
                "VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ref_gastoexterno,?suc_pago)";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?tienda",tienda);
            cmd.Parameters.AddWithValue("?mov", "AJ");
            cmd.Parameters.AddWithValue("?ie", "E");
            cmd.Parameters.AddWithValue("?banco",TB_banco_origen.Text);
            cmd.Parameters.AddWithValue("?cuenta", TB_cuenta_origen.Text);
            cmd.Parameters.AddWithValue("?pagara", TB_cliente_origen.Text);
            cmd.Parameters.AddWithValue("?cantidad", TB_deposito.Text);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:MM:SS"));
            cmd.Parameters.AddWithValue("?fk_gastoexterno", "0");
            cmd.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
            cmd.Parameters.AddWithValue("?suc_pago", "");
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = new MySqlCommand(query, con);

            cmd2.Parameters.AddWithValue("?tienda", tienda);
            cmd2.Parameters.AddWithValue("?mov", mov);
            cmd2.Parameters.AddWithValue("?ie", "I");
            cmd2.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("?cuenta", TB_cuenta_destino.Text);
            cmd2.Parameters.AddWithValue("?pagara", CB_cliente_bancario.SelectedItem.ToString()); ;
            cmd2.Parameters.AddWithValue("?cantidad", TB_deposito.Text);
            cmd2.Parameters.AddWithValue("?fecha", fecha.ToString("yyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?hora", fecha.ToString("HH:MM:SS"));
            cmd2.Parameters.AddWithValue("?fk_gastoexterno", "0");
            cmd2.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia.Text);
            cmd2.Parameters.AddWithValue("?suc_pago", "");

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Se ha depositado el dinero");
        }
        private void BT_depositar_Click(object sender, EventArgs e)
        {
            depositarAotraCuenta();
        }


        //Botón depositar
        private void button1_Click(object sender, EventArgs e)
        {


            if (saldo<Convert.ToDouble(TB_egreso.Text))
            {
                MessageBox.Show("No se puede aplicar pago, el monto es mayor al saldo");
            }
           
            else
            {
                string query = "INSERT INTO rd_historial_saldobancos(tienda,mov,ie,banco,cuenta,pagara,cantidad,fecha,hora,fk_gastoexterno,ref_gastoexterno,suc_pago,fk_flujo)" +
               "VALUES(?tienda,?mov,?ie,?banco,?cuenta,?pagara,?cantidad,?fecha,?hora,?fk_gastoexterno,?ref_gastoexterno,?suc_pago,?fk_flujo)";

                string query2 = "INSERT INTO rd_desglose_pagos_otis(fk_id_historial_banco,importe,sucursal,fecha,usuario)VALUES(?fk_id_historial_banco,?importe,?sucursal,?fecha,?usuario)";
                MySqlCommand cmd = null;
                MySqlConnection con = null;
                try
                {
                    con = BDConexicon.BodegaOpen();



                    cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("?tienda", tienda);
                    cmd.Parameters.AddWithValue("?mov", mov);
                    cmd.Parameters.AddWithValue("?ie", "E");
                    cmd.Parameters.AddWithValue("?banco", banco);
                    cmd.Parameters.AddWithValue("?cuenta", cuenta);
                    cmd.Parameters.AddWithValue("?pagara", cliente);
                    cmd.Parameters.AddWithValue("?cantidad", Convert.ToDouble(TB_egreso.Text));
                    cmd.Parameters.AddWithValue("?fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("?hora", DateTime.Now.ToString("HH:mm:ss"));
                    cmd.Parameters.AddWithValue("?fk_gastoexterno", 0);
                    cmd.Parameters.AddWithValue("?ref_gastoexterno", TB_referencia_otis.Text);
                    cmd.Parameters.AddWithValue("?suc_pago", tienda);
                    cmd.Parameters.AddWithValue("?fk_flujo", 0);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al insertar registro en historial bancario: " + ex);
                }

                try
                {
                    cmd = new MySqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("?fk_id_historial_banco", id);
                    cmd.Parameters.AddWithValue("?importe", Convert.ToDouble(TB_egreso.Text));
                    cmd.Parameters.AddWithValue("?sucursal", tienda);
                    cmd.Parameters.AddWithValue("?fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("?usuario", usuario);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Se ha registrado el pago exitosamente");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al insertar registro en desglose de pago otis: " + ex);
                }
                con.Close();

            }



        }

        private void CB_cliente_bancario_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_banco.Items.Clear();
            TB_cuenta_destino.Text = "";
            string query = "select banco from rd_bancos_osmart where clientebancario='"+CB_cliente_bancario.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_banco.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
            CB_banco.SelectedIndex = -1;
            CB_banco.Text = "";
        }

        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_cuenta_destino.Text = "";
            string query = "select cuenta from rd_bancos_osmart where clientebancario='" + CB_cliente_bancario.SelectedItem.ToString() + "' and banco='"+CB_banco.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_cuenta_destino.Text =   dr["cuenta"].ToString();
            }
            dr.Close();
        }

        public void CuentasOsmart()
        {
             con = BDConexicon.BodegaOpen();
            string query = "SELECT distinct clientebancario FROM rd_bancos_osmart";
           
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                CB_cliente_bancario.Items.Add(dr["clientebancario"].ToString());
              
            }
            dr.Close();
            
        }


        public DataTable abonosOtis(int transaccion)
        {

            DataTable tabla = new DataTable();
            tabla.Columns.Add("ID",typeof(int));
            tabla.Columns.Add("TRANSACCION", typeof(int));
            tabla.Columns.Add("IMPORTE", typeof(double));
            tabla.Columns.Add("SUCURSAL", typeof(string));
            tabla.Columns.Add("FECHA", typeof(string));
           
            string query = "SELECT * " +
                "           FROM rd_desglose_pagos_otis" +
                "           WHERE fk_id_historial_banco ='"+transaccion+"'";

            double saldo = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //saldo += Convert.ToDouble(dr["importe"].ToString());
                tabla.Rows.Add(Convert.ToInt32(dr["id"].ToString()),Convert.ToInt32(dr["fk_id_historial_banco"].ToString()),Convert.ToDouble(dr["importe"].ToString()),dr["sucursal"].ToString(),Convert.ToDateTime(dr["fecha"]).ToString("yyyy-MM-dd"));
            }
            dr.Close();
            con.Close();

            return tabla;
        }

        private void DepositoEntreCuentasOsmart_Load(object sender, EventArgs e)
        {

            double pagos = 0;
            if (cuenta.Equals("PRESTAMO OTIS"))
            {
                TB_banco_otis.Text = banco;
                TB_cuenta_otis.Text = cuenta;
                TB_fecha_otis.Text = fecha.ToString("yyyy-MM-dd");
                TB_cliente_otis.Text = cliente;
                TB_ingreso_otis.Text = deposito.ToString("C2");


                DataTable tabla = abonosOtis(id);
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    pagos += Convert.ToDouble(tabla.Rows[i]["IMPORTE"]);
                    DG_pagos_otis.Rows.Add(tabla.Rows[i]["TRANSACCION"],tabla.Rows[i]["SUCURSAL"],tabla.Rows[i]["FECHA"],tabla.Rows[i]["IMPORTE"]);
                }

                DG_pagos_otis.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
                saldo = deposito - pagos;
                TB_saldo_otis.Text = saldo.ToString("C2");
                TB_egreso.Text = saldo.ToString();
                
            }
            else{
                TB_cuenta_origen.Text = cuenta;
                TB_fecha.Text = fecha.ToString("yyyy-MM-dd");
                TB_deposito.Text = deposito.ToString();
                TB_banco_origen.Text = banco;
                TB_cliente_origen.Text = cliente;
                CuentasOsmart();
            }
           
            
        }
    }
}
