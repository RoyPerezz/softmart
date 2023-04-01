using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    public class FortmatoEnCajas
    {

     
      
        double egreso = 0;
        double otrosIngresos = 0;
        double vaucher = 0; //ventas con tarjetas
        double efectivo = 0;
        double ventaTotal = 0;
#pragma warning disable CS0414 // El campo 'FortmatoEnCajas.ventaNeta' está asignado pero su valor nunca se usa
        double ventaNeta = 0;
#pragma warning restore CS0414 // El campo 'FortmatoEnCajas.ventaNeta' está asignado pero su valor nunca se usa
        double sobrante = 0;
        double devoluciones = 0;
        double cortez = 0; //diferencia que sale al ejecutar el cortez


 

        //SE ENCARGA DE RETORNAR LA CANTIDAD DE EFECTIVO QUE LAS CAJERAS REPORTAN COMO SOBRANTE
        public double Sobrante(string estacion, string fecha, MySqlConnection con)
        {
            //SE CONSULTA EL INGRESO Y SOLO SE TOMA EN CUENTA EL IMPORTE DEL INGRESO CON CONCEPTO 'SOBRA'
            sobrante = 0;
            string query = "SELECT SUM( Importe ) As `Ingreso`, flujo.concepto2, coningre.descrip FROM flujo INNER JOIN coningre ON flujo.concepto = coningre.concepto WHERE estacion = '" + estacion + "' AND ing_eg = 'I' AND flujo.concepto2 <> 'EFE' AND moneda = 'MN' AND FECHA ='" + fecha + "' GROUP BY flujo.concepto2 ORDER BY flujo.flujo";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["concepto2"].ToString().Equals("SOBRA"))
                {
                    sobrante += Convert.ToDouble(dt.Rows[i]["Ingreso"].ToString());// SE GUARDA EL IMPORTE TOTAL DEL SOBRANTE
                }
            }

            return sobrante;
        }

        //SE ENCARGA DE RETORNAR EL IMPORTE DE LAS VENTAS CON TARJETA DE CREDITO
        public double VentaTarjetas(string estacion, string fecha, MySqlConnection con)
        {
            //SE CONSULTA EL INGRESO PERO SOLO SE TOMA EN CUENTA EL IMPORTE DONDE EL CONCEPTO2 SEA TAR
            vaucher = 0;
            string query = "SELECT SUM( Importe ) As `Ingreso`, flujo.concepto2, coningre.descrip FROM flujo INNER JOIN coningre ON flujo.concepto = coningre.concepto WHERE estacion = '" + estacion + "' AND ing_eg = 'I' AND flujo.concepto2 <> 'EFE' AND moneda = 'MN' AND FECHA ='" + fecha + "' GROUP BY flujo.concepto2 ORDER BY flujo.flujo";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["concepto2"].ToString().Equals("TAR"))
                {
                    vaucher += Convert.ToDouble(dt.Rows[i]["Ingreso"].ToString());// SE GUARDA EL IMPORTE TOTAL DE LAS VENTAS CON TARJETAS
                }
            }

            return vaucher;
            
        }

        //CALCULA Y RETOTNA EL TOTAL DE LOS EGRESOS
        public double CalcularEgreso(string estacion,string fecha, MySqlConnection con)
        {
            //SUMA EL IMPORTE DE TODOS LOS EGRESOS A EXEPCION DEL IMPORTE GENERADO AL REALIZAR CORTEZ
            egreso = 0;
            string query2 = "select sum(importe) as egreso from flujo where estacion='" + estacion + "' AND FECHA='" + fecha + "' AND ING_EG='E' AND CONCEPTO<>'CAM'";
            //string query = "SELECT SUM( Importe ) As `Egreso`, flujo.concepto, conegre.descrip FROM flujo INNER JOIN conegre ON flujo.concepto = conegre.concepto WHERE estacion = '" + estacion + "' AND ing_eg = 'E' AND concepto2 <> 'CAM' AND moneda = 'MN' AND FECHA ='" + fecha + "' GROUP BY flujo.flujo ";
            //MySqlCommand cmd = new MySqlCommand(query, con);
            //DataTable dt = new DataTable();
            //MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            //ad.Fill(dt);



            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (dt.Rows[i]["Egreso"].ToString().Equals("CORTEZ"))
            //    {
            //        //que no sume el importe de cortez
            //    }
            //    else
            //    {
            //        egreso += Convert.ToDouble(dt.Rows[i]["Egreso"].ToString());
            //    }

            //}
          
            try
            {
                MySqlCommand cmd = new MySqlCommand(query2, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    if (dr["egreso"].ToString().Equals(""))
                    {
                        egreso = 0;
                    }
                    else
                    {
                        egreso += Convert.ToDouble(dr["egreso"].ToString());
                    }
                    



                }
                dr.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: "+ex);
            }
            
            return egreso;
        }

        //RETORNA EL IMPORTE TOTAL QUE SE GENERA AL REALIZARLE CORTEZ A ALGUNA CAJA
        public double ImporteCorteZ(string estacion, string fecha, MySqlConnection con)
        {
            //ESTE IMPORTE SE CALCULA APARTE, PARA PODER USARLO EN LA CLASE VentasEnCajas, YA QUE SE LE RESTARÁ AL EGRESO
            cortez = 0;
            string query = "SELECT SUM( Importe ) As `Egreso`, flujo.concepto, conegre.descrip FROM flujo INNER JOIN conegre ON flujo.concepto = conegre.concepto WHERE estacion = '" + estacion + "' AND ing_eg = 'E' AND concepto2 <> 'CAM' AND moneda = 'MN' AND FECHA ='" + fecha + "' GROUP BY flujo.flujo ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["concepto"].ToString().Equals("CORTZ"))
                {
                    cortez += Convert.ToDouble(dt.Rows[i]["Egreso"].ToString());// SE GUARDA EL IMPORTE DEL CORTEZ
                }
               

            }
            return cortez;
        }


        //CALCULA Y RETORNA EL EFECTIVO DISPONIBLE DE CAJA1 Y 2 PARA REPORTE DE CONTABILIDAD
        ArrayList fechas;
        public DataTable TotalEfectivoParaContabilidad( DateTime inicio,DateTime fin, MySqlConnection con)
        {
            //EL EFECTIVO DISPONIBLE ES LA SUMATORIA DEL IMPORTE DE CADA RETIRO

            //string query = "SELECT SUM(IMPORTE) AS RETIRO " +
            //   "FROM FLUJO " +
            //   "WHERE FECHA = '" + fecha.ToString("yyyy-MM-dd") + "'  and ESTACION ='" + estacion + "' AND CONCEPTO='RETIR'";
            //string query2 = "SELECT SUM(Importe) As `Ingreso`, flujo.USUARIO,flujo.HORA FROM flujo INNER JOIN coningre ON flujo.concepto = coningre.concepto WHERE concepto2 = 'TAR' AND estacion = '" + estacion + "' AND ing_eg = 'I' AND flujo.concepto2 <> 'EFE' AND moneda = 'MN' AND FECHA = '" + fecha + "' GROUP BY flujo.FLUJO ORDER BY flujo.flujo";

            DataTable dt = new DataTable();
            dt.Columns.Add("FECHA", typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("IMPORTE", typeof(double));
            dt.Columns.Add("IMPUESTO", typeof(double));
            dt.Columns.Add("TOTAL", typeof(double));
            string aux = "";
            efectivo = 0;
            try
            {
                fechas = new ArrayList();
                for (DateTime dia = inicio; dia <= fin; dia = dia.AddDays(1))
                {
                    aux = Convert.ToString(dia.ToShortDateString());
                    fechas.Add(aux);
                }

               
#pragma warning disable CS0219 // La variable 'tar' está asignada pero su valor nunca se usa
                double tar = 0;
#pragma warning restore CS0219 // La variable 'tar' está asignada pero su valor nunca se usa
                string x = "";
               DateTime fecha;
                MySqlCommand cmd = null;
                MySqlCommand cmd2 = null;
                MySqlDataReader dr = null;
                MySqlDataReader dr2 = null;
                for (int i = 0; i < fechas.Count; i++)
                {
                    fecha = Convert.ToDateTime(fechas[i].ToString());

                    if (fecha >= Convert.ToDateTime("21-12-2022"))
                    {
                        cmd = new MySqlCommand("SELECT SUM(IMPORTE) AS EFECTIVO FROM FLUJO WHERE FECHA='" + fecha.ToString("yyyy-MM-dd") + "' and ESTACION ='CAJA1' AND CONCEPTO='RETIR'", con);
                       
                    }
                    else
                    {
                        cmd = new MySqlCommand("SELECT SUM(IMPORTE) AS EFECTIVO FROM FLUJO WHERE FECHA='" + fecha.ToString("yyyy-MM-dd") + "' and ESTACION IN ('CAJA1','CAJA2') AND CONCEPTO='RETIR'", con);
                    }
                    
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dt.Rows.Add(fechas[i].ToString(),"Pago en Efectivo",0,0,Convert.ToDouble(dr["EFECTIVO"].ToString()));
                    }
                    dr.Close();


                    if (fecha>=Convert.ToDateTime("21-12-2022"))
                    {
                        cmd2 = new MySqlCommand("SELECT SUM(IMPORTE) AS 'TARJETAS' FROM FLUJO WHERE FECHA='" + fecha.ToString("yyyy-MM-dd") + "' AND CONCEPTO2='TAR' AND ESTACION = 'CAJA1'", con);
                    }
                    else
                    {
                        cmd2 = new MySqlCommand("SELECT SUM(IMPORTE) AS 'TARJETAS' FROM FLUJO WHERE FECHA='" + fecha.ToString("yyyy-MM-dd") + "' AND CONCEPTO2='TAR' AND ESTACION in ('CAJA1','CAJA2')", con);
                        
                    }
                     
                   dr2 = cmd2.ExecuteReader();

                    
                        while (dr2.Read())
                        {
                           x = dr2["TARJETAS"].ToString();
                            if (x.Equals(""))
                            {
                                dt.Rows.Add(fechas[i].ToString(), "Pago con Tarjeta", 0, 0, 0);
                            }
                            else
                            {
                                dt.Rows.Add(fechas[i].ToString(), "Pago con Tarjeta", 0, 0, Convert.ToDouble(dr2["TARJETAS"].ToString()));
                            }
                       
                            
                        }
                        
                    
                    
                    dr2.Close();
                }
               
               

               


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex);
                efectivo = 0;
            }



            return dt;
        }



        //CALCULA Y RETORNA EL EFECTIVO DISPONIBLE
        public double TotalEfectivo(string estacion, string fecha, MySqlConnection con)
        {
            //EL EFECTIVO DISPONIBLE ES LA SUMATORIA DEL IMPORTE DE CADA RETIRO
            string query = "SELECT SUM(IMPORTE) AS RETIRO FROM FLUJO WHERE FECHA ='"+fecha+"' AND ESTACION ='"+estacion+"' AND CONCEPTO='RETIR'";
            efectivo = 0;
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, con);
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);
               
                if (dt.Rows.Count==0)
                {
                    efectivo = 0;
                }
                else
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        efectivo += Convert.ToDouble(dt.Rows[i]["RETIRO"]);
                    }
                }

             
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                efectivo = 0;
            }



            return efectivo;
        }

        //CALCULA Y RETORNA LA VENTA TOTAL DEL DIA
        public double VentaTotal(string estacion,string fecha,MySqlConnection con)
        {

            try
            {
                /*
                 "SELECT clients.nombre, SUM(IF(ventas.tipo_doc = 'DV' OR ventas.tipo_doc = 'DEV', IF(partvta.invent <> 0, (partvta.cantidad - partvta.a01), 0), (partvta.cantidad - partvta.a01))) AS cantvend," +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`," +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As `Impuesto`," +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100))) As `Total`," +
                    "SUM(IF(partvta.impuesto > 0, (partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100)), 0)) As `Ventagravada`," +
                    "SUM(IF(partvta.impuesto = 0, (partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (1 + (partvta.impuesto / 100)), 0)) As `VentaNogravada`" +
                    "FROM(partvta INNER JOIN ventas ON ventas.venta = partvta.venta) INNER JOIN clients ON ventas.cliente = clients.cliente WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND moneda = 'MN' AND partvta.usufecha = '"+fecha+"' AND ventas.caja = '"+estacion+"' GROUP BY ventas.cliente ORDER BY cantvend DESC"
                 
                 */


                string query2 = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`," +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As `Impuesto`" +
                    "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '"+fecha+"' AND ventas.caja = '"+estacion+"' AND partvta.impuesto > 0 ";


          
                string nventa = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`    " +
                    "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha + "' AND partvta.impuesto = 0 AND ventas.caja = '" + estacion + "'"; 

                ventaTotal = 0;
                double importe=0, impuesto = 0,Nventa=0;
                
                MySqlCommand cmd = new MySqlCommand(query2, con);
                DataTable dt = new DataTable();
                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                ad.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    importe += Convert.ToDouble(dt.Rows[i]["importe"].ToString());
                    impuesto += Convert.ToDouble(dt.Rows[i]["impuesto"].ToString());
                    //ventaTotal += Convert.ToDouble(dt.Rows[i]["Total"].ToString());
                    ventaTotal = importe + impuesto;
                }

                MySqlCommand cmd2 = new MySqlCommand(nventa, con);
                MySqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    if (DBNull.Value.Equals(dr2["Importe"].ToString()) || dr2["Importe"].ToString().Equals(""))
                    {
                        Nventa = 0;
                    }
                    else
                    {
                        Nventa = Convert.ToDouble(dr2["Importe"].ToString());
                    }
                }
                dr2.Close();

                ventaTotal += Nventa;
                


            }
            catch (Exception ex)
            {

                Console.WriteLine("Error:"+ex);
            }
            




            return ventaTotal;
            
        }

 
        //CALCULA Y RETORNA LA SUMA DE LOS OTROS INGRESOS
        public double OtrosIngresos(string estacion, string fecha, MySqlConnection con)
        {
            //LOS OTROS INGRESOS SON TODOS AQUELLOS INGRESOS QUE NO ES UN INGRESO CONSECUENCIA DE UNA VENTA, COMO EL PAGO DE COMIDA DE LOS EMPLEADOS, PAGO DE FICHA POR PARTE DEL CLIENTE, ETC.
            otrosIngresos = 0;
            string query = "SELECT SUM( Importe ) As `Ingreso`, flujo.concepto2, coningre.descrip FROM flujo INNER JOIN coningre ON flujo.concepto = coningre.concepto WHERE estacion = '"+estacion+"' AND ing_eg = 'I' AND flujo.concepto2 <> 'EFE' AND moneda = 'MN' AND FECHA ='"+fecha+"' GROUP BY flujo.concepto2 ORDER BY flujo.flujo";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //NO SE DEBE TOMAR EN CUENTA, LA VENTA CON TARJETAS Y EL SOBRANTE
                    if (dr["concepto2"].ToString().Equals("TAR")|| dr["concepto2"].ToString().Equals("SOBRA"))
                    {
                        //QUE NO HAGA NADA
                    }
                    else
                    {
                        otrosIngresos += Convert.ToDouble(dr["Ingreso"].ToString());// SE GUARDA EL TOTAL DE LOS OTROS INGRESOS
                    }
                   
                }
               
            }
            else
            {
                otrosIngresos = 0;
            }

            dr.Close();
            return otrosIngresos;
           
        }

        //CALCULA Y RETORNA EL TOTAL DE DEVOLUCIONES
        public double Devoluciones(string estacion, string fecha, MySqlConnection con)
        {
            //UNA DEVOLUCION OCURRE CUANDO UN CLIENTE REGRESA UN PRODUCTO, ESTO SIGNIFICA QUE SE LE DEBE DEVOLVER EL DINERO
            string query = "SELECT SUM(vales.importe) As `Importe` FROM vales WHERE  incluirencorte = 1 AND estacion = '" + estacion + "' AND FECHA ='" + fecha + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    if (dr["Importe"]!=DBNull.Value)
                    {
                        devoluciones = Convert.ToDouble(dr["Importe"].ToString());

                    }
                    else
                    {
                        devoluciones = 0;
                    }

                   

                }
                dr.Close();
            }
            else
            {
                devoluciones = 0;
            }
               
            
            
            
          
            return devoluciones;
        }

        //CONSULTA Y RETORNA LOS RETIROS DE EFECTIVOS REALIZADOS A LAS CAJAS
        public DataTable RetirosCaja(string estacion, string fecha, MySqlConnection con)
        {
            //LA INFORMACIÓN DE LOS RETIROS SE RETORNA EN UN DATATABLE
            string query = "SELECT IMPORTE,HORA,USUARIO FROM FLUJO WHERE FECHA ='" + fecha + "' AND ESTACION ='" + estacion + "' AND CONCEPTO='RETIR'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);

            return dt;
            
        }

        //CONSULTA Y RETORNA LOS EGRESOS REALIZADOS EN LAS CAJAS
        public DataTable EgresosCaja(string estacion, string fecha, MySqlConnection con)
        {
            //RETORNA CADA UNO DE LOS EGRESOS EN UN DATATABLE
            string query = "SELECT SUM( Importe ) As `Egreso`, flujo.concepto, conegre.descrip, flujo.hora,flujo.usuario  FROM flujo INNER JOIN conegre ON flujo.concepto = conegre.concepto WHERE estacion = '" + estacion+"' AND ing_eg = 'E' AND concepto2 <> 'CAM' AND moneda = 'MN' AND FECHA ='"+fecha+"' GROUP BY flujo.flujo";

            MySqlCommand cmd = new MySqlCommand(query,con);
            DataTable dt = new DataTable();

            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);

            return dt;
        }

        public DataTable IngresoTarjetas(string estacion, string fecha, MySqlConnection con)
        {
            string query = "SELECT SUM(Importe) As `Ingreso`, flujo.USUARIO,flujo.HORA FROM flujo INNER JOIN coningre ON flujo.concepto = coningre.concepto WHERE concepto2 = 'TAR' AND estacion = '"+estacion+"' AND ing_eg = 'I' AND flujo.concepto2 <> 'EFE' AND moneda = 'MN' AND FECHA = '"+fecha+"' GROUP BY flujo.FLUJO ORDER BY flujo.flujo";
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);

            return dt;
        }

        public DataTable EgresoTarjetas(string estacion, string fecha, MySqlConnection con)
        {
            string query = "SELECT SUM( Importe ) As `Egreso`,flujo.usuario ,  flujo.hora FROM flujo INNER JOIN conegre ON flujo.concepto = conegre.concepto WHERE flujo.concepto ='TARJ' AND estacion = '" + estacion + "' AND ing_eg = 'E' AND concepto2 <> 'CAM' AND moneda = 'MN' AND FECHA ='" + fecha + "' GROUP BY flujo.flujo";
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);

            return dt;
        }



    }
}
