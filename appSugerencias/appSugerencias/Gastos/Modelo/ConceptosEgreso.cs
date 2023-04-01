using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Modelo
{
   public class ConceptosEgreso
    {
        public string Concepto { get; set; }
        public string Descripcion { get; set; }
        public int Presup { get; set; }
        public double Saldo { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Cuenta { get; set; }
        public string ConceptoGral { get; set; }
        public string TipoGasto { get; set; }


    }
}
