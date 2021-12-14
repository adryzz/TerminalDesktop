using System;

namespace TerminalDesktop.UI
{
    public interface IConsoleUIFormatter
    {
        public static IConsoleUIFormatter Shared { get; }

        public void Print();
    }
}