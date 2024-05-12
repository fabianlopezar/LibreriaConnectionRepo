﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaConnection.views;

namespace LibreriaConnection
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UIUpdateCategorias() /*Form1()*/);
            //Application.Run(new UIInsertTelefono() /*Form1()*/) ;
            //Application.Run(new UIInsertCuenta() ) ;
            //Application.Run(new UIInsertEditorial() ) ;
            //Application.Run(new UIInsertAdministradores()) ;
            Application.Run(new UIInsertAutores()) ;
            //Application.Run(new UIInsertCategoria() /*Form1()*/) ;
            //Application.Run(new UIUpdateCuentas() /*Form1()*/);
            //Application.Run(new UIUpdateEditoriales() /*Form1()*/);
        }
    }
}
