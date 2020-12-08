using Framework.Main.Core.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;

namespace Framework.Main.Core.Driver.Factory
{
    internal static class WebDriverFactory
    {
        internal static Dictionary<DriverType, IWebDriver> webDrivers;

        static WebDriverFactory()
        {
            string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"));
            webDrivers = new Dictionary<DriverType, IWebDriver>
            {
                { DriverType.CHROME, new ChromeDriver(path + @"Resources/") }
            };
        }

        public static IWebDriver GetDriver(DriverType browserType)
        {
            if (webDrivers.ContainsKey(browserType))
                return webDrivers[browserType];

            throw new ArgumentException("Driver is not supports");
        }
    }
}
