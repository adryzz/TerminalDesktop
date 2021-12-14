using TerminalDesktop.Theming;
using Console = Colorful.Console;

namespace TerminalDesktop.UI
{
    public class VerticalBorderFormatter : IConsoleUIFormatter
    {
        public static IConsoleUIFormatter Shared
        {
            get
            {
                if (_shared == null)
                {
                    _shared = new VerticalBorderFormatter();
                }

                return _shared;
            }
        }

        private static IConsoleUIFormatter? _shared;

        public void Print()
        {
            for (int i = 1; i < Console.WindowHeight - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('│', ThemeManager.CurrentTheme.Outline);
                Console.SetCursorPosition(Console.WindowWidth, i);
                Console.Write('│', ThemeManager.CurrentTheme.Outline);
            }

        }
    }
}