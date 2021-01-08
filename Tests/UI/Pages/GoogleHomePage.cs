using Framework.Main.Core.Attributes;
using Framework.Main.Core.UI.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests.Pages
{
    public class GoogleHomePage : BasePage, IGoogleHomePage
    {
        [FindsBy(How = How.Name, Using = "q")]
        protected IWebElement InputField { get; set; }

        public IGoogleResultPage Search(string query)
        {
            InputField.SendKeys(query);
            InputField.SendKeys(Keys.Enter);

            return PageLoader.GetGoogleResultPage;
        }
    }

    public interface IGoogleHomePage
    {
        [Step("Search page")]
        IGoogleResultPage Search(string query);
    }
}
