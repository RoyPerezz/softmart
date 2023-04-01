using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using Microsoft.Office.Interop.Excel;
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
    public partial class GastosPendientesPorEnviar : Form
    {
        string sucursal = "";
        DateTime fecha = DateTime.Now;
        public GastosPendientesPorEnviar(string sucursal,DateTime fecha)
        {
            this.sucursal = sucursal;
            this.fecha = fecha;
            InitializeComponent();
            
        }


        public void GastosPendientes()
        {
            bool respaldo = false;
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            RevisionGastosController rg = new RevisionGastosController();
            List<Gasto> lista = rg.BuscarNumTicket(sucursal,inicio,fin);
            if (CBX_respaldo.Checked==true)
            {
                respaldo = true;
            }

            List<Gasto> gastosTienda = rg.BuscarGastos(sucursal,inicio,fin,respaldo);
#pragma warning disable CS0219 // La variable 'ticket' está asignada pero su valor nunca se usa
            string ticket = "";
#pragma warning restore CS0219 // La variable 'ticket' está asignada pero su valor nunca se usa
            

                foreach (var item2 in gastosTienda)
                {
                    
                        
                        DG_tabla.Rows.Add(item2.Concepto, item2.Descripcion, item2.Importe, item2.Ticket, item2.Fecha.ToString("yyyy-MM-dd"));
                      
                }

            
            foreach (var item in lista)
            {

                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    if (item.Ticket.Equals(DG_tabla.Rows[i].Cells["TICKET"].Value.ToString()))
                    {
                        DG_tabla.Rows[i].Visible = false;
                    }
                }

                
              
            }
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
        }

  
        
        private void BT_pendientes_Click(object sender, EventArgs e)
        {
            GastosPendientes();
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;
           

            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

           
           
                foreach (DataGridViewRow row in DG_tabla.Rows)

                if (row.Visible == true)
                {
                    indiceFila++;
                    indiceColumna = 0;
                   
                     foreach (DataGridViewColumn col in DG_tabla.Columns)
                     {
                        indiceColumna++;


                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;




                    }

                }

            excel.Cells.Range["A4:A4"].Value = "Reporte de gastos pendientes por envíar";
            excel.Cells.Range["A5:E5"].Interior.ColorIndex=25;
            excel.Cells.Range["A5:E5"].Font.ColorIndex = 2;
            excel.Range["C6:C100"].NumberFormat = "$#,##0.00";
            int indice = indiceFila + 1;
            int indiceHorizontal = indiceFila + 2;
            excel.Cells.Range["A5:E"+indice].Borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A5:A"+indice].Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["D5:E"+indice].Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            excel.Cells.Range["A4:E"+ indiceHorizontal].Borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            excel.Visible = true;
        }

        private void GastosPendientesPorEnviar_Load(object sender, EventArgs e)
        {

        }
    }
}
