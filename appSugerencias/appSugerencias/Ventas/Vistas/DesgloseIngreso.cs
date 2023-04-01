using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Ventas.Controlador;
using appSugerencias.Ventas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Ventas.Vistas
{
    public partial class DesgloseIngreso : Form
    {

        string clave = "";
        DateTime fecha;
        string sucursal = "";
        bool check = false;
        public DesgloseIngreso(string clave, DateTime fecha,string sucursal,bool check)
        {
            this.clave = clave;
            this.fecha = fecha;
            this.sucursal = sucursal;
            this.check = check;
            InitializeComponent();
        }

        private void DesgloseIngreso_Load(object sender, EventArgs e)
        {
            string concepto = "", descripcion = "";
            double importe = 0;

            List<Ingreso> ingresos = null;
            List<Gasto> Gasto = null;
            if (clave.Equals("DEV") || clave.Equals("DEVCL"))
            {
                GastosController gc = new GastosController();
                Gasto = gc.DesgloseEgresos(clave,fecha,sucursal,check);

                foreach (var item in Gasto)
                {
                    concepto = clave;
                    importe = item.Importe;
                    DG_tabla.Rows.Add(importe);
                }
            }
            else
            {
                ingresos = VentaController.BuscarIngreso(sucursal, fecha, clave, check);

              


                foreach (var item in ingresos)
                {
                    concepto = item.Concepto;
                    descripcion = item.Descripcion;
                    importe = item.Importe;

                    DG_tabla.Rows.Add(importe);
                }
            }

          

         

            LB_concepto.Text = descripcion;
            LB_fecha.Text = fecha.ToString("yyyy-MM-dd");
        }
    }
}
