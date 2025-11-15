using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Odev.AltSınıflar
{
    // Pizza sınıfları bu interface'i implemente edecek.
    public class SucukSeverPizza : IPizza
    {
        //Logger sınıfından nesne üretip, log kaydı bu sınıftaki metotlardan gidecek.
        Logger logger = Logger.GetInstance();
        public void SiparisEt()
        {
            Console.WriteLine("\nSucuk Sever pizza siparişi alındı.");
            logger.Log("Sucuk Sever pizza siparişi verildi.");
        }
        public void Pisme()
        {
            Console.WriteLine("\nSucuk Sever pizza pişiriliyor...");
            logger.Log("Sucuk Sever pizza pişiriliyor.");
        }
        public void Hazirla()
        {
            Console.WriteLine("\nSucuk Sever pizza hazırlanıyor...");
            logger.Log("Sucuk Sever pizza siparişi hazırlanıyor.");
        }
        public void Paketle()
        {
            Console.WriteLine("\nSucuk Sever pizza paketleniyor...");
            logger.Log("Sucuk Sever pizza paketleniyor.");
        }
        public void TeslimEt()
        {
            Console.WriteLine("\nSucuk Sever pizza sipraşiniz hazır teslim alabilirsiniz.");
            logger.Log("Sucuk Sever pizza siparişi teslim edildi.");
        }
    }
}
