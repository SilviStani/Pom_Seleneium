namespace TestingChrome.Pages.HerokuHomePage
{
    public partial class MapHerokuHomePage : Base
    {
        protected IWebElement Buttons => WaitAndFindElement(By.Id("loginBTN")); 
        protected IWebElement FirstText => WaitAndFindElement(By.Id("notLoggedTitleTXT")); 
        protected IWebElement SecondText => WaitAndFindElement(By.Id("notLoggedScreen")); 
        protected IWebElement LogInButton => WaitAndFindElement(By.Id("loginBTN")); 
        protected IWebElement Link1 => WaitAndFindElement(By.XPath("//*[@id='root']/div/div[1]/nav/div/div[1]/a")); 
        protected IWebElement Link2 => WaitAndFindElement(By.XPath("//*[@id='navbar-intest']/li/a")); 
        protected IWebElement Footer => WaitAndFindElement( By.ClassName("footerClass")); 
        
    }
}