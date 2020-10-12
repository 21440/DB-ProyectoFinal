using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoB2
{
    class Privada: Habitaciones
    {
       
        public override void Pago()
        {
            costo = 10000;
            pago = costo * dias;
        }
    }
}
