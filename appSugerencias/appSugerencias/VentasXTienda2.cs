using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class VentasXTienda2 : Form
    {

        public VentasXTienda2()
        {
            InitializeComponent();
        }

        MySqlConnection Conex;

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        public void Consulta()
        {
#pragma warning disable CS0219 // La variable 'importeDiaTo' está asignada pero su valor nunca se usa
            double importeDiaVa, importeDiaRe, importeDiaVe, importeDiaCo, importeDiaPre, importeDiaTo;
#pragma warning restore CS0219 // La variable 'importeDiaTo' está asignada pero su valor nunca se usa
#pragma warning disable CS0168 // La variable 'Total' se ha declarado pero nunca se usa
            double totalVa, totalRe, totalCo, totalVe, totalPre, Total;
#pragma warning restore CS0168 // La variable 'Total' se ha declarado pero nunca se usa
            int renglonNuevo = 0; ;

            importeDiaTo = 0;
            DateTime fecha;


            try
            {
                Conex = BDConexicon.VallartaOpen();

                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmd = new MySqlCommand(comando, Conex);

                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();

                adaptador.Fill(dt);

                dgvVentas.Rows.Clear();
                totalVa = 0;

                foreach (DataRow item in dt.Rows)
                {
                    int n = dgvVentas.Rows.Add();

                    importeDiaVa = Convert.ToDouble(item["total"].ToString());
                    //LisVallarta.Add(importeDiaVa);
                    totalVa = totalVa + importeDiaVa;
                    fecha = Convert.ToDateTime(item["fecha"].ToString());

                    dgvVentas.Rows[n].Cells[0].Value = fecha.ToString("dd/MM/yyyy");
                    dgvVentas.Rows[n].Cells[1].Value = importeDiaVa.ToString("C");


                }
                Conex.Close();
                renglonNuevo = dgvVentas.Rows.Add();
                dgvVentas.Rows[renglonNuevo].Cells[0].Value = "TOTAL";
                dgvVentas.Rows[renglonNuevo].Cells[1].Value = totalVa.ToString("C");
                //LisVallarta.Add(totalVa);

            }
            catch (Exception er)
            {
                //for (int i = 0; i < dgvVentas.Rows.Count; i++)
                //{

                //    dgvVentas.Rows[i].Cells[1].Value = 0;
                //    LisVallarta.Add(0);
                //}
                //LisVallarta.Add(0);

                MessageBox.Show("Vallarta sin conexion Motivo: "+ er.Message);
            }

            try
            {
                Conex = BDConexicon.RenaOpen();
                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmdr = new MySqlCommand(comando, Conex);

                MySqlDataReader dr = cmdr.ExecuteReader();
                int y = 0;
                totalRe = 0;
                while (dr.Read())
                {
                    importeDiaRe = Convert.ToDouble(dr["total"].ToString());
                    fecha = Convert.ToDateTime(dr["fecha"].ToString());
                    //LisRena.Add(importeDiaRe);
                    totalRe = totalRe + importeDiaRe;
                    dgvVentas.Rows[y].Cells[2].Value = fecha.ToString("dd/MM/yyyy");
                    dgvVentas.Rows[y].Cells[3].Value = importeDiaRe.ToString("C");
                    y = y + 1;



                }

                dgvVentas.Rows[renglonNuevo].Cells[2].Value = "TOTAL";
                dgvVentas.Rows[renglonNuevo].Cells[3].Value = totalRe.ToString("C");
                //dgvVentas.Rows[y].Cells[2].Value = totalRe.ToString("C");
                //LisRena.Add(totalRe);
                dr.Close();


            }
            catch (Exception er)
            {
                //for (int i = 0; i < dgvVentas.Rows.Count; i++)
                //{

                //    dgvVentas.Rows[i].Cells[2].Value = 0;
                //    //LisRena.Add(0);
                //}
                //LisRena.Add(0);
                MessageBox.Show("Rena sin conexion Motivo: "+ er.Message);



            }


            try
            {
                Conex = BDConexicon.VelazquezOpen();
                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmdr = new MySqlCommand(comando, Conex);

                MySqlDataReader dr = cmdr.ExecuteReader();
                int y = 0;
                totalVe = 0;
                while (dr.Read())
                {
                    importeDiaVe = Convert.ToDouble(dr["total"].ToString());
                    fecha = Convert.ToDateTime(dr["fecha"].ToString());
                    //LisVelazquez.Add(importeDiaVe);
                    totalVe = totalVe + importeDiaVe;
                    dgvVentas.Rows[y].Cells[4].Value = fecha.ToString("dd/MM/yyyy");
                    dgvVentas.Rows[y].Cells[5].Value = importeDiaVe.ToString("C");
                    y = y + 1;



                }

                dgvVentas.Rows[renglonNuevo].Cells[4].Value = "TOTAL";
                dgvVentas.Rows[renglonNuevo].Cells[5].Value = totalVe.ToString("C");
                //conectar.Close();
                dr.Close();
                //dgvVentas.Rows[y].Cells[3].Value = totalVe.ToString("C");
                //LisVelazquez.Add(totalVe);
            }
            catch (Exception er)
            {
                //for (int i = 0; i < dgvVentas.Rows.Count; i++)
                //{

                //    dgvVentas.Rows[i].Cells[3].Value = 0;
                //    LisVelazquez.Add(0);
                //}
                //LisVelazquez.Add(0);

                MessageBox.Show("Velazquez sin conexion Motivo: " + er.Message);
            }


            try
            {
                Conex = BDConexicon.ColosoOpen();
                string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
                    "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
                    "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
                    "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
                    "GROUP BY ventas.F_EMISION " +
                    "ORDER BY ventas.F_EMISION";

                MySqlCommand cmdr = new MySqlCommand(comando, Conex);

                MySqlDataReader dr = cmdr.ExecuteReader();
                int y = 0;
                totalCo = 0;
                while (dr.Read())
                {
                    importeDiaCo = Convert.ToDouble(dr["total"].ToString());
                    fecha = Convert.ToDateTime(dr["fecha"].ToString());
                    //LisColoso.Add(importeDiaCo);
                    totalCo = totalCo + importeDiaCo;
                    dgvVentas.Rows[y].Cells[6].Value = fecha.ToString("dd/MM/yyyy");
                    dgvVentas.Rows[y].Cells[7].Value = importeDiaCo.ToString("C");
                    y = y + 1;



                }
                dgvVentas.Rows[renglonNuevo].Cells[6].Value = "TOTAL";
                dgvVentas.Rows[renglonNuevo].Cells[7].Value = totalCo.ToString("C");
                //conectar.Close();
                dr.Close();
                //dgvVentas.Rows[y].Cells[4].Value = totalCo.ToString("C");
                //LisColoso.Add(totalCo);
            }
            catch (Exception er)
            {
                //for (int i = 0; i < dgvVentas.Rows.Count; i++)
                //{

                //    dgvVentas.Rows[i].Cells[4].Value = 0;
                //    LisColoso.Add(0);
                //}
                //LisColoso.Add(0);

                MessageBox.Show("Coloso sin conexion Motivo : " +er.Message);
            }

            //try
            //{
            //    Conex = BDConexicon.Papeleria1Open();
            //    string comando = "SELECT ventas.F_EMISION AS 'Fecha', " +
            //        "SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam)) + SUM((partvta.precio * (partvta.cantidad - partvta.a01) * (1 - (partvta.descuento / 100)) * ventas.tipo_cam) * (partvta.impuesto / 100)) As 'Total' " +
            //        "FROM(partvta LEFT JOIN ventas ON ventas.VENTA = partvta.VENTA) INNER JOIN prods ON partvta.ARTICULO = prods.ARTICULO " +
            //        "WHERE ventas.ESTADO = 'CO' AND(ventas.TIPO_DOC = 'FAC' OR ventas.TIPO_DOC = 'DV' OR ventas.TIPO_DOC = 'REM') AND ventas.CIERRE = 0 " +
            //        "GROUP BY ventas.F_EMISION " +
            //        "ORDER BY ventas.F_EMISION";

            //    MySqlCommand cmdr = new MySqlCommand(comando, Conex);

            //    MySqlDataReader dr = cmdr.ExecuteReader();
            //    int y = 0;
            //    totalPre = 0;
            //    while (dr.Read())
            //    {
            //        importeDiaPre = Convert.ToDouble(dr["total"].ToString());
            //        fecha = Convert.ToDateTime(dr["fecha"].ToString());
            //        //LisPregot.Add(importeDiaPre);
            //        totalPre = totalPre + importeDiaPre;
            //        dgvVentas.Rows[y].Cells[8].Value = fecha.ToString("dd/MM/yyyy");
            //        dgvVentas.Rows[y].Cells[9].Value = importeDiaPre.ToString("C");
            //        y = y + 1;



            //    }
            //    dgvVentas.Rows[renglonNuevo].Cells[8].Value = "TOTAL";
            //    dgvVentas.Rows[renglonNuevo].Cells[9].Value = totalPre.ToString("C");
            //    //conectar.Close();
            //    dr.Close();
            //    //dgvVentas.Rows[y].Cells[5].Value = totalPre.ToString("C");
            //    //LisPregot.Add(totalPre);
            //}
            //catch (Exception er)
            //{
            //    //for (int i = 0; i < dgvVentas.Rows.Count; i++)
            //    //{

            //    //    dgvVentas.Rows[i].Cells[5].Value = 0;
            //    //    LisPregot.Add(0);
            //    //}
            //    //LisPregot.Add(0);
            //    MessageBox.Show("Pregot sin conexion Motivo: " + er.Message);
            //}




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Consulta();
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A1000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in dgvVentas.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in dgvVentas.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;
        }

        private void dgvVentas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (this.dgvVentas.Columns[e.ColumnIndex].Name == "VALLARTA")
            //{
            //    if (Convert.ToDouble(e.Value) > 50000.00)
            //    {
            //        e.CellStyle.BackColor = Color.LimeGreen;
            //    }
            //    if (Convert.ToDouble(e.Value) <= 5000.00)
            //    {
            //        e.CellStyle.BackColor = Color.LightCoral;
            //    }
            //}
        }
    }
}
