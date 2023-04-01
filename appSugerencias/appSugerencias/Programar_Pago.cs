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
    public partial class Programar_Pago : Form
    {
        string usuario = "";
        int indicador = 0;
        public Programar_Pago(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        //LIMPIA EL FORMULARIO
        public void Limpiar()
        {
            try
            {
                //DT_fecha_vencimiento.Value = DateTime.Now;

                CB_sucursal.Items.Clear();
                CB_sucursal.Items.Add("");
                CB_sucursal.Items.Add("BODEGA");
                CB_sucursal.Items.Add("VALLARTA");
                CB_sucursal.Items.Add("RENA");
                CB_sucursal.Items.Add("VELAZQUEZ");
                CB_sucursal.Items.Add("COLOSO");
                CB_sucursal.Items.Add("PREGOT");
                CB_sucursal.SelectedIndex = 0;

                //CB_proveedor.Items.Clear();
                //CB_proveedor.Items.Add("");
                //Proveedores();
                //CB_proveedor.SelectedIndex = 0;

                //TB_proveedor.Text = "";

                CB_compra.Items.Clear();
                CB_compra.Items.Add("");
                CB_compra.SelectedIndex = 0;

                TB_enlace.Text = "";
                TB_rfc.Text = "";
                TB_factura.Text = "";

                CB_banco.Items.Clear();
                CB_banco.Items.Add("");
                CB_banco.SelectedIndex = 0;

                CB_cuenta.Items.Clear();
                CB_cuenta.Items.Add("");
                CB_cuenta.SelectedIndex = 0;

                TB_cliente.Text = "";

                CB_tipo_pago.Items.Clear();
                CB_tipo_pago.Items.Add("");
                CB_tipo_pago.Items.Add("EFECTIVO");
                CB_tipo_pago.Items.Add("DEP/EFE");
                CB_tipo_pago.Items.Add("SPEI");
                CB_tipo_pago.SelectedIndex = 0;

                //CB_proveedoresServicios.Items.Clear();
                //CB_proveedoresServicios.Items.Add("");
                //ProveedoresServicios();
                //CB_proveedoresServicios.SelectedIndex = 0;

                CB_patrones.Items.Clear();
                CB_patrones.Items.Add("");
                CB_patrones.SelectedIndex = 0;

                TB_concepto.Text = "";
                TB_iva.Text = "";
                //TB_proveedorServ.Text = "";

                TB_importe.Text = "";
                CHX_anticipado.Checked = false;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                
            }

           

        }

        //INSERTA LOS CAMPOS EN LA TABLA rd_programar_pago
        public void ProgramarPago()
        {

            DateTime fecha = DateTime.Now;
            DateTime fecha_venc = DT_fecha_vencimiento.Value;
            int anticipado = 0;

            if (CHX_anticipado.Checked==true)
            {
                anticipado =1;
            }


            if (indicador==0)
            {
                if (CB_tipo_pago.SelectedItem.ToString().Equals("EFECTIVO"))
                {
                  
                    try
                    {
                        MySqlConnection conexion = BDConexicon.BodegaOpen();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_programar_pago(fecha_programada,fecha_venc,sucursal,proveedor,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,anticipado,patron,importe,iva,concepto,factura,usuario,estado,indicador)" +
                            "VALUES(?fecha_programada,?fecha_venc,?sucursal,?proveedor,?rfc,?compra,?enlace,?banco,?cuenta,?clientebancario,?tipo_pago,?anticipado,?patron,?importe,?iva,?concepto,?factura,?usuario,?estado,?indicador)", conexion);


                        cmd.Parameters.AddWithValue("?fecha_programada", fecha.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?fecha_venc", fecha_venc.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?proveedor", TB_proveedor.Text);
                        cmd.Parameters.AddWithValue("?rfc","");
                        cmd.Parameters.AddWithValue("?compra", CB_compra.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?enlace", TB_enlace.Text);
                        cmd.Parameters.AddWithValue("?banco", "");
                        cmd.Parameters.AddWithValue("?cuenta", "");
                        cmd.Parameters.AddWithValue("?clientebancario", "");
                        cmd.Parameters.AddWithValue("?tipo_pago", CB_tipo_pago.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?anticipado", anticipado);
                        cmd.Parameters.AddWithValue("?patron", "");
                        cmd.Parameters.AddWithValue("?importe", TB_importe.Text);
                        cmd.Parameters.AddWithValue("?iva", TB_iva.Text);
                        cmd.Parameters.AddWithValue("?concepto", "");
                        cmd.Parameters.AddWithValue("?factura", "");
           
                        cmd.Parameters.AddWithValue("?usuario", usuario);
                        cmd.Parameters.AddWithValue("?estado", 0);
                        cmd.Parameters.AddWithValue("?indicador", indicador);
                        cmd.ExecuteNonQuery();
                        Limpiar();
                        MessageBox.Show("Se ha programado el pago");
                        conexion.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al programar el pago: " + ex);
                    }
                }
                if (CB_tipo_pago.SelectedItem.ToString().Equals("DEP/EFE"))
                {
                    try
                    {
                        MySqlConnection conexion = BDConexicon.BodegaOpen();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_programar_pago(fecha_programada,fecha_venc,sucursal,proveedor,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,anticipado,patron,importe,iva,concepto,factura,usuario,estado,indicador)" +
                            "VALUES(?fecha_programada,?fecha_venc,?sucursal,?proveedor,?rfc,?compra,?enlace,?banco,?cuenta,?clientebancario,?tipo_pago,?anticipado,?patron,?importe,?iva,?concepto,?factura,?usuario,?estado,?indicador)", conexion);


                        cmd.Parameters.AddWithValue("?fecha_programada", fecha.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?fecha_venc", fecha_venc.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?proveedor", TB_proveedor.Text);
                        cmd.Parameters.AddWithValue("?rfc","");
                        cmd.Parameters.AddWithValue("?compra", CB_compra.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?enlace", TB_enlace.Text);
                        cmd.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?clientebancario", TB_cliente.Text);
                        cmd.Parameters.AddWithValue("?tipo_pago", CB_tipo_pago.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?anticipado", anticipado);
                        cmd.Parameters.AddWithValue("?patron", "");
                        cmd.Parameters.AddWithValue("?importe", TB_importe.Text);
                        cmd.Parameters.AddWithValue("?iva", TB_iva.Text);
                        cmd.Parameters.AddWithValue("?concepto", "");
                        cmd.Parameters.AddWithValue("?factura", "");
                        cmd.Parameters.AddWithValue("?usuario", usuario);
                        cmd.Parameters.AddWithValue("?estado", 0);
                        cmd.Parameters.AddWithValue("?indicador", indicador);
                        cmd.ExecuteNonQuery();
                        Limpiar();
                        MessageBox.Show("Se ha programado el pago");
                        conexion.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al programar el pago: " + ex);
                    }
                }

                if (CB_tipo_pago.SelectedItem.ToString().Equals("SPEI"))
                {
                    try
                    {
                        MySqlConnection conexion = BDConexicon.BodegaOpen();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_programar_pago(fecha_programada,fecha_venc,sucursal,proveedor,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,anticipado,patron,importe,iva,concepto,factura,usuario,estado,indicador)" +
                            "VALUES(?fecha_programada,?fecha_venc,?sucursal,?proveedor,?rfc,?compra,?enlace,?banco,?cuenta,?clientebancario,?tipo_pago,?anticipado,?patron,?importe,?iva,?concepto,?factura,?usuario,?estado,?indicador)", conexion);


                        cmd.Parameters.AddWithValue("?fecha_programada", fecha.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?fecha_venc", fecha_venc.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?proveedor", TB_proveedor.Text);
                        cmd.Parameters.AddWithValue("?rfc", TB_rfc.Text);
                        cmd.Parameters.AddWithValue("?compra", CB_compra.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?enlace", TB_enlace.Text);
                        cmd.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?clientebancario", TB_cliente.Text);
                        cmd.Parameters.AddWithValue("?tipo_pago", CB_tipo_pago.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?anticipado", anticipado);
                        cmd.Parameters.AddWithValue("?patron", CB_patrones.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?importe", TB_importe.Text);
                        cmd.Parameters.AddWithValue("?iva", TB_iva.Text);
                        cmd.Parameters.AddWithValue("?concepto", "");
                        cmd.Parameters.AddWithValue("?factura", TB_factura.Text);
                        cmd.Parameters.AddWithValue("?usuario", usuario);
                        cmd.Parameters.AddWithValue("?estado", 0);
                        cmd.Parameters.AddWithValue("?indicador", indicador);
                        cmd.ExecuteNonQuery();
                        Limpiar();
                        MessageBox.Show("Se ha programado el pago");
                        conexion.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al programar el pago: " + ex);
                    }
                }
            }

            if (indicador==1)
            {
                if (CB_tipo_pago.SelectedItem.ToString().Equals("EFECTIVO"))
                {
                    
                    try
                    {
                        MySqlConnection conexion = BDConexicon.BodegaOpen();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_programar_pago(fecha_programada,fecha_venc,sucursal,proveedor,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,anticipado,patron,importe,iva,concepto,factura,usuario,estado,indicador)" +
                            "VALUES(?fecha_programada,?fecha_venc,?sucursal,?proveedor,?rfc,?compra,?enlace,?banco,?cuenta,?clientebancario,?tipo_pago,?anticipado,?patron,?importe,?iva,?concepto,?factura,?usuario,?estado,?indicador)", conexion);


                        cmd.Parameters.AddWithValue("?fecha_programada", fecha.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?fecha_venc", fecha_venc.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?proveedor", TB_proveedorServ.Text);
                        cmd.Parameters.AddWithValue("?rfc", "");
                        cmd.Parameters.AddWithValue("?compra", "");
                        cmd.Parameters.AddWithValue("?enlace", "");
                        cmd.Parameters.AddWithValue("?banco", "");
                        cmd.Parameters.AddWithValue("?cuenta", "");
                        cmd.Parameters.AddWithValue("?clientebancario", "");
                        cmd.Parameters.AddWithValue("?tipo_pago", CB_tipo_pago.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?anticipado",anticipado);
                        cmd.Parameters.AddWithValue("?patron", "");
                        cmd.Parameters.AddWithValue("?importe", TB_importe.Text);
                        cmd.Parameters.AddWithValue("?iva", TB_iva.Text);
                        cmd.Parameters.AddWithValue("?concepto", TB_concepto.Text);
                        cmd.Parameters.AddWithValue("?factura", "");
                        cmd.Parameters.AddWithValue("?usuario", usuario);
                        cmd.Parameters.AddWithValue("?estado", 0);
                        cmd.Parameters.AddWithValue("?indicador",indicador);
                        cmd.ExecuteNonQuery();
                        Limpiar();
                        MessageBox.Show("Se ha programado el pago");
                        conexion.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al programar el pago: " + ex);
                    }
                }
                if (CB_tipo_pago.SelectedItem.ToString().Equals("DEP/EFE"))
                {
                    try
                    {
                        MySqlConnection conexion = BDConexicon.BodegaOpen();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_programar_pago(fecha_programada,fecha_venc,sucursal,proveedor,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,patron,importe,iva,concepto,factura,usuario,estado,indicador)" +
                            "VALUES(?fecha_programada,?fecha_venc,?sucursal,?proveedor,?rfc,?compra,?enlace,?banco,?cuenta,?clientebancario,?tipo_pago,?patron,?importe,?iva,?concepto,?factura,?usuario,?estado,?indicador)", conexion);


                        cmd.Parameters.AddWithValue("?fecha_programada", fecha.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?fecha_venc", fecha_venc.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?proveedor", TB_proveedorServ.Text);
                        cmd.Parameters.AddWithValue("?rfc", "");
                        cmd.Parameters.AddWithValue("?compra", "");
                        cmd.Parameters.AddWithValue("?enlace", "");
                        cmd.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?clientebancario", TB_cliente.Text);
                        cmd.Parameters.AddWithValue("?tipo_pago", CB_tipo_pago.SelectedItem.ToString());

                        cmd.Parameters.AddWithValue("?patron", "");
                        cmd.Parameters.AddWithValue("?importe", TB_importe.Text);
                        cmd.Parameters.AddWithValue("?iva", TB_iva.Text);
                        cmd.Parameters.AddWithValue("?concepto", TB_concepto.Text);
                        cmd.Parameters.AddWithValue("?factura", "");
                        cmd.Parameters.AddWithValue("?usuario", usuario);
                        cmd.Parameters.AddWithValue("?estado", 0);
                        cmd.Parameters.AddWithValue("?indicador", indicador);
                        cmd.ExecuteNonQuery();
                        Limpiar();
                        MessageBox.Show("Se ha programado el pago");
                        conexion.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al programar el pago: " + ex);
                    }
                }

                if (CB_tipo_pago.SelectedItem.ToString().Equals("SPEI"))
                {
                    try
                    {
                        MySqlConnection conexion = BDConexicon.BodegaOpen();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_programar_pago(fecha_programada,fecha_venc,sucursal,proveedor,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,patron,importe,iva,concepto,factura,usuario,estado,indicador)" +
                            "VALUES(?fecha_programada,?fecha_venc,?sucursal,?proveedor,?rfc,?compra,?enlace,?banco,?cuenta,?clientebancario,?tipo_pago,?patron,?importe,?iva,?concepto,?factura,?usuario,?estado,?indicador)", conexion);


                        cmd.Parameters.AddWithValue("?fecha_programada", fecha.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?fecha_venc", fecha_venc.ToString("yyy-MM-dd"));
                        cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?proveedor", TB_proveedorServ.Text);
                        cmd.Parameters.AddWithValue("?rfc", TB_rfc.Text);
                        cmd.Parameters.AddWithValue("?compra", "");
                        cmd.Parameters.AddWithValue("?enlace", "");
                        cmd.Parameters.AddWithValue("?banco", CB_banco.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?cuenta", CB_cuenta.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?clientebancario", TB_cliente.Text);
                        cmd.Parameters.AddWithValue("?tipo_pago", CB_tipo_pago.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?patron", CB_patrones.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("?importe", TB_importe.Text);
                        cmd.Parameters.AddWithValue("?iva", TB_iva.Text);
                        cmd.Parameters.AddWithValue("?concepto", TB_concepto.Text);
                        cmd.Parameters.AddWithValue("?factura", TB_factura.Text);
                        cmd.Parameters.AddWithValue("?usuario", usuario);
                        cmd.Parameters.AddWithValue("?estado", 0);
                        cmd.Parameters.AddWithValue("?indicador", indicador);
                        cmd.ExecuteNonQuery();
                        Limpiar();
                        MessageBox.Show("Se ha programado el pago");
                        conexion.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al programar el pago: " + ex);
                    }
                }
            }


            

        }

        //OBTIENE LOS NOMBRES DE LOS PROVEEDORES
        public void Proveedores()
        {
            Proveedor p = new Proveedor();
           ArrayList prov = p.Proveedores();
            for (int i = 0; i < prov.Count; i++)
            {
                CB_proveedor.Items.Add(prov[i]);
            }
        }

        //OBTIENE LOS NOMBRES DE LOS PROVEEDORES DE SERVICIO
        public void ProveedoresServicios()
        {
            Proveedor p = new Proveedor();
            ArrayList provServ = p.ProveedoresServicios();
            for (int i = 0; i < provServ.Count; i++)
            {
                CB_proveedoresServicios.Items.Add(provServ[i]);
            }
        }


        //BOTON QUE EJECUTA EL METODO PROGRAMARPAGO
        private void BT_programarPago_Click(object sender, EventArgs e)
        {
            ProgramarPago();
        }


        //AL CARGAR EL FORM SE EJECUTA EL METODO PROVEEDORES
        private void Programar_Pago_Load(object sender, EventArgs e)
        {
            CB_patrones.Enabled = false;
            BT_patron.Enabled = false;
            Proveedores();
            ProveedoresServicios();
            }


        //EVENTO QUE NOS TRAE EL NUMERO DE PROVEEDOR
        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "SELECT PROVEEDOR FROM PROVEED WHERE NOMBRE='"+CB_proveedor.SelectedItem.ToString()+"'";
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_proveedor.Text = dr["PROVEEDOR"].ToString();
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR AL SELECCIONAR AL PROVEEDOR: "+ex);
            }

        }

        //OBTIENE LAS COMPRAS DEL PROVEEDOR SELECCIONADO EN LA SUCURSAL SELECCIONADA
        public void Compras()
        {
            CB_compra.Items.Clear();
            CB_compra.Items.Add("");
            CB_compra.SelectedIndex = 0;
            LB_mensajeCompras.Text = "Buscando compras";
            Compras comp = new Compras();
            ArrayList compras = comp.ListaCompras(CB_sucursal.SelectedItem.ToString(),TB_proveedor.Text);

            for (int i = 0; i < compras.Count; i++)
            {
                CB_compra.Items.Add(compras[i]);
            }
            LB_mensajeCompras.Text = "";
        }

       
        private void BT_compras_Click(object sender, EventArgs e)
        {
        }

        private void BT_bancos_Click(object sender, EventArgs e)
        {

           



                CB_banco.Items.Clear();
                CB_banco.Items.Add("");
                CB_banco.SelectedIndex = 0;

                CB_cuenta.Items.Clear();
                CB_cuenta.Items.Add("");
                CB_cuenta.SelectedIndex = 0;

                TB_cliente.Text = "";
            if (indicador==0)
            {
                Proveedor p = new Proveedor();
                ArrayList bancos = p.Bancos(TB_proveedor.Text);
                for (int i = 0; i < bancos.Count; i++)
                {
                    CB_banco.Items.Add(bancos[i]);
                }
            }

            if (indicador==1)
            {
                Proveedor p = new Proveedor();
                ArrayList bancos = p.ProvServBancos(TB_proveedorServ.Text);
                for (int i = 0; i < bancos.Count; i++)
                {
                    CB_banco.Items.Add(bancos[i]);
                }
            }
                
            

        }

        private void CB_banco_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (indicador==0)
                {
                    CB_cuenta.Items.Clear();
                    CB_cuenta.Items.Add("");
                    CB_cuenta.SelectedIndex = 0;
                    TB_cliente.Text = "";
                    Proveedor p = new Proveedor();
                    ArrayList cuentas = p.Cuentas(CB_banco.SelectedItem.ToString(), TB_proveedor.Text);

                    for (int i = 0; i < cuentas.Count; i++)
                    {
                        CB_cuenta.Items.Add(cuentas[i]);
                    }
                }

                if (indicador==1)
                {
                    CB_cuenta.Items.Clear();
                    CB_cuenta.Items.Add("");
                    CB_cuenta.SelectedIndex = 0;
                    TB_cliente.Text = "";
                    Proveedor p = new Proveedor();
                    ArrayList cuentas = p.ProvServCuentas(CB_banco.SelectedItem.ToString(), TB_proveedorServ.Text);

                    for (int i = 0; i < cuentas.Count; i++)
                    {
                        CB_cuenta.Items.Add(cuentas[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
                
            }
        }

        private void CB_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (indicador==0)
                {
                    TB_cliente.Text = "";
                    Proveedor p = new Proveedor();
                    ArrayList cliente = p.ClientesBancarios(CB_banco.SelectedItem.ToString(), CB_cuenta.SelectedItem.ToString());

                    TB_cliente.Text = cliente[0].ToString();
                }

                if (indicador == 1)
                {
                    TB_cliente.Text = "";
                    Proveedor p = new Proveedor();
                    ArrayList cliente = p.PSClientesBancarios(CB_banco.SelectedItem.ToString(), CB_cuenta.SelectedItem.ToString(),TB_proveedorServ.Text);

                    TB_cliente.Text = cliente[0].ToString();
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void CB_tipo_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_tipo_pago.SelectedItem.ToString().Equals("EFECTIVO"))
            {
                CB_banco.Enabled = false;
                CB_cuenta.Enabled = false;
                TB_cliente.Enabled = false;
                BT_bancos.Enabled = false;

                CB_patrones.Enabled = false;
                BT_patron.Enabled = false;



            }

            if (CB_tipo_pago.SelectedItem.ToString().Equals("SPEI"))
           {
                CB_banco.Enabled = true;
                CB_cuenta.Enabled =true;
                TB_cliente.Enabled =true;
                BT_bancos.Enabled = true;


                BT_patron.Enabled = true;
              CB_patrones.Enabled = true;
              


            }


            if (CB_tipo_pago.SelectedItem.ToString().Equals("DEP/EFE"))
            {
                CB_banco.Enabled = true;
                CB_cuenta.Enabled = true;
                TB_cliente.Enabled = true;
                BT_bancos.Enabled = true;

                BT_patron.Enabled = false;
            
                CB_patrones.Enabled = false;
               
            }
        }

        private void BT_bancosOsmart_Click(object sender, EventArgs e)
        {
           
        }


        //patrones
        private void BT_bancosOsmart_Click_1(object sender, EventArgs e)
        {

           
            CB_patrones.Items.Clear();
            CB_patrones.Items.Add("");
            CB_patrones.SelectedIndex = 0;

        


            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT DISTINCT clientebancario FROM rd_bancos_osmart";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_patrones.Items.Add(dr["clientebancario"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        private void CB_banco_osmart_SelectedIndexChanged(object sender, EventArgs e)
        {


           
        }

        private void CB_cuenta_os_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TB_importe_Enter(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (tabControl1.SelectedIndex == 0)
            {
                indicador = 0;
            }


            if (tabControl1.SelectedIndex==1)
            {
                indicador = 1;
            }
        }

        private void CB_proveedoresServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = CB_proveedoresServicios.SelectedItem.ToString();
            string query = "SELECT idprov FROM rd_proveedor_servicios WHERE nombre='" + nombre + "'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_proveedorServ.Text = dr["idprov"].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void CB_proveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string nombre = CB_proveedor.SelectedItem.ToString();
            string query = "SELECT proveedor FROM proveed WHERE nombre='" + nombre + "'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_proveedor.Text = dr["proveedor"].ToString();
            }
            dr.Close();
            con.Close();
        }


        //EJECUTA EL METODO COMPRAS
        private void BT_compras_Click_1(object sender, EventArgs e)
        {

            if (CB_sucursal.SelectedIndex == -1 || TB_proveedor.Text.Equals(""))
            {
                MessageBox.Show("Debes elegir la sucursal y el proveedor");
            }
            else
            {
                try
                {
                    Compras();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    MessageBox.Show("Debes elegir la sucursal y el proveedor, además revisa tu conexión a la red");
                }
            }
        }

        private void TB_importe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CB_tipo_pago.SelectedItem.ToString().Equals("SPEI"))
                {
                    double importe = Convert.ToDouble(TB_importe.Text);
                    double iva = (importe / 1.16) * 0.16;
                    TB_iva.Text = Convert.ToString(iva);
                }
                else
                {
                    TB_iva.Text = "0";
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                TB_iva.Text = "0";
            }
        }
    }
}
