using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Clases
{
    public class productoFactura
    {
     
        

        public productoFactura(int cantidad, double precio, double subtotal1, Producto producto, Factura factura)
        {
            Cantidad = cantidad;
            Precio = precio;
            Subtotal1 = subtotal1;
            Producto = producto;
            Factura = factura;
        }

        public productoFactura()
        {
        }

        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private double precio;

        public double Precio
        {           
            get { return precio; }
            set { precio = Producto.Precio; }
        }

        private double subtotal1;

        public double Subtotal1
        {
            get {
                subtotal1 = Cantidad * Precio;
                return subtotal1; }
            set { subtotal1 = value; }
        }

        private Producto producto;

        public  Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }

    }
}