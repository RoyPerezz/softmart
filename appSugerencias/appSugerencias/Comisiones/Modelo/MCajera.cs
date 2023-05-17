using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Modelo
{
    public class MCajera : MEmpleados
    {
        public int clientesAtendidos;
        public DateTime fechaInicio;
        public DateTime fechaFin;

        //Mostrar Empleados
        public static int MClientesAtendidos(MCajera objCajera)
        {
            //List<MCajera> listaCajeras = new List<MCajera>();
            int clientesAtendidos = 0;
            try
            {
                //SELECT id_consec,nombres,apellido_pa,apellido_ma,rol, huella FROM rd_empleados ORDER BY id_consec DESC
                MySqlCommand cmdr = new MySqlCommand("SELECT COUNT(VENTA) as ventas FROM ventas WHERE USUARIO=?usuario AND USUFECHA BETWEEN ?fechaInicio AND ?fechaFin", objCajera.Conex);
                cmdr.Parameters.AddWithValue("?usuario", objCajera.Usuario);
                cmdr.Parameters.AddWithValue("?fechaInicio", objCajera.fechaInicio);
                cmdr.Parameters.AddWithValue("?fechaFin", objCajera.fechaFin);


                MySqlDataReader dr = cmdr.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        clientesAtendidos = Convert.ToInt32(dr["ventas"].ToString());


                    }
                }

                dr.Close();
            }
            catch (Exception er)
            {
                return 0;
            }

            return clientesAtendidos;
        }
    }
}
