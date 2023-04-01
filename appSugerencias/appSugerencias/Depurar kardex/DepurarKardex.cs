using appSugerencias.Depurar_kardex;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class DepurarKardex : Form
    {

        string consulta = "";
        public DepurarKardex()
        {
            InitializeComponent();
            
        }

        

      

        #region METODOS

        public void ExistenciaCE(string articulo)
        {

            try
            {
                //consulta = "SELECT DESCRIP,EXISTENCIA FROM prods where ARTICULO='" + articulo + "'";
                consulta = "SELECT  PRODS.DESCRIP,PRODS.EXISTENCIA, MOVSINV.f_movim as fecha, MOVSINV.tipo_movim FROM MOVSINV INNER JOIN PRODS ON MOVSINV.ARTICULO = PRODS.ARTICULO " +
                    "WHERE MOVSINV.ARTICULO = '"+articulo+"' and(MOVSINV.tipo_movim <> 'IF+' and MOVSINV.tipo_movim <> 'IC-') order BY MOVSINV.f_movim desc limit 1";
                MySqlConnection CE_conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(consulta, CE_conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TB_descripcion.Text = dr["DESCRIP"].ToString();

                    DG_tabla.Rows[0].Cells[1].Value = dr["EXISTENCIA"].ToString();
                    DG_tabla.Rows[0].Cells[2].Value = dr["fecha"].ToString();
                    DG_tabla.Rows[0].Cells[3].Value = dr["tipo_movim"].ToString();


                }
                else
                {
                    TB_descripcion.Text = "No se encontró la descripción";
                    DG_tabla.Rows[0].Cells[1].Value = "No existe";
                }
                dr.Close();
                CE_conexion.Close();
            }
            catch (Exception ex)
            {

                DG_tabla.Rows[0].Cells[1].Value = "Sin conexion";
                MessageBox.Show(""+ex);
            }
           
         
        }

        public void ExistenciaVA(string articulo)
        {

            try
            {
                //consulta = "SELECT EXISTENCIA FROM prods where ARTICULO='" + articulo + "'";
                consulta = "SELECT  PRODS.DESCRIP,PRODS.EXISTENCIA, MOVSINV.f_movim as fecha, MOVSINV.tipo_movim FROM MOVSINV INNER JOIN PRODS ON MOVSINV.ARTICULO = PRODS.ARTICULO " +
            "WHERE MOVSINV.ARTICULO = '" + articulo + "' and(MOVSINV.tipo_movim <> 'IF+' and MOVSINV.tipo_movim <> 'IC-') order BY MOVSINV.f_movim desc limit 1";
                MySqlConnection VA_conexion = BDConexicon.VallartaOpen();
                MySqlCommand cmd = new MySqlCommand(consulta, VA_conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    DG_tabla.Rows[1].Cells[1].Value = dr["EXISTENCIA"].ToString();
                    DG_tabla.Rows[1].Cells[2].Value = dr["fecha"].ToString();
                    DG_tabla.Rows[1].Cells[3].Value = dr["tipo_movim"].ToString();

                }
                else
                {
                    DG_tabla.Rows[1].Cells[1].Value ="No existe";
                }
                dr.Close();
                VA_conexion.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                DG_tabla.Rows[1].Cells[1].Value = "Sin conexion";
            }
          
        }

        public void ExistenciaRE(string articulo)
        {

            try
            {
                //consulta = "SELECT EXISTENCIA FROM prods where ARTICULO='" + articulo + "'";
                consulta = "SELECT  PRODS.DESCRIP,PRODS.EXISTENCIA, MOVSINV.f_movim as fecha, MOVSINV.tipo_movim FROM MOVSINV INNER JOIN PRODS ON MOVSINV.ARTICULO = PRODS.ARTICULO " +
            "WHERE MOVSINV.ARTICULO = '" + articulo + "' and(MOVSINV.tipo_movim <> 'IF+' and MOVSINV.tipo_movim <> 'IC-') order BY MOVSINV.f_movim desc limit 1";
                MySqlConnection RE_conexion = BDConexicon.RenaOpen();
                MySqlCommand cmd = new MySqlCommand(consulta, RE_conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    DG_tabla.Rows[2].Cells[1].Value = dr["EXISTENCIA"].ToString();
                    DG_tabla.Rows[2].Cells[2].Value = dr["fecha"].ToString();
                    DG_tabla.Rows[2].Cells[3].Value = dr["tipo_movim"].ToString();

                }
                else
                {
                    DG_tabla.Rows[2].Cells[1].Value = "No existe";
                }
                dr.Close();
                RE_conexion.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                DG_tabla.Rows[2].Cells[1].Value = "Sin conexion";
            }
            
        }

        public void ExistenciaVE(string articulo)
        {

            try
            {
                //consulta = "SELECT EXISTENCIA FROM prods where ARTICULO='" + articulo + "'";
                consulta = "SELECT  PRODS.DESCRIP,PRODS.EXISTENCIA, MOVSINV.f_movim as fecha, MOVSINV.tipo_movim FROM MOVSINV INNER JOIN PRODS ON MOVSINV.ARTICULO = PRODS.ARTICULO " +
            "WHERE MOVSINV.ARTICULO = '" + articulo + "' and(MOVSINV.tipo_movim <> 'IF+' and MOVSINV.tipo_movim <> 'IC-') order BY MOVSINV.f_movim desc limit 1";
                MySqlConnection VE_conexion = BDConexicon.VelazquezOpen();
                MySqlCommand cmd = new MySqlCommand(consulta, VE_conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    DG_tabla.Rows[3].Cells[1].Value = dr["EXISTENCIA"].ToString();
                    DG_tabla.Rows[3].Cells[2].Value = dr["fecha"].ToString();
                    DG_tabla.Rows[3].Cells[3].Value = dr["tipo_movim"].ToString();

                }
                else
                {
                    DG_tabla.Rows[3].Cells[1].Value = "No existe";
                }
                dr.Close();
                VE_conexion.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                DG_tabla.Rows[3].Cells[1].Value = "Sin conexion";
                
            }
            
        }

        public void ExistenciaCO(string articulo)
        {

            try
            {
                //consulta = "SELECT EXISTENCIA FROM prods where ARTICULO='" + articulo + "'";
                consulta = "SELECT  PRODS.DESCRIP,PRODS.EXISTENCIA, MOVSINV.f_movim as fecha, MOVSINV.tipo_movim FROM MOVSINV INNER JOIN PRODS ON MOVSINV.ARTICULO = PRODS.ARTICULO " +
      "WHERE MOVSINV.ARTICULO = '" + articulo + "' and(MOVSINV.tipo_movim <> 'IF+' and MOVSINV.tipo_movim <> 'IC-') order BY MOVSINV.f_movim desc limit 1";

                MySqlConnection CO_conexion = BDConexicon.ColosoOpen();
                MySqlCommand cmd = new MySqlCommand(consulta, CO_conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    DG_tabla.Rows[4].Cells[1].Value = dr["EXISTENCIA"].ToString();
                    DG_tabla.Rows[4].Cells[2].Value = dr["fecha"].ToString();
                    DG_tabla.Rows[4].Cells[3].Value = dr["tipo_movim"].ToString();

                }
                else
                {
                    DG_tabla.Rows[4].Cells[1].Value = "No existe";
                }
                dr.Close();
                CO_conexion.Close();
            }
            catch (Exception)
            {

                DG_tabla.Rows[4].Cells[1].Value = "Sin conexion";
            }
            
        }

        #endregion

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            TB_descripcion.Text = "";
            DG_tabla.Rows.Add("CEDIS", "");
            DG_tabla.Rows.Add("VALLARTA", "");
            DG_tabla.Rows.Add("RENA", "");
            DG_tabla.Rows.Add("VELAZQUEZ", "");
            DG_tabla.Rows.Add("COLOSO", "");

            ExistenciaCE(TB_articulo.Text);
            ExistenciaVA(TB_articulo.Text);
            ExistenciaRE(TB_articulo.Text);
            ExistenciaVE(TB_articulo.Text);
            ExistenciaCO(TB_articulo.Text);

            

        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {
            DepurarKardex_eliminar eliminar = new DepurarKardex_eliminar(TB_articulo.Text,TB_descripcion.Text);
            eliminar.Show();
        }

        private void DepurarKardex_Load(object sender, EventArgs e)
        {
            DG_tabla.Rows.Add("CEDIS","");
            DG_tabla.Rows.Add("VALLARTA", "");
            DG_tabla.Rows.Add("RENA", "");
            DG_tabla.Rows.Add("VELAZQUEZ", "");
            DG_tabla.Rows.Add("COLOSO", "");

            BT_cargar_excel.Enabled = false;
        }

        
            private void TB_articulo_KeyDown(object sender, KeyEventArgs e)
            {
                
            }

        private void TB_articulo_KeyDown_1(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Down)
            //{

            //    DG_tabla.Rows.Clear();
            //    TB_descripcion.Text = "";
            //    string clave = TB_articulo.Text;



            //    ArticulosADepurar aux = new ArticulosADepurar(clave);
            //    AddOwnedForm(aux);
            //    aux.Show();



            //}

            //if (e.KeyData == Keys.Enter)
            //{

            //    DG_tabla.Rows.Clear();
        
            //    TB_descripcion.Text = "";
            //    DG_tabla.Rows.Add("CEDIS", "");
            //    DG_tabla.Rows.Add("VALLARTA", "");
            //    DG_tabla.Rows.Add("RENA", "");
            //    DG_tabla.Rows.Add("VELAZQUEZ", "");
            //    DG_tabla.Rows.Add("COLOSO", "");

            //    ExistenciaCE(TB_articulo.Text);
            //    ExistenciaVA(TB_articulo.Text);
            //    ExistenciaRE(TB_articulo.Text);
            //    ExistenciaVE(TB_articulo.Text);
            //    ExistenciaCO(TB_articulo.Text);

            //}
        }

        private void DepurarKardex_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void TB_descripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {

                DG_tabla.Rows.Clear();
              
                string clave = TB_articulo.Text;
                string descrip = TB_descripcion.Text;



                ArticulosADepurar aux = new ArticulosADepurar(clave,descrip);
                AddOwnedForm(aux);
                aux.Show();



            }

            if (e.KeyData == Keys.Enter)
            {

                DG_tabla.Rows.Clear();

                TB_descripcion.Text = "";
                DG_tabla.Rows.Add("CEDIS", "");
                DG_tabla.Rows.Add("VALLARTA", "");
                DG_tabla.Rows.Add("RENA", "");
                DG_tabla.Rows.Add("VELAZQUEZ", "");
                DG_tabla.Rows.Add("COLOSO", "");

                ExistenciaCE(TB_articulo.Text);
                ExistenciaVA(TB_articulo.Text);
                ExistenciaRE(TB_articulo.Text);
                ExistenciaVE(TB_articulo.Text);
                ExistenciaCO(TB_articulo.Text);

            }
        }


        DataTable dt = new DataTable();

        DataTable ImportarDatos(string archivo)
        {
            dt.Rows.Clear();
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ={0}; Extended Properties ='Excel 12.0;'", archivo);
            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();

            OleDbCommand consulta = new OleDbCommand("select * from[hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };


            adaptador.Fill(dt);
            conector.Close();
            return dt;




        }

        private void BT_cargar_excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls; *xlsx",
                Title = "Seleccionar Archivo"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                dt = ImportarDatos(openFileDialog.FileName);

            }

            DepurarKardex_excel excel = new DepurarKardex_excel(dt);
            excel.Show();
        }
    }
}
