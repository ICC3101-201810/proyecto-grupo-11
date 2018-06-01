using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

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

            #region "Primeros Alumnos"
            /*var objAlumno = new List<Alumno>();
            objAlumno.Add(new Alumno(0, new List<string>(), "Joaquin", "Tellez", "19079901-8", "jatellez", "joaquin"));
            objAlumno.Add(new Alumno(0, new List<string>(), "Santiago", "Figueroa", "19990164-4", "sfigueroa", "santiago"));
            objAlumno.Add(new Alumno(0, new List<string>(), "Nicolas", "Apara", "19006158-7", "napara", "nicolas"));
            objAlumno.Add(new Alumno(0, new List<string>(), "Alfonso", "Zuñiga", "19747589-6", "azuñiga", "alfonso"));

            using (Stream stream = new FileStream("Alumnos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, objAlumno);
                stream.Close();

            }*/
            #endregion

            #region "Primeros Libros"
            /*List<Libro> libros = new List<Libro>();
            List<string> palabras = new List<string> { "muy bueno", "espectacular" };
            Ubicacion tercer_piso = new Ubicacion("norte", 3, 5, 2);
            Libro baldor = new Libro("Ingenieria", 3, "Al Juarismi", "1986", 8, palabras, tercer_piso, "Baldor. Álgebra");
            libros.Add(baldor);
            List<string> palabras2 = new List<string> { "me gusto", "increible" };
            Ubicacion segundo_piso = new Ubicacion("norte", 2, 10, 4);
            Libro metafisica = new Libro("Derecho", 1, "Juan Antonio Widow", "1998", 8, palabras2, segundo_piso, "Curso de Metafísica");
            libros.Add(metafisica);
            List<string> palabras3 = new List<string> { "Buenos ejemplos", "sencillo" };
            Ubicacion primer_piso = new Ubicacion("centro", 1, 2, 2);
            Libro quimica = new Libro("Medicina", 5, "R Chi", "1978", 6, palabras3, primer_piso, "Fundamentos de la Química");
            libros.Add(quimica);

            using (Stream stream = new FileStream("Libros.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, libros);
                stream.Close();

            }*/
            #endregion

            List<Alumno> alumnos = null;
            List<Libro> libros = null;
            List<Arriendo> arriendos = null;
            try
            {
                using(Stream stream = new FileStream("Alumnos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    alumnos = (List<Alumno>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch(IOException)
            {
                
            }

            try
            {
                using (Stream stream = new FileStream("Libros.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    libros = (List<Libro>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (IOException)
            {

            }

            #region "Creando Arriendos"
            /*List<Arriendo> arriendos = new List<Arriendo>();
            foreach(Alumno a in alumnos)
            {
                arriendos.Add(new Arriendo(a));
            }

            using (Stream stream = new FileStream("Arriendos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, arriendos);
                stream.Close();

            }*/
            #endregion

            try
            {
                using (Stream stream = new FileStream("Arriendos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    arriendos = (List<Arriendo>)formatter.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (IOException)
            {

            }

            vista_alumno vista2 = new vista_alumno();
            vista_administrador vista = new vista_administrador(vista2);
            inicio_sesion i_s = new inicio_sesion();
            string busqueda = " ";
            vista_busqueda vista3 = new vista_busqueda(busqueda, libros);
            Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista3);

            Application.Run(i_s);
            
        }
    }
}
