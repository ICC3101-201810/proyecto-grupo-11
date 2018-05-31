using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    public class Ubicacion
    {
        internal string Sector { get; set; }
        internal int Piso { get; set; }
        internal int Librero { get; set; }
        internal int Estante { get; set; }

        public Ubicacion(string MiSector, int MiPiso, int MiLibrero, int MiEstante)
        {
            Sector = MiSector;
            Piso = MiPiso;
            Librero = MiLibrero;
            Estante = MiEstante;
        }
        
    }
}
