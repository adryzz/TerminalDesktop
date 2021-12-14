using System;
using Console = Colorful.Console;

namespace TerminalDesktop.Hardware
{
    public static class MouseHelper
    {
        public static (int, int) GetMouseMovement()
        {
            return (0, 0);
        }

        public static (int, int) GetEmulatedMouseMovement()
        {
            (int, int) value = (0, 0);
            
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.LeftArrow: 
                        value.Item1 = +1;
                        break;
                            
                    case ConsoleKey.RightArrow:
                        value.Item1 = -1;
                        break;
                    case ConsoleKey.UpArrow:
                        value.Item2 = +1;
                        break;
                    case ConsoleKey.DownArrow:
                        value.Item2 = -1;
                        break;
                }
            }

            return value;
        }
    }
}