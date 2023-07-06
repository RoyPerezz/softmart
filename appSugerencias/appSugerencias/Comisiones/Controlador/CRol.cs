using appSugerencias.Comisiones.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Controlador
{
    public class CRol
    {
        //Agregar Rol
        public static string CAgregarRol(string prol, bool pcalificaxsemana, MySqlConnection pconex)
        {
            MRol objRol = new MRol();

            objRol.Rol = prol;
            //Se agrega 1 como estado activo
            objRol.Activo = 1;
            objRol.CalificaXSemana = Convert.ToInt32(pcalificaxsemana);
            objRol.Conex = pconex;

            return objRol.MAgregarRol(objRol);
        }

        //Mostrar Roles
        public static List<MRol> CMostrarRoles(MySqlConnection pconex)
        {
            MRol objRol = new MRol();
            objRol.Conex = pconex;

            return objRol.MMostrarEmpledos(objRol);
        }

        //Colsutar Roles
        public static List<MRol> CConsultarRoles(string prol, MySqlConnection pconex)
        {
            MRol objRol = new MRol();
            objRol.Rol = prol;
            objRol.Conex = pconex;

            return objRol.MConsultarRol(objRol);
        }

        //Modificar Rol
        public static string CModificaRol(int pid, string prol, bool pcalificaxsemana, MySqlConnection pconex)
        {
            MRol objRol = new MRol();
            objRol.Id = pid;
            objRol.Rol = prol;
            objRol.CalificaXSemana = Convert.ToInt32(pcalificaxsemana);

            objRol.Conex = pconex;

            return objRol.MModificaRol(objRol);
        }

        //private static int BoolxInt(bool opcion)
        //{
        //    if(opcion)
        //        return 1;
        //    else
        //        return 0;
        //}
    }
}
