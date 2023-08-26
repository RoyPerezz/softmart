using appSugerencias.Gastos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Controlador
{
    class GastosController
    {
        
        public GastosController()
        {
            
        }


        public static DataTable ConceptosGenerales(string sucursal,string tipo_gasto)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CONCEPTO GRAL", typeof(string));
            string query = "SELECT  DISTINCT CONCEPTOGRAL FROM CONEGRE WHERE TIPO_GASTO='"+tipo_gasto+"' ORDER BY CONCEPTOGRAL";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dt.Rows.Add(dr["CONCEPTOGRAL"].ToString());
            }
            dr.Close();
            return dt;
        }

       
        public List<Gasto> GastosTienda(string sucursal,DateTime fecha,bool respaldo)
        {

            MySqlConnection con = null;
            List<Gasto> lista = new List<Gasto>();
            string query = "SELECT flujo.flujo,flujo.concepto2 as clave,conegre.descrip as concepto,conegre.TIPO_GASTO,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion,conegre.CONCEPTOGRAL FROM" +
                    " flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto where fecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND flujo.concepto<>'CAM' AND flujo.ing_eg = 'E' and flujo.concepto<>'cortz' GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora";

            int m = fecha.Month;
            int año = fecha.Year;

            string mes = FormatoFecha.Mes(m);
            if (respaldo == true)
            {
                con = BDConexicon.RespMultiSuc(sucursal,mes,año); ;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }
            
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Id = Convert.ToInt32(dr["flujo"].ToString()),
                    Concepto = dr["clave"].ToString(),
                    Descripcion = dr["concepto"].ToString(),
                    Importe = Convert.ToDouble(dr["Importe"].ToString()),
                    ConceptoGral = dr["CONCEPTOGRAL"].ToString(),
                   Tipo_egreso = dr["TIPO_GASTO"].ToString()
                };

                lista.Add(gasto);

               
            }

            return lista;


        }


    
        public List<Gasto> BuscarGastos(string sucursal,DateTime fecha,bool respaldo)
        {

            MySqlConnection con = null;
            int mes = Convert.ToInt32(fecha.Month);
            int año = Convert.ToInt32(fecha.Year);
            string nombreMes = FormatoFecha.Mes(mes);

            if (respaldo == true)
            {
                con = BDConexicon.RespMultiSuc(sucursal, nombreMes, año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }
          
            //string query = "select flujo.CONCEPTO,conegre.DESCRIP,flujo.IMPORTE from flujo INNER JOIN conegre on flujo.CONCEPTO = conegre.CONCEPTO where flujo.ING_EG ='E' and flujo.CONCEPTO<>'CAM' WHERE FECHA='2022-07-19'";

            string query = "SELECT flujo.flujo,flujo.concepto,conegre.CONCEPTOGRAL, conegre.DESCRIP,flujo.IMPORTE,flujo.usuario ,flujo.ESTACION,flujo.FECHA FROM flujo INNER JOIN conegre ON flujo.CONCEPTO = conegre.CONCEPTO WHERE flujo.FECHA ='" + fecha.ToString("yyyy-MM-dd") + "' " +
           "AND (flujo.CONCEPTO<>'CAM' AND flujo.CONCEPTO<>'Retir' AND flujo.CONCEPTO<>'RBAN' AND flujo.CONCEPTO<>'RPPP' AND flujo.CONCEPTO<>'CORTZ' AND flujo.CONCEPTO<>'TARJ'  AND flujo.CONCEPTO<>'ALBR' AND flujo.CONCEPTO<>'CGRAL' AND flujo.CONCEPTO<>'CCDMX'  AND flujo.CONCEPTO<>'CINO' AND flujo.CONCEPTO<>'FNZAS'" +
           "AND flujo.CONCEPTO<>'ACCR' AND flujo.CONCEPTO<>'ACR' AND flujo.CONCEPTO<>'CCDIS')";
           MySqlCommand cmd = new MySqlCommand(query,con);
            List<Gasto> listaGastos = new List<Gasto>();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto();
                gasto.Concepto = dr["CONCEPTOGRAL"].ToString();
                gasto.Descripcion = dr["DESCRIP"].ToString();
                gasto.Importe = Convert.ToDouble(dr["IMPORTE"].ToString());
                gasto.Fecha = Convert.ToDateTime(dr["FECHA"].ToString());
                gasto.Ticket = dr["flujo"].ToString();
                gasto.UsuarioAplico = dr["usuario"].ToString();
                gasto.Clave = dr["concepto"].ToString();
                gasto.Caja = dr["ESTACION"].ToString();
              
                listaGastos.Add(gasto);
            }
            dr.Close();
            con.Close();
            return listaGastos;
        }

        public static List<Gasto> BuscarTodosLosGastosMesActual(string sucursal,DateTime inicio,DateTime fin,bool respaldo)
        {
            List<Gasto> listaGastos = new List<Gasto>();

            string query = "SELECT flujo.flujo,flujo.concepto,conegre.CONCEPTOGRAL, conegre.DESCRIP,flujo.IMPORTE,flujo.usuario ,flujo.ESTACION,flujo.FECHA FROM flujo INNER JOIN conegre ON flujo.CONCEPTO = conegre.CONCEPTO WHERE flujo.FECHA BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"' " +
                " and (flujo.CONCEPTO<>'CAM' AND flujo.CONCEPTO<>'Retir' AND flujo.CONCEPTO<>'RBAN' AND flujo.CONCEPTO<>'RPPP' AND flujo.CONCEPTO<>'CORTZ' AND flujo.CONCEPTO<>'TARJ'  AND flujo.CONCEPTO<>'ALBR' AND flujo.CONCEPTO<>'CGRAL' AND flujo.CONCEPTO<>'CGRAL' AND flujo.CONCEPTO<>'CCDMX' AND flujo.CONCEPTO<>'CINO' AND flujo.CONCEPTO<>'FNZAS'" +
           "AND flujo.CONCEPTO<>'ACCR' AND flujo.CONCEPTO<>'ACR' AND flujo.CONCEPTO<>'CCDIS')";

            MySqlConnection con = null;
            int mes = Convert.ToInt32(inicio.Month);
            int año = Convert.ToInt32(inicio.Year);
            string nombreMes = FormatoFecha.Mes(mes);
            if (respaldo == true)
            {
                con = BDConexicon.RespMultiSuc(sucursal, nombreMes, año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Ticket = dr["flujo"].ToString(),
                    Fecha = Convert.ToDateTime(dr["FECHA"].ToString())
                };
                listaGastos.Add(gasto);
            }
            dr.Close();
            con.Close();
            return listaGastos;
        }
        public void GuardarGastos(Gasto gasto,string sucursal,DateTime fecha,string usuario,string encajas,string clave)
        {

            DateTime fechaRegistro = DateTime.Now;
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            string query = "INSERT INTO rd_auditoria_gastos(concepto,descripcion,importe,comentario,rutaFoto,nombreFoto,rutaFoto2,nombreFoto2,rutaFoto3,nombreFoto3,fecha,fechaRegistro,usuario,comentarioRevision,Revision1,numAutorizacion,Revision2,Estado,ticket,enc_cajas,revision,claveEgreso)" +
                "VALUES(?concepto,?descripcion,?importe,?comentario,?rutaFoto,?nombreFoto,?rutaFoto2,?nombreFoto2,?rutaFoto3,?nombreFoto3,?fecha,?fechaRegistro,?usuario,?comentarioRevision,?Revision1,?numAutorizacion,?Revision2,?Estado,?ticket,?enc_cajas,?revision,?claveEgreso) ";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?concepto",gasto.Concepto);
            cmd.Parameters.AddWithValue("?descripcion",gasto.Descripcion);
            cmd.Parameters.AddWithValue("?importe",gasto.Importe);
            cmd.Parameters.AddWithValue("?comentario",gasto.Detalle.ToUpper());

            if (gasto.NombreFoto.Equals(""))
            {
                cmd.Parameters.AddWithValue("?rutaFoto","");
                cmd.Parameters.AddWithValue("?nombreFoto","");
            }
            else
            {
                cmd.Parameters.AddWithValue("?rutaFoto", gasto.RutaFoto);
                cmd.Parameters.AddWithValue("?nombreFoto", gasto.NombreFoto);
            }

            if (String.IsNullOrEmpty(gasto.NombreFoto2))
            {

                cmd.Parameters.AddWithValue("?rutaFoto2", "");
                cmd.Parameters.AddWithValue("?nombreFoto2", "");
            }
            else
            {
                cmd.Parameters.AddWithValue("?rutaFoto2", gasto.RutaFoto2);
                cmd.Parameters.AddWithValue("?nombreFoto2", gasto.NombreFoto2);
            }

            if (String.IsNullOrEmpty(gasto.NombreFoto3))
            {

                cmd.Parameters.AddWithValue("?rutaFoto3", "");
                cmd.Parameters.AddWithValue("?nombreFoto3", "");
            }
            else
            {
                cmd.Parameters.AddWithValue("?rutaFoto3", gasto.RutaFoto3);
                cmd.Parameters.AddWithValue("?nombreFoto3", gasto.NombreFoto3);
            }

            cmd.Parameters.AddWithValue("fecha",fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?fechaRegistro",fechaRegistro.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?usuario",usuario);
            cmd.Parameters.AddWithValue("?comentarioRevision","");
            cmd.Parameters.AddWithValue("?Revision1",0);
            cmd.Parameters.AddWithValue("?numAutorizacion",0);
            cmd.Parameters.AddWithValue("?Revision2",0);
            cmd.Parameters.AddWithValue("?Estado","");
            cmd.Parameters.AddWithValue("?ticket", gasto.Ticket);
            cmd.Parameters.AddWithValue("?enc_cajas", encajas);
            cmd.Parameters.AddWithValue("?revision","SIN REVISAR");
            cmd.Parameters.AddWithValue("?claveEgreso", clave);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }


        public void ActualizarFoto1(int id,string ruta,string nombreFoto,string sucursal)
        {
            string query = "UPDATE rd_auditoria_gastos SET rutaFoto='" + ruta + "', nombrefoto='" + nombreFoto + "' WHERE id=" + id + "";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = null;
            cmd = new MySqlCommand(query, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ActualizarFoto2(int id, string ruta, string nombreFoto, string sucursal)
        {
            string query = "UPDATE rd_auditoria_gastos SET  rutaFoto2='" + ruta + "', nombrefoto2='" + nombreFoto + "' WHERE id=" + id + "";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = null;
            cmd = new MySqlCommand(query, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void ActualizarFoto3(int id, string ruta, string nombreFoto, string sucursal)
        {
            string query = "UPDATE rd_auditoria_gastos SET rutaFoto3='" + ruta + "', nombrefoto3='" + nombreFoto + "' WHERE id=" + id + "";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = null;
            cmd = new MySqlCommand(query, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ActualizarComentario(int id, string sucursal,string comentario)
        {
            string query = "UPDATE rd_auditoria_gastos SET comentario ='"+comentario+"' WHERE id=" + id + "";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = null;
            cmd = new MySqlCommand(query, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        //public void Actualizar(int id,string comentario,string ruta,string nombreFoto,string sucursal,string rutaFoto2,string nombreFoto2,string rutaFoto3,string nombreFoto3)
        //{
            
        //    string query = "UPDATE rd_auditoria_gastos SET comentario='" + comentario.ToUpper() + "', rutaFoto='" + ruta + "', nombrefoto='"+nombreFoto+"',rutaFoto2='"+rutaFoto2+"', nombreFoto2='"+nombreFoto2+"',rutaFoto3='"+rutaFoto3+"',nombreFoto3='"+nombreFoto3+"' WHERE id=" + id + "";
        //    MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
        //    MySqlCommand cmd = null;
        //    cmd = new MySqlCommand(query, con);           
            
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

         public void Actualizar(int actualizarFoto1, int actualizarFoto2, int actualizarFoto3, int actualizarComentario ,int id,string comentario,string ruta,string nombreFoto,string sucursal,string rutaFoto2,string nombreFoto2,string rutaFoto3,string nombreFoto3)
        {

            if (actualizarFoto1 ==1)
            {
                ActualizarFoto1(id,ruta,nombreFoto,sucursal);

            }
            
            if(actualizarFoto2==1){

                ActualizarFoto2(id,rutaFoto2,nombreFoto2,sucursal);
            }

            if (actualizarFoto3==1)
            {
                ActualizarFoto3(id,rutaFoto3,nombreFoto3,sucursal);
            }

            if (actualizarComentario==1)
            {
                ActualizarComentario(id,sucursal,comentario);
            }
        }

        public void ActualizarRevision(int id,string sucursal)
        {
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand("update rd_auditoria_gastos set revision ='CORREGIDO' WHERE id='"+id+"'",con);
            cmd.ExecuteNonQuery();
        }

        public bool ExisteGasto(int id,string sucursal)
        {
            bool respuesta = false;
            string query = "SELECT * FROM rd_auditoria_gastos WHERE id ="+id+"";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                respuesta = true;
            }
            dr.Close();
            return respuesta;
        }

        public DataTable DatosGasto(string sucursal, DateTime fecha)
        {
            string query = "select id,CONCEPTO,descripcion,importe,comentario,rutaFoto,nombreFoto,rutaFoto2,nombreFoto2,rutaFoto3,nombreFoto3,ticket,Estado,revision,comentarioRevision,comentarioRevision2,comentarioSRA,numAutorizacion,usuario,enc_cajas from rd_auditoria_gastos " +
                " where fecha='"+fecha.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);

            return dt;
#pragma warning disable CS0162 // Se detectó código inaccesible
            con.Close();
#pragma warning restore CS0162 // Se detectó código inaccesible
        }

        public DataTable DatosGasto(string sucursal, DateTime inicio, DateTime fin)
        {
            string query = "select id,CONCEPTO,descripcion,importe,comentario,rutaFoto,nombreFoto,rutaFoto2,nombreFoto2,rutaFoto3,nombreFoto3,ticket,Estado,revision,comentarioRevision,comentarioRevision2,comentarioSRA,numAutorizacion,usuario,enc_cajas from rd_auditoria_gastos " +
                " where fecha between '" + inicio.ToString("yyyy-MM-dd") +"' and '"+fin.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            DataTable dt = new DataTable();
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);

            return dt;
#pragma warning disable CS0162 // Se detectó código inaccesible
            con.Close();
#pragma warning restore CS0162 // Se detectó código inaccesible
        }

        public int ObtenerId(string sucursal)
        {
            int id = 0;
            string query = "SELECT MAX(id) AS id FROM rd_auditoria_gastos";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt32(dr["id"].ToString());
            }
            dr.Close();
            con.Close();
            return id;
        }

        public List<Gasto> BuscarGastosGuardados(DateTime fecha, string sucursal)
        {
            List<Gasto> lista = new List<Gasto>();

            string query = "select * from rd_auditoria_gastos where fecha='" + fecha.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {



                Gasto gasto = new Gasto()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    Concepto = dr["concepto"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Detalle = dr["comentario"].ToString(),
                    RutaFoto = dr["rutaFoto"].ToString(),
                    NombreFoto = dr["nombreFoto"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    FechaRegistro = Convert.ToDateTime(dr["fechaRegistro"].ToString()),
                    //UsuarioAplico = dr["usuario"].ToString()
                    UsuarioAplico = "SISTEMAS"
                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }

        public List<Gasto> BuscarGastosGuardados(DateTime inicio,DateTime fin, string sucursal)
        {
            List<Gasto> lista = new List<Gasto>();

            string query = "select * from rd_auditoria_gastos where fecha between'" + inicio.ToString("yyyy-MM-dd") + "' and '"+fin.ToString("yyyy-MM-dd")+"'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {



                Gasto gasto = new Gasto()
                {
                    Id = Convert.ToInt32(dr["id"].ToString()),
                    Concepto = dr["concepto"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Ticket = dr["ticket"].ToString(),
                    Detalle = dr["comentario"].ToString(),
                    RutaFoto = dr["rutaFoto"].ToString(),
                    NombreFoto = dr["nombreFoto"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    FechaRegistro = Convert.ToDateTime(dr["fechaRegistro"].ToString()),
                    //UsuarioAplico = dr["usuario"].ToString()
                    UsuarioAplico = "SISTEMAS"
                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }


        public List<Gasto> DetalleConcetoEgreso(string concepto)
        {
            List<Gasto> lista = new List<Gasto>();
            string query = "SELECT  DESCRIP,CONCEPTOGRAL,TIPO_GASTO FROM conegre WHERE CONCEPTO='"+concepto+"'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Descripcion = dr["DESCRIP"].ToString(),
                    Concepto = dr["CONCEPTOGRAL"].ToString(),
                    Tipo_egreso = dr["TIPO_GASTO"].ToString()
                };

                lista.Add(gasto);
            }
            dr.Close();
            return lista;
        }
        
        public List<Gasto> DesgloseEgresos(string concepto,DateTime fecha,string sucursal,bool check)
        {
            MySqlConnection con =null;
            if (check == true)
            {
                int m = fecha.Month;
                int año = fecha.Year;

                string mes = FormatoFecha.Mes(m);
                    
                con = BDConexicon.RespMultiSuc(sucursal,mes,año);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            List<Gasto> lista = new List<Gasto>();
            string query = "select flujo,concepto,importe " +
                "from flujo " +
                "where concepto ='"+concepto+"' and fecha = '"+fecha.ToString("yyyy-MM-dd")+"'";
           
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Id =Convert.ToInt32(dr["flujo"].ToString()),
                    Concepto = dr["concepto"].ToString(),
                   
                    Importe = Convert.ToDouble(dr["importe"].ToString())
                  
                };

                lista.Add(gasto);
            }
            dr.Close();

            int flujo = 0;
          
            MySqlCommand cmd2 = null;
            MySqlDataReader dr2 = null;
            for (int i = 0; i < lista.Count; i++)
            {
                flujo = lista[i].Id;
                cmd2 = new MySqlCommand("SELECT concepto,descripcion,comentario FROM rd_auditoria_gastos WHERE ticket='" + flujo + "'", con);
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    lista[i].Descripcion = dr2["descripcion"].ToString();
                    lista[i].Detalle = dr2["comentario"].ToString();
                }
                dr2.Close();
            }

            con.Close();

            return lista;
        }

        public bool EliminarFoto(int numFoto,int id,string sucursal)
        {
            bool exito = false;
            string query = "";
            if (numFoto ==1)
            {
                query = "UPDATE rd_auditoria_gastos SET rutaFoto='', nombreFoto='' WHERE  id = " + id + "";

                MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                exito = true;
            }
            else if(numFoto==2)
            {
                query = "UPDATE rd_auditoria_gastos SET rutaFoto2='', nombreFoto2='' WHERE  id = " + id + "";

                MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                exito = true;
            }
            else if(numFoto==3)
            {
                query = "UPDATE rd_auditoria_gastos SET rutaFoto3='', nombreFoto3='' WHERE  id = " + id + "";

                MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                exito = true;
            }
            else
            {

            }

            return exito;
        }

        public List<Gasto> GastosXCorregir(string sucursal,DateTime inicio,DateTime fin)
        {
            DateTime fecha;
            List<Gasto> lista = new List<Gasto>();
            string query = "select fecha, count(id) as gastos_corregir from rd_auditoria_gastos where fecha BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"' and revision = 'CORREGIR' GROUP BY  fecha order by fecha";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fecha = Convert.ToDateTime(dr["fecha"].ToString());
                Gasto gasto = new Gasto()
                {
                    Fecha = fecha,
                    CantGastos = Convert.ToInt32(dr["gastos_corregir"].ToString())
                };
                lista.Add(gasto);
                
            }
            dr.Close();
            con.Close();

            return lista;
        }

        public List<Gasto> CantGastosPendientes(string sucursal,bool check,DateTime fecha)
        {

            int count = 0;

            List<Gasto> lista = new List<Gasto>();
            List<Gasto> lista2 = new List<Gasto>();
            lista = BuscarGastos(sucursal,fecha,check);
            lista2 = BuscarGastosGuardados(fecha,sucursal);


            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista2.Count; j++)
                {
                    if (lista[i].Ticket.Equals(lista2[j].Ticket))
                    {
                        lista.RemoveAt(i);
                    }
                }
                
            }

            return lista;
        }

        public static void ReimprimirTicketEgreso(string claveConcepto,string caja)
        {
            Egreso egreso = null;
            DateTime fecha = DateTime.Now;
            string query = "select * from flujo where CONCEPTO='" + claveConcepto + "' and fecha='" + fecha.ToString("yyyy-MM-dd") + "' and estacion='" + caja + "'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                egreso = new Egreso()
                {
                    Flujo = Convert.ToInt32(dr["flujo"].ToString()),
                    Usuario = dr["usuario"].ToString(),
                    Estacion = dr["estacion"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Hora = dr["hora"].ToString(),
                    Clave = dr["concepto"].ToString(),
                    ConceptoDetalle = "",
                    Importe = Convert.ToDouble(dr["importe"].ToString())
                };
            }

            Ticket ticket = new Ticket();
            //ticket.Logo = PB_logo.Image;
            //ticket.Sucursal = Sucursal();
            ticket.Usuario = egreso.Usuario;
            ticket.Estacion = egreso.Estacion;
            ticket.Flujo = egreso.Flujo.ToString();
            ticket.Fecha = egreso.Fecha.ToString("dd-MM-yyyy");
            ticket.Hora = egreso.Hora;
            ticket.Clave = egreso.Clave;
            ticket.ConceptoDetalle = egreso.ConceptoDetalle;
            ticket.Importe = egreso.Importe;
            ticket.Imprimir(ticket);
        }
       
    }
}
