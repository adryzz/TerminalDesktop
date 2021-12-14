using System;

namespace TerminalDesktop.Utils
{
    public static class StringUtils
    {
        public static string MakeNumbersSevenSegments(string s)
        {
            s = s.Replace("0", "🯰");
            s = s.Replace("1", "🯱");
            s = s.Replace("2", "🯲");
            s = s.Replace("3", "🯳");
            s = s.Replace("4", "🯴");
            s = s.Replace("5", "🯵");
            s = s.Replace("6", "🯶");
            s = s.Replace("7", "🯷");
            s = s.Replace("8", "🯸");
            s = s.Replace("9", "🯹");
            s = s.Replace(":", "╏");
            return s;
        }
    }
}