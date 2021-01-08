using Framework.Main.Core.UI.Components;
using Framework.Main.Core.UI.Tests;
using NUnit.Framework;
using System.Collections.Generic;
using Tests.Pages;

namespace Tests
{
    [TestFixture]
    public class C1 : BaseTest
    {
        private IGoogleHomePage googleHomePage = PageLoader.GetGoogleHomePage;

        [TestCase("Selenium IDE export to C#", 3)]
        public void GoogleCheckTest(string query, int resultOrder)
        {
            string extectedText = "Selenium IDE";

            List<SearchResultModel> actualResults = googleHomePage.Search(query)
                .GetSearchResults();

            Assert.That(actualResults.Count, Is.GreaterThanOrEqualTo(resultOrder));
            Assert.That(actualResults[resultOrder].Title.Contains(extectedText), () =>
            {
                return string.Format("'{0}' is NOT contains '{1}'", actualResults[resultOrder].Title, extectedText);
            });
        }
    }
}
