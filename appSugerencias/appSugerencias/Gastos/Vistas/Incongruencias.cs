using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Ventas.Controlador;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class Incongruencias : Form
    {
        public Incongruencias()
        {
            InitializeComponent();
        }


        string tipo_gasto = "";
        string claveConcepto = "";
        DataTable conDetalle;
        public void BuscarGastosIncongruentes()
        {
            DG_tabla.Rows.Clear();
            DG_tabla.Columns.Clear();
            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            bool check = CBX_respaldo.Checked;

            //AGREGAR COLUMNAS AL DATAGRID
            DataTable dt = RevisionGastosController.ColumnasGastosIncongruentes(sucursal,inicio,fin,check);
            DG_tabla.Columns.Add("FECHAS","FECHAS");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DG_tabla.Columns.Add(dt.Rows[i]["concepto"].ToString(), dt.Rows[i]["descripcion"].ToString()+" "+dt.Rows[i]["tipo"].ToString());
            }

            ArrayList fechas = FormatoFecha.RangoFechas(inicio,fin);
            for (int i = 0; i < fechas.Count; i++)
            {
                DG_tabla.Rows.Add(fechas[i].ToString());
            }


            //AGREGAR LOS IMPORTES EN CADA COLUMNA
            DataTable importesConceptos = RevisionGastosController.GastosIncongruentes(sucursal,inicio,fin,check);

            //Creamos una vista del DataTable para organizarlo por fecha

            DataView dtV = importesConceptos.DefaultView;
            dtV.Sort = "FECHA ASC";
            importesConceptos = dtV.ToTable();
            DateTime fecha;
            DateTime fechaDT;
            string concepto = "",conceptoDT="";

           
            //===================== se agregan los importes a cada concepto =======================================
            for (int i = 1; i < DG_tabla.Columns.Count; i++)
            {


                for (int j = 0; j < importesConceptos.Rows.Count; j++)
                {
                   
                    concepto = DG_tabla.Columns[i].Name;
                    conceptoDT = importesConceptos.Rows[j]["CONCEPTO"].ToString();

                    if (concepto.Equals(conceptoDT))
                    {
                        for (int k = 0; k < DG_tabla.Rows.Count; k++)
                        {
                            
                            fecha = Convert.ToDateTime(DG_tabla.Rows[k].Cells[0].Value.ToString());
                            fechaDT = Convert.ToDateTime(importesConceptos.Rows[j]["FECHA"].ToString());
                            if (fecha.Equals(fechaDT))
                            {
                                DG_tabla.Rows[k].Cells[concepto].Value = Convert.ToDouble(importesConceptos.Rows[j]["IMPORTE"].ToString());
                                DG_tabla.Rows[k].Cells[concepto].Style.ForeColor = Color.White;
                                DG_tabla.Rows[k].Cells[concepto].Style.BackColor = Color.SeaGreen;
                            }




                        }
                    }
                   
                   
                   
                }

               
                
            }

            //==================== se agrega las columnas de los ingresos =====================================
            DG_tabla.Columns.Add("SOBRA", "SOBRANTE");
            DG_tabla.Columns.Add("COMID", "CUOTA COMIDA");
            DG_tabla.Columns.Add("COMIE", "VENTA COMIDA");


            //=============== se agrega importes de los ingresos =============================================
            DataTable conceptosIngresos = VentaController.IngresosIncongruencia(sucursal, inicio, fin, check);
            ArrayList ingresos = new ArrayList();
            ingresos.Add("SOBRA");
            ingresos.Add("COMID");
            ingresos.Add("COMIE");
       


            for (int i = 0; i < conceptosIngresos.Rows.Count; i++)
            {

                conceptoDT = conceptosIngresos.Rows[i]["CONCEPTO"].ToString();
                fechaDT = Convert.ToDateTime(conceptosIngresos.Rows[i]["FECHA"].ToString());
                if (conceptoDT.Equals("SOBRA"))
                {
                    for (int j = 0; j < DG_tabla.Rows.Count; j++)
                    {
                        fecha = Convert.ToDateTime(DG_tabla.Rows[j].Cells["FECHAS"].Value.ToString());

                        if (fechaDT.Equals(fecha))
                        {
                            DG_tabla.Rows[j].Cells["SOBRA"].Value = Convert.ToDouble(conceptosIngresos.Rows[i]["IMPORTE"].ToString());
                            DG_tabla.Rows[j].Cells["SOBRA"].Style.BackColor = Color.SeaGreen;
                            DG_tabla.Rows[j].Cells["SOBRA"].Style.ForeColor = Color.White; ;
                        }
                    }
                }
                else if(conceptoDT.Equals("COMID"))
                {
                    for (int j = 0; j < DG_tabla.Rows.Count; j++)
                    {
                        fecha = Convert.ToDateTime(DG_tabla.Rows[j].Cells["FECHAS"].Value.ToString());

                        if (fechaDT.Equals(fecha))
                        {
                            DG_tabla.Rows[j].Cells["COMID"].Value = Convert.ToDouble(conceptosIngresos.Rows[i]["IMPORTE"].ToString());
                            DG_tabla.Rows[j].Cells["COMID"].Style.BackColor = Color.SeaGreen;
                            DG_tabla.Rows[j].Cells["COMID"].Style.ForeColor = Color.White;
                        }
                    }
                }
                else if(conceptoDT.Equals("COMIE"))
                {
                    for (int j = 0; j < DG_tabla.Rows.Count; j++)
                    {
                        fecha = Convert.ToDateTime(DG_tabla.Rows[j].Cells["FECHAS"].Value.ToString());

                        if (fechaDT.Equals(fecha))
                        {
                            DG_tabla.Rows[j].Cells["COMIE"].Value =  Convert.ToDouble(conceptosIngresos.Rows[i]["IMPORTE"].ToString());
                            DG_tabla.Rows[j].Cells["COMIE"].Style.BackColor = Color.SeaGreen;
                            DG_tabla.Rows[j].Cells["COMIE"].Style.ForeColor = Color.White;
                        }
                    }
                }
                
            }

            //Llenar espacios vacios con 0
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                for (int j = 1; j < DG_tabla.Columns.Count; j++)
                {

                    if (DG_tabla.Rows[i].Cells[j].Value == null)
                    {
                        DG_tabla.Rows[i].Cells[j].Value = Convert.ToDouble("0.00");
                        DG_tabla.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        DG_tabla.Rows[i].Cells[j].Style.BackColor = Color.DarkRed;

                    }
                   
                }
            }


            

            FormatoCeldas();


        }

        
        public void FormatoCeldas()
        {

            DG_tabla.Columns[0].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            DG_tabla.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 1; i < DG_tabla.Columns.Count; i++)
            {
                
                
                DG_tabla.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                DG_tabla.Columns[i].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[i].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);



            }
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            BuscarGastosIncongruentes();
        }


       
        private void Incongruencias_Load(object sender, EventArgs e)
        {
           
           
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;



            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;

                excel.Cells[5, indiceColumna] = col.HeaderText;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_tabla.Columns)
                {
                    indiceColumna++;



                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }

            excel.Cells.Range["A4"].Value = "Reporte de incongruencias " + CB_sucursal.SelectedItem.ToString() + " del "+DT_inicio.Value.ToString("dd-MM-yyyy") +" al "+DT_fin.Value.ToString("dd-MM-yyyy");
            excel.Cells.Range["A4:F4"].Merge();
            excel.Cells.Range["B6:AT40"].NumberFormat = "$#,##0.00";


            excel.Visible = true;
        }

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            CB_concepto_detalle.Text = "";
            tipo_gasto = "TIENDA";
            List<Egreso>  conceptosGral= TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }
        }

        private void RB_general_CheckedChanged(object sender, EventArgs e)
        {
            CB_concepto_gral.Items.Clear();
            CB_concepto_gral.Text = "";
            CB_concepto_detalle.Text = "";
            tipo_gasto = "GENERAL";
            List<Egreso> conceptosGral = TipoGastosController.ConceptosGrales(tipo_gasto);
            foreach (var item in conceptosGral)
            {
                CB_concepto_gral.Items.Add(item.ConceptoGral);
            }
        }

        private void CB_concepto_gral_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_concepto_detalle.Items.Clear();
            CB_concepto_detalle.Text = "";

            string conceptGral = CB_concepto_gral.SelectedItem.ToString();
           
            List<Egreso> conceptosDetalle = TipoGastosController.ConceptoDetalle(conceptGral, tipo_gasto);
            conDetalle = new DataTable();
            conDetalle.Columns.Add("CONCEPTO",typeof(string));
            conDetalle.Columns.Add("DESCRIPCION", typeof(string));
            foreach (var item in conceptosDetalle)
            {
                CB_concepto_detalle.Items.Add(item.ConceptoDetalle);
                conDetalle.Rows.Add(item.Clave, item.ConceptoDetalle);
            }
        }

        private void BT_agregar_Click(object sender, EventArgs e)
        {
            string sucursal = CB_sucursal.SelectedItem.ToString();
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            string query = "INSERT INTO rd_conceptos_incongruencias(concepto) VALUES(?concepto)";
            MySqlCommand cmd = new MySqlCommand(query,con);
            cmd.Parameters.AddWithValue("?concepto",claveConcepto);
            cmd.ExecuteNonQuery();
            CB_concepto_detalle.Items.Clear();
            CB_concepto_detalle.Text = "";
            MessageBox.Show("Se ha guardado el concepto de egreso");
            

        }

        private void CB_concepto_detalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < conDetalle.Rows.Count; i++)
            {
                if (CB_concepto_detalle.SelectedItem.ToString().Equals(conDetalle.Rows[i]["DESCRIPCION"].ToString()))
                {
                    claveConcepto = conDetalle.Rows[i]["CONCEPTO"].ToString();
                }
            }
        }
    }
}
