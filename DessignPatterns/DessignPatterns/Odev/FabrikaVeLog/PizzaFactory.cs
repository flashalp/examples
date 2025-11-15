using DessignPatterns.Odev.AltSınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Odev.Fabrika
{
    // PizzaFactory ile pizza türüne göre pizza oluşturulacak.
    public class PizzaFactory
    {
        // Pizza türleri: Klasik, Margarita, SucukSever, BolMalzemos, Vejeteryan
        public static IPizza Getpizza(string pizzaTuru)
        {
            switch(pizzaTuru)
            {
                case "klasik":
                    return new KlasikPizza();
                case "margarita":
                    return new MargaritaPizza();
                case "sucuksever":
                    return new SucukSeverPizza();
                case "bolmalzemos":
                    return new BolMalzemosPizza();
                case "vejeteryan":
                    return new VejeteryanPizza();
                    default:
                    throw new ArgumentException("Geçersiz pizza türü");
            }
        }
    }
}