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

namespace appSugerencias
{
    public partial class Rep_compras_prov_depto : Form
    {
        public Rep_compras_prov_depto()
        {
            InitializeComponent();
        }

        private void Rep_ventas_prov_depto_Load(object sender, EventArgs e)
        {
            DG_tabla.Columns[1].Width = 400;
        }


        public string NombreProveedor(string proveedor)
        {
            string nombre = "";
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            string query = "SELECT NOMBRE FROM PROVEED WHERE PROVEEDOR='"+proveedor+"'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["NOMBRE"].ToString();

            }

            dr.Close();
            con.Close();
            return nombre;
        }


        ArrayList proveedores = new ArrayList();
        private void BT_buscar_Click(object sender, EventArgs e)
        {

            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            //agregarmos los nombres de los proveedores al datagrid
            string nombre = "";
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            string query = "SELECT DISTINCT PROVEEDOR FROM COMPRAS WHERE F_EMISION BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"' order by PROVEEDOR";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                proveedores.Add(dr["PROVEEDOR"].ToString());
                nombre = NombreProveedor(dr["PROVEEDOR"].ToString());
                DG_tabla.Rows.Add(dr["PROVEEDOR"].ToString(),nombre,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0);
            }
            dr.Close();
           

            DG_tabla.Columns[1].Frozen=true;

            //string query2 = "SELECT compras.proveedor,prods.linea,partcomp.compra,compras.TIPO_DOC,(compras.importe) + (compras.impuesto) as total " +
            //    "FROM prods inner join partcomp on prods.articulo = partcomp.articulo inner join compras on partcomp.compra = compras.compra " +
            //    "where  compras.F_EMISION between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+ "' group by compra ";
            //MySqlCommand cmd2 = new MySqlCommand(query2, con);
             MySqlCommand cmd2 = null;
             MySqlDataReader dr2 = null;
            MySqlCommand cmd3 = null;
            MySqlDataReader dr3 = null;



            string idProv = "",linea="";

            double totalxLinea = 0;

            string dtProveedor = "";
            double totalFiesta = 0,totalCosmeticos=0,totalNav=0,totalBolsa=0,totalPly=0,totalBisute=0,totalBplastc=0,totalLLymo=0,totalVitrinaNVO=0,totalJuguetes=0,totalMayo=0,totalMascotas=0;
            double totalMontab=0,totalMostra=0,totalPlastic=0,totalSer=0,totalSombrillas=0,totalEscolar=0,totalCovid=0,totalFeb=0;

            double DesctotalFiesta = 0, DesctotalCosmeticos = 0, DesctotalNav = 0, DesctotalBolsa = 0, DesctotalPly = 0, DesctotalBisute = 0, DesctotalBplastc = 0, DesctotalLLymo = 0, DesctotalVitrinaNVO = 0, DesctotalJuguetes = 0;
            double DesctotalMontab = 0, DesctotalMostra = 0, DesctotalPlastic = 0, DesctotalSer = 0, DesctotalSombrillas = 0, DesctotalEscolar = 0, DesctotalCovid = 0, DesctotalFeb = 0, desctotalMayo = 0, desctotalMascotas = 0;

            ArrayList compras = new ArrayList();
            string tipo = "";
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                compras.Clear();
               


                dtProveedor = Convert.ToString(DG_tabla.Rows[i].Cells[0].Value);

                //obtenemos las compras del proveedor
                cmd2 = new MySqlCommand("SELECT compra FROM compras WHERE proveedor='"+dtProveedor+"' and USUFECHA BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"'",con);
                dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    compras.Add(dr2["compra"].ToString());
                }
                dr2.Close();
                totalFiesta = 0; totalCosmeticos = 0; totalNav = 0; totalBolsa = 0; totalPly = 0; totalBisute = 0; totalBplastc = 0; totalLLymo = 0; totalVitrinaNVO = 0; totalJuguetes = 0;
                totalMontab = 0; totalMostra = 0; totalPlastic = 0; totalSer = 0; totalSombrillas = 0; totalEscolar = 0; totalCovid = 0; totalFeb = 0;

