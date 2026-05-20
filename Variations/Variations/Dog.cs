using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    public class Dog : Mammal
    {
        public string Breed { get;}
        public string Name { get; set; }

        public Dog(string breed, string name, int age)
        {
            this.Breed = breed;
            this.Name = name;
            this.Age = age;
            Species = "собака";
        }

        public Dog() : this("дворняга", "Шарик", 1) { }

        public override string ToString()
        {
            return $"Собака породы {Breed}. Кличка {Name}. Возраст: {Age}";
        }
    }
}
