using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunum.LiskovSubstitution
{
    public class Tavuk : Kus
    {
        public override void Uc()
        {
            Console.WriteLine("Tavuklar uçamaz!");
        }
    }
}
