using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Modelo
{
    public class MRol
    {

        private int _Id;
        private string _Rol;
        private int _CalificaXSemana;
        private int _Activo;
        private MySqlConnection _Conex;

        public int Id { get => _Id; set => _Id = value; }
        public string Rol { get => _Rol; set => _Rol = value; }
        public int CalificaXSemana { get => _CalificaXSemana; set => _CalificaXSemana = value; }
        public int Activo { get => _Activo; set => _Activo = value; }
        public MySqlConnection Conex { get => _Conex; set => _Conex = value; }

        public MRol()
        {

        }

        public MRol(int pid, string prol, int pcalificaxsemana, int pactivo, MySqlConnection pconex)
        {
            this.Id = pid;
            this.Rol = prol;
            this.Activo = pactivo;
            this.Conex = pconex;
            this.CalificaXSemana = pcalificaxsemana;
        }
        //Agregar Rol
        public string MAgregarRol(MRol objRol)
        {
            string resultado = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into rd_rol(nombre_rol,calificaxsemana,activo) values(?rol,?calificaxsemana,?activo)", objRol.Conex);

                cmd.Parameters.AddWithValue("?rol", objRol.Rol);
                cmd.Parameters.AddWithValue("?calificaxsemana", objRol.CalificaXSemana);
                cmd.Parameters.AddWithValue("?activo", objRol.Activo);


                resultado = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se agrego el registro correctamente";
            }
            catch (Exception er)
            {
                resultado = er.Message;
            }

            return resultado;
        }

        //Mostrar Roles
        public List<MRol> MMostrarEmpledos(MRol objRol)
        {
            List<MRol> listaRoles = new List<MRol>();
            try
            {
                //SELECT id_consec,nombres,apellido_pa,apellido_ma,rol, huella FROM rd_empleados ORDER BY id_consec DESC
                MySqlCommand cmdr = new MySqlCommand("SELECT * FROM rd_rol", objRol.Conex);

                MySqlDataReader dr;
                dr = cmdr.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MRol oRol = new MRol();
                        oRol.Id = Convert.ToInt32(dr["id"].ToString());
                        oRol.Rol = dr["nombre_rol"].ToString();
                        oRol.Activo = Convert.ToInt32(dr["activo"].ToString());
                        oRol.CalificaXSemana = Convert.ToInt32(dr["calificaxsemana"].ToString());




                        listaRoles.Add(oRol);


                    }
                }

                dr.Close();
            }
            catch (Exception er)
            {
                listaRoles = null;
            }
            return listaRoles;
        }

        //Consultar Rol
        public List<MRol> MConsultarRol(MRol objRol)
        {
            List<MRol> listaRoles = new List<MRol>();
            try
            {
                //SELECT id_consec,nombres,apellido_pa,apellido_ma,rol, huella FROM rd_empleados ORDER BY id_consec DESC
                MySqlCommand cmdr = new MySqlCommand("SELECT * FROM rd_rol WHERE nombre_rol LIKE'%" + objRol.Rol + "%'", objRol.Conex);
                //cmdr.Parameters.AddWithValue("?nombre", objEmpleado.Nombre);
                MySqlDataReader dr;
                dr = cmdr.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MRol oRol = new MRol();
                        oRol.Id = Convert.ToInt32(dr["id"].ToString());
                        oRol.Rol = dr["nombre_rol"].ToString();
                        oRol.Activo = Convert.ToInt32(dr["activo"].ToString());
                        oRol.CalificaXSemana = Convert.ToInt32(dr["calificaxsemana"].ToString());




                        listaRoles.Add(oRol);


                    }
                }

                dr.Close();
            }
            catch (Exception er)
            {
                listaRoles = null;
            }
            return listaRoles;
        }

        //Modificar Rol
        public string MModificaRol(MRol objRol)
        {
            string resultado = "";
            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE rd_rol SET nombre_rol=?rol,calificaxsemana=?calificaxsemana WHERE id=?id", objRol.Conex);
                cmd.Parameters.AddWithValue("?id", objRol.Id);
                cmd.Parameters.AddWithValue("?rol", objRol.Rol);
                cmd.Parameters.AddWithValue("?calificaxsemana", objRol.CalificaXSemana);



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
