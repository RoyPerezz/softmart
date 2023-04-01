using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ComisionesBod : Form
    {
        public ComisionesBod()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComisionesBod_Load(object sender, EventArgs e)
        {
            DG_tabla.Columns["NOMBRE"].Width = 190;
            DG_tabla.Columns[2].Width = 80;
            DG_tabla.Columns[3].Width = 80;
            DG_tabla.Columns[4].Width = 80;
            DG_tabla.Columns[5].Width = 80;
            DG_tabla.Columns[6].Width = 80;
            DG_tabla.Columns[7].Width = 80;
            DG_tabla.Columns[8].Width = 80;
            DG_tabla.Columns[9].Width = 80;
            DG_tabla.Columns[10].Width = 80;
            DG_tabla.Columns[12].Width = 210;
            DG_tabla.Columns[13].Width = 80;

        }

        public string NombrEmp(int id)
        {
            string nombre = "";
            MySqlConnection con = BDConexicon.conectar();
            string query = "SELECT nombre FROM rd_alta_empbodega WHERE idemp='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["nombre"].ToString();
            }

            dr.Close();
            con.Close();
            return nombre;
        }

        public void TraerDatos()
        {

            TB_total.Text = "";
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            string nombre = "";
            int id = 0;
       
            double total = 0;
            double sumTotal = 0;
            double Tpagar = 0;
            double totalEtiquetador = 0;
          
            ArrayList fechas = new ArrayList();
            string aux = "";
            int cont = 0;
            try
            {
                for (DateTime dia = inicio; dia <= fin; dia = dia.AddDays(1))
                {
                    cont++;

                    if (cont<=7)
                    {
                        aux = Convert.ToString(dia.ToShortDateString());
                        fechas.Add(aux);
                    }
                    else
                    {
                        MessageBox.Show("Solo debes elegir 7 días");
                    }
                   
                }

                int indice = 2;
                for (int j = 0; j < fechas.Count; j++)
                {
                    DG_tabla.Columns[indice].HeaderText = Convert.ToString(fechas[j]);
                    DG_tabla.Columns[indice].Name = Convert.ToString(fechas[j]);
                    indice++;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("[Excepcion controlada] Revisa las fechas que seleccionaste, solo debes elegir 7 días "+ex);
            }

#pragma warning disable CS0219 // La variable 'idempleado' está asignada pero su valor nunca se usa
            int idempleado = 0;
#pragma warning restore CS0219 // La variable 'idempleado' está asignada pero su valor nunca se usa
            string nom = "";
            MySqlCommand cmd2 = new MySqlCommand("Select DISTINCT nombre from rd_calif_emp_bodega where Fecha between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'order by idempleado", BDConexicon.conectar());
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                //idempleado = Convert.ToInt32(dr2["nombre"].ToString());
                //nom = NombrEmp(idempleado);
                nom = dr2["nombre"].ToString();
                DG_tabla.Rows.Add("",nom,"0","0","0","0","0","0","0","0","0","0","","0","0","0");


            }

            dr2.Close();



            try
            {
                MySqlConnection con = BDConexicon.conectar();
                //string query = "SELECT idempleado,imagen,cajas,articulos,areas_limpias,merc_fuera_empaque,merc_ord_areas,senalizacion,ba_limpios,promedio,tpagar,apoyo_area,merc_estancada,llegada_merc,rep_merc,merc_exhibida,total,fecha " +
                //    "FROM rd_calif_emp_bodega WHERE fecha BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"'";
                string query = "SELECT idempleado,nombre,tpagar,total,totalEtiquetador,fecha " +
                "FROM rd_calif_emp_bodega WHERE fecha BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";


                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = null;
                string empleado = "";
#pragma warning disable CS0219 // La variable 'fechaCol' está asignada pero su valor nunca se usa
                string fechaCol = "";
#pragma warning restore CS0219 // La variable 'fechaCol' está asignada pero su valor nunca se usa
                DateTime fechaBD = DateTime.Now;
                string f = "";
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    empleado = Convert.ToString(DG_tabla.Rows[i].Cells[1].Value);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = Convert.ToInt32(dr["idempleado"].ToString());
                        //nombre = NombrEmp(id);
                        nombre = dr["nombre"].ToString();
                        fechaBD = Convert.ToDateTime(dr["fecha"].ToString());
                        f = fechaBD.ToString("dd/MM/yyyy");
                        Tpagar = Convert.ToDouble(dr["tpagar"].ToString());
                        total = Convert.ToDouble(dr["total"].ToString());
                        totalEtiquetador = Convert.ToDouble(dr["totalEtiquetador"].ToString());

                        for (int col = 2; col < DG_tabla.ColumnCount - 7; col++)
                        {

                            if (empleado.Equals(nombre) && f.Equals(DG_tabla.Columns[col].HeaderText))
                            {

                                sumTotal = Tpagar + total + totalEtiquetador;

                                if (sumTotal > 114.29)
                                {
                                    sumTotal = 114.29;
                                }
                                DG_tabla.Rows[i].Cells[col].Value = String.Format("{0:0.##}", sumTotal.ToString("C"));
                                break;

                            }
                        }

                    }
                    dr.Close();
                    //empleado = Convert.ToString(DG_tabla.Rows[i].Cells[1].Value);
                    //dr = cmd.ExecuteReader();

                    //for (int col = 2; col < DG_tabla.ColumnCount - 7; col++)
                    //{

                    //    while (dr.Read())
                    //    {
                    //        id = Convert.ToInt32(dr["idempleado"].ToString());
                    //        nombre = NombrEmp(id);
                    //        fechaBD = Convert.ToDateTime(dr["fecha"].ToString());
                    //        f = fechaBD.ToString("dd/MM/yyyy");
                    //        Tpagar = Convert.ToDouble(dr["tpagar"].ToString());
                    //        total = Convert.ToDouble(dr["total"].ToString());
                    //        totalEtiquetador = Convert.ToDouble(dr["totalEtiquetador"].ToString());

                    //        if (empleado.Equals(nombre) && f.Equals(DG_tabla.Columns[col].HeaderText))
                    //        {

                    //            sumTotal = Tpagar + total + totalEtiquetador;

                    //            if (sumTotal > 114.29)
                    //            {
                    //                sumTotal = 114.29;
                    //            }
                    //            DG_tabla.Rows[i].Cells[col].Value = String.Format("{0:0.##}", sumTotal.ToString("C"));


                    //        }

                    //    }
                    //    dr.Close();







                    //}

                }
                

                dr.Close();
                con.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("[Excepción controlada]:"+" No hay datos en la semana seleccionada");
            }
        }

        double total = 0;

        private void BT_consultar_Click(object sender, EventArgs e)
        {
            TraerDatos();
        }

        private void BT_calcular_Click(object sender, EventArgs e)
        {
            double fecha1 = 0, fecha2 = 0,fecha3=0,fecha4=0,fecha5=0,fecha6=0,fecha7=0,merc_sin_daño=0,merc_sin_resagar=0,apoyoEtiquetador=0,malEtiquetado=0,aseo=0;
            double totalComision = 0;
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {


                decimal digito = decimal.Parse(DG_tabla.Rows[i].Cells[2].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string texto = digito.ToString("G0");
               fecha1 = Convert.ToDouble(texto);

                decimal digito2 = decimal.Parse(DG_tabla.Rows[i].Cells[3].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string texto2 = digito2.ToString("G0");
                fecha2 = Convert.ToDouble(texto2);

                decimal digito3 = decimal.Parse(DG_tabla.Rows[i].Cells[4].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string texto3 = digito3.ToString("G0");
                fecha3 = Convert.ToDouble(texto3);

                decimal digito4 = decimal.Parse(DG_tabla.Rows[i].Cells[5].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string texto4 = digito4.ToString("G0");
                fecha4 = Convert.ToDouble(texto4);

                decimal digito5 = decimal.Parse(DG_tabla.Rows[i].Cells[6].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string texto5 = digito5.ToString("G0");
                fecha5 = Convert.ToDouble(texto5);

                decimal digito6 = decimal.Parse(DG_tabla.Rows[i].Cells[7].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string texto6 = digito6.ToString("G0");
                fecha6 = Convert.ToDouble(texto6);

                decimal digito7 = decimal.Parse(DG_tabla.Rows[i].Cells[8].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                string texto7 = digito7.ToString("G0");
                fecha7 = Convert.ToDouble(texto7);


                //fecha1 = Convert.ToDouble(DG_tabla.Rows[i].Cells[2].Value);
                //fecha2 = Convert.ToDouble(DG_tabla.Rows[i].Cells[3].Value);
                //fecha3 = Convert.ToDouble(DG_tabla.Rows[i].Cells[4].Value);
                //fecha4 = Convert.ToDouble(DG_tabla.Rows[i].Cells[5].Value);
                //fecha5 = Convert.ToDouble(DG_tabla.Rows[i].Cells[6].Value);
                //fecha6 = Convert.ToDouble(DG_tabla.Rows[i].Cells[7].Value);
                //fecha7 = Convert.ToDouble(DG_tabla.Rows[i].Cells[8].Value);
                merc_sin_daño = Convert.ToDouble(DG_tabla.Rows[i].Cells["MERC_SIN_DAÑO"].Value);
                merc_sin_resagar = Convert.ToDouble(DG_tabla.Rows[i].Cells["MERC_NO_RESAGADA"].Value);
                apoyoEtiquetador = Convert.ToDouble(DG_tabla.Rows[i].Cells["APOYO_ETI"].Value);
                malEtiquetado =Convert.ToDouble(DG_tabla.Rows[i].Cells["MAL_ETIQUETADO"].Value);
                aseo =Convert.ToDouble(DG_tabla.Rows[i].Cells["ASEO"].Value);



                totalComision = (fecha1 + fecha2 + fecha3 + fecha4 + fecha5 + fecha6 + fecha7 + merc_sin_daño + merc_sin_resagar + apoyoEtiquetador) - (malEtiquetado + aseo);

                //TOPE NORMAL
                if (totalComision > 900)
                {
                    totalComision = 900;
                }

                //if (totalComision>1200)
                //{
                //    totalComision = 1200;
                //}
                DG_tabla.Rows[i].Cells["TOTAL_PAGAR"].Value = totalComision;

                //total += Convert.ToDouble(DG_tabla.Rows[i].Cells["TOTAL_PAGAR"].Value);

                //TB_total.Text = String.Format("{0:0.##}", total.ToString("C"));
                fecha1 = 0; fecha2 = 0; fecha3 = 0; fecha4 = 0; fecha5 = 0; fecha6 = 0; fecha7 = 0; merc_sin_daño = 0; merc_sin_resagar = 0; apoyoEtiquetador = 0;malEtiquetado = 0;aseo = 0;total = 0;

            }

            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                total += Convert.ToDouble(DG_tabla.Rows[i].Cells["TOTAL_PAGAR"].Value);
                TB_total.Text = String.Format("{0:0.##}", total.ToString("C"));
            }
           
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

           

            
            excel.Cells.Range["B6:P25"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["O25"].Value="TOTAL";
            excel.Cells.Range["P25"].Value = total;
            excel.Visible = true;
        }
    }
}
