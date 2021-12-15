using Pty.Net;

namespace TerminalDesktop.Terminal
{
    public class TerminalInstance
    {
        public IPtyConnection Connection { get; }
        public TerminalInstance(IPtyConnection c)
        {
            Connection = c;
        }
    }
}