using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _09_Serialización_de_objetos__JSON_
{
    /* C# como otros lenguajes ya tiene herramientas para convertir objetos a formato JSON o de formato JSON a 
     * objetos, la ventaja de tener estas funcionalidades es que no tenemos que hacerlo a mano nosotros simplemente
     * invocamos una función que van a estar en unas clases ya hechas dentro de .NET framework 
     * Para ello instalamos el paquete Newtonsoft.Json porque estamos en .net framework  y agregamos arriba del
     * programa using Newtonsoft.Json; para trabajar con el paquete y comenzar a hacer la serialización de objetos
     * y la deserialización de objetos 
     * Pero si estamos usando .NET Core o también llamado .NET simplemente agregamos arriba del programa esta 
     * linea: System.Text.Json; para hacer uso de la libreria para trabajar con Json
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
            //Hacemos la serialización de objetos, este es el proceso por el cual convertimos un objeto a formato
            //Json 
            string json = JsonConvert.SerializeObject(micerveza);//Converitimos micerveza a formato Json
            //Si estamos en Visual Studio podemos agregar un punto de interrupción en el programa para que así
            //podamos pasar el raton por la variable json y ver los datos.

            //El proceso se llama deserialización 
            Cerveza cerveza = JsonConvert.DeserializeObject<Cerveza>(json);
            //Como nos damos cuenta que DeserializeObject funciona con generics 
            //Lo que va dentro de los parentesis es la cadena que tiene el formato json 


            //También podemos hacerlo con arreglos 
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

            //Serializamos 
            string json2 = JsonConvert.SerializeObject(cervezas); //Esta es la que usamos si queremos enviar información a una aplicación tercera
            //y si hacemos un punto de interrupción vemos que tiene el mismo formato que se hicieron 
            //en el archivo 08 Json 

            //Ahora hacemos a la inversa
            Cerveza[] cervezas1 = JsonConvert.DeserializeObject<Cerveza[]>(json2); //Esta la usamos si queremos recibir información de una aplicación tercera
            //Si queremos hacemos un punto de interrupcion (Debug) vemos los datos pasando el mouse
            //por cervezas1

            /*¿Cómo se manda una información?
             * Eso depende si vas a enviarla a una base de datos, a una solicitud, C# tiene sus propias
             * clases para hacer ese envio pero necesitamos antes convertir los objetos a un formato JSON
             * para que sea un formato que pueda caber en una cadena y este pueda ser enviado como una cadena
             */
        }
    }
    public class Cerveza
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Marca { get; set; }
    }
}
