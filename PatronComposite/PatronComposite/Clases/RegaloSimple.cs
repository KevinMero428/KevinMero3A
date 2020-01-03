using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite.Clases
{
    public class RegaloSimple : Regalo
    {

        //Creamos un constructos vacio para poder asignar o no asginar un regalo simple
        public RegaloSimple (string nombre , int precio) : base (nombre, precio)
        {
        }

        //Sobre escribimos el metodo de calcular para que sea diferente el formato cuando es un regalo simple
        public override int CalcularPrecioTotal()
        {
            Console.WriteLine($"{nombre} con el precio {precio}");
            return precio;
        }
    }
}