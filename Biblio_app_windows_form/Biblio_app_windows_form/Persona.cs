using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_app_windows_form
{
    [Serializable]
    public class Persona
    {
        internal string Nombre { get; set; }
        internal string Apellido { get; set; }
        public string Rut { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        internal bool sesion { get; set; }

        public Persona(string miNombre, string miApellido, string miRut, string miUsuario, string miPassword)
        {
            Nombre = miNombre;
            Apellido = miApellido;
            Rut = miRut;
            Usuario = miUsuario;
            Password = miPassword;
            sesion = false;
        }

        public string GetUsername()
        {
            return Usuario;
        }
        public string GetPassword()
        {
            return Password;
        }
        public bool GetSesion()
        {
            return sesion;
        }
    }
}
