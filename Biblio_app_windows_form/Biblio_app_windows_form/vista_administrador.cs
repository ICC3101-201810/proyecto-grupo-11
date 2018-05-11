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
    public partial class vista_administrador : Form
    {
        public event EventHandler<AgregarUsuarioEventArgs> OnAgregarUsuario;
        public event EventHandler<AgregarLibroEventArgs> OnAgregarLibro;

        private void CrearNuevoUsuarioButton_Click(object sender, EventArgs e)
        {
            if(OnAgregarUsuario != null)
            {
                AgregarUsuarioEventArgs usuarioArgs = new AgregarUsuarioEventArgs();
                usuarioArgs.Nombre = this.nombre_txtbox.Text;
                usuarioArgs.Apellido = this.apellido_txtbox.Text;
                usuarioArgs.Rut = this.rut_txtbox.Text+"-"+this.dgt_ver_txtbox.Text;
                usuarioArgs.Usuario = this.new_username_txtbox.Text;
                usuarioArgs.Password = this.new_password_txtbox.Text;
                OnAgregarUsuario(this, usuarioArgs);
            }
        }

        private void AgregarLibroButton_Click(object sender, EventArgs e)
        {
            if (OnAgregarLibro != null)
            {
                AgregarLibroEventArgs libroArgs = new AgregarLibroEventArgs();
                libroArgs.Titulo = this.titulo_txtbox.Text;
                libroArgs.Autor = this.autor_txtbox.Text;
                libroArgs.Copia = Int32.Parse(this.copias_txtbox.Text);
                OnAgregarLibro(this, libroArgs);
            }
        }

        public vista_administrador()
        {
            InitializeComponent();
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
