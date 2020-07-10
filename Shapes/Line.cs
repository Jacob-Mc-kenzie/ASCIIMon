using System;
using System.Collections.Generic;
using System.Text;
using CompactGraphics;

namespace Shapes
{
    public class Line : Shape
    {
        Rect points;
        ConsoleColor forground, background;
        TFrame Render;

        public Line(Rect Points)
        {
            points = Points;
            this.forground = ConsoleColor.White;
            this.background = ConsoleColor.Black;
        }
        public Line(Rect Points, ConsoleColor forground, ConsoleColor background) : this(Points)
        {
            this.forground = forground;
            this.background = background;
        }
        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
