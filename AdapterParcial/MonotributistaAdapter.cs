using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterParcial
{
    public   class MonotributistaAdapter : Socio
    {
        Monotributista monotributista = new Monotributista();

        public override string nro
        {
            get { return monotributista.nroMonotributo; }
            set { monotributista.nroMonotributo = value; }
        }
        public override void obtenerNroSocio()
        {
            monotributista.obtenerNroMonotributo();
        }

        public override void altaSocio()
        {
            monotributista.altaMonotributo();
        }

        public override void bajaSocio()
        {
           monotributista.bajaMonotributo();
        }
    }
}
