﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TercerNivelCia.Clases;

namespace TercerNivelCia
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura();
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingresar nombres y apellidos completos:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresar numero de cedula:");
            cliente.Cedula = Console.ReadLine();
            Console.WriteLine("Ingresar direccion:");
            cliente.Direccion = Console.ReadLine();

            Gasolina gasolina = new Gasolina();
            Program.Gasolina();
            int opcion = Convert.ToInt16(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    gasolina.Tipo = "Extra";
                    gasolina.Precio = 1.50;
                    break;
                case 2:
                    gasolina.Tipo = "Super";
                    gasolina.Precio = 2.00;
                    break;
                default:
                    Console.WriteLine("Ingrese un valor valido!");
                    break;
            }
            Console.WriteLine("Ingresar la cantidad de galones que desea comprar:");
            gasolina.CantidadGalones = Convert.ToInt16(Console.ReadLine());
            factura.Subtotal = gasolina.Precio * gasolina.CantidadGalones;

            Console.WriteLine("***********************************FACTURA***********************************************");
            Console.Write("Nombre: {0}", cliente.Nombre);
            Console.WriteLine("\t\t\tCedula: {0}", cliente.Cedula);
            Console.WriteLine("Direccion: {0}",cliente.Direccion);
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("Tipo \t\t\t Cantidad De Galones \t\t\t Precio De Venta");
            Console.Write(gasolina.Tipo+"\t\t\t\t");
            Console.Write(gasolina.CantidadGalones+"\t\t\t\t\t");
            Console.WriteLine(gasolina.Precio);
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("\t\t\t\t\t\t\t Subtotal: {0}", gasolina.CantidadGalones * gasolina.Precio);
            Console.WriteLine("\t\t\t\t\t\t\t IVA: {0}", factura.IVA);
            Console.WriteLine("\t\t\t\t\t\t\t Total: {0}", factura.Total);

            Console.ReadKey();
        }

        static void Gasolina()
        {
            Console.WriteLine("*******************************************************");
            Console.WriteLine("Elegir el tipo de gasolina que desea comprar");
            Console.WriteLine("1.- Extra __________________________ $1.50");
            Console.WriteLine("2.- Super __________________________ $2.00");
            Console.WriteLine("*******************************************************");
        }
    }
}
