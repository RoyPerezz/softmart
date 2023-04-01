using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Utilidades
{
    public class Sucursal
    {
        public static string NombreSucursalIP(string ip)
        {
            string sucursal = "";

            if (ip.Equals("192.168.0.190"))
            {
                sucursal = "CEDIS";

            }else if(ip.Equals("192.168.1.2"))
            {
                sucursal = "VALLARTA";

            }else if(ip.Equals("192.168.2.2"))
            {
                sucursal = "RENA";
            }
            else if (ip.Equals("192.168.4.2"))
            {
                sucursal = "VELAZQUEZ";
            }
            else if (ip.Equals("192.168.3.2"))
            {
                sucursal = "COLOSO";
            }
            else
            {

            }

            return sucursal;
        }
    }
}
