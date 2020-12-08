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
        }

        [TearDown]
        public void tearDown()
        {
            WebDriverManager.CleanUp();
        }
    }
}
