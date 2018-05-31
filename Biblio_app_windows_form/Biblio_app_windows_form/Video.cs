using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    public class Video : MaterialEducativo
    {
        int Stock;

        public Video(int MiStock, string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, string MiCarrecaAsociada, Ubicacion MiUbicacion)
            : base(MiAutor, MiFechaCreacion, MiCalificacion, MiComentario, MiCarrecaAsociada, MiUbicacion)
        {
            Stock = MiStock;
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

        public int Stocks
        {
            get
            {
                return Stock;
            }
            set
            {
                Stock = value;
            }
        }
    }
}
