using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracFılosu
{
    //TODO: tasşıt sınıfından kalıtım al ve propertyi tanımla
    public class Kamyon : Tasit
    {
        public Kamyon(string marka, string model, int hiz) 
        {
            if (string.IsNullOrEmpty(marka)) throw new ArgumentNullException("Marka boş olamaz!");
            if (string.IsNullOrEmpty(model)) throw new ArgumentNullException("Model boş olamaz!");
            if (hiz <= 0) throw new ArgumentOutOfRangeException("Hız sıfır veya negatif olamaz!");
            Marka = marka;
            Model = model;
            Hız = hiz;
        }
        //TODO: Taşıt sınıfındaki metodu ezerek yeni metod yaz.
        public override void HareketEt()
        {
            Console.WriteLine($"{Marka} marka, {Model} model kamyon {Hız} km/h ile yük taşıyor...");
        }
    }
}
