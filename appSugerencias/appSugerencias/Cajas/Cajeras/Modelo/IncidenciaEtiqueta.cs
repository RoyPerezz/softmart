using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Cajas.Cajeras.Modelo
{
    public class IncidenciaEtiqueta
    {
        public int Id { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Caja { get; set; }
        public string Incidencia { get; set; }
        public int Estado { get; set; }
        public string RutaFoto { get; set; }
        public string NombreFoto { get; set; }
    }
}
