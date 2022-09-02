namespace TestingChrome.Pages.GoogleSearchResult
{
    public partial class GoogleSearchResultMap: Base
    
    {
        protected IWebElement FirstResult => WaitAndFindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div/div/div/div/div[1]/a/h3"));
    }
}