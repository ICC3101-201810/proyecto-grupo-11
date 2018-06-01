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
            

            string input_user = username_txtbox.Text;
            string input_password = password_txtbox.Text;
            List<Alumno> alumnos = null;
            List<Libro> libros = null;
            List<Arriendo> arriendos = null;
            try
            {
                using (Stream stream = new FileStream("Alumnos.bin", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    IFormatter formatter = new BinaryFormatter();
                    alumnos = (List<Alumno>)formatter.Deserialize(stream);
                    stream.Close();
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
                    stream.Close();
                }
            }
            catch (IOException)
            {

            }

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
            string busqueda = " ";
            
            for (int alumno = 0; alumno < alumnos.Count; alumno++)
            {
                
                if(alumnos[alumno].GetUsername() == input_user)
                {
                    if(alumnos[alumno].GetPassword() != input_password)
                    {
                        MessageBox.Show("Nombre de Usuario o Contraseña incorrectos");
                    }
                    else
                    {
                        /*string tipo_string = alumnos[alumno].GetType().ToString();
                        if (tipo_string == "Administrador")
                        {
                            vista_alumno vista2 = new vista_alumno();
                            vista_administrador vista = new vista_administrador(vista2);
                            inicio_sesion i_s = new inicio_sesion();
                            vista_busqueda vista3 = new vista_busqueda(busqueda, libros);
                            Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista3);
                            vista.Show();
                            this.Hide();
                        }*/

                        alumnos[alumno].sesion = true;
                        arriendos[alumno].alumno.sesion = true;
                        using (Stream stream = new FileStream("Alumnos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            IFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(stream, alumnos);
                            stream.Close();
                        }
                        using (Stream stream = new FileStream("Arriendos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            IFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(stream, arriendos);
                            stream.Close();

                        }
                        vista_alumno vista2 = new vista_alumno();
                        vista_administrador vista = new vista_administrador(vista2);
                        inicio_sesion i_s = new inicio_sesion();
                        vista_busqueda vista3 = new vista_busqueda(busqueda, libros);
                        Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista3);
                        vista2.Show();
                            
                        this.Hide();
                        


                    }
                }
            }
            
            if (username_txtbox.Text == "alumno")
            {
                
                vista_alumno vista2 = new vista_alumno();
                vista_administrador vista = new vista_administrador(vista2);
                inicio_sesion i_s = new inicio_sesion();
                vista_busqueda vista3 = new vista_busqueda(busqueda, libros);
                Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista3);
                vista2.Show();
                this.Hide();
            }

            if (username_txtbox.Text == "admin")
            {

                vista_alumno vista2 = new vista_alumno();
                vista_administrador vista = new vista_administrador(vista2);
                inicio_sesion i_s = new inicio_sesion();
                vista_busqueda vista3 = new vista_busqueda(busqueda, libros);
                Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista3);
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
