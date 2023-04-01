using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos_Externos.Modelo
{
    public class GastoExternoPago
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public double Importe { get; set; }

        public int IdGastoExterno { get; set; }
        public string ConceptoDetalle { get; set; }
        public string  ConceptoGral { get; set; }
        public string TipoGasto { get; set; }
        public string Usuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Observacion { get; set; }
    }
}
