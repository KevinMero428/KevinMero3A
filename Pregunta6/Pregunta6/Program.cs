using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar el valor de filas para el rombo:");
            int fila = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= fila; i++)
            {
                for (int j = 1; j <= fila - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (int i = fila - 1; i >= 1; i--)
            {
                for (int j = 1; j <= fila - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}