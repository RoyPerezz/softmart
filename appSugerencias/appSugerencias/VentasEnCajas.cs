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
    public partial class VentasEnCajas : Form
    {


        //VARIABLES GLOBALES
        ArrayList estaciones = new ArrayList();
        DataTable ventas = new DataTable();
        string usuario = "";
        DataTable inTarjetas = null;
        DataTable egTarjetas = null;
        public VentasEnCajas(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
           
        }

       
        //OBTIENE LAS ESTACIONES QUE SE USAN EN LA SUCURSAL EN LA FECHA SELECCIONADA
        public void ObtenerEstaciones()
        {

            try
            {
                DateTime fecha = DT_fecha.Value;
                MySqlConnection con = ElegirSucursal();
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT ESTACION FROM FLUJO WHERE FECHA='" + fecha.ToString("yyyy-MM-d") + "'", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    estaciones.Add(dr["ESTACION"].ToString());
                }
                dr.Close();
                estaciones.Remove("ESTACION01");
                estaciones.Remove("");
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer las estaciones de trabajo de la tienda: "+ex);
            }

        }

        //METODO DE APORYO PARA CONSULTAR EL RESPALDO
        public string MesRespaldo(int mes)
        {
            //RETORNA LA ABREVIACION DEL MES QUE SE LE PASA COMO PARÁMETRO
            string mesRespaldo = "";

            if (mes == 1)
            {
                mesRespaldo = "ENE";
            }
            if (mes == 2)
            {
                mesRespaldo = "FEB";
            }
            if (mes == 3)
            {
                mesRespaldo = "MAR";
            }
            if (mes == 4)
            {
                mesRespaldo = "ABR";
            }
            if (mes == 5)
            {
                mesRespaldo = "MAY";
            }
            if (mes == 6)
            {
                mesRespaldo = "JUN";
            }
            if (mes == 7)
            {
                mesRespaldo = "JUL";
            }
            if (mes == 8)
            {
                mesRespaldo = "AGO";
            }
            if (mes == 9)
            {
                mesRespaldo = "SEP";
            }
            if (mes == 10)
            {
                mesRespaldo = "OCT";
            }
            if (mes == 11)
            {
                mesRespaldo = "NOV";
            }
            if (mes == 12)
            {
                mesRespaldo = "DIC";
            }
            return mesRespaldo;
        }

        //ELIGE A QUE SUCURSAL CONECTARSE DE ACUERDO AL NOMBRE DE SUCURSAL SELECCIONADO EN EL COMBOBOX CB_sucursal
        public MySqlConnection ElegirSucursal()
        {

            MySqlConnection con = null;
            try
            {
                string tienda = CB_sucursal.SelectedItem.ToString();
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;
                //DateTime fecha = DT_fecha.Value;




                if (CHK_respaldo.Checked == true)
                {
                    string mesRespaldo = MesRespaldo(mes);
                    if (tienda.Equals("VALLARTA"))
                    {
                        con = BDConexicon.RespaldoVA(mesRespaldo, año);
                    }
                    if (tienda.Equals("RENA"))
                    {
                        con = BDConexicon.RespaldoRE(mesRespaldo, año);
                    }

                    if (tienda.Equals("COLOSO"))
                    {
                        con = BDConexicon.RespaldoCO(mesRespaldo, año);
                    }

                    if (tienda.Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.RespaldoVE(mesRespaldo, año);
                    }

                    if (tienda.Equals("PREGOT"))
                    {
                        con = BDConexicon.RespaldoPRE(mesRespaldo, año);
                    }

                }
                else
                {
                    if (tienda.Equals("BODEGA"))
                    {
                        con = BDConexicon.BodegaOpen();
                    }
                    if (tienda.Equals("VALLARTA"))
                    {
                        con = BDConexicon.VallartaOpen();
                    }
                    if (tienda.Equals("RENA"))
                    {
                        con = BDConexicon.RenaOpen();
                    }

                    if (tienda.Equals("COLOSO"))
                    {
                        con = BDConexicon.ColosoOpen();
                    }

                    if (tienda.Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.VelazquezOpen();
                    }

                    if (tienda.Equals("PREGOT"))
                    {
                        con = BDConexicon.Papeleria1Open();
                    }

                    if (tienda.Equals("VITRINA VA"))
                    {
                        con = BDConexicon.V_vallarta();
                    }

                    if (tienda.Equals("VITRINA RE"))
                    {
                        con = BDConexicon.V_rena();
                    }

                    if (tienda.Equals("VITRINA VE"))
                    {
                        con = BDConexicon.V_velazquez();
                    }

                    if (tienda.Equals("VITRINA CO"))
                    {
                        con = BDConexicon.V_coloso();
                    }

                    if (tienda.Equals("VITRINA PRE"))
                    {
                        con = BDConexicon.V_pregot();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Debes elegir una sucursal ERROR: " + ex);
            }

            return con;


        }

        //OBTIENE EL NOMBRE DE LA SUCURSAL
        public string Sucursal()
        {

            string nombre = "";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT EMPRESA FROM ECONFIG", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["EMPRESA"].ToString();
            }
            dr.Close();
            con.Close();

            return nombre;

        }


        //TRAE TODA LA INFORMACIÓN DE LAS VENTAS DE CADA CAJA EN UN DÍA SELECCIONADO
        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
           

          
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //OBTIENE EL AREA DE TRABAJO DEL USUARIO LOGEADO
        public string AreaTrabajo()
        {
            string area = "";

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT area from usuarios WHERE usuario ='" + usuario + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                area = dr["area"].ToString();
            }
            dr.Close();
            con.Close();
            return area;
        }

        private void VentasEnCajas_Load(object sender, EventArgs e)
        {
            //CONFIGURACIONES QUE SE EJECUTAN AL INICIAR LA VENTANA
            //*********************** EL COMBOBOX MUESTRA LA TIENDA Y VITRINA DE ACUERDO A LA IP  *************************************
            string suc = Sucursal();
            string area = AreaTrabajo();

            if (suc.Equals("OSMART VALLARTA")&&(area.Equals("ADMON GRAL")|| area.Equals("SISTEMAS") || area.Equals("FINANZAS") || area.Equals("CXPAGAR")))
            {
                CB_sucursal.Items.Add("---- TIENDAS ----");
                CB_sucursal.Items.Add("VALLARTA");
                CB_sucursal.Items.Add("RENA");
                CB_sucursal.Items.Add("VELAZQUEZ");
                CB_sucursal.Items.Add("COLOSO");
                CB_sucursal.Items.Add("PREGOT");
                //CB_sucursal.Items.Add("---- VITRINAS ----");
                //CB_sucursal.Items.Add("VITRINA VA");
                //CB_sucursal.Items.Add("VITRINA RE");
                //CB_sucursal.Items.Add("VITRINA VE");
                //CB_sucursal.Items.Add("VITRINA CO");
                //CB_sucursal.Items.Add("VITRINA PRE");

                
            }

            if (suc.Equals("OSMART VALLARTA") && (area.Equals("ENC CAJAS") || area.Equals("GERENTE") || area.Equals("SUPER")))
            {
              
                CB_sucursal.Items.Add("VALLARTA");
                //CB_sucursal.Items.Add("VITRINA VA");
              
            }


            if (suc.Equals("OSMART RENACIMIENTO") && (area.Equals("ADMON GRAL") || area.Equals("SISTEMAS") || area.Equals("FINANZAS") || area.Equals("CXPAGAR")))
            {
                CB_sucursal.Items.Add("---- TIENDAS ----");
                CB_sucursal.Items.Add("VALLARTA");
                CB_sucursal.Items.Add("RENA");
                CB_sucursal.Items.Add("VELAZQUEZ");
                CB_sucursal.Items.Add("COLOSO");
                CB_sucursal.Items.Add("PREGOT");
                //CB_sucursal.Items.Add("---- VITRINAS ----");
                //CB_sucursal.Items.Add("VITRINA VA");
                //CB_sucursal.Items.Add("VITRINA RE");
                //CB_sucursal.Items.Add("VITRINA VE");
                //CB_sucursal.Items.Add("VITRINA CO");
                //CB_sucursal.Items.Add("VITRINA PRE");

                

            }

            if (suc.Equals("OSMART RENACIMIENTO") && (area.Equals("ENC CAJAS") || area.Equals("GERENTE") || area.Equals("SUPER")))
            {

                CB_sucursal.Items.Add("RENA");
                //CB_sucursal.Items.Add("VITRINA RE");

            }

            if (suc.Equals("OSMART VELAZQUEZ") && (area.Equals("ADMON GRAL") || area.Equals("SISTEMAS") || area.Equals("FINANZAS") || area.Equals("CXPAGAR")))
            {
                CB_sucursal.Items.Add("---- TIENDAS ----");
                CB_sucursal.Items.Add("VALLARTA");
                CB_sucursal.Items.Add("RENA");
                CB_sucursal.Items.Add("VELAZQUEZ");
                CB_sucursal.Items.Add("COLOSO");
                CB_sucursal.Items.Add("PREGOT");
                //CB_sucursal.Items.Add("---- VITRINAS ----");
                //CB_sucursal.Items.Add("VITRINA VA");
                //CB_sucursal.Items.Add("VITRINA RE");
                //CB_sucursal.Items.Add("VITRINA VE");
                //CB_sucursal.Items.Add("VITRINA CO");
                //CB_sucursal.Items.Add("VITRINA PRE");



            }

            if (suc.Equals("OSMART VELAZQUEZ") && (area.Equals("ENC CAJAS") || area.Equals("GERENTE") || area.Equals("SUPER")))
            {

                CB_sucursal.Items.Add("VELAZQUEZ");
                //CB_sucursal.Items.Add("VITRINA VE");

            }

            if (suc.Equals("OSMART COLOSO") && (area.Equals("ADMON GRAL") || area.Equals("SISTEMAS") || area.Equals("FINANZAS") || area.Equals("CXPAGAR")))
            {
                CB_sucursal.Items.Add("---- TIENDAS ----");
                CB_sucursal.Items.Add("VALLARTA");
                CB_sucursal.Items.Add("RENA");
                CB_sucursal.Items.Add("VELAZQUEZ");
                CB_sucursal.Items.Add("COLOSO");
                CB_sucursal.Items.Add("PREGOT");
                //CB_sucursal.Items.Add("---- VITRINAS ----");
                //CB_sucursal.Items.Add("VITRINA VA");
                //CB_sucursal.Items.Add("VITRINA RE");
                //CB_sucursal.Items.Add("VITRINA VE");
                //CB_sucursal.Items.Add("VITRINA CO");
                //CB_sucursal.Items.Add("VITRINA PRE");



            }

            if (suc.Equals("OSMART COLOSO") && (area.Equals("ENC CAJAS") || area.Equals("GERENTE") || area.Equals("SUPER")))
            {

                CB_sucursal.Items.Add("COLOSO");
                //CB_sucursal.Items.Add("VITRINA CO");

            }

            if (suc.Equals("PREGOT") && (area.Equals("ADMON GRAL") || area.Equals("SISTEMAS") || area.Equals("FINANZAS") || area.Equals("CXPAGAR")))
            {
                CB_sucursal.Items.Add("---- TIENDAS ----");
                CB_sucursal.Items.Add("VALLARTA");
                CB_sucursal.Items.Add("RENA");
                CB_sucursal.Items.Add("VELAZQUEZ");
                CB_sucursal.Items.Add("COLOSO");
                CB_sucursal.Items.Add("PREGOT");
                //CB_sucursal.Items.Add("---- VITRINAS ----");
                //CB_sucursal.Items.Add("VITRINA VA");
                //CB_sucursal.Items.Add("VITRINA RE");
                //CB_sucursal.Items.Add("VITRINA VE");
                //CB_sucursal.Items.Add("VITRINA CO");
                //CB_sucursal.Items.Add("VITRINA PRE");



            }

            if (suc.Equals("PREGOT") && (area.Equals("ENC CAJAS") || area.Equals("GERENTE") || area.Equals("SUPER")))
            {

                CB_sucursal.Items.Add("PREGOT");
                //CB_sucursal.Items.Add("VITRINA PRE");

            }

            if (suc.Equals("BODEGA") && (area.Equals("ADMON GRAL") || area.Equals("SISTEMAS") || area.Equals("FINANZAS") || area.Equals("CXPAGAR")))
            {
                CB_sucursal.Items.Add("---- TIENDAS ----");
                CB_sucursal.Items.Add("VALLARTA");
                CB_sucursal.Items.Add("RENA");
                CB_sucursal.Items.Add("VELAZQUEZ");
                CB_sucursal.Items.Add("COLOSO");
                CB_sucursal.Items.Add("PREGOT");
                //CB_sucursal.Items.Add("---- VITRINAS ----");
                //CB_sucursal.Items.Add("VITRINA VA");
                //CB_sucursal.Items.Add("VITRINA RE");
                //CB_sucursal.Items.Add("VITRINA VE");
                //CB_sucursal.Items.Add("VITRINA CO");
                //CB_sucursal.Items.Add("VITRINA PRE");


            }

            ventas.Columns.Add("VENTA",typeof(string));
            ventas.Columns.Add("TICKET", typeof(string));
            ventas.Columns.Add("IMPORTE", typeof(double));
            ventas.Columns.Add("FECHA", typeof(string));
            ventas.Columns.Add("HORA", typeof(string));
            ventas.Columns.Add("USUARIO", typeof(string));
            ventas.Columns.Add("TIPO", typeof(string));

            //************************************************************************************************************************

            //********************* BLOQUEAR COMBOBOX SUCURSAL ********************************************************************

            //SOLO LOS USUARIOS CON AREA SISTEMAS Y ADMON GRAL PODRÁN ELEGIR SUCURSAL EN ESTE MODULO
            //if (area.Equals("SISTEMAS")|| area.Equals("ADMON GRAL"))
            //{
            //    CB_sucursal.Enabled = true;
            //}
            //else
            //{
            //    CB_sucursal.Enabled = false;
            //}
            //************************************************************************************************************************
            LB_usuario.Text = usuario;
            DG_egresos.Columns[0].Width = 315;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


      

        //EVENTO DEL DATAGRID DG_tabka
        private void DG_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {//AL DAR DOBLE CLICK EN ALGUNA DE LAS FILAS DEL DATAGRID DG_tabla
            DG_retiros.Rows.Clear();
            DG_egresos.Rows.Clear();
            ventas.Clear();

            //try
            //{
            //    inTarjetas.Rows.Clear();
            //    egTarjetas.Rows.Clear();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(""+ex);
            //}


            DateTime fecha = DT_fecha.Value;
            MySqlConnection conexion = ElegirSucursal();
            string caja = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells[0].Value);// se guarda el nombre de la estacion seleccionada
            double importe = 0;
            string hora = "", usuario = "";
            int count = 0;


            GB_datos.Text = caja;//se le asigna el nombre de la estacion al GroupBox

            FortmatoEnCajas obj = new FortmatoEnCajas();

            DataTable dt = obj.RetirosCaja(caja, fecha.ToString("yyyy-MM-dd"), conexion);//se guardan los rertiros de la caja

            for (int i = 0; i < dt.Rows.Count; i++)
            {//uno a uno los datos del datatable dt se guardan en el DataGrid  DG_retiros
                count++;
                importe = Convert.ToDouble(dt.Rows[i]["IMPORTE"].ToString());
                hora = dt.Rows[i]["HORA"].ToString();
                usuario = dt.Rows[i]["USUARIO"].ToString();

                DG_retiros.Rows.Add(count, importe, hora, usuario);
            }
            DG_retiros.Columns[1].DefaultCellStyle.Format = "C2";
            DG_retiros.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;


            count = 0;
            string concepto = "";
            double imp = 0;
#pragma warning disable CS0219 // La variable 'h' está asignada pero su valor nunca se usa
            string h = "";
#pragma warning restore CS0219 // La variable 'h' está asignada pero su valor nunca se usa
            string user = "";
            DataTable egresos = obj.EgresosCaja(caja, fecha.ToString("yyyy-MM-dd"), conexion);// se guardan los egresos de la caja


        
            for (int i = 0; i < egresos.Rows.Count; i++)
            {//uno a uno los datos del datatable dt se guardan en el DataGrid  DG_egresos
                concepto = egresos.Rows[i]["descrip"].ToString();
                imp = Convert.ToDouble(egresos.Rows[i]["Egreso"].ToString());
                hora= egresos.Rows[i]["hora"].ToString();
                user= egresos.Rows[i]["usuario"].ToString();

                DG_egresos.Rows.Add(concepto,imp,hora,user);


            }

           

            DG_egresos.Columns[1].DefaultCellStyle.Format = "C2";
            DG_egresos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            inTarjetas = obj.IngresoTarjetas(caja, fecha.ToString("yyyy-MM-dd"), conexion);
            DG_tarjin.DataSource = inTarjetas;

            egTarjetas = obj.EgresoTarjetas(caja, fecha.ToString("yyyy-MM-dd"), conexion);
            DG_tarjeg.DataSource = egTarjetas;

            DG_tarjin.Columns[0].DefaultCellStyle.Format = "C2";
            DG_tarjin.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tarjeg.Columns[0].DefaultCellStyle.Format = "C2";
            DG_tarjeg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            DG_tarjin.Columns[0].Width = 80;
            DG_tarjin.Columns[2].Width = 80;

            DG_tarjeg.Columns[0].Width = 80;
            DG_tarjeg.Columns[2].Width = 80;


            // ---------------------- CALCULAR LA DIFERENCIA ENTRE INGRESO Y EGRESO DE VENTAS CON TARJETA-----------------------------------------
            DG_diferencia.Rows.Clear();
            double ingreso = 0, egreso = 0,diferencia=0;


            int filasIngreso = DG_tarjin.Rows.Count;
            int filasEgreso = DG_tarjeg.Rows.Count;

            int numFilas = 0;
            if (filasIngreso>filasEgreso)
            {
                numFilas = filasIngreso;
            }

            if (filasIngreso<filasEgreso)
            {
                numFilas = filasEgreso;
            }

            if (filasIngreso==filasEgreso)
            {
                numFilas = filasIngreso;
            }


            for (int i = 0; i < numFilas; i++)
            {
                if (filasIngreso==0||filasIngreso<0)
                {
                    ingreso = 0;
                }
                else
                {
                    ingreso = Convert.ToDouble(DG_tarjin.Rows[i].Cells["Ingreso"].Value);
                }

                if (filasEgreso==0||filasEgreso < 0)
                {
                    egreso = 0;
                }
                else
                {
                    egreso = Convert.ToDouble(DG_tarjeg.Rows[i].Cells["Egreso"].Value);
                }

                diferencia = ingreso - egreso;
                
                DG_diferencia.Rows.Add(diferencia);

                
                diferencia = 0;ingreso = 0;egreso = 0;
                filasIngreso--;
                filasEgreso--;
            }

            double dif = 0;
            for (int i = 0; i < DG_diferencia.Rows.Count; i++)
            {
                dif = Convert.ToDouble(DG_diferencia.Rows[i].Cells[0].Value);

                if (dif > 0 || dif < 0)
                {
                    DG_diferencia.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    DG_diferencia.Rows[i].Cells[0].Style.ForeColor = Color.White;
                }
            }

            DG_diferencia.Columns[0].DefaultCellStyle.Format = "C2";
            DG_tarjin.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            //----------------------------------------------------------------------------------------------------------------------------


            //------------------ VENTAS DE LA CAJA -----------------------------------------------------------------------------------------
       
            string query = "SELECT VENTAS.VENTA,VENTAS.NO_REFEREN, FLUJO.IMPORTE,FLUJO.FECHA,FLUJO.HORA,FLUJO.USUARIO,FLUJO.CONCEPTO2 FROM VENTAS INNER JOIN FLUJO ON VENTAS.VENTA = FLUJO.VENTA WHERE FLUJO.FECHA = '"+fecha.ToString("yyyy-MM-dd")+"' AND FLUJO.ESTACION = '"+caja+"' AND FLUJO.CONCEPTO2 <> 'CAM' ";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ventas.Rows.Add(dr["VENTA"].ToString(), dr["NO_REFEREN"].ToString(), Convert.ToDouble(dr["IMPORTE"].ToString()), dr["FECHA"].ToString(), dr["HORA"].ToString(), dr["USUARIO"].ToString(), dr["CONCEPTO2"].ToString());
            }
            

            
            DG_ventasCaja.DataSource = ventas;
            DG_ventasCaja.Columns[0].Visible = false;
            DG_ventasCaja.Columns[1].ReadOnly = true;
            DG_ventasCaja.Columns[2].ReadOnly = true;
            DG_ventasCaja.Columns[3].ReadOnly = true;
            DG_ventasCaja.Columns[4].ReadOnly = true;
            DG_ventasCaja.Columns[5].ReadOnly = true;
            DG_ventasCaja.Columns[6].ReadOnly = true;
            dr.Close();
           
        


            conexion.Close();

        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
          
        }

        private void DG_tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //EXPORTA A EXCEL EL CONTENIDO DE LOS DATAGRID
        private void BT_excel_Click(object sender, EventArgs e)
        {
            if (CHK_ventas.Checked==true)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);



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

            if (CHK_retiros.Checked==true)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);



                int indiceColumna = 0;

                foreach (DataGridViewColumn col in DG_retiros.Columns)
                {
                    indiceColumna++;
                    excel.Cells[5, indiceColumna] = col.Name;

                }

                int indiceFila = 4;

                foreach (DataGridViewRow row in DG_retiros.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;




                    foreach (DataGridViewColumn col in DG_retiros.Columns)
                    {
                        indiceColumna++;

                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                    }



                }




                excel.Visible = true;

            }

            if (CHK_egresos.Checked==true)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);



                int indiceColumna = 0;

                foreach (DataGridViewColumn col in DG_egresos.Columns)
                {
                    indiceColumna++;
                    excel.Cells[5, indiceColumna] = col.Name;

                }

                int indiceFila = 4;

                foreach (DataGridViewRow row in DG_egresos.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;




                    foreach (DataGridViewColumn col in DG_egresos.Columns)
                    {
                        indiceColumna++;

                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                    }



                }




                excel.Visible = true;

            }

            if (CHK_inTarj.Checked == true)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);



                int indiceColumna = 0;

                foreach (DataGridViewColumn col in DG_tarjin.Columns)
                {
                    indiceColumna++;
                    excel.Cells[5, indiceColumna] = col.Name;

                }

                int indiceFila = 4;

                foreach (DataGridViewRow row in DG_tarjin.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;




                    foreach (DataGridViewColumn col in DG_tarjin.Columns)
                    {
                        indiceColumna++;

                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                    }



                }




                excel.Visible = true;

            }

            if (CHK_egTarj.Checked == true)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);



                int indiceColumna = 0;

                foreach (DataGridViewColumn col in DG_tarjeg.Columns)
                {
                    indiceColumna++;
                    excel.Cells[5, indiceColumna] = col.Name;

                }

                int indiceFila = 4;

                foreach (DataGridViewRow row in DG_tarjeg.Rows)
                {
                    indiceFila++;
                    indiceColumna = 0;




                    foreach (DataGridViewColumn col in DG_tarjeg.Columns)
                    {
                        indiceColumna++;

                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                    }



                }




                excel.Visible = true;

            }

            if (CHK_ventas.Checked == false && CHK_retiros.Checked == false && CHK_egresos.Checked == false && CHK_inTarj.Checked == false && CHK_egTarj.Checked == false)
            {
                MessageBox.Show("SELECCIONA ALGUNA DE LAS CASILLAS PARA EXPORTAR LOS DATOS");
            }
        }


        public double Diferencia(string estacion,string fecha)
        {
            double egreso = 0,ingreso=0;
            MySqlConnection conexion = ElegirSucursal();
            string query = "select sum(importe) as Egreso from flujo where estacion='"+estacion+"' and fecha='"+fecha+"' and ING_EG='E'";
            string query2 = "select sum(importe) as Ingreso from flujo where estacion='" + estacion + "' and fecha='" + fecha+ "' and ING_EG='I'";
            
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                egreso = Convert.ToDouble(dr["Egreso"].ToString());
            }
            dr.Close();

            MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
            MySqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                ingreso = Convert.ToDouble(dr2["Ingreso"].ToString());
            }
            dr2.Close();
            conexion.Close();
            return ingreso-egreso;
        }


        private void BT_Aceptar_Click_1(object sender, EventArgs e)
        {
            ventas.Clear();
            estaciones.Clear();
            DG_egresos.Rows.Clear();
            DG_retiros.Rows.Clear();
            DG_tabla.Rows.Clear();
            DG_diferencia.Rows.Clear();
            GB_datos.Text = "ESTACION";
            try
            {

                if (inTarjetas !=null)
                {
                    inTarjetas.Rows.Clear();
                }

                if (egTarjetas !=null)
                {
                    egTarjetas.Rows.Clear();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);

            }
            CHK_ventas.Checked = false;
            CHK_retiros.Checked = false;
            CHK_egresos.Checked = false;
            CHK_inTarj.Checked = false;
            CHK_egTarj.Checked = false;

            ObtenerEstaciones();//OBTIENE EL NOMBRE DE LAS ESTACIONES EN EL DATAGRIG


            double egreso = 0;
            double vaucher = 0;//VENTAS CON TARJETA
            double retiros = 0; //ES LA SUMA DEL EFECTIVO DISPONIBLE Y EL TOTAL DE LAS VENTAS CON TARJETA
            double devoluciones = 0;
            double sobrante = 0;
            double efectivo = 0;
            double otrosEfectivos = 0;
            double ventaNeta = 0;
            double diferencia = 0;
            double cortez = 0;
            DateTime fecha = DT_fecha.Value;


            double TotalVenta = 0;


            //LLENAR DATAGRID CON LOS DATOS DE CADA ESTACION
            FortmatoEnCajas calc = new FortmatoEnCajas();
            MySqlConnection conexion = ElegirSucursal();
            for (int i = 0; i < estaciones.Count; i++)
            {
                //SE CALCULAN LOS RESULTADOS MOSTRADOS EN EL DATAGRID DG_tabla
                TotalVenta = calc.VentaTotal(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"), conexion);
                egreso = calc.CalcularEgreso(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"), conexion);
                cortez = calc.ImporteCorteZ(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"), conexion);
                efectivo = calc.TotalEfectivo(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"), conexion);
                otrosEfectivos = calc.OtrosIngresos(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"), conexion);
                vaucher = calc.VentaTarjetas(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"), conexion);
                sobrante = calc.Sobrante(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"), conexion);
                devoluciones = calc.Devoluciones(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"), conexion);

                retiros = efectivo + vaucher;
                egreso -= cortez;
                ventaNeta = ((((((TotalVenta - egreso) - vaucher) + sobrante) + otrosEfectivos) + devoluciones) + retiros);

                diferencia = efectivo - ventaNeta;

                //diferencia = Diferencia(estaciones[i].ToString(), fecha.ToString("yyyy-MM-dd"));
                //SE INSERTAN LOS VALORES EN EL DATAGRID DG_tabla
                DG_tabla.Rows.Add(estaciones[i].ToString(), TotalVenta, egreso, efectivo, vaucher, retiros, sobrante, devoluciones, otrosEfectivos, ventaNeta, diferencia);

                //SE RESETEAN LAS VARIABLES PARA EVITAR QUE SE ACUMULEN LOS RESULTADOS DE OTRAS CAJAS
                egreso = 0; efectivo = 0; otrosEfectivos = 0; vaucher = 0; sobrante = 0; devoluciones = 0; retiros = 0; ventaNeta = 0; diferencia = 0;


            }
            //SE RESETEAN LAS VARIABLES PARA EVITAR QUE SE ACUMULEN LOS RESULTADOS DE OTRAS CAJAS
            double SumaVT = 0, SumaEgresos = 0, sumaTE = 0, totalVaucher = 0, sumaRetiros = 0, sumaSobrante = 0, sumaDevoluciones = 0, sumaOF = 0, sumaVN = 0, sumaDif = 0;

            for (int j = 0; j < DG_tabla.RowCount; j++)
            {//EN ESTE FOR SE CALCULA EL TOTAL DE CADA COLUMNA DEL DATAGRID   DG_tabla
                SumaVT += Convert.ToDouble(DG_tabla.Rows[j].Cells[1].Value);
                SumaEgresos += Convert.ToDouble(DG_tabla.Rows[j].Cells[2].Value);
                sumaTE += Convert.ToDouble(DG_tabla.Rows[j].Cells[3].Value);
                totalVaucher += Convert.ToDouble(DG_tabla.Rows[j].Cells[4].Value);
                sumaRetiros += Convert.ToDouble(DG_tabla.Rows[j].Cells[5].Value);
                sumaSobrante += Convert.ToDouble(DG_tabla.Rows[j].Cells[6].Value);
                sumaDevoluciones += Convert.ToDouble(DG_tabla.Rows[j].Cells[7].Value);
                sumaOF += Convert.ToDouble(DG_tabla.Rows[j].Cells[8].Value);
                sumaVN += Convert.ToDouble(DG_tabla.Rows[j].Cells[9].Value);
                sumaDif += Convert.ToDouble(DG_tabla.Rows[j].Cells[10].Value);

            }
            //EN ESTA FILA SE INSERTAN LOS TOTALES DE CADA COLUMNA
            DG_tabla.Rows.Add("TOTALES", SumaVT, SumaEgresos, sumaTE, totalVaucher, sumaRetiros, sumaSobrante, sumaDevoluciones, sumaOF, sumaVN, sumaDif);

            //ALINEAR EL CONTENIDO DE LAS COLUMNAS A LA DERECHA
            DG_tabla.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            // FORMATO DE MONEDA PARA LAS COLUMNAS CORRESPONDIENTES
            DG_tabla.Columns[0].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[1].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[3].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[4].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[5].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[6].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[7].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[8].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[9].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[10].DefaultCellStyle.Format = "C2";

            this.DG_tabla.Sort(this.DG_tabla.Columns["ESTACION"], ListSortDirection.Ascending);// SE ORDENAN LOS DATOS POR ORDEN ALFABETICO DE LAS CAJAS



            conexion.Close();
        }

        private void TB_buscarTicket_TextChanged(object sender, EventArgs e)
        {
            DataView view = ventas.DefaultView;
            view.RowFilter = string.Empty;
            view.RowFilter = "TICKET" + " LIKE '%" + TB_buscarTicket.Text + "%'";
            DG_ventasCaja.DataSource = view;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DG_ventasCaja_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string user = this.usuario;
            string venta = DG_ventasCaja.Rows[e.RowIndex].Cells[0].Value.ToString();
            string ticket = DG_ventasCaja.Rows[e.RowIndex].Cells[1].Value.ToString();
            double importe = Convert.ToDouble(DG_ventasCaja.Rows[e.RowIndex].Cells[2].Value.ToString());
            string fecha = DG_ventasCaja.Rows[e.RowIndex].Cells[3].Value.ToString();
            string hora = DG_ventasCaja.Rows[e.RowIndex].Cells[4].Value.ToString();
            string cajera  = DG_ventasCaja.Rows[e.RowIndex].Cells[5].Value.ToString();
            string tipoVenta = DG_ventasCaja.Rows[e.RowIndex].Cells[6].Value.ToString();
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime fechaVenta = DT_fecha.Value;
            ModificarTipoVenta modificar = new ModificarTipoVenta(usuario,venta,ticket,importe,fecha,hora,cajera,tipoVenta,user,sucursal,fechaVenta);
            modificar.Show();

        }

        private void BT_CambiarConcepto_Click(object sender, EventArgs e)
        {
            ConceptoEgreso egreso = new ConceptoEgreso(usuario);
            egreso.Show();
        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DG_ventasCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
