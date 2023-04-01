using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.IO;
using System.Collections;

namespace appSugerencias
{
    public partial class PanelFacturas : Form
    {

       

        public PanelFacturas()
        {
            InitializeComponent();
           
        }

        #region VARIABLES
        Computer pc = new Computer();
        ArrayList facturas = new ArrayList();
        ArrayList xml = new ArrayList();
        #endregion


        #region BOTONES
        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            string query = "";
            try
            {
                string sucursal = CB_sucursal.SelectedItem.ToString();

                MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);


                if (RB_vigentes.Checked)
                {
                    query = "SELECT * FROM facturacion WHERE fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' and estatus='VIGENTE'";
                }

                if (RB_canceladas.Checked)
                {
                    query = "SELECT * FROM facturacion WHERE fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND estatus='CANCELADO'";
                }



                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                string rfc = "";
                DateTime fecha;
                double importe = 0, iva = 0, total = 0;


                while (dr.Read())
                {
                    rfc = dr["rfccliente"].ToString();
                    fecha = Convert.ToDateTime(dr["fecha"].ToString());
                    importe = Convert.ToDouble(dr["importe"].ToString());
                    iva = Convert.ToDouble(dr["iva"].ToString());
                    total = Convert.ToDouble(dr["total"].ToString());
                    if (rfc.Equals("XAXX010101000"))
                    {
                        DG_tabla.Rows.Add(dr["idfactura"].ToString(), "PUBLICO EN GENERAL", importe.ToString("C2"), iva.ToString("C2"), total.ToString("C2"), dr["estatus"].ToString(), dr["no_ticket"].ToString(), fecha.ToString("dd/MM/yyyy"), dr["archivopdf"].ToString(), dr["archivoxml"].ToString());
                    }
                    else
                    {
                        DG_tabla.Rows.Add(dr["idfactura"].ToString(), dr["razonsocial"].ToString(), importe.ToString("C2"), iva.ToString("C2"), total.ToString("C2"), dr["estatus"].ToString(), dr["no_ticket"].ToString(), fecha.ToString("dd/MM/yyyy"), dr["archivopdf"].ToString(), dr["archivoxml"].ToString());
                    }
                }


                for (int i = 0; i < DG_tabla.RowCount; i++)
                {
                    facturas.Add(DG_tabla.Rows[i].Cells[8].Value.ToString());
                    xml.Add(DG_tabla.Rows[i].Cells[9].Value.ToString());
                }

                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectarse con la sucursal: " + ex);
            }
        }


        private void BT_traer_Click(object sender, EventArgs e)
        {
            if (DG_tabla.Rows.Count == 0)
            {
                MessageBox.Show("Debes consultar las facturas antes de copiarlas a tu equipo");
            }
            else
            {
                try
                {





                    if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                    {

                        //SI LA CARPETA DESTINO NO EXITE, LA CREA
                        if (!(Directory.Exists(@"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\VALLARTA")))
                        {
                            Directory.CreateDirectory(@"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\VALLARTA");
                        }
                        string nombreFactura = "";


                        for (int i = 0; i < facturas.Count; i++)
                        {
                            nombreFactura = facturas[i].ToString();
                            if (File.Exists(@"\\FACTURACION\FACTURACION\CFDIS\" + nombreFactura))
                            {
                                File.Copy(@"\\FACTURACION\FACTURACION\CFDIS\" + facturas[i].ToString(), @"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\VALLARTA\" + facturas[i].ToString());
                                File.Copy(@"\\FACTURACION\FACTURACION\CFDIS\" + xml[i].ToString(), @"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\VALLARTA\" + xml[i].ToString());
                            }
                        }

                    }


                    if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                    {

                        //SI LA CARPETA DESTINO NO EXITE, LA CREA
                        if (!(Directory.Exists(@"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\RENA")))
                        {
                            Directory.CreateDirectory(@"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\RENA");
                        }
                        string nombreFactura = "";


                        for (int i = 0; i < facturas.Count; i++)
                        {
                            nombreFactura = facturas[i].ToString();
                            if (File.Exists(@"\\192.168.2.11\Facturacion3\CFDIS\" + nombreFactura))
                            {
                                File.Copy(@"\\192.168.2.11\Facturacion3\CFDIS\" + facturas[i].ToString(), @"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\RENA\" + facturas[i].ToString());
                                File.Copy(@"\\192.168.2.11\Facturacion3\CFDIS\" + xml[i].ToString(), @"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\RENA\" + xml[i].ToString());
                            }
                        }
                    }

                    if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                    {

                        //SI LA CARPETA DESTINO NO EXITE, LA CREA
                        if (!(Directory.Exists(@"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\COLOSO")))
                        {
                            Directory.CreateDirectory(@"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\COLOSO");
                        }
                        string nombreFactura = "";


                        for (int i = 0; i < facturas.Count; i++)
                        {
                            nombreFactura = facturas[i].ToString();
                            if (File.Exists(@"\\192.168.3.4\cfdis\" + nombreFactura))
                            {
                                File.Copy(@"\\192.168.3.4\cfdis\" + facturas[i].ToString(), @"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\COLOSO\" + facturas[i].ToString());
                                File.Copy(@"\\192.168.3.4\cfdis\" + xml[i].ToString(), @"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\COLOSO\" + xml[i].ToString());
                            }
                        }
                    }

                    if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                    {

                        //SI LA CARPETA DESTINO NO EXITE, LA CREA
                        if (!(Directory.Exists(@"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\VELAZQUEZ")))
                        {
                            Directory.CreateDirectory(@"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\VELAZQUEZ");

                        }
                        string nombreFactura = "";


                        for (int i = 0; i < facturas.Count; i++)
                        {
                            nombreFactura = facturas[i].ToString();
                            if (File.Exists(@"\\192.168.4.4\CFDIS\" + nombreFactura))
                            {
                                File.Copy(@"\\192.168.4.4\CFDIS\" + facturas[i].ToString(), @"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\VELAZQUEZ\" + facturas[i].ToString());
                                File.Copy(@"\\192.168.4.4\CFDIS\" + xml[i].ToString(), @"C:\Users\CONATBILIDAD1\Desktop\FACTURAS\VELAZQUEZ\" + xml[i].ToString());
                            }
                        }
                    }

                    MessageBox.Show("Los archivos se han copiado a su equipo con éxito");
                    facturas.Clear();
                    xml.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al copiar las facturas de la tienda " + CB_sucursal.SelectedItem.ToString() + " " + ex);

                }
            }




        }

        //EXPORTA A EXCEL

        private void button1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            //excel.Range["A1:A4000"].NumberFormat = "@";
            //excel.Range["C1:D2000"].NumberFormat = "$#,##0.00";
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


            excel.Visible = true;

        }
        #endregion


        #region METODOS DE LA CLASE
        private void PanelFacturas_Load(object sender, EventArgs e)
        {
            RB_vigentes.Checked = true;
            DG_tabla.Columns["IDFACTURA"].Width = 75;
            DG_tabla.Columns["RAZON_SOCIAL"].Width = 250;
            DG_tabla.Columns["TICKET"].Width = 75;
        }
        #endregion








    }
}
