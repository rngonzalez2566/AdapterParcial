using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParcial
{
    public  class Monotributista
    {
        public string nroMonotributo { get; set; }
        public void obtenerNroMonotributo()
        {
            Console.WriteLine("El nro de cuil del monotributista es: {0}", nroMonotributo);
        }

        public void altaMonotributo()
        {
            Console.WriteLine("Se dio de alta el monotributo: {0}", nroMonotributo);
        }

        public void bajaMonotributo()
        {
            Console.WriteLine("Se dio de baja el monotributo: {0}", nroMonotributo);
        }
    }
}
