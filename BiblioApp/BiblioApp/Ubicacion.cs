using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    class Ubicacion
    {
        string Sector;
        int Piso;
        int Librero;
        int Estante;

        public Ubicacion(string MiSector, int MiPiso, int MiLibrero, int MiEstante)
        {
            Sector = MiSector;
            Piso = MiPiso;
            Librero = MiLibrero;
            Estante = MiEstante;
        }


    }
}
