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

            Thread.Sleep(1000);
            WebService.LogIn(mike);
            Thread.Sleep(1000);

            var ann = new RegisteredUser("Ann", "ann@urfu.ru", "qwerty2026");
            Console.WriteLine(ann.GetInfo());

            var admin = new Admin("John", "admin@service.ru", "Gnvion$1654bc", 2);
            Console.WriteLine(admin.GetInfo());

            Console.WriteLine(admin.ToString());

        }
    }
}
