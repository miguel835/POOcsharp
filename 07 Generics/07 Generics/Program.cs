using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _07_Generics
{
    /*Generics nos ayuda a reutilizar código y escribir menos lineas*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos un objeto de tipo MiLista
            MiLista<int> numeros = new MiLista<int>(10); //Aqui se pone el tipo de dato con los cuales vamos a trabajar 
            numeros.Agregar(10);
            numeros.Agregar(6);
            //Ahora hacemos para que acepten string
            MiLista<string> strings = new MiLista<string>(10);//Van a ser 10
            strings.Agregar("Miguel");

            //También podemos hacer que la clase MiLista también trabaje sobre personas para así crear
            //objetos personas
            MiLista<Persona> persona = new MiLista<Persona>(5);//Le enviamos 5 al constructor de MiLista
            persona.Agregar(new Persona() { Nombre = "Miguel", País = "Ecuador"});
            persona.Agregar(new Persona() {Nombre = "Juan", País ="Dubai"});

            Console.WriteLine(numeros.ObtenerString());//Vemos como reutilizamos el código con menos lineas 
            Console.WriteLine(strings.ObtenerString());
            Console.WriteLine(persona.ObtenerString());//Pero tenemos el problema que nos devuelve 
            //El siguiente resultado: _07_Generics.Persona|_07_Generics.Persona| eso es porque
            //en la clase Persona no temos un método ToString(), hay un método ToString() por defecto ya 
            //que todas las clases heredan de object  y hay vemos la definición de ToString() que permite
            //sobreescritura de métodos y viendo la definición entendemos porque nos regresa el nombre de la
            //clase

            Console.WriteLine(numeros.ObtenerElemento(11));
            Console.WriteLine(strings.ObtenerElemento(0));
        }
    }
    /* El problema va cuando queremos una clase que tenga la administración de una lista pero de tipo string
    y lo que normalmente lo que la gente hace es copiar el código de la misma clase MiLista y cambiar de 
    int a string, lo cual ese problema resolvemos usando generics 
    Para hacer uso de generics tan solo agregamos un mayor que y un menor que y dentro de estas va una palabra
    alias generalmente se pone T pero se puede poner cualquier palabra como PATO pero siempre debemos especificarlo
    en todas partes
    */
    public class MiLista<T> //Con esto la clase va a poder recibir un tipo de dato
    {
        //Propiedades
        private T[] _elementos; //Ahora este trabaja con cualquier tipo de dato
        private int _index = 0;
        //Constructor
        public MiLista(int n)//Como estamos usando generics en el constructor debe recibir un tipo no un valor 
        {
            _elementos = new T[n];
        }
        //Métodos 
        public void Agregar(T e)
        {
            //Se agregan siempre y cuando los limites no superen la longitud del arreglo
            if (_index < _elementos.Length)
            {
                _elementos[_index] = e;
                _index++;
            }
        }
        //Se puede usar generics también para regresar ejemplo ->
        public T ObtenerElemento(int i)
        {
            //Protegemos de que lo que recibamos sea menor al indice y también sea mayor o igual a cero
            if (i <= _index && i <=0)
            {
                return _elementos[i];
            }
            //¿Qué pasa cuando me envian algo invalido?
            //Hacemos uso de default este ya viene con Generics que en si es un método 
            return default(T); //Retornamos un valor por defecto de un tipo de dato
            //Ejm: el valor por defecto de un entero es cero
        }
        public string ObtenerString()
        {
            int i = 0;
            string resultado = "";
            while (i<_index)
            {
                resultado += _elementos[i].ToString() + "|";
                i++; 
            }
            return resultado;
        }
    }



    //También los generics pueden trabajar con otros objetos 
    public class Persona : Object
    {
        //Propiedades
        public string Nombre { get; set; }
        public string País { get; set; }
        //Métodos
        //Sobreescribimos el método ToString()
        public override string ToString()
        {
            return $"Nombre: {Nombre}, País: {País}";
        }
    }
}