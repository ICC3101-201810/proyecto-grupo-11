using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    public class DevolverLibroEventArgs
    {
        public int row { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
    }
}
