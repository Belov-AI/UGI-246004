using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eucid
{
    public interface IRotatable
    {
        void Rotate(Point center, double AngleInDegrees);
    }
}
