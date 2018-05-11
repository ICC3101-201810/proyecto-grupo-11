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
        List<Libro> Libros;
        vista_administrador vista_Administrador;

        public AdminController(vista_administrador vista_Administrador)
        {
            Usuario = new List<Alumno>();
            Admin = new List<Administrador>();
            Libros = new List<Libro>();
            this.vista_Administrador = vista_Administrador;
            this.vista_Administrador.OnAgregarUsuario += Vista_Administrador_OnAgregarUsuario;
            this.vista_Administrador.OnAgregarLibro += Vista_Administrador_OnAgregarLibro;
        }

        public void Vista_Administrador_OnAgregarLibro(object sender, AgregarLibroEventArgs e)
        {
            Libro libro = new Libro(e.CarreraAsociada, e.Copia, e.Autor, e.FechaCreacion, 0, new List<string>(), null, e.Titulo);
            Libros.Add(libro);
        }

        private void Vista_Administrador_OnAgregarUsuario(object sender, AgregarUsuarioEventArgs e)
        {
            Alumno alumno = new Alumno(0, new List<string>(), e.Nombre, e.Apellido, e.Rut, e.Usuario, e.Password);
            Usuario.Add(alumno);
        }
    }
}
