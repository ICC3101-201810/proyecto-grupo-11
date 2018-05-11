using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    public class Libro : MaterialEducativo
    {
        string Titulo { get; set; }
        
        public int Copia { get; set; }

        public Libro(string MiCarreraAsociada, int MiCopia, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, Ubicacion[] MiUbicacion, string MiTitulo)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarreraAsociada, MiUbicacion)
        {
            
            Copia = MiCopia;
            Titulo = MiTitulo;
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
                    resultado += "Piso: " + a.ToString() + "\n";
                }

                else if (GetUbicacion()[2] == a)
                {
                    resultado += "Librero: " + a.ToString() + "\n";
                }

                else if (GetUbicacion()[3] == a)
                {
                    resultado += "Estante: " + a.ToString() + "\n";
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
        
        public string Titulos
        {
            get
            {
                return Titulo;
            }
            set
            {
                Titulo = value;
            }
        }
    }
}
