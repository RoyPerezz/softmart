using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Modelo
{
    class Egreso
    {
        public int Flujo { get; set; }
        public int Abono { get; set; }
        public string Clave { get; set; }
        public string ConceptoDetalle { get; set; }
        public string ConceptoGral { get; set; }
        public string IE { get; set; }
        public double Importe{ get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string Moneda { get; set; }
        public string Estacion { get; set; }
        public string Usuario { get; set; }
        public string Modulo { get; set; }
        public int Venta { get; set; }
        public int Corte { get; set; }
        public int Tipo_cam { get; set; }
        public int Cargo { get; set; }
        public string Concepto2 { get; set; }
        public  string Banco { get; set; }
        public string Cheque { get; set; }
        public int Verificado { get; set; }

    }
}