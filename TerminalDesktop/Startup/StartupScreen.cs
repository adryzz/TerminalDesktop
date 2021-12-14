using System;
using System.Threading;
using TerminalDesktop.UI;

namespace TerminalDesktop.Startup
{
    public static class StartupScreen
    {
        public static void Show(int timeout)
        {
            TopBarFormatter.Shared.Print();
            Thread.Sleep(timeout);
        }
    }
}