using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace appSugerencias
{
    class Empleado
    {

        public string id_consec { get; set; }
        public string id_empleado { get; set; }
        public string id_checador { get; set; }
        public int ultimoInsertId { get; set; }
        public string nombres { get; set; }
        public string apellido_pa { get; set; }
        public string apellido_ma { get; set; }
        public string rol { get; set; }
        public double salario { get; set; }
        public string usuario { get; set; }
        public string patron { get; set; }

        //guarda un empleado primero en CEDIS y optione su id para el resto de tiendas
        public bool guardar1(MySqlConnection Conex)
        {
            //=================================================== ACTUALIZAR  CONSECUTIVO BD ORIGEN ====================================================
            MySqlCommand cmdR = new MySqlCommand("INSERT INTO rd_empleados (id_empleado,id_checador,nombres,apellido_pa,apellido_ma,salario,rol,usuario,fk_patron) " +
                "values(?id_empleado,?id_checador,?nombres,?apellido_pa,?apellido_ma,?salario,?rol,?usuario,?fk_patron)", Conex);
            cmdR.Parameters.Add("?id_empleado", MySqlDbType.VarChar).Value = id_empleado;
            cmdR.Parameters.Add("?id_checador", MySqlDbType.VarChar).Value = id_checador;
            cmdR.Parameters.Add("?nombres", MySqlDbType.VarChar).Value = nombres;
            cmdR.Parameters.Add("?apellido_pa", MySqlDbType.VarChar).Value = apellido_pa;
            cmdR.Parameters.Add("?apellido_ma", MySqlDbType.VarChar).Value = apellido_ma;
            cmdR.Parameters.Add("?salario", MySqlDbType.Float).Value = salario;
            cmdR.Parameters.Add("?rol", MySqlDbType.VarChar).Value = rol;
            cmdR.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usuario;
            cmdR.Parameters.Add("?fk_patron", MySqlDbType.VarChar).Value = patron;


            if (cmdR.ExecuteNonQuery() == 1)
            {
                ultimoInsertId = Convert.ToInt32(cmdR.LastInsertedId);
                return true;
            }
            else
            {
                return false;
            }
        }

        //con el Id de bodega se guarda en el resto de sucursales
        public bool guardar2(MySqlConnection Conex)
        {
            //=================================================== ACTUALIZAR  CONSECUTIVO BD ORIGEN ====================================================
            MySqlCommand cmdR = new MySqlCommand("INSERT INTO rd_empleados (id_consec,id_empleado,id_checador,nombres,apellido_pa,apellido_ma,salario,rol,usuario,fk_patron) " +
                "values(?id_consec,?id_empleado,?id_checador,?nombres,?apellido_pa,?apellido_ma,?salario,?rol,?usuario,?fk_patron)", Conex);
            cmdR.Parameters.Add("?id_consec", MySqlDbType.VarChar).Value = ultimoInsertId;
            cmdR.Parameters.Add("?id_empleado", MySqlDbType.VarChar).Value = id_empleado;
            cmdR.Parameters.Add("?id_checador", MySqlDbType.VarChar).Value = id_checador;
            cmdR.Parameters.Add("?nombres", MySqlDbType.VarChar).Value = nombres;
            cmdR.Parameters.Add("?apellido_pa", MySqlDbType.VarChar).Value = apellido_pa;
            cmdR.Parameters.Add("?apellido_ma", MySqlDbType.VarChar).Value = apellido_ma;
            cmdR.Parameters.Add("?salario", MySqlDbType.Float).Value = salario;
            cmdR.Parameters.Add("?rol", MySqlDbType.VarChar).Value = rol;
            cmdR.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usuario;
            cmdR.Parameters.Add("?fk_patron", MySqlDbType.VarChar).Value = patron;



            if (cmdR.ExecuteNonQuery() == 1)
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        //Actualiza la informacion de un empleado
        public bool actualizar(MySqlConnection Conex)
        {
            //=================================================== ACTUALIZAR  CONSECUTIVO BD ORIGEN ====================================================
            MySqlCommand cmdR = new MySqlCommand("UPDATE rd_empleados SET id_empleado=?id_empleado,id_checador=?id_checador,nombres=?nombres,apellido_pa=?apellido_pa,apellido_ma=?apellido_ma,salario=?salario,rol=?rol,usuario=?usuario WHERE id_consec='" + id_consec + "'", Conex);

            cmdR.Parameters.Add("?id_empleado", MySqlDbType.VarChar).Value = id_empleado;
            cmdR.Parameters.Add("?id_checador", MySqlDbType.VarChar).Value = id_checador;
            cmdR.Parameters.Add("?nombres", MySqlDbType.VarChar).Value = nombres;
            cmdR.Parameters.Add("?apellido_pa", MySqlDbType.VarChar).Value = apellido_pa;
            cmdR.Parameters.Add("?apellido_ma", MySqlDbType.VarChar).Value = apellido_ma;
            cmdR.Parameters.Add("?salario", MySqlDbType.Float).Value = salario;
            cmdR.Parameters.Add("?rol", MySqlDbType.VarChar).Value = rol;
            cmdR.Parameters.Add("?usuario", MySqlDbType.VarChar).Value = usuario;



            if (cmdR.ExecuteNonQuery() == 1)
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        //Carga un data grid con la informacion de los empleado
        public static void consultaEmpleados(MySqlConnection Conex, DataGridView dgv)
        {
            try
            {



                double salario;
                string comando = "SELECT id_consec,id_empleado, id_checador, nombres, apellido_pa, apellido_ma,salario,rol,fk_patron  FROM rd_empleados ORDER BY id_consec DESC";


                MySqlCommand cmd = new MySqlCommand(comando, Conex);


                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt3 = new System.Data.DataTable();



                adaptador.Fill(dt3);

                dgv.Rows.Clear();

                foreach (DataRow item in dt3.Rows)
                {
                    int n = dgv.Rows.Add();
                    salario = 0;

                    dgv.Rows[n].Cells[0].Value = item["id_consec"].ToString();
                    dgv.Rows[n].Cells[1].Value = item["id_empleado"].ToString();
                    dgv.Rows[n].Cells[2].Value = item["id_checador"].ToString();
                    dgv.Rows[n].Cells[3].Value = item["nombres"].ToString();
                    dgv.Rows[n].Cells[4].Value = item["apellido_pa"].ToString();
                    dgv.Rows[n].Cells[5].Value = item["apellido_ma"].ToString();

                    salario = Convert.ToDouble(item["salario"]);
                    dgv.Rows[n].Cells[6].Value = item["salario"].ToString();
                    dgv.Rows[n].Cells[7].Value = salario.ToString("C");

                    dgv.Rows[n].Cells[8].Value = item["rol"].ToString();
                    dgv.Rows[n].Cells[9].Value = item["fk_patron"].ToString();


                }

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {

            }

        }

        public static string Area(string usuario)
        {
            string area = "";
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT AREA FROM usuarios WHERE USUARIO='"+usuario+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                area = dr["AREA"].ToString();
            }


            return area;
        }

    }
}
