﻿using System;
using TerminalDesktop.Startup;
using TerminalDesktop.UI;

namespace TerminalDesktop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.TreatControlCAsInput = true;
            Console.CursorVisible = false;
            Console.Clear();
            while (true)
            {
                TopBarFormatter.Shared.Print();
                VerticalBorderFormatter.Shared.Print();
                BottomBarFormatter.Shared.Print();
            }
        }
    }
}