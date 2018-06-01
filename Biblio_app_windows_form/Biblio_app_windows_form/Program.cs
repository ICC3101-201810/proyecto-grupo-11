using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio_app_windows_form
{
    static class Program
    {

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            vista_alumno vista2 = new vista_alumno();
            vista_administrador vista = new vista_administrador(vista2);
            inicio_sesion i_s = new inicio_sesion();
            
            Controller controlador = new Controller(vista, vista2, i_s);

            Application.Run(i_s);
            
        }
    }
}
