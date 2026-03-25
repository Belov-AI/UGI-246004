using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape : ICloneable
    {
        public Color FillColour;
        public Color OutlineColour;

        public abstract double Area { get; }

        public abstract object Clone();

        public abstract void Draw();
    }
}
