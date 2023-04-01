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
    public partial class CalificarHosstess : Form
    {



        int presentacion = 0, saludo = 0, temperatura = 0, info_cliente = 0, paqueteria_limpia = 0, pisos_limpios = 0, muebles_limpios = 0, material_ordenado = 0, etiquetas = 0, material_completo = 0, trabajo_equipo = 0;
        int actividades = 0, saludo_despedida = 0, disponibilidad = 0, iniciativa = 0, entrega_mercancia = 0, letreros_orden = 0, labor_ventas = 0, orientacion = 0, reporte_camaras = 0;

        private void CB_paqueteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_paqueteria.SelectedIndex==-1)
            {

            }
            else
            {
                string nombre = CB_paqueteria.SelectedItem.ToString();


                string query = "SELECT idasesora,apellidos FROM rd_asesoras_venta WHERE nombre='" + nombre + "'";
                MySqlConnection con = BDConexicon.conectar();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["idasesora"].ToString());
                    TB_apellidos.Text = dr["apellidos"].ToString();

                }

                dr.Close();
                con.Close();
            }
        }


        //EL APOYO DIARIO NORMAL ES DE 133.34
        double apoyo_diario = 133.34;
        double descuento = 0;
        int id = 0;
       

        public CalificarHosstess()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {

            presentacion = 0; saludo = 0; temperatura = 0; info_cliente = 0; paqueteria_limpia = 0; pisos_limpios = 0; muebles_limpios = 0; material_ordenado = 0; etiquetas = 0; material_completo = 0; trabajo_equipo = 0;

            actividades = 0; saludo_despedida = 0; disponibilidad = 0; iniciativa = 0; entrega_mercancia = 0; letreros_orden = 0; labor_ventas = 0; orientacion = 0; reporte_camaras = 0;

            descuento = 0;id = 0;

            LB_descuento.Text = "";
            LB_total.Text="";
            TB_apellidos.Text = "";
            CB_paqueteria.SelectedIndex = -1;
            DG_tabla.Rows.Clear();

            DG_tabla.Rows.Add("Presentación (peinado, uniformé, zapatos limpios, fajados )".ToUpper(), "$4.00", 0, 0);
            DG_tabla.Rows.Add("Saludo al cliente".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Toma de temperatura e informacion de gel".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Informacion al cliente sobre etiqueta y revision ala salida.".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Paqueteria limpia".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Pisos limpios".ToUpper(), "$3.00", 0, 0);
            DG_tabla.Rows.Add("Muebles limpios".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Material de trabajo ordenado".ToUpper(), "$3.00", 0, 0);
            DG_tabla.Rows.Add("Etiquetas completas".ToUpper(), "$4.00", 0, 0);
            DG_tabla.Rows.Add("Material completo y en buen estado".ToUpper(), "$3.00", 0, 0);
            DG_tabla.Rows.Add("Trabajo en equipo".ToUpper(), "$8.00", 0, 0);
            DG_tabla.Rows.Add("Realizar actividades asignadas".ToUpper(), "$6.00", 0, 0);
            DG_tabla.Rows.Add("Saludo y despedida al cliente".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Disponibilidad de hacer las cosas".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Iniciativa de modificar su área".ToUpper(), "$6.00", 0, 0);
            DG_tabla.Rows.Add("Entrega de mercancia de cliente completa".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Exhibicion de letreros en orden, limpios y visibles".ToUpper(), "$3.00", 0, 0);
            DG_tabla.Rows.Add("Labor de ventas".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Orientacion al cliente sobre articulo que desea.".ToUpper(), "$3.00", 0, 0);
            DG_tabla.Rows.Add("Reportes en cámaras".ToUpper(), "$12.00", 0, 0);
        }


        public void EmpPaqueteria()
        {
            string nombre = "", apellidos = "";
            string query = "SELECT idasesora,nombre,apellidos FROM rd_asesoras_venta WHERE puesto='PAQUETERIA' || puesto='HOSTESS'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt32(dr["idasesora"].ToString());
                nombre = dr["nombre"].ToString();
                apellidos = dr["apellidos"].ToString();
                CB_paqueteria.Items.Add(nombre);
            }

            dr.Close();
            con.Close();

        }

        private void CalificarHosstess_Load(object sender, EventArgs e)
        {


            EmpPaqueteria();


            DG_tabla.Rows.Add("Presentación (peinado, uniformé, zapatos limpios, fajados )".ToUpper(),"$6.00",0,0);
            DG_tabla.Rows.Add("Saludo al cliente".ToUpper(), "$7.00", 0, 0);
            DG_tabla.Rows.Add("Toma de temperatura e informacion de gel".ToUpper(), "$7.00", 0, 0);
            DG_tabla.Rows.Add("Informacion al cliente sobre etiqueta y revision ala salida.".ToUpper(), "$7.00", 0, 0);
            DG_tabla.Rows.Add("Paqueteria limpia".ToUpper(), "$7.00", 0, 0);
            DG_tabla.Rows.Add("Pisos limpios".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Muebles limpios".ToUpper(), "$7.00", 0, 0);
            DG_tabla.Rows.Add("Material de trabajo ordenado".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Etiquetas completas".ToUpper(), "$6.00", 0, 0);
            DG_tabla.Rows.Add("Material completo y en buen estado".ToUpper(), "$5.00", 0, 0);
            DG_tabla.Rows.Add("Trabajo en equipo".ToUpper(), "$10.00", 0, 0);
            DG_tabla.Rows.Add("Realizar actividades asignadas".ToUpper(), "$9.00", 0, 0);
            DG_tabla.Rows.Add("Saludo y despedida al cliente".ToUpper(), "$8.00", 0, 0);
            DG_tabla.Rows.Add("Disponibilidad de hacer las cosas".ToUpper(), "$6.00", 0, 0);
            DG_tabla.Rows.Add("Iniciativa de modificar su área".ToUpper(), "$6.00", 0, 0);
            DG_tabla.Rows.Add("Entrega de mercancia de cliente completa".ToUpper(), "$6.00", 0, 0);
            DG_tabla.Rows.Add("Exhibicion de letreros en orden, limpios y visibles".ToUpper(), "$4.00", 0, 0);
            DG_tabla.Rows.Add("Labor de ventas".ToUpper(), "$6.00", 0, 0);
            DG_tabla.Rows.Add("Orientacion al cliente sobre articulo que desea.".ToUpper(), "$4.00", 0, 0);
            DG_tabla.Rows.Add("Reportes en cámaras".ToUpper(), "$12.00", 0, 0);


        }

        private void BT_calcular_Click(object sender, EventArgs e)
        {
            presentacion = Convert.ToInt32(DG_tabla.Rows[0].Cells[2].Value);
            saludo = Convert.ToInt32(DG_tabla.Rows[1].Cells[2].Value);
            temperatura = Convert.ToInt32(DG_tabla.Rows[2].Cells[2].Value);
            info_cliente = Convert.ToInt32(DG_tabla.Rows[3].Cells[2].Value);
            paqueteria_limpia = Convert.ToInt32(DG_tabla.Rows[4].Cells[2].Value);
            pisos_limpios = Convert.ToInt32(DG_tabla.Rows[5].Cells[2].Value);
            muebles_limpios = Convert.ToInt32(DG_tabla.Rows[6].Cells[2].Value);
            material_ordenado = Convert.ToInt32(DG_tabla.Rows[7].Cells[2].Value);
            etiquetas = Convert.ToInt32(DG_tabla.Rows[8].Cells[2].Value);
            material_completo = Convert.ToInt32(DG_tabla.Rows[9].Cells[2].Value);
            trabajo_equipo = Convert.ToInt32(DG_tabla.Rows[10].Cells[2].Value);
            actividades = Convert.ToInt32(DG_tabla.Rows[11].Cells[2].Value);
            saludo_despedida = Convert.ToInt32(DG_tabla.Rows[12].Cells[2].Value);
            disponibilidad = Convert.ToInt32(DG_tabla.Rows[13].Cells[2].Value);
            iniciativa = Convert.ToInt32(DG_tabla.Rows[14].Cells[2].Value);
            entrega_mercancia = Convert.ToInt32(DG_tabla.Rows[15].Cells[2].Value);
            letreros_orden = Convert.ToInt32(DG_tabla.Rows[16].Cells[2].Value);
            labor_ventas = Convert.ToInt32(DG_tabla.Rows[17].Cells[2].Value);
            orientacion = Convert.ToInt32(DG_tabla.Rows[18].Cells[2].Value);
            reporte_camaras = Convert.ToInt32(DG_tabla.Rows[19].Cells[2].Value);

            DG_tabla.Rows[0].Cells[3].Value = presentacion * 6;
            DG_tabla.Rows[1].Cells[3].Value = saludo * 7;
            DG_tabla.Rows[2].Cells[3].Value = temperatura * 7;
            DG_tabla.Rows[3].Cells[3].Value = info_cliente * 7;
            DG_tabla.Rows[4].Cells[3].Value = paqueteria_limpia * 7;
            DG_tabla.Rows[5].Cells[3].Value = pisos_limpios * 5;
            DG_tabla.Rows[6].Cells[3].Value = muebles_limpios * 7;
            DG_tabla.Rows[7].Cells[3].Value = material_ordenado * 5;
            DG_tabla.Rows[8].Cells[3].Value = etiquetas * 6;
            DG_tabla.Rows[9].Cells[3].Value = material_completo * 5;
            DG_tabla.Rows[10].Cells[3].Value = trabajo_equipo * 10;
            DG_tabla.Rows[11].Cells[3].Value = actividades * 9;
            DG_tabla.Rows[12].Cells[3].Value = saludo_despedida * 8;
            DG_tabla.Rows[13].Cells[3].Value = disponibilidad * 6;
            DG_tabla.Rows[14].Cells[3].Value = iniciativa * 6;
            DG_tabla.Rows[15].Cells[3].Value = entrega_mercancia * 6;
            DG_tabla.Rows[16].Cells[3].Value = letreros_orden * 4;
            DG_tabla.Rows[17].Cells[3].Value = labor_ventas * 6;
            DG_tabla.Rows[18].Cells[3].Value = orientacion * 4;
            DG_tabla.Rows[19].Cells[3].Value = reporte_camaras * 12;


        
            for (int i = 0; i < DG_tabla.RowCount; i++)
            {
                descuento += Convert.ToInt32(DG_tabla.Rows[i].Cells[3].Value);
            }

            if (descuento>apoyo_diario)
            {
                descuento = apoyo_diario;
            }

            LB_descuento.Text = Convert.ToString(descuento);
            LB_total.Text = Convert.ToString(apoyo_diario - descuento);


            presentacion = 0; saludo = 0; temperatura = 0; info_cliente = 0; paqueteria_limpia = 0; pisos_limpios = 0; muebles_limpios = 0; material_ordenado = 0; etiquetas = 0; material_completo = 0; trabajo_equipo = 0;

            actividades = 0; saludo_despedida = 0; disponibilidad = 0; iniciativa = 0; entrega_mercancia = 0; letreros_orden = 0; labor_ventas = 0; orientacion = 0; reporte_camaras = 0;

            descuento = 0;

        }

        public bool validarCalificacion()
        {
            bool indicador = false;
            DateTime fecha = DT_fecha.Value;
            int idEmpleado = 0;
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT idreg FROM rd_calificacion_emp_paqueteria WHERE FECHA='"+fecha.ToString("yyyy-MM-dd")+"' AND idEmpleado='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                idEmpleado = Convert.ToInt32(dr["idreg"].ToString());
                indicador = true;
            }
            dr.Close();
            conexion.Close();

            return indicador;
        }

        private void BT_guardar_Click(object sender, EventArgs e)
        {

            bool indicador = validarCalificacion();


            DateTime fecha = DT_fecha.Value;
   

            string query = "INSERT INTO rd_calificacion_emp_paqueteria(idEmpleado,presentacion,saludo_cliente,toma_temperatura,info_cliente,paqueteria_limpia,pisos_limpios,muebles_limpios,material_ordenado,etiquetas_completas,material_completo," +
                "trabajo_equipo,actividades_asignadas,saludo_despedida,disponibilidad,iniciativa,entrega_mercancia,letreros_orden,labor_venta,orientacion,reporte_camaras,total_descuento,totalPagar,fecha)" +
                "VALUES(?idEmpleado,?presentacion,?saludo_cliente,?toma_temperatura,?info_cliente,?paqueteria_limpia,?pisos_limpios,?muebles_limpios,?material_ordenado,?etiquetas_completas,?material_completo," +
                "?trabajo_equipo,?actividades_asignadas,?saludo_despedida,?disponibilidad,?iniciativa,?entrega_mercancia,?letreros_orden,?labor_venta,?orientacion,?reporte_camaras,?total_descuento,?totalPagar,?fecha)";


            if (indicador == true)
            {
                MessageBox.Show("El empleado ya fue calificado el día seleccionado, elige otra fecha");
            }
            else
            {
                MySqlConnection conectar = BDConexicon.conectar();

                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.Parameters.AddWithValue("?idEmpleado", id);
                cmd.Parameters.AddWithValue("?presentacion", DG_tabla.Rows[0].Cells[3].Value);
                cmd.Parameters.AddWithValue("?saludo_cliente", DG_tabla.Rows[1].Cells[3].Value);
                cmd.Parameters.AddWithValue("?toma_temperatura", DG_tabla.Rows[2].Cells[3].Value);
                cmd.Parameters.AddWithValue("?info_cliente", DG_tabla.Rows[3].Cells[3].Value);
                cmd.Parameters.AddWithValue("?paqueteria_limpia", DG_tabla.Rows[4].Cells[3].Value);
                cmd.Parameters.AddWithValue("?pisos_limpios", DG_tabla.Rows[4].Cells[3].Value);
                cmd.Parameters.AddWithValue("?muebles_limpios", DG_tabla.Rows[6].Cells[3].Value);
                cmd.Parameters.AddWithValue("?material_ordenado", DG_tabla.Rows[7].Cells[3].Value);
                cmd.Parameters.AddWithValue("?etiquetas_completas", DG_tabla.Rows[8].Cells[3].Value);
                cmd.Parameters.AddWithValue("?material_completo", DG_tabla.Rows[9].Cells[3].Value);
                cmd.Parameters.AddWithValue("?trabajo_equipo", DG_tabla.Rows[10].Cells[3].Value);
                cmd.Parameters.AddWithValue("?actividades_asignadas", DG_tabla.Rows[11].Cells[3].Value);
                cmd.Parameters.AddWithValue("?saludo_despedida", DG_tabla.Rows[12].Cells[3].Value);
                cmd.Parameters.AddWithValue("?disponibilidad", DG_tabla.Rows[13].Cells[3].Value);
                cmd.Parameters.AddWithValue("?iniciativa", DG_tabla.Rows[14].Cells[3].Value);
                cmd.Parameters.AddWithValue("?entrega_mercancia", DG_tabla.Rows[15].Cells[3].Value);
                cmd.Parameters.AddWithValue("?letreros_orden", DG_tabla.Rows[16].Cells[3].Value);
                cmd.Parameters.AddWithValue("?labor_venta", DG_tabla.Rows[17].Cells[3].Value);
                cmd.Parameters.AddWithValue("?orientacion", DG_tabla.Rows[18].Cells[3].Value);
                cmd.Parameters.AddWithValue("?reporte_camaras", DG_tabla.Rows[19].Cells[3].Value);
                cmd.Parameters.AddWithValue("?total_descuento", Convert.ToUInt32(LB_descuento.Text));
                cmd.Parameters.AddWithValue("?totalPagar", Convert.ToDouble(LB_total.Text));
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));

                cmd.ExecuteNonQuery();

                Limpiar();
                MessageBox.Show("Se ha guardado la calificacion");

            }



        }
    }
}
