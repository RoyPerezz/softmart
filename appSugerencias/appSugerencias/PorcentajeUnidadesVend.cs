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
using System.Threading;

namespace appSugerencias
{
    public partial class PorcentajeUnidadesVend : Form
    {
        public PorcentajeUnidadesVend()
        {
            InitializeComponent();
        }

        DataTable va = new DataTable();
        DataTable re = new DataTable();
        DataTable ve = new DataTable();
        DataTable co = new DataTable();
        DataTable pre = new DataTable();
        DataTable maestro = new DataTable();

        DataTable articulosVA = new DataTable();
        DataTable articulosRE = new DataTable();
        DataTable articulosVE = new DataTable();
        DataTable articulosCO = new DataTable();
        DataTable articulosPRE = new DataTable();
        DataTable articulosAUX = new DataTable();
        DataTable articulos = new DataTable();




        ArrayList listaVA = new ArrayList();
        ArrayList listaRE = new ArrayList();
        ArrayList listaVE = new ArrayList();
        ArrayList listaCO = new ArrayList();
        ArrayList listaPRE = new ArrayList();

        string linea = "";
        DateTime inicio = DateTime.Now;
        DateTime fin =DateTime.Now;

        string estadoVA = "";
        string estadoRE = "";
        string estadoCO = "";
        string estadoVE = "";
        string estadoPRE = "";

        private void PorcentajeUnidadesVend_Load(object sender, EventArgs e)
        {
            Lineas();//SE EJECUTA EL METODO LINEAS QUE CARGA LAS LINEAS EN EL COMBOBOX (LAS LINEAS LAS TOMA DE LA TIENDA VALLARTA)

            //#################################### SE LE ASIGNA UN ANCHO A LAS COLUMNAS DEL DATAGRID ####################################
            DG_tabla.Columns["DESCRIPCION"].Width = 200;
            DG_tabla.Columns["PRECIO_MAY"].Width = 80;
            DG_tabla.Columns["PRECIO_MEN"].Width = 80;

            DG_tabla.Columns["EXVA"].Width = 60;
            DG_tabla.Columns["F_ENTRADA_VA"].Width = 50;
            //DG_tabla.Columns["PORCENTAJEVA"].Width = 60;

            DG_tabla.Columns["EXRE"].Width = 60;
            DG_tabla.Columns["F_ENTRADA_RE"].Width = 50;
            //DG_tabla.Columns["PORCENTAJERE"].Width = 60;

            DG_tabla.Columns["EXVE"].Width = 60;
            DG_tabla.Columns["F_ENTRADA_VE"].Width = 50;
            //DG_tabla.Columns["PORCENTAJEVE"].Width = 60;

            DG_tabla.Columns["EXCO"].Width = 60;
            DG_tabla.Columns["F_ENTRADA_CO"].Width = 50;
            //DG_tabla.Columns["PORCENTAJECO"].Width = 60;

            DG_tabla.Columns["EXPRE"].Width = 60;
            DG_tabla.Columns["F_ENTRADA_PRE"].Width = 50;
            //DG_tabla.Columns["PORCENTAJEPRE"].Width = 60;
            //################################################################################################################################

            // #################### AGREGAR COLUMNAS A LOS DATATABLES  ###########################################################################
            va.Columns.Add("ARTICULO",typeof(string));
            va.Columns.Add("DESCRIPCION", typeof(string));
            va.Columns.Add("PRECIO MAYOREO", typeof(double));
            va.Columns.Add("PRECIO MENUDEO", typeof(double));
            va.Columns.Add("EXISTENCIA", typeof(int));
            va.Columns.Add("F_ENTRADA_VA", typeof(string));
            //va.Columns.Add("PORCENTAJE", typeof(double));

            re.Columns.Add("ARTICULO", typeof(string));
            re.Columns.Add("DESCRIPCION", typeof(string));
            re.Columns.Add("PRECIO MAYOREO", typeof(double));
            re.Columns.Add("PRECIO MENUDEO", typeof(double));
            re.Columns.Add("EXISTENCIA", typeof(int));
            re.Columns.Add("F_ENTRADA_RE", typeof(string));
            //re.Columns.Add("PORCENTAJE", typeof(double));

            ve.Columns.Add("ARTICULO", typeof(string));
            ve.Columns.Add("DESCRIPCION", typeof(string));
            ve.Columns.Add("PRECIO MAYOREO", typeof(double));
            ve.Columns.Add("PRECIO MENUDEO", typeof(double));
            ve.Columns.Add("EXISTENCIA", typeof(int));
            ve.Columns.Add("F_ENTRADA_VE", typeof(string));
            //ve.Columns.Add("PORCENTAJE", typeof(double));

            co.Columns.Add("ARTICULO", typeof(string));
            co.Columns.Add("DESCRIPCION", typeof(string));
            co.Columns.Add("PRECIO MAYOREO", typeof(double));
            co.Columns.Add("PRECIO MENUDEO", typeof(double));
            co.Columns.Add("EXISTENCIA", typeof(int));
            co.Columns.Add("F_ENTRADA_CO", typeof(string));
            //co.Columns.Add("PORCENTAJE", typeof(double));

            pre.Columns.Add("ARTICULO", typeof(string));
            pre.Columns.Add("DESCRIPCION", typeof(string));
            pre.Columns.Add("PRECIO MAYOREO", typeof(double));
            pre.Columns.Add("PRECIO MENUDEO", typeof(double));
            pre.Columns.Add("EXISTENCIA", typeof(int));
            pre.Columns.Add("F_ENTRADA_PRE", typeof(string));
            //pre.Columns.Add("PORCENTAJE", typeof(double));


            articulosVA.Columns.Add("ARTICULO", typeof(string));
            articulosVA.Columns.Add("DESCRIPCION", typeof(string));
            articulosVA.Columns.Add("PRECIO MAYOREO", typeof(double));
            articulosVA.Columns.Add("PRECIO MENUDEO", typeof(double));

            articulosRE.Columns.Add("ARTICULO", typeof(string));
            articulosRE.Columns.Add("DESCRIPCION", typeof(string));
            articulosRE.Columns.Add("PRECIO MAYOREO", typeof(double));
            articulosRE.Columns.Add("PRECIO MENUDEO", typeof(double));


            articulosVE.Columns.Add("ARTICULO", typeof(string));
            articulosVE.Columns.Add("DESCRIPCION", typeof(string));
            articulosVE.Columns.Add("PRECIO MAYOREO", typeof(double));
            articulosVE.Columns.Add("PRECIO MENUDEO", typeof(double));

            articulosCO.Columns.Add("ARTICULO", typeof(string));
            articulosCO.Columns.Add("DESCRIPCION", typeof(string));
            articulosCO.Columns.Add("PRECIO MAYOREO", typeof(double));
            articulosCO.Columns.Add("PRECIO MENUDEO", typeof(double));


            articulosPRE.Columns.Add("ARTICULO", typeof(string));
            articulosPRE.Columns.Add("DESCRIPCION", typeof(string));
            articulosPRE.Columns.Add("PRECIO MAYOREO", typeof(double));
            articulosPRE.Columns.Add("PRECIO MENUDEO", typeof(double));

            articulosAUX.Columns.Add("ARTICULO", typeof(string));
            articulosAUX.Columns.Add("DESCRIPCION", typeof(string));
            articulosAUX.Columns.Add("PRECIO MAYOREO", typeof(double));
            articulosAUX.Columns.Add("PRECIO MENUDEO", typeof(double));

            maestro.Columns.Add("ARTICULO", typeof(string));
            maestro.Columns.Add("DESCRIPCION", typeof(string));
            maestro.Columns.Add("PRECIO MAYOREO", typeof(double));
            maestro.Columns.Add("PRECIO MENUDEO", typeof(double));

            maestro.Columns.Add("EXVA", typeof(int));
            maestro.Columns.Add("F_MOVIM_VA", typeof(string));
            //maestro.Columns.Add("PORCENTAJEVA", typeof(double));

            maestro.Columns.Add("EXRE", typeof(int));
            maestro.Columns.Add("F_MOVIM_RE", typeof(string));
            //maestro.Columns.Add("PORCENTAJERE", typeof(double));

            maestro.Columns.Add("EXVE", typeof(int));
            maestro.Columns.Add("F_MOVIM_VE", typeof(string));
            //maestro.Columns.Add("PORCENTAJEVE", typeof(double));

            maestro.Columns.Add("EXCO", typeof(int));
            maestro.Columns.Add("F_MOVIM_CO", typeof(string));
            //maestro.Columns.Add("PORCENTAJECO", typeof(double));

            //maestro.Columns.Add("EXPRE", typeof(int));
            //maestro.Columns.Add("UNIDADES VENDIDAS PRE", typeof(int));
            //maestro.Columns.Add("PORCENTAJEPRE", typeof(double));

            //##########################  ESTILOS DEL DATAGRID ###############################################################################################

            DG_tabla.Columns["EXVA"].HeaderCell.Style.BackColor = Color.Black;

            //################################################################################################################################################




            //################################################################################################################################################
        }

