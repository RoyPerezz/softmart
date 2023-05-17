using appSugerencias.Comisiones.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Controlador
{

    public class CEmpleado
    {
        //Agregar Empleado
        public static string CAgregarEmpleado(string pcodigo, string pnombre, string pusuario, int prol, MySqlConnection pconex)
        {
            MEmpleados objEmpleado = new MEmpleados();
            objEmpleado.Codigo = pcodigo;
            objEmpleado.Nombre = pnombre;
            objEmpleado.Usuario = pusuario;
            objEmpleado.Rol = prol;
            objEmpleado.Conex = pconex;

            return objEmpleado.MAgregarEmpleado(objEmpleado);
        }

        //Mostrar Empleados2
        public static System.Data.DataTable CMostrarEmpleados2(MySqlConnection pconex)
        {
            MEmpleados objEmpleado = new MEmpleados();
            objEmpleado.Conex = pconex;

            return objEmpleado.MMostrarEmpledos2(objEmpleado);
        }

        ////Mostrar Empleados2
        //public static System.Data.DataTable CMostrarEmpleadosPorRol(MySqlConnection pconex)
        //{
        //    MEmpleados objEmpleado = new MEmpleados();
        //    objEmpleado.Conex = pconex;

        //    return objEmpleado.MMostrarEmpledos2(objEmpleado);
        //}

        //Mostrar Empleados
        public static List<MEmpleados> CMostrarEmpleados(MySqlConnection pconex)
        {
            MEmpleados objEmpleado = new MEmpleados();
            objEmpleado.Conex = pconex;

            return objEmpleado.MMostrarEmpledos(objEmpleado);
        }
        //Consultar Empleado
        public static List<MEmpleados> CConsultaEmpleado(string pnombre, MySqlConnection pconex)
        {
            MEmpleados objEmpleado = new MEmpleados();
            objEmpleado.Nombre = pnombre;
            objEmpleado.Conex = pconex;

            return objEmpleado.MConsultaEmpleado(objEmpleado);
        }

        //Modificar Empleado
        public static string CModificaEmpleado(string pcodigo, string pnombre, string pusuario, int prol, MySqlConnection pconex)
        {
            MEmpleados objEmpleado = new MEmpleados();
            objEmpleado.Codigo = pcodigo;
            objEmpleado.Nombre = pnombre;
            objEmpleado.Usuario = pusuario;
            objEmpleado.Rol = prol;
            objEmpleado.Conex = pconex;

            return objEmpleado.MModificaEmpleado(objEmpleado);
        }

        //Elimina Empleado
        public static string CEliminaEmpleado(string pcodigo, MySqlConnection pconex)
        {
            MEmpleados objEmpleado = new MEmpleados();
            objEmpleado.Codigo = pcodigo;


            objEmpleado.Conex = pconex;

            return objEmpleado.MEliminaEmpleado(objEmpleado);
        }
    }
}
