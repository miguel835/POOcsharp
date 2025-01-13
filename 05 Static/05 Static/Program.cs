using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos un objeto tipo People 
            People miguel = new People()
            {
                Name = "Miguel",
                Age = 19
            };

            People hector = new People()
            {
                Name = "Hector",
                Age = 34
            };
            //Count no se puede llamar desde el objeto sino solo desde la clase, es decir Count no necesita una creación
            // de objetos para existir sino que pertenece al tipo y el tipo es la clase, con esto podemos crear un 
            //contador de objetos
            Console.WriteLine(People.Count);
            Console.WriteLine(People.GetCount());
        }
        /* Static es una palabra reservada que nos permite hacer algo sea perteneciente al tipo, es decir nosotros 
        creamos clases para crear objetos, estas clases tienen métodos, propiedades y atributos y para usar estas cosas 
        debemos crear el objeto.
        Pero con la palabra static no tenemos la necestdad de crear el objeto ya que static va a pertenecer a la 
        clase 
        Con static podemos agregar una propiedad que pertenezca a la clase y no al objeto, es decir una propiedad en la
        cual yo pueda invocar desde la clase y no desde el objeto
        */
        public class People
        {
            public static int Count = 0;
            //Propiedades
            public string Name { get; set; }
            public int Age { get; set; }
            //Constructor
            public People()
            {
                Count++;
            }
            //static tambien se puede usar con metodos
            public static string GetCount()
            {
                //Hacemos que nos devuelva una interpolación de cadenas
                return $"Esta clase se ha utilizado {Count} veces";
            }

        }

        //Static tambien se puede aplicar a la clase misma y esto significa que todos los metodos y propiedades de la
        //clase deben ser estaticas
        /*De que me sirve esto ->  Quizas se necesite solo una clase que tenga funcionalidades, es decir sumatorias,
         numeros complejos, pero que no necesito crear un objeto*/
        public static class A
        {
            //Todo debe ser static
            public static void Some()
            {
                Console.WriteLine("algo");
            }
        }
    }
}
