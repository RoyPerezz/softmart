using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Stock_Compras.Modelo
{
    public  class Compra
    {
        public string ClaveProducto { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double Precio_mayoreo { get; set; }
        public double Precio_menudo { get; set; }
        public string  IVA { get; set; }
        public string Linea { get; set; }
        public string Marca { get; set; }
        public string Fabricante { get; set; }
        public int CantidadVA { get; set; }
        public int CantidadRE { get; set; }
        public  int CantidadVE { get; set; }
        public int CantidadCO { get; set; }
        public int CantidadBO { get; set; }

        public int Utilidad { get; set; }
        public int Descuento { get; set; }
        public string Folio { get; set; }
    }
}
