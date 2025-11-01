using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterFaceSegregation
{
    public interface ITalking  // Ayrı bir interface oluşturuldu. Aynı zamanda Single Responsibility Principle'a da uygun oldu.
    {
        void Talk();
    }
    public interface IWorking  // Ayrı bir interface oluşturuldu. Aynı zamanda Single Responsibility Principle'a da uygun oldu.
    {
        void Work();
    }
    public interface IFlying  // Ayrı bir interface oluşturuldu. Aynı zamanda Single Responsibility Principle'a da uygun oldu.
    {
        void Fly();
    }
}
