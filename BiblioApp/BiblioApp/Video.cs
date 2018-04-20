using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    public class Video : MaterialEducativo, IUbicable
    {
        int Stock;

        public Video(int MiStock, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, string MiCarrecaAsociada, Ubicacion[] MiUbicacion)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarrecaAsociada, MiUbicacion)
        {
            Stock = MiStock;
        }
    }
}
