namespace TestingChrome.Pages.GoogleSearchResult
{
    public partial class GoogleSearchResultAsserter: GoogleSearchResultMap
    {
        public void AssertFirstResult() => Assert.AreEqual(true, FirstResult.Displayed);
        public void AssertResultTitlePage() => Assert.AreEqual("Selenium - Buscar con Google", driver.Title);
        public void AssertFirstResultTitlePage() => Assert.AreEqual("Selenium", driver.Title);
    }
}