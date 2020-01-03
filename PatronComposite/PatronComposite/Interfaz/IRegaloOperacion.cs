using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronComposite.Clases;

namespace PatronComposite.Interfaz
{
    public interface IRegaloOperacion
    {
        //Esta interfaz la usamos para seguir agregando los productos a la lista de los regalos compuestos
        // tambien podriamos eliminar
        void Agregar(Regalo regalo);
        void Eliminar(Regalo regalo);
    }
}
