using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Odev.AltSınıflar
{
    // Pizza sınıfları bu interface'i implemente edecek.
    public class VejeteryanPizza : IPizza
    {
        //Logger sınıfından nesne üretip, log kaydı bu sınıftaki metotlardan gidecek.
        Logger logger = Logger.GetInstance();
        public void SiparisEt()
        {
            Console.WriteLine("\nVejeteryan pizza siparişi alındı.");
            logger.Log("Vejeteryan pizza siparişi verildi.");
        }
        public void Pisme()
        {
            Console.WriteLine("\nVejeteryan pizza pişiriliyor...");
            logger.Log("Vejeteryan pizza pişiriliyor.");
        }
        public void Hazirla()
        {
            Console.WriteLine("\nVejeteryan pizza hazırlanıyor...");
            logger.Log("Vejeteryan pizza siparişi hazırlanıyor.");
        }
        public void Paketle()
        {
            Console.WriteLine("\nVejeteryan pizza paketleniyor...");
            logger.Log("Vejeteryan pizza paketleniyor.");
        }
        public void TeslimEt()
        {
            Console.WriteLine("\nVejeteryan pizza sipraşiniz hazır teslim alabilirsiniz.");
            logger.Log("Vejeteryan pizza siparişi teslim edildi.");
        }
    }
}
