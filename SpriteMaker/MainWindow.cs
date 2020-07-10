using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompactGraphics;
using Menus;

namespace SpriteMaker
{
    public class MainWindow : Menu
    {
        Frame mainFrame;
        Frame SideFrame;
        Button button;
        ConsoleColor toggleColor;
        public MainWindow(Graphics g)
        {
            this.g = g;
            init();
        }
        private int ClickBinding(Mouse m)
        {
            if(toggleColor == ConsoleColor.White)
            {
                toggleColor = ConsoleColor.Green;
            }
            else
            {
                toggleColor = ConsoleColor.White;
            }
            mainFrame.SetColor(toggleColor);
            return 1;
        }
        private void init()
        {
            toggleColor = ConsoleColor.White;
            mainFrame = new Frame('#', new Rect(0, 46, 2, 46));
            SideFrame = new Frame('#', new Rect(48, 89, 2, 46));
            button = new Button(new Rect(5, 12, 5, 8), "Test Button");
            button.BindOnClick(ClickBinding);
            onPage.Add(mainFrame);
            onPage.Add(SideFrame);
            onPage.Add(button);
        }

        public void StepFrame(Mouse mouse)
        {
            foreach (Widget widget in onPage)
            {
                widget.Draw(g, mouse);
            }
        }
    }
}
