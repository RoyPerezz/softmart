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
    public partial class InsertarRegistroMovSinv : Form
    {
        public InsertarRegistroMovSinv()
        {
            InitializeComponent();
        }

        string operacion = "", ent_sal = "", tipoMov = "",movimiento="",articulo="",descrip="";
        int cantidad = 0;
        double costo = 0;

        public void TipoMovimiento(string tipo)
        {
            if (tipo.Equals("COM"))
            {
                operacion = "CO";
                ent_sal = "E";
            }
        }

        public void Limpiar()
        {
            //TB_movimiento.Text = "";
            TB_articulo.Text = "";
            TB_cantidad.Text = "";
        }


        public int IdEntrada(MySqlConnection con)
        {
            int id = 0;

            string query = "SELECT ID_ENTRADA FROM partcomp WHERE ARTICULO='"+articulo+"'";
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                id = Convert.ToInt32(dr["ID_ENTRADA"].ToString());
            }
            dr.Close();
            return id;
        }


        public int ConsecMovSinv()
        {
            int consec = 1;
            string query = "SELECT Consec FROM Consec WHERE Dato='movsinv'";
           
            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                consec += Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();

            string queryActualizar = "UPDATE Consec SET Consec ='"+consec+"' WHERE Dato='movsinv'";
            MySqlCommand actualizar = new MySqlCommand(queryActualizar, conexion);
            actualizar.ExecuteNonQuery();
            conexion.Close();
            return consec;
        }


        private void BT_guardad_Click(object sender, EventArgs e)
        {

            tipoMov = CB_tipo_mov.SelectedItem.ToString();
            movimiento = TB_movimiento.Text;
            articulo = TB_articulo.Text;
            cantidad = Convert.ToInt32(TB_cantidad.Text);
            DateTime fecha = DT_fecha.Value;
            TipoMovimiento(tipoMov);

            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString()); ;


            string queryProds = "SELECT DESCRIP,COSTO_U FROM prods WHERE articulo='" + articulo + "'";
            MySqlCommand comando = new MySqlCommand(queryProds, conexion);

            MySqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                descrip = dr["DESCRIP"].ToString();
                costo = Convert.ToDouble(dr["COSTO_U"].ToString());
            }

            dr.Close();

            string query = "INSERT INTO movsinv(CONSEC,OPERACION,MOVIMIENTO,ENT_SAL,TIPO_MOVIM,NO_REFEREN,ARTICULO,F_MOVIM,CANTIDAD,COSTO,EXISTENCIA,VALOR,ALMACEN,EXIST_ALM,PRECIO_VTA,POR_COSTEA,PARTIDA,Cerrado,Usuario,UsuFecha,UsuHora,CLAVEADD,PRCANTIDAD,ID_SALIDA,ID_ENTRADA,REORDENA,inicial,exportado,verificado,inventariofisico,donativo,precio_vta_original,costopromedio,poliza)" +
                "VALUES(?CONSEC,?OPERACION,?MOVIMIENTO,?ENT_SAL,?TIPO_MOVIM,?NO_REFEREN,?ARTICULO,?F_MOVIM,?CANTIDAD,?COSTO,?EXISTENCIA,?VALOR,?ALMACEN,?EXIST_ALM,?PRECIO_VTA,?POR_COSTEA,?PARTIDA,?Cerrado,?Usuario,?UsuFecha,?UsuHora,?CLAVEADD,?PRCANTIDAD,?ID_SALIDA,?ID_ENTRADA,?REORDENA,?inicial,?exportado,?verificado,?inventariofisico,?donativo,?precio_vta_original,?costopromedio,?poliza)";

            int id_entrada = IdEntrada(conexion);
            int consec = ConsecMovSinv();

            MySqlCommand cmd = new MySqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("?CONSEC", consec);
            cmd.Parameters.AddWithValue("?OPERACION", operacion);
            cmd.Parameters.AddWithValue("?MOVIMIENTO", movimiento);
            cmd.Parameters.AddWithValue("?ENT_SAL", ent_sal);
            cmd.Parameters.AddWithValue("?TIPO_MOVIM", tipoMov);
            cmd.Parameters.AddWithValue("?NO_REFEREN", "");
            cmd.Parameters.AddWithValue("?ARTICULO", articulo);
            cmd.Parameters.AddWithValue("?F_MOVIM", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?CANTIDAD", cantidad);
            cmd.Parameters.AddWithValue("?COSTO", costo);
            cmd.Parameters.AddWithValue("?EXISTENCIA", 0);
            cmd.Parameters.AddWithValue("?VALOR", 0);
            cmd.Parameters.AddWithValue("?ALMACEN", 1);
            cmd.Parameters.AddWithValue("?EXIST_ALM", 0);//ES EL MISMO VALOR DE LA EXISTENCIA
            cmd.Parameters.AddWithValue("?PRECIO_VTA", costo);
            cmd.Parameters.AddWithValue("?POR_COSTEA", 0);//MISMO VALOR QUE EXISTENCIA Y EXIST_ALM
            cmd.Parameters.AddWithValue("?PARTIDA", 0);
            cmd.Parameters.AddWithValue("?Cerrado", 0);
            cmd.Parameters.AddWithValue("?Usuario", "SOPORTE");
            cmd.Parameters.AddWithValue("?UsuFecha", fecha.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?UsuHora", fecha.Hour);
            cmd.Parameters.AddWithValue("?CLAVEADD", "");
            cmd.Parameters.AddWithValue("?PRCANTIDAD", 0);
            cmd.Parameters.AddWithValue("?ID_SALIDA", 0);
            cmd.Parameters.AddWithValue("?ID_ENTRADA", id_entrada);
            cmd.Parameters.AddWithValue("?REORDENA", 0);
            cmd.Parameters.AddWithValue("?inicial", 0);
            cmd.Parameters.AddWithValue("?exportado", 0);
            cmd.Parameters.AddWithValue("?verificado", 0);
            cmd.Parameters.AddWithValue("?inventariofisico", 0);
            cmd.Parameters.AddWithValue("?donativo", 0);
            cmd.Parameters.AddWithValue("?precio_vta_original", 0);
            cmd.Parameters.AddWithValue("?costopromedio", 0);
            cmd.Parameters.AddWithValue("?poliza", "");
            cmd.ExecuteNonQuery();
            MessageBox.Show("SE GUARDÓ EL REGISTRO EN EL KARDEX DEL ARTICULO: "+articulo+" "+descrip);
            Limpiar();

        }
    }
}
