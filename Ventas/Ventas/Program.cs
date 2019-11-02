using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Clases;

namespace Ventas
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente persona1 = new Cliente()
            {
                Identificacion = "3050364227",
                Nombre = "Kevin Mero",
                Direccion = "Jaramijo",
                Telefono = 0987866879,
            };


            List<Producto> listaproductos = new List<Producto>()
            {
                new Producto()
                {
                    Codigo = "001", Descripcion = "Cafe", Precio = 1,
                },
                new Producto()
                {
                    Codigo = "002", Descripcion = "Leche", Precio = 1
                },
                new Producto()
                {
                    Codigo = "003", Descripcion = "Azucar", Precio = 0.50
                },
                new Producto()
                {
                    Codigo = "004", Descripcion = "Pan", Precio = 1
                },
                new Producto()
                {
                    Codigo = "005", Descripcion = "Tacos", Precio = 5
                },
                new Producto()
                {
                    Codigo = "006", Descripcion = "Suavitel", Precio = 2
                },
                new Producto()
                {
                    Codigo = "007", Descripcion = "Pinoclin", Precio = 1
                },
                new Producto()
                {
                    Codigo = "008", Descripcion = "Escoba", Precio = 5
                },
                new Producto()
                {
                    Codigo = "009", Descripcion = "Mapo", Precio = 3
                },
                new Producto()
                {
                    Codigo = "010", Descripcion = "Toalla", Precio = 5
                }
            };
            List<productoFactura> listaProductoFacturas = new List<productoFactura>()
            {
                new productoFactura()
                {
                    //Cafe
                    Cantidad = 2,
                },
                new productoFactura()
                {
                    //Leche
                    Cantidad = 4
                },
                new productoFactura()
                {
                    //Azucar
                    Cantidad = 2
                },
                new productoFactura()
                {
                    //Pan
                    Cantidad = 3
                },
                new productoFactura()
                {
                    //Tacos
                    Cantidad = 2
                },
                new productoFactura()
                {
                    //Suavitel
                    Cantidad = 5
                },
                new productoFactura()
                {
                    //Pinoclin
                    Cantidad = 2
                },
                new productoFactura()
                {
                    //Escoba
                    Cantidad = 2
                },
                new productoFactura()
                {
                    //Mapo
                    Cantidad = 1
                },
                new productoFactura()
                {
                    //Toalla
                    Cantidad = 1,
                }

            };

            Factura factura = new Factura()
            {
                Numero =  "000-000-001", Fecha = new DateTime(2019,10,30), Descuento = 3
            };


            Console.Write("Numero: {0}         \t\t", factura.Numero);
            Console.WriteLine("Fecha: {0}     \t\t", factura.Fecha);
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("Cliente: {0} - Consumidor Final", persona1.Identificacion);
            Console.WriteLine("*****************************************************************************************");
            Console.Write("Codigo \t\t");
            Console.Write("Descripcion \t\t");
            Console.Write("Cantidad \t\t");
            Console.Write("PVP \t\t");
            Console.WriteLine("Subtotal");

            foreach (Producto item in listaproductos)
            {
                Console.Write(item.Codigo+"\t\t");
                Console.Write(item.Descripcion + "\t\t\t");
                Console.Write(item.Cantidad1+ "\t\t\t");
                Console.Write(item.Precio + "\t\t\t");
                Console.WriteLine(item.Subtotal12);
            }
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t Subtotal: {0}",factura.Subtotal);
            Console.WriteLine("\t\t\t\t\t\t\t\t\t Descuento: {0}", factura.Descuento);
            Console.WriteLine("\t\t\t\t\t\t\t\t\t Subtotal-Descuento: {0}", factura.SubtotalDescuento);
            Console.WriteLine("\t\t\t\t\t\t\t\t\t IVA: {0}", factura.IVA);
            Console.WriteLine("\t\t\t\t\t\t\t\t\t Total: {0}", factura.Total);

            Console.ReadKey();
        }
    }
}