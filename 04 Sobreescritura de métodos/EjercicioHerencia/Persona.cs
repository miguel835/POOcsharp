using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Persona
    {
        //Atributos
        public int edad;
        public string nombre;
        //Metodo Constructor Persona
        public Persona(string Nombre, int Edad)
        {
            nombre = Nombre;
            edad = Edad;
            //Console.WriteLine($"Nombre: {nombre} \t Edad: {edad} años");
        }
        //Metodo imprimir le añadimos virtual para que asi permita sobreescribir
        public virtual void Imprimir()
        {
            Console.WriteLine($"Nombre = {nombre} : Edad = {edad}");
        }
    }
}
