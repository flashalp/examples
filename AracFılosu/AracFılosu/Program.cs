using AracFılosu;
AracYonetimi yonetim = new AracYonetimi();
//TODO: Alt sınıflardan yeni nesne oluşturarak parametre gir.
Otomobil oto1 = new Otomobil("BMW", "I20", 130);
Otobus otobus1 = new Otobus("Mercedes", "Travego", 90);
Kamyon kamyon1 = new Kamyon("Volvo", "FH16", 50);
Bisiklet bisiklet1 = new Bisiklet("Umit", "2025", 10);

//TODO: Araç listesine bu araçları ekle
yonetim.TasitEkle(oto1);
yonetim.TasitEkle(otobus1);
yonetim.TasitEkle(kamyon1);
yonetim.TasitEkle(bisiklet1);


//TODO: Araçları listele ve hareket ettir.
yonetim.Listele();
yonetim.HepsiniHareketEttir();