                DesctotalFiesta = 0; DesctotalCosmeticos = 0; DesctotalNav = 0; DesctotalBolsa = 0; DesctotalPly = 0; DesctotalBisute = 0; DesctotalBplastc = 0; DesctotalLLymo = 0; DesctotalVitrinaNVO = 0; DesctotalJuguetes = 0;
                DesctotalMontab = 0; DesctotalMostra = 0; DesctotalPlastic = 0; DesctotalSer = 0; DesctotalSombrillas = 0; DesctotalEscolar = 0; DesctotalCovid = 0; DesctotalFeb = 0;
                for (int j = 0; j < compras.Count; j++)
                {


                   

                    cmd3 = new MySqlCommand("SELECT partcomp.ARTICULO,prods.linea,(partcomp.CANTIDAD) *(partcomp.PRECIO + (partcomp.PRECIO * (partcomp.IMPUESTO/100))) AS total,partcomp.TIPO_DOC " +
                   "FROM partcomp  INNER JOIN prods ON partcomp.ARTICULO = prods.ARTICULO and COMPRA ='"+compras[j]+"'", con);

                    dr3 = cmd3.ExecuteReader();

                    while (dr3.Read())
                    {
                       
                        linea = dr3["linea"].ToString();
                       

                        //EL DESCUENTO SE LE SUMA AL TOTAL PORQUE EL DESCUENTO VIENE EN NEGATIVO DESDE LA BD
                        if (linea.Equals("FIESTA"))
                        {
                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalFiesta += Convert.ToDouble(dr3["total"].ToString()); ;
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalFiesta += Convert.ToDouble(dr3["total"].ToString()); ;
                            }

                            DG_tabla.Rows[i].Cells[2].Value = totalFiesta + DesctotalFiesta;
                            DG_tabla.Rows[i].Cells[2].Style.ForeColor = Color.DarkGreen;



                        }

                        if (linea.Equals("COSMET"))
                        {
                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalCosmeticos += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalCosmeticos += Convert.ToDouble(dr3["total"].ToString());
                            }
                            DG_tabla.Rows[i].Cells[3].Value = totalCosmeticos + DesctotalCosmeticos;
                            DG_tabla.Rows[i].Cells[3].Style.ForeColor = Color.DarkGreen;
                        }

                        if (linea.Equals("NAV"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalNav += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalNav += Convert.ToDouble(dr3["total"].ToString());
                            }


                            DG_tabla.Rows[i].Cells[4].Value = totalNav + DesctotalNav;
                            DG_tabla.Rows[i].Cells[4].Style.ForeColor = Color.DarkGreen;
                        }

                        if (linea.Equals("BOLSA"))
                        {
                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalBolsa += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalBolsa += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[5].Value = totalBolsa + DesctotalBolsa;
                            DG_tabla.Rows[i].Cells[5].Style.ForeColor = Color.DarkGreen;
                        }
                        if (linea.Equals("PLY"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalPly += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalPly += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[6].Value = totalPly + DesctotalPly;
                            DG_tabla.Rows[i].Cells[6].Style.ForeColor = Color.DarkGreen;
                        }

                        if (linea.Equals("BISUTE"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalBisute += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalBisute += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[7].Value = totalBisute + DesctotalBisute;
                            DG_tabla.Rows[i].Cells[7].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("BPLASTC"))
                        {
                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalBplastc += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalBplastc += Convert.ToDouble(dr3["total"].ToString());
                            }




                            DG_tabla.Rows[i].Cells[8].Value = totalBplastc + DesctotalBplastc;
                            DG_tabla.Rows[i].Cells[8].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("LLYMO"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalLLymo += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalLLymo += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[9].Value = totalLLymo + DesctotalLLymo;
                            DG_tabla.Rows[i].Cells[9].Style.ForeColor = Color.DarkGreen;

                        }


                        if (linea.Equals("VITRINA"))
                        {
                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalVitrinaNVO += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalVitrinaNVO += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[10].Value = totalVitrinaNVO + DesctotalVitrinaNVO;
                            DG_tabla.Rows[i].Cells[10].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("JUGUET"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalJuguetes += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalJuguetes += Convert.ToDouble(dr3["total"].ToString());
                            }


                            DG_tabla.Rows[i].Cells[11].Value = totalJuguetes + DesctotalJuguetes;
                            DG_tabla.Rows[i].Cells[11].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("MONTAB"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalMontab += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalMontab += Convert.ToDouble(dr3["total"].ToString());
                            }


                            DG_tabla.Rows[i].Cells[12].Value = totalMontab + DesctotalMontab;
                            DG_tabla.Rows[i].Cells[12].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("MOSTRA"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalMostra += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalMostra += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[13].Value = totalMostra + DesctotalMostra;
                            DG_tabla.Rows[i].Cells[13].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("PLASTIC"))
                        {



                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalPlastic += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalPlastic += Convert.ToDouble(dr3["total"].ToString());
                            }


                            DG_tabla.Rows[i].Cells[14].Value = totalPlastic + DesctotalPlastic;
                            DG_tabla.Rows[i].Cells[14].Style.ForeColor = Color.DarkGreen;

                        }



                        if (linea.Equals("SER"))
                        {


                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalSer += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalSer += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[15].Value = totalSer + DesctotalSer;
                            DG_tabla.Rows[i].Cells[15].Style.ForeColor = Color.DarkGreen;

                        }


                        if (linea.Equals("SOMBRILLAS"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalSombrillas += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalSombrillas += Convert.ToDouble(dr3["total"].ToString());
                            }


                            DG_tabla.Rows[i].Cells[16].Value = totalSombrillas + DesctotalSombrillas;
                            DG_tabla.Rows[i].Cells[16].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("ESCOLA"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalEscolar += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalEscolar += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[17].Value = totalEscolar + DesctotalEscolar;
                            DG_tabla.Rows[i].Cells[17].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("COVID"))
                        {


                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalCovid += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalCovid += Convert.ToDouble(dr3["total"].ToString());
                            }


                            DG_tabla.Rows[i].Cells[18].Value = totalCovid + DesctotalCovid;
                            DG_tabla.Rows[i].Cells[18].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("FEB"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalFeb += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                DesctotalFeb += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells[19].Value = totalFeb + DesctotalFeb;
                            DG_tabla.Rows[i].Cells[19].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("MAY"))
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalMayo += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                desctotalMayo += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells["MAYO10"].Value = totalMayo + desctotalMayo;
                            DG_tabla.Rows[i].Cells["MAYO10"].Style.ForeColor = Color.DarkGreen;

                        }

                        if (linea.Equals("MASCOTAS")) //-------------------------------------------------------------------------------------------------------------------------------------
                        {

                            tipo = dr3["TIPO_DOC"].ToString();
                            if (tipo.Equals("COM"))
                            {
                                totalMascotas += Convert.ToDouble(dr3["total"].ToString());
                            }

                            if (tipo.Equals("DV"))
                            {
                                desctotalMascotas += Convert.ToDouble(dr3["total"].ToString());
                            }



                            DG_tabla.Rows[i].Cells["MASCOTAS"].Value = totalMascotas + desctotalMascotas;
                            DG_tabla.Rows[i].Cells["MASCOTAS"].Style.ForeColor = Color.DarkGreen;

                        }




                    }
                    dr3.Close();
                }
               
            }
            Calcular();

            DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[3].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[4].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[5].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[6].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[7].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[8].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[9].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[10].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[11].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[12].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[13].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[14].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[15].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[16].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[17].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[18].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[19].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[20].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[21].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns[22].DefaultCellStyle.Format = "C2";

            int filas = DG_tabla.RowCount;
            DG_tabla.Rows[filas - 1].DefaultCellStyle.BackColor = Color.SeaGreen;
            DG_tabla.Rows[filas-1].DefaultCellStyle.ForeColor = Color.White;

        }


        public void Calcular()
        {

            //CALCULA EL TOTAL QUE SE LE COMPRO A CADA PROVEEDOR
            double sumaFila = 0;
            double totalFiesta = 0, totalCosmeticos = 0, totalNav = 0, totalBolsa = 0, totalPly = 0, totalBisute = 0, totalBplastc = 0, totalLLymo = 0, totalVitrinaNVO = 0, totalJuguetes = 0;
            double totalMontab = 0, totalMostra = 0, totalPlastic = 0, totalSer = 0, totalSombrillas = 0, totalEscolar = 0, totalCovid = 0, totalFeb = 0,totalMayo=0,totalMascotas=0,Total=0;

            double cantidad = 0;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                for (int J = 2; J < DG_tabla.ColumnCount; J++)
                {
                    cantidad =Convert.ToDouble(DG_tabla.Rows[i].Cells[J].Value);
                    if (cantidad<0)
                    {
                        DG_tabla.Rows[i].Cells[J].Value = 0;
                    }
                }
            }


            for (int fila = 0; fila < DG_tabla.RowCount; fila++)
            {
                sumaFila = 0;


                totalFiesta += Convert.ToDouble(DG_tabla.Rows[fila].Cells[2].Value);
                totalCosmeticos += Convert.ToDouble(DG_tabla.Rows[fila].Cells[3].Value);
                totalNav += Convert.ToDouble(DG_tabla.Rows[fila].Cells[4].Value);
                totalBolsa += Convert.ToDouble(DG_tabla.Rows[fila].Cells[5].Value);
                totalPly += Convert.ToDouble(DG_tabla.Rows[fila].Cells[6].Value);
                totalBisute += Convert.ToDouble(DG_tabla.Rows[fila].Cells[7].Value);
                totalBplastc += Convert.ToDouble(DG_tabla.Rows[fila].Cells[8].Value);
                totalLLymo += Convert.ToDouble(DG_tabla.Rows[fila].Cells[9].Value);
                totalVitrinaNVO += Convert.ToDouble(DG_tabla.Rows[fila].Cells[10].Value);
                totalJuguetes += Convert.ToDouble(DG_tabla.Rows[fila].Cells[11].Value);
                totalMontab += Convert.ToDouble(DG_tabla.Rows[fila].Cells[12].Value);
                totalMostra += Convert.ToDouble(DG_tabla.Rows[fila].Cells[13].Value);
                totalPlastic += Convert.ToDouble(DG_tabla.Rows[fila].Cells[14].Value);
                totalSer += Convert.ToDouble(DG_tabla.Rows[fila].Cells[15].Value);
                totalSombrillas += Convert.ToDouble(DG_tabla.Rows[fila].Cells[16].Value);
                totalEscolar += Convert.ToDouble(DG_tabla.Rows[fila].Cells[17].Value);
                totalCovid += Convert.ToDouble(DG_tabla.Rows[fila].Cells[18].Value);
                totalFeb += Convert.ToDouble(DG_tabla.Rows[fila].Cells[19].Value);
                totalMayo += Convert.ToDouble(DG_tabla.Rows[fila].Cells["MAYO10"].Value);
                totalMascotas += Convert.ToDouble(DG_tabla.Rows[fila].Cells["MASCOTAS"].Value);



                for (int columna = 2; columna < DG_tabla.ColumnCount; columna++)
                {
                    sumaFila += Convert.ToDouble(DG_tabla.Rows[fila].Cells[columna].Value);

                }

                DG_tabla.Rows[fila].Cells["TOTAL"].Value = sumaFila;
                Total += Convert.ToDouble(DG_tabla.Rows[fila].Cells["TOTAL"].Value);


            }

            DG_tabla.Rows.Add("","TOTALES", totalFiesta, totalCosmeticos, totalNav, totalBolsa, totalPly, totalBisute, totalBplastc, totalLLymo, totalVitrinaNVO, totalJuguetes, totalMontab, totalMostra, totalPlastic, totalSer, totalSombrillas, totalEscolar, totalCovid, totalFeb,totalMayo, totalMascotas,Total);


        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


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



           
            excel.Cells.Range["A3"].Value = "TOTAL COMPRAS A PROVEEDORES DEL MES DE ";
            excel.Cells.Range["C6:U100"].NumberFormat = "$#,##0.00";
           

            excel.Visible = true;
        }
    }
}
