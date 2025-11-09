using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunum.DependencyInversion
{
    public class HavaleOdeme : IOdeme
    {
        public void Odeme()
        {
            // Havale ile ödeme işlemleri burada gerçekleştirilir.
            Console.WriteLine("Havale ile ödeme yapıldı.");
        }
    }

}
