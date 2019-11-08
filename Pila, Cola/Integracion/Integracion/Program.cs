using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Integracion
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Menu();
            string opcion = Console.ReadLine();
            Stack pila = new Stack();
            string [] arreglo = new string[3];
            Queue cola = new Queue();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingresar cualquier nombre para formar la pila");
                    for (int i = 0; i < 3; i++)
                    {
                        arreglo[i] = Console.ReadLine();
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        pila.Push(arreglo[i]);
                    }
                    Console.WriteLine("\nEl resultado en forma de pila es:");
                    for (int i = 0; i < 3; i++)
                    {
                        string mensaje = (string)pila.Pop();
                        Console.WriteLine(mensaje+" ");
                    }
                    Console.ReadKey();
                    break;

                case "2":
                    Console.WriteLine("Ingresar cualquier nombre para formar la pila");
                    for (int i = 0; i < 3; i++)
                    {
                        arreglo[i] = Console.ReadLine();
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        cola.Enqueue(arreglo[i]);
                    }
                    Console.WriteLine("\nEl resultado de la cola es:");
                    for (int i = 0; i < 3; i++)
                    {
                        string mensaje = (string)cola.Dequeue();
                        Console.WriteLine(mensaje+" ");
                    }
                    Console.ReadKey();
                    break;

                default:                    
                    break;
            }
                


        }

        static void Menu()
        {
            Console.WriteLine("***************************************************");
            Console.WriteLine("1.- Pila");
            Console.WriteLine("2.- Cola");
            Console.WriteLine("3.- Salir");
            Console.WriteLine("***************************************************");
        }
    }
}
