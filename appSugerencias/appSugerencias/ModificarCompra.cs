using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class ModificarCompra : Form
    {
        public ModificarCompra()
        {
            InitializeComponent();
        }


        List<string> articulos = new List<string>();



        #region METODOS
        private void ModificarCompra_Load(object sender, EventArgs e)
        {
            Proveedor prov = new Proveedor();
            ArrayList proveedores = prov.Proveedores();
            for (int i = 0; i < proveedores.Count; i++)
            {
                CB_proveedores.Items.Add(proveedores[i].ToString());
            }
        }

        public void Limpiar()
        {
            TB_compra.Text = "";
            CB_sucursal.SelectedIndex = -1;
            TB_referencia.Text = "";
            TB_proveedor.Text = "";
            CB_proveedores.SelectedIndex = -1;
            TB_saldo.Text = "";
            articulos.Clear();
        }


        public void RecalcularExistencia()
        {

            int entradas = 0;
            int salidas = 0;
            int ex = 0;
            MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());

            MySqlDataReader drRec = null;
            for (int i = 0; i < articulos.Count; i++)
            {
                string query = "SELECT ENT_SAL,CANTIDAD FROM MOVSINV WHERE ARTICULO='" + articulos[i] + "'";
                MySqlCommand recalculo = new MySqlCommand(query, conexion);
                drRec = recalculo.ExecuteReader();
                while (drRec.Read())
                {
                    if (drRec["ENT_SAL"].ToString().Equals("E"))
                    {
                        entradas += Convert.ToInt32(drRec["CANTIDAD"].ToString());
                    }


                    if (drRec["ENT_SAL"].ToString().Equals("S"))
                    {
                        salidas += Convert.ToInt32(drRec["CANTIDAD"].ToString());
                    }
                }
                drRec.Close();
                ex = entradas - salidas;

                string actualizarExistencia = "UPDATE PRODS SET EXISTENCIA =" + ex + " WHERE ARTICULO='" + articulos[i] + "'";

                MySqlCommand actualizar = new MySqlCommand(actualizarExistencia, conexion);
                actualizar.ExecuteNonQuery();
                ex = 0; entradas = 0; salidas = 0;
            }
        }
        #endregion

        #region BOTONES

        private void BT_buscar_Click(object sender, EventArgs e)
        {

            double importe = 0, impuesto = 0,total=0;
            DateTime fechaLlegada;
            try
            {
                if (TB_compra.Text.Equals(""))
                {
                    MessageBox.Show("Captura la compra");
                }else if (CB_sucursal.SelectedIndex==-1)
                {
                    MessageBox.Show("Selecciona la sucursal");
                }
                else
                {

                    MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                    string query = "select * from compras where compra='" + TB_compra.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    Proveedor prov = new Proveedor();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TB_referencia.Text = dr["FACTURA"].ToString();

                        importe = Convert.ToDouble(dr["importe"].ToString());
                        impuesto = Convert.ToDouble(dr["impuesto"].ToString());

                        total = importe + impuesto;
                        TB_saldo.Text = total.ToString("C2");
                        CB_proveedores.SelectedItem = prov.NombreProveedor(dr["proveedor"].ToString());
                        fechaLlegada = Convert.ToDateTime(dr["F_EMISION"]);
                        DT_fecha_llegada.Value = fechaLlegada;

                    }
                    dr.Close();
                   

                    string query2 = "select articulo from partcomp where compra='" + TB_compra.Text + "'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
                   
                    MySqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {

                        articulos.Add(dr2["articulo"].ToString());
                    }
                    dr2.Close();
                    conexion.Close();
                }   
            }
            catch (Exception ex)
            {

                MessageBox.Show("Excepcion controlada al buscar la compra "+ex);
            }
        }

        private void BT_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB_compra.Text.Equals(""))
                {
                    MessageBox.Show("Captura el número de compra");
                }
                else if (CB_sucursal.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona la sucursal");
                }
                else if (TB_referencia.Text.Equals(""))
                {
                    MessageBox.Show("La referencia no debe estar vacía");
                }
                else if (TB_proveedor.Text.Equals(""))
                {
                    MessageBox.Show("Selecciona un proveedor");
                }
                else
                {
                    DateTime f_emision = DT_fecha_llegada.Value;
                    //ACTUALIZAR DATOS DE LA TABLA COMPRAS
                    MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                    string query = "update compras set FACTURA='" + TB_referencia.Text + "', PROVEEDOR='" + TB_proveedor.Text + "', F_EMISION='" + f_emision.ToString("yyyy-MM-dd") + "' WHERE COMPRA='" + TB_compra.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();

                    //ACTUALIZAR DATOS DE LA TABLA CUENXPAG
                    string query2 = "update CUENXPAG set FACTURA='" + TB_referencia.Text + "', PROVEEDOR='" + TB_proveedor.Text + "' WHERE COMPRA='" + TB_compra.Text + "'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
                    cmd2.ExecuteNonQuery();


                    //ACTUALIZAR DATOS DE LA TABLA CUENXPDET
                    string query3 = "update CUENXPDET set NO_REFEREN='" + TB_referencia.Text + "', PROVEEDOR='" + TB_proveedor.Text + "' WHERE COMPRA='" + TB_compra.Text + "'";
                    MySqlCommand cmd3 = new MySqlCommand(query3, conexion);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Se han actualizado los datos de la compra " + TB_compra + " de " + CB_sucursal.SelectedItem.ToString() + "");
                    Limpiar();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la compra " + ex);
            }


        }

        private void BT_eliminar_Click(object sender, EventArgs e)
        {

            if (TB_compra.Text.Equals(""))
            {
                MessageBox.Show("Captura la compra");
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar esta compra?", "Eliminar compra", botones, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    //ELIMINAR COMPRA
                    MySqlConnection conexion = BDConexicon.ConexionSucursal(CB_sucursal.SelectedItem.ToString());
                    string query = "DELETE FROM COMPRAS WHERE COMPRA ='" + TB_compra.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.ExecuteNonQuery();

                    //ELIMINAR PARTCOMP          
                    string query2 = "DELETE FROM partcomp WHERE COMPRA ='" + TB_compra.Text + "'";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
                    cmd2.ExecuteNonQuery();

                    //ELIMINAR CUENTA POR PAGAR          
                    string query3 = "DELETE FROM CUENXPAG WHERE COMPRA ='" + TB_compra.Text + "'";
                    MySqlCommand cmd3 = new MySqlCommand(query3, conexion);
                    cmd3.ExecuteNonQuery();

                    //ELIMINAR CUENTA PENDIENTE          
                    string query4 = "DELETE FROM CUENXPDET WHERE COMPRA ='" + TB_compra.Text + "'";
                    MySqlCommand cmd4 = new MySqlCommand(query4, conexion);
                    cmd4.ExecuteNonQuery();

                    //ELIMINAR EXISTENCIA EN MOVSINV       
                    string query5 = "DELETE FROM MOVSINV WHERE MOVIMIENTO ='" + TB_compra.Text + "' AND TIPO_MOVIM='COM'";
                    MySqlCommand cmd5 = new MySqlCommand(query5, conexion);
                    cmd5.ExecuteNonQuery();

                    RecalcularExistencia();
                    MessageBox.Show("Se ha eliminado la compra " + TB_compra.Text + " de la base de datos");
                    Limpiar();
                }

            }
        }

        #endregion

        #region EVENTOS
        private void CB_proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                string query = "select proveedor from proveed where NOMBRE='" + CB_proveedores.SelectedItem.ToString() + "'";
                MySqlCommand cmd = new MySqlCommand(query, conexion);

                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TB_proveedor.Text = dr["proveedor"].ToString();
                }
                dr.Close();
                conexion.Close();
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }
        }
        #endregion







      
        
    }
}
