using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace appSugerencias
{
    public partial class frm_surtidor_listado : Form
    {
        string UsuarioMyB;
        public frm_surtidor_listado()
        {
            InitializeComponent();
        }


        public frm_surtidor_listado( string usuario)
        {
            InitializeComponent();
            UsuarioMyB=usuario;
        }

        MySqlConnection Conex;

#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.ColumnaSurtir' está asignado pero su valor nunca se usa
        int ColumnaSurtir = 6;
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.ColumnaSurtir' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.exisCo' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.exisRe' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.exisVa' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.exisPm' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.exisVl' está asignado pero su valor nunca se usa
        int exisVa = 7, exisRe = 9, exisCo = 11, exisVl = 13, exisPm = 15;
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.exisVl' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.exisPm' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.exisVa' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.exisRe' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.exisCo' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.surtePm' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.surteCo' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'frm_surtidor_listado.surteRe' está asignado pero su valor nunca se usa
        int surteVa = 8, surteRe = 10, surteCo = 12, surteVl = 14, surtePm = 16;
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.surteRe' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.surteCo' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'frm_surtidor_listado.surtePm' está asignado pero su valor nunca se usa

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente deseo Eliminar todas las Solicitudes", "Eliminar Solcitudes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion == DialogResult.OK)
            {
                //Codigo
                Conex = BDConexicon.BodegaOpen();
                eliminar();
                dgvSurtidor.Rows.Clear();
                Conex.Close();

            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbMotivo.Text = "";
        }

        public void eliminar()
        {
            MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE rd_surtidor", Conex);
            cmd.ExecuteNonQuery();
        }

        public void eliminarPedidoTienda(string tienda)
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM rd_surtidor WHERE destino=?destino", Conex);
            cmd.Parameters.AddWithValue("?destino", tienda);
            cmd.ExecuteNonQuery();
        }


        private void frm_surtidor_listado_Load(object sender, EventArgs e)
        {
            List<Item> tienda = new List<Item>();

            tienda.Add(new Item("VALLARTA", "VA"));
            tienda.Add(new Item("RENA", "RE"));
            tienda.Add(new Item("VELAZQUEZ", "VE"));
            tienda.Add(new Item("COLOSO", "CO"));
            tienda.Add(new Item("PREGOT", "PREGOT"));

            cbTiendas.DisplayMember = "Name";
            cbTiendas.ValueMember = "Value";
            cbTiendas.DataSource = tienda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conex = BDConexicon.BodegaOpen();
            busqueda();
            Conex.Close();
        }

        public void busqueda()
        {
            //string tienda="";
            //if (cbTiendas.Text == "VALLARTA")
            //{
            //    tienda = "VA";
            //}
            //else if (cbTiendas.Text == "RENA")
            //{
            //    tienda = "RE";
            //}
            //else if (cbTiendas.Text == "COLOSO")
            //{
            //    tienda = "CO";
            //}

            //else if (cbTiendas.Text == "VELAZQUEZ")
            //{
            //    tienda = "VL";
            //}
            //else if (cbTiendas.Text == "PREGOT")
            //{
            //    tienda = "PM";
            //}

            string comando = "SELECT articulo,descripcion,cantidad FROM rd_surtidor WHERE destino='" + cbTiendas.SelectedValue.ToString()+ "'";
            //MessageBox.Show(comando);
            MySqlCommand cmd = new MySqlCommand(comando, Conex);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();



            adapter.Fill(dt);

            dgvSurtidor.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dgvSurtidor.Rows.Add();
                dgvSurtidor.Rows[n].Cells[0].Value = n + 1;
                dgvSurtidor.Rows[n].Cells[1].Value = item["articulo"].ToString();
                dgvSurtidor.Rows[n].Cells[2].Value = item["descripcion"].ToString();
                dgvSurtidor.Rows[n].Cells[3].Value = item["cantidad"].ToString();
               
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvSurtidor.Rows.Count == 0)
            {

                MessageBox.Show("No hay Datos");
            }
            else
            {
               
                if (tbMotivo.Text != "")
                {
                    string id;

                    Conex = BDConexicon.BodegaOpen();
                    id = guardarTraspaso(cbTiendas.SelectedValue.ToString(), tbMotivo.Text.ToUpper(), surteVa);
                    
                    CrearPDF(id, cbTiendas.SelectedValue.ToString(), tbMotivo.Text.ToUpper(), surteVl);
                    eliminarPedidoTienda(cbTiendas.SelectedValue.ToString());
                    Conex.Close();
                    dgvSurtidor.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Observaciones es un campo requerido.");
                }
            }
            
            
                
            

        }


        public string guardarTraspaso(string destino, string motivo, int ColumnaTienda)
        {
            //CABECERA DE LA SOLICITUD
            DateTime fecha = DateTime.Now;
            string idSolicitud;
            MySqlCommand cmd = new MySqlCommand("insert into rd_traspaso(fecha, usuario, origen, destino, estatus, motivo) values(?fecha, ?usuario, ?origen, ?destino, ?status, ?motivo)", Conex);

            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy,MM,dd"));
            cmd.Parameters.AddWithValue("?usuario", UsuarioMyB);
            cmd.Parameters.AddWithValue("?origen", "BO");
            cmd.Parameters.AddWithValue("?destino", destino);
            cmd.Parameters.AddWithValue("?status", "SOLICITADO");
            cmd.Parameters.AddWithValue("?motivo", motivo);
            cmd.ExecuteNonQuery();
            idSolicitud = cmd.LastInsertedId.ToString();



            MySqlCommand cmd2 = new MySqlCommand("insert into rd_traspaso_articulos(fk_idtraspaso,articulo,descripcion,cantidad) values(?fk_idtraspaso,?articulo,?descripcion,?cantidad)", Conex);


            for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
            {



                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("?fk_idtraspaso", idSolicitud);
                            cmd2.Parameters.AddWithValue("?articulo", dgvSurtidor.Rows[i].Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("?descripcion", dgvSurtidor.Rows[i].Cells[2].Value.ToString());
                            cmd2.Parameters.AddWithValue("?cantidad", dgvSurtidor.Rows[i].Cells[3].Value.ToString());
                            cmd2.ExecuteNonQuery();

 
            }
            return idSolicitud;
        }

        public void CrearPDF(string id, string des, string mot, int ColumnaTienda)
        {
            DateTime fecha = DateTime.Now;
            string origen = "CEDIS";
            string destino = des;
            string motivo = mot;
            string idtraspaso = id;




            try
            {



                if (destino.Equals("VA"))
                {
                    destino = "VALLARTA";
                }

                if (destino.Equals("VE"))
                {
                    destino = "VELAZQUEZ";
                }

                if (destino.Equals("CO"))
                {
                    destino = "COLOSO";
                }

                if (destino.Equals("BO"))
                {
                    destino = "BODEGA";
                }

                if (destino.Equals("RE"))
                {
                    destino = "RENA";
                }
                if (destino.Equals("PREGOT"))
                {
                    destino = "PREGOT";
                }

                Document doc = new Document(PageSize.A4);
                string filename = "TraspasosPDF\\TRASPASO " + origen + " " + destino + " " + fecha.ToString("dd_MM_yyyy") + "_" + idtraspaso + ".pdf";
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@filename, FileMode.Create));

                doc.AddTitle("Prueba DaNxD");
                doc.AddCreator("DaN");

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



                parrafoEnc.Add("SOLICITUD DE TRASPASO " + origen + " No. " + idtraspaso);
                doc.Add(parrafoEnc);
                parrafoEnc.Clear();

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                //parrafo.Add(new Chunk("ID Traspaso: ", negritas));
                //parrafo.Add(new Chunk(id, normal));
                //doc.Add(parrafo);

                //parrafo.Clear();


                parrafo.Add(new Chunk("Fecha de Creacion: ", negritas));
                parrafo.Add(new Chunk(fecha.ToString(), normal));
                doc.Add(parrafo);

                parrafo.Clear();

                //parrafo.Add(new Chunk("Fecha de Aplicacion: ", negritas));
                //parrafo.Add(new Chunk(fecha_apli, normal));
                //doc.Add(parrafo);

                //parrafo.Clear();

                parrafo.Add(new Chunk("Elaboró: ", negritas));
                parrafo.Add(new Chunk(UsuarioMyB, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                //parrafo.Add(new Chunk("Origen: ", negritas));
                //parrafo.Add(new Chunk(origen, normal));

                //parrafo.Add("   ");
                parrafo.Add(new Chunk("Destino: ", negritas));
                parrafo.Add(new Chunk(destino, normal));

                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Motivo: ", negritas));
                parrafo.Add(new Chunk(motivo.ToUpper(), normal));
                doc.Add(parrafo);

                parrafo.Clear();



                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                parrafoEnc.Add("ARTICULOS DEL TRASPASO");
                doc.Add(parrafoEnc);
                doc.Add(Chunk.NEWLINE);
                // PRUEBA DAN
                PdfPTable table = new PdfPTable(3);

                table.WidthPercentage = 100;
                float[] widths = new float[] { 40f, 100f, 40f };
                table.SetWidths(widths);
                table.SkipLastFooter = true;
                table.SpacingAfter = 10;


                //Encabezados
                //for (int j = 0; j < DG_datos.Columns.Count; j++)
                //{
                table.AddCell(new Phrase("ARTICULO"));
                table.AddCell(new Phrase("DESCRIPCION"));
                table.AddCell(new Phrase("CANTIDAD"));

                //}

                //flag the first row as a header
                table.HeaderRows = 1;

                for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
                {
                    
                                table.AddCell(new Phrase(dgvSurtidor[1, i].Value.ToString()));
                                table.AddCell(new Phrase(dgvSurtidor[2, i].Value.ToString()));
                                table.AddCell(new Phrase(dgvSurtidor[3, i].Value.ToString()));

                }

                doc.Add(table);


                doc.Close();
                writer.Close();

                //Process prc = new System.Diagnostics.Process();
                //prc.StartInfo.FileName = filename;

                System.Diagnostics.Process.Start(filename);
                //MessageBox.Show(filename);
                //    prc.Start();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("Error al generar archivo PDF o el archivo ya esta abierto.");
            }
        }
    }
}
