using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterFaceSegregation
{
    public class DeepFreeze : IFreezing, IElectricUsingDevice
    {
        public void Elecktric()
        {
            Console.WriteLine("Deep Freeze uses electricity.");
        }
        public void Freeze()
        {
            Console.WriteLine("Deep Freeze is freezing items.");
        }
    }
}
