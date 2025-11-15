//using DessignPatterns.Singleton;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DessignPatterns.Student
//{
//    public class StudentServices : IStudentSevices
//    {
//        private Logger _logger;
//        public StudentServices(Logger? log) 
//        {
//            _logger = log;
//        }
//        public void Add()
//        {
//            Console.WriteLine("Öğrenci sisteme eklendi");
//            _logger.Log("Kullanıcı sisteme öğrenci ekledi");
//        }

//        public void Delete()
//        {
//            Console.WriteLine("Öğrenci sistemden silindi");
//            _logger.Log("Kullanıcı sistemden öğrenci sildi");
//        }
//        public void Update()
//        { 
//            Console.WriteLine("Öğrenci bilgileri güncellendi"); 
//            _logger.Log("Kullanıcı öğrenci bilgilerini güncelledi");
//        }
//        public void List()
//        {
//            Console.WriteLine("Öğrenci listelendi");
//            _logger.Log("Kullanıcı öğrenci listesini görüntüledi");
//        }

//    }
//}
