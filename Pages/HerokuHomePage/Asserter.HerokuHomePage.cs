namespace TestingChrome.Pages.HerokuHomePage
{
    public partial class HerokuHomePageAsserter: MapHerokuHomePage
    {
       public void AssertTitleHerokuPage() => Assert.AreEqual("Homme Page", driver.Title);
       public void NotLoggedFstTxt() => Assert.AreEqual("Welcome to my Atomation Testing Site", FirstText.Text);
       public void NotLoggedScndTxt() => Assert.AreEqual("Please click Login button to log into the application or sign up!", SecondText.Text);
       public void LoginButtonDisplayed() => Assert.AreEqual(true, LogInButton.Displayed);
       public void Link1Enabled() => Assert.AreEqual(true, Link1.Enabled);
       public void Link2Enabled() => Assert.AreEqual(true, Link2.Enabled);
       public void Link1Href() => Assert.AreEqual("https://testappautomation.herokuapp.com/lorem/", Link1.GetAttribute("href"));
       public void Link2Href() => Assert.AreEqual("https://testappautomation.herokuapp.com/forms/", Link2.GetAttribute("href"));
       public void FooterFixed() => Assert.AreEqual("fixed", Footer.GetCssValue("position"));
       public void FooterDisclaimer() => Assert.AreEqual("Disclaimer: This project is a personal site meant to be used as a help test site to be able to perform some automation test on demand.", Footer.Text);
       public void LogInClick() => LogInButton.Click();
    }
}