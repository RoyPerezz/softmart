using appSugerencias.Gastos_Externos.Controlador;
using appSugerencias.Gastos_Externos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos_Externos.Vistas
{
    public partial class ReporteGastosFinanzas_Gerencia : Form
    {

        string usuario = "",area="";
        public ReporteGastosFinanzas_Gerencia(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        public string AreaTrabajo()
        {
            string area = "";

            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand("SELECT area from usuarios WHERE usuario ='" + usuario + "'", con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                area = dr["area"].ToString();
            }
            dr.Close();
            con.Close();
            return area;
        }


        //private void BT_buscar_Click(object sender, EventArgs e)
        //{

        //}

        //private void BT_guardar_Click(object sender, EventArgs e)
        //{

        //}



        //private void ReporteGastosFinanzas_Gerencia_Load(object sender, EventArgs e)
        //{

        //}

        //private void BT_excel_Click(object sender, EventArgs e)
        //{

        //}

        public void PintarFila()
        {

            bool estado = false;


            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                estado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["CHECK"].Value);

                if (estado == true)
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    DG_tabla.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }


        }


        public double CalcularSaldoCuenta(string banco,string cuenta)
        {

            double saldo = 0;

            try
            {

                MySqlConnection con = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand("SELECT tienda,suc_pago,mov,ie,pagara,fecha,cantidad,ref_gastoexterno,suc_pago " +
                    "FROM rd_historial_saldobancos " +
                    "WHERE  banco='" + banco + "' and cuenta='" +cuenta+ "' ORDER BY FECHA", con);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    double cantidad = Convert.ToDouble(dr["cantidad"].ToString());
                    if (dr["ie"].ToString().Equals("I"))
                    {
                        saldo += cantidad;
                       // DG_tabla.Rows.Add(dr["mov"].ToString(), dr["pagara"].ToString(), dr["fecha"].ToString(), dr["ref_gastoexterno"].ToString(), dr["suc_pago"].ToString(), cantidad, "", saldo, dr["tienda"].ToString(), dr["suc_pago"].ToString());
                    }

                    if (dr["ie"].ToString().Equals("E"))
                    {

                        saldo -= cantidad;
                        //DG_tabla.Rows.Add(dr["mov"].ToString(), dr["pagara"].ToString(), dr["fecha"].ToString(), dr["ref_gastoexterno"].ToString(), dr["suc_pago"].ToString(), "", cantidad, saldo, dr["tienda"].ToString(), dr["suc_pago"].ToString());
                        
                    }
                }

                dr.Close();
                con.Close();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR EN ESTADO DE CUENTA DE CUENTAS OSMART: " + ex);
            }
            return saldo;
        }
        private void ReporteGastosFinanzas_Gerencia_Load_1(object sender, EventArgs e)
        {
            area = AreaTrabajo();

            if (area.Equals("FINANZAS"))
            {
                BT_abrir.Visible = false;
                groupBox2.Visible = false;
                DG_tabla.Columns["CHECK"].ReadOnly=true;
            }
            LB_saldo_finanzas.Text =  CalcularSaldoCuenta("FINANZAS", "ENVIO").ToString("C2");
        }

        private void BT_buscar_Click_1(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            double total = 0;
            DataGridViewCheckBoxCell check = new DataGridViewCheckBoxCell();

            int revisado = 0;
            List<GastoExterno> lista = GastoFinanzasController.ListaGastos(inicio, fin);
            foreach (var item in lista)
            {

                revisado = item.Revisado;

                if (revisado == 1)
                {
                    check.ThreeState = true;
                }
                else
                {
                    check.ThreeState = false;
                }
                DG_tabla.Rows.Add(item.Id, item.Concepto_gral, item.ConceptoDetalle, item.Descripcion, item.Importe, item.Folio, item.Fecha.ToString("yyyy-MM-dd"), check.ThreeState);
                total += item.Importe;
            }


            LB_total.Text = total.ToString("C2");
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
            PintarFila();
        }

        private void BT_guardar_Click_1(object sender, EventArgs e)
        {

            int id = 0;
            bool estado = false;
            int revisado = 0;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value.ToString());
                estado = Convert.ToBoolean(DG_tabla.Rows[i].Cells["CHECK"].Value);

                if (estado == true)
                {
                    revisado = 1;
                }
                else
                {
                    revisado = 0;
                }
                GastoFinanzasController.ActualizarEstado(revisado, id);
            }



            MessageBox.Show("Se ha guardado el estado de cada gasto");
            PintarFila();
        }

        private void BT_excel_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);


            int indiceColumna = 0;


            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {

                if (col.Visible == true)
                {
                    indiceColumna++;
                    excel.Cells[5, indiceColumna] = col.Name;
                }


            }

            int indiceFila = 4;



            foreach (DataGridViewRow row in DG_tabla.Rows)
            {
                //if (row.Visible == true)
                //{
                indiceFila++;
                indiceColumna = 0;

                foreach (DataGridViewColumn col in DG_tabla.Columns)
                {


                    if (col.Visible == true)
                    {
                        indiceColumna++;


                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                    }





                }

                //}
            }
           

            excel.Visible = true;
        }

        private void BT_abrir_Click(object sender, EventArgs e)
        {
            Rep_cuentas_osmart rep = new Rep_cuentas_osmart("INOCENCIO");
            rep.Show();
        }
    }
}
