using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronComposite.Interfaz;

namespace PatronComposite.Clases
{
    public class RegaloComposite : Regalo, IRegaloOperacion
    {

        //En esta clase, creamos una lista de regalos donde se almacenara todos los regalos que agregamos
        private List<Regalo> regalos;

        public RegaloComposite(String nombre, int precio): base (nombre, precio)
        {
            regalos = new List<Regalo>();
        }
        //Aqui creamos el metodo de agregar y eliminar
        public void Agregar(Regalo regalo)
        {
            regalos.Add(regalo);
        }

        public void Eliminar(Regalo regalo)
        {
            regalos.Remove(regalo);
        }

        //Sobre escribimos el metodo porque se repite en otra clase, por la cual seria lo mismo
        //pero de un formato distinto
        public override int CalcularPrecioTotal()
        {
            int total = 0;

            Console.WriteLine($"{nombre} contiene los siguientes productos con estos precios: ");

            foreach (var regalo in regalos)
            {
                total += regalo.CalcularPrecioTotal();
            }
            return total;
            
        }



    }
}
