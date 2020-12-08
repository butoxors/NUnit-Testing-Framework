using Framework.Main.Core.Enums;

namespace Framework.Main.Core.Configs
{
    public static class WebDriverConfig
    {
        public const int implictWait = 30_000;
        public const int explicitWait = 30_000;
        public const DriverType driverType = DriverType.CHROME;
        public const string baseUrl = "http://www.google.com";
    }
}
