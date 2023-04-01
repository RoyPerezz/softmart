using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;


namespace appSugerencias
{
    public partial class frm_Surtidor : Form
    {
        string UsuarioMyB;

        public frm_Surtidor()
        {
            InitializeComponent();
        }

        public frm_Surtidor(string usuario)
        {
            InitializeComponent();
            
            UsuarioMyB = usuario;
        }
        
        
        DateTime fecha=DateTime.Now;
        MySqlConnection Conex;
        int ColumnaSurtir=6;
        int exisVa=7, exisRe=9, exisCo=11, exisVl=13,exisPm=15;
        int surteVa = 8, surteRe = 10, surteCo = 12, surteVl = 14, surtePm = 16;
        bool verificar;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conex = BDConexicon.BodegaOpen();
                busqueda();
                Conex.Close();

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Sin conexion a Bodega");
            }

            try
            {
                Conex = BDConexicon.VallartaOpen();
                busqueda2();
                Conex.Close();
                //btnVa.Enabled = true;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch(Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                noEnLinea(surteVa);

            }


            

            try
            {
                Conex = BDConexicon.RenaOpen();
                busqueda3();
                Conex.Close();
                //btnRe.Enabled = true;

            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                noEnLinea(surteRe);
            }

            

            try
            {
                Conex = BDConexicon.ColosoOpen();
                busqueda4();
                Conex.Close();
                //btnCo.Enabled = true;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                noEnLinea(surteCo);
            }

            

            try
            {
                Conex = BDConexicon.VelazquezOpen();
                busqueda5();
                Conex.Close();
                //btnVe.Enabled = true;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                noEnLinea(surteVl);
            }

            

            try
            {
                Conex = BDConexicon.Papeleria1Open();
                busqueda6();
                Conex.Close();
                //btnPm.Enabled = true;
            }
#pragma warning disable CS0168 // La variable 'er' se ha declarado pero nunca se usa
            catch (Exception er)
#pragma warning restore CS0168 // La variable 'er' se ha declarado pero nunca se usa
            {
                noEnLinea(surtePm);
            }




