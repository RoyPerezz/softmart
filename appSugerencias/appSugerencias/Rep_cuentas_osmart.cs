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
    public partial class Rep_cuentas_osmart : Form
    {

        string usuario = "";
        string area = "";
        public Rep_cuentas_osmart(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }


        public void EstadoCuenta()
        {
            DG_tabla.Rows.Clear();
            DateTime fecha;
            MySqlConnection con = BDConexicon.BodegaOpen();
            double saldo = 0;
            if (area.Equals("FINANZAS"))
            {
                try
                {


                    MySqlCommand cmd = new MySqlCommand("SELECT tienda,suc_pago,mov,ie,pagara,fecha,cantidad,ref_gastoexterno,suc_pago " +
                        "FROM rd_historial_saldobancos " +
                        "WHERE  banco='FUNDACION ALBERGUE' and cuenta='FUNDACION ALBERGUE' ORDER BY FECHA", con);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        fecha = Convert.ToDateTime(dr["fecha"].ToString());
                        double cantidad = Convert.ToDouble(dr["cantidad"].ToString());
                        if (dr["ie"].ToString().Equals("I"))
                        {
                            saldo += cantidad;
                            DG_tabla.Rows.Add( dr["mov"].ToString(), dr["pagara"].ToString(),fecha.ToString("dd-MM-yyyy"), "", "", cantidad, "", saldo,dr["tienda"].ToString(), dr["suc_pago"].ToString());
                        }

                        if (dr["ie"].ToString().Equals("E"))
                        {

                            saldo -= cantidad;
                            DG_tabla.Rows.Add( dr["mov"].ToString(), dr["pagara"].ToString(), dr["fecha"].ToString(), dr["ref_gastoexterno"].ToString(), dr["suc_pago"].ToString(), "", cantidad, saldo, dr["tienda"].ToString(), dr["suc_pago"].ToString());
                        }
                    }

                    dr.Close();
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR EN ESTADO DE CUENTA DE CUENTAS OSMART: " + ex);
                }
            }
            else
            {
                try
                {


                    MySqlCommand cmd = new MySqlCommand("SELECT tienda,suc_pago,mov,ie,pagara,fecha,cantidad,ref_gastoexterno,suc_pago " +
                        "FROM rd_historial_saldobancos " +
                        "WHERE  banco='" + CB_banco.SelectedItem.ToString() + "' and cuenta='" + CB_cuentas.SelectedItem.ToString() + "' ORDER BY FECHA", con);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        double cantidad = Convert.ToDouble(dr["cantidad"].ToString());
                        if (dr["ie"].ToString().Equals("I"))
                        {
                            saldo += cantidad;
                            DG_tabla.Rows.Add(dr["mov"].ToString(), dr["pagara"].ToString(), dr["fecha"].ToString(), dr["ref_gastoexterno"].ToString(), dr["suc_pago"].ToString(), cantidad, "", saldo, dr["tienda"].ToString(), dr["suc_pago"].ToString());
                        }

                        if (dr["ie"].ToString().Equals("E"))
                        {

                            saldo -= cantidad;
                            DG_tabla.Rows.Add(dr["mov"].ToString(), dr["pagara"].ToString(), dr["fecha"].ToString(), dr["ref_gastoexterno"].ToString(), dr["suc_pago"].ToString(), "", cantidad, saldo, dr["tienda"].ToString(), dr["suc_pago"].ToString());
                        }
                    }

                    dr.Close();
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR EN ESTADO DE CUENTA DE CUENTAS OSMART: " + ex);
                }
            }


           
            
            


            DG_tabla.Columns[5].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[6].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[7].DefaultCellStyle.Format = "C2";
        }



        private void BT_estado_cuenta_Click(object sender, EventArgs e)
        {
            EstadoCuenta();
        }

        private void Rep_cuentas_osmart_Load(object sender, EventArgs e)
        {

           area = Empleado.Area(usuario);

            if (area.Equals("FINANZAS"))
            {
                CB_sucursal.Enabled = false;
                CB_banco.Enabled = false;
                CB_cuentas.Enabled = false;
                CB_sucursal.SelectedText = "BODEGA";
                //CB_banco.SelectedItem = "FUNDACION ALBERGUE";
                //CB_cuentas.SelectedItem= "FUNDACION ALBERGUE";
            }
            
            

            DG_tabla.Columns["MOV"].Width = 120;
            DG_tabla.Columns["PAGARA"].Width = 250;
           

        }


        //AL SELECCIONAR UNA SUCURSAL, LLENA A CB_BANCOS CON LOS BANCOS REGISTRADOS A LA SUC. SELECCIONADA
        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

            CB_banco.Items.Clear();
            CB_cuentas.Items.Clear();
            CB_banco.Items.Add("");
            CB_banco.SelectedIndex = 0;
            CB_cuentas.Items.Add("");
            CB_cuentas.SelectedIndex = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT distinct banco FROM rd_bancos_osmart WHERE tienda='" + CB_sucursal.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_banco.Items.Add(dr["banco"].ToString());
            }
            dr.Close();
            con.Close();
        }


        //AL SELECCIONAR UN BANCO, SE LLENA A CB_CUENTA CON LAS CUENTAS BANCARIAS EN EL BANCO SELECCIONADO CORRESPONDIENTE A LA SUC. SELECCIONADA
        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_cuentas.Items.Clear();
            CB_cuentas.Items.Add("");
            CB_cuentas.SelectedIndex = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand("SELECT distinct cuenta FROM rd_bancos_osmart WHERE tienda='" + CB_sucursal.SelectedItem.ToString()+"' and banco='"+CB_banco.SelectedItem.ToString()+"'",con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                CB_cuentas.Items.Add(dr["cuenta"].ToString());
            }

            dr.Close();
            con.Close();
        }


        public void Exportar()
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Cells.Range["C6:C100"].NumberFormat = "$#,##0.00";


            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_tabla.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

        }


        //exporta a excel
        private void button1_Click(object sender, EventArgs e)
        {
            Exportar();
        }

        private void BT_ajuste_Click(object sender, EventArgs e)
        {
            AjusteCuentaOS ajuste = new AjusteCuentaOS(usuario);
            ajuste.Show();
        }


       


        
        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            double deposito = 0;
            string clienteBancario = DG_tabla.Rows[e.RowIndex].Cells["PAGARA"].Value.ToString();
            string fecha = DG_tabla.Rows[e.RowIndex].Cells["FECHA"].Value.ToString();
            string tienda = DG_tabla.Rows[e.RowIndex].Cells["TIENDA"].Value.ToString();
            string suc_pago = DG_tabla.Rows[e.RowIndex].Cells["SUC_PAGO"].Value.ToString();
            string mov = DG_tabla.Rows[e.RowIndex].Cells["MOV"].Value.ToString();

            try
            {
                deposito = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["INGRESO"].Value.ToString());
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("Selecciona un registro que sea un ingreso de esta cuenta");
            }
            string banco = CB_banco.SelectedItem.ToString();
            string cuenta = CB_cuentas.SelectedItem.ToString();
            DepositoEntreCuentasOsmart depCuentaOsmart = new   DepositoEntreCuentasOsmart(fecha,clienteBancario,deposito,banco,cuenta,tienda,suc_pago,mov);
            depCuentaOsmart.Show();
        }
    }
}
