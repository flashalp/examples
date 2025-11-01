using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterFaceSegregation
{
    public interface IElectricUsingDevice
    {
        void Elecktric();
    }
    public interface IFreezing
    {
        void Freeze();
    }
    public interface IWashing
    {
        void Wash();
    }
}
