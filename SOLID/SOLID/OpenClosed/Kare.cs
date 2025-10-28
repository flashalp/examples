using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClosed
{
    public class Kare : ISekil
    {
        public double Kenar;
        public Kare(double k) { Kenar = k; }
        public double Alan() => Kenar * Kenar;
    }
}
