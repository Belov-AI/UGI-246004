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

            var animalNumber = yearInCycle % 12;
            var colorNumber = yearInCycle / 12;

            string color;

            if (colorNumber == 0)
                color = "зелен";
            else if (colorNumber == 1)
                color = "красн";
            else if (colorNumber == 2)
                color = "желт";
            else if (colorNumber == 3)
                color = "бел";
            else
                color = "черн";

            string animal;

            if (animalNumber == 0)
                animal = "ой крысы";
            else if (animalNumber == 1)
                animal = "ой коровы";
            else if (animalNumber == 2)
                animal = "ого тигра";
            else if (animalNumber == 3)
                animal = "ого зайца";
            else if (animalNumber == 4)
                animal = "ого дракона";
            else if (animalNumber == 5)
                animal = "ой змеи";
            else if (animalNumber == 6)
                animal = "ой лошади";
            else if (animalNumber == 7)
                animal = "ой овцы";
            else if (animalNumber == 8)
                animal = "ой обезьяны";
            else if (animalNumber == 9)
                animal = "ой курицы";
            else if (animalNumber == 10)
                animal = "ой собаки";
            else
                animal = "ой свиньи";
            
            Console.WriteLine($"{year} г. — год {color}{animal}");
        }
    }
}
