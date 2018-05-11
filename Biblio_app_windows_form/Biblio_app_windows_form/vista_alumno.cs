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
        public vista_alumno()
        {
            InitializeComponent();
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
    }
}
