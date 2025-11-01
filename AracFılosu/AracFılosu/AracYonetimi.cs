using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracFılosu
{
    //TODO: Araçların yönetilebileceği bir class kuruldu.
    public class AracYonetimi
    {
        private List<Tasit> tasitlar = new List<Tasit>(); // araçların gizli listesi yapıldı.

        public void TasitEkle(Tasit tasit) // yeni taşıt eklemek için metod yazıldı
        {
            tasitlar.Add(tasit);
            Console.WriteLine($"{tasit.Marka} marka, {tasit.Model} model taşıt filoya eklendi");
        }
        public void Listele() //Araçları listelemek için metod yazıldı.
        {
            Console.WriteLine("\n----Filodaki Taşıtlar-----");
            foreach (var t in tasitlar)
            {
                Console.WriteLine($"{t.Marka}, {t.Model} Hız: {t.Hız} km/h");
            }
        }
        public void HepsiniHareketEttir() //taşıtları hareket ettirmek için metod kullan.
        {
            foreach (var t in tasitlar)
            {   
                    t.HareketEt();
            }
        }
    }
}

