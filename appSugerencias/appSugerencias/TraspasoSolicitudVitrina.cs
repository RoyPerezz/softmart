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
    public partial class TraspasoSolicitudVitrina : Form
    {
        int idtraspaso = 0;
        int existencia = 0;
        //TextReader IP;
#pragma warning disable CS0414 // El campo 'TraspasoSolicitudVitrina.cantidad' está asignado pero su valor nunca se usa
        int cantidad = 0;
#pragma warning restore CS0414 // El campo 'TraspasoSolicitudVitrina.cantidad' está asignado pero su valor nunca se usa
#pragma warning disable CS0649 // El campo 'TraspasoSolicitudVitrina.Usuario' nunca se asigna y siempre tendrá el valor predeterminado null
        string Usuario;
#pragma warning restore CS0649 // El campo 'TraspasoSolicitudVitrina.Usuario' nunca se asigna y siempre tendrá el valor predeterminado null

        public TraspasoSolicitudVitrina()
        {
            InitializeComponent();
        }

        private void BT_agregar_Click(object sender, EventArgs e)
        {
            if (DG_datos.RowCount > 0)
            {
                bool bCampoVacio = false;
                foreach (DataGridViewRow dr in DG_datos.Rows)
                {
                    foreach (DataGridViewCell dc in dr.Cells)
                    {
                        if (dc.Value == null || string.IsNullOrEmpty(dc.Value.ToString()))
                        {
                            bCampoVacio = true;
                        }
                        else
                        {

                        }
                    }
                }
                if (bCampoVacio)
                {
                    MessageBox.Show("Introduce la cantidad");
                }
                else
                {
                    // dataGridView1.Rows.Add(TB_nombre.Text, TB_apellidos.Text);
                    AgregarArticulo();
                    TB_articulo.Text = "";
                    LB_filas.Text = DG_datos.RowCount.ToString();
                }


            }
            else
            {
                AgregarArticulo();
                TB_articulo.Text = "";
                //dataGridView1.Rows.Add(TB_nombre.Text, TB_apellidos.Text);
                LB_filas.Text = DG_datos.RowCount.ToString();
            }
        }


        //##################################################### ESTE MÉTODO AGREGA LOS ARTICULOS AL DATAGRIDVIEW #######################################
        public void AgregarArticulo()
        {


            MySqlConnection con = BDConexicon.conectar();


            if (TB_articulo.Text.Equals(""))
            {
                MessageBox.Show("Introduce el artículo");

            }
            else
            {



                //obtengo el id del ultimo traspaso creado

                bool exist = DG_datos.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["CODIGO"].Value) == TB_articulo.Text);

                if (!exist)
                {


                    MySqlCommand c = new MySqlCommand("select articulo from prods where articulo='" + TB_articulo.Text + "'", con);
                    MySqlDataReader art = c.ExecuteReader();
                    string articulo = "";
                    while (art.Read())
                    {
                        articulo = art[0].ToString();
                    }
                    art.Close();



                    if (TB_articulo.Text.Equals(articulo))
                    {
                        MySqlCommand cmd = new MySqlCommand("select descrip, existencia from prods where articulo='" + TB_articulo.Text + "'", con);
                        MySqlDataReader rd = cmd.ExecuteReader();

                        while (rd.Read())
                        {


                            //double precio = Convert.ToDouble(rd["precio1"].ToString());
                            //precio += precio * .16;
                            existencia = Convert.ToInt32(rd["existencia"].ToString());

                            DG_datos.Rows.Add(TB_articulo.Text, rd["descrip"].ToString(), rd["existencia"].ToString());
                            DG_datos.CurrentRow.Cells[3].Selected = true;





                        }
                        rd.Close();


                    }
                    else
                    {
                        MessageBox.Show("El artículo no existe en la base de datos o el codigo es incorrecto, favor de verificar");
                    }


                }
                else
                {
                    MessageBox.Show("El artículo ya fue agregado al traspaso, favor de verificar");
                }



                con.Close();


            }




        }

        private void BT_quitar_Click(object sender, EventArgs e)
        {
            try
            {
                DG_datos.Rows.Remove(DG_datos.CurrentRow);
                LB_filas.Text = DG_datos.RowCount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede eliminar una fila sin datos");

            }
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = BDConexicon.conectar();

            try
            {


                //EncabezadoTras();


                if (CB_destino.SelectedIndex == -1)
                {
                    MessageBox.Show("Debes seleccionar un destino de traspaso");
                }
                else if (TB_motivo.Text.Equals(""))
                {
                    MessageBox.Show("Justifica el traspaso agregando un motivo");
                }
                else if (TB_origen.Text.Equals(CB_destino.SelectedItem.ToString()))
                {
                    MessageBox.Show("El origen y el destino es el mismo, favor de cambiar el destino");
                }
                else if (DG_datos.RowCount == 0)
                {
                    //crea el traspaso en rd_traspaso
                    MessageBox.Show("DEBES AGREGAR ARTICULOS A LA SOLICITUD DE TRASPASO");

                }
                else
                {

                    //CABECERA DE LA SOLICITUD
                    MySqlCommand cmd = new MySqlCommand("insert into rd_traspaso(fecha, usuario, origen, destino, estatus, motivo) values(?fecha, ?usuario, ?origen, ?destino, ?status, ?motivo)", con);
                    DateTime fecha = DT_fecha.Value;
                    cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy,MM,dd"));
                    cmd.Parameters.AddWithValue("?usuario", Usuario);
                    cmd.Parameters.AddWithValue("?origen", TB_origen.Text);
                    cmd.Parameters.AddWithValue("?destino", CB_destino.SelectedItem);
                    cmd.Parameters.AddWithValue("?status", "SOLICITADO");
                    cmd.Parameters.AddWithValue("?motivo", TB_motivo.Text.ToUpper());
                    cmd.ExecuteNonQuery();

                    //obtengo el ultimo id creado
                    MySqlCommand id = new MySqlCommand("select max(idtraspaso) as id from rd_traspaso ", con);
                    MySqlDataReader r = id.ExecuteReader();
                    //int idtraspaso = 0;
                    while (r.Read())
                    {
                        idtraspaso = Convert.ToInt32(r[0].ToString());
                        // MessageBox.Show("id:" + idtraspaso);
                    }

                    r.Close();



                    //se agregan articulos a la tabla 

                    MySqlCommand cmd2 = new MySqlCommand("insert into rd_traspaso_articulos(fk_idtraspaso,articulo,descripcion,cantidad) values(?fk_idtraspaso,?articulo,?descripcion,?cantidad)", con);



                    foreach (DataGridViewRow row in DG_datos.Rows)
                    {

                        cmd2.Parameters.Clear();
                        cmd2.Parameters.AddWithValue("?fk_idtraspaso", idtraspaso);
                        cmd2.Parameters.AddWithValue("?articulo", Convert.ToString(row.Cells["CODIGO"].Value).ToUpper());
                        cmd2.Parameters.AddWithValue("?descripcion", Convert.ToString(row.Cells["DESCRIP"].Value).ToUpper());
                        cmd2.Parameters.AddWithValue("?cantidad", Convert.ToInt32(row.Cells["CANT"].Value));
                        cmd2.ExecuteNonQuery();





                    }




                    MessageBox.Show("Se han agregado los productos al traspaso");
                    //deshabilitar();
                    CrearPDF();
                    limpiar();
                    LB_filas.Text = "0";



                }


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);

            }
        }


        public void CrearPDF()
        {
            DateTime fecha = DT_fecha.Value;
            string origen = TB_origen.Text;
            string destino = Convert.ToString(CB_destino.SelectedItem);
            string motivo = TB_motivo.Text;





            try
            {

                if (origen.Equals("VA"))
                {
                    origen = "VALLARTA";
                }

                if (origen.Equals("VE"))
                {
                    origen = "VELAZQUEZ";
                }

                if (origen.Equals("CO"))
                {
                    origen = "COLOSO";
                }

                if (origen.Equals("BO"))
                {
                    origen = "BODEGA";
                }


                if (origen.Equals("RE"))
                {
                    origen = "RENA";
                }

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
                parrafo.Add(new Chunk(Usuario, normal));
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
                PdfPTable table = new PdfPTable(DG_datos.Columns.Count);

                table.WidthPercentage = 100;
                float[] widths = new float[] { 40f, 100f, 0f, 30f };
                table.SetWidths(widths);
                table.SkipLastFooter = true;
                table.SpacingAfter = 10;


                //Encabezados
                for (int j = 0; j < DG_datos.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(DG_datos.Columns[j].HeaderText));

                }

                //flag the first row as a header
                table.HeaderRows = 1;

                for (int i = 0; i < DG_datos.Rows.Count; i++)
                {
                    for (int k = 0; k < DG_datos.Columns.Count; k++)
                    {
                        if (DG_datos[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(DG_datos[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(table);


                doc.Close();
                writer.Close();

                System.Diagnostics.Process.Start(filename);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("Error al generar archivo PDF o el archivo ya esta abierto.");
            }
        }

        public void limpiar()
        {
            CB_destino.SelectedIndex = -1;
            TB_motivo.Text = "";
            DG_datos.Rows.Clear();
            DG_datos.Refresh();

        }

        private void TraspasoSolicitudVitrina_Load(object sender, EventArgs e)
        {
            Sucursal();
        }

        //########################### OBTIENE EL NOMBRE DE LA SUCURSAL ################################################################
        public void Sucursal()// obtiene el nombre de la sucursal, debe cambiar el método de conexión según la suc. donde se use
        {
            string sucursal = "";
            MySqlCommand cmd = new MySqlCommand("select empresa from econfig", BDConexicon.conectar());

            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                sucursal = rd[0].ToString();

                if (sucursal.Equals("RELOJ VALLARTA"))
                {
                    TB_origen.Text = "VA";
                }
                if (sucursal.Equals("RELOJ RENA"))
                {
                    TB_origen.Text = "RE";
                }
                if (sucursal.Equals("RELOJ COLOSO"))
                {
                    TB_origen.Text = "CO";
                }
                if (sucursal.Equals("RELOJ VELAZQUEZ"))
                {
                    TB_origen.Text = "VE";
                }
               
                if (sucursal.Equals("VITRINA PREGOT"))
                {
                    TB_origen.Text = "PREGOT";
                }
            }

            BDConexicon.ConectarClose();

        }
    }
}
