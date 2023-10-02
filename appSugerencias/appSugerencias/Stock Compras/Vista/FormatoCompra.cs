using appSugerencias.Stock_Compras.Controlador;
using appSugerencias.Stock_Compras.Modelo;
using appSugerencias.Utilidades;
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

namespace appSugerencias.Stock_Compras.Vista
{
    public partial class FormatoCompra : Form
    {
        string Usuario = "";
        public FormatoCompra(string usuario)
        {
            this.Usuario = usuario;
            InitializeComponent();
        }

        string descripArtiCompra, lineaCompra, marcaCompra, fabricanteCompra, articuloCompra, idFabricante, impuesto;
        int idMovsinv, idCompra, idPartcomp, idCuentasxPag, existenciaTotal, existenciaCompra, existenciaPrevia, itemsCompra, cantidadArticompra;

        double impuestoCompra, costoArtiCompra, mayoreoArtiCompra, menudeoArtiCompra, descuento,impuestoIVA=1.16;

        double importeArticulo, IVAcompra, costoArticulo, importeCompra, importecompraSinIVA, TotalCompra;
        private void FormatoCompra_Load(object sender, EventArgs e)
        {

            //Carga la lista de proveedores en el combobox CB_proveedores
            List<string> lista = CompraController.ListaProveedores();
            for (int i = 0; i < lista.Count; i++)
            {
                CB_proveedor.Items.Add(lista[i].ToString());
               
            }

            //Cargar fabricantes
           
            List<string> listaFabricantes = Catalogos.CatalogoNombreFabricantes();
            for (int i = 0; i < lista.Count; i++)
            {
                CB_cambio_fabricante.Items.Add(listaFabricantes[i].ToString());

            }

            //Carga el catalogo de lineas
            List<string> lineas = Catalogos.CatalogoClavesLineas();

            for (int i = 0; i < lineas.Count; i++)
            {
                CB_cambio_linea.Items.Add(lineas[i].ToString());
            }


            
        }

        private void CB_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Buscar los stock creados para cada proveedor
            string proveedor = CB_proveedor.Text;

            TB_idproveedor.Text = CompraController.ClaveProveedor(proveedor);

            List<string> stocks = CompraController.BuscarStocks(TB_idproveedor.Text);
            for (int i = 0; i < stocks.Count; i++)
            {
                CB_stock.Items.Add(stocks[i].ToString());
            }

           
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            List<Compra> compra = CompraController.BuscarDatosCompra(Convert.ToInt32(TB_idstock.Text));


            // obtengo los datos de folio, utilidad y descuento
            List<Compra> DatosCompra = CompraController.ValoresEncabezado(TB_idstock.Text);
            TB_folio.Text = DatosCompra[0].Folio.ToString();
            TB_utilidad.Text = DatosCompra[0].Utilidad.ToString();
            TB_descuento.Text = DatosCompra[0].Descuento.ToString();

            double descuento = Convert.ToInt32(TB_descuento.Text);
            double costo = 0;
           


            for (int i = 0; i < compra.Count; i++)
            {
                //Se aplica el descuentoal costo
                costo = compra[i].Costo;
                costo = costo - (costo * (descuento / 100));

                DG_tabla.Rows.Add(compra[i].ClaveProducto, compra[i].Descripcion,costo , compra[i].Precio_mayoreo, compra[i].Precio_menudo,"", compra[i].Linea,"",CB_proveedor.Text, 
                compra[i].CantidadVA, compra[i].CantidadRE, compra[i].CantidadVE, compra[i].CantidadCO, compra[i].CantidadBO);
            }

            
        }

        private void CB_stock_SelectedIndexChanged(object sender, EventArgs e)
        {

            TB_idstock.Text = Convert.ToString(CompraController.IdStockCompra(CB_stock.Text));
        }

        public void AplicarMarca(string marca)
        {

            int filas = DG_tabla.RowCount;

            if (filas>0)
            {
                for (int i = 0; i < DG_tabla.RowCount; i++)
                {
                    DG_tabla.Rows[i].Cells["MARCA"].Value = marca;
                }
            }else
            {
                MessageBox.Show("Debes seleccionar un stock");
            }
            
        }

        public void AplicarTipoImpuesto(string impuesto)
        {
            int filas = DG_tabla.RowCount;

            if (filas > 0)
            {
                for (int i = 0; i < DG_tabla.RowCount; i++)
                {
                    DG_tabla.Rows[i].Cells["IVA"].Value = impuesto;
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un stock");
            }
        }


        private void RB_com2_CheckedChanged(object sender, EventArgs e)
        {
            AplicarMarca("COM2");
        }

        private void RB_com3_CheckedChanged(object sender, EventArgs e)
        {
            AplicarMarca("COM3");
        }

        private void RB_iva_CheckedChanged(object sender, EventArgs e)
        {
            AplicarTipoImpuesto("IVA");
        }

        private void RB_sys_CheckedChanged(object sender, EventArgs e)
        {
            AplicarTipoImpuesto("SYS");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = DG_tabla.SelectedRows;


            if (filas.Count > 0)
            {
                foreach (DataGridViewRow item in filas)
                {
                    DG_tabla.Rows[item.Index].Cells["IVA"].Value = CB_tipoImpuesto.Text;
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila");
            }
        }

        private void BT_aplicar_cambio_linea_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = DG_tabla.SelectedRows;


            if (filas.Count > 0)
            {
                foreach (DataGridViewRow item in filas)
                {
                    DG_tabla.Rows[item.Index].Cells["LINEA"].Value = CB_cambio_linea.Text;
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila");
            }
        }

        private void BT_aplicar_cambio_fab_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = DG_tabla.SelectedRows;


            if (filas.Count > 0)
            {
                foreach (DataGridViewRow item in filas)
                {
                    DG_tabla.Rows[item.Index].Cells["FABRICANTE"].Value =CB_cambio_fabricante.Text;
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar al menos una fila");
            }
        }


        //aplicar descuento
        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void BT_Exportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);



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




            excel.Visible = true;
        }

