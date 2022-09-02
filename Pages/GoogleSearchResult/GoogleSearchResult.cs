namespace TestingChrome.Pages.GoogleSearchResult
{
    public partial class GoogleSearchResult: GoogleSearchResultAsserter
    {
        public void ClickFirstResult() {
            FirstResult.Click();
        }

        public void PerformAllSearchAsserts(){
            Thread.Sleep(3000);
            AssertFirstResult();
            AssertResultTitlePage();
        }

        public void Sleep(){
              Thread.Sleep(3000);
        }
    }
}