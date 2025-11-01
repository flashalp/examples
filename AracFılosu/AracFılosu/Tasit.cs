using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracFılosu
{
    //TODO: Taşıtlar ile ilgili ana class kur ve property ver
    public class Tasit
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Hız { get; set; }
        
        //TODO: Virtual metod oluştur 
        public virtual void HareketEt()
        {
            Console.WriteLine("Taşıt hareket ediyor...");
        }
    }
}
