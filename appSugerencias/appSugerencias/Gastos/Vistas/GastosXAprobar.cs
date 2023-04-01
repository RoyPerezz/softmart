using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class GastosXAprobar : Form
    {
        string sucursal = "";
        public GastosXAprobar(string sucursal)
        {
            this.sucursal = sucursal;
            InitializeComponent();
        }

        private void GastosXAprobar_Load(object sender, EventArgs e)
        {
            
            RevisionGastosController gc = new RevisionGastosController();
            List<Gasto> lista = gc.BuscarGastosXAprobar(sucursal);
            foreach (var item in lista)
            {
                
                DG_tabla.Rows.Add(item.Fecha.ToString("dd-MM-yyyy"),item.CantGastos);
            }
        }
    }
}
