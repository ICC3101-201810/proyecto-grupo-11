﻿using System;
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
        float Calificacion;
        List<string> Comentario;
        string CarreraAsociada;
        Ubicacion Ubicacion;
        int numero_calificaciones = 1;

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

        public string GetUbicacionString()
        {
            if (Ubicacion != null)
                return "Sector: " + Ubicacion.Sector + ". Piso: " + Ubicacion.Piso.ToString() + ". Librero: " + Ubicacion.Librero.ToString() + ". Estante: " + Ubicacion.Estante.ToString();
            else
                return "";
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

        public void AgregarComentario(string comentario)
        {
            Comentario.Add(comentario);
        }

        public float GetCalificacion()
        {
            return Calificacion;
        }

        public string GetCarreraAsociada()
        {
            return CarreraAsociada;
        }

        public string GetFechaPublicacion()
        {
            return FechaCreacion;
        }

        public void AgregarCalificacion(int nueva_calificacion)
        {
            numero_calificaciones++;
            Calificacion += nueva_calificacion / (float)numero_calificaciones;
        }
    }

}
