using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Gastos.Vistas
{
    public partial class RegistroEgresos : Form
    {

        string claveConcepto = "";
       
        string usuario = "",caja="";
        public RegistroEgresos(string usuario,string caja)
        {
            this.usuario = usuario;
            this.caja = caja;
            InitializeComponent();
        }

        private void RB_tienda_CheckedChanged(object sender, EventArgs e)
        {
            CB_conceptoGral.Items.Clear();
            CB_conceptoGral.Text = "";
            CB_conceptoDetalle.Items.Clear();
            CB_conceptoDetalle.Text = "";
            List<Egreso> lista = TipoGastosController.ConceptosGralesEgresosCaja("TIENDA");

            foreach (var item in lista)
            {
                CB_conceptoGral.Items.Add(item.ConceptoGral.ToString());
            }
        }

        private void RB_general_CheckedChanged(object sender, EventArgs e)
        {
            CB_conceptoGral.Items.Clear();
            CB_conceptoGral.Text = "";
            CB_conceptoDetalle.Items.Clear();
            CB_conceptoDetalle.Text = "";
            List<Egreso> lista = TipoGastosController.ConceptosGralesEgresosCaja("GENERAL");

            foreach (var item in lista)
            {
                CB_conceptoGral.Items.Add(item.ConceptoGral.ToString());
            }
        }

        private void CB_conceptoGral_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoGasto = "";

            if (RB_tienda.Checked==true)
            {
                tipoGasto = "TIENDA";
            }

            if (RB_general.Checked==true)
            {
                tipoGasto = "GENERAL";
            }

            CB_conceptoDetalle.Items.Clear();
            CB_conceptoDetalle.Text = "";
            string conceptoGral = CB_conceptoGral.SelectedItem.ToString();
            List<Egreso> lista = TipoGastosController.ConceptoDetalle(conceptoGral,tipoGasto);
            foreach (var item in lista)
            {
                CB_conceptoDetalle.Items.Add(item.ConceptoDetalle.ToString());
            }
        }

        public string ClaveEgresoDetalle(string conceptoDetalle,string conceptoGral,string tipo_gasto)
        {
            string clave = "";
            string query = "select CONCEPTO from conegre where DESCRIP='"+ conceptoDetalle + "' and CONCEPTOGRAL='"+ conceptoGral+"' and TIPO_GASTO='"+tipo_gasto+"'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clave = dr["CONCEPTO"].ToString();
            }
            dr.Close();
            con.Close();
            return clave;
        }

        private void CB_conceptoDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroEgresos_Load(object sender, EventArgs e)
        {
            TB_cajera.Text = usuario;
            TB_caja.Text = caja;
            PB_logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        public string Sucursal()
        {
            string sucursal = "";
            string query = "select empresa from econfig";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sucursal = dr["empresa"].ToString();
            }
            return sucursal;
        }
        public string ObtenerDescripcionDetalle(string concepto)
        {
            string concepto_detalle = "";

            string query = "select descrip from conegre where concepto='"+concepto+"'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                concepto_detalle = dr["descrip"].ToString();
            }
            return concepto_detalle;
        }

        public void ImprimirEgreso()
        {
            Egreso egreso= null;
            DateTime fecha = DateTime.Now;
            string query = "select * from flujo where CONCEPTO='"+claveConcepto+"' and fecha='"+fecha.ToString("yyyy-MM-dd")+"' and estacion='"+TB_caja.Text+"'";
            MySqlConnection con = BDConexicon.conectar();
            MySqlCommand cmd = new MySqlCommand(query,con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                egreso = new Egreso()
                {
                    Flujo = Convert.ToInt32(dr["flujo"].ToString()),
                    Usuario = dr["usuario"].ToString(),
                    Estacion = dr["estacion"].ToString(),
                    Fecha = Convert.ToDateTime(dr["fecha"].ToString()),
                    Hora = dr["hora"].ToString(),
                    Clave = dr["concepto"].ToString(),
                    ConceptoDetalle = ObtenerDescripcionDetalle(dr["concepto"].ToString()),
                    Importe = Convert.ToDouble(dr["importe"].ToString())
                };
            }

            Ticket ticket = new Ticket();
            ticket.Logo = PB_logo.Image;
            ticket.Sucursal = Sucursal();
            ticket.Usuario = egreso.Usuario;
            ticket.Estacion = egreso.Estacion;
            ticket.Flujo = egreso.Flujo.ToString();
            ticket.Fecha = egreso.Fecha.ToString("dd-MM-yyyy");
            ticket.Hora = egreso.Hora;
            ticket.Clave = egreso.Clave;
            ticket.ConceptoDetalle = egreso.ConceptoDetalle;
            ticket.Importe =egreso.Importe;
            ticket.Imprimir(ticket);
        }


        public void Limpiar()
        {
            RB_general.Checked = false;
            RB_tienda.Checked = false;
            CB_conceptoGral.SelectedIndex = -1;
            CB_conceptoDetalle.SelectedIndex = -1;
            TB_importe.Text = "";

        }
        private void BT_registrar_Click(object sender, EventArgs e)
        {
            if (RB_general.Checked==false && RB_tienda.Checked==false)
            {
                MessageBox.Show("Seleccione el tipo de egreso");
            }else if(CB_conceptoGral.SelectedIndex ==-1)
            {
                MessageBox.Show("Seleciona el concepto general del egreso");
            }
            else if(CB_conceptoDetalle.SelectedIndex ==-1)
            {
                MessageBox.Show("Seleccione el concepto detalle del egreso");
            }
            else if(TB_importe.Text.Equals(""))
            {
                MessageBox.Show("Captura el importe del egreso");
            }
            else
            {
                string tipoGasto = "";
                if (RB_tienda.Checked == true)
                {
                    tipoGasto = "TIENDA";
                }

                if (RB_general.Checked == true)
                {
                    tipoGasto = "GENERAL";
                }

                DateTime fecha = DateTime.Now;
                claveConcepto = ClaveEgresoDetalle(CB_conceptoDetalle.SelectedItem.ToString(), CB_conceptoGral.SelectedItem.ToString(), tipoGasto);
                Egreso egreso = new Egreso()
                {
                    Flujo = TipoGastosController.ConsecutivoFlujo(),
                    Abono = 0,
                    Clave = claveConcepto,
                    IE = "E",
                    Importe = Convert.ToDouble(TB_importe.Text),
                    Fecha = fecha,
                    Hora = fecha.ToString("HH:mm:ss"),
                    Moneda = "MN",
                    Estacion = caja,
                    Usuario = usuario,
                    Modulo = "EGR",
                    Venta = 0,
                    Corte = 0,
                    Tipo_cam = 1,
                    Cargo = 0,
                    Concepto2 = claveConcepto,
                    Banco = "",
                    Cheque = "",
                    Verificado = 0


                };
                try
                {


                    if (CB_conceptoGral.Text.Equals(""))
                    {
                        MessageBox.Show("Selecciona un concepto general");
                    }else if(CB_conceptoDetalle.Text.Equals(""))
                    {
                        MessageBox.Show("Selecciona un concepto detalle");
                    }else if(TB_importe.Text.Equals(""))
                    {
                        MessageBox.Show("Captura un importe para el gasto");
                    }
                    else
                    {
                        TipoGastosController.RegistroEgreso(egreso);
                        ImprimirEgreso();
                        Limpiar();
                        MessageBox.Show("Se ha registrado el egreso correctamente");
                    }
                    
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al guardar el egreso: " + ex);

                }
            }
        } 
    }
}
