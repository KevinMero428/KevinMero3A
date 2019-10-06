using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar la cantidad de numeros que desea comparar:");
            int valor = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[valor];
            for (int i = 0; i < valor; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }
            int Mayor = numeros.Max();
            Console.WriteLine("El numero mayor es: {0}", Mayor);
            Console.ReadKey();
        }
    }
}