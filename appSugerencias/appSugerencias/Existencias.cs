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
    public partial class Existencias : Form
        

    {
        string Usuario;
        string Area;
        string ip;

        public Existencias()
        {
            InitializeComponent();
        }

        public Existencias(string usuario, string area)
        {
            InitializeComponent();
            Usuario = usuario;
            Area = area;
        }


        public void Vallarta()
        {
           
            try
            {
                MySqlConnection con = BDConexicon.VallartaOpen();

                MySqlCommand cmd = new MySqlCommand("select existencia,linea,fabricante,precio1,precio2,impuesto from prods where articulo='" + TB_articulo.Text + "'",con );
                MySqlDataReader rd = cmd.ExecuteReader();

                //while (rd.Read())
                //{
                //    TB_vallarta.Text = rd[0].ToString();
                //    LB_vallarta.Text = "Conectado";
                //}
                double precio1 = 0;
                double precio2 = 0;

                if (rd.Read())
                {
                   
                    TB_vallarta.Text = rd[0].ToString();
                    LB_prov_vallarta.Text= rd["fabricante"].ToString();
                    LB_va_linea.Text = rd["linea"].ToString();
                    LB_vallarta.Text = "Conectado";
                    LB_vallarta.ForeColor = Color.DarkGreen;
                    if (rd["impuesto"].ToString().Equals("SYS") || rd["impuesto"].ToString().Equals("sys"))
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());
                        LB_PM_vallarta.Text = precio2.ToString("C2");
                        LB_PME_vallarta.Text = precio1.ToString("C2");
                    }
                    else
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());
                        precio1 += precio1 * 0.16;
                        precio2 += precio2 * 0.16;

                        LB_PM_vallarta.Text = Convert.ToString( precio2.ToString("C"));
                        LB_PME_vallarta.Text =Convert.ToString(precio1.ToString("C"));
                    }
                    
                }
                else
                {
                    LB_vallarta.Text = "No existe";
                    LB_vallarta.ForeColor = Color.Red;
                }
                rd.Close();
                con.Close();
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                LB_vallarta.Text = "Sin conexion";
                LB_vallarta.ForeColor = Color.Red;
            }
           
        }

        public void Velazquez()
        {
          
            try {
                MySqlConnection con = BDConexicon.VelazquezOpen();
                MySqlCommand cmd = new MySqlCommand("select existencia,linea,precio1,precio2,fabricante,impuesto from prods where articulo='" + TB_articulo.Text + "'",con );
            MySqlDataReader rd = cmd.ExecuteReader();
                double precio1 = 0;
                double precio2 = 0;
            //while (rd.Read())
            //{
            //    TB_velazquez.Text = rd[0].ToString();
            //        LB_velazquez.Text = "Conectado";
            // }

                if (rd.Read())
                {
                    TB_velazquez.Text = rd[0].ToString();
                    LB_prov_velazquez.Text= rd["fabricante"].ToString();
                    LB_ve_linea.Text = rd["linea"].ToString();
                    LB_velazquez.Text = "Conectado";
                    LB_velazquez.ForeColor = Color.DarkGreen;
                    if (rd["impuesto"].ToString().Equals("SYS") || rd["impuesto"].ToString().Equals("sys"))
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());

                        LB_PM_velazquez.Text = precio2.ToString("C2");
                        LB_PME_velazquez.Text = precio1.ToString("C2");
                    }
                    else
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());

                        precio1 += precio1 * 0.16;
                        precio2 += precio2 * 0.16;
                        LB_PM_velazquez.Text = Convert.ToString(precio2.ToString("C"));
                        LB_PME_velazquez.Text = Convert.ToString(precio1.ToString("C"));
                    }
                }
                else
                {
                    LB_velazquez.Text = "No existe";
                    LB_velazquez.ForeColor = Color.Red;
                }
                rd.Close();
                con.Close();
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                LB_velazquez.Text = "Sin conexion";
                LB_velazquez.ForeColor = Color.Red;
            }

           
        }

        public void Rena()
        {

          
            try {
                MySqlConnection con = BDConexicon.RenaOpen();
                MySqlCommand cmd = new MySqlCommand("select existencia,linea,precio1,precio2,fabricante,impuesto from prods where articulo='" + TB_articulo.Text + "'",con);
            MySqlDataReader rd = cmd.ExecuteReader();

                //while (rd.Read())
                //{
                //    TB_rena.Text = rd[0].ToString();
                //        LB_rena.Text = "Conectado";
                //}
                double precio1 = 0, precio2 = 0;
                if (rd.Read())
                {
                    TB_rena.Text = rd[0].ToString();
                    LB_prov_rena.Text= rd["fabricante"].ToString();
                    LB_re_linea.Text = rd["linea"].ToString();
                    LB_rena.Text = "Conectado";
                    if (rd["impuesto"].ToString().Equals("SYS") || rd["impuesto"].ToString().Equals("sys"))
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());
                        LB_PM_rena.Text = precio2.ToString("C2");
                        LB_PME_rena.Text = precio1.ToString("C2");
                    }
                    else
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());

                        precio1 += precio1 * 0.16;
                        precio2 += precio2 * 0.16;
                        LB_PM_rena.Text = Convert.ToString(precio2.ToString("C"));
                        LB_PME_rena.Text = Convert.ToString(precio1.ToString("C"));
                    }
                    LB_rena.ForeColor = Color.DarkGreen;
                }
                else
                {
                    LB_rena.Text = "No existe";
                    LB_rena.ForeColor = Color.Red;
                }
                rd.Close();
                con.Close();

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                LB_rena.Text = "Sin conexion";
                LB_rena.ForeColor = Color.Red;
            }

            
        }

        public void Coloso()
        {

           
            try {
                MySqlConnection con = BDConexicon.ColosoOpen();

                MySqlCommand cmd = new MySqlCommand("select existencia,linea,precio1,precio2,fabricante,impuesto from prods where articulo='" + TB_articulo.Text + "'", con);
            MySqlDataReader rd = cmd.ExecuteReader();

                //while (rd.Read())
                //{
                //    TB_coloso.Text = rd[0].ToString();
                //    LB_coloso.Text = "Conectado";
                //}
                double precio1 = 0, precio2 = 0;

                if (rd.Read())
                {
                    TB_coloso.Text = rd[0].ToString();
                    LB_prov_coloso.Text = rd["fabricante"].ToString();
                    LB_co_linea.Text = rd["linea"].ToString();
                    LB_coloso.Text = "Conectado";
                    if (rd["impuesto"].ToString().Equals("SYS") || rd["impuesto"].ToString().Equals("sys"))
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());
                        LB_PM_coloso.Text = precio2.ToString("C2");
                        LB_PME_coloso.Text = precio1.ToString("C2");
                    }
                    else
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());

                        precio1 += precio1 * 0.16;
                        precio2 += precio2 * 0.16;
                        LB_PM_coloso.Text = Convert.ToString(precio2.ToString("C"));
                        LB_PME_coloso.Text = Convert.ToString(precio1.ToString("C"));
                    }
                    LB_coloso.ForeColor = Color.DarkGreen;
                }
                else
                {
                    LB_coloso.Text = "No existe";
                    LB_coloso.ForeColor = Color.Red;
                }
                rd.Close();
                con.Close();
            }
            
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                LB_coloso.Text = "Sin conexion";
                LB_coloso.ForeColor = Color.Red;
            }

           
        }

        public void Bodega()
        {
            try
            {
                MySqlConnection con = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand("select existencia,linea,precio1,precio2,fabricante,impuesto from prods where articulo='" + TB_articulo.Text + "'", con);
                MySqlDataReader rd = cmd.ExecuteReader();
                double precio1 = 0, precio2 = 0;
              

                if (rd.Read())
                {
                    TB_bodega.Text = rd["existencia"].ToString();
                    LB_prov_bodega.Text= rd["fabricante"].ToString();
                    LB_bo_linea.Text = rd["linea"].ToString();
                    Lb_bodega.Text = "Conectado";
                    if (rd["impuesto"].ToString().Equals("SYS") || rd["impuesto"].ToString().Equals("sys"))
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());
                        LB_PM_bodega.Text = precio2.ToString("C2");
                        LB_PME_bodega.Text =precio1.ToString("C2");
                    }
                    else
                    {
                        precio1 = Convert.ToDouble(rd["precio1"].ToString());
                        precio2 = Convert.ToDouble(rd["precio2"].ToString());
                        precio1 += precio1 * 0.16;
                        precio2 += precio2 * 0.16;
                        LB_PM_bodega.Text = Convert.ToString(precio2.ToString("C"));
                        LB_PME_bodega.Text = Convert.ToString(precio1.ToString("C"));
                    }
                    Lb_bodega.ForeColor = Color.DarkGreen;
                }
                else
                {
                    Lb_bodega.Text = "No existe";
                    Lb_bodega.ForeColor = Color.Red;
                }

                rd.Close();
                con.Close();
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                Lb_bodega.Text = "Sin conexion";
                Lb_bodega.ForeColor = Color.Red;
            }

           
        }

    //    public void Pregot()
    //    {
    //        try
    //        {
    //            MySqlConnection con = BDConexicon.Papeleria1Open();
    //        MySqlCommand cmd = new MySqlCommand("select existencia,linea,precio1,precio2,fabricante,impuesto from prods where articulo='" + TB_articulo.Text + "'", con);
    //        MySqlDataReader rd = cmd.ExecuteReader();

    //            double precio1 = 0, precio2 = 0;

    //        if (rd.Read())
    //        {
    //            TB_pregot.Text = rd["existencia"].ToString();
    //            LB_prov_pregot.Text = rd["fabricante"].ToString();
    //            LB_pre_linea.Text = rd["linea"].ToString();
    //            LB_pregot.Text = "Conectado";
    //                if (rd["impuesto"].ToString().Equals("SYS") || rd["impuesto"].ToString().Equals("sys"))
    //                {
    //                    precio1 = Convert.ToDouble(rd["precio1"].ToString());
    //                    precio2 = Convert.ToDouble(rd["precio2"].ToString());
    //                    LB_PM_pregot.Text = precio2.ToString("C2");
    //                    LB_PME_pregot.Text = precio1.ToString("C2");
    //                }
    //                else
    //                {
    //                    precio1 = Convert.ToDouble(rd["precio1"].ToString());
    //                    precio2 = Convert.ToDouble(rd["precio2"].ToString());

    //                    precio1 += precio1 * 0.16;
    //                    precio2 += precio2 * 0.16;
    //                    LB_PM_pregot.Text = Convert.ToString(precio2.ToString("C"));
    //                    LB_PME_pregot.Text = Convert.ToString(precio1.ToString("C"));
    //                }

    //                LB_pregot.ForeColor = Color.DarkGreen;
    //        }
    //        else
    //        {
    //            //LB_pregot.Text = "No existe";
    //            //LB_pregot.ForeColor = Color.Red;
    //        }

    //        rd.Close();
    //        con.Close();


    //    }catch (Exception e)

    //        {
    //            //LB_pregot.Text = "Sin conexion";
    //            //LB_pregot.ForeColor = Color.Red;
    //        }
    //}


        public void DatosProducto()
        {

           

            try
            {
                MySqlConnection con = BDConexicon.conectar();
                MySqlCommand cmd = new MySqlCommand("select descrip, precio1,precio2, costo_u, existencia,fabricante,impuesto from prods where articulo ='" + TB_articulo.Text + "'",con);
                MySqlDataReader rd = cmd.ExecuteReader();

                if(rd.Read())
                {
                    if (rd["impuesto"].ToString().Equals("SYS")||rd["impuesto"].ToString().Equals("sys"))
                    {
                        TB_desc.Text = rd["DESCRIP"].ToString();
                       

                        double precio1 = Convert.ToDouble(rd["PRECIO1"].ToString());
                        double precio2 = Convert.ToDouble(rd["PRECIO2"].ToString());
                        double costo = Convert.ToDouble(rd["COSTO_U"].ToString());

                        TB_precio1.Text = precio1.ToString("C2");
                        TB_precio2.Text = precio2.ToString("C2");
                        TB_costo.Text = costo.ToString("C2");

                        TB_fabricante.Text = rd["fabricante"].ToString();


                      }
                    else
                    {
                        TB_desc.Text = rd["DESCRIP"].ToString();

                        double precio1 = Convert.ToDouble(rd["PRECIO1"].ToString());
                        double ivaPrecio1 = precio1 + precio1 * 0.16;

                        double precio2 = Convert.ToDouble(rd["PRECIO2"].ToString());
                        double ivaPrecio2 = precio2 + precio2 * 0.16;

                        TB_precio1.Text = ivaPrecio1.ToString("C");
                        TB_precio2.Text = ivaPrecio2.ToString("C");


                        double costo = Convert.ToDouble(rd["COSTO_U"].ToString());
                        double IvaCosto = costo + costo * 0.16;

                        TB_costo.Text = IvaCosto.ToString("C");
                        TB_fabricante.Text = rd["fabricante"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("ESTE ARTICULO NO EXISTE EN ESTA SUCURSAL");
                }
                rd.Close();
                con.Close();
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
               
            }

            
        }




        private void BTN_aceptar_Click(object sender, EventArgs e)
        {



          
            if (TB_articulo.Text.Equals(""))
            {
                MessageBox.Show("Ingresa un artículo");
            }
            else
            {


                lblVa.Text = "";
                lblRe.Text = "";
                lblVe.Text = "";
                lblCo.Text = "";

                lblVaPre.Text = "";
                lblRePre.Text = "";
                lblVePre.Text = "";
                //lblCoPre.Text = "";

                DatosProducto();

                if (CKB_Bodega.Checked == true)
                {
                    Bodega();
                }

                if (CKB_Vallarta.Checked == true)
                {
                    Vallarta();
                }

                if (CKB_Rena.Checked == true)
                {
                    Rena();
                }

                if (CKB_Velazquez.Checked == true)
                {
                    Velazquez();
                }

                if (CKB_Coloso.Checked == true)
                {
                    Coloso();
                }

                //if (CKB_Pregot.Checked == true)
                //{
                //    Pregot();
                //}
                




            }



        }

 //################################################################# CODIGO DE DANIEL ####################################################################################
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }





        private void Existencias_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    



        private void cBoxTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxTodas.Checked)
            {
                cBoxVa.Checked = true;
                cBoxRe.Checked = true;
                cBoxVe.Checked = true;
                cBoxCo.Checked = true;
            }else if (!cBoxTodas.Checked)
            {
                cBoxVa.Checked = false;
                cBoxRe.Checked = false;
                cBoxVe.Checked = false;
                cBoxCo.Checked = false;
            }
        }

        internal static String getDate(DateTime now)
        {
            String datePatt = @"yyyy-MM-dd";
            String snow = now.ToString(datePatt);
            return snow;
        }



        public void VallartaOferta()
        {

            MySqlConnection con = BDConexicon.VallartaOpen();
            try
            {
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblVa.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                lblVa.Text = "N/A";
                lblVa.ForeColor = Color.Red;
            }
            con.Close();
        }


        public void RenaOferta()
        {

            MySqlConnection con = BDConexicon.RenaOpen();
            try
            {
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo",con);
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblRe.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                lblRe.Text = "N/A";
                lblRe.ForeColor = Color.Red;
            }
          con.Close();
        }

        public void VelazquezOferta()
        {

            MySqlConnection con = BDConexicon.VelazquezOpen();
            try
            {
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

                //limpiarOferta();

                lblVe.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                lblVe.Text = "N/A";
                lblVe.ForeColor = Color.Red;
            }

            con.Close();
        }

        public void ColosoOferta()
        {

            MySqlConnection con = BDConexicon.ColosoOpen();
            try
            {
                DateTime Finicio = dt_Inicio.Value;
                DateTime Ffin = dt_Fin.Value;

                string inicio = getDate(Finicio);
                string fin = getDate(Ffin);



                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();

                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdr;
                mdr = cmdo.ExecuteReader();
                mdr.Close();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
                cmd.ExecuteNonQuery();

               // limpiarOferta();

                lblCo.Text = "OK";
                //MessageBox.Show("Los datos se Guardaron");
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                lblCo.Text = "N/A";
                lblCo.ForeColor = Color.Red;
            }

            BDConexicon.ColosoClose();
        }


