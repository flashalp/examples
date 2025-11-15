using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Odev
{
    // Pizza interface'inde SiparisEt, Hazirla, Pisme, Paketle metodları olacak.
    public interface IPizza
    {
        void SiparisEt();
        void Hazirla();
        void Pisme();
        void Paketle();
        void TeslimEt();
    }
}
