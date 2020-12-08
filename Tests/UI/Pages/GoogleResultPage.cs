using Framework.Main.Core.UI.Components;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace Tests.Pages
{
    public class GoogleResultPage : GoogleHomePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.g:not(.g-blk)")]
        private IList<IWebElement> searchResults;

        public List<SearchResultModel> GetSearchResults()
        {
            return searchResults.Select(e => new SearchResultModel
            {
                Description = e.FindElement(By.CssSelector("span.aCOpRe")).Text,
                Title = e.FindElement(By.CssSelector("h3.LC20lb")).Text
            }).ToList();
        }
    }
}
