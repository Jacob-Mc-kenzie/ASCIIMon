using System;
using CompactGraphics;

namespace Shapes
{
    public abstract class Shape
    {
        public Rect Bounds;
        public abstract void Draw();
        public abstract double Area();

        
    }
}