//        public void PregotOferta()
//        {

//            MySqlConnection con = BDConexicon.Papeleria1Open();
//            try
//            {
//                DateTime Finicio = dt_Inicio.Value;
//                DateTime Ffin = dt_Fin.Value;

//                string inicio = getDate(Finicio);
//                string fin = getDate(Ffin);



//                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET oferta=1  WHERE articulo=?articulo", con);
//                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
//                MySqlDataReader mdrr;
//                mdrr = cmdoo.ExecuteReader();
//                mdrr.Close();

//                MySqlCommand cmdo = new MySqlCommand("DELETE FROM ofertas WHERE articulo=?articulo", con);
//                cmdo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
//                MySqlDataReader mdr;
//                mdr = cmdo.ExecuteReader();
//                mdr.Close();

//                MySqlCommand cmd = new MySqlCommand("INSERT INTO ofertas(articulo,fechainicial,fechafinal,porporcentaje,porcentaje) VALUES(?articulo,?fechainicial,?fechafinal,?porporcentaje,?porcentaje)", con);
//                cmd.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
//                cmd.Parameters.Add("?fechainicial", MySqlDbType.VarChar).Value = inicio;
//                cmd.Parameters.Add("?fechafinal", MySqlDbType.VarChar).Value = fin;
//                cmd.Parameters.Add("?porporcentaje", MySqlDbType.Int16).Value = 1;
//                cmd.Parameters.Add("?porcentaje", MySqlDbType.Float).Value = (float)Convert.ToDouble(tbporcentaje.Text);
//                cmd.ExecuteNonQuery();

