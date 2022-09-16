namespace TestingChrome.Pages.HerokuHomePage
{
    public partial class MapHerokuHomePage : Base
    {
        protected IWebElement Buttons => WaitAndFindElement(By.Id("loginBTN")); 
        protected IWebElement FirstText => WaitAndFindElement(By.Id("notLoggedTitleTXT")); 
        protected IWebElement SecondText => WaitAndFindElement(By.Id("notLoggedScreen")); 
        protected IWebElement LogInButton => WaitAndFindElement(By.Id("loginBTN")); 
        
    }
}