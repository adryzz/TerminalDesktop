using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Pty.Net;

namespace TerminalDesktop.Terminal
{
    public class TerminalSelector
    {
        public ImmutableList<TerminalInstance> Instances => _instances.ToImmutableList();

        private List<TerminalInstance> _instances = new List<TerminalInstance>();

        public int Active = 0;

        public TerminalSelector()
        {
            CreateNew();
        }

        public void CreateNew()
        {
            _instances.Add(new TerminalInstance(PtyProvider.Spawn("/bin/zsh", Console.WindowWidth-2, Console.WindowHeight-2, $"/home/{Environment.UserName}")));
        }

        public void Destroy(int index)
        {
            _instances[index].Connection.Dispose();
            _instances.RemoveAt(index);
        }
    }
}