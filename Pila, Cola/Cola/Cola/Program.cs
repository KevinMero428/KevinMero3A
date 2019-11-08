using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;

            Queue cola = new Queue();

            cola.Enqueue("Universidad");
            cola.Enqueue("Laica");
            cola.Enqueue("Eloy");
            cola.Enqueue("Alfaro");
            cola.Enqueue("De Manabi");

            for (int i = 0; i < 5; i++)
            {
                mensaje = (string)cola.Dequeue();
                Console.Write(mensaje+" ");
            }
            Console.ReadKey();
        }
    }
}
