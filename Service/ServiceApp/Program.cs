using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ServiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mike = new User("Mike");

            var service = new WebService();

            Thread.Sleep(1000);
            service.LogIn(mike);
            Thread.Sleep(1000);

            var ann = new RegisteredUser("Ann", "ann@urfu.ru", "qwerty2026");
            service.LogIn(ann);

            var admin = new Admin("John", "admin@service.ru", "Gnvion$1654bc", 2);
            service.LogIn(admin);

            PrintUsersInfo(service);
        }

        static void PrintUsersInfo(WebService service)
        {
            foreach(var user in service)
                Console.WriteLine(user.GetInfo());
        }
   }
}
