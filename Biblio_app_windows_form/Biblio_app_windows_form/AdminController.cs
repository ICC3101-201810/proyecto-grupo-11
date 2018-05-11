using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    class AdminController
    {
        List<Alumno> Usuario;
        List<Administrador> Admin;
        vista_administrador vista_Administrador;

        public AdminController(vista_administrador vista_Administrador)
        {
            Usuario = new List<Alumno>();
            Admin = new List<Administrador>();
            this.vista_Administrador = vista_Administrador;
            
        }
    }
}
