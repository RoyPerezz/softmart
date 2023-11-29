using appSugerencias.Stock_Compras.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Stock_Compras.Controlador
{
    class AclaracionController
    {



        //public static void GuardarFotosAclaracion(string sucursal,string foto1,string nombreFoto1,string foto2,string nombreFoto2,int stock)
        //  {
        //      MySqlConnection con = BDConexicon.BodegaOpen();
        //      string query = "";
        //      MySqlCommand cmd2 = null;


        //      if (sucursal.Equals("CEDIS"))
        //      {

        //          query = "UPDATE rd_stock_compra SET" +
        //            "     foto_ce1='" + foto1 + "',nombreFoto_ce1='" + nombreFoto1 + "',foto_ce2='" + foto2 + "',nombreFoto_ce2='" + nombreFoto2 + "' where idreg=" + stock + "";
        //          cmd2 = new MySqlCommand(query, con);
        //          cmd2.ExecuteNonQuery();

        //      }else if(sucursal.Equals("VALLARTA"))
        //      {
        //          query = "UPDATE rd_stock_compra SET" +
        //           "     foto_va1=" + foto1 + ",nombreFoto_va1=" + nombreFoto1 + ",foto_va2=" + foto2 + ",nombreFoto_va2=" + nombreFoto2 + " where idreg=" + stock + "";
        //          cmd2 = new MySqlCommand(query, con);
        //          cmd2.ExecuteNonQuery();

        //      }else if(sucursal.Equals("RENA"))
        //      {
        //          query = "UPDATE rd_stock_compra SET" +
        //           "     foto_re1=" + foto1 + ",nombreFoto_re1=" + nombreFoto1 + ",foto_re2=" + foto2 + ",nombreFoto_re2=" + nombreFoto2 + " where idreg=" + stock + "";
        //          cmd2 = new MySqlCommand(query, con);
        //          cmd2.ExecuteNonQuery();
        //      }
        //      else if(sucursal.Equals("VELAZQUEZ"))
        //      {
        //          query = "UPDATE rd_stock_compra SET" +
        //          "     foto_ve1=" + foto1 + ",nombreFoto_ve1=" + nombreFoto1 + ",foto_ve2=" + foto2 + ",nombreFoto_ve2=" + nombreFoto2 + " where idreg=" + stock + "";
        //          cmd2 = new MySqlCommand(query, con);
        //          cmd2.ExecuteNonQuery();
        //      }
        //      else if (sucursal.Equals("COLOSO"))
        //      {
        //          query = "UPDATE rd_stock_compra SET" +
        //          "     foto_co1=" + foto1 + ",nombreFoto_co1=" + nombreFoto1 + ",foto_co2=" + foto2 + ",nombreFoto_co2=" + nombreFoto2 + " where idreg=" + stock + "";
        //          cmd2 = new MySqlCommand(query, con);
        //          cmd2.ExecuteNonQuery();
        //      }


        //  }


        public static void GuardarFotosAclaracion1(string sucursal, string foto1, string nombreFoto1, int stock)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "";
            MySqlCommand cmd2 = null;


            if (sucursal.Equals("CEDIS"))
            {

                query = "UPDATE rd_stock_compra SET" +
                  "     foto_ce1='" + foto1 + "',nombreFoto_ce1='" + nombreFoto1 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();

            }
            else if (sucursal.Equals("VALLARTA"))
            {
                query = "UPDATE rd_stock_compra SET" +
                 "     foto_va1='" + foto1 + "',nombreFoto_va1='" + nombreFoto1 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();

            }
            else if (sucursal.Equals("RENA"))
            {
                query = "UPDATE rd_stock_compra SET" +
                 "     foto_re1='" + foto1 + "',nombreFoto_re1='" + nombreFoto1 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();
            }
            else if (sucursal.Equals("VELAZQUEZ"))
            {
                query = "UPDATE rd_stock_compra SET" +
                "     foto_ve1='" + foto1 + "',nombreFoto_ve1='" + nombreFoto1 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();
            }
            else if (sucursal.Equals("COLOSO"))
            {
                query = "UPDATE rd_stock_compra SET" +
                "     foto_co1='" + foto1 + "',nombreFoto_co1='" + nombreFoto1 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();
            }


        }

        public static void GuardarFotosAclaracion2(string sucursal, string foto2, string nombreFoto2, int stock)
        {
            MySqlConnection con = BDConexicon.BodegaOpen();
            string query = "";
            MySqlCommand cmd2 = null;


            if (sucursal.Equals("CEDIS"))
            {

                query = "UPDATE rd_stock_compra SET" +
                  "     foto_ce2='" + foto2 + "',nombreFoto_ce2='" + nombreFoto2 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();

            }
            else if (sucursal.Equals("VALLARTA"))
            {
                query = "UPDATE rd_stock_compra SET" +
                 "     foto_va2='" + foto2 + "',nombreFoto_va2='" + nombreFoto2 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();

            }
            else if (sucursal.Equals("RENA"))
            {
                query = "UPDATE rd_stock_compra SET" +
                 "     foto_re2='" + foto2 + "',nombreFoto_re2='" + nombreFoto2 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();
            }
            else if (sucursal.Equals("VELAZQUEZ"))
            {
                query = "UPDATE rd_stock_compra SET" +
                "     foto_ve2='" + foto2 + "',nombreFoto_ve2='" + nombreFoto2 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();
            }
            else if (sucursal.Equals("COLOSO"))
            {
                query = "UPDATE rd_stock_compra SET" +
                "     foto_co2='" + foto2 + "',nombreFoto_co2='" + nombreFoto2 + "' where idreg=" + stock + "";
                cmd2 = new MySqlCommand(query, con);
                cmd2.ExecuteNonQuery();
            }


        }

        public static void GuardarAclaracion(string sucursal,List<Aclaracion> aclaracion)
        {
            string query = "";
            string query2 = "";
            MySqlCommand cmd = null;
            MySqlCommand cmd2 = null;
            MySqlConnection con = BDConexicon.BodegaOpen();
            if (sucursal.Equals("CEDIS"))
            {
               
                    for (int i = 0; i < aclaracion.Count; i++)
                    {
                    

                        query = "UPDATE rd_detalle_stock_compra SET" +
                         " falta_bo=" + aclaracion[i].Faltante + ", mal_estado_bo=" + aclaracion[i].Medo + ",sobrante_bo=" + aclaracion[i].Sobrante + ",total_aclaracion_bo=" + aclaracion[i].Importe + ",surtio='"+aclaracion[i].Surtio+"'" +
                        " WHERE idreg=" + aclaracion[i].Id + "";

                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }

              
               
            }
            else if (sucursal.Equals("VALLARTA"))
            {

                
                    for (int i = 0; i < aclaracion.Count; i++)
                    {
                       

                        query = "UPDATE rd_detalle_stock_compra SET" +
                            " falta_va=" + aclaracion[i].Faltante + ", mal_estado_va=" + aclaracion[i].Medo + ",sobrante_va=" + aclaracion[i].Sobrante + ",total_aclaracion_va=" + aclaracion[i].Importe + ",surtio=" + aclaracion[i].Surtio + "" +
                            "WHERE idreg=" + aclaracion[i].Id + "";

                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }
               


            }
            else if (sucursal.Equals("RENA"))
            {
                  for (int i = 0; i < aclaracion.Count; i++)
                    {
                        
                        query = "UPDATE rd_detalle_stock_compra SET" +
                        " falta_re=" + aclaracion[i].Faltante + ", mal_estado_re=" + aclaracion[i].Medo + ",sobrante_re=" + aclaracion[i].Sobrante + ",total_aclaracion_re=" + aclaracion[i].Importe + ",surtio=" + aclaracion[i].Surtio + "" +
                        "WHERE idreg=" + aclaracion[i].Id + "";

                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }
                
               
            }
            else if (sucursal.Equals("VELAZQUEZ"))
            {
               
                    for (int i = 0; i < aclaracion.Count; i++)
                    {
                       

                        query = "UPDATE rd_detalle_stock_compra SET" +
                        " falta_re=" + aclaracion[i].Faltante + ", mal_estado_ve=" + aclaracion[i].Medo + ",sobrante_ve=" + aclaracion[i].Sobrante + ",total_aclaracion_ve=" + aclaracion[i].Importe + ",surtio=" + aclaracion[i].Surtio + "" +
                        "WHERE idreg=" + aclaracion[i].Id + "";

                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }
               
            }
            else if (sucursal.Equals("COLOSO"))
            {
                
                    for (int i = 0; i < aclaracion.Count; i++)
                    {
                       

                        query = "UPDATE rd_detalle_stock_compra SET" +
                        " falta_re=" + aclaracion[i].Faltante + ", mal_estado_co=" + aclaracion[i].Medo + ",sobrante_co=" + aclaracion[i].Sobrante + ",total_aclaracion_co=" + aclaracion[i].Importe + ",surtio=" + aclaracion[i].Surtio + "" +
                        "WHERE idreg=" + aclaracion[i].Id + "";

                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                    }
            }

            con.Close();

        }


        public  static List<Aclaracion> FotosAclaracion(string sucursal,int stock)
        {
            List<Aclaracion> lista = new List<Aclaracion>();
            string query = "";
            MySqlCommand cmd = null;
            Aclaracion aclaracion = null;
            MySqlConnection con = BDConexicon.BodegaOpen();
            if (sucursal.Equals("CEDIS"))
            {

                query = "SELECT foto_ce1," +
                    "           foto_ce2" +
                    "    FROM rd_stock_compra" +
                    "    WHERE idreg='"+stock+"'";

                cmd = new MySqlCommand(query,con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {

                        
                        RutaFoto1 = dr["foto_ce1"].ToString(),
                        RutaFoto2 = dr["foto_ce2"].ToString()
                    };

                    lista.Add(aclaracion);
                }
                dr.Close();

            }
            else if (sucursal.Equals("VALLARTA"))
            {


                query = "SELECT foto_va1," +
                    "           foto_va2" +
                    "    FROM rd_stock_compra" +
                    "    WHERE idreg='" + stock + "'";

                cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {


                        RutaFoto1 = dr["foto_va1"].ToString(),
                        RutaFoto2 = dr["foto_va2"].ToString()
                    };

                    lista.Add(aclaracion);
                }
                dr.Close();





            }
            else if (sucursal.Equals("RENA"))
            {


                query = "SELECT foto_re1," +
                    "           foto_re2" +
                    "    FROM rd_stock_compra" +
                    "    WHERE idreg='" + stock + "'";

                cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {


                        RutaFoto1 = dr["foto_re1"].ToString(),
                        RutaFoto2 = dr["foto_re2"].ToString()
                    };

                    lista.Add(aclaracion);
                }
                dr.Close();

            }
            else if (sucursal.Equals("VELAZQUEZ"))
            {


                query = "SELECT foto_ve1," +
                    "           foto_ve2" +
                    "    FROM rd_stock_compra" +
                    "    WHERE idreg='" + stock + "'";

                cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {


                        RutaFoto1 = dr["foto_ve1"].ToString(),
                        RutaFoto2 = dr["foto_ve2"].ToString()
                    };

                    lista.Add(aclaracion);
                }
                dr.Close();
            }
            else if (sucursal.Equals("COLOSO"))
            {


                query = "SELECT foto_co1," +
                    "           foto_co2" +
                    "    FROM rd_stock_compra" +
                    "    WHERE idreg='" + stock + "'";

                cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {


                        RutaFoto1 = dr["foto_co1"].ToString(),
                        RutaFoto2 = dr["foto_co2"].ToString()
                    };

                    lista.Add(aclaracion);
                }
                dr.Close();

            }

            con.Close();



            return lista;


          
        }
        public static List<Aclaracion> BuscarAclaracion(string sucursal,int stock)
        {
            List<Aclaracion> lista = new List<Aclaracion>();
            lista.Clear();
            
            string query = "";
            
           
            MySqlConnection con = BDConexicon.BodegaOpen();
            if (sucursal.Equals("CEDIS"))
            {

                query = "SELECT idreg," +
                    "           modelo," +
                     "        claveProducto," +
                     "        descripcion," +
                     "        pzxpaq," +
                     "        costoxpaq," +
                     "        costoxpz," +
                     "        falta_bo," +
                     "        mal_estado_bo," +
                     "        sobrante_bo," +
                     "        total_aclaracion_bo," +
                     "        surtio " +
                 
                     "FROM rd_detalle_stock_compra " +
                     "WHERE fk_stock=" + stock + "";
                Aclaracion aclaracion = null;
               MySqlCommand cmd = new MySqlCommand(query,con);
               MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {
                        Id = Convert.ToInt32(dr["idreg"].ToString()),
                        Modelo = dr["modelo"].ToString(),
                        Clave = dr["claveProducto"].ToString(),
                        Descripcion = dr["descripcion"].ToString(),
                        PzxPaq = Convert.ToInt32(dr["pzxpaq"].ToString()),
                        CostoxPaq = Convert.ToDouble(dr["costoxpaq"].ToString()),
                        CostoxPz = Convert.ToDouble(dr["costoxpz"].ToString()),
                        Faltante = Convert.ToInt32(dr["falta_bo"].ToString()),
                        Medo = Convert.ToInt32(dr["mal_estado_bo"].ToString()),
                        Sobrante = Convert.ToInt32(dr["sobrante_bo"].ToString()),
                        Importe = Convert.ToDouble(dr["total_aclaracion_bo"].ToString()),
                        Surtio = dr["surtio"].ToString()
                   
                    };

                    lista.Add(aclaracion);
                }
                dr.Close();
                
               

            }
            else if (sucursal.Equals("VALLARTA"))
            {

                query = "SELECT idreg," +
                    "           modelo," +
                     "        claveProducto," +
                     "        descripcion," +
                     "        pzxpaq," +
                     "        costoxpaq," +
                     "        costoxpz," +
                     "        falta_va," +
                     "        mal_estado_va," +
                     "        sobrante_va," +
                     "        total_aclaracion_va," +
                     "        surtio " +
                     "FROM rd_detalle_stock_compra " +
                     "WHERE fk_stock=" + stock + "";
                Aclaracion aclaracion = null;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {
                        Id = Convert.ToInt32(dr["idreg"].ToString()),
                        Modelo = dr["modelo"].ToString(),
                        Clave = dr["claveProducto"].ToString(),
                        Descripcion = dr["descripcion"].ToString(),
                        PzxPaq = Convert.ToInt32(dr["pzxpaq"].ToString()),
                        CostoxPaq = Convert.ToDouble(dr["costoxpaq"].ToString()),
                        CostoxPz = Convert.ToDouble(dr["costoxpz"].ToString()),
                        Faltante = Convert.ToInt32(dr["falta_va"].ToString()),
                        Medo = Convert.ToInt32(dr["mal_estado_va"].ToString()),
                        Sobrante = Convert.ToInt32(dr["sobrante_va"].ToString()),
                        Importe = Convert.ToDouble(dr["total_aclaracion_va"].ToString()),
                        Surtio = dr["surtio"].ToString()
                    };

                    lista.Add(aclaracion);
                }

                dr.Close();





            }
            else if (sucursal.Equals("RENA"))
            {

                query = "SELECT idreg," +
                    "           modelo," +
                     "        claveProducto," +
                     "        descripcion," +
                     "        pzxpaq," +
                     "        costoxpaq," +
                     "        costoxpz," +
                     "        falta_re," +
                     "        mal_estado_re," +
                     "        sobrante_re," +
                     "        total_aclaracion_re," +
                     "        surtio" +
                     "FROM rd_detalle_stock_compra" +
                     "WHERE fk_stock=" + stock + "";
                Aclaracion aclaracion = null;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {
                        Id = Convert.ToInt32(dr["idreg"].ToString()),
                        Modelo = dr["modelo"].ToString(),
                        Clave = dr["claveProducto"].ToString(),
                        Descripcion = dr["descripcion"].ToString(),
                        PzxPaq = Convert.ToInt32(dr["pzxpaq"].ToString()),
                        CostoxPaq = Convert.ToDouble(dr["costoxpaq"].ToString()),
                        CostoxPz = Convert.ToDouble(dr["costoxpz"].ToString()),
                        Faltante = Convert.ToInt32(dr["falta_re"].ToString()),
                        Medo = Convert.ToInt32(dr["mal_estado_re"].ToString()),
                        Sobrante = Convert.ToInt32(dr["sobrante_re"].ToString()),
                        Importe = Convert.ToDouble(dr["total_aclaracion_re"].ToString()),
                        Surtio = dr["surtio"].ToString()
                    };

                    lista.Add(aclaracion);
                }

                dr.Close();


            }
            else if (sucursal.Equals("VELAZQUEZ"))
            {

                query = "SELECT idreg," +
                    "           modelo," +
                     "        claveProducto," +
                     "        descripcion," +
                     "        pzxpaq," +
                     "        costoxpaq," +
                     "        costoxpz," +
                     "        falta_ve," +
                     "        mal_estado_ve," +
                     "        sobrante_ve," +
                     "        total_aclaracion_ve," +
                     "        surtio" +
                     "FROM rd_detalle_stock_compra" +
                     "WHERE fk_stock=" + stock + "";
                Aclaracion aclaracion = null;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {
                        Id = Convert.ToInt32(dr["idreg"].ToString()),
                        Modelo = dr["modelo"].ToString(),
                        Clave = dr["claveProducto"].ToString(),
                        Descripcion = dr["descripcion"].ToString(),
                        PzxPaq = Convert.ToInt32(dr["pzxpaq"].ToString()),
                        CostoxPaq = Convert.ToDouble(dr["costoxpaq"].ToString()),
                        CostoxPz = Convert.ToDouble(dr["costoxpz"].ToString()),
                        Faltante = Convert.ToInt32(dr["falta_ve"].ToString()),
                        Medo = Convert.ToInt32(dr["mal_estado_ve"].ToString()),
                        Sobrante = Convert.ToInt32(dr["sobrante_ve"].ToString()),
                        Importe = Convert.ToDouble(dr["total_aclaracion_ve"].ToString()),
                        Surtio = dr["surtio"].ToString()
                    };

                    lista.Add(aclaracion);
                }

                dr.Close();


            }
            else if (sucursal.Equals("COLOSO"))
            {

                query = "SELECT idreg," +
                     "           modelo," +
                      "        claveProducto," +
                      "        descripcion," +
                      "        pzxpaq," +
                      "        costoxpaq," +
                      "        costoxpz," +
                      "        falta_co," +
                      "        mal_estado_co," +
                      "        sobrante_co," +
                      "        total_aclaracion_co," +
                      "        surtio" +
                      "FROM rd_detalle_stock_compra" +
                      "WHERE fk_stock=" + stock + "";
                Aclaracion aclaracion = null;
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    aclaracion = new Aclaracion()
                    {
                        Id = Convert.ToInt32(dr["idreg"].ToString()),
                        Modelo = dr["modelo"].ToString(),
                        Clave = dr["claveProducto"].ToString(),
                        Descripcion = dr["descripcion"].ToString(),
                        PzxPaq = Convert.ToInt32(dr["pzxpaq"].ToString()),
                        CostoxPaq = Convert.ToDouble(dr["costoxpaq"].ToString()),
                        CostoxPz = Convert.ToDouble(dr["costoxpz"].ToString()),
                        Faltante = Convert.ToInt32(dr["falta_co"].ToString()),
                        Medo = Convert.ToInt32(dr["mal_estado_co"].ToString()),
                        Sobrante = Convert.ToInt32(dr["sobrante_co"].ToString()),
                        Importe = Convert.ToDouble(dr["total_aclaracion_co"].ToString()),
                        Surtio = dr["surtio"].ToString()
                    };

                    lista.Add(aclaracion);
                }

                dr.Close();

            }

            con.Close();



            return lista;
        }
    }
}
