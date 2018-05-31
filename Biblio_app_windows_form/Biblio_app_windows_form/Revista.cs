using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    public class Revista : MaterialEducativo
    {
        int Copia;

        public Revista(int MiCopia, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, string MiCarreraAsociada, Ubicacion MiUbicacion)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarreraAsociada, MiUbicacion)
        {
            Copia = MiCopia;
        }

        public string MostrarUbicacion()
        {
            string resultado = "";

            resultado += "Sector: " + GetUbicacion().Sector + "\n";
            resultado += "Piso: " + GetUbicacion().Piso + "\n";
            resultado += "Librero: " + GetUbicacion().Librero + "\n";
            resultado += "Estante: " + GetUbicacion().Estante + "\n";

            return resultado;
        }

        public int Copias
        {
            get
            {
                return Copia;
            }
            set
            {
                Copia = value;
            }
        }
    }
}
