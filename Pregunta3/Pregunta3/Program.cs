using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta3
{
    class Program
    {
        static void Main(string[] args)
        {
            int producto = 0;
            int valor = 0;
            int acomulador = 0;
            do
            {
                Console.WriteLine("Ingresar la cantidad del producto vendido:");
                producto = Convert.ToInt32(Console.ReadLine());
                if (producto != 0)
                {
                    Console.WriteLine("Ingresar el valor del producto comprado:");
                    valor = Convert.ToInt32(Console.ReadLine());
                }
                acomulador = acomulador + (valor * producto);
            } while (producto != 0);
            Console.WriteLine("El valor a cancelar es: {0}", acomulador);
            Console.ReadKey();
        }
    }
}