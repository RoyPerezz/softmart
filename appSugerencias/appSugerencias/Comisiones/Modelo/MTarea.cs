using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Modelo
{
    public  class MTarea
    {
        private int _IdTarea;
        private int _IdRol;
        private string _Descripcion;
        private int _TopeDiario;
        private int _TopeSemanal;
        private MySqlConnection _Conex;

        public int IdTarea { get => _IdTarea; set => _IdTarea = value; }
        public int IdRol { get => _IdRol; set => _IdRol = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int TopeDiario { get => _TopeDiario; set => _TopeDiario = value; }
        public int TopeSemanal { get => _TopeSemanal; set => _TopeSemanal = value; }
        public MySqlConnection Conex { get => _Conex; set => _Conex = value; }

        public MTarea()
        {

        }
        public MTarea(int pidtarea, int pidrol, string pdescripcion, int ptopediario, int ptopesemanal, MySqlConnection pconex)
        {
            this.IdTarea = pidtarea;
            this.IdRol = pidrol;
            this.Descripcion = pdescripcion;
            this.TopeDiario = ptopediario;
            this.TopeSemanal = ptopesemanal;
            this.Conex = pconex;
        }


        //Mostrar Tareas
        public System.Data.DataTable MMostrarTareas(MTarea objTarea)
        {
            System.Data.DataTable dtresultado = new System.Data.DataTable();
            dtresultado.Columns.Add("idtarea", typeof(String));
            dtresultado.Columns.Add("idrol", typeof(String));
            dtresultado.Columns.Add("DESCRIPCION", typeof(String));
            dtresultado.Columns.Add("TOPE DIARIO", typeof(String));
            dtresultado.Columns.Add("TOPE SEMANAL", typeof(String));
            try
            {


                MySqlCommand cmd = new MySqlCommand("SELECT * FROM rd_tareas WHERE idrol=?idrol", objTarea.Conex);
                cmd.Parameters.AddWithValue("?idrol", objTarea.IdRol);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dtresultado.Rows.Add(dr["idtarea"].ToString(), dr["idrol"].ToString(), dr["descripcion"].ToString(), dr["topediario"].ToString(), dr["topesemanal"].ToString());
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

        //Agregar Empleados
        public string MAgregarTarea(MTarea objTarea)
        {
            string resultado = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO rd_tareas (idrol,descripcion,topediario,topesemanal)VALUES(?idrol,?descripcion,?topediario,?topesemanal)", objTarea.Conex);
                cmd.Parameters.AddWithValue("?idrol", objTarea.IdRol);
                cmd.Parameters.AddWithValue("?descripcion", objTarea.Descripcion);
                cmd.Parameters.AddWithValue("?topediario", objTarea.TopeDiario);
                cmd.Parameters.AddWithValue("?topesemanal", objTarea.TopeSemanal);


                resultado = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
            }
            catch (Exception er)
            {
                resultado = er.Message;
            }

            return resultado;
        }


        //Modificar 
        public string MModificarTarea(MTarea objTarea)
        {
            string resultado = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE rd_tareas SET descripcion=?descripcion,topediario=?topediario,topesemanal=?topesemanal WHERE idtarea=?idtarea", objTarea.Conex);
                cmd.Parameters.AddWithValue("?descripcion", objTarea.Descripcion);
                cmd.Parameters.AddWithValue("?topediario", objTarea.TopeDiario);
                cmd.Parameters.AddWithValue("?topesemanal", objTarea.TopeSemanal);
                cmd.Parameters.AddWithValue("?idtarea", objTarea.IdTarea);


                resultado = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
            }
            catch (Exception er)
            {
                resultado = er.Message;
            }

            return resultado;
        }

        //Eliminar Tarea
        public string MEliminaTarea(MTarea objTarea)
        {
            string resultado = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM rd_tareas WHERE idtarea=?idtarea", objTarea.Conex);
                cmd.Parameters.AddWithValue("?idtarea", objTarea.IdTarea);



                resultado = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
            }
            catch (Exception er)
            {
                resultado = er.Message;
            }

            return resultado;
        }
    }
}
