using System;
using System.Numerics;
using TerminalDesktop.Hardware;
using Console = Colorful.Console;

namespace TerminalDesktop.UI
{
    public class CursorFormatter : IConsoleUIFormatter
    {
        public static IConsoleUIFormatter Shared
        {
            get
            {
                if (_shared == null)
                {
                    _shared = new CursorFormatter();
                }

                return _shared;
            }
        }

        private static IConsoleUIFormatter? _shared;

        public int CursorPosX = 5;

        public int CursorPosY = 5;
        
        private int OldCursorPosX = 5;

        private int OldCursorPosY = 5;
        public void Print()
        {
            OldCursorPosX = CursorPosX;
            OldCursorPosY = CursorPosY;
            var movement = MouseHelper.GetEmulatedMouseMovement();
            CursorPosX -= movement.Item1;
            CursorPosY -= movement.Item2;
            
            CursorPosX = Math.Clamp(CursorPosX, 1, Console.WindowWidth - 2);
            CursorPosY = Math.Clamp(CursorPosY, 1, Console.WindowHeight - 2);
            
            Console.SetCursorPosition(OldCursorPosX, OldCursorPosY);
            Console.Write(' ');
            Console.SetCursorPosition(CursorPosX, CursorPosY);
            Console.Write("🮰");
        }
    }
}