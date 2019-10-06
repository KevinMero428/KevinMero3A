using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Horas = 0;
            int Total = 0;
            int Opcion = 0;
            do
            {
                Console.WriteLine("Ingresar la cantidad de horas que cumplio el trabajador:");
                Horas = Convert.ToInt32(Console.ReadLine());
                if(Horas <= 35)
                {
                    Total = Horas * 15;
                }
                else
                {
                    Total = ((35 * 15) + (Horas - 35) * 22);            
                }
                Console.WriteLine("El valor que se debe pagar es: {0}", Total);
                Console.WriteLine("¿Desea continuar consultando otro salario?");
                Console.WriteLine("1.- Si");
                Console.WriteLine("2.- No");
                Opcion = Convert.ToInt32(Console.ReadLine());
            } while (Opcion == 1);
        }
    }
}