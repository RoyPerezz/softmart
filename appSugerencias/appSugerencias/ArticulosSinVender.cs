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
    public partial class ArticulosSinVender : Form
    {
        public ArticulosSinVender()
        {
            InitializeComponent();
        }



        public void BuscarArticulosSinMov()
        {

           
            //string sucursal = CB_sucursal.SelectedItem.ToString();
            //string linea = CB_linea.SelectedItem.ToString();
            //DataTable articulos = new DataTable();
            //articulos.Rows.Clear();
            //LB_items.Text = "";
            //InventarioFisico invf = new InventarioFisico();
            //articulos = invf.ArticulosSinMov(sucursal,linea);


            //DataView dtV = articulos.DefaultView;
            //dtV.Sort = "FECHA ASC";
            //articulos = dtV.ToTable();

            ////DG_tabla.DataSource = articulos;
            //double mayoreo = 0;
            //double menudeo = 0;

           
            //foreach (DataRow item in articulos.Rows)
            //{
              
            //    mayoreo = Convert.ToDouble(item["precio2"]);
            //    menudeo = Convert.ToDouble(item["precio1"]);

            //    mayoreo = mayoreo+(mayoreo*0.16);
            //    menudeo = menudeo+(menudeo*0.16);

            //    DG_tabla.Rows.Add(item["ARTICULO"],item["DESCRIPCION"],mayoreo.ToString("C"),menudeo.ToString("C"),item["MOVIMIENTO"],"",item["FECHA"],item["EXISTENCIA"]);
                
            //}



            //############################### CREAMOS EL DATATBLE Y GUARDAMOS EN EL LOS DATOS DE LA TABLA PRODS
            DataTable claves = new DataTable();
            claves.Columns.Add("ARTICULOS",typeof(string));
            claves.Columns.Add("DESCRIPCION", typeof(string));
            claves.Columns.Add("PRECIO_MAY", typeof(string));
            claves.Columns.Add("PRECIO_MEN", typeof(string));
            claves.Columns.Add("EXISTENCIA", typeof(string));
            
            claves.Columns.Add("FECHA_COMPRA", typeof(string));
            claves.Columns.Add("TIPO MOV", typeof(string));
            claves.Columns.Add("FECHA_MOV", typeof(string));
            claves.Columns.Add("ULTIMO MOV", typeof(string));
            string query = "select ARTICULO,DESCRIP,PRECIO1,PRECIO2,EXISTENCIA FROM PRODS WHERE EXISTENCIA >0 AND LINEA ='"+CB_linea.SelectedItem.ToString()+"'";
            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            MySqlCommand cmd0 = new MySqlCommand(query,conexion);
            MySqlDataReader dr0 = cmd0.ExecuteReader();

            while (dr0.Read())
            {
                claves.Rows.Add(dr0["ARTICULO"].ToString(), dr0["DESCRIP"].ToString(), dr0["PRECIO2"].ToString(), dr0["PRECIO1"].ToString(), dr0["EXISTENCIA"].ToString(),"","","");
                //DG_tabla.DataSource = claves;
            }
            dr0.Close();


            //################# AGREGAMOS AL DATATABLE LA FECHA DE SU ULTIMO MOVIMIENTO Y SI ESTE FUE ENTRADA O SALIDA

            MySqlCommand cmd1 = null;
            MySqlDataReader dr1 = null;
            string articulo = "";
            for (int i = 0; i < claves.Rows.Count; i++)
            {
                articulo = claves.Rows[i]["ARTICULOS"].ToString();
                cmd1 = new MySqlCommand("select ENT_SAL, F_MOVIM  from movsinv  where ARTICULO='"+articulo+"' AND TIPO_MOVIM IN ('COM','TK','T+','T-','A+','A-') order by consec desc limit 1",conexion);
                dr1 = cmd1.ExecuteReader();

                while (dr1.Read())
                {
                    claves.Rows[i]["ULTIMO MOV"] = dr1["ENT_SAL"].ToString();
                    claves.Rows[i]["FECHA_MOV"] =dr1["F_MOVIM"].ToString();
                    

                }
                dr1.Close();

            }

            //############################ AGREGAMOS LA FECHA DE LA ULTIMA COMPRA
            MySqlCommand cmd2 = null;
            MySqlDataReader dr2 = null;
            // CONSULTA ANTERIOR:   select F_MOVIM from movsinv  where ARTICULO='"+articulo+ "' AND (TIPO_MOVIM='COM' or TIPO_MOVIM='T+')   order by consec desc limit 1"
            for (int i = 0; i < claves.Rows.Count; i++)
            {
                articulo = claves.Rows[i]["ARTICULOS"].ToString();
                cmd2 = new MySqlCommand("SELECT * FROM MOVSINV WHERE ARTICULO ='" + articulo + "' AND (TIPO_MOVIM ='T+' or TIPO_MOVIM ='COM' OR TIPO_MOVIM ='A+'  ) order by F_MOVIM desc limit 1", conexion);
                dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    claves.Rows[i]["FECHA_COMPRA"] = dr2["F_MOVIM"].ToString();
                    claves.Rows[i]["TIPO MOV"] = dr2["TIPO_MOVIM"].ToString();

                }
                dr2.Close();

            }


            DataView view = claves.DefaultView;
            
            view.Sort= "FECHA_MOV";

            DG_tabla.DataSource = view;
            int count = claves.Rows.Count;

            conexion.Close();

            
           

      
            LB_items.Text = Convert.ToString(DG_tabla.Rows.Count+ " ARTICULOS EN LA LINEA");
           
        }


        private void BT_buscar_Click(object sender, EventArgs e)
        {
            if (CB_sucursal.SelectedIndex==-1 || CB_linea.SelectedIndex==-1)
            {
                MessageBox.Show("Debes seleccionar la sucursal y la linea");
            }
            else
            {

                BT_buscar.Enabled = false;
                BuscarArticulosSinMov();
                BT_buscar.Enabled = true;
            }

        }

        public void Lineas()
        {
            //string sucursal = CB_sucursal.SelectedItem.ToString();
            //InventarioFisico invf = new InventarioFisico();
            //MySqlConnection con = invf.ConexionSucursal(sucursal);

            try
            {
                string consulta = "SELECT Linea FROM lineas";
                MySqlConnection con = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(consulta, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_linea.Items.Add(dr["Linea"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer lineas: "+ex);
            }
        }

        private void ArticulosSinVender_Load(object sender, EventArgs e)
        {

            CB_linea.Items.Add("");

            Lineas();
        }

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            // Exportar formato = new Exportar();
            // formato.Excel(DG_tabla);
            Exportar.Excel(DG_tabla);
        }
    }
}
