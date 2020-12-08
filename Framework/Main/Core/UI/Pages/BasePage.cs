using Framework.Main.Core.Driver;
using Framework.Main.Core.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Main.Core.UI.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver = WebDriverManager.GetDriver();

        public BasePage()
        {
            WebDriverWaitUtils.WaitForPageToLoad();

            PageFactory.InitElements(driver, this);
        }
    }
}
