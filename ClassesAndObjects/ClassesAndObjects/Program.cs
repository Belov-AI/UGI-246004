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
            peter.Gender = Gender.Male;

            var ann = new Person { Name = "Анна", Surname = "Каренина", 
                Age = 20,  Gender = Gender.Female};

            var mike = new Person("Michael", "Mayers", 25, Gender.Male);

            Console.WriteLine(peter.GetInfo());
            Console.WriteLine(ann.GetInfo());
            Console.WriteLine(mike.GetInfo());
        }
    }
}
