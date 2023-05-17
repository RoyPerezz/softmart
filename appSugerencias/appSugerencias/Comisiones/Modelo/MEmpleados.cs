using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Modelo
{
    public  class MEmpleados
    {
        private string _Codigo;
        private string _Nombre;
        private string _Usuario;
        private int _Rol;
        private string _NombreRol;
        private int _Score;
        private MySqlConnection _Conex;

        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public int Rol { get => _Rol; set => _Rol = value; }

        public string NombreRol { get => _NombreRol; set => _NombreRol = value; }

        public int Score { get => _Score; set => _Score = value; }
        public MySqlConnection Conex { get => _Conex; set => _Conex = value; }
        public MEmpleados()
        {

        }

        public MEmpleados(string pidempleado, string pnombre, string pusuario, int prol, string pnombrerol, int pscore, MySqlConnection pconex)
        {
            this.Codigo = pidempleado;
            this.Nombre = pnombre;
            this.Usuario = pusuario;
            this.Rol = prol;
            this.NombreRol = pnombrerol;
            this.Conex = pconex;
            this.Score = pscore;

        }
        //Agregar Empleados
        public string MAgregarEmpleado(MEmpleados objEmpleado)
        {
            string resultado = "";
            bool calificacionExiste;
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM rd_empleadoss WHERE codigo=?codigo", objEmpleado.Conex);
                cmd1.Parameters.AddWithValue("?codigo", objEmpleado.Codigo);
                MySqlDataReader dr = cmd1.ExecuteReader();

                calificacionExiste = dr.HasRows;
                dr.Close();

                if (!calificacionExiste)
                {
                    MySqlCommand cmd = new MySqlCommand("insert into rd_empleadoss(codigo,nombre,usuario,rol,activo) values(?codigo,?nombre,?usuario,?rol,1)", objEmpleado.Conex);
                    cmd.Parameters.AddWithValue("?codigo", objEmpleado.Codigo);
                    cmd.Parameters.AddWithValue("?nombre", objEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("?usuario", objEmpleado.Nombre);
                    cmd.Parameters.AddWithValue("?rol", objEmpleado.Rol);


                    resultado = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
                }
                else
                {
                    resultado = "El codigo de empleado ya esta registrado";
                }


            }
            catch (Exception er)
            {
                resultado = er.Message;
            }

            return resultado;
        }
        //Mostrar Empleados
        public System.Data.DataTable MMostrarEmpledos2(MEmpleados objEmpleado)
        {
            System.Data.DataTable dtresultado = new System.Data.DataTable();
            dtresultado.Columns.Add("codigo", typeof(String));
            dtresultado.Columns.Add("nombre", typeof(String));
            dtresultado.Columns.Add("usuario", typeof(String));
            dtresultado.Columns.Add("rol", typeof(String));
            dtresultado.Columns.Add("nombre_rol", typeof(String));
            try
            {


                MySqlCommand cmd = new MySqlCommand("SELECT codigo,nombre,usuario,rol,nombre_rol FROM rd_empleadoss INNER JOIN rd_rol ON rd_empleadoss.rol = rd_rol.id WHERE rd_empleadoss.activo=1 ORDER BY codigo DESC", objEmpleado.Conex);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dtresultado.Rows.Add(dr["codigo"].ToString(), dr["nombre"].ToString(), dr["usuario"].ToString(), dr["rol"].ToString(), dr["nombre_rol"].ToString());
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

        ////Mostrar Empleados
        //public System.Data.DataTable MMostrarEmpledosPorRol(MEmpleados objEmpleado)
        //{
        //    System.Data.DataTable dtresultado = new System.Data.DataTable();
        //    dtresultado.Columns.Add("codigo", typeof(String));
        //    dtresultado.Columns.Add("nombre", typeof(String));
        //    dtresultado.Columns.Add("rol", typeof(String));
        //    dtresultado.Columns.Add("nombre_rol", typeof(String));
        //    try
        //    {


        //        MySqlCommand cmd = new MySqlCommand("SELECT codigo,nombre,rol,nombre_rol FROM rd_empleadoss INNER JOIN rd_rol ON rd_empleadoss.rol = rd_rol.id WHERE rd_empleadoss.activo=1 and rd_empleadoss.rol=?rol", objEmpleado.Conex);
        //        cmd.Parameters.AddWithValue("?rol", objEmpleado.Rol);
        //        MySqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.HasRows)
        //        {
        //            while (dr.Read())
        //            {
        //                dtresultado.Rows.Add(dr["codigo"].ToString(), dr["nombre"].ToString(), dr["rol"].ToString(), dr["nombre_rol"].ToString());
        //            }
        //        }
        //        dr.Close();
        //    }
        //    catch (Exception er)
        //    {
        //        dtresultado = null;
        //    }
        //    return dtresultado;

        //}

        //Mostrar Empleados
        public List<MEmpleados> MMostrarEmpledos(MEmpleados objEmpleado)
        {
            List<MEmpleados> listaEmpleados = new List<MEmpleados>();
            try
            {
                //SELECT id_consec,nombres,apellido_pa,apellido_ma,rol, huella FROM rd_empleados ORDER BY id_consec DESC
                MySqlCommand cmdr = new MySqlCommand("SELECT * FROM rd_empleadoss", objEmpleado.Conex);

                MySqlDataReader dr = cmdr.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MEmpleados oEmpleado = new MEmpleados();
                        oEmpleado.Codigo = dr["codigo"].ToString();
                        oEmpleado.Nombre = dr["nombre"].ToString();
                        oEmpleado.Rol = Convert.ToInt32(dr["rol"].ToString());




                        listaEmpleados.Add(oEmpleado);


                    }
                }

                dr.Close();
            }
            catch (Exception er)
            {
                listaEmpleados = null;
            }
            return listaEmpleados;
        }

        //Consultar Empleado
        public List<MEmpleados> MConsultaEmpleado(MEmpleados objEmpleado)
        {
            List<MEmpleados> listaEmpleados = new List<MEmpleados>();
            try
            {
                //SELECT id_consec,nombres,apellido_pa,apellido_ma,rol, huella FROM rd_empleados ORDER BY id_consec DESC
                MySqlCommand cmdr = new MySqlCommand("SELECT codigo,nombre,usuario,rol,nombre_rol FROM rd_empleadoss INNER JOIN rd_rol ON rd_empleadoss.rol = rd_rol.id WHERE rd_empleadoss.activo=1 and nombre LIKE'%" + objEmpleado.Nombre + "%'", objEmpleado.Conex);
                //cmdr.Parameters.AddWithValue("?nombre", objEmpleado.Nombre);
                MySqlDataReader dr;
                dr = cmdr.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {


                        MEmpleados oEmpleado = new MEmpleados();
                        oEmpleado.Codigo = dr["codigo"].ToString();
                        oEmpleado.Nombre = dr["nombre"].ToString();
                        oEmpleado.Usuario = dr["usuario"].ToString();
                        oEmpleado.NombreRol = dr["nombre_rol"].ToString();
                        oEmpleado.Rol = Convert.ToInt32(dr["rol"].ToString());




                        listaEmpleados.Add(oEmpleado);


                    }
                }

                dr.Close();
            }
            catch (Exception er)
            {
                listaEmpleados = null;
            }
            return listaEmpleados;
        }

        //Modificar 
        public string MModificaEmpleado(MEmpleados objEmpleado)
        {
            string resultado = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE rd_empleadoss SET nombre=?nombre,usuario=?usuario,rol=?rol WHERE codigo=?codigo", objEmpleado.Conex);
                cmd.Parameters.AddWithValue("?codigo", objEmpleado.Codigo);
                cmd.Parameters.AddWithValue("?nombre", objEmpleado.Nombre);
                cmd.Parameters.AddWithValue("?usuario", objEmpleado.Usuario);
                cmd.Parameters.AddWithValue("?rol", objEmpleado.Rol);
                //cmd.Parameters.AddWithValue("?rol", objEmpleado.Rol);


                resultado = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
            }
            catch (Exception er)
            {
                resultado = er.Message;
            }

            return resultado;
        }

        //Eliminar empleado
        public string MEliminaEmpleado(MEmpleados objEmpleado)
        {
            string resultado = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE rd_empleadoss SET activo=0 WHERE codigo=?codigo", objEmpleado.Conex);
                cmd.Parameters.AddWithValue("?codigo", objEmpleado.Codigo);



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
