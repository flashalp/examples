using DessignPatterns.Factory;
using DessignPatterns.Singleton;
using DessignPatterns.Student;

#region Singleton Pattern
//var logger = Logger.GetInstance();
//logger.Log("Program sağlıklı çalıştı.");

//StudentServices studentServices = new StudentServices(logger);
//studentServices.Add();
//studentServices.Delete();
//studentServices.Update();
//studentServices.List();
#endregion

#region Factory Pattern

var sekilDaire = SekilFactory.GetSekil("daire");
var sekilKare = SekilFactory.GetSekil("kare");


sekilDaire.Ciz();
sekilKare.Ciz();


#endregion



