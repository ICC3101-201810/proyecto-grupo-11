using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    class Libro : MaterialEducativo
    {
        string Tomo;
        int Copia;

        public Libro(string MiCarreraAsociada, string MiTomo, int MiCopia, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarreraAsociada)
        {
            Tomo = MiTomo;
            Copia = MiCopia;
        }

    }
}
