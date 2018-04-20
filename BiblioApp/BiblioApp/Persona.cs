using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    class Persona
    {
        string Nombre;
        string Apellido;
        string Rut;
        string Usuario;
        string Password;

        public Persona(string miNombre, string miApellido, string miRut, string miUsuario, string miPassword)
        {
            Nombre = miNombre;
            Apellido = miApellido;
            Rut = miRut;
            Usuario = miUsuario;
            Password = miPassword;
        }

        public string GetUsername()
        {
            return Usuario;
        }
        public string GetPassword()
        {
            return Password;
        }
    }
}
