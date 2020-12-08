using Framework.Main.Core.Configs;
using Framework.Main.Core.Driver.Factory;
using Framework.Main.Core.Enums;
using OpenQA.Selenium;
using System;

namespace Framework.Main.Core.Driver
{
    public static class WebDriverManager
    {
        public static IWebDriver GetDriver(DriverType browserType = WebDriverConfig.driverType)
        {
            IWebDriver driver = WebDriverFactory.GetDriver(browserType);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(WebDriverConfig.implictWait);

            return driver;
        }

        public static void CleanUp()
        {
           foreach(var driver in WebDriverFactory.webDrivers)
            {
                driver.Value.Quit();
            }
        }
    }
}
