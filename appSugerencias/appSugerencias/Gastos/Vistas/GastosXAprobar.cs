using appSugerencias.Gastos.Controlador;
using appSugerencias.Gastos.Modelo;
using appSugerencias.Gastos_Externos.Controlador;
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
    public partial class GastosXAprobar : Form
    {
        string sucursal = "";
        public GastosXAprobar(string sucursal)
        {
            this.sucursal = sucursal;
            InitializeComponent();
        }

        private void GastosXAprobar_Load(object sender, EventArgs e)
        {
            
            //RevisionGastosController gc = new RevisionGastosController();
            //List<Gasto> lista = gc.BuscarGastosXAprobar(sucursal);
            //foreach (var item in lista)
            //{
                
            //    DG_tabla.Rows.Add(item.Fecha.ToString("dd-MM-yyyy"),item.CantGastos);
            //}

            //DataTable gastosPendientes = RevisionGastosController.BuscarGastosPendientesXCargar(sucursal);

            //for (int i = 0; i < DG_tabla.; i++)
            //{

            //}
        }

        private void BT_buscar_Click(object sender, EventArgs e)
        {
            DG_tabla.Rows.Clear();
            DateTime inicio = DT_inicio.Value;
            DateTime fin = DT_fin.Value;
            bool respaldo = false;

            if (sucursal.Equals("CEDIS"))
            {
                DataTable pendienteXRevisar = RevisionGastosController.GastosXRevisarCedis(inicio,fin);
                DataTable pendienteXCorregir = RevisionGastosController.GastosXCorregirCedis(inicio,fin);
                DataTable pendienteXAprobar = RevisionGastosController.GastosXAprobarCedis(inicio,fin);

                for (DateTime i = inicio; i <= fin; i = i.AddDays(1))
                {
                    DG_tabla.Rows.Add(i.ToString("yyyy-MM-dd"), 0, 0, 0, 0);
                }
                DateTime fechaTabla;
                DateTime fechaDataTable;


                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    fechaTabla = Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value);
                    for (int j = 0; j < pendienteXRevisar.Rows.Count; j++)
                    {
                        fechaDataTable = Convert.ToDateTime(pendienteXRevisar.Rows[j]["FECHA"]);

                        if (fechaTabla == fechaDataTable)
                        {
                            DG_tabla.Rows[i].Cells["REVISAR"].Value = pendienteXRevisar.Rows[j]["CANTIDAD"];
                            break;
                        }
                        else
                        {
                            DG_tabla.Rows[i].Cells["REVISAR"].Value = 0;
                        }
                    }

                    for (int j = 0; j < pendienteXCorregir.Rows.Count; j++)
                    {
                        fechaDataTable = Convert.ToDateTime(pendienteXCorregir.Rows[j]["FECHA"]);

                        if (fechaTabla == fechaDataTable)
                        {
                            DG_tabla.Rows[i].Cells["PENDIENTES_CORREGIR"].Value = pendienteXCorregir.Rows[j]["CANTIDAD"];
                            break;
                        }
                        else
                        {
                            DG_tabla.Rows[i].Cells["PENDIENTES_CORREGIR"].Value = 0;
                        }
                    }

                    for (int j = 0; j < pendienteXAprobar.Rows.Count; j++)
                    {
                        fechaDataTable = Convert.ToDateTime(pendienteXAprobar.Rows[j]["FECHA"]);

                        if (fechaTabla == fechaDataTable)
                        {
                            DG_tabla.Rows[i].Cells["CANT_GASTOS"].Value = pendienteXAprobar.Rows[j]["CANTIDAD"];
                            break;
                        }
                        else
                        {
                            DG_tabla.Rows[i].Cells["CANT_GASTOS"].Value = 0;
                        }
                    }
                }

                  
            }
            else if (sucursal.Equals("FINANZAS"))
            {
                DataTable gastosXAprobarFinanzas = GastoExternoController.CantidadGastosPorAprobar(inicio,fin);
                for (DateTime i = inicio; i <= fin; i = i.AddDays(1))
                {
                    DG_tabla.Rows.Add(i.ToString("yyyy-MM-dd"),0,0,0,0);
                }

                DateTime fechaTabla;
                DateTime fechaDataTable;
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    fechaTabla = Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value);

                  

                    for (int j = 0; j < gastosXAprobarFinanzas.Rows.Count; j++)
                    {
                        fechaDataTable = Convert.ToDateTime(gastosXAprobarFinanzas.Rows[j]["FECHA"]);

                        if (fechaTabla == fechaDataTable)
                        {
                            DG_tabla.Rows[i].Cells["CANT_GASTOS"].Value = gastosXAprobarFinanzas.Rows[j]["CANTIDAD"];
                            break;
                        }
                        else
                        {
                            DG_tabla.Rows[i].Cells["CANT_GASTOS"].Value = 0;
                        }
                    }
                }

            }
            else
            {
                if (CBX_respaldo.Checked == true)
                {
                    respaldo = true;
                }

                DataTable gastosXCargar = RevisionGastosController.BuscarGastosPendientesXCargar(sucursal, inicio, fin, respaldo);
                DataTable gastosXRevisar = RevisionGastosController.gastosXRevisarGina(sucursal, inicio, fin);
                DataTable gastosPendientesCorregir = RevisionGastosController.gastosPendientesCorregir(sucursal, inicio, fin);
                DataTable gastosXAprobar = RevisionGastosController.gastosXAprobar(sucursal, inicio, fin);

                for (DateTime i = inicio; i <= fin; i = i.AddDays(1))
                {
                    DG_tabla.Rows.Add(i.ToString("yyyy-MM-dd"), 0, 0, 0, 0);
                }



                DateTime fechaTabla;
                DateTime fechaDataTable;
                for (int i = 0; i < DG_tabla.Rows.Count; i++)
                {
                    fechaTabla = Convert.ToDateTime(DG_tabla.Rows[i].Cells["FECHA"].Value);

                    for (int j = 0; j < gastosXCargar.Rows.Count; j++)
                    {
                        fechaDataTable = Convert.ToDateTime(gastosXCargar.Rows[j]["FECHA"]);

                        if (fechaTabla == fechaDataTable)
                        {
                            DG_tabla.Rows[i].Cells["PENDIENTES_CARGAR"].Value = gastosXCargar.Rows[j]["CANTIDAD"];
                            break;
                        }
                        else
                        {
                            DG_tabla.Rows[i].Cells["PENDIENTES_CARGAR"].Value = 0;
                        }
                    }

                    for (int j = 0; j < gastosXRevisar.Rows.Count; j++)
                    {
                        fechaDataTable = Convert.ToDateTime(gastosXRevisar.Rows[j]["FECHA"]);

                        if (fechaTabla == fechaDataTable)
                        {
                            DG_tabla.Rows[i].Cells["REVISAR"].Value = gastosXRevisar.Rows[j]["CANTIDAD"];
                            break;
                        }
                        else
                        {
                            DG_tabla.Rows[i].Cells["REVISAR"].Value = 0;
                        }
                    }

                    for (int j = 0; j < gastosPendientesCorregir.Rows.Count; j++)
                    {
                        fechaDataTable = Convert.ToDateTime(gastosPendientesCorregir.Rows[j]["FECHA"]);

                        if (fechaTabla == fechaDataTable)
                        {
                            DG_tabla.Rows[i].Cells["PENDIENTES_CORREGIR"].Value = gastosPendientesCorregir.Rows[j]["CANTIDAD"];
                            break;
                        }
                        else
                        {
                            DG_tabla.Rows[i].Cells["PENDIENTES_CORREGIR"].Value = 0;
                        }
                    }

                    for (int j = 0; j < gastosXAprobar.Rows.Count; j++)
                    {
                        fechaDataTable = Convert.ToDateTime(gastosXAprobar.Rows[j]["FECHA"]);

                        if (fechaTabla == fechaDataTable)
                        {
                            DG_tabla.Rows[i].Cells["CANT_GASTOS"].Value = gastosXAprobar.Rows[j]["CANTIDAD"];
                            break;
                        }
                        else
                        {
                            DG_tabla.Rows[i].Cells["CANT_GASTOS"].Value = 0;
                        }
                    }
                }
            }
        

        }   
    }
}
