using appSugerencias.Ventas.Controlador;
using appSugerencias.Ventas.Modelo;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ReporteXTicket : Form
    {
        public ReporteXTicket()
        {
            InitializeComponent();
        }

        string patron = "";
        double total = 0;
        double PDFTotal = 0;
        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            LB_total.Text = "$0.00";
            DG_tabla.Rows.Clear();
            //string caja = CB_caja.SelectedItem.ToString();

            //string query = "select prods.articulo,prods.descrip,partvta.cantidad,partvta.precio,partvta.impuesto,partvta.descuento from prods inner join partvta on  prods.articulo = partvta.articulo" +
            //    "where partvta.venta=";


            MySqlConnection con = null;
            bool check = false;
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            if (CBX_respaldo.Checked==true)
            {
                string mes = FormatoFecha.Mes(inicio.Month);
                con = BDConexicon.RespMultiSuc(sucursal,mes,inicio.Year);
                check = true;
            }
            else
            {
                con = BDConexicon.ConexionSucursal(sucursal);
            }

          
            List<VentasXTicket> lista = VentaController.Ventas(sucursal,inicio,fin,check);
          
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            int cantidad = 0,descuento=0;
            double precio, totalVenta, totalPrecioArticulo, precioArticuloSinIVA, DescuentoArticulo = 0, IVaArticulo = 0, impuesto = 0;
            int fila = 0;
            double totalDev = 0;
            string caja = "";
            string ticket = "";
            foreach (var item in lista)
            {

                if (item.Tipo_Doc.Equals("DV"))
                {
                    totalDev = item.Importe + item.Impuesto;
                    totalDev = totalDev * 2;
                    totalVenta = (item.Importe + item.Impuesto) - totalDev;
                    cmd = new MySqlCommand("select no_referen from ventas where venta ='"+item.ventaDev+"'",con);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        ticket = dr["no_referen"].ToString();
                    }
                    dr.Close();
                    caja = item.Caja + " DV-" + ticket;
                }
                else
                {
                    totalVenta = item.Importe + item.Impuesto;
                    caja = item.Caja;
                }
               
                DG_tabla.Rows.Add(item.Venta,item.F_Emision.ToString("yyyy-MM-dd"),item.UsuHora,caja,item.No_referen, String.Format("{0:0.##}", item.Importe.ToString("C")), String.Format("{0:0.##}", item.Impuesto.ToString("C")), String.Format("{0:0.##}", totalVenta.ToString("C")));
                total += totalVenta;

                DG_tabla.Rows[fila].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                DG_tabla.Rows[fila].DefaultCellStyle.ForeColor = Color.White;
               
                DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["IMPUESTO"].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns["IMPORTE_TOTAL"].DefaultCellStyle.Format = "C2";

                cmd = new MySqlCommand("select prods.articulo,prods.descrip,partvta.cantidad,partvta.precio,partvta.impuesto,partvta.descuento from prods inner join partvta on  prods.articulo = partvta.articulo" +
                " where partvta.venta="+item.Venta+"", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cantidad = Convert.ToInt32(dr["cantidad"].ToString());
                    precio = Convert.ToDouble(dr["precio"].ToString());
                    impuesto = Convert.ToInt32(dr["impuesto"].ToString());
                    descuento = Convert.ToInt32(dr["descuento"].ToString());
                    precioArticuloSinIVA = (cantidad * precio);

                    if (descuento>0)
                    {
                        DescuentoArticulo = precio - (precio  * descuento / 100);
                       
                    }
                    if (impuesto>0)
                    {
                        
                        IVaArticulo = precio *(impuesto/100);
                    }


                    totalPrecioArticulo = cantidad * ((precio - DescuentoArticulo) + IVaArticulo);


                    DG_tabla.Rows.Add("","",dr["articulo"].ToString(),dr["descrip"].ToString(),cantidad, String.Format("{0:0.##}", precio.ToString("C")), String.Format("{0:0.##}", IVaArticulo.ToString("C")), String.Format("{0:0.##}", totalPrecioArticulo.ToString("C")));
                    DescuentoArticulo = 0; IVaArticulo = 0; precioArticuloSinIVA = 0; cantidad=0;
                    fila++;
                }
                dr.Close();
                fila++;
            }


            //buscas las devoluciones que se realizacion en el rango de fechas seleccionado
            //ArrayList devoluciones = VentaController.Devoluciones(sucursal,inicio,fin,check);
            //foreach (var item in devoluciones)
            //{
            //    DG_tabla.Rows.Add("");
            //    cmd = new MySqlCommand("SELECT venta,SUM(IMPORTE + IMPUESTO) AS total FROM VENTAS",con);
            //}
            LB_total.Text = total.ToString("C2");
            PDFTotal = total;
            total = 0;
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReporteXTicket_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            PDF();
        }


       
        public class HeaderFooter : PdfPageEventHelper
        {
            string sucursal = "",patron="";
            DateTime inicio, fin;
            public HeaderFooter(string sucursal,DateTime inicio,DateTime fin,string patron)
            {
                this.sucursal = sucursal;
                this.inicio = inicio;
                this.fin = fin;
                this.patron = patron;
            }
            public override void OnEndPage(PdfWriter writer, Document document)
            {

                
                //base.OnEndPage(writer, document);
                PdfPTable tbHeader = new PdfPTable(1);
                tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tbHeader.DefaultCell.Border = 0;

                tbHeader.AddCell(new Paragraph());
                tbHeader.AddCell(new Paragraph());



                PdfPCell _cell = new PdfPCell(new Paragraph("Reporte de tickets"+"                                                                                                             "+sucursal));
                _cell.HorizontalAlignment = Element.ALIGN_LEFT;
                _cell.Border = 0;
                _cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                
               
               
                tbHeader.AddCell(_cell);

              



                tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 17, writer.DirectContent);
                

                //----------------------------------------------------------------

                

                //PdfPTable tbHeader2 = new PdfPTable(2);
                //tbHeader2.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                //tbHeader2.DefaultCell.Border = 0;
                
                //tbHeader2.AddCell(new Paragraph());



                // iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance("logo.png");
                // //image1.ScalePercent(50f);
                // image1.ScaleAbsoluteWidth(110);
                // image1.ScaleAbsoluteHeight(50);
                // image1.Alignment = Element.ALIGN_RIGHT;

                //document.Add(image1);


                //----------------------------------------------------------------




                //Paragraph parrafoEnc = new Paragraph();
                //parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                //parrafoEnc.Add("\n");
                //parrafoEnc.Add("\n");
                //parrafoEnc.Alignment = Element.ALIGN_LEFT;

                //document.Add(parrafoEnc);


                PdfPTable tbFooter = new PdfPTable(3);
                tbFooter.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tbFooter.DefaultCell.Border = 0;

                tbFooter.AddCell(new Paragraph());
                _cell = new PdfPCell(new Paragraph(""));
                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                _cell.Border = 0;
                tbFooter.AddCell(_cell);
                _cell = new PdfPCell(new Paragraph("Página " + writer.PageNumber));
                _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                _cell.Border = 0;
                tbFooter.AddCell(_cell);
                tbFooter.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin), writer.DirectContent);

            }
        }

        public string RazonSocial(string sucursal)
        {
            string patron = "";

            if (sucursal.Equals("VALLARTA"))
            {
                patron = "Maricela Lopez Lorenzo";
            }

            if (sucursal.Equals("RENA"))
            {
                patron = "Georgina Lagunas Escobedo";
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                patron = "Miguel Angel Reza Flores";
            }

            if (sucursal.Equals("COLOSO"))
            {
                patron = "Daniela Lopez Ramírez";
            }


            return patron;
        }
        public void PDF()
        {

            try
            {

                string mes = "", año = "", nombre = "";

                DateTime inicio = DT_inicio.Value;
                DateTime finFecha = DT_fin.Value;
                string sucursal = CB_sucursal.SelectedItem.ToString();
                
                mes = FormatoFecha.Mes(inicio.Month);

                nombre = "Reporte " + inicio.ToString("yyyy-MM-dd") + "__al__"+ finFecha.ToString("yyyy-MM-dd") +"_"+sucursal + ".pdf";
                string ruta = "Reporte tickets\\" + nombre;


                patron = RazonSocial(CB_sucursal.SelectedItem.ToString());

                Document doc = new Document(PageSize.LETTER);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@ruta, FileMode.Create));
                writer.PageEvent = new HeaderFooter(sucursal,inicio, finFecha,patron);
                doc.AddTitle(ruta);
                doc.AddCreator("");



                // Abrimos el archivo
                doc.Open();

                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 6, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //######################################## ENCABEZADO ################################################################

                // Escribimos el encabezamiento en el documento
                Paragraph parrafoEnc = new Paragraph();
                parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial",14);
                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8);

                Paragraph parrafo = new Paragraph();
                //parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial", 14);
                var normal = FontFactory.GetFont(FontFactory.HELVETICA, 8);
                var negritas = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8);



                //iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance("logo.png");
                ////image1.ScalePercent(50f);

                //image1.ScaleAbsoluteWidth(110);
                //image1.ScaleAbsoluteHeight(50);
                //image1.Alignment = Element.ALIGN_CENTER;
                //image1.BackgroundColor = BaseColor.LIGHT_GRAY;
                //doc.Add(image1);



                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);
                parrafoEnc.Add("Razón social: " + patron + "\n");
                parrafoEnc.Add("Software: MyBusiness POS" + "\n");
                parrafoEnc.Add("Fecha: "+inicio.ToString("dd-MM-yyyy")+" al "+finFecha.ToString("dd-MM-yyyy"));

                parrafoEnc.Alignment = Element.ALIGN_LEFT;
               
                doc.Add(parrafoEnc);
                doc.Add(Chunk.NEWLINE);

              
                PdfPTable table = new PdfPTable(DG_tabla.Columns.Count-1);
                
                table.WidthPercentage = 100;
                float[] widths = new float[] { 40f, 50f, 100f, 40f, 40,40f,40f };
                table.SetWidths(widths);
                table.SkipLastFooter = true;
                table.SpacingAfter = 10;
               
               




                //Encabezados
                PdfPCell celda = new PdfPCell();
                

                iTextSharp.text.Font columnas = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 11, iTextSharp.text.Font.NORMAL);
                columnas.SetColor(255,255,255);
                
                for (int j = 1; j < DG_tabla.Columns.Count; j++)
                {
                    celda = new PdfPCell(new Phrase(DG_tabla.Columns[j].HeaderText, columnas));
                    celda.BackgroundColor = BaseColor.DARK_GRAY;
                    celda.Top = 30;
                    celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(celda);
                    //table.AddCell(new Phrase(DG_tabla.Columns[j].HeaderText));


                }

                //flag the first row as a header
                table.HeaderRows = 1;
                
                iTextSharp.text.Font filas = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL);
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    
                    for (int k = 1; k < DG_tabla.Columns.Count; k++)
                    {
                        if (DG_tabla[k, i].Value != null)
                        {
                            celda = new PdfPCell(new Phrase(DG_tabla[k, i].Value.ToString(),filas));
                            
                            if (k == 5 || k==6 || k==7)
                            {
                                
                                celda.HorizontalAlignment = Element.ALIGN_RIGHT;
                                
                            }
                            else
                            {
                                celda.HorizontalAlignment = Element.ALIGN_CENTER;
                            }


                            if (!DG_tabla.Rows[i].Cells["VENTA"].Value.ToString().Equals(""))
                            {
                                celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                                
                               
                            }

                            table.AddCell(celda);
                            
                        }
                    }
                }




                doc.Add(table);

                Paragraph fin = new Paragraph();
                fin.Add(String.Format("Total: " + "{0:0.##}", PDFTotal.ToString("C")));
                fin.Alignment = Element.ALIGN_RIGHT;
                doc.Add(fin);


                doc.Close();
                writer.Close();

                //Agregar número de páginas ******************************************************************************************************************************************

                //byte[] bytes = File.ReadAllBytes(@"C:\Users\Admin\Documents\GitHub\osmart\appSugerencias\appSugerencias\bin\Debug\Reportes ventas con tarjeta\" + nombre);
                //iTextSharp.text.Font blackFont = FontFactory.GetFont("Arial", "12", Font.Bold, 12, 1, BaseColor.BLACK);
                //using (MemoryStream stream = new MemoryStream())
                //{
                //    PdfReader reader = new PdfReader(bytes);
                //    using (PdfStamper stamper = new PdfStamper(reader, stream))
                //    {
                //        int pages = reader.NumberOfPages;
                //        for (int i = 1; i <= pages; i++)
                //        {

                //            ColumnText.ShowTextAligned(stamper.GetUnderContent(i), Element.ALIGN_RIGHT, new Phrase(i.ToString(), blackFont), 568f, 15f, 0);
                //        }
                //    }
                //    bytes = stream.ToArray();
                //}
                //File.WriteAllBytes(@"C:\Users\Admin\Documents\GitHub\osmart\appSugerencias\appSugerencias\bin\Debug\Reportes ventas con tarjeta\" + nombre, bytes);
                //Agregar número de páginas ******************************************************************************************************************************************


                //Process prc = new System.Diagnostics.Process();
                //prc.StartInfo.FileName = nombre;
                //prc.Start();

                MessageBox.Show("Se ha creado el reporte PDF");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar archivo PDF o el archivo ya esta abierto." + ex);
            }

        }

    }
}
