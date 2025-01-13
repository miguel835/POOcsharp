using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objeto Doctor1
            Doctor doctor1 = new Doctor("Juan", 40, "Cardiologo");
            Console.WriteLine(doctor1.GetInfo());
            Console.WriteLine(doctor1.GetData());
            //Objeto Dev1
            Dev dev1 = new Dev("Miguel", 18, "C#");
            Console.WriteLine(dev1.GetInfo());
            Console.WriteLine(dev1.GetData());
        }
    }
    /*Herencia es una clase pueda herederar las caracteristicas de otras clases
    Si tenemos a un doctor y a un desarrollador de software que es lo que relaciona a estas dos entidades
    es que ambas son personas, pero un doctor hara cosas distintas a una dev y viceversa. 
    La acción de esas cosas es que son personas esto es abstraer funcionalidades*/
    class People
    {
        //Atributos 
        private string _name; //Como buena practica siempre los atributos privados los ponemos guion bajo en c#
        private int _age;
        //Constructor
        public People(string name, int age)
        {
            _name = name;
            _age = age;
        }
        //Metodos
        public string GetInfo()
        {
            return _name + " " + _age;
            /*En los metodos es mejor hacer return ya que despues podemos usarlo para más cosas y no limitamos
             al programa*/
        }
        /*Si en vez de public ponemos protected entonces no podemos acceder en el Main al metodo pero si 
         en la clase que esta heredando
        Cuando es private tan solo podremos usarlo dentro de la clase People, no en el Main ni en la clase que 
        esta heredando*/
    }
    
    //Creamos la clase doctor y heredamos las cualidades de la clase People 
    class Doctor : People
    {
        /*En c# tan solo se puede heredar de una sola clase
        Como la clase people tiene un constructor que tiene como parametro a name y age.
        Entonces para solucionar eso creamos un constructor de Doctor que reciba esos dos valores
        CUANDO HACEMOS HERENCIA LOS OBJETOS QUE CREEMOS DE LA CLASE DOCTOR VAN A TENER LOS ATRIBUTOS DE LA CLASE
        PEOPLE*/
        //Para mandar los atributos del objeto doctor a la clase people ponemos : base(atributos)

        //Atributos
        private string _speciality;
        //La clase doctor vendria a ser una clase hija que hereda de la clase base  o tambien llama clase padre
        public Doctor(string name, int age, string speciality) : base(name, age)
        {
            //Los parametros en el constructor son los que reciben y luego de recibir se los va a enviar 
            //a su padre People. Obviamente debe ser en el orden del constructor del padre. 
            _speciality=speciality;
        }

        public string GetData()
        {
            return GetInfo() + " " + _speciality;
        }
    }

    class Dev : People
    {
        //Atributos
        private string _language;
        //Constructor
        public Dev(string name, int age, string language) : base(name, age)
        {
            _language = language;
        }
        //Metodos
        public string GetData()
        {
            return GetInfo() + " " + _language;
        }
    }
}
