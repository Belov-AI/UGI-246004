using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactwersAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = 'z';

            letter = (char)0x42F;

            Console.WriteLine(letter);

            var smallLetter = char.ToLower(letter);
            Console.WriteLine(smallLetter);
            Console.WriteLine(letter);
        }
    }
}
