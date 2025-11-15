using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DessignPatterns.Odev
{
    // pizza siparişi verirken Logger singleton pattern ile loglanacak.
    public class Logger
    {
        private static Logger _instance;
        private Logger() { }
        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }
        // SiprarisEt, Hazirla, Pisme, Paketle işlemlerini loglayacak.
        public void Log(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}]: {message}");
        }
    }
}
