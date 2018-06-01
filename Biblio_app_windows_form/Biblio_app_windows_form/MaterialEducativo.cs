using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    [Serializable]
    public class MaterialEducativo
    {
        string Autor;
        string FechaCreacion;
        int Calificacion;
        List<string> Comentario;
        string CarreraAsociada;
        Ubicacion Ubicacion;

        public MaterialEducativo(string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, string MiCarreraAsociada, Ubicacion MiUbicacion)
        {
            Autor = MiAutor;
            FechaCreacion = MiFechaCreacion;
            Calificacion = MiCalificacion;
            Comentario = new List<string>(MiComentario);
            CarreraAsociada = MiCarreraAsociada;
            Ubicacion = MiUbicacion;
        }

        public Ubicacion GetUbicacion()
        {
            return Ubicacion;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public string MostrarComentarios()
        {
            string resultado = "";

            foreach (string a in Comentario)
            {
                resultado += a + "\n\n";
            }

            return resultado;
        }
    }

}
