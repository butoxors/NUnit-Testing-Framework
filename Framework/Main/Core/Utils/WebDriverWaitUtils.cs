using Framework.Main.Core.Configs;
using Framework.Main.Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Framework.Main.Core.Utils
{
    public static class WebDriverWaitUtils
    {
        public static void WaitForPageToLoad()
        {
            new WebDriverWait(WebDriverManager.GetDriver(), TimeSpan.FromSeconds(WebDriverConfig.explicitWait))
                .Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
