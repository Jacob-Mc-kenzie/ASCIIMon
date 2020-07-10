using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompactGraphics;
using Menus;
namespace AsciiMon
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphics g = new Graphics(50, 30);
            MainMenu mainM = new MainMenu();
            while (true)
            {
                
                mainM.StepFrame();
                g.Draw("wowowowow", ConsoleColor.White, 0, 0);
                g.pushFrame();
            }
        }
        
    }
}
