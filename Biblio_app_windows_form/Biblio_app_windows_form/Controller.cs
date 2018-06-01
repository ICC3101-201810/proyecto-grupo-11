using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Biblio_app_windows_form
{
    [Serializable()]
    class Controller
    {
        List<Alumno> User;
        List<Administrador> Admin;
        List<Libro> Libros { get; set; }
        vista_administrador vista_Administrador;
        vista_alumno vista_Alumno;
        inicio_sesion i_s;
        Libro libro;

        public Controller(vista_administrador mi_vista_Administrador, vista_alumno mi_vista_Alumno, inicio_sesion mi_i_s)
        {
            User = new List<Alumno>();
            Admin = new List<Administrador>();
            Libros = new List<Libro>();
            vista_Administrador = mi_vista_Administrador;
            vista_Administrador.OnAgregarUsuario += Vista_Administrador_OnAgregarUsuario;
            this.vista_Administrador.OnAgregarLibro += Vista_Administrador_OnAgregarLibro;
            vista_Alumno = mi_vista_Alumno;
            vista_Alumno.OnArrendar += Vista_Alumno_OnArrendar;
            i_s = mi_i_s;
            i_s.OnInicio += i_s_OnInicio;
        }

        private void i_s_OnInicio(object sender, InicioEventArgs e)
        {
            
        }

        private void Vista_Administrador_OnAgregarLibro(object sender, AgregarLibroEventArgs e)
        {
            Libro libro = new Libro(e.CarreraAsociada, e.Copia, e.Autor, e.FechaCreacion, 0, new List<string>(), null, e.Titulo);
            Libros.Add(libro);
            

            /*IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("libro.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, libro);*/
        }

        private void Vista_Administrador_OnAgregarUsuario(object sender, AgregarUsuarioEventArgs e)
        {
            Alumno alumno = new Alumno(0, new List<string>(), e.Nombre, e.Apellido, e.Rut, e.Usuario, e.Password);
            User.Add(alumno);
            
    
            /*IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("alumno.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, alumno);*/
        }

        private void Vista_Alumno_OnArrendar(object sender, ArrendarLibroEventArgs e)
        {
            foreach(Libro l in Libros)
            {
                if(l.Titulos == e.titulo && l.Copia > 0)
                {
                    l.Copia--;
                }
            }
        }
    }   
}
