using appSugerencias.Stock_Compras.Controlador;
using appSugerencias.Stock_Compras.Modelo;
using appSugerencias.Utilidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSugerencias.Stock_Compras.Vista
{
    public partial class FormatoAclaracionesTiendas : Form
    {
        string usuario = "", area = "",ip="";
        string tipo = "";
        string nombreIMG1 = "", nombreIMG2 = "", rutaOrigen1 = "",rutaOrigen2="", rutaIMG2 = "",rutaFoto1="",rutaFoto2="", rutaServidor="", rutaBD="",rutaBD2="";
        double importe = 0;
        bool clickFoto1 = false;
        bool clickFoto2 = false;
        public FormatoAclaracionesTiendas(string usuario,string ip)
        {
            this.ip = ip;
            this.usuario = usuario;
            InitializeComponent();
        }

        private void FormatoAclaracionesTiendas_Load(object sender, EventArgs e)
        {
            List<string> lista = StockController.ListaProveedores();

            
            CB_proveedor.DataSource = lista;


            if (usuario.Equals("LILIA") || usuario.Equals("SOPORTE")|| usuario.Equals("INOCENCIO")|| usuario.Equals("SISTEMAS"))
            {
                LB_sucursal.Visible = true;
                CB_sucursal.Visible = true;
            }

            DG_tabla.Columns["DESCRIPCION"].Width = 210;
            DG_tabla.Columns["FALTANTE"].Width = 70;
            DG_tabla.Columns["MEDO"].Width = 50;
            DG_tabla.Columns["SOBRANTE"].Width = 70;
        }

        private void BT_eliminar_img2_Click(object sender, EventArgs e)
        {
            PB_imagen2.Image = null;
            nombreIMG2 = "";
            rutaFoto2 = "";
            rutaBD2 = "";
        }

        private void BT_eliminar_img1_Click(object sender, EventArgs e)
        {
            PB_imagen1.Image = null;
            nombreIMG1 = "";
            rutaFoto1 = "";
            rutaBD = "";
        }

        private void BT_imagen2_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                PB_imagen2.ImageLocation = abrirImagen.FileName;
                PB_imagen2.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                PB_imagen2.Tag = abrirImagen.FileName;
                rutaOrigen2 = PB_imagen2.Tag.ToString();
                nombreIMG2 = Path.GetFileName(PB_imagen2.Tag.ToString());
                rutaServidor = RutaServidor(nombreIMG2);

                rutaBD2 = RutaBD(nombreIMG2, false);
            }
            //clickFoto1 = true;
        }

        public string RutaServidor(string nombreImagen)
        {

            string ruta = @"\\192.168.6.190\Users\Admin\Documents\imgAclaraciones\" + nombreImagen;


            return ruta;
        }

        public string RutaBD(string nombreImagen, bool actualizar)
        {
            string ruta = "";

                ruta = @"\\\\\\\\192.168.6.190\\\\Users\\\\Admin\\\\Documents\\\\imgAclaraciones\\\\" + nombreImagen;
            


            return ruta;
        }
        private void BT_img1_Click(object sender, EventArgs e)
        {

            OpenFileDialog abrirImagen = new OpenFileDialog();



            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                PB_imagen1.ImageLocation = abrirImagen.FileName;
                PB_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;//la imagen se adapta al tamaño del contenedor picturebox
                PB_imagen1.Tag = abrirImagen.FileName;
                rutaOrigen1 = PB_imagen1.Tag.ToString();
                nombreIMG1 = Path.GetFileName(PB_imagen1.Tag.ToString());
                rutaServidor = RutaServidor(nombreIMG1);

                rutaBD = RutaBD(nombreIMG1, false);
            }
            //clickFoto1 = true;
        }
    

        private void BT_guardar_Click(object sender, EventArgs e)
        {

            List<Aclaracion> lista = new List<Aclaracion>();
            string sucursal = Sucursal.NombreSucursalIP(ip);
            string query = "";
            int falta=0,medo=0,sobra=0,id=0;
            MySqlCommand cmd = null;
            MySqlConnection con = BDConexicon.BodegaOpen();
            Aclaracion aca = null;
            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                aca = new Aclaracion()
                {
                    Id = Convert.ToInt32(DG_tabla.Rows[i].Cells["ID"].Value.ToString()),
                    Modelo = DG_tabla.Rows[i].Cells["MODELO"].Value.ToString(),
                    Clave = DG_tabla.Rows[i].Cells["CLAVE"].Value.ToString(),
                    Descripcion = DG_tabla.Rows[i].Cells["DESCRIPCION"].Value.ToString(),
                    PzxPaq = Convert.ToDouble(DG_tabla.Rows[i].Cells["PZXPAQ"].Value.ToString()),
                    CostoxPaq = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_OPAQ"].Value.ToString()),
                    CostoxPz = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PZ"].Value.ToString()),
                    Faltante = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTANTE"].Value.ToString()),
                    Medo = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO"].Value.ToString()),
                    Sobrante = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRANTE"].Value.ToString()),
                    Importe = Convert.ToDouble(DG_tabla.Rows[i].Cells["IMPORTE_TOTAL"].Value.ToString()),
                    Surtio = DG_tabla.Rows[i].Cells["SURTIO"].Value.ToString(),
                    RutaFoto1 = rutaBD,
                    NombreFoto1 = nombreIMG1,
                    RutaFoto2 =rutaBD2,
                    NombreFoto2 = nombreIMG2
                };
                lista.Add(aca);

               
            }

            try
            {

                if (!nombreIMG1.Equals(""))
                {
                    File.Copy(rutaOrigen1, RutaServidor(nombreIMG1), true);
                    AclaracionController.GuardarFotosAclaracion1(sucursal, rutaBD, nombreIMG1, Convert.ToInt32(TB_id_stock.Text));
                }

                if (!nombreIMG2.Equals(""))
                {
                    File.Copy(rutaOrigen2, RutaServidor(nombreIMG2), true);
                    AclaracionController.GuardarFotosAclaracion2(sucursal, rutaBD2, nombreIMG2, Convert.ToInt32(TB_id_stock.Text));
                }
                AclaracionController.GuardarAclaracion(sucursal, lista);
                
                MessageBox.Show("Se han guardado los cambios");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un problema al intentar guardar los cambios: " + ex);
            }








        }

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_id_proveedor.Text = StockController.ClaveProveedor(CB_proveedor.Text); //Clave del proveedor
            List<string> stocks = StockController.BuscarStocks(TB_id_proveedor.Text);
            CB_stock.DataSource = stocks;
        }

        private void CB_stock_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "SELECT idreg" +
                "           FROM rd_stock_compra" +
                "           WHERE descripcion='" + CB_stock.Text + "'";

            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                TB_id_stock.Text = dr["idreg"].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            int faltava = 0, mal_estado_va = 0, sobranteva = 0, faltare = 0, mal_estado_re = 0, sobrantere = 0, faltave = 0, mal_estado_ve = 0, sobranteve = 0, faltaco = 0, mal_estado_co = 0, sobranteco = 0;
            MySqlConnection con = BDConexicon.BodegaOpen();
            string sucursal = "";
            DG_tabla.Rows.Clear();

            if (usuario.Equals("LILIA") || usuario.Equals("SOPORTE") || usuario.Equals("INOCENCIO") || usuario.Equals("SISTEMAS"))
            {
                sucursal = CB_sucursal.Text;
            }else
            {
                sucursal = Sucursal.NombreSucursalIP(ip);
            }
           
       
            List<Aclaracion> lista = AclaracionController.BuscarAclaracion(sucursal,Convert.ToInt32(TB_id_stock.Text));

            foreach (var item in lista)
            {
                DG_tabla.Rows.Add(item.Id,item.Modelo,item.Clave,item.Descripcion,item.PzxPaq,item.CostoxPz,item.CostoxPaq,item.Faltante,item.Medo,item.Sobrante,item.Importe,item.Surtio);
            }

            List <Aclaracion> listaFotos = AclaracionController.FotosAclaracion(sucursal, Convert.ToInt32(TB_id_stock.Text));

            if (listaFotos.Count==0)
            {

            }
            else
            {
                if (!listaFotos[0].RutaFoto1.ToString().Equals(""))
                {
                    PB_imagen1.Image = Image.FromFile(listaFotos[0].RutaFoto1);
                    PB_imagen1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
               
            }

            if ( listaFotos.Count == 0)
            {

            }
            else
            {

                if (!listaFotos[0].RutaFoto2.ToString().Equals(""))
                {
                    PB_imagen2.Image = Image.FromFile(listaFotos[0].RutaFoto2);
                    PB_imagen2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                
            }




            //DG_tabla.Rows.Clear();

            //string consulta = "SELECT tipo FROM  rd_stock_compra WHERE idreg='" + TB_id_stock.Text + "'";
            //MySqlCommand cmd1 = new MySqlCommand(consulta, con);
            //MySqlDataReader dr1 = cmd1.ExecuteReader();

            //while (dr1.Read())
            //{
            //    tipo = dr1["tipo"].ToString();
            //}
            //dr1.Close();






            //string query = "SELECT" +
            //    "                idreg," +
            //    "                modelo," +
            //    "                claveProducto," +
            //    "                descripcion," +
            //    "                pzxpaq," +
            //    "                costoxpaq," +
            //    "                costoxpz" +
            //    "          FROM rd_detalle_stock_compra" +
            //    "          WHERE fk_stock='" + TB_id_stock.Text + "'" +
            //    "          ORDER BY idreg";


            //MySqlCommand cmd = new MySqlCommand(query, con);
            //MySqlDataReader dr = null;
            //dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{



            //    DG_tabla.Rows.Add(dr["idreg"].ToString(), dr["modelo"].ToString(), dr["claveProducto"].ToString(), dr["descripcion"].ToString(), dr["pzxpaq"].ToString(), dr["costoxpaq"].ToString(), dr["costoxpz"].ToString(), 0, 0, 0, 0, "");
            //}
            //dr.Close();




            Calcular(tipo);
        }

        private void BT_calcular_Click(object sender, EventArgs e)
        {
            int faltante = 0;
            int medo = 0;
            int sobra = 0;
            double costoxpz = 0;
           

            for (int i = 0; i < DG_tabla.Rows.Count; i++)
            {
                faltante = Convert.ToInt32(DG_tabla.Rows[i].Cells["FALTANTE"].Value.ToString());
                medo = Convert.ToInt32(DG_tabla.Rows[i].Cells["MEDO"].Value.ToString());
                sobra = Convert.ToInt32(DG_tabla.Rows[i].Cells["SOBRANTE"].Value.ToString());
                costoxpz = Convert.ToDouble(DG_tabla.Rows[i].Cells["COSTO_PZ"].Value.ToString());

                importe = (faltante * costoxpz) - (medo * costoxpz)- (sobra * costoxpz);

                DG_tabla.Rows[i].Cells["IMPORTE_TOTAL"].Value = importe;
            }
               
        }

        public void Calcular(string tipo)
        {

        }
    }
}
