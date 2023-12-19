using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ValorInventario : Form
    {
        public ValorInventario()
        {
            InitializeComponent();
        }


        double totalMayoreo = 0, totalCosto = 0;








        #region METODOS
        private void ValorInventario_Load(object sender, EventArgs e)
        {
            DG_tabla.Rows.Add("CEDIS", "$0.00", "$0.00");
            DG_tabla.Rows.Add("VALLARTA", "$0.00", "$0.00");
            DG_tabla.Rows.Add("RENA", "$0.00", "$0.00");
            DG_tabla.Rows.Add("VELAZQUEZ", "$0.00", "$0.00");
            DG_tabla.Rows.Add("COLOSO", "$0.00", "$0.00");
            DG_tabla.Rows.Add("TOTALES", "$0.00", "$0.00");
            DG_tabla.Rows[5].DefaultCellStyle.ForeColor = Color.White;
        }

        //SI LOS ENLACES ESTAN ACTIVOS PINTA DE VERDE EL NOMBRE DE LA SUCURSAL
        public void EnlaceOnline(string sucursal)
        {
            if (sucursal.Equals("BODEGA"))
            {
                LB_cedis.ForeColor = Color.Green;
            }

            if (sucursal.Equals("VALLARTA"))
            {
                LB_va.ForeColor = Color.Green;
            }

            if (sucursal.Equals("RENA"))
            {
                LB_rena.ForeColor = Color.Green;
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                LB_velazquez.ForeColor = Color.Green;
            }

            if (sucursal.Equals("COLOSO"))
            {
                LB_coloso.ForeColor = Color.Green;
            }
        }


        //SI LOS ENLACES ESTAN OFFLINE PINTA DE ROJO EL NOMBRE DE LA SUCURSAL
        public void EnlaceOffLine(string sucursal)
        {
            if (sucursal.Equals("BODEGA"))
            {
                LB_cedis.ForeColor = Color.Red;
            }

            if (sucursal.Equals("VALLARTA"))
            {
                LB_va.ForeColor = Color.Red;
            }

            if (sucursal.Equals("RENA"))
            {
                LB_rena.ForeColor = Color.Red;
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                LB_velazquez.ForeColor = Color.Red;
            }

            if (sucursal.Equals("COLOSO"))
            {
                LB_coloso.ForeColor = Color.Red;
            }
        }

        //CALCULA EL VALOR DEL INVENTARIO DE ACUERDO AL COSTO DE CADA ARTICULO
        public double InventarioAlCosto(string sucursal)
        {
            double total = 0;
            try
            {
                MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
                string query = "SELECT sum(prods.existencia * prods.costo_u) AS `costo` FROM prods WHERE prods.articulo <> 'SYS' and prods.EXISTENCIA > 0 ORDER BY prods.descrip";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total = Convert.ToDouble(dr["costo"].ToString());
                }
                dr.Close();
                conexion.Close();
                EnlaceOnline(sucursal);

            }

            catch (Exception ex)

            {
                EnlaceOffLine(sucursal);
                //MessageBox.Show("Error al traer el valor del inventario de "+sucursal);
            }

            return total;
        }

        //CALCULA EL VALOR DEL INVENTARIO DE ACUERDO AL VALOR DEL PRECIO DE MAYOREO
        public double InventarioAlMayoreo(string sucursal)
        {
            double total = 0;
            try
            {
                MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
                string query = "SELECT sum(prods.existencia * prods.PRECIO2) AS `mayoreo` FROM prods WHERE prods.articulo <> 'SYS' and prods.EXISTENCIA > 0 ORDER BY prods.descrip";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total = Convert.ToDouble(dr["mayoreo"].ToString());
                }
                dr.Close();
                conexion.Close();
                EnlaceOnline(sucursal);

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                EnlaceOffLine(sucursal);
                //MessageBox.Show("Error al traer el valor del inventario de "+sucursal);
            }

            return total;
        }
        #endregion


        #region BOTONES
        private void BT_buscar_Click(object sender, EventArgs e)
        {
            totalMayoreo = 0;
            totalCosto = 0;

            DG_tabla.Rows[0].Cells[1].Value = InventarioAlMayoreo("BODEGA")+(InventarioAlMayoreo("BODEGA")*0.16);
            DG_tabla.Rows[0].Cells[2].Value = InventarioAlCosto("BODEGA")+ (InventarioAlCosto("BODEGA")*0.16);

            DG_tabla.Rows[1].Cells[1].Value = InventarioAlMayoreo("VALLARTA") + (InventarioAlMayoreo("VALLARTA") * 0.16);
            DG_tabla.Rows[1].Cells[2].Value = InventarioAlCosto("VALLARTA") + (InventarioAlCosto("VALLARTA") * 0.16);

            DG_tabla.Rows[2].Cells[1].Value = InventarioAlMayoreo("RENA") + (InventarioAlMayoreo("RENA") * 0.16);
            DG_tabla.Rows[2].Cells[2].Value = InventarioAlCosto("RENA") + (InventarioAlCosto("RENA") * 0.16);

            DG_tabla.Rows[3].Cells[1].Value = InventarioAlMayoreo("VELAZQUEZ") + (InventarioAlMayoreo("VELAZQUEZ") * 0.16);
            DG_tabla.Rows[3].Cells[2].Value = InventarioAlCosto("VELAZQUEZ") + (InventarioAlCosto("VELAZQUEZ") * 0.16);

            DG_tabla.Rows[4].Cells[1].Value = InventarioAlMayoreo("COLOSO") + (InventarioAlMayoreo("COLOSO") * 0.16);
            DG_tabla.Rows[4].Cells[2].Value = InventarioAlCosto("COLOSO") + (InventarioAlCosto("COLOSO") * 0.16);


            for (int i = 0; i < DG_tabla.Rows.Count - 1; i++)
            {
                totalMayoreo += Convert.ToDouble(DG_tabla.Rows[i].Cells[1].Value);
                totalCosto += Convert.ToDouble(DG_tabla.Rows[i].Cells[2].Value);
            }

            DG_tabla.Rows[5].Cells[1].Value = totalMayoreo;
            DG_tabla.Rows[5].Cells[2].Value = totalCosto;

            DG_tabla.Columns[1].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);




            int indiceColumna = 0;



            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

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


            excel.Cells.Range["B6:C11"].NumberFormat = "$#,##0.00";


            excel.Visible = true;
        }
        #endregion
    }
}
