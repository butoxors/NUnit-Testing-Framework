using Framework.Main.Core.Enums;

namespace Framework.Main.Core.Utils
{
    public static class DriverConverter
    {
        public static DriverType Convert(string driverName)
        {
            switch (driverName.ToLower())
            {
                case "firefox": return DriverType.FIREFOX;
                default: return DriverType.CHROME;
            }
        }
    }
}
