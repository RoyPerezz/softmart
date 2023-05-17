using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class CuentasXPagar : Form
    {
#pragma warning disable CS0414 // El campo 'CuentasXPagar.valbo' está asignado pero su valor nunca se usa
        int valva = 0,valre=0,valve=0,valco=0,valpre=0,valbo=0;
#pragma warning restore CS0414 // El campo 'CuentasXPagar.valbo' está asignado pero su valor nunca se usa
        string usuario = "";
        double saldo = 0;
        double importe = 0;
        double cargo = 0;
        double abono = 0;
        string tienda = "";
        DateTime fecha;
#pragma warning disable CS0169 // El campo 'CuentasXPagar.conectar' nunca se usa
        MySqlConnection conectar;
#pragma warning restore CS0169 // El campo 'CuentasXPagar.conectar' nunca se usa
        DataTable DTVallarta = new DataTable();
        DataTable DTRena = new DataTable();
        DataTable DTColoso = new DataTable();
        DataTable DTVelazquez = new DataTable();
        //DataTable DTPregot = new DataTable();
        DataTable DTBodega = new DataTable();
        DataTable master = new DataTable();
        DataTable pagos = new DataTable();


        //############# OBTENGO EL REGISTRO DE CARGOS Y ABONOS DE CADA UNA DE LAS TIENDAS #####################################################################
        public void CuentasPendientesVA(string proveedor)
        {
            //string consulta = "SELECT TE.CUENXPAG,CXP.COMPRA, TE.PROVEEDOR, TE.FECHA AS FECHA, TE.TIPO_DOC, TE.NO_REFEREN, TE.CARGO_AB, TE.IMPORTE FROM CUENXPDET TE INNER JOIN CUENXPAG CXP  ON TE.CUENXPAG = CXP.CUENXPAG WHERE TE.PROVEEDOR ='" + proveedor + "'"; 
            string consulta = "SELECT COMPRA, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE,OBSERV,COBRADOR FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
            //DATOS DE VALLLARTA
            try
            {
                MySqlConnection conVallarta = BDConexicon.VallartaOpen();
                MySqlCommand cmdVA = new MySqlCommand(consulta, conVallarta);
                MySqlDataAdapter adVA = new MySqlDataAdapter(cmdVA);
                adVA.Fill(DTVallarta);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "VALLARTA";
                DTVallarta.Columns.Add(col);
                //LB_vallarta.Text = "CONECTADO";
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

            }
        }

        public void CuentasPendientesRE(string proveedor)
        {
            // string consulta = "SELECT TE.CUENXPAG,CXP.COMPRA, TE.PROVEEDOR, TE.FECHA AS FECHA, TE.TIPO_DOC, TE.NO_REFEREN, TE.CARGO_AB, TE.IMPORTE FROM CUENXPDET TE INNER JOIN CUENXPAG CXP  ON TE.CUENXPAG = CXP.CUENXPAG WHERE TE.PROVEEDOR ='" + proveedor + "'";
            string consulta = "SELECT COMPRA, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE,OBSERV,COBRADOR FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";

            try
            {
                //DATOS DE RENA
                MySqlConnection conRena = BDConexicon.RenaOpen();
                MySqlCommand cmdRE = new MySqlCommand(consulta, conRena);
                MySqlDataAdapter adRE = new MySqlDataAdapter(cmdRE);
                adRE.Fill(DTRena);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "RENA";
                DTRena.Columns.Add(col);
                //LB_rena.Text = "CONECTADO";
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

            }

        }

        public void CuentasPendientesCO(string proveedor)
        {
            //string consulta = "SELECT TE.CUENXPAG,CXP.COMPRA, TE.PROVEEDOR, TE.FECHA AS FECHA, TE.TIPO_DOC, TE.NO_REFEREN, TE.CARGO_AB, TE.IMPORTE FROM CUENXPDET TE INNER JOIN CUENXPAG CXP  ON TE.CUENXPAG = CXP.CUENXPAG WHERE TE.PROVEEDOR ='" + proveedor + "'";
            string consulta = "SELECT COMPRA, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE,OBSERV,COBRADOR FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
            try
            {
                //DATOS DE COLOSO
                MySqlConnection conColoso = BDConexicon.ColosoOpen();
                MySqlCommand cmdCO = new MySqlCommand(consulta, conColoso);
                MySqlDataAdapter adCO = new MySqlDataAdapter(cmdCO);
                adCO.Fill(DTColoso);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "COLOSO";
                DTColoso.Columns.Add(col);
                //LB_coloso.Text = "CONECTADO";
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }

        public void CuentasPendientesVE(string proveedor)
        {
            //string consulta = "SELECT TE.CUENXPAG,CXP.COMPRA, TE.PROVEEDOR, TE.FECHA AS FECHA, TE.TIPO_DOC, TE.NO_REFEREN, TE.CARGO_AB, TE.IMPORTE FROM CUENXPDET TE INNER JOIN CUENXPAG CXP  ON TE.CUENXPAG = CXP.CUENXPAG WHERE TE.PROVEEDOR ='" + proveedor + "'";
            string consulta = "SELECT COMPRA, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE,OBSERV,COBRADOR FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
            try
            {
                //DATOS DE VELAZQUEZ
                MySqlConnection conVelazquez = BDConexicon.VelazquezOpen();
                MySqlCommand cmdVE = new MySqlCommand(consulta, conVelazquez);
                MySqlDataAdapter adVE = new MySqlDataAdapter(cmdVE);
                adVE.Fill(DTVelazquez);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "VELAZQUEZ";
                DTVelazquez.Columns.Add(col);
                //LB_velazquez.Text = "CONECTADO";
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
            }
        }

//        public void CuentasPendientesPRE(string proveedor)
//        {
//            // string consulta = "SELECT TE.CUENXPAG,CXP.COMPRA, TE.PROVEEDOR, TE.FECHA  AS FECHA, TE.TIPO_DOC, TE.NO_REFEREN, TE.CARGO_AB, TE.IMPORTE FROM CUENXPDET TE INNER JOIN CUENXPAG CXP  ON TE.CUENXPAG = CXP.CUENXPAG WHERE TE.PROVEEDOR ='" + proveedor + "'";
//            string consulta = "SELECT COMPRA, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE,OBSERV,COBRADOR FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
//            try
//            {
//                //DATOS DE PREGOT
//                MySqlConnection conPregot = BDConexicon.Papeleria1Open();
//                MySqlCommand cmdPRE = new MySqlCommand(consulta, conPregot);
//                MySqlDataAdapter adPRE = new MySqlDataAdapter(cmdPRE);
//                adPRE.Fill(DTPregot);
//                DataColumn col = new DataColumn();
//                col.ColumnName = "TIENDA";
//                col.DefaultValue = "PREGOT";
//                DTPregot.Columns.Add(col);
//                //LB_pregot.Text = "CONECTADO";
//            }
//#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
//            catch (Exception ex)
//#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
//            {

//            }
//        }

        public void CuentasPendientesBO(string proveedor)
        {
            // string consulta = "SELECT TE.CUENXPAG,CXP.COMPRA, TE.PROVEEDOR, TE.FECHA AS FECHA, TE.TIPO_DOC, TE.NO_REFEREN, TE.CARGO_AB, TE.IMPORTE FROM CUENXPDET TE INNER JOIN CUENXPAG CXP  ON TE.CUENXPAG = CXP.CUENXPAG WHERE TE.PROVEEDOR ='" + proveedor + "'";
            string consulta = "SELECT COMPRA,PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, CARGO_AB, IMPORTE,OBSERV,COBRADOR FROM CUENXPDET WHERE PROVEEDOR ='" + proveedor + "'";
            try
            {

                //DATOS DE BODEGA
                MySqlConnection conBodega = BDConexicon.BodegaOpen();
                MySqlCommand cmdBO = new MySqlCommand(consulta, conBodega);
                MySqlDataAdapter adBO = new MySqlDataAdapter(cmdBO);
                adBO.Fill(DTBodega);
                DataColumn col = new DataColumn();
                col.ColumnName = "TIENDA";
                col.DefaultValue = "BODEGA";
                DTBodega.Columns.Add(col);
                //LB_bodega.Text = "CONECTADO";
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

            }

        }


        //###################################### EN EL CONSTRUCTOR SE CARGA EL TAMAÑO DE LAS COLUMNAS DEL DATAGRIDVIEW #################################
        public CuentasXPagar(string usuario)
        {
            InitializeComponent();
            DG_datos.Columns[0].Width = 100;
            DG_datos.Columns[1].Width = 130;
            DG_datos.Columns[2].Width = 140;
            DG_datos.Columns[3].Width = 120;
            DG_datos.Columns[4].Width = 275;
            DG_datos.Columns[5].Width = 60;
            DG_datos.Columns[6].Width = 150;
            DG_datos.Columns[7].Width = 150;
            this.usuario = usuario;
        }


   


        DataTable nuevo = new DataTable();
        //#################################### INSERTA EN EL DATAGRIDVIEW LOS DATOS CORRESPONDIENTES AL HISTORIAL DE PAGOS Y COMPRAS DEL PROVEEDOR ##############
        public void EstadoCuenta()
        {
            master.Merge(DTBodega);
            master.Merge(DTVallarta);
            master.Merge(DTRena);
            master.Merge(DTVelazquez);
            master.Merge(DTColoso);      
            //master.Merge(DTPregot);
            
            //master.DefaultView.Sort = "FECHA";
            DataView vista = master.DefaultView;
            vista.Sort = "FECHA";
            master = vista.ToTable();
            string cobrador = "";


            for (int i = 0; i < master.Rows.Count; i++)
            {
                importe = Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                fecha = Convert.ToDateTime(master.Rows[i]["FECHA"].ToString());
                tienda = master.Rows[i]["TIENDA"].ToString();

                if (master.Rows[i]["cargo_ab"].ToString().Equals("C"))
                {//SI LA OPERACION ES "C" ES UNA COMPRA Y SE SUMA AL SALDO
                    saldo += Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                    cargo = Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                    cobrador = master.Rows[i]["COBRADOR"].ToString();

                    if (string.IsNullOrEmpty(cobrador))
                    {
                        DG_datos.Rows.Add(master.Rows[i]["COMPRA"].ToString(), master.Rows[i]["PROVEEDOR"].ToString() + " " + CB_proveedor.SelectedItem.ToString(), fecha.ToString("dd/MM/yyyy"), master.Rows[i]["TIPO_DOC"].ToString(), master.Rows[i]["NO_REFEREN"].ToString(), master.Rows[i]["CARGO_AB"].ToString(), tienda, String.Format("{0:0.##}", cargo.ToString("C")), "", String.Format("{0:0.##}", saldo.ToString("C")), master.Rows[i]["OBSERV"].ToString(), master.Rows[i]["COBRADOR"].ToString());
                    }
                    else
                    {
                        DG_datos.Rows.Add(master.Rows[i]["COBRADOR"].ToString(), master.Rows[i]["PROVEEDOR"].ToString() + " " + CB_proveedor.SelectedItem.ToString(), fecha.ToString("dd/MM/yyyy"), master.Rows[i]["TIPO_DOC"].ToString(), master.Rows[i]["NO_REFEREN"].ToString(), master.Rows[i]["CARGO_AB"].ToString(), tienda, String.Format("{0:0.##}", cargo.ToString("C")), "", String.Format("{0:0.##}", saldo.ToString("C")), master.Rows[i]["OBSERV"].ToString(), master.Rows[i]["COBRADOR"].ToString());
                    }

                    //DG_datos.Rows.Add(master.Rows[i]["COMPRA"].ToString(), master.Rows[i]["PROVEEDOR"].ToString() + " " + CB_proveedor.SelectedItem.ToString(), fecha.ToString("dd/MM/yyyy"), master.Rows[i]["TIPO_DOC"].ToString(), master.Rows[i]["NO_REFEREN"].ToString(), master.Rows[i]["CARGO_AB"].ToString(), tienda, String.Format("{0:0.##}", cargo.ToString("C")), "", String.Format("{0:0.##}", saldo.ToString("C")), master.Rows[i]["OBSERV"].ToString(), master.Rows[i]["COBRADOR"].ToString());

                }

                else
                {
                    //PERO SI ES DIFERENTE DE "C"(UN ABONO, AJUSTE, DEVOLUCIO, ETC) SE RESTA DEL SALDO DE LA CUENTA

                    saldo -= Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());
                    abono = Convert.ToDouble(master.Rows[i]["IMPORTE"].ToString());

                    cobrador = master.Rows[i]["COBRADOR"].ToString();

                    if (string.IsNullOrEmpty(cobrador))
                    {
                        DG_datos.Rows.Add(master.Rows[i]["COMPRA"].ToString(), master.Rows[i]["PROVEEDOR"].ToString() + " " + CB_proveedor.SelectedItem.ToString(), fecha.ToString("dd/MM/yyyy"), master.Rows[i]["TIPO_DOC"].ToString(), master.Rows[i]["NO_REFEREN"].ToString(), master.Rows[i]["CARGO_AB"].ToString(), tienda, "", abono.ToString("C"), saldo.ToString("C"), master.Rows[i]["OBSERV"].ToString(), master.Rows[i]["COBRADOR"].ToString());
                    }
                    else
                    {
                        DG_datos.Rows.Add(master.Rows[i]["COBRADOR"].ToString(), master.Rows[i]["PROVEEDOR"].ToString() + " " + CB_proveedor.SelectedItem.ToString(), fecha.ToString("dd/MM/yyyy"), master.Rows[i]["TIPO_DOC"].ToString(), master.Rows[i]["NO_REFEREN"].ToString(), master.Rows[i]["CARGO_AB"].ToString(), tienda, "", abono.ToString("C"), saldo.ToString("C"), master.Rows[i]["OBSERV"].ToString(), master.Rows[i]["COBRADOR"].ToString());
                    }

                    //DG_datos.Rows.Add(master.Rows[i]["COMPRA"].ToString(), master.Rows[i]["PROVEEDOR"].ToString() + " " + CB_proveedor.SelectedItem.ToString(), fecha.ToString("dd/MM/yyyy"), master.Rows[i]["TIPO_DOC"].ToString(), master.Rows[i]["NO_REFEREN"].ToString(), master.Rows[i]["CARGO_AB"].ToString(), tienda, "", abono.ToString("C"),  saldo.ToString("C"), master.Rows[i]["OBSERV"].ToString(), master.Rows[i]["COBRADOR"].ToString());

                }



            }

            int filas = DG_datos.Rows.Count;
            double saldoCuenta = 0;
            decimal digito = decimal.Parse(DG_datos.Rows[filas - 1].Cells[9].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string saldo_Cuenta = digito.ToString("G0");

            saldoCuenta = Convert.ToDouble(saldo_Cuenta);



            LB_saldo.Text = String.Format("{0:0.##}", saldoCuenta.ToString("C"));

            if (saldoCuenta > 0)
            {
                LB_saldo.ForeColor = Color.Green;
            }

            if (saldoCuenta <= 0)
            {
                LB_saldo.ForeColor = Color.Red;
            }




            DG_datos.Columns["IDMOV"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["PROV"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["FECHA_"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["TIPO_DOCUMENTO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["REFERENCIA"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["MOVIMIENTO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["SUCURSAL_"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["COMPRA_"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["PAGO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_datos.Columns["SALDO_"].SortMode = DataGridViewColumnSortMode.NotSortable;




        }



        //###################################### OBTENER LOS NOMBRES DE LOS PROVEEDORES #######################################################
        public void proveedores()
        {
            MySqlConnection BO = BDConexicon.BodegaOpen();

            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM proveed ORDER BY nombre ASC", BO);
                MySqlDataReader dr = cmd.ExecuteReader();
                //LB_status.ForeColor = Color.DarkGreen;
                //LB_status.Text = "Conectado";
                while (dr.Read())
                {

                    CB_proveedor.Items.Add(dr["nombre"].ToString());
                }

                dr.Close();

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("NO HAY CONEXIÓN CON EL SERVIDOR DE BODEGA");
            }


            BO.Close();


            //conectar.Close();

        }

        //################################ PRUEBA AL INICIAR EL FORM QUE TIENDAS TIENEN CONEXION ##########################################
        public void ProbarConexiones()
        {
            try
            {
                MySqlConnection bo = BDConexicon.BodegaOpen();
                if (bo.State == ConnectionState.Open)
                {

                    LB_bo.ForeColor = Color.DarkGreen;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


                LB_bo.ForeColor = Color.Red;
            }
            try
            {
                MySqlConnection va = BDConexicon.VallartaOpen();
                if (va.State == ConnectionState.Open)
                {
                    //LB_vallarta.Text = "CONECTADO";
                    LB_va.ForeColor = Color.DarkGreen;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                //LB_vallarta.Text = "SIN CONEXIÓN";
                LB_va.ForeColor = Color.Red;

            }


            try
            {
                MySqlConnection re = BDConexicon.RenaOpen();
                if (re.State == ConnectionState.Open)
                {

                    LB_re.ForeColor = Color.DarkGreen;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                LB_re.ForeColor = Color.Red;

            }

            try
            {

                MySqlConnection co = BDConexicon.ColosoOpen();
                if (co.State == ConnectionState.Open)
                {

                    LB_co.ForeColor = Color.DarkGreen;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


                LB_co.ForeColor = Color.Red;
            }

            try
            {
                MySqlConnection ve = BDConexicon.VelazquezOpen();
                if (ve.State == ConnectionState.Open)
                {

                    LB_ve.ForeColor = Color.DarkGreen;
                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                LB_ve.ForeColor = Color.Red;

            }


            //try
            //{
            //    MySqlConnection pre = BDConexicon.Papeleria1Open();
            //    if (pre.State == ConnectionState.Open)
            //    {
            //        //LB_pregot.Text = "CONECTADO";
            //        LB_pre.ForeColor = Color.DarkGreen;
            //    }
            //}

            //catch (Exception ex)

            //{
            //    //LB_pregot.Text = "SIN CONEXIÓN";
            //    LB_pre.ForeColor = Color.Red;

            //}


        }



        private void CuentasXPagar_Load(object sender, EventArgs e)
        {
            DG_datos.Columns["OBSERV"].Visible = false;
            proveedores();
            DG_datos.Columns["PROV"].Width = 400;
            DG_datos.Columns["FECHA_"].Width = 125;
            DG_datos.Columns["TIPO_DOCUMENTO"].Width = 100;
            DG_datos.Columns["REFERENCIA"].Width = 230;
            DG_datos.Columns["MOVIMIENTO"].Width = 50;
            DG_datos.Columns["SUCURSAL_"].Width = 150;
            DG_datos.Columns["COMPRA_"].Width = 155;
            DG_datos.Columns["PAGO"].Width = 150;
            DG_datos.Columns["SALDO_"].Width = 150;

            pagos.Columns.Add("IMPORTE", typeof(double));
            pagos.Columns.Add("FECHA PAGO", typeof(string));
            pagos.Columns.Add("FECHA EFECTIVO", typeof(string));
            pagos.Columns.Add("TIPO", typeof(string));
            pagos.Columns.Add("BANCO", typeof(string));
            pagos.Columns.Add("CUENTA", typeof(string));
            pagos.Columns.Add("CLIENTE BANCARIO", typeof(string));
            pagos.Columns.Add("TIENDA", typeof(string));

            CHB_bodega.Checked = true;
            CHB_vallarta.Checked = true;
            CHB_rena.Checked = true;
            CHB_velazquez.Checked = true;
            CHB_coloso.Checked = true;
            //CHB_pregot.Checked = true;




        }


        //############################### OBTIENE EL ID DEL PROVEEDOR CADA VEZ QUE SE SELECCIONA DEL COMBOBOX #######################################

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            

            ResetarComponentes();
            MySqlConnection BO = BDConexicon.BodegaOpen();
            DG_datos.Rows.Clear();
            saldo = 0;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR FROM proveed where NOMBRE='" + CB_proveedor.SelectedItem.ToString() + "'", BO);
                MySqlDataReader d = cmd.ExecuteReader();
                //MessageBox.Show(conectar.State.ToString());
                while (d.Read())
                {

                    TB_proveedor.Text = d["proveedor"].ToString();

                }
                d.Close();
                //EstadoCuenta();

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

            }
            BO.Close();

        }






        private void label2_Click(object sender, EventArgs e)
        {

        }






        private void BT_guardar_Click(object sender, EventArgs e)
        {
            //ESTE BOTON EXPORTA EN EXCEL EL ESTADO DE CUENTA DE UN PROVEEDOR

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_datos.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_datos.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_datos.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;

        }



        private void LB_pregot_Click(object sender, EventArgs e)
        {

        }

        private void LB_velazquez_Click(object sender, EventArgs e)
        {

        }

        private void LB_vallarta_Click(object sender, EventArgs e)
        {

        }

        private void LB_coloso_Click(object sender, EventArgs e)
        {

        }

        private void LB_rena_Click(object sender, EventArgs e)
        {

        }

        private void BT_buscar_compra_Click(object sender, EventArgs e)
        {
            string compra = TB_compra.Text;
            string compraDG = "";
            for (int i = 0; i < DG_datos.RowCount; i++)
            {
                compraDG = Convert.ToString(DG_datos.Rows[i].Cells[0].Value);

                if (compra.Equals(compraDG))
                {
                    DG_datos.CurrentCell = DG_datos.Rows[i].Cells[0];
                    DG_datos.Rows[i].Selected=true;
                    break;
                }
            }
        }



        string proveedor = "", id = "", compra = "";
        string importeComp = "";
        string sucursal = "";

    

        //ventana para depositar de proveedor a proveedor
        private void button1_Click_1(object sender, EventArgs e)
        {

            string proveedor = TB_proveedor.Text;
            string nombreprov = CB_proveedor.SelectedItem.ToString();
            string sucursalParaDepositar = sucursal;
            string compra2 = compra;
            DepositarDeProvaProv deposito = new DepositarDeProvaProv(proveedor,nombreprov,usuario);
            string modulo = deposito.Name;
            RegistrarAccesos(modulo);
            deposito.Show();
        }

        
        private void TB_filtro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Down)
            {
                string nombre = TB_filtro.Text;



                TFiltroProveedores proveedor = new TFiltroProveedores(nombre);
                AddOwnedForm(proveedor);
                proveedor.Show();



            }

           


        }

      

        //traer el estado de cuenta con un enter
        private void CB_proveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                saldo = 0;
                DTBodega.Clear();
                DTVallarta.Clear();
                DTRena.Clear();
                DTColoso.Clear();
                DTVelazquez.Clear();
                //DTPregot.Clear();
                master.Clear();
                ResetarComponentes();
                ProbarConexiones();
                valva = 0; valre = 0; valve = 0; valco = 0; valpre = 0;
                string proveedor = TB_proveedor.Text;

                if (CHB_bodega.Checked)
                {
                    CuentasPendientesBO(proveedor);
                    valbo = 1;
                }

                if (CHB_vallarta.Checked)
                {
                    CuentasPendientesVA(proveedor);
                    valva = 1;
                }

                if (CHB_rena.Checked)
                {
                    CuentasPendientesRE(proveedor);
                    valre = 1;
                }

                if (CHB_coloso.Checked)
                {
                    CuentasPendientesCO(proveedor);
                    valco = 1;
                }

                if (CHB_velazquez.Checked)
                {
                    CuentasPendientesVE(proveedor);
                    valve = 1;
                }

                //if (CHB_pregot.Checked)
                //{
                //    CuentasPendientesPRE(proveedor);
                //    valpre = 1;

                //}

                EstadoCuenta();
                //LIMPIAR DATATABLES
                //DTBodega.Clear();
                //DTVallarta.Clear();
                //DTRena.Clear();
                //DTColoso.Clear();
                //DTVelazquez.Clear();
                //DTPregot.Clear();
                //master.Clear();
                if (DG_datos.RowCount == 0)
                {
                    MessageBox.Show("NO HAY REGISTROS DE ESTE PROVEEDOR");
                }



            }
        }

        private void TB_compra_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
            {
                string compra = TB_compra.Text;
                string compraDG = "";
                for (int i = 0; i < DG_datos.RowCount; i++)
                {
                    compraDG = Convert.ToString(DG_datos.Rows[i].Cells[0].Value);

                    if (compra.Equals(compraDG))
                    {
                        DG_datos.CurrentCell = DG_datos.Rows[i].Cells[0];
                        DG_datos.Rows[i].Selected = true;
                        break;
                    }
                }
            }
        }

        private void DG_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            proveedor = CB_proveedor.SelectedItem.ToString();
            id = TB_proveedor.Text;
            compra = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells[0].Value);
            importeComp = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells[7].Value);
            sucursal = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells[6].Value);

        }

        private void DG_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void RegistrarAccesos(string modulo)
        {
            string query = "INSERT INTO rd_log_acceso_modulos(usuario,fecha,hora,ip,nombre_equipo,modulo)VALUES(?usuario,?fecha,?hora,?ip,?nombre_equipo,?modulo)";
            MySqlConnection conexion = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            DateTime fecha = DateTime.Now;
            string nombre_equipo = Environment.MachineName;

            IPHostEntry host;
            string ip = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress IP in host.AddressList)
            {
                if (IP.AddressFamily.ToString() == "InterNetwork")
                {
                    ip = IP.ToString();
                }
            }

            cmd.Parameters.AddWithValue("?usuario", usuario);
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?hora", fecha.ToString("HH:mm:dd"));
            cmd.Parameters.AddWithValue("?ip", ip);
            cmd.Parameters.AddWithValue("?nombre_equipo", nombre_equipo);
            cmd.Parameters.AddWithValue("?modulo", modulo);
            cmd.ExecuteNonQuery();
        }


        private void BT_cuentasOS_Click(object sender, EventArgs e)
        {
            var Deposito = new DevolverDineroACuentaOsmart(proveedor,id,compra,importeComp,usuario,sucursal);
            string modulo = Deposito.Name;
            RegistrarAccesos(modulo);
            Deposito.Show();
        }

        public void ResetarComponentes()
        {

            LB_bo.ForeColor = Color.Gray;
            LB_va.ForeColor = Color.Gray;
            LB_re.ForeColor = Color.Gray;
            LB_co.ForeColor = Color.Gray;
            LB_ve.ForeColor = Color.Gray;
            //LB_pre.ForeColor = Color.Gray;
            DG_datos.Rows.Clear();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            saldo = 0;
            DTBodega.Clear();
            DTVallarta.Clear();
            DTRena.Clear();
            DTColoso.Clear();
            DTVelazquez.Clear();
            //DTPregot.Clear();
            master.Clear();
            ResetarComponentes();
            ProbarConexiones();
            valva = 0;valre = 0;valve = 0;valco = 0;valpre = 0;
            string proveedor = TB_proveedor.Text;

            if (CHB_bodega.Checked)
            {
                CuentasPendientesBO(proveedor);
                valbo = 1;
            }

            if (CHB_vallarta.Checked)
            {
                CuentasPendientesVA(proveedor);
                valva = 1;
            }

            if (CHB_rena.Checked)
            {
                CuentasPendientesRE(proveedor);
                valre = 1;
            }

            if (CHB_coloso.Checked)
            {
                CuentasPendientesCO(proveedor);
                valco = 1;
            }

            if (CHB_velazquez.Checked)
            {
                CuentasPendientesVE(proveedor);
                valve = 1;
            }

            //if (CHB_pregot.Checked)
            //{
            //    CuentasPendientesPRE(proveedor);
            //    valpre = 1;

            //}

            EstadoCuenta();
            //LIMPIAR DATATABLES
            //DTBodega.Clear();
            //DTVallarta.Clear();
            //DTRena.Clear();
            //DTColoso.Clear();
            //DTVelazquez.Clear();
            //DTPregot.Clear();
            //master.Clear();
            if (DG_datos.RowCount == 0)
            {
                MessageBox.Show("NO HAY REGISTROS DE ESTE PROVEEDOR");
            }




        }

        private void TB_filtro_TextChanged_1(object sender, EventArgs e)
        {
            //if (TB_filtro.Text == "")
            //{
            //    CB_proveedor.SelectedIndex = -1;
            //    DG_datos.DataSource = null;
            //}
            //else
            //{
            //    int index = CB_proveedor.FindString(TB_filtro.Text.ToUpper());
            //    CB_proveedor.SelectedIndex = index;

            //}

        }



        private void DG_datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pagos.Clear();


            string ca = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells["MOVIMIENTO"].Value);
            string compra = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells["IDMOV"].Value);
            DateTime fecha = Convert.ToDateTime(DG_datos.Rows[e.RowIndex].Cells["FECHA_"].Value);
            string idabono = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells["OBSERV"].Value);
            string movimiento = Convert.ToString(DG_datos.Rows[e.RowIndex].Cells["TIPO_DOCUMENTO"].Value);
            MySqlConnection conVa = BDConexicon.VallartaOpen();
            MySqlConnection conRe = BDConexicon.RenaOpen();
            MySqlConnection conVe = BDConexicon.VelazquezOpen();
            MySqlConnection conCo = BDConexicon.ColosoOpen();
           // MySqlConnection conPre = BDConexicon.Papeleria1Open();
            MySqlConnection conBo = BDConexicon.BodegaOpen();

            if (ca.Equals("C"))
            {
                MessageBox.Show("HAZ CLICK SOBRE UN PAGO");
            }
            else
            {
                string query = "SELECT importe,fecha_pago,fecha_efe,tipo FROM rd_desglose_abonos WHERE idabono='" + idabono + "'";
                //string query = "SELECT importe,fecha_pago,fecha_efe,tipo FROM rd_desglose_abonos WHERE compra='" + compra + "'";
                string spei = "SELECT importe,fecha_pago,fecha_efe,tipo,banco,cuenta,clientebancario FROM rd_desglose_abonos WHERE idabono='" + idabono + "'";
                //string spei = "SELECT importe,fecha_pago,fecha_efe,tipo,banco,cuenta,clientebancario FROM rd_desglose_abonos WHERE compra='" + compra + "'";


                if (movimiento.Equals("SPE"))
                {
                    //############################## PAGOS DE bodega #############################################
                    try
                    {
                        MySqlCommand cmdBo = new MySqlCommand(spei, conBo);
                        MySqlDataReader drBO = cmdBo.ExecuteReader();
                        if (drBO.HasRows)
                        {
                            while (drBO.Read())
                            {
                                pagos.Rows.Add(drBO["importe"].ToString(), drBO["fecha_pago"].ToString(), drBO["fecha_efe"].ToString(), drBO["tipo"].ToString(), drBO["banco"].ToString(), drBO["cuenta"].ToString(), drBO["clientebancario"].ToString(), "BODEGA");

                            }

                            drBO.Close();

                        }
                        else
                        {

                        }
                        conBo.Close();
                    }

                    catch (Exception ex)

                    {


                    }
                   



                    // ############################## PAGOS DE VALLLARTA #############################################
                    try
                    {
                        MySqlCommand cmdVa = new MySqlCommand(spei, conVa);
                        MySqlDataReader drVA = cmdVa.ExecuteReader();
                        if (drVA.HasRows)
                        {
                            while (drVA.Read())
                            {
                                pagos.Rows.Add(drVA["importe"].ToString(), drVA["fecha_pago"].ToString(), drVA["fecha_efe"].ToString(), drVA["tipo"].ToString(), drVA["banco"].ToString(), drVA["cuenta"].ToString(), drVA["clientebancario"].ToString(), "VALLARTA");

                            }

                            drVA.Close();

                        }
                        else
                        {

                        }
                        conVa.Close();
                    }

                    catch (Exception ex)

                    {


                    }


                    // ############################## PAGOS DE RENA #############################################
                    try
                    {
                        MySqlCommand cmdRe = new MySqlCommand(spei, conRe);
                        MySqlDataReader drRE = cmdRe.ExecuteReader();
                        if (drRE.HasRows)
                        {
                            while (drRE.Read())
                            {
                                pagos.Rows.Add(drRE["importe"].ToString(), drRE["fecha_pago"].ToString(), drRE["fecha_efe"].ToString(), drRE["tipo"].ToString(), drRE["banco"].ToString(), drRE["cuenta"].ToString(), drRE["clientebancario"].ToString(), "RENA");

                            }

                            drRE.Close();

                        }
                        else
                        {

                        }
                        conRe.Close();
                    }

                    catch (Exception ex)

                    {


                    }

                    // ############################## PAGOS DE VELAZQUEZ #############################################
                    try
                    {
                        MySqlCommand cmdVe = new MySqlCommand(spei, conVe);
                        MySqlDataReader drVE = cmdVe.ExecuteReader();
                        if (drVE.HasRows)
                        {
                            while (drVE.Read())
                            {
                                pagos.Rows.Add(drVE["importe"].ToString(), drVE["fecha_pago"].ToString(), drVE["fecha_efe"].ToString(), drVE["tipo"].ToString(), drVE["banco"].ToString(), drVE["cuenta"].ToString(), drVE["clientebancario"].ToString(), "VELAZQUEZ");

                            }

                            drVE.Close();

                        }
                        else
                        {

                        }
                        conVe.Close();
                    }

                    catch (Exception ex)

                    {


                    }

                    // ############################## PAGOS DE COLOSO #############################################
                    try
                    {
                        MySqlCommand cmdCo = new MySqlCommand(spei, conCo);
                        MySqlDataReader drCO = cmdCo.ExecuteReader();
                        if (drCO.HasRows)
                        {
                            while (drCO.Read())
                            {
                                pagos.Rows.Add(drCO["importe"].ToString(), drCO["fecha_pago"].ToString(), drCO["fecha_efe"].ToString(), drCO["tipo"].ToString(), drCO["banco"].ToString(), drCO["cuenta"].ToString(), drCO["clientebancario"].ToString(), "COLOSO");

                            }

                            drCO.Close();

                        }
                        else
                        {

                        }
                        conCo.Close();
                    }

                    catch (Exception ex)

                    {


                    }

                    // ############################## PAGOS DE PREGOT #############################################
                    //try
                    //{
                    //    MySqlCommand cmdPre = new MySqlCommand(query, conPre);
                    //    MySqlDataReader drPRE = cmdPre.ExecuteReader();
                    //    if (drPRE.HasRows)
                    //    {
                    //        while (drPRE.Read())
                    //        {
                    //            pagos.Rows.Add(drPRE["importe"].ToString(), drPRE["fecha_pago"].ToString(), drPRE["fecha_efe"].ToString(), drPRE["tipo"].ToString(), drPRE["banco"].ToString(), drPRE["cuenta"].ToString(), drPRE["clientebancario"].ToString(), "PREGOT");

                    //        }

                    //        drPRE.Close();

                    //    }
                    //    else
                    //    {

                    //    }
                    //    conPre.Close();
                    //}

                    //catch (Exception ex)

                    //{


                    //}
                }
                else
                {

                    //############################## PAGOS DE bodega #############################################
                    try
                    {
                        MySqlCommand cmdBo = new MySqlCommand(query, conBo);
                        MySqlDataReader drBO = cmdBo.ExecuteReader();
                        if (drBO.HasRows)
                        {
                            while (drBO.Read())
                            {
                                pagos.Rows.Add(drBO["importe"].ToString(), drBO["fecha_pago"].ToString(), drBO["fecha_efe"].ToString(), drBO["tipo"].ToString(), drBO["banco"].ToString(), drBO["cuenta"].ToString(), drBO["clientebancario"].ToString(), "BODEGA");

                            }

                            drBO.Close();

                        }
                        else
                        {

                        }
                        conBo.Close();
                    }

                    catch (Exception ex)

                    {


                    }



                    // ############################## PAGOS DE VALLLARTA #############################################
                    try
                    {
                        MySqlCommand cmdVa = new MySqlCommand(query, conVa);
                        MySqlDataReader drVA = cmdVa.ExecuteReader();
                        if (drVA.HasRows)
                        {
                            while (drVA.Read())
                            {
                                pagos.Rows.Add(drVA["importe"].ToString(), drVA["fecha_pago"].ToString(), drVA["fecha_efe"].ToString(), drVA["tipo"].ToString(), "", "", "", "VALLARTA");

                            }

                            drVA.Close();

                        }
                        else
                        {

                        }
                        conVa.Close();
                    }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    {


                    }


                    // ############################## PAGOS DE RENA #############################################
                    try
                    {
                        MySqlCommand cmdRe = new MySqlCommand(query, conRe);
                        MySqlDataReader drRE = cmdRe.ExecuteReader();
                        if (drRE.HasRows)
                        {
                            while (drRE.Read())
                            {
                                pagos.Rows.Add(drRE["importe"].ToString(), drRE["fecha_pago"].ToString(), drRE["fecha_efe"].ToString(), drRE["tipo"].ToString(), "", "", "", "RENA");

                            }

                            drRE.Close();

                        }
                        else
                        {

                        }
                        conRe.Close();
                    }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    {


                    }

                    // ############################## PAGOS DE VELAZQUEZ #############################################
                    try
                    {
                        MySqlCommand cmdVe = new MySqlCommand(query, conVe);
                        MySqlDataReader drVE = cmdVe.ExecuteReader();
                        if (drVE.HasRows)
                        {
                            while (drVE.Read())
                            {
                                pagos.Rows.Add(drVE["importe"].ToString(), drVE["fecha_pago"].ToString(), drVE["fecha_efe"].ToString(), drVE["tipo"].ToString(), "", "", "", "VELAZQUEZ");

                            }

                            drVE.Close();

                        }
                        else
                        {

                        }
                        conVe.Close();
                    }

                    catch (Exception ex)

                    {


                    }

                    // ############################## PAGOS DE COLOSO #############################################
                    try
                    {
                        MySqlCommand cmdCo = new MySqlCommand(query, conCo);
                        MySqlDataReader drCO = cmdCo.ExecuteReader();
                        if (drCO.HasRows)
                        {
                            while (drCO.Read())
                            {
                                pagos.Rows.Add(drCO["importe"].ToString(), drCO["fecha_pago"].ToString(), drCO["fecha_efe"].ToString(), drCO["tipo"].ToString(), "", "", "", "COLOSO");

                            }

                            drCO.Close();

                        }
                        else
                        {

                        }
                        conCo.Close();
                    }

                    catch (Exception ex)

                    {


                    }

                    // ############################## PAGOS DE PREGOT #############################################
                    //try
                    //{
                    //    MySqlCommand cmdPre = new MySqlCommand(query, conPre);
                    //    MySqlDataReader drPRE = cmdPre.ExecuteReader();
                    //    if (drPRE.HasRows)
                    //    {
                    //        while (drPRE.Read())
                    //        {
                    //            pagos.Rows.Add(drPRE["importe"].ToString(), drPRE["fecha_pago"].ToString(), drPRE["fecha_efe"].ToString(), drPRE["tipo"].ToString(), "", "", "", "PREGOT");

                    //        }

                    //        drPRE.Close();

                    //    }
                    //    else
                    //    {

                    //    }
                    //    conPre.Close();
                    //}

                    //catch (Exception ex)

                    //{


                    //}
                }
                Desglose des = new Desglose(pagos, compra);
                des.Show();
            }

        }




        private void BT_abonos_Click(object sender, EventArgs e)
        {
            if (DG_datos.Rows.Count > 0)
            {
                int filas = DG_datos.RowCount;

                decimal digito = decimal.Parse(DG_datos.Rows[filas - 1].Cells[9].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string s = digito.ToString("G0");
                saldo = Convert.ToDouble(s);

                string prov = TB_proveedor.Text;
                string nombre = CB_proveedor.SelectedItem.ToString();
                Abonos ab = new Abonos(prov, nombre, saldo, usuario,valva,valre,valve,valco);
                ab.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un proveedor y busca su estado de cuenta para poder aplicar un abono");
            }
        }

      



        //private void TB_compra_TextChanged(object sender, EventArgs e)
        //{

        //    // vista = master.DefaultView;
        //    //vista.RowFilter = string.Empty;
        //    //vista.RowFilter = $"COMPRA  LIKE '{TB_compra.Text}%'";
        //    vista.RowFilter = string.Format("convert(COMPRA, 'System.String') Like '%{0}%' ", TB_compra.Text);

        //    DG_datos.DataSource = vista;

        //    //      string condicion = "COMPRA LIKE '"+TB_compra.Text+"'";
        //    //      string sort = "FECHA";

        //    //(DG_datos.DataSource as DataTable).DefaultView.RowFilter = TB_compra.Text;
        //    //      view = new DataView(filtro, condicion, sort, DataViewRowState.CurrentRows);
        //    //      DG_datos.DataSource = view;



        //}
    }
}
