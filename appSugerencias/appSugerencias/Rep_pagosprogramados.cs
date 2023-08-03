using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class Rep_pagosprogramados : Form
    {
        public Rep_pagosprogramados(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();

        }

        DataTable dt = new DataTable();
        string usuario = "";

        public string NombreProveedor(string proveedor)
        {
            string nombre = "";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT NOMBRE FROM PROVEED WHERE PROVEEDOR='"+proveedor+"'";

            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["NOMBRE"].ToString();
            }
            dr.Close();
            conexion.Close();
            return nombre;
        }

        public string NombreProveedorServ(string proveedor)
        {
            string nombre = "";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT NOMBRE FROM rd_proveedor_servicios WHERE idprov='" + proveedor + "'";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["NOMBRE"].ToString();
            }
            dr.Close();
            conexion.Close();
            return nombre;
        }


        public void PintarFilaBusqueda(int estado,int pagoParcial,int pagoAnticipado,int indicador)
        {

        }
        private void BT_aceptar_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            int numFila = 0;
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string nombre = "";

            string todos = "SELECT idreg,fecha_programada,fecha_venc,sucursal,proveedor,nombre_prov,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,anticipado,patron,importe,iva,concepto,factura,usuario,estado,indicador,pago_parcial,pago_anticipado FROM rd_programar_pago  WHERE fecha_programada between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd")+ "' order by idreg, fecha_programada";
           
            string efectivo = "SELECT idreg,fecha_programada,fecha_venc,sucursal,proveedor,nombre_prov,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,anticipado,patron,importe,iva,concepto,factura,usuario,estado,indicador,pago_parcial,pago_anticipado FROM rd_programar_pago  WHERE fecha_programada between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND tipo_pago='EFECTIVO' order by idreg, fecha_programada";

            string deposito = "SELECT idreg,fecha_programada,fecha_venc,sucursal,proveedor,nombre_prov,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,anticipado,patron,importe,iva,concepto,factura,usuario,estado,indicador,pago_parcial,pago_anticipado FROM rd_programar_pago  WHERE fecha_programada between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND tipo_pago='DEP/EFE' order by idreg, fecha_programada";

            string spei  = "SELECT idreg,fecha_programada,fecha_venc,sucursal,proveedor,nombre_prov,rfc,compra,enlace,banco,cuenta,clientebancario,tipo_pago,anticipado,patron,importe,iva,concepto,factura,usuario,estado,indicador,pago_parcial,pago_anticipado FROM rd_programar_pago  WHERE fecha_programada between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND tipo_pago='SPEI' order by idreg, fecha_programada";
            if (RB_todos.Checked==true)
            {
                MySqlCommand cmd = new MySqlCommand(todos, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkParcial = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkAnticipado = new DataGridViewCheckBoxCell();


                while (dr.Read())
                {
                    int estado = Convert.ToInt32(dr["estado"].ToString());
                    int pagoParcial = Convert.ToInt32(dr["pago_parcial"].ToString());
                    int pagoAnticipado = Convert.ToInt32(dr["pago_anticipado"].ToString());
                    int indicador = Convert.ToInt32(dr["indicador"].ToString());
                    //string proveedor = dr["proveedor"].ToString();
                    nombre = dr["nombre_prov"].ToString();

                    if (indicador == 0)
                    {
                        //nombre = NombreProveedor(proveedor);
                        //nombre = "";
                    }

                    if (indicador == 1)
                    {
                       //nombre = NombreProveedorServ(proveedor);
                    }

                   
                    if (estado == 0)
                    {
                        check.ThreeState = false;
                    }

                    if (estado == 1)
                    {
                        check.ThreeState = true;
                    }

                    if (pagoParcial == 0)
                    {
                        checkParcial.ThreeState = false;
                    }

                    if (pagoParcial == 1)
                    {
                        checkParcial.ThreeState = true;
                    }

                    if (pagoAnticipado == 0)
                    {
                        checkAnticipado.ThreeState = false;
                    }

                    if (pagoAnticipado == 1)
                    {
                        checkAnticipado.ThreeState = true;
                    }



                    double importe = Convert.ToDouble(dr["importe"].ToString());
                    double iva = Convert.ToDouble(dr["iva"].ToString());

                    
                    DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["fecha_programada"].ToString(), dr["fecha_venc"].ToString(), dr["sucursal"].ToString(), dr["banco"].ToString(), String.Format("{0:0.##}", importe.ToString("C")), String.Format("{0:0.##}", iva.ToString("C")), dr["clientebancario"].ToString(), dr["cuenta"].ToString(), dr["patron"].ToString(), nombre, dr["rfc"].ToString(), dr["compra"].ToString(), dr["concepto"].ToString(), dr["enlace"].ToString(), dr["factura"].ToString(), dr["tipo_pago"].ToString(), dr["anticipado"].ToString(), check.ThreeState, checkParcial.ThreeState,checkAnticipado.ThreeState);

                    numFila = DG_tabla.Rows.Count-1;
                    if (check.ThreeState == true && checkParcial.ThreeState == false && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.Yellow;
                    }else if(check.ThreeState == false && checkParcial.ThreeState == true && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.Green;
                    }else if(check.ThreeState == false && checkParcial.ThreeState == false && checkAnticipado.ThreeState == true)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.DodgerBlue;
                    }else if (check.ThreeState == false && checkParcial.ThreeState == false && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.White;
                    }
                }

                dr.Close();
            }

            if (RB_efectivo.Checked == true)
            {
                MySqlCommand cmd = new MySqlCommand(efectivo, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkParcial = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkAnticipado = new DataGridViewCheckBoxCell();

                while (dr.Read())
                {
                    int pagoParcial = Convert.ToInt32(dr["pago_parcial"].ToString());
                    int pagoAnticipado = Convert.ToInt32(dr["pago_anticipado"].ToString());
                    int estado = Convert.ToInt32(dr["estado"].ToString());
                    int indicador = Convert.ToInt32(dr["indicador"].ToString());
                    string proveedor = dr["proveedor"].ToString();
                    nombre = dr["nombre_prov"].ToString();
                    //if (indicador == 0)
                    //{
                    //    nombre = NombreProveedor(proveedor);
                    //}

                    //if (indicador == 1)
                    //{
                    //    nombre = NombreProveedorServ(proveedor);
                    //}

                    if (estado == 0)
                    {
                        check.ThreeState = false;
                    }

                    if (estado == 1)
                    {
                        check.ThreeState = true;
                    }

                    if (pagoParcial == 0)
                    {
                        checkParcial.ThreeState = false;
                    }

                    if (pagoParcial == 1)
                    {
                        checkParcial.ThreeState = true;
                    }


                    if (pagoAnticipado == 0)
                    {
                        checkAnticipado.ThreeState = false;
                    }

                    if (pagoAnticipado == 1)
                    {
                        checkAnticipado.ThreeState = true;
                    }


                    double importe = Convert.ToDouble(dr["importe"].ToString());
                    double iva = Convert.ToDouble(dr["iva"].ToString());
                    DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["fecha_programada"].ToString(), dr["fecha_venc"].ToString(), dr["sucursal"].ToString(), dr["banco"].ToString(), String.Format("{0:0.##}", importe.ToString("C")), String.Format("{0:0.##}", iva.ToString("C")), dr["clientebancario"].ToString(), dr["cuenta"].ToString(), dr["patron"].ToString(), nombre, dr["rfc"].ToString(), dr["compra"].ToString(), dr["concepto"].ToString(), dr["enlace"].ToString(), dr["factura"].ToString(), dr["tipo_pago"].ToString(), dr["anticipado"].ToString(), check.ThreeState, checkParcial.ThreeState, checkAnticipado.ThreeState);

                    numFila = DG_tabla.Rows.Count - 1;
                    if (check.ThreeState == true && checkParcial.ThreeState == false && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == true && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == false && checkAnticipado.ThreeState == true)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.DodgerBlue;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == false && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.White;
                    }
                }

                dr.Close();
            }

            if (RB_spei.Checked == true)
            {
                MySqlCommand cmd = new MySqlCommand(spei, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkParcial = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkAnticipado = new DataGridViewCheckBoxCell();
                while (dr.Read())
                {
                    int pagoParcial = Convert.ToInt32(dr["pago_parcial"].ToString());
                    int pagoAnticipado = Convert.ToInt32(dr["pago_anticipado"].ToString());
                    int estado = Convert.ToInt32(dr["estado"].ToString());
                    int indicador = Convert.ToInt32(dr["indicador"].ToString());
                    string proveedor = dr["proveedor"].ToString();
                    nombre = dr["nombre_prov"].ToString();
                    //if (indicador == 0)
                    //{
                    //    nombre = NombreProveedor(proveedor);
                    //}

                    //if (indicador == 1)
                    //{
                    //    nombre = NombreProveedorServ(proveedor);
                    //}

                    if (estado == 0)
                    {
                        check.ThreeState = false;
                    }

                    if (estado == 1)
                    {
                        check.ThreeState = true;
                    }

                    if (pagoParcial == 0)
                    {
                        checkParcial.ThreeState = false;
                    }

                    if (pagoParcial == 1)
                    {
                        checkParcial.ThreeState = true;
                    }

                    if (pagoAnticipado == 0)
                    {
                        checkAnticipado.ThreeState = false;
                    }

                    if (pagoAnticipado == 1)
                    {
                        checkAnticipado.ThreeState = true;
                    }


                    double importe = Convert.ToDouble(dr["importe"].ToString());
                    double iva = Convert.ToDouble(dr["iva"].ToString());
                    DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["fecha_programada"].ToString(), dr["fecha_venc"].ToString(), dr["sucursal"].ToString(), dr["banco"].ToString(), String.Format("{0:0.##}", importe.ToString("C")), String.Format("{0:0.##}", iva.ToString("C")), dr["clientebancario"].ToString(), dr["cuenta"].ToString(), dr["patron"].ToString(), nombre, dr["rfc"].ToString(), dr["compra"].ToString(), dr["concepto"].ToString(), dr["enlace"].ToString(), dr["factura"].ToString(), dr["tipo_pago"].ToString(), dr["anticipado"].ToString(), check.ThreeState,checkParcial.ThreeState, checkAnticipado.ThreeState);
                    numFila = DG_tabla.Rows.Count - 1;
                    if (check.ThreeState == true && checkParcial.ThreeState == false && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == true && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == false && checkAnticipado.ThreeState == true)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.DodgerBlue;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == false && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.White;
                    }
                }

                dr.Close();
            }

            if (RB_deposito.Checked == true)
            {
                MySqlCommand cmd = new MySqlCommand(deposito, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkParcial = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkAnticipado = new DataGridViewCheckBoxCell();
                while (dr.Read())
                {
                    int estado = Convert.ToInt32(dr["estado"].ToString());
                    int pagoParcial = Convert.ToInt32(dr["pago_parcial"].ToString());
                    int pagoAnticipado = Convert.ToInt32(dr["pago_anticipado"].ToString());
                    int indicador = Convert.ToInt32(dr["indicador"].ToString());
                    string proveedor = dr["proveedor"].ToString();
                    nombre = dr["nombre_prov"].ToString();
                    //if (indicador == 0)
                    //{
                    //    nombre = NombreProveedor(proveedor);
                    //}

                    //if (indicador == 1)
                    //{
                    //    nombre = NombreProveedorServ(proveedor);
                    //}

                    if (estado == 0)
                    {
                        check.ThreeState = false;
                    }

                    if (estado == 1)
                    {
                        check.ThreeState = true;
                    }
                    if (pagoParcial == 0)
                    {
                        checkParcial.ThreeState = false;
                    }

                    if (pagoParcial == 1)
                    {
                        checkParcial.ThreeState = true;
                    }

                    if (pagoAnticipado == 0)
                    {
                        checkAnticipado.ThreeState = false;
                    }

                    if (pagoAnticipado == 1)
                    {
                        checkAnticipado.ThreeState = true;
                    }


                    double importe = Convert.ToDouble(dr["importe"].ToString());
                    double iva = Convert.ToDouble(dr["iva"].ToString());
                    DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["fecha_programada"].ToString(), dr["fecha_venc"].ToString(), dr["sucursal"].ToString(), dr["banco"].ToString(), String.Format("{0:0.##}", importe.ToString("C")), String.Format("{0:0.##}", iva.ToString("C")), dr["clientebancario"].ToString(), dr["cuenta"].ToString(), dr["patron"].ToString(), nombre, dr["rfc"].ToString(), dr["compra"].ToString(), dr["concepto"].ToString(), dr["enlace"].ToString(), dr["factura"].ToString(), dr["tipo_pago"].ToString(), dr["anticipado"].ToString(), check.ThreeState,checkParcial.ThreeState, checkAnticipado.ThreeState);

                    numFila = DG_tabla.Rows.Count - 1;
                    if (check.ThreeState == true && checkParcial.ThreeState == false && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == true && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == false && checkAnticipado.ThreeState == true)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.DodgerBlue;
                    }
                    else if (check.ThreeState == false && checkParcial.ThreeState == false && checkAnticipado.ThreeState == false)
                    {
                        DG_tabla.Rows[numFila].DefaultCellStyle.BackColor = Color.White;
                    }
                }

                dr.Close();
            }

           
            
            conexion.Close();
            //PintarFila();
        }

        

        private void Rep_pagosprogramados_Load(object sender, EventArgs e)
        {
            RB_todos.Checked = true;
            DG_tabla.Columns["FECHA"].Width = 85;
            DG_tabla.Columns["FECHA_VENC"].Width = 85;
            DG_tabla.Columns["IMPORTE"].Width = 105;
            DG_tabla.Columns["SUCURSAL"].Width = 90;
            DG_tabla.Columns["CLIENTE"].Width = 230;
            DG_tabla.Columns["PROVEEDOR"].Width = 230;
            DG_tabla.Columns["CONTRIBUYENTE"].Width = 210;
            DG_tabla.Columns["CUENTA"].Width = 140;
            DG_tabla.Columns["CHECK"].Width = 40;
            DG_tabla.Columns["PAGO_PARCIAL"].Width = 50;
            DG_tabla.Columns["TIPO"].Width = 90;
            DG_tabla.Columns["ENLACE"].Width = 50;
            DG_tabla.Columns["COMPRA"].Width = 60;
            DG_tabla.Columns["IVA"].Width = 50;
            DG_tabla.Columns["RFC"].Width = 115;
            DG_tabla.Columns["CONCEPTO"].Width = 150;
            DG_tabla.Columns["FACTURA"].Width = 100;
            DG_tabla.Columns["PAGO_ANTICIPADO"].Width = 70;

            string area = Empleado.Area(usuario);

            if (area.Equals("SISTEMAS")||area.Equals("ADMON GRAL"))
            {
                DG_tabla.Columns["CHECK"].ReadOnly=false;
                DG_tabla.Columns["PAGO_PARCIAL"].ReadOnly = false;
            }
            else
            {
                DG_tabla.Columns["CHECK"].ReadOnly= true;
                DG_tabla.Columns["PAGO_PARCIAL"].ReadOnly = true;

            }

            dt.Columns.Add("ID",typeof(string));
            dt.Columns.Add("FECHA", typeof(string));
            dt.Columns.Add("FECHA VENCIMIENTO", typeof(string));
            dt.Columns.Add("SUCURSAL", typeof(string));
            dt.Columns.Add("BANCO", typeof(string));
            dt.Columns.Add("IMPORTE", typeof(string));
            dt.Columns.Add("IVA", typeof(string));
            dt.Columns.Add("CLIENTE BANCARIO", typeof(string));
            dt.Columns.Add("CUENTA BANCARIA", typeof(string));
            dt.Columns.Add("CONTRIBUYENTE", typeof(string));
            dt.Columns.Add("PROVEEDOR", typeof(string));
            dt.Columns.Add("RFC", typeof(string));
            dt.Columns.Add("NO COMPRA", typeof(string));
            dt.Columns.Add("CONCEPTO", typeof(string));
            dt.Columns.Add("ENLACE", typeof(string));
            dt.Columns.Add("FACTURA", typeof(string));
            dt.Columns.Add("TIPO PAGO", typeof(string));
            dt.Columns.Add("ANTICIPADO", typeof(int));
            dt.Columns.Add("CHECK", typeof(string));
            dt.Columns.Add("PARCIAL", typeof(string));
            dt.Columns.Add("PAGO ANTICIPADO", typeof(string));

        }

        private void DG_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            bool checkParcial = Convert.ToBoolean(DG_tabla.Rows[e.RowIndex].Cells["PAGO_PARCIAL"].Value);

            if (checkParcial == true)
            {
                string enlace = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["ENLACE"].Value);
                string sucursal = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["SUCURSAL"].Value);
                string compra = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["COMPRA"].Value);
                string importe = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["IMPORTE"].Value);
                string referencia = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells["FACTURA"].Value);

                DataTable pagosParciales = new DataTable();

                MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
                string query = "SELECT IMPORTE, TIPO_DOC, FECHA FROM CUENXPDET WHERE COMPRA='" + compra + "' AND Cargo_ab='A'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(pagosParciales);

                PagosParciales_enlace parcial = new PagosParciales_enlace(enlace, pagosParciales, usuario, importe, referencia, compra, sucursal);
                parcial.Show();
                //try
                //{
                //    Process.Start(enlace);
                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show("ERROR, SOFTMART no reconoce el enlace del recurso al cual quieres acceder "+ex);
                //}
            }
            else
            {
                MessageBox.Show("El pago ya se ha realizado, por lo que no puedes aplicarlo otra vez.");

               
            }


        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            int id = 0;
            bool check = false;
            bool parcial = false;
            bool anticipado = false;
            int estado = 0, estadoParcial = 0,estadoAnticipado=0;


            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
               id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value);
                check = Convert.ToBoolean(DG_tabla.Rows[i].Cells["CHECK"].Value);
                parcial = Convert.ToBoolean(DG_tabla.Rows[i].Cells["PAGO_PARCIAL"].Value);
               anticipado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["PAGO_ANTICIPADO"].Value);
              

                if (check==true)
                {
                    estado = 1;
                }
                else
                {
                    estado = 0;
                }


                if (parcial == true)
                {
                    estadoParcial = 1;
                }
                else
                {
                    estadoParcial = 0;
                }

                if (anticipado == true)
                {
                    estadoAnticipado = 1;
                }
                else
                {
                    estadoAnticipado = 0;
                }


                MySqlCommand cmd = new MySqlCommand("UPDATE rd_programar_pago SET estado="+estado+" WHERE idreg="+id+"",conexion);
                cmd.ExecuteNonQuery();

                MySqlCommand cmd2 = new MySqlCommand("UPDATE rd_programar_pago SET pago_parcial=" + estadoParcial + " WHERE idreg=" + id + "", conexion);
                cmd2.ExecuteNonQuery();

                MySqlCommand cmd3 = new MySqlCommand("UPDATE rd_programar_pago SET pago_anticipado=" + estadoAnticipado + " WHERE idreg=" + id + "", conexion);
                cmd3.ExecuteNonQuery();
            }

            MessageBox.Show("Se ha guardado el estado de los check");
            conexion.Close();
        }

        public void PintarFila()
        {

            bool estado = false;
            bool parcial = false;
            bool anticipado = false;
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                 estado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["CHECK"].Value);
                 parcial= Convert.ToBoolean(DG_tabla.Rows[i].Cells["PAGO_PARCIAL"].Value);
                 anticipado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["PAGO_ANTICIPADO"].Value);

                //if (estado == true)
                //{
                //    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                //}
                //else
                //{
                //    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.White;
                //}

                if (estado == true && parcial==false && anticipado == false)
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if(estado == false && parcial == true && anticipado == false)
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                if (estado == false && parcial == false)
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

                if (estado == false && parcial == false && anticipado == true)
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.DodgerBlue;
                }

                if (estado == true && parcial == true)
                {
                   
                    MessageBox.Show("Solo debes seleccionar una casilla");
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.White;

                }

                if (estado == true && anticipado == true)
                {

                    MessageBox.Show("Solo debes seleccionar una casilla");
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.White;

                }

                if (anticipado == true && parcial == true)
                {

                    MessageBox.Show("Solo debes seleccionar una casilla");
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.White;

                }

            }
        }

        private void DG_tabla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            PintarFila();
        }

        private void DG_tabla_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RB_prov_CheckedChanged(object sender, EventArgs e)
        {
            CB_filtro_prov.Items.Clear();
            string query = "SELECT nombre FROM proveed ORDER BY nombre";

            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_filtro_prov.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer nombre de proveedores para filtro: "+ex);
            }
           
        }

        private void RB_prov_serv_CheckedChanged(object sender, EventArgs e)
        {
            CB_filtro_prov.Items.Clear();
            string query = "SELECT nombre FROM rd_proveedor_servicios ORDER BY nombre";

            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_filtro_prov.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer nombre de proveedores para filtro: " + ex);
            }
        }





        private void BT_buscar_prov_Click(object sender, EventArgs e)
        {
        
            dt.Rows.Clear();
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                dt.Rows.Add(DG_tabla.Rows[i].Cells[0].Value, DG_tabla.Rows[i].Cells[1].Value, DG_tabla.Rows[i].Cells[2].Value, DG_tabla.Rows[i].Cells[3].Value, DG_tabla.Rows[i].Cells[4].Value, DG_tabla.Rows[i].Cells[5].Value, DG_tabla.Rows[i].Cells[6].Value, DG_tabla.Rows[i].Cells[7].Value, DG_tabla.Rows[i].Cells[8].Value, DG_tabla.Rows[i].Cells[9].Value, DG_tabla.Rows[i].Cells[10].Value, DG_tabla.Rows[i].Cells[11].Value, DG_tabla.Rows[i].Cells[12].Value, DG_tabla.Rows[i].Cells[13].Value, DG_tabla.Rows[i].Cells[14].Value, DG_tabla.Rows[i].Cells[15].Value, DG_tabla.Rows[i].Cells[16].Value, DG_tabla.Rows[i].Cells[17].Value, DG_tabla.Rows[i].Cells[18].Value, DG_tabla.Rows[i].Cells[19].Value, DG_tabla.Rows[i].Cells[20].Value);
            }
            
            DG_tabla.Rows.Clear();
            DataView view = null;
            string proveedor = CB_filtro_prov.SelectedItem.ToString();
            view = dt.DefaultView;
            view.RowFilter = string.Empty;
            view.RowFilter = "PROVEEDOR='" + proveedor + "'";
            //view.RowFilter = "PROVEEDOR='" + proveedor + "' AND ANTICIPADO =1";
            //DG_tabla.DataSource = view;

            DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
            DataGridViewCheckBoxCell checkParcial = new DataGridViewCheckBoxCell();
            DataGridViewCheckBoxCell checkAnticipado = new DataGridViewCheckBoxCell();
            bool total = false, parcial = false, anticipado = false;

            foreach (DataRowView row in view)
            {
                total = Convert.ToBoolean(row["CHECK"]);
                parcial = Convert.ToBoolean(row["PARCIAL"]);
                anticipado = Convert.ToBoolean(row["PAGO ANTICIPADO"]);

                if (total == true)
                {
                    check.ThreeState = true;
                }

                if (parcial == true)
                {
                    checkParcial.ThreeState = true;
                }

                if (anticipado == true)
                {
                    checkAnticipado.ThreeState = true;
                }

                DG_tabla.Rows.Add(row["ID"], row["FECHA"], row["FECHA VENCIMIENTO"], row["SUCURSAL"], row["BANCO"], row["IMPORTE"], row["IVA"], row["CLIENTE BANCARIO"], row["CUENTA BANCARIA"], row["CONTRIBUYENTE"], row["PROVEEDOR"], row["RFC"], row["NO COMPRA"], row["CONCEPTO"], row["ENLACE"], row["FACTURA"], row["TIPO PAGO"], row["ANTICIPADO"], check.ThreeState, checkParcial.ThreeState, checkAnticipado.ThreeState);
                check.ThreeState = false; checkParcial.ThreeState = false; checkAnticipado.ThreeState = false;
            }

            PintarFila();
        }

        private void BT_guardar_SPEI_Click(object sender, EventArgs e)
        {

        }

        private void Rep_pagosprogramados_KeyPress(object sender, KeyPressEventArgs e)
        {



           
        }

        private void CB_filtro_prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dt.Rows.Clear();
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    dt.Rows.Add(DG_tabla.Rows[i].Cells[0].Value, DG_tabla.Rows[i].Cells[1].Value, DG_tabla.Rows[i].Cells[2].Value, DG_tabla.Rows[i].Cells[3].Value, DG_tabla.Rows[i].Cells[4].Value, DG_tabla.Rows[i].Cells[5].Value, DG_tabla.Rows[i].Cells[6].Value, DG_tabla.Rows[i].Cells[7].Value, DG_tabla.Rows[i].Cells[8].Value, DG_tabla.Rows[i].Cells[9].Value, DG_tabla.Rows[i].Cells[10].Value, DG_tabla.Rows[i].Cells[11].Value, DG_tabla.Rows[i].Cells[12].Value, DG_tabla.Rows[i].Cells[13].Value, DG_tabla.Rows[i].Cells[14].Value, DG_tabla.Rows[i].Cells[15].Value, DG_tabla.Rows[i].Cells[16].Value, DG_tabla.Rows[i].Cells[17].Value, DG_tabla.Rows[i].Cells[18].Value, DG_tabla.Rows[i].Cells[19].Value, DG_tabla.Rows[i].Cells[20].Value);
                }

                DG_tabla.Rows.Clear();
                DataView view = null;
                string proveedor = CB_filtro_prov.SelectedItem.ToString();
                view = dt.DefaultView;
                view.RowFilter = string.Empty;
                view.RowFilter = "PROVEEDOR='" + proveedor + "'";
                //view.RowFilter = "PROVEEDOR='" + proveedor + "' AND ANTICIPADO =1";
                //DG_tabla.DataSource = view;

                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkParcial = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell checkAnticipado = new DataGridViewCheckBoxCell();
                bool total = false, parcial = false, anticipado = false;

                foreach (DataRowView row in view)
                {
                    total = Convert.ToBoolean(row["CHECK"]);
                    parcial = Convert.ToBoolean(row["PARCIAL"]);
                    anticipado = Convert.ToBoolean(row["PAGO ANTICIPADO"]);

                    if (total == true)
                    {
                        check.ThreeState = true;
                    }

                    if (parcial == true)
                    {
                        checkParcial.ThreeState = true;
                    }

                    if (anticipado == true)
                    {
                        checkAnticipado.ThreeState = true;
                    }

                    DG_tabla.Rows.Add(row["ID"], row["FECHA"], row["FECHA VENCIMIENTO"], row["SUCURSAL"], row["BANCO"], row["IMPORTE"], row["IVA"], row["CLIENTE BANCARIO"], row["CUENTA BANCARIA"], row["CONTRIBUYENTE"], row["PROVEEDOR"], row["RFC"], row["NO COMPRA"], row["CONCEPTO"], row["ENLACE"], row["FACTURA"], row["TIPO PAGO"], row["ANTICIPADO"], check.ThreeState, checkParcial.ThreeState, checkAnticipado.ThreeState);
                    check.ThreeState = false; checkParcial.ThreeState = false; checkAnticipado.ThreeState = false;
                }

                PintarFila();
            }

        }
    }
}
