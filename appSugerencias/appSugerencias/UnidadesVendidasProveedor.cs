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
    public partial class UnidadesVendidasProveedor : Form
    {
        public UnidadesVendidasProveedor()
        {
            InitializeComponent();
        }

        DataTable va = new DataTable();
        DataTable re = new DataTable();
        DataTable ve = new DataTable();
        DataTable co = new DataTable();


        DataTable articulosva = new DataTable();
        DataTable articulosre = new DataTable();
        DataTable articulosve = new DataTable();
        DataTable articulosco = new DataTable();
        DataTable auxarticulos = new DataTable();
        DataTable articulos = new DataTable();

        DataTable aux = new DataTable();
        DataTable maestro = new DataTable();

        DateTime inicio = DateTime.Now;
        DateTime fin = DateTime.Now;

        public void LimpiarEscructuras()
        {
            va.Clear();
            re.Clear();
            ve.Clear();
            co.Clear();

            articulosva.Clear();
            articulosre.Clear();
            articulosco.Clear();
            articulosve.Clear();

            articulos.Clear();
            auxarticulos.Clear();

            aux.Clear();
            maestro.Clear();
            DG_tabla.Rows.Clear();
        }

        private void UnidadesVendidasProveedor_Load(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor();
            ArrayList proveedores = prov.Fabricante();

            for (int i = 0; i < proveedores.Count; i++)
            {
                CB_proveedor.Items.Add(proveedores[i].ToString());
            }

            va.Columns.Add("ARTICULO",typeof(string));
            va.Columns.Add("DESCRIPCION", typeof(string));
            va.Columns.Add("UNIDADES", typeof(int));

            re.Columns.Add("ARTICULO", typeof(string));
            re.Columns.Add("DESCRIPCION", typeof(string));
            re.Columns.Add("UNIDADES", typeof(int));

            co.Columns.Add("ARTICULO", typeof(string));
            co.Columns.Add("DESCRIPCION", typeof(string));
            co.Columns.Add("UNIDADES", typeof(int));

            ve.Columns.Add("ARTICULO", typeof(string));
            ve.Columns.Add("DESCRIPCION", typeof(string));
            ve.Columns.Add("UNIDADES", typeof(int));

            articulosva.Columns.Add("ARTICULO", typeof(string));
            articulosva.Columns.Add("DESCRIPCION", typeof(string));

            articulosre.Columns.Add("ARTICULO", typeof(string));
            articulosre.Columns.Add("DESCRIPCION", typeof(string));

            articulosco.Columns.Add("ARTICULO", typeof(string));
            articulosco.Columns.Add("DESCRIPCION", typeof(string));

            articulosve.Columns.Add("ARTICULO", typeof(string));
            articulosve.Columns.Add("DESCRIPCION", typeof(string));

            auxarticulos.Columns.Add("ARTICULO", typeof(string));
            auxarticulos.Columns.Add("DESCRIPCION", typeof(string));

            articulos.Columns.Add("ARTICULO", typeof(string));
            articulos.Columns.Add("DESCRIPCION", typeof(string));






        }

        //##################################  ESTOS METODOS OBTIENEN Y GAURDAN LOS ARTICULOS DEL FABRICANTE EN UN ARRAY  ############################################################
        public void ArticulosVA()
        {
            inicio = DT_inicio.Value;
            fin = DT_fin.Value;
            string fabricante = CB_proveedor.SelectedItem.ToString();

            string query = "select prods.articulo as 'articulo',prods.descrip as 'descrip',sum(movsinv.cantidad) as unidades from prods inner join movsinv on " +
            "prods.articulo = movsinv.articulo where F_MOVIM between '"+inicio.ToString("yyyy-MM-dd")+"' and '"+fin.ToString("yyyy-MM-dd")+"' AND prods.fabricante = '"+fabricante+"' " +
            "and movsinv.TIPO_MOVIM = 'TK' group by prods.articulo";

            try
            {
                MySqlConnection conexion = BDConexicon.VallartaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    articulosva.Rows.Add(dr["articulo"].ToString(), dr["descrip"].ToString());
                    va.Rows.Add(dr["articulo"].ToString(),dr["descrip"].ToString(),dr["unidades"].ToString());
                }
                dr.Close();
                conexion.Close();

                LB_estado_va.Text = "CONECTADO";
                LB_estado_va.ForeColor = Color.Green;
            }

            catch (Exception ex)

            {
                LB_estado_va.Text = "SIN CONEXION";
                LB_estado_va.ForeColor = Color.Red;
               
                
            }
        }

        public void ArticulosRE()
        {
            inicio = DT_inicio.Value;
            fin = DT_fin.Value;
            string fabricante = CB_proveedor.SelectedItem.ToString();

            string query = "select prods.articulo as 'articulo',prods.descrip as 'descrip',sum(movsinv.cantidad) as unidades from prods inner join movsinv on " +
            "prods.articulo = movsinv.articulo where F_MOVIM between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND prods.fabricante = '" + fabricante + "' " +
            "and movsinv.TIPO_MOVIM = 'TK' group by prods.articulo";

            try
            {
                MySqlConnection conexion = BDConexicon.RenaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    articulosre.Rows.Add(dr["articulo"].ToString(), dr["descrip"].ToString());
                    re.Rows.Add(dr["articulo"].ToString(), dr["descrip"].ToString(), dr["unidades"].ToString());
                }
                dr.Close();
                conexion.Close();
                LB_estado_re.Text = "CONECTADO";
                LB_estado_re.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                LB_estado_re.Text = "SIN CONEXION";
                LB_estado_re.ForeColor = Color.Red;


            }
        }

        public void ArticulosCO()
        {
            inicio = DT_inicio.Value;
            fin = DT_fin.Value;
            string fabricante = CB_proveedor.SelectedItem.ToString();

            string query = "select prods.articulo as 'articulo',prods.descrip as 'descrip',sum(movsinv.cantidad) as unidades from prods inner join movsinv on " +
            "prods.articulo = movsinv.articulo where F_MOVIM between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND prods.fabricante = '" + fabricante + "' " +
            "and movsinv.TIPO_MOVIM = 'TK' group by prods.articulo";

            try
            {
                MySqlConnection conexion = BDConexicon.ColosoOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    articulosco.Rows.Add(dr["articulo"].ToString(), dr["descrip"].ToString());
                    co.Rows.Add(dr["articulo"].ToString(), dr["descrip"].ToString(), dr["unidades"].ToString());
                }
                dr.Close();
                conexion.Close();
                LB_estado_co.Text = "CONECTADO";
                LB_estado_co.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                LB_estado_co.Text = "SIN CONEXION";
                LB_estado_co.ForeColor = Color.Red;


            }
        }

        public void ArticulosVE()
        {
            inicio = DT_inicio.Value;
            fin = DT_fin.Value;
            string fabricante = CB_proveedor.SelectedItem.ToString();

            string query = "select prods.articulo as 'articulo',prods.descrip as 'descrip',sum(movsinv.cantidad) as unidades from prods inner join movsinv on " +
            "prods.articulo = movsinv.articulo where F_MOVIM between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND prods.fabricante = '" + fabricante + "' " +
            "and movsinv.TIPO_MOVIM = 'TK' group by prods.articulo";

            try
            {
                MySqlConnection conexion = BDConexicon.VelazquezOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    articulosve.Rows.Add(dr["articulo"].ToString(), dr["descrip"].ToString());
                    ve.Rows.Add(dr["articulo"].ToString(), dr["descrip"].ToString(), dr["unidades"].ToString());
                }
                dr.Close();
                conexion.Close();
                LB_estado_ve.Text = "CONECTADO";
                LB_estado_ve.ForeColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                LB_estado_ve.Text = "SIN CONEXION";
                LB_estado_ve.ForeColor = Color.Red;


            }
        }

        //###########################################################################################################################################################################

        public DataTable repetidos(DataTable dtData, string sColumnName)
        {
            try
            {
                DataTable distintos = dtData.DefaultView.ToTable(true, sColumnName);
                DataTable dtNew = new DataTable();
                foreach (DataColumn dcName in dtData.Columns)
                {
                    dtNew.Columns.Add(new DataColumn(dcName.Caption, dcName.DataType));
                }

                foreach (DataRow drRow in distintos.Rows)
                {
                    dtNew.ImportRow(dtData.Select(sColumnName + " = '" + drRow[0] + "'")[0]);
                }
                return dtNew;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        private void BT_buscar_Click(object sender, EventArgs e)
        {
            LimpiarEscructuras();
            ArticulosVA();
            ArticulosRE();
            ArticulosCO();
            ArticulosVE();


            auxarticulos = articulosva.AsEnumerable()
               .Union(articulosre.AsEnumerable())
               .Union(articulosco.AsEnumerable())
               .Union(articulosve.AsEnumerable()).Distinct(DataRowComparer.Default).CopyToDataTable<DataRow>();


            articulos = repetidos(auxarticulos,"ARTICULO");

            //LLENA EL DATA GRID CON EL ARTICULO Y SU DESCRIPCION
            foreach  (DataRow row in articulos.Rows )
            {
                DG_tabla.Rows.Add(row["ARTICULO"],row["DESCRIPCION"],0,0,0,0);
            }


            //aux = va.AsEnumerable()
            //  .Union(re.AsEnumerable())
            //  .Union(co.AsEnumerable())
            //  .Union(ve.AsEnumerable()).Distinct(DataRowComparer.Default).CopyToDataTable<DataRow>();

            //maestro = repetidos(aux, "ARTICULO");

         
            string artva = "";
            string artDGva = "";
            foreach (DataRow row in va.Rows)
            {
                artva = row["ARTICULO"].ToString();
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    artDGva = DG_tabla.Rows[i].Cells[0].Value.ToString();
                    if (artDGva.Equals(artva))
                    {
                        DG_tabla.Rows[i].Cells[2].Value = row["UNIDADES"];
                        break;
                    }
                }
                
               
            }


 
            string artre = "";
            string artDGre = "";
            foreach (DataRow row in re.Rows)
            {
                artre = row["ARTICULO"].ToString();
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    artDGre = DG_tabla.Rows[i].Cells[0].Value.ToString();
                    if (artDGre.Equals(artre))
                    {
                        DG_tabla.Rows[i].Cells[3].Value = row["UNIDADES"];
                    }
                }
                
              
            }

            string artve = "";
            string artDGve = "";
            foreach (DataRow row in ve.Rows)
            {
                artve = row["ARTICULO"].ToString();

                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    artDGve = DG_tabla.Rows[i].Cells[0].Value.ToString();
                    if (artDGve.Equals(artve))
                    {
                        DG_tabla.Rows[i].Cells[4].Value = row["UNIDADES"];
                    }
                }
             
            }

           
            string artco = "";
            string artDGco = "";

            foreach (DataRow row in co.Rows)
            {
                artco = row["ARTICULO"].ToString();

                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    artDGco = DG_tabla.Rows[i].Cells[0].Value.ToString();
                    if (artDGco.Equals(artco))
                    {
                        DG_tabla.Rows[i].Cells[5].Value = row["UNIDADES"];
                    }
                }
                
             
            }

            

        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {

            inicio = DT_inicio.Value;
            fin = DT_fin.Value;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);

                excel.Range["A4:F4"].Merge();
            excel.Range["A4:F4"].Value = "UNIDADES VENDIDAS DEL "+inicio.ToString("dd-MM-yyy")+" AL "+fin.ToString("dd-MM-yyyy");
                excel.Range["A1:A4000"].NumberFormat = "@";
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
