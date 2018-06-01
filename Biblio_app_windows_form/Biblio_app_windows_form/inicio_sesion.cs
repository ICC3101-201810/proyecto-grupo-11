using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;

namespace Biblio_app_windows_form
{
    public partial class inicio_sesion : Form
    {
        public event EventHandler<InicioEventArgs> OnInicio;

        public inicio_sesion()
        {
            InitializeComponent();
        }

        private void iniciar_sesion_btn_Click(object sender, EventArgs e)
        {
            // verificar inicio de sesion
            // si corresponde a un administrador:
            // esto es algo provisorio:
            List<Persona> personas = new List<Persona>();

            string input_user = username_txtbox.Text;
            string input_password = password_txtbox.Text;
            List<Alumno> alumnos = null;
            List<Libro> libros = null;
            try
            {
                using (Stream stream = new FileStream("Alumnos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    alumnos = (List<Alumno>)formatter.Deserialize(stream);
                }
            }
            catch (IOException)
            {

            }

            try
            {
                using (Stream stream = new FileStream("Libros.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    libros = (List<Libro>)formatter.Deserialize(stream);
                }
            }
            catch (IOException)
            {

            }
            for (int alumno = 0; alumno < personas.Count; alumno++)
            {
                Persona current = personas[alumno];
                if(current.GetUsername() == input_user)
                {
                    if(current.GetPassword() != input_password)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        string tipo_string = current.GetType().ToString();
                        if (tipo_string == "Administrador")
                        {
                            vista_alumno vista2 = new vista_alumno();
                            vista_administrador vista = new vista_administrador(vista2);
                            inicio_sesion i_s = new inicio_sesion();                       
                            Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros);
                            vista.Show();
                            this.Hide();
                        }
                        if (tipo_string == "Alumno")
                        {

                            vista_alumno vista2 = new vista_alumno();
                            vista_administrador vista = new vista_administrador(vista2);
                            inicio_sesion i_s = new inicio_sesion();
                            Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros);
                            vista2.Show();
                            
                            this.Hide();
                        }


                    }
                }
            }
            
            if (username_txtbox.Text == "alumno")
            {
                
                vista_alumno vista2 = new vista_alumno();
                vista_administrador vista = new vista_administrador(vista2);
                inicio_sesion i_s = new inicio_sesion();
                Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros);
                vista2.Show();
                this.Hide();
            }

            if (username_txtbox.Text == "admin")
            {

                vista_alumno vista2 = new vista_alumno();
                vista_administrador vista = new vista_administrador(vista2);
                inicio_sesion i_s = new inicio_sesion();
                Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros);
                vista.Show();
                this.Hide();
            }


        }

        public void abrir_inicio()
        {
            this.Show();
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
