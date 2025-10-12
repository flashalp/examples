#region 1.Kısım
DortIslem(4, 2, global::DortIslem.Toplama);
DortIslem(4, 2, global::DortIslem.Çıkarma);
DortIslem(4, 2, global::DortIslem.Çarpma);
DortIslem(4, 2, global::DortIslem.Bölme);

static void DortIslem(double sayi1, double sayi2, DortIslem islemTipi)
{
    switch(islemTipi)
    {
        case global::DortIslem.Toplama:
            Console.WriteLine($"Toplama İşleminin sonu: {sayi1 + sayi2}");
            break;
        case global::DortIslem.Çıkarma:
            Console.WriteLine($"Çıkarma İşleminin sonu: {sayi1 - sayi2}");
            break;
        case global::DortIslem.Çarpma:
            Console.WriteLine($"Çarpma İşleminin sonu: {sayi1 * sayi2}");
            break;
        case global::DortIslem.Bölme:
            Console.WriteLine($"Bölme İşleminin sonu: {sayi1 / sayi2}");
            break;
    }
}
enum DortIslem
{
    Toplama,
    Çıkarma,
    Çarpma,
    Bölme,
}
#endregion