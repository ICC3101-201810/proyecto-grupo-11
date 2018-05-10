using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BiblioApp
{
    class Program
    {
        public static List<Persona> usuarios;
        public static List<Persona> alumnos;
        public static List<Persona> profesores;
        public static List<Persona> administradores;

        static void Main(string[] args)
        {
            usuarios = new List<Persona>();
            alumnos = new List<Persona>();
            profesores = new List<Persona>();
            administradores = new List<Persona>();

            string eleccion;
            
            VERDE("Biblio app\n");
            bool correr_programa = true;
            while (correr_programa)
            {
                ESCRIBIR_CONSOLA("1. Iniciar sesion.\n2. Nuevo usuario.\n3. Salir.\nSeleccione: ");
                eleccion = LEER_CONSOLA();
                while(Int32.Parse(eleccion) < 1 || Int32.Parse(eleccion) > 3)
                {
                    Console.Clear();
                    ROJO("Seleccione una opcion correcta\n");
                    ESCRIBIR_CONSOLA("1. Iniciar sesion.\n2. Nuevo usuario.\n3. Salir.\nSeleccione: ");
                    eleccion = LEER_CONSOLA();
                }
                if (eleccion == "1")
                {
                    bool inicio_sesion = LogIn(usuarios);
                    if (inicio_sesion == true)
                    {
                        VERDE("LogIn exitoso.\n");
                        Console.Clear();
                    }

                }//iniciar sesion
                if (eleccion == "2")
                {
                    if (SignIn(usuarios))
                    {
                        VERDE("Usuario creado!\n");
                    }
                }//crear usuario
                if (eleccion == "3")
                {
                    correr_programa = false;
                }//salir
            }
            
            
        }

        static void ESCRIBIR_CONSOLA(string mensaje)
        {
            Console.Write(mensaje);
        }
        static string LEER_CONSOLA()
        {
            return Console.ReadLine();
        }
        static void ROJO(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(mensaje);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void AMARILLO(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(mensaje);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void AZUL(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(mensaje);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void VERDE(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(mensaje);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void GRIS(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(mensaje);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static bool LogIn(List<Persona> usuarios)
        {
            string nombre_usuario, password_usuario;
            ESCRIBIR_CONSOLA("Nombre de usuario: ");
            nombre_usuario = LEER_CONSOLA();
            while (RevisarUsername(nombre_usuario, usuarios) == false)
            {
                ROJO("Error, nombre de usuario incorrecto. Ingrese 0 para volver.\n");
                ESCRIBIR_CONSOLA("Nombre de usuario: ");
                nombre_usuario = LEER_CONSOLA();
                if (nombre_usuario == "0")
                {
                    return false;
                }
            }
            ESCRIBIR_CONSOLA("Password: ");
            password_usuario = LEER_CONSOLA();
            while (RevisarPassword(password_usuario, usuarios) == false)
            {
                ROJO("Error, password incorrecto. Ingrese 0 para volver.\n");
                ESCRIBIR_CONSOLA("Password: ");
                password_usuario = LEER_CONSOLA();
                if (password_usuario == "0")
                {
                    return false;
                }
            }
            return true;
        }
        static bool SignIn(List<Persona> usuarios)
        {
            ESCRIBIR_CONSOLA("Nombre: ");
            string nombre = LEER_CONSOLA();
            ESCRIBIR_CONSOLA("Apellido: ");
            string apellido = LEER_CONSOLA();
            ESCRIBIR_CONSOLA("RUT: ");
            string rut = LEER_CONSOLA();
            ESCRIBIR_CONSOLA("Username: ");
            string username = LEER_CONSOLA();
            while (username == "")
            {
                ROJO("Invalid username.\n");
                ESCRIBIR_CONSOLA("Username: ");
                username = LEER_CONSOLA();
            }
            ESCRIBIR_CONSOLA("Password: ");
            string password = LEER_CONSOLA();
            while (password == "")
            {
                ROJO("Invalid username.\n");
                ESCRIBIR_CONSOLA("Username: ");
                password = LEER_CONSOLA();
            }
            Persona NewUser = new Persona(nombre, apellido, rut, username, password);
            if (RevisarPersona(usuarios, NewUser))
            {
                usuarios.Add(NewUser);
                return true;
            }
            return false;
        }

        static bool RevisarUsername(string Username, List<Persona> usuarios)
        {
            foreach (Persona usuario in usuarios)
            {
                if (usuario.GetUsername() == Username)
                {
                    return true;
                }
            }
            return false;
        }
        static bool RevisarPassword(string password, List<Persona> usuarios)
        {
            foreach (Persona usuario in usuarios)
            {
                if (usuario.GetPassword() == password)
                {
                    return true;
                }
            }
            return false;
        }
        static bool RevisarPersona(List<Persona> personas, Persona new_persona)
        {
            if (personas.Contains(new_persona))
            {
                return false;
            }
            return true;
        }
    }
}
