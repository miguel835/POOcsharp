using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Formato_JSON
{
    /* ¿Qué es JSON?
    Es un formato de texto que nos va a servir a traducir un objeto a una cadena o caracteres, este formato
    tiene una especificación y es muy sencilla.
    Se usa JSON porque sirve para traducir un objeto y se pueda pasar a otros lenguajes de programación o puedas
    pasarlo por la red, es decir, JSON es un traductor una representación de los valores de tus objetos, o te estas
    conectando a un servicio este formato es por donde tu puedes mandar sin problema ya que los lenguajes de 
    programación tienen herramientas para leer este formato JSON y a partir de este formato tu puedas convertir al
    objeto al lenguaje de programación que sea, pero como se conecta C# con Javascript por ejemplo el JSON  es el 
    traductor, es el medio por el que se pueda entender los lenguajes.
    JSON puede representar objetos y también una colección de objetos
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos un objeto de tipo Cerveza
            Cerveza micerveza = new Cerveza()
            {
                Nombre = "Pikantus",
                Marca = "Erdinger"
            };
            //Especificación de JSON para los objetos
            //Cuando vemos "{}" esto en JSON es un objeto
            string json = "{\"Nombre\": \"Pikantus\",\"Marca\": \"Erdinger\"}";
            //Se ponen \ para decir que respete las comillas de adentro, esto es por C#
            //Se ponen , para especificar un nuevo atributo


            //Colección de objetos
            Cerveza[] cervezas = new Cerveza[] {
                new Cerveza()
                {
                    Nombre = "Pikantus",
                    Marca = "Erdinger"
                },
                new Cerveza()
                {
                    Nombre = "Corona",
                    Marca = "Modelo"
                }
            };
            //Así se representan una colección de objetos o arreglos y se comienzan con corchetes
            string json2 = "[" +
                "{\"Nombre\": \"Pikantus\", \"Marca\": \"Erdinger\"}," + 
                "{\"Nombre\": \"Corona\", \"Marca\": \"Modelo\"}" + 
                "]";
            //Y este json se lo mando a un lenguaje como Javascript, Java y estos lenguajes van a tener herramientas
            //para convertir este formato sin importar que venga de C# a un objeto de Java, Javascript
            //Para eso sirve JSON para comunicarse con otros medios o terceros 
        }
    }

    public class Cerveza
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Marca { get; set; }
    }
}
