using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Odev.AltSınıflar
{
    // Pizza sınıfları bu interface'i implemente edecek.
    public class MargaritaPizza : IPizza
    {
        //Logger sınıfından nesne üretip, log kaydı bu sınıftaki metotlardan gidecek.
        Logger logger = Logger.GetInstance();
        public void SiparisEt()
        {
            Console.WriteLine("\nMargarita pizza siparişi alındı.");
            logger.Log("Margarita pizza siparişi verildi.");
        }
        public void Pisme()
        {
            Console.WriteLine("\nMargarita pizza pişiriliyor...");
            logger.Log("Margarita pizza pişiriliyor.");
        }
        public void Hazirla()
        {
            Console.WriteLine("\nMargarita pizza hazırlanıyor...");
            logger.Log("Margarita pizza siparişi hazırlanıyor.");
        }
        public void Paketle()
        {
            Console.WriteLine("\nMargarita pizza paketleniyor...");
            logger.Log("Margarita pizza paketleniyor.");
        }
        public void TeslimEt()
        {
            Console.WriteLine("\nMargarita pizza sipraşiniz hazır teslim alabilirsiniz.");
            logger.Log("Margarita pizza siparişi teslim edildi.");
        }
    }
}
