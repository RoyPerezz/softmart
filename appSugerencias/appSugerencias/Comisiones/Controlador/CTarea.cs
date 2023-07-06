using appSugerencias.Comisiones.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Controlador
{
    public class CTarea
    {
        //Mostrar Tarea
        public static System.Data.DataTable CMostrarTareas(int pidrol, MySqlConnection pconex)
        {
            MTarea objTarea = new MTarea();
            objTarea.IdRol = pidrol;
            objTarea.Conex = pconex;

            return objTarea.MMostrarTareas(objTarea);
        }

        //Agregar Empleado
        public static string CAgregarTarea(int pidrol, string pdescripcion, int ptopediario, int ptopesemanal, MySqlConnection pconex)
        {
            MTarea objTarea = new MTarea();
            objTarea.IdRol = pidrol;
            objTarea.Descripcion = pdescripcion;
            objTarea.TopeDiario = ptopediario;
            objTarea.TopeSemanal = ptopesemanal;
            objTarea.Conex = pconex;

            return objTarea.MAgregarTarea(objTarea);
        }

        //Modificar Empleado
        public static string CModificarTarea(int pidtarea, string pdescripcion, int ptopediario, int ptopesemanal, MySqlConnection pconex)
        {
            MTarea objTarea = new MTarea();
            objTarea.IdTarea = pidtarea;
            objTarea.Descripcion = pdescripcion;
            objTarea.TopeDiario = ptopediario;
            objTarea.TopeSemanal = ptopesemanal;
            objTarea.Conex = pconex;

            return objTarea.MModificarTarea(objTarea);
        }

        //Elimina Tarea
        public static string CEliminaTarea(int pidtarea, MySqlConnection pconex)
        {
            MTarea objTarea = new MTarea();
            objTarea.IdTarea = pidtarea;


            objTarea.Conex = pconex;

            return objTarea.MEliminaTarea(objTarea);
        }
    }
}
