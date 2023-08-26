using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Stock_Compras.Modelo
{
    public class DetalleStockCompra
    {
        public int Id { get; set; }
        public int Fk_stock { get; set; }
        public string Modelo { get; set; }
        public string ClaveProducto { get; set; }
        public string Descripcion { get; set; }
        public string Departamento { get; set; }
        public int PzXPedir { get; set; }
        public double CajasXPedir { get; set; }
        public int CajasPeBo { get; set; }
        public int PzXCaja { get; set; }
        public int PzXpaq { get; set; }
        public double CostoXPaq { get; set; }
        public double CostoXPz { get; set; }
        public int Ped_bo { get; set; }
        public double Importe_bo { get; set; }
        public int Max_ce { get; set; }
        public int Ex_ce { get; set; }
        public int Ped_ce { get; set; }
        public double Importe_ce { get; set; }
        public int Max_va { get; set; }
        public int Ex_va { get; set; }
        public int Ex_pasada_va { get; set; }
        public int Ped_va { get; set; }
        public double Importe_va { get; set; }
        public int Max_re { get; set; }
        public int Ex_re { get; set; }
        public int Ex_pasada_re { get; set; }
        public int Ped_re { get; set; }
        public double Importe_re { get; set; }
        public int Max_ve { get; set; }
        public int Ex_ve { get; set; }
        public int Ex_pasada_ve { get; set; }
        public int Ped_ve { get; set; }
        public double Importe_ve { get; set; }
        public int Max_co { get; set; }
        public int Ex_co { get; set; }
        public int Ex_pasada_co { get; set; }
        public int Ped_co { get; set; }
        public double Importe_co { get; set; }
        public int Oferta { get; set; }
        public double CostoU { get; set; }
        public string Comentario { get; set; }
        public double PrecioMayoreo { get; set; }
        public double PrecioMenudeo { get; set; }
        public double PrecioManual { get; set; }

        public int Falta_bo { get; set; }
        public int Mal_estado_bo { get; set; }
        public int Sobrante_bo { get; set; }
        public double total_aclaracion_bo { get; set; }
        public int Falta_va { get; set; }
        public int Mal_estado_va { get; set; }
        public int Sobrante_va { get; set; }
        public double total_aclaracion_va { get; set; }
        public int Falta_re { get; set; }
        public int Mal_estado_re { get; set; }
        public int Sobrante_re { get; set; }
        public double total_aclaracion_re { get; set; }
        public int Falta_ve { get; set; }
        public int Mal_estado_ve { get; set; }
        public int Sobrante_ve { get; set; }
        public double total_aclaracion_ve { get; set; }
        public int Falta_co { get; set; }
        public int Mal_estado_co { get; set; }
        public int Sobrante_co { get; set; }
        public double total_aclaracion_co { get; set; }

        public int Total_faltante { get; set; }
        public int Total_sobrante { get; set; }
        public double Importe_total_aclaracion { get; set; }
    }
}
