using appSugerencias.Comisiones.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Controlador
{
    public class CCalificacion
    {
        //Agregar calificacion
        public static string CAgregarCalificacion(int pidtarea, int pidrol, string pidempleado, int pcalificacion, DateTime pfechainicio, DateTime pfechafin, MySqlConnection pconex)
        {
            MCalificacion objCalificacion = new MCalificacion();
            objCalificacion.IdTarea = pidtarea;
            objCalificacion.IdRol = pidrol;
            objCalificacion.IdEmpleado = pidempleado;
            objCalificacion.Calificacion = pcalificacion;
            objCalificacion.FechaInicio = pfechainicio;
            objCalificacion.FechaFin = pfechafin;

            objCalificacion.Conex = pconex;

            return objCalificacion.MAgregarCalificacion(objCalificacion);
        }

        //Mostar calificacion
        public static System.Data.DataTable CMostrarCalificacion(string pcodigo, DateTime pfechainicio, DateTime pfechafin, MySqlConnection pconex)
        {
            DateTime fecha;

            MCalificacion ObjCalificacion = new MCalificacion();
            ObjCalificacion.IdEmpleado = pcodigo;
            ObjCalificacion.FechaInicio = pfechainicio;
            ObjCalificacion.FechaFin = pfechafin;
            ObjCalificacion.Conex = pconex;

            return ObjCalificacion.MMostrarCalificacion(ObjCalificacion);
        }

        //Mostar calificacion 2
        public static System.Data.DataTable CMostrarSumaCalificacion(DateTime pfechainicio, DateTime pfechafin, MySqlConnection pconex)
        {
            MCalificacion ObjCalificacion = new MCalificacion();
            ObjCalificacion.FechaInicio = pfechainicio;
            ObjCalificacion.FechaFin = pfechafin;
            ObjCalificacion.Conex = pconex;

            return ObjCalificacion.MMostrarSumaCalificacion(ObjCalificacion);
        }

        //Mostar calificacion suma por rol
        public static System.Data.DataTable CMostrarSumaCalificacionXRol(DateTime pfechainicio, DateTime pfechafin, int prol, MySqlConnection pconex)
        {
            MCalificacion ObjCalificacion = new MCalificacion();
            ObjCalificacion.FechaInicio = pfechainicio;
            ObjCalificacion.FechaFin = pfechafin;
            ObjCalificacion.IdRol = prol;
            ObjCalificacion.Conex = pconex;

            return ObjCalificacion.MMostrarSumaCalificacionXRol(ObjCalificacion);
        }

        //Agregar Calificacion
        public static string CModificarCalificacion(int pidcalificacion, string pidempleado, int pcalificacion, DateTime pfechainicio, MySqlConnection pconex)
        {
            MCalificacion objCalificacion = new MCalificacion();
            objCalificacion.IdCalificacion = pidcalificacion;
            objCalificacion.IdEmpleado = pidempleado;
            objCalificacion.Calificacion = pcalificacion;
            objCalificacion.FechaInicio = pfechainicio;


            objCalificacion.Conex = pconex;

            return objCalificacion.MmodificarCalificacion(objCalificacion);
        }
    }
}
