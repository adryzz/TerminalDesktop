using System.Drawing;

namespace TerminalDesktop.Theming
{
    public struct ColorPalette
    {
        public static readonly ColorPallette Default = new ColorPallette()
        {
            Main = Color.Ivory,
            Outline = Color.Aqua,
            Info = Color.LimeGreen,
            Warning = Color.FromArgb(255, 187, 0),
            Error = Color.Red
        };

        public Color Main;
        public Color Outline;
        public Color Info;
        public Color Warning;
        public Color Error;
    }
}