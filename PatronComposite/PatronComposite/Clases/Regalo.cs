using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite.Clases
{
    public abstract class Regalo
    {
        protected string nombre;
        protected int precio;

        public Regalo(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public abstract int CalcularPrecioTotal();
    }
}
