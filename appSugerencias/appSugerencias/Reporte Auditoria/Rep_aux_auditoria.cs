using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Reporte_Auditoria
{
    public partial class Rep_aux_auditoria : Form
    {

        string modulo = "", sucursal = "", id = "", usuario = "",
               nombre_equipo = "", ip = "", fecha = "", hora = "",
#pragma warning disable CS0414 // El campo 'Rep_aux_auditoria.motivo' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Rep_aux_auditoria.destino' está asignado pero su valor nunca se usa
#pragma warning disable CS0414 // El campo 'Rep_aux_auditoria.origen' está asignado pero su valor nunca se usa
               origen = "", destino = "", motivo = "";
#pragma warning restore CS0414 // El campo 'Rep_aux_auditoria.origen' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'Rep_aux_auditoria.destino' está asignado pero su valor nunca se usa
#pragma warning restore CS0414 // El campo 'Rep_aux_auditoria.motivo' está asignado pero su valor nunca se usa

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);




            int indiceColumna = 0;
           


            excel.Cells.Range["A2"].Value = "SUCURSAL";
            excel.Cells.Range["A3"].Value = LB_sucursal.Text;

            excel.Cells.Range["B2"].Value = "USUARIO";
            excel.Cells.Range["B3"].Value = LB_usuario.Text;

            excel.Cells.Range["C2"].Value = "IP";
            excel.Cells.Range["C3"].Value = LB_ip.Text;

            excel.Cells.Range["D2"].Value = "FECHA";
            excel.Cells.Range["D3"].Value = LB_fecha.Text;

            excel.Cells.Range["E2"].Value = "HORA";
            excel.Cells.Range["E3"].Value = LB_hora.Text;

            excel.Cells.Range["F2"].Value = "EQUIPO";
            excel.Cells.Range["F3"].Value = LB_equipo.Text;

            foreach (DataGridViewColumn col in DG_articulos.Columns)
            {
                indiceColumna++;

                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_articulos.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_articulos.Columns)
                {
                    indiceColumna++;



                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }


            //excel.Cells.Range["B6:M36"].NumberFormat = "$#,##0.00";


            excel.Visible = true;
        }

        private void Rep_aux_auditoria_Load(object sender, EventArgs e)
        {
            LB_sucursal.Text = sucursal;
            LB_usuario.Text = usuario;
            LB_equipo.Text = nombre_equipo;
            LB_ip.Text = ip;
            LB_fecha.Text = fecha;
            LB_hora.Text = hora;
            

        }

        public Rep_aux_auditoria()
        {
           

            InitializeComponent();


          
        }


        public void ArticulosCotizacion(string modulo, string sucursal, string folio, string usuario, string nombre_equipo, string ip, string fecha, string hora, string origen, string destino, string motivo)
        {
            string consulta = "select * from rd_log_cotizacion_traspaso_articulos where fk_log_cotizacion='"+ folio + "'";
            string consultaColumnas = "SHOW COLUMNS FROM rd_log_cotizacion_traspaso_articulos FROM MyBusinessDelta";

            this.modulo = modulo;
            this.sucursal = sucursal;
            this.id = folio;
            this.usuario = usuario;
            this.nombre_equipo = nombre_equipo;
            this.ip = ip;
            this.fecha = fecha;
            this.hora = hora;
         

            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);
            MySqlCommand cmd0 = new MySqlCommand(consultaColumnas,con);
            MySqlDataReader dr0 = cmd0.ExecuteReader();
            while (dr0.Read())
            {
                DG_articulos.Columns.Add(dr0["Field"].ToString(), dr0["Field"].ToString());
            }
            dr0.Close();

            MySqlCommand cmd = new MySqlCommand(consulta,con);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_articulos.Rows.Add("", dr["fk_log_cotizacion"].ToString(), dr["articulo"].ToString(),dr["descripcion"].ToString(),dr["existencia"].ToString(),dr["cantidad"].ToString());
            }
            dr.Close();
            con.Close();
            DG_articulos.Columns[0].Visible = false;
            DG_articulos.Columns[1].Visible = false;
            List_datos.Items.Add("Origen: " + origen);
            List_datos.Items.Add("Destino: " + destino);
            List_datos.Items.Add("Motivo: " + motivo);

        }

        public void ArticulosDevolucionCompra(string modulo, string sucursal, string usuario, string nombre_equipo, string ip, string fecha, string hora, string sucursal_compra, string fk_proveedor, string compra, string factura, string importe_compra, string dev_parcial, string dev_total, string importe_devolucion, string observacion)
        {


            this.modulo = modulo;
            this.sucursal = sucursal;
           
            this.usuario = usuario;
            this.nombre_equipo = nombre_equipo;
            this.ip = ip;
            this.fecha = fecha;
            this.hora = hora;

            string consulta = "select * from rd_log_articulos_dev_compra where compra='" + compra + "'";
            string consultaColumnas = "SHOW COLUMNS FROM rd_log_articulos_dev_compra FROM MyBusinessDelta";
            MySqlConnection con = BDConexicon.ConexionSucursal(sucursal);

            MySqlCommand cmd0 = new MySqlCommand(consultaColumnas, con);
            MySqlDataReader dr0 = cmd0.ExecuteReader();
            while (dr0.Read())
            {
                DG_articulos.Columns.Add(dr0["Field"].ToString(), dr0["Field"].ToString());
            }
            dr0.Close();

            MySqlCommand cmd = new MySqlCommand(consulta, con);

            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DG_articulos.Rows.Add("", dr["fk_id_devolucion"].ToString(), dr["compra"].ToString(), dr["articulo"].ToString(), dr["descripcion"].ToString(), dr["precio"].ToString(), dr["cantidad"].ToString(), dr["descuento"].ToString(), dr["impuesto"].ToString(), dr["costo_u"].ToString(), dr["importe"].ToString());
            }
            dr.Close();
            con.Close();
            DG_articulos.Columns[0].Visible = false;
            DG_articulos.Columns[1].Visible = false;
            List_datos.Items.Add("Compra: " + compra);
            List_datos.Items.Add("factura: " + factura);
            List_datos.Items.Add("importe: " + importe_compra);
            List_datos.Items.Add("importe devolción: " + importe_devolucion);
            List_datos.Items.Add("Observación: " + observacion);


        }
    }
}
