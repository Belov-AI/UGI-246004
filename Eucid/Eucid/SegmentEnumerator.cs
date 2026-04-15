using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eucid
{
    class SegmentEnumerator : IEnumerator<Point>
    {
        Segment s;
        object current;

        public Point Current => (Point)current;

        object IEnumerator.Current => Current;

        public SegmentEnumerator(Segment s)
        {
            this.s = s;
            current = null;
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (current as object == null)
            {
                current = s.A;
                return true;
            }
            else if (current == (object)s.A)
            {
                current = (object)s.B;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            current = null;
        }
    }
}
