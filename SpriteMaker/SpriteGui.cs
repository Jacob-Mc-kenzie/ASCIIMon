using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompactGraphics;

namespace SpriteMaker
{
    class SpriteGui
    {
        static void Main(string[] args)
        {
            Graphics g = new Graphics(250,50);
            MainWindow m = new MainWindow(g);
            Mouse mouse = new Mouse();
            Rect b = new Rect(14, 20, 5, 6);
            while (true)
            {
                m.StepFrame(mouse);
                g.Draw($"mouse state: {mouse.GetMouseState()}", ConsoleColor.Yellow, 30, 20);
                int[] cord = mouse.GetMouse();
                if(b.Overlaps(cord[0],cord[1]))
                    for (int i = 14; i < 20; i++)
                    {
                        for (int j = 5; j < 6; j++)
                        {
                            g.DrawBackground(ConsoleColor.Green, i, j);
                        }
                    }
                else
                    for (int i = 14; i < 20; i++)
                    {
                        for (int j = 5; j < 6; j++)
                        {
                            g.DrawBackground(ConsoleColor.White, i, j);
                        }
                    }
                g.Draw("+",ConsoleColor.Cyan,cord[0], cord[1]);
                g.pushFrame();
            }
        }
    }
}
