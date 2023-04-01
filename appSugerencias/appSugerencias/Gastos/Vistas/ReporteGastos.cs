using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
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
    public partial class ReporteGastos : Form
    {
        public ReporteGastos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            CB_concepto_detalle.Items.Clear();
            CB_concepto_detalle.Text = "";
            List<Egreso> lista = TipoGastosController.ConceptosGrales("TIENDA");

            foreach (var item in lista)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral.ToString());
            }
        }

        private void RB_general_CheckedChanged(object sender, EventArgs e)
        {

            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            CB_concepto_detalle.Items.Clear();
            CB_concepto_detalle.Text = "";
            List<Egreso> lista = TipoGastosController.ConceptosGrales("GENERAL");

            foreach (var item in lista)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral.ToString());
            }
        }

        private void RB_todos_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            CB_concepto_detalle.Items.Clear();
            CB_concepto_detalle.Text = "";
        }

        private void ReporteGastos_Load(object sender, EventArgs e)
        {
            RB_todos.Checked = true;
        }

        private void CB_concepto_gral_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoGasto = "";

            if (RB_tienda.Checked == true)
            {
                tipoGasto = "TIENDA";
            }

            if (RB_general.Checked == true)
            {
                tipoGasto = "GENERAL";
            }

            CB_concepto_detalle.Items.Clear();
            CB_concepto_detalle.Text = "";
            string conceptoGral = CB_concepto_gral.SelectedItem.ToString();
            List<Egreso> lista = TipoGastosController.ConceptoDetalle(conceptoGral, tipoGasto);
            foreach (var item in lista)
            {
                CB_concepto_detalle.Items.Add(item.ConceptoDetalle.ToString());
            }
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {

            double total = 0;
            string tipoGasto = "";
            LB_total.Text = "";
            DG_tabla.Rows.Clear();
            string sucursal = "";
            DateTime inicio,fin;
            bool check = false;

            if (CBX_respaldo.Checked==true)
            {
                check = true;
            }

            if (RB_todos.Checked==true)//TODOS LOS GASTOS (TIENDA Y GENERALES)
            {
                inicio = DT_inicio.Value;
                fin = DT_fin.Value;


                if (CB_sucursal.SelectedIndex==-1)
                {
                    MessageBox.Show("Debes seleccionar una sucursal");
                }
                else
                {
                    sucursal = CB_sucursal.SelectedItem.ToString();
                    if (sucursal.Equals("CEDIS"))
                    {
                        List<GastoAlmacenCedis> lista = GastosAlmacenCedisController.BuscarGastos(inicio,fin);
                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.FolioSalida,"GENERAL", item.ConceptoGral, item.ConceptoDetalle, item.DescripcionDetallada, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.FolioAprobacion);
                            total += item.Importe;
                        }
                    }else if(sucursal.Equals("FINANZAS"))
                    {
                      List<GastoExterno> lista = GastoFinanzasController.ListaGastos(inicio,fin);
                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.Folio, "GENERAL", item.Concepto_gral, item.ConceptoDetalle, item.Descripcion, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                            total += item.Importe;
                        }
                    }
                    else
                    {
                        RevisionGastosController rg = new RevisionGastosController();
                        List<Gasto> lista = rg.BuscarXFechas(inicio, fin, sucursal, check);

                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.Ticket, item.Tipo_egreso, item.Concepto, item.Descripcion, "", item.Importe, item.Fecha.ToString("yyyy-MM-dd"), "");
                            total += item.Importe;
                        }

                        GastosController gc = new GastosController();
                        DataTable dt = gc.DatosGasto(sucursal, inicio, fin);

                        for (int i = 0; i < DG_tabla.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                if (DG_tabla.Rows[i].Cells["TICKET"].Value.ToString().Equals(dt.Rows[j]["ticket"].ToString()))
                                {
                                    DG_tabla.Rows[i].Cells["DESCRIP_DETALLADA"].Value = dt.Rows[j]["comentario"].ToString();
                                    DG_tabla.Rows[i].Cells["NUM_AUTORIZACION"].Value = dt.Rows[j]["numAutorizacion"].ToString();
                                }
                            }
                        }
                    }
                }
               
               
            }
            else if(RB_tienda.Checked==true)
            {
                tipoGasto = "TIENDA";
                inicio = DT_inicio.Value;
                fin = DT_fin.Value;
                sucursal = CB_sucursal.SelectedItem.ToString();

                if ((RB_general.Checked == true || RB_tienda.Checked == true) && !CB_concepto_gral.Text.Equals("") && CB_concepto_detalle.Text.Equals(""))

                {
                    //busca gasto por concepto gral

                    bool general = RB_general.Checked;
                    bool tienda = RB_tienda.Checked;
                    string tipo_gasto = "";
                    if (general == true)
                    {
                        tipo_gasto = "GENERAL";
                    }
                    else if (tienda == true)
                    {
                        tipo_gasto = "TIENDA";
                    }


                    inicio = DT_inicio.Value;
                    fin = DT_fin.Value;
                    sucursal = CB_sucursal.SelectedItem.ToString();
                    RevisionGastosController rg = new RevisionGastosController();
                    List<Gasto> lista = rg.BuscarGastoXConceptoGral(sucursal, inicio, fin, tipo_gasto, CB_concepto_gral.SelectedItem.ToString());

                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.Ticket, item.Tipo_egreso, item.Concepto, item.Descripcion, item.Detalle, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                        total += item.Importe;
                    }


                    GastosController gc = new GastosController();
                    DataTable dt = gc.DatosGasto(sucursal, inicio, fin);

                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            if (DG_tabla.Rows[i].Cells["TICKET"].Value.ToString().Equals(dt.Rows[j]["ticket"].ToString()))
                            {
                                DG_tabla.Rows[i].Cells["DESCRIP_DETALLADA"].Value = dt.Rows[j]["comentario"].ToString();
                                DG_tabla.Rows[i].Cells["NUM_AUTORIZACION"].Value = dt.Rows[j]["numAutorizacion"].ToString();
                            }
                        }
                    }


                }
                else
                {

                    //busca gasto por concepto general y concepto detalle
                    RevisionGastosController rg = new RevisionGastosController();
                    List<Gasto> lista = rg.BuscarGastoXConcepto(sucursal, inicio, fin, tipoGasto, CB_concepto_gral.SelectedItem.ToString(), CB_concepto_detalle.SelectedItem.ToString());
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.Ticket, item.Tipo_egreso, item.Concepto, item.Descripcion, item.Detalle, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                        total += item.Importe;
                    }
                    GastosController gc = new GastosController();
                    DataTable dt = gc.DatosGasto(sucursal, inicio, fin);

                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            if (DG_tabla.Rows[i].Cells["TICKET"].Value.ToString().Equals(dt.Rows[j]["ticket"].ToString()))
                            {
                                DG_tabla.Rows[i].Cells["DESCRIP_DETALLADA"].Value = dt.Rows[j]["comentario"].ToString();
                                DG_tabla.Rows[i].Cells["NUM_AUTORIZACION"].Value = dt.Rows[j]["numAutorizacion"].ToString();
                            }
                        }
                    }
                }





                
            }
            else if(RB_general.Checked==true)
            {
                tipoGasto = "GENERAL";
                inicio = DT_inicio.Value;
                fin = DT_fin.Value;
                sucursal = CB_sucursal.SelectedItem.ToString();
               


                if ((RB_general.Checked == true || RB_tienda.Checked == true) && !CB_concepto_gral.Text.Equals("") && CB_concepto_detalle.Text.Equals(""))

                {
                    //busca gasto por concepto gral

                    bool general = RB_general.Checked;
                    bool tienda = RB_tienda.Checked;
                    string tipo_gasto = "";
                    if (general == true)
                    {
                        tipo_gasto = "GENERAL";
                    }
                    else if (tienda == true)
                    {
                        tipo_gasto = "TIENDA";
                    }


                    inicio = DT_inicio.Value;
                    fin = DT_fin.Value;
                    sucursal = CB_sucursal.SelectedItem.ToString();
                    if (sucursal.Equals("CEDIS"))
                    {
                        List<GastoAlmacenCedis> lista = GastosAlmacenCedisController.BuscarGastoXConceptoGral(CB_concepto_gral.SelectedItem.ToString(),inicio,fin);
                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.FolioSalida, "GENERAL", item.ConceptoGral, item.ConceptoDetalle, item.DescripcionDetallada, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.FolioAprobacion);
                            total += item.Importe;
                        }
                    }
                    if (sucursal.Equals("FINANZAS"))
                    {
                        List<GastoExterno> lista = GastoFinanzasController.BuscarGastoFinanzasXConceptoGral(CB_concepto_gral.SelectedItem.ToString(), inicio,fin);
                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.Folio, "GENERAL", item.Concepto_gral, item.ConceptoDetalle, item.Descripcion, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                            total += item.Importe;
                        }
                    }
                    else
                    {
                        RevisionGastosController rg = new RevisionGastosController();
                        List<Gasto> lista = rg.BuscarGastoXConceptoGral(sucursal, inicio, fin, tipo_gasto, CB_concepto_gral.SelectedItem.ToString());

                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.Ticket, item.Tipo_egreso, item.Concepto, item.Descripcion, item.Detalle, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                            total += item.Importe;
                        }

                        GastosController gc = new GastosController();
                        DataTable dt = gc.DatosGasto(sucursal, inicio, fin);

                        for (int i = 0; i < DG_tabla.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                if (DG_tabla.Rows[i].Cells["TICKET"].Value.ToString().Equals(dt.Rows[j]["ticket"].ToString()))
                                {
                                    DG_tabla.Rows[i].Cells["DESCRIP_DETALLADA"].Value = dt.Rows[j]["comentario"].ToString();
                                    DG_tabla.Rows[i].Cells["NUM_AUTORIZACION"].Value = dt.Rows[j]["numAutorizacion"].ToString();
                                }
                            }
                        }
                    }
                }
                else
                {

                    if (sucursal.Equals("CEDIS"))
                    {
                        List<GastoAlmacenCedis> lista = GastosAlmacenCedisController.BuscarGastoXConceptoDetalle(CB_concepto_gral.SelectedItem.ToString(),CB_concepto_detalle.SelectedItem.ToString() ,inicio, fin);
                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.FolioSalida, "GENERAL", item.ConceptoGral, item.ConceptoDetalle, item.DescripcionDetallada, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.FolioAprobacion);
                            total += item.Importe;
                        }

                    }
                    else if (sucursal.Equals("FINANZAS"))
                    {
                        List<GastoExterno> lista = GastoFinanzasController.BuscarGastoFinanzasXConceptoDetalle(CB_concepto_gral.SelectedItem.ToString(),CB_concepto_detalle.SelectedItem.ToString(),inicio,fin);
                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.Folio, "GENERAL", item.Concepto_gral, item.ConceptoDetalle, item.Descripcion, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                            total += item.Importe;
                        }
                    }
                    else
                    {
                        RevisionGastosController rg = new RevisionGastosController();
                        List<Gasto> lista = rg.BuscarGastoXConcepto(sucursal, inicio, fin, tipoGasto, CB_concepto_gral.SelectedItem.ToString(), CB_concepto_detalle.SelectedItem.ToString());
                        foreach (var item in lista)
                        {
                            DG_tabla.Rows.Add(item.Ticket, item.Tipo_egreso, item.Concepto, item.Descripcion, item.Detalle, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                            total += item.Importe;
                        }

                        GastosController gc = new GastosController();
                        DataTable dt = gc.DatosGasto(sucursal, inicio, fin);

                        for (int i = 0; i < DG_tabla.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                if (DG_tabla.Rows[i].Cells["TICKET"].Value.ToString().Equals(dt.Rows[j]["ticket"].ToString()))
                                {
                                    DG_tabla.Rows[i].Cells["DESCRIP_DETALLADA"].Value = dt.Rows[j]["comentario"].ToString();
                                    DG_tabla.Rows[i].Cells["NUM_AUTORIZACION"].Value = dt.Rows[j]["numAutorizacion"].ToString();
                                }
                            }
                        }
                    }
                    

                    
                }



            }
            else if(RB_tienda_todos.Checked==true || RB_general_todos.Checked == true)
            {

                bool general = RB_general_todos.Checked;
                bool tienda = RB_tienda_todos.Checked;
                string tipo_gasto = "";
                if (general == true)
                {
                    tipo_gasto = "GENERAL";
                }
                else if (tienda == true)
                {
                    tipo_gasto = "TIENDA";
                }

                inicio = DT_inicio.Value;
                fin = DT_fin.Value;
                sucursal = CB_sucursal.SelectedItem.ToString();
                if (sucursal.Equals("CEDIS"))
                {

                    List<GastoAlmacenCedis> lista = GastosAlmacenCedisController.BuscarGastos(inicio, fin);
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.FolioSalida, "GENERAL", item.ConceptoGral, item.ConceptoDetalle, item.DescripcionDetallada, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.FolioAprobacion);
                        total += item.Importe;
                    }
                }
                else if (sucursal.Equals("FINANZAS"))
                {
                    List<GastoExterno> lista = GastoFinanzasController.ListaGastos(inicio, fin);
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.Folio, "GENERAL", item.Concepto_gral, item.ConceptoDetalle, item.Descripcion, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                        total += item.Importe;
                    }
                }
                else
                {
                    RevisionGastosController rg = new RevisionGastosController();
                    List<Gasto> lista = rg.BuscarGastosXTipoGasto(sucursal, inicio, fin, tipo_gasto);
                    foreach (var item in lista)
                    {
                        DG_tabla.Rows.Add(item.Ticket, item.Tipo_egreso, item.Concepto, item.Descripcion, item.Detalle, item.Importe, item.Fecha.ToString("yyyy-MM-dd"), item.NumAutorizacion);
                        total += item.Importe;
                    }

                    GastosController gc = new GastosController();
                    DataTable dt = gc.DatosGasto(sucursal, inicio, fin);

                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Rows.Count; j++)
                        {
                            if (DG_tabla.Rows[i].Cells["TICKET"].Value.ToString().Equals(dt.Rows[j]["ticket"].ToString()))
                            {
                                DG_tabla.Rows[i].Cells["DESCRIP_DETALLADA"].Value = dt.Rows[j]["comentario"].ToString();
                                DG_tabla.Rows[i].Cells["NUM_AUTORIZACION"].Value = dt.Rows[j]["numAutorizacion"].ToString();
                            }
                        }
                    }
                }
            }
           
           
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
            LB_total.Text = total.ToString("C2");
            total = 0;
        }

        private void BT_excel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;


            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {

                if (col.Visible==true)
                {
                     indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;
                }
               

            }

            int indiceFila = 4;



            foreach (DataGridViewRow row in DG_tabla.Rows)
            {
                //if (row.Visible == true)
                //{
                    indiceFila++;
                    indiceColumna = 0;

                    foreach (DataGridViewColumn col in DG_tabla.Columns)
                    {


                        if (col.Visible==true)
                        {
                            indiceColumna++;


                            excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                        }
                       




                    }

                //}
            }
            excel.Range["E6:C1000"].NumberFormat = "$#,##0.00";
           
            excel.Visible = true;
        }

        private void DG_tabla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            if (CB_sucursal.SelectedItem.Equals("FINANZAS"))
            {

            }
            else
            {
                int ticket = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells["TICKET"].Value.ToString());
                string tipo_gasto = DG_tabla.Rows[e.RowIndex].Cells["TIPO_GASTO"].Value.ToString();
                string concepto_gral = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTO_GRAL"].Value.ToString();
                string concepto_detalle = DG_tabla.Rows[e.RowIndex].Cells["CONCEPTO_DETALLE"].Value.ToString();
                string sucursal = CB_sucursal.SelectedItem.ToString();
                DateTime fecha = Convert.ToDateTime(DG_tabla.Rows[e.RowIndex].Cells["FECHA"].Value.ToString());
                double importe = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells["IMPORTE"].Value.ToString());
                ModificarGasto mg = new ModificarGasto(ticket, tipo_gasto, concepto_gral, concepto_detalle, sucursal, fecha, importe);
                mg.Show();
            }
          
        }

        private void CB_concepto_detalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
