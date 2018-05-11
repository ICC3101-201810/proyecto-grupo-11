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
        public inicio_sesion()
        {
            InitializeComponent();
        }

        private void iniciar_sesion_btn_Click(object sender, EventArgs e)
        {
            // verificar inicio de sesion
            // si corresponde a un administrador:
            // esto es algo provisorio:
            if (username_txtbox.Text == "admin")// provisorio
            {// provisorio
                vista_administrador vista_Administrador = new vista_administrador();
                vista_Administrador.Show();
                this.Hide();
            }// provisorio
            if (username_txtbox.Text == "alumno")
            {
                vista_alumno vista_Alumno = new vista_alumno();
                vista_Alumno.Show();
                this.Hide();
            }
            
            // si corresponde a un alumno

        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
