using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.RealWorld
{
    public class Circle(int radius, Color color) : IShape
    {
        public IShape Clone()
        {
            return new Circle(radius, color.Clone());
        }
    }

    public class Rectangle(int width, int height, Color color) : IShape
    {
        public IShape Clone()
        {
            return new Rectangle(width, height, color.Clone());
        }
    }
}
