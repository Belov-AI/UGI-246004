using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Sequences
{
    internal class Sequence
    {
        public IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = 1;
            BigInteger b = 1;

            BigInteger c;

            yield return a;
            yield return b;

            while (true)
            {
                c = a + b;
                a = b;
                b = c;
                yield return c;
            } 
        }

        public IEnumerable<BigInteger> Factorial()
        {
            BigInteger n = 0;
            BigInteger f = 1;

            do
            {
                yield return f;
                f *= ++n;
            } while(true);          
        }

        public IEnumerable<BigInteger> Collatz(BigInteger n)
        {
            yield return n;

            while (true)
            {
               if (n % 2 == 0)
                    n /= 2;
                else
                    n = 3 * n + 1;

                yield return n;

                if (n == 1) break;
            } 
            

            
        }
    }
}
