using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioApp
{
    class Program
    {
        static void Main(string[] args)
        {

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
    }
}
