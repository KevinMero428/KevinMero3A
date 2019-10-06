using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta5
{
    class Program
    {
        static void Main(string[] args)
        {           
           Console.WriteLine("Ingresar un numero entero para crea la piramide");
           int valor = Convert.ToInt32(Console.ReadLine());
           int j = 0;
           int k = 0;
           for (int i = 1; i <= valor; i++)
           {
               for (j = 1; j <= (valor - i); j++)
                    Console.Write(" ");
               for (k = 1; k <= i; k++)
                    Console.Write('*');
               for (k = (i - 1); k >= 1; k--)
                    Console.Write('*');
                Console.WriteLine();
           }
           Console.ReadKey();         
        }
    }
}
