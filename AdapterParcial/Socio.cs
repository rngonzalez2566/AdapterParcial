using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParcial
{
    public abstract class Socio
    {
        public abstract string nro { get; set; }
        public abstract void obtenerNroSocio();
        public abstract void altaSocio();
        public abstract void bajaSocio();

    }
}
