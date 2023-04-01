using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Modelo
{
    public class GastoAlmacenCedis
    {
        public int Id { get; set; }
        public string Clave { get; set; }
        public string ConceptoGral { get; set; }
        public string ConceptoDetalle { get; set; }
        public string DescripcionDetallada { get; set; }
        public double Importe { get; set; }
        public DateTime Fecha { get; set; }
        public string FolioSalida { get; set; }
        public string FolioAprobacion { get; set; }
        public string Imagen1 { get; set; }
        public string NombreFoto { get; set; }
        public string Imagen2 { get; set; }


        public string NombreFoto2 { get; set; }

        public string EstadoRevision { get; set; }
        public string EstadoAprobacion { get; set; }
        public string Usuario { get; set; }
        public string ComRevision { get; set; }
        public string ComSra { get; set; }
        public bool Actualizar { get; set; }
    }
}
