namespace TestingChrome;

[TestFixture]
public class Tests: TestBase
{

    [Test]
    public void GoogleSearchingTest()
    {
        // Go to url
        googleHomePage.GoToGoogle(); 

        // Do ALL my asserts
        googleHomePage.PerformGeneralAsserts();

        // Searching "Selenium":
        googleHomePage.Search("Selenium");

        //Hacemos los asserts de Selenium Page
        googleSearchResult.PerformAllSearchAsserts(); // selenium . buscar con google
        googleSearchResult.ClickFirstResult(); 
        googleSearchResult.AssertFirstResultTitlePage(); // Selenium
        googleSearchResult.Sleep();
    }

}