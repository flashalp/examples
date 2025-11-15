namespace DessignPatterns.Odev.AltSınıflar
{
    // Pizza sınıfları bu interface'i implemente edecek.
    public class KlasikPizza : IPizza
    {
        //Logger sınıfından nesne üretip, log kaydı bu sınıftaki metotlardan gidecek.
        Logger logger = Logger.GetInstance();
        public void SiparisEt()
        {
            Console.WriteLine("\nKlasik pizza siparişi alındı.");
            logger.Log("Klasik pizza siparişi verildi.");
        }
        public void Pisme()
        {
            Console.WriteLine("\nKlasik pizza pişiriliyor...");
            logger.Log("Klasik pizza pişiriliyor.");
        }
        public void Hazirla()
        {
            Console.WriteLine("\nKlasik pizza hazırlanıyor...");
            logger.Log("Klasik pizza siparişi hazırlanıyor.");
        }
        public void Paketle()
        {
            Console.WriteLine("\nKlasik pizza paketleniyor...");
            logger.Log("Klasik pizza paketleniyor.");
        }
        public void TeslimEt()
        {
            Console.WriteLine("\nKlasik pizza sipraşiniz hazır teslim alabilirsiniz.");
            logger.Log("Klasik pizza siparişi teslim edildi.");
        }
    }
}
