using DessignPatterns.Odev.Fabrika;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Odev.FabrikaVeBaseSınıf
{
    public class Siparis
    {
        public void PizzaSiparisi(int pizzaSecimi) 
        {
            switch (pizzaSecimi)
            {
                case 1:
                    var klasikPizza = PizzaFactory.Getpizza("klasik");
                    klasikPizza.SiparisEt();
                    Thread.Sleep(1000);
                    klasikPizza.Hazirla();
                    Thread.Sleep(1000);
                    klasikPizza.Pisme();
                    Thread.Sleep(1000);
                    klasikPizza.Paketle();
                    Thread.Sleep(1000);
                    klasikPizza.TeslimEt();
                    break;
                case 2:
                    var bolMalzemosPizza = PizzaFactory.Getpizza("bolmalzemos");
                    bolMalzemosPizza.SiparisEt();
                    Thread.Sleep(1000);
                    bolMalzemosPizza.Hazirla();
                    Thread.Sleep(1000);
                    bolMalzemosPizza.Pisme();
                    Thread.Sleep(1000);
                    bolMalzemosPizza.Paketle();
                    Thread.Sleep(1000);
                    bolMalzemosPizza.TeslimEt();
                    break;
                case 3:
                    var vejeteryanPizza = PizzaFactory.Getpizza("vejeteryan");
                    vejeteryanPizza.SiparisEt();
                    Thread.Sleep(1000);
                    vejeteryanPizza.Hazirla();
                    Thread.Sleep(1000);
                    vejeteryanPizza.Pisme();
                    Thread.Sleep(1000);
                    vejeteryanPizza.Paketle();
                    Thread.Sleep(1000);
                    vejeteryanPizza.TeslimEt();
                    break;
                case 4:
                    var sucukSeverPizza = PizzaFactory.Getpizza("sucuksever");
                    sucukSeverPizza.SiparisEt();
                    Thread.Sleep(1000);
                    sucukSeverPizza.Hazirla();
                    Thread.Sleep(1000);
                    sucukSeverPizza.Pisme();
                    Thread.Sleep(1000);
                    sucukSeverPizza.Paketle();
                    Thread.Sleep(1000);
                    sucukSeverPizza.TeslimEt();
                    break;
                case 5:
                    var margaritaPizza = PizzaFactory.Getpizza("margarita");
                    margaritaPizza.SiparisEt();
                    Thread.Sleep(1000);
                    margaritaPizza.Hazirla();
                    Thread.Sleep(1000);
                    margaritaPizza.Pisme();
                    Thread.Sleep(1000);
                    margaritaPizza.Paketle();
                    Thread.Sleep(1000);
                    margaritaPizza.TeslimEt();
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız.");
                    break;
            }
        }
    }
}
