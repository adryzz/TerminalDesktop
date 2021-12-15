using System;
using System.Drawing;
using System.Text;
using TerminalDesktop.Hardware;
using TerminalDesktop.Theming;
using TerminalDesktop.Utils;
using Console = Colorful.Console;

namespace TerminalDesktop.UI
{
    public class TopBarFormatter : IConsoleUIFormatter
    {
        public static IConsoleUIFormatter Shared
        {
            get
            {
                if (_shared == null)
                {
                    _shared = new TopBarFormatter();
                }

                return _shared;
            }
        }

        private static IConsoleUIFormatter? _shared;

        public void Print()
        {
            string time = $"{DateTime.Now:h:mm:ss}";
            int batt = BatteryHelper.GetBatteryPercentage();
            string battery = $"{batt}%";
            string username = Environment.UserName;
            int totalLength = time.Length + battery.Length + username.Length + 8;//add in the extra chars
            int chars = Console.WindowWidth - totalLength;
            
            Console.SetCursorPosition(0, 0);
            
            Console.Write('┌', ThemeManager.CurrentTheme.Outline);
            
            for (int i = 0; i < chars / 6; i++)
            {
                Console.Write('─', ThemeManager.CurrentTheme.Outline);
            }
            Console.WriteFormatted("┐{0}┌", ThemeManager.CurrentTheme.Main, ThemeManager.CurrentTheme.Outline, username);
            
            for (int i = 0; i < chars / 3; i++)
            {
                Console.Write('─', ThemeManager.CurrentTheme.Outline);
            }
            Console.WriteFormatted("┐{0}┌", ThemeManager.CurrentTheme.Main, ThemeManager.CurrentTheme.Outline, time);
            
            for (int i = 0; i < chars / 3; i++)
            {
                Console.Write('─', ThemeManager.CurrentTheme.Outline);
            }
            printBattery(batt, battery);
            
            for (int i = 0; i < (chars / 6); i++)
            {
                Console.Write('─', ThemeManager.CurrentTheme.Outline);
            }

            for (int i = 0; i < chars - Console.CursorLeft-totalLength+1; i++)
            {
                Console.Write('─', ThemeManager.CurrentTheme.Outline);
            }
            Console.Write('┐', ThemeManager.CurrentTheme.Outline);
        }

        private void printBattery(int battery, string batt)
        {
            Color color = ThemeManager.CurrentTheme.Main;
            if (battery >= 0 && battery <= 15)
                color = ThemeManager.CurrentTheme.Error;
            else if (battery > 15 && battery < 50)
                color = ThemeManager.CurrentTheme.Warning;
            else if (battery >= 50)
                color = ThemeManager.CurrentTheme.Info;
            
            Console.WriteFormatted("┐{0}┌", color, ThemeManager.CurrentTheme.Outline, batt);
        }
    }
}