using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamiento2.Clase;

namespace Encapsulamiento2
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas notas = new Notas();

            Console.WriteLine("Ingresar nombre completo del estudiante:");
            notas.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresar nota de actividad en clase 1:");
            notas.Actividad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar nota de practica 1:");
            notas.Practica = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingesar nota de trabajo autonomo 1:");
            notas.TrabajoAutonomo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar nota de evaluacion final 1:");
            notas.Evaluacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar nota de actividad en clase 2:");
            notas.Actividad2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar nota de practica 2:");
            notas.Practica2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingesar nota de trabajo autonomo 2:");
            notas.TrabajoAutonomo2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar nota de evaluacion final 2:");
            notas.Evaluacion2 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Nombre del estudiante: {0}", notas.Nombre);
            Console.WriteLine("Actividad en clase 1: {0}", notas.Actividad1);
            Console.WriteLine("Nota de practica 1: {0}", notas.Practica);
            Console.WriteLine("Nota de trabajo autonomo 1: {0}", notas.TrabajoAutonomo);
            Console.WriteLine("Nota de evaluacion final 1: {0}", notas.Evaluacion);
            Console.WriteLine("Nota primer parcial: {0}", notas.PrimerParcial);

            Console.WriteLine("Actividad en clase 2: {0}", notas.Actividad2);
            Console.WriteLine("Nota de practica 2: {0}", notas.Practica2);
            Console.WriteLine("Nota de trabajo autonomo 2: {0}", notas.TrabajoAutonomo2);
            Console.WriteLine("Nota de evaluacion final 2: {0}", notas.Evaluacion2);
            Console.WriteLine("Nota segundo parcial: {0}", notas.SegundoParcial);
            Console.WriteLine("Suma total: {0}", notas.Suma);

            Console.WriteLine("Estado: {0}", notas.Estado);
            if(notas.Estado == "REPROBADO")
            {
                Console.WriteLine("Ingresar nota de recuperacion:");
                notas.Recupera = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("La suma total del primer parcial y segundo es: {0}", notas.Suma2);
            Console.WriteLine("El promedio es: {0}", notas.Final);

            Console.ReadKey();
        }
    }
}
