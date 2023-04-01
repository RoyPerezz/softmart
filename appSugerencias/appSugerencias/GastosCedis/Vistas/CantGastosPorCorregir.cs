using appSugerencias.Gastos.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.GastosCedis.Vistas
{
    public partial class CantGastosPorCorregir : Form
    {
        bool rechazado;
        public CantGastosPorCorregir(bool rechazado)
        {
            this.rechazado = rechazado;
            InitializeComponent();
        }

        private void CantGastosPorCorregir_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            if (rechazado==true)
            {
                dt = GastosAlmacenCedisController.GastosRechazados();
                DG_tabla.Columns["CORREGIR"].HeaderText = "REZACHADOS";
            }
            else
            {
                dt = GastosAlmacenCedisController.GastosPorCorregir();
            }
            

            foreach (DataRow row in dt.Rows)
            {
                DG_tabla.Rows.Add(row["FECHA"].ToString(),row["NUMERO"].ToString());
            }
        }
    }
}
