using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Facturacion.Modelo
{
    class CantidadFacturar
    {
        public double TotalVenta { get; set; }
        public double DepositoVentanilla { get; set; }
        public double DepositoPana { get; set; }
        public bool CheckDepositado { get; set; }
        public double FacturacionEFE { get; set; }
        public double FacturacionTAR { get; set; }
        public double TotalFacturado { get; set; }
        public double  VentasEFE { get; set; }
        public double Baucher { get; set; }
        public double FacturaGlobal { get; set; }
        public double  Efectivo { get; set; }
        public double Tarjeta { get; set; }
        public bool CheckFacturaElaborada { get; set; }

    }
}
