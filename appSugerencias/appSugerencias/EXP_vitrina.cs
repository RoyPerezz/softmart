﻿using MySql.Data.MySqlClient;
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
    public partial class EXP_vitrina : Form
    {
        public EXP_vitrina()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlConnection convallarta;
        MySqlConnection conrena;
        MySqlConnection concoloso;
        MySqlConnection convelazquez;
        MySqlConnection conpregot;
        DataTable master;



        public void Existencias()
        {

            try
            {


                //Los datos del datagrid DG_existencias los cargamos como null, para que a la hora de elegir proveedor se limpie el datagrid y muestre
                //los datos del nuevo proveedor seleccionado
                DG_existencias.DataSource = null;
                //LB_estadoBodega.Text = "";
                LB_estadoVallarta.Text = "";
                LB_Rena.Text = "";
                LB_Coloso.Text = "";
                LB_estadoVelazquez.Text = "";

                //Crear DataTables por cada sucursal para guardar la consulta
                //DataTable DTbodega = new DataTable();
                DataTable DTvallarta = new DataTable();
                DataTable DTrena = new DataTable();
                DataTable DTcoloso = new DataTable();
                DataTable DTvelazquez = new DataTable();
                DataTable DTpregot = new DataTable();
                //DataTable extra para unir los demás
                master = new DataTable();



                try
                {
                    convallarta = BDConexicon.V_vallarta();
                    MySqlCommand cmdVallarta = new MySqlCommand("SELECT articulo AS ARTICULO,descrip AS DESCRIPCION,existencia " +
                        "from prods where fabricante= '" + CB_proveedores.SelectedItem.ToString() + "'order by DESCRIPCION", convallarta);

                    MySqlDataAdapter adVallarta = new MySqlDataAdapter(cmdVallarta);
                    adVallarta.Fill(DTvallarta);
                }
                catch (Exception)
                {
                    LB_estadoVallarta.Text = "Sin Conexión";
                    LB_estadoVallarta.ForeColor = Color.Red;
                }
                try
                {
                    conrena = BDConexicon.V_rena();
                    MySqlCommand cmdRena = new MySqlCommand("SELECT articulo AS ARTICULO,descrip AS DESCRIPCION, existencia " +
                        "from prods where fabricante= '" + CB_proveedores.SelectedItem.ToString() + "'order by DESCRIPCION", conrena);
                    MySqlDataAdapter adRena = new MySqlDataAdapter(cmdRena);
                    adRena.Fill(DTrena);
                }
                catch (Exception)
                {
                    LB_Rena.Text = "Sin Conexión";
                    LB_Rena.ForeColor = Color.Red;
                }


                try
                {

                    convelazquez = BDConexicon.V_velazquez();
                    MySqlCommand cmdVelazquez = new MySqlCommand("SELECT articulo AS ARTICULO,descrip AS DESCRIPCION, existencia " +
                        "from prods where fabricante= '" + CB_proveedores.SelectedItem.ToString() + "'order by DESCRIPCION", convelazquez);
                    MySqlDataAdapter adVelazquez = new MySqlDataAdapter(cmdVelazquez);

                    adVelazquez.Fill(DTvelazquez);

                }
                catch (Exception)
                {

                   
                    LB_estadoVelazquez.Text = "Sin Conexión";
                    LB_estadoVelazquez.ForeColor = Color.Red;

                }

                try
                {


                    concoloso = BDConexicon.V_coloso();
                    MySqlCommand cmdColoso = new MySqlCommand("SELECT articulo AS ARTICULO,descrip AS DESCRIPCION, existencia " +
                        "from prods where fabricante= '" + CB_proveedores.SelectedItem.ToString() + "'order by DESCRIPCION", concoloso);
                    MySqlDataAdapter adColoso = new MySqlDataAdapter(cmdColoso);
                    adColoso.Fill(DTcoloso);

                }
                catch (Exception)
                {
                    LB_Coloso.Text = "Sin Conexión";
                    LB_Coloso.ForeColor = Color.Red;

                }


                try
                {
                    conpregot = BDConexicon.V_pregot();
                    MySqlCommand cmdPregot = new MySqlCommand("SELECT articulo AS ARTICULO,descrip AS DESCRIPCION, existencia " +
                        "from prods where fabricante= '" + CB_proveedores.SelectedItem.ToString() + "'order by DESCRIPCION", conpregot);
                    MySqlDataAdapter adPregot = new MySqlDataAdapter(cmdPregot);
                    adPregot.Fill(DTpregot);


                }
                catch (Exception)
                {

                    //LB_estadoBodega.Text = "Sin Conexión";
                    //LB_estadoBodega.ForeColor = Color.Red;
                }

                //Combinar los 5 DataTables en DataTable master

                DataTable master1 = DTvallarta.AsEnumerable()
                .Union(DTrena.AsEnumerable())
                .Union(DTvelazquez.AsEnumerable())
                .Union(DTcoloso.AsEnumerable()).Union(DTpregot.AsEnumerable()).Distinct(DataRowComparer.Default).CopyToDataTable<DataRow>();

                master = repetidos(master1, "articulo");//se llama al metodo repetidos para que elimine los regitros iguales

                //Agrego las columnas al DaTable donde se mostrarán las existencias de los productos en cada sucursal
                // master.DefaultView.ToTable(true, "articulo");


                //master.Columns.Add("BODEGA", typeof(String));
                master.Columns.Add("VALLARTA", typeof(String));
                master.Columns.Add("RENA", typeof(String));
                master.Columns.Add("VELAZQUEZ", typeof(String));
                master.Columns.Add("COLOSO", typeof(String));
                master.Columns.Add("PREGOT", typeof(String));

                master.Columns.Remove("existencia");




                // se recorren los datatables con los registros de cada suc.
                //RecorreBodega(DTbodega);
                RecorreVallarta(DTvallarta);
                RecorreRena(DTrena);
                RecorreVelazquez(DTvelazquez);
                RecorreColoso(DTcoloso);
                RecorrePregot(DTpregot);






                DG_existencias.DataSource = master;

                //DG_existencias.Columns["ARTICULO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                //DG_existencias.Columns["DESCRIPCION"].SortMode = DataGridViewColumnSortMode.NotSortable;
                //DG_existencias.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_existencias.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_existencias.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_existencias.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_existencias.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;

                DG_existencias.Columns["DESCRIPCION"].Width = 375;

                DG_existencias.Columns[2].HeaderCell.Style.BackColor = Color.Aqua;
                DG_existencias.Columns[3].HeaderCell.Style.BackColor = Color.DarkSeaGreen;
                DG_existencias.Columns[4].HeaderCell.Style.BackColor = Color.DeepSkyBlue;
                DG_existencias.Columns[5].HeaderCell.Style.BackColor = Color.DodgerBlue;

                //DG_existencias.Columns[6].HeaderCell.Style.BackColor = Color.LightBlue;





                //conbodega.Close();
                convallarta.Close();
                conrena.Close();
                concoloso.Close();

                convelazquez.Close();
                conpregot.Close();

            }
            catch (Exception ex)
            {
                String mensaje = "EL PROVEEDOR NO TIENE REGISTROS Y/O NO HAY CONEXION CON UNA O VARIAS TIENDAS ";

                MessageBox.Show(mensaje + "  " + ex);
            }

        }


       

        public void RecorreVallarta(DataTable DTVallarta)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {
                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTVallarta.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["VALLARTA"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }

        }

        public void RecorreRena(DataTable DTrena)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {
                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTrena.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["RENA"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }

        }

        public void RecorreColoso(DataTable DTcoloso)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {
                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTcoloso.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["COLOSO"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }

        }

        public void RecorreVelazquez(DataTable DTvelazquez)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {
                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTvelazquez.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["VELAZQUEZ"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }

        }

        public void RecorrePregot(DataTable DTpregot)
        {
            try
            {
                foreach (DataRow row in master.Rows)
                {


                    string valor = row["articulo"].ToString();

                    foreach (DataRow row1 in DTpregot.Rows)
                    {

                        if (valor.Equals(row1["articulo"].ToString()))

                        {

                            row["PREGOT"] = row1["existencia"].ToString();
                        }

                    }


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }

        }

        public void proveedores()
        {
            try
            {


                con = BDConexicon.V_vallarta();
                MySqlCommand cmd = new MySqlCommand("SELECT distinct fabricante from prods order by fabricante", con);

                //MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
                //DataTable prov = new DataTable();
                //ad.Fill(prov);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.CB_proveedores.Items.Add(dr["fabricante"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMA CON LA CONEXIÓN LOCAL: " + ex);
            }

            //NOTA: NO CIERRO LA VARIABLE conbodega, PORQUE SE USA Y SE CIERRA MAS ADELANTE EN EL PROGRAMA, AL FINAL DEL METODO Existencias

        }

        private void EXP_vitrina_Load(object sender, EventArgs e)
        {
            proveedores();
        }

        private void CB_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Existencias();
        }

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

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            excel.Range["A1:A4000"].NumberFormat = "@";
            int indiceColumna = 0;

            foreach (DataGridViewColumn col in DG_existencias.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_existencias.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_existencias.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }




            excel.Visible = true;
        }
    }
}
