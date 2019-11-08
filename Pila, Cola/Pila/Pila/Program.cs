using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Pila
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;

            Stack pila = new Stack();

            pila.Push("Kevin");
            pila.Push("Mero");
            pila.Push("Avila");

            for (int i = 0; i < 3; i++)
            {
                mensaje = (string)pila.Pop();
                Console.WriteLine(mensaje+" ");
            }
            Console.ReadKey();
        }
    }
}