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
