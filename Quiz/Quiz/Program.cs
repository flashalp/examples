using Quiz;
//TODO: Bilgi yarışması giriş kısmı oluştur ve kulllanıcıdan isim al
Console.WriteLine("Bilgi Yarışmasına Hoşgeldiniz!");
Console.Write("Lütfen isminizi giriniz: ");
string isim = Console.ReadLine();

//TODO: Liste oluştur ve soru, secenek ve dogru cevapları tanımla
List<Soru> sorular = new List<Soru>()
        {
            new Soru
            {
                Metin = "Türkiye’de yer alan Nemrut Dağı, hangi uygarlığa ait heykelleriyle ünlüdür?",
                Secenekler = ["A) Hitit", "B) Urartu", "C) Kommagene", "D) Lidya" ],
                DogruCevap = 'C'
            },
            new Soru
            {
                Metin = "“Kırmızı Gezegen” olarak bilinen gezegen hangisidir?",
                Secenekler = ["A) Venüs", "B) Mars", "C) Jüpiter", "D) Satürn" ],
                DogruCevap = 'B'
            },
            new Soru
            {
                Metin = "Aşağıdaki yazarlardan hangisi “Suç ve Ceza” adlı romanın yazarıdır?",
                Secenekler = ["A) Lev Tolstoy", "B) Fyodor Dostoyevski", "C) Anton Çehov", "D) Maksim Gorki"],
                DogruCevap = 'B'
            },
            new Soru
            {
                Metin = "Aşağıdaki elementlerden hangisi soy gazlar grubundadır?",
                Secenekler = ["A) Oksijen", "B) Azot", "C) Helyum", "D) Karbon" ],
                DogruCevap = 'C'
            },
            new Soru
            {
                Metin = "Aşağıdaki ülkelerden hangisinin yüzölçümü en büyüktür?",
                Secenekler = ["A) Kanada", "B) Çin", "C) Amerika Birleşik Devletleri", "D) Rusya"],
                DogruCevap = 'D'
            }
        };

//TODO: Soruları döngü ile göster
int puan = 0;
int soruSayisi = 1;

foreach (var soru in sorular)
{
SoruTekrar:
    Console.WriteLine($"\nSoru {soruSayisi}: {soru.Metin}");

    foreach (var secenek in soru.Secenekler)
    {
        Console.WriteLine(secenek);
    }

    Console.Write("\nCevabınız (A, B, C, D): ");
    char kullaniciCevap = char.ToUpper(Console.ReadLine()[0]);

    //TODO: Cevapları kontrol et doğru ise puan ekle yanlış ise oyunu bitir
    if (kullaniciCevap == soru.DogruCevap)
    {
        puan += 10;
        Console.WriteLine($"Doğru! Toplam puanınız: {puan}");
        soruSayisi++;
    }
    else if (kullaniciCevap != 'A' & kullaniciCevap != 'C' & kullaniciCevap != 'C' & kullaniciCevap != 'D')
    {
        Console.WriteLine("\nGeçersiz cevap. Lütfen A, B, C veya D seçeneklerinden birini giriniz.");
        goto SoruTekrar;
    }
    else
    {
        Console.WriteLine($"Yanlış cevap verdiniz! oyun bitti...\n Toplam puanınız: {puan}");
        break;
    }
}