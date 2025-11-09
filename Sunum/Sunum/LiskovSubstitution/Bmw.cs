using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunum.LiskovSubstitution
{
    public class Bmw : Araba , IKlima
    {
        public void KlimaAc()
        {
            Console.WriteLine("Bmw kliması açıldı.");
        }
    }
}
