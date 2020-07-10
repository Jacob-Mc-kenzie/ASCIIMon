using System;
using System.Collections.Generic;
using System.Text;
using CompactGraphics;

namespace Menus
{
    class Frames : CompactGraphics.Frame
    {
        int Style;
        static char[][] styleChart = new char[][] { new []{ '=', '+'}, new [] { '#', '*'}, new [] {'~', 'X' }, new[] { '?', ' '} };
        public Frames(char c, Rect r) : base(c,r)
        {
            Style = 0;
        }
        public Frames(int style, Rect r):base('=',r)
        {
            Style = style;
            if(style < 4 && style >= 0)
            {
                Style = style;
                borderchar = styleChart[style][0];
            }
            else
            {
                Style = 3;
                borderchar = styleChart[3][0];
            }
        }
        public Frames(char c, ConsoleColor forcolor, ConsoleColor backcolor, Rect r, DrawPoint p) : this(c, r)
        {
            forColor = forcolor;
            this.backcolor = backcolor;
            Pin = p;
            Bounds = r.OffsetPin(Pin);
        }

        public override void Draw(Graphics g)
        {
            for (int i = Bounds.x1; i <= Bounds.x2; i++)
            {
                for (int j = Bounds.y1; j <= Bounds.y2; j++)
                {
                    if((i == Bounds.x1 || i== Bounds.x2) && (j == Bounds.y1 || j== Bounds.y2))
                    {
                        g.Draw(styleChart[Style][1], forColor, i, j);
                    }
                    else if (i == Bounds.x1 || i == Bounds.x2 || j == Bounds.y1 || j == Bounds.y2)
                    {
                        g.Draw(borderchar, forColor, i, j);
                    }
                    g.DrawBackground(backcolor, i, j);
                }
            }
        }
    }
}
