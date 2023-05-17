using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using appSugerencias.Comisiones.Controlador;

namespace appSugerencias.Comisiones.Modelo
{
    public class MCalificacion
    {
        private int _IdCalificacion;
        private int _IdTarea;
        private int _IdRol;
        private string _IdEmpleado;
        private int _Calificacion;
        private DateTime _fechaInicio;
        private DateTime _fechafin;
        private MySqlConnection _Conex;

        private int _IdDescripcion;
        private int _TopeDiario;
        private int _TopeSemanal;

        public int IdCalificacion { get => _IdCalificacion; set => _IdCalificacion = value; }
        public int IdTarea { get => _IdTarea; set => _IdTarea = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string IdEmpleado { get => _IdEmpleado; set => _IdEmpleado = value; }
        public int Calificacion { get => _Calificacion; set => _Calificacion = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaFin { get => _fechafin; set => _fechafin = value; }
        public int TopeDiario { get => _TopeDiario; set => _TopeDiario = value; }
        public int TopeSemanal { get => _TopeSemanal; set => _TopeSemanal = value; }
        public MySqlConnection Conex { get => _Conex; set => _Conex = value; }

        public MCalificacion()
        {

        }
        public MCalificacion(int pidcalificacion, int pidtarea, int pidrol, string pidempleado, int pcalificacion, DateTime pfechainicio,
            DateTime pfechafin, int ptopediario, int ptopesemanal, MySqlConnection pconex)
        {
            this.IdCalificacion = pidcalificacion;
            this.IdTarea = pidtarea;
            this.IdRol = pidrol;
            this.IdEmpleado = pidempleado;
            this.Calificacion = pcalificacion;
            this.FechaInicio = pfechainicio;
            this.FechaFin = pfechafin;
            this.TopeDiario = ptopediario;
            this.TopeSemanal = ptopesemanal;
            this.Conex = pconex;
        }

        //Agregar Calificacion
        public string MAgregarCalificacion(MCalificacion objCalificacion)
        {
            string resultado = "";
            bool calificacionExiste;
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM rd_calificacioness WHERE idtarea=?idtarea and idempleado=?idempleado AND fechaInicio=?fechainicio", objCalificacion.Conex);
                cmd1.Parameters.AddWithValue("?idtarea", objCalificacion.IdTarea);
                cmd1.Parameters.AddWithValue("?idempleado", objCalificacion.IdEmpleado);
                cmd1.Parameters.AddWithValue("?fechainicio", objCalificacion.FechaInicio);

                MySqlDataReader dr = cmd1.ExecuteReader();

                calificacionExiste = dr.HasRows;
                dr.Close();

                if (!calificacionExiste)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_calificacioness (idtarea,idrol,idempleado,calificacion,fechainicio,fechafin) VALUES(?idtarea,?idrol,?idempleado,?calificacion,?fechainicio,?fechafin)", objCalificacion.Conex);
                    cmd.Parameters.AddWithValue("?idtarea", objCalificacion.IdTarea);
                    cmd.Parameters.AddWithValue("?idrol", objCalificacion.IdRol);
                    cmd.Parameters.AddWithValue("?idempleado", objCalificacion.IdEmpleado);
                    cmd.Parameters.AddWithValue("?calificacion", objCalificacion.Calificacion);
                    cmd.Parameters.AddWithValue("?fechainicio", objCalificacion.FechaInicio);
                    cmd.Parameters.AddWithValue("?fechafin", objCalificacion.FechaFin);


                    resultado = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                }


            }
            catch (Exception er)
            {
                resultado = er.Message;
            }

            return resultado;
        }


        //Mostrar Calificaciones
        //Retorna una tabla de las calificaciones
        public System.Data.DataTable MMostrarCalificacion(MCalificacion objCalificacion)
        {
            string comando = "";
            System.Data.DataTable dtresultado = new System.Data.DataTable();
            dtresultado.Columns.Add("idcalificacion", typeof(String));
            dtresultado.Columns.Add("idtarea", typeof(String));
            dtresultado.Columns.Add("idrol", typeof(String));
            dtresultado.Columns.Add("idempleado", typeof(String));
            dtresultado.Columns.Add("calificacion", typeof(String));
            dtresultado.Columns.Add("fechainicio", typeof(String));
            dtresultado.Columns.Add("fechafin", typeof(String));
            dtresultado.Columns.Add("nombre", typeof(String));
            dtresultado.Columns.Add("descripcion", typeof(String));
            dtresultado.Columns.Add("topediario", typeof(String));
            dtresultado.Columns.Add("topesemanal", typeof(String));
            dtresultado.Columns.Add("nombre_rol", typeof(String));
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT rd_calificacioness.idcalificacion, rd_calificacioness.idtarea,rd_calificacioness.idrol,rd_calificacioness.idempleado,calificacion,fechaInicio,fechafin,rd_empleadoss.nombre,rd_tareas.descripcion,topediario,topesemanal,rd_rol.nombre_rol \r\nFROM rd_calificacioness INNER JOIN rd_empleadoss ON rd_empleadoss.codigo=rd_calificacioness.idempleado INNER JOIN rd_tareas ON rd_calificacioness.idtarea=rd_tareas.idtarea\r\nINNER JOIN rd_rol ON rd_calificacioness.idrol=rd_rol.id WHERE fechaInicio=?fechainicio AND fechafin=?fechafin and codigo=?codigo", objCalificacion.Conex);
                cmd.Parameters.AddWithValue("?fechainicio", objCalificacion.FechaInicio);
                cmd.Parameters.AddWithValue("?fechafin", objCalificacion.FechaFin);
                cmd.Parameters.AddWithValue("?codigo", objCalificacion.IdEmpleado);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dtresultado.Rows.Add(dr["idcalificacion"].ToString(), dr["idtarea"].ToString(), dr["idrol"].ToString(), dr["idempleado"].ToString(), dr["calificacion"].ToString(), dr["fechainicio"].ToString(), dr["fechafin"].ToString(), dr["nombre"].ToString(), dr["descripcion"].ToString(), dr["topediario"].ToString(), dr["topesemanal"].ToString(), dr["nombre_rol"].ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception er)
            {
                dtresultado = null;
            }
            return dtresultado;

        }

