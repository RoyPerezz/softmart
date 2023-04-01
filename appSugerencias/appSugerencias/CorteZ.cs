using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace appSugerencias
{
    public partial class CorteZ : Form
    {
        public CorteZ()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void CorteZ_Load(object sender, EventArgs e)
        {
           
        }

        string sucursal = "";
        string patron = "";
        string rfc = "";
        string direccion = "";
        string telefono = "";
        string cp = "";
        double importeTarj = 0,importeEfe=0;
        int folio = 0;

        public void DatosFiscales()
        {
            string sucursal = CB_sucursal.SelectedItem.ToString();
            if (sucursal.Equals("VALLARTA"))
            {
                sucursal = "Osmart Vallarta";
                patron = "MARICELA LOPEZ LORENZO";
                rfc = "RFC LOLM-851128-AV2";
                direccion = "AV. VALLARTA 25 COL. PROGRESO ";
                cp = "ACAPULCO GRO.   CP 39350 ";
                telefono = "TEL: 4-85-35-34";

            }

            if (sucursal.Equals("RENA"))
            {
              

                sucursal = "OSMART RENACIMIENTO";
                patron = "GEORGINA LAGUNAS ESCOBEDO";
                rfc = " RFC LAEG-870303-PZ8";
                direccion = "BLVD.VICENTE GUERRERO Lt.9 \n COL. LIBERTADORES ";
                cp = " ACAPULCO GRO.   CP 39700 ";
                telefono = "TEL: 1-88-01-24";
            }

            if (sucursal.Equals("VELAZQUEZ"))
            {


                sucursal = "OSMART MINA";
                patron = "MIGUEL ANGEL REZA FLORES";
                rfc = "RFC REFM-830818-584";
                direccion = "VELAZQUEZ DE LEON  No.17 \n COL. CENTRO  ";
                cp = " ACAPULCO GRO.    CP 39300  ";
                telefono = "TEL: 74-46-88-66-42";
            }

            if (sucursal.Equals("COLOSO"))
            {


                sucursal = "Osmart Coloso";
                patron = "GERMAN BENITEZ GALLARDO";
                rfc = "RFC BEGG-891023-Q52";
                direccion = "CARR.CAYACO-PTO.MARQUES No.58 LOCAL A \n COL. POTRERO DE LA MORA  ";
                cp = " ACAPULCO GRO.   CP 39810    ";
                telefono = "TEL: 6-88-19-67";
            }

            if (sucursal.Equals("PREGOT"))
            {
                sucursal = "PAPELERIA PREGOT";
                patron = " ASUNCION REZA ARZATE";
                rfc = "RFC REAA650527MD5";
                direccion = " CALLE MINA No. 7 COL. CENTRO  ";
                cp = " ACAPULCO GRO.   CP 39300    ";
                //telefono = "TEL: 6-88-19-67";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.
            DatosFiscales();


            //obtener importe de efectivo que capture el usuario
            string concepto = "";
            for (int i = 0; i < DG_ingresos.RowCount; i++)
            {
                concepto = Convert.ToString(DG_ingresos.Rows[i].Cells[0].Value);
                if (concepto.Equals("EFE Pago de clientes"))
                {
                    importeEfe = Convert.ToDouble(DG_ingresos.Rows[i].Cells[1].Value);
                }
            }


            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo


            ticket.TextoCentro("****corte z en moneda mn****");
            ticket.TextoCentro(sucursal);
            ticket.TextoCentro(patron);
            ticket.TextoCentro(rfc);
            ticket.TextoCentro(direccion);
            ticket.TextoCentro(cp);
            ticket.TextoCentro(telefono);


            folio = ObtenerFolio();
            double totalIng = importeTarj + importeEfe;
            ticket.TextoIzquierda("Corte z #"+folio);
            ticket.TextoExtremos(CB_caja.SelectedItem.ToString() + " FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.TextoIzquierda("** Ingresos **");
            ticket.TextoExtremos("EFE Pago de clientes", "$"+importeTarj);
            ticket.TextoExtremos("TAR Pago de clientes", "$"+ importeEfe);
            ticket.lineasAsteriscos();
            ticket.TextoExtremos("Total de Ingresos:", "$"+ totalIng);
            ticket.TextoIzquierda("**Egresos**");

            //aqui va todos los conceptos de egresos de la caja
            string conceptoEgre = "";
            double importeEgre = 0;
            double totalEgre = 0;

            for (int i = 0; i < DG_egresos.Rows.Count; i++)
            {
                conceptoEgre = Convert.ToString(DG_egresos.Rows[i].Cells[0].Value);
                importeEgre = Convert.ToDouble(DG_egresos.Rows[i].Cells[1].Value);
                ticket.TextoExtremos(conceptoEgre," $" + importeEgre);
                //ticket.TextoDerecha(" $" + importeEgre);
                totalEgre += importeEgre;
            }

            ticket.lineasAsteriscos();
            ticket.TextoExtremos("Total de Egresos:"," $"+totalEgre);
            ticket.lineasAsteriscos();
            ticket.lineasAsteriscos();
            ticket.TextoExtremos("Total de Caja:","$"+(totalIng-totalEgre));
            ticket.lineasAsteriscos();
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("**********VENTAS DEL CORTE**********");
            ticket.TextoIzquierda("Ventas 15%        :       $.00 ");
            ticket.TextoIzquierda("Impuesto 15%      :       $.00 ");
            ticket.TextoIzquierda("Ventas 10%        :       $.00 ");
            ticket.TextoIzquierda("Impuesto 10%      :       $.00 ");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("Ventas gravadas   :       $.00 ");
            ticket.TextoIzquierda("Impuesto          :       $.00 ");
            ticket.TextoIzquierda("Ventas no gravadas:       $.00 ");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("Redondeos         :       $.00 ");
            ticket.TextoIzquierda("Total Ventas      :       $.00 ");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("Ventas Credito      :       $.00 ");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("**Cheques del dia**");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("Total de vales emitidos      :       $.00 ");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("Total de vales de cambio     :       $.00 ");
            ticket.lineasAsteriscos();
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("**********Cobranza del día**********");
            ticket.TextoIzquierda("PAGO                           SALDO");
            ticket.lineasAsteriscos();
            ticket.TextoIzquierda("Ingreso por cobranza            $.00");
            ticket.TextoIzquierda("Clientes atendidos:"+TB_numClientes.Text);

            ticket.lineasAsteriscos();
    
            ticket.CortaTicket();
            //ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
            dt.Clear();
            GuardarTicket();

        }

        private void DG_ingresos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string clave = "";
            try
            {
                clave = Convert.ToString(DG_ingresos.Rows[e.RowIndex].Cells["CLAVE"].Value);
            }
#pragma warning disable CS0168 // La variable 'EX' se ha declarado pero nunca se usa
            catch (Exception EX)
#pragma warning restore CS0168 // La variable 'EX' se ha declarado pero nunca se usa
            {


            }

            if (clave.Equals("TAR Pago de clientes"))
            {
                DG_ingresos.Rows[e.RowIndex].Cells["IMPORTE"].Value = Convert.ToString(importeTarj);
                SendKeys.Send("{Tab}");
            }
            //if (clave.Equals("TAR"))
            //{
            //    DG_ingresos.Rows[e.RowIndex].Cells["DESCRIPCION"].Value = "Pago de clientes";
            //}
            //if (clave.Equals("SOBRA"))
            //{
            //    DG_ingresos.Rows[e.RowIndex].Cells["DESCRIPCION"].Value = "SOBRANTE";
            //}
        }

        public string Mes(int m)
        {
            string mes = "";

            if (m==1)
            {
                mes = "ENE";
            }
            if (m == 2)
            {
                mes = "FEB";
            }
            if (m == 3)
            {
                mes = "MAR";
            }
            if (m == 4)
            {
                mes = "ABR";
            }
            if (m == 5)
            {
                mes = "MAY";
            }
            if (m == 6)
            {
                mes = "JUN";
            }
            if (m == 7)
            {
                mes = "JUL";
            }
            if (m == 8)
            {
                mes = "AGO";
            }
            if (m == 9)
            {
                mes = "SEP";
            }
            if (m == 10)
            {
                mes = "OCT";
            }
            if (m == 11)
            {
                mes = "NOV";
            }
            if (m == 12)
            {
                mes = "DIC";
            }
            return mes;
        }




        public int ObtenerFolio()
        {
           
            string query = "";
            MySqlConnection conexion = null;
            string mes = "";
            int numMes = 0;
            int año = 0;
            DateTime fecha = DT_fecha.Value;
            numMes = fecha.Month;
            mes = Mes(numMes);
            año = fecha.Year;
            if (CBX_respaldo.Checked == true)
            {
                if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.RespaldoBO(mes, año);
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.RespaldoRE(mes, año);
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.RespaldoVE(mes, año);
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.RespaldoCO(mes, año);
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("PREGOT"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.RespaldoPRE(mes, año);
                }
            }
            else
            {
                if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.VallartaOpen();
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.RenaOpen();
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.VelazquezOpen();
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.ColosoOpen();
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("PREGOT"))
                {
                    query = "SELECT Consec FROM consec where Dato= 'cortezFolio'";
                    conexion = BDConexicon.Papeleria1Open();
                }
            }

            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                folio = Convert.ToInt32(dr["Consec"].ToString());
            }
            dr.Close();
            try
            {
                string actualizar = "UPDATE consec SET Consec ='"+(folio+1)+"' WHERE Dato='cortezFolio'";
                MySqlCommand cmd2 = new MySqlCommand(actualizar, conexion);
                cmd2.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el folio del cortez en  " + CB_sucursal.SelectedItem.ToString()+"ERROR"+ex);
            }
        

            return folio+1;
        }


        public void GuardarTicket()
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string corte = "INSERT INTO rd_cortez(estacion,folio,sucursal,fecha,hora,pagoefe,pagotarj,totaling,totalegr,totalcaja,numclientes)VALUES(?estacion,?folio,?sucursal,?fecha,?hora,?pagoefe,?pagotarj,?totaling,?totalegr,?totalcaja,?numclientes)";
            string egresos = "INSERT INTO rd_egresos_cortez(idcortez,concepto,importe)VALUES(?idcortez,?concepto,?importe)";
            DateTime fecha = DT_fecha.Value;
            //folio = ObtenerFolio();
            try
            {
                MySqlCommand cmd = new MySqlCommand(corte, conexion);
                cmd.Parameters.AddWithValue("?estacion", CB_caja.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?folio", folio);
                cmd.Parameters.AddWithValue("?sucursal",CB_sucursal.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?hora", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("?pagoefe", importeEfe);
                cmd.Parameters.AddWithValue("?pagotarj", importeTarj);
                cmd.Parameters.AddWithValue("?totaling", (importeEfe + importeTarj));
                cmd.Parameters.AddWithValue("?totalegr", (importeEfe + importeTarj));
                cmd.Parameters.AddWithValue("?totalcaja", 0);
                cmd.Parameters.AddWithValue("?numclientes", TB_numClientes.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos del corte z: " + ex);

            }

            //**********OBTENER IDCORTE*************************

            int id = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            string consulta = "SELECT max(idcortez) as idcortez FROM rd_cortez";
            MySqlCommand comand = new MySqlCommand(consulta, con);
            MySqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["idcortez"].ToString());
            }
            //**************************************************
            reader.Close();

            string concepto = "";
            double importe = 0;
            try
            {
                for (int i = 0; i < DG_egresos.RowCount-1; i++)
                {
                    concepto = Convert.ToString(DG_egresos.Rows[i].Cells[0].Value);
                    importe = Convert.ToDouble(DG_egresos.Rows[i].Cells[1].Value);
                    MySqlCommand cmd = new MySqlCommand(egresos, conexion);
                    cmd.Parameters.AddWithValue("?idcortez", id);
                    cmd.Parameters.AddWithValue("?concepto", concepto);
                    cmd.Parameters.AddWithValue("?importe", importe);
                    cmd.ExecuteNonQuery();

                }

                MessageBox.Show("Se ha guardado el corte z de la caja "+CB_caja.SelectedItem.ToString()+" de "+CB_sucursal.SelectedItem.ToString());
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Error al guardar los egresos del corte z: " + id);

            }
        }

        private void BT_guardarTicket_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string corte = "INSERT INTO rd_cortez(estacion,folio,sucursal,fecha,hora,pagoefe,pagotarj,totaling,totalegr,totalcaja,numclientes)VALUES(?estacion,?folio,?sucursal,?fecha,?hora,?pagoefe,?pagotarj,?totaling,?totalegr,?totalcaja,?numclientes)";
            string egresos = "INSERT INTO rd_egresos_cortez(idcortez,concepto,importe)VALUES(?idcortez,?concepto,?importe)";
            DateTime fecha = DT_fecha.Value;
            folio = ObtenerFolio();
            try
            {
                MySqlCommand cmd = new MySqlCommand(corte, conexion);
                cmd.Parameters.AddWithValue("?estacion", CB_caja.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?folio", folio);
                cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("?fecha", fecha.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("?hora", DateTime.Now.ToShortTimeString());
                cmd.Parameters.AddWithValue("?pagoefe", importeEfe);
                cmd.Parameters.AddWithValue("?pagotarj", importeTarj);
                cmd.Parameters.AddWithValue("?totaling", (importeEfe + importeTarj));
                cmd.Parameters.AddWithValue("?totalegr", (importeEfe + importeTarj));
                cmd.Parameters.AddWithValue("?totalcaja", 0);
                cmd.Parameters.AddWithValue("?numclientes", TB_numClientes.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos del corte z: " + ex);

            }

            //**********OBTENER IDCORTE*************************

            int id = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            string consulta = "SELECT max(idcortez) as idcortez FROM rd_cortez";
            MySqlCommand comand = new MySqlCommand(consulta, con);
            MySqlDataReader reader = comand.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["idcortez"].ToString());
            }
            //**************************************************
            reader.Close();

            string concepto = "";
            double importe = 0;
            try
            {
                for (int i = 0; i < DG_egresos.RowCount; i++)
                {
                    concepto = Convert.ToString(DG_egresos.Rows[i].Cells[0].Value);
                    importe = Convert.ToDouble(DG_egresos.Rows[i].Cells[1].Value);
                    MySqlCommand cmd = new MySqlCommand(egresos, conexion);
                    cmd.Parameters.AddWithValue("?idcortez", id);
                    cmd.Parameters.AddWithValue("?concepto", concepto);
                    cmd.Parameters.AddWithValue("?importe", importe);
                    cmd.ExecuteNonQuery();

                }

               
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                MessageBox.Show("Error al guardar los egresos del corte z: " + id);

            }


        }

        private void BT_ventasTarj_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = null;
            DateTime fecha = DT_fecha.Value;
            string mes = Mes(fecha.Month);
            int año = fecha.Year;


            if (CBX_respaldo.Checked==true)
            {
                if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                {
                    conexion = BDConexicon.RespaldoVA(mes,año);
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                {
                    conexion = BDConexicon.RespaldoRE(mes, año);
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                {
                    conexion = BDConexicon.RespaldoVE(mes, año);
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                {
                    conexion = BDConexicon.RespaldoCO(mes, año);
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("PREGOT"))
                {
                    conexion = BDConexicon.RespaldoPRE(mes, año);
                }
            }
            else
            {
                if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
                {
                    conexion = BDConexicon.VallartaOpen();
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
                {
                    conexion = BDConexicon.RenaOpen();
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
                {
                    conexion = BDConexicon.VelazquezOpen();
                }
                if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
                {
                    conexion = BDConexicon.ColosoOpen();
                }

                if (CB_sucursal.SelectedItem.ToString().Equals("PREGOT"))
                {
                    conexion = BDConexicon.Papeleria1Open();
                }

            }
            

            string query="SELECT SUM(IMPORTE) AS IMPORTE FROM FLUJO WHERE CONCEPTO2='TAR' AND ESTACION='"+CB_caja.SelectedItem.ToString()+"' AND FECHA='"+fecha.ToString("yyyy-MM-dd")+"'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    importeTarj = Convert.ToDouble(dr["IMPORTE"].ToString());
                }

                //TB_importe.Text = Convert.ToString(importeTarj);
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                MessageBox.Show("[EXCEPCION CONTROLADA]: No se pudo traer el importe total de las ventas con tarjeta de la caja "+CB_caja.SelectedItem.ToString());
            }
        }
    }   

}
