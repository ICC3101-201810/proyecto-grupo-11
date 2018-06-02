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
    public partial class vista_administrador : Form
    {
        public event EventHandler<AgregarUsuarioEventArgs> OnAgregarUsuario;
        public event EventHandler<AgregarLibroEventArgs> OnAgregarLibro;

        private vista_alumno mainForm = null;

        public vista_administrador(Form callingForm)
        {
            mainForm = callingForm as vista_alumno;
            InitializeComponent();

        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrar_sesion_btn_Click(object sender, EventArgs e)
        {
            vista_alumno vista2 = new vista_alumno();
            vista_administrador vista = new vista_administrador(vista2);
            inicio_sesion i_s = new inicio_sesion();
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
            foreach(Alumno a in alumnos)
            {
                if(a.sesion == true)
                {
                    a.sesion = false;
                }

            }
            using (Stream stream = new FileStream("Alumnos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, alumnos);
                stream.Close();
            }

            foreach (Arriendo ar in arriendos)
            {
                ar.alumno.sesion = false;
            }

            using (Stream stream = new FileStream("Arriendos.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, arriendos);
                stream.Close();

            }
            string busqueda = " ";
            vista_busqueda vista3 = new vista_busqueda(busqueda, libros);
            Controller controlador = new Controller(vista, vista2, i_s, alumnos, libros, arriendos, vista3);
            
            i_s.Show();
            this.Close();
        }

        private void rut_lbl_Click(object sender, EventArgs e)
        {

        }

        private void vista_administrador_Load(object sender, EventArgs e)
        {

        }

        private void agregar_libro_btn_Click(object sender, EventArgs e)
        {
            if (OnAgregarLibro != null)
            {
                AgregarLibroEventArgs libroArgs = new AgregarLibroEventArgs();
                libroArgs.Titulo = this.titulo_txtbox.Text;
                libroArgs.Autor = this.autor_txtbox.Text;
                int number;
                libroArgs.CarreraAsociada = this.CarreraAsociada_txtBox.Text;
                libroArgs.FechaCreacion = this.fecha_pub_txtbox.Text;
                bool result = Int32.TryParse(this.copias_txtbox.Text,out number);
                if (result)
                {
                    libroArgs.Copia = Int32.Parse(this.copias_txtbox.Text);
                    OnAgregarLibro(this, libroArgs);
                    this.mainForm.ActualizarLibros(this.titulo_txtbox.Text);
                    MessageBox.Show("Libro agregado con éxito!");
                }
                else
                {
                    MessageBox.Show("Favor ingrese un numero para el campo 'Copias'");
                }
            }
        }

        private void agreagar_usuario_btn_Click(object sender, EventArgs e)
        {
            if (OnAgregarUsuario != null)
            {
                AgregarUsuarioEventArgs usuarioArgs = new AgregarUsuarioEventArgs();
                usuarioArgs.Nombre = this.nombre_txtbox.Text;
                usuarioArgs.Apellido = this.apellido_txtbox.Text;
                usuarioArgs.Rut = this.rut_txtbox.Text + "-" + this.dgt_ver_txtbox.Text;
                usuarioArgs.Usuario = this.new_username_txtbox.Text;
                usuarioArgs.Password = this.new_password_txtbox.Text;
                OnAgregarUsuario(this, usuarioArgs);
                MessageBox.Show("Usuario creado con éxito!");
                
            }
        }

        
    }
}
