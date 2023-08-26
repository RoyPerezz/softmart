using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using MySql.Data.MySqlClient;
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
    public partial class GastosxCorregir : Form
    {

        string sucursal = "";
#pragma warning disable CS0169 // El campo 'GastosxCorregir.fecha' nunca se usa
        DateTime fecha;
#pragma warning restore CS0169 // El campo 'GastosxCorregir.fecha' nunca se usa
        bool respaldo = false;
        public GastosxCorregir(string sucursal)
        {
            this.sucursal = sucursal;
            InitializeComponent();
        }

        private void GastosxCorregir_Load(object sender, EventArgs e)
        {

            
           
        }

        public void CargarGastosXCorregir()
        {

            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            
            GastosController gc = new GastosController();
            List<Gasto> lista = gc.GastosXCorregir(sucursal,inicio,fin);

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Fecha.ToString("dd-MM-yyyy"), item.CantGastos);
            }

        }

        public void CargarGastosPendientes(string sucursal,DateTime inicio,DateTime fin,bool check)
        {

            DG_tabla2.Rows.Clear();

            List<Gasto> lista = new List<Gasto>();
            List<Gasto> lista2 = new List<Gasto>();
            GastosController gc = new GastosController();
            lista = GastosController.BuscarTodosLosGastosMesActual(sucursal,inicio,fin,check);
            lista2 = gc.BuscarGastosGuardados(inicio,fin, sucursal);
            List<Gasto> NuevaLista = new List<Gasto>();
            Gasto gasto = new Gasto();
            //gastos = GastosController.BuscarTodosLosGastosMesActual(sucursal, inicio, fin, check);

            for (int i = 0; i < lista2.Count; i++)
            {
                for (int j = 0; j < lista.Count; j++)
                {
                    if (lista[j].Ticket.Equals(lista2[i].Ticket))
                    {
                        lista.RemoveAt(j);
                        break;
                        //gasto.Ticket = lista[i].Ticket;
                        //gasto.Fecha = lista[i].Fecha;
                        //NuevaLista.Add(gasto);
                    }
                    else
                    {
                        

                    }
                    
                }
                
            }

            int contador = 0;
            for (DateTime F_inicio = inicio;  F_inicio <= fin; F_inicio = F_inicio.AddDays(1))
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    if (F_inicio.ToString("yyyy-MM-dd") == lista[i].Fecha.ToString("yyyy-MM-dd"))
                    {

                      
                        contador++;
                    }
                }
                DG_tabla2.Rows.Add(F_inicio.ToString("yyyy-MM-dd"),contador);
                contador = 0;
            }

        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            CargarGastosXCorregir();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            if (CBX_respaldo.Checked==true)
            {
                respaldo = true;
            }
            CargarGastosPendientes(sucursal, inicio,fin, respaldo);
        }
    }
}
