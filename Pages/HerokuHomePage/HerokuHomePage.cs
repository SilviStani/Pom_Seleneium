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
        }
    }
}