using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    public class vista_administrador_1 : vista_administrador
    {
        public event EventHandler<AgregarUsuarioEventArgs> OnAgregarUsuario;
    }
}
