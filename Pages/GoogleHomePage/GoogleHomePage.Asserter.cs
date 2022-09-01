namespace TestingChrome.Pages.GoogleHomePage
{
 public partial class GoogleHomePageAsserters: GoogleHomePageMap
 {
    public void AssertPageTitle() => Assert.AreEqual("Google", driver.Title);
    public void AssertGoogleImgVisible() => Assert.AreEqual(true, GoogleImg.Displayed);
    public void AssertSearchBoxVisible() => Assert.AreEqual(true, SearchBox.Displayed);
 }   
}