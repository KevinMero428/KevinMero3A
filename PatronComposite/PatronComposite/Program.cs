using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronComposite.Clases;
using PatronComposite.Interfaz;

namespace PatronComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Regalo Simple
            // Aqui calculamos un solo regalo, sin estar agrupado con cualquier otro producto
            var telefono = new RegaloSimple("Telefono", 350);
            telefono.CalcularPrecioTotal();
            Console.WriteLine();

            //Regalo Compuesto
            //Aqui agregamos todos los productos uno por uno y a la final los juntamos todos para hacer una sola impresion
            // de tal manera que se haga mas facil calcular todo por grupo y no uno por uno.
            var Parlante = new RegaloComposite("Parlante", 100);
            var Computadora = new RegaloSimple("Computadora", 600);
            var Juguete = new RegaloSimple("Juguete", 50);
            Parlante.Agregar(Computadora);
            Parlante.Agregar(Juguete);

            var Zapato = new RegaloComposite("Zapato", 40);
            var Camiseta = new RegaloSimple("Camiseta", 60);
            Zapato.Agregar(Camiseta);
            Parlante.Agregar(Zapato);

            Console.WriteLine($"El precio total de este componente es: {Parlante.CalcularPrecioTotal()}");
            Console.ReadKey();
        }
    }
}
