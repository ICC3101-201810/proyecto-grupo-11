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
    public partial class vista_busqueda : Form
    {
        public vista_busqueda(string mi_busqueda, List<Libro> mi_libros)
        {
            busqueda_txtbox.Text = mi_busqueda;
            foreach (Libro libro in mi_libros)
            {
                resultados_listbox.Items.Add(libro);
            }
            
            InitializeComponent();
        }

        private void arrendar_btn_Click(object sender, EventArgs e)
        {

        }

        
    }
}
