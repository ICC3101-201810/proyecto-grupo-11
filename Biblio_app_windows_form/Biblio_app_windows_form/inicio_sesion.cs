using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            vista_administrador vista = new vista_administrador();
                            vista_alumno vista2 = new vista_alumno();
                            inicio_sesion i_s = new inicio_sesion();
                            Controller controlador = new Controller(vista, vista2, i_s);
                            vista.Show();
                            this.Hide();
                        }
                        if (tipo_string == "Alumno")
                        {

                            vista_administrador vista = new vista_administrador();
                            vista_alumno vista2 = new vista_alumno();
                            inicio_sesion i_s = new inicio_sesion();
                            Controller controlador = new Controller(vista, vista2, i_s);
                            vista2.Show();
                            this.Hide();
                        }


                    }
                }
            }
            
            if (username_txtbox.Text == "alumno")
            {
                
                vista_administrador vista = new vista_administrador();
                vista_alumno vista2 = new vista_alumno();
                inicio_sesion i_s = new inicio_sesion();
                Controller controlador = new Controller(vista, vista2, i_s);
                vista2.Show();
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
