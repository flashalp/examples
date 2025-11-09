using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunum.SingleResponsibility
{
    public class RaporYazici
    {
        public void RaporuYazdir(string rapor)
        {
            // Rapor yazdırma işlemi
            Console.WriteLine($"Rapor yazdırılıyor: {rapor}");
        }
    }
}
