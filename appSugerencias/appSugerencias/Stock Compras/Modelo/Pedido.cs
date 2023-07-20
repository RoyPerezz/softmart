using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Stock_Compras.Modelo
{
    public class Pedido
    {
        
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public double Cajas { get; set; }
        public int PzXCaja { get; set; }
        public int PzxPaq { get; set; }

        public int PBodega { get; set; }
        public int PVallarta { get; set; }
        public int PRena { get; set; }
        public int PVelazquez{ get; set; }
        public int PColoso { get; set; }
        public double Costoxpaq { get; set; }
        public double Pmayoreo { get; set; }
        public double Pmenudeo { get; set; }
        public double Descuento { get; set; }
        public double CostoXPz { get; set; }

    }
}