            btnValidar.BackColor = Color.DodgerBlue;
            //btnVa.BackColor = Color.DodgerBlue;
            //btnRe.BackColor = Color.DodgerBlue;
            //btnCo.BackColor = Color.DodgerBlue;
            //btnVe.BackColor = Color.DodgerBlue;
            //btnPm.BackColor = Color.DodgerBlue;
        }


        public void noEnLinea(int columna)
        {
            int nItems = dgvSurtidor.Rows.Count;
            for (int i = 0; i < nItems; i++)
            {
                dgvSurtidor.Rows[i].Cells[columna].Value = "NO";
            }
        }

        public void busqueda()
        {
            string comando = "SELECT ARTICULO,DESCRIP,EXISTENCIA,Peso FROM prods WHERE EXISTENCIA >0 AND LINEA='"+cbLinea.SelectedValue.ToString()+"'";

            MySqlCommand cmd = new MySqlCommand(comando, Conex);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();



            adapter.Fill(dt);

            dgvSurtidor.Rows.Clear();

            foreach(DataRow item in dt.Rows)
            {
                int n = dgvSurtidor.Rows.Add();
                dgvSurtidor.Rows[n].Cells[0].Value = n+1;
                dgvSurtidor.Rows[n].Cells[1].Value = item["ARTICULO"].ToString();
                dgvSurtidor.Rows[n].Cells[2].Value = item["DESCRIP"].ToString();
                dgvSurtidor.Rows[n].Cells[3].Value = item["EXISTENCIA"].ToString();
                dgvSurtidor.Rows[n].Cells[4].Value = item["Peso"].ToString();
                if (Convert.ToInt32(item["Peso"].ToString())==0)
                {
                    dgvSurtidor.Rows[n].Cells[5].Value = "N/A";
                }
                else
                {
                    dgvSurtidor.Rows[n].Cells[5].Value = Convert.ToDouble(item["EXISTENCIA"].ToString()) / Convert.ToDouble(item["Peso"].ToString());
                }
                
            }

            

        }

        public void busqueda2()
        {
#pragma warning disable CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            string comando = "SELECT EXISTENCIA FROM prods WHERE ARTICULO=?ARTICULO";
#pragma warning restore CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            double bulto, existenciaTienda;
            List<int> ExisVallarta = new List<int>();
            
            int i,nItems;
            nItems = dgvSurtidor.Rows.Count;
            
            for (i = 0; i < nItems; i++)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT EXISTENCIA FROM prods WHERE ARTICULO='"+ dgvSurtidor.Rows[i].Cells[1].Value.ToString()+"'", Conex);

                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {

             
                    ExisVallarta.Add(Convert.ToInt32(mdr["EXISTENCIA"].ToString()));
                    

                }
                else
                {
                    ExisVallarta.Add(0);
                }
                
                mdr.Close();
            }

            for (i = 0; i < nItems; i++)
            {

                dgvSurtidor.Rows[i].Cells[exisVa].Value = ExisVallarta[i];
                bulto = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[4].Value.ToString());
                existenciaTienda = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[exisVa].Value.ToString());

                if (existenciaTienda <= (bulto / 2))
                {

                    dgvSurtidor.Rows[i].Cells[surteVa].Value = dgvSurtidor.Rows[i].Cells[4].Value.ToString();

                    if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surteVa].Value.ToString()) < Convert.ToDouble(dgvSurtidor.Rows[i].Cells[3].Value.ToString()))
                    {
                        dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value = true;
                    }
                    else
                    {
                        dgvSurtidor.Rows[i].Cells[surteVa].Value = "NO";

                    }
                        
                }
                else
                {
                    dgvSurtidor.Rows[i].Cells[surteVa].Value = "NO";

                }

            }

        }

        public void busqueda3()
        {
#pragma warning disable CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            string comando = "SELECT EXISTENCIA FROM prods WHERE ARTICULO=?ARTICULO";
#pragma warning restore CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            double bulto, existenciaTienda;
            List<int> ExisRena = new List<int>();

            int i, nItems;
            nItems = dgvSurtidor.Rows.Count;

            for (i = 0; i < nItems; i++)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT EXISTENCIA FROM prods WHERE ARTICULO='" + dgvSurtidor.Rows[i].Cells[1].Value.ToString() + "'", Conex);

                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {

                    ExisRena.Add(Convert.ToInt32(mdr["EXISTENCIA"].ToString()));


                }
                else
                {
                    ExisRena.Add(0);
                }

                mdr.Close();
            }

            for (i = 0; i < nItems; i++)
            {

                dgvSurtidor.Rows[i].Cells[exisRe].Value = ExisRena[i];
                bulto = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[4].Value.ToString());
                existenciaTienda = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[exisRe].Value.ToString());

                if (existenciaTienda <= (bulto / 2))
                {
                    dgvSurtidor.Rows[i].Cells[surteRe].Value = dgvSurtidor.Rows[i].Cells[4].Value.ToString();
                    if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surteRe].Value.ToString()) < Convert.ToDouble(dgvSurtidor.Rows[i].Cells[3].Value.ToString()))
                    {
                        dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value = true;
                    }
                    else
                    {
                        dgvSurtidor.Rows[i].Cells[surteRe].Value = "NO";

                    }
                }
                else
                {
                    dgvSurtidor.Rows[i].Cells[surteRe].Value = "NO";

                }

            }
  
        }


        public void busqueda4()
        {
#pragma warning disable CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            string comando = "SELECT EXISTENCIA FROM prods WHERE ARTICULO=?ARTICULO";
#pragma warning restore CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            double bulto, existenciaTienda;
            List<int> ExisColoso = new List<int>();

            int i, nItems;
            nItems = dgvSurtidor.Rows.Count;

            for (i = 0; i < nItems ; i++)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT EXISTENCIA FROM prods WHERE ARTICULO='" + dgvSurtidor.Rows[i].Cells[1].Value.ToString() + "'", Conex);

                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {

                    ExisColoso.Add(Convert.ToInt32(mdr["EXISTENCIA"].ToString()));


                }
                else
                {
                    ExisColoso.Add(0);
                }

                mdr.Close();
            }

            for (i = 0; i < nItems; i++)
            {

                dgvSurtidor.Rows[i].Cells[exisCo].Value = ExisColoso[i];
                bulto = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[4].Value.ToString());
                existenciaTienda = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[exisCo].Value.ToString());

                if (existenciaTienda <= (bulto / 2))
                {
                    dgvSurtidor.Rows[i].Cells[surteCo].Value = dgvSurtidor.Rows[i].Cells[4].Value.ToString();
                    if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surteCo].Value.ToString()) < Convert.ToDouble(dgvSurtidor.Rows[i].Cells[3].Value.ToString()))
                    {
                        dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value = true;
                    }
                    else
                    {
                        dgvSurtidor.Rows[i].Cells[surteCo].Value = "NO";

                    }
                }
                else
                {
                    dgvSurtidor.Rows[i].Cells[surteCo].Value = "NO";

                }

            }
       

            
        }

        public void busqueda5()
        {
#pragma warning disable CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            string comando = "SELECT EXISTENCIA FROM prods WHERE ARTICULO=?ARTICULO";
#pragma warning restore CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            double bulto, existenciaTienda;
            List<int> ExisVelaz = new List<int>();

            int i, nItems;
            nItems = dgvSurtidor.Rows.Count;

            for (i = 0; i < nItems; i++)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT EXISTENCIA FROM prods WHERE ARTICULO='" + dgvSurtidor.Rows[i].Cells[1].Value.ToString() + "'", Conex);

                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {

                   
                    ExisVelaz.Add(Convert.ToInt32(mdr["EXISTENCIA"].ToString()));

          
                }
                else
                {
                    ExisVelaz.Add(0);
                }

                mdr.Close();
            }

            for (i = 0; i < nItems ; i++)
            {

                dgvSurtidor.Rows[i].Cells[exisVl].Value = ExisVelaz[i];
                bulto = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[4].Value.ToString());
                existenciaTienda = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[exisVl].Value.ToString());

                if (existenciaTienda <= (bulto / 2))
                {
                    dgvSurtidor.Rows[i].Cells[surteVl].Value = dgvSurtidor.Rows[i].Cells[4].Value.ToString();
                    if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surteVl].Value.ToString()) < Convert.ToDouble(dgvSurtidor.Rows[i].Cells[3].Value.ToString()))
                    {
                        dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value = true;
                    }
                    else
                    {
                        dgvSurtidor.Rows[i].Cells[surteVl].Value = "NO";

                    }
                }
                else
                {
                    dgvSurtidor.Rows[i].Cells[surteVl].Value = "NO";

                }

            }
         


        }

        public void busqueda6()
        {
#pragma warning disable CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            string comando = "SELECT EXISTENCIA FROM prods WHERE ARTICULO=?ARTICULO";
#pragma warning restore CS0219 // La variable 'comando' está asignada pero su valor nunca se usa
            double bulto, existenciaTienda;
            List<int> ExisPm = new List<int>();

            int i, nItems;
            nItems = dgvSurtidor.Rows.Count;

            for (i = 0; i < nItems; i++)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT EXISTENCIA FROM prods WHERE ARTICULO='" + dgvSurtidor.Rows[i].Cells[1].Value.ToString() + "'", Conex);

                MySqlDataReader mdr;
                mdr = cmd.ExecuteReader();

                if (mdr.Read())
                {

                    
                    ExisPm.Add(Convert.ToInt32(mdr["EXISTENCIA"].ToString()));

                    
                }
                else
                {
                    ExisPm.Add(0);
                }

                mdr.Close();
            }

            for (i = 0; i < nItems; i++)
            {

                dgvSurtidor.Rows[i].Cells[exisPm].Value = ExisPm[i];
                bulto = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[4].Value.ToString());
                existenciaTienda = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[exisPm].Value.ToString());

                if (existenciaTienda <= (bulto / 2))
                {
                    dgvSurtidor.Rows[i].Cells[surtePm].Value = dgvSurtidor.Rows[i].Cells[4].Value.ToString();
                    if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surtePm].Value.ToString()) < Convert.ToDouble(dgvSurtidor.Rows[i].Cells[3].Value.ToString()))
                    {
                        dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value = true;
                    }
                    else
                    {
                        dgvSurtidor.Rows[i].Cells[surtePm].Value = "NO";

                    }
                }
                else
                {
                    dgvSurtidor.Rows[i].Cells[surtePm].Value = "NO";

                }

            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificaSurtidor();
        }

        private void frm_Surtidor_Load(object sender, EventArgs e)
        {
            try
            {
                Conex = BDConexicon.BodegaOpen();
                llenaComboLinea();
                eliminar();
                Conex.Close();

            }
            catch(Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
            
        }

        public void eliminar()
        {
            MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE rd_surtidor", Conex);
            cmd.ExecuteNonQuery();
        }

        public void llenaComboLinea()
        {
            cbLinea.DataSource = null;


            MySqlCommand cmd = new MySqlCommand("SELECT * FROM lineas", Conex);
            MySqlDataAdapter mysqladap = new MySqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();

            mysqladap.Fill(dt1);

            cbLinea.ValueMember = "Linea";
            cbLinea.DisplayMember = "Descrip";
            cbLinea.DataSource = dt1;
            
        }

        private void dgvSutidor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string id;
            //verificar = VerificaSurtidor();
            //if (verificar)
            //{
            //    Conex = BDConexicon.BodegaOpen();
            //    id = guardarTraspaso("VA", lblMotivo.Text.ToUpper(), surteVa);
            //    Conex.Close();
            //    CrearPDF(id, "VA", lblMotivo.Text.ToUpper(), surteVl);
            //    btnVa.BackColor = Color.DarkGreen;
            //}


        }

    
        private void colorFila(DataGridView datagrid)
        {
            foreach (DataGridViewRow row in datagrid.Rows)
            {
               
                if (Convert.ToBoolean(datagrid.Rows[row.Index].Cells[ColumnaSurtir].Value) == true)
                {

                    row.DefaultCellStyle.BackColor = Color.LightBlue;

                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //string id;
            //verificar = VerificaSurtidor();
            //if (verificar)
            //{
            //    Conex = BDConexicon.BodegaOpen();
            //    id=guardarTraspaso("RE", lblMotivo.Text.ToUpper(), surteRe);
            //    Conex.Close();
            //    CrearPDF(id, "RE", lblMotivo.Text.ToUpper(), surteVl);
            //    btnRe.BackColor = Color.DarkGreen;
            //}

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //lblMotivo.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string id;
            //verificar = VerificaSurtidor();
            //if (verificar)
            //{
            //    Conex = BDConexicon.BodegaOpen();
            //    id=guardarTraspaso("CO", lblMotivo.Text.ToUpper(), surteCo);
            //    Conex.Close();
            //    CrearPDF(id, "CO", lblMotivo.Text.ToUpper(), surteVl);
            //    btnCo.BackColor = Color.DarkGreen;
            //}

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string id;
            //verificar = VerificaSurtidor();
            //if (verificar)
            //{
            //    Conex = BDConexicon.BodegaOpen();
            //    id=guardarTraspaso("VL", lblMotivo.Text.ToUpper(), surteVl);
            //    Conex.Close();
            //    CrearPDF(id,"VL",lblMotivo.Text.ToUpper(),surteVl);
            //    btnVe.BackColor = Color.DarkGreen;
            //}

        }

        private void dgvSutidor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            colorFila(dgvSurtidor);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CrearPDF("1","VA","",surteVa);
        }



        private void dgvSutidor_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dgvSurtidor.Rows.Count == 0)
            {
                MessageBox.Show("No hay Datos");
            }
            else
            {
                verificar = VerificaSurtidor();
                if (verificar)
                {
                    try
                    {
                        Conex = BDConexicon.BodegaOpen();
                        guardarLineasSurtidor();
                        Conex.Close();
                        MessageBox.Show("Datos Agregados");
                        dgvSurtidor.Rows.Clear();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Error: " + er.Message);
                    }
                }

            }
            
        }

        private void dgvSutidor_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_surtidor_listado);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_surtidor_listado(UsuarioMyB);
            frm.Show();
        }

        private void btnPm_Click(object sender, EventArgs e)
        {
            //string id;
            //verificar = VerificaSurtidor();
            //if (verificar)
            //{
            //    Conex = BDConexicon.BodegaOpen();
            //    id = guardarTraspaso("PM", lblMotivo.Text.ToUpper(), surtePm);
            //    Conex.Close();
            //    CrearPDF(id, "PM", lblMotivo.Text.ToUpper(), surtePm);
            //    btnPm.BackColor = Color.DarkGreen;
            //}
        }

        private void dgvSutidor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(this.dgvSurtidor.Columns[e.ColumnIndex].Name== "EXIS_VA")
            {
                e.CellStyle.BackColor = Color.Gainsboro;
            }

            if (this.dgvSurtidor.Columns[e.ColumnIndex].Name == "EXIS_RE")
            {
                e.CellStyle.BackColor = Color.Gainsboro;
            }

            if (this.dgvSurtidor.Columns[e.ColumnIndex].Name == "EXIS_CO")
            {
                e.CellStyle.BackColor = Color.Gainsboro;
            }

            if (this.dgvSurtidor.Columns[e.ColumnIndex].Name == "EXIS_VL")
            {
                e.CellStyle.BackColor = Color.Gainsboro;
            }

            if (this.dgvSurtidor.Columns[e.ColumnIndex].Name == "EXIS_PM")
            {
                e.CellStyle.BackColor = Color.Gainsboro;
            }
        }


        public bool VerificaSurtidor()
        {
            double exisBodega,surtirVa,surtirRe,surtirCo,surtirVl,surtirPm,surtirTotal;
#pragma warning disable CS0168 // La variable 'flagVa' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'flagVl' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'flagCo' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'flagRe' se ha declarado pero nunca se usa
            bool flag, flagVa,flagRe,flagCo,flagVl;
#pragma warning restore CS0168 // La variable 'flagRe' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'flagCo' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'flagVl' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'flagVa' se ha declarado pero nunca se usa
            flag = true;
            int i;
            for(i=0; i < dgvSurtidor.Rows.Count; i++)
            {



                if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                {

                    exisBodega = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[3].Value.ToString());
                    //VALLARTA BLOQUE

                    if (dgvSurtidor.Rows[i].Cells[surteVa].Value.ToString() != "NO")
                    {

                        try
                        {
                            surtirVa = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surteVa].Value.ToString());
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Error en la celda: " + er.Message);

                            dgvSurtidor.Rows[i].Cells[surteVa].Style.BackColor = Color.Salmon;
                            btnValidar.BackColor = Color.Salmon;
                            flag = false;
                            break;
                        }


                    }
                    else
                    {
                        surtirVa = 0;
                    }



                    //RENA BLOQUE

                    if (dgvSurtidor.Rows[i].Cells[surteRe].Value.ToString() != "NO")
                    {


                        try
                        {
                            surtirRe = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surteRe].Value.ToString());
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Error en la celda: " + er.Message);

                            dgvSurtidor.Rows[i].Cells[surteRe].Style.BackColor = Color.Salmon;
                            btnValidar.BackColor = Color.Salmon;
                            flag = false;
                            break;
                        }

                    }
                    else
                    {
                        surtirRe = 0;
                    }



                    //Bloque coloso
                    if (dgvSurtidor.Rows[i].Cells[surteCo].Value.ToString() != "NO")
                    {


                        try
                        {
                            surtirCo = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surteCo].Value.ToString());

                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Error en la celda: " + er.Message);

                            dgvSurtidor.Rows[i].Cells[surteCo].Style.BackColor = Color.Salmon;
                            btnValidar.BackColor = Color.Salmon;
                            flag = false;
                            break;

                        }


                    }
                    else
                    {
                        surtirCo = 0;
                    }




                    //VELAZQUEZ BLOQUE

                    if (dgvSurtidor.Rows[i].Cells[surteVl].Value.ToString() != "NO")
                    {


                        try
                        {
                            surtirVl = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surteVl].Value.ToString());

                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Error en la celda: " + er.Message);

                            dgvSurtidor.Rows[i].Cells[surteVl].Style.BackColor = Color.Salmon;
                            btnValidar.BackColor = Color.Salmon;
                            flag = false;
                            break;

                        }
                    }
                    else
                    {
                        surtirVl = 0;
                    }



                    //PREGOT BLOQUE

                    if (dgvSurtidor.Rows[i].Cells[surtePm].Value.ToString() != "NO")
                    {


                        try
                        {
                            surtirPm = Convert.ToDouble(dgvSurtidor.Rows[i].Cells[surtePm].Value.ToString());

                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Error en la celda: " + er.Message);

                            dgvSurtidor.Rows[i].Cells[surtePm].Style.BackColor = Color.Salmon;
                            btnValidar.BackColor = Color.Salmon;
                            flag = false;
                            break;

                        }


                    }
                    else
                    {
                        surtirPm = 0;
                    }






                    surtirTotal = 0;
                    surtirTotal = surtirVa + surtirRe + surtirCo + surtirVl + surtirPm;

                    if (surtirTotal > exisBodega)
                    {

                        dgvSurtidor.Rows[i].Cells[surteVa].Style.BackColor = Color.Salmon;

                        dgvSurtidor.Rows[i].Cells[surteRe].Style.BackColor = Color.Salmon;
                        dgvSurtidor.Rows[i].Cells[surteCo].Style.BackColor = Color.Salmon;
                        dgvSurtidor.Rows[i].Cells[surteVl].Style.BackColor = Color.Salmon;
                        dgvSurtidor.Rows[i].Cells[surtePm].Style.BackColor = Color.Salmon;

                        flag = false;
                    }
                    else
                    {

                        dgvSurtidor.Rows[i].Cells[surteVa].Style.BackColor = Color.White;
                        dgvSurtidor.Rows[i].Cells[surteRe].Style.BackColor = Color.White;
                        dgvSurtidor.Rows[i].Cells[surteCo].Style.BackColor = Color.White;
                        dgvSurtidor.Rows[i].Cells[surteVl].Style.BackColor = Color.White;
                        dgvSurtidor.Rows[i].Cells[surtePm].Style.BackColor = Color.White;

                    }

                    if (flag)
                    {
                        btnValidar.BackColor = Color.DarkGreen;
                    }
                    else
                    {
                        btnValidar.BackColor = Color.Salmon;
                    }



                }
            }//for
            return flag;
        }

        public void VerificaSurtidor2()
        {
#pragma warning disable CS0168 // La variable 'surtirRe' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'surtirTotal' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'exisBodega' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'surtirVa' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'surtirPm' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'surtirVl' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'surtirCo' se ha declarado pero nunca se usa
            double exisBodega, surtirVa, surtirRe, surtirCo, surtirVl, surtirPm, surtirTotal;
#pragma warning restore CS0168 // La variable 'surtirCo' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'surtirVl' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'surtirPm' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'surtirVa' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'exisBodega' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'surtirTotal' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'surtirRe' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'flagCo' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'flagVa' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'flagRe' se ha declarado pero nunca se usa
#pragma warning disable CS0168 // La variable 'flagVl' se ha declarado pero nunca se usa
            bool flagVa, flagRe, flagCo, flagVl;
#pragma warning restore CS0168 // La variable 'flagVl' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'flagRe' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'flagVa' se ha declarado pero nunca se usa
#pragma warning restore CS0168 // La variable 'flagCo' se ha declarado pero nunca se usa

            for (int i = 0; i < dgvSurtidor.Rows.Count-1; i++)
            {



                if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                {

                    //exisBodega = Convert.ToDouble(dgvSutidor.Rows[i].Cells[3].Value.ToString());
                    //VALLARTA BLOQUE
                    if (dgvSurtidor.Rows[i].Cells[7].Value.ToString() != "NO")
                    {
                        if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[7].Value) > Convert.ToDouble(dgvSurtidor.Rows[i].Cells[3].Value))
                        {
                            dgvSurtidor.Rows[i].Cells[7].Style.BackColor = Color.Salmon;
                        }
                        //surtirVa = Convert.ToDouble(dgvSutidor.Rows[i].Cells[7].Value.ToString());
                    }

                }
            }

        }

        public void guardarLineasSurtidor()
        {
            //bloque de codigo para guardar los productos por linea que se surtiran a cada tienda
            int ColumnaTienda;

            MySqlCommand cmd2 = new MySqlCommand("insert into rd_surtidor(destino,articulo,descripcion,cantidad) values(?destino,?articulo,?descripcion,?cantidad)", Conex);

            //======================================================== Guardar Datos de Vallarta===========================================================//
            ColumnaTienda = surteVa;
            for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
            {



                if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                {


                    //VALLARTA BLOQUE
                    if (dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString() != "NO")
                    {
                        if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString()) > 0)
                        {
                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("?destino", "VA");
                            cmd2.Parameters.AddWithValue("?articulo", dgvSurtidor.Rows[i].Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("?descripcion", dgvSurtidor.Rows[i].Cells[2].Value.ToString());
                            cmd2.Parameters.AddWithValue("?cantidad", dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString());
                            
                            cmd2.ExecuteNonQuery();

                        }

                    }

                }
            }

            //======================================================== Guardar Datos de Rena ===========================================================//
            ColumnaTienda = surteRe;
            for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
            {



                if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                {


                    //VALLARTA BLOQUE
                    if (dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString() != "NO")
                    {
                        if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString()) > 0)
                        {
                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("?destino", "RE");
                            cmd2.Parameters.AddWithValue("?articulo", dgvSurtidor.Rows[i].Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("?descripcion", dgvSurtidor.Rows[i].Cells[2].Value.ToString());
                            cmd2.Parameters.AddWithValue("?cantidad", dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString());

                            cmd2.ExecuteNonQuery();

                        }

                    }

                }
            }
            //======================================================== Guardar Datos de Coloso ===========================================================//
            ColumnaTienda = surteCo;
            for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
            {



                if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                {


                    //VALLARTA BLOQUE
                    if (dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString() != "NO")
                    {
                        if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString()) > 0)
                        {
                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("?destino", "CO");
                            cmd2.Parameters.AddWithValue("?articulo", dgvSurtidor.Rows[i].Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("?descripcion", dgvSurtidor.Rows[i].Cells[2].Value.ToString());
                            cmd2.Parameters.AddWithValue("?cantidad", dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString());

                            cmd2.ExecuteNonQuery();

                        }

                    }

                }
            }

            //======================================================== Guardar Datos de Velazquez ===========================================================//
            ColumnaTienda = surteVl;
            for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
            {



                if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                {


                    //VALLARTA BLOQUE
                    if (dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString() != "NO")
                    {
                        if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString()) > 0)
                        {
                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("?destino", "VE");
                            cmd2.Parameters.AddWithValue("?articulo", dgvSurtidor.Rows[i].Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("?descripcion", dgvSurtidor.Rows[i].Cells[2].Value.ToString());
                            cmd2.Parameters.AddWithValue("?cantidad", dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString());

                            cmd2.ExecuteNonQuery();

                        }

                    }

                }
            }

            //======================================================== Guardar Datos de Pregot ===========================================================//
            ColumnaTienda = surtePm;
            for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
            {



                if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                {


                    //VALLARTA BLOQUE
                    if (dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString() != "NO")
                    {
                        if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString()) > 0)
                        {
                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("?destino", "PREGOT");
                            cmd2.Parameters.AddWithValue("?articulo", dgvSurtidor.Rows[i].Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("?descripcion", dgvSurtidor.Rows[i].Cells[2].Value.ToString());
                            cmd2.Parameters.AddWithValue("?cantidad", dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString());

                            cmd2.ExecuteNonQuery();

                        }

                    }

                }
            }


        }

        public string guardarTraspaso(string destino, string motivo, int ColumnaTienda)
        {
            //CABECERA DE LA SOLICITUD
            string idSolicitud;
            MySqlCommand cmd = new MySqlCommand("insert into rd_traspaso(fecha, usuario, origen, destino, estatus, motivo) values(?fecha, ?usuario, ?origen, ?destino, ?status, ?motivo)", Conex);
    
            cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy,MM,dd"));
            cmd.Parameters.AddWithValue("?usuario", UsuarioMyB);
            cmd.Parameters.AddWithValue("?origen", "BO");
            cmd.Parameters.AddWithValue("?destino", destino);
            cmd.Parameters.AddWithValue("?status", "SOLICITADO");
            cmd.Parameters.AddWithValue("?motivo", motivo);
            cmd.ExecuteNonQuery();
            idSolicitud = cmd.LastInsertedId.ToString();



            MySqlCommand cmd2 = new MySqlCommand("insert into rd_traspaso_articulos(fk_idtraspaso,articulo,descripcion,cantidad) values(?fk_idtraspaso,?articulo,?descripcion,?cantidad)", Conex);


            for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
            {



                if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                {


                    //VALLARTA BLOQUE
                    if (dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString() != "NO")
                    {
                        if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString()) > 0)
                        {
                            cmd2.Parameters.Clear();
                            cmd2.Parameters.AddWithValue("?fk_idtraspaso", idSolicitud);
                            cmd2.Parameters.AddWithValue("?articulo", dgvSurtidor.Rows[i].Cells[1].Value.ToString());
                            cmd2.Parameters.AddWithValue("?descripcion", dgvSurtidor.Rows[i].Cells[2].Value.ToString());
                            cmd2.Parameters.AddWithValue("?cantidad", dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString());
                            cmd2.ExecuteNonQuery();

                        }
                       
                    }

                }
            }
            return idSolicitud;
        }

        public void CrearPDF(string id, string des,string mot,int ColumnaTienda)
        {
            
            string origen = "CEDIS";
            string destino = des;
            string motivo = mot;
            string idtraspaso=id;




            try
            {



                if (destino.Equals("VA"))
                {
                    destino = "VALLARTA";
                }

                if (destino.Equals("VL"))
                {
                    destino = "VELAZQUEZ";
                }

                if (destino.Equals("CO"))
                {
                    destino = "COLOSO";
                }

                if (destino.Equals("BO"))
                {
                    destino = "BODEGA";
                }

                if (destino.Equals("RE"))
                {
                    destino = "RENA";
                }
                if (destino.Equals("PM"))
                {
                    destino = "PREGOT";
                }

                Document doc = new Document(PageSize.A4);
                string filename = "TraspasosPDF\\TRASPASO " + origen + " " + destino + " " + fecha.ToString("dd_MM_yyyy") + "_" + idtraspaso + ".pdf";
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@filename, FileMode.Create));

                doc.AddTitle("Prueba DaNxD");
                doc.AddCreator("DaN");

                // Abrimos el archivo
                doc.Open();

                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //######################################## ENCABEZADO ################################################################

                // Escribimos el encabezamiento en el documento
                Paragraph parrafoEnc = new Paragraph();
                parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial",14);
                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);

                Paragraph parrafo = new Paragraph();
                //parrafoEnc.Alignment = Element.ALIGN_CENTER;
                //parrafoEnc.Font = FontFactory.GetFont("Arial", 14);
                var normal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                var negritas = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);



                parrafoEnc.Add("SOLICITUD DE TRASPASO " + origen + " No. " + idtraspaso);
                doc.Add(parrafoEnc);
                parrafoEnc.Clear();

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                //parrafo.Add(new Chunk("ID Traspaso: ", negritas));
                //parrafo.Add(new Chunk(id, normal));
                //doc.Add(parrafo);

                //parrafo.Clear();


                parrafo.Add(new Chunk("Fecha de Creacion: ", negritas));
                parrafo.Add(new Chunk(fecha.ToString(), normal));
                doc.Add(parrafo);

                parrafo.Clear();

                //parrafo.Add(new Chunk("Fecha de Aplicacion: ", negritas));
                //parrafo.Add(new Chunk(fecha_apli, normal));
                //doc.Add(parrafo);

                //parrafo.Clear();

                parrafo.Add(new Chunk("Elaboró: ", negritas));
                parrafo.Add(new Chunk(UsuarioMyB, normal));
                doc.Add(parrafo);

                parrafo.Clear();

                //parrafo.Add(new Chunk("Origen: ", negritas));
                //parrafo.Add(new Chunk(origen, normal));

                //parrafo.Add("   ");
                parrafo.Add(new Chunk("Destino: ", negritas));
                parrafo.Add(new Chunk(destino, normal));

                doc.Add(parrafo);

                parrafo.Clear();

                parrafo.Add(new Chunk("Motivo: ", negritas));
                parrafo.Add(new Chunk(motivo.ToUpper(), normal));
                doc.Add(parrafo);

                parrafo.Clear();



                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                parrafoEnc.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                parrafoEnc.Add("ARTICULOS DEL TRASPASO");
                doc.Add(parrafoEnc);
                doc.Add(Chunk.NEWLINE);
                // PRUEBA DAN
                PdfPTable table = new PdfPTable(3);

                table.WidthPercentage = 100;
                float[] widths = new float[] { 40f, 100f, 40f};
                table.SetWidths(widths);
                table.SkipLastFooter = true;
                table.SpacingAfter = 10;


                //Encabezados
                //for (int j = 0; j < DG_datos.Columns.Count; j++)
                //{
                    table.AddCell(new Phrase("ARTICULO"));
                    table.AddCell(new Phrase("DESCRIPCION"));
                    table.AddCell(new Phrase("CANTIDAD"));

                //}

                //flag the first row as a header
                table.HeaderRows = 1;

                for (int i = 0; i < dgvSurtidor.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvSurtidor.Rows[i].Cells[ColumnaSurtir].Value) == true)
                    {

                        //exisBodega = Convert.ToDouble(dgvSutidor.Rows[i].Cells[3].Value.ToString());
                        //VALLARTA BLOQUE
                        if (dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString() != "NO")
                        {
                            if (Convert.ToDouble(dgvSurtidor.Rows[i].Cells[ColumnaTienda].Value.ToString()) > 0)
                            {
                                table.AddCell(new Phrase(dgvSurtidor[1, i].Value.ToString()));
                                table.AddCell(new Phrase(dgvSurtidor[2, i].Value.ToString()));
                                table.AddCell(new Phrase(dgvSurtidor[ColumnaTienda, i].Value.ToString()));
                            }
                        }
                    }
                }

                doc.Add(table);


                doc.Close();
                writer.Close();

                //Process prc = new System.Diagnostics.Process();
                //prc.StartInfo.FileName = filename;

            System.Diagnostics.Process.Start(filename);
            //MessageBox.Show(filename);
                //    prc.Start();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("Error al generar archivo PDF o el archivo ya esta abierto.");
            }
        }
        private void cbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
