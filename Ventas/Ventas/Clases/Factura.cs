using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Clases
{
    public class Factura
    {

        public Factura(string numero, DateTime fecha, double subtotal, double descuento, double subtotalDescuento, 
            double iVA, double total, List<productoFactura> listaProductoFactura, Cliente cliente)
        {
            Numero = numero;
            Fecha = fecha;
            Subtotal = subtotal;
            Descuento = descuento;
            SubtotalDescuento = subtotalDescuento;
            IVA = iVA;
            Total = total;
            ListaProductoFactura = listaProductoFactura;
            Cliente = cliente;
        }

        public Factura()
        {
        }

        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private double subtotal;

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = this.ProductoFactura.Subtotal1; }
        }

        private double descuento;

        public double Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        private double subtotaldescuento;

        public double SubtotalDescuento
        {
            get {
                SubtotalDescuento = Subtotal - Descuento;
                return subtotaldescuento; }
            set { subtotaldescuento = value; }
        }

        private double iva;

        public double IVA
        {
            get {
                IVA = SubtotalDescuento * 0.12;

                return iva; }
            set { iva = value; }
        }

        private double total;

        public double Total
        {
            get {

                if(Subtotal < 10)
                {
                    //throw new Exception("***DEBE CONSUMIR AL MENOS 10 DOLARES***");
                }
                Total = SubtotalDescuento + IVA;
                return total; }
            set { total = value; }
        }

        private List<productoFactura> listaproductofactura;

        public  List<productoFactura> ListaProductoFactura
        {
            get { return listaproductofactura; }
            set { listaproductofactura = value; }
        }

        private productoFactura productofactura;

        public productoFactura ProductoFactura
        {
            get { return productofactura; }
            set { productofactura = value; }
        }


        private Cliente cliente;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


    }
}
