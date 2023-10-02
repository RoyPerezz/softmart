using appSugerencias.Stock_Compras.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias.Stock_Compras.Controlador
{
    public class StockController
    {
        public static List<string> BuscarStocks(string proveedor)
        {
            List<string> stocks = new List<string>();

            string consulta = "SELECT descripcion" +
                "              FROM rd_stock_compra" +
                "              WHERE proveedor ='"+proveedor+"'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                stocks.Add(dr["descripcion"].ToString());
            }
            dr.Close();
            con.Close();

            return stocks;
        }

        public static List<string> ListaProveedores()
        {
            List<string> proveedores = new List<string>();

          
            string consulta = "SELECT proveedor,nombre" +
                "              FROM proveed" +
                "              ORDER BY nombre";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                proveedores.Add(dr["nombre"].ToString());
            }
            dr.Close();
            con.Close();

            return proveedores;

        }

        public static string ClaveProveedor(string nombre)
        {
            string clave = "";
            string consulta = "SELECT proveedor" +
                "              FROM proveed" +
                "              WHERE nombre ='"+nombre+"'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clave = dr["proveedor"].ToString();
            }
            dr.Close();
            con.Close();
            return clave;
        }


        public static void GuardarAclaracion(List<DetalleStockCompra> lista,string tipo)
        {

            // actualiza los articulos en la tabla  rd_detalle_stock_compra

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = null;
            MySqlCommand cmd2 = null;
            MySqlCommand revisar = null;
            MySqlDataReader dr = null;
            int bandera = 0;


            string insertar = "";

            if (tipo.Equals("CEDIS"))
            {
               insertar = "INSERT INTO rd_mercancia_aclaraciones(fk_id_articulo,falta_bo,mal_estado_bo,sobrante_bo,importe_bo,falta_va," +
                     "mal_estado_va,sobrante_va,importe_va,falta_re,mal_estado_re,sobrante_re,importe_re,falta_ve,mal_estado_ve,sobrante_ve,importe_ve" +
                     ",falta_co,mal_estado_co,sobrante_co,importe_co) VALUES (?fk_id_articulo,?falta_bo,?mal_estado_bo,?sobrante_bo,?importe_bo,?falta_va,?mal_estado_va,?sobrante_va,?importe_va,?falta_re,?mal_estado_re,?sobrante_re,?importe_re,?falta_ve,?mal_estado_ve,?sobrante_ve,?importe_ve,?falta_co,?mal_estado_co,?sobrante_co,?importe_co)";
            }
            else if(tipo.Equals("TODAS"))
            {
                insertar = "INSERT INTO rd_mercancia_aclaraciones(fk_id_articulo,falta_bo,falta_va," +
                    "mal_estado_va,sobrante_va,importe_va,falta_re,mal_estado_re,sobrante_re,importe_re,falta_ve,mal_estado_ve,sobrante_ve,importe_ve" +
                    ",falta_co,mal_estado_co,sobrante_co,importe_co) VALUES (?fk_id_articulo,?falta_bo,?mal_estado_bo,?sobrante_bo,?importe_bo,?falta_va,?mal_estado_va,?sobrante_va,?importe_va,?falta_re,?mal_estado_re,?sobrante_re,?importe_re,?falta_ve,?mal_estado_ve,?sobrante_ve,?importe_ve,?falta_co,?mal_estado_co,?sobrante_co,?importe_co)";
            }

            string _upDate = "";
            for (int i = 0; i < lista.Count; i++)
            {
                revisar = new MySqlCommand("select * from rd_mercancia_aclaraciones where fk_id_articulo=" + lista[i].Id+"",con);
                dr = revisar.ExecuteReader();
                if (dr.Read())
                {
                    bandera = 1;
                    dr.Close();
                   
                }
                else
                {

                    bandera = 0;
                    dr.Close();
                }

                if (tipo.Equals("CEDIS"))
                {
                    _upDate = "UPDATE rd_mercancia_aclaraciones " +
                 "                   SET falta_bo="+lista[i].Falta_bo+",mal_estado_bo="+lista[i].Mal_estado_bo+",sobrante_bo="+lista[i].Sobrante_bo+",importe_bo="+lista[i].Importe_bo+",falta_va=" + lista[i].Falta_va + ", mal_estado_va=" + lista[i].Mal_estado_va + ", sobrante_va=" + lista[i].Sobrante_va + ", importe_va=" + lista[i].Importe_va + "," +
                 "                   falta_re=" + lista[i].Falta_re + ", mal_estado_re=" + lista[i].Mal_estado_re + ",sobrante_re=" + lista[i].Sobrante_re + ",importe_re=" + lista[i].Importe_re + "," +
                 "                   falta_ve=" + lista[i].Falta_ve + ", mal_estado_ve=" + lista[i].Falta_ve + ", sobrante_ve=" + lista[i].Sobrante_ve + ",importe_ve=" + lista[i].Importe_ve + "," +
                 "                   falta_co =" + lista[i].Falta_co + ",mal_estado_co=" + lista[i].Mal_estado_co + ",sobrante_co=" + lista[i].Sobrante_co + ",importe_co=" + lista[i].Importe_co + " WHERE fk_id_articulo=" + lista[i].Id + "";
                }
                else if (tipo.Equals("TODAS"))
                {
                    _upDate = "UPDATE rd_mercancia_aclaraciones " +
                  "                   SET falta_va=" + lista[i].Falta_va + ", mal_estado_va=" + lista[i].Mal_estado_va + ", sobrante_va=" + lista[i].Sobrante_va + ", importe_va=" + lista[i].Importe_va + "," +
                  "                   falta_re=" + lista[i].Falta_re + ", mal_estado_re=" + lista[i].Mal_estado_re + ",sobrante_re=" + lista[i].Sobrante_re + ",importe_re=" + lista[i].Importe_re + "," +
                  "                   falta_ve=" + lista[i].Falta_ve + ", mal_estado_ve=" + lista[i].Falta_ve + ", sobrante_ve=" + lista[i].Sobrante_ve + ",importe_ve=" + lista[i].Importe_ve + "," +
                  "                   falta_co =" + lista[i].Falta_co + ",mal_estado_co=" + lista[i].Mal_estado_co + ",sobrante_co=" + lista[i].Sobrante_co + ",importe_co=" + lista[i].Importe_co + " WHERE fk_id_articulo=" + lista[i].Id + "";
                }

                if (bandera==1)
                {
                    cmd = new MySqlCommand(_upDate, con);

                    cmd.ExecuteNonQuery();


                }
                else if(bandera==0)
                {
                    cmd2 = new MySqlCommand(insertar, con);
                    cmd2.Parameters.AddWithValue("?fk_id_articulo",lista[i].Id);
                    cmd2.Parameters.AddWithValue("?falta_bo", lista[i].Falta_bo);
                    cmd2.Parameters.AddWithValue("?mal_estado_bo", lista[i].Mal_estado_bo);
                    cmd2.Parameters.AddWithValue("?sobrante_bo", lista[i].Sobrante_bo);
                    cmd2.Parameters.AddWithValue("?importe_bo", lista[i].Importe_bo);
                    cmd2.Parameters.AddWithValue("?falta_va", lista[i].Falta_va);
                    cmd2.Parameters.AddWithValue("?mal_estado_va", lista[i].Mal_estado_va);
                    cmd2.Parameters.AddWithValue("?sobrante_va", lista[i].Sobrante_va);
                    cmd2.Parameters.AddWithValue("?importe_va", lista[i].Importe_va);
                    cmd2.Parameters.AddWithValue("?falta_re", lista[i].Falta_re);
                    cmd2.Parameters.AddWithValue("?mal_estado_re", lista[i].Mal_estado_re);
                    cmd2.Parameters.AddWithValue("?sobrante_re", lista[i].Sobrante_re);
                    cmd2.Parameters.AddWithValue("?importe_re", lista[i].Importe_re);
                    cmd2.Parameters.AddWithValue("?falta_ve", lista[i].Falta_ve);
                    cmd2.Parameters.AddWithValue("?mal_estado_ve", lista[i].Mal_estado_ve);
                    cmd2.Parameters.AddWithValue("?sobrante_ve", lista[i].Sobrante_ve);
                    cmd2.Parameters.AddWithValue("?importe_ve", lista[i].Importe_ve);
                    cmd2.Parameters.AddWithValue("?falta_co", lista[i].Falta_co);
                    cmd2.Parameters.AddWithValue("?mal_estado_co", lista[i].Mal_estado_co);
                    cmd2.Parameters.AddWithValue("?sobrante_co", lista[i].Sobrante_co);
                    cmd2.Parameters.AddWithValue("?importe_co", lista[i].Importe_co);

                    cmd2.ExecuteNonQuery();
                }

               

            }

            con.Close();
        }

       
    }
}
