using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoB2
{
    class Suite: Habitaciones
    {
        
        public override void Pago()
        {
            costo = 15000;
            pago = costo * dias;
        }
    }
}
