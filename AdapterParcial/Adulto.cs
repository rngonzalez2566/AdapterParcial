using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParcial
{
    public class Adulto : Socio
    {
        public override string nro { get; set; }
        public override void obtenerNroSocio()
        {
            Console.WriteLine("El nro de socio Adulto es: {0}", nro);
        }
        public override void altaSocio()
        {
            Console.WriteLine("Se dio de alta el siguiente nro socio Adulto: {0}", nro);
        }
        public override void bajaSocio()
        {
            Console.WriteLine("Se dio de baja el siguiente nro socio Adulto: {0}", nro);
        }
    }
}
