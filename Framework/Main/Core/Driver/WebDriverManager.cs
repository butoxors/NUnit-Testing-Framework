using Framework.Main.Core.Configs;
using Framework.Main.Core.Driver.Factory;
using OpenQA.Selenium;
using System;

namespace Framework.Main.Core.Driver
{
    public static class WebDriverManager
    {
        private static ConfigReader configReader = new ConfigReader();
        public static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = WebDriverFactory.GetDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(configReader.ImplicitWait);
                driver.Url = configReader.URL;
            }

            return driver;
        }

        public static void CleanUp()
        {
            WebDriverFactory.TerminateAll();
        }
    }
}
