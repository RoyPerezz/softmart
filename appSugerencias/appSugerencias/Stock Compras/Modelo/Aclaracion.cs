using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Stock_Compras.Modelo
{
    public class Aclaracion
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Clave { get; set; }
        public string Descripcion { get; set; }
        public double PzxPaq { get; set; }
        public double CostoxPaq { get; set; }
        public double CostoxPz { get; set; }
        public int Faltante { get; set; }
        public int Medo { get; set; }
        public int Sobrante { get; set; }
        public double Importe { get; set; }
        public string Surtio { get; set; }
        public string RutaFoto1 { get; set; }
        public string NombreFoto1 { get; set; }
        public string RutaFoto2 { get; set; }
        public string NombreFoto2 { get; set; }
    }
}
