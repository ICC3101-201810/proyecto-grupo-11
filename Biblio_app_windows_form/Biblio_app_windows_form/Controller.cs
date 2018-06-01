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
        List<Libro> Libros;
        List<Arriendo> Arriendos;
        vista_administrador vista_Administrador;
        vista_alumno vista_Alumno;
        inicio_sesion i_s;
        vista_busqueda vista_Busqueda;
        Libro libro;

        public Controller(vista_administrador mi_vista_Administrador, vista_alumno mi_vista_Alumno, inicio_sesion mi_i_s, List<Alumno> Misalumnos, List<Libro> Mislibros, List<Arriendo> MisArriendos, vista_busqueda Mi_vista_Busqueda)
        {
            User = Misalumnos;
            Admin = new List<Administrador>();
            Libros = Mislibros;
            Arriendos = MisArriendos;
            vista_Administrador = mi_vista_Administrador;
            vista_Administrador.OnAgregarUsuario += Vista_Administrador_OnAgregarUsuario;
            this.vista_Administrador.OnAgregarLibro += Vista_Administrador_OnAgregarLibro;
            vista_Alumno = mi_vista_Alumno;
            vista_Alumno.OnArrendar += Vista_Alumno_OnArrendar;
            vista_Alumno.OnDevolver += Vista_Alumno_OnDevolver;
            i_s = mi_i_s;
            i_s.OnInicio += i_s_OnInicio;
            vista_Busqueda = Mi_vista_Busqueda;
            vista_Busqueda.OnArrendar += Vista_Busqueda_OnArrendar;
        }

        private void Vista_Alumno_OnDevolver(object sender, DevolverLibroEventArgs e)
        {
            foreach(Arriendo a in Arriendos)
            {
                if(a.alumno.sesion == true)
                {
                    a.libro[e.row].Copia++;
                    foreach(Libro l in Libros)
                    {
                        if(l.Titulos == e.titulo && l.GetAutor() == e.autor)
                        {
                            l.Copia++;
                            break;
                        }
                    }
                    a.libro.RemoveAt(e.row);
                    using (Stream stream = new FileStream("Arriendos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, Arriendos);
                        stream.Close();

                    }
                    using (Stream stream = new FileStream("Libros.bin", FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(stream, Libros);
                        stream.Close();

                    }
                    break;
                }
            }
        }

        private void Vista_Busqueda_OnArrendar(object sender, ArrendarLibroEventArgs e)
        {            
            foreach(Libro l in Libros)
            {
                if (l.Titulos == e.titulo && l.Copia > 0 && l.GetAutor() == e.autor)
                {
                    for(int i = 0; i < User.Count(); i++)
                    {
                        if(User[i].sesion == true && User[i].Deudas == 0)
                        {
                            Arriendos[i].libro.Add(l);
                            Arriendos[i].FechaArriendo.Add(DateTime.Now);
                            l.Copia--;
                            using (Stream stream = new FileStream("Arriendos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                IFormatter formatter = new BinaryFormatter();
                                formatter.Serialize(stream, Arriendos);
                                stream.Close();

                            }
                            using (Stream stream = new FileStream("Libros.bin", FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                IFormatter formatter = new BinaryFormatter();
                                formatter.Serialize(stream, Libros);
                                stream.Close();

                            }
                            break;
                        }
                    }
                }               
            }
            

        }

        private void i_s_OnInicio(object sender, InicioEventArgs e)
        {
            
        }

        private void Vista_Administrador_OnAgregarLibro(object sender, AgregarLibroEventArgs e)
        {
            Libro libro = new Libro(e.CarreraAsociada, e.Copia, e.Autor, e.FechaCreacion, 0, new List<string>(), null, e.Titulo);
            Libros.Add(libro);
            using (Stream stream = new FileStream("Libros.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Libros);
                stream.Close();

            }
        }

        private void Vista_Administrador_OnAgregarUsuario(object sender, AgregarUsuarioEventArgs e)
        {
            Alumno alumno = new Alumno(0, new List<string>(), e.Nombre, e.Apellido, e.Rut, e.Usuario, e.Password);
            User.Add(alumno);
            Arriendos.Add(new Arriendo(alumno));
            using (Stream stream = new FileStream("Alumnos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, User);
                stream.Close();
            }

            using (Stream stream = new FileStream("Arriendos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, Arriendos);
                stream.Close();

            }
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
