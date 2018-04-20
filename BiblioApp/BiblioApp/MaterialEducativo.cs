using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    class MaterialEducativo
    {
        string Autor;
        string FechaCreacion;
        int Calificacion;
        List<string> Comentario;
        string CarreraAsociada;

        public MaterialEducativo(string MiAutor, string MiFechaCreacion, int MiCalificacion, List<string> MiComentario, string MiCarreraAsociada)
        {
            Autor = MiAutor;
            FechaCreacion = MiFechaCreacion;
            Calificacion = MiCalificacion;
            Comentario = new List<string>(MiComentario);
            CarreraAsociada = MiCarreraAsociada;
        }


    }
}
