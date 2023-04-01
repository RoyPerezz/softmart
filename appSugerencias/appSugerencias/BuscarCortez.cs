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
    public partial class BuscarCortez : Form
    {
        public BuscarCortez()
        {
            InitializeComponent();
        }


        string sucursal = "";
        string patron = "";
        string rfc = "";
        string direccion = "";
        string telefono = "";
        string cp = "";

        //double ingEfe = 0, ingTarj = 0, ingTotal = 0;
        //double egrTotal = 0;
        //int folio = 0;
        //string estacion = "";
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

        public void CrearTicket(int id, int folio, string estacion, string fecha, string hora, double ingEfe, double ingTarj, double ingTotal, double egrTotal, double totalCaja, int clientes)
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.
            DatosFiscales();


            //obtener importe de efectivo que capture el usuario
#pragma warning disable CS0219 // La variable 'concepto' está asignada pero su valor nunca se usa
            string concepto = "";
#pragma warning restore CS0219 // La variable 'concepto' está asignada pero su valor nunca se usa



            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo


            ticket.TextoCentro("****corte z en moneda mn****");
            ticket.TextoCentro(sucursal);
            ticket.TextoCentro(patron);
            ticket.TextoCentro(rfc);
            ticket.TextoCentro(direccion);
            ticket.TextoCentro(cp);
            ticket.TextoCentro(telefono);




            ticket.TextoIzquierda("Corte z #" + folio);
            ticket.TextoIzquierda("Estacion: "+ CB_caja.SelectedItem.ToString());
            ticket.TextoExtremos("FECHA: " + fecha, "HORA: " + hora);
            ticket.TextoIzquierda("** Ingresos **");
            ticket.TextoExtremos("EFE Pago de clientes", "$" + ingEfe);
            ticket.TextoExtremos("TAR Pago de clientes", "$" + ingTarj);
            ticket.lineasAsteriscos();
            ticket.TextoExtremos("Total de Ingresos:","$"+ingTotal);
            ticket.TextoIzquierda("**Egresos**");

            //aqui va todos los conceptos de egresos de la caja
#pragma warning disable CS0219 // La variable 'conceptoEgre' está asignada pero su valor nunca se usa
            string conceptoEgre = "";
#pragma warning restore CS0219 // La variable 'conceptoEgre' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'importeEgre' está asignada pero su valor nunca se usa
            double importeEgre = 0;
#pragma warning restore CS0219 // La variable 'importeEgre' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'totalEgre' está asignada pero su valor nunca se usa
            double totalEgre = 0;
#pragma warning restore CS0219 // La variable 'totalEgre' está asignada pero su valor nunca se usa

            DataTable egresos = new DataTable();

            ArrayList conceptoEgr = new ArrayList();
            ArrayList importeEgr = new ArrayList();


            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT * FROM rd_egresos_cortez WHERE idcortez='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //egresos.Rows.Add(dr["concepto"].ToString(),dr["importe"].ToString());
                conceptoEgr.Add(dr["concepto"].ToString());
                importeEgr.Add(dr["importe"].ToString());
            }
            dr.Close();

            for (int i = 0; i < conceptoEgr.Count; i++)
            {
                ticket.TextoExtremos(conceptoEgr[i].ToString(),"$ "+importeEgr[i]);
            }

            ticket.lineasAsteriscos();
            ticket.TextoExtremos("Total de Egresos:", " $" + egrTotal);
            ticket.lineasAsteriscos();
            ticket.lineasAsteriscos();
            ticket.TextoExtremos("Total de Caja:", "$" + totalCaja);
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
            ticket.TextoIzquierda("Clientes atendidos:" + clientes);

            ticket.lineasAsteriscos();

            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
            //dt.Clear();
        }
        private void BT_buscarTicket_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            MySqlConnection conexion = BDConexicon.BodegaOpen();
            string query = "SELECT * FROM rd_cortez WHERE sucursal='"+CB_sucursal.SelectedItem.ToString()+"' AND estacion='"+CB_caja.SelectedItem+"' AND FECHA BETWEEN '"+inicio.ToString("yyyy-MM-dd")+"' AND '"+fin.ToString("yyyy-MM-dd")+"'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DG_tabla.Rows.Add(dr["idcortez"].ToString(),dr["folio"].ToString(),dr["estacion"].ToString(),dr["fecha"].ToString(),dr["hora"].ToString(),dr["pagoefe"].ToString(),dr["pagotarj"].ToString(),dr["totaling"].ToString(),dr["totalegr"].ToString(),dr["totalcaja"].ToString(),dr["numclientes"].ToString());
                }
                dr.Close();
               

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al traer los corte z: "+ex);
            }
        }

        private void DG_tabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells[0].Value);
            int folio = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells[1].Value);
            string estacion = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells[2].Value);
            DateTime fecha = Convert.ToDateTime(DG_tabla.Rows[e.RowIndex].Cells[3].Value);
            string hora = Convert.ToString(DG_tabla.Rows[e.RowIndex].Cells[4].Value);
            double pagoEfe = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells[5].Value);
            double pagoTarj = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells[6].Value);
            double totalIng= Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells[7].Value);
            double totalEgr = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells[8].Value);
            double totalCaja = Convert.ToDouble(DG_tabla.Rows[e.RowIndex].Cells[9].Value);
            int clientes = Convert.ToInt32(DG_tabla.Rows[e.RowIndex].Cells[9].Value);

            CrearTicket(id,folio,estacion,fecha.ToString("dd-MM-yyyy"),hora,pagoEfe,pagoTarj,totalIng,totalEgr,totalCaja,clientes);
        }
    }
}
