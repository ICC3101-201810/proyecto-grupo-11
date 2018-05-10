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

        public Revista(int MiCopia, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, string MiCarreraAsociada, Ubicacion[] MiUbicacion)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarreraAsociada, MiUbicacion)
        {
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

                else if (GetUbicacion()[2] == a)
                {
                    resultado += "Librero: " + a + "\n";
                }

                else if (GetUbicacion()[3] == a)
                {
                    resultado += "Estante: " + a + "\n";
                }
            }

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
