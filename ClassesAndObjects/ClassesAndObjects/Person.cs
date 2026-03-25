using ClassesAndObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public Gender Gender { get; set; }

        private int age;
        public int Age
        {
            get => age;
            
            set
            {
                if(value < 0 || value >150)
                    throw new ArgumentOutOfRangeException("value");

                age = value;
            }
        }

        public Person(string name, string surname,  int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public Person() : this("", "", 0, Gender.Female) { }

        public string GetInfo() => $"{Name} {Surname}, возраст: {Age}, пол: {GetGenderRu()}";

        private string GetGenderRu()
        {
            if (Gender == Gender.Female)
                return "женский";
            else
                return "мужской";
        }

    }
}
