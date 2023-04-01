using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Modelo
{
    public class Ticket
    {
        public Image Logo { get; set; }
        public  string Sucursal { get; set; }
        public string Usuario { get; set; }
        public string Estacion { get; set; }
        public string Flujo { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Clave { get; set; }
        public string ConceptoDetalle { get; set; }
        public double Importe { get; set; }

        private PrintDocument doc = new PrintDocument();

        // no lo usare solo pruebas
        private PrintPreviewDialog vista = new PrintPreviewDialog();

        

        public void ImprimirTicket(object sender,PrintPageEventArgs e)
        {


            int psX=10, psY=10;

            Font fuente = new Font("Tahoma", 8,FontStyle.Regular);
            try
            {
                e.Graphics.DrawImage(Logo, 15, 20, 250, 100);
                e.Graphics.DrawString(Sucursal, fuente, Brushes.Black,10,160);
              
                e.Graphics.DrawString(Usuario, fuente, Brushes.Black, 10, 210);
               
                e.Graphics.DrawString(Estacion, fuente, Brushes.Black, 80, 210);
               
                e.Graphics.DrawString("Salida No:  "+Flujo, fuente, Brushes.Black, 160, 210);
               
                e.Graphics.DrawString(Fecha, fuente, Brushes.Black, 10, 220);
               
                e.Graphics.DrawString("Hora: "+Hora, fuente, Brushes.Black, 80, 220);

                e.Graphics.DrawString("Clave", fuente, Brushes.Black, 10, 230);
                e.Graphics.DrawString("Descripcion", fuente, Brushes.Black, 80, 230);
                e.Graphics.DrawString(Clave, fuente, Brushes.Black, 10, 240);
                e.Graphics.DrawString(ConceptoDetalle, fuente, Brushes.Black, 80, 240);
                e.Graphics.DrawString("Importe: ", fuente, Brushes.Black,10, 280);
                e.Graphics.DrawString(Importe.ToString("N2"), fuente, Brushes.Black, 130, 280);
                e.Graphics.DrawString("Firma de recibido", fuente, Brushes.Black, 10, 310);
                e.Graphics.DrawString("_____________________________________", fuente, Brushes.Black, 30, 360);
                e.Graphics.DrawString("FIRMA", fuente, Brushes.Black, 120, 375);
                e.Graphics.DrawString(".", fuente, Brushes.Black, 10, 430);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: "+ex);
            }
        }
        public void Imprimir(Ticket t)
        {
            doc.PrinterSettings.PrinterName = doc.DefaultPageSettings.PrinterSettings.PrinterName;
            doc.PrintPage += new PrintPageEventHandler(ImprimirTicket);
            vista.Document = doc;
            //vista.Show();
            doc.Print();
        }

        public void ReImprimir(Ticket t,string impresora)
        {
            doc.PrinterSettings.PrinterName = impresora;
            doc.PrintPage += new PrintPageEventHandler(ImprimirTicket);
            vista.Document = doc;
            //vista.Show();
            doc.Print();
        }
    }
}
