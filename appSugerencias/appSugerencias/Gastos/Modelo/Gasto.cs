using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Modelo
{
    class Gasto
    {
        public int Id { get; set; }
        public string Concepto { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }
        public string Detalle { get; set; }
        public string RutaFoto { get; set; }
        public string NombreFoto { get; set; }
        public string RutaFoto2 { get; set; }
        public string NombreFoto2 { get; set; }
        public string RutaFoto3 { get; set; }
        public string NombreFoto3 { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioAplico { get; set; }
        public string ComentarioRevision { get; set; }
        public string ComentarioRevision2 { get; set; }
        public int Revision1 { get; set; }
        public string NumAutorizacion { get; set; }
        public int Revision2 { get; set; }
        public string Estado { get; set; }
        public string Ticket { get; set; }
        public string Encajas { get; set; }
        public string Revision { get; set; }
        public  string Tipo_egreso { get; set; }
        public string ConceptoGral { get; set; }
        public string ComentarioSRA { get; set; }
        public string Clave { get; set; }
        public string Caja { get; set; }
        public int CantGastos { get; set; }
    }
}