        public void Lineas()//CARGA LAS LINEAS EN EL COMBOBOX
        {
            try
            {
                MySqlConnection conexion = BDConexicon.ConexionSucursal("VALLARTA");
                string query = "SELECT Linea FROM LINEAS";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CB_linea.Items.Add(dr["Linea"].ToString());
                }
                dr.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("[Excepcion controlada] Ocurrió un error al cargar las lineas desde el origen "+ex);
            }
        }

        //BUSCA LOS ARTICULOS DE LA LINEA SELECCIONADA EN LA SUC. VALLARTA
        public void BuscarVA()
        {
            va.Rows.Clear();
            listaVA.Clear();
            articulosVA.Rows.Clear();
            linea = CB_linea.SelectedItem.ToString();
            inicio = DT_inicio.Value;
            fin = DT_fin.Value;
            try
            {

                //###################################  LLENA LA LISTA CON LOS ARTICULOS DE LA TIENDA VALLARTA DENTRO DE LA LINEA SELECCIONADA ############################################
                string query = "SELECT ARTICULO FROM PRODS WHERE LINEA='" + linea + "'";
                MySqlConnection conexion = BDConexicon.VallartaOpen();
                MySqlCommand comand = new MySqlCommand(query, conexion);
                MySqlDataReader dread = comand.ExecuteReader();

                while (dread.Read())
                {
                    listaVA.Add(dread["ARTICULO"].ToString());
                }
                dread.Close();
                //#########################################################################################################################################################################
                conexion.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("[ARTICULOS VALLARTA] " + ex);
                estadoVA = "SIN CONEXION";
            }

        }

