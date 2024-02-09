using appSugerencias.Inventario.Controlador;
using appSugerencias.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Inventario.Vistas
{
    public partial class CostoXlinea : Form
    {
        public CostoXlinea()
        {
            InitializeComponent();
        }
        double costoMayoreo = 0, costo = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> lineas = Catalogos.CatalogoLineas();

            foreach (var item in lineas)
            {
                CB_lineas.Items.Add(item);
            }

            DG_Tabla.Rows.Add("CEDIS",0,0,"");
            DG_Tabla.Rows.Add("VALLARTA", 0, 0,"");
            DG_Tabla.Rows.Add("RENA", 0, 0,"");
            DG_Tabla.Rows.Add("VELAZQUEZ", 0, 0,"");
            DG_Tabla.Rows.Add("COLOSO", 0, 0,"");
            DG_Tabla.Rows.Add("TOTALES", 0, 0, "");

        }

        private void CB_lineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_claveLinea.Text = Catalogos.ClaveLinea(CB_lineas.Text);
        }

       

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);




            int indiceColumna = 0;



            foreach (DataGridViewColumn col in DG_Tabla.Columns)
            {
                indiceColumna++;
                if (indiceColumna <=3)
                {
                    excel.Cells[5, indiceColumna] = col.Name;
                }
               

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_Tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_Tabla.Columns)
                {
                    indiceColumna++;

                    if (indiceColumna<=3)
                    {
                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                    }

                   






                }



            }


            excel.Cells.Range["B6:M36"].NumberFormat = "$#,##0.00";


            excel.Visible = true;
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_Tabla.Rows[0].Cells["PRECIO_MAY"].Value = 0;
            DG_Tabla.Rows[0].Cells["COSTO"].Value = 0;
            DG_Tabla.Rows[0].Cells["ESTADO"].Value = "";
            DG_Tabla.Rows[0].Cells["ESTADO"].Style.BackColor = Color.White;
            DG_Tabla.Rows[1].Cells["PRECIO_MAY"].Value = 0;
            DG_Tabla.Rows[1].Cells["COSTO"].Value = 0;
            DG_Tabla.Rows[1].Cells["ESTADO"].Value = "";
            DG_Tabla.Rows[1].Cells["ESTADO"].Style.BackColor = Color.White;
            DG_Tabla.Rows[2].Cells["PRECIO_MAY"].Value = 0;
            DG_Tabla.Rows[2].Cells["COSTO"].Value = 0;
            DG_Tabla.Rows[2].Cells["ESTADO"].Value = "";
            DG_Tabla.Rows[2].Cells["ESTADO"].Style.BackColor = Color.White;
            DG_Tabla.Rows[3].Cells["PRECIO_MAY"].Value = 0;
            DG_Tabla.Rows[3].Cells["COSTO"].Value = 0;
            DG_Tabla.Rows[3].Cells["ESTADO"].Value = "";
            DG_Tabla.Rows[3].Cells["ESTADO"].Style.BackColor = Color.White;
            DG_Tabla.Rows[4].Cells["PRECIO_MAY"].Value = 0;
            DG_Tabla.Rows[4].Cells["COSTO"].Value = 0;
            DG_Tabla.Rows[4].Cells["ESTADO"].Value = "";
            DG_Tabla.Rows[4].Cells["ESTADO"].Style.BackColor = Color.White;

            DG_Tabla.Rows[5].Cells["PRECIO_MAY"].Value = 0;
            DG_Tabla.Rows[5].Cells["COSTO"].Value = 0;
            double totalMayoreoCE = 0,totalMayoreoVA=0,totalMayoreoRE=0,totalMayoreoVE=0,totalMayoreoCO=0;
            double totalMenudeoCE = 0, totalMenudeoVA = 0, totalMenudeoRE = 0, totalMenudeoVE = 0, totalMenudeoCO = 0;
            if (InventarioController.InventarioAlMayoreo("BODEGA", TB_claveLinea.Text) >= 0 || InventarioController.InventarioAlCosto("BODEGA", TB_claveLinea.Text)>=0)
            {


                totalMayoreoCE = InventarioController.InventarioAlMayoreo("BODEGA", TB_claveLinea.Text);
                totalMenudeoCE = InventarioController.InventarioAlCosto("BODEGA", TB_claveLinea.Text);
                DG_Tabla.Rows[0].Cells["PRECIO_MAY"].Value = totalMayoreoCE = totalMayoreoCE + (totalMayoreoCE * 0.16);
                DG_Tabla.Rows[0].Cells["COSTO"].Value = totalMenudeoCE = totalMenudeoCE + (totalMenudeoCE * 0.16);
                DG_Tabla.Rows[0].Cells["ESTADO"].Value = "CONECTADO";
                DG_Tabla.Rows[0].Cells["ESTADO"].Style.BackColor = Color.Green;
                DG_Tabla.Rows[0].Cells["ESTADO"].Style.ForeColor = Color.White;
            }
            else
            {
                DG_Tabla.Rows[0].Cells["ESTADO"].Value = "SIN CONEXION";
                DG_Tabla.Rows[0].Cells["ESTADO"].Style.BackColor = Color.Red;
                DG_Tabla.Rows[0].Cells["ESTADO"].Style.ForeColor = Color.White;
            }

            if (InventarioController.InventarioAlMayoreo("VALLARTA", TB_claveLinea.Text) > 0 || InventarioController.InventarioAlCosto("VALLARTA", TB_claveLinea.Text) > 0)
            {
                totalMayoreoVA = InventarioController.InventarioAlMayoreo("VALLARTA", TB_claveLinea.Text);
                totalMenudeoVA = InventarioController.InventarioAlCosto("VALLARTA", TB_claveLinea.Text);
                DG_Tabla.Rows[1].Cells["PRECIO_MAY"].Value = totalMayoreoVA = totalMayoreoVA + (totalMayoreoVA * 0.16);
                DG_Tabla.Rows[1].Cells["COSTO"].Value = totalMenudeoVA = totalMenudeoVA + (totalMenudeoVA * 0.16);
                DG_Tabla.Rows[1].Cells["ESTADO"].Value = "CONECTADO";
                DG_Tabla.Rows[1].Cells["ESTADO"].Style.BackColor = Color.Green;
                DG_Tabla.Rows[1].Cells["ESTADO"].Style.ForeColor = Color.White;
            
            }else
            {
                DG_Tabla.Rows[1].Cells["ESTADO"].Value = "SIN CONEXION";
                DG_Tabla.Rows[1].Cells["ESTADO"].Style.BackColor = Color.Red;
                DG_Tabla.Rows[1].Cells["ESTADO"].Style.ForeColor = Color.White;
            }

            if (InventarioController.InventarioAlMayoreo("RENA", TB_claveLinea.Text)>=0 || InventarioController.InventarioAlCosto("RENA", TB_claveLinea.Text)>=0)
            {
                totalMayoreoRE = InventarioController.InventarioAlMayoreo("RENA", TB_claveLinea.Text);
                totalMenudeoRE = InventarioController.InventarioAlCosto("RENA", TB_claveLinea.Text);
                DG_Tabla.Rows[2].Cells["PRECIO_MAY"].Value = totalMayoreoRE = totalMayoreoRE + (totalMayoreoRE * 0.16);
                DG_Tabla.Rows[2].Cells["COSTO"].Value = totalMenudeoRE = totalMenudeoRE + (totalMenudeoRE*0.16);
                DG_Tabla.Rows[2].Cells["ESTADO"].Value = "CONECTADO";
                DG_Tabla.Rows[2].Cells["ESTADO"].Style.BackColor = Color.Green;
                DG_Tabla.Rows[2].Cells["ESTADO"].Style.ForeColor = Color.White;
            }
            else
            {

                DG_Tabla.Rows[2].Cells["ESTADO"].Value = "SIN CONEXION";
                DG_Tabla.Rows[2].Cells["ESTADO"].Style.BackColor = Color.Red;
                DG_Tabla.Rows[2].Cells["ESTADO"].Style.ForeColor = Color.White;
            }

            if (InventarioController.InventarioAlMayoreo("VELAZQUEZ", TB_claveLinea.Text)>0 || InventarioController.InventarioAlCosto("VELAZQUEZ", TB_claveLinea.Text)>0)
            {
                totalMayoreoVE = InventarioController.InventarioAlMayoreo("VELAZQUEZ", TB_claveLinea.Text);
                totalMenudeoVE = InventarioController.InventarioAlCosto("VELAZQUEZ", TB_claveLinea.Text);
                DG_Tabla.Rows[3].Cells["PRECIO_MAY"].Value = totalMayoreoVE = totalMayoreoVE + (totalMayoreoVE * 0.16);
                DG_Tabla.Rows[3].Cells["COSTO"].Value = totalMenudeoVE = totalMenudeoVE + (totalMenudeoVE*0.16);
                DG_Tabla.Rows[3].Cells["ESTADO"].Value = "CONECTADO";
                DG_Tabla.Rows[3].Cells["ESTADO"].Style.BackColor = Color.Green;
                DG_Tabla.Rows[3].Cells["ESTADO"].Style.ForeColor = Color.White;
            }
            else
            {

                DG_Tabla.Rows[3].Cells["ESTADO"].Value = "SIN CONEXION";
                DG_Tabla.Rows[3].Cells["ESTADO"].Style.BackColor = Color.Red;
                DG_Tabla.Rows[3].Cells["ESTADO"].Style.ForeColor = Color.White;
            }

            if (InventarioController.InventarioAlMayoreo("COLOSO", TB_claveLinea.Text)>0 || InventarioController.InventarioAlCosto("COLOSO", TB_claveLinea.Text)>0)
            {
                totalMayoreoCO = InventarioController.InventarioAlMayoreo("COLOSO", TB_claveLinea.Text);
                totalMenudeoCO = InventarioController.InventarioAlCosto("COLOSO", TB_claveLinea.Text);
                DG_Tabla.Rows[4].Cells["PRECIO_MAY"].Value = totalMayoreoCO = totalMayoreoCO + (totalMayoreoCO * 0.16);
                DG_Tabla.Rows[4].Cells["COSTO"].Value = totalMenudeoCO = totalMenudeoCO + (totalMenudeoCO*0.16);
                DG_Tabla.Rows[4].Cells["ESTADO"].Value = "CONECTADO";
                DG_Tabla.Rows[4].Cells["ESTADO"].Style.BackColor = Color.Green;
                DG_Tabla.Rows[4].Cells["ESTADO"].Style.ForeColor = Color.White;
            }
            else{
                DG_Tabla.Rows[4].Cells["ESTADO"].Value = "SIN CONEXION";
                DG_Tabla.Rows[4].Cells["ESTADO"].Style.BackColor = Color.Red;
                DG_Tabla.Rows[4].Cells["ESTADO"].Style.ForeColor = Color.White;
            }
          
           

            for (int i = 0; i < DG_Tabla.Rows.Count; i++)
            {
                costoMayoreo += Convert.ToDouble(DG_Tabla.Rows[i].Cells["PRECIO_MAY"].Value);
                costo += Convert.ToDouble(DG_Tabla.Rows[i].Cells["COSTO"].Value);
            }

            DG_Tabla.Rows[5].Cells["PRECIO_MAY"].Value = costoMayoreo;
            DG_Tabla.Rows[5].Cells["COSTO"].Value = costo;

            DG_Tabla.Columns["PRECIO_MAY"].DefaultCellStyle.Format = "C2";
            DG_Tabla.Columns["COSTO"].DefaultCellStyle.Format = "C2";
        }
    }
}
