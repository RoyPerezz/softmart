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
    public partial class Rep_comisionesJefeAlmacen : Form
    {



        int cajasClave = 0, articulosClave = 0, proveedoresSurtir = 0, areasLimpias = 0, saldoMax = 0, conocerProd = 0, sugerencias = 0, fueraEmpaque = 0, articulosNoVisibles = 0, mercaRegada = 0, bañosSucios = 0, sinReparar = 0;

        int intercambioSinSeguimiento = 0, mercDañada = 0, comisionesIncompletas = 0, reportes = 0, atrazo = 0, malFuncionamiento = 0, malEstado = 0, noReportarCambioClaves = 0, etiquetarProd = 0, prodMalEtiquetados = 0;
        int noRotarProd = 0, sinRolComidas = 0, noAtenderTimbre = 0, malAcomodo = 0, noHacerCambiosPersonal = 0, sinUniforme = 0, personalSucio = 0, malasPalabras = 0, timbreGrosero = 0, malInventario = 0, sinRolsistemas = 0, prodNoExibidos = 0, sinSeguimientoRoles = 0;
#pragma warning disable CS0414 // El campo 'Rep_comisionesJefeAlmacen.descuento' está asignado pero su valor nunca se usa
        int descuento = 0;
#pragma warning restore CS0414 // El campo 'Rep_comisionesJefeAlmacen.descuento' está asignado pero su valor nunca se usa

        public Rep_comisionesJefeAlmacen()
        {
            InitializeComponent();
        }

        public void Calcular()
        {
            for (int i = 2; i < 6; i++)
            {
                cajasClave = Convert.ToInt32(DG_tabla.Rows[0].Cells[i].Value);
                articulosClave = Convert.ToInt32(DG_tabla.Rows[1].Cells[i].Value);
                proveedoresSurtir = Convert.ToInt32(DG_tabla.Rows[2].Cells[i].Value);
                areasLimpias = Convert.ToInt32(DG_tabla.Rows[3].Cells[i].Value);
                saldoMax = Convert.ToInt32(DG_tabla.Rows[4].Cells[i].Value);
                conocerProd = Convert.ToInt32(DG_tabla.Rows[5].Cells[i].Value);
                sugerencias = Convert.ToInt32(DG_tabla.Rows[6].Cells[i].Value);
                fueraEmpaque = Convert.ToInt32(DG_tabla.Rows[7].Cells[i].Value);
                articulosNoVisibles = Convert.ToInt32(DG_tabla.Rows[8].Cells[i].Value);
                mercaRegada = Convert.ToInt32(DG_tabla.Rows[9].Cells[i].Value);
                bañosSucios = Convert.ToInt32(DG_tabla.Rows[10].Cells[i].Value);
                sinReparar = Convert.ToInt32(DG_tabla.Rows[11].Cells[i].Value);
                intercambioSinSeguimiento = Convert.ToInt32(DG_tabla.Rows[12].Cells[i].Value);
                mercDañada = Convert.ToInt32(DG_tabla.Rows[13].Cells[i].Value);
                comisionesIncompletas = Convert.ToInt32(DG_tabla.Rows[14].Cells[i].Value);
                reportes = Convert.ToInt32(DG_tabla.Rows[15].Cells[i].Value);
                atrazo = Convert.ToInt32(DG_tabla.Rows[16].Cells[i].Value);
                malFuncionamiento = Convert.ToInt32(DG_tabla.Rows[17].Cells[i].Value);
                malEstado = Convert.ToInt32(DG_tabla.Rows[18].Cells[i].Value);
                noReportarCambioClaves = Convert.ToInt32(DG_tabla.Rows[19].Cells[i].Value);
                etiquetarProd = Convert.ToInt32(DG_tabla.Rows[20].Cells[i].Value);
                prodMalEtiquetados = Convert.ToInt32(DG_tabla.Rows[21].Cells[i].Value);
                noRotarProd = Convert.ToInt32(DG_tabla.Rows[22].Cells[i].Value);
                sinRolComidas = Convert.ToInt32(DG_tabla.Rows[23].Cells[i].Value);
                noAtenderTimbre = Convert.ToInt32(DG_tabla.Rows[24].Cells[i].Value);
                malAcomodo = Convert.ToInt32(DG_tabla.Rows[25].Cells[i].Value);
                noHacerCambiosPersonal = Convert.ToInt32(DG_tabla.Rows[26].Cells[i].Value);
                sinUniforme = Convert.ToInt32(DG_tabla.Rows[27].Cells[i].Value);
                personalSucio = Convert.ToInt32(DG_tabla.Rows[28].Cells[i].Value);
                malasPalabras = Convert.ToInt32(DG_tabla.Rows[29].Cells[i].Value);
                timbreGrosero = Convert.ToInt32(DG_tabla.Rows[30].Cells[i].Value);
                malInventario = Convert.ToInt32(DG_tabla.Rows[31].Cells[i].Value);
                sinRolsistemas = Convert.ToInt32(DG_tabla.Rows[32].Cells[i].Value);
                prodNoExibidos = Convert.ToInt32(DG_tabla.Rows[33].Cells[i].Value);
                sinSeguimientoRoles = Convert.ToInt32(DG_tabla.Rows[34].Cells[i].Value);

                DG_tabla.Rows[0].Cells[i + 4].Value = cajasClave * 5;
                DG_tabla.Rows[1].Cells[i + 4].Value = articulosClave * 3;
                DG_tabla.Rows[2].Cells[i + 4].Value = proveedoresSurtir * 20;
                DG_tabla.Rows[3].Cells[i + 4].Value = areasLimpias * 5;
                DG_tabla.Rows[4].Cells[i + 4].Value = saldoMax * 5;
                DG_tabla.Rows[5].Cells[i + 4].Value = conocerProd * 10;
                DG_tabla.Rows[6].Cells[i + 4].Value = sugerencias * 5;
                DG_tabla.Rows[7].Cells[i + 4].Value = fueraEmpaque * 3;
                DG_tabla.Rows[8].Cells[i + 4].Value = articulosNoVisibles * 3;
                DG_tabla.Rows[9].Cells[i + 4].Value = mercaRegada * 3;
                DG_tabla.Rows[10].Cells[i + 4].Value = bañosSucios * 10;
                DG_tabla.Rows[11].Cells[i + 4].Value = sinReparar * 10;
                DG_tabla.Rows[12].Cells[i + 4].Value = intercambioSinSeguimiento * 5;
                DG_tabla.Rows[13].Cells[i + 4].Value = mercDañada * 3;
                DG_tabla.Rows[14].Cells[i + 4].Value = comisionesIncompletas * 5;
                DG_tabla.Rows[15].Cells[i + 4].Value = reportes * 10;
                DG_tabla.Rows[16].Cells[i + 4].Value = atrazo * 10;
                DG_tabla.Rows[17].Cells[i + 4].Value = malFuncionamiento * 10;
                DG_tabla.Rows[18].Cells[i + 4].Value = malEstado * 5;
                DG_tabla.Rows[19].Cells[i + 4].Value = noReportarCambioClaves * 3;
                DG_tabla.Rows[20].Cells[i + 4].Value = etiquetarProd * 1;
                DG_tabla.Rows[21].Cells[i + 4].Value = prodMalEtiquetados * 1;
                DG_tabla.Rows[22].Cells[i + 4].Value = noRotarProd * 1;
                DG_tabla.Rows[23].Cells[i + 4].Value = sinRolComidas * 2;
                DG_tabla.Rows[24].Cells[i + 4].Value = noAtenderTimbre * 2;
                DG_tabla.Rows[25].Cells[i + 4].Value = malAcomodo * 5;
                DG_tabla.Rows[26].Cells[i + 4].Value = noHacerCambiosPersonal * 10;
                DG_tabla.Rows[27].Cells[i + 4].Value = sinUniforme * 5;
                DG_tabla.Rows[28].Cells[i + 4].Value = personalSucio * 2;
                DG_tabla.Rows[29].Cells[i + 4].Value = malasPalabras * 6;
                DG_tabla.Rows[30].Cells[i + 4].Value = timbreGrosero * 5;
                DG_tabla.Rows[31].Cells[i + 4].Value = malInventario * 10;
                DG_tabla.Rows[32].Cells[i + 4].Value = sinRolsistemas * 5;
                DG_tabla.Rows[33].Cells[i + 4].Value = prodNoExibidos * 10;
                DG_tabla.Rows[34].Cells[i + 4].Value = sinSeguimientoRoles * 5;













            }

            DG_tabla.Rows[35].DefaultCellStyle.BackColor = Color.SeaGreen;
            DG_tabla.Rows[36].DefaultCellStyle.BackColor = Color.SeaGreen;
            DG_tabla.Rows[37].DefaultCellStyle.BackColor = Color.SeaGreen;
            DG_tabla.Rows[38].DefaultCellStyle.BackColor = Color.SeaGreen;
            DG_tabla.Rows[35].DefaultCellStyle.ForeColor = Color.White;
            DG_tabla.Rows[36].DefaultCellStyle.ForeColor = Color.White;
            DG_tabla.Rows[37].DefaultCellStyle.ForeColor = Color.White;
            DG_tabla.Rows[38].DefaultCellStyle.ForeColor = Color.White;

            DG_tabla.Columns["T_VALLARTA"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["T_RENA"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["T_VELAZQUEZ"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["T_COLOSO"].DefaultCellStyle.Format = "C2";

        }


        private void Rep_comisionesJefeAlmacen_Load(object sender, EventArgs e)
        {

            DG_tabla.Rows.Add("CAJAS CON CLAVE Y DESCRIPCION (POR CAJA)", "$5.00", 0, 0,0,0,0,0,0,0);
            DG_tabla.Rows.Add("ARTICULOS CON CLAVE Y DESCRIPCION EN ANAQUEL (POR ARTICULO) ", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("PROVEEDORES POR SURTIR MAXIMO 10 (8 VARIOS Y 2 BISUTERIA), EL DIA QUE LLEGA NO CUENTA, ", "$20.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("AREAS LIMPIAS Y PASILLOS DESPEJADOS (POR PASILLO)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("SALDO MAXIMO UNA TARA, ENVIAR FOTOS (MAX 8 DIAS) BUSCAR QUIEN PONGA PRECIO", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("CONOCER SU PRODUCTO", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("SUGERENCIAS Y SOLUCIONES(5) SOLUCIONADAS", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("MERCANCIA FUERA DE SU EMPAQUE", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("ARTICULOS NO VISIBLES (POR ARTICULO)", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("MERCANCIA REGADA EN ANAQUELES ", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("BAÑOS SUCIOS (SARRO, PISO SUCIO, LLAVES EN MAL ESTADO, FUGAS, TAPA DEL TANQUE, ETC.)  ", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("BICICLETAS, TRICICLOS Y  MONTABLES SIN REPARAR (POR PIEZA)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO SEGUIMIENTO A INTERCAMBIO DE MERCANCIA (POR PRODUCTO)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("MERCANCIA DAÑADA POR DESCUIDO (POR PRODUCTO)", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("COMISIONES INCOMPLETAS (FOTOS DE AREA Y BAÑOS)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("REPORTE DE CAMARAS", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("ATRAZO EN ENVIO DE COMISIONES  (POR DIA DE ATRAZO)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("EQUIPO DE COMPUTO CON MAL FUNCIONAMIENTO (POR COMPUTADORA, IMPRESORA DE ETIQUETA, IMPORESORA POR DIA)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("INSTALACIONES EN MAL ESTADO (LAMPARAS, FOCOS, CONTACTOS, APAGADORES, TAPAS, CABLEADO DE RED Y ELECTRICO),POR CADA CONCEPTO", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO REPORTAR CAMBIO DE CLAVES Y PRECIOS (POR ARTICULO)", "$3.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("ETIQUETAR PRODUCTOS CON CODIGO DE BARRAS (POR ETIQUETA)", "$1.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("PRODUCTOS MAL ETIQUETADOS (ETIQUETA BORROSA, MAL PUESTA)", "$1.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO ROTAR PRODUCTO (POR ARTICULO)", "$1.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO TENER ROL DE COMIDAS O NO RESPETARLO (POR PERSONA)", "$2.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO ATENDER EL TIMBRE (POR REPORTE DE TIENDA)", "$2.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("MAL ACOMODO DE MERCANCIA EN LA CANASTA, EN LA TARA Y EL MALACATE)", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO HACER CAMBIOS DE PERSONAL PASANDO TEMPORADA (POR PERSONA)", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("BAJAR A LA TIENDA SIN UNIFORME (POR PERSONA) INCLUYE REPORTE DE CAMARAS", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("PERSONAL SUCIO (UNIFORME, FALTA DE HIGIENE PERSONAL)", "$2.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("HABLAR PALABRAS OBSCENAS", "$6.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("CONTESTAR EL TIMBRE DE FORMA GROSERA", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO PREPARADO EL INVENTARIO ", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO TENER ROLL DE MANTENIMIENTO DE SISTEMAS, CAMARAS Y AIRE ACONDICIONADO ", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("PRODUCTOS NO EXHIBIDOS", "$10.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("NO DAR SEGUEMIENTO A LOS ROLES DE MANTENIMIENTO ", "$5.00", 0, 0, 0, 0, 0, 0, 0, 0);
            DG_tabla.Rows.Add("APOYO SEMANAL ", "", "", "", "", "", 0, 0, 0, 0);
            DG_tabla.Rows.Add("TOTAL DESCUENTO ", "", "", "", "", "", 0, 0, 0, 0);
            DG_tabla.Rows.Add("TOTAL A PAGAR ", "", "", "", "", "", 0, 0, 0, 0);
            DG_tabla.Rows.Add("JEFE DE ALMACEN", "", "", "", "", "", "", "", "", "");

            DG_tabla.Columns["ASPECTOS"].Width = 500;
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            string query = "SELECT * FROM rd_calif_jefe_almacen_va WHERE inicio_semana='" + inicio.ToString("yyyy-MM-dd") + "' AND fin_semana='" + fin.ToString("yyyy-MM-dd") + "'"; ;

            MySqlConnection conexion = BDConexicon.BodegaOpen();

            MySqlCommand cmd = new MySqlCommand(query,conexion);

            MySqlDataReader dr = cmd.ExecuteReader();

            string sucursal = "";
            while (dr.Read())
            {
                sucursal = dr["sucursal"].ToString();

                if (sucursal.Equals("VALLARTA"))
                {
                    DG_tabla.Rows[0].Cells[2].Value = dr["cajasClave"].ToString();
                    DG_tabla.Rows[1].Cells[2].Value = dr["articulosClave"].ToString();
                    DG_tabla.Rows[2].Cells[2].Value = dr["proveedoresSurtir"].ToString();
                    DG_tabla.Rows[3].Cells[2].Value = dr["areasLimpias"].ToString();
                    DG_tabla.Rows[4].Cells[2].Value = dr["saldoMax"].ToString();
                    DG_tabla.Rows[5].Cells[2].Value = dr["conocerProd"].ToString();
                    DG_tabla.Rows[6].Cells[2].Value = dr["sugerencias"].ToString();
                    DG_tabla.Rows[7].Cells[2].Value = dr["fueraEmpaque"].ToString();
                    DG_tabla.Rows[8].Cells[2].Value = dr["articulosNoVisibles"].ToString();
                    DG_tabla.Rows[9].Cells[2].Value = dr["mercaRegada"].ToString();
                    DG_tabla.Rows[10].Cells[2].Value = dr["bSucios"].ToString();
                    DG_tabla.Rows[11].Cells[2].Value = dr["sinReparar"].ToString();
                    DG_tabla.Rows[12].Cells[2].Value = dr["intercambioSinSeguimiento"].ToString();
                    DG_tabla.Rows[13].Cells[2].Value = dr["mercDanada"].ToString();
                    DG_tabla.Rows[14].Cells[2].Value = dr["comisionesIncompletas"].ToString();
                    DG_tabla.Rows[15].Cells[2].Value = dr["reportes"].ToString();
                    DG_tabla.Rows[16].Cells[2].Value = dr["atrazo"].ToString();
                    DG_tabla.Rows[17].Cells[2].Value = dr["malFuncionamiento"].ToString();
                    DG_tabla.Rows[18].Cells[2].Value = dr["malEstado"].ToString();
                    DG_tabla.Rows[19].Cells[2].Value = dr["noReportarCambioClaves"].ToString();
                    DG_tabla.Rows[20].Cells[2].Value = dr["etiquetarProd"].ToString();
                    DG_tabla.Rows[21].Cells[2].Value = dr["prodMalEtiquetados"].ToString();
                    DG_tabla.Rows[22].Cells[2].Value = dr["noRotarProd"].ToString();
                    DG_tabla.Rows[23].Cells[2].Value = dr["sinRolComidas"].ToString();
                    DG_tabla.Rows[24].Cells[2].Value = dr["noAtenderTimbre"].ToString();
                    DG_tabla.Rows[25].Cells[2].Value = dr["malAcomodo"].ToString();
                    DG_tabla.Rows[26].Cells[2].Value = dr["noHacerCambiosPersonal"].ToString();
                    DG_tabla.Rows[27].Cells[2].Value = dr["sinUniforme"].ToString();
                    DG_tabla.Rows[28].Cells[2].Value = dr["personalSucio"].ToString();
                    DG_tabla.Rows[29].Cells[2].Value = dr["malasPalabras"].ToString();
                    DG_tabla.Rows[30].Cells[2].Value = dr["timbreGrosero"].ToString();
                    DG_tabla.Rows[31].Cells[2].Value = dr["malInventario"].ToString();
                    DG_tabla.Rows[32].Cells[2].Value = dr["sinRolSistemas"].ToString();
                    DG_tabla.Rows[33].Cells[2].Value = dr["prodNoExibidos"].ToString();
                    DG_tabla.Rows[34].Cells[2].Value = dr["sinSeguimientoRoles"].ToString();
                    DG_tabla.Rows[35].Cells[6].Value =Convert.ToInt32(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[36].Cells[6].Value = Convert.ToInt32(dr["descuento"].ToString());
                    DG_tabla.Rows[37].Cells[6].Value = Convert.ToInt32(dr["totalPagar"].ToString());
                    DG_tabla.Rows[38].Cells[6].Value = dr["nombre"].ToString();


                }

                if (sucursal.Equals("RENA"))
                {
                    DG_tabla.Rows[0].Cells[3].Value = dr["cajasClave"].ToString();
                    DG_tabla.Rows[1].Cells[3].Value = dr["articulosClave"].ToString();
                    DG_tabla.Rows[2].Cells[3].Value = dr["proveedoresSurtir"].ToString();
                    DG_tabla.Rows[3].Cells[3].Value = dr["areasLimpias"].ToString();
                    DG_tabla.Rows[4].Cells[3].Value = dr["saldoMax"].ToString();
                    DG_tabla.Rows[5].Cells[3].Value = dr["conocerProd"].ToString();
                    DG_tabla.Rows[6].Cells[3].Value = dr["sugerencias"].ToString();
                    DG_tabla.Rows[7].Cells[3].Value = dr["fueraEmpaque"].ToString();
                    DG_tabla.Rows[8].Cells[3].Value = dr["articulosNoVisibles"].ToString();
                    DG_tabla.Rows[9].Cells[3].Value = dr["mercaRegada"].ToString();
                    DG_tabla.Rows[10].Cells[3].Value = dr["bSucios"].ToString();
                    DG_tabla.Rows[11].Cells[3].Value = dr["sinReparar"].ToString();
                    DG_tabla.Rows[12].Cells[3].Value = dr["intercambioSinSeguimiento"].ToString();
                    DG_tabla.Rows[13].Cells[3].Value = dr["mercDanada"].ToString();
                    DG_tabla.Rows[14].Cells[3].Value = dr["comisionesIncompletas"].ToString();
                    DG_tabla.Rows[15].Cells[3].Value = dr["reportes"].ToString();
                    DG_tabla.Rows[16].Cells[3].Value = dr["atrazo"].ToString();
                    DG_tabla.Rows[17].Cells[3].Value = dr["malFuncionamiento"].ToString();
                    DG_tabla.Rows[18].Cells[3].Value = dr["malEstado"].ToString();
                    DG_tabla.Rows[19].Cells[3].Value = dr["noReportarCambioClaves"].ToString();
                    DG_tabla.Rows[20].Cells[3].Value = dr["etiquetarProd"].ToString();
                    DG_tabla.Rows[21].Cells[3].Value = dr["prodMalEtiquetados"].ToString();
                    DG_tabla.Rows[22].Cells[3].Value = dr["noRotarProd"].ToString();
                    DG_tabla.Rows[23].Cells[3].Value = dr["sinRolComidas"].ToString();
                    DG_tabla.Rows[24].Cells[3].Value = dr["noAtenderTimbre"].ToString();
                    DG_tabla.Rows[25].Cells[3].Value = dr["malAcomodo"].ToString();
                    DG_tabla.Rows[26].Cells[3].Value = dr["noHacerCambiosPersonal"].ToString();
                    DG_tabla.Rows[27].Cells[3].Value = dr["sinUniforme"].ToString();
                    DG_tabla.Rows[28].Cells[3].Value = dr["personalSucio"].ToString();
                    DG_tabla.Rows[29].Cells[3].Value = dr["malasPalabras"].ToString();
                    DG_tabla.Rows[30].Cells[3].Value = dr["timbreGrosero"].ToString();
                    DG_tabla.Rows[31].Cells[3].Value = dr["malInventario"].ToString();
                    DG_tabla.Rows[32].Cells[3].Value = dr["sinRolSistemas"].ToString();
                    DG_tabla.Rows[33].Cells[3].Value = dr["prodNoExibidos"].ToString();
                    DG_tabla.Rows[34].Cells[3].Value = dr["sinSeguimientoRoles"].ToString();
                    DG_tabla.Rows[35].Cells[7].Value = Convert.ToInt32(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[36].Cells[7].Value = Convert.ToInt32(dr["descuento"].ToString());
                    DG_tabla.Rows[37].Cells[7].Value = Convert.ToInt32(dr["totalPagar"].ToString());
                    DG_tabla.Rows[38].Cells[7].Value = dr["nombre"].ToString();

                }

                if (sucursal.Equals("COLOSO"))
                {
                    DG_tabla.Rows[0].Cells[5].Value = dr["cajasClave"].ToString();
                    DG_tabla.Rows[1].Cells[5].Value = dr["articulosClave"].ToString();
                    DG_tabla.Rows[2].Cells[5].Value = dr["proveedoresSurtir"].ToString();
                    DG_tabla.Rows[3].Cells[5].Value = dr["areasLimpias"].ToString();
                    DG_tabla.Rows[4].Cells[5].Value = dr["saldoMax"].ToString();
                    DG_tabla.Rows[5].Cells[5].Value = dr["conocerProd"].ToString();
                    DG_tabla.Rows[6].Cells[5].Value = dr["sugerencias"].ToString();
                    DG_tabla.Rows[7].Cells[5].Value = dr["fueraEmpaque"].ToString();
                    DG_tabla.Rows[8].Cells[5].Value = dr["articulosNoVisibles"].ToString();
                    DG_tabla.Rows[9].Cells[5].Value = dr["mercaRegada"].ToString();
                    DG_tabla.Rows[10].Cells[5].Value = dr["bSucios"].ToString();
                    DG_tabla.Rows[11].Cells[5].Value = dr["sinReparar"].ToString();
                    DG_tabla.Rows[12].Cells[5].Value = dr["intercambioSinSeguimiento"].ToString();
                    DG_tabla.Rows[13].Cells[5].Value = dr["mercDanada"].ToString();
                    DG_tabla.Rows[14].Cells[5].Value = dr["comisionesIncompletas"].ToString();
                    DG_tabla.Rows[15].Cells[5].Value = dr["reportes"].ToString();
                    DG_tabla.Rows[16].Cells[5].Value = dr["atrazo"].ToString();
                    DG_tabla.Rows[17].Cells[5].Value = dr["malFuncionamiento"].ToString();
                    DG_tabla.Rows[18].Cells[5].Value = dr["malEstado"].ToString();
                    DG_tabla.Rows[19].Cells[5].Value = dr["noReportarCambioClaves"].ToString();
                    DG_tabla.Rows[20].Cells[5].Value = dr["etiquetarProd"].ToString();
                    DG_tabla.Rows[21].Cells[5].Value = dr["prodMalEtiquetados"].ToString();
                    DG_tabla.Rows[22].Cells[5].Value = dr["noRotarProd"].ToString();
                    DG_tabla.Rows[23].Cells[5].Value = dr["sinRolComidas"].ToString();
                    DG_tabla.Rows[24].Cells[5].Value = dr["noAtenderTimbre"].ToString();
                    DG_tabla.Rows[25].Cells[5].Value = dr["malAcomodo"].ToString();
                    DG_tabla.Rows[26].Cells[5].Value = dr["noHacerCambiosPersonal"].ToString();
                    DG_tabla.Rows[27].Cells[5].Value = dr["sinUniforme"].ToString();
                    DG_tabla.Rows[28].Cells[5].Value = dr["personalSucio"].ToString();
                    DG_tabla.Rows[29].Cells[5].Value = dr["malasPalabras"].ToString();
                    DG_tabla.Rows[30].Cells[5].Value = dr["timbreGrosero"].ToString();
                    DG_tabla.Rows[31].Cells[5].Value = dr["malInventario"].ToString();
                    DG_tabla.Rows[32].Cells[5].Value = dr["sinRolSistemas"].ToString();
                    DG_tabla.Rows[33].Cells[5].Value = dr["prodNoExibidos"].ToString();
                    DG_tabla.Rows[34].Cells[5].Value = dr["sinSeguimientoRoles"].ToString();
                    DG_tabla.Rows[35].Cells[9].Value =Convert.ToInt32(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[36].Cells[9].Value = Convert.ToInt32(dr["descuento"].ToString());
                    DG_tabla.Rows[37].Cells[9].Value =Convert.ToInt32(dr["totalPagar"].ToString());
                    DG_tabla.Rows[38].Cells[9].Value = dr["nombre"].ToString();

                }

                if (sucursal.Equals("VELAZQUEZ"))
                {
                    DG_tabla.Rows[0].Cells[4].Value = dr["cajasClave"].ToString();
                    DG_tabla.Rows[1].Cells[4].Value = dr["articulosClave"].ToString();
                    DG_tabla.Rows[2].Cells[4].Value = dr["proveedoresSurtir"].ToString();
                    DG_tabla.Rows[3].Cells[4].Value = dr["areasLimpias"].ToString();
                    DG_tabla.Rows[4].Cells[4].Value = dr["saldoMax"].ToString();
                    DG_tabla.Rows[5].Cells[4].Value = dr["conocerProd"].ToString();
                    DG_tabla.Rows[6].Cells[4].Value = dr["sugerencias"].ToString();
                    DG_tabla.Rows[7].Cells[4].Value = dr["fueraEmpaque"].ToString();
                    DG_tabla.Rows[8].Cells[4].Value = dr["articulosNoVisibles"].ToString();
                    DG_tabla.Rows[9].Cells[4].Value = dr["mercaRegada"].ToString();
                    DG_tabla.Rows[10].Cells[4].Value = dr["bSucios"].ToString();
                    DG_tabla.Rows[11].Cells[4].Value = dr["sinReparar"].ToString();
                    DG_tabla.Rows[12].Cells[4].Value = dr["intercambioSinSeguimiento"].ToString();
                    DG_tabla.Rows[13].Cells[4].Value = dr["mercDanada"].ToString();
                    DG_tabla.Rows[14].Cells[4].Value = dr["comisionesIncompletas"].ToString();
                    DG_tabla.Rows[15].Cells[4].Value = dr["reportes"].ToString();
                    DG_tabla.Rows[16].Cells[4].Value = dr["atrazo"].ToString();
                    DG_tabla.Rows[17].Cells[4].Value = dr["malFuncionamiento"].ToString();
                    DG_tabla.Rows[18].Cells[4].Value = dr["malEstado"].ToString();
                    DG_tabla.Rows[19].Cells[4].Value = dr["noReportarCambioClaves"].ToString();
                    DG_tabla.Rows[20].Cells[4].Value = dr["etiquetarProd"].ToString();
                    DG_tabla.Rows[21].Cells[4].Value = dr["prodMalEtiquetados"].ToString();
                    DG_tabla.Rows[22].Cells[4].Value = dr["noRotarProd"].ToString();
                    DG_tabla.Rows[23].Cells[4].Value = dr["sinRolComidas"].ToString();
                    DG_tabla.Rows[24].Cells[4].Value = dr["noAtenderTimbre"].ToString();
                    DG_tabla.Rows[25].Cells[4].Value = dr["malAcomodo"].ToString();
                    DG_tabla.Rows[26].Cells[4].Value = dr["noHacerCambiosPersonal"].ToString();
                    DG_tabla.Rows[27].Cells[4].Value = dr["sinUniforme"].ToString();
                    DG_tabla.Rows[28].Cells[4].Value = dr["personalSucio"].ToString();
                    DG_tabla.Rows[29].Cells[4].Value = dr["malasPalabras"].ToString();
                    DG_tabla.Rows[30].Cells[4].Value = dr["timbreGrosero"].ToString();
                    DG_tabla.Rows[31].Cells[4].Value = dr["malInventario"].ToString();
                    DG_tabla.Rows[32].Cells[4].Value = dr["sinRolSistemas"].ToString();
                    DG_tabla.Rows[33].Cells[4].Value = dr["prodNoExibidos"].ToString();
                    DG_tabla.Rows[34].Cells[4].Value = dr["sinSeguimientoRoles"].ToString();
                    DG_tabla.Rows[35].Cells[8].Value = Convert.ToInt32(dr["apoyo_semanal"].ToString());
                    DG_tabla.Rows[36].Cells[8].Value = Convert.ToInt32(dr["descuento"].ToString());
                    DG_tabla.Rows[37].Cells[8].Value = Convert.ToInt32(dr["totalPagar"].ToString());
                    DG_tabla.Rows[38].Cells[8].Value = dr["nombre"].ToString();

                }
            }



          

            Calcular();
        }

        

        private void BT_exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);

            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;


            int indiceColumna = 0;



            foreach (DataGridViewColumn col in DG_tabla.Columns)
            {
                indiceColumna++;
                excel.Cells[5, indiceColumna] = col.Name;

            }

            int indiceFila = 4;

            foreach (DataGridViewRow row in DG_tabla.Rows)
            {
                indiceFila++;
                indiceColumna = 0;




                foreach (DataGridViewColumn col in DG_tabla.Columns)
                {
                    indiceColumna++;

                    excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;






                }



            }



            excel.Cells.Range["A3:F3"].Merge();
            excel.Cells.Range["A3"].Value = "COMISIONES DE LA SEMANA DEL " + inicio.ToString("dd-MM-yyyy") + " AL " + fin.ToString("dd-MM-yyyy") + "";
            excel.Cells.Range["B6:B40"].NumberFormat = "$#,##0.00";
            excel.Cells.Range["G6:J43"].NumberFormat = "$#,##0.00";


            excel.Visible = true;
        }
    }
}
