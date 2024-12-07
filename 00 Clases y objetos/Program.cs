using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_objetos
{
    //Clase Program 
    internal class Program
    {
        //Metodo 
        static void Main(string[] args)
        {
            //Para poder usar la clase debemos usar un objeto de la clase a usar 
            //Es como hacer int number = 1;
            Persona persona = new Persona("Miguel", 18);
            //Luego de esto ya podemos usar la clase y sus metodos 
            persona.SayHello();
            Console.WriteLine("¿Deseas conocer mi nombre y mi edad?");
            var answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes") Console.WriteLine(persona.GetInfo());
            else Console.WriteLine("It's ok");

            //Creamos otro objeto, podemos crear tantos objetos como queramos 
            Persona persona1 = new Persona("David", 18);
            Console.WriteLine("Tengo además un amigo que tiene los siguientes datos: \n" + persona1.GetInfo());

            Console.ReadKey();
        }
    }
    /*
    POO es el más utilizado ya que es tener clases y objetos
    Un objeto es una representación de una entidad que tiene propiedades y tiene funcionalidades
    Es decir un carro tiene propiedades tiene un color, tipo de motor 
    y tiene funcionalidades como prender, frenar, correr, etc. Un objeto es eso. 
    Una clase es el molde que nos sirve para crear estos objetos, la clase es la definición para crear 
    estos objetos es muy parecido al tipo de dato que usamos como int, string, bool pero la diferencia es 
    que nosotros especificar el tipo y somos libres de crear nuestro propios tipos en la clase
    */

    //Clase Persona 
    public class Persona
    {
        string name;
        int ago;
        //Creación de un constructor 
        //Un constructor se distingue porque se llama igual que la clase 
        public Persona(string name, int ago)
        {
            //Para realizar la asignación de las variables hacemos lo siguiente
            this.name = name; //El ultimo name es la que la funcion recibe como parametro 
            this.ago = ago;

        }

        //Metodos son lo que puede hacer la clase persona 
        public void SayHello()
        {
            //Este metodo es publico (public) para que asi puede ser usado fuera de la clase 
            //si fuera privada (private) no puede usarse fuera de la clase solo dentro de esta. 
            Console.WriteLine("Hola soy una persona de alguna parte del mundo");
        }

        public string GetInfo()
        {
            return name + " " + ago;
        }
    }
}
