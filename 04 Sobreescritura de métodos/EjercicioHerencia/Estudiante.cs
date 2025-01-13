using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Estudiante : Persona
    {
        //Propiedad
        public int nivel;
        public string carrera; 
        //Metodo constructor
        public Estudiante(string nombre, int edad, int Nivel, string Carrera) : base (nombre, edad)
        {
            nivel = Nivel;
            carrera = Carrera;
        }
        //Le ponemos override para reescribir
        public override void Imprimir()
        {
            Console.WriteLine($"Nombre = {nombre} : Edad = {edad} : Nivel = {nivel} : Carrera = {carrera}");
        }
    }
}
