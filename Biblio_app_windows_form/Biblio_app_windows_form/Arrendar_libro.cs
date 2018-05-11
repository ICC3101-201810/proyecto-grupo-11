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
    public partial class Arrendar_libro : Form
    {
        public Arrendar_libro()
        {
            InitializeComponent();
        }

        private void volver_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arrendar_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Libro arrendado con éxito.");
            this.Close();
        }
    }
}
