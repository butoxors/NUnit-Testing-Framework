using Framework.Main.Core.Configs;
using Framework.Main.Core.Driver;
using Framework.Main.Core.Ioc;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Main.Core.Utils
{
    public static class WebDriverWaitUtils
    {
        private static IConfigReader configReader = DIContainer.GetService<IConfigReader>();
        public static void WaitForPageToLoad()
        {
            new WebDriverWait(DIContainer.GetService<IWebDriverManager>().GetDriver(), 
                TimeSpan.FromSeconds(configReader.ImplicitWait))
                .Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
