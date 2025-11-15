using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Odev.AltSınıflar
{
    // Pizza sınıfları bu interface'i implemente edecek.
    public class BolMalzemosPizza : IPizza
    {
        //Logger sınıfından nesne üretip, log kaydı bu sınıftaki metotlardan gidecek.
        Logger logger = Logger.GetInstance();
        public void SiparisEt()
        {
            Console.WriteLine("\nBol Malzemos pizza siparişi alındı.");
            logger.Log("Bol Malzemos pizza siparişi verildi.");
        }
        public void Pisme()
        {
            Console.WriteLine("\nBol Malzemos pizza pişiriliyor...");
            logger.Log("Bol Malzemos pizza pişiriliyor.");
        }
        public void Hazirla()
        {
            Console.WriteLine("\nBol Malzemos pizza hazırlanıyor...");
            logger.Log("Bol Malzemos pizza siparişi hazırlanıyor.");
        }
        public void Paketle()
        {
            Console.WriteLine("\nBol Malzemos pizza paketleniyor...");
            logger.Log("Bol Malzemos pizza paketleniyor.");
        }
        public void TeslimEt()
        {
            Console.WriteLine("\nBol Malzemos pizza sipraşiniz hazır teslim alabilirsiniz.");
            logger.Log("Bol Malzemos pizza siparişi teslim edildi.");
        }

    }
}
