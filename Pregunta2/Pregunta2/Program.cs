using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un numero entero para crear un cuadrado:");
            Console.WriteLine("Valor de las dimensiones:");
            int fila = Convert.ToInt32(Console.ReadLine());

            while(fila < 2)
            {
                Console.WriteLine("Ingresar un valor mayor a 2 para crear un cuadrado");
                Console.WriteLine("Valor de las dimensiones:");
                fila = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= fila; i++)
            {
                for (int j = 1; j <= fila; j++)
                {
                    if (i == 1 || i == fila ||
                        j == 1 || j == fila)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
