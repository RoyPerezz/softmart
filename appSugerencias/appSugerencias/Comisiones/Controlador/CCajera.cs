using appSugerencias.Comisiones.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Comisiones.Controlador
{
    public class CCajera
    {

        public static int CClientesAtendidos(string pusuario, DateTime pfechainicio, DateTime pfechafin, MySqlConnection pconex)
        {
            MCajera objCajera = new MCajera();
            objCajera.Usuario = pusuario;
            objCajera.fechaInicio = pfechainicio;
            objCajera.fechaFin = pfechafin;
            objCajera.Conex = pconex;

            return MCajera.MClientesAtendidos(objCajera);


        }
    }
}
