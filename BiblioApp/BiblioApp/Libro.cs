using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    public class Libro : MaterialEducativo, IUbicable
    {
        string Tomo;
        int Copia;

        public Libro(string MiCarreraAsociada, string MiTomo, int MiCopia, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, Ubicacion[] MiUbicacion)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarreraAsociada, MiUbicacion)
        {
            Tomo = MiTomo;
            Copia = MiCopia;
        }

        public string MostrarUbicacion()
        {

        }

    }
}
