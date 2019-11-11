using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerNivelCia.Clases
{
    public class Cliente
    {
        public Cliente(string nombre, string cedula, string direccion)
        {
            Nombre = nombre;
            Cedula = cedula;
            Direccion = direccion;
        }
        public Cliente()
        {

        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string cedula;

        public  string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private Factura factura;

        public Factura Factura
        {
            get { return factura; }
            set { factura = value; }
        }


    }
}
