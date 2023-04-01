using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class DefineTiendaIP
    {
        public static string defineTienda()
        {
            string tienda = "";

            string ip = BDConexicon.optieneIp().Substring(8, 1);

            if ("0" == ip)
            {
                tienda = "CEDIS";
            }
            else if ("1" == ip)
            {
                tienda = "VA";

            }
            else if ("2" == ip)
            {
                tienda = "RE";

            }
            else if ("3" == ip)
            {
                tienda = "CO";

            }
            else if ("4" == ip)
            {
                tienda = "VL";
            }
            else
            {
                tienda = "NA";
            }


            return tienda;

        }
    }
}
