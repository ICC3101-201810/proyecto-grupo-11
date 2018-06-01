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

            List<Alumno> alumnos = null;
            try
            {
                using(Stream stream = new FileStream("Alumnos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    alumnos = (List<Alumno>)formatter.Deserialize(stream);
                }
            }
            catch(IOException)
            {
                
            }

            vista_alumno vista2 = new vista_alumno();
            vista_administrador vista = new vista_administrador(vista2);
            inicio_sesion i_s = new inicio_sesion();
            
            Controller controlador = new Controller(vista, vista2, i_s, alumnos);

            Application.Run(i_s);
            
        }
    }
}
