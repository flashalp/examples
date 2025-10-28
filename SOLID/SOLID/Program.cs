using SOLID;
using SOLID.LiskovSubstitution;
using SOLID.OpenClosed;
#region SINGLE RESPONSIBILITY PRINCIPLE (Tek Sorumluluk)
// Her sinifin tek bir sorumlulugu olmalidir. Bir sinifin degistirilme nedeni sadece bir tane olmalidir.
//StudentService studentService = new StudentService();
//studentService.CreateStudent();

//MailService mailService = new MailService();
//mailService.SendMail("Mail konusu", "Mail icerigi");
#endregion

#region OPEN/CLOSED PRINCIPLE (Acik/Kapali)
// Yeni sekil eklemek istedigimizde mevcut kodlara dokunmuyoruz, yeni siniflar ekliyoruz.
//Daire daire = new Daire(5);
//Console.WriteLine($"Dairenin Alani: {daire.Alan()}");

//Kare kare = new Kare(5);
//Console.WriteLine($"Karenin Alani: {kare.Alan()}");
#endregion

#region LISKOV SUBSTITUTION PRINCIPLE (Liskov Yerine Gecme)
// Alt siniflar, ust siniflarin yerine  ecmlei ve sistem dogru sekildi calismaya devam etmelidir.
Eagle eagle = new Eagle();
eagle.Fly();

Penguen penguen = new Penguen();
penguen.Fly();
#endregion