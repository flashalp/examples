csharp Sunum\DependencyInversion\OdemeIslemcisi_NotDIP_Modified.cs
using System;

namespace Sunum.DependencyInversion
{
    public class OdemeIslemcisi
    {
        public void OdemeYap(string odemeTipi)
        {
            if (odemeTipi == "kredi")
            {
                new KrediKartiOdeme().Odeme();
            }
            else if (odemeTipi == "havale")
            {
                new HavaleOdeme().Odeme();
            }
            else if (odemeTipi == "bitcoin") // Yeni dal eklendi — sýnýf deðiþti
            {
                new BitcoinOdeme().Odeme();
            }
            else
            {
                throw new InvalidOperationException("Bilinmeyen ödeme türü");
            }
        }
    }
}