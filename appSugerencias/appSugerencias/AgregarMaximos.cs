using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class AgregarMaximos : Form
    {
        public AgregarMaximos()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataView ImportarDatos(string archivo)
        {
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source ={0}; Extended Properties ='Excel 12.0;'", archivo);
            OleDbConnection conector = new OleDbConnection(conexion);
            conector.Open();

            OleDbCommand consulta = new OleDbCommand("select * from[hoja1$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };

          
            adaptador.Fill(ds);
            conector.Close();
            return ds.Tables[0].DefaultView;




        }
        private void BT_importarExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter="Excel | *.xls; *xlsx",
                Title ="Seleccionar Archivo"
            };

            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                
               DG_tabla.DataSource= ImportarDatos(openFileDialog.FileName);
               
            }
            
        }


        //guardar multiples articulos
        private void BT_guardar_Click(object sender, EventArgs e)
        {
            if (CB_sucursal.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona la Sucursal");
            }
            else
            {
                if (DG_tabla.Rows.Count == 0)
                {
                    MessageBox.Show("Debes cargar el excel");
                }
                else
                {
                    MySqlConnection conexion = BDConexicon.BodegaOpen();

                    string query = "";

                    if (CB_sucursal.SelectedItem.ToString().Equals("BODEGA"))
                    {
                        query = "INSERT INTO rd_maximos_bo(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                    }

                    if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                    {
                        query = "INSERT INTO rd_maximos_va(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                    }


                    if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                    {
                        query = "INSERT INTO rd_maximos_re(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                    }

                    if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                    {
                        query = "INSERT INTO rd_maximos_ve(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                    }

                    if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                    {
                        query = "INSERT INTO rd_maximos_co(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                    }


                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    int numArticulos = DG_tabla.Rows.Count;
                    for (int i = 0; i < DG_tabla.Rows.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("?articulo", DG_tabla.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("?descripcion", DG_tabla.Rows[i].Cells[1].Value);
                        cmd.Parameters.AddWithValue("?maximo", Convert.ToInt32(DG_tabla.Rows[i].Cells[2].Value));
                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();

                    MessageBox.Show("Se han registrado las cantidades maximas de " + numArticulos + " articulos, en " + CB_sucursal.SelectedItem.ToString() + "");
                    ds.Clear();
                    DG_tabla.DataSource = null;
                }

            }

        }

        private void BT_guardarArt_Click(object sender, EventArgs e)
        {

            if (CB_sucursal2.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona la sucursal");
            }else if(TB_articulo.Text.Equals(""))
            {
                MessageBox.Show("Captura el articulo");
            }
            else if (TB_descrip.Text.Equals(""))
            {
                MessageBox.Show("Captura la descripcion");
            }
            else if(TB_maximo.Text.Equals(""))
            {
                MessageBox.Show("Captura el máximo");
            }
            else
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();

                string query = "";

                if (CB_sucursal2.SelectedItem.ToString().Equals("BODEGA"))
                {
                    query = "INSERT INTO rd_maximos_bo(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                }

                if (CB_sucursal2.SelectedItem.ToString().Equals("VALLARTA"))
                {
                    query = "INSERT INTO rd_maximos_va(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                }


                if (CB_sucursal2.SelectedItem.ToString().Equals("RENA"))
                {
                    query = "INSERT INTO rd_maximos_re(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                }

                if (CB_sucursal2.SelectedItem.ToString().Equals("VELAZQUEZ"))
                {
                    query = "INSERT INTO rd_maximos_ve(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                }

                if (CB_sucursal2.SelectedItem.ToString().Equals("COLOSO"))
                {
                    query = "INSERT INTO rd_maximos_co(articulo,descripcion,maximo)VALUES(?articulo,?descripcion,?maximo)";
                }


                MySqlCommand cmd = new MySqlCommand(query, conexion);


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("?articulo", TB_articulo.Text);
                cmd.Parameters.AddWithValue("?descripcion", TB_descrip.Text);
                cmd.Parameters.AddWithValue("?maximo", Convert.ToInt32(TB_maximo.Text));
                cmd.ExecuteNonQuery();
                conexion.Close();


                MessageBox.Show("Se han registrado la cantidad maxima del articulo " + TB_articulo.Text + " en " + CB_sucursal.SelectedItem.ToString() + "");
                TB_articulo.Text = "";
                TB_descrip.Text = "";
                TB_maximo.Text = "";
            }

        }


        //MODIFICAR MAXIMO
        private void button1_Click(object sender, EventArgs e)
        {

            if (CB_suc.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione la sucursal");
            }else if(TB_art.Text.Equals(""))
            {
                MessageBox.Show("Capture el articulo");
            }else if(TB_max.Text.Equals(""))
            {
                MessageBox.Show("Capture el máximo");
            }
            else
            {
                string query = "";

                int maximo = Convert.ToInt32(TB_max.Text);

                if (CB_suc.SelectedItem.ToString().Equals("BODEGA"))
                {
                    query = "UPDATE rd_maximos_bo SET maximo=" + maximo + " WHERE articulo ='" + TB_art.Text + "'";
                }

                if (CB_suc.SelectedItem.ToString().Equals("VALLARTA"))
                {
                    query = "UPDATE rd_maximos_va SET maximo=" + maximo + " WHERE articulo ='" + TB_art.Text + "'";
                }


                if (CB_suc.SelectedItem.ToString().Equals("RENA"))
                {
                    query = "UPDATE rd_maximos_re SET maximo=" + maximo + " WHERE articulo ='" + TB_art.Text + "'";
                }

                if (CB_suc.SelectedItem.ToString().Equals("VELAZQUEZ"))
                {
                    query = "UPDATE rd_maximos_ve SET maximo=" + maximo + " WHERE articulo ='" + TB_art.Text + "'";
                }

                if (CB_suc.SelectedItem.ToString().Equals("COLOSO"))
                {
                    query = "UPDATE rd_maximos_co SET maximo=" + maximo + " WHERE articulo ='" + TB_art.Text + "'";
                }

                MySqlConnection conexion = BDConexicon.BodegaOpen();

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizó el maximo del articulo " + TB_art.Text + " a " + TB_max.Text);

                TB_art.Text = "";
                TB_max.Text = "";
            }


            
        }
    }
}
