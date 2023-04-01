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
    public partial class Pagos_efe_enc_cajas : Form
    {
        string usuario;
        string area;
        public Pagos_efe_enc_cajas(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void Pagos_efe_enc_cajas_Load(object sender, EventArgs e)
        {
            DG_tabla.Columns["PROVEEDOR"].Width = 350;
            DG_tabla.Columns["REFERENCIA"].Width = 200;
             area = ObtenerArea();

            if (area.Equals("ENC CAJAS"))
            {
                CB_sucursal.Enabled = false;
                BT_revisado.Enabled = false;
            }
        }


        

        //GENERA LA CONEXION DE ACUERDO A LA SUCURSAL SELECCIONADA EN EL COMBOBOX
        public MySqlConnection ConexionSucursal(string sucursal)
        {
            MySqlConnection conexion=null;

            if (sucursal.Equals("VALLARTA"))
            {
                conexion = BDConexicon.VallartaOpen();
            }

            if (sucursal.Equals("RENA"))
            {
                conexion = BDConexicon.RenaOpen();
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {
                conexion = BDConexicon.VelazquezOpen();
            }

            if (sucursal.Equals("COLOSO"))
            {
                conexion = BDConexicon.ColosoOpen();
            }

            if (sucursal.Equals("PREGOT"))
            {
                conexion = BDConexicon.Papeleria1Open();
            }

            return conexion;
        }

        public string ObtenerArea()
        {
            string area = "";
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "select area from usuarios where usuario='"+usuario+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                area = dr["area"].ToString();
            }
            dr.Close();
            conexion.Close();
            return area;
        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
           
            if (area.Equals("ENC CAJAS"))
            {
               
                    //LLENA EL DATAGRID CON EL RESULTADO DE LA CONSULTA
                    CB_sucursal.Enabled = false;
                    DG_tabla.Rows.Clear();
                    DateTime inicio = DT_inicio.Value;
                    DateTime fin = DT_fin.Value;
                MySqlConnection conexion = BDConexicon.conectar();
                    string query = "SELECT * FROM rd_pagos_enc_cajas WHERE fecha_pago between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                    string estado = "";

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            estado = dr["check_gral"].ToString();

                            if (estado.Equals("0"))
                            {
                                check.ThreeState = false;
                            }
                            if (estado.Equals("1"))
                            {
                                check.ThreeState = true;
                            }


                            DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["nomprov"].ToString(), Convert.ToDouble(dr["importe"].ToString()), dr["referencia"].ToString(), dr["realizo"].ToString(), dr["fecha_pago"].ToString(), dr["tienda"].ToString(), check.ThreeState);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos en la fecha seleccionada");
                    }

                    dr.Close();
                    conexion.Close();
                    DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";
                    DG_tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            }
            else
            {
                if (CB_sucursal.SelectedIndex == -1)
                {//SI EL INDICE DE LA SUCURSAL ES -1, SIGNIFICA QUE NOS SE HA SELECCIONADA SUCURSAL
                    MessageBox.Show("Debes seleccionar una sucursal");
                }
                else
                {
                    //LLENA EL DATAGRID CON EL RESULTADO DE LA CONSULTA
                    DG_tabla.Rows.Clear();
                    DateTime inicio = DT_inicio.Value;
                    DateTime fin = DT_fin.Value;
                    MySqlConnection conexion = ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                    string query = "SELECT * FROM rd_pagos_enc_cajas WHERE fecha_pago between '" + inicio.ToString("yyyy-MM-dd") + "' and '" + fin.ToString("yyyy-MM-dd") + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();
                    string estado = "";

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            estado = dr["check_gral"].ToString();

                            if (estado.Equals("0"))
                            {
                                check.ThreeState = false;
                            }
                            if (estado.Equals("1"))
                            {
                                check.ThreeState = true;
                            }


                            DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["nomprov"].ToString(), Convert.ToDouble(dr["importe"].ToString()), dr["referencia"].ToString(), dr["realizo"].ToString(), dr["fecha_pago"].ToString(), dr["tienda"].ToString(), check.ThreeState);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos en la fecha seleccionada");
                    }

                    dr.Close();
                    conexion.Close();
                    DG_tabla.Columns[2].DefaultCellStyle.Format = "C2";
                    DG_tabla.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                }
            }

            
        }


        //ESTE METODO ACTUALIZA EL ESTADO DE LAS CELDAS CHECKBOX DEL DATAGRID
        private void BT_revisado_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = ConexionSucursal(CB_sucursal.SelectedItem.ToString());
           
            bool estado = false;
            int state = 0;
            string id = "";
            
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                estado =Convert.ToBoolean(DG_tabla.Rows[i].Cells["CHECK"].Value);
                id = Convert.ToString(DG_tabla.Rows[i].Cells["ID"].Value);
                if (estado==true)
                {
                    state = 1;
                }

                if (estado == false)
                {
                    state = 0;
                }

                
                MySqlCommand cmd = new MySqlCommand("UPDATE rd_pagos_enc_cajas SET check_gral= " + state + " WHERE idreg='"+id+"'",conexion);
              
                cmd.ExecuteNonQuery();
               
            }
            MessageBox.Show("SE HAN ACTUALIZADO LOS CHECKS");
            conexion.Close();
        }
    }
}
