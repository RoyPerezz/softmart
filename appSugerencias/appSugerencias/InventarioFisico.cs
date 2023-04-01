using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class InventarioFisico
    {
        public string articulo { get; set; }
        public string descripcion { get; set; }




        public MySqlConnection ConexionSucursal(string sucursal)
        {
            MySqlConnection con = null;

            if (sucursal.Equals("VALLARTA"))
            {
                con = BDConexicon.VallartaOpen();
            }

            if (sucursal.Equals("RENA"))
            {
                con = BDConexicon.RenaOpen();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                con = BDConexicon.VelazquezOpen();
            }

            if (sucursal.Equals("COLOSO"))
            {
                con = BDConexicon.ColosoOpen();
            }

            if (sucursal.Equals("PREGOT"))
            {
                con = BDConexicon.Papeleria1Open();
            }
            return con;
        }

        public DataTable ArticulosSinMov(string sucursal,string linea)
        {
            DataTable tabla = new DataTable();

            //string consulta = "select ms.articulo as ARTICULO,p.descrip as DESCRIPCION, ms.ENT_SAL as MOVIMIENTO,max(ms.F_MOVIM ) AS FECHA, p.existencia as EXISTENCIA " +
            //    "from movsinv ms inner join prods p on ms.articulo = p.articulo " +
            //    "where p.linea = '"+linea+ "'  and p.existencia > 0  and  (ms.TIPO_MOVIM='TK' OR ms.TIPO_MOVIM='COM' OR ms.TIPO_MOVIM='A+' OR ms.TIPO_MOVIM='A-' OR ms.TIPO_MOVIM='T+' OR ms.TIPO_MOVIM='T-' ) group by ms.articulo";

            //string consulta = "select ms.articulo as ARTICULO,p.descrip as DESCRIPCION, ms.ENT_SAL as MOVIMIENTO,max(ms.F_MOVIM ) AS FECHA, p.existencia as EXISTENCIA " +
            //   "from movsinv ms inner join prods p on ms.articulo = p.articulo " +
            //   "where p.linea = '" + linea + "'  and p.existencia > 0  and  TIPO_MOVIM  IN ('TK','COM','A+','A-','T+','T-') group by ms.articulo";

            string consulta = "select ms.articulo as ARTICULO,p.descrip as DESCRIPCION,p.precio1,p.precio2, ms.ENT_SAL as MOVIMIENTO,max(ms.F_MOVIM ) AS FECHA, p.existencia as EXISTENCIA " +
        "from movsinv ms, prods p where ms.articulo = p.articulo " +
        "and p.linea = '" + linea + "'  and p.existencia > 0  and  TIPO_MOVIM  IN ('TK','COM','A+','A-','T+','T-') group by ms.articulo";
            MySqlConnection con = ConexionSucursal(sucursal);

            MySqlCommand cmd = new MySqlCommand(consulta,con);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            ad.Fill(tabla);


            con.Close();
            return tabla;
        }

        //RECALCULA LA EXISTENCIA DEL ARTICULO
        public void Recalcular(string articulo,MySqlConnection conexion, MySqlDataReader dr)
        {
            
              
                string query = "SELECT ENT_SAL,EXISTENCIA FROM MOVSINV WHERE ARTICULO='" + articulo + "'";
                int entrada = 0;
                int salida = 0;
                int existencia = 0;


                MySqlCommand cmd = new MySqlCommand(query, conexion);
               
                while (dr.Read())
                {
                     if (dr["ENT_SAL"].ToString().Equals("E"))
                     {
                        entrada = Convert.ToInt32(dr["EXISTENCIA"].ToString());
                     }


                    if (dr["ENT_SAL"].ToString().Equals("S"))
                    {
                        salida = Convert.ToInt32(dr["EXISTENCIA"].ToString());
                    }
                }
            dr.Close();
            existencia = entrada - salida;

                string actualizarExistencia = "UPDATE PRODS SET EXISTENCIA ="+existencia+" WHERE ARTICULO='"+articulo+"'";

                MySqlCommand actualizar = new MySqlCommand(actualizarExistencia,conexion);
                actualizar.ExecuteNonQuery();
           
        }



    }
}
