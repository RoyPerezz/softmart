using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Inventario.Modelo
{
    class CostoInventario
    {
        public string ClaveArticulo { get; set; }
        public string DescripcionArticulo { get; set; }
        public double Costo { get; set; }
        public double PrecioMay { get; set; }
    }
}
