using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Modelo
{
    static public  class MSesion
    {
        static private string _Usuario;
        static private MySqlConnection _Conexion;
        static private string _Rol;

        static public void SetDatos(string usuario, string rol, MySqlConnection conexion)
        {
            _Usuario = usuario;
            _Rol = rol;
            _Conexion = conexion;

        }

        static public void SetConexion(MySqlConnection conexion)
        {
            _Conexion = conexion;
        }

        static public string GetUsuario()
        {
            return _Usuario;
        }
        static public string GetRol()
        {
            return _Rol;
        }
        static public MySqlConnection GetConexion()
        {
            return _Conexion;
        }
    }
}
