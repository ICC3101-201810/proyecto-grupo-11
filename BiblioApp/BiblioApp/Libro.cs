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
