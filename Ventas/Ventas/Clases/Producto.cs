using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Clases
{
    public class Producto
    {

        private List<productoFactura> listaproductofactura;

        public List<productoFactura> ListaProductoFactura
        {
            get { return listaproductofactura; }
            set { listaproductofactura = value; }
        }
        private productoFactura productofactura;

        public productoFactura ProductoFacutra
        {
            get { return productofactura; }
            set { productofactura = value; }
        }


        public Producto()
        {
        }

        public Producto(string codigo, string descripcion, double precio, int cantidad1, double subtotal12, 
            List<productoFactura> listaProductoFactura, productoFactura productoFacutra)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad1 = cantidad1;
            Subtotal12 = subtotal12;
            ListaProductoFactura = listaProductoFactura;
            ProductoFacutra = productoFacutra;
        }

        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int cantidad1;

        public int Cantidad1
        {
            get { return cantidad1;  }
            set { cantidad1 = ProductoFacutra.Cantidad; }
        }        

        private double subtotal12;

        public double Subtotal12
        {
            get { return subtotal12; }
            set { subtotal12 = ProductoFacutra.Subtotal1; }
        }

    }
}