        //CALCULA LA EXISTENCIA EN EL RANGO DE FECHA SELECCIONADO, LAS UNIDADES VENDIDAS Y EL PORCENTAJE QUE ESO REPRESENTA POR CADA ARTICULO EN LA LINEA EN VALLARTA
        public void SubBuscarVA()
        {
            long entradas = 0;
            long salidas = 0;
#pragma warning disable CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
            string ent_sal = "";
#pragma warning restore CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
            string tipo_mov = "";
#pragma warning restore CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            int cantidad = 0;
#pragma warning restore CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            long existencia = 0;
#pragma warning disable CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
            int existenciaReal = 0;
#pragma warning restore CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'porcentaje' está asignada pero su valor nunca se usa
            double porcentaje = 0;
#pragma warning restore CS0219 // La variable 'porcentaje' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cancelarEntrada' está asignada pero su valor nunca se usa
            int cancelarEntrada = 0;
#pragma warning restore CS0219 // La variable 'cancelarEntrada' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cancelarSalida' está asignada pero su valor nunca se usa
            int cancelarSalida = 0;
#pragma warning restore CS0219 // La variable 'cancelarSalida' está asignada pero su valor nunca se usa




            MySqlDataReader dr = null;
            MySqlDataReader dr0 = null;
          
            double precio2 = 0;
            double precio1 = 0;
            double mayoreo = 0;
            double menudeo = 0;
            //DateTime f_movim = DateTime.Now;
            string f_movim = "";
            string producto = "";

            try
            {
                MySqlConnection conexion = BDConexicon.VallartaOpen();
                for (int i = 0; i < listaVA.Count; i++)
                {


                    //MySqlCommand exist = new MySqlCommand("SELECT ENT_SAL,TIPO_MOVIM,CANTIDAD,EXISTENCIA FROM MOVSINV WHERE ARTICULO='" + listaVA[i] + "' and F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "' LIMIT 1", conexion);
                    MySqlCommand exist = new MySqlCommand("SELECT MAX(F_MOVIM) AS F_MOV FROM MOVSINV WHERE ARTICULO='" + listaVA[i] + "' AND (TIPO_MOVIM='COM' ||TIPO_MOVIM='T+' ||TIPO_MOVIM='A+' )", conexion);
                    dr0 = exist.ExecuteReader();
                    producto = listaVA[i].ToString();
                    while (dr0.Read())
                    {
                        //existencia = Convert.ToInt32(dr0["EXISTENCIA"].ToString());
                        //if (dr0["ENT_SAL"].ToString().Equals("E"))
                        //{
                        //    cancelarEntrada = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        //}
                        //if (dr0["ENT_SAL"].ToString().Equals("S") && dr0["TIPO_MOVIM"].ToString().Equals("TK"))
                        //{
                        //    cancelarSalida = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        //}
                        //f_movim = Convert.ToDateTime(dr0["F_MOV"].ToString());
                        f_movim = dr0["F_MOV"].ToString();
                    }
                    dr0.Close();


                    // MySqlCommand cmd = new MySqlCommand("SELECT mov.ARTICULO,p.DESCRIP,p.PRECIO1,p.PRECIO2,mov.ENT_SAL, mov.TIPO_MOVIM,mov.CANTIDAD,mov.EXISTENCIA " +
                    //"FROM MOVSINV mov INNER JOIN PRODS p ON mov.ARTICULO=p.ARTICULO" +
                    //" WHERE p.ARTICULO='" + listaVA[i] + "' AND mov.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'", conexion);
                    // dr = cmd.ExecuteReader();
                    MySqlCommand cmd = new MySqlCommand("SELECT mov.ARTICULO,p.DESCRIP,p.PRECIO1,p.PRECIO2,mov.ENT_SAL, mov.TIPO_MOVIM,mov.CANTIDAD,mov.EXISTENCIA " +
                 "FROM MOVSINV mov INNER JOIN PRODS p ON mov.ARTICULO=p.ARTICULO" +
                 " WHERE p.ARTICULO='" + listaVA[i] + "' ORDER BY DESCRIP", conexion);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        //if (dr["ENT_SAL"].ToString().Equals("E") && dr["TIPO_MOVIM"].ToString() != "IF+")
                        //{
                        //    entradas += Convert.ToInt32(dr["CANTIDAD"].ToString());
                        //    //existencia += Convert.ToInt32(dr["EXISTENCIA"].ToString());
                        //    //existencia += entradas;
                        //}

                        //if (dr["ENT_SAL"].ToString().Equals("S") && dr["TIPO_MOVIM"].ToString() !="IF-")
                        //{
                        //    salidas += Convert.ToInt32(dr["CANTIDAD"].ToString());
                        //}
                        if (dr["ENT_SAL"].ToString().Equals("E"))
                        {
                            entradas += Convert.ToInt64(dr["CANTIDAD"].ToString());
                            //existencia += Convert.ToInt32(dr["EXISTENCIA"].ToString());
                            //existencia += entradas;
                        }

                        if (dr["ENT_SAL"].ToString().Equals("S"))
                        {
                            salidas += Convert.ToInt64(dr["CANTIDAD"].ToString());
                        }


                    }
                    existencia = entradas - salidas;
                    try
                    {
                        //existenciaReal = existencia - salidas;
                        //existencia = existencia - cancelarEntrada;
                        //salidas = salidas - cancelarSalida;
                        //porcentaje = (salidas * 100) / existencia;
                    }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    {
                        

                    }

                    if (dr.HasRows)
                    {
                        

                            precio2 = Convert.ToDouble(dr["PRECIO2"].ToString());
                            precio1 = Convert.ToDouble(dr["PRECIO1"].ToString());

                            mayoreo = precio2 + (precio2 * 0.16);
                            menudeo = precio1 + (precio1 * 0.16);

                            DataRow row = va.NewRow();
                            DataRow row2 = articulosVA.NewRow();

                            row["ARTICULO"] = dr["ARTICULO"].ToString();
                            row["DESCRIPCION"] = dr["DESCRIP"].ToString();
                            row["PRECIO MAYOREO"] = mayoreo;
                            row["PRECIO MENUDEO"] = menudeo;
                            row["EXISTENCIA"] = existencia;
                            row["F_ENTRADA_VA"] = f_movim;
                            //row["PORCENTAJE"] = porcentaje.ToString("N2");
                            va.Rows.Add(row);

                            estadoVA = "CONECTADO";
                            row2["ARTICULO"] = dr["ARTICULO"].ToString();
                            row2["DESCRIPCION"] = dr["DESCRIP"].ToString();
                            row2["PRECIO MAYOREO"] = mayoreo;
                            row2["PRECIO MENUDEO"] = menudeo;
                            articulosVA.Rows.Add(row2);

                        
                    }
                    //else
                    //{

                    //}

                    estadoVA = "CONECTADO";
                    dr.Close();

                    existenciaReal = 0; existencia = 0; salidas = 0; porcentaje = 0; entradas = 0; cancelarEntrada = 0; cancelarSalida = 0;



                }



                conexion.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("[ERROR VALLARTA] "+producto+" "+ ex);
                estadoVA = "SIN CONEXION";
            }
        }

        //BUSCA LOS ARTICULOS DE LA LINEA SELECCIONADA EN LA SUC. RENA
        public void BuscarRE()
        {

            re.Rows.Clear();
            listaRE.Clear();
            articulosRE.Rows.Clear();
            linea = CB_linea.SelectedItem.ToString();
            inicio = DT_inicio.Value;
            fin = DT_fin.Value;
            try
            {
                //###################################  LLENA LA LISTA CON LOS ARTICULOS DE LA TIENDA VALLARTA DENTRO DE LA LINEA SELECCIONADA ############################################
                string query = "SELECT ARTICULO FROM PRODS WHERE LINEA='" + linea + "'";
                MySqlConnection conexion = BDConexicon.RenaOpen();
                MySqlCommand comand = new MySqlCommand(query, conexion);
                MySqlDataReader dread = comand.ExecuteReader();

                while (dread.Read())
                {
                    listaRE.Add(dread["ARTICULO"].ToString());
                }
                dread.Close();
                //#########################################################################################################################################################################
                conexion.Close();

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                //MessageBox.Show("[ARTICULOS RENA] " + ex);
                estadoRE = "SIN CONEXION";
            }
            
        }

        //CALCULA LA EXISTENCIA EN EL RANGO DE FECHA SELECCIONADO, LAS UNIDADES VENDIDAS Y EL PORCENTAJE QUE ESO REPRESENTA POR CADA ARTICULO EN LA LINEA EN RENA
        public void SubBuscarRE()
        {
            long entradas = 0;
            long salidas = 0;
#pragma warning disable CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
            string ent_sal = "";
#pragma warning restore CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
            string tipo_mov = "";
#pragma warning restore CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            int cantidad = 0;
#pragma warning restore CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            long existencia = 0;
#pragma warning disable CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
            int existenciaReal = 0;
#pragma warning restore CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'porcentaje' está asignada pero su valor nunca se usa
            double porcentaje = 0;
#pragma warning restore CS0219 // La variable 'porcentaje' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cancelarEntrada' está asignada pero su valor nunca se usa
            int cancelarEntrada = 0;
#pragma warning restore CS0219 // La variable 'cancelarEntrada' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cancelarSalida' está asignada pero su valor nunca se usa
            int cancelarSalida = 0;
#pragma warning restore CS0219 // La variable 'cancelarSalida' está asignada pero su valor nunca se usa
            //DateTime f_movim = DateTime.Now;
            string f_movim = "";
            string producto = "";


            MySqlDataReader dr = null;
            MySqlDataReader dr0 = null;
           

            try
            {
                MySqlConnection conexion = BDConexicon.RenaOpen();
                for (int i = 0; i < listaRE.Count; i++)
                {


                    //MySqlCommand exist = new MySqlCommand("SELECT ENT_SAL,TIPO_MOVIM,CANTIDAD,EXISTENCIA FROM MOVSINV WHERE ARTICULO='" + listaRE[i] + "' and F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "' LIMIT 1", conexion);
                    MySqlCommand exist = new MySqlCommand("SELECT MAX(F_MOVIM) AS F_MOV FROM MOVSINV WHERE ARTICULO='" + listaRE[i] + "'  AND (TIPO_MOVIM='COM' ||TIPO_MOVIM='T+' ||TIPO_MOVIM='A+' )", conexion);
                    dr0 = exist.ExecuteReader();
                    producto=listaRE[i].ToString();
                    while (dr0.Read())
                    {
                        //existencia = Convert.ToInt32(dr0["EXISTENCIA"].ToString());
                        //if (dr0["ENT_SAL"].ToString().Equals("E"))
                        //{
                        //    entradas = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        //}
                        //if (dr0["ENT_SAL"].ToString().Equals("S"))
                        //{
                        //   salidas = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        //}
                        f_movim = dr0["F_MOV"].ToString();
                    }
                    dr0.Close();


                    MySqlCommand cmd = new MySqlCommand("SELECT mov.ARTICULO,p.DESCRIP,p.PRECIO1,p.PRECIO2,mov.ENT_SAL, mov.TIPO_MOVIM,mov.CANTIDAD,mov.EXISTENCIA " +
                   "FROM MOVSINV mov INNER JOIN PRODS p ON mov.ARTICULO=p.ARTICULO" +
                   " WHERE p.ARTICULO='" + listaRE[i] + "' ORDER BY DESCRIP", conexion);
                    dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {

                        if (dr["ENT_SAL"].ToString().Equals("E"))
                        {
                            
                            entradas += Convert.ToInt64(dr["CANTIDAD"].ToString());
                            //existencia += Convert.ToInt32(dr["EXISTENCIA"].ToString());
                            //existencia += entradas;
                        }

                        if (dr["ENT_SAL"].ToString().Equals("S"))
                        {
                            salidas += Convert.ToInt64(dr["CANTIDAD"].ToString());
                        }

                    }
                    existencia = entradas - salidas;
                    try
                    {
                        //existenciaReal = existencia - salidas;
                        //existencia = existencia - cancelarEntrada;
                        //salidas = salidas - cancelarSalida;
                        //porcentaje = (salidas * 100) / existencia;
                    }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    {


                    }

                    if (dr.HasRows)
                    {
                        
                            double precio2 = Convert.ToDouble(dr["PRECIO2"].ToString());
                            double precio1 = Convert.ToDouble(dr["PRECIO1"].ToString());

                            double mayoreo = precio2 + (precio2 * 0.16);
                            double menudeo = precio1 + (precio1 * 0.16);

                            DataRow row = re.NewRow();
                            DataRow row2 = articulosRE.NewRow();

                            row["ARTICULO"] = dr["ARTICULO"].ToString();
                            row["DESCRIPCION"] = dr["DESCRIP"].ToString();
                            row["PRECIO MAYOREO"] = mayoreo;
                            row["PRECIO MENUDEO"] = menudeo;
                            row["EXISTENCIA"] = existencia;
                            row["F_ENTRADA_RE"] = f_movim;
                            //row["PORCENTAJE"] = porcentaje.ToString("N2");
                            re.Rows.Add(row);


                        row2["ARTICULO"] = dr["ARTICULO"].ToString();
                        row2["DESCRIPCION"] = dr["DESCRIP"].ToString();
                        row2["PRECIO MAYOREO"] = mayoreo;
                        row2["PRECIO MENUDEO"] = menudeo;
                        articulosRE.Rows.Add(row2);


                    }
                    else
                    {

                    }


                    dr.Close();

                    existenciaReal = 0; existencia = 0; salidas = 0; porcentaje = 0; entradas = 0; cancelarEntrada = 0; cancelarSalida = 0;



                }

                estadoRE = "CONECTADO";
                conexion.Close();

            }
            catch (Exception ex)
            {

                //MessageBox.Show("[PORCENTAJE RENA] " + ex);
                estadoRE = "SIN CONEXION";
                MessageBox.Show("Error RE " +producto+" "+ ex);
            }
          
        }

        //BUSCA LOS ARTICULOS DE LA LINEA SELECCIONADA EN LA SUC. VELAZQUEZ
        public void BuscarVE()
        {

            ve.Rows.Clear();
            listaVE.Clear();
            articulosVE.Rows.Clear();
            linea = CB_linea.SelectedItem.ToString();

            inicio = DT_inicio.Value;
            fin = DT_fin.Value;
            try
            {
                //###################################  LLENA LA LISTA CON LOS ARTICULOS DE LA TIENDA VALLARTA DENTRO DE LA LINEA SELECCIONADA ############################################
                string query = "SELECT ARTICULO FROM PRODS WHERE LINEA='" + linea + "'";
                MySqlConnection conexion = BDConexicon.VelazquezOpen();
                MySqlCommand comand = new MySqlCommand(query, conexion);
                MySqlDataReader dread = comand.ExecuteReader();

                while (dread.Read())
                {
                    listaVE.Add(dread["ARTICULO"].ToString());
                }
                dread.Close();
                //#########################################################################################################################################################################
                conexion.Close();

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {
                //MessageBox.Show("[ARTICULOS VELAZQUEZ] " + ex);
                estadoVE = "SIN CONEXION";
            }
        }

        //CALCULA LA EXISTENCIA EN EL RANGO DE FECHA SELECCIONADO, LAS UNIDADES VENDIDAS Y EL PORCENTAJE QUE ESO REPRESENTA POR CADA ARTICULO EN LA LINEA EN VELAZQUEZ
        public void SubBuscarVE()
        {
            long entradas = 0;
            long salidas = 0;
#pragma warning disable CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
            string ent_sal = "";
#pragma warning restore CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
            string tipo_mov = "";
#pragma warning restore CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            int cantidad = 0;
#pragma warning restore CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            long existencia = 0;
#pragma warning disable CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
            int existenciaReal = 0;
#pragma warning restore CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'porcentaje' está asignada pero su valor nunca se usa
            double porcentaje = 0;
#pragma warning restore CS0219 // La variable 'porcentaje' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cancelarEntrada' está asignada pero su valor nunca se usa
            int cancelarEntrada = 0;
#pragma warning restore CS0219 // La variable 'cancelarEntrada' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cancelarSalida' está asignada pero su valor nunca se usa
            int cancelarSalida = 0;
#pragma warning restore CS0219 // La variable 'cancelarSalida' está asignada pero su valor nunca se usa


            double precio2 = 0;
            double precio1 = 0;
            double mayoreo = 0;
            double menudeo = 0;
            //DateTime f_movim = DateTime.Now;
            string f_movim = "";
            string producto = "";
            MySqlDataReader dr = null;
            MySqlDataReader dr0 = null;
            try
            {
                MySqlConnection conexion = BDConexicon.VelazquezOpen();
               
                for (int i = 0; i < listaVE.Count; i++)
                {


                    MySqlCommand exist = new MySqlCommand("SELECT MAX(F_MOVIM) AS F_MOV FROM MOVSINV WHERE ARTICULO='" + listaVE[i] + "'  AND (TIPO_MOVIM='COM' ||TIPO_MOVIM='T+' ||TIPO_MOVIM='A+' )", conexion);
                    dr0 = exist.ExecuteReader();
                    producto = listaVE[i].ToString();
                    while (dr0.Read())
                    {
                        //existencia = Convert.ToInt32(dr0["EXISTENCIA"].ToString());
                        //if (dr0["ENT_SAL"].ToString().Equals("E"))
                        //{
                        //    cancelarEntrada = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        //}
                        //if (dr0["ENT_SAL"].ToString().Equals("S") && dr0["TIPO_MOVIM"].ToString().Equals("TK"))
                        //{
                        //    cancelarSalida = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        //}
                        f_movim = dr0["F_MOV"].ToString();
                    }
                    dr0.Close();


                    MySqlCommand cmd = new MySqlCommand("SELECT mov.ARTICULO,p.DESCRIP,p.PRECIO1,p.PRECIO2,mov.ENT_SAL, mov.TIPO_MOVIM,mov.CANTIDAD,mov.EXISTENCIA " +
                   "FROM MOVSINV mov INNER JOIN PRODS p ON mov.ARTICULO=p.ARTICULO" +
                   " WHERE p.ARTICULO='" + listaVE[i] + "' ORDER BY DESCRIP", conexion);
                    dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {

                        if (dr["ENT_SAL"].ToString().Equals("E"))
                        {
                            entradas += Convert.ToInt64(dr["CANTIDAD"].ToString());
                            //existencia += Convert.ToInt32(dr["EXISTENCIA"].ToString());
                            //existencia += entradas;
                        }

                        if (dr["ENT_SAL"].ToString().Equals("S"))
                        {
                            salidas += Convert.ToInt64(dr["CANTIDAD"].ToString());
                        }

                    }
                    existencia = entradas-salidas;
                    try
                    {
                        //existenciaReal = existencia - salidas;
                    //    existencia = existencia - cancelarEntrada;
                    //    salidas = salidas - cancelarSalida;
                    //    porcentaje = (salidas * 100) / existencia;
                    }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    {


                    }

                    if (dr.HasRows)
                    {
                        
                            precio2 = Convert.ToDouble(dr["PRECIO2"].ToString());
                            precio1 = Convert.ToDouble(dr["PRECIO1"].ToString());

                            mayoreo = precio2 + (precio2 * 0.16);
                            menudeo = precio1 + (precio1 * 0.16);

                            DataRow row = ve.NewRow();
                            DataRow row2 = articulosVE.NewRow();

                            row["ARTICULO"] = dr["ARTICULO"].ToString();
                            row["DESCRIPCION"] = dr["DESCRIP"].ToString();
                            row["PRECIO MAYOREO"] = mayoreo;
                            row["PRECIO MENUDEO"] = menudeo;
                            row["EXISTENCIA"] = existencia;
                            row["F_ENTRADA_VE"] = f_movim;
                            //row["PORCENTAJE"] = porcentaje.ToString("N2");
                            ve.Rows.Add(row);


                        row2["ARTICULO"] = dr["ARTICULO"].ToString();
                        row2["DESCRIPCION"] = dr["DESCRIP"].ToString();
                        row2["PRECIO MAYOREO"] = mayoreo;
                        row2["PRECIO MENUDEO"] = menudeo;
                        articulosVE.Rows.Add(row2);


                    }
                    else
                    {

                    }


                    dr.Close();

                    existenciaReal = 0; existencia = 0; salidas = 0; porcentaje = 0; entradas = 0; cancelarEntrada = 0; cancelarSalida = 0;



                }
                estadoVE = "CONECTADO";

                conexion.Close();
            }
            catch (Exception ex)
            {

                //MessageBox.Show("[PORCENTAJE VELAZQUEZ] " + ex);
                MessageBox.Show("Error VE " + producto + " "+ ex);

                estadoVE = "SIN CONEXION";
            }
        }

        //BUSCA LOS ARTICULOS DE LA LINEA SELECCIONADA EN LA SUC. COLOSO
        public void BuscarCO()
        {

            co.Rows.Clear();
            listaCO.Clear();
            articulosCO.Rows.Clear();
            linea = CB_linea.SelectedItem.ToString();
             inicio = DT_inicio.Value;
             fin = DT_fin.Value;
            try
            {
                //###################################  LLENA LA LISTA CON LOS ARTICULOS DE LA TIENDA VALLARTA DENTRO DE LA LINEA SELECCIONADA ############################################
                string query = "SELECT ARTICULO FROM PRODS WHERE LINEA='" + linea + "'";
                MySqlConnection conexion = BDConexicon.ColosoOpen();
                MySqlCommand comand = new MySqlCommand(query, conexion);
                MySqlDataReader dread = comand.ExecuteReader();

                while (dread.Read())
                {
                    listaCO.Add(dread["ARTICULO"].ToString());
                }
                dread.Close();
                //#########################################################################################################################################################################
                conexion.Close();

            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {

                //MessageBox.Show("[ARTICULOS COLOSO] " + ex);
                estadoCO = "SIN CONEXION";
            }
          

        }

        //CALCULA LA EXISTENCIA EN EL RANGO DE FECHA SELECCIONADO, LAS UNIDADES VENDIDAS Y EL PORCENTAJE QUE ESO REPRESENTA POR CADA ARTICULO EN LA LINEA EN COLOSO
        public void SubBuscarCO()
        {
            long entradas = 0;
            long salidas = 0;
#pragma warning disable CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
            string ent_sal = "";
#pragma warning restore CS0219 // La variable 'ent_sal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
            string tipo_mov = "";
#pragma warning restore CS0219 // La variable 'tipo_mov' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            int cantidad = 0;
#pragma warning restore CS0219 // La variable 'cantidad' está asignada pero su valor nunca se usa
            long existencia = 0;
#pragma warning disable CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
            int existenciaReal = 0;
#pragma warning restore CS0219 // La variable 'existenciaReal' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'porcentaje' está asignada pero su valor nunca se usa
            double porcentaje = 0;
#pragma warning restore CS0219 // La variable 'porcentaje' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cancelarEntrada' está asignada pero su valor nunca se usa
            int cancelarEntrada = 0;
#pragma warning restore CS0219 // La variable 'cancelarEntrada' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'cancelarSalida' está asignada pero su valor nunca se usa
            int cancelarSalida = 0;
#pragma warning restore CS0219 // La variable 'cancelarSalida' está asignada pero su valor nunca se usa

            double precio2 = 0;
            double precio1 = 0;
            double mayoreo = 0;
            double menudeo = 0;
            //DateTime f_movim = DateTime.Now;
            string f_movim = "";
            string producto = "";
            MySqlDataReader dr = null;
            MySqlDataReader dr0 = null;
            try
            {
                MySqlConnection conexion = BDConexicon.ColosoOpen();

                for (int i = 0; i < listaCO.Count; i++)
                {


                    MySqlCommand exist = new MySqlCommand("SELECT MAX(F_MOVIM) AS F_MOV FROM MOVSINV WHERE ARTICULO='" + listaCO[i] + "'  AND (TIPO_MOVIM='COM' ||TIPO_MOVIM='T+' ||TIPO_MOVIM='A+' )", conexion);
                    dr0 = exist.ExecuteReader();
                    producto = listaCO[i].ToString();
                    while (dr0.Read())
                    {
                        //existencia = Convert.ToInt32(dr0["EXISTENCIA"].ToString());
                        //if (dr0["ENT_SAL"].ToString().Equals("E"))
                        //{
                        //    cancelarEntrada = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        //}
                        //if (dr0["ENT_SAL"].ToString().Equals("S") && dr0["TIPO_MOVIM"].ToString().Equals("TK"))
                        //{
                        //    cancelarSalida = Convert.ToInt32(dr0["CANTIDAD"].ToString());
                        //}
                        f_movim = dr0["F_MOV"].ToString();
                    }
                    dr0.Close();


                    MySqlCommand cmd = new MySqlCommand("SELECT mov.ARTICULO,p.DESCRIP,p.PRECIO1,p.PRECIO2,mov.ENT_SAL, mov.TIPO_MOVIM,mov.CANTIDAD,mov.EXISTENCIA " +
                   "FROM MOVSINV mov INNER JOIN PRODS p ON mov.ARTICULO=p.ARTICULO" +
                   " WHERE p.ARTICULO='" + listaCO[i] + "' ORDER BY DESCRIP", conexion);
                    dr = cmd.ExecuteReader();


                    while (dr.Read())
                    {

                        if (dr["ENT_SAL"].ToString().Equals("E"))
                        {
                            entradas += Convert.ToInt64(dr["CANTIDAD"].ToString());
                            //existencia += Convert.ToInt32(dr["EXISTENCIA"].ToString());
                            //existencia += entradas;
                        }

                        if (dr["ENT_SAL"].ToString().Equals("S"))
                        {
                            salidas += Convert.ToInt64(dr["CANTIDAD"].ToString());
                        }

                    }
                    existencia = entradas-salidas;
                    try
                    {
                        //existenciaReal = existencia - salidas;
                        //existencia = existencia - cancelarEntrada;
                        //salidas = salidas - cancelarSalida;
                        //porcentaje = (salidas * 100) / existencia;
                    }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
                    {


                    }

                    if (dr.HasRows)
                    {
                       
                             precio2 = Convert.ToDouble(dr["PRECIO2"].ToString());
                            precio1 = Convert.ToDouble(dr["PRECIO1"].ToString());

                           mayoreo = precio2 + (precio2 * 0.16);
                            menudeo = precio1 + (precio1 * 0.16);

                            DataRow row = co.NewRow();
                            DataRow row2 = articulosCO.NewRow();

                            row["ARTICULO"] = dr["ARTICULO"].ToString();
                            row["DESCRIPCION"] = dr["DESCRIP"].ToString();
                            row["PRECIO MAYOREO"] = mayoreo;
                            row["PRECIO MENUDEO"] = menudeo;
                            row["EXISTENCIA"] = existencia;
                            row["F_ENTRADA_CO"] = f_movim;
                            //row["PORCENTAJE"] = porcentaje.ToString("N2");
                            co.Rows.Add(row);


                        row2["ARTICULO"] = dr["ARTICULO"].ToString();
                        row2["DESCRIPCION"] = dr["DESCRIP"].ToString();
                        row2["PRECIO MAYOREO"] = mayoreo;
                        row2["PRECIO MENUDEO"] = menudeo;
                        articulosCO.Rows.Add(row2);


                    }
                    else
                    {

                    }


                    dr.Close();

                    existenciaReal = 0; existencia = 0; salidas = 0; porcentaje = 0; entradas = 0; cancelarEntrada = 0; cancelarSalida = 0;



                }
                estadoCO = "CONECTADO";

                conexion.Close();
            }
            catch (Exception ex)
            {

                //MessageBox.Show("[PORCENTAJE COLOSO] " + ex);
                MessageBox.Show("Error CO, valor de la entrada: "+producto+" "+ ex);

                estadoCO = "SIN CONEXION";
            }
        }

        ////BUSCA LOS ARTICULOS DE LA LINEA SELECCIONADA EN LA SUC. PREGOT
        //public void BuscarPRE()
        //{

        //   pre.Rows.Clear();
        //    listaPRE.Clear();
        //    articulosPRE.Rows.Clear();

        //    linea = CB_linea.SelectedItem.ToString();
        //    inicio = DT_inicio.Value;
        //    fin = DT_fin.Value;
        //    try
        //    {
        //        //###################################  LLENA LA LISTA CON LOS ARTICULOS DE LA TIENDA VALLARTA DENTRO DE LA LINEA SELECCIONADA ############################################
        //        string query = "SELECT ARTICULO FROM PRODS WHERE LINEA='" + linea + "'";
        //        MySqlConnection conexion = BDConexicon.Papeleria1Open();
        //        MySqlCommand comand = new MySqlCommand(query, conexion);
        //        MySqlDataReader dread = comand.ExecuteReader();

        //        while (dread.Read())
        //        {
        //            listaPRE.Add(dread["ARTICULO"].ToString());
        //        }
        //        dread.Close();
        //        conexion.Close();
        //        //#########################################################################################################################################################################
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show("[ARTICULOS PREGOT] "+ex);
        //        estadoPRE = "SIN CONEXION";
                
        //    }

         
           
        //}

        ////CALCULA LA EXISTENCIA EN EL RANGO DE FECHA SELECCIONADO, LAS UNIDADES VENDIDAS Y EL PORCENTAJE QUE ESO REPRESENTA POR CADA ARTICULO EN LA LINEA EN PREGOT
        //public void SubBuscarPRE()
        //{
        //    int entradas = 0;
        //    double salidas = 0;
        //    string ent_sal = "";
        //    string tipo_mov = "";
        //    int cantidad = 0;
        //    double existencia = 0;
        //    int existenciaReal = 0;
        //    double porcentaje = 0;
        //    int cancelarEntrada = 0;
        //    int cancelarSalida = 0;

        //    double precio2 = 0;
        //    double precio1 = 0;
        //    double mayoreo = 0;
        //    double menudeo = 0;

        //    try
        //    {
        //        MySqlConnection conexion = BDConexicon.Papeleria1Open();

        //        MySqlDataReader dr = null;
        //        MySqlDataReader dr0 = null;

        //        for (int i = 0; i < listaPRE.Count; i++)
        //        {

        //            MySqlCommand exist = new MySqlCommand("SELECT ENT_SAL,TIPO_MOVIM,CANTIDAD,EXISTENCIA FROM MOVSINV WHERE ARTICULO='" + listaPRE[i] + "' and F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "' LIMIT 1", conexion);
        //            dr0 = exist.ExecuteReader();

        //            while (dr0.Read())
        //            {
        //                existencia = Convert.ToInt32(dr0["EXISTENCIA"].ToString());
        //                if (dr0["ENT_SAL"].ToString().Equals("E"))
        //                {
        //                    cancelarEntrada = Convert.ToInt32(dr0["CANTIDAD"].ToString());
        //                }
        //                if (dr0["ENT_SAL"].ToString().Equals("S") && dr0["TIPO_MOVIM"].ToString().Equals("TK"))
        //                {
        //                    cancelarSalida = Convert.ToInt32(dr0["CANTIDAD"].ToString());
        //                }
        //            }
        //            dr0.Close();


        //            MySqlCommand cmd = new MySqlCommand("SELECT mov.ARTICULO,p.DESCRIP,p.PRECIO1,p.PRECIO2,mov.ENT_SAL, mov.TIPO_MOVIM,mov.CANTIDAD,mov.EXISTENCIA " +
        //           "FROM MOVSINV mov INNER JOIN PRODS p ON mov.ARTICULO=p.ARTICULO" +
        //           " WHERE p.ARTICULO='" + listaPRE[i] + "' AND mov.F_MOVIM BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fin.ToString("yyyy-MM-dd") + "'", conexion);
        //            dr = cmd.ExecuteReader();


        //            while (dr.Read())
        //            {

        //                if (dr["ENT_SAL"].ToString().Equals("E") && dr["TIPO_MOVIM"].ToString() != "IF+")
        //                {
        //                    entradas += Convert.ToInt32(dr["CANTIDAD"].ToString());
        //                    //existencia += Convert.ToInt32(dr["EXISTENCIA"].ToString());
        //                    //existencia += entradas;
        //                }

        //                if (dr["ENT_SAL"].ToString().Equals("S") && dr["TIPO_MOVIM"].ToString() != "IF-")
        //                {
        //                    salidas += Convert.ToInt32(dr["CANTIDAD"].ToString());
        //                }

        //            }
        //            existencia = existencia + entradas;
        //            try
        //            {
        //                //existenciaReal = existencia - salidas;
        //                existencia = existencia - cancelarEntrada;
        //                salidas = salidas - cancelarSalida;
        //                porcentaje = (salidas * 100) / existencia;
        //            }
        //            catch (Exception ex)
        //            {


        //            }

        //            if (dr.HasRows)
        //            {
        //                if (porcentaje <= 10)
        //                {
        //                    precio2 = Convert.ToDouble(dr["PRECIO2"].ToString());
        //                    precio1 = Convert.ToDouble(dr["PRECIO1"].ToString());

        //                    mayoreo = precio2 + (precio2 * 0.16);
        //                    menudeo = precio1 + (precio1 * 0.16);

        //                    DataRow row = pre.NewRow();
        //                    DataRow row2 = articulosPRE.NewRow();

        //                    row["ARTICULO"] = dr["ARTICULO"].ToString();
        //                    row["DESCRIPCION"] = dr["DESCRIP"].ToString();
        //                    row["PRECIO MAYOREO"] = mayoreo;
        //                    row["PRECIO MENUDEO"] = menudeo;
        //                    row["EXISTENCIA"] = existencia;
        //                    row["U. VENDIDAS"] = salidas;
        //                    row["PORCENTAJE"] = porcentaje.ToString("N2");
        //                    pre.Rows.Add(row);


        //                    //row2["ARTICULO"] = dr["ARTICULO"].ToString();
        //                    //row2["DESCRIPCION"] = dr["DESCRIP"].ToString();
        //                    //row2["PRECIO MAYOREO"] = mayoreo;
        //                    //row2["PRECIO MENUDEO"] = menudeo;
        //                    //articulosPRE.Rows.Add(row2);

        //                }
        //            }
        //            else
        //            {

        //            }

        //            dr.Close();

        //            existenciaReal = 0; existencia = 0; salidas = 0; porcentaje = 0; entradas = 0; cancelarEntrada = 0; cancelarSalida = 0;

        //        }
        //        estadoPRE = "CONECTADO";

        //        conexion.Close();

        //    }
        //    catch (Exception ex)
        //    {

        //        //MessageBox.Show("[PORCENTAJE PREGOT] " + ex);
        //        estadoPRE = "SIN CONEXION";
        //    }
        //}



        private void BT_exportar_Click(object sender, EventArgs e)
        {
            try
            {
                LB_mensajeExp.Text = "";
                LB_mensajeExp.Text = "EXPORTANDO A EXCEL";

                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);


                excel.Range["A1:A4000"].NumberFormat = "@";
                excel.Range["C1:D2000"].NumberFormat = "$#,##0.00";
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



                LB_mensajeExp.Text = "ARCHIVO DE EXCEL CREADO";
                excel.Visible = true;

            }
            catch (Exception ex)
            {
                LB_mensajeExp.Text = "ERROR AL CREAR ARCHIVO DE EXCEL";
                MessageBox.Show("[Excepcion controlada] " +ex);
            }
        }


        //Este método auxiliar ayuda a eliminar los productos repetidos retornando un datatable de productos sin repetir
        public DataTable Repetidos(DataTable dtData, string sColumnName)
        {
            try
            {
                DataTable distintos = dtData.DefaultView.ToTable(true, sColumnName);
                DataTable dtNew = new DataTable();
                foreach (DataColumn dcName in dtData.Columns)
                {
                    dtNew.Columns.Add(new DataColumn(dcName.Caption, dcName.DataType));
                }

                foreach (DataRow drRow in distintos.Rows)
                {
                    dtNew.ImportRow(dtData.Select(sColumnName + " = '" + drRow[0] + "'")[0]);
                }
                return dtNew;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        //LLENA EL DATATABLE MAESTRO CON LA INFORMACION DE LOS DATATABLES DE LAS TIENDAS, ASI MISMO MAESTRO LLENA AL DATAGRID
        private void BT_buscar_Click(object sender, EventArgs e)
        {
            LB_va.Text = "";
            LB_re.Text = "";
            LB_ve.Text = "";
            LB_co.Text = "";
            LB_pre.Text = "";
            LB_mensajeExp.Text = "";
            LB_mensaje.Text = "";
            LB_mensaje.Text="BUSCANDO INFORMACIÓN EN LAS TIENDAS...";
            maestro.Rows.Clear();
            DG_tabla.Rows.Clear();
            BuscarVA();
            BuscarRE();
            BuscarVE();
            BuscarCO();
            //BuscarPRE();


            // ################################# HILOS ###############################################################################
            Thread procesoVA = new Thread(SubBuscarVA);
            Thread procesoRE = new Thread(SubBuscarRE);
            Thread procesoVE = new Thread(SubBuscarVE);
            Thread procesoCO = new Thread(SubBuscarCO);
            //Thread procesoPRE = new Thread(SubBuscarPRE);

            procesoVA.Start();
            procesoRE.Start();
            procesoVE.Start();
            procesoCO.Start();
            //procesoPRE.Start();
          
            procesoVA.Join();
            procesoRE.Join();
            procesoVE.Join();
            procesoCO.Join();
            //procesoPRE.Join();
            //###########################################################################################################################

            // UNION DE LOS DATA TABLES QUE CONTIENEN LOS ARTICULOS ########################################################
            articulosAUX = va.AsEnumerable()
                .Union(re.AsEnumerable())
                .Union(ve.AsEnumerable())
                .Union(co.AsEnumerable()).Distinct(DataRowComparer.Default).CopyToDataTable<DataRow>();
            //##############################################################################################################
            maestro = Repetidos(articulosAUX,"ARTICULO");//SE ELIMINAN LOS ARTICULOS REPETIDOS Y SE GUARDAN EN UN NUEVO DATATABLE


            //#################################   SE AGREGAN ESTAS COLUMNAS A DATATBLE MAESTRO  ################################################
            maestro.Columns.Remove("EXISTENCIA");
            //maestro.Columns.Remove("F_MOVIM");
            //maestro.Columns.Remove("PORCENTAJE");

            maestro.Columns.Add("EXVA", typeof(int));
            maestro.Columns.Add("ULTIMA ENTRADA VA", typeof(string));
            //maestro.Columns.Add("PORCENTAJEVA", typeof(double));

            maestro.Columns.Add("EXRE", typeof(int));
            maestro.Columns.Add("ULTIMA ENTRADA RE", typeof(string));
            //maestro.Columns.Add("PORCENTAJERE", typeof(double));

            maestro.Columns.Add("EXVE", typeof(int));
            maestro.Columns.Add("ULTIMA ENTRADA VE", typeof(string));
            //maestro.Columns.Add("PORCENTAJEVE", typeof(double));

            maestro.Columns.Add("EXCO", typeof(int));
            maestro.Columns.Add("ULTIMA ENTRADA CO", typeof(string));
            //maestro.Columns.Add("PORCENTAJECO", typeof(double));

            //maestro.Columns.Add("EXPRE", typeof(int));
            //maestro.Columns.Add("UNIDADES VENDIDAS PRE", typeof(int));
            //maestro.Columns.Add("PORCENTAJEPRE", typeof(double));
            //################################################################################################################################
            //################################################ SE LLENA MAESTRO DE LA INFORMACION DE LOS OTROS DATATABLES ############################
            string valor = "";
            try
            {
                foreach (DataRow row in maestro.Rows)
                {
                    valor = row["ARTICULO"].ToString();

                    foreach (DataRow row1 in va.Rows)
                    {

                        if (valor.Equals(row1["ARTICULO"].ToString()))

                        {

                            row["EXVA"] = row1["EXISTENCIA"].ToString();
                            row["ULTIMA ENTRADA VA"] = row1["F_ENTRADA_VA"].ToString();
                            //row["PORCENTAJEVA"] = row1["PORCENTAJE"].ToString();
                        }

                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("[EXCEPCION]: " + ex);
            }

            try
            {
                foreach (DataRow row in maestro.Rows)
                {
                    valor = row["ARTICULO"].ToString();

                    foreach (DataRow row1 in re.Rows)
                    {

                        if (valor.Equals(row1["ARTICULO"].ToString()))

                        {

                            row["EXRE"] = row1["EXISTENCIA"].ToString();
                            row["ULTIMA ENTRADA RE"] = row1["F_ENTRADA_RE"].ToString();
                            //row["PORCENTAJERE"] = row1["PORCENTAJE"].ToString();
                        }

                    }


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }

            try
            {
                foreach (DataRow row in maestro.Rows)
                {
                    valor = row["ARTICULO"].ToString();

                    foreach (DataRow row1 in ve.Rows)
                    {

                        if (valor.Equals(row1["ARTICULO"].ToString()))

                        {

                            row["EXVE"] = row1["EXISTENCIA"].ToString();
                            row["ULTIMA ENTRADA VE"] = row1["F_ENTRADA_VE"].ToString();
                            //row["PORCENTAJEVE"] = row1["PORCENTAJE"].ToString();
                        }

                    }


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }

            try
            {
                foreach (DataRow row in maestro.Rows)
                {
                    valor = row["ARTICULO"].ToString();

                    foreach (DataRow row1 in co.Rows)
                    {

                        if (valor.Equals(row1["ARTICULO"].ToString()))

                        {

                            row["EXCO"] = row1["EXISTENCIA"].ToString();
                            row["ULTIMA ENTRADA CO"] = row1["F_ENTRADA_CO"].ToString();
                            //row["PORCENTAJECO"] = row1["PORCENTAJE"].ToString();
                        }

                    }


                }
            }
#pragma warning disable CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable 'ex' se ha declarado pero nunca se usa
            {


            }


            //try
            //{
            //    foreach (DataRow row in maestro.Rows)
            //    {
            //        valor = row["ARTICULO"].ToString();

            //        foreach (DataRow row1 in pre.Rows)
            //        {

            //            if (valor.Equals(row1["ARTICULO"].ToString()))

            //            {

            //                row["EXPRE"] = row1["EXISTENCIA"].ToString();
            //                row["UNIDADES VENDIDAS PRE"] = row1["U. VENDIDAS"].ToString();
            //                row["PORCENTAJEPRE"] = row1["PORCENTAJE"].ToString();
            //            }

            //        }


            //    }
            //}
            //catch (Exception ex)
            //{


            //}

            //########################################################################################################################################################

            // ############################# SE LLENA EL DATAGRID CON LA INFORMACION DE MAESTRO, ADEMÁS SE FORMATEAN LOS DATOS #################################
#pragma warning disable CS0219 // La variable 'pVA' está asignada pero su valor nunca se usa
            double pVA = 0;
#pragma warning restore CS0219 // La variable 'pVA' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'porcentajeVA' está asignada pero su valor nunca se usa
            string porcentajeVA = "";
#pragma warning restore CS0219 // La variable 'porcentajeVA' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'pRE' está asignada pero su valor nunca se usa
            double pRE = 0;
#pragma warning restore CS0219 // La variable 'pRE' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'porcentajeRE' está asignada pero su valor nunca se usa
            string porcentajeRE = "";
#pragma warning restore CS0219 // La variable 'porcentajeRE' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'pVE' está asignada pero su valor nunca se usa
            double pVE = 0;
#pragma warning restore CS0219 // La variable 'pVE' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'porcentajeVE' está asignada pero su valor nunca se usa
            string porcentajeVE = "";
#pragma warning restore CS0219 // La variable 'porcentajeVE' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'pCO' está asignada pero su valor nunca se usa
            double pCO = 0;
#pragma warning restore CS0219 // La variable 'pCO' está asignada pero su valor nunca se usa
#pragma warning disable CS0219 // La variable 'porcentajeCO' está asignada pero su valor nunca se usa
            string porcentajeCO = "";
#pragma warning restore CS0219 // La variable 'porcentajeCO' está asignada pero su valor nunca se usa
            //double pPRE = 0;
            //string  porcentajePRE = "";

            foreach (DataRow item in maestro.Rows)
            {

                //if (item["PORCENTAJEVA"] !=DBNull.Value )
                //{
                //    pVA = Convert.ToDouble(item["PORCENTAJEVA"]);
                //    pVA = pVA / 100;
                //    porcentajeVA = $"{pVA:0.#%}";

                //}
                //else
                //{
                //    porcentajeVA = "";
                //}

                //if (item["PORCENTAJERE"] != DBNull.Value )
                //{
                //    pRE = Convert.ToDouble(item["PORCENTAJERE"]);
                //    pRE = pRE / 100;
                //    porcentajeRE = $"{pRE:0.#%}";
                //}
                //else
                //{
                //    porcentajeRE = "";
                //}

                //if (item["PORCENTAJEVE"] != DBNull.Value )
                //{
                //    pVE = Convert.ToDouble(item["PORCENTAJEVE"]);
                //    pVE = pVE / 100;
                //    porcentajeVE = $"{pVE:0.#%}";
                //}
                //else
                //{
                //    porcentajeVE = "";
                //}

                //if (item["PORCENTAJECO"] != DBNull.Value )
                //{
                //    pCO = Convert.ToDouble(item["PORCENTAJECO"]);
                //    pCO = pCO / 100;
                //    porcentajeCO = $"{pCO:0.#%}";
                //}
                //else
                //{
                //    porcentajeCO = "";
                //}

                //if (item["PORCENTAJEPRE"] != DBNull.Value)
                //{
                //    pPRE = Convert.ToDouble(item["PORCENTAJEPRE"]);
                //    pPRE = pPRE / 100;
                //    porcentajePRE = $"{pPRE:0.#%}";

                //}
                //else
                //{
                //    porcentajePRE = "";
                //}

                DG_tabla.Rows.Add(item["ARTICULO"], item["DESCRIPCION"], item["PRECIO MAYOREO"], item["PRECIO MENUDEO"], item["EXVA"], item["ULTIMA ENTRADA VA"], item["EXRE"], item["ULTIMA ENTRADA RE"], item["EXVE"], item["ULTIMA ENTRADA VE"], item["EXCO"], item["ULTIMA ENTRADA CO"]);

                LB_va.Text = estadoVA; LB_re.Text = estadoRE; LB_ve.Text = estadoVE; LB_co.Text = estadoCO; LB_pre.Text = estadoPRE;


                if (LB_va.Text.Equals("CONECTADO"))
                {
                    LB_va.ForeColor = Color.Green;
                }
                else
                {
                    LB_va.ForeColor = Color.Red;
                }


                if (LB_re.Text.Equals("CONECTADO"))
                {
                    LB_re.ForeColor = Color.Green;
                }
                else
                {
                    LB_re.ForeColor = Color.Red;
                }

                if (LB_ve.Text.Equals("CONECTADO"))
                {
                    LB_ve.ForeColor = Color.Green;
                }
                else
                {
                    LB_ve.ForeColor = Color.Red;
                }

                if (LB_co.Text.Equals("CONECTADO"))
                {
                    LB_co.ForeColor = Color.Green;
                }
                else
                {
                    LB_co.ForeColor = Color.Red;
                }

                if (LB_pre.Text.Equals("CONECTADO"))
                {
                    LB_pre.ForeColor = Color.Green;
                }
                else
                {
                    LB_pre.ForeColor = Color.Red;
                }
            }


            DG_tabla.Columns["PRECIO_MAY"].DefaultCellStyle.Format = "C2";
            DG_tabla.Columns["PRECIO_MEN"].DefaultCellStyle.Format = "C2";

            //DG_tabla.Columns["PORCENTAJEVA"].DefaultCellStyle.Format = "##.####%";
            //DG_tabla.Columns["PORCENTAJERE"].DefaultCellStyle.Format = "##.####%";
            //DG_tabla.Columns["PORCENTAJEVE"].DefaultCellStyle.Format = "##.####%";
            //DG_tabla.Columns["PORCENTAJECO"].DefaultCellStyle.Format = "##.####%";
            //DG_tabla.Columns["PORCENTAJEPRE"].DefaultCellStyle.Format = "##.####%";


            DG_tabla.Columns["PRECIO_MAY"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            DG_tabla.Columns["PRECIO_MEN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

            LB_mensaje.Text = "BUSQUEDA FINALIZADA";
            //###########################################################################################################################################
        }
    }
}
