using System;
using System.Text;
using TerminalDesktop.Terminal;

namespace TerminalDesktop.UI
{
    public class TerminalFormatter : IConsoleUIFormatter
    {
        public static IConsoleUIFormatter Shared
        {
            get
            {
                if (_shared == null)
                {
                    _shared = new TerminalFormatter();
                }

                return _shared;
            }
        }

        private static IConsoleUIFormatter? _shared;
        
        private StringBuilder builder = new StringBuilder();
        
        public TerminalFormatter()
        {
            Program.TerminalHost.Instances[Program.TerminalHost.Active].Connection.PtyData +=
                (sender, data) => builder.Append(data);
        }
        
        public void Print()
        {
            Console.SetCursorPosition(1, 1);
            Console.Write(builder.ToString());
            builder.Clear();
        }
    }
}