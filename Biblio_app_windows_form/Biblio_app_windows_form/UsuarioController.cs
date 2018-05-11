using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    class UsuarioController
    {
        Libro libro;
        vista_alumno vista_Alumno;

        public UsuarioController(vista_alumno vista_Alumno)
        {
            this.vista_Alumno = vista_Alumno;
            this.vista_Alumno.OnArrendar += Vista_Alumno_OnArrendar;
        }

        private void Vista_Alumno_OnArrendar(object sender, ArrendarLibroEventArgs e)
        {
            if(libro.Titulos == e.titulo && libro.Copia > 0 )
            {
                libro.Copia--;                
            }            
        }
    }
}
