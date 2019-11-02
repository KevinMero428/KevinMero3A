using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Clases
{
    public class Cliente
    {

        public Cliente()
        {
        }

        public Cliente(string identificacion, string nombre, string direccion, int telefono, List<Factura> listaFactura)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            ListaFactura = listaFactura;
        }

        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private List<Factura> listafactura;

        public List<Factura> ListaFactura
        {
            get { return listafactura; }
            set { listafactura = value; }
        }


    }
}
