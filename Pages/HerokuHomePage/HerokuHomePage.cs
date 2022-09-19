namespace TestingChrome.Pages.HerokuHomePage
{
    public partial class HerokuHomePage: HerokuHomePageAsserter
    {
        public void GoToGoogle(){
            Navigate("https://testappautomation.herokuapp.com/");
        }

        public void PerformHerokuGeneralAsserts(){
            AssertTitleHerokuPage();
            NotLoggedFstTxt();
            NotLoggedScndTxt();
            LoginButtonDisplayed();
            Link1Enabled();
            Link2Enabled();
            Link1Href();
            Link2Href();
        }
         public void ClickLogIn() {
            LogInButton.Click();
        }
    }
}