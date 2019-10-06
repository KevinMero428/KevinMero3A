using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar numero entero para empezar un conteo:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int doble = 0;
            int triple = 0;
            for (int i = 1; i <= numero; i++)
            {
                Console.Write(i);
                Console.Write(" ");

                doble = doble + 2;
                if(doble > numero )
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(doble);
                }
                Console.Write("  ");
                triple = triple + 3;
                if(triple > numero)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(triple);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
