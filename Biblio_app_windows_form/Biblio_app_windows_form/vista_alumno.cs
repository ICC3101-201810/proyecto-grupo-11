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
    public partial class vista_alumno : Form
    {
        public event EventHandler<ArrendarLibroEventArgs> OnArrendar;
        


        private void ArrendarLibroButton_Click(object sender, EventArgs e)
        {
            ArrendarLibroEventArgs arriendo = new ArrendarLibroEventArgs();
            arriendo.titulo = this.seleccionar_libro_cbbox.Text;
        }

        public void ActualizarLibros(string nuevoLibro)
        {
            
            seleccionar_libro_cbbox.Items.Add(nuevoLibro);
            
        }

        public vista_alumno()
        {
            InitializeComponent();
            tipo_usuario_label.Text = "Alumno";
            nombre_usuario_label.Text = "Prueba";
            
        }

        private void devolver_btn_Click(object sender, EventArgs e)
        {
            // revisar la deuda, aunque el boton deberia estar inactivo si el usuario no selecciona pagar
            // devolver el libro
            // quitar de la lista de libros arrendados
        }

        private void pagar_deuda_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (pagar_deuda_chkbox.Checked == true)
            {
                devolver_btn.Enabled = true;
                renovar_btn.Enabled = true;
            }
            if (pagar_deuda_chkbox.Checked == false & deuda_txtbox.Text != "0")
            {
                devolver_btn.Enabled = false;
                renovar_btn.Enabled = false;
            }
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            string busqueda = busqueda_txtbox.Text;
            // Desde aqui es para probar:
            List<Libro> libros = new List<Libro>(); // temporal, después hay que ver como pasarle la lista filtrada
            List<string> palabras = new List<string> { "muy bueno", "espectacular" };
            Ubicacion tercer_piso = new Ubicacion("norte", 3, 5, 2);
            Libro baldor = new Libro("Ingenieria", 3, "Al Juarismi", "1986", 8, palabras, tercer_piso, "Baldor. Algebra");
            libros.Add(baldor);
            // hasta aqui es de prueba

            // Se revisan los libros segun el criterio de busqueda:
            string filtro = filtro_cbbox.Text;
            List<Libro> libros_a_mostrar = new List<Libro>();
            List<Libro> libros_a_mostrar_primero = new List<Libro>();
            List<Libro> libros_a_mostrar_ultimo = new List<Libro>();

            foreach (Libro lib in libros)
            {
                if (lib.Titulos == filtro)
                {
                    libros_a_mostrar_primero.Add(lib);
                }
                else
                    libros_a_mostrar_ultimo.Add(lib);
            }

            foreach (Libro lib in libros_a_mostrar_primero)
            {
                libros_a_mostrar.Add(lib);
            }
            foreach (Libro lib in libros_a_mostrar_ultimo)
            {
                libros_a_mostrar.Add(lib);
            }

            vista_busqueda vista_Busqueda = new vista_busqueda(busqueda, libros_a_mostrar);
            //abrir ventana de resultados de busqueda
        }

        private void cerrar_sesion_btn_Click(object sender, EventArgs e)
        {
            vista_alumno vista2 = new vista_alumno();
            vista_administrador vista = new vista_administrador(vista2);
            inicio_sesion i_s = new inicio_sesion();
            Controller controlador = new Controller(vista, vista2, i_s);
            i_s.abrir_inicio();
            //i_s.Show();
            this.Close();
            //abrir_inicio();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void renovar_btn_Click(object sender, EventArgs e)
        {
            if (OnArrendar != null)
            {
                ArrendarLibroEventArgs arriendo = new ArrendarLibroEventArgs();
                arriendo.titulo = this.seleccionar_libro_cbbox.Text;
                OnArrendar(this, arriendo);
                MessageBox.Show("Arriendo exitoso");
            }
        }
    }
}
