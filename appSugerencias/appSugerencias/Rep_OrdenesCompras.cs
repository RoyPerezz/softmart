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
    public partial class Rep_OrdenesCompras : Form
    {
        DataTable bo = new DataTable();
        DataTable va = new DataTable();
        DataTable re = new DataTable();
        DataTable ve = new DataTable();
        DataTable co = new DataTable();
        DataTable pre = new DataTable();
        DataTable aux = new DataTable();
        DataTable maestro = new DataTable();
        System.Collections.ArrayList repetidos = new System.Collections.ArrayList();
     
        


        public Rep_OrdenesCompras()
        {
            InitializeComponent();
        }

        private void Rep_OrdenesCompras_Load(object sender, EventArgs e)
        {

            bo.Columns.Add("COMPRA", typeof(string));
            bo.Columns.Add("FACTURA", typeof(string));
            bo.Columns.Add("F_EMISION", typeof(string));
            bo.Columns.Add("IMPORTE", typeof(double));
            bo.Columns.Add("PROVEEDOR", typeof(string));
            bo.Columns.Add("FECHA CAPTURA", typeof(string));
            bo.Columns.Add("NUM ORDEN", typeof(string));

            va.Columns.Add("COMPRA", typeof(string));
            va.Columns.Add("FACTURA", typeof(string));
            va.Columns.Add("F_EMISION", typeof(string));
            va.Columns.Add("IMPORTE", typeof(double));
            va.Columns.Add("PROVEEDOR", typeof(string));
            va.Columns.Add("FECHA CAPTURA", typeof(string));
            va.Columns.Add("NUM ORDEN", typeof(string));

            re.Columns.Add("COMPRA", typeof(string));
            re.Columns.Add("FACTURA", typeof(string));
            re.Columns.Add("F_EMISION", typeof(string));
            re.Columns.Add("IMPORTE", typeof(double));
            re.Columns.Add("PROVEEDOR", typeof(string));
            re.Columns.Add("FECHA CAPTURA", typeof(string));
            re.Columns.Add("NUM ORDEN", typeof(string));

            ve.Columns.Add("COMPRA", typeof(string));
            ve.Columns.Add("FACTURA", typeof(string));
            ve.Columns.Add("F_EMISION", typeof(string));
            ve.Columns.Add("IMPORTE", typeof(double));
            ve.Columns.Add("PROVEEDOR", typeof(string));
            ve.Columns.Add("FECHA CAPTURA", typeof(string));
            ve.Columns.Add("NUM ORDEN", typeof(string));

            co.Columns.Add("COMPRA", typeof(string));
            co.Columns.Add("FACTURA", typeof(string));
            co.Columns.Add("F_EMISION", typeof(string));
            co.Columns.Add("IMPORTE", typeof(double));
            co.Columns.Add("PROVEEDOR", typeof(string));
            co.Columns.Add("FECHA CAPTURA", typeof(string));
            co.Columns.Add("NUM ORDEN", typeof(string));

            pre.Columns.Add("COMPRA", typeof(string));
            pre.Columns.Add("FACTURA", typeof(string));
            pre.Columns.Add("F_EMISION", typeof(string));
            pre.Columns.Add("IMPORTE", typeof(double));
            pre.Columns.Add("PROVEEDOR", typeof(string));
            pre.Columns.Add("FECHA CAPTURA", typeof(string));
            pre.Columns.Add("NUM ORDEN", typeof(string));

            maestro.Columns.Add("NUM ORDEN",typeof(string));
            maestro.Columns.Add("FACTURA", typeof(string));
            maestro.Columns.Add("FECHA ENTREGA", typeof(string));
            maestro.Columns.Add("DIAS", typeof(string));
            maestro.Columns.Add("FECHA VENCIMIENTO", typeof(string));
            maestro.Columns.Add("PROVEEDOR", typeof(string));
            maestro.Columns.Add("IMPORTE", typeof(double));
            
        }

        public void OrdenesBo()
        {

            bo.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


            string query = "SELECT COMPRA,FACTURA,F_EMISION,IMPORTE,PROVEEDOR,USUFECHA,NumOrden FROM COMPRAS WHERE USUFECHA BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            try
            {
                MySqlConnection conexion = BDConexicon.BodegaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = bo.NewRow();
                    row["COMPRA"] = dr["COMPRA"].ToString();
                    row["FACTURA"] = dr["FACTURA"].ToString();
                    row["F_EMISION"] = dr["F_EMISION"].ToString();
                    row["IMPORTE"] = Convert.ToDouble(dr["IMPORTE"].ToString());
                    row["PROVEEDOR"] = dr["PROVEEDOR"].ToString();
                    row["FECHA CAPTURA"] = dr["USUFECHA"].ToString();
                    row["NUM ORDEN"] = dr["NumOrden"].ToString();
                    bo.Rows.Add(row);


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


        public void OrdenesVa()
        {

            va.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
           

            string query = "SELECT COMPRA,FACTURA,F_EMISION,IMPORTE,PROVEEDOR,USUFECHA,NumOrden FROM COMPRAS WHERE USUFECHA BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            try
            {
                MySqlConnection conexion = BDConexicon.VallartaOpen();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = va.NewRow();
                    row["COMPRA"] = dr["COMPRA"].ToString();
                    row["FACTURA"] = dr["FACTURA"].ToString();
                    row["F_EMISION"] = dr["F_EMISION"].ToString();
                    row["IMPORTE"] = Convert.ToDouble(dr["IMPORTE"].ToString());
                    row["PROVEEDOR"] = dr["PROVEEDOR"].ToString();
                    row["FECHA CAPTURA"] = dr["USUFECHA"].ToString();
                    row["NUM ORDEN"] = dr["NumOrden"].ToString();
                    va.Rows.Add(row);


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

        public void OrdenesRe()
        {
            re.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


            string query = "SELECT COMPRA,FACTURA,F_EMISION,IMPORTE,PROVEEDOR,USUFECHA,NumOrden FROM COMPRAS WHERE USUFECHA BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            try
            {
                MySqlConnection conexion = BDConexicon.RenaOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = re.NewRow();
                    row["COMPRA"] = dr["COMPRA"].ToString();
                    row["FACTURA"] = dr["FACTURA"].ToString();
                    row["F_EMISION"] = dr["F_EMISION"].ToString();
                    row["IMPORTE"] = Convert.ToDouble(dr["IMPORTE"].ToString());
                    row["PROVEEDOR"] = dr["PROVEEDOR"].ToString();
                    row["FECHA CAPTURA"] = dr["USUFECHA"].ToString();
                    row["NUM ORDEN"] = dr["NumOrden"].ToString();
                    re.Rows.Add(row);


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

        public void OrdenesCo()
        {
            co.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


            string query = "SELECT COMPRA,FACTURA,F_EMISION,IMPORTE,PROVEEDOR,USUFECHA,NumOrden FROM COMPRAS WHERE USUFECHA BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            try
            {
                MySqlConnection conexion = BDConexicon.ColosoOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    DataRow row = co.NewRow();
                    row["COMPRA"] = dr["COMPRA"].ToString();
                    row["FACTURA"] = dr["FACTURA"].ToString();
                    row["F_EMISION"] = dr["F_EMISION"].ToString();
                    row["IMPORTE"] = Convert.ToDouble(dr["IMPORTE"].ToString());
                    row["PROVEEDOR"] = dr["PROVEEDOR"].ToString();
                    row["FECHA CAPTURA"] = dr["USUFECHA"].ToString();
                    row["NUM ORDEN"] = dr["NumOrden"].ToString();
                    co.Rows.Add(row);


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

        public void OrdenesVe()
        {
            ve.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


            string query = "SELECT COMPRA,FACTURA,F_EMISION,IMPORTE,PROVEEDOR,USUFECHA,NumOrden FROM COMPRAS WHERE USUFECHA BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            try
            {
                MySqlConnection conexion = BDConexicon.VelazquezOpen();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = ve.NewRow();
                    row["COMPRA"] = dr["COMPRA"].ToString();
                    row["FACTURA"] = dr["FACTURA"].ToString();
                    row["F_EMISION"] = dr["F_EMISION"].ToString();
                    row["IMPORTE"] = Convert.ToDouble(dr["IMPORTE"].ToString());
                    row["PROVEEDOR"] = dr["PROVEEDOR"].ToString();
                    row["FECHA CAPTURA"] = dr["USUFECHA"].ToString();
                    row["NUM ORDEN"] = dr["NumOrden"].ToString();
                    ve.Rows.Add(row);


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


        public void OrdenesPre()
        {
            pre.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


            string query = "SELECT COMPRA,FACTURA,F_EMISION,IMPORTE,PROVEEDOR,USUFECHA,NumOrden FROM COMPRAS WHERE USUFECHA BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'";
            try
            {
                MySqlConnection conexion = BDConexicon.Papeleria1Open();
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = pre.NewRow();
                    row["COMPRA"] = dr["COMPRA"].ToString();
                    row["FACTURA"] = dr["FACTURA"].ToString();
                    row["F_EMISION"] = dr["F_EMISION"].ToString();
                    row["IMPORTE"] = Convert.ToDouble(dr["IMPORTE"].ToString());
                    row["PROVEEDOR"] = dr["PROVEEDOR"].ToString();
                    row["FECHA CAPTURA"] = dr["USUFECHA"].ToString();
                    row["NUM ORDEN"] = dr["NumOrden"].ToString();
                    pre.Rows.Add(row);


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



        public int ObtenerDiasCredito(string proveedor)
        {
            int dias = 0;
            MySqlConnection conexion = BDConexicon.conectar();
            string query = "SELECT DIAS FROM PROVEED WHERE PROVEEDOR ='"+proveedor+"'";
            MySqlCommand cmd = new MySqlCommand(query,conexion);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dias = Convert.ToInt32(dr["DIAS"].ToString());
            }
            dr.Close();
            conexion.Close();
            return dias;
        }

        public DateTime FechaVencimiento(int diasCredito,DateTime f_entrega)
        {
            DateTime vencimiento = DateTime.Now;

           vencimiento = f_entrega.AddDays(diasCredito);
           
          

            return vencimiento;
        }





        private void BT_ordenes_Click(object sender, EventArgs e)
        {



            string orden = "0";
            double importe = 0;

            OrdenesBo();
            OrdenesVa();
            OrdenesRe();
            OrdenesCo();
            OrdenesVe();
            OrdenesPre();

            maestro.Rows.Clear();
            aux.Rows.Clear();
            repetidos.Clear();
            //SE UNEN LOS DATATABLES EN EL DATATABLE AUX
            aux = bo.AsEnumerable().Union(va.AsEnumerable())
                .Union(re.AsEnumerable())
                .Union(co.AsEnumerable())
                .Union(ve.AsEnumerable())
                .Union(pre.AsEnumerable()).CopyToDataTable<DataRow>();

            int diasCredito = 0;
            DateTime f_vencimiento = DateTime.Now;
            DateTime f_entrega = DateTime.Now;
            string proveedor = "";
            bool repetido = false;
            Proveedor prov = new Proveedor();
            DateTime fechaLlegada = DateTime.Now;

            double suma = 0;
            foreach (DataRow row in aux.Rows)
            {
                repetido = false;
                orden = Convert.ToString(row["NUM ORDEN"]);
                if (orden.Equals(""))
                {
                    continue;
                }
                else
                {
                    for (int i = 0; i < repetidos.Count; i++)
                    {
                        if (orden.Equals(repetidos[i].ToString()))
                        {
                            repetido = true;
                            break;
                        }
                    }
                }


                if (repetido==true)
                {
                    continue;
                }
                else
                {
                    f_entrega = Convert.ToDateTime(row["F_emision"]);
                    repetidos.Add(row["NUM ORDEN"]);
                    foreach (DataRow row2 in aux.Rows)
                    {
                        if (orden.Equals(row2["NUM ORDEN"]))
                        {
                            importe += Convert.ToDouble(row2["IMPORTE"]);
                        }
                    }


                    diasCredito = ObtenerDiasCredito(row["PROVEEDOR"].ToString());
                    f_vencimiento = FechaVencimiento(diasCredito, f_entrega);
                    proveedor = prov.NombreProveedor(row["PROVEEDOR"].ToString());
                    importe = importe + (importe*0.16);
                    fechaLlegada = Convert.ToDateTime(row["F_EMISION"]);
                    maestro.Rows.Add(row["NUM ORDEN"], row["FACTURA"],fechaLlegada.ToString("dd-MM-yyyy") , diasCredito, f_vencimiento.ToString("dd-MM-yyyy"), proveedor, importe);

                  
                    importe = 0;
                }

               
                
             
            }

            foreach(DataRow total in maestro.Rows)
            {
                suma += Convert.ToDouble(total["IMPORTE"]);
            }

            maestro.Rows.Add("","","","","","TOTAL",suma);
            DG_tabla.DataSource = maestro;


            suma = 0;
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["IMPORTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
           
        }
    }
}
