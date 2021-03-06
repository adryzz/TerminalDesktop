using System;
using System.Numerics;
using TerminalDesktop.Startup;
using TerminalDesktop.Terminal;
using TerminalDesktop.UI;

namespace TerminalDesktop
{
    public static class Program
    {
        public static Configuration Config = new Configuration();
        public static TerminalSelector TerminalHost = new TerminalSelector();
        public static void Main(string[] args)
        {
            //Console.TreatControlCAsInput = true;
            Console.CursorVisible = false;
            int mousex = 5;
            int mousey = 5;

            int oldx = mousex;
            int oldy = mousey;
            
            while (true)
            {
                TopBarFormatter.Shared.Print();
                VerticalBorderFormatter.Shared.Print();
                BottomBarFormatter.Shared.Print();
                TerminalFormatter.Shared.Print();
                CursorFormatter.Shared.Print();
            }
        }
    }
}