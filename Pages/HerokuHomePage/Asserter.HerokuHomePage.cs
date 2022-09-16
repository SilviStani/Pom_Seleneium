namespace TestingChrome.Pages.HerokuHomePage
{
    public partial class HerokuHomePageAsserter: MapHerokuHomePage
    {
       public void AssertTitleHerokuPage() => Assert.AreEqual("Homme Page", driver.Title);
       public void NotLoggedFstTxt() => Assert.AreEqual("Welcome to my Atomation Testing Site", FirstText.Text);
       public void NotLoggedScndTxt() => Assert.AreEqual("Please click Login button to log into the application or sign up!", SecondText.Text);
       public void LoginButtonDisplayed() => Assert.AreEqual(true, LogInButton.Displayed);
    }
}


/*
Validate page title = Home Page​ (Y)
Validate login button exists​ (Y) ... 

Validate hyperlinks are not accessible if not logged in​

Validate page texts:​

          - Welcome to my Automation Testing Site​ (Y)

          - Please click Login button to log into the application or sign up!​ (Y)
*/