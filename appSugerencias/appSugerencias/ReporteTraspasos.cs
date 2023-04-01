using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ReporteTraspasos : Form
    {
        public ReporteTraspasos()
        {
            InitializeComponent();
        }

        string sucursalLocal = "";

        #region METODOS

        public void PDF()
        {
            string id, usuario, usuario_aplic, fecha_sol, fecha_apli, origen, destino, motivo, observaciones, estatus;
            id = TB_id.Text;
            usuario = TB_creador.Text;
            origen = TB_origen.Text;
            destino = TB_destino.Text;
            fecha_sol = TB_fecha.Text;
            fecha_apli = TB_fecha_aplicacion.Text;
            motivo = TB_motivo.Text;
            estatus = TB_status.Text;
            usuario_aplic = TB_aplicado.Text;

            observaciones = TB_observacion.Text;
            try
            {
                Document doc = new Document(PageSize.A4);
                string filename = "TraspasosPDF\\TRASPASO " + id + " " + origen + ".pdf";
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@filename, FileMode.Create));

                doc.AddTitle("Reporte de traspaso");
                doc.AddCreator("Osmart");

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



                parrafoEnc.Add("Traspaso de " + origen + " N. " + id);
                doc.Add(parrafoEnc);
                parrafoEnc.Clear();

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                parrafo.Add(new Chunk("ID Traspaso: ", negritas));
                parrafo.Add(new Chunk(id, normal));
                doc.Add(parrafo);

                parrafo.Clear();


                parrafo.Add(new Chunk("Fecha de Creacion: ", negritas));
                parrafo.Add(new Chunk(fecha_sol, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Fecha de Aplicacion: ", negritas));
                parrafo.Add(new Chunk(fecha_apli, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Solicito: ", negritas));
                parrafo.Add(new Chunk(usuario, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Origen: ", negritas));
                parrafo.Add(new Chunk(origen, normal));

                parrafo.Add("         ");
                parrafo.Add(new Chunk("Destino: ", negritas));
                parrafo.Add(new Chunk(destino, normal));

                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Motivo: ", negritas));
                parrafo.Add(new Chunk(motivo, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Aplico: ", negritas));
                parrafo.Add(new Chunk(TB_aplicado.Text, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Observaciones: ", negritas));
                parrafo.Add(new Chunk(observaciones, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Estado: ", negritas));
                parrafo.Add(new Chunk(estatus, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                parrafoEnc.Add("ARTICULOS DEL TRASPASO");
                doc.Add(parrafoEnc);
                doc.Add(Chunk.NEWLINE);
                // PRUEBA DAN
                PdfPTable table = new PdfPTable(DG_detalle_traspasos.Columns.Count);

                table.WidthPercentage = 100;
                float[] widths = new float[] { 30f, 100f, 30f };
                table.SetWidths(widths);
                table.SkipLastFooter = true;
                table.SpacingAfter = 10;


                //Encabezados
                for (int j = 0; j < DG_detalle_traspasos.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(DG_detalle_traspasos.Columns[j].HeaderText));

                }

                //flag the first row as a header
                table.HeaderRows = 1;

                for (int i = 0; i < DG_detalle_traspasos.Rows.Count; i++)
                {
                    for (int k = 0; k < DG_detalle_traspasos.Columns.Count; k++)
                    {
                        if (DG_detalle_traspasos[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(DG_detalle_traspasos[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(table);


                doc.Close();
                writer.Close();

                Process prc = new System.Diagnostics.Process();
                prc.StartInfo.FileName = filename;
                prc.Start();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Error al generar archivo PDF o el archivo ya esta abierto.");
            }

        }


        public void BuscarTraspasos()
        {
            LB_conexion.Text = "";
            DG_traspasos.Rows.Clear();
            DG_detalle_traspasos.Rows.Clear();
            TB_destino.Text =""; TB_origen.Text = ""; TB_fecha.Text = "";TB_status.Text = "";TB_creador.Text = "";TB_motivo.Text = "";TB_observacion.Text = "";TB_id.Text = "";TB_fecha_aplicacion.Text = "";TB_aplicado.Text = "";
            TB_status.BackColor = Color.White;
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            try
            {

               
                MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                string query = "select idtraspaso from rd_traspaso where fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' and destino= '" + sucursalLocal + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DG_traspasos.Rows.Add(dr["idtraspaso"].ToString());
                    }
                    dr.Close();
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("No se han generado traspasos en esta fecha");
                }
               
                LB_conexion.Text = "Conectado";
                LB_conexion.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                LB_conexion.Text = "Sin conexion";
                LB_conexion.ForeColor = Color.Red;

            }
        }
        #endregion

        private void ReporteTraspasos_Load(object sender, EventArgs e)
        {
            DataTable sucursales = Sucursales.ObtenerSucursales();
          
            
            foreach (DataRow suc in sucursales.Rows)        
            {
                CB_sucursal.Items.Add(suc["descripcion"].ToString());
            }

            sucursalLocal = Sucursales.IdentificarSucursal();

            if (sucursalLocal.Equals("BODEGA")||sucursalLocal.Equals("CEDIS"))
            {
                sucursalLocal = "BO";
            }


            if (sucursalLocal.Equals("VALLARTA"))
            {
                sucursalLocal = "VA";
            }


            if (sucursalLocal.Equals("RENA"))
            {
                sucursalLocal = "RE";
            }


            if (sucursalLocal.Equals("VELAZQUEZ"))
            {
                sucursalLocal = "VE";
            }


            if (sucursalLocal.Equals("COLOSO") )
            {
                sucursalLocal = "CO";
            }

        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            BuscarTraspasos();
        }

        private void DG_traspasos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


          
            DG_detalle_traspasos.Rows.Clear();
            TB_destino.Text = ""; TB_origen.Text = ""; TB_fecha.Text = ""; TB_status.Text = ""; TB_creador.Text = ""; TB_motivo.Text = ""; TB_observacion.Text = ""; TB_id.Text = ""; TB_fecha_aplicacion.Text = ""; TB_aplicado.Text = "";
            TB_status.BackColor = Color.White;

            string idTraspaso = DG_traspasos.Rows[e.RowIndex].Cells[0].Value.ToString();

            string query = "Select * from rd_traspaso_articulos where fk_idtraspaso ='" + idTraspaso + "'";
            string query2 = "Select * from rd_traspaso where idtraspaso ='" + idTraspaso + "'";

            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_detalle_traspasos.Rows.Add(dr["articulo"].ToString(), dr["descripcion"].ToString(), dr["cantidad"].ToString());
            }
            dr.Close();

            MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                TB_id.Text = dr2["idtraspaso"].ToString();
                TB_origen.Text = dr2["origen"].ToString();
                TB_destino.Text = dr2["destino"].ToString();
                TB_fecha.Text = dr2["fecha"].ToString();
                TB_fecha_aplicacion.Text = dr2["fecha_aplica"].ToString();
                TB_status.Text = dr2["estatus"].ToString();
                TB_creador.Text = dr2["usuario"].ToString();
                TB_aplicado.Text = dr2["usuario_aplica"].ToString();
                TB_motivo.Text = dr2["motivo"].ToString();
                TB_observacion.Text = dr2["observacion_aplica"].ToString();
            }
            dr2.Close();
            conexion.Close();

            if (TB_status.Text.Equals("APLICADO"))
            {
                TB_status.ForeColor = Color.White;
                TB_status.BackColor = Color.Green;
            }


            if (TB_status.Text.Equals("SOLICITADO"))
            {
                TB_status.ForeColor = Color.White;
                TB_status.BackColor = Color.Blue;
            }


            if (TB_status.Text.Equals("CANCELADO"))
            {
                TB_status.ForeColor = Color.White;
                TB_status.BackColor = Color.Red;
            }
        }

        private void BT_pdf_Click(object sender, EventArgs e)
        {
            PDF();
        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
