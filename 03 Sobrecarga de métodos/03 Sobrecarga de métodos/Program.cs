using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sobrecarga_de_métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.Sum(1,2));
            Console.WriteLine(math.Sum("1","2"));
            int[] numbers = new int[] { 1, 2, 3 };
            Console.WriteLine(math.Sum(numbers));
        }
        /*La sobrecarga de metodos es la capacidad que tienen las clases para tener metodos con el mismo nombre pero
        con distintos parametros. Ejm: Metodo a que recibe un entero, entonces tambien se puede tener otro Metodo
        a que recibe un string. 
        La sobrecarga se da solo en que se recibe mas no en lo que regresamos*/
    }
    class Math
    {
        //Metodos 
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }
        public int Sum(int[] numbers)
        {
            int result = 0;
            int i = 0;
            while (i < numbers.Length)
            {
                result += numbers[i];
                i++;
            }
            return result;
        }
    }
}
