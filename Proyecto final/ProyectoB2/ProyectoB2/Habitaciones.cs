using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoB2
{
    public abstract class Habitaciones
    {
        public int costo { get; set; }
        public int dias { get; set; }
        public int pago { get; set; }
        public abstract void Pago();

    }
}
