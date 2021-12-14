using System;
using System.Drawing;
using TerminalDesktop.Theming;
using Console = Colorful.Console;

namespace TerminalDesktop.UI
{
    public class BottomBarFormatter : IConsoleUIFormatter
    {
        public static IConsoleUIFormatter Shared
        {
            get
            {
                if (_shared == null)
                {
                    _shared = new BottomBarFormatter();
                }

                return _shared;
            }
        }

        private static IConsoleUIFormatter? _shared;

        public void Print()
        {
            Console.SetCursorPosition(0, Console.WindowHeight);
            Console.Write('└', ThemeManager.CurrentTheme.Outline);
            for (int i = 0; i < Console.WindowWidth-2; i++)
            {
                Console.Write('─', ThemeManager.CurrentTheme.Outline);
            }
            Console.Write('┘', ThemeManager.CurrentTheme.Outline);
        }
    }
}