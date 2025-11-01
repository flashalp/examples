using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracFılosu
{
    public class Bisiklet : Tasit
    {
        public Bisiklet(string marka, string model, int hiz)
        {
            if (string.IsNullOrEmpty(marka)) throw new ArgumentNullException("Marka boş olamaz!");
            if (string.IsNullOrEmpty(model)) throw new ArgumentNullException("Model boş olamaz!");
            if (hiz <= 0) throw new ArgumentOutOfRangeException("Hız sıfır veya negatif olamaz!");
            Marka = marka;
            Model = model;
            Hız = hiz;
        }
        public override void HareketEt()
        {
            Console.WriteLine($"{Marka} marka, {Model} model bisiklet {Hız} km/h ile pedal çevirerek ilerliyor...");
        }
    }
}
