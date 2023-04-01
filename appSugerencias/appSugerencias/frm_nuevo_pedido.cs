using System;

using System.Data;

using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace appSugerencias
{
    public partial class frm_nuevo_pedido : Form
    {
        string UsuarioMyB;
        string Area;
        string guia = "", nota = "", com_pago = "",estado="";
#pragma warning disable CS0414 // El campo 'frm_nuevo_pedido.rutaDestino' está asignado pero su valor nunca se usa
        string rutaDestino = "";
#pragma warning restore CS0414 // El campo 'frm_nuevo_pedido.rutaDestino' está asignado pero su valor nunca se usa

        public frm_nuevo_pedido()
        {
            InitializeComponent();
        }


        MySqlConnection Conex = BDConexicon.BodegaOpen();

        public frm_nuevo_pedido(string usuario,string area,int x, string id)
        {
            byte urge = 1;
            byte  bo=1,va = 1, re = 1, co = 1, ve = 1, pm = 1;
            string proveed = "";
            UsuarioMyB = usuario;
            
            Area = area;
            Area = "SISTEMAS";


            InitializeComponent();
            if (x == 1)
            {
                
            }
            else
            {


                

                string comando = "SELECT * FROM rd_pedido WHERE id_pedido='" + id + "'";
                
                MySqlCommand cmd = new MySqlCommand(comando, Conex);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();

                


                adaptador.Fill(dt);

               

                foreach (DataRow item in dt.Rows)
                {
                    
                    tbIdPedido.Text = item["id_pedido"].ToString();
                    tbPedido2.Text= item["id_pedido"].ToString();

                    tbPedido.Text = item["titulo_pedido"].ToString();
                    tbTitulo2.Text = item["titulo_pedido"].ToString();
                    tbArea.Text = item["area"].ToString();
                    proveed = item["proveedor"].ToString();
                    estado= item["estatus"].ToString();
                   
                    tbIdProv.Text = item["proveedor"].ToString();

                    tbLink.Text = item["link_pedido"].ToString();

                    link.Links.Add(0, 0, item["link_pedido"].ToString());

                    tbCotiz.Text = item["cotiz"].ToString();
                    tbGuia.Text = item["guia"].ToString();
                    tbNota.Text = item["nota"].ToString();
                    tbComPago.Text = item["comprobante_pago"].ToString();

                    urge = Convert.ToByte(item["pago_urge"].ToString());
                    bo = Convert.ToByte(item["bo"].ToString());
                    va = Convert.ToByte(item["va"].ToString());
                    re = Convert.ToByte(item["re"].ToString());
                    co = Convert.ToByte(item["co"].ToString());
                    ve = Convert.ToByte(item["vl"].ToString());
                    pm = Convert.ToByte(item["pm"].ToString());


                    if (item["forma_pago"].ToString() == "EFECTIVO")
                    {
                        cbFormaPago.SelectedIndex = 1;
                    }
                    if (item["forma_pago"].ToString() == "DEP/F")
                    {
                        cbFormaPago.SelectedIndex = 2;
                    }
                    if (item["forma_pago"].ToString()=="SPEI")
                    {
                        cbFormaPago.SelectedIndex = 3;
                    }


                    if (item["tipo_pago"].ToString() == "ANTICIPADO")
                    {
                        cbTipoPago.SelectedIndex = 1;
                    }
                    if (item["tipo_pago"].ToString() == "CONTADO")
                    {
                        cbTipoPago.SelectedIndex = 2;
                    }
                    if (item["tipo_pago"].ToString() == "CREDITO")
                    {
                        cbTipoPago.SelectedIndex = 3;
                    }

                    //tbTipoPago.Text = item["tipo_pago"].ToString();
                    //tbFormaPago.Text = item["forma_pago"].ToString();
                    tbObservaciones.Text = item["observaciones"].ToString();


                }


                MySqlCommand cm = new MySqlCommand("SELECT NOMBRE FROM proveed WHERE PROVEEDOR='" + proveed + "'", Conex);

                MySqlDataAdapter adaptador1 = new MySqlDataAdapter(cm);
                System.Data.DataTable dt1 = new System.Data.DataTable();

                adaptador1.Fill(dt1);

                foreach (DataRow item in dt1.Rows)
                {
                    tbProveedor.Text = item["NOMBRE"].ToString();
                }

                Conex.Close();


                cbProveedor.Visible = false;
                tbProveedor.Visible = true;
                
                tbProveedor.Enabled = false;
                link.Visible = true;

                if (bo == 1)
                {
                    cBoxBo.Checked = true;
                }
                if (va == 1)
                {
                    cBoxVa.Checked = true;
                }
                else
                {
                    cBoxVa.Checked = false;
                }

                if (re == 1)
                {
                    cBoxRe.Checked = true;
                }
                else
                {
                    cBoxRe.Checked = false;
                }

                if (co == 1)
                {
                    cBoxCo.Checked = true;
                }
                else
                {
                    cBoxCo.Checked = false;
                }

                if (ve == 1)
                {
                    cBoxVl.Checked = true;
                }
                else
                {
                    cBoxVl.Checked = false;
                }


                if (pm == 1)
                {
                    cBoxPm.Checked = true;
                }
                else
                {
                    cBoxPm.Checked = false;
                }

                if (urge == 1)
                {
                    cBoxUrge.Checked = true;
                }
                else
                {
                    cBoxUrge.Checked = false;
                }


                busquedaReporte();

            }

        }


        public void busquedaReporte()
        {
           

           
            string comando = "SELECT rd_pedido_reportes.tienda,rd_pedido_reportes.almacen,rd_pedido_reportes.piso_venta,rd_pedido_reportes.reporte FROM rd_pedido_reportes INNER JOIN rd_pedido ON rd_pedido_reportes.fk_idpedido = rd_pedido.id_pedido WHERE rd_pedido.id_pedido = '"+tbIdPedido.Text+"'";
           
            MySqlCommand cmd = new MySqlCommand(comando, Conex);


            MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();

          

            adaptador.Fill(dt);

            dgvReportes.Rows.Clear();



            foreach (DataRow item in dt.Rows)
            {
                int n = dgvReportes.Rows.Add();
                bool almacen = false, piso = false, reporte = false;

                if (item["almacen"].ToString() == "1")
                {
                    almacen = true;
                }

                if (item["piso_venta"].ToString() == "1")
                {
                    piso = true;
                }

                if (item["reporte"].ToString() == "1")
                {
                    reporte = true;
                }




                dgvReportes.Rows[n].Cells[0].Value = item["tienda"].ToString();
                dgvReportes.Rows[n].Cells[1].Value = almacen;
                dgvReportes.Rows[n].Cells[2].Value = piso;
                dgvReportes.Rows[n].Cells[3].Value = reporte;
               

            }

            Conex.Close();
        }

        public void llenaComboBoxEstado()
        {
           
            cbEstadoPedido.DataSource = null;


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_pedido_estado WHERE usuarios LIKE '%"+UsuarioMyB+"%'", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            mysqladap.Fill(dt);

            cbEstadoPedido.ValueMember = "idestado";
            cbEstadoPedido.DisplayMember = "estado";
            cbEstadoPedido.DataSource = dt;
            
        }


        private void frm_nuevo_pedido_Load(object sender, EventArgs e)
        {
            if ( Area == "SISTEMAS" || Area == "ADMON GRAL" || Area == "SUPER")
            {
                gbDatosGrl.Enabled = true;
            }
            else
            {
                gbDatosGrl.Enabled = false;
            }

            if (Area == "SISTEMAS" || Area == "ADMON GRAL" || Area == "CXPAGAR")
            {
                gbPagos.Enabled = true;
            }
            else
            {
                gbPagos.Enabled = false;
            }

            if (Area == "SISTEMAS" || Area == "ADMON GRAL" || Area == "SUPER" || Area == "CXPAGAR")
            {
                btguardar.Enabled = true;
            }
            else
            {
                btguardar.Enabled = false;
            }

            tbIdPedido.Enabled = false;
            llenaComboProveedor();
            llenaComboArea();
            llenaComboBoxEstado();
            Conex.Close();

        }


        public void llenaComboProveedor()
        {
            cbProveedor.DataSource = null;

            

            MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE FROM proveed ", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbProveedor.ValueMember = "PROVEEDOR";
            cbProveedor.DisplayMember = "NOMBRE";
            cbProveedor.DataSource = dt1;
            Conex.Close();
        }

        public void llenaComboArea()
        {
            cbLinea.DataSource = null;

            
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_pedido_area", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbLinea.ValueMember = "idarea";
            cbLinea.DisplayMember = "area";
            cbLinea.DataSource = dt1;
            Conex.Close();
        }


        public void guardaDatos()
        {
            string comando;
            string idpedido;
            int bo = 0, va=0, re=0, vl=0, co=0, pm=0;
            DateTime fecha = dtDia.Value;
            



            try
            {

                comando = "INSERT INTO rd_pedido (titulo_pedido,fecha,area,proveedor,link_pedido,estatus,cotiz,pago_urge,tipo_pago,forma_pago,observaciones,bo,va,re,vl,co,pm) values (?titulo_pedido,?fecha,?area,?proveedor,?link_pedido,?estatus,?cotiz,?pago_urge,?tipo_pago,?forma_pago,?observaciones,?bo,?va,?re,?vl,?co,?pm)";



                MySqlCommand cmd = new MySqlCommand(comando, Conex);
                cmd.Parameters.Add("?titulo_pedido", MySqlDbType.VarChar).Value = tbPedido.Text.ToUpper(); ; ;
                cmd.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("?area", MySqlDbType.VarChar).Value = tbArea.Text;
                cmd.Parameters.Add("?proveedor", MySqlDbType.VarChar).Value = cbProveedor.SelectedValue.ToString();
                cmd.Parameters.Add("?link_pedido", MySqlDbType.VarChar).Value = tbLink.Text;
                cmd.Parameters.Add("?estatus", MySqlDbType.VarChar).Value = "CREADO";
                cmd.Parameters.Add("?cotiz", MySqlDbType.VarChar).Value = tbCotiz.Text;
                //cmd.Parameters.Add("?nota", MySqlDbType.VarChar).Value = tbNota.Text;
                //cmd.Parameters.Add("?guia", MySqlDbType.VarChar).Value =guardaarchivos(tbGuia.Text,guia,1);
                //cmd.Parameters.Add("?comprobante_pago", MySqlDbType.VarChar).Value = tbComPago.Text;
                cmd.Parameters.Add("?tipo_pago", MySqlDbType.VarChar).Value = cbTipoPago.Text ;
                cmd.Parameters.Add("?forma_pago", MySqlDbType.VarChar).Value = cbFormaPago.Text ;
                cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar).Value = tbObservaciones.Text.ToUpper(); ;

                if (cBoxUrge.Checked)
                {
                    cmd.Parameters.Add("?pago_urge", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?pago_urge", MySqlDbType.VarChar).Value = 0;

                }


                if (cBoxBo.Checked)
                {
                    bo = 1;
                }

                cmd.Parameters.Add("?bo", MySqlDbType.VarChar).Value = bo;

                if (cBoxVa.Checked)
                {
                     va = 1;
                }

                cmd.Parameters.Add("?va", MySqlDbType.VarChar).Value = va;



                if (cBoxRe.Checked)
                {
                    re= 1;
                }
                cmd.Parameters.Add("?re", MySqlDbType.VarChar).Value = re;


                if (cBoxVl.Checked)
                {
                    vl = 1;
                }
                cmd.Parameters.Add("?vl", MySqlDbType.VarChar).Value = vl;


                if (cBoxCo.Checked)
                {
                    co = 1;
                }
                cmd.Parameters.Add("?co", MySqlDbType.VarChar).Value = co;


                if (cBoxPm.Checked)
                {
                    pm = 1;
                }
                cmd.Parameters.Add("?pm", MySqlDbType.VarChar).Value = pm;

                cmd.ExecuteNonQuery();



                idpedido = cmd.LastInsertedId.ToString();

                if (tbGuia.Text != "")
                {
                   

                    MySqlCommand ccmdR = new MySqlCommand("UPDATE rd_pedido SET guia=?guia WHERE id_pedido=?id_pedido", Conex);
                    ccmdR.Parameters.Add("?guia", MySqlDbType.VarChar).Value = guardaarchivos(tbGuia.Text, guia, 1, idpedido);
                    ccmdR.Parameters.Add("?id_pedido", MySqlDbType.VarChar).Value = idpedido;

                    ccmdR.ExecuteNonQuery();

                }

                


                if (tbNota.Text != "")
                {


                    MySqlCommand ccmdR = new MySqlCommand("UPDATE rd_pedido SET nota=?nota WHERE id_pedido=?id_pedido", Conex);
                    ccmdR.Parameters.Add("?nota", MySqlDbType.VarChar).Value = guardaarchivos(tbNota.Text, nota, 2, idpedido);
                    ccmdR.Parameters.Add("?id_pedido", MySqlDbType.VarChar).Value = idpedido;

                    ccmdR.ExecuteNonQuery();

                }

                if (tbComPago.Text != "")
                {


                    MySqlCommand ccmdR = new MySqlCommand("UPDATE rd_pedido SET comprobante_pago=?com_pago WHERE id_pedido=?id_pedido", Conex);
                    ccmdR.Parameters.Add("?com_pago", MySqlDbType.VarChar).Value = guardaarchivos(tbComPago.Text, com_pago, 3, idpedido);
                    ccmdR.Parameters.Add("?id_pedido", MySqlDbType.VarChar).Value = idpedido;

                    ccmdR.ExecuteNonQuery();

                }


                MySqlCommand cmdHistorial = new MySqlCommand("INSERT INTO rd_pedido_historial (id_pedido,movimiento,estado1,estado2,fecha,usuario) values(?id_pedido,?movimiento,?estado1,?estado2,?fecha,?usuario)", Conex);
                cmdHistorial.Parameters.Add("?id_pedido", MySqlDbType.VarChar).Value = idpedido;
                cmdHistorial.Parameters.Add("?movimiento", MySqlDbType.VarChar).Value = "CREACION";
                cmdHistorial.Parameters.Add("?estado1", MySqlDbType.VarChar).Value = "CREADO";
                cmdHistorial.Parameters.Add("?estado2", MySqlDbType.VarChar).Value = "";
                cmdHistorial.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmdHistorial.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = UsuarioMyB;
                cmdHistorial.ExecuteNonQuery();


                MySqlCommand cmdVa = new MySqlCommand("INSERT INTO rd_pedido_reportes (fk_idpedido,tienda,almacen,piso_venta,reporte)values(?idpedido,?tienda,0,0,0)", Conex);
                    cmdVa.Parameters.Add("?idpedido", MySqlDbType.VarChar).Value = idpedido;
                    cmdVa.Parameters.Add("?tienda", MySqlDbType.VarChar).Value = "VA";
                    cmdVa.ExecuteNonQuery();

                    MySqlCommand cmdRe = new MySqlCommand("INSERT INTO rd_pedido_reportes (fk_idpedido,tienda,almacen,piso_venta,reporte)values(?idpedido,?tienda,0,0,0)", Conex);
                    cmdRe.Parameters.Add("?idpedido", MySqlDbType.VarChar).Value = idpedido;
                cmdRe.Parameters.Add("?tienda", MySqlDbType.VarChar).Value = "RE";
                cmdRe.ExecuteNonQuery();

                    MySqlCommand cmdCo = new MySqlCommand("INSERT INTO rd_pedido_reportes (fk_idpedido,tienda,almacen,piso_venta,reporte)values(?idpedido,?tienda,0,0,0)", Conex);
                    cmdCo.Parameters.Add("?idpedido", MySqlDbType.VarChar).Value = idpedido;
                cmdCo.Parameters.Add("?tienda", MySqlDbType.VarChar).Value = "CO";
                cmdCo.ExecuteNonQuery();

                    MySqlCommand cmdVl = new MySqlCommand("INSERT INTO rd_pedido_reportes (fk_idpedido,tienda,almacen,piso_venta,reporte)values(?idpedido,?tienda,0,0,0)", Conex);
                    cmdVl.Parameters.Add("?idpedido", MySqlDbType.VarChar).Value = idpedido;
                cmdVl.Parameters.Add("?tienda", MySqlDbType.VarChar).Value = "VL";
                cmdVl.ExecuteNonQuery();

                    MySqlCommand cmdPm = new MySqlCommand("INSERT INTO rd_pedido_reportes (fk_idpedido,tienda,almacen,piso_venta,reporte)values(?idpedido,?tienda,0,0,0)", Conex);
                    cmdPm.Parameters.Add("?idpedido", MySqlDbType.VarChar).Value = idpedido;
                cmdPm.Parameters.Add("?tienda", MySqlDbType.VarChar).Value = "PM";
                cmdPm.ExecuteNonQuery();




                 Conex.Close();


                MessageBox.Show("Datos gregados con exito");

            }
            catch (Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }

            limpiar();
            this.Close();
        }

        public void actualizaDatos()
        {
            string comando;

            DateTime fecha = dtDia.Value;
            
            try
            {

                comando = "UPDATE rd_pedido SET titulo_pedido=?titulo_pedido,area=?area,link_pedido=?link_pedido,cotiz=?cotiz, nota =?nota,guia=?guia,comprobante_pago=?comprobante_pago,pago_urge=?pago_urge,tipo_pago=?tipo_pago,forma_pago=?forma_pago,observaciones=?observaciones,bo=?bo,va=?va,re=?re,vl=?vl,co=?co,pm=?pm WHERE id_pedido='" + tbIdPedido.Text + "'";




                MySqlCommand cmd = new MySqlCommand(comando, Conex);
                cmd.Parameters.Add("?titulo_pedido", MySqlDbType.VarChar).Value = tbPedido.Text.ToUpper(); ;
                
                cmd.Parameters.Add("?area", MySqlDbType.VarChar).Value = tbArea.Text;
                
                cmd.Parameters.Add("?link_pedido", MySqlDbType.VarChar).Value = tbLink.Text;
                
                cmd.Parameters.Add("?cotiz", MySqlDbType.VarChar).Value = tbCotiz.Text;
             

                bool x = tbGuia.Text.Contains("192.168.");
                bool y = tbNota.Text.Contains("192.168.");
                bool z = tbComPago.Text.Contains("192.168.");

                if (tbGuia.Text != "")
                {
                    if (x)
                    {
                        cmd.Parameters.Add("?guia", MySqlDbType.VarChar).Value = tbGuia.Text;

                    }
                    else
                    {
                        cmd.Parameters.Add("?guia", MySqlDbType.VarChar).Value = guardaarchivos(tbGuia.Text, guia, 1, tbIdPedido.Text);
                    }
                }
                else
                {
                    cmd.Parameters.Add("?guia", MySqlDbType.VarChar).Value = "";
                }

                if (tbNota.Text != "")
                {

                    if (y)
                    {
                        cmd.Parameters.Add("?nota", MySqlDbType.VarChar).Value = tbNota.Text;

                    }
                    else
                    {
                        cmd.Parameters.Add("?nota", MySqlDbType.VarChar).Value = guardaarchivos(tbNota.Text, nota, 2, tbIdPedido.Text);
                    }
                }
                else
                {
                    cmd.Parameters.Add("?nota", MySqlDbType.VarChar).Value = "";
                }


                if (tbComPago.Text != "")
                {


                    if (z)
                    {
                        cmd.Parameters.Add("?comprobante_pago", MySqlDbType.VarChar).Value = tbComPago.Text;

                    }
                    else
                    {
                        cmd.Parameters.Add("?comprobante_pago", MySqlDbType.VarChar).Value = guardaarchivos(tbComPago.Text, com_pago, 3, tbIdPedido.Text);
                    }
                }
                else
                {
                    cmd.Parameters.Add("?comprobante_pago", MySqlDbType.VarChar).Value = "";
                }

                
                cmd.Parameters.Add("?tipo_pago", MySqlDbType.VarChar).Value = cbTipoPago.Text ;
                cmd.Parameters.Add("?forma_pago", MySqlDbType.VarChar).Value = cbFormaPago.Text ;
                cmd.Parameters.Add("?observaciones", MySqlDbType.VarChar).Value = tbObservaciones.Text.ToUpper(); ;

                if (cBoxUrge.Checked)
                {
                    cmd.Parameters.Add("?pago_urge", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?pago_urge", MySqlDbType.VarChar).Value = 0;

                }



                if (cBoxBo.Checked)
                {
                    cmd.Parameters.Add("?bo", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?bo", MySqlDbType.VarChar).Value = 0;

                }

              
                if (cBoxVa.Checked)
                {
                    cmd.Parameters.Add("?va", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?va", MySqlDbType.VarChar).Value = 0;

                }

                if (cBoxRe.Checked)
                {
                    cmd.Parameters.Add("?re", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?re", MySqlDbType.VarChar).Value = 0;

                }
                if (cBoxVl.Checked)
                {
                    cmd.Parameters.Add("?vl", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?vl", MySqlDbType.VarChar).Value = 0;

                }


                if (cBoxCo.Checked)
                {
                    cmd.Parameters.Add("?co", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?co", MySqlDbType.VarChar).Value = 0;

                }


                if (cBoxPm.Checked)
                {
                    cmd.Parameters.Add("?pm", MySqlDbType.VarChar).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("?pm", MySqlDbType.VarChar).Value = 0;

                }



                cmd.ExecuteNonQuery();


            MySqlCommand cmdHistorial = new MySqlCommand("INSERT INTO rd_pedido_historial (id_pedido,movimiento,estado1,estado2,fecha,usuario) values(?id_pedido,?movimiento,?estado1,?estado2,?fecha,?usuario)", Conex);
            cmdHistorial.Parameters.Add("?id_pedido", MySqlDbType.VarChar).Value = tbIdPedido.Text;
            cmdHistorial.Parameters.Add("?movimiento", MySqlDbType.VarChar).Value = "MODIFICACION";
            cmdHistorial.Parameters.Add("?estado1", MySqlDbType.VarChar).Value = estado;
            cmdHistorial.Parameters.Add("?estado2", MySqlDbType.VarChar).Value = "";
            cmdHistorial.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
            cmdHistorial.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = UsuarioMyB;
            cmdHistorial.ExecuteNonQuery();


                Conex.Close();
            MessageBox.Show("Datos gregados con exito");

             }
            catch (Exception EX)
            {
                MessageBox.Show("Error" + EX.Message);
            }

    limpiar();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbIdPedido.Text == "")
            {
               
                guardaDatos();
                Conex.Close();
            }
            else
            {
               
                actualizaDatos();
                Conex.Close();
            }
        }
        public void limpiar()
        {
            tbIdPedido.Text = "";
            tbPedido.Text = "";
            tbArea.Text = "";
            cbProveedor.Text = "";
            tbLink.Text = "";
            tbCotiz.Text = "";

            cBoxVa.Enabled = true;
            cBoxRe.Enabled = true;
            cBoxCo.Enabled = true;
            cBoxVl.Enabled = true;
            cBoxPm.Enabled = true;
            cBoxUrge.Enabled = true;

            tbGuia.Text = "";
            tbNota.Text = "";
            tbComPago.Text = "";
            //tbTipoPago.Text = "";
            //tbFormaPago.Text = "";
            tbObservaciones.Text = "";


        }

        private void tbLink_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog open = new OpenFileDialog();



                open.Filter = "IMAGE FILE | *.jpg|PDF FILE | *.pdf";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    tbGuia.Text = open.FileName;
                }
                guia = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1);

            }
            catch (Exception ed)
            {
                MessageBox.Show("Error" + ed.Message);
            }

        }


        public string guardaarchivos(string origen, string archivo, int x, string idpedido)
        {
            

            string nuevonombre = "";

            string carpeta = tbIdProv.Text;

            string pdf = "";

            string fileName;
            string servidor;

            string fullPath;

#pragma warning disable CS0168 // La variable 'sourcePath' se ha declarado pero nunca se usa
            string sourcePath;
#pragma warning restore CS0168 // La variable 'sourcePath' se ha declarado pero nunca se usa
            string targetPath;

            string sourceFile;
            string destFile;

            servidor = BDConexicon.optieneIp();
            targetPath = "\\\\"+servidor+"\\doc\\" + carpeta;
            nuevonombre = idpedido;

            if (!Directory.Exists(targetPath))
            {

                DirectoryInfo di = Directory.CreateDirectory(targetPath);
            }

            bool a = archivo.Contains(".jpg");
            bool b = archivo.Contains(".pdf");

            if (x == 1)
            {
                nuevonombre = nuevonombre + "-GUIA-" + carpeta + ".pdf";
            }
            else if (x == 2)
            {
                nuevonombre = nuevonombre + "-NOTA-" + carpeta + ".pdf";
            }
            else if (x == 3)
            {
                nuevonombre = nuevonombre + "-COMPAGO-" + carpeta + ".pdf";
            }


            if (a)
            {
                pdf = "ManejoPDF\\" + nuevonombre;
                ConvertJPG2PDF(@origen, pdf);

                fileName = nuevonombre;
                //fileName2 = "p.pdf";
                fullPath = Path.GetFullPath(@"ManejoPDF");


                sourceFile = Path.Combine(fullPath, fileName);
                destFile = Path.Combine(targetPath, fileName);

                File.Copy(sourceFile, destFile, true);
                File.SetAttributes(destFile, FileAttributes.Normal);
            }
            if (b)
            {

                fullPath = Path.GetDirectoryName(origen);
                sourceFile = Path.Combine(fullPath, archivo);
                destFile = Path.Combine(targetPath, nuevonombre);

                File.Copy(sourceFile, destFile, true);
                File.SetAttributes(destFile, FileAttributes.Normal);
            }
    

            return targetPath + "\\" + nuevonombre;

            

        }


        private void button5_Click(object sender, EventArgs e)
        {
            cbProveedor.SelectedIndex = Convert.ToInt32(tbArea.Text.ToString());
        }

       
        void ConvertJPG2PDF(string jpgfile, string pdf)
        {
            var document = new Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);

            using (var stream = new FileStream(pdf, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                using (var imageStream = new FileStream(jpgfile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = Image.GetInstance(imageStream);
                    if (image.Height > iTextSharp.text.PageSize.A4.Height - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    else if (image.Width > iTextSharp.text.PageSize.A4.Width - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                    document.Add(image);
                }

                document.Close();
            }
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbIdPedido.Text == "")
            {
                tbIdProv.Text = cbProveedor.SelectedValue.ToString();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog open = new OpenFileDialog();



                open.Filter = "IMAGE FILE | *.jpg|PDF FILE | *.pdf";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    tbGuia.Text = open.FileName;
                }
                guia = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1);

            }
            catch (Exception ed)
            {
                MessageBox.Show("Error" + ed.Message);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (tbArea.Text == "")
            {
                tbArea.Text = cbLinea.Text;
            }
            else
            {
                tbArea.Text = tbArea.Text + " - " + cbLinea.Text;
            }
        }

        private void button5_Click_2(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start(tbGuia.Text);
            }
            catch(Exception er)
            {
                MessageBox.Show("Error al abrir: " + er.Message);
            }
            
            //try
            //{


            //    System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //    proc.EnableRaisingEvents = false;
            //    proc.StartInfo.FileName = "cmd";
            //    proc.StartInfo.RedirectStandardInput = true;
            //    proc.StartInfo.RedirectStandardOutput = true;
            //    proc.StartInfo.CreateNoWindow = true;
            //    proc.StartInfo.UseShellExecute = false;
            //    proc.Start();
            //    proc.StandardInput.WriteLine(@tbGuia.Text);
            //    proc.StandardInput.Flush();
            //    proc.StandardInput.Close();
            //    // MessageBox.Show("Se detuvo MySql");
            //    proc.Close();




            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

        }

        public void actualizaEstado()
        {
            try
            {


                DateTime fecha = dtDia.Value;

                MySqlCommand cmd = new MySqlCommand("UPDATE rd_pedido  SET estatus='" + cbEstadoPedido.Text + "'  WHERE  id_pedido='" + tbIdPedido.Text + "'", Conex);
                cmd.ExecuteNonQuery();


                MySqlCommand cmdHistorial = new MySqlCommand("INSERT INTO rd_pedido_historial (id_pedido,movimiento,estado1,estado2,fecha,usuario) values(?id_pedido,?movimiento,?estado1,?estado2,?fecha,?usuario)", Conex);
                cmdHistorial.Parameters.Add("?id_pedido", MySqlDbType.VarChar).Value = tbIdPedido.Text;
                cmdHistorial.Parameters.Add("?movimiento", MySqlDbType.VarChar).Value = "CAMBIA-ESTADO";
                cmdHistorial.Parameters.Add("?estado1", MySqlDbType.VarChar).Value = estado;
                cmdHistorial.Parameters.Add("?estado2", MySqlDbType.VarChar).Value = cbEstadoPedido.Text;
                cmdHistorial.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = fecha.ToString("yyyy-MM-dd");
                cmdHistorial.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = UsuarioMyB;
                cmdHistorial.ExecuteNonQuery();





                Conex.Close();
                //MessageBox.Show("Estado Actualizado");
            }
            catch(Exception er)
            {
                MessageBox.Show("Error al Altualizar: " + er.Message);
            }
        }

        private void cbProveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tbIdPedido.Text == "")
            {
                tbIdProv.Text = cbProveedor.SelectedValue.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbIdPedido.Text == "")
            {
                Conex.Open();
                guardaDatos();
                Conex.Close();
            }
            else
            {
                Conex.Open();
                actualizaDatos();
                Conex.Close();
            }
        }

        private void Pedido_Click(object sender, EventArgs e)
        {
            
        }

        private void link_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enlace No valido :" + ex.Message);
            }
        }

        private void tbProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLink_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            bool actualizar=false;

            if (cbEstadoPedido.Text == "CANCELADO")
            {
               

                    

                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea cancelar el Pedido", "Cancelar Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    actualizar = true;

                }



            }


            if (cbEstadoPedido.Text == "AUTORIZADO")
            {
                if (estado == "CREADO")
                {

                    actualizar = true;
                }
                else
                {
                    MessageBox.Show("Pedido no ha sido AUTORIZADO");
                }

            }


            if (cbEstadoPedido.Text== "ENVIADO-PROVEEDOR")
            {
                if (estado == "AUTORIZADO")
                {

                    actualizar = true;
                }
                else
                {
                    MessageBox.Show("Pedido no ha sido AUTORIZADO");
                }

            }

            if (cbEstadoPedido.Text == "TRANSPORTE MEXICO")
            {
                if (estado == "ENVIADO-PROVEEDOR")
                {

                    actualizar = true;
                }
                else
                {
                    MessageBox.Show("Pedido no se ha ENVIADO-PROVEEDOR");
                }

            }

            if (cbEstadoPedido.Text == "CEDIS")
            {
                if (estado == "TRANSPORTE MEXICO")
                {

                    actualizar = true;
                }
                else
                {
                    MessageBox.Show("Pedido no esta en TRANSPORTE MEXICO");
                }

            }

            if (cbEstadoPedido.Text == "REPARTIDO-TIENDA")
            {
                if (estado == "CEDIS")
                {

                    actualizar = true;
                }
                else
                {
                    MessageBox.Show("Pedido no esta en CEDIS");
                }

            }

            if (cbEstadoPedido.Text == "CARGADO-SISTEMA")
            {
                if (estado == "TRANSPORTE MEXICO" || estado == "REPARTIDO-TIENDA")
                {

                    actualizar = true;
                }
                else
                {
                    MessageBox.Show("Pedido no esta en TRANSPORTE MEXICO Ó REPARTIDO-TIENDA");
                }

            }

            if (cbEstadoPedido.Text == "ORDEN TERMINADA")
            {
                if (estado == "CARGADO-SISTEMA")
                {

                    actualizar = true;
                }
                else
                {
                    MessageBox.Show("Pedido no esta CARGADO-SISTEMA");
                }

            }


            if (actualizar)
            {
                MessageBox.Show("Estado actualizado");
                Conex.Open();
                actualizaEstado();
                Conex.Close();
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog open = new OpenFileDialog();



                open.Filter = "IMAGE FILE | *.jpg|PDF FILE | *.pdf";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    tbNota.Text = open.FileName;
                }
                nota = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1);
                
            }
            catch (Exception ed)
            {
                MessageBox.Show("Error" + ed.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog open = new OpenFileDialog();



                open.Filter = "IMAGE FILE | *.jpg|PDF FILE | *.pdf";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    tbComPago.Text = open.FileName;
                }
                com_pago = open.FileName.Substring(open.FileName.LastIndexOf("\\") + 1);

            }
            catch (Exception ed)
            {
                MessageBox.Show("Error" + ed.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            try
            {
                System.Diagnostics.Process.Start(tbNota.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al abrir: " + er.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(tbComPago.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al abrir: " + er.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbArea.Text == "")
            {
                tbArea.Text = cbLinea.Text;
            }
            else
            {
                tbArea.Text = tbArea.Text + " - " + cbLinea.Text;
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enlace No valido :" + ex.Message);
            }
        }
    }
}
