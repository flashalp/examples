using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunum.InterfaceSegregation
{
    public class BasitYazici : IYazdir
    {
        public void Yazdir()
        {
            Console.WriteLine("Basit Yazici Yazdiriyor");
        }
    }
}
