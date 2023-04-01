using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class frm_proveed : Form
    {
        MySqlConnection Conex;

        public frm_proveed()
        {
            InitializeComponent();
        }

        string idProveedor;
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                
                MessageBox.Show("Ingrese nombre del Proveedor");
            }
            else
            {

                try
                {
                    Conex = BDConexicon.VallartaOpen();
                    guardaProveedor();
                    Conex.Close();

                    lblVa.Text = "OK";
                    lblVa.ForeColor = Color.DarkGreen;

                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch(Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                    lblVa.Text = "NA";
                    lblVa.ForeColor = Color.Red;

                }

                try
                {
                    Conex = BDConexicon.RenaOpen();
                    guardaProveedor();
                    Conex.Close();

                    lblRe.Text = "OK";
                    lblRe.ForeColor = Color.DarkGreen;

                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                    lblRe.Text = "NA";
                    lblRe.ForeColor = Color.Red;

                }

                try
                {
                    Conex = BDConexicon.ColosoOpen();
                    guardaProveedor();
                    Conex.Close();

                    lblCo.Text = "OK";
                    lblCo.ForeColor = Color.DarkGreen;

                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                    lblCo.Text = "NA";
                    lblCo.ForeColor = Color.Red;

                }

                try
                {

                    Conex = BDConexicon.VelazquezOpen();
                    guardaProveedor();
                    Conex.Close();

                    lblVl.Text = "OK";
                    lblVl.ForeColor = Color.DarkGreen;

                }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
                catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
                {
                    lblVl.Text = "NA";
                    lblVl.ForeColor = Color.Red;

                }





                

                

                


            }
            
        }

        public void guardaProveedor()
        {
            MySqlConnection conectar;
            conectar = BDConexicon.conectar();

            string comando;

            comando = "INSERT INTO proveed (PROVEEDOR,NOMBRE,CALLE,COLONIA,POBLA,ESTADO,PAIS, TELEFONO,RFC,CP,MAIL,TIPO,DIAS) " +
             "values (?PROVEEDOR,?NOMBRE,?CALLE,?COLONIA,?POBLA,?ESTADO,?PAIS,?TEL,?RFC,?CP,?EMAIL,'SYS',?DIAS)";


            MySqlCommand cmd = new MySqlCommand(comando, conectar);

            cmd.Parameters.Add("?PROVEEDOR", MySqlDbType.VarChar).Value = obtieneid(); ;
            cmd.Parameters.Add("?NOMBRE", MySqlDbType.VarChar).Value = tbNombre.Text.ToUpper();
            cmd.Parameters.Add("?CALLE", MySqlDbType.VarChar).Value = tbCalle.Text.ToUpper();
            cmd.Parameters.Add("?COLONIA", MySqlDbType.VarChar).Value = tbColonia.Text.ToUpper();
            cmd.Parameters.Add("?POBLA", MySqlDbType.VarChar).Value = tbLocalidad.Text.ToUpper();
            cmd.Parameters.Add("?ESTADO", MySqlDbType.VarChar).Value = tbEstado.Text.ToUpper();
            cmd.Parameters.Add("?TEL", MySqlDbType.VarChar).Value = tbTelefono.Text.ToUpper();
            cmd.Parameters.Add("?PAIS", MySqlDbType.VarChar).Value = tbPais.Text.ToUpper();
            cmd.Parameters.Add("?DIAS", MySqlDbType.VarChar).Value = tbCredito.Text.ToUpper();

           
            cmd.Parameters.Add("?CP", MySqlDbType.VarChar).Value = tbCP.Text;

            cmd.Parameters.Add("?EMAIL", MySqlDbType.VarChar).Value = tbEmail.Text;
            cmd.Parameters.Add("?RFC", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();


            cmd.ExecuteNonQuery();


            conectar.Close();
          

            MessageBox.Show("Agregado");

        }


        public string obtieneid()
        {
           

            string comando = "SELECT Consec FROM consec WHERE Dato='Proveed'";

            int idproveed = 0;
            
            string valor;
            MySqlCommand cmd = new MySqlCommand(comando, Conex);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgvRFC.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvRFC.Rows.Add();

                idproveed = Convert.ToInt32(item["Consec"].ToString());

            }
           

            idproveed = idproveed + 1;
            //MessageBox.Show(idproveed.ToString());
            comando = "";

            ActualizaId(idproveed);

            valor = "00" + idproveed.ToString();
            //MessageBox.Show(valor);
            return valor;
        }

        public void ActualizaId(int id)
        {
            //MessageBox.Show(id.ToString());
            string comando = "UPDATE consec SET Consec=?consec WHERE Dato='Proveed'";
            MySqlCommand Comand = new MySqlCommand(comando, Conex);
            Comand.Parameters.Add("?consec", MySqlDbType.VarChar).Value=id.ToString();
            Comand.ExecuteNonQuery();


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conex = BDConexicon.VallartaOpen();
            buscaProveedor();
            Conex.Close();
            limpiaTiendas();

        }

        public void buscaProveedor()
        {
            

            string comando = "SELECT PROVEEDOR, NOMBRE, RFC  FROM proveed WHERE NOMBRE LIKE'%" + tbRFCBusqueda.Text + "%'";

            MySqlCommand cmd = new MySqlCommand(comando, Conex);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgvRFC.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvRFC.Rows.Add();

                dgvRFC.Rows[n].Cells[0].Value = item["PROVEEDOR"].ToString();
                dgvRFC.Rows[n].Cells[1].Value = item["NOMBRE"].ToString();
                dgvRFC.Rows[n].Cells[2].Value = item["RFC"].ToString();
            }
            
        }

        private void dgvRFC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //idProveedor = dgvRFC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                idProveedor = dgvRFC.Rows[e.RowIndex].Cells[0].Value.ToString();
                btn_nuevo.Enabled = false;
                btn_actualiza.Enabled = true;
                buscaDatosProveedor(idProveedor);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

            }
        }

        public void buscaDatosProveedor(string idProveedor)
        {
            MySqlConnection conectar;
            conectar = BDConexicon.conectar();

            string comando = "SELECT PROVEEDOR,NOMBRE,CALLE,COLONIA,POBLA,ESTADO,PAIS, TELEFONO,RFC,CP,MAIL,TIPO,DIAS FROM proveed WHERE PROVEEDOR=?PROVEEDOR";

            MySqlCommand cmd = new MySqlCommand(comando, conectar);
            cmd.Parameters.Add("?PROVEEDOR", MySqlDbType.VarChar).Value = idProveedor;
            MySqlDataReader mdr;

            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
               
                //idProveedor = mdr.GetString("CLIENTE");
                tbRFC.Text = mdr.GetString("RFC");
                tbNombre.Text = mdr.GetString("NOMBRE");
                tbCredito.Text = mdr.GetString("DIAS");
                tbCalle.Text = mdr.GetString("CALLE");
                tbColonia.Text = mdr.GetString("COLONIA");

                //if (mdr.IsDBNull(6))
                //{
                //    tbInterior.Text = "";
                //}
                //else
                //{
                //    tbInterior.Text = mdr.GetString("numerointerior");
                //}

                //if (mdr.IsDBNull(7))
                //{
                //    tbExterior.Text = "";
                //}
                //else
                //{
                //    tbExterior.Text = mdr.GetString("numeroexterior");
                //}

                tbEstado.Text = mdr.GetString("ESTADO");
                tbLocalidad.Text = mdr.GetString("POBLA");

                tbPais.Text = mdr.GetString("PAIS");
                tbTelefono.Text = mdr.GetString("TELEFONO");
                tbCP.Text = mdr.GetString("CP");
                tbEmail.Text = mdr.GetString("MAIL");




            }

            conectar.Close();

        }

        private void frm_proveed_Load(object sender, EventArgs e)
        {
            btn_actualiza.Enabled = false;
        }

        private void btn_actualiza_Click(object sender, EventArgs e)
        {
            //Conex = BDConexicon.VallartaOpen();
            //actualizaProveedor();



            try
            {
                Conex = BDConexicon.VallartaOpen();
                actualizaProveedor();
                Conex.Close();

                lblVa.Text = "OK";
                lblVa.ForeColor = Color.DarkGreen;

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblVa.Text = "NA";
                lblVa.ForeColor = Color.Red;

            }


            try
            {
                Conex = BDConexicon.RenaOpen();
                actualizaProveedor();
                Conex.Close();

                lblRe.Text = "OK";
                lblRe.ForeColor = Color.DarkGreen;

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblRe.Text = "NA";
                lblRe.ForeColor = Color.Red;

            }

            try
            {
                Conex = BDConexicon.ColosoOpen();
                actualizaProveedor();
                Conex.Close();

                lblCo.Text = "OK";
                lblCo.ForeColor = Color.DarkGreen;

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblCo.Text = "NA";
                lblCo.ForeColor = Color.Red;

            }

            try
            {
                Conex = BDConexicon.VelazquezOpen();
                actualizaProveedor();
                Conex.Close();

                lblVl.Text = "OK";
                lblVl.ForeColor = Color.DarkGreen;

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                lblVl.Text = "NA";
                lblVl.ForeColor = Color.Red;

            }

            Conex.Close();
            limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbRFC.Text = "";
            tbNombre.Text = "";
            tbCredito.Text = "";
            tbCalle.Text = "";
            tbColonia.Text = "";
            tbEstado.Text = "";
            tbLocalidad.Text = "";
            tbPais.Text = "";
            tbTelefono.Text = "";
            tbCP.Text = "";
            tbEmail.Text = "";

            btn_nuevo.Enabled = true;
            btn_actualiza.Enabled = false;

            limpiaTiendas();
        }
        public void limpiar()
        {
            tbRFC.Text = "";
            tbNombre.Text = "";
            tbCredito.Text = "";
            tbCalle.Text = "";
            tbColonia.Text = "";
            tbEstado.Text = "";
            tbLocalidad.Text = "";
            tbPais.Text = "";
            tbTelefono.Text = "";
            tbCP.Text = "";
            tbEmail.Text = "";

            btn_nuevo.Enabled = true;
            btn_actualiza.Enabled = false;

        }

        public void limpiaTiendas()
        {
            lblVa.Text = "-";
            lblRe.Text = "-";
            lblCo.Text = "-";
            lblVl.Text = "-";
        }
        public void actualizaProveedor()
        {
            

            string comando;

            comando = "UPDATE proveed  SET PROVEEDOR=?PROVEEDOR,NOMBRE=?NOMBRE,CALLE=?CALLE,COLONIA=?COLONIA,POBLA=?POBLA,ESTADO=?ESTADO,PAIS=?PAIS, TELEFONO=?TEL,RFC=?RFC,CP=?CP,MAIL=?EMAIL,TIPO=?TIPO,DIAS=?DIAS " +
             "WHERE PROVEEDOR=?PROVEEDOR";


            MySqlCommand cmd = new MySqlCommand(comando, Conex);

            cmd.Parameters.Add("?PROVEEDOR", MySqlDbType.VarChar).Value =idProveedor; ;
            cmd.Parameters.Add("?NOMBRE", MySqlDbType.VarChar).Value = tbNombre.Text.ToUpper();
            cmd.Parameters.Add("?CALLE", MySqlDbType.VarChar).Value = tbCalle.Text.ToUpper();
            cmd.Parameters.Add("?COLONIA", MySqlDbType.VarChar).Value = tbColonia.Text.ToUpper();
            cmd.Parameters.Add("?POBLA", MySqlDbType.VarChar).Value = tbLocalidad.Text.ToUpper();
            cmd.Parameters.Add("?ESTADO", MySqlDbType.VarChar).Value = tbEstado.Text.ToUpper();
            cmd.Parameters.Add("?TEL", MySqlDbType.VarChar).Value = tbTelefono.Text.ToUpper();
            cmd.Parameters.Add("?PAIS", MySqlDbType.VarChar).Value = tbPais.Text.ToUpper();
            cmd.Parameters.Add("?DIAS", MySqlDbType.VarChar).Value = tbCredito.Text.ToUpper();

            cmd.Parameters.Add("?TIPO", MySqlDbType.VarChar).Value = "SYS";
            cmd.Parameters.Add("?CP", MySqlDbType.VarChar).Value = tbCP.Text;

            cmd.Parameters.Add("?EMAIL", MySqlDbType.VarChar).Value = tbEmail.Text.ToLower();
            cmd.Parameters.Add("?RFC", MySqlDbType.VarChar).Value = tbRFC.Text.ToUpper();


            cmd.ExecuteNonQuery();


            


            MessageBox.Show("Agregado");
        }
    }
}
