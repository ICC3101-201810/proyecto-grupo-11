using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    class Administrador : Persona
    {
        public Administrador(string miNombre, string miApellido, string miRut, string miUsuario, string miPassword) 
            : base(miNombre, miApellido, miRut, miUsuario, miPassword)
        {

        }
    }
}
