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
    public partial class CrearProveedor : Form
    {


#pragma warning disable CS0414 // El campo 'CrearProveedor.usuario' está asignado pero su valor nunca se usa
        string usuario = "";
#pragma warning restore CS0414 // El campo 'CrearProveedor.usuario' está asignado pero su valor nunca se usa
        public CrearProveedor()
        {
            //this.usuario = usuario;
            InitializeComponent();
        }


#pragma warning disable CS0414 // El campo 'CrearProveedor.id' está asignado pero su valor nunca se usa
        int id = 0;
#pragma warning restore CS0414 // El campo 'CrearProveedor.id' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'CrearProveedor.cadenaid' está asignado pero su valor nunca se usa
        string cadenaid = "";
#pragma warning restore CS0414 // El campo 'CrearProveedor.cadenaid' está asignado pero su valor nunca se usa
       
        private void CrearProveedor_Load(object sender, EventArgs e)
        {




            //MySqlConnection conexion = BDConexicon.BodegaOpen();
            MySqlConnection conexion = BDConexicon.conectar();
            string query="select PROVEEDOR from proveed where NOMBRE='PARA OTRO PROVEEDOR'";
            string query2 = "select nombre from proveed order by nombre";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CB_numeros_disponibles.Items.Add(dr["PROVEEDOR"].ToString());
            }
            dr.Close();



            MySqlCommand cmd2 = new MySqlCommand(query2,conexion);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CB_proveedor.Items.Add(dr2["nombre"].ToString());
            }
            dr2.Close();
            conexion.Close();

            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       


        #region METODOS

        public void ModifcarProveedor(string Id)
        {
            MySqlConnection con = null;
            MySqlCommand cmd = null;
            MySqlCommand cmdva = null;
            MySqlCommand cmdre = null;
            MySqlCommand cmdve = null;
            MySqlCommand cmdco = null;
            TB_ce.BackColor = Color.White;
            TB_va.BackColor = Color.White;
            TB_re.BackColor = Color.White;
            TB_ve.BackColor = Color.White;
            TB_co.BackColor = Color.White;
            string consulta = "update proveed set nombre='"+ TB_nombremodificar.Text+"', dias='"+ TB_creditomodificar.Text + "' where proveedor='"+Id+"'";

            try
            {
                con = BDConexicon.BodegaOpen();
                cmd = new MySqlCommand(consulta,con);
                cmd.ExecuteNonQuery();
                TB_ce.BackColor = Color.Green;
            }
            catch (Exception ex)
            {

                TB_ce.BackColor = Color.Red;
                MessageBox.Show("ERROR"+ex);
            }

            try
            {
                con = BDConexicon.VallartaOpen();
                cmdva = new MySqlCommand(consulta, con);
                cmdva.ExecuteNonQuery();
                TB_va.BackColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                TB_va.BackColor = Color.Red;
            }

            try
            {
                con = BDConexicon.RenaOpen();
                cmdre = new MySqlCommand(consulta, con);
                cmdre.ExecuteNonQuery();
                TB_re.BackColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                TB_re.BackColor = Color.Red;
            }

            try
            {
                con = BDConexicon.VelazquezOpen();
                cmdve = new MySqlCommand(consulta, con);
                cmdve.ExecuteNonQuery();
                TB_ve.BackColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                TB_ve.BackColor = Color.Red;
            }

            try
            {
                con = BDConexicon.ColosoOpen();
                cmdco = new MySqlCommand(consulta, con);
                cmdco.ExecuteNonQuery();
                TB_co.BackColor = Color.Green;
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                TB_co.BackColor = Color.Red;
            }
        }

        //public void EliminarProveedor()
        //{
            

        //    MySqlConnection con = null;
        //    MySqlCommand cmd = null;
        //    MySqlCommand cmdva = null;
        //    MySqlCommand cmdre = null;
        //    MySqlCommand cmdve = null;
        //    MySqlCommand cmdco = null;

        //    string consulta = "delete from proveed where proveedor ='"+TB_id_eliminar.Text+"'";

        //    try
        //    {
        //        con = BDConexicon.BodegaOpen();
        //        cmd = new MySqlCommand(consulta, con);
        //        cmd.ExecuteNonQuery();
        //        TB_ce.BackColor = Color.Green;
        //    }
        //    catch (Exception ex)
        //    {

        //        TB_ce.BackColor = Color.Red;
        //    }

        //    try
        //    {
        //        con = BDConexicon.VallartaOpen();
        //        cmdva = new MySqlCommand(consulta, con);
        //        cmdva.ExecuteNonQuery();
        //        TB_va.BackColor = Color.Green;
        //    }
        //    catch (Exception ex)
        //    {

        //        TB_va.BackColor = Color.Red;
        //    }

        //    try
        //    {
        //        con = BDConexicon.RenaOpen();
        //        cmdre = new MySqlCommand(consulta, con);
        //        cmdre.ExecuteNonQuery();
        //        TB_re.BackColor = Color.Green;
        //    }
        //    catch (Exception ex)
        //    {

        //        TB_re.BackColor = Color.Red;
        //    }

        //    try
        //    {
        //        con = BDConexicon.VelazquezOpen();
        //        cmdve = new MySqlCommand(consulta, con);
        //        cmdve.ExecuteNonQuery();
        //        TB_ve.BackColor = Color.Green;
        //    }
        //    catch (Exception ex)
        //    {

        //        TB_ve.BackColor = Color.Red;
        //    }

        //    try
        //    {
        //        con = BDConexicon.ColosoOpen();
        //        cmdco = new MySqlCommand(consulta, con);
        //        cmdco.ExecuteNonQuery();
        //        TB_co.BackColor = Color.Green;
        //    }
        //    catch (Exception ex)
        //    {

        //        TB_co.BackColor = Color.Red;
        //    }


        //}
        #endregion

       

        #region BOTONES
        private void BT_guardar_Click(object sender, EventArgs e)
        {
           
        }

        private void BT_modificar_Click(object sender, EventArgs e)
        {
            ModifcarProveedor(CB_numeros_disponibles.SelectedItem.ToString());

        }
        #endregion

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
         
        }

        private void CB_prov_eliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        //ELIMINAR PROVEEDOR
        private void button1_Click(object sender, EventArgs e)
        {
            //EliminarProveedor();
        }

        private void BT_guardar_Click_1(object sender, EventArgs e)
        {
            LB_mensaje.Text = "";
            TB_ce.BackColor = Color.White;
            TB_va.BackColor = Color.White;
            TB_re.BackColor = Color.White;
            TB_ve.BackColor = Color.White;
            TB_co.BackColor = Color.White;
            string query = "INSERT INTO fabricantes(fabricante,nombre)VALUES(?fabricante,?nombre)";
            MySqlConnection conexion = null;

           

           
            int longitud = TB_fabricante.Text.Length;
            if (longitud>20)
            {
                LB_mensaje.Text = "El nombre del fabricante no debe sobrepasar los 20 caracteres";
                LB_mensaje.ForeColor = Color.Red;
            }
            else
            {

                try
                {
                    //CREAR FABRICANTE EN CEDIS
                    conexion = BDConexicon.BodegaOpen();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("?fabricante", TB_fabricante.Text);
                    cmd.Parameters.AddWithValue("?nombre", CB_proveedor.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    LB_mensaje.Text = "Se ha creado el nuevo fabricante";
                    LB_mensaje.ForeColor = Color.Green;
                    conexion.Close();
                    TB_ce.BackColor = Color.Green;
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    TB_ce.BackColor = Color.Red;
                }

                try
                {
                    //CREAR FABRICANTE EN VALLARTA
                    conexion = BDConexicon.VallartaOpen();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("?fabricante", TB_fabricante.Text);
                    cmd.Parameters.AddWithValue("?nombre", CB_proveedor.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    LB_mensaje.Text = "Se ha creado el nuevo fabricante";
                    LB_mensaje.ForeColor = Color.Green;
                    conexion.Close();
                    TB_va.BackColor = Color.Green;
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    TB_va.BackColor = Color.Red;
                }

                try
                {
                    //CREAR FABRICANTE EN RENA
                    conexion = BDConexicon.RenaOpen();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("?fabricante", TB_fabricante.Text);
                    cmd.Parameters.AddWithValue("?nombre", CB_proveedor.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    LB_mensaje.Text = "Se ha creado el nuevo fabricante";
                    LB_mensaje.ForeColor = Color.Green;
                    conexion.Close();
                    TB_re.BackColor = Color.Green;
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    TB_re.BackColor = Color.Red;
                }

                try
                {
                    //CREAR FABRICANTE EN VELAZQUEZ
                    conexion = BDConexicon.VelazquezOpen();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("?fabricante", TB_fabricante.Text);
                    cmd.Parameters.AddWithValue("?nombre", CB_proveedor.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    LB_mensaje.Text = "Se ha creado el nuevo fabricante";
                    LB_mensaje.ForeColor = Color.Green;
                    conexion.Close();
                    TB_ve.BackColor = Color.Green;
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    TB_ve.BackColor = Color.Red;
                }

                try
                {
                    //CREAR FABRICANTE EN COLOSO
                    conexion = BDConexicon.ColosoOpen();
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("?fabricante", TB_fabricante.Text);
                    cmd.Parameters.AddWithValue("?nombre", CB_proveedor.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    LB_mensaje.Text = "Se ha creado el nuevo fabricante";
                    LB_mensaje.ForeColor = Color.Green;
                    conexion.Close();
                    TB_co.BackColor = Color.Green;
                }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                {

                    TB_co.BackColor = Color.Red;
                }

            }
           
        }

        private void BT_recargar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query2 = "select nombre from proveed order by nombre";
            MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                CB_proveedor.Items.Add(dr2["nombre"].ToString());
            }
            dr2.Close();
            conexion.Close();
        }
    }
}
