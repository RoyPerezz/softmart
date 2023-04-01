using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace appSugerencias.Gastos.Modelo
{
    public interface IDatos
    {

        void DatosGastoEncCajas(string comentario, string rutaFoto,int fila,string nombreFoto,int id,string rutafoto2,string nombreFoto2,string rutaFoto3, string nombreFoto3);
        void GastosPorCorregir(string comentario, string rutaFoto, int fila, string nombreFoto, int id, string rutafoto2, string nombreFoto2, string rutaFoto3, string nombreFoto3);
    }
}
