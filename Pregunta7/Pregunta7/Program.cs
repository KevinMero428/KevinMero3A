using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dos columnas de numero del 1 al 100 y del 100 al 1:");
            int j = 100;
            for (int i = 1; i <= j; i++)
            {
                Console.Write(i);
                Console.Write("   ");
                Console.WriteLine(101 - i);
            }
            Console.ReadKey();
        }
    }
}
