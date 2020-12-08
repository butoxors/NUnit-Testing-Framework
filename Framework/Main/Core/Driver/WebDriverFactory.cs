using Framework.Main.Core.Configs;
using Framework.Main.Core.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Framework.Main.Core.Driver.Factory
{
    internal static class WebDriverFactory
    {
        internal static Dictionary<DriverType, List<IWebDriver>> webDrivers = new Dictionary<DriverType, List<IWebDriver>>();
        static ConfigReader configReader = new ConfigReader();
        static DriverType driverType = configReader.DriverType;

        static WebDriverFactory()
        {
            webDrivers[driverType] = new List<IWebDriver>();
        }

        public static IWebDriver GetDriver(DriverType driverType)
        {
            IWebDriver driver = webDrivers[driverType].FirstOrDefault();

            if (driver == null)
            {
                driver = CreateDriver(driverType);
                webDrivers[driverType].Add(driver);
            }

            return driver;
        }

        public static IWebDriver GetDriver()
        {
            return GetDriver(configReader.DriverType);
        }

        private static IWebDriver CreateDriver(DriverType type)
        {
            string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../Resources/"));

            switch (type)
            {
                case DriverType.FIREFOX: return new FirefoxDriver(path);
                default: return new ChromeDriver(path);
            }
        }

        internal static void TerminateAll()
        {
            webDrivers.ToList().ForEach(x => x.Value.ForEach(a => a.Quit()));
        }
    }
}
