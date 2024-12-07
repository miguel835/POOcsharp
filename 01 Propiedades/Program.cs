
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
            Venta miVenta = new Venta(502, DateTime.Now);
            miVenta.Total = -8858;
            Console.WriteLine("El total de la venta es de: " + miVenta.Total);
            Console.ReadKey();
        }
    }

    public class Venta
    {
        //Atributos 
        private int total;
        DateTime date; 

        //Propiedad o metodo 
        public int Total
        {
            get
            {
                //return total.ToString("#.00");
                return total;
            }
            set
            {
                if (value < 0) value = 0;
                total = value;
            }
        }
        
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
