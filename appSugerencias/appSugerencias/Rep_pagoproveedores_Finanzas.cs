using MySql.Data.MySqlClient;
using System;
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
    public partial class Rep_pagoproveedores_Finanzas : Form
    {

        string usuario = "";
        public Rep_pagoproveedores_Finanzas(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        //OBTIENE EL NOMBRE DE LA SUCURSAL
        public string Sucursal()
        {

            string nombre = "";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT EMPRESA FROM ECONFIG", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nombre = dr["EMPRESA"].ToString();
            }
            dr.Close();
            con.Close();

            return nombre;

        }

        public string AreaTrabajo()
        {
            string area = "";

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT area from usuarios WHERE usuario ='" + usuario + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                area = dr["area"].ToString();
            }
            dr.Close();
            con.Close();
            return area;
        }

        private void Rep_pagoproveedores_Finanzas_Load(object sender, EventArgs e)
        {
            string suc = Sucursal();

            if (suc.Equals("OSMART VALLARTA"))
            {
                CB_sucursal.SelectedIndex = 1;
            }

            if (suc.Equals("OSMART RENACIMIENTO"))
            {
                CB_sucursal.SelectedIndex = 2;
            }

            if (suc.Equals("OSMART VELAZQUEZ"))
            {
                CB_sucursal.SelectedIndex = 3;
            }

            if (suc.Equals("OSMART COLOSO"))
            {
                CB_sucursal.SelectedIndex = 4;
            }

            if (suc.Equals("PREGOT"))
            {
                CB_sucursal.SelectedIndex = 5;
            }

            string area = AreaTrabajo();

            if (area.Equals("ADMON GRAL") || area.Equals("SISTEMAS") || area.Equals("CXPAGAR") || area.Equals("FINANZAS"))
            {
                CB_sucursal.Enabled = true;
            }
            else
            {
                CB_sucursal.Enabled = false;
            }


            if (area.Equals("ADMON GRAL") || area.Equals("DIREC GRAL"))
            {
                DG_reporte.Columns["STATUS"].ReadOnly = true;
                DG_reporte.Columns["AUXFIN"].ReadOnly = true;
                DG_reporte.Columns["FINANZAS"].ReadOnly = true;
            }


            if (area.Equals("FINANZAS"))
            {
                DG_reporte.Columns["STATUS"].ReadOnly = true;
                DG_reporte.Columns["GERENTEGRAL"].ReadOnly = true;
            }


            DG_reporte.Columns["PROVEEDOR"].Width = 270;
            DG_reporte.Columns["PAGARA"].Width = 270;
            DG_reporte.Columns["BANCO"].Width = 120;
            DG_reporte.Columns["CUENTA"].Width = 170;
            DG_reporte.Columns["REFERENCIA"].Width = 170;


            DG_reporte.Columns["STATUS"].Width = 70;
            DG_reporte.Columns["FINANZAS"].Width = 70;
            DG_reporte.Columns["AUXFIN"].Width = 70;
            DG_reporte.Columns["GERENTEGRAL"].Width = 70;
        }

        public string MesRespaldo(int mes)
        {
            string mesRespaldo = "";

            if (mes == 1)
            {
                mesRespaldo = "ENE";
            }
            if (mes == 2)
            {
                mesRespaldo = "FEB";
            }
            if (mes == 3)
            {
                mesRespaldo = "MAR";
            }
            if (mes == 4)
            {
                mesRespaldo = "ABR";
            }
            if (mes == 5)
            {
                mesRespaldo = "MAY";
            }
            if (mes == 6)
            {
                mesRespaldo = "JUN";
            }
            if (mes == 7)
            {
                mesRespaldo = "JUL";
            }
            if (mes == 8)
            {
                mesRespaldo = "AGO";
            }
            if (mes == 9)
            {
                mesRespaldo = "SEP";
            }
            if (mes == 10)
            {
                mesRespaldo = "OCT";
            }
            if (mes == 11)
            {
                mesRespaldo = "NOV";
            }
            if (mes == 12)
            {
                mesRespaldo = "DIC";
            }
            return mesRespaldo;
        }


        public MySqlConnection ElegirSucursal()
        {

            MySqlConnection con = null;
            try
            {
                string tienda = CB_sucursal.SelectedItem.ToString();
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;
                DateTime fecha = DT_fecha.Value;




                if (CHK_respaldo.Checked == true)
                {
                    string mesRespaldo = MesRespaldo(mes);
                    if (tienda.Equals("VALLARTA"))
                    {
                        con = BDConexicon.RespaldoVA(mesRespaldo, año);
                    }
                    if (tienda.Equals("RENA"))
                    {
                        con = BDConexicon.RespaldoRE(mesRespaldo, año);
                    }

                    if (tienda.Equals("COLOSO"))
                    {
                        con = BDConexicon.RespaldoCO(mesRespaldo, año);
                    }

                    if (tienda.Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.RespaldoVE(mesRespaldo, año);
                    }

                    if (tienda.Equals("PREGOT"))
                    {
                        con = BDConexicon.RespaldoPRE(mesRespaldo, año);
                    }

                }
                else
                {
                    if (tienda.Equals("BODEGA"))
                    {
                        con = BDConexicon.BodegaOpen();
                    }
                    if (tienda.Equals("VALLARTA"))
                    {
                        con = BDConexicon.VallartaOpen();
                    }
                    if (tienda.Equals("RENA"))
                    {
                        con = BDConexicon.RenaOpen();
                    }

                    if (tienda.Equals("COLOSO"))
                    {
                        con = BDConexicon.ColosoOpen();
                    }

                    if (tienda.Equals("VELAZQUEZ"))
                    {
                        con = BDConexicon.VelazquezOpen();
                    }

                    if (tienda.Equals("PREGOT"))
                    {
                        con = BDConexicon.Papeleria1Open();
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Debes elegir una sucursal ERROR: " + ex);
            }

            return con;


        }

        private void BT_aceptar_Click(object sender, EventArgs e)
        {
            if (CB_sucursal.SelectedIndex == 0)
            {
                MessageBox.Show("Elige la sucursal");
            }
            else
            {
                DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell aux_fin = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell finanzas = new DataGridViewCheckBoxCell();
                DataGridViewCheckBoxCell gerentegral = new DataGridViewCheckBoxCell();

                check.ThreeState = false;
                aux_fin.ThreeState = false;
                finanzas.ThreeState = false;
                gerentegral.ThreeState = false;

                MySqlConnection sucursal = ElegirSucursal();

                DG_reporte.Rows.Clear();
                DateTime fecha = DT_fecha.Value;
                DateTime fecha2 = DT_fecha2.Value;



                MySqlCommand cmd = new MySqlCommand("SELECT idreporte,nombreprov,pagarA,monto,banco,cuenta,fecha,fecha_efe,tienda,compra,referencia,status,finanzas,aux_fin,gerentegral FROM rd_rep_pagoproveedores WHERE fecha between'" + fecha.ToString("yyyy-MM-dd") + "' and '" + fecha2.ToString("yyyy-MM-dd")+"'", sucursal);
                MySqlDataReader dr = cmd.ExecuteReader();
                double monto = 0;



                while (dr.Read())
                {
                    //DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                    if (dr["fecha_efe"].ToString().Equals("0000-00-00"))
                    {
                        DateTime fecha_efe = new DateTime();


                        monto = Convert.ToDouble(dr["monto"].ToString());
                        if (dr["status"].ToString().Equals("1"))
                        {
                            check.ThreeState = true;
                        }
                        else
                        {
                            check.ThreeState = false;
                        }
                        if (dr["aux_fin"].ToString().Equals("1"))
                        {
                            aux_fin.ThreeState = true;
                        }
                        else
                        {
                            aux_fin.ThreeState = false;
                        }
                        if (dr["finanzas"].ToString().Equals("1"))
                        {
                            finanzas.ThreeState = true;
                        }
                        else
                        {
                            finanzas.ThreeState = false;
                        }
                        if (dr["gerentegral"].ToString().Equals("1"))
                        {
                            gerentegral.ThreeState = true;
                        }
                        else
                        {
                            gerentegral.ThreeState = false;
                        }

                        DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState, finanzas.ThreeState, aux_fin.ThreeState, gerentegral.ThreeState);

                    }
                    else
                    {
                        DateTime fecha_efe = Convert.ToDateTime(dr["fecha_efe"].ToString());


                        monto = Convert.ToDouble(dr["monto"].ToString());
                        if (dr["status"].ToString().Equals("1"))
                        {
                            check.ThreeState = true;
                        }
                        else
                        {
                            check.ThreeState = false;
                        }
                        if (dr["aux_fin"].ToString().Equals("1"))
                        {
                            aux_fin.ThreeState = true;
                        }
                        else
                        {
                            aux_fin.ThreeState = false;
                        }
                        if (dr["finanzas"].ToString().Equals("1"))
                        {
                            finanzas.ThreeState = true;
                        }
                        else
                        {
                            finanzas.ThreeState = false;
                        }
                        if (dr["gerentegral"].ToString().Equals("1"))
                        {
                            gerentegral.ThreeState = true;
                        }
                        else
                        {
                            gerentegral.ThreeState = false;
                        }

                        DG_reporte.Rows.Add(dr["idreporte"].ToString(), dr["nombreprov"].ToString(), dr["pagarA"].ToString(), String.Format("{0:0.##}", monto.ToString("C")), dr["banco"].ToString(), dr["cuenta"].ToString(), dr["fecha"].ToString(), fecha_efe, dr["tienda"].ToString(), dr["compra"].ToString(), dr["referencia"].ToString(), check.ThreeState, finanzas.ThreeState, aux_fin.ThreeState, gerentegral.ThreeState);
                    }


                }
               

                double suma = 0;
                for (int i = 0; i < DG_reporte.RowCount; i++)
                {
                    //suma += Convert.ToDouble(DG_reporte.Rows[i].Cells[2].Value);
                    decimal digito = decimal.Parse(DG_reporte.Rows[i].Cells["MONTO"].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    string num = digito.ToString("G0");

                    suma += Convert.ToDouble(num);
                }

                //DG_reporte.Rows.Add("", "", "TOTAL", String.Format("{0:0.##}", suma.ToString("C")), "", "", "", "");
                TB_total.Text = String.Format("{0:0.##}", suma.ToString("C"));
                DG_reporte.Columns[3].DefaultCellStyle.Format = "C2";

                this.DG_reporte.Sort(this.DG_reporte.Columns["PROVEEDOR"], ListSortDirection.Ascending);
                dr.Close();
                sucursal.Close();
            }
    }

        private void BT_guardar_Click(object sender, EventArgs e)
        {
            MySqlConnection sucursal = ElegirSucursal();


            for (int i = 0; i < DG_reporte.RowCount; i++)
            {
                int id = Convert.ToInt32(DG_reporte.Rows[i].Cells[0].Value);
                bool status = Convert.ToBoolean(DG_reporte.Rows[i].Cells[11].Value);
                bool aux_fin = Convert.ToBoolean(DG_reporte.Rows[i].Cells[13].Value);
                bool finanzas = Convert.ToBoolean(DG_reporte.Rows[i].Cells[12].Value);
                bool gerentegral = Convert.ToBoolean(DG_reporte.Rows[i].Cells[14].Value);
                int val1 = 0, val2 = 0, val3 = 0, val4 = 0;
                if (status==true)
                {
                    val1 = 1;
                }
                else
                {
                    val1 = 0;
                }
                if (aux_fin==true)
                {
                    val2 = 1;
                }
                else
                {
                    val2 = 0;
                }
                if (finanzas==true)
                {
                    val3 = 1;
                }
                else
                {
                    val3 = 0;
                }
                if (gerentegral == true)
                {
                    val4 = 1;
                }
                else
                {
                    val4 = 0;
                }


                MySqlCommand cmd = new MySqlCommand("UPDATE rd_rep_pagoproveedores SET status="+val1+",aux_fin="+val2+",finanzas="+val3+",gerentegral="+val4+" where idreporte='"+id+"'",sucursal);
                cmd.ExecuteNonQuery();
              
               
            }
            MessageBox.Show("Se han actualizado los check");
            sucursal.Close();
        }

        public void EfectivoDisponible()
        {
            DateTime fecha = DT_fecha.Value;
            string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
            "where  fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

            MySqlConnection con = ElegirSucursal();
            double retiro = 0, efectivo = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    string concepto = dr["concepto2"].ToString();
                    if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR") || concepto.Equals("CCDIS"))
                    {
                        retiro += Convert.ToDouble(dr["Importe"].ToString());
                    }

                    if (concepto.Equals("Retir"))
                    {
                        efectivo = Convert.ToDouble(dr["Importe"].ToString());
                    }


                }

                dr.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepcion "+ex);

            }

            double disponible = efectivo - retiro;
            TB_disponible.Text = String.Format("{0:0.##}", disponible.ToString("C"));


        }

        private void BT_efectivo_Click(object sender, EventArgs e)
        {
            EfectivoDisponible();
        }
    }

}
