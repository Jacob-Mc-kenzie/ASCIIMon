using System;
using System.Collections.Generic;
using System.Text;
using CompactGraphics;
namespace Menus
{
    public class MainMenu : Menu
    {
        public MainMenu() : base()
        {
            init();
        }
        public MainMenu(Graphics g) : base(g)
        {
            init();
        }
        private void init()
        {
            onPage.Add(new Frames(1, new Rect(0, 30, 0, 28)));
        }
        public override void StepFrame()
        {
            base.StepFrame();
            g.Draw('#', ConsoleColor.Yellow, 15, 15);
        }
    }
}
