using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace appSugerencias
{
    public partial class Caja1Tarjetas : Form
    {
        public Caja1Tarjetas()
        {
            InitializeComponent();
        }

        private void Caja1Tarjetas_Load(object sender, EventArgs e)
        {
            LB_mes.Visible = false;
            LB_año.Visible = false;
            CB_mes.Visible = false;
            CB_año.Visible = false;
            LB_fecha.Visible = false;
            DT_fecha.Visible = false;
        }


        double totalVentas = 0;
        #region METODOS


        public void PDF()
        {
        
            try
            {
                string mes = "", año = "", nombre = "";
                string sucursal = CB_sucursal.SelectedItem.ToString();
                if (RB_mes.Checked==true)
                {
                    mes = CB_mes.SelectedItem.ToString();
                    año = CB_año.SelectedItem.ToString();
                    nombre = "Reporte " + mes + " " + año + " " + sucursal + ".pdf";
                }

                if (RB_dia.Checked==true)
                {
                    DateTime fecha = DT_fecha.Value;
                    nombre = "Reporte "+sucursal+" del "+fecha.ToString("dd-MM-yyyy")+".pdf";
                }
                 
                string ruta = "Reportes ventas con tarjeta\\"+nombre;

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
                parrafoEnc.Add("Razón social: "+patron +"\n");
                parrafoEnc.Add("Software: MyBusiness");
                parrafoEnc.Alignment = Element.ALIGN_LEFT;
              
                doc.Add(parrafoEnc);
                doc.Add(Chunk.NEWLINE);
               PdfPTable table = new PdfPTable(DG_tabla.Columns.Count);
                
                table.WidthPercentage = 100;
                float[] widths = new float[] { 20f, 30f, 30f,30f,25f,30f,35f };
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
                            if (k==1)
                            {
                                celda.HorizontalAlignment = Element.ALIGN_RIGHT;
                            }
                            else
                            {
                                celda.HorizontalAlignment = Element.ALIGN_CENTER;
                            }


                            if (i%2==0)
                            {
                                celda.BackgroundColor = BaseColor.LIGHT_GRAY;
                            }
                          
                            table.AddCell(celda);
                            //table.AddCell(new Phrase(DG_tabla[k, i].Value.ToString()));
                        }
                    }
                }



                
                doc.Add(table);

                Paragraph fin = new Paragraph();
                fin.Add(String.Format("Total: "+ "{0:0.##}", totalVentas.ToString("C")));
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
                MessageBox.Show("Error al generar archivo PDF o el archivo ya esta abierto."+ex);
            }

        }



        

        //obtiene el mes del comobobox
        public int Mes(string nombreMes)
        {
            int mes = 0;
            if (nombreMes.Equals("ENERO"))
            {
                mes = 1;
            }
            if (nombreMes.Equals("FEBRERO"))
            {
                mes = 2;
            }
            if (nombreMes.Equals("MARZO"))
            {
                mes = 3;
            }
            if (nombreMes.Equals("ABRIL"))
            {
                mes = 4;
            }
            if (nombreMes.Equals("MAYO"))
            {
                mes = 5;
            }
            if (nombreMes.Equals("JUNIO"))
            {
                mes = 6;
            }
            if (nombreMes.Equals("JULIO"))
            {
                mes = 7;
            }
            if (nombreMes.Equals("AGOSTO"))
            {
                mes = 8;
                
            }
            if (nombreMes.Equals("SEPTIEMBRE"))
            {
                mes = 9;

            }
            if (nombreMes.Equals("OCTUBRE"))
            {
                mes = 10;

            }
            if (nombreMes.Equals("NOVIEMBRE"))
            {
                mes = 11;

            }
            if (nombreMes.Equals("DICIEMBRE"))
            {
                mes = 12;

            }

            return mes;
        }


        public string Mes(int num)
        {
            string mes = "";

            if (num==1)
            {
                mes = "ENE";
            }

            if (num==2)
            {
                mes = "FEB";
            }

            if (num==3)
            {
                mes = "MAR";
            }

            if (num==4)
            {
                mes = "ABR";
            }

            if (num==5)
            {
                mes = "MAY";
            }

            if (num==6)
            {
                mes = "JUN";
            }

            if (num==7)
            {
                mes = "JUL";
            }

            if (num==8)
            {
                mes = "AGO";
            }

            if (num==9)
            {
                mes = "SEP";
            }

            if(num==10)
            {
                mes = "OCT";
            }

            if(num==11)
            {
                mes = "NOV";
            }

            if (num==12)
            {
                mes = "DIC";
            }
            return mes;
        }

        public string NumTicket(int venta)
        {
            string ticket = "";
            string consulta = "SELECT NO_REFEREN FROM VENTAS WHERE VENTA =" + venta + "";
            MySqlConnection conexion = null;
            if (CBX_respaldo.Checked==true)
            {
                if (RB_mes.Checked == true)
                {
                    int num = Mes(CB_mes.SelectedItem.ToString());
                    conexion = BDConexicon.RespMultiSuc(CB_sucursal.SelectedItem.ToString(), Mes(num), Convert.ToInt32(CB_año.SelectedItem.ToString()));
                }

                if (RB_dia.Checked == true)
                {
                    conexion = BDConexicon.RespMultiSuc(CB_sucursal.SelectedItem.ToString(), Mes(DT_fecha.Value.Month), DT_fecha.Value.Year);
                }
            }
            else
            {
                conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            }
            
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ticket = dr["NO_REFEREN"].ToString();
            }
            dr.Close();

            return ticket;
        }

        public void VentaTarjetas()
        {
            LB_total.Text = "";
            LB_items.Text = "";
            totalVentas = 0;
            DG_tabla.Rows.Clear();
            DateTime fecha,fechaSeleccionada;
#pragma warning disable CS0219 // La variable 'importe' está asignada pero su valor nunca se usa
            double importe = 0;
#pragma warning restore CS0219 // La variable 'importe' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'ticket' está asignada pero su valor nunca se usa
            string ticket = "";
#pragma warning restore CS0219 // La variable 'ticket' está asignada pero su valor nunca se usa

            

            string consulta = "";
            string query = "";


            string dev = "";
           
            if (RB_mes.Checked == true)
            {
                int mes = Mes(CB_mes.SelectedItem.ToString());
                int año = Convert.ToInt32(CB_año.SelectedItem.ToString());

                dev = "SELECT OrigenDev,IMPORTE,IMPUESTO FROM VENTAS WHERE TIPO_DOC ='DV' AND (CAJA='CAJA1' or CAJA='CAJA2') AND MONTH(F_EMISION)='" + mes+ "'  AND YEAR(F_EMISION)='" + año + "' ";


                consulta = "SELECT VENTA, NO_REFEREN, SUM(IMPORTE) IMPORTE, SUM(IMPUESTO) IMPUESTO,F_EMISION,CAJA, PAGO1,PAGO2,USUHORA,TIPO_DOC,OrigenDev FROM VENTAS WHERE (CAJA='CAJA1' or CAJA='CAJA2') AND MONTH(F_EMISION)=" + mes + " AND YEAR(F_EMISION)=" + año + "    GROUP BY VENTA order by F_EMISION,USUHORA";

                //query = "Select count(flujo) cantidad from flujo where  (concepto2='TAR' or concepto2='EFE') AND MONTH(FECHA)=" + mes + " AND YEAR(FECHA)=" + año + " AND ESTACION='CAJA1'";
                query = "SELECT COUNT(VENTA) VENTA FROM VENTAS WHERE MONTH(F_EMISION)=" + mes + " AND YEAR(F_EMISION)=" + año + " AND (CAJA='CAJA1' or CAJA='CAJA2')";
                //consulta = "SELECT * FROM flujo WHERE (concepto2='TAR' or concepto2='EFE') AND ESTACION='CAJA1' AND MONTH(FECHA)=" + mes + " AND YEAR(FECHA)=" + año + "  order by fecha,USUHORA";
            }

            if (RB_dia.Checked==true)
            {
                fechaSeleccionada = DT_fecha.Value;


                dev = "SELECT OrigenDev,IMPORTE,IMPUESTO FROM VENTAS WHERE TIPO_DOC ='DV' AND (CAJA='CAJA1' or CAJA='CAJA2') AND F_EMISION='"+fechaSeleccionada.ToString("yyyy-MM-dd")+"' ";
                //query = "Select count(flujo) cantidad from flujo where  (concepto2='TAR' or concepto2='EFE') AND fecha='"+ fechaSeleccionada.ToString("yyyy-MM-dd") + "' AND ESTACION='CAJA1'";
                query = "SELECT COUNT(VENTA) VENTA FROM VENTAS WHERE F_EMISION='" + fechaSeleccionada.ToString("yyyy-MM-dd")+ "' AND (CAJA='CAJA1' or CAJA='CAJA2')";
                //consulta = "SELECT * FROM flujo WHERE (concepto2='TAR' or concepto2='EFE') AND ESTACION='CAJA1' AND fecha='"+fechaSeleccionada.ToString("yyyy-MM-dd")+"' order by fecha,USUHORA";
                consulta = "SELECT VENTA,NO_REFEREN, SUM(IMPORTE) IMPORTE, SUM(IMPUESTO) IMPUESTO,F_EMISION,CAJA ,PAGO1,PAGO2,USUHORA,TIPO_DOC,OrigenDev FROM VENTAS WHERE (CAJA='CAJA1' or CAJA='CAJA2') AND F_EMISION='" + fechaSeleccionada.ToString("yyyy-MM-dd")+ "'    GROUP BY VENTA  order by F_EMISION,USUHORA";
            }
           
           
            int count = 0;


            MySqlConnection conexion = null;

            try
            {
                if (CBX_respaldo.Checked == true)
                {
                    if (RB_mes.Checked == true)
                    {
                        int num = Mes(CB_mes.SelectedItem.ToString());
                        conexion = BDConexicon.RespMultiSuc(CB_sucursal.SelectedItem.ToString(),Mes(num) , Convert.ToInt32(CB_año.SelectedItem.ToString()));
                    }

                    if (RB_dia.Checked == true)
                    {
                        conexion = BDConexicon.RespMultiSuc(CB_sucursal.SelectedItem.ToString(),Mes(DT_fecha.Value.Month),DT_fecha.Value.Year);
                    }
                   
                    

                    
                    
                }
                else
                {
                    conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                }

                

                DataTable devoluciones = new DataTable();
                devoluciones.Columns.Add("VENTA",typeof(string));
                devoluciones.Columns.Add("IMPORTE", typeof(double));
                MySqlCommand devo = new MySqlCommand(dev,conexion);
                MySqlDataReader drdev = devo.ExecuteReader();
                devoluciones.Clear();
                double importedev = 0, impuestodev = 0;
                //double dv=0;
                while (drdev.Read())
                {
                    importedev = Convert.ToDouble(drdev["IMPORTE"].ToString());
                    impuestodev = Convert.ToDouble(drdev["IMPUESTO"].ToString());
                    devoluciones.Rows.Add(drdev["OrigenDev"],importedev + impuestodev);
                }
                drdev.Close();

                MySqlCommand cmd0 = new MySqlCommand(query, conexion);
                MySqlDataReader dr0 = cmd0.ExecuteReader();
                while (dr0.Read())
                {
                    count = Convert.ToInt32(dr0["VENTA"].ToString());
                }
                dr0.Close();

                string venta = "";
                double total = 0, importeVTA = 0, impuesto = 0;
                string tipoPago = "";
                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                PB_barra.Value = 1;
                PB_barra.Minimum = 0;
                PB_barra.Maximum = count;
                PB_barra.Step = 1;
                string origenDev = "";
                while (dr.Read())
                {

                    //fecha = Convert.ToDateTime(dr["F_EMISION"].ToString());
                    //ticket = NumTicket(Convert.ToInt32(dr["VENTA"].ToString()));
                    //importe = Convert.ToDouble(dr["IMPORTE"].ToString());
                    //total += importe;
                    //DG_tabla.Rows.Add(ticket, String.Format("{0:0.##}", importe.ToString("C")), fecha.ToString("dd-MM-yyyy"), dr["USUHORA"].ToString(), dr["ESTACION"].ToString(), dr["CONCEPTO2"].ToString());

                    //if (dr["TIPO_DOC"].ToString().Equals("DV"))
                    //{
                    //    dv += Convert.ToDouble(dr["IMPORTE"].ToString()) + Convert.ToDouble(dr["IMPUESTO"].ToString());
                        
                    //}
                    venta = dr["VENTA"].ToString();

                    if (Convert.ToDouble(dr["PAGO1"].ToString()) > 0)
                    {
                        tipoPago = "EFE";
                    }

                    if (Convert.ToDouble(dr["PAGO2"].ToString()) > 0)
                    {
                        tipoPago = "TAR";
                    }


                    importeVTA = Convert.ToDouble(dr["IMPORTE"].ToString());
                    impuesto = Convert.ToDouble(dr["IMPUESTO"].ToString());
                    total = importeVTA + impuesto;


                    origenDev = dr["OrigenDev"].ToString();


                    if (!origenDev.Equals("0"))
                    {
                        totalVentas -= total;
                    }
                    else
                    {
                        totalVentas += total;
                    }
                    fecha = Convert.ToDateTime(dr["F_EMISION"].ToString());



                    DG_tabla.Rows.Add(dr["NO_REFEREN"].ToString(), String.Format("{0:0.##}", total.ToString("C")), fecha.ToString("dd-MM-yyyy"), dr["USUHORA"].ToString(), dr["CAJA"].ToString(), tipoPago, NumTicket(Convert.ToInt32(dr["OrigenDev"].ToString())));

                   






                    PB_barra.PerformStep();
                    
                }
                dr.Close();


                conexion.Close();

                int filas = DG_tabla.Rows.Count;
                //totalVentas -= dv*2;
                LB_total.Text = String.Format("{0:0.##}","Total: "+ totalVentas.ToString("C"));
                LB_items.Text = filas + " ventas";
                MessageBox.Show("Busqueda exitosa");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de conexión: " + ex);
            }


          


            
            
            
           
           
           
            
            //DG_tabla.Columns[1].DefaultCellStyle.Format = "C2";
        }
        #endregion

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            VentaTarjetas();
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            PDF();
        }

        class HeaderFooter: PdfPageEventHelper
        {
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                //base.OnEndPage(writer, document);
                PdfPTable tbHeader = new PdfPTable(1);
                tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                tbHeader.DefaultCell.Border = 0;

                tbHeader.AddCell(new Paragraph());


                PdfPCell _cell = new PdfPCell(new Paragraph("Reporte de Tickets de Ventas con Tarjeta"));
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
                _cell = new PdfPCell(new Paragraph("Página "+writer.PageNumber ));
                _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                _cell.Border = 0;
                tbFooter.AddCell(_cell);
                tbFooter.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin), writer.DirectContent);

            }
        }

        private void CBX_respaldo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_mes_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_mes.Checked==true)
            {
                LB_mes.Visible = true;
                LB_año.Visible = true;
                CB_mes.Visible = true;
                CB_año.Visible = true;
                LB_fecha.Visible = false;
                DT_fecha.Visible = false;
            }
            else
            {
               
            }
        }

        private void RB_dia_CheckedChanged(object sender, EventArgs e)
        {

            if (RB_dia.Checked == true)
            {

                LB_fecha.Visible = true;
                DT_fecha.Visible = true;
                LB_mes.Visible = false;
                LB_año.Visible = false;
                CB_mes.Visible = false;
                CB_año.Visible = false;
            }
            else
            {
                
            }
        }
    }
}
