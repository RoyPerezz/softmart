﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Reflection;

using System.Windows.Forms;
using appSugerencias.ReportesCCTV;
using appSugerencias.Depurar_kardex;
using appSugerencias.Gastos.Vistas;
using appSugerencias.GastosCedis.Vistas;
using appSugerencias.Gastos_Externos.Modelo;
using appSugerencias.Gastos_Externos.Vistas;
using appSugerencias.Gastos;
using appSugerencias.Cajas.Cajeras.Vista;
using appSugerencias.Cajas.Enc_Cajas.Vista;
using appSugerencias.Comisiones.Vista;

namespace appSugerencias
{
    static class Program
    {
        private static bool FirstInstance
        {
            get
            {
                bool created;
                string name = Assembly.GetEntryAssembly().FullName;
                // created will be True if the current thread creates and owns the mutex.
                // Otherwise created will be False if a previous instance already exists.

                Mutex mutex = new Mutex(true, name, out created);
                return created;
            }
        }
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]


        static void Main()
      {
            if (FirstInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
               
                Application.Run(new frm_Login());
            }
            else
            {

                MessageBox.Show("La apliacion ya esta Ejecutandose");
                Application.Exit();
            }

        }
    }



}