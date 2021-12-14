using System.IO;

namespace TerminalDesktop.Hardware
{
    public static class BatteryHelper
    {
        private const string BattFile = "/sys/class/power_supply/BAT0/capacity";
        /// <summary>
        /// Returns the battery percentage or -1 if not present.
        /// </summary>
        /// <returns></returns>
        public static int GetBatteryPercentage()
        {
            int value = 70;

            if (File.Exists(BattFile))
            {
                int.TryParse(File.ReadAllText(BattFile), out value);
            }

            return value;
        }
    }
}