using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneeseCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год н. э.");

            var year = int.Parse(Console.ReadLine());

            var yearInCycle = (year - 1984) % 60;

            if (yearInCycle < 0)
                yearInCycle += 60;

            var animalIndex = yearInCycle % 12;
            var colorIndex = yearInCycle / 12;

            var colors = new[] { "зелен", "красн", "желт", "бел", "черн" };

            var animals = new[] { "ой крысы", "ой коровы", "ого тигра",
                "ого зайца", "ого дракона", "ой змеи", "ой лошади", "ой овцы",
                "ой обезьяны", "ой курицы", "ой собаки", "ой свиньи"};

            Console.WriteLine($"{year} г. — год {colors[colorIndex]}{animals[animalIndex]}");
        }
    }
}
