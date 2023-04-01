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
    public partial class CalificarJefeAlmacen : Form
    {


        int intercambioSinSeguimiento = 0, mercDañada = 0, comisionesIncompletas = 0, reportes = 0, atrazo = 0, malFuncionamiento = 0, malEstado = 0, noReportarCambioLlaves = 0, etiquetarProd = 0, prodMalEtiquetados = 0;

       

        int noRotarProd = 0, sinRolComidas = 0, noAtenderTimbre = 0, malAcomodo = 0, noHacerCambiosPersonal = 0, sinUniforme = 0, personalSucio = 0, malasPalabras = 0, timbreGrosero = 0, malInventario = 0, sinRolsistemas = 0, prodNoExibidos = 0, sinSeguimientoRoles = 0;
        int cajasClave = 0, articulosClave = 0, proveedoresSurtir = 0, areasLimpias = 0, saldoMax = 0, conocerProd = 0, sugerencias = 0, fueraEmpaque = 0, articulosNoVisibles = 0, mercaRegada = 0, bañosSucios = 0, sinReparar = 0;
        int descuento = 0;
        string nombre = "", apellidos = "", usuario = "";


        public CalificarJefeAlmacen(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void CB_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sucursal = CB_sucursal.SelectedItem.ToString();

            string query = "SELECT nombre, apellidos FROM rd_registro_jefes WHERE puesto='JEFE ALMACEN' AND tienda='" + sucursal + "'";
            MySqlConnection con = BDConexicon.BodegaOpen();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            CB_jefeAlmacen.SelectedIndex = -1;
            CB_jefeAlmacen.Items.Clear();

            while (dr.Read())
            {
                nombre = dr["nombre"].ToString();
                apellidos = dr["apellidos"].ToString();
                CB_jefeAlmacen.Items.Add(dr["nombre"].ToString() + " " + dr["apellidos"].ToString());
            }
            dr.Close();
            con.Close();
        }




        public void Limpiar()
        {
            DG_tabla.Rows.Clear();

            DG_tabla.Rows.Add("CAJAS CON CLAVE Y DESCRIPCION (POR CAJA)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("ARTICULOS CON CLAVE Y DESCRIPCION EN ANAQUEL (POR ARTICULO) ", "$3.00", 0, 0);
            DG_tabla.Rows.Add("PROVEEDORES POR SURTIR MAXIMO 10 (8 VARIOS Y 2 BISUTERIA), EL DIA QUE LLEGA NO CUENTA, ", "$20.00", 0, 0);
            DG_tabla.Rows.Add("AREAS LIMPIAS Y PASILLOS DESPEJADOS (POR PASILLO)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("SALDO MAXIMO UNA TARA, ENVIAR FOTOS (MAX 8 DIAS) BUSCAR QUIEN PONGA PRECIO", "$5.00", 0, 0);
            DG_tabla.Rows.Add("CONOCER SU PRODUCTO", "$10.00", 0, 0);
            DG_tabla.Rows.Add("SUGERENCIAS Y SOLUCIONES(5) SOLUCIONADAS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("MERCANCIA FUERA DE SU EMPAQUE", "$3.00", 0, 0);
            DG_tabla.Rows.Add("ARTICULOS NO VISIBLES (POR ARTICULO)", "$3.00", 0, 0);
            DG_tabla.Rows.Add("MERCANCIA REGADA EN ANAQUELES ", "$3.00", 0, 0);
            DG_tabla.Rows.Add("BAÑOS SUCIOS (SARRO, PISO SUCIO, LLAVES EN MAL ESTADO, FUGAS, TAPA DEL TANQUE, ETC.)  ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("BICICLETAS, TRICICLOS Y  MONTABLES SIN REPARAR (POR PIEZA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("NO SEGUIMIENTO A INTERCAMBIO DE MERCANCIA (POR PRODUCTO)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("MERCANCIA DAÑADA POR DESCUIDO (POR PRODUCTO)", "$3.00", 0, 0);
            DG_tabla.Rows.Add("COMISIONES INCOMPLETAS (FOTOS DE AREA Y BAÑOS)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("REPORTE DE CAMARAS", "$10.00", 0, 0);
            DG_tabla.Rows.Add("ATRAZO EN ENVIO DE COMISIONES  (POR DIA DE ATRAZO)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("EQUIPO DE COMPUTO CON MAL FUNCIONAMIENTO (POR COMPUTADORA, IMPRESORA DE ETIQUETA, IMPORESORA POR DIA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("INSTALACIONES EN MAL ESTADO (LAMPARAS, FOCOS, CONTACTOS, APAGADORES, TAPAS, CABLEADO DE RED Y ELECTRICO),POR CADA CONCEPTO", "$5.00", 0, 0);
            DG_tabla.Rows.Add("NO REPORTAR CAMBIO DE CLAVES Y PRECIOS (POR ARTICULO)", "$3.00", 0, 0);
            DG_tabla.Rows.Add("ETIQUETAR PRODUCTOS CON CODIGO DE BARRAS (POR ETIQUETA)", "$1.00", 0, 0);
            DG_tabla.Rows.Add("PRODUCTOS MAL ETIQUETADOS (ETIQUETA BORROSA, MAL PUESTA)", "$1.00", 0, 0);
            DG_tabla.Rows.Add("NO ROTAR PRODUCTO (POR ARTICULO)", "$1.00", 0, 0);
            DG_tabla.Rows.Add("NO TENER ROL DE COMIDAS O NO RESPETARLO (POR PERSONA)", "$2.00", 0, 0);
            DG_tabla.Rows.Add("NO ATENDER EL TIMBRE (POR REPORTE DE TIENDA)", "$2.00", 0, 0);
            DG_tabla.Rows.Add("MAL ACOMODO DE MERCANCIA EN LA CANASTA, EN LA TARA Y EL MALACATE)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("NO HACER CAMBIOS DE PERSONAL PASANDO TEMPORADA (POR PERSONA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("BAJAR A LA TIENDA SIN UNIFORME (POR PERSONA) INCLUYE REPORTE DE CAMARAS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("PERSONAL SUCIO (UNIFORME, FALTA DE HIGIENE PERSONAL)", "$2.00", 0, 0);
            DG_tabla.Rows.Add("HABLAR PALABRAS OBSCENAS", "$6.00", 0, 0);
            DG_tabla.Rows.Add("CONTESTAR EL TIMBRE DE FORMA GROSERA", "$5.00", 0, 0);
            DG_tabla.Rows.Add("NO PREPARADO EL INVENTARIO ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("NO TENER ROLL DE MANTENIMIENTO DE SISTEMAS, CAMARAS Y AIRE ACONDICIONADO ", "$5.00", 0, 0);
            DG_tabla.Rows.Add("PRODUCTOS NO EXHIBIDOS", "$10.00", 0, 0);
            DG_tabla.Rows.Add("NO DAR SEGUEMIENTO A LOS ROLES DE MANTENIMIENTO ", "$5.00", 0, 0);

            LB_totaldesc.Text = "";
            LB_totalPagar.Text = "";
        }

        private void CalificarJefeAlmacen_Load(object sender, EventArgs e)
        {
            DG_tabla.Columns["ASPECTOS"].Width = 450;
            DG_tabla.Columns["PRECIO"].Width = 70;

            DG_tabla.Rows.Add("CAJAS CON CLAVE Y DESCRIPCION (POR CAJA)","$5.00",0,0);
            DG_tabla.Rows.Add("ARTICULOS CON CLAVE Y DESCRIPCION EN ANAQUEL (POR ARTICULO) ", "$3.00", 0, 0);
            DG_tabla.Rows.Add("PROVEEDORES POR SURTIR MAXIMO 10 (8 VARIOS Y 2 BISUTERIA), EL DIA QUE LLEGA NO CUENTA, ","$20.00", 0, 0);
            DG_tabla.Rows.Add("AREAS LIMPIAS Y PASILLOS DESPEJADOS (POR PASILLO)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("SALDO MAXIMO UNA TARA, ENVIAR FOTOS (MAX 8 DIAS) BUSCAR QUIEN PONGA PRECIO", "$5.00", 0, 0);
            DG_tabla.Rows.Add("CONOCER SU PRODUCTO", "$10.00", 0, 0);
            DG_tabla.Rows.Add("SUGERENCIAS Y SOLUCIONES(5) SOLUCIONADAS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("MERCANCIA FUERA DE SU EMPAQUE", "$3.00", 0, 0);
            DG_tabla.Rows.Add("ARTICULOS NO VISIBLES (POR ARTICULO)", "$3.00", 0, 0);
            DG_tabla.Rows.Add("MERCANCIA REGADA EN ANAQUELES ", "$3.00", 0, 0);
            DG_tabla.Rows.Add("BAÑOS SUCIOS (SARRO, PISO SUCIO, LLAVES EN MAL ESTADO, FUGAS, TAPA DEL TANQUE, ETC.)  ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("BICICLETAS, TRICICLOS Y  MONTABLES SIN REPARAR (POR PIEZA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("NO SEGUIMIENTO A INTERCAMBIO DE MERCANCIA (POR PRODUCTO)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("MERCANCIA DAÑADA POR DESCUIDO (POR PRODUCTO)", "$3.00", 0, 0);
            DG_tabla.Rows.Add("COMISIONES INCOMPLETAS (FOTOS DE AREA Y BAÑOS)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("REPORTE DE CAMARAS", "$10.00", 0, 0);
            DG_tabla.Rows.Add("ATRAZO EN ENVIO DE COMISIONES  (POR DIA DE ATRAZO)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("EQUIPO DE COMPUTO CON MAL FUNCIONAMIENTO (POR COMPUTADORA, IMPRESORA DE ETIQUETA, IMPORESORA POR DIA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("INSTALACIONES EN MAL ESTADO (LAMPARAS, FOCOS, CONTACTOS, APAGADORES, TAPAS, CABLEADO DE RED Y ELECTRICO),POR CADA CONCEPTO", "$5.00", 0, 0);
            DG_tabla.Rows.Add("NO REPORTAR CAMBIO DE CLAVES Y PRECIOS (POR ARTICULO)", "$3.00", 0, 0);
            DG_tabla.Rows.Add("ETIQUETAR PRODUCTOS CON CODIGO DE BARRAS (POR ETIQUETA)", "$1.00", 0, 0);
            DG_tabla.Rows.Add("PRODUCTOS MAL ETIQUETADOS (ETIQUETA BORROSA, MAL PUESTA)", "$1.00", 0, 0);
            DG_tabla.Rows.Add("NO ROTAR PRODUCTO (POR ARTICULO)", "$1.00", 0, 0);
            DG_tabla.Rows.Add("NO TENER ROL DE COMIDAS O NO RESPETARLO (POR PERSONA)", "$2.00", 0, 0);
            DG_tabla.Rows.Add("NO ATENDER EL TIMBRE (POR REPORTE DE TIENDA)", "$2.00", 0, 0);
            DG_tabla.Rows.Add("MAL ACOMODO DE MERCANCIA EN LA CANASTA, EN LA TARA Y EL MALACATE)", "$5.00", 0, 0);
            DG_tabla.Rows.Add("NO HACER CAMBIOS DE PERSONAL PASANDO TEMPORADA (POR PERSONA)", "$10.00", 0, 0);
            DG_tabla.Rows.Add("BAJAR A LA TIENDA SIN UNIFORME (POR PERSONA) INCLUYE REPORTE DE CAMARAS", "$5.00", 0, 0);
            DG_tabla.Rows.Add("PERSONAL SUCIO (UNIFORME, FALTA DE HIGIENE PERSONAL)", "$2.00", 0, 0);
            DG_tabla.Rows.Add("HABLAR PALABRAS OBSCENAS", "$6.00", 0, 0);
            DG_tabla.Rows.Add("CONTESTAR EL TIMBRE DE FORMA GROSERA", "$5.00", 0, 0);
            DG_tabla.Rows.Add("NO PREPARADO EL INVENTARIO ", "$10.00", 0, 0);
            DG_tabla.Rows.Add("NO TENER ROLL DE MANTENIMIENTO DE SISTEMAS, CAMARAS Y AIRE ACONDICIONADO ", "$5.00", 0, 0);
            DG_tabla.Rows.Add("PRODUCTOS NO EXHIBIDOS", "$10.00", 0, 0);
            DG_tabla.Rows.Add("NO DAR SEGUEMIENTO A LOS ROLES DE MANTENIMIENTO ", "$5.00", 0, 0);

            



        }





        private void BT_guardar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = BDConexicon.BodegaOpen();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;

            string query = "";
            //if (CB_sucursal.SelectedItem.ToString().Equals("VALLARTA"))
            //{
            //    query = "INSERT INTO rd_calif_jefe_almacen_va (cajasClave,articulosClave,proveedoresSurtir,areasLimpias,saldoMax,conocerProd,sugerencias,fueraEmpaque,articulosNovisibles,mercaRegada,bSucios,sinReparar,intercambioSinSeguimiento,mercDanada,comisionesIncompletas,reportes,atrazo,malFuncionamiento,malEstado,noReportarCambioClaves,etiquetarProd,prodMalEtiquetados,noRotarProd,sinRolComidas,noAtenderTimbre,malAcomodo,noHacerCambiosPersonal,sinUniforme,personalSucio,malasPalabras,timbreGrosero,malInventario,sinRolSistemas,prodNoExibidos,sinSeguimientoRoles,apoyo_semanal,descuento,totalPagar,nombre,apellidos,inicio_semana,fin_semana,usuario,sucursal)" +
            //   "VALUES(?cajasClave,?articulosClave,?proveedoresSurtir,?areasLimpias,?saldoMax,?conocerProd,?sugerencias,?fueraEmpaque,?articulosNovisibles,?mercaRegada,?bSucios,?sinReparar,?intercambioSinSeguimiento,?mercDanada,?comisionesIncompletas,?reportes,?atrazo,?malFuncionamiento,?malEstado,?noReportarCambioClaves,?etiquetarProd,?prodMalEtiquetados,?noRotarProd,?sinRolComidas,?noAtenderTimbre,?malAcomodo,?noHacerCambiosPersonal,?sinUniforme,?personalSucio,?malasPalabras,?timbreGrosero,?malInventario,?sinRolSistemas,?prodNoExibidos,?sinSeguimientoRoles,?apoyo_semanal,?descuento,?totalPagar,?nombre,?apellidos,?inicio_semana,?fin_semana,?usuario,?sucursal)";
            //}

            //if (CB_sucursal.SelectedItem.ToString().Equals("RENA"))
            //{
            //    query = "INSERT INTO rd_calif_jefe_almacen_re (cajasClave,articulosClave,proveedoresSurtir,areasLimpias,saldoMax,conocerProd,sugerencias,fueraEmpaque,articulosNovisibles,mercaRegada,bSucios,sinReparar,intercambioSinSeguimiento,mercDanada,comisionesIncompletas,reportes,atrazo,malFuncionamiento,malEstado,noReportarCambioClaves,etiquetarProd,prodMalEtiquetados,noRotarProd,sinRolComidas,noAtenderTimbre,malAcomodo,noHacerCambiosPersonal,sinUniforme,personalSucio,malasPalabras,timbreGrosero,malInventario,sinRolSistemas,prodNoExibidos,sinSeguimientoRoles,apoyo_semanal,descuento,totalPagar,nombre,apellidos,inicio_semana,fin_semana,usuario,sucursal)" +
            //   "VALUES(?cajasClave,?articulosClave,?proveedoresSurtir,?areasLimpias,?saldoMax,?conocerProd,?sugerencias,?fueraEmpaque,?articulosNovisibles,?mercaRegada,?bSucios,?sinReparar,?intercambioSinSeguimiento,?mercDanada,?comisionesIncompletas,?reportes,?atrazo,?malFuncionamiento,?malEstado,?noReportarCambioClaves,?etiquetarProd,?prodMalEtiquetados,?noRotarProd,?sinRolComidas,?noAtenderTimbre,?malAcomodo,?noHacerCambiosPersonal,?sinUniforme,?personalSucio,?malasPalabras,?timbreGrosero,?malInventario,?sinRolSistemas,?prodNoExibidos,?sinSeguimientoRoles,?apoyo_semanal,?descuento,?totalPagar,?nombre,?apellidos,?inicio_semana,?fin_semana,?usuario,?sucursal)";
            //}

            //if (CB_sucursal.SelectedItem.ToString().Equals("VELAZQUEZ"))
            //{
            //    query = "INSERT INTO rd_calif_jefe_almacen_ve (cajasClave,articulosClave,proveedoresSurtir,areasLimpias,saldoMax,conocerProd,sugerencias,fueraEmpaque,articulosNovisibles,mercaRegada,bSucios,sinReparar,intercambioSinSeguimiento,mercDanada,comisionesIncompletas,reportes,atrazo,malFuncionamiento,malEstado,noReportarCambioClaves,etiquetarProd,prodMalEtiquetados,noRotarProd,sinRolComidas,noAtenderTimbre,malAcomodo,noHacerCambiosPersonal,sinUniforme,personalSucio,malasPalabras,timbreGrosero,malInventario,sinRolSistemas,prodNoExibidos,sinSeguimientoRoles,apoyo_semanal,descuento,totalPagar,nombre,apellidos,inicio_semana,fin_semana,usuario,sucursal)" +
            //   "VALUES(?cajasClave,?articulosClave,?proveedoresSurtir,?areasLimpias,?saldoMax,?conocerProd,?sugerencias,?fueraEmpaque,?articulosNovisibles,?mercaRegada,?bSucios,?sinReparar,?intercambioSinSeguimiento,?mercDanada,?comisionesIncompletas,?reportes,?atrazo,?malFuncionamiento,?malEstado,?noReportarCambioClaves,?etiquetarProd,?prodMalEtiquetados,?noRotarProd,?sinRolComidas,?noAtenderTimbre,?malAcomodo,?noHacerCambiosPersonal,?sinUniforme,?personalSucio,?malasPalabras,?timbreGrosero,?malInventario,?sinRolSistemas,?prodNoExibidos,?sinSeguimientoRoles,?apoyo_semanal,?descuento,?totalPagar,?nombre,?apellidos,?inicio_semana,?fin_semana,?usuario,?sucursal)";
            //}

            //if (CB_sucursal.SelectedItem.ToString().Equals("COLOSO"))
            //{
            //    query = "INSERT INTO rd_calif_jefe_almacen_co (cajasClave,articulosClave,proveedoresSurtir,areasLimpias,saldoMax,conocerProd,sugerencias,fueraEmpaque,articulosNovisibles,mercaRegada,bSucios,sinReparar,intercambioSinSeguimiento,mercDanada,comisionesIncompletas,reportes,atrazo,malFuncionamiento,malEstado,noReportarCambioClaves,etiquetarProd,prodMalEtiquetados,noRotarProd,sinRolComidas,noAtenderTimbre,malAcomodo,noHacerCambiosPersonal,sinUniforme,personalSucio,malasPalabras,timbreGrosero,malInventario,sinRolSistemas,prodNoExibidos,sinSeguimientoRoles,apoyo_semanal,descuento,totalPagar,nombre,apellidos,inicio_semana,fin_semana,usuario,sucursal)" +
            //   "VALUES(?cajasClave,?articulosClave,?proveedoresSurtir,?areasLimpias,?saldoMax,?conocerProd,?sugerencias,?fueraEmpaque,?articulosNovisibles,?mercaRegada,?bSucios,?sinReparar,?intercambioSinSeguimiento,?mercDanada,?comisionesIncompletas,?reportes,?atrazo,?malFuncionamiento,?malEstado,?noReportarCambioClaves,?etiquetarProd,?prodMalEtiquetados,?noRotarProd,?sinRolComidas,?noAtenderTimbre,?malAcomodo,?noHacerCambiosPersonal,?sinUniforme,?personalSucio,?malasPalabras,?timbreGrosero,?malInventario,?sinRolSistemas,?prodNoExibidos,?sinSeguimientoRoles,?apoyo_semanal,?descuento,?totalPagar,?nombre,?apellidos,?inicio_semana,?fin_semana,?usuario,?sucursal)";
            //}
            query = "INSERT INTO rd_calif_jefe_almacen_va (cajasClave,articulosClave,proveedoresSurtir,areasLimpias,saldoMax,conocerProd,sugerencias,fueraEmpaque,articulosNovisibles,mercaRegada,bSucios,sinReparar,intercambioSinSeguimiento,mercDanada,comisionesIncompletas,reportes,atrazo,malFuncionamiento,malEstado,noReportarCambioClaves,etiquetarProd,prodMalEtiquetados,noRotarProd,sinRolComidas,noAtenderTimbre,malAcomodo,noHacerCambiosPersonal,sinUniforme,personalSucio,malasPalabras,timbreGrosero,malInventario,sinRolSistemas,prodNoExibidos,sinSeguimientoRoles,apoyo_semanal,descuento,totalPagar,nombre,apellidos,inicio_semana,fin_semana,usuario,sucursal)" +
              "VALUES(?cajasClave,?articulosClave,?proveedoresSurtir,?areasLimpias,?saldoMax,?conocerProd,?sugerencias,?fueraEmpaque,?articulosNovisibles,?mercaRegada,?bSucios,?sinReparar,?intercambioSinSeguimiento,?mercDanada,?comisionesIncompletas,?reportes,?atrazo,?malFuncionamiento,?malEstado,?noReportarCambioClaves,?etiquetarProd,?prodMalEtiquetados,?noRotarProd,?sinRolComidas,?noAtenderTimbre,?malAcomodo,?noHacerCambiosPersonal,?sinUniforme,?personalSucio,?malasPalabras,?timbreGrosero,?malInventario,?sinRolSistemas,?prodNoExibidos,?sinSeguimientoRoles,?apoyo_semanal,?descuento,?totalPagar,?nombre,?apellidos,?inicio_semana,?fin_semana,?usuario,?sucursal)";

            MySqlCommand cmd = new MySqlCommand(query,conexion);

            cmd.Parameters.AddWithValue("?cajasClave",cajasClave);
            cmd.Parameters.AddWithValue("?articulosClave", articulosClave);
            cmd.Parameters.AddWithValue("?proveedoresSurtir", proveedoresSurtir);
            cmd.Parameters.AddWithValue("?areasLimpias", areasLimpias);
            cmd.Parameters.AddWithValue("?saldoMax", saldoMax);
            cmd.Parameters.AddWithValue("?conocerProd", conocerProd);
            cmd.Parameters.AddWithValue("?sugerencias", sugerencias);
            cmd.Parameters.AddWithValue("?fueraEmpaque", fueraEmpaque);
            cmd.Parameters.AddWithValue("?articulosNoVisibles", articulosNoVisibles);
            cmd.Parameters.AddWithValue("?mercaRegada", mercaRegada);
            cmd.Parameters.AddWithValue("?bSucios", bañosSucios);
            cmd.Parameters.AddWithValue("?sinReparar", sinReparar);
            cmd.Parameters.AddWithValue("?intercambioSinSeguimiento", intercambioSinSeguimiento);
            cmd.Parameters.AddWithValue("?mercDanada", mercDañada);
            cmd.Parameters.AddWithValue("?comisionesIncompletas", comisionesIncompletas);
            cmd.Parameters.AddWithValue("?reportes", reportes );
            cmd.Parameters.AddWithValue("?atrazo", atrazo);
            cmd.Parameters.AddWithValue("?malFuncionamiento", malFuncionamiento);
            cmd.Parameters.AddWithValue("?malEstado", malEstado);
            cmd.Parameters.AddWithValue("?noReportarCambioClaves", noReportarCambioLlaves);
            cmd.Parameters.AddWithValue("?etiquetarProd", etiquetarProd);
            cmd.Parameters.AddWithValue("?prodMalEtiquetados", prodMalEtiquetados);
            cmd.Parameters.AddWithValue("?noRotarProd", noRotarProd);
            cmd.Parameters.AddWithValue("?sinRolComidas", sinRolComidas);
            cmd.Parameters.AddWithValue("?noAtenderTimbre", noAtenderTimbre);
            cmd.Parameters.AddWithValue("?malAcomodo", malAcomodo);
            cmd.Parameters.AddWithValue("?noHacerCambiosPersonal", noHacerCambiosPersonal);
            cmd.Parameters.AddWithValue("?sinUniforme", sinUniforme);
            cmd.Parameters.AddWithValue("?personalSucio", personalSucio);
            cmd.Parameters.AddWithValue("?malasPalabras", malasPalabras);
            cmd.Parameters.AddWithValue("?timbreGrosero", timbreGrosero);
            cmd.Parameters.AddWithValue("?malInventario", malInventario);
            cmd.Parameters.AddWithValue("?sinRolSistemas", sinRolsistemas);
            cmd.Parameters.AddWithValue("?prodNoExibidos", prodNoExibidos);
            cmd.Parameters.AddWithValue("?sinSeguimientoRoles", sinSeguimientoRoles);
            cmd.Parameters.AddWithValue("?apoyo_semanal", 1500);
            cmd.Parameters.AddWithValue("?descuento", descuento);
            cmd.Parameters.AddWithValue("?totalPagar", 1500-descuento);
            cmd.Parameters.AddWithValue("?nombre", nombre);
            cmd.Parameters.AddWithValue("?apellidos", apellidos);
            cmd.Parameters.AddWithValue("?inicio_semana", inicio.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?fin_semana", fin.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("?usuario", usuario);
            cmd.Parameters.AddWithValue("?sucursal", CB_sucursal.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha guardado la calificación del Jefe de Almacen de "+CB_sucursal.SelectedItem.ToString());

            Limpiar();



        }



        private void BT_calcular_Click(object sender, EventArgs e)
        {


            descuento = 0;
            cajasClave = Convert.ToInt32(DG_tabla.Rows[0].Cells[2].Value);
            articulosClave = Convert.ToInt32(DG_tabla.Rows[1].Cells[2].Value);
            proveedoresSurtir = Convert.ToInt32(DG_tabla.Rows[2].Cells[2].Value);
            areasLimpias = Convert.ToInt32(DG_tabla.Rows[3].Cells[2].Value);
            saldoMax = Convert.ToInt32(DG_tabla.Rows[4].Cells[2].Value);
            conocerProd = Convert.ToInt32(DG_tabla.Rows[5].Cells[2].Value);
            sugerencias = Convert.ToInt32(DG_tabla.Rows[6].Cells[2].Value);
            fueraEmpaque = Convert.ToInt32(DG_tabla.Rows[7].Cells[2].Value);
            articulosNoVisibles = Convert.ToInt32(DG_tabla.Rows[8].Cells[2].Value);
            mercaRegada = Convert.ToInt32(DG_tabla.Rows[9].Cells[2].Value);
            bañosSucios = Convert.ToInt32(DG_tabla.Rows[10].Cells[2].Value);
            sinReparar = Convert.ToInt32(DG_tabla.Rows[11].Cells[2].Value);
            intercambioSinSeguimiento = Convert.ToInt32(DG_tabla.Rows[12].Cells[2].Value);
            mercDañada = Convert.ToInt32(DG_tabla.Rows[13].Cells[2].Value);
            comisionesIncompletas = Convert.ToInt32(DG_tabla.Rows[14].Cells[2].Value);
            reportes = Convert.ToInt32(DG_tabla.Rows[15].Cells[2].Value);
            atrazo = Convert.ToInt32(DG_tabla.Rows[16].Cells[2].Value);
            malFuncionamiento = Convert.ToInt32(DG_tabla.Rows[17].Cells[2].Value);
            malEstado = Convert.ToInt32(DG_tabla.Rows[18].Cells[2].Value);
            noReportarCambioLlaves = Convert.ToInt32(DG_tabla.Rows[19].Cells[2].Value);
            etiquetarProd = Convert.ToInt32(DG_tabla.Rows[20].Cells[2].Value);
            prodMalEtiquetados = Convert.ToInt32(DG_tabla.Rows[21].Cells[2].Value);
            noRotarProd = Convert.ToInt32(DG_tabla.Rows[22].Cells[2].Value);
            sinRolComidas = Convert.ToInt32(DG_tabla.Rows[23].Cells[2].Value);
            noAtenderTimbre = Convert.ToInt32(DG_tabla.Rows[24].Cells[2].Value);
            malAcomodo = Convert.ToInt32(DG_tabla.Rows[25].Cells[2].Value);
            noHacerCambiosPersonal = Convert.ToInt32(DG_tabla.Rows[26].Cells[2].Value);
            sinUniforme = Convert.ToInt32(DG_tabla.Rows[27].Cells[2].Value);
            personalSucio = Convert.ToInt32(DG_tabla.Rows[28].Cells[2].Value);
            malasPalabras = Convert.ToInt32(DG_tabla.Rows[29].Cells[2].Value);
            timbreGrosero = Convert.ToInt32(DG_tabla.Rows[30].Cells[2].Value);
            malInventario = Convert.ToInt32(DG_tabla.Rows[31].Cells[2].Value);
            sinRolsistemas = Convert.ToInt32(DG_tabla.Rows[32].Cells[2].Value);
            prodNoExibidos = Convert.ToInt32(DG_tabla.Rows[33].Cells[2].Value);
            sinSeguimientoRoles = Convert.ToInt32(DG_tabla.Rows[34].Cells[2].Value);

            DG_tabla.Rows[0].Cells[3].Value = cajasClave * 5;
            DG_tabla.Rows[1].Cells[3].Value = articulosClave * 3;
            DG_tabla.Rows[2].Cells[3].Value = proveedoresSurtir * 20;
            DG_tabla.Rows[3].Cells[3].Value = areasLimpias * 5;
            DG_tabla.Rows[4].Cells[3].Value = saldoMax * 5;
            DG_tabla.Rows[5].Cells[3].Value = conocerProd * 10;
            DG_tabla.Rows[6].Cells[3].Value = sugerencias * 5;
            DG_tabla.Rows[7].Cells[3].Value = fueraEmpaque * 3;
            DG_tabla.Rows[8].Cells[3].Value = articulosNoVisibles * 3;
            DG_tabla.Rows[9].Cells[3].Value = mercaRegada * 3;
            DG_tabla.Rows[10].Cells[3].Value = bañosSucios * 10;
            DG_tabla.Rows[11].Cells[3].Value = sinReparar * 10;
            DG_tabla.Rows[12].Cells[3].Value = intercambioSinSeguimiento * 5;
            DG_tabla.Rows[13].Cells[3].Value = mercDañada * 3;
            DG_tabla.Rows[14].Cells[3].Value = comisionesIncompletas * 5;
            DG_tabla.Rows[15].Cells[3].Value = reportes * 10;
            DG_tabla.Rows[16].Cells[3].Value = atrazo * 10;
            DG_tabla.Rows[17].Cells[3].Value = malFuncionamiento * 10;
            DG_tabla.Rows[18].Cells[3].Value = malEstado * 5;
            DG_tabla.Rows[19].Cells[3].Value = noReportarCambioLlaves * 3;
            DG_tabla.Rows[20].Cells[3].Value = etiquetarProd * 1;
            DG_tabla.Rows[21].Cells[3].Value = prodMalEtiquetados * 1;
            DG_tabla.Rows[22].Cells[3].Value = noRotarProd * 1;
            DG_tabla.Rows[23].Cells[3].Value = sinRolComidas * 2;
            DG_tabla.Rows[24].Cells[3].Value = noAtenderTimbre * 2;
            DG_tabla.Rows[25].Cells[3].Value = malAcomodo * 5;
            DG_tabla.Rows[26].Cells[3].Value = noHacerCambiosPersonal * 10;
            DG_tabla.Rows[27].Cells[3].Value = sinUniforme * 5;
            DG_tabla.Rows[28].Cells[3].Value = personalSucio * 2;
            DG_tabla.Rows[29].Cells[3].Value = malasPalabras * 6;
            DG_tabla.Rows[30].Cells[3].Value = timbreGrosero * 5;
            DG_tabla.Rows[31].Cells[3].Value = malInventario * 10;
            DG_tabla.Rows[32].Cells[3].Value = sinRolsistemas * 5;
            DG_tabla.Rows[33].Cells[3].Value = prodNoExibidos * 10;
            DG_tabla.Rows[34].Cells[3].Value = sinSeguimientoRoles * 5;


            for (int i = 0; i <= 34; i++)
            {
                descuento += Convert.ToInt32(DG_tabla.Rows[i].Cells[3].Value);
            }

            LB_totaldesc.Text = Convert.ToString(descuento);
            LB_totalPagar.Text = Convert.ToString(1000-descuento);
        }
    }
}
