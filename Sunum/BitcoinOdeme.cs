csharp Sunum\DependencyInversion\BitcoinOdeme.cs
using System;

namespace Sunum.DependencyInversion
{
    // Yeni ödeme türü (örnek) — DIP uygulanmamýþ yapý bunu bile yönetemez.
    public class BitcoinOdeme
    {
        public void Odeme()
        {
            Console.WriteLine("Bitcoin ile ödeme yapýldý.");
        }
    }
}