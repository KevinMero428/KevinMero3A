using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite.Clases
{
    public abstract class Regalo
    {
        //Aqui es donde almacenamos los nombres y el precio del regalo que sera
        //visto al final de la consola para poder calcular su precio y tenerlo al lado del nombre
        
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
