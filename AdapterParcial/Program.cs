using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Infantil infantil = new Infantil();
            infantil.nro = "socio-10";
            infantil.obtenerNroSocio();
            infantil.bajaSocio();
            infantil.altaSocio();

            Adulto adulto = new Adulto();
            adulto.nro = "socio-11";
            adulto.obtenerNroSocio();
            adulto.bajaSocio();
            adulto.altaSocio();

            MonotributistaAdapter monotributista = new MonotributistaAdapter();
            monotributista.nro = "20-1231231231-2";
            monotributista.obtenerNroSocio();
            monotributista.bajaSocio();
            monotributista.altaSocio();

            Console.ReadKey();
        }
    }
}
