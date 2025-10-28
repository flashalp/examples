//TODO: Yarisma girisi, kullanici ismi
using YarismaProgrami;

Console.WriteLine("---BILGI YARISMASINA HOSGELDINIZ---");
Console.Write("Adinizi giriniz: ");
string ad = Console.ReadLine();
Console.WriteLine($"Bilgi yarismasina hos geldin, {ad}!");

//TODO: Sorular cok tekrar olacagi icin metod icine yap
static void SoruCevap()
{
    Soru soru1 = new Soru
    {
        Metin = "\nTürkiye Cumhuriyeti’nin ilk kadın pilotu kimdir?",
        Secenekler = ["A) Sabiha Gökçen", "B) Afet İnan", "C) Halide Edip Adıvar", "D) Nene Hatun"],
        DogruCevap = 'A'
    };
    Soru soru2 = new Soru
    {
        Metin = "\nGüneş Sistemi’nde halkalarıyla ünlü gezegen hangisidir?",
        Secenekler = ["A) Mars", "B) Jüpiter", "C) Satürn", "D) Neptün"],
        DogruCevap = 'B'
    };
    Soru soru3 = new Soru
    {
        Metin = "\n“Suç ve Ceza” romanının yazarı kimdir?",
        Secenekler = ["A) Lev Tolstoy", "B) Fyodor Dostoyevski", "C) Anton Çehov", "D) Maksim Gorki"],
        DogruCevap = 'B'
    };
    Soru soru4 = new Soru
    {
        Metin = "\nDNA’nın çift sarmal yapısını keşfeden bilim insanları kimlerdir?",
        Secenekler = ["A) Isaac Newton ve Robert Hooke", "B) Charles Darwin ve Gregor Mendel", "C) James Watson ve Francis Crick", "D) Marie Curie ve Pierre Curie"],
        DogruCevap = 'C'
    };
    Soru soru5 = new Soru
    {
        Metin = "\nAşağıdaki ülkelerden hangisi Avrupa Birliği üyesi değildir?",
        Secenekler = ["A) Almanya", "B) Norveç", "C) Fransa", "D) İtalya"],
        DogruCevap = 'B'
    };

    //TODO: Sorulari ve cevaplari karistir foreach dongusuyle sor (Karistiramadim :((( )
    Soru[] sorular = { soru1, soru2, soru3, soru4, soru5 };
    int puan = 0;
    foreach (var soru in sorular)
    {
        SoruTekrar:
        Console.WriteLine($"\n{soru.Metin}");

            foreach (var secenek in soru.Secenekler)
            {
                Console.WriteLine(secenek.ToString());
            }

        Console.Write("Cevabınız(A / B / C / D): ");
        string gelencevap = Console.ReadLine().ToUpper();
        char cevap = gelencevap[0];

        //TODO: Dogru cevap verildiginde puan sistemi, yanlis olursa elenir
        if (cevap == soru.DogruCevap)
        {
            puan += 10;
            Console.WriteLine($"Dogru! Toplam Puaniniz: {puan}");
        }
        else if (cevap != 'A' & cevap != 'B' & cevap != 'C' & cevap != 'D')
        {
            Console.WriteLine("\nLutfen seceneklerden birini seciniz");
            goto SoruTekrar;
        }
        else
        {
            Console.WriteLine("Yanlis cevap verdiniz! Oyun bitti!");
            Console.WriteLine($"Toplam puaniniz: {puan}");
            return;
        }
    }
            Console.WriteLine("\nTEBRIKLER YARISMAYI TAMAMLADINIZ !!!");
}


SoruCevap();




