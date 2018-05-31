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

        public Libro(string MiCarreraAsociada, int MiCopia, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, Ubicacion MiUbicacion, string MiTitulo)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarreraAsociada, MiUbicacion)
        {
            
            Copia = MiCopia;
            Titulo = MiTitulo;
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
