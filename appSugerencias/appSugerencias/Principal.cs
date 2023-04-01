using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace appSugerencias
{
    public partial class Principal : Form
    {
        string Usuario="";
        string Area;
        string Estacion;
       
        
        public Principal()
        {
            InitializeComponent();
            lblUsuario.Text = Usuario;
            


        }

       

        public Principal(string usuario,string area)
        {
            InitializeComponent();
            Usuario = usuario;
            Area = area;
            Estacion = BDConexicon.optieneEstacion();
            lblEstacion.Text = Estacion;
            lblUsuario.Text = Usuario;
            //repEtiquetasToolStripMenuItem.Enabled = false;

        }

        public static string optieneIp()
        {
            TextReader IP;
            IP = new StreamReader("IP.txt");
            string ipn = IP.ReadLine();
            IP.Close();
            return ipn;
        }

        public static string optieneBd()
        {
            TextReader BD;
            BD = new StreamReader("BD.txt");
            string bdn = BD.ReadLine();
            BD.Close();
            return bdn;
        }




        private void nuevaSugerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Sugerencias form = new frm_Sugerencias();
            form.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImprimirReporte imp = new ImprimirReporte();
            imp.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticuloSinVentas asv = new ArticuloSinVentas();
            asv.Show();
        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_ReporteASinVentas rasv = new frm_ReporteASinVentas();
            rasv.Show();
        }


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login rasv = new frm_Login();
            rasv.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
             if (Area == "SISTEMAS" || Area == "ADMON GRAL" || Area == "SUPER")
            {
                supervisiónToolStripMenuItem.Enabled = true;
            }
            else
            {
                supervisiónToolStripMenuItem.Enabled = false;
            }



            //MENU DE REPORTES
            if (Area=="SISTEMAS"||Area== "ADMON GRAL" || Area == "CXPAGAR")
            {
                reportesToolStripMenuItem1.Enabled = true;
            }
            else
            {
                reportesToolStripMenuItem1.Enabled = false;
            }
            
           
            if (Area == "COMPRAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "CXPAGAR" || Area=="BODEGA")
            { 
                menuPedido.Enabled = true;
            }
            else
            {
                menuPedido.Enabled = false;
            }


            if (true)
            {
                almacenToolStripMenuItem.Enabled = true;
            }
            else
            {
#pragma warning disable CS0162 // Se detectó código inaccesible
                almacenToolStripMenuItem.Enabled = false;
#pragma warning restore CS0162 // Se detectó código inaccesible
            }


            if (Area == "TRASPASOS" || Area == "SISTEMAS" || Area == "ADMON GRAL" || Area == "SUPER" || Area == "COMPRAS")
            {
                aplicarTraspasoToolStripMenuItem.Enabled = true;
            }
            else
            {
                aplicarTraspasoToolStripMenuItem.Enabled = false;
            }


            if (Area == "BODEGA" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                creaTraspasoToolStripMenuItem.Enabled = true;
            }
            else
            {
                creaTraspasoToolStripMenuItem.Enabled = false;
            }


            if (Area == "COMPRAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "TRASPASO")
            {
                comprasToolStripMenuItem.Enabled = true;
            }
            else
            {
                comprasToolStripMenuItem.Enabled = false;


            }

            if (Area == "ENC CAJAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "GERENTE")
            {
                comisionesToolStripMenuItem.Enabled = true;
            }
            else
            {
                comisionesToolStripMenuItem.Enabled = false;


            }

            if (Area == "ENC CAJAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "GERENTE" || Area == "CXPAGAR")
            {
                reportesToolStripMenuItem.Enabled = true;
            }
            else
            {
                reportesToolStripMenuItem.Enabled = false;


            }

            if (Area == "ENC CAJAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "GERENTE")
            {
                pisoVentaToolStripMenuItem.Enabled = true;
            }
            else
            {
                pisoVentaToolStripMenuItem.Enabled = false;


            }

            //if (Area == "COMPRAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "TRASPASOS")
            //{
            //    menuPedido.Enabled = true;
            //}
            //else
            //{
            //    menuPedido.Enabled = false;


            //}

            if (Area == "COMPRAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "TRASPASO")
            {
                vitrinaToolStripMenuItem.Enabled = true;
            }
            else
            {
                vitrinaToolStripMenuItem.Enabled = false;


            }


            if (Area == "PAGOS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL" || Area == "CXPAGAR")
            {
                cuentasPPagarToolStripMenuItem.Enabled = true;
            }
            else
            {
                cuentasPPagarToolStripMenuItem.Enabled = false;


            }

            if (Area == "INVENTARIOS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                inventarioToolStripMenuItem.Enabled = true;
            }
            else
            {
                inventarioToolStripMenuItem.Enabled = false;


            }

            if (Area == "FINANZAS" || Area == "SISTEMAS" || Area == "SUPER" || Area == "ADMON GRAL")
            {
                finanzasToolStripMenuItem.Enabled = true;
            }
            else
            {
                finanzasToolStripMenuItem.Enabled = false;


            }

            if ( Area == "SISTEMAS" || Area == "ADMON GRAL"|| Area=="FINANZAS"||Area== "CXPAGAR")
            {
                gerenciaToolStripMenuItem.Enabled = true;
            }
            else
            {
                gerenciaToolStripMenuItem.Enabled = false;


            }

            if (Area == "SISTEMAS" || Area == "ADMON GRAL" )
            {
                ventasPTiendaToolStripMenuItem.Enabled = true;
            }
            else
            {
                ventasPTiendaToolStripMenuItem.Enabled = false;

                
            }

            if (Area == "SISTEMAS" || Area == "ADMON GRAL" || Area == "FINANZAS" ||Area== "CXPAGAR")
            {
                reporteCostosToolStripMenuItem.Enabled = true;
            }
            else
            {
                reporteCostosToolStripMenuItem.Enabled = false;

               
            }



            if (Area == "SISTEMAS" || Area == "ADMON GRAL")
            {
                transaccionesPTiempoToolStripMenuItem.Enabled = true;
            }
            else
            {
                transaccionesPTiempoToolStripMenuItem.Enabled = false;


            }

            if (Area == "SISTEMAS" || Area == "ADMON GRAL")
            {
                depositoACuentasOsmartToolStripMenuItem.Enabled = true;
            }
            else
            {
                depositoACuentasOsmartToolStripMenuItem.Enabled = false;


            }


            if (Area == "SISTEMAS" || Area == "ADMON GRAL" || Area == "ENC CAJAS" || Area == "SUPER"  || Area == "GERENTE")
            {
                pagoAProveedoresToolStripMenuItem2.Enabled = true;
            }
            else
            {
                pagoAProveedoresToolStripMenuItem2.Enabled =false;
            }

            if (Area == "SISTEMAS" || Area == "ADMON GRAL"||Area=="COMPRAS" || Area == "CXPAGAR")
            {
                catalogosToolStripMenuItem.Enabled = true;
            }
            else
            {
                catalogosToolStripMenuItem.Enabled = false;
            }


            if (Area=="SUPER"||Area=="SISTEMAS"||Area== "ADMON GRAL")
            {
                supervisiónToolStripMenuItem.Enabled = true;
            }
            else
            {
                supervisiónToolStripMenuItem.Enabled = true;
            }

            string IP = optieneIp();
            string BD = optieneBd();

            lblBD.Text = BD;
            lblIP.Text = IP;

        }

        public void ejecutar (string dato)
        {
            lblUsuario.Text = dato;
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            log.Show();
        }

        private void calificacionescomisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificacionescs cal = new Calificacionescs();
            cal.Show();
        }

        private void formatoCajeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void formatoCajerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FormatoCajera c = new frm_FormatoCajera(Usuario);
            c.Show();
        }

        private void validarFormatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_validarcajas v= new frm_validarcajas();
            v.Show();
        }

        private void reportesDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rp_pagocomisiones rp = new Rp_pagocomisiones();
            rp.Show();
        }

        private void pagoComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoComisiones pc = new PagoComisiones();
            pc.Show();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void traspasosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void aplicarTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TraspasoTiendas);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new TraspasoTiendas(Usuario);
        //    frm.Show();

        //    //TraspasoTiendas appTras = new TraspasoTiendas(Usuario);
        //    //appTras.Show();
        //}

        //private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Existencias);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new Existencias(Usuario,Area);
        //    frm.Show();
        //}

        //private void crearTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CotizacionTraspaso);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new CotizacionTraspaso(Usuario);
        //    frm.Show();

        //    //CotizacionTraspaso traspaso = new CotizacionTraspaso(Usuario);
        //    //traspaso.Show();
        //}

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            //se localiza el formulario buscandolo entre los forms abiertos 
            //Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

            //if (frm != null)
            //{
            //    //si la instancia existe la pongo en primer plano
            //    frm.BringToFront();
            //    return;
            //}

            ////sino existe la instancia se crea una nueva
            //frm = new CuentasXPagar();
            //frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //menuStrip1.BackColor = Color.LightSteelBlue;
        }

        //private void estadosDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new CuentasXPagar();
        //    frm.Show();
        //}

        //private void reporteGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //CREA UN REPORTE DE LOS SALDOS DE TODOS LOS PROVEEDORES EN CIERTA SUCURSAL

        //    Form frm2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RPT_SaldoProveedores);

        //    if (frm2 != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm2.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm2 = new RPT_SaldoProveedores();
        //    frm2.Show();
        //}

        //private void datagridsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExistenciaXProveedor);

        //    if (frm3 != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm3.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm3 = new ExistenciaXProveedor();
        //    frm3.Show();
        //}

        //private void elQueVaASerElBuenoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExProductosProveedor);

        //    if (frm3 != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm3.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm3 = new ExProductosProveedor();
        //    frm3.Show();
        //}

       

        //private void cargarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_Compras);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_Compras(Usuario);
        //    frm.Show();

        //}

       

        

        //private void generadorDeClavesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GenClaves);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new GenClaves();
        //    frm.Show();

        //}

        private void tiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExProductosProveedor);

            if (frm3 != null)
            {
                //si la instancia existe la pongo en primer plano
                frm3.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm3 = new ExProductosProveedor();
            frm3.Show();
        }

        //private void vitrinasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EXP_vitrina);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new EXP_vitrina();
        //    frm.Show();
        //}

        private void ventasPTiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cONCENTRADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ofertasVitrinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExistenciasVitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ExistenciasVitrina();
            frm.Show();
        }

        private void ventasPTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasxTienda);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasxTienda();
            frm.Show();
        }

        //private void reporteCostosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void existenciasPorLineaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_existXlinea);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new form_existXlinea();
        //    frm.Show();
        //}

        //private void ventasPHoraToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ventasxhora);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_ventasxhora();
        //    frm.Show();
        //}

        //private void existenciasPorLineaToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_ExistVitrina);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new form_ExistVitrina();
        //    frm.Show();
        //}

        //private void reporteCostosToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_costos);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_costos();
        //    frm.Show();
        //}

        //private void crearConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_CreaGastosExterno);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_CreaGastosExterno();
        //    frm.Show();
        //}

        //private void registrarGastosExternoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_GastosExternos();
        //    frm.Show();
        //}

        //private void tIENDAToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Concentrador);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new Concentrador();
        //    frm.Show();
        //}

        //private void vITRINAToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ConcentradorVitrina);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_ConcentradorVitrina();
        //    frm.Show();
        //}

        //private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_pedido);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new frm_pedido();
        //    frm.Show();

        //}

        //private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void calculoDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PagoComisiones);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new PagoComisiones();
        //    frm.Show();
        //}

        //private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Calificacionescs);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new Calificacionescs();
        //    frm.Show();
        //}

        //private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void gerenteToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void altabajaAsesorasDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is registroAsesoras);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new registroAsesoras();
        //    frm.Show();
        //}

        //private void comisionesToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesAsesoras);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new ComisionesAsesoras();
        //    frm.Show();
        //}

        //private void totalComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TotalComisionesAsesoras);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new TotalComisionesAsesoras();
        //    frm.Show();
        //}

        //private void sugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        //{

          
          
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Sugerencias);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva

        //    //frm = new Sugerencias();
        //    //frm.Show();
        //    Sugerencias sug = new Sugerencias();
        //    sug.LB_cajera.Text = lblUsuario.Text;
        //    sug.Show();
        //}

        //private void etiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Etiquetas);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    Etiquetas et = new Etiquetas();
        //    et.LB_cajera.Text = lblUsuario.Text;
        //    et.Show();
        //    //sino existe la instancia se crea una nueva
        //    //frm = new Etiquetas();
        //    //frm.Show();
        //}

        //private void sugerenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteSug);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new ReporteSug();
        //    frm.Show();
        //}

        //private void repEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepEtiquetas);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new RepEtiquetas();
        //    frm.Show();
        //}

        //private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void inventarioFisicoToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is InvFisicoxLinea);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new InvFisicoxLinea();
        //    frm.Show();
        //}
        // =========================================================================================NUEVO MENU===============================//
        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Existencias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Existencias(Usuario, Area);
            frm.Show();
        }

        private void creaTraspasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CotizacionTraspaso);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CotizacionTraspaso(Usuario);
            frm.Show();
        }

        private void aplicarTraspasoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TraspasoTiendas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new TraspasoTiendas(Usuario);
            frm.Show();
        }

        private void cargarCompraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_Compras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_Compras(Usuario);
            frm.Show();
        }

        private void generadorClavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is GenClaves);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new GenClaves();
            frm.Show();
        }

        private void concentradorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           // se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Concentrador);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Concentrador();
            frm.Show();
        }

        private void existenciaProvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExProductosProveedor);

            if (frm3 != null)
            {
                //si la instancia existe la pongo en primer plano
                frm3.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm3 = new ExProductosProveedor();
            frm3.Show();
        }

        private void sugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Sugerencias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva

            //frm = new Sugerencias();
            //frm.Show();
            Sugerencias sug = new Sugerencias();
            sug.LB_cajera.Text = lblUsuario.Text;
            sug.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Calificacionescs);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Calificacionescs();
            frm.Show();
        }

        private void calculoComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PagoComisiones);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new PagoComisiones();
            frm.Show();
        }

        private void etiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Etiquetas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            Etiquetas et = new Etiquetas();
            et.LB_cajera.Text = lblUsuario.Text;
            et.Show();
         
        }

        private void repSugerenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteSug);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteSug();
            frm.Show();
        }

        private void repEtiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepEtiquetas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepEtiquetas();
            frm.Show();
        }

        private void altaBajaAsesoraVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is registroAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new registroAsesoras();
            frm.Show();
        }

        private void comisionesDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesAsesoras();
            frm.Show();
        }

        private void totalComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TotalComisionesAsesoras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new TotalComisionesAsesoras(lblUsuario.Text);
            frm.Show();
        }

        private void existenciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ExistenciasVitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ExistenciasVitrina();
            frm.Show();
        }

        private void concentradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ConcentradorVitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_ConcentradorVitrina();
            frm.Show();
        }

        private void existenciasPProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EXP_vitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EXP_vitrina();
            frm.Show();
        }

        private void existenciasPLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_ExistVitrina);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new form_ExistVitrina();
            frm.Show();
        }

        private void reporteGeneralToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_saldos_prov);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_saldos_prov();
            frm.Show();
        }

        private void estadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasXPagar(lblUsuario.Text);
            frm.Show();
        }

        private void ventasPTiendaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         
        }

        private void reporteCostosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_costos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_costos();
            frm.Show();
        }

        private void crearConceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_CreaGastosExterno);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_CreaGastosExterno();
            frm.Show();
        }

        private void registrarConceptoExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_GastosExternos(Usuario);
            frm.Show();
        }

        private void transaccionesPTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ventasxhora);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_ventasxhora();
            frm.Show();
        }

        private void existenciaPLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is form_existXlinea);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new form_existXlinea();
            frm.Show();
        }

        private void cuentasPPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasBancarias);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasBancarias(Usuario);
            frm.Show();
        }

        private void pagosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasTarjeta);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasTarjeta(lblUsuario.Text);
            frm.Show();
        }

        private void pagoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagoproveedores);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            //frm = new Rep_pagoproveedores();
            //frm.Show();
            Rep_pagoproveedores rep = new Rep_pagoproveedores(lblUsuario.Text);
            rep.Show();
        }

        private void gastosxDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepGastosxDia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepGastosxDia(lblUsuario.Text);
            frm.Show();
        }

        private void cuentasBancariasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasBancariasOS);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasBancariasOS(Usuario);
            frm.Show();
        }

        private void depositoACuentasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RetirarEfectivoTiendas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RetirarEfectivoTiendas(lblUsuario.Text,lblEstacion.Text);
            frm.Show();
        }



        private void cobroTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Retiros);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            //frm = new Rep_CajaGral();
            //frm.Show();

            Retiros r = new Retiros(lblUsuario.Text, lblEstacion.Text);
            r.Show();
        }

        private void reporteCostosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_pedido);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_pedido(Usuario,Area);
            frm.Show();
        }

        private void ventasPTiendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasXTienda2);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasXTienda2();
            frm.Show();
        }

        private void ventasPLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasXLinea);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasXLinea();
            frm.Show();
        }

        private void seguimientoPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_pedido_almacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_pedido_almacen();
            frm.Show();
        }

        private void gerenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagoproveedores_Finanzas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagoproveedores_Finanzas(lblUsuario.Text);
            frm.Show();
        }

        private void finanzasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void repPagoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagoproveedores_Finanzas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagoproveedores_Finanzas(lblUsuario.Text);
            frm.Show();
        }

        private void cEDISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_Surtidor);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_Surtidor(Usuario);
            frm.Show();
        }

       
 // SE CREO ESTE MENU PARA ACCEDER DE NUEVO A ESTE MODULO POR PETICION DE LA GERENCIA GRAL.
        private void pagoAProveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagoproveedores_Finanzas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagoproveedores_Finanzas(lblUsuario.Text);
            frm.Show();
        }



        // SE CREO ESTE MENU PARA ACCEDER DE NUEVO A ESTE MODULO POR PETICION DE LA GERENCIA GRAL.

        private void ventasConTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasTarjeta);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasTarjeta(lblUsuario.Text);
            frm.Show();
        }
        // SE CREO ESTE MENU PARA ACCEDER DE NUEVO A ESTE MODULO POR PETICION DE LA GERENCIA GRAL.
        private void estadoDeCuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CuentasXPagar);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CuentasXPagar(lblUsuario.Text);
            frm.Show();
        }

        // SE CREO ESTE MENU PARA ACCEDER DE NUEVO A ESTE MODULO POR PETICION DE LA GERENCIA GRAL.
        private void saldoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_saldos_prov);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_saldos_prov();
            frm.Show();
        }

        private void depositoACuentasOsmartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RetirarEfectivoTiendas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RetirarEfectivoTiendas(lblUsuario.Text,lblEstacion.Text);
            frm.Show();
        }


        private void estadoDeCuentaOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cuentas_osmart);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cuentas_osmart(lblUsuario.Text);
            frm.Show();
        }


        //ESTE MENU SE CREO A PETICION DE LA GERENCIA GRAL
        private void gastosExternosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_GastosExternos(Usuario);
            frm.Show();
        }

        private void efectivoDisponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EfectivoDisponible);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EfectivoDisponible();
            frm.Show();
        }

        private void gastosXDíaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepGastosxDia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepGastosxDia(lblUsuario.Text);
            frm.Show();
        }

        private void artSinVenderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ArticulosSinVender);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ArticulosSinVender();
            frm.Show();
        }


        //este acceso se concedio por autorizacion del contador inocencio
        private void artSinMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ArticulosSinVender);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ArticulosSinVender();
            frm.Show();
        }

        private void ventasEnCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasEnCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasEnCajas(lblUsuario.Text);
            frm.Show();
        }

        private void pagoAProveedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PagosEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new PagosEncCajas(lblUsuario.Text,lblIP.Text);
            frm.Show();
        }

        private void pagoEnEfectivoAProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Pagos_efe_enc_cajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Pagos_efe_enc_cajas(lblUsuario.Text);
            frm.Show();
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is DevolucionesCompras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new DevolucionesCompras(lblUsuario.Text);
            frm.Show();
        }

        //ESTE NUEVO ACCESO AL MODULO SE CREÓ PARA LA AUX DE FINANZAS A PETICION DE ADMON. GRAL.
        private void efectivoDisponibleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EfectivoDisponible);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EfectivoDisponible();
            frm.Show();
        }
        //ESTE NUEVO ACCESO AL MODULO SE CREÓ PARA LA AUX DE FINANZAS A PETICION DE ADMON. GRAL.
        private void ventasEnCajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasEnCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasEnCajas(lblUsuario.Text);
            frm.Show();
        }

        //ESTE NUEVO ACCESO SE CREA PARA EL GTE. DE CUENTAS POR PAGAR A PETICION DEL CONT. INOCENCIO
        private void estadoDeCuentasOsmartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cuentas_osmart);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cuentas_osmart(lblUsuario.Text);
            frm.Show();
        }

       

        private void repSolicitudDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagosprogramados);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagosprogramados(lblUsuario.Text);
            frm.Show();
        }



        private void proveedoresServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ProveedorServicios);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ProveedorServicios(lblUsuario.Text);
            frm.Show();
        }


        //nuevo acceso a este modulo para el gerente de contabilidad
        private void reporteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasTarjeta);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasTarjeta(lblUsuario.Text);
            frm.Show();
        }


       //registra empleado de bodega
        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AltaEmpBodega);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new AltaEmpBodega();
            frm.Show();
        }

        private void calificarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalifBodega);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalifBodega();
            frm.Show();
        }

        private void calculoDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesBod);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesBod();
            frm.Show();
        }

        private void eliminarCalificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is EliminarCalifBod);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new EliminarCalifBod();
            frm.Show();
        }

        private void porcentajeDeUnidadesVendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PorcentajeUnidadesVend);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new PorcentajeUnidadesVend();
            frm.Show();
        }

        private void gerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //PROGRAMAR PAGO
        private void programarPagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Programar_Pago);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Programar_Pago(lblUsuario.Text);
            frm.Show();
        }


        //ACCESO AL REPORTE DE PAGOS PROGRAMADOS PARA EL GERENTE DE CUENTAS POR PAGAR

        private void reportePagosProgramadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_pagosprogramados);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_pagosprogramados(lblUsuario.Text);
            frm.Show();
        }

        private void modificarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Modificar_pago);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Modificar_pago();
            frm.Show();
        }

        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_OrdenesCompras);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_OrdenesCompras();
            frm.Show();
        }

        private void crearCorteZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CorteZ);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CorteZ();
            frm.Show();
        }

        private void buscarCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is BuscarCortez);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new BuscarCortez();
            frm.Show();
        }


        //acceso para la supervisora gral.
        private void ventasXHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ventasxhora);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_ventasxhora();
            frm.Show();
        }

        private void calificarDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesVerificadores);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesVerificadores();
            frm.Show();
        }

        private void reporteDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ReporteComVerif);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ReporteComVerif();
            frm.Show();
        }

        private void registroDeJefesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RegistroJefe);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RegistroJefe();
            frm.Show();
        }

        private void calificarGerenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarGte);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarGte();
            frm.Show();
        }

        private void reporteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_comisiones_gtes);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_comisiones_gtes();
            frm.Show();
        }

        private void estadoDeCuentasOsmartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cuentas_osmart);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cuentas_osmart(lblUsuario.Text);
            frm.Show();
        }

        private void gastosExternosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_GastosExternos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new frm_GastosExternos(lblUsuario.Text);
            frm.Show();
        }

        private void totalCompraPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_compras_prov_depto);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_compras_prov_depto();
            frm.Show();
        }

        private void paquetetíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void calificarDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarHosstess);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarHosstess();
            frm.Show();
        }

        private void reportePaqueteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_comisionesPaq);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_comisionesPaq();
            frm.Show();
        }

        private void ventasPorLineacostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasLineaProv);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasLineaProv();
            frm.Show();
        }

        private void unidadesVendidasProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is UnidadesVendidasProveedor);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new UnidadesVendidasProveedor();
            frm.Show();
        }

        private void calificarEncCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarEncCajas();
            frm.Show();
        }

        private void repComisionesEncDeCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ComisionesEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new ComisionesEncCajas();
            frm.Show();
        }

        private void stockDeLineasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is StockLineaProv);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new StockLineaProv();
            frm.Show();
        }

        private void intercambioDeMercancíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is IntercambioMercancia);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new IntercambioMercancia(lblUsuario.Text);
            frm.Show();
        }

        private void jefesAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calificarJefeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarJefeAlmacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarJefeAlmacen(lblUsuario.Text);
            frm.Show();
        }

        private void reporteJefeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_comisionesJefeAlmacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_comisionesJefeAlmacen();
            frm.Show();
        }


        //Esta acceso se creo por orden del contador inocencio para el contador francisco
        private void ventasPLineaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasXLinea);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasXLinea();
            frm.Show();
        }

        private void maximosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AgregarMaximos);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new AgregarMaximos();
            frm.Show();
        }

        private void califificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarCubres);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarCubres();
            frm.Show();
        }

        private void reporteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is RepComisionCubre);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new RepComisionCubre();
            frm.Show();
        }

        private void calificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarCubreEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarCubreEncCajas();
            frm.Show();
        }

        private void reporteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_cubreEncCajas);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_cubreEncCajas();
            frm.Show();
        }

        private void jefeAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is CalificarCubreAlmacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new CalificarCubreAlmacen();
            frm.Show();
        }

        private void reporteToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Rep_ComCubreJefeAlmacen);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new Rep_ComCubreJefeAlmacen();
            frm.Show();

        }

        private void ventasPorTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasXTienda2);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new VentasXTienda2();
            frm.Show();
        }

        private void fechaLlegadaXLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FechaLlegada);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new FechaLlegada();
            frm.Show();
        }


        //ESTE ACCESO DEL MODULO FECHALLEGADA SE CREO PARA LA ENC DE OFERTAS
        private void fechaLlegadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FechaLlegada);

            if (frm != null)
            {
                //si la instancia existe la pongo en primer plano
                frm.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            frm = new FechaLlegada();
            frm.Show();
        }










        //private void ventasPTiendasToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    //se localiza el formulario buscandolo entre los forms abiertos 
        //    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasxTienda);

        //    if (frm != null)
        //    {
        //        //si la instancia existe la pongo en primer plano
        //        frm.BringToFront();
        //        return;
        //    }

        //    //sino existe la instancia se crea una nueva
        //    frm = new VentasxTienda();
        //    frm.Show();
        //}

        //#################### PASA EL USUARIO A AL FORM ETIQUETAS ############################################################


    }
}
