using appSugerencias.Gastos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Controlador
{
    class RevisionGastosController
    {

        public List<Gasto> Buscar(DateTime fecha, string sucursal)
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
                    ComentarioRevision = dr["comentarioRevision"].ToString(),

                    Revision1 = Convert.ToInt32(dr["Revision1"].ToString()),
                    NumAutorizacion = dr["numAutorizacion"].ToString(),
                    Revision2 = Convert.ToInt32(dr["Revision2"].ToString()),
                    UsuarioAplico = dr["usuario"].ToString(),
                    RutaFoto2 = dr["rutaFoto2"].ToString(),
                    RutaFoto3 = dr["rutaFoto3"].ToString(),
                    Revision = dr["revision"].ToString()
                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }

        public List<Gasto> BuscarXFechas(DateTime inicio, DateTime fin, string sucursal,bool check)
        {
            MySqlConnection con = null;

            string mes = FormatoFecha.Mes(inicio.Month);
            if (check==true)
            {
                con = BDConexicon.RespMultiSuc(sucursal,mes,inicio.Year);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

            List<string> flujo = new List<string>();
            string query = "select flujo.flujo as TICKET,conegre.TIPO_GASTO AS TIPO_GASTO,conegre.CONCEPTOGRAL AS CONCEPTOGRAL,conegre.concepto AS CONCEPTO,conegre.descrip AS CONCEPTODETALLE, flujo.importe AS IMPORTE,flujo.fecha AS FECHA from conegre inner join flujo on conegre.CONCEPTO = flujo.CONCEPTO " +
                "where flujo.ING_EG = 'E' AND flujo.fecha between '"+inicio.ToString("yyyy-MM-dd")+"'and '"+fin.ToString("yyyy-MM-dd")+"' and(flujo.concepto <> 'CAM' AND flujo.CONCEPTO <> 'RETIR' AND flujo.CONCEPTO <> 'TARJ' AND flujo.CONCEPTO <> 'CORTZ' AND flujo.CONCEPTO <> 'ALBR' AND flujo.CONCEPTO <> 'CGRAL' AND flujo.CONCEPTO <> 'RBAN'" +
                "AND flujo.CONCEPTO <> 'RPPP' AND flujo.CONCEPTO <> 'CINO' AND flujo.CONCEPTO <> 'CCDMX' AND flujo.CONCEPTO <> 'FNZAS' AND flujo.CONCEPTO <> 'ACCR'AND flujo.CONCEPTO <> 'ACR' AND flujo.CONCEPTO <> 'CCDIS')" +
                "ORDER BY flujo.FECHA";

            List<Gasto> lista = new List<Gasto>();

            //string query = "select * from rd_auditoria_gastos  where fecha between'" + inicio.ToString("yyyy-MM-dd") + "' and '"+fin.ToString("yyyy-MM-dd")+"'";
            //string query = "select  ag.Id as Id, c.TIPO_GASTO as TIPO_GASTO, ag.concepto as concepto, ag.descripcion as descripcion,ag.importe as importe,ag.comentario as comentario,ag.usuario as usuario,ag.fecha as fecha,ag.comentarioRevision as comentarioRevision,ag.comentarioRevision2 as comentarioRevision2,ag.comentarioSRA as comentarioSRA," +
            //    "ag.numAutorizacion as numAutorizacion,ag.rutaFoto as rutaFoto,ag.rutaFoto2 as rutaFoto2,ag.rutaFoto3 as rutaFoto3,ag.enc_cajas as enc_cajas,ag.revision as revision,ag.fechaRegistro as fechaRegistro,ag.Revision1 as Revision1,ag.Revision2 as Revision2,ag.revision as revision, ag.ticket as ticket" +
            //    " from rd_auditoria_gastos ag inner join conegre c on ag.claveEgreso = c.CONCEPTO WHERE ag.fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'";
            
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {



                Gasto gasto = new Gasto()
                {
                   
                    Concepto = dr["CONCEPTOGRAL"].ToString(),
                    Descripcion = dr["CONCEPTODETALLE"].ToString(),
                    Importe = Convert.ToDouble(dr["IMPORTE"].ToString()),
                   
                    Fecha = Convert.ToDateTime(dr["FECHA"].ToString()),
                    
                    Tipo_egreso = dr["TIPO_GASTO"].ToString(),
                    Ticket = dr["TICKET"].ToString()
                    
                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }


        public List<Gasto> BuscarXFechas(DateTime inicio, DateTime fin, string sucursal)
        {
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);

           
           

            List<Gasto> lista = new List<Gasto>();

          
            string query = "select  ag.Id as Id, c.TIPO_GASTO as TIPO_GASTO, ag.concepto as concepto, ag.descripcion as descripcion,ag.importe as importe,ag.comentario as comentario,ag.usuario as usuario,ag.fecha as fecha,ag.comentarioRevision as comentarioRevision,ag.comentarioRevision2 as comentarioRevision2,ag.comentarioSRA as comentarioSRA," +
                "ag.numAutorizacion as numAutorizacion,ag.rutaFoto as rutaFoto,ag.rutaFoto2 as rutaFoto2,ag.rutaFoto3 as rutaFoto3,ag.enc_cajas as enc_cajas,ag.revision as revision,ag.fechaRegistro as fechaRegistro,ag.Revision1 as Revision1,ag.Revision2 as Revision2,ag.revision as revision, ag.ticket as ticket" +
                " from rd_auditoria_gastos ag inner join conegre c on ag.claveEgreso = c.CONCEPTO WHERE ag.fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' order by ag.fecha";

            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {



                Gasto gasto = new Gasto()
                {
                    Id = Convert.ToInt32(dr["Id"].ToString()),
                    RutaFoto = dr["rutaFoto"].ToString(),
                    RutaFoto2 = dr["rutaFoto2"].ToString(),
                    RutaFoto3 = dr["rutaFoto3"].ToString(),
                    Concepto = dr["concepto"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    NumAutorizacion = dr["numAutorizacion"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    UsuarioAplico = dr["usuario"].ToString(),
                    Tipo_egreso = dr["TIPO_GASTO"].ToString(),
                    Revision = dr["revision"].ToString(),
                    Encajas = dr["enc_cajas"].ToString(),
                    Detalle = dr["comentario"].ToString(),
                    ComentarioRevision = dr["comentarioRevision"].ToString(),
                    ComentarioRevision2 = dr["comentarioRevision2"].ToString(),
                    ComentarioSRA = dr["comentarioSRA"].ToString(),
                    Ticket = dr["ticket"].ToString()

                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }





        public void ActualizarGastoRevision(int id, string sucursal, string comentario, string comentario2, string revision)
        {
            string query = "";

            if (sucursal.Equals("CEDIS"))
            {
                query = "UPDATE rd_gastos_almacen_cedis SET comRevision='" + comentario + "',estado_revision='"+revision+"' WHERE id=" + id + "";
            }
            else
            {
                query = "UPDATE rd_auditoria_gastos SET comentarioRevision='" + comentario + "',revision='" + revision + "',comentarioRevision2='" + comentario2 + "' WHERE id=" + id + "";
            }
           
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void ActualizarAutorizacionGasto(int id, string sucursal, string numAutorizacion, string estado, string comentarioSRA)
        {
            string query = "UPDATE rd_auditoria_gastos SET numAutorizacion='" + numAutorizacion + "', Estado='" + estado + "',comentarioSRA='" + comentarioSRA + "' WHERE id=" + id + "";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }





        public List<Gasto> GastosAutorizados(string sucursal, DateTime fecha)
        {
            List<Gasto> lista = new List<Gasto>();

            string query = "SELECT * FROM rd_auditoria_gastos WHERE fecha='" + fecha.ToString("yyyy-MM-dd") + "' AND numAutorizacion<>'0'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {


                Gasto gasto = new Gasto()
                {
                    Concepto = dr["concepto"].ToString(),
                    Descripcion = dr["descripcion"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),
                    Detalle = dr["comentario"].ToString(),
                    RutaFoto = dr["rutaFoto"].ToString(),
                    NumAutorizacion = dr["numAutorizacion"].ToString(),
                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }

        public List<Gasto> GastosRevisados(string sucursal, DateTime fecha)
        {
            List<Gasto> lista = new List<Gasto>();
            string query = "SELECT ticket FROM rd_auditoria_gastos WHERE revision='REVISADO' OR revision='CORREGIR' AND fecha ='" + fecha.ToString("yyyy-MM-dd") + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto ticket = new Gasto()
                {
                    Ticket = dr["ticket"].ToString()
                };

                lista.Add(ticket);
            }
            dr.Close();
            con.Close();
            return lista;

        }

        public List<Gasto> GastosPorCorregir(string sucursal, DateTime fecha)
        {

            //MySqlConnection con = null;
            //int mes = Convert.ToInt32(fecha.Month);
            //int año = Convert.ToInt32(fecha.Year);
            //string nombreMes = FormatoFecha.Mes(mes);

            //if (respaldo == true)
            //{
            //    con = BDConexicon.RespMultiSuc(sucursal, nombreMes, año);
            //}
            //else
            //{
            //    con = BDConexicon.ConexionSucursal(sucursal);
            //}

            List<Gasto> lista = new List<Gasto>();
            string query = "SELECT * FROM rd_auditoria_gastos WHERE revision='CORREGIR' AND fecha ='" + fecha.ToString("yyyy-MM-dd") + "'";
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
                    Detalle = dr["comentario"].ToString(),
                    Importe = Convert.ToDouble(dr["importe"].ToString()),

                    ComentarioRevision = dr["comentarioRevision"].ToString(),
                    ComentarioRevision2 = dr["comentarioRevision2"].ToString(),
                    RutaFoto = dr["rutaFoto"].ToString(),
                    NombreFoto = dr["nombreFoto"].ToString(),
                    RutaFoto2 = dr["rutaFoto2"].ToString(),
                    NombreFoto2 = dr["nombreFoto2"].ToString(),
                    RutaFoto3 = dr["rutaFoto3"].ToString(),
                    NombreFoto3 = dr["nombreFoto3"].ToString(),
                    Ticket = dr["ticket"].ToString(),
                    Revision = dr["revision"].ToString()

                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;

        }

        public List<Gasto> GastosAprobados(string sucursal, DateTime fecha)
        {
            List<Gasto> lista = new List<Gasto>();
            string query = "SELECT * FROM rd_auditoria_gastos WHERE numAutorizacion<>'0'&& numAutorizacion<>'RECHAZADO' AND fecha ='" + fecha.ToString("yyyy-MM-dd") + "'";
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
                    RutaFoto2 = dr["rutaFoto2"].ToString(),
                    RutaFoto3 = dr["rutaFoto3"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    FechaRegistro = Convert.ToDateTime(dr["fechaRegistro"].ToString()),
                    UsuarioAplico = dr["usuario"].ToString(),
                    ComentarioRevision = dr["comentarioRevision"].ToString(),
                    Revision1 = Convert.ToInt32(dr["Revision1"]),
                    Revision2 = Convert.ToInt32(dr["Revision2"]),
                    Ticket = dr["ticket"].ToString(),
                    NumAutorizacion = dr["numAutorizacion"].ToString(),
                    Revision = dr["revision"].ToString()

                };
                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }


        public List<Gasto> BuscarNumTicket(string sucursal, DateTime inicio, DateTime fin)
        {
            List<Gasto> lista = new List<Gasto>();
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            string query = "select ticket from rd_auditoria_gastos where fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Ticket = dr["ticket"].ToString()
                };

                lista.Add(gasto);
            }

            dr.Close();
            con.Close();
            return lista;
        }

        public static string GenerarNumAprobacion(string sucursal)
        {
            string inicial = "";
            if (sucursal.Equals("VALLARTA"))
            {
                inicial = "V";
            }
            else if (sucursal.Equals("RENA"))
            {
                inicial = "R";
            } else if (sucursal.Equals("VELAZQUEZ"))
            {
                inicial = "VL";
            } else if (sucursal.Equals("COLOSO"))
            {
                inicial = "C";
            }
            //else if (sucursal.Equals("CEDIS"))
            //{
            //    inicial = "GG";
            //}

            //string num = "";
            //Random rand = new Random();
            //num = Convert.ToString(rand.Next(1111111,9999999));

            DateTime fecha = DateTime.Now;
            //int dia = fecha.Day;
            //int mes = fecha.Month;
            //int año = fecha.Year;
            //int hora = fecha.Hour;
            //int minutos = fecha.Minute;
            //int segundos = fecha.Second;
            //int mili = fecha.Millisecond;
            string num = fecha.Minute.ToString() + fecha.Second.ToString() + fecha.Millisecond.ToString();
            //string cadena = hora.ToString() + dia.ToString() + segundos.ToString() + mes.ToString() + año.ToString() + minutos.ToString() + mili.ToString();

            if (sucursal.Equals("CEDIS"))
            {
                return num;
            }
            else
            {
                return inicial + "-" + num;
            }
            
        }

      


        public List<Gasto> BuscarGastos(string sucursal, DateTime inicio, DateTime fin,bool respaldo)
        {
            MySqlConnection con = null;
            if (respaldo == true)
            {
                int m = inicio.Month;
                string mes = FormatoFecha.Mes(m);
                con = BDConexicon.RespMultiSuc(sucursal,mes,inicio.Year);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }
           
           
            //string query = "select flujo.CONCEPTO,conegre.DESCRIP,flujo.IMPORTE from flujo INNER JOIN conegre on flujo.CONCEPTO = conegre.CONCEPTO where flujo.ING_EG ='E' and flujo.CONCEPTO<>'CAM' WHERE FECHA='2022-07-19'";

            string query = "SELECT flujo.flujo,conegre.CONCEPTOGRAL, conegre.DESCRIP,flujo.IMPORTE,flujo.usuario,flujo.FECHA FROM flujo INNER JOIN conegre ON flujo.CONCEPTO = conegre.CONCEPTO WHERE flujo.FECHA between'" + inicio.ToString("yyyy-MM-dd") + "'and  '" + fin.ToString("yyyy-MM-dd") + "'" +
           "AND (flujo.CONCEPTO<>'CAM' AND flujo.CONCEPTO<>'Retir' AND flujo.CONCEPTO<>'RBAN' AND flujo.CONCEPTO<>'RPPP' AND flujo.CONCEPTO<>'CORTZ' AND flujo.CONCEPTO<>'TARJ'  AND flujo.CONCEPTO<>'CGRAL'  AND flujo.CONCEPTO<>'ALBR' AND flujo.CONCEPTO<>'CINO' AND flujo.CONCEPTO<>'ACR' AND flujo.CONCEPTO<>'ACCR' AND flujo.CONCEPTO<>'FNZAS' AND flujo.CONCEPTO<>'CCDIS' AND flujo.CONCEPTO<>'CCDMX')";
            MySqlCommand cmd = new MySqlCommand(query, con);
            List<Gasto> listaGastos = new List<Gasto>();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto();
                gasto.Concepto = dr["CONCEPTOGRAL"].ToString();
                gasto.Descripcion = dr["DESCRIP"].ToString();
                gasto.Importe = Convert.ToDouble(dr["IMPORTE"].ToString());
                gasto.Ticket = dr["flujo"].ToString();
                gasto.UsuarioAplico = dr["usuario"].ToString();
                gasto.Fecha = Convert.ToDateTime(dr["FECHA"].ToString());
                listaGastos.Add(gasto);
            }
            dr.Close();
            con.Close();
            return listaGastos;
        }

        public List<Gasto> CuentasRetiroEfectivo(string sucursal, DateTime inicio, DateTime fin)
        {
             MySqlConnection con = null;
             con = BDConexicon.ConexionSucursal(sucursal);
             List<Gasto> lista = new List<Gasto>();
             string query = "SELECT flujo.flujo,conegre.CONCEPTOGRAL, conegre.DESCRIP,flujo.IMPORTE,flujo.usuario,flujo.FECHA FROM flujo INNER JOIN conegre ON flujo.CONCEPTO = conegre.CONCEPTO " +
            "WHERE flujo.CONCEPTO IN('RPPP','RBAN','CGRAL','ALBR','CINO','CCDIS','CCDMX','FNZAS','ACCR','ACR')";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Concepto = dr["CONCEPTOGRAL"].ToString(),
                    Descripcion = dr["DESCRIP"].ToString(),
                    Importe = Convert.ToDouble(dr["IMPORTE"].ToString()),
                    Ticket = dr["flujo"].ToString(),
                    UsuarioAplico = dr["usuario"].ToString(),
                    Fecha = Convert.ToDateTime(dr["FECHA"].ToString()),
                    
                };
                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }

        public List<Gasto> BuscarGastoXConcepto(string sucursal,DateTime inicio,DateTime fin,string tipoGasto,string conceptoGral,string conceptoDetalle)
        {
            List<Gasto> lista = new List<Gasto>();
            string query = "select flujo.flujo as TICKET,conegre.TIPO_GASTO AS TIPO_GASTO,conegre.CONCEPTOGRAL AS CONCEPTOGRAL,conegre.concepto AS CONCEPTO,conegre.descrip AS CONCEPTODETALLE, flujo.importe AS IMPORTE,flujo.fecha AS FECHA from conegre inner join flujo on conegre.CONCEPTO = flujo.CONCEPTO " +
                 "where flujo.ING_EG = 'E' AND flujo.fecha between '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "' and(flujo.concepto <> 'CAM' AND flujo.CONCEPTO <> 'RETIR' AND flujo.CONCEPTO <> 'TARJ' AND flujo.CONCEPTO <> 'CORTZ' AND flujo.CONCEPTO <> 'ALBR' AND flujo.CONCEPTO <> 'CGRAL' AND flujo.CONCEPTO <> 'RBAN'" +
                 "AND flujo.CONCEPTO <> 'RPPP' AND flujo.CONCEPTO <> 'CINO' AND flujo.CONCEPTO <> 'CCDMX' AND flujo.CONCEPTO <> 'FNZAS' AND flujo.CONCEPTO <> 'ACCR'AND flujo.CONCEPTO <> 'ACR' AND flujo.CONCEPTO <> 'CCDIS') and conegre.TIPO_GASTO ='" + tipoGasto + "' AND conegre.CONCEPTOGRAL='" + conceptoGral + "' and conegre.DESCRIP='"+ conceptoDetalle + "'" +
                 "ORDER BY flujo.FECHA";
            //string query = "select  ag.Id as Id, c.TIPO_GASTO as TIPO_GASTO, ag.concepto as concepto, ag.descripcion as descripcion,ag.importe as importe,ag.comentario as comentario,ag.usuario as usuario,ag.fecha as fecha,ag.comentarioRevision as comentarioRevision,ag.comentarioRevision2 as comentarioRevision2,ag.comentarioSRA as comentarioSRA," +
            //    "ag.numAutorizacion as numAutorizacion,ag.rutaFoto as rutaFoto,ag.rutaFoto2 as rutaFoto2,ag.rutaFoto3 as rutaFoto3,ag.enc_cajas as enc_cajas,ag.revision as revision,ag.fechaRegistro as fechaRegistro,ag.Revision1 as Revision1,ag.Revision2 as Revision2,ag.revision as revision, ag.ticket as ticket " +
            //    "from rd_auditoria_gastos ag inner join conegre c on ag.claveEgreso = c.CONCEPTO WHERE ag.fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND c.TIPO_GASTO ='"+tipoGasto+"' and ag.concepto='"+conceptoGral+"' and ag.descripcion='"+conceptoDetalle+"'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Concepto = dr["CONCEPTOGRAL"].ToString(),
                    Descripcion = dr["CONCEPTODETALLE"].ToString(),
                    Importe = Convert.ToDouble(dr["IMPORTE"].ToString()),

                    Fecha = Convert.ToDateTime(dr["FECHA"].ToString()),

                    Tipo_egreso = dr["TIPO_GASTO"].ToString(),
                    Ticket = dr["TICKET"].ToString()
                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }

        public List<Gasto> BuscarGastoXConceptoGral(string sucursal, DateTime inicio, DateTime fin, string tipoGasto, string conceptoGral)
        {
            List<Gasto> lista = new List<Gasto>();

            string query = "select flujo.flujo as TICKET,conegre.TIPO_GASTO AS TIPO_GASTO,conegre.CONCEPTOGRAL AS CONCEPTOGRAL,conegre.concepto AS CONCEPTO,conegre.descrip AS CONCEPTODETALLE, flujo.importe AS IMPORTE,flujo.fecha AS FECHA from conegre inner join flujo on conegre.CONCEPTO = flujo.CONCEPTO " +
                 "where flujo.ING_EG = 'E' AND flujo.fecha between '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "' and(flujo.concepto <> 'CAM' AND flujo.CONCEPTO <> 'RETIR' AND flujo.CONCEPTO <> 'TARJ' AND flujo.CONCEPTO <> 'CORTZ' AND flujo.CONCEPTO <> 'ALBR' AND flujo.CONCEPTO <> 'CGRAL' AND flujo.CONCEPTO <> 'RBAN'" +
                 "AND flujo.CONCEPTO <> 'RPPP' AND flujo.CONCEPTO <> 'CINO' AND flujo.CONCEPTO <> 'CCDMX' AND flujo.CONCEPTO <> 'FNZAS' AND flujo.CONCEPTO <> 'ACCR'AND flujo.CONCEPTO <> 'ACR' AND flujo.CONCEPTO <> 'CCDIS') and conegre.TIPO_GASTO ='"+ tipoGasto + "' AND conegre.CONCEPTOGRAL='"+conceptoGral+"'" +
                 "ORDER BY flujo.FECHA";
            //string query = "select  ag.Id as Id, c.TIPO_GASTO as TIPO_GASTO, ag.concepto as concepto, ag.descripcion as descripcion,ag.importe as importe,ag.comentario as comentario,ag.usuario as usuario,ag.fecha as fecha,ag.comentarioRevision as comentarioRevision,ag.comentarioRevision2 as comentarioRevision2,ag.comentarioSRA as comentarioSRA," +
            //    "ag.numAutorizacion as numAutorizacion,ag.rutaFoto as rutaFoto,ag.rutaFoto2 as rutaFoto2,ag.rutaFoto3 as rutaFoto3,ag.enc_cajas as enc_cajas,ag.revision as revision,ag.fechaRegistro as fechaRegistro,ag.Revision1 as Revision1,ag.Revision2 as Revision2,ag.revision as revision, ag.ticket as ticket " +
            //    "from rd_auditoria_gastos ag inner join conegre c on ag.claveEgreso = c.CONCEPTO WHERE ag.fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND c.TIPO_GASTO ='" + tipoGasto + "' and ag.concepto='" + conceptoGral + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Concepto = dr["CONCEPTOGRAL"].ToString(),
                    Descripcion = dr["CONCEPTODETALLE"].ToString(),
                    Importe = Convert.ToDouble(dr["IMPORTE"].ToString()),

                    Fecha = Convert.ToDateTime(dr["FECHA"].ToString()),

                    Tipo_egreso = dr["TIPO_GASTO"].ToString(),
                    Ticket = dr["TICKET"].ToString()
                };

                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }


        public List<Gasto> BuscarGastosXTipoGasto(string sucursal,DateTime inicio,DateTime fin,string tipo_gasto)
        {
            List<Gasto> lista = new List<Gasto>();
            string query = "select flujo.flujo as TICKET,conegre.TIPO_GASTO AS TIPO_GASTO,conegre.CONCEPTOGRAL AS CONCEPTOGRAL,conegre.concepto AS CONCEPTO,conegre.descrip AS CONCEPTODETALLE, flujo.importe AS IMPORTE,flujo.fecha AS FECHA from conegre inner join flujo on conegre.CONCEPTO = flujo.CONCEPTO " +
                 "where flujo.ING_EG = 'E' AND flujo.fecha between '" + inicio.ToString("yyyy-MM-dd") + "'and '" + fin.ToString("yyyy-MM-dd") + "' and(flujo.concepto <> 'CAM' AND flujo.CONCEPTO <> 'RETIR' AND flujo.CONCEPTO <> 'TARJ' AND flujo.CONCEPTO <> 'CORTZ' AND flujo.CONCEPTO <> 'ALBR' AND flujo.CONCEPTO <> 'CGRAL' AND flujo.CONCEPTO <> 'RBAN'" +
                 "AND flujo.CONCEPTO <> 'RPPP' AND flujo.CONCEPTO <> 'CINO' AND flujo.CONCEPTO <> 'CCDMX' AND flujo.CONCEPTO <> 'FNZAS' AND flujo.CONCEPTO <> 'ACCR'AND flujo.CONCEPTO <> 'ACR' AND flujo.CONCEPTO <> 'CCDIS') and conegre.TIPO_GASTO ='" + tipo_gasto + "'" +
                 "ORDER BY flujo.FECHA";
            //string query = "select  ag.Id as Id, c.TIPO_GASTO as TIPO_GASTO, ag.concepto as concepto, ag.descripcion as descripcion,ag.importe as importe,ag.comentario as comentario,ag.usuario as usuario,ag.fecha as fecha,ag.comentarioRevision as comentarioRevision,ag.comentarioRevision2 as comentarioRevision2,ag.comentarioSRA as comentarioSRA," +
            //   "ag.numAutorizacion as numAutorizacion,ag.rutaFoto as rutaFoto,ag.rutaFoto2 as rutaFoto2,ag.rutaFoto3 as rutaFoto3,ag.enc_cajas as enc_cajas,ag.revision as revision,ag.fechaRegistro as fechaRegistro,ag.Revision1 as Revision1,ag.Revision2 as Revision2,ag.revision as revision, ag.ticket as ticket " +
            //   "from rd_auditoria_gastos ag inner join conegre c on ag.claveEgreso = c.CONCEPTO WHERE ag.fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND c.TIPO_GASTO ='" + tipo_gasto + "'";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Concepto = dr["CONCEPTOGRAL"].ToString(),
                    Descripcion = dr["CONCEPTODETALLE"].ToString(),
                    Importe = Convert.ToDouble(dr["IMPORTE"].ToString()),

                    Fecha = Convert.ToDateTime(dr["FECHA"].ToString()),

                    Tipo_egreso = dr["TIPO_GASTO"].ToString(),
                    Ticket = dr["TICKET"].ToString()
                };
                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }

        public List<Gasto> BuscarGastosXAprobar(string sucursal)
        {
            List<Gasto> lista = new List<Gasto>();
            string query = "";
            if (sucursal.Equals("CEDIS"))
            { 
                query = "select fecha,count(id) as aprobar FROM rd_gastos_almacen_cedis WHERE (estado_aprobacion='EN REVISION' or estado_aprobacion='RECHAZADO') group by fecha order by fecha";
            }else if(sucursal.Equals("FINANZAS"))
            {
                query = "select fecha,count(id) as aprobar FROM rd_gastos_finanzas WHERE (estado_aprobacion='EN REVISION' or estado_aprobacion='RECHAZADO' or estado_aprobacion='CORREGIDO') group by fecha order by fecha";
            }
            else
             {
                query = "SELECT fecha, count(id) as aprobar FROM rd_auditoria_gastos WHERE (ESTADO = 'EN REVISION' OR ESTADO='') group by fecha order by fecha";

            }
           
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query,con);
            
            
                MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Gasto gasto = new Gasto()
                {
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    CantGastos = Convert.ToInt32(dr["aprobar"].ToString())
                };
                lista.Add(gasto);
            }
            dr.Close();
            con.Close();
            return lista;
        }

        public static int NumAutorizacionCedis()
        {
            int num = 0;

            string query = "SELECT Consec FROM CONSEC WHERE Dato='NumAutorizacionCedis'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                num = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            con.Close();
            return num;
        }

        public static string NumAutorizacionFinanzas()
        {
            //    int num = 0;

            //    string query = "SELECT Consec FROM CONSEC WHERE Dato='NumAutorizacionFinanzas'";
            //    MySqlConnection con = BDConexicon.BodegaOpen();
            //    MySqlCommand cmd = new MySqlCommand(query, con);
            //    MySqlDataReader dr = cmd.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        num = Convert.ToInt32(dr["Consec"].ToString());
            //    }
            //    dr.Close();
            //    con.Close();
            //    return num;


            //string inicial = "F";



            //int num = 0;
            //Random rand = new Random();
            //num = rand.Next(1111111, 9999999);

            DateTime fecha = DateTime.Now;
            string num = fecha.Minute.ToString() + fecha.Second.ToString() + fecha.Millisecond.ToString();


            return num;
        }

        public static void ActualizarNumAutorizacionFinanzas(int num)
        {
            num++;
            string query = "UPDATE CONSEC SET Consec=" + num + " WHERE Dato='NumAutorizacionFinanzas'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

        }

        public static void ActualizarNumAutorizacionCedis(int num)
        {
            num++;
            string query = "UPDATE CONSEC SET Consec="+num+ " WHERE Dato='NumAutorizacionCedis'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();

        }


        //INCONGRUENCIAS


        public static DataTable ColumnasGastosIncongruentes(string sucursal, DateTime inicio, DateTime fin, bool check)
        {

            double total = 0;

            MySqlConnection con = null;
            DataTable listaConceptos = new DataTable();
            
            listaConceptos.Columns.Add("CONCEPTO", typeof(string));
            listaConceptos.Columns.Add("DESCRIPCION", typeof(string));
            listaConceptos.Columns.Add("TIPO", typeof(string));
            listaConceptos.Rows.Clear();
            if (check == true)

            {
                int m = inicio.Month;
                string mes = FormatoFecha.Mes(m);
                con = BDConexicon.RespMultiSuc(sucursal, mes, inicio.Year);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }


            //OBTENGO LOS CONCEPTOS QUE SE QUIERE SABER CUANTO SE GASTÓ EN ELLOS
            string conceptos = "select conegre.concepto as concepto,conegre.descrip as descripcion, conegre.TIPO_GASTO from rd_conceptos_incongruencias inner join conegre on rd_conceptos_incongruencias.concepto = conegre.CONCEPTO order by conegre.concepto";
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            cmd = new MySqlCommand(conceptos, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listaConceptos.Rows.Add(dr["concepto"].ToString(), dr["descripcion"].ToString(),dr["TIPO_GASTO"].ToString());
            }
            dr.Close();
            con.Close();
            return listaConceptos;
        }


        public static DataTable GastosIncongruentes(string sucursal,DateTime inicio,DateTime fin,bool check)
        {

            double total = 0;

            MySqlConnection con = null;
            DataTable dt = new DataTable();
            dt.Rows.Clear();
            dt.Columns.Add("FLUJO",typeof(string));
            dt.Columns.Add("CONCEPTO", typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("FECHA", typeof(string));
            dt.Columns.Add("IMPORTE", typeof(double));
            dt.Rows.Clear();
            if (check == true)

            {
                int m = inicio.Month;
                string mes = FormatoFecha.Mes(m);
                con = BDConexicon.RespMultiSuc(sucursal, mes, inicio.Year);
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }



            DataTable conceptos = ColumnasGastosIncongruentes(sucursal,inicio,fin,check);


            
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            for (int i = 0; i < conceptos.Rows.Count; i++)
            {
                cmd = new MySqlCommand("SELECT flujo.FLUJO,conegre.CONCEPTO,conegre.DESCRIP AS DESCRIPCION,sum(flujo.IMPORTE) AS IMPORTE,flujo.FECHA FROM flujo INNER JOIN conegre ON flujo.CONCEPTO= conegre.CONCEPTO WHERE  flujo.fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' and flujo.concepto='"+conceptos.Rows[i]["concepto"].ToString()+"' GROUP BY flujo.CONCEPTO,flujo.FECHA ORDER BY flujo.FECHA", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt.Rows.Add(dr["flujo"].ToString(), dr["concepto"].ToString(), dr["DESCRIPCION"].ToString(), dr["fecha"].ToString(), Convert.ToDouble(dr["IMPORTE"].ToString()));
                }
                dr.Close();
            }
           
            
            con.Close();
            return dt;
        }
    }
}
