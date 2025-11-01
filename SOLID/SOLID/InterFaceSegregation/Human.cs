using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterFaceSegregation
{
    public class Human : ITalking , IWorking
    {
        public void Talk()  // Human sınıfı sadece ITalking ve IWorking arayüzlerini uyguluyor. Kendi ihtacı olanı uyguluyor.
        {
            Console.WriteLine("Human is talking");
        }

        public void Work() //Human sınıfı sadece ITalking ve IWorking arayüzlerini uyguluyor. Kendi ihtacı olanı uyguluyor.
        {
            Console.WriteLine("Human is working");
        }
    }
}
