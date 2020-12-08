using Framework.Main.Core.UI.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tests.Pages
{
    public class GoogleHomePage : BasePage
    {
        [FindsBy(How = How.Name, Using = "q")]
        protected IWebElement InputField { get; set; }

        public GoogleResultPage Search(string query)
        {
            InputField.SendKeys(query);
            InputField.SendKeys(Keys.Enter);

            return new GoogleResultPage();
        }
    }
}
