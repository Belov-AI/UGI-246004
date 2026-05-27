using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Dog
    {
        public string Name { get; set; }

        public void Bark(object sender, AlarmEventArgs e) =>
            Console.WriteLine($"{Name}: Гав-гав!!");
    }
}
