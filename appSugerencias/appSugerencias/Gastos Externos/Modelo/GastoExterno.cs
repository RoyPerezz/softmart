using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos_Externos.Modelo
{
    public class GastoExterno
    {
        public int Id { get; set; }
        public string Nombre_Gasto { get; set; }
        public string Concepto_gral { get; set; }

        public string ConceptoDetalle { get; set; }
        public string Tipo_gasto_ex { get; set; }
        public DateTime Fecha { get; set; }
        public string Folio { get; set; }
        public double Importe { get; set; }
        public string PersonaGeneraGasto { get; set; }
        public string Descripcion { get; set; }

        public string Foto1 { get; set; }
        public string NombreFoto1 { get; set; }
        public string NombreFoto2 { get; set; }
        public string Foto2 { get; set; }
        public string EstadoAprobacion { get; set; }
        public string ComentarioAprobacion { get; set; }

        public string NumAutorizacion { get; set; }
        public bool Actualizar { get; set; }
        public int Revisado { get; set; }
    }
}
