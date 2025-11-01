using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterFaceSegregation
{
    public class WashingMachine : IWashing, IElectricUsingDevice
    {
        public void Elecktric()
        {
            Console.WriteLine("Washing Machine uses electricity.");
        }
        public void Wash()
        {
            Console.WriteLine("Washing Machine is washing clothes.");
        }
    }
}
