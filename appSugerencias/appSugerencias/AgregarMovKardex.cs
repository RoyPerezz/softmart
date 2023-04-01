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
    public partial class AgregarMovKardex : Form
    {
        public AgregarMovKardex()
        {
            InitializeComponent();
        }

        public int ConsecMovsinv()
        {
            int consec = 1;
            MySqlConnection con = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT Consec FROM CONSEC WHERE Dato ='movsinv'", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    consec += consec = Convert.ToInt32(dr["Consec"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer consecutivo de movsinv " + ex);
            }



            return consec;

        }


        private void BT_insertar_Click(object sender, EventArgs e)
        {

            int movsinv = ConsecMovsinv();

            string sucursal = CB_sucursal.SelectedItem.ToString();
            DateTime fecha = DT_fecha.Value;
            MySqlConnection conexion = BDConexicon.ConexionSucursal(sucursal);
            string query = "INSERT INTO movsinv(CONSEC,OPERACION,MOVIMIENTO,ENT_SAL,TIPO_MOVIM,NO_REFEREN,ARTICULO,F_MOVIM,CANTIDAD,COSTO,EXISTENCIA,VALOR,ALMACEN,EXIST_ALM,PRECIO_VTA,POR_COSTEA,PARTIDA,Cerrado,Usuario,UsuFecha,UsuHora,CLAVEADD,PRCANTIDAD,ID_SALIDA,ID_ENTRADA,REORDENA,inicial,exportado,verificado,inventariofisico,donativo,precio_vta_original,costopromedio,poliza)" +
                "VALUES(?CONSEC,?OPERACION,?MOVIMIENTO,?ENT_SAL,?TIPO_MOVIM,?NO_REFEREN,?ARTICULO,?F_MOVIM,?CANTIDAD,?COSTO,?EXISTENCIA,?VALOR,?ALMACEN,?EXIST_ALM,?PRECIO_VTA,?POR_COSTEA,?PARTIDA,?Cerrado,?Usuario,?UsuFecha,?UsuHora,?CLAVEADD,?PRCANTIDAD,?ID_SALIDA,?ID_ENTRADA,?REORDENA,?inicial,?exportado,?verificado,?inventariofisico,?donativo,?precio_vta_original,?costopromedio,?poliza)";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            cmd.Parameters.AddWithValue("?CONSEC",movsinv);
            cmd.Parameters.AddWithValue("?OPERACION",TB_operacion.Text);
            cmd.Parameters.AddWithValue("?MOVIMIENTO",TB_movimiento.Text);
            cmd.Parameters.AddWithValue("?ENT_SAL", TB_entsal.Text);
            cmd.Parameters.AddWithValue("?TIPO_MOVIM", TB_tipo_mov.Text);
            cmd.Parameters.AddWithValue("?NO_REFEREN", TB_no_referen.Text);
            cmd.Parameters.AddWithValue("?ARTICULO", TB_articulo.Text);
            cmd.Parameters.AddWithValue("?F_MOVIM", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?CANTIDAD", TB_cantidad.Text);
            cmd.Parameters.AddWithValue("?COSTO", 0);
            cmd.Parameters.AddWithValue("?EXISTENCIA",0);
            cmd.Parameters.AddWithValue("?VALOR", 0);
            cmd.Parameters.AddWithValue("?ALMACEN", 1);
            cmd.Parameters.AddWithValue("?EXIST_ALM", 0);
            cmd.Parameters.AddWithValue("?PRECIO_VTA",0);
            cmd.Parameters.AddWithValue("?POR_COSTEA", 0);
            cmd.Parameters.AddWithValue("?PARTIDA",0);
            cmd.Parameters.AddWithValue("?Cerrado", 0);
            cmd.Parameters.AddWithValue("?Usuario","ALEXIA");
            cmd.Parameters.AddWithValue("?UsuFecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?UsuHora", fecha.ToString("HH:MM"));
            cmd.Parameters.AddWithValue("?CLAVEADD",0);
            cmd.Parameters.AddWithValue("?PRCANTIDAD", 0);
            cmd.Parameters.AddWithValue("?ID_SALIDA", 0);
            cmd.Parameters.AddWithValue("?ID_ENTRADA", 0);
            cmd.Parameters.AddWithValue("?REORDENA", 0);
            cmd.Parameters.AddWithValue("?inicial", 0);
            cmd.Parameters.AddWithValue("?exportado", 0);
            cmd.Parameters.AddWithValue("?verificado", 0);
            cmd.Parameters.AddWithValue("?inventariofisico", 0);
            cmd.Parameters.AddWithValue("?donativo", 0);
            cmd.Parameters.AddWithValue("?precio_vta_original", 0);
            cmd.Parameters.AddWithValue("?costopromedio", 0);
            cmd.Parameters.AddWithValue("?poliza", 0);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro insertado");


        }

        private void AgregarMovKardex_Load(object sender, EventArgs e)
        {

        }
    }
}
