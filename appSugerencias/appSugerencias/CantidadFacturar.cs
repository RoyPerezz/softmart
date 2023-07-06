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
    public partial class CantidadFacturar : Form
    {
        double excedente = 0;
#pragma warning disable CS0414 // El campo 'CantidadFacturar.excedenteTARJ' está asignado pero su valor nunca se usa
        double excedenteTARJ = 0;
#pragma warning restore CS0414 // El campo 'CantidadFacturar.excedenteTARJ' está asignado pero su valor nunca se usa
        string usuario = "";
        ArrayList ventasFacturadas = new ArrayList();
        ArrayList facturasEfe = new ArrayList();
        ArrayList facturasTar = new ArrayList();
        double devEFE = 0, devTAR = 0;
        public CantidadFacturar(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        string sucursal = "";
        
        public void FacturadoPorDia()
        {
            MySqlConnection conexion = BDConexicon.conectar();
        }


       

        public int NumMes(string mes)
        {
            int num = 0;

            switch(mes)
            {
                case "ENERO": num = 1;
                break;
                case "FEBRERO": num = 2;
                break;
                case "MARZO": num = 3;
                break;
                case "ABRIL": num = 4;
                break;
                case "MAYO":  num = 5;
                break;
                case "JUNIO": num = 6;
                break;
                case "JULIO": num = 7;
                break;
                case "AGOSTO": num = 8;
                break;
                case "SEPTIEMBRE":
                    num = 9;
                    break;
                case "OCTUBRE":
                    num = 10;
                    break;
                case "NOVIEMBRE":
                    num =11;
                    break;
                case "DICIEMBRE":
                    num = 12;
                    break;
                default: num = 0;
                 break;
            }

            return num;
        }

        public string Mes(int num)
        {
            string mes = "";

            if (num == 1)
            {
                mes = "ENE";
            }

            if (num == 2)
            {
                mes = "FEB";
            }

            if (num == 3)
            {
                mes = "MAR";
            }

            if (num == 4)
            {
                mes = "ABR";
            }

            if (num == 5)
            {
                mes = "MAY";
            }

            if (num == 6)
            {
                mes = "JUN";
            }

            if (num == 7)
            {
                mes = "JUL";
            }

            if (num == 8)
            {
                mes = "AGO";
            }

            if (num == 9)
            {
                mes = "SEP";
            }

            if (num == 10)
            {
                mes = "OCT";
            }

            if (num == 11)
            {
                mes = "NOV";
            }

            if (num == 12)
            {
                mes = "DIC";
            }
            return mes;
        }

        public string AcortarMes(string mes)
        {
            string m = "";

            if (mes.Equals("ENERO"))
            {
                m = "ENE";
            }
            if (mes.Equals("FEBRERO"))
            {
                m = "FEB";
            }
            if (mes.Equals("MARZO"))
            {
                m = "MAR";
            }
            if (mes.Equals("ABRIL"))
            {
                m = "ABR";
            }
            if (mes.Equals("MAYO"))
            {
                m = "MAY";
            }
            if (mes.Equals("JUNIO"))
            {
                m = "JUN";
            }
            if (mes.Equals("JULIO"))
            {
                m = "JUL";
            }
            if (mes.Equals("AGOSTO"))
            {
                m = "AGO";
            }
            if (mes.Equals("SEPTIEMBRE"))
            {
                m = "SEP";
            }
            if (mes.Equals("OCTUBRE"))
            {
                m = "OCT";
            }
            if (mes.Equals("NOVIEMBRE"))
            {
                m = "NOV";
            }
            if (mes.Equals("DICIEMBRE"))
            {
                m = "DIC";
            }
            return m;
        }
        
        public double VentaTotal(DateTime fecha)
        {

            excedente = 0;
          
            string sucursal = "";

            sucursal = SucursalSeleccionada();

            if (sucursal.Equals("VALLARTA"))
            {
                if (fecha.ToString("yyyy-MM-dd").Equals("2022-08-31"))
                {
                    excedente = 100000;
                }


                if (fecha.ToString("yyyy-MM-dd").Equals("2022-12-03"))
                {
                    excedente = 35000;
                }

               
                if (fecha.ToString("yyyy-MM-dd").Equals("2023-01-05"))
                {
                    excedente = 20000;
                }
                if (fecha.ToString("yyyy-MM-dd").Equals("2023-01-06"))
                {
                    excedente = 20000;
                }


            }


            if (sucursal.Equals("VELAZQUEZ"))
            {
                if (fecha.ToString("yyyy-MM-dd").Equals("2023-01-05"))
                {
                    excedente = 65000;
                }
            }

            if (sucursal.Equals("COLOSO"))
            {
                if (fecha.ToString("yyyy-MM-dd").Equals("2022-08-27"))
                {
                    excedente = 28000;
                }

                if (fecha.ToString("yyyy-MM-dd").Equals("2022-08-28"))
                {
                    excedente = 90000;
                }

                if (fecha.ToString("yyyy-MM-dd").Equals("2022-08-29"))
                {
                    excedente = 20000;
                }
            }

            
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {
                con = BDConexicon.ConexionSucursal(SucursalSeleccionada());
            }
            else
            {
                con = BDConexicon.conectar();
            }


            double importe = 0, impuesto = 0;
            double Nventa = 0;
            double Nventa2 = 0;

            //ventatotal1
            string query2 = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`," +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As `Impuesto`" +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND ventas.caja = 'CAJA1' AND partvta.impuesto > 0 ";

            //nventa1
            string nventa = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`    " +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND partvta.impuesto = 0 AND ventas.caja = 'CAJA1'";

            //ventatotal2
            string queryCaja2 = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`," +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As `Impuesto`" +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND ventas.caja = 'CAJA2' AND partvta.impuesto > 0 ";

            //nventa2
            string nventa2 = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`    " +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND partvta.impuesto = 0 AND ventas.caja = 'CAJA2'";
            double ventaTotal1 =0 ,ventaTotal2=0;
            try
            {


               


         
                if (CBX_mes_anterior.Checked == true)
                {

                    int num = NumMes(CB_mes.SelectedItem.ToString());
                    MySqlConnection conectar = BDConexicon.RespMultiSuc(SucursalSeleccionada(), Mes(num),Convert.ToInt32(CB_año.SelectedItem.ToString()));
                    //######################################### VENTAS CAJA1 ################################################
                    MySqlCommand cmd0 = new MySqlCommand(query2, conectar);
                    DataTable dt0 = new DataTable();
                    MySqlDataAdapter ad0 = new MySqlDataAdapter(cmd0);
                    ad0.Fill(dt0);

                    for (int i = 0; i < dt0.Rows.Count; i++)
                    {
                        //    importe += Convert.ToDouble(dt0.Rows[i]["Importe"].ToString());
                        //    impuesto += Convert.ToDouble(dt0.Rows[i]["Impuesto"].ToString());
                        //    //ventaTotal += Convert.ToDouble(dt.Rows[i]["Total"].ToString());


                        if (DBNull.Value.Equals(dt0.Rows[i]["Importe"].ToString()) || dt0.Rows[i]["Importe"].ToString().Equals(""))
                        {
                            importe = 0;
                        }
                        else
                        {
                            importe += Convert.ToDouble(dt0.Rows[i]["Importe"].ToString());
                        }

                        if (DBNull.Value.Equals(dt0.Rows[i]["Impuesto"].ToString()) || dt0.Rows[i]["Importe"].ToString().Equals(""))
                        {
                            impuesto = 0;
                        }
                        else
                        {
                            impuesto += Convert.ToDouble(dt0.Rows[i]["Impuesto"].ToString());
                        }
                        ventaTotal1 = importe + impuesto;
                    }

                    MySqlCommand cmd20 = new MySqlCommand(nventa, conectar);
                    MySqlDataReader dr0 = cmd20.ExecuteReader();



                    while (dr0.Read())
                    {
                        if (DBNull.Value.Equals(dr0["Importe"].ToString()) || dr0["Importe"].ToString().Equals(""))
                        {
                            Nventa = 0;
                        }
                        else
                        {
                            Nventa = Convert.ToDouble(dr0["Importe"].ToString());
                        }
                    }

                    dr0.Close();
                    ventaTotal1 += Nventa;
                    //#############################################################################################################

                    //DateTime f = Convert.ToDateTime("2022-05-09");
                    DateTime f = DateTime.Now; // a partir de estas fechas es que se comienza a acumular las ventas de la caja 2 en el reporte
                    if (SucursalSeleccionada().ToString().Equals("VALLARTA"))
                    {
                        f = Convert.ToDateTime("2022-05-10");
                    }
                    if (SucursalSeleccionada().ToString().Equals("RENA"))
                    {
                        f = Convert.ToDateTime("2022-05-09");
                    }
                    if (SucursalSeleccionada().ToString().Equals("VELAZQUEZ"))
                    {
                        f = Convert.ToDateTime("2022-05-11");
                    }
                    if (SucursalSeleccionada().ToString().Equals("COLOSO"))
                    {
                        f = Convert.ToDateTime("2022-05-10");
                    }

                    if (Convert.ToDateTime(fecha.ToString("yyyy-MM-dd")) >= Convert.ToDateTime(f.ToString("yyy-MM-dd")))
                    {

                        if (Convert.ToDateTime(fecha.ToString("yyyy-MM-dd")) > Convert.ToDateTime("2022-12-21"))// para que las ventas de la caja2 no se sumen a las ventas apartir de 21 de dic 2022
                        {
                            ventaTotal2 = 0; Nventa2 = 0;
                        }else
                        {
                            //######################################### VENTAS CAJA2 ################################################
                            MySqlCommand cmdC2 = new MySqlCommand(queryCaja2, conectar);
                            DataTable dtC2 = new DataTable();
                            MySqlDataAdapter adC2 = new MySqlDataAdapter(cmdC2);
                            adC2.Fill(dtC2);
                            double importe2 = 0, impuesto2 = 0;
                            try
                            {
                                for (int i = 0; i < dtC2.Rows.Count; i++)
                                {
                                    //importe2 += Convert.ToDouble(dtC2.Rows[i]["Importe"].ToString());
                                    //impuesto2 += Convert.ToDouble(dtC2.Rows[i]["Impuesto"].ToString());
                                    if (DBNull.Value.Equals(dtC2.Rows[i]["Importe"].ToString()) || dtC2.Rows[i]["Importe"].ToString().Equals(""))
                                    {
                                        importe2 = 0;
                                    }
                                    else
                                    {
                                        importe2 += Convert.ToDouble(dtC2.Rows[i]["Importe"].ToString());
                                    }

                                    if (DBNull.Value.Equals(dtC2.Rows[i]["Impuesto"].ToString()) || dtC2.Rows[i]["Importe"].ToString().Equals(""))
                                    {
                                        impuesto2 = 0;
                                    }
                                    else
                                    {
                                        impuesto2 += Convert.ToDouble(dtC2.Rows[i]["Impuesto"].ToString());
                                    }
                                    ventaTotal2 = importe2 + impuesto2;
                                }
                            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                            {


                            }

                            MySqlCommand cmdN2 = new MySqlCommand(nventa2, conectar);
                            MySqlDataReader drN2 = cmdN2.ExecuteReader();



                            while (drN2.Read())
                            {
                                if (DBNull.Value.Equals(drN2["Importe"].ToString()) || drN2["Importe"].ToString().Equals(""))
                                {
                                    Nventa2 = 0;
                                }
                                else
                                {
                                    Nventa2 = Convert.ToDouble(drN2["Importe"].ToString());
                                }
                            }

                            drN2.Close();
                            ventaTotal2 += Nventa2;
                            //#############################################################################################################
                        }

                    }




                    conectar.Close();
                }
                else
                {

                    // ################### VENTAS CAJA1 #####################################
                    MySqlCommand cmd = new MySqlCommand(query2, con);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dt);
                  
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            if (DBNull.Value.Equals(dt.Rows[i]["Importe"].ToString()) || dt.Rows[i]["Importe"].ToString().Equals(""))
                            {
                                importe = 0;
                            }
                            else
                            {
                                importe += Convert.ToDouble(dt.Rows[i]["Importe"].ToString());
                            }

                            if (DBNull.Value.Equals(dt.Rows[i]["Impuesto"].ToString()) || dt.Rows[i]["Importe"].ToString().Equals(""))
                            {
                                impuesto = 0;
                            }
                            else
                            {
                                impuesto += Convert.ToDouble(dt.Rows[i]["Impuesto"].ToString());
                            }
                            ventaTotal2 = importe + impuesto;


                            //importe += Convert.ToDouble(dt.Rows[i]["Importe"].ToString());
                            //impuesto += Convert.ToDouble(dt.Rows[i]["Impuesto"].ToString());
                            //ventaTotal += Convert.ToDouble(dt.Rows[i]["Total"].ToString());
                            ventaTotal1 = importe + impuesto;
                        

                        MySqlCommand cmd2 = new MySqlCommand(nventa, con);
                        MySqlDataReader dr = cmd2.ExecuteReader();



                        while (dr.Read())
                        {
                            if (DBNull.Value.Equals(dr["Importe"].ToString()) || dr["Importe"].ToString().Equals(""))
                            {
                                Nventa = 0;
                            }
                            else
                            {
                                Nventa = Convert.ToDouble(dr["Importe"].ToString());
                            }
                        }

                        dr.Close();

                        ventaTotal1 += Nventa;
                    }
                   
                    // ###########################################################################################################
                    DateTime f = DateTime.Now; // a partir de estas fechas es que se comienza a acumular las ventas de la caja 2 en el reporte
                    if (SucursalSeleccionada().ToString().Equals("VALLARTA"))
                    {
                        f = Convert.ToDateTime("2022-05-10");
                    }
                    if (SucursalSeleccionada().ToString().Equals("RENA"))
                    {
                        f = Convert.ToDateTime("2022-05-09");
                    }
                    if (SucursalSeleccionada().ToString().Equals("VELAZQUEZ"))
                    {
                        f = Convert.ToDateTime("2022-05-11");
                    }
                    if (SucursalSeleccionada().ToString().Equals("COLOSO"))
                    {
                        f = Convert.ToDateTime("2022-05-10");
                    }


                    if (Convert.ToDateTime(fecha.ToString("yyyy-MM-dd")) >= f)
                    {

                        if (Convert.ToDateTime(fecha.ToString("yyyy-MM-dd"))>Convert.ToDateTime("2022-12-21"))// para que las ventas de la caja2 no se sumen a las ventas apartir de 21 de dic 2022
                        {
                            ventaTotal2 = 0; Nventa2=0;
                        }
                        else
                        {
                            // ################### VENTAS CAJA2 #####################################
                            MySqlCommand cmd3 = new MySqlCommand(queryCaja2, con);
                            DataTable dt2 = new DataTable();
                            MySqlDataAdapter ad2 = new MySqlDataAdapter(cmd3);
                            ad2.Fill(dt2);
                            double importe2 = 0, impuesto2 = 0;
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {


                                //ventaTotal += Convert.ToDouble(dt.Rows[i]["Total"].ToString());

                                if (DBNull.Value.Equals(dt2.Rows[i]["Importe"].ToString()) || dt2.Rows[i]["Importe"].ToString().Equals(""))
                                {
                                    importe2 = 0;
                                }
                                else
                                {
                                    importe2 += Convert.ToDouble(dt2.Rows[i]["Importe"].ToString());
                                }

                                if (DBNull.Value.Equals(dt2.Rows[i]["Impuesto"].ToString()) || dt2.Rows[i]["Importe"].ToString().Equals(""))
                                {
                                    impuesto2 = 0;
                                }
                                else
                                {
                                    impuesto2 += Convert.ToDouble(dt2.Rows[i]["Impuesto"].ToString());
                                }
                                ventaTotal2 = importe2 + impuesto2;
                            }

                            MySqlCommand cmd4 = new MySqlCommand(nventa2, con);
                            MySqlDataReader dr2 = cmd4.ExecuteReader();



                            while (dr2.Read())
                            {
                                if (DBNull.Value.Equals(dr2["Importe"].ToString()) || dr2["Importe"].ToString().Equals(""))
                                {
                                    Nventa2 = 0;
                                }
                                else
                                {
                                    Nventa2 = Convert.ToDouble(dr2["Importe"].ToString());
                                }
                            }

                            dr2.Close();


                            if (SucursalSeleccionada().ToString().Equals("RENA") && fecha == Convert.ToDateTime("2022-05-09"))
                            {
                                ventaTotal2 = 5256.40;
                            }
                            else
                            {
                                ventaTotal2 += Nventa2;
                            }



                            // ###########################################################################################################

                        }

                        con.Close();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la fecha " +fecha+":" + ex );
            }





            return ((ventaTotal1 + ventaTotal2) - excedente);

            //return (ventaTotal1 + ventaTotal2);

        }

        public double IngresoTarjetas(DateTime fecha)
        {
            DateTime f = DateTime.Now; // a partir de estas fechas es que se comienza a acumular las ventas de la caja 2 en el reporte

            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            double tarjetas = 0 ,tarjetasC2=0;
            string query = "select sum(importe) as tarjetas from flujo where concepto2 ='TAR' AND FECHA ='" + fecha.ToString("yyyy-MM-dd") + "' AND ESTACION='CAJA1'";
            string query2 = "select sum(importe) as tarjetas from flujo where concepto2 ='TAR' AND FECHA ='" + fecha.ToString("yyyy-MM-dd") + "' AND ESTACION='CAJA2'";


            string sucursalSeleccionada = SucursalSeleccionada();
            if (CBX_mes_anterior.Checked == true)
            {
                int num = NumMes(CB_mes.SelectedItem.ToString());
                MySqlConnection conectar = BDConexicon.RespMultiSuc(SucursalSeleccionada(), Mes(num), Convert.ToInt32(CB_año.SelectedItem.ToString()));



                MySqlCommand cmd0 = new MySqlCommand(query, conectar);
                MySqlDataReader dr0 = cmd0.ExecuteReader();
                while (dr0.Read())
                {

                    if (dr0["tarjetas"].ToString().Equals(""))
                    {
                        tarjetas = 0;
                    }
                    else
                    {
                        tarjetas = Convert.ToDouble(dr0["tarjetas"].ToString());
                    }

                }
                dr0.Close();
               
                if (sucursalSeleccionada.Equals("VALLARTA"))
                {
                    f = Convert.ToDateTime("2022-05-10");
                }
                if (sucursalSeleccionada.Equals("RENA"))
                {
                    f = Convert.ToDateTime("2022-05-09");
                }
                if (sucursalSeleccionada.Equals("VELAZQUEZ"))
                {
                    f = Convert.ToDateTime("2022-05-11");
                }
                if (sucursalSeleccionada.Equals("COLOSO"))
                {
                    f = Convert.ToDateTime("2022-05-10");
                }

                if (fecha >= f)
                {


                    if (fecha == Convert.ToDateTime("2022-06-23")) //se necesita que en este día no se sume la ventas de caja2 en tarjeta
                    {

                    }
                    else
                    {
                        MySqlCommand cmd2 = new MySqlCommand(query2, conectar);
                        MySqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {

                            if (dr2["tarjetas"].ToString().Equals(""))
                            {
                                tarjetasC2 = 0;
                            }
                            else
                            {
                                tarjetasC2 = Convert.ToDouble(dr2["tarjetas"].ToString());
                            }

                        }
                        dr2.Close();
                    }


                }
                else
                {
                    tarjetasC2 = 0;
                }


            }
            else
            {
                if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
                {
                    con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
                }
                else
                {
                    con = BDConexicon.conectar();
                }

                

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr["tarjetas"].ToString().Equals(""))
                    {
                        tarjetas = 0;
                    }
                    else
                    {
                        tarjetas = Convert.ToDouble(dr["tarjetas"].ToString());
                    }

                }
                dr.Close();

               
                if (sucursalSeleccionada.Equals("VALLARTA"))
                {
                    f = Convert.ToDateTime("2022-05-10");
                }
                if (sucursalSeleccionada.Equals("RENA"))
                {
                    f = Convert.ToDateTime("2022-05-09");
                }
                if (sucursalSeleccionada.Equals("VELAZQUEZ"))
                {
                    f = Convert.ToDateTime("2022-05-11");
                }
                if (sucursalSeleccionada.Equals("COLOSO"))
                {
                    f = Convert.ToDateTime("2022-05-10");
                }

                if (fecha >= f)
                {
                    //MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    //MySqlDataReader dr2 = cmd2.ExecuteReader();
                    //while (dr2.Read())
                    //{

                    //    if (dr2["tarjetas"].ToString().Equals(""))
                    //    {
                    //        tarjetasC2 = 0;
                    //    }
                    //    else
                    //    {
                    //        tarjetasC2 = Convert.ToDouble(dr2["tarjetas"].ToString());
                    //    }

                    //}
                    //dr2.Close();




                    if (fecha == Convert.ToDateTime("2022-06-23")&& sucursalSeleccionada.Equals("VALLARTA")) //se necesita que en este día no se sume la ventas de caja2 en tarjeta
                    {

                    }
                    else
                    {
                        MySqlCommand cmd2 = new MySqlCommand(query2, con);
                        MySqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {

                            if (dr2["tarjetas"].ToString().Equals(""))
                            {
                                tarjetasC2 = 0;
                            }
                            else
                            {
                                tarjetasC2 = Convert.ToDouble(dr2["tarjetas"].ToString());
                            }

                        }
                        dr2.Close();
                    }
                    //MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    //MySqlDataReader dr2 = cmd2.ExecuteReader();
                    //while (dr2.Read())
                    //{

                    //    if (dr2["tarjetas"].ToString().Equals(""))
                    //    {
                    //        tarjetasC2 = 0;
                    //    }
                    //    else
                    //    {
                    //        tarjetasC2 = Convert.ToDouble(dr2["tarjetas"].ToString());
                    //    }

                    //}
                    //dr2.Close();
                }
                else
                {
                    tarjetasC2 = 0;
                }
            }


            return (tarjetas + tarjetasC2);
        }

        public double DepositoPana(double ventaTotal,double ventanilla,double dep_cliente,double tarj)
        {
            double pana = 0;

            pana =  (ventaTotal - ventanilla - dep_cliente-tarj);
            return pana;
           
        }

        double dev_EFE = 0,dev_TAR=0;

        public void VentasDv(DateTime fecha)
        {
            string sucursalSeleccionada = SucursalSeleccionada();

            MySqlConnection con = null;

            if (CBX_mes_anterior.Checked == true)
            {
              
                int mes = fecha.Month;
                int año = fecha.Year;

                string sucursal = "";

                

                string m = Mes(mes);

                con = BDConexicon.RespMultiSuc(sucursalSeleccionada, m, año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }

            string consulta = "SELECT ventas.importe ,ventas.impuesto , ventas.OrigenDev,flujo.concepto2 " +
                "FROM ventas inner join flujo on ventas.OrigenDev = flujo.venta " +
                "where ventas.USUFECHA = '" + fecha.ToString("yyyy-MM-dd") + "' and ventas.TIPO_DOC = 'DV' AND(ventas.CAJA = 'CAJA1' OR ventas.CAJA = 'CAJA2')GROUP BY ventas.OrigenDev";
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //devoluciones.Rows.Add(dr["total"].ToString(),dr["OrigenDev"].ToString(),dr["concepto2"].ToString());

                if (dr["concepto2"].ToString().Equals("EFE"))
                {
                    devEFE += Convert.ToDouble(dr["importe"].ToString()) + Convert.ToDouble(dr["impuesto"].ToString());
                }

                if (dr["concepto2"].ToString().Equals("TAR"))
                {
                    devTAR += Convert.ToDouble(dr["importe"].ToString()) + Convert.ToDouble(dr["impuesto"].ToString());
                }

               


            }



            //Descuento por exceso de ventas  cambio 1/2
            string f = "";
            if (tienda.Equals("COLOSO"))
            {
                f = fecha.ToString("yyyy-MM-dd");

                if (f.Equals("2022-08-27"))
                {
                    dev_EFE = devEFE;
                    dev_TAR = devTAR;
                }
                if (f.Equals("2022-08-28"))
                {
                    dev_EFE = devEFE;
                    dev_TAR = devTAR;
                }
                if (f.Equals("2022-08-29"))
                {
                    dev_EFE = devEFE;
                    dev_TAR = devTAR;
                }
            }


            if (tienda.Equals("VALLARTA"))
            {
                f = fecha.ToString("yyyy-MM-dd");

                if (f.Equals("2022-08-31"))
                {
                    dev_EFE = devEFE;
                    dev_TAR = devTAR;
                }
            }
            dr.Close();
            con.Close();
        }


        public void Calcular()

        {

            



            string patron = Patron(Empresa());
            LB_patron.Text = patron;
            double ventaTotal = 0;
            double facturacion = 0;
            double facturaGlobal = 0;
            double efectivo = 0;
            double tarj = 0;
            double pana = 0;
            double depVentanilla = 0;
            double totalEfectivo = 0;
           
            double depCliente = 0;
            DateTime fecha = DateTime.Now;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {


                fecha = Convert.ToDateTime(DG_tabla.Rows[i].Cells[0].Value);
               
                ventaTotal = Convert.ToDouble(DG_tabla.Rows[i].Cells["TOTAL_VENTAS"].Value);
                facturacion = Convert.ToDouble(DG_tabla.Rows[i].Cells["T_FAC_CLIENTES"].Value);
                tarj = Convert.ToDouble(DG_tabla.Rows[i].Cells["BAUCHER"].Value);

                facturaGlobal = ventaTotal - facturacion;
                DG_tabla.Rows[i].Cells["FACTURA_GLOBAL"].Value = facturaGlobal;

               

                VentasDv(Convert.ToDateTime(DG_tabla.Rows[i].Cells[0].Value));

             

                DG_tabla.Rows[i].Cells["TARJETA"].Value = ((tarj - Convert.ToDouble(DG_tabla.Rows[i].Cells["FAC_TAR"].Value)-devTAR)/1.16);

                depCliente = DepositoCliente(patron, Convert.ToDateTime(DG_tabla.Rows[i].Cells[0].Value.ToString()));
                DG_tabla.Rows[i].Cells["DEPOSITOS"].Value = depCliente;

                depVentanilla = Convert.ToDouble(DG_tabla.Rows[i].Cells[2].Value);

                pana = ventaTotal - tarj - depCliente - depVentanilla;

                DG_tabla.Rows[i].Cells["DEPOSITO_PANA"].Value = pana;

                totalEfectivo = Convert.ToDouble(DG_tabla.Rows[i].Cells["DEPOSITO_VENTANILLA"].Value)+ Convert.ToDouble(DG_tabla.Rows[i].Cells["DEPOSITOS"].Value) + Convert.ToDouble(DG_tabla.Rows[i].Cells["DEPOSITO_PANA"].Value);

                DG_tabla.Rows[i].Cells["VENTAS_EFE"].Value = totalEfectivo;

                efectivo = Convert.ToDouble(DG_tabla.Rows[i].Cells["VENTAS_EFE"].Value) - Convert.ToDouble(DG_tabla.Rows[i].Cells["FAC_EFE"].Value);
                efectivo = efectivo / 1.16;
                DG_tabla.Rows[i].Cells["EFECTIVO"].Value = efectivo;
                dev_TAR = 0;
                dev_EFE = 0;
                devEFE = 0;
                devTAR = 0;
            }

           
        }

        public double TotalFacturacion(DateTime fecha)
        {
            string sucursalSeleccionada = SucursalSeleccionada();
            double facturacion = 0;
            string consulta = "select total, no_ticket  from facturacion where fecha BETWEEN '"+fecha.ToString("yyyy-MM-dd 00:00:00")+ "' and '" + fecha.ToString("yyyy-MM-dd 23:59:59") + "' and rfccliente <> 'XAXX010101000'";
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            else
            {
                con = BDConexicon.conectar();
            }
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                if (dr["total"].ToString().Equals(""))
                {
                    facturacion = 0;
                }
                else
                {
                    facturacion += Convert.ToDouble(dr["total"].ToString());
                    ventasFacturadas.Add(dr["no_ticket"].ToString());
                }
                
            }

            SepararFacturas(ventasFacturadas);// este metodo separa las ventas facturas, en efectivo y tarjeta
            dr.Close();
            con.Close();
            return facturacion;
        }

        public void SepararFacturas(ArrayList ventasFacturadas)
        {
            MySqlConnection con = null;
            string sucursalSeleccionada = SucursalSeleccionada();
            if (CBX_mes_anterior.Checked==true)
            {

                string mes = AcortarMes(CB_mes.SelectedItem.ToString());
                con = BDConexicon.RespMultiSuc(sucursalSeleccionada, mes,Convert.ToInt32(CB_año.SelectedItem.ToString()));
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            for (int i = 0; i < ventasFacturadas.Count; i++)
            {
                cmd = new MySqlCommand("select concepto2 from flujo where venta ='" + ventasFacturadas[i]+"'",con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["concepto2"].ToString().Equals("EFE"))
                    {
                        facturasEfe.Add(ventasFacturadas[i].ToString());
                    }

                    if (dr["concepto2"].ToString().Equals("TAR"))
                    {
                        facturasTar.Add(ventasFacturadas[i].ToString());
                    }


                }
                dr.Close();
            }
        }

        public double TotalFacEfe(ArrayList ventasEfectivo)
        {
            string sucursalSeleccionada = SucursalSeleccionada();
            MySqlConnection con = null;
            if (CBX_mes_anterior.Checked == true)
            {

                string mes = AcortarMes(CB_mes.SelectedItem.ToString());
                con = BDConexicon.RespMultiSuc(sucursalSeleccionada, mes, Convert.ToInt32(CB_año.SelectedItem.ToString()));
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            double total = 0;
            for (int i = 0; i < ventasEfectivo.Count; i++)
            {
                cmd = new MySqlCommand("select total from facturacion where no_ticket ='"+ ventasEfectivo[i].ToString()+ "'  and rfccliente<>'XAXX010101000'", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    total += Convert.ToDouble(dr["total"].ToString());
                }
                dr.Close();
            }


           
            con.Close();
            return total;
        }

        public double TotalFacTar(ArrayList ventasEfectivo)
        {
            string sucursalSeleccionada = SucursalSeleccionada();
            MySqlConnection con = null;
            if (CBX_mes_anterior.Checked == true)
            {

                string mes = AcortarMes(CB_mes.SelectedItem.ToString());
                con = BDConexicon.RespMultiSuc(sucursalSeleccionada, mes, Convert.ToInt32(CB_año.SelectedItem.ToString()));
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            double total = 0;
            for (int i = 0; i < ventasEfectivo.Count; i++)
            {
                cmd = new MySqlCommand("select total from facturacion where no_ticket ='" + ventasEfectivo[i].ToString() + "' and rfccliente<>'XAXX010101000'", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    total += Convert.ToDouble(dr["total"].ToString());
                }
                dr.Close();
            }
            con.Close();
            return total;
        }

        public string Empresa()
        {
            string sucursalSeleccionada = SucursalSeleccionada();
            string empresa = "";
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            else
            {
                con = BDConexicon.conectar();
            }
            string consulta = "select EMPRESA from econfig";
            MySqlCommand cmd = new MySqlCommand(consulta, con);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                empresa = dr["EMPRESA"].ToString();
            }
            dr.Close();
            con.Close();
            return empresa;
        }

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


        public string Patron(string empresa)
        {
            string patron = "";

            if (empresa.Equals("OSMART VALLARTA"))
            {
                patron = "MARICELA LOPEZ LORENZO";
            }

            if (empresa.Equals("OSMART RENACIMIENTO"))
            {
                patron = "GEORGINA LAGUNAS ESCOBEDO";
            }

            if (empresa.Equals("OSMART VELAZQUEZ"))
            {
                patron = "MIGUEL ANGEL REZA FLORES";
            }

            if (empresa.Equals("OSMART COLOSO"))
            {
                patron = "DANIELA LOPEZ RAMIREZ";
            }



            return patron;
        }

        public double DepositoCliente(string patron,DateTime fecha)
        {
            string sucursalSeleccionada = SucursalSeleccionada();
            double deposito = 0;
            string consulta = "select sum(importe) as deposito from rd_pagos_enc_cajas where nomprov='"+patron+"' and fecha_pago = '"+fecha.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            else
            {
                con = BDConexicon.conectar();
            }
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            
          
          

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                deposito = 0;
                cmd = new MySqlCommand(consulta, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["deposito"].ToString().Equals(""))
                    {
                        deposito = 0;
                    }
                    else
                    {
                        deposito += Convert.ToDouble(dr["deposito"].ToString());
                    }

                   
                }
                dr.Close();
            }
           
            con.Close();


            return deposito;
        }


        public void DepositoVentanilla()
        {

            string sucursalSeleccionada = SucursalSeleccionada();
            DateTime fecha;
#pragma warning disable CS0219 // La variable 'valor' está asignada pero su valor nunca se usa
            bool valor = false;
#pragma warning restore CS0219 // La variable 'valor' está asignada pero su valor nunca se usa
            int estado = 0;
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {

                if (CBX_mes_anterior.Checked == true)
                {
                    int num = NumMes(CB_mes.SelectedItem.ToString());
                    con = BDConexicon.RespMultiSuc(sucursalSeleccionada, Mes(num), Convert.ToInt32(CB_año.SelectedItem.ToString()));
                }
                else
                {
                    con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
                }



               
            }
            else
            {
                con = BDConexicon.conectar();
            }
            MySqlCommand cmd = null;
            MySqlDataReader dr =null;
            DataGridViewCheckBoxCell check = null;
            

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                check = new DataGridViewCheckBoxCell();
                fecha = Convert.ToDateTime(DG_tabla.Rows[i].Cells[0].Value.ToString());
                cmd = new MySqlCommand("select fecha,importe,estado from rd_deposito_ventanilla where fecha='" +fecha.ToString("yyyy-MM-dd") + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DG_tabla.Rows[i].Cells["DEPOSITO_VENTANILLA"].Value = Convert.ToDouble(dr["importe"].ToString());
                    estado = Convert.ToInt32(dr["estado"].ToString());

                    
                }
                dr.Close();
            }

            
        }

        public DataGridViewCheckBoxCell estadoFactura(DateTime fecha)
        {
            string sucursalSeleccionada = SucursalSeleccionada();
            DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
            int valor = 0;
            string consulta = "Select estado from rd_deposito_ventanilla where fecha ='"+fecha.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            else
            {
                con = BDConexicon.conectar();
            }
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                valor = Convert.ToInt32(dr["estado"].ToString());

                if (valor ==1)
                {
                    check.ThreeState = true;
                }
                else
                {
                    check.ThreeState = false;
                }
            }
            return check;
        }

        public DataGridViewCheckBoxCell Depositado(DateTime fecha)
        {
            string sucursalSeleccionada = SucursalSeleccionada();
            DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
            int valor = 0;
            string consulta = "Select depositado from rd_deposito_ventanilla where fecha ='" + fecha.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            string empresa = "";

            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("FINANZAS"))
            {


                if (CBX_mes_anterior.Checked == true)
                {
                    int num = NumMes(CB_mes.SelectedItem.ToString());
                    con = BDConexicon.RespMultiSuc(sucursalSeleccionada, Mes(num), Convert.ToInt32(CB_año.SelectedItem.ToString()));
                }
                else
                {
                    con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
                }

            }
            else
            {

                if (CBX_mes_anterior.Checked == true)
                {

                    if (sucursal.Equals("OSMART VALLARTA"))
                    {
                        empresa = "VALLARTA";
                    }

                    if (sucursal.Equals("OSMART RENACIMIENTO"))
                    {
                        empresa = "RENA";
                    }

                    if (sucursal.Equals("OSMART VELAZQUEZ"))
                    {
                        empresa = "VELAZQUEZ";
                    }

                    if (sucursal.Equals("OSMART COLOSO"))
                    {
                        empresa = "COLOSO";
                    }

                    int num = NumMes(CB_mes.SelectedItem.ToString());
                    con = BDConexicon.RespMultiSuc(empresa, Mes(num), Convert.ToInt32(CB_año.SelectedItem.ToString()));
                }
                else
                {
                    con = BDConexicon.conectar();

                }
                
            }

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                valor = Convert.ToInt32(dr["depositado"].ToString());

                if (valor == 1)
                {
                    check.ThreeState = true;
                }
                else
                {
                    check.ThreeState = false;
                }
            }
            return check;
        }


        public double VentasEfectivo(DateTime fecha)
        {

            string sucursalSeleccionada = SucursalSeleccionada();
            double total = 0;
            double cambio = 0;
            
            string consulta = " SELECT SUM( Importe ) As `Ingreso`, flujo.concepto2, coningre.descrip " +
                "FROM flujo INNER JOIN coningre ON flujo.concepto = coningre.concepto " +
                "WHERE (estacion = 'CAJA1' or estacion = 'CAJA2') AND ing_eg = 'I' AND FECHA='" + fecha.ToString("yyyy-MM-dd") + "' AND flujo.concepto2 = 'EFE' AND moneda = 'MN' GROUP BY flujo.concepto2";

            string consulta2 = " SELECT SUM( Importe ) As `Egreso`, flujo.concepto, conegre.descrip " +
                "FROM flujo INNER JOIN conegre ON flujo.concepto = conegre.concepto " +
                "WHERE (estacion = 'CAJA1' or estacion = 'CAJA2') AND ing_eg = 'E' AND FECHA='" + fecha.ToString("yyyy-MM-dd") + "'AND flujo.concepto2 = 'CAM' AND moneda = 'MN' GROUP BY flujo.concepto";
            MySqlConnection con = null;

            if (CBX_mes_anterior.Checked == true)
            {

                string mes = AcortarMes(CB_mes.SelectedItem.ToString());
                con = BDConexicon.RespMultiSuc(sucursalSeleccionada, mes, Convert.ToInt32(CB_año.SelectedItem.ToString()));
            }
            else
            {
                con = BDConexicon.conectar();
            }

          

            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                total = Convert.ToDouble(dr["Ingreso"].ToString());
            }
            dr.Close();

            MySqlCommand cmd2 = new MySqlCommand(consulta2, con);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cambio = Convert.ToDouble(dr2["Egreso"].ToString());
            }
            dr2.Close();


            return (total - cambio) - excedente;
        }


        public string SucursalSeleccionada()
        {
            string sucursal = "";
            if (RB_va.Checked==true)
            {
                sucursal = "VALLARTA";
                tienda = "VALLARTA";
            }

            if (RB_re.Checked == true)
            {
                sucursal = "RENA";
                tienda = "RENA";
            }

            if (RB_ve.Checked == true)
            {
                sucursal = "VELAZQUEZ";
                tienda = "VELAZQUEZ";
            }
            if (RB_co.Checked == true)
            {
                sucursal = "COLOSO";
                tienda = "COLOSO";
            }

            return sucursal;
        }


        private void BT_buscar_Click(object sender, EventArgs e)
        {

            string sucursalSeleccionada = SucursalSeleccionada();
            double ventaTotal = 0;

            double depVentanilla = 0;

            double depCliente = 0;
            double tarj = 0;

            double pana = 0;

            double facturacion = 0;
            DataTable fechas = new DataTable();
            fechas.Columns.Add("FECHAS",typeof(string));
            MySqlConnection con = null;
           string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            string empresa = "";
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {


                if (CBX_mes_anterior.Checked==true)
                {
                    int num = NumMes(CB_mes.SelectedItem.ToString());
                    con = BDConexicon.RespMultiSuc(sucursalSeleccionada, Mes(num),Convert.ToInt32(CB_año.SelectedItem.ToString()));
                }
                else
                {
                    con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
                }
               
            }
            else
            {

                if (CBX_mes_anterior.Checked == true)
                {

                    if (sucursal.Equals("OSMART VALLARTA"))
                    {
                        empresa = "VALLARTA";
                    }

                    if (sucursal.Equals("OSMART RENACIMIENTO"))
                    {
                        empresa = "RENA";
                    }

                    if (sucursal.Equals("OSMART VELAZQUEZ"))
                    {
                        empresa = "VELAZQUEZ";
                    }

                    if (sucursal.Equals("OSMART COLOSO"))
                    {
                        empresa = "COLOSO";
                    }

                    int num = NumMes(CB_mes.SelectedItem.ToString());
                    con = BDConexicon.RespMultiSuc(empresa, Mes(num), Convert.ToInt32(CB_año.SelectedItem.ToString()));
                }
                else
                {
                    con = BDConexicon.conectar();
                }
                
            }


           
            string mes = CB_mes.SelectedItem.ToString();
            int numMes = NumMes(mes);
            string area = AreaTrabajo();
            double facEfe = 0;
            double facTar = 0;
            double totalEfectivo = 0;
            DG_tabla.Rows.Clear();

            DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
            DataGridViewCheckBoxCell checkDep = new DataGridViewCheckBoxCell();


            string consulta = "select distinct fecha from flujo where MONTH(fecha)="+numMes+" and YEAR(fecha)="+CB_año.SelectedItem.ToString()+" order by fecha";
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = null;

           dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fechas.Rows.Add(dr["fecha"].ToString());
            }
            dr.Close();
            DateTime fechaTabla;
          
            for (int i = 0; i < fechas.Rows.Count; i++)
            {

                fechaTabla = Convert.ToDateTime(fechas.Rows[i][0].ToString());
                ventaTotal = Convert.ToDouble(VentaTotal(Convert.ToDateTime(fechas.Rows[i]["FECHAS"].ToString())));
                tarj = Convert.ToDouble(IngresoTarjetas(Convert.ToDateTime(fechas.Rows[i]["FECHAS"].ToString())));
                facturacion = TotalFacturacion(Convert.ToDateTime(fechas.Rows[i]["FECHAS"].ToString()));
                //totalEfectivo = VentasEfectivo(Convert.ToDateTime(fechas.Rows[i]["FECHAS"].ToString()));
               
                facEfe = TotalFacEfe(facturasEfe);
                if (fechaTabla == Convert.ToDateTime("2023-03-05"))
                {
                    facEfe = 0;
                }
                facTar = TotalFacTar(facturasTar);
                check = estadoFactura(Convert.ToDateTime(fechas.Rows[i]["FECHAS"].ToString()));
                checkDep = Depositado(Convert.ToDateTime(fechas.Rows[i]["FECHAS"].ToString()));



                
                DG_tabla.Rows.Add(fechaTabla.ToString("yyyy-MM-dd"), ventaTotal, 0, depCliente, 0,checkDep.ThreeState, facEfe, facTar, facturacion, totalEfectivo, tarj,0, 0, 0, 0, check.ThreeState);
                     DG_tabla.Rows[i].Visible = false; //oculto las filas
               

                ventasFacturadas.Clear();
                facturasEfe.Clear();
                facturasTar.Clear();
                
            }





          

          
            DepositoVentanilla();
            Calcular();


            // mostrar filas
            for (int i = 0; i < fechas.Rows.Count; i++)
            {

                
                DG_tabla.Rows[i].Visible = true;



            }

            DG_tabla.Columns[1].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[3].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[4].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[8].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[6].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[7].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[9].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[10].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[11].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[12].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[13].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[14].DefaultCellStyle.Format = "C2";

            DG_tabla.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DG_tabla.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            DG_tabla.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[13].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[14].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;




            if (area.Equals("SISTEMAS")|| area.Equals("CXPAGAR") || area.Equals("ADMON GRAL") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {
                DG_tabla.Columns[2].ReadOnly = false;
            }else
            {
                DG_tabla.Columns[1].ReadOnly = true;
                DG_tabla.Columns[2].ReadOnly = true;
                DG_tabla.Columns[3].ReadOnly = true;
                DG_tabla.Columns[4].ReadOnly = true;
                DG_tabla.Columns[5].ReadOnly = true;
                DG_tabla.Columns[6].ReadOnly = true;
                DG_tabla.Columns[7].ReadOnly = true;
                DG_tabla.Columns[9].ReadOnly = true;
                DG_tabla.Columns[10].ReadOnly = true;
                DG_tabla.Columns[11].ReadOnly = true;
                DG_tabla.Columns[12].ReadOnly = true;
                DG_tabla.Columns[13].ReadOnly = true;
            }


           

        }


        public bool FechaExiste(DateTime fecha)
        {
            bool respuesta = false;
            string sucursalSeleccionada = SucursalSeleccionada();
            string consulta = "select * from rd_deposito_ventanilla where fecha='´"+fecha.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {
                con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
            }
            else
            {
                con = BDConexicon.conectar();
            }
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                respuesta = true;
            }

            dr.Close();

            return respuesta;
        }


        private void BT_guardar_Click(object sender, EventArgs e)
        {
            string sucursalSeleccionada = SucursalSeleccionada();
            DateTime fecha;
            bool existe = false;
            double importe = 0;
            bool estado = false;
            bool depositado = false;
            int valor = 0,valor1=0;
            string consulta = "INSERT INTO rd_deposito_ventanilla(fecha,importe,usuario,depositado)VALUES(?fecha,?importe,?usuario,?depositado)";

            MySqlConnection con = null;
            string areaTrabajo = "";
            areaTrabajo = AreaTrabajo();
            string empresa = "";
            if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL") || areaTrabajo.Equals("CONTAB") || areaTrabajo.Equals("SOPORTE") || areaTrabajo.Equals("FINANZAS"))
            {


                if (CBX_mes_anterior.Checked == true)
                {
                    int num = NumMes(CB_mes.SelectedItem.ToString());
                    con = BDConexicon.RespMultiSuc(sucursalSeleccionada, Mes(num), Convert.ToInt32(CB_año.SelectedItem.ToString()));
                }
                else
                {
                    con = BDConexicon.ConexionSucursal(sucursalSeleccionada);
                }

            }
            else
            {

                if (CBX_mes_anterior.Checked == true)
                {

                    if (sucursal.Equals("OSMART VALLARTA"))
                    {
                        empresa = "VALLARTA";
                    }

                    if (sucursal.Equals("OSMART RENACIMIENTO"))
                    {
                        empresa = "RENA";
                    }

                    if (sucursal.Equals("OSMART VELAZQUEZ"))
                    {
                        empresa = "VELAZQUEZ";
                    }

                    if (sucursal.Equals("OSMART COLOSO"))
                    {
                        empresa = "COLOSO";
                    }

                    int num = NumMes(CB_mes.SelectedItem.ToString());
                    con = BDConexicon.RespMultiSuc(empresa, Mes(num), Convert.ToInt32(CB_año.SelectedItem.ToString()));
                }
                else
                {
                    con = BDConexicon.conectar();
                }

            }
            MySqlCommand cmd = null;

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                fecha = Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value.ToString());
                importe = Convert.ToDouble(DG_tabla.Rows[i].Cells["DEPOSITO_VENTANILLA"].Value.ToString());
                estado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["FACTURA_ELABORADA"].Value);
                depositado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["DEPOSITADO_"].Value);
                valor = 0;

                if (estado == true)
                {
                    valor = 1;
                }

                if (estado ==false)
                {
                    valor = 0;
                }

                if (depositado == true)
                {
                    valor1 = 1;
                }

                if (depositado == false)
                {
                    valor1 = 0;
                }

                string sucursal = SucursalSeleccionada();

                
               
                existe = FechaExiste(fecha);
                if (existe==true)
                {
                    MySqlCommand actualizar = new MySqlCommand("UPDATE rd_deposito_ventanilla SET importe=" + importe + ", estado=" + valor + ", depositado="+valor1+" WHERE fecha='" + fecha.ToString("yyyy-MM-dd")+"'",con);
                    actualizar.ExecuteNonQuery();

                   
                }
                else
                {
                    cmd = new MySqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("?fecha", Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value.ToString()));
                    cmd.Parameters.AddWithValue("?importe", DG_tabla.Rows[i].Cells["DEPOSITO_VENTANILLA"].Value.ToString());
                    cmd.Parameters.AddWithValue("?usuario", usuario);
                    cmd.Parameters.AddWithValue("?depositado", valor1);
                    cmd.ExecuteNonQuery();
                }




                //Solo se guarda si el usuario es del depto. de sistemas, cuentas por pagar o administracion gral, ya que las enc de cajas solo marcan que ya hicieron la factura global
                if (areaTrabajo.Equals("SISTEMAS") || areaTrabajo.Equals("CXPAGAR") || areaTrabajo.Equals("ADMON GRAL"))
                {
                    Auditoria.Auditoria_cantidad_facturar(usuario, fecha.ToString("yyyy-MM-dd"), importe, sucursal);
                }

               
            }
            con.Close();
            MessageBox.Show("Se han guardado los cambios");
        }


        private void colorFila(DataGridView datagrid)
        {
             foreach (DataGridViewRow row in datagrid.Rows)
             {
                 if (Convert.ToBoolean(datagrid.Rows[row.Index].Cells["FACTURA_ELABORADA"].Value) == true)
                 {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                 }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
                }

              
                



            }
        }

        private void colorDeposito(DataGridView datagrid)
        {
            foreach (DataGridViewRow row in datagrid.Rows)
            {
               
                if (Convert.ToBoolean(datagrid.Rows[row.Index].Cells["DEPOSITADO_"].Value) == true)
                {

                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.ForeColor = Color.White;
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.BackColor = Color.Red;
                }
                else if(Convert.ToBoolean(datagrid.Rows[row.Index].Cells[12].Value) == true)
                {
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.ForeColor = Color.Black;
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.BackColor = Color.Yellow;
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.SelectionBackColor = Color.SeaGreen;

                }
                else
                {
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.ForeColor = Color.Black;
                    datagrid.Rows[row.Index].Cells["DEPOSITO_PANA"].Style.BackColor = Color.White;
                }




            }
        }

        private void DG_tabla_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            colorFila(DG_tabla);
            colorDeposito(DG_tabla);
        }



        string tienda = "";
        private void CantidadFacturar_Load(object sender, EventArgs e)
        {
            string area = AreaTrabajo();
            string consulta = "select EMPRESA from econfig";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(consulta, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sucursal = dr["EMPRESA"].ToString();
            }
            dr.Close();

            if (area.Equals("SISTEMAS") || area.Equals("CXPAGAR") || area.Equals("ADMON GRAL") ||area.Equals("CONTAB") || area.Equals("SOPORTE") || area.Equals("FINANZAS"))
            {
                //CB_sucursal.Visible = true;
                //CB_sucursal.Items.Add("VALLARTA");
                //CB_sucursal.Items.Add("RENA");
                //CB_sucursal.Items.Add("VELAZQUEZ");
                //CB_sucursal.Items.Add("COLOSO");
                RB_va.Enabled = true;
                RB_re.Enabled = true;
                RB_ve.Enabled = true;
                RB_co.Enabled = true;
                DG_tabla.Columns["DEPOSITADO_"].Visible = true;
            }
            else
            {
                //CB_sucursal.Visible = false;
                DG_tabla.Columns["DEPOSITADO_"].Visible = false;
                if (sucursal.Equals("OSMART VALLARTA"))
                {
                    RB_va.Enabled = true;
                    RB_va.Checked = true;
                    RB_re.Enabled = false;
                    RB_ve.Enabled = false;
                    RB_co.Enabled = false;
                    tienda = "VALLARTA";
                }

                if (sucursal.Equals("OSMART RENACIMIENTO"))
                {
                    RB_va.Enabled = false;
                    RB_re.Enabled = true;
                    RB_re.Checked = true;                  
                    RB_ve.Enabled = false;
                    RB_co.Enabled = false;
                    tienda = "RENA";
                }

                if (sucursal.Equals("OSMART VELAZQUEZ"))

                {
                    RB_va.Enabled = false;
                    RB_re.Enabled = false;
                    RB_ve.Enabled = true;
                    RB_ve.Checked = true;
                    RB_co.Enabled = false;
                    tienda = "VELAZQUEZ";
                }

                if (sucursal.Equals("OSMART COLOSO"))
                {
                    RB_va.Enabled = false;
                    RB_re.Enabled = false;
                    RB_ve.Enabled = false;
                    RB_co.Enabled = true;
                    RB_co.Checked = true;
                    tienda = "COLOSO";
                }
            }


            //DG_tabla.Columns["FECHA"].DisplayIndex = 0;
            //DG_tabla.Columns["TOTAL_VENTAS"].DisplayIndex = 1;
            //DG_tabla.Columns["DEPOSITO_VENTANILLA"].DisplayIndex = 2;
            //DG_tabla.Columns["DEPOSITOS"].DisplayIndex = 3;
            //DG_tabla.Columns["DEPOSITO_PANA"].DisplayIndex = 4;
            //DG_tabla.Columns.Add("FAC_EFE", "FACTURADO EFE");
            //DG_tabla.Columns["FAC_EFE"].DisplayIndex = 5;



            //DG_tabla.Columns.Add("FAC_TAR", "FACTURADO TAR");
          




        }


        //Exportar a excel
        private void button1_Click(object sender, EventArgs e)
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


            excel.Cells.Range["B6:M36"].NumberFormat = "$#,##0.00";


            excel.Visible = true;
        }

    }
}
