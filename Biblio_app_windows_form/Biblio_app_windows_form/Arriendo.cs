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
        DateTime FechaArriendo;
        Alumno alumno;
        Libro libro;

        public Arriendo(DateTime MiFechaArriendo, Alumno MiAlumno, Libro MiLibro)
        {
            FechaArriendo = MiFechaArriendo;
            alumno = MiAlumno;
            libro = MiLibro;
        }
    }
}
