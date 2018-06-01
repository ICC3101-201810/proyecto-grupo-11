using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    [Serializable]
    public class Arriendo
    {
        internal List<DateTime> FechaArriendo { get; set; }
        internal Alumno alumno { get; set; }
        internal List<Libro> libro { get; set; }

        public Arriendo(Alumno MiAlumno)
        {
            FechaArriendo = new List<DateTime>();
            alumno = MiAlumno;
            libro = new List<Libro>();
        }


    }
}
