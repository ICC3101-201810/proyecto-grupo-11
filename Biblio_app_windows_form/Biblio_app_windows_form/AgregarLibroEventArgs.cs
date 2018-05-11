using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    public class AgregarLibroEventArgs : EventArgs
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Copia { get; set; }
    }
}
