using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    delegate Dog DogHandler(Dog dog);

    internal class Program
    {
        static void Main(string[] args)
        {
            DogHandler handler;

            var dog = new Dog();
            Console.WriteLine(dog);
            handler = InceaseDogAge;
            Console.WriteLine(handler(dog));

            handler = MakeHoundFromCreature;         
            Console.WriteLine(handler(dog));

        }

        static Dog InceaseDogAge(Dog dog)
        {
            dog.Age += 1;
            return dog;
        }

        static Hound MakeHoundFromCreature(Mammal creature)
        {
            var hound = new Hound();
            hound.Age = creature.Age;
            return hound;
        }
    }
}
