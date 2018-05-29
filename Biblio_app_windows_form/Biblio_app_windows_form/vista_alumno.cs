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

        public void ActualizarLibros(Libro nuevoLibro)
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
            string filtro = filtro_cbbox.Text;
            //abrir ventana de resultados de busqueda
        }

        private void cerrar_sesion_btn_Click(object sender, EventArgs e)
        {
            vista_administrador vista = new vista_administrador();
            vista_alumno vista2 = new vista_alumno();
            inicio_sesion i_s = new inicio_sesion();
            Controller controlador = new Controller(vista, vista2, i_s);
            i_s.Show();
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
