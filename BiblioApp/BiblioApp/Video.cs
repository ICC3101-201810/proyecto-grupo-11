using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    class Video : MaterialEducativo
    {
        int Stock;

        public Video(int MiStock, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, string MiCarrecaAsociada)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarrecaAsociada)
        {
            Stock = MiStock;
        }
    }
}
