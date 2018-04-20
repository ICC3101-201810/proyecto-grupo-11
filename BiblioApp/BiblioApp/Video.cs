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

        public string MostrarUbicacion()
        {
            string resultado = "";

            foreach (Ubicacion a in GetUbicacion())
            {
                if (GetUbicacion()[0] == a)
                {
                    resultado += "Sector: " + a + "\n";
                }

                else if (GetUbicacion()[1] == a)
                {
                    resultado += "Piso: " + a + "\n";
                }

                if (GetUbicacion()[2] == a)
                {
                    resultado += "Librero: " + a + "\n";
                }

                if (GetUbicacion()[3] == a)
                {
                    resultado += "Estante: " + a + "\n";
                }
            }

            return resultado;
        }
    }
}
