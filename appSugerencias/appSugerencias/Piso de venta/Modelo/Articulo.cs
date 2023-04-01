using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Piso_de_venta.Modelo
{
    class Articulo
    {
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public string Linea { get; set; }
        public string LineaDescrip { get; set; }
        public string Marca { get; set; }
        public double PrecioMenudeo { get; set; }
        public double PrecioMayoreo { get; set; }
        public int Existencia { get; set; }
        public double CostoU { get; set; }
        public string TipoImpuesto { get; set; }
        public string Fabricante { get; set; }
        public string ClaveSAT { get; set; }
        public string DescripcionSAT { get; set; }
        public string UnidadSAT { get; set; }
        public string UnidadDescripSAT { get; set; }



    }
}
