﻿using System;
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
        public string CarreraAsociada { get; set; }
        public string FechaCreacion { get; set; }
        public int piso { get; set; }
        public string zona { get; set; }
        public int librero { get; set; }
        public int estante { get; set; }
    }
}
