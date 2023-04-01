using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace appSugerencias
{
    public partial class ReporteCorteZ : Form
    {
        public ReporteCorteZ()
        {
            InitializeComponent();
        }

        private void ReporteCorteZ_Load(object sender, EventArgs e)
        {
            
        }

        #region METODOS

        public string Mes(int num)
        {
            string mes = "";

            if (num == 1)
            {
                mes = "ENE";
            }

            if (num == 2)
            {
                mes = "FEB";
            }

            if (num == 3)
            {
                mes = "MAR";
            }

            if (num == 4)
            {
                mes = "ABR";
            }

            if (num == 5)
            {
                mes = "MAY";
            }

            if (num == 6)
            {
                mes = "JUN";
            }

            if (num == 7)
            {
                mes = "JUL";
            }

            if (num == 8)
            {
                mes = "AGO";
            }

            if (num == 9)
            {
                mes = "SEP";
            }

            if (num == 10)
            {
                mes = "OCT";
            }

            if (num == 11)
            {
                mes = "NOV";
            }

            if (num == 12)
            {
                mes = "DIC";
            }
            return mes;
        }

        public void Ventas()
        {


            DateTime fechaSeleccionada = DT_inicio.Value;
            string tipoVenta = "";
            double importe = 0, impuesto = 0, total = 0;
            string consulta = "SELECT VENTA,NO_REFEREN, SUM(IMPORTE) IMPORTE, SUM(IMPUESTO) IMPUESTO,F_EMISION,CAJA ,PAGO1,PAGO2,USUHORA,TIPO_DOC,OrigenDev FROM VENTAS WHERE CAJA='CAJA1' AND F_EMISION='" + fechaSeleccionada.ToString("yyyy-MM-dd") + "'    GROUP BY VENTA  order by F_EMISION,USUHORA";
            MySqlCommand cmd = null;
            MySqlConnection conexion = null;
            MySqlDataReader dr = null;

            if (CBX_mes_anterior.Checked==true)
            {
                importe = 0;impuesto = 0;total = 0;
                DG_tabla.Rows.Clear();
               

                DateTime f;
               f = DT_inicio.Value;
                int num = f.Month;
                conexion = BDConexicon.RespMultiSuc(CB_sucursal.SelectedItem.ToString(),Mes(num),f.Year);
                cmd = new MySqlCommand(consulta, conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    importe = Convert.ToDouble(dr["IMPORTE"].ToString());
                    impuesto = Convert.ToDouble(dr["IMPUESTO"].ToString());
                    total = importe + impuesto;

                    if (Convert.ToDouble(dr["PAGO1"].ToString()) > 0)
                    {
                        tipoVenta = "EFE PAGO CLIENTE";
                    }

                    if (Convert.ToDouble(dr["PAGO2"].ToString()) > 0)
                    {
                        tipoVenta = "TAR PAGO CLIENTE";
                    }
                    DG_tabla.Rows.Add(tipoVenta, (String.Format("{0:0.##}", total.ToString("C"))));
                }
                dr.Close();
                conexion.Close();
            }
            else
            {
                importe = 0; impuesto = 0; total = 0;
                DG_tabla.Rows.Clear();
               

                conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                cmd = new MySqlCommand(consulta,conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    importe = Convert.ToDouble(dr["IMPORTE"].ToString());
                    impuesto = Convert.ToDouble(dr["IMPUESTO"].ToString());
                    total = importe + impuesto;

                    if (Convert.ToDouble(dr["PAGO1"].ToString())>0)
                    {
                        tipoVenta = "EFE PAGO CLIENTE";
                    }

                    if (Convert.ToDouble(dr["PAGO2"].ToString()) > 0)
                    {
                        tipoVenta = "TAR PAGO CLIENTE";
                    }
                    DG_tabla.Rows.Add(tipoVenta, (String.Format("{0:0.##}", total.ToString("C"))));
                }
                dr.Close();
                conexion.Close();
            }

        }

        public double VentaTotal(DateTime fecha)
        {
            MySqlConnection con = null;
            
          
           
                con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
           

            double importe = 0, impuesto = 0;
            double Nventa = 0;

            //ventatotal
            string query2 = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`," +
                "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As `Impuesto`" +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND ventas.caja = 'CAJA1' AND partvta.impuesto > 0 ";

            //nventa
            string nventa = "SELECT SUM((partvta.precio * ( partvta.cantidad  - partvta.a01 ) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) As `Importe`    " +
                "FROM partvta INNER JOIN ventas ON ventas.venta = partvta.venta WHERE ventas.estado = 'CO' AND(ventas.tipo_doc = 'FAC' Or ventas.tipo_doc = 'DV' Or ventas.tipo_doc = 'REM') AND ventas.cierre = 0 AND moneda = 'MN' AND ventas.usufecha = '" + fecha.ToString("yyyy-MM-dd") + "' AND partvta.impuesto = 0 AND ventas.caja = 'CAJA1'";
            double ventaTotal = 0;
            try
            {









                if (CBX_mes_anterior.Checked == true)
                {
                    
                    DateTime f = DT_inicio.Value;
                    int num = f.Month;
                    MySqlConnection conectar = BDConexicon.RespMultiSuc(CB_sucursal.SelectedItem.ToString(), Mes(num), f.Year);

                    MySqlCommand cmd0 = new MySqlCommand(query2, conectar);
                    DataTable dt0 = new DataTable();
                    MySqlDataAdapter ad0 = new MySqlDataAdapter(cmd0);
                    ad0.Fill(dt0);

                    for (int i = 0; i < dt0.Rows.Count; i++)
                    {
                        importe += Convert.ToDouble(dt0.Rows[i]["Importe"].ToString());
                        impuesto += Convert.ToDouble(dt0.Rows[i]["Impuesto"].ToString());
                        //ventaTotal += Convert.ToDouble(dt.Rows[i]["Total"].ToString());
                        ventaTotal = importe + impuesto;
                    }

                    MySqlCommand cmd20 = new MySqlCommand(nventa, conectar);
                    MySqlDataReader dr0 = cmd20.ExecuteReader();



                    while (dr0.Read())
                    {
                        if (DBNull.Value.Equals(dr0["Importe"].ToString()) || dr0["Importe"].ToString().Equals(""))
                        {
                            Nventa = 0;
                        }
                        else
                        {
                            Nventa = Convert.ToDouble(dr0["Importe"].ToString());
                        }
                    }

                    dr0.Close();
                    conectar.Close();
                    ventaTotal += Nventa;


                   // TB_total.Text = String.Format("{0:0.##}", ventaTotal.ToString("C"));
                }
                else
                {
                   // TB_total.Text = "";
                    MySqlCommand cmd = new MySqlCommand(query2, con);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                    ad.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        importe += Convert.ToDouble(dt.Rows[i]["Importe"].ToString());
                        impuesto += Convert.ToDouble(dt.Rows[i]["Impuesto"].ToString());
                        //ventaTotal += Convert.ToDouble(dt.Rows[i]["Total"].ToString());
                        ventaTotal = importe + impuesto;
                    }

                    MySqlCommand cmd2 = new MySqlCommand(nventa, con);
                    MySqlDataReader dr = cmd2.ExecuteReader();



                    while (dr.Read())
                    {
                        if (DBNull.Value.Equals(dr["Importe"].ToString()) || dr["Importe"].ToString().Equals(""))
                        {
                            Nventa = 0;
                        }
                        else
                        {
                            Nventa = Convert.ToDouble(dr["Importe"].ToString());
                        }
                    }

                    dr.Close();

                    ventaTotal += Nventa;
                   // TB_total.Text = String.Format("{0:0.##}", ventaTotal.ToString("C"));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la fecha " + fecha + ":" + ex);
            }





            return ventaTotal;

        }

        class HeaderFooter : PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                //base.OnEndPage(writer, document);
                PdfPTable tbHeader = new PdfPTable(1);
                tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tbHeader.DefaultCell.Border = 0;

                tbHeader.AddCell(new Paragraph());


                PdfPCell _cell = new PdfPCell(new Paragraph("Reporte corte Z"));
                _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                _cell.Border = 0;
                tbHeader.AddCell(_cell);
                tbHeader.AddCell(new Paragraph());

                tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 17, writer.DirectContent);

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

        public void PDF()
        {

            try
            {
#pragma warning disable CS0219 // La variable 'mes' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'nombre' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'año' está asignada pero su valor nunca se usa
                string mes = "", año = "", nombre = "";
#pragma warning restore CS0219 // La variable 'año' está asignada pero su valor nunca se usa
#pragma warning restore CS0219 // La variable 'nombre' está asignada pero su valor nunca se usa
#pragma warning restore CS0219 // La variable 'mes' está asignada pero su valor nunca se usa
                string sucursal = CB_sucursal.SelectedItem.ToString();
                //if (RB_mes.Checked == true)
                //{
                //    mes = CB_mes.SelectedItem.ToString();
                //    año = CB_año.SelectedItem.ToString();
                //    nombre = "Reporte " + mes + " " + año + " " + sucursal + ".pdf";
                //}

                //if (RB_dia.Checked == true)
                //{
                //    DateTime fecha = DT_fecha.Value;
                //    nombre = "Reporte " + sucursal + " del " + fecha.ToString("dd-MM-yyyy") + ".pdf";
                //}
                DateTime fecha = DT_inicio.Value;
                string ruta = "Reporte corte z\\" + fecha.ToString("dd_MM_yyyy")+".pdf";
                //double totalVentas = Convert.ToDouble(TB_total.Text);
                Document doc = new Document(PageSize.LETTER);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@ruta, FileMode.Create));
                writer.PageEvent = new HeaderFooter();
                doc.AddTitle(ruta);
                doc.AddCreator("");



                // Abrimos el archivo
                doc.Open();

                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //######################################## ENCABEZADO ################################################################

                // Escribimos el encabezamiento en el documento
                Paragraph parrafoEnc = new Paragraph();
                parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial",14);
                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);

                Paragraph parrafo = new Paragraph();
                //parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial", 14);
                var normal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                var negritas = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);



                string patron = "";

                if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                {
                    patron = "Maricela Lopez Lorenzo";
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                {
                    patron = "Georgina Lagunas Escobedo";
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                {
                    patron = "Miguel Angel Reza Flores";
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                {
                    patron = "Daniela Lopez Ramírez";
                }






                Paragraph imagen = new Paragraph();

                iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance("logo.png");
                //image1.ScalePercent(50f);
                image1.ScaleAbsoluteWidth(110);
                image1.ScaleAbsoluteHeight(50);
                image1.Alignment = Element.ALIGN_RIGHT;

                doc.Add(image1);

                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                parrafoEnc.Add("Razón social: " + patron + "\n");
                parrafoEnc.Add("Software: MyBusiness" + "\n");
                parrafoEnc.Add("Caja: Caja 1                                      ");
                parrafoEnc.Add("Fecha: "+ fecha.ToString("dd-MM-yyyy")+"                               ");
               // parrafoEnc.Add("Total venta: "+ TB_total.Text);
                parrafoEnc.Alignment = Element.ALIGN_LEFT;

                doc.Add(parrafoEnc);
                doc.Add(Chunk.NEWLINE);
                PdfPTable table = new PdfPTable(DG_tabla.Columns.Count);

                table.WidthPercentage = 100;
                float[] widths = new float[] { 40f, 40f, 40f, 40f,40f};
                table.SetWidths(widths);
                table.SkipLastFooter = true;
                table.SpacingAfter = 10;




                //Encabezados
                PdfPCell celda = new PdfPCell();
                for (int j = 0; j < DG_tabla.Columns.Count; j++)
                {
                    celda = new PdfPCell(new Phrase(DG_tabla.Columns[j].HeaderText));
                    celda.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(celda);
                    //table.AddCell(new Phrase(DG_tabla.Columns[j].HeaderText));


                }

                //flag the first row as a header
                table.HeaderRows = 1;


                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    for (int k = 0; k < DG_tabla.Columns.Count; k++)
                    {
                        if (DG_tabla[k, i].Value != null)
                        {
                            celda = new PdfPCell(new Phrase(DG_tabla[k, i].Value.ToString()));
                            if (k == 1)
                            {
                                celda.HorizontalAlignment = Element.ALIGN_RIGHT;
                            }
                            else
                            {
                                celda.HorizontalAlignment = Element.ALIGN_CENTER;
                            }


                            if (i % 2 == 0)
                            {
                                celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                            }

                            table.AddCell(celda);
                            //table.AddCell(new Phrase(DG_tabla[k, i].Value.ToString()));
                        }
                    }
                }




                doc.Add(table);

                
                //Paragraph fin = new Paragraph();
                //fin.Add(String.Format("Total: " + "{0:0.##}", totalVentas.ToString("C")));
                //fin.Alignment = Element.ALIGN_RIGHT;
                //doc.Add(fin);


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


        #endregion

        #region BOTONES
        private void BT_caja_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            //VentaTotal(fecha);
            //Ventas();
            FortmatoEnCajas f = new FortmatoEnCajas();
            DataTable dt = f.TotalEfectivoParaContabilidad(inicio,fin,con);

            double total = 0,impuesto=0,importe=0;
            int count = 0;
#pragma warning disable CS0219 // La variable 'pintar' está asignada pero su valor nunca se usa
            bool pintar = true;
#pragma warning restore CS0219 // La variable 'pintar' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'no' está asignada pero su valor nunca se usa
            int si = 0, no = 0;
#pragma warning restore CS0219 // La variable 'no' está asignada pero su valor nunca se usa
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total = Convert.ToDouble(dt.Rows[i]["TOTAL"].ToString());
                impuesto = total * 0.16;
                importe = total - impuesto;

                if (dt.Rows[i]["DESCRIPCION"].ToString().Equals("Pago con Tarjeta"))
                {
                    DG_tabla.Rows.Add("", dt.Rows[i]["DESCRIPCION"].ToString(), importe, impuesto, total);
                }
                else
                {
                    DG_tabla.Rows.Add(dt.Rows[i]["FECHA"].ToString(), dt.Rows[i]["DESCRIPCION"].ToString(), importe, impuesto, total);

                }

               


                if (si <2)
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    si++;
                    count = 0;
                }
                else
                {

                    count++;
                    if (count==2)
                    {
                        si = 0;
                    }
                   
                }
                


            }


           

            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPUESTO"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["TOTAL"].DefaultCellStyle.Format = "C2";

            con.Close();
        }


        private void BT_pdf_Click(object sender, EventArgs e)
        {
            PDF();
        }

        #endregion



        public void prueba()
        {
            XmlDocument xml = new XmlDocument();
            XmlNode root = xml.CreateElement("Biblioteca");
            xml.AppendChild(root);

            XmlNode nodoLibro = xml.CreateElement("Libro");
            XmlAttribute atributo = xml.CreateAttribute("Autor");
            atributo.Value = "Michael Ende";
            nodoLibro.Attributes.Append(atributo);

            XmlNode nodotitulo = xml.CreateElement("titulo");
            nodotitulo.InnerText = "La historia interminable";

            XmlNode nodopaginas = xml.CreateElement("paginas");
            nodopaginas.InnerText = "234";

            nodoLibro.AppendChild(nodotitulo);
            nodoLibro.AppendChild(nodopaginas);
            root.AppendChild(nodoLibro);

            //-------------------------------------------------------

            nodoLibro = xml.CreateElement("Libro");
            atributo = xml.CreateAttribute("Autor");
            atributo.Value = "Miguel de cervantes";
            nodoLibro.Attributes.Append(atributo);

            nodotitulo = xml.CreateElement("titulo");
            nodotitulo.InnerText = "El quijote";

            nodopaginas = xml.CreateElement("paginas");
            nodopaginas.InnerText = "570";

            nodoLibro.AppendChild(nodotitulo);
            nodoLibro.AppendChild(nodopaginas);
            root.AppendChild(nodoLibro);

            //-------------------------------------------------------

            nodoLibro = xml.CreateElement("Libro");
            atributo = xml.CreateAttribute("Autor");
            atributo.Value = "aldoux huxley";
            nodoLibro.Attributes.Append(atributo);

            nodotitulo = xml.CreateElement("titulo");
            nodotitulo.InnerText = "Un mundo feliz";

            nodopaginas = xml.CreateElement("paginas");
            nodopaginas.InnerText = "270";

            nodoLibro.AppendChild(nodotitulo);
            nodoLibro.AppendChild(nodopaginas);
            root.AppendChild(nodoLibro);
            xml.Save("ArchivoPrueba.xml");
        }

    }
}
