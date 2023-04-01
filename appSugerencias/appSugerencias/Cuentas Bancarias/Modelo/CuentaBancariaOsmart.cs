using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Cuentas_Bancarias.Modelo
{
    class CuentaBancariaOsmart
    {
        public int Id { get; set; }
        public string SucursalCuenta { get; set; }
        public string Mov { get; set; }
        public char IE { get; set; }
        public string Banco { get; set; }
        public string Cuenta { get; set; }
        public string ClienteBancario { get; set; }
        public double Importe { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int FK_GastoExterno { get; set; }
        public string Ref_GastoExterno { get; set; }
        public string Suc_pago { get; set; }
        public int FK_flujo { get; set; }
    }
}
