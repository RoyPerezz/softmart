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
    public partial class FechaLlegada : Form
    {
        DataTable aux = new DataTable();
        DataTable master = new DataTable();
        DataTable DT_cedis = new DataTable();
        DataTable DT_vallarta = new DataTable();
        DataTable DT_rena = new DataTable();
        DataTable  DT_velazquez = new DataTable();
        DataTable DT_coloso = new DataTable();
        DataTable dt = new DataTable();

        public FechaLlegada()
        {
            InitializeComponent();
        }




        public void ArticulosDeLinea()
        {
            string query = "SELECT prods.ARTICULO,prods.DESCRIP,prods.FABRICANTE FROM prods inner join partcomp on prods.ARTICULO=partcomp.ARTICULO WHERE LINEA ='"+CB_lineas.SelectedItem.ToString()+"' AND partcomp.USUFECHA>'2019-12-31'";
            DataTable d = new DataTable();
            d.Columns.Add("ARTICULO",typeof(string));
            d.Columns.Add("DESCRIPCION", typeof(string));
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
               
                while (dr.Read())
                {
                    
                    DG_tabla.Rows.Add(dr["ARTICULO"].ToString(),dr["DESCRIP"].ToString(),"","","","","","","","","","","","","","","",dr["FABRICANTE"]);
                    //d.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectarse al servidor de cedis..." +ex);
            }
            
        }

        ArrayList maximosce = new ArrayList();
        ArrayList maximosva = new ArrayList();
        ArrayList maximosre = new ArrayList();
        ArrayList maximosve = new ArrayList();
        ArrayList maximosco = new ArrayList();

        public void MaxConsecCe(string linea)
        {

            try
            {
                string query = "select max(movsinv.CONSEC) as consec from movsinv inner join prods on movsinv.ARTICULO = prods.ARTICULO where prods.linea = '" + CB_lineas.SelectedItem.ToString() + "' AND movsinv.TIPO_MOVIM in ('COM','T+') GROUP BY movsinv.ARTICULO";

                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    maximosce.Add(dr["consec"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
        }

        public void MaxConsecVa(string linea)
        {

            try
            {
                string query = "select max(movsinv.CONSEC) as consec from movsinv inner join prods on movsinv.ARTICULO = prods.ARTICULO where prods.linea = '" + CB_lineas.SelectedItem.ToString() + "' AND movsinv.TIPO_MOVIM in ('COM','T+') GROUP BY movsinv.ARTICULO";

                MySqlConnection conexion = BDConexicon.VallartaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    maximosva.Add(dr["consec"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
        }

        public void MaxConsecRe(string linea)
        {

            try
            {
                string query = "select max(movsinv.CONSEC) as consec from movsinv inner join prods on movsinv.ARTICULO = prods.ARTICULO where prods.linea = '" + CB_lineas.SelectedItem.ToString() + "' AND movsinv.TIPO_MOVIM in ('COM','T+') GROUP BY movsinv.ARTICULO";

                MySqlConnection conexion = BDConexicon.RenaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    maximosre.Add(dr["consec"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
        }

        public void MaxConsecVe(string linea)
        {

            try
            {
                string query = "select max(movsinv.CONSEC) as consec from movsinv inner join prods on movsinv.ARTICULO = prods.ARTICULO where prods.linea = '" + CB_lineas.SelectedItem.ToString() + "' AND movsinv.TIPO_MOVIM in ('COM','T+') GROUP BY movsinv.ARTICULO";

                MySqlConnection conexion = BDConexicon.VelazquezOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    maximosve.Add(dr["consec"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
        }

        public void MaxConsecCo(string linea)
        {

            try
            {
                string query = "select max(movsinv.CONSEC) as consec from movsinv inner join prods on movsinv.ARTICULO = prods.ARTICULO where prods.linea = '" + CB_lineas.SelectedItem.ToString() + "' AND movsinv.TIPO_MOVIM in ('COM','T+') GROUP BY movsinv.ARTICULO";

                MySqlConnection conexion = BDConexicon.ColosoOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    maximosco.Add(dr["consec"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex);
            }
        }
        /*
          public void TablaVallarta()
        {


            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            MaxConsecVa(CB_lineas.SelectedItem.ToString());

            string query = "SELECT prods.ARTICULO,prods.DESCRIP,prods.EXISTENCIA,partcomp.CANTIDAD,prods.fabricante,max(MOVSINV.F_MOVIM) as FECHA FROM prods INNER JOIN partcomp ON prods.ARTICULO = partcomp.ARTICULO INNER JOIN MOVSINV ON prods.ARTICULO=MOVSINV.ARTICULO where prods.LINEA ='" + CB_lineas.SelectedItem.ToString() + "' AND prods.EXISTENCIA > 0 and MOVSINV.TIPO_MOVIM='COM' GROUP BY prods.ARTICULO";
            DateTime fecha;
            try
            {
                MySqlConnection conexion = BDConexicon.VallartaOpen();
                MySqlDataReader dr = null;
                for (int i = 0; i < maximosva.Count; i++)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT prods.ARTICULO, prods.DESCRIP, prods.EXISTENCIA, MOVSINV.CANTIDAD, prods.fabricante, max(MOVSINV.F_MOVIM) as FECHA" +
                " FROM prods INNER JOIN partcomp ON prods.ARTICULO = partcomp.ARTICULO INNER JOIN MOVSINV ON prods.ARTICULO=MOVSINV.ARTICULO where MOVSINV.consec ='" + maximosva[i] + "' AND prods.EXISTENCIA > 0  and MOVSINV.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'  GROUP BY prods.ARTICULO  ORDER BY MOVSINV.F_MOVIM", conexion);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fecha = Convert.ToDateTime(dr["FECHA"].ToString());

                        DT_vallarta.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), Convert.ToInt32(dr["EXISTENCIA"].ToString()), Convert.ToInt32(dr["CANTIDAD"].ToString()), fecha.ToString("dd-MM-yyyy"), dr["FABRICANTE"].ToString());
                    }
                    dr.Close();
                }


                conexion.Close();
                LB_va.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                LB_va.ForeColor = Color.Red;

            }
        }

             */



        //DATOS DE CEDIS
        public void TablaCedis()
        {
            //MaxConsecCe(CB_lineas.SelectedItem.ToString());
            //"SELECT prods.ARTICULO, prods.DESCRIP, prods.EXISTENCIA, MOVSINV.CANTIDAD, prods.fabricante, max(MOVSINV.F_MOVIM) as FECHA" +
            //" FROM prods INNER JOIN partcomp ON prods.ARTICULO = partcomp.ARTICULO INNER JOIN MOVSINV ON prods.ARTICULO=MOVSINV.ARTICULO where MOVSINV.consec ='" + maximosce[i] + "' AND prods.EXISTENCIA > 0  and MOVSINV.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'  GROUP BY prods.ARTICULO  ORDER BY MOVSINV.F_MOVIM"
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            


            DateTime fecha;
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();

                MySqlDataReader dr = null;
                   MySqlCommand cmd = new MySqlCommand("SELECT prods.ARTICULO, prods.DESCRIP, prods.EXISTENCIA, MOVSINV.CANTIDAD, prods.fabricante, max(MOVSINV.F_MOVIM) as FECHA, MOVSINV.TIPO_MOVIM " +
                        "FROM prods  INNER JOIN MOVSINV ON prods.ARTICULO = MOVSINV.ARTICULO where  prods.EXISTENCIA > 0 and prods.LINEA='"+CB_lineas.SelectedItem.ToString()+"' and MOVSINV.F_MOVIM BETWEEN '"+inicio.ToString("yyyy-MM-dd")+ "' and '" + fin.ToString("yyyy-MM-dd") + "' AND MOVSINV.TIPO_MOVIM IN('COM', 'T+')  GROUP BY prods.ARTICULO  ORDER BY MOVSINV.F_MOVIM", conexion);

                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fecha = Convert.ToDateTime(dr["FECHA"].ToString());

                        DT_cedis.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), Convert.ToInt32(dr["EXISTENCIA"].ToString()), Convert.ToInt32(dr["CANTIDAD"].ToString()), fecha.ToString("dd-MM-yyyy"),dr["FABRICANTE"].ToString());
                    }
                    dr.Close();
                




                conexion.Close();
                LB_cedis.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                LB_cedis.ForeColor = Color.Red;
                MessageBox.Show("" + ex);

            }
        }

        //DATOS DE VALLARTA
        public void TablaVallarta()
        {


            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;




            DateTime fecha;
            try
            {
                MySqlConnection conexion = BDConexicon.VallartaOpen();

                MySqlDataReader dr = null;
                MySqlCommand cmd = new MySqlCommand("SELECT prods.ARTICULO, prods.DESCRIP, prods.EXISTENCIA, MOVSINV.CANTIDAD, prods.fabricante, max(MOVSINV.F_MOVIM) as FECHA, MOVSINV.TIPO_MOVIM " +
                     "FROM prods  INNER JOIN MOVSINV ON prods.ARTICULO = MOVSINV.ARTICULO where  prods.EXISTENCIA > 0 and prods.LINEA='" + CB_lineas.SelectedItem.ToString() + "' and MOVSINV.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND MOVSINV.TIPO_MOVIM IN('COM', 'T+')  GROUP BY prods.ARTICULO  ORDER BY MOVSINV.F_MOVIM", conexion);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fecha = Convert.ToDateTime(dr["FECHA"].ToString());

                    DT_vallarta.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), Convert.ToInt32(dr["EXISTENCIA"].ToString()), Convert.ToInt32(dr["CANTIDAD"].ToString()), fecha.ToString("dd-MM-yyyy"), dr["FABRICANTE"].ToString());
                }
                dr.Close();





                conexion.Close();
                LB_va.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                LB_va.ForeColor = Color.Red;
                MessageBox.Show("" + ex);

            }
        }

        //DATOS DE RENA
        public void TablaRena()
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;




            DateTime fecha;
            try
            {
                MySqlConnection conexion = BDConexicon.RenaOpen();

                MySqlDataReader dr = null;
                MySqlCommand cmd = new MySqlCommand("SELECT prods.ARTICULO, prods.DESCRIP, prods.EXISTENCIA, MOVSINV.CANTIDAD, prods.fabricante, max(MOVSINV.F_MOVIM) as FECHA, MOVSINV.TIPO_MOVIM " +
                     "FROM prods  INNER JOIN MOVSINV ON prods.ARTICULO = MOVSINV.ARTICULO where  prods.EXISTENCIA > 0 and prods.LINEA='" + CB_lineas.SelectedItem.ToString() + "' and MOVSINV.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND MOVSINV.TIPO_MOVIM IN('COM', 'T+')  GROUP BY prods.ARTICULO  ORDER BY MOVSINV.F_MOVIM", conexion);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fecha = Convert.ToDateTime(dr["FECHA"].ToString());

                    DT_rena.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), Convert.ToInt32(dr["EXISTENCIA"].ToString()), Convert.ToInt32(dr["CANTIDAD"].ToString()), fecha.ToString("dd-MM-yyyy"), dr["FABRICANTE"].ToString());
                }
                dr.Close();





                conexion.Close();
                LB_re.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                LB_re.ForeColor = Color.Red;
                MessageBox.Show("" + ex);

            }
        }

      
        //DATOS DE VELAZQUEZ
        public void TablaVelazquez()
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;




            DateTime fecha;
            try
            {
                MySqlConnection conexion = BDConexicon.VelazquezOpen();

                MySqlDataReader dr = null;
                MySqlCommand cmd = new MySqlCommand("SELECT prods.ARTICULO, prods.DESCRIP, prods.EXISTENCIA, MOVSINV.CANTIDAD, prods.fabricante, max(MOVSINV.F_MOVIM) as FECHA, MOVSINV.TIPO_MOVIM " +
                     "FROM prods  INNER JOIN MOVSINV ON prods.ARTICULO = MOVSINV.ARTICULO where  prods.EXISTENCIA > 0 and prods.LINEA='" + CB_lineas.SelectedItem.ToString() + "' and MOVSINV.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND MOVSINV.TIPO_MOVIM IN('COM', 'T+')  GROUP BY prods.ARTICULO  ORDER BY MOVSINV.F_MOVIM", conexion);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fecha = Convert.ToDateTime(dr["FECHA"].ToString());

                    DT_velazquez.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), Convert.ToInt32(dr["EXISTENCIA"].ToString()), Convert.ToInt32(dr["CANTIDAD"].ToString()), fecha.ToString("dd-MM-yyyy"), dr["FABRICANTE"].ToString());
                }
                dr.Close();





                conexion.Close();
                LB_ve.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                LB_ve.ForeColor = Color.Red;
                MessageBox.Show("" + ex);

            }
        }

        //DATOS DE COLOSO
        public void TablaColoso()
        {

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;




            DateTime fecha;
            try
            {
                MySqlConnection conexion = BDConexicon.ColosoOpen();

                MySqlDataReader dr = null;
                MySqlCommand cmd = new MySqlCommand("SELECT prods.ARTICULO, prods.DESCRIP, prods.EXISTENCIA, MOVSINV.CANTIDAD, prods.fabricante, max(MOVSINV.F_MOVIM) as FECHA, MOVSINV.TIPO_MOVIM " +
                     "FROM prods  INNER JOIN MOVSINV ON prods.ARTICULO = MOVSINV.ARTICULO where  prods.EXISTENCIA > 0 and prods.LINEA='" + CB_lineas.SelectedItem.ToString() + "' and MOVSINV.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "' AND MOVSINV.TIPO_MOVIM IN('COM', 'T+')  GROUP BY prods.ARTICULO  ORDER BY MOVSINV.F_MOVIM", conexion);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    fecha = Convert.ToDateTime(dr["FECHA"].ToString());

                    DT_coloso.Rows.Add(dr["ARTICULO"].ToString(), dr["DESCRIP"].ToString(), Convert.ToInt32(dr["EXISTENCIA"].ToString()), Convert.ToInt32(dr["CANTIDAD"].ToString()), fecha.ToString("dd-MM-yyyy"), dr["FABRICANTE"].ToString());
                }
                dr.Close();





                conexion.Close();
                LB_co.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                LB_co.ForeColor = Color.Red;
                MessageBox.Show("" + ex);

            }
        }



        //AL CARGAR EL FORMULARIO SE CARGAN LAS LINEAS EN EL COMBOBOX DESDE LA BD DE CEDIS
        private void FechaLlegada_Load(object sender, EventArgs e)
        {
            
            string query = "SELECT Linea FROM LINEAS";
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_lineas.Items.Add(dr["Linea"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al traer las lineas "+ex);
               
            }


            
            try
            {
                MySqlConnection conextion = BDConexicon.conectar();
                string consulta = "select descripcion from rd_sucursales";
                MySqlCommand cmd = new MySqlCommand(consulta, conextion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_sucursal.Items.Add(dr["descripcion"].ToString());
                }
                dr.Close();
                conextion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer las sucursales " + ex);
            }
            DT_cedis.Columns.Add("ARTICULO", typeof(string));
            DT_cedis.Columns.Add("DESCRIP", typeof(string));
            DT_cedis.Columns.Add("EXISTENCIA", typeof(int));
            DT_cedis.Columns.Add("CANTIDAD", typeof(int));
            DT_cedis.Columns.Add("FECHA", typeof(string));
            DT_cedis.Columns.Add("FABRICANTE", typeof(string));

            DT_vallarta.Columns.Add("ARTICULO",typeof(string));
            DT_vallarta.Columns.Add("DESCRIP", typeof(string));
            DT_vallarta.Columns.Add("EXISTENCIA", typeof(int));
            DT_vallarta.Columns.Add("CANTIDAD", typeof(int));
            DT_vallarta.Columns.Add("FECHA", typeof(string));
            DT_vallarta.Columns.Add("FABRICANTE", typeof(string));


            DT_rena.Columns.Add("ARTICULO", typeof(string));
            DT_rena.Columns.Add("DESCRIP", typeof(string));
            DT_rena.Columns.Add("EXISTENCIA", typeof(int));
            DT_rena.Columns.Add("CANTIDAD", typeof(int));
            DT_rena.Columns.Add("FECHA", typeof(string));
            DT_rena.Columns.Add("FABRICANTE", typeof(string));


            DT_velazquez.Columns.Add("ARTICULO", typeof(string));
            DT_velazquez.Columns.Add("DESCRIP", typeof(string));
            DT_velazquez.Columns.Add("EXISTENCIA", typeof(int));
            DT_velazquez.Columns.Add("CANTIDAD", typeof(int));
            DT_velazquez.Columns.Add("FECHA", typeof(string));
            DT_velazquez.Columns.Add("FABRICANTE", typeof(string));


            DT_coloso.Columns.Add("ARTICULO", typeof(string));
            DT_coloso.Columns.Add("DESCRIP", typeof(string));
            DT_coloso.Columns.Add("EXISTENCIA", typeof(int));
            DT_coloso.Columns.Add("CANTIDAD", typeof(int));
            DT_coloso.Columns.Add("FECHA", typeof(string));
            DT_coloso.Columns.Add("FABRICANTE", typeof(string));


            //master.Columns.Add("ARTICULO",typeof(string));
            //master.Columns.Add("DESCRIPCION", typeof(string));
            //master.Columns.Add("EXISTENCIA VA", typeof(int));
            //master.Columns.Add("FECHA COMPRA VA", typeof(string));
            //master.Columns.Add("CANTIDAD COMPRA VA", typeof(string));
            //master.Columns.Add("EXISTENCIA RE", typeof(int));
            //master.Columns.Add("FECHA COMPRA RE", typeof(string));
            //master.Columns.Add("CANTIDAD COMPRA RE", typeof(string));
            //master.Columns.Add("EXISTENCIA VE", typeof(int));
            //master.Columns.Add("FECHA COMPRA VE", typeof(string));
            //master.Columns.Add("CANTIDAD COMPRA VE", typeof(string));
            //master.Columns.Add("EXISTENCIA CO", typeof(int));
            //master.Columns.Add("FECHA COMPRA CO", typeof(string));
            //master.Columns.Add("CANTIDAD COMPRA CO", typeof(string));
            //master.Columns.Add("PROVEEDOR", typeof(string));

            DG_tabla.Columns["DESCRIPCION"].Width = 200;
            DG_tabla.Columns["PROVEEDOR"].Width = 200;

            DG_tabla.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[11].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[12].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[13].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[14].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[15].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[16].SortMode = DataGridViewColumnSortMode.NotSortable;
            DG_tabla.Columns[17].SortMode = DataGridViewColumnSortMode.NotSortable;

           
            dt.Columns.Add("ARTICULO",typeof(string));
            dt.Columns.Add("DESCRIPCION", typeof(string));
            dt.Columns.Add("EXISTENCIA", typeof(int));

        }


        public DataTable Repetidos(DataTable dtData, string sColumnName)
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


        public void EliminarFilasDG()
        {

            int num = DG_tabla.Rows.Count;

            string ce, va, re, ve, co;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {

              

                ce = DG_tabla.Rows[i].Cells[2].Value.ToString();
                va = DG_tabla.Rows[i].Cells[4].Value.ToString();
                re = DG_tabla.Rows[i].Cells[6].Value.ToString();
                ve = DG_tabla.Rows[i].Cells[8].Value.ToString();
                co = DG_tabla.Rows[i].Cells[10].Value.ToString();

                if (ce.Equals("") && va.Equals("") && re.Equals("") && ve.Equals("") && co.Equals(""))
                {

                    DG_tabla.Rows[i].Selected = true;
                    //DG_tabla.Rows.RemoveAt(DG_tabla.SelectedRows[i].Index);
                    DG_tabla.Rows.Remove(DG_tabla.Rows[i]);
                }
            }

           
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            LB_cedis.ForeColor = Color.Black;
            LB_va.ForeColor = Color.Black;
            LB_re.ForeColor = Color.Black;
            LB_ve.ForeColor = Color.Black;
            LB_co.ForeColor = Color.Black;

            aux.Rows.Clear();
            DG_tabla.Rows.Clear();

            LB_mensaje.Text = "";
            LB_mensaje.Text = "Buscando artículos...";
            //ArticulosDeLinea();
           

            //METODOS QUE LLENAN LOS DATATABLES PARA GUARDAR LA INFORMACION DE CADA TIENDA
            TablaCedis();
            TablaVallarta();
            TablaRena();
            TablaVelazquez();
            TablaColoso();

            //UNIR LA INFO DE LOS DATATABLES
            aux = DT_vallarta.AsEnumerable()
               .Union(DT_rena.AsEnumerable())
               .Union(DT_velazquez.AsEnumerable())
               .Union(DT_coloso.AsEnumerable()).Union(DT_cedis.AsEnumerable()).Distinct(DataRowComparer.Default).CopyToDataTable<DataRow>();

           master=  Repetidos(aux,"ARTICULO");

            foreach (DataRow row in master.Rows)
            {
                DG_tabla.Rows.Add(row["ARTICULO"].ToString(), row["DESCRIP"].ToString(), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", row["FABRICANTE"]);
            }


            //SE LLENA EL DATAGRID CON LA INFORMACION EN EL DATATABLE AUX
            string articuloDG = "";
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                articuloDG = DG_tabla.Rows[i].Cells[0].Value.ToString();

                foreach (DataRow item in DT_cedis.Rows)
                {
                    if (articuloDG.Equals(item["ARTICULO"].ToString()))
                    {
                        DG_tabla.Rows[i].Cells[2].Value = item["EXISTENCIA"];
                        DG_tabla.Rows[i].Cells[3].Value = item["FECHA"];
                        DG_tabla.Rows[i].Cells[4].Value = item["CANTIDAD"];
                    }
                }

                foreach (DataRow item in DT_vallarta.Rows)
                {
                    if (articuloDG.Equals(item["ARTICULO"].ToString()))
                    {
                        DG_tabla.Rows[i].Cells[5].Value = item["EXISTENCIA"];
                        DG_tabla.Rows[i].Cells[6].Value = item["FECHA"];
                        DG_tabla.Rows[i].Cells[7].Value = item["CANTIDAD"];
                    }
                }


                foreach (DataRow item in DT_rena.Rows)
                {
                    if (articuloDG.Equals(item["ARTICULO"].ToString()))
                    {
                        DG_tabla.Rows[i].Cells[8].Value = item["EXISTENCIA"];
                        DG_tabla.Rows[i].Cells[9].Value = item["FECHA"];
                        DG_tabla.Rows[i].Cells[10].Value = item["CANTIDAD"];
                    }
                }

                foreach (DataRow item in DT_velazquez.Rows)
                {
                    if (articuloDG.Equals(item["ARTICULO"].ToString()))
                    {
                        DG_tabla.Rows[i].Cells[11].Value = item["EXISTENCIA"];
                        DG_tabla.Rows[i].Cells[12].Value = item["FECHA"];
                        DG_tabla.Rows[i].Cells[13].Value = item["CANTIDAD"];
                    }
                }

                foreach (DataRow item in DT_coloso.Rows)
                {
                    if (articuloDG.Equals(item["ARTICULO"].ToString()))
                    {
                        DG_tabla.Rows[i].Cells[14].Value = item["EXISTENCIA"];
                        DG_tabla.Rows[i].Cells[15].Value = item["FECHA"];
                        DG_tabla.Rows[i].Cells[16].Value = item["CANTIDAD"];
                    }
                }


            }
            //EliminarFilasDG();
            LB_mensaje.Text = "Finalizado";

            
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            
            try
            {
                LB_mensaje.Text = "";
                LB_mensaje.Text = "Exportando a Excel...";
               

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);


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
            catch (Exception ex)
            {
                LB_mensaje.Text = "ERROR AL CREAR ARCHIVO DE EXCEL";
                MessageBox.Show("[Excepcion controlada] " + ex);
            }


           LB_mensaje.Text = "Excel Creado";
        }

        private void BT_eliminarFilas_Click(object sender, EventArgs e)
        {
            EliminarFilasDG();
        }


     
        private void BT_existencia_Click(object sender, EventArgs e)
        {

          
            MySqlCommand cmd = null;
            DataRow row1 = null;
            try
            {
                MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                MySqlDataReader dr = null;
               
                    cmd = new MySqlCommand("select ARTICULO,DESCRIP,EXISTENCIA from prods where LINEA ='"+CB_lineas.SelectedItem.ToString()+"'",con);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        row1 = dt.NewRow();
                        row1["ARTICULO"] = dr["ARTICULO"].ToString();
                        row1["DESCRIPCION"] = dr["DESCRIP"].ToString();
                        row1["EXISTENCIA"] = Convert.ToInt32(dr["EXISTENCIA"].ToString());

                        dt.Rows.Add(row1);
                    }

                    dr.Close();

                DataGridView DG_tabla = new DataGridView();
                DG_tabla.Columns.Add("ARTICULO","ARTICULO");
                DG_tabla.Columns.Add("DESCRIPCION", "DESCRIPCION");
                DG_tabla.Columns.Add("EXISTENCIA", "EXISTENCIA");

                int valor = 0;

                foreach (DataRow item in dt.Rows)
                {
                    DG_tabla.Rows.Add(item["ARTICULO"].ToString(),item["DESCRIPCION"].ToString(),item["EXISTENCIA"].ToString());
                    valor++;
                }


                PB_progreso.Maximum = valor+1;
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                excel.Rows.Clear();

                excel.Range["A1:A30000"].NumberFormat = "@";
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
                    PB_progreso.Value += 1;



                    foreach (DataGridViewColumn col in DG_tabla.Columns)
                    {
                        indiceColumna++;

                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;

                    }

                }


                excel.Visible = true;

                con.Close();
                valor = 0;
                PB_progreso.Value = 0;
                DG_tabla.Rows.Clear();
                dt.Rows.Clear();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al llenar el DT con los articulos de la linea"+ ex);
            }
        }
    }
}
