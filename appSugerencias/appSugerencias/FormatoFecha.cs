using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias
{
    class FormatoFecha
    {



        public static ArrayList RangoFechas(DateTime inicio, DateTime fin)
        {
            ArrayList fechas = new ArrayList();
            string aux = "";
            for (DateTime dia = inicio; dia <= fin; dia = dia.AddDays(1))
            {
                aux = Convert.ToString(dia.ToShortDateString());
                fechas.Add(aux);
            }

            return fechas;
        }

        public static  String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }

        public static string Mes(int num)
        {
            string mes = "";

            if (num == 1)
            {
                mes = "ENE";
            }

            if (num == 2)
            {
                mes = "FEB";
            }

            if (num == 3)
            {
                mes = "MAR";
            }

            if (num == 4)
            {
                mes = "ABR";
            }

            if (num == 5)
            {
                mes = "MAY";
            }

            if (num == 6)
            {
                mes = "JUN";
            }

            if (num == 7)
            {
                mes = "JUL";
            }

            if (num == 8)
            {
                mes = "AGO";
            }

            if (num == 9)
            {
                mes = "SEP";
            }

            if (num == 10)
            {
                mes = "OCT";
            }

            if (num == 11)
            {
                mes = "NOV";
            }

            if (num == 12)
            {
                mes = "DIC";
            }
            return mes;
        }
    }
}
