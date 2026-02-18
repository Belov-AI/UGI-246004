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
            var mike = new User("mike");

            Thread.Sleep(5000);
            WebService.LogIn(mike);
            Thread.Sleep(2000);
        }
    }
}
