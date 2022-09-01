namespace TestingChrome.Pages.GoogleHomePage
{
    public partial class GoogleHomePageMap: Base 
    {
        protected IWebElement GoogleImg => WaitAndFindElement(By.CssSelector("#logo"));
        protected IWebElement SearchBox => WaitAndFindElement(By.Name("q"));
    }
}