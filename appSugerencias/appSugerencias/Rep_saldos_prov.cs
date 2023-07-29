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
    public partial class Rep_saldos_prov : Form
    {
        public Rep_saldos_prov()
        {
            InitializeComponent();
        }

        DataTable dtBO = new DataTable();
        DataTable dtVA = new DataTable();
        DataTable dtRE = new DataTable();
        DataTable dtCO = new DataTable();
        DataTable dtVE = new DataTable();
        DataTable dtPRE = new DataTable();
       DataTable maestro = new DataTable();

        List<Proveedor> prov = new List<Proveedor>();


        public void SaldosMayoresCero()
        {
            maestro.Clear();
            prov.Clear();
            Proveedores();

            MySqlConnection bo = BDConexicon.BodegaOpen();
            MySqlConnection va = BDConexicon.VallartaOpen();
            MySqlConnection re = BDConexicon.RenaOpen();
            MySqlConnection ve = BDConexicon.VelazquezOpen();
            MySqlConnection co = BDConexicon.ColosoOpen();
            //MySqlConnection pre = BDConexicon.Papeleria1Open();


            MySqlDataAdapter adBO = null;


            MySqlDataAdapter adVA = null;

            MySqlDataAdapter adRE = null;
#pragma warning restore CS0219 // La variable 'adRE' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'adVE' está asignada pero su valor nunca se usa
            MySqlDataAdapter adVE = null;
#pragma warning restore CS0219 // La variable 'adVE' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'adCO' está asignada pero su valor nunca se usa
            MySqlDataAdapter adCO = null;
#pragma warning restore CS0219 // La variable 'adCO' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'adPRE' está asignada pero su valor nunca se usa
            MySqlDataAdapter adPRE = null;
#pragma warning restore CS0219 // La variable 'adPRE' está asignada pero su valor nunca se usa


            MySqlDataReader drBO = null;
            MySqlDataReader drVA = null;
            MySqlDataReader drRE = null;
            MySqlDataReader drVE = null;
            MySqlDataReader drCO = null;
            MySqlDataReader drPRE = null;

            string mov = "";
            double abonoBO = 0;
            double compraBO = 0;
            double saldoBO = 0;

            double abonoVA = 0;
            double compraVA = 0;
            double saldoVA= 0;

            double abonoRE = 0;
            double compraRE = 0;
            double saldoRE = 0;

            double abonoVE = 0;
            double compraVE = 0;
            double saldoVE = 0;

            double abonoCO = 0;
            double compraCO = 0;
            double saldoCO = 0;

            //double abonoPRE = 0;
            //double compraPRE = 0;
            //double saldoPRE = 0;


            if (CBX_saldo.Checked == true)
            {


                for (int i = 0; i < prov.Count; i++)
                {
                    string query = "SELECT Cargo_ab,importe FROM cuenxpdet WHERE proveedor='" + prov[i].proveedor + "'";


                    //#####################################   SALDOS BODEGA  ####################################################
                    MySqlCommand cmdBO = new MySqlCommand(query, bo);
                    drBO = cmdBO.ExecuteReader();
                    while (drBO.Read())
                    {
                        mov = drBO["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraBO += Convert.ToDouble(drBO["importe"].ToString());
                        }
                        else
                        {
                            abonoBO += Convert.ToDouble(drBO["importe"].ToString());
                        }
                    }
                    drBO.Close();
                    saldoBO = compraBO - abonoBO;
                    string proveedor = "";

                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);
                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["BODEGA"].Value =Convert.ToString(saldoBO);
                            maestro.Rows[i]["BODEGA"] = Convert.ToDouble(saldoBO);
                        }
                    }

                    saldoBO = 0; compraBO = 0; abonoBO = 0;



                    //#####################################   SALDOS VALLARTA  ####################################################
                    MySqlCommand cmdVA = new MySqlCommand(query, va);
                    drVA = cmdVA.ExecuteReader();
                    while (drVA.Read())
                    {
                        mov = drVA["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraVA += Convert.ToDouble(drVA["importe"].ToString());
                        }
                        else
                        {
                            abonoVA += Convert.ToDouble(drVA["importe"].ToString());
                        }
                    }
                    drVA.Close();
                    saldoVA = compraVA - abonoVA;


                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);
                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["VALLARTA"].Value = Convert.ToString(saldoVA);
                            maestro.Rows[i]["VALLARTA"] = Convert.ToDouble(saldoVA);
                        }
                    }

                    saldoVA = 0; compraVA = 0; abonoVA = 0;


                    //#####################################   SALDOS RENA  ####################################################
                    MySqlCommand cmdRE = new MySqlCommand(query, re);
                    drRE = cmdRE.ExecuteReader();
                    while (drRE.Read())
                    {
                        mov = drRE["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraRE += Convert.ToDouble(drRE["importe"].ToString());
                        }
                        else
                        {
                            abonoRE += Convert.ToDouble(drRE["importe"].ToString());
                        }
                    }
                    drRE.Close();
                    saldoRE = compraRE - abonoRE;


                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);
                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["RENA"].Value = Convert.ToString(saldoRE);
                            maestro.Rows[i]["RENA"] = Convert.ToDouble(saldoRE);
                        }
                    }

                    saldoRE = 0; compraRE = 0; abonoRE = 0;

                    //#####################################   SALDOS VELAZQUEZ  ####################################################
                    MySqlCommand cmdVE = new MySqlCommand(query, ve);
                    drVE = cmdVE.ExecuteReader();
                    while (drVE.Read())
                    {
                        mov = drVE["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraVE += Convert.ToDouble(drVE["importe"].ToString());
                        }
                        else
                        {
                            abonoVE += Convert.ToDouble(drVE["importe"].ToString());
                        }
                    }
                    drVE.Close();
                    saldoVE = compraVE - abonoVE;


                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);

                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["VELAZQUEZ"].Value = Convert.ToString(saldoVE);
                            maestro.Rows[i]["VELAZQUEZ"] = Convert.ToDouble(saldoVE);
                        }
                    }

                    saldoVE = 0; compraVE = 0; abonoVE = 0;



                    //#####################################   SALDOS COLOSO  ####################################################
                    MySqlCommand cmdCO = new MySqlCommand(query, co);
                    drCO = cmdCO.ExecuteReader();
                    while (drCO.Read())
                    {
                        mov = drCO["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraCO += Convert.ToDouble(drCO["importe"].ToString());
                        }
                        else
                        {
                            abonoCO += Convert.ToDouble(drCO["importe"].ToString());
                        }
                    }
                    drCO.Close();
                    saldoCO = compraCO - abonoCO;


                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);
                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["COLOSO"].Value = Convert.ToString(saldoCO);
                            maestro.Rows[i]["COLOSO"] = Convert.ToDouble(saldoCO);
                        }
                    }

                    saldoCO = 0; compraCO = 0; abonoCO = 0;


                    //#####################################   SALDOS PREGOT  ####################################################
                    //MySqlCommand cmdPRE = new MySqlCommand(query, pre);
                    //drPRE = cmdPRE.ExecuteReader();
                    //while (drPRE.Read())
                    //{
                    //    mov = drPRE["Cargo_ab"].ToString();

                    //    if (mov.Equals("C"))
                    //    {
                    //        compraPRE += Convert.ToDouble(drPRE["importe"].ToString());
                    //    }
                    //    else
                    //    {
                    //        abonoPRE += Convert.ToDouble(drPRE["importe"].ToString());
                    //    }
                    //}
                    //drPRE.Close();
                    //saldoPRE = compraPRE - abonoPRE;


                    //for (int j = 0; j < maestro.Rows.Count; j++)
                    //{
                    //    /*proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);*/
                    //    proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                    //    if (proveedor.Equals(prov[i].proveedor))
                    //    {
                    //        /*DG_tabla.Rows[j].Cells["PREGOT"].Value = Convert.ToString(saldoPRE);*/
                    //        maestro.Rows[i]["PREGOT"] = Convert.ToDouble(saldoPRE);
                    //    }
                    //}

                    //saldoPRE = 0; compraPRE = 0; abonoPRE = 0;

                }

                bo.Close(); va.Close(); re.Close(); ve.Close(); co.Close(); /*pre.Close();*/


                // saldo total por proveedor

                double saldoTotal = 0;
                double saldobo = 0, saldova = 0, saldore = 0, saldove = 0, saldoco = 0, saldopre = 0;
                for (int i = 0; i < maestro.Rows.Count; i++)
                {
                    //saldobo = Convert.ToDouble(DG_tabla.Rows[i].Cells["BODEGA"].Value);
                    //saldova = Convert.ToDouble(DG_tabla.Rows[i].Cells["VALLARTA"].Value);
                    //saldore = Convert.ToDouble(DG_tabla.Rows[i].Cells["RENA"].Value);
                    //saldove = Convert.ToDouble(DG_tabla.Rows[i].Cells["VELAZQUEZ"].Value);
                    //saldoco = Convert.ToDouble(DG_tabla.Rows[i].Cells["COLOSO"].Value);
                    //saldopre = Convert.ToDouble(DG_tabla.Rows[i].Cells["PREGOT"].Value);
                    saldobo = Convert.ToDouble(maestro.Rows[i]["BODEGA"]);
                    saldova = Convert.ToDouble(maestro.Rows[i]["VALLARTA"]);
                    saldore = Convert.ToDouble(maestro.Rows[i]["RENA"]);
                    saldove = Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]);
                    saldoco = Convert.ToDouble(maestro.Rows[i]["COLOSO"]);
                    //saldopre = Convert.ToDouble(maestro.Rows[i]["PREGOT"]);

                    saldoTotal = saldobo + saldova + saldore + saldove + saldoco + saldopre;
                    //DG_tabla.Rows[i].Cells["SALDOTOTAL"].Value = saldoTotal;
                    maestro.Rows[i]["SALDO"] = Convert.ToDouble(saldoTotal);

                    saldobo = 0; saldova = 0; saldore = 0; saldove = 0; saldoco = 0; saldopre = 0; saldoTotal = 0;
                }

                double tBodega = 0, tVallarta = 0, tRena = 0, tColoso = 0, tVelazquez = 0, tPregot = 0, tTotal = 0;
                for (int i = 0; i < maestro.Rows.Count; i++)
                {
                    //tBodega += Convert.ToDouble(DG_tabla.Rows[i].Cells["BODEGA"].Value);
                    //tVallarta += Convert.ToDouble(DG_tabla.Rows[i].Cells["VALLARTA"].Value);
                    //tRena += Convert.ToDouble(DG_tabla.Rows[i].Cells["RENA"].Value);
                    //tVelazquez += Convert.ToDouble(DG_tabla.Rows[i].Cells["VELAZQUEZ"].Value);
                    //tColoso += Convert.ToDouble(DG_tabla.Rows[i].Cells["COLOSO"].Value);
                    //tPregot += Convert.ToDouble(DG_tabla.Rows[i].Cells["PREGOT"].Value);
                    //tTotal += Convert.ToDouble(DG_tabla.Rows[i].Cells["SALDOTOTAL"].Value);
                    tBodega += Convert.ToDouble(maestro.Rows[i]["BODEGA"]);
                    tVallarta += Convert.ToDouble(maestro.Rows[i]["VALLARTA"]);
                    tRena += Convert.ToDouble(maestro.Rows[i]["RENA"]);
                    tVelazquez += Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]);
                    tColoso += Convert.ToDouble(maestro.Rows[i]["COLOSO"]);
                    //tPregot += Convert.ToDouble(maestro.Rows[i]["PREGOT"]);
                    tTotal += Convert.ToDouble(maestro.Rows[i]["SALDO"]);
                }
                maestro.Rows.Add("", "TOTALES", tBodega, tVallarta, tRena, tVelazquez, tColoso, tTotal);

                DataView dv = null;
          
               dv = new DataView(maestro);
                dv.RowFilter = "SALDO <> 0";


                DG_tabla.DataSource = dv;

                DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[3].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[4].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[5].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[6].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[7].DefaultCellStyle.Format = "C2";
                //DG_tabla.Columns[8].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                //DG_tabla.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns["PROVEEDOR"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["NOMBRE"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;
                //DG_tabla.Columns["PREGOT"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["SALDO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            else
            {
                for (int i = 0; i < prov.Count; i++)
                {
                    string query = "SELECT Cargo_ab,importe FROM cuenxpdet WHERE proveedor='" + prov[i].proveedor + "'";


                    //#####################################   SALDOS BODEGA  ####################################################
                    MySqlCommand cmdBO = new MySqlCommand(query, bo);
                    drBO = cmdBO.ExecuteReader();
                    while (drBO.Read())
                    {
                        mov = drBO["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraBO += Convert.ToDouble(drBO["importe"].ToString());
                        }
                        else
                        {
                            abonoBO += Convert.ToDouble(drBO["importe"].ToString());
                        }
                    }
                    drBO.Close();
                    saldoBO = compraBO - abonoBO;
                    string proveedor = "";

                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);
                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["BODEGA"].Value =Convert.ToString(saldoBO);
                            maestro.Rows[i]["BODEGA"] = Convert.ToDouble(saldoBO);
                        }
                    }

                    saldoBO = 0; compraBO = 0; abonoBO = 0;



                    //#####################################   SALDOS VALLARTA  ####################################################
                    MySqlCommand cmdVA = new MySqlCommand(query, va);
                    drVA = cmdVA.ExecuteReader();
                    while (drVA.Read())
                    {
                        mov = drVA["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraVA += Convert.ToDouble(drVA["importe"].ToString());
                        }
                        else
                        {
                            abonoVA += Convert.ToDouble(drVA["importe"].ToString());
                        }
                    }
                    drVA.Close();
                    saldoVA = compraVA - abonoVA;


                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);
                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["VALLARTA"].Value = Convert.ToString(saldoVA);
                            maestro.Rows[i]["VALLARTA"] = Convert.ToDouble(saldoVA);
                        }
                    }

                    saldoVA = 0; compraVA = 0; abonoVA = 0;


                    //#####################################   SALDOS RENA  ####################################################
                    MySqlCommand cmdRE = new MySqlCommand(query, re);
                    drRE = cmdRE.ExecuteReader();
                    while (drRE.Read())
                    {
                        mov = drRE["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraRE += Convert.ToDouble(drRE["importe"].ToString());
                        }
                        else
                        {
                            abonoRE += Convert.ToDouble(drRE["importe"].ToString());
                        }
                    }
                    drRE.Close();
                    saldoRE = compraRE - abonoRE;


                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);
                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["RENA"].Value = Convert.ToString(saldoRE);
                            maestro.Rows[i]["RENA"] = Convert.ToDouble(saldoRE);
                        }
                    }

                    saldoRE = 0; compraRE = 0; abonoRE = 0;

                    //#####################################   SALDOS VELAZQUEZ  ####################################################
                    MySqlCommand cmdVE = new MySqlCommand(query, ve);
                    drVE = cmdVE.ExecuteReader();
                    while (drVE.Read())
                    {
                        mov = drVE["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraVE += Convert.ToDouble(drVE["importe"].ToString());
                        }
                        else
                        {
                            abonoVE += Convert.ToDouble(drVE["importe"].ToString());
                        }
                    }
                    drVE.Close();
                    saldoVE = compraVE - abonoVE;


                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);

                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["VELAZQUEZ"].Value = Convert.ToString(saldoVE);
                            maestro.Rows[i]["VELAZQUEZ"] = Convert.ToDouble(saldoVE);
                        }
                    }

                    saldoVE = 0; compraVE = 0; abonoVE = 0;



                    //#####################################   SALDOS COLOSO  ####################################################
                    MySqlCommand cmdCO = new MySqlCommand(query, co);
                    drCO = cmdCO.ExecuteReader();
                    while (drCO.Read())
                    {
                        mov = drCO["Cargo_ab"].ToString();

                        if (mov.Equals("C"))
                        {
                            compraCO += Convert.ToDouble(drCO["importe"].ToString());
                        }
                        else
                        {
                            abonoCO += Convert.ToDouble(drCO["importe"].ToString());
                        }
                    }
                    drCO.Close();
                    saldoCO = compraCO - abonoCO;


                    for (int j = 0; j < maestro.Rows.Count; j++)
                    {
                        //proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);
                        proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                        if (proveedor.Equals(prov[i].proveedor))
                        {
                            //DG_tabla.Rows[j].Cells["COLOSO"].Value = Convert.ToString(saldoCO);
                            maestro.Rows[i]["COLOSO"] = Convert.ToDouble(saldoCO);
                        }
                    }

                    saldoCO = 0; compraCO = 0; abonoCO = 0;


                    //#####################################   SALDOS PREGOT  ####################################################
                    //MySqlCommand cmdPRE = new MySqlCommand(query, pre);
                    //drPRE = cmdPRE.ExecuteReader();
                    //while (drPRE.Read())
                    //{
                    //    mov = drPRE["Cargo_ab"].ToString();

                    //    if (mov.Equals("C"))
                    //    {
                    //        compraPRE += Convert.ToDouble(drPRE["importe"].ToString());
                    //    }
                    //    else
                    //    {
                    //        abonoPRE += Convert.ToDouble(drPRE["importe"].ToString());
                    //    }
                    //}
                    //drPRE.Close();
                    //saldoPRE = compraPRE - abonoPRE;


                    //for (int j = 0; j < maestro.Rows.Count; j++)
                    //{
                    //    /*proveedor = Convert.ToString(DG_tabla.Rows[j].Cells["PROVEEDOR"].Value);*/
                    //    proveedor = Convert.ToString(maestro.Rows[i]["PROVEEDOR"]);
                    //    if (proveedor.Equals(prov[i].proveedor))
                    //    {
                    //        /*DG_tabla.Rows[j].Cells["PREGOT"].Value = Convert.ToString(saldoPRE);*/
                    //        maestro.Rows[i]["PREGOT"] = Convert.ToDouble(saldoPRE);
                    //    }
                    //}

                    //saldoPRE = 0; compraPRE = 0; abonoPRE = 0;

                }

                bo.Close(); va.Close(); re.Close(); ve.Close(); co.Close(); /*pre.Close();*/


                // saldo total por proveedor

                double saldoTotal = 0;
                double saldobo = 0, saldova = 0, saldore = 0, saldove = 0, saldoco = 0, saldopre = 0;
                for (int i = 0; i < maestro.Rows.Count; i++)
                {
                    //saldobo = Convert.ToDouble(DG_tabla.Rows[i].Cells["BODEGA"].Value);
                    //saldova = Convert.ToDouble(DG_tabla.Rows[i].Cells["VALLARTA"].Value);
                    //saldore = Convert.ToDouble(DG_tabla.Rows[i].Cells["RENA"].Value);
                    //saldove = Convert.ToDouble(DG_tabla.Rows[i].Cells["VELAZQUEZ"].Value);
                    //saldoco = Convert.ToDouble(DG_tabla.Rows[i].Cells["COLOSO"].Value);
                    //saldopre = Convert.ToDouble(DG_tabla.Rows[i].Cells["PREGOT"].Value);
                    saldobo = Convert.ToDouble(maestro.Rows[i]["BODEGA"]);
                    saldova = Convert.ToDouble(maestro.Rows[i]["VALLARTA"]);
                    saldore = Convert.ToDouble(maestro.Rows[i]["RENA"]);
                    saldove = Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]);
                    saldoco = Convert.ToDouble(maestro.Rows[i]["COLOSO"]);
                    //saldopre = Convert.ToDouble(maestro.Rows[i]["PREGOT"]);

                    saldoTotal = saldobo + saldova + saldore + saldove + saldoco + saldopre;
                    //DG_tabla.Rows[i].Cells["SALDOTOTAL"].Value = saldoTotal;
                    maestro.Rows[i]["SALDO"] = Convert.ToDouble(saldoTotal);

                    saldobo = 0; saldova = 0; saldore = 0; saldove = 0; saldoco = 0; saldopre = 0; saldoTotal = 0;
                }

                double tBodega = 0, tVallarta = 0, tRena = 0, tColoso = 0, tVelazquez = 0, tPregot = 0, tTotal = 0;
                for (int i = 0; i < maestro.Rows.Count; i++)
                {
                    //tBodega += Convert.ToDouble(DG_tabla.Rows[i].Cells["BODEGA"].Value);
                    //tVallarta += Convert.ToDouble(DG_tabla.Rows[i].Cells["VALLARTA"].Value);
                    //tRena += Convert.ToDouble(DG_tabla.Rows[i].Cells["RENA"].Value);
                    //tVelazquez += Convert.ToDouble(DG_tabla.Rows[i].Cells["VELAZQUEZ"].Value);
                    //tColoso += Convert.ToDouble(DG_tabla.Rows[i].Cells["COLOSO"].Value);
                    //tPregot += Convert.ToDouble(DG_tabla.Rows[i].Cells["PREGOT"].Value);
                    //tTotal += Convert.ToDouble(DG_tabla.Rows[i].Cells["SALDOTOTAL"].Value);
                    tBodega += Convert.ToDouble(maestro.Rows[i]["BODEGA"]);
                    tVallarta += Convert.ToDouble(maestro.Rows[i]["VALLARTA"]);
                    tRena += Convert.ToDouble(maestro.Rows[i]["RENA"]);
                    tVelazquez += Convert.ToDouble(maestro.Rows[i]["VELAZQUEZ"]);
                    tColoso += Convert.ToDouble(maestro.Rows[i]["COLOSO"]);
                    //tPregot += Convert.ToDouble(maestro.Rows[i]["PREGOT"]);
                    tTotal += Convert.ToDouble(maestro.Rows[i]["SALDO"]);
                }
                maestro.Rows.Add("", "TOTALES", tBodega, tVallarta, tRena, tVelazquez, tColoso, tPregot, tTotal);

             


                DG_tabla.DataSource = maestro;

                DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[3].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[4].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[5].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[6].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[7].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[8].DefaultCellStyle.Format = "C2";
                DG_tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                DG_tabla.Columns["PROVEEDOR"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["NOMBRE"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["BODEGA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["VALLARTA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["RENA"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["COLOSO"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["VELAZQUEZ"].SortMode = DataGridViewColumnSortMode.NotSortable;
                //DG_tabla.Columns["PREGOT"].SortMode = DataGridViewColumnSortMode.NotSortable;
                DG_tabla.Columns["SALDO"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        
        private void BT_saldos_Click(object sender, EventArgs e)
        {
            LB_mensaje.Text = "";
            LB_mensaje.Text = "Calculando saldos, espere...";
            SaldosMayoresCero();
            LB_mensaje.Text = ""; ;
        }


        public void Proveedores()
        {

            MySqlConnection con = BDConexicon.BodegaOpen();
            try
            {

                //OBTENGO LOS PROVEEDORES QUE EXISTEN EN LA BASE DE DATOS DE BODEGA
                MySqlCommand cmd = new MySqlCommand("SELECT PROVEEDOR,NOMBRE from proveed", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    prov.Add(new Proveedor { proveedor = dr["PROVEEDOR"].ToString(), nombre = dr["NOMBRE"].ToString() });

                }
                dr.Close();


                

                for (int i = 0; i < prov.Count; i++)
                {
                    //DG_tabla.Rows.Add(prov[i].proveedor, prov[i].nombre, 0, 0, 0, 0, 0, 0);
                    maestro.Rows.Add(prov[i].proveedor, prov[i].nombre, 0, 0, 0, 0, 0, 0);


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("NO HAY CONEXION CON EL SERVIDOR DE BODEGA");
            }
        }

        private void Rep_saldos_prov_Load(object sender, EventArgs e)
        {
            //DG_tabla.Columns["NOMBRE"].Width = 240;
            CBX_saldo.Checked = true;
            maestro.Columns.Add("PROVEEDOR", typeof(string));
            maestro.Columns.Add("NOMBRE", typeof(string));
            maestro.Columns.Add("BODEGA", typeof(double));
            maestro.Columns.Add("VALLARTA", typeof(double));
            maestro.Columns.Add("RENA", typeof(double));
            maestro.Columns.Add("VELAZQUEZ", typeof(double));
            maestro.Columns.Add("COLOSO", typeof(double));
            //maestro.Columns.Add("PREGOT", typeof(double));
            maestro.Columns.Add("SALDO", typeof(double));


        }



        //exporta a excel
        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            excel.Cells.Range["C6:C1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["D6:D1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["E6:E1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["F6:F1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["G6:G1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["H6:H1000"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["I6:I1000"].NumberFormat = "$#,##0.00";

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
