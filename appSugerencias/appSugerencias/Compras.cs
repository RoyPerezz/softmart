using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class Compras
    {


        //AYUDA A CONECTARSE A LA SUCURSAL ELEGIDA POR EL USUARIO
        public MySqlConnection ConexionSucursal(string sucursal)
        {
            MySqlConnection conexion = null;

            if (sucursal.Equals("VALLARTA"))
            {
                conexion = BDConexicon.VallartaOpen();
            }

            if (sucursal.Equals("RENA"))
            {
                conexion = BDConexicon.RenaOpen();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                conexion = BDConexicon.VelazquezOpen();
            }

            if (sucursal.Equals("COLOSO"))
            {
                conexion = BDConexicon.ColosoOpen();
            }

            if (sucursal.Equals("PREGOT"))
            {
                conexion = BDConexicon.Papeleria1Open();
            }

            if (sucursal.Equals("BODEGA"))
            {
                conexion = BDConexicon.BodegaOpen();
            }
            return conexion;
        }

        //GUARDA EN UN ARRAYLIST LAS COMPRAS DE UN PROVEEDOR EN CIERTA SUCURSAL
        public ArrayList ListaCompras(string sucursal,string proveedor)
        {
            ArrayList lista = new ArrayList();
            MySqlConnection conexion = ConexionSucursal(sucursal);
            string query = "SELECT COMPRA FROM compras WHERE PROVEEDOR='"+proveedor+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["COMPRA"].ToString());
            }
            dr.Close();
            conexion.Close();
            return lista;
        }

        public DataTable ArticulosCompra(string compra,string sucursal)
        {
            DataTable dt = new DataTable();
            
            string query = "SELECT pt.ARTICULO,p.DESCRIP,pt.PRECIO,pt.CANTIDAD,pt.DESCUENTO,pt.IMPUESTO,p.COSTO_U " +
               "FROM PARTCOMP pt INNER JOIN PRODS p ON p.ARTICULO = pt.ARTICULO WHERE COMPRA='" + compra+"'";
            MySqlConnection conexion = ConexionSucursal(sucursal);
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(dt);
            conexion.Close();
            return dt;
        }
    }
}
