using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta9
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Ingresar un numero para generar una tabla de multiplicar:");
            string numero = Console.ReadLine();
            int valor = 0;
            bool error = Int32.TryParse(numero, out valor);
            int i = 1;    
            if (error)
            {
                for (i = 1; i <= 15; i++)
                {
                    Convert.ToInt32(numero);
                    Console.WriteLine("{0} x {1} = {2}", valor, i, valor*i);
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es correcto");
            }
            Console.ReadKey();
        }
    }
}