using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Las interfaces las podemos entender como un contrato que una clase debe implementar  
esta interfaz tiene que respetar y cumplir este contrato, los contratos tienen anexos y 
en la POO los anexos vienen siendo propiedades y métodos 
Si se desea implementar un interfaz tiene que cumplir con los métodos y las propiedades que
este lo obliga a cumplir 
Las interfaces un término abstracto de POO que lo implementar varios lenguajes de programación, 
estas son las bases de patrones de diseño.
Las interfaces más de cumplir un contrato le da una clase una categorización, un contrato, pero 
esta categoria de esta clase que no sea una, ejemplo cuando tenemos una clase y heredamos de otra 
clase solo podemos heredar una vez, pero con las interfaces podemos implementar las interfaces que
deseemos
Las interfaces permiten categorizar los objetos*/
namespace _06_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de tiburones
            Tiburon[] tiburones = new Tiburon[]
            {
                //Objetos
                new Tiburon("Tiburonsin",56),
                new Tiburon("Jaws",65)
            };
            //Arreglo de pescados
            IPescado[] pescado = new IPescado[] //El new IPescado[] es solo una capsula de arreglos 
            {
                //Las interfaces no sirven para crear objetos, sino para darle una categorización al objeto
                new Sirena(100),//Los objetos son los que están adentro 
                new Tiburon("Tiburonsin",56)
                //Como nos damos cuenta que podemos tener un arreglos de pescado el cual pueda recibir todos
                //los objetos que se creen con la clase que implemente Pescado
                //Lo que no se pueden es crear objetos directamente de la interfaz ejm: new Ipescado(100);
            };
            /*
             También se puede hacer esto 
            IPescado[] pescado = new Siren[]  
            pero solo estaría aceptando a que se creen objetos que sean Sirena y no puedo crear objetos
            que sean otra cosa
            */

            /* Si hacemos esto IPescado f = new Tiburon("Tiburon",40)
             pero lo que sucede es que f se comporta como pescado más no como tiburon por ende estamos limitado
            a eso al acceder a sus propiedades y métodos
             */

            //Llamamos al método MostrarPescado
            MostrarPescado(tiburones); //A pesar de que Tiburon es una clase si puede ser Pescado porque 
            //implementan interfaces
            //Llamamos al método MostrarAnimales
            MostrarAnimales(tiburones);
            MostrarPescado(pescado);
        }
        //Método que solo trabaje con objetos que sean pescado
        public static void MostrarPescado(IPescado[] pescados)
        {
            //¿Quién define un pescado? La interfaz
            Console.WriteLine("--Mostramos los peces--");
            int i = 0;
            while (i < pescados.Length)
            {
                Console.WriteLine(pescados[i].Nadar());
                i++;
            }
        }
        //Método que solo trabaje con objetos que sean animales
        public static void MostrarAnimales(IAnimal[] animal)
        {
            //¿Quién define un pescado? La interfaz
            Console.WriteLine("--Mostramos los animales--");
            int i = 0;
            while (i < animal.Length)
            {
                Console.WriteLine(animal[i].nombre);
                i++;
            }
        }
    }
    //Clase
    public class Sirena: IPescado
    {
        /* El chiste de las interfaces es que te obligan a poner eso porque tu vas a ejecutar esos objetos
         en algunos métodos que necesites esas propiedades y esos métodos, de esta forma estamos obligando
        y estamos haciendo una buena práctica y otra es que es útil cuando se trabaja en equipo (convención
        de código)
         */
        public int Velocidad { get; set; }
        //Constructor
        public Sirena(int Velocidad)
        {
            this.Velocidad = Velocidad;
        }
        public string Nadar()
        {
            return $"La sirena nada a {Velocidad} Km/h";
        }
    }
    public class Tiburon : IAnimal, IPescado //Un tiburón es un animal y también un pescado
    {
        public string nombre { get;set; }
        public int Velocidad { get; set; }
        //Constructor
        public Tiburon(string nombre, int Velocidad)
        {
            this.nombre = nombre;
            this.Velocidad = Velocidad;
        }
        public string Nadar()//Siempre debemos implementar los métodos para que se quite el error
        {
            return $"{nombre} Nada {Velocidad} Km/h";
        }
    }
    //Interfaces 
    public interface IAnimal //Debemos ver lo que tienen todos los animales como el nombre
    {
        //Anexos, toda clase que implemente esta interfaz debe cumplir con este anexo
        public string nombre { get; set; }
    }
    public interface IPescado
    {
        //Anexos
        public int Velocidad { get; set; }//Todos sabemos que si los pescados nadan tienen una velocidad
        public string Nadar(); //Creamos un método pero no lo implementamos
        //Si queremos implementar la interfaz pescado debes tener la propiedad Velocidad y debes tener un 
        //método llamado Nadar();
    }
}
