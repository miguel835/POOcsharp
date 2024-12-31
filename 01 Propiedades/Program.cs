
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    //Clase program
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objeto miVenta
            Venta miVenta = new Venta(502, DateTime.Now);
            miVenta.Total = -8858;
            Console.WriteLine("El total de la venta es de: " + miVenta.Total);
            Console.ReadKey();
        }
    }
    public class Venta
    {
        //Atributos 
        private int total; //Private para mayor seguridad en las reglas del negocio 
        private DateTime date; 
        //Propiedades
        //Estas tienen accesors que nos permiten leer y escribir
        public int Total
        {
            get
            {
                //Siempre regresa un valor equivalente al dato de la propiedad
                //return total.ToString("#.00");
                return total;
            }
            set
            {
                //El value es el valor de entrada que se recepta
                if (value < 0) value = 0;
                total = value;
            }
        }
        //Como regla siempre se inician con mayusculas las propiedades publicas
        public string Date
        {
            get
            {
                return date.ToShortDateString();
            }
        }
        //Constructor 
        public Venta(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
            
        }
    }
}