//                //limpiarOferta();

//                lblPre.Text = "OK";
//                //MessageBox.Show("Los datos se Guardaron");
//            }
//#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
//            catch (Exception e)
//#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
//            {
//                lblPre.Text = "N/A";
//                lblPre.ForeColor = Color.Red;
//            }
//            con.Close();
//        }

        public void limpiarPrecio()
        {
            cBoxTodasPrecio.Checked = false;
            cBoxVaPrecio.Checked = false;
            cBoxRePrecio.Checked = false;
            cBoxVePrecio.Checked = false;
            cBoxCoPrecio.Checked = false;
            //cBoxPre2.Checked = false;

            tbPrecio1.Text = "";
            tbPrecio2.Text = "";
        }

        public void limpiarOferta()
        {
            cBoxTodas.Checked = false;
            cBoxVa.Checked = false;
            cBoxRe.Checked = false;
            cBoxVe.Checked = false;
            cBoxCo.Checked = false;
            //cBoxPre.Checked = false;
            tbporcentaje.Text = "";
        }

        private void AplicaOferta_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }


        public string AreaTrabajo()
        {
            string area = "";

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT area from usuarios WHERE usuario ='" + Usuario + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                area = dr["area"].ToString();
            }
            dr.Close();
            con.Close();
            return area;
        }

        private void Existencias_Load_1(object sender, EventArgs e)
        {
            string area = "";
            area = AreaTrabajo();
            //#################################################### ACTUALIZACION PARA ACTIVAR  SEGUN USUARIO #####################################
            if (Area == "COMPRAS" || Area == "TRASPASOS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                panelOfertas.Enabled = true;
            }
            else
            {
                panelOfertas.Enabled = false;
            }


            if (Area == "COMPRAS" || Area == "TRASPASOS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                panelPrecio.Enabled = true;
            }
            else
            {
                panelPrecio.Enabled = false;
            }

            //CHECKSBOX DE CONEXIONES A LAS BASES DE DATOS
            CKB_Bodega.Checked = true;
            CKB_Vallarta.Checked = true;
            CKB_Rena.Checked = true;
            CKB_Coloso.Checked = true;
            CKB_Velazquez.Checked = true;
            //CKB_Pregot.Checked = true;

            //ocultar componentes
           
          
            if (area.Equals("COMPRAS") || area.Equals("ADMON GRAL") || area.Equals("SISTEMAS") || area.Equals("ENC CAJAS")||area.Equals("BODEGA") || area.Equals("GERENTE") || area.Equals("SUPER"))
            {
                //TB_costo.Visible=true;
                //LB_costo.Visible = true;
                LB_PM_bodega.Visible = true;
                LB_PM_vallarta.Visible = true;
                LB_PM_rena.Visible = true;
                LB_PM_coloso.Visible = true;
                LB_PM_velazquez.Visible = true;
                //LB_PM_pregot.Visible = true;

                LB_PME_bodega.Visible = true;
                LB_PME_vallarta.Visible = true;
                LB_PME_rena.Visible = true;
                LB_PME_velazquez.Visible = true;
                LB_PME_coloso.Visible = true;
                //LB_PME_pregot.Visible = true;

                if (area.Equals("COMPRAS") || area.Equals("ADMON GRAL") || area.Equals("SISTEMAS"))
                {
                    TB_costo.Visible = true;
                    LB_costo.Visible = true;
                    //LB_fabricante.SetBounds(17, 231, 34, 13);
                    //TB_fabricante.SetBounds(74, 217, 433, 43);

                }
                else
                {
                    TB_costo.Visible = false;
                    LB_costo.Visible = false;
                    LB_fabricante.SetBounds(17, 231, 34, 13);
                    TB_fabricante.SetBounds(74, 217, 433, 43);
                }


            }
            else
            {
                TB_costo.Visible = false;
                LB_costo.Visible = false;
                LB_fabricante.SetBounds(17, 231, 34, 13);
                TB_fabricante.SetBounds(74, 217, 433, 43);

                //if (Usuario.Equals("LILIA")&&area.Equals("BODEGA"))
                //{
                //    TB_costo.Visible = true;
                //    LB_costo.Visible = true;

                //    LB_PM_bodega.Visible = true;
                //    LB_PM_vallarta.Visible = true;
                //    LB_PM_rena.Visible = true;
                //    LB_PM_coloso.Visible = true;
                //    LB_PM_velazquez.Visible = true;
                //    LB_PM_pregot.Visible = true;

                //    LB_PME_bodega.Visible = true;
                //    LB_PME_vallarta.Visible = true;
                //    LB_PME_rena.Visible = true;
                //    LB_PME_velazquez.Visible = true;
                //    LB_PME_coloso.Visible = true;
                //    LB_PME_pregot.Visible = true;
                //}
                //else
                //{

                //    TB_costo.Visible = false;
                //    LB_costo.Visible = false;
                //    LB_fabricante.SetBounds(17, 231, 34, 13);
                //    TB_fabricante.SetBounds(74, 217, 433, 43);

                //    LB_PM_bodega.Visible = false;
                //    LB_PM_vallarta.Visible = false;
                //    LB_PM_rena.Visible = false;
                //    LB_PM_coloso.Visible = false;
                //    LB_PM_velazquez.Visible = false;
                //    LB_PM_pregot.Visible = false;

                //    LB_PME_bodega.Visible = false;
                //    LB_PME_vallarta.Visible = false;
                //    LB_PME_rena.Visible = false;
                //    LB_PME_velazquez.Visible =false;
                //    LB_PME_coloso.Visible = false;
                //    LB_PME_pregot.Visible = false;
                //}



            }

        }

        private void groupBox2_Enter_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cBoxTodas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cBoxTodas.Checked)
            {
                cBoxVa.Checked = true;
                cBoxRe.Checked = true;
                cBoxVe.Checked = true;
                cBoxCo.Checked = true;
            }
            else if (!cBoxTodas.Checked)
            {
                cBoxVa.Checked = false;
                cBoxRe.Checked = false;
                cBoxVe.Checked = false;
                cBoxCo.Checked = false;
            }

            ip = BDConexicon.optieneIp();
        }

        private void AplicaOferta_Click_1(object sender, EventArgs e)
        {
            //if (cBoxVa.Checked == false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false)
            //{
            //    MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            //}
            //if (cBoxVa.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        VallartaOferta();
            //        //MessageBox.Show("Vallarta");
            //    }

            //}
            //if (cBoxRe.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        RenaOferta();
            //        //MessageBox.Show("Rena");
            //    }
                
            //}
            //if (cBoxVe.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        VelazquezOferta();
            //        //MessageBox.Show("Velazquez");
            //    }
            //}
            //if (cBoxCo.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        ColosoOferta();
            //        //MessageBox.Show("Coloso");
            //    }
            //}
            //else
            //{
            //    limpiarOferta();
            //}

        }

        //private void cBoxTodas_CheckedChanged_2(object sender, EventArgs e)
        //{
        //    if (cBoxTodas.Checked)
        //    {
        //        cBoxVa.Checked = true;
        //        cBoxRe.Checked = true;
        //        cBoxVe.Checked = true;
        //        cBoxCo.Checked = true;
        //    }
        //    else if (!cBoxTodas.Checked)
        //    {
        //        cBoxVa.Checked = false;
        //        cBoxRe.Checked = false;
        //        cBoxVe.Checked = false;
        //        cBoxCo.Checked = false;
        //    }
        //}

        private void AplicaOferta_Click_2(object sender, EventArgs e)
        {
            if (cBoxVa.Checked == false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false)
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVa.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VallartaOferta();
                    //MessageBox.Show("Vallarta");
                }

            }
            if (cBoxRe.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    RenaOferta();
                    //MessageBox.Show("Rena");
                }

            }
            if (cBoxVe.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VelazquezOferta();
                    //MessageBox.Show("Velazquez");
                }
            }
            if (cBoxCo.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    ColosoOferta();
                    //MessageBox.Show("Coloso");
                }
            }
            else
            {
                limpiarOferta();
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblVe_Click(object sender, EventArgs e)
        {

        }

        private void borrarArticulo()
        {
            TB_articulo.Text = "";
            TB_desc.Text = "";
            TB_precio1.Text = "";
            TB_precio2.Text = "";
            TB_costo.Text = "";
            TB_fabricante.Text = "";

            TB_bodega.Text = "";
            TB_coloso.Text = "";
            TB_rena.Text = "";
            TB_vallarta.Text = "";
            TB_velazquez.Text = "";
            //TB_pregot.Text = "";

            Lb_bodega.Text = "";
            LB_rena.Text = "";
            LB_coloso.Text = "";
            LB_vallarta.Text = "";
            LB_velazquez.Text = "";
            //LB_pregot.Text = "";
        }

        private void BT_limpiar_Click(object sender, EventArgs e)
        {
            borrarArticulo();
            limpiarOferta();
            limpiarPrecio();

            lblVa.Text = "";
            lblRe.Text = "";
            lblVe.Text = "";
            lblCo.Text = "";

            lblVaPre.Text = "";
            lblRePre.Text = "";
            lblVePre.Text = "";
            lblCoPre.Text = "";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void AplicaOferta_Click_3(object sender, EventArgs e)
        {
            if (cBoxVa.Checked == false & cBoxRe.Checked == false & cBoxVe.Checked == false & cBoxCo.Checked == false )
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVa.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VallartaOferta();
                    //MessageBox.Show("Vallarta");
                }

            }
            if (cBoxRe.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    RenaOferta();
                    //MessageBox.Show("Rena");
                }

            }
            if (cBoxVe.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    VelazquezOferta();
                    //MessageBox.Show("Velazquez");
                }
            }
            if (cBoxCo.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbporcentaje.Text))
                {
                    MessageBox.Show("Inserta Porcentaje de Descuento");
                }
                else
                {
                    ColosoOferta();
                    //MessageBox.Show("Coloso");
                }
            }
            //if (cBoxPre.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbporcentaje.Text))
            //    {
            //        MessageBox.Show("Inserta Porcentaje de Descuento");
            //    }
            //    else
            //    {
            //        PregotOferta();
            //        //MessageBox.Show("Coloso");
            //    }
            //}
            else
            {
                limpiarOferta();
            }
        }

        private void aplicarPrecio_Click(object sender, EventArgs e)
        {
            // APLICACION DE PRECIO
            

            if (cBoxVaPrecio.Checked == false & cBoxRePrecio.Checked == false & cBoxVePrecio.Checked == false & cBoxCoPrecio.Checked == false & cBoxBo.Checked == false)
            {
                MessageBox.Show("Selecciona una Tienda para aplicar la Oferta");
            }
            if (cBoxVaPrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {
                    
                    VallartaPrecio();
                    //MessageBox.Show("Vallarta");
                }

            }
            if (cBoxRePrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {
                    RenaPrecio();
                    //MessageBox.Show("Rena");
                }

            }
            if (cBoxVePrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                else
                {
                    VelazquezPrecio();
                    //MessageBox.Show("Velazquez");
                }
            }
            if (cBoxCoPrecio.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                {
                    ColosoPrecio();
                    //MessageBox.Show("Coloso");
                }
            }
            //if (cBoxPre2.Checked)
            //{
            //    if (string.IsNullOrEmpty(TB_articulo.Text))
            //    {
            //        MessageBox.Show("Inserta Codigo de Articulo");

            //    }
            //    else if (string.IsNullOrEmpty(tbPrecio1.Text))
            //    {
            //        MessageBox.Show("Inserta Precio Menudeo");
            //    }
            //    else if (string.IsNullOrEmpty(tbPrecio2.Text))
            //    {
            //        MessageBox.Show("Inserta Precio Mayoreo");
            //    }
            //    {
            //        PregotPrecio();
            //        //MessageBox.Show("Coloso");
            //    }
            //}

            if (cBoxBo.Checked)
            {
                if (string.IsNullOrEmpty(TB_articulo.Text))
                {
                    MessageBox.Show("Inserta Codigo de Articulo");

                }
                else if (string.IsNullOrEmpty(tbPrecio1.Text))
                {
                    MessageBox.Show("Inserta Precio Menudeo");
                }
                else if (string.IsNullOrEmpty(tbPrecio2.Text))
                {
                    MessageBox.Show("Inserta Precio Mayoreo");
                }
                {
                    BodegaPrecio();
                    //PregotPrecio();
                    //MessageBox.Show("Coloso");
                }
            }

            limpiarPrecio();
            
        }

        //#############################################################################################################################
        public void VallartaPrecio()
        {

            MySqlConnection con = BDConexicon.VallartaOpen();
            try
            {

                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo",con );
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();
              

                lblVaPre.Text = "OK";
                lblVaPre.ForeColor = Color.DarkGreen;
                
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                lblVaPre.Text = "N/A";
                lblVaPre.ForeColor = Color.Red;
            }
            BDConexicon.VallartaClose();
        }

        

        private void RenaPrecio()
        {

            MySqlConnection con = BDConexicon.RenaOpen();
            try
            {

                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo",con);
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblRePre.Text = "OK";
                lblRePre.ForeColor = Color.DarkGreen;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                lblRePre.Text = "N/A";
                lblRePre.ForeColor = Color.Red;
            }
            BDConexicon.RenaClose();
        }

        private void VelazquezPrecio()
        {

           MySqlConnection con = BDConexicon.VelazquezOpen();
            try
            {

                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo",con);
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblVePre.Text = "OK";
                lblVePre.ForeColor = Color.DarkGreen;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                lblVePre.Text = "N/A";
                lblVePre.ForeColor = Color.Red;
            }
            BDConexicon.VelazquezClose();
        }

        private void ColosoPrecio()
        {


            MySqlConnection con = null;
            try
            {
                 con= BDConexicon.ColosoOpen();
                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo",con );
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                lblCoPre.Text = "OK";
                lblCoPre.ForeColor = Color.DarkGreen;
                con.Close();
            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                lblCoPre.Text = "N/A";
                lblCoPre.ForeColor = Color.Red;
            }
           
        }


//        public void PregotPrecio()
//        {

//            MySqlConnection con=null;            
                
//            try
//            {
//               con = BDConexicon.Papeleria1Open();
//                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
//                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
//                Precio1 = Precio1 / 1.16;
//                Precio2 = Precio2 / 1.16;


//                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", con);
//                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
//                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
//                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
//                MySqlDataReader mdrr;
//                mdrr = cmdoo.ExecuteReader();
//                mdrr.Close();


//                lblPre2.Text = "OK";
//                lblPre2.ForeColor = Color.DarkGreen;

//            }
//#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
//            catch (Exception e)
//#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
//            {
//                lblPre2.Text = "N/A";
//                lblPre2.ForeColor = Color.Red;
//            }
//            con.Close();
//        }


        private void BodegaPrecio()
        {

            MySqlConnection con = BDConexicon.BodegaOpen();
            try
            {

                double Precio1 = Convert.ToDouble(tbPrecio1.Text);
                double Precio2 = Convert.ToDouble(tbPrecio2.Text);
                Precio1 = Precio1 / 1.16;
                Precio2 = Precio2 / 1.16;


                MySqlCommand cmdoo = new MySqlCommand("UPDATE prods SET precio1=?precio1,precio2=?precio2  WHERE articulo=?articulo", con);
                cmdoo.Parameters.Add("?precio1", MySqlDbType.VarChar).Value = Precio1;
                cmdoo.Parameters.Add("?precio2", MySqlDbType.VarChar).Value = Precio2;
                cmdoo.Parameters.Add("?articulo", MySqlDbType.VarChar).Value = TB_articulo.Text;
                MySqlDataReader mdrr;
                mdrr = cmdoo.ExecuteReader();
                mdrr.Close();


                LBBoPre.Text = "OK";
                LBBoPre.ForeColor = Color.DarkGreen;

            }
#pragma warning disable CS0168 // La variable 'e' se ha declarado pero nunca se usa
            catch (Exception e)
#pragma warning restore CS0168 // La variable 'e' se ha declarado pero nunca se usa
            {
                LBBoPre.Text = "N/A";
                LBBoPre.ForeColor = Color.Red;
            }
            con.Close();
        }



        private void cBoxTodasPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxTodasPrecio.Checked)
            {
                cBoxVaPrecio.Checked = true;
                cBoxRePrecio.Checked = true;
                cBoxVePrecio.Checked = true;
                cBoxCoPrecio.Checked = true;
                //cBoxPre2.Checked = true;
                cBoxBo.Checked = true;
            }
            else if (!cBoxTodasPrecio.Checked)
            {
                cBoxVaPrecio.Checked = false;
                cBoxRePrecio.Checked = false;
                cBoxVePrecio.Checked = false;
                cBoxCoPrecio.Checked = false;
                //cBoxPre2.Checked = false;
                cBoxBo.Checked = false;
            }
        }

        private void cBoxTodas_CheckedChanged_3(object sender, EventArgs e)
        {
            if (cBoxTodas.Checked)
            {
                cBoxVa.Checked = true;
                cBoxRe.Checked = true;
                cBoxVe.Checked = true;
                cBoxCo.Checked = true;
                //cBoxPre.Checked = true;
            }
            else if (!cBoxTodas.Checked)
            {
                cBoxVa.Checked = false;
                cBoxRe.Checked = false;
                cBoxVe.Checked = false;
                cBoxCo.Checked = false;
                //cBoxPre.Checked = false;

            }
        }

        private void BT_limpiar_Click_1(object sender, EventArgs e)
        {
            borrarArticulo();
            limpiarOferta();
            limpiarPrecio();

            lblVa.Text = "";
            lblRe.Text = "";
            lblVe.Text = "";
            lblCo.Text = "";
            //lblPre.Text = "";

            lblVaPre.Text = "";
            lblRePre.Text = "";
            lblVePre.Text = "";
            lblCoPre.Text = "";
            //lblPre2.Text = "";
            LBBoPre.Text = "";

            LB_prov_bodega.Text = "";
            LB_prov_coloso.Text = "";
            //LB_prov_pregot.Text = "";
            LB_prov_rena.Text = "";
            LB_prov_vallarta.Text = "";
            LB_prov_velazquez.Text = "";

            LB_bo_linea.Text = "";
            LB_va_linea.Text = "";
            LB_re_linea.Text = "";
            LB_ve_linea.Text = "";
            LB_co_linea.Text = "";
            //LB_pre_linea.Text = "";
        }

        private void TB_articulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TB_articulo.Text.Equals(""))
                {
                    MessageBox.Show("Ingresa un artículo");
                }
                else
                {


                    lblVa.Text = "";
                    lblRe.Text = "";
                    lblVe.Text = "";
                    lblCo.Text = "";
                    //lblPre.Text = "";

                    lblVaPre.Text = "";
                    lblRePre.Text = "";
                    lblVePre.Text = "";
                    lblCoPre.Text = "";
                    //lblPre2.Text = "";
                    LBBoPre.Text = "";

                    DatosProducto();
                    if (CKB_Bodega.Checked == true)
                    {
                        Bodega();
                    }

                    if (CKB_Vallarta.Checked == true)
                    {
                        Vallarta();
                    }

                    if (CKB_Rena.Checked == true)
                    {
                        Rena();
                    }

                    if (CKB_Velazquez.Checked == true)
                    {
                        Velazquez();
                    }

                    if (CKB_Coloso.Checked == true)
                    {
                        Coloso();
                    }

                    //if (CKB_Pregot.Checked == true)
                    //{
                    //    Pregot();
                    //}
                  


                }
            }

            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                borrarArticulo();
                limpiarOferta();
                limpiarPrecio();

                lblVa.Text = "";
                lblRe.Text = "";
                lblVe.Text = "";
                lblCo.Text = "";
                //lblPre.Text = "";

                lblVaPre.Text = "";
                lblRePre.Text = "";
                lblVePre.Text = "";
                lblCoPre.Text = "";
                //lblPre2.Text = "";
                LBBoPre.Text = "";


                LB_prov_bodega.Text = "";
                LB_prov_coloso.Text = "";
                //LB_prov_pregot.Text = "";
                LB_prov_rena.Text = "";
                LB_prov_vallarta.Text = "";
                LB_prov_velazquez.Text = "";

                LB_bo_linea.Text = "";
                LB_va_linea.Text = "";
                LB_re_linea.Text = "";
                LB_ve_linea.Text = "";
                LB_co_linea.Text = "";
                //LB_pre_linea.Text = "";

                TB_articulo.Focus();
                TB_articulo.SelectAll();
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void panelOfertas_Enter(object sender, EventArgs e)
        {

        }

        private void panelPrecio_Enter(object sender, EventArgs e)
        {

        }
    }
}