        //Mostrar Calificaciones 2
        public System.Data.DataTable MMostrarSumaCalificacion(MCalificacion objCalificacion)
        {

            System.Data.DataTable dtresultado = new System.Data.DataTable();

            dtresultado.Columns.Add("codigo", typeof(String));
            dtresultado.Columns.Add("fechainicio", typeof(String));

            dtresultado.Columns.Add("MONTO", typeof(String));
            dtresultado.Columns.Add("NOMBRE", typeof(String));
            dtresultado.Columns.Add("TOPE DIARIO", typeof(String));
            dtresultado.Columns.Add("TOPE SEMANAL", typeof(String));
            dtresultado.Columns.Add("ROL", typeof(String));
            try
            {

                //modificacion
                MySqlCommand cmd = new MySqlCommand("SELECT rd_empleadoss.codigo,fechaInicio,SUM(calificacion) as puntaje,rd_empleadoss.nombre,topediario,topesemanal,rd_rol.nombre_rol  \r\nFROM rd_calificacioness INNER JOIN rd_empleadoss ON rd_empleadoss.codigo=rd_calificacioness.idempleado INNER JOIN rd_tareas ON rd_calificacioness.idtarea=rd_tareas.idtarea\r\nINNER JOIN rd_rol ON rd_calificacioness.idrol=rd_rol.id WHERE  fechaInicio BETWEEN ?fechainicio and ?fechafin GROUP BY codigo ", objCalificacion.Conex);
                cmd.Parameters.AddWithValue("?fechainicio", objCalificacion.FechaInicio);
                cmd.Parameters.AddWithValue("?fechafin", objCalificacion.FechaFin);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //dtresultado.Rows.Add( dr["puntaje"].ToString(), dr["fechainicio"].ToString(), dr["nombre"].ToString(), dr["topediario"].ToString(), dr["topesemanal"].ToString(), dr["nombre_rol"].ToString());
                        dtresultado.Rows.Add(dr["codigo"].ToString(), dr["fechaInicio"].ToString(), dr["puntaje"].ToString(), dr["nombre"].ToString(), dr["topediario"].ToString(), dr["topesemanal"].ToString(), dr["nombre_rol"].ToString());

                    }
                }
                dr.Close();
            }
            catch (Exception er)
            {
                dtresultado = null;
            }
            return dtresultado;

        }
        //Mostrar Calificaciones 2
        public System.Data.DataTable MMostrarSumaCalificacionXRol(MCalificacion objCalificacion)
        {

            System.Data.DataTable dtresultado = new System.Data.DataTable();

            dtresultado.Columns.Add("MONTO", typeof(String));
            dtresultado.Columns.Add("USUARIO", typeof(String));
            dtresultado.Columns.Add("NOMBRE", typeof(String));
            dtresultado.Columns.Add("TOPE DIARIO", typeof(String));
            dtresultado.Columns.Add("TOPE SEMANAL", typeof(String));
            dtresultado.Columns.Add("ROL", typeof(String));
            try
            {

                //modificacion
                MySqlCommand cmd = new MySqlCommand("SELECT rd_empleadoss.usuario,fechaInicio,SUM(calificacion) as puntaje,rd_empleadoss.nombre,topediario,topesemanal,rd_rol.nombre_rol  \r\nFROM rd_calificacioness INNER JOIN rd_empleadoss ON rd_empleadoss.codigo=rd_calificacioness.idempleado INNER JOIN rd_tareas ON rd_calificacioness.idtarea=rd_tareas.idtarea\r\nINNER JOIN rd_rol ON rd_calificacioness.idrol=rd_rol.id WHERE  fechaInicio BETWEEN ?fechainicio and ?fechafin AND rd_rol.id=?id_rol GROUP BY codigo ", objCalificacion.Conex);
                cmd.Parameters.AddWithValue("?fechainicio", objCalificacion.FechaInicio);
                cmd.Parameters.AddWithValue("?fechafin", objCalificacion.FechaFin);
                cmd.Parameters.AddWithValue("?id_rol", objCalificacion.IdRol);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        dtresultado.Rows.Add(dr["puntaje"].ToString(), dr["usuario"].ToString(), dr["nombre"].ToString(), dr["topediario"].ToString(), dr["topesemanal"].ToString(), dr["nombre_rol"].ToString());

                        //if (dr["nombre_rol"].ToString()=="CAJAS")
                        //{
                        //    int clientesAtendidos = CCajera.CClientesAtendidos(dr["usuario"].ToString(), objCalificacion.FechaInicio, objCalificacion.FechaFin, objCalificacion.Conex);
                        //    dtresultado.Rows.Add(clientesAtendidos + Convert.ToInt32(dr["puntaje"].ToString()), dr["nombre"].ToString(), dr["topediario"].ToString(), dr["topesemanal"].ToString(), dr["nombre_rol"].ToString());

                        //}
                        //else
                        //{
                        //    dtresultado.Rows.Add(dr["puntaje"].ToString(), dr["nombre"].ToString(), dr["topediario"].ToString(), dr["topesemanal"].ToString(), dr["nombre_rol"].ToString());

                        //}

                    }
                }
                dr.Close();
                foreach (DataRow empleado in dtresultado.Rows)
                {
                    if (empleado["ROL"].ToString() == "CAJAS")
                    {
                        int clientesAtendidos = CCajera.CClientesAtendidos(empleado["USUARIO"].ToString(), objCalificacion.FechaInicio, objCalificacion.FechaFin, objCalificacion.Conex);
                        empleado["MONTO"] = Convert.ToInt32(empleado["MONTO"]) + clientesAtendidos;
                    }
                }
            }
            catch (Exception er)
            {
                dtresultado = null;
            }
            return dtresultado;

        }

        //Mostrar Suma de Calificaciones 2
        public System.Data.DataTable MMostrarSumaCalificacion2(MCalificacion objCalificacion)
        {

            System.Data.DataTable dtresultado = new System.Data.DataTable();

            dtresultado.Columns.Add("puntaje", typeof(String));
            dtresultado.Columns.Add("fechainicio", typeof(String));
            dtresultado.Columns.Add("nombre", typeof(String));
            dtresultado.Columns.Add("topediario", typeof(String));
            dtresultado.Columns.Add("topesemanal", typeof(String));
            dtresultado.Columns.Add("nombre_rol", typeof(String));
            try
            {

                //modificacion
                MySqlCommand cmd = new MySqlCommand("SELECT fechaInicio,SUM(calificacion) as puntaje,rd_empleadoss.nombre,topediario,topesemanal,rd_rol.nombre_rol  \r\nFROM rd_calificacioness INNER JOIN rd_empleadoss ON rd_empleadoss.codigo=rd_calificacioness.idempleado INNER JOIN rd_tareas ON rd_calificacioness.idtarea=rd_tareas.idtarea\r\nINNER JOIN rd_rol ON rd_calificacioness.idrol=rd_rol.id WHERE fechaInicio=?fechainicio and fechafin=?fechafin GROUP BY codigo", objCalificacion.Conex);
                cmd.Parameters.AddWithValue("?fechainicio", objCalificacion.FechaInicio);
                cmd.Parameters.AddWithValue("?fechafin", objCalificacion.FechaFin);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dtresultado.Rows.Add(dr["puntaje"].ToString(), dr["fechainicio"].ToString(), dr["nombre"].ToString(), dr["topediario"].ToString(), dr["topesemanal"].ToString(), dr["nombre_rol"].ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception er)
            {
                dtresultado = null;
            }
            return dtresultado;

        }

        //Modificar Calificacion
        public string MmodificarCalificacion(MCalificacion objCalificacion)
        {
            string resultado = "";
            bool calificacionExiste;
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM rd_calificacioness WHERE idcalificacion=?idcalificacion and idempleado=?idempleado AND fechaInicio=?fechainicio", objCalificacion.Conex);
                cmd1.Parameters.AddWithValue("?idcalificacion", objCalificacion.IdCalificacion);
                cmd1.Parameters.AddWithValue("?idempleado", objCalificacion.IdEmpleado);
                cmd1.Parameters.AddWithValue("?fechainicio", objCalificacion.FechaInicio);

                MySqlDataReader dr = cmd1.ExecuteReader();

                calificacionExiste = dr.HasRows;
                dr.Close();

                if (calificacionExiste)
                {
                    MySqlCommand cmd = new MySqlCommand("UPDATE rd_calificacioness SET calificacion=?calificacion WHERE idcalificacion=?idcalificacion", objCalificacion.Conex);
                    cmd.Parameters.AddWithValue("?idcalificacion", objCalificacion.IdCalificacion);
                    cmd.Parameters.AddWithValue("?calificacion", objCalificacion.Calificacion);


                    resultado = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                }


            }
            catch (Exception er)
            {
                resultado = er.Message;
            }

            return resultado;
        }
    }
}