        private void BT_Aplicar_Click(object sender, EventArgs e)
        {
            if (DG_tabla.Rows.Count>0)
            {
                string comando;
                int numArticulos = DG_tabla.Rows.Count;
                DateTime Fecha = DateTime.Now;
                DateTime FechaLlegada = DT_fecha_llegada.Value;
                string Hora = DateTime.Now.ToString("hh:mm:ss");

                MySqlConnection conectar = BDConexicon.ConexionSucursal(CB_sucursal.Text); // Se crea la conexión dependiendo de la tienda a donde se quiere aplicar la venta

                // ################################### SE OBTIENE Y ACTUALIZA CONSECUTIVO DE MOVSINV #########################################################################################
                int consecMovsinv = Consec.ConsecMovsinv(CB_sucursal.Text);// Se toma el consecutivo de movsinv

                MySqlCommand cmdc = new MySqlCommand("UPDATE consec SET Consec='" + (consecMovsinv + DG_tabla.Rows.Count) + "' WHERE Dato='movsinv'", conectar); // se actualizar el consecutivo de movsinv
                cmdc.ExecuteNonQuery();

                // ################################## SE OBTIENE Y ACTUALIZA CONSECUTIVO DE COMPRA ###############################################################################################
                int consecCompra = Consec.ConsecCompra(CB_sucursal.Text);

                MySqlCommand cmdc2 = new MySqlCommand("UPDATE consec SET Consec='" + consecCompra + "' WHERE Dato='Compra'", conectar);
                cmdc2.ExecuteNonQuery();

                // ################################## SE OBTIENE Y ACTUALIZA CONSECUTIVO DE PARTCOMP ###############################################################################################
                int consecPartCompra = Consec.ConsecPartcomp(CB_sucursal.Text);
                MySqlCommand cmdc3 = new MySqlCommand("UPDATE consec SET Consec='" + (consecPartCompra + DG_tabla.Rows.Count) + "' WHERE Dato='partcomp'", conectar);
                cmdc3.ExecuteNonQuery();


                // ################################## SE OBTIENE Y ACTUALIZA CONSECUTIVO DE CUENXPAG ###############################################################################################
                int consecCuentasXPagar = Consec.ConsecCuentasXPagar(CB_sucursal.Text);
                MySqlCommand cmdc4 = new MySqlCommand("UPDATE consec SET Consec='" + consecCuentasXPagar + "' WHERE Dato='cuenxpag'", conectar);
                cmdc4.ExecuteNonQuery();


               
               

                if (string.IsNullOrEmpty(TB_descuento.Text))
                {
                    descuento = 0;

                }
                else
                {
                    descuento = Convert.ToInt32(TB_descuento.Text);
                }

                double importeCompra = 0;
                importecompraSinIVA = 0;
                descuento = descuento * 0.01;
                itemsCompra = DG_tabla.Rows.Count;



                //==============================================
                //  0-articulo
                //  1-desccripcion
                //  2-costo_u
                //  3-mayoreo
                //  4-menudeo
                //  5-IMPUESTO
                //  6-linea
                //  7-marca
                //  8-fabricante
                //  9-vallarta
                // 10-rena
                // 11-velazquez
                // 12-coloso
                // 13-bodega
                // 14-PREGOT
                //=============================================

                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(DG_tabla[0, i].Value.ToString()))
                    {
                        articuloCompra = "";
                    }
                    else
                    {
                        articuloCompra = DG_tabla[0, i].Value.ToString();
                    }

                    if (string.IsNullOrEmpty(DG_tabla[1, i].Value.ToString()))
                    {
                        descripArtiCompra = "";
                    }
                    else
                    {
                        descripArtiCompra = DG_tabla[1, i].Value.ToString().TrimEnd();
                    }


                    costoArtiCompra = Convert.ToDouble(DG_tabla[2, i].Value);
                    costoArtiCompra = costoArtiCompra - (costoArtiCompra * descuento);


                    mayoreoArtiCompra = Convert.ToDouble(DG_tabla[3, i].Value);


                    menudeoArtiCompra = Convert.ToDouble(DG_tabla[4, i].Value);


                    //revisa el impuesto no este en blanco

                    if (string.IsNullOrEmpty(DG_tabla[5, i].Value.ToString().TrimEnd()))
                    {
                        impuesto = "IVA";
                    }
                    else
                    {
                        impuesto = DG_tabla[5, i].Value.ToString().TrimEnd();
                    }

                    // REVISAR ESTAS LINEAS DE CODIGO DAN
                    if (CB_sucursal.SelectedItem.Equals("BODEGA"))
                    {
                        if (string.IsNullOrEmpty(DG_tabla[13, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DG_tabla[13, i].Value);
                        }
                    }

                    if (CB_sucursal.SelectedItem.Equals("RENA"))
                    {
                        if (string.IsNullOrEmpty(DG_tabla[10, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DG_tabla[10, i].Value);
                        }
                    }

                    if (CB_sucursal.SelectedItem.Equals("COLOSO"))
                    {
                        if (string.IsNullOrEmpty(DG_tabla[12, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DG_tabla[12, i].Value);
                        }
                    }

                    if (CB_sucursal.SelectedItem.Equals("VELAZQUEZ"))
                    {
                        if (string.IsNullOrEmpty(DG_tabla[11, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DG_tabla[11, i].Value);
                        }
                    }

                    if (CB_sucursal.SelectedItem.Equals("VALLARTA"))
                    {

                        if (string.IsNullOrEmpty(DG_tabla[9, i].Value.ToString()))
                        {
                            existenciaCompra = 0;
                        }
                        else
                        {
                            existenciaCompra = Convert.ToInt32(DG_tabla[9, i].Value);
                        }
                    }

                   
                    if (string.IsNullOrEmpty(DG_tabla[6, i].Value.ToString()))
                    {
                        lineaCompra = "SYS";
                    }
                    else
                    {
                        lineaCompra = DG_tabla[6, i].Value.ToString();
                    }

                    if (string.IsNullOrEmpty(DG_tabla[7, i].Value.ToString()))
                    {
                        marcaCompra = "SYS";
                    }
                    else
                    {
                        marcaCompra = DG_tabla[7, i].Value.ToString();
                    }

                    if (string.IsNullOrEmpty(DG_tabla[8, i].Value.ToString()))
                    {
                        fabricanteCompra = "SYS";
                    }
                    else
                    {
                        fabricanteCompra = DG_tabla[8, i].Value.ToString();
                    }



                    //if (impuesto != "SYS" || impuesto != "sys")
                    //{
                    //        mayoreoArtiCompra = mayoreoArtiCompra / IVA;
                    //        menudeoArtiCompra = menudeoArtiCompra / IVA;


                    //        costoArtiCompra = costoArtiCompra / IVA;
                    //}

                    //SI EL IMPUESTO ES IGUAL A IVA REALIZA LAS OPERACIONES
                    if (impuesto.Equals("IVA") || impuesto.Equals("iva"))
                    {
                        mayoreoArtiCompra = mayoreoArtiCompra / impuestoIVA;
                        menudeoArtiCompra = menudeoArtiCompra / impuestoIVA;


                        costoArtiCompra = costoArtiCompra / impuestoIVA;
                    }


                    MySqlCommand cmdart = new MySqlCommand("SELECT EXISTENCIA FROM prods WHERE ARTICULO ='" + articuloCompra + "'", conectar);
                    MySqlDataReader mdrart;
                    mdrart = cmdart.ExecuteReader();


                    if (mdrart.Read())
                    {

                        existenciaPrevia = mdrart.GetInt32("EXISTENCIA");
                        importeArticulo = existenciaCompra * costoArtiCompra;
                        existenciaTotal = existenciaPrevia + existenciaCompra;
                        if (impuesto == "IVA" || impuesto == "iva")
                        {
                            importeCompra = importeCompra + importeArticulo;
                        }
                        else
                        {
                            importecompraSinIVA = importecompraSinIVA + importeArticulo;
                        }


                        comando = "UPDATE prods SET EXISTENCIA='" + existenciaTotal + "', ALM1='" + existenciaTotal + "',DESCRIP='" + descripArtiCompra + "',FABRICANTE='" + fabricanteCompra + "',COSTO_U='" + costoArtiCompra + "',PRECIO1='" + menudeoArtiCompra + "', PRECIO2='" + mayoreoArtiCompra + "', IMPUESTO='" + impuesto + "' WHERE ARTICULO='" + articuloCompra + "'";
                    }
                    else
                    {
                        existenciaPrevia = 0;
                        importeArticulo = existenciaCompra * costoArtiCompra;
                        existenciaTotal = existenciaPrevia + existenciaCompra;
                        if (impuesto == "IVA" || impuesto == "iva")
                        {
                            importeCompra = importeCompra + importeArticulo;
                        }
                        else
                        {
                            importecompraSinIVA = importecompraSinIVA + importeArticulo;
                        }

                        comando = "INSERT INTO prods (ARTICULO,LINEA,MARCA,FABRICANTE,UNIDAD,IMPUESTO,INVENT,PARAVENTA,EXISTENCIA,ALM1,DESCRIP,COSTO_U,PRECIO1,PRECIO2)" +
                                " VALUES('" + articuloCompra + "','" + lineaCompra + "','" + marcaCompra + "','" + fabricanteCompra + "','PZA','" + impuesto + "','1','1','" + existenciaTotal + "','" + existenciaTotal + "','" + descripArtiCompra + "','" + costoArtiCompra + "','" + menudeoArtiCompra + "','" + mayoreoArtiCompra + "')";
                    }

                    mdrart.Close();

                    //################### EJECUTA INSERCCION O ACTUALIZACION EN PRODS #####################
                    MySqlCommand cmdprod = new MySqlCommand(comando, conectar);
                    cmdprod.ExecuteNonQuery();


                    //################## GUARDA EN PARTCOMP ##############################
                    comando = "INSERT INTO partcomp (COMPRA,TIPO_DOC,NO_REFEREN,ARTICULO,CANTIDAD,PRECIO,DESCUENTO,IMPUESTO,OBSERV,PARTIDA,ID_ENTRADA,Usuario,UsuFecha,UsuHora,PRCANTIDAD,PRDESCRIP) " +
                        "VALUES('" + consecCompra + "','COM','" + consecCompra + "','" + articuloCompra + "','" + existenciaCompra + "','" + costoArtiCompra + "','" + TB_descuento.Text + "','16','" + descripArtiCompra + "','0','" + consecPartCompra + "','" + Usuario + "','" + Fecha.ToString("yyyy-MM-dd") + "','" + Hora + "','0','0')";

                    MySqlCommand cmdpart = new MySqlCommand(comando, conectar);
                    cmdpart.ExecuteNonQuery();



                    //################# GUARDAR EN MOVSINV #################################

                    comando = "INSERT INTO movsinv (CONSEC,OPERACION,MOVIMIENTO , ENT_SAL, TIPO_MOVIM, NO_REFEREN, ARTICULO, F_MOVIM,CANTIDAD,COSTO, EXISTENCIA, ALMACEN,EXIST_ALM,PRECIO_VTA, POR_COSTEA,Usuario,UsuFecha,UsuHora,ID_SALIDA,ID_ENTRADA) " +
                        "VALUES('" + consecMovsinv + "','CO','" + consecCompra + "','E','COM','" + consecCompra + "','" + articuloCompra + "','" + Fecha.ToString("yyyy-MM-dd") + "','" + existenciaCompra + "','" + costoArtiCompra + "','" + existenciaTotal + "','1','" + existenciaTotal + "','" + costoArtiCompra + "','" + existenciaTotal + "','" + Usuario + "','" + Fecha.ToString("yyyy-MM-dd") + "','" + Hora + "','0','" + idPartcomp + "') ";

                    MySqlCommand cmdmov = new MySqlCommand(comando, conectar);
                    cmdmov.ExecuteNonQuery();




                    consecMovsinv++;

                    consecPartCompra++;

                }


                impuestoCompra = importeCompra * 0.16;

                TotalCompra = importeCompra + impuestoCompra + importecompraSinIVA;
                idFabricante = TB_idproveedor.Text;
                //########################### GENERAR COMPRA###############################

                comando = "INSERT INTO compras(COMPRA,TIPO_DOC,FACTURA,F_EMISION,F_VENC,PROVEEDOR,IMPORTE,DESCUENTO,IMPUESTO,COSTO,ALMACEN,ESTADO,OBSERV,TIPO_CAM,MONEDA,DESC1,DESC2,DESC3,DESC4,DESC5,DATOS,DESGLOSE,CUENXPAG,USUARIO,USUFECHA,USUHORA,vencimiento,NumOrden) " +
                    "VALUES('" + consecCompra + "','COM','" + TB_factura.Text.ToUpper() + "','" + FechaLlegada.ToString("yyyy-MM-dd") + "','" + Fecha.ToString("yyyy-MM-dd") + "','" + idFabricante + "','" + (importeCompra + importecompraSinIVA) + "','" + TB_descuento.Text + "','" + impuestoCompra + "','0','1','CO','" + TB_observaciones.Text.ToUpper() + "','1','MN','MN','MN','MN','MN','MN','" + CB_proveedor.Text + "','1','" + idCuentasxPag + "','"+Usuario+"','" + Fecha.ToString("yyyy-MM-dd") + "','" + Hora + "','" + Fecha.ToString("yyyy-MM-dd") + "','" + TB_orden_compra.Text + "')";

                MySqlCommand cmdcom = new MySqlCommand(comando, conectar);
                cmdcom.ExecuteNonQuery();

                //######################### GUARDAR DATOS EN CUENXPAG ##############################
                comando = "INSERT INTO cuenxpag(CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, FECHA_VENC, FACTURA, IMPORTE, MONEDA, SALDO, TIP_CAM, COMPRA, ESTADO, USUARIO, USUFECHA, USUHORA) " +
                    "VALUES('" + consecCuentasXPagar + "','" + idFabricante + "','" + Fecha.ToString("yyyy-MM-dd") + "','COM','" + consecCompra + "','" + Fecha.ToString("yyyy-MM-dd") + "','" + TB_factura.Text.ToUpper() + "','" + TotalCompra + "','MN','" + TotalCompra + "','1','" + consecCompra + "','P','" + Usuario + "','" + FechaLlegada.ToString("yyyy-MM-dd") + "','" + Hora + "')";


                MySqlCommand cmdcuen = new MySqlCommand(comando, conectar);
                cmdcuen.ExecuteNonQuery();

                comando = "INSERT INTO cuenxpdet(CUENXPAG, PROVEEDOR, FECHA, TIPO_DOC, NO_REFEREN, Cargo_ab, IMPORTE,MONEDA, TIP_CAM,COMPRA, USUARIO, USUFECHA,USUHORA)" +
                    " VALUES('" + consecCuentasXPagar + "','" + idFabricante + "','" + Fecha.ToString("yyyy-MM-dd") + "','COM','" + TB_factura.Text.ToUpper() + "','C','" + TotalCompra + "','MN','1','" + consecCompra + "','" + Usuario + "','" + FechaLlegada.ToString("yyyy-MM-dd") + "','" + Hora + "')";

                MySqlCommand cmdpdet = new MySqlCommand(comando, conectar);
                cmdpdet.ExecuteNonQuery();



               
                MessageBox.Show("Compra Registrada" + Environment.NewLine + "No. Compra: " + idCompra + Environment.NewLine + "Importe: " + TotalCompra);

                conectar.Close();

            }
            else
            {
                MessageBox.Show("Debes seleccionar una compra para aplicarla");
            }
        }

        public void CargarCompra()
        {

        }
    }
}
