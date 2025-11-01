using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterFaceSegregation
{
    public class Bird : IFlying, ITalking, IWorking
    {
        public void Fly() // Bird sınıfı IFlying, ITalking ve IWorking interface'ini uyguluyor. Kendi ihtiyacı olanı uyguluyor.
        {
            Console.WriteLine("Bird is flying");
        }
        public void Talk() // Bird sınıfı IFlying, ITalking ve IWorking interface'ini uyguluyor. Kendi ihtiyacı olanı uyguluyor.
        {
            Console.WriteLine("Bird is talking");
        }
        public void Work() // Bird sınıfı IFlying, ITalking ve IWorking interface'ini uyguluyor. Kendi ihtiyacı olanı uyguluyor.
        {
            Console.WriteLine("Bird is working");
        }
    }
}
