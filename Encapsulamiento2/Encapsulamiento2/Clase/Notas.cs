using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento2.Clase
{
    class Notas
    {
        private string nombre;

        public string Nombre
        {
            get
            {

                try
                {

                    var completo = nombre.Split(' ');
                    string nombre1 = completo[0];
                    string nombre2 = completo[1];
                    string apellido1 = completo[2];
                    string apellido2 = completo[3];
                    return nombre;

                }
                catch (Exception e)
                { nombre = "****INGRESE NOMBRES COMPLETOS****"; }
                return nombre;
            }

            set { nombre = value; }
        }

        private float actividad1;

        public float Actividad1
        {
            get
            {
                if (actividad1 <= 10 && actividad1 >= 0)
                {
                    actividad1 = (actividad1 * 25) / 100;
                    return actividad1;
                }
                else
                    throw new Exception("***INGRESAR NOTA MAYOR A 0 Y MENOR A 10***");
            }
            set { actividad1 = value; }
        }

        private float practica;

        public float Practica
        {
            get
            {
                if (practica <= 10 && practica >= 0)
                {
                    practica = (practica * 25) / 100;
                    return practica;
                }
                else
                    throw new Exception("***INGRESAR NOTA MAYOR A 0 Y MENOR A 10***");
            }
                set { practica = value; }
        }

        private float trabajoautonomo;

        public float TrabajoAutonomo
        {
            get
            {
                if (trabajoautonomo <= 10 && trabajoautonomo >= 0)
                {
                    trabajoautonomo = (trabajoautonomo * 20) / 100;
                    return trabajoautonomo;
                }
                else
                    throw new Exception("***INGRESAR NOTA MAYOR A 0 Y MENOR A 10***");
            }
                set { trabajoautonomo = value; }
        }

        private float evaluacion;

        public float Evaluacion
        {
            get
            {
                if (evaluacion <= 10 && evaluacion >= 0)
                {
                    evaluacion = (evaluacion * 30) / 100;
                    return evaluacion;
                }
                else
                    throw new Exception("***INGRESAR NOTA MAYOR A 0 Y MENOR A 10***");
            }
                set { evaluacion = value; }
        }

        private float primerparcial;

        public float PrimerParcial
        {
            get {
                primerparcial = actividad1 + practica + trabajoautonomo + evaluacion;
                return primerparcial; }
            //set { primerparcial = value; }
        }

        private float actividad2;

        public float Actividad2
        {
            get
            {
                if (actividad2 <= 10 && actividad2 >= 0)
                {
                    actividad2 = (actividad2 * 25) / 100;
                    return actividad2;
                }
                else
                    throw new Exception("***INGRESAR NOTA MAYOR A 0 Y MENOR A 10***");
            }
            set { actividad2 = value; }
        }

        private float practica2;

        public float Practica2
        {
            get
            {
                if (practica2 <= 10 && practica2 >= 0)
                {
                    practica2 = (practica2 * 25) / 100;
                    return practica2;
                }
                else
                    throw new Exception("***INGRESAR NOTA MAYOR A 0 Y MENOR A 10***");
            }
            set { practica2 = value; }
        }

        private float trabajoautonomo2;

        public float TrabajoAutonomo2
        {
            get
            {
                if (trabajoautonomo2 <= 10 && trabajoautonomo2 >= 0)
                {
                    trabajoautonomo2 = (trabajoautonomo2 * 20) / 100;
                    return trabajoautonomo2;
                }
                else
                    throw new Exception("***INGRESAR NOTA MAYOR A 0 Y MENOR A 10***");
            }
            set { trabajoautonomo2 = value; }
        }

        private float evaluacion2;

        public float Evaluacion2
        {
            get {
                if (evaluacion2 <= 10 && evaluacion2 >= 0)
                {
                    evaluacion2 = (evaluacion2 * 30) / 100;
                    return evaluacion2;
                }
                else
                    throw new Exception("***INGRESAR NOTA MAYOR A 0 Y MENOR A 10***");
            }
            set { evaluacion2 = value; }
        }

        private float segundoparcial;

        public float SegundoParcial
        {
            get {

                segundoparcial = actividad2 + practica2 + trabajoautonomo2 + evaluacion2;
                return segundoparcial; }
            //set { segundoparcial = value; }
        }

        private float suma;

        public float Suma
        {
            get {
                suma = primerparcial + segundoparcial;
                return suma; }
            //set { suma = value; }
        }

        private string estado;

        public string Estado
        {
            get
            {
                if (suma <= 14)
                {
                    estado = "REPROBADO";
                    return estado;
                }
                else
                    estado = "APROBADO";
                return estado;
            }
        }
            //set { estado = value; }

        private float recupera;

        public float Recupera
        {
            get {
                if (estado == "REPROBADO")
                {
                    return recupera;
                }
                else
                    throw new Exception(" ");    
                }
            set { recupera = value; }
        }

        private float suma2;

        public float Suma2
        {
            get {
                if (estado == "REPROBADO")
                {
                    suma2 = ((recupera * 3) / 10) + suma;
                    return suma2;
                }
                else
                    suma2 = suma;
                return suma2;
                }
            //set { suma2 = value; }
        }

        private float final;

        public float Final
        {
            get {
                final = suma2 / 2;

                return final; }
            //set { final = value; }
        }

    }
}