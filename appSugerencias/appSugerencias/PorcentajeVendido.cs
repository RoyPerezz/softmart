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
    public partial class PorcentajeVendido : Form
    {
        public PorcentajeVendido()
        {
            InitializeComponent();
        }
        //#############################################################################################################
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //#############################################################################################################


        ArrayList lista = new ArrayList();//lista de articulos
       

        //carga las lineas en el combobox
       public void Lineas()
       {
            MySqlConnection conexion = BDConexicon.ConexionSucursal("VALLARTA");
            string query = "SELECT Linea FROM LINEAS";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_linea.Items.Add(dr["Linea"].ToString());
            }
            dr.Close();
            conexion.Close();
       }


        //METODOS QUE SE EJECUTAN AL CARGAR EL FORMULARIO
        private void PorcentajeVendido_Load(object sender, EventArgs e)
        {
            Lineas();
        }


        //AL SELECCIONAR UNA LINEA SE LLENA LA LISTA CON LOS ARTICULOS DE ESA LINEA
        private void CB_linea_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista.Clear();
            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            string query = "SELECT ARTICULO FROM PRODS WHERE LINEA='"+CB_linea.SelectedItem.ToString()+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["ARTICULO"].ToString());
            }
            dr.Close();
            conexion.Close();
        }

        public void BuscarArticulos()
        {
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            int entradas = 0;
            double salidas = 0;
#pragma warning disable CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
            string ent_sal = "";
#pragma warning restore CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
            string tipo_mov = "";
#pragma warning restore CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            int cantidad = 0;
#pragma warning restore CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            double existencia = 0;
#pragma warning disable CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
            int existenciaReal = 0;
#pragma warning restore CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
            double porcentaje = 0;
            int cancelarEntrada = 0;
            int cancelarSalida = 0;
         
            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());



            MySqlDataReader dr = null;
            MySqlDataReader dr0 = null;
            for (int i = 0; i < lista.Count; i++)
            {

               
                    MySqlCommand exist = new MySqlCommand("SELECT ENT_SAL,TIPO_MOVIM,CANTIDAD,EXISTENCIA FROM MOVSINV WHERE ARTICULO='" + lista[i] + "' and F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd")+"' AND '"+ fin.ToString("yyyy-MM-dd") + "' LIMIT 1", conexion);
                    dr0 = exist.ExecuteReader();
               
                    while (dr0.Read())
                    {
                        existencia = Convert.ToInt32(dr0["EXISTENCIA"].ToString());
                        if (dr0["ENT_SAL"].ToString().Equals("E"))
                        {
                            cancelarEntrada = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        }
                    if (dr0["ENT_SAL"].ToString().Equals("S") && dr0["TIPO_MOVIM"].ToString().Equals("TK"))
                    {
                        cancelarSalida = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                    }
                }
                    dr0.Close();
              

                MySqlCommand cmd = new MySqlCommand("SELECT mov.ARTICULO,p.DESCRIP,p.PRECIO1,p.PRECIO2,mov.ENT_SAL, mov.TIPO_MOVIM,mov.CANTIDAD,mov.EXISTENCIA " +
               "FROM MOVSINV mov INNER JOIN PRODS p ON mov.ARTICULO=p.ARTICULO" +
               " WHERE p.ARTICULO='"+lista[i]+"' AND mov.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd") + "'", conexion);
                dr = cmd.ExecuteReader();

               
                    while (dr.Read())
                    {

                        if (dr["ENT_SAL"].ToString().Equals("E")&&dr["TIPO_MOVIM"].ToString() != "IF+")
                        {
                            entradas += Convert.ToInt32(dr["CANTIDAD"].ToString());
                            //existencia += Convert.ToInt32(dr["EXISTENCIA"].ToString());
                            //existencia += entradas;
                        }

                        if (dr["ENT_SAL"].ToString().Equals("S") && dr["TIPO_MOVIM"].ToString().Equals("TK"))
                        {
                            salidas += Convert.ToInt32(dr["CANTIDAD"].ToString());
                        }

                    }
                existencia = existencia + entradas;
                try
                    {
                            //existenciaReal = existencia - salidas;
                            existencia = existencia - cancelarEntrada;
                            salidas = salidas - cancelarSalida;
                            porcentaje = (salidas * 100) / existencia;
                    }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    {


                    }

                if (dr.HasRows)
                {
                    if (porcentaje <=10)
                    {
                        double precio2 = Convert.ToDouble(dr["PRECIO2"].ToString());
                        double precio1 = Convert.ToDouble(dr["PRECIO1"].ToString());

                        double mayoreo = precio2 + (precio2 * 0.16);
                        double menudeo = precio1 + (precio1 * 0.16);
                        DG_tabla.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), String.Format("{0:0.##}", mayoreo.ToString("C")), String.Format("{0:0.##}", menudeo.ToString("C")), existencia, salidas, porcentaje.ToString("N2") + "%");
                    }
                }
                else
                {

                }
                           
                     
                    dr.Close();
                    existenciaReal = 0;existencia = 0;salidas = 0;porcentaje = 0; entradas = 0; cancelarEntrada=0;cancelarSalida = 0;
              
              

            }
           
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            BuscarArticulos();
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            
            excel.Cells.Range["A:A"].NumberFormat = "@";
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
    }
}
