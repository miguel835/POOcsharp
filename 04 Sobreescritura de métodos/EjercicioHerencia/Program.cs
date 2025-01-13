using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pantalla();
            Persona persona1 = new Persona("Miguel", 19);
            Estudiante estudiante1 = new Estudiante("Jasmani", 20, 5, "Software");
            persona1.Imprimir();
            estudiante1.Imprimir();
            Console.ReadKey();
        }
        static void Pantalla()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.SetCursorPosition(10,0);
            Console.WriteLine("Ejercicio de Herencia 10/01/2025\n");
        }
    }
}
