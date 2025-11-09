using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunum.SingleResponsibility
{
    public class RaporKaydedici
    {
        public void RaporuKaydet(string rapor)
        {
            // Rapor kaydetme işlemi
            Console.WriteLine($"Rapor kaydediliyor: {rapor}");
        }
    }
}
