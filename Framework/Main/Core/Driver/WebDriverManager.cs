using Framework.Main.Core.Configs;
using Framework.Main.Core.Driver.Factory;
using Framework.Main.Core.Ioc;
using OpenQA.Selenium;
using System;

namespace Framework.Main.Core.Driver
{
    public class WebDriverManager : IWebDriverManager
    {
        private static IConfigReader configReader = DIContainer.GetService<IConfigReader>();
        private static IWebDriver driver;

        public IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = WebDriverFactory.GetDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(configReader.ImplicitWait);
                driver.Url = configReader.URL;
            }

            return driver;
        }

        public void CleanUp()
        {
            WebDriverFactory.TerminateAll();
        }
    }

    public interface IWebDriverManager
    {
        IWebDriver GetDriver();
        void CleanUp();
    }
}
