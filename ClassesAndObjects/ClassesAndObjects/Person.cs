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

        public string GetInfo() => $"{Name} {Surname}, возраст: {Age}";

    }
}
