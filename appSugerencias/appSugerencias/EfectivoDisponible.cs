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
    public partial class EfectivoDisponible : Form
    {
        public EfectivoDisponible()
        {
            InitializeComponent();
        }

        //Devuelve el mes
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


        //TRAE EL EFECTIVO DISPONIBLE DE VALLARTA
        public void EfectivoVA()
        {
            LB_va.Text="";
            LB_efevallarta.Text = "";

            double efeVA = 0;
            if (CHK_respaldo.Checked == true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);

                LB_va.ForeColor = Color.Black;
                double retiroVA = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, " +
                    "flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where  fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RespaldoVA(mesRespaldo, año);

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_va.ForeColor = Color.DarkGreen;
                        LB_va.Text = "Conectado";
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR") || concepto.Equals("CCDIS"))
                        {
                            retiroVA += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeVA = Convert.ToDouble(dr["Importe"].ToString());
                        }


                    }

                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_va.ForeColor = Color.Red;
                    LB_va.Text = "Sin Conexión";
                    LB_efevallarta.Text = "$0.00";
                }

                double disponible = efeVA - retiroVA;
                LB_efevallarta.Text = String.Format("{0:0.##}", disponible.ToString("C"));
                con.Close();
            }
            else
            {
                LB_va.ForeColor = Color.Black;
                double retiroVA = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, " +
                    "flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where  fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.VallartaOpen();


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_va.ForeColor = Color.DarkGreen;
                        LB_va.Text = "Conectado";
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR"))
                        {
                            retiroVA += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeVA = Convert.ToDouble(dr["Importe"].ToString());
                        }


                    }

                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_va.ForeColor = Color.Red;
                    LB_va.Text = "Sin Conexión";
                    LB_efevallarta.Text = "$0.00";
                }

                double disponible = efeVA - retiroVA;
                LB_efevallarta.Text = String.Format("{0:0.##}", disponible.ToString("C"));


                con.Close();
            }




        }

        //TRAE EL EFECTIVO DISPONIBLE DE RENA
        public void EfectivoRE()
        {

            LB_re.Text = "";
            LB_eferena.Text = "";
            double efeRE = 0;

            if (CHK_respaldo.Checked == true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);

              
                DateTime fecha = DT_fecha.Value;
                double retiroRE = 0;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RespaldoRE(mesRespaldo, año);


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_re.ForeColor = Color.DarkGreen;
                        LB_re.Text = "Conectado";

                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR") || concepto.Equals("CCDIS"))
                        {
                            retiroRE += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeRE = Convert.ToDouble(dr["Importe"].ToString());
                        }

                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " RENA ";
                    //}
                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_re.ForeColor = Color.Red;
                    LB_re.Text = "Sin Conexión";
                    LB_eferena.Text = "$0.00";
                }

                double disponible = efeRE - retiroRE;
                LB_eferena.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();

            }
            else
            {
                LB_re.ForeColor = Color.Black;
                DateTime fecha = DT_fecha.Value;
                double retiroRE = 0;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RenaOpen();


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_re.ForeColor = Color.DarkGreen;
                        LB_re.Text = "Conectado";
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN")|| concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR"))
                        {
                            retiroRE += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeRE = Convert.ToDouble(dr["Importe"].ToString());
                        }

                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " RENA ";
                    //}
                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_re.ForeColor = Color.Red;
                    LB_re.Text = "Sin Conexión";
                    LB_eferena.Text = "$0.00";
                }

                double disponible = efeRE - retiroRE;
                LB_eferena.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();
            }




        }

        //TRAE EL EFECTIVO DISPONIBLE DE COLOSO
        public void EfectivoCO()
        {
            LB_co.Text = "";
            LB_efecoloso.Text = "";
            double efeCO =0;
            if (CHK_respaldo.Checked == true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);

                LB_co.ForeColor = Color.Black;
                double retiroCO = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RespaldoCO(mesRespaldo, año);


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_co.ForeColor = Color.DarkGreen;
                        LB_co.Text = "Conectado";
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR") || concepto.Equals("CCDIS"))
                        {
                            retiroCO += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeCO = Convert.ToDouble(dr["Importe"].ToString());
                        }


                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " COLOSO ";
                    //}
                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_co.ForeColor = Color.Red;
                    LB_co.Text = "Sin Conexión";
                    LB_efecoloso.Text = "$0.00";
                }
                double disponible = efeCO - retiroCO;
                LB_efecoloso.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();

            }
            else
            {

                LB_co.ForeColor = Color.Black;
                double retiroCO = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.ColosoOpen();


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_co.ForeColor = Color.DarkGreen;
                        LB_co.Text = "Conectado";
                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR"))
                        {
                            retiroCO += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeCO = Convert.ToDouble(dr["Importe"].ToString());
                        }


                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " COLOSO ";
                    //}
                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_co.ForeColor = Color.Red;
                    LB_co.Text = "Sin Conexión";
                    LB_efecoloso.Text = "$0.00";
                }
                double disponible = efeCO - retiroCO;
                LB_efecoloso.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();
            }



        }

        //TRAE EL EFECTIVO DISPONIBLE DE VELAZQUEZ
        public void EfectivoVE()
        {
            LB_ve.Text = "";
            LB_efevelazquez.Text = "";
            double efeVE = 0;
            if (CHK_respaldo.Checked == true)
            {
                int mes = DT_fecha.Value.Month;
                int año = DT_fecha.Value.Year;

                string mesRespaldo = MesRespaldo(mes);

                LB_ve.ForeColor = Color.Black;
                double retiroVE = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.RespaldoVE(mesRespaldo, año);


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_ve.ForeColor = Color.DarkGreen;
                        LB_ve.Text = "Conectado";

                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR") || concepto.Equals("CCDIS"))
                        {
                            retiroVE += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeVE = Convert.ToDouble(dr["Importe"].ToString());
                        }

                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " VELAZQUEZ ";
                    //}
                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_ve.ForeColor = Color.Red;
                    LB_ve.Text = "Sin Conexión";

                    LB_efevelazquez.Text = "$0.00";
                }

                double disponible = efeVE - retiroVE;
                LB_efevelazquez.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();

            }
            else
            {
                LB_ve.ForeColor = Color.Black;
                double retiroVE = 0;
                DateTime fecha = DT_fecha.Value;
                string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
                "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";

                MySqlConnection con = BDConexicon.VelazquezOpen();


                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        LB_ve.ForeColor = Color.DarkGreen;
                        LB_ve.Text = "Conectado";


                        string concepto = dr["concepto2"].ToString();
                        if (concepto.Equals("RPPP") || concepto.Equals("RBAN") || concepto.Equals("ALBR") || concepto.Equals("CINO") || concepto.Equals("CCDMX") || concepto.Equals("FNZAS") || concepto.Equals("ACCR") || concepto.Equals("CGRAL") || concepto.Equals("ACR"))
                        {
                            retiroVE += Convert.ToDouble(dr["Importe"].ToString());
                        }

                        if (concepto.Equals("Retir"))
                        {
                            efeVE = Convert.ToDouble(dr["Importe"].ToString());
                        }

                    }
                    //else
                    //{
                    //    cont++;
                    //    mensaje += " VELAZQUEZ ";
                    //}
                    dr.Close();
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    LB_ve.ForeColor = Color.Red;
                    LB_ve.Text = "Sin Conexión";

                    LB_efevelazquez.Text = "$0.00";
                }

                double disponible = efeVE - retiroVE;
                LB_efevelazquez.Text = String.Format("{0:0.##}", disponible.ToString("C"));

                con.Close();
            }




        }

        //TRAE EL EFECTIVO DISPONIBLE DE PREGOT
        //public void EfectivoPRE()
        //{
        //    LB_pre.Text = "";
        //    LB_efepregot.Text = "";
        //    double efePRE = 0;
        //    if (CHK_respaldo.Checked == true)
        //    {
        //        int mes = DT_fecha.Value.Month;
        //        int año = DT_fecha.Value.Year;

        //        string mesRespaldo = MesRespaldo(mes);

        //        LB_pre.ForeColor = Color.Black;
        //        double retiroPRE = 0;
        //        DateTime fecha = DT_fecha.Value;
        //        string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
        //        "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";


        //        MySqlConnection con = null;

        //        try
        //        {
        //            con = BDConexicon.RespaldoPRE(mesRespaldo, año);
        //            MySqlCommand cmd = new MySqlCommand(query, con);
        //            MySqlDataReader dr = cmd.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                LB_pre.ForeColor = Color.DarkGreen;
        //                LB_pre.Text = "Conectado";

        //                string concepto = dr["concepto2"].ToString();
        //                if (concepto.Equals("RPPP") || concepto.Equals("RBAN"))
        //                {
        //                    retiroPRE += Convert.ToDouble(dr["Importe"].ToString());
        //                }

        //                if (concepto.Equals("Retir"))
        //                {
        //                    efePRE = Convert.ToDouble(dr["Importe"].ToString());
        //                }

        //            }
        //            //else
        //            //{
        //            //    cont++;
        //            //    mensaje += " PREGOT ";
        //            //}
        //            dr.Close();
        //        }
        //        catch (Exception ex)
        //        {

        //            LB_pre.ForeColor = Color.Red;
        //            LB_pre.Text = "Sin Conexión";

        //            LB_efepregot.Text = "$0.00";
        //        }
        //        double disponible = efePRE - retiroPRE;
        //        LB_efepregot.Text = String.Format("{0:0.##}", disponible.ToString("C"));

        //        con.Close();

        //    }
        //    else
        //    {

        //        LB_pre.ForeColor = Color.Black;
        //        double retiroPRE = 0;
        //        DateTime fecha = DT_fecha.Value;
        //        string query = "SELECT flujo.concepto2,conegre.descrip,SUM(flujo.importe * flujo.tipo_cam) AS `Importe`,flujo.ing_eg AS IE, flujo.banco, flujo.cheque, flujo.fecha, flujo.hora, flujo.usuario, flujo.estacion FROM(flujo INNER JOIN conegre ON flujo.concepto2 = conegre.concepto) " +
        //        "where fecha ='" + fecha.ToString("yyyy/MM/dd") + "'GROUP BY flujo.concepto2 ORDER BY flujo.fecha, flujo.hora ";


        //        MySqlConnection con = null;

        //        try
        //        {
        //            con = BDConexicon.Papeleria1Open();
        //            MySqlCommand cmd = new MySqlCommand(query, con);
        //            MySqlDataReader dr = cmd.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                LB_pre.ForeColor = Color.DarkGreen;
        //                LB_pre.Text = "Conectado";


        //                string concepto = dr["concepto2"].ToString();
        //                if (concepto.Equals("RPPP") || concepto.Equals("RBAN"))
        //                {
        //                    retiroPRE += Convert.ToDouble(dr["Importe"].ToString());
        //                }

        //                if (concepto.Equals("Retir"))
        //                {
        //                    efePRE = Convert.ToDouble(dr["Importe"].ToString());
        //                }

        //            }
        //            //else
        //            //{
        //            //    cont++;
        //            //    mensaje += " PREGOT ";
        //            //}
        //            dr.Close();
        //        }
        //        catch (Exception ex)
        //        {

        //            LB_pre.ForeColor = Color.Red;
        //            LB_pre.Text = "Sin Conexión";

        //            LB_efepregot.Text = "$0.00";
        //        }
        //        double disponible = efePRE - retiroPRE;
        //        LB_efepregot.Text = String.Format("{0:0.##}", disponible.ToString("C"));

        //        con.Close();
        //    }





        //}

        public void SumarEfectivo()
        {
#pragma warning disable CS0219 // La variable 'pre' está asignada pero su valor nunca se usa
            double va = 0, re = 0, ve = 0, co = 0, pre = 0,suma =0;
#pragma warning restore CS0219 // La variable 'pre' está asignada pero su valor nunca se usa
           

            decimal var = decimal.Parse(LB_efevallarta.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string s = var.ToString("G0");
            va = Convert.ToDouble(s);

            decimal var2 = decimal.Parse(LB_eferena.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string s2 = var2.ToString("G0");
            re = Convert.ToDouble(s2);

            decimal var3 = decimal.Parse(LB_efevelazquez.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string s3 = var3.ToString("G0");
            ve = Convert.ToDouble(s3);

            decimal var4 = decimal.Parse(LB_efecoloso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            string s4 = var4.ToString("G0");
            co = Convert.ToDouble(s4);

            //decimal var5 = decimal.Parse(LB_efepregot.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            //string s5 = var5.ToString("G0");
            //pre = Convert.ToDouble(s5);

            suma = va + re + ve + co;

            LB_total.Text = String.Format("{0:0.##}", suma.ToString("C"));

        }

        private void EfectivoDisponible_Load(object sender, EventArgs e)
        {
            
        }

        private void BT_efectivo_Click(object sender, EventArgs e)
        {
            EfectivoVA();
            EfectivoRE();
            EfectivoCO();
            EfectivoVE();
            //EfectivoPRE();
            SumarEfectivo();
        }
    }
}
