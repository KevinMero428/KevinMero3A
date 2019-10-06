using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta10
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                
                Console.WriteLine("\nElegir un opcion del menu:");
                Console.WriteLine("1.- Salir");
                Console.WriteLine("2.- Sumatorio");
                Console.WriteLine("3.- Factorial");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch(opcion)
                {
                    case 1 :

                        break;
                    case 2:
                        Console.WriteLine("Ingresar 2 numeros para la sumatoria:");
                        int valor1 = Convert.ToInt32(Console.ReadLine());
                        int valor2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La respuesta es: {0}", valor1+valor2);
                        Console.WriteLine("Ingresar cualquier tecla para continuar:");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ingrese un numero para calcular el factorial:");
                        int numero = Convert.ToInt32(Console.ReadLine());
                        int fact = numero;
                        for (int i = numero - 1; i >= 1; i--)
                        {
                            fact = fact * i;
                        }
                        Console.WriteLine("El factorial de {0} es {1}", numero, fact);
                        Console.WriteLine("Ingresar cualqueir tecla para continuar:");
                        Console.ReadKey();
                        break;

                }
            } while (opcion != 1);
        }
    }
}