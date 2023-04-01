using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Ventas.Modelo
{
    public class VentasXTicket
    {
        public int Venta { get; set; }
        public int Ocupado { get; set; }
        public string Tipo_Doc { get; set; }
        public int No_referen { get; set; }
        public DateTime F_Emision { get; set; }
        public DateTime F_vencimiento { get; set; }
        public int Cliente { get; set; }
        public string Vendedor { get; set; }
        public double Importe { get; set; }
        public int Descuento { get; set; }
        public double Impuesto { get; set; }
        public string Usuario { get; set; }
        public string Estado { get; set; }
        public string UsuHora { get; set; }
        
        public string Caja { get; set; }

        public string ventaDev { get; set; }
    }
}
