using System;
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
            //-------------------- inserts -------------------------------
            //Application.Run(new UIInsertLibro() ); //Funciona
            //Application.Run(new UIInsertAutores()) ; //Funciona
            //Application.Run(new UIInsertCuenta() ) ;
            
            
            //Application.Run(new UIInsertTelefono() ) ;
            //Application.Run(new UIInsertEditorial() ) ;
            //Application.Run(new UIInsertAdministradores()) ;
            //Application.Run(new UIInsertCategoria() ) ;



            //-------------------- Updates-------------------------------

            //Application.Run(new UIUpdateCategorias() /*Form1()*/);
            //Application.Run(new UIUpdateAutores()) ;
            //Application.Run(new UIUpdateCuentas() /*Form1()*/);
            //Application.Run(new UIUpdateEditoriales() /*Form1()*/);
            //Application.Run(new UIUpdateLibro() );
            
            //-------------------- Principales -------------------------------           
            //Application.Run(new PrincipalAdministrador() );
            
            //-------------------- Consultas -------------------------------           
            Application.Run(new ConsultaLibroPrestamo() );

        }
    }
}
