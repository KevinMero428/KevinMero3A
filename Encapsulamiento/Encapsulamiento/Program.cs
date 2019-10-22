using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamiento.Clases;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura();

            Program.menu();

            string seleccion = Console.ReadLine();
            factura.Cancha = seleccion;
            


            Console.WriteLine("Ingresar la cantidad de horas:");
            factura.Horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar el descuento que desea aplicar:");
            factura.Descuento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar el valor a cancelar");
            factura.Pagado = Convert.ToInt32(Console.ReadLine());
            

            //Console.WriteLine("Cancha: {0}", factura.Cancha);
            Console.WriteLine("El costo de la cancha es: {0}", factura.Costo);
            Console.WriteLine("Horas elegida: {0}", factura.Horas);
            Console.WriteLine("Subtotal 1: {0}", factura.Subtotal);
            Console.WriteLine("El descuento es de: {0}%", factura.Descuento);
            Console.WriteLine("El subtotal con descuento es: {0}", factura.Subtotal2);
            Console.WriteLine("El valor del IVA es: {0}", factura.IVA);
            Console.WriteLine("El precio final es: {0}", factura.Final);
            Console.WriteLine("El valor pagado es: {0}", factura.Pagado);
            Console.WriteLine("El saldo pendiente es de: {0}", factura.Pendiente);
            Console.WriteLine("ESTADO: {0}", factura.Estado);

            Console.ReadKey();
        }





        static void menu()
        {
           Console.WriteLine("MENU");
           Console.WriteLine("1.- Futbol ----------- $20");
           Console.WriteLine("2.- Fulbito ----------- $15");
           Console.WriteLine("3.- Indor ----------- $5");
           Console.WriteLine("4.- Basquet ----------- $5");

        }
    }

}