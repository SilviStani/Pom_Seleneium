namespace TestingChrome;

[TestFixture]
public class Tests: TestBase
{
    public static GoogleHomePage googleHomePage;

    [Test]
    public void GoogleSearchingTest()
    {
        googleHomePage = new GoogleHomePage();

        googleHomePage.GoToGoogle(); //Go to url

        // Do ALL my asserts
        googleHomePage.PerformGeneralAsserts();

        //Searching:
        googleHomePage.Search("Selenium");
    }

}