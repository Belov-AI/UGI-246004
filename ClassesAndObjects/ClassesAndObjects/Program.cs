using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            peter.Name = "Пётр";
            peter.Surname = "Иванов";
            peter.Age = 18;

            var ann = new Person() { Name = "Анна", Surname = "Каренина", Age = 20 };

            Console.WriteLine(peter.GetInfo());
            Console.WriteLine(ann.GetInfo());
        }
    }
}
