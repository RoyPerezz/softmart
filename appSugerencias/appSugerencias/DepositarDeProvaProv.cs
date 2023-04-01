using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class DepositarDeProvaProv : Form
    {
        string proveedor = "",nombreprov="",usuario="";




        #region METODOS
        //consecutivo de cuentas por pagar
        public int ConsecCuenxpag()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.BodegaOpen();
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='cuenxpag'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de cuenxpag " + ex);
            }



            return consec;

        }

        //consecutivo de abono
        public int ConsecAbono()
        {
            int consec = 1;
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT Consec FROM consec WHERE Dato='Abonoprov'";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consec += consec = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            conexion.Close();

            return consec;
        }

        public void Limpiar()
        {
            CB_proveedores.SelectedIndex = -1;
            TB_id2.Text = "";
            CB_tipo.SelectedIndex = -1;
            TB_importe.Text = "";
            TB_referencia.Text = "";
        }
        #endregion


        private void BT_deposito_Click(object sender, EventArgs e)
        {
            int cuenxpag = 0;
            int abono = 0;
            string tipo = "";
            DateTime fecha = DT_fecha.Value;

            string query1 = "insert into cuenxpdet(CUENXPAG,PROVEEDOR,FECHA,TIPO_DOC,NO_REFEREN,Cargo_ab,IMPORTE,MONEDA,TIP_CAM,COMPRA,COBRADOR,OBSERV,CONTAB,ABONO,USUARIO,USUFECHA,USUHORA,ORDEN,poliza)" +
                "values(?CUENXPAG,?PROVEEDOR,?FECHA,?TIPO_DOC,?NO_REFEREN,?Cargo_ab,?IMPORTE,?MONEDA,?TIP_CAM,?COMPRA,?COBRADOR,?OBSERV,?CONTAB,?ABONO,?USUARIO,?USUFECHA,?USUHORA,?ORDEN,?poliza)";
            MySqlConnection conexion = BDConexicon.BodegaOpen();


            if (CB_tipo.SelectedItem.ToString().Equals("EFECTIVO"))
            {
                tipo = "EFE";
            }

            if (CB_tipo.SelectedItem.ToString().Equals("DEPOSITO/EFECTIVO"))
            {
                tipo = "DEP";
            }

            if (CB_tipo.SelectedItem.ToString().Equals("SPEI"))
            {
                tipo = "SPE";
            }

            if (CB_tipo.SelectedItem.ToString().Equals("CHEQUE"))
            {
                tipo = "CHE";
            }

            cuenxpag = ConsecCuenxpag();
            abono = ConsecAbono();
            MySqlCommand cmd = new MySqlCommand(query1,conexion);
            cmd.Parameters.AddWithValue("?CUENXPAG",cuenxpag);
            cmd.Parameters.AddWithValue("?PROVEEDOR", TB_id.Text);
            cmd.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?TIPO_DOC", tipo);
            cmd.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
            cmd.Parameters.AddWithValue("?Cargo_ab",'C');
            cmd.Parameters.AddWithValue("?IMPORTE",Convert.ToDouble(TB_importe.Text));
            cmd.Parameters.AddWithValue("?MONEDA","MN");
            cmd.Parameters.AddWithValue("?TIP_CAM", 1);
            cmd.Parameters.AddWithValue("?COMPRA", 0);
            cmd.Parameters.AddWithValue("?COBRADOR", "DEVEFE");
            cmd.Parameters.AddWithValue("?OBSERV", 0);
            cmd.Parameters.AddWithValue("?CONTAB", 0);
            cmd.Parameters.AddWithValue("?ABONO", abono);
            cmd.Parameters.AddWithValue("?USUARIO", usuario);
            cmd.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?USUHORA", fecha.ToString("HH:MM"));
            cmd.Parameters.AddWithValue("?ORDEN", 0);
            cmd.Parameters.AddWithValue("?poliza", 0);
            cmd.ExecuteNonQuery();



            //actualizar consecutivo de cuentas por pagar
            MySqlCommand consecCxp = new MySqlCommand("UPDATE consec SET Consec ='" + cuenxpag + "'" + " where Dato ='cuenxpag'", conexion);
            consecCxp.ExecuteNonQuery();

            //actualizar el consecutivo de abonos
            MySqlCommand actualizarConsec = new MySqlCommand("UPDATE consec SET Consec ='" + abono + "'" + " where Dato ='ABONOPROV'", conexion);
            actualizarConsec.ExecuteNonQuery();

            cuenxpag = ConsecCuenxpag();
            abono = ConsecAbono();
            MySqlCommand cmd2 = new MySqlCommand(query1, conexion);
            cmd2.Parameters.AddWithValue("?CUENXPAG", cuenxpag);
            cmd2.Parameters.AddWithValue("?PROVEEDOR", TB_id2.Text);
            cmd2.Parameters.AddWithValue("?FECHA", fecha.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?TIPO_DOC", tipo);
            cmd2.Parameters.AddWithValue("?NO_REFEREN", TB_referencia.Text);
            cmd2.Parameters.AddWithValue("?Cargo_ab", 'A');
            cmd2.Parameters.AddWithValue("?IMPORTE", Convert.ToDouble(TB_importe.Text));
            cmd2.Parameters.AddWithValue("?MONEDA", "MN");
            cmd2.Parameters.AddWithValue("?TIP_CAM", 1);
            cmd2.Parameters.AddWithValue("?COMPRA", 0);
            cmd2.Parameters.AddWithValue("?COBRADOR", "DEVEFE");
            cmd2.Parameters.AddWithValue("?OBSERV", 0);
            cmd2.Parameters.AddWithValue("?CONTAB", 0);
            cmd2.Parameters.AddWithValue("?ABONO", abono);
            cmd2.Parameters.AddWithValue("?USUARIO", usuario);
            cmd2.Parameters.AddWithValue("?USUFECHA", fecha.ToString("yyyy-MM-dd"));
            cmd2.Parameters.AddWithValue("?USUHORA", fecha.ToString("HH:MM"));
            cmd2.Parameters.AddWithValue("?ORDEN", 0);
            cmd2.Parameters.AddWithValue("?poliza", 0);
            cmd2.ExecuteNonQuery();

            MySqlCommand consecCxp2 = new MySqlCommand("UPDATE consec SET Consec ='" + cuenxpag + "'" + " where Dato ='cuenxpag'", conexion);
            consecCxp2.ExecuteNonQuery();

            MySqlCommand actualizarConsec2 = new MySqlCommand("UPDATE consec SET Consec ='" + abono + "'" + " where Dato ='ABONOPROV'", conexion);
            actualizarConsec2.ExecuteNonQuery();


            string query2 = "INSERT INTO rd_pago_prov_a_prov(pagador,id_pagador,beneficiario,id_beneficiario,importe,fecha,usuario)VALUES(?pagador,?id_pagador,?beneficiario,?id_beneficiario,?importe,?fecha,?usuario)";
            MySqlCommand cmd3 = new MySqlCommand(query2,conexion);
            cmd3.Parameters.AddWithValue("?pagador",TB_proveedor.Text);
            cmd3.Parameters.AddWithValue("?id_pagador", TB_id.Text);
            cmd3.Parameters.AddWithValue("?beneficiario", CB_proveedores.SelectedItem.ToString());
            cmd3.Parameters.AddWithValue("?id_beneficiario", TB_id2.Text);
            cmd3.Parameters.AddWithValue("?importe", Convert.ToDouble(TB_importe.Text));
            cmd3.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd3.Parameters.AddWithValue("?usuario", usuario);

            cmd3.ExecuteNonQuery();


            Auditoria.Auditoria_Depositar_de_Proveedor_a_Proveedor(usuario, TB_id.Text, TB_id2.Text, CB_tipo.SelectedItem.ToString(), Convert.ToDouble(TB_importe.Text), TB_referencia.Text, fecha.ToString("yyyy-MM-dd")); ;
            MessageBox.Show("Se ha realizado el deposito del proveedor "+TB_proveedor.Text+ " al proveedor "+CB_proveedores.SelectedItem.ToString()+"");
            Limpiar();
            conexion.Close();
        }

        private void CB_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Proveedor prov = new Proveedor();
                TB_id2.Text = prov.IdProveedor(CB_proveedores.SelectedItem.ToString());
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

               
            }
        }

        public DepositarDeProvaProv(string proveedor,string nombreprov,string usuario)
        {
            this.proveedor = proveedor;
            this.nombreprov = nombreprov;
          
            this.usuario = usuario;
            InitializeComponent();
        }

        private void DepositarDeProvaProv_Load(object sender, EventArgs e)
        {
            TB_proveedor.Text = nombreprov;
            TB_id.Text = proveedor;
            
            Proveedor provedores = new Proveedor();
            ArrayList lista = provedores.Proveedores();

            for (int i = 0; i < lista.Count; i++)
            {
                CB_proveedores.Items.Add(lista[i].ToString());
            }
        }
    }
}
