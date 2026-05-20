using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    public class Hound : Dog
    {
        public double Rating { get; set; }

        public Hound(string name, int age, double rating) : 
            base("гончая", name, age)
        {
            Rating = rating;
        }

        public Hound() : this("Speedy", 3, 0) { }

        public override string ToString()
        {
            return base.ToString() + $". Рейтинг: {Rating}";
        }

    }
}
