using Framework.Main.Core.Configs;
using Framework.Main.Core.Driver;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework.Main.Core.UI.Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected IWebDriver driver = WebDriverManager.GetDriver();

        [SetUp]
        public void setUp()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(WebDriverConfig.baseUrl);
        }

        [TearDown]
        public void tearDown()
        {
            WebDriverManager.CleanUp();
        }
    }
}
