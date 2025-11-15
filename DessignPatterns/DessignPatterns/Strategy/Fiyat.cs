using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Strategy
{
    public class Yüzde10 : IIndirim
    {
        public double Hesapla(double tutar) => tutar * 0.9;
    }
    public class Yüzde20 : IIndirim
    {
        public double Hesapla(double tutar)
        {
            return tutar * 0.8;
        }
    }
}
