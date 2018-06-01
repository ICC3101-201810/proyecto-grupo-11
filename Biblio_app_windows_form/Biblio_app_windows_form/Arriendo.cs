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
        List<DateTime> FechaArriendo;
        Alumno alumno;
        List<Libro> libro;

        public Arriendo(Alumno MiAlumno)
        {
            FechaArriendo = new List<DateTime>();
            alumno = MiAlumno;
            libro = new List<Libro>();
        }
    }
}
