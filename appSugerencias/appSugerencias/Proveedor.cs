using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class Proveedor
    {

        public string proveedor { get; set; }
        public string nombre { get; set; }

      

        public ArrayList Fabricante()
        {
            ArrayList fabricante = new ArrayList();
            string query = "SELECT DISTINCT fabricante as 'proveedor' FROM PRODS ORDER BY fabricante";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fabricante.Add( dr["proveedor"].ToString());
            }
            dr.Close();
            conexion.Close();
            return fabricante;
        }


        public string IdProveedor(string nombre)
        {
            string id = "";
            string query = "SELECT proveedor FROM proveed WHERE nombre ='"+nombre+"'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = dr["proveedor"].ToString();
            }
            dr.Close();
            conexion.Close();
            return id;
        }


        //BUSCA EL NOMBRE DE LOS PROVEEDORES Y LOS RETORNA EN UN ARRAY
        public ArrayList Proveedores()
        {
            ArrayList prov = new ArrayList();
            //  MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT nombre FROM proveed ORDER BY nombre";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                prov.Add(dr["nombre"].ToString());
            }
            dr.Close();
            return prov;
        }

        public string NombreProveedor(string proveedor)
        {
            string nombre = "";
            string query = "SELECT NOMBRE FROM PROVEED WHERE PROVEEDOR='"+proveedor+"'";
            MySqlConnection conexion = BDConexicon.conectar();
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

        //BUSCA LOS BANCOS DE LOS PROVEEDORES Y LOS RETORNA EN UNA ARRAY
        public ArrayList Bancos(string proveedor)
        {
            ArrayList bancos = new ArrayList();

            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT DISTINCT banco FROM rd_cuentas_bancarias WHERE fk_proveedor='"+proveedor+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bancos.Add(dr["banco"].ToString());
            }
            dr.Close();
            conexion.Close();
            return bancos;
        }

        public ArrayList Cuentas(string banco,string proveedor)
        {
            ArrayList cuentas = new ArrayList();
            string query = "SELECT cuenta FROM rd_cuentas_bancarias WHERE banco='"+banco+"' AND fk_proveedor='"+proveedor+"'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cuentas.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            conexion.Close();
            return cuentas;

           
        }

        public ArrayList ClientesBancarios(string banco, string cuenta)
        {
            ArrayList clientebancario = new ArrayList();
            string query = "SELECT pagara FROM rd_cuentas_bancarias WHERE banco='" + banco + "' AND cuenta='" + cuenta + "'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientebancario.Add(dr["pagara"].ToString());
            }
            dr.Close();
            conexion.Close();
            return clientebancario;


        }

        public ArrayList ProveedoresServicios()
        {
            ArrayList provServicios = new ArrayList();

            string query = "SELECT DISTINCT nombre FROM rd_proveedor_servicios";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                provServicios.Add(dr["nombre"].ToString());
            }
            dr.Close();
            con.Close();


            return provServicios;
        }

        public ArrayList ProvServBancos( string proveedor)
        {
            ArrayList bancos = new ArrayList();
            string query = "SELECT DISTINCT banco FROM rd_cuentas_prov_serv WHERE proveedor='" +proveedor + "'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bancos.Add(dr["banco"].ToString());
            }
            dr.Close();
            conexion.Close();
            return bancos;


        }

        public ArrayList ProvServCuentas(string banco, string proveedor)
        {
            ArrayList cuentas = new ArrayList();
            string query = "SELECT cuenta FROM rd_cuentas_prov_serv WHERE banco='" + banco + "' AND proveedor='" + proveedor + "'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cuentas.Add(dr["cuenta"].ToString());
            }
            dr.Close();
            conexion.Close();
            return cuentas;


        }

        public ArrayList PSClientesBancarios(string banco, string cuenta,string id)
        {
            ArrayList clientebancario = new ArrayList();
            string query = "SELECT beneficiario FROM rd_cuentas_prov_serv WHERE banco='" + banco + "' AND cuenta='" + cuenta + "' and proveedor='"+id+"'";
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientebancario.Add(dr["beneficiario"].ToString());
            }
            dr.Close();
            conexion.Close();
            return clientebancario;


        }

    }
}
