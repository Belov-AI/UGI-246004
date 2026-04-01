using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class ComparerByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y) => x.Age - y.Age;
    }
}
