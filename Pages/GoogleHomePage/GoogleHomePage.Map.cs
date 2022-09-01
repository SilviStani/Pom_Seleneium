namespace TestingChrome.Pages.GoogleHomePage
{
    public partial class GoogleHomePageMap: Base 
    {
        protected IWebElement GoogleImg => WaitAndFindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.LLD4me.yr19Zb.LS8OJ > div > img"));
        protected IWebElement SearchBox => WaitAndFindElement(By.Name("q"));
    }
}