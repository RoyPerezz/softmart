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
    public partial class Rep_comisionesPaq : Form
    {
        public Rep_comisionesPaq()
        {
            InitializeComponent();
        }

        ArrayList empleado = new ArrayList();
        ArrayList fechas = new ArrayList();
        public void Fechas()
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
           
            string aux = "";
            int cont = 0;
            try
            {
                for (DateTime dia = inicio; dia <= fin; dia = dia.AddDays(1))
                {
                    cont++;

                    if (cont <= 6)
                    {
                        aux = Convert.ToString(dia.ToShortDateString());
                        fechas.Add(aux);
                    }
                    else
                    {
                        MessageBox.Show("Solo debes elegir 6 días");
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

                MessageBox.Show("[Excepcion controlada] Revisa las fechas que seleccionaste, solo debes elegir 6 días " + ex);
            }
        }


        public string NombreEmpleado(int id)
        {
            string nombre = "";
            string query = "SELECT NOMBRE FROM rd_asesoras_venta WHERE idasesora ='"+id+"'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["NOMBRE"].ToString();
            }
            dr.Close();
            con.Close();

            return nombre;
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            empleado.Clear();
            fechas.Clear();
            Fechas();
            string nombre = "";
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


            string query1 = "SELECT DISTINCT idEmpleado FROM  rd_calificacion_emp_paqueteria WHERE fecha between '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            string query2 = "SELECT idEmpleado,totalPagar,fecha FROM rd_calificacion_emp_paqueteria WHERE fecha between '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"'";

            //OBTIENE LOS ID DE LOS EMPLEADOS Y LOS GUARDA EN UN ARRAY
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query1,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                empleado.Add(dr["idEmpleado"].ToString());
            }
            dr.Close();


            //EL ID Y EL NOMBRE DEL EMPLEADO SE AGREGAN AL DATAGRID
            for (int i = 0; i < empleado.Count; i++)
            {
                //EL METODO NombreEmpleado ACEPTA EL ID DEL EMPLEADO Y RETORNA EL NOMBRE DEL EMPLEADO
                nombre = NombreEmpleado(Convert.ToInt32(empleado[i].ToString()));
                DG_tabla.Rows.Add(empleado[i],nombre,0,0,0,0,0,0,0);
            }


            string nom = "";
            string DG_nombre = "";
#pragma warning disable CS0219 // La variable 'columna' está asignada pero su valor nunca se usa
            string columna = "";
#pragma warning restore CS0219 // La variable 'columna' está asignada pero su valor nunca se usa
            double total = 0;
            DateTime fecha = DateTime.Now;
            string f = "";
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            MySqlDataReader dr2 = null;

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                DG_nombre = Convert.ToString(DG_tabla.Rows[i].Cells[1].Value);
               
                dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {

                    nom = NombreEmpleado(Convert.ToInt32(dr2["idEmpleado"].ToString()));
                    fecha = Convert.ToDateTime(dr2["fecha"].ToString());
                    f = fecha.ToString("dd/MM/yyyy");
                    total = Convert.ToDouble(dr2["totalPagar"].ToString());

                    for (int col= 2; col < DG_tabla.Columns.Count; col++)
                    {
                        if (DG_nombre.Equals(nom)&&f.Equals(DG_tabla.Columns[col].HeaderText))
                        {
                            DG_tabla.Rows[i].Cells[col].Value = total;
                            break;
                        }
                    }
                }
                dr2.Close();
            }

            double suma = 0,totalComisiones=0;
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                for (int j = 2; j <=7; j++)
                {
                    suma += Convert.ToDouble(DG_tabla.Rows[i].Cells[j].Value);
                    totalComisiones += Convert.ToDouble(DG_tabla.Rows[i].Cells[j].Value);
                }


                if(suma > 900)
                {
                    suma = 900;
                }
                DG_tabla.Rows[i].Cells[8].Value = suma;
                suma = 0;
            }

            //if (totalComisiones > 800)
            //{
            //    totalComisiones = 800;
            //}
            LB_total.Text = Convert.ToString(totalComisiones);



            con.Close();
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

                    
                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.HeaderText].Value;
                 
                }



            }

            excel.Cells.Range["A3:F3"].Merge();
            excel.Cells.Range["A3"].Value = "COMISIONES DE LA SEMANA DEL " + inicio.ToString("dd/MM/yyyy") + " AL " + fin.ToString("dd/MM/yyyy") + "";
            excel.Cells.Range["B6:J30"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["H18"].Value="TOTAL";
            excel.Cells.Range["I18"].Value =LB_total.Text;


            excel.Visible = true;
        }
    }
}
