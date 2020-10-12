using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoB2
{
    class Doble: Habitaciones
    {
        
        public override void Pago()
        {
            costo = 5000;
            pago = costo * dias;
        }
    }
}
