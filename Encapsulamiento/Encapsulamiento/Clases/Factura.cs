using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento.Clases
{
    public class Factura

    {
        string opcion;

        private string cancha;

        public string Cancha
        {
            get { return cancha; }
            set { cancha = value; }

        }

        private float costo;

        public float Costo
        {
            get
            {
                switch (cancha)
                {
                    case "1":
                        opcion = "Futbol";
                        costo = 20;
                        break;

                    case "2":
                        opcion = "Fulbito";
                        costo = 15;
                        break;

                    case "3":
                        opcion = "Indor";
                        costo = 5;
                        break;

                    case "4":
                        opcion = "Basquet";
                        costo = 5;
                        break;

                    default:
                        Console.WriteLine("***Ingresar una opcion valida***");
                        break;
                }
                return costo;
            }
        }

        private float horas;

        public float Horas
        {
            get { return horas; }
            set
            {

                if (value > 3)
                {
                    throw new Exception("No puede solicitar mas de 3 horas");
                }
                horas = value;
            }
        }

        private float subtotal;

        public float Subtotal
        {
            get
            {
                subtotal = costo * horas;
                return subtotal;
            }
        }

        private float descuento;

        public float Descuento
        {
            get { return descuento; }
            set
            {
                if (value == 10 || value == 20 || value == 0)
                {
                    descuento = value;
                }
                else
                    throw new Exception("No ingreso un descuento valido");
            }
        }

        private float subtotal2;
        public float Subtotal2
        {

            get
            {
                if (descuento == 10)
                {
                    subtotal2 = subtotal - ((subtotal * 10) / 100);
                    return subtotal2;
                }
                else if (descuento == 20)
                {
                    subtotal2 = subtotal - ((subtotal * 20) / 100);
                    return subtotal2;
                }
                subtotal2 = subtotal;
                return subtotal2;
            }
        }

        private float iva;

        public float IVA
        {
            get
            {
                iva = (subtotal2 * 12) / 100;
                return iva;
            }
        }

        private float final;

        public float Final
        {
            get
            {
                final = subtotal2 + iva;
                return final;
            }
        }

        private float pagado;

        public float Pagado
        {
            get
            {
                float abonar = final / 2;
                if (pagado >= abonar)
                {
                    return pagado;
                }
                else
                    throw new Exception("Debe cancelar al menos el 50% del total a pagar");
            }
            set { pagado = value; }
        }

        private float pendiente;

        public float Pendiente
        {
            get
            {
                pendiente = final - pagado;
                return pendiente;
            }
        }

        private string estado;

        public string Estado
        {
            get
            {

                if (pendiente > 0)
                {
                    estado = "PENDIENTE";
                    return estado;
                }
                else
                {
                    estado = "PAGADO";
                    return estado;
                }
            }
        }
    }
}