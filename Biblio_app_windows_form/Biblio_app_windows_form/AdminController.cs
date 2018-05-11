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
            this.vista_Administrador.OnAgregarUsuario += Vista_Administrador_OnAgregarUsuario;
        }

        private void Vista_Administrador_OnAgregarUsuario(object sender, AgregarUsuarioEventArgs e)
        {
            Alumno alumno = new Alumno(0, new List<string>(), e.Nombre, e.Apellido, e.Rut, e.Usuario, e.Password);
            Usuario.Add(alumno);
        }
    }
}
