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

    [Test]
    public void HerokuTestHomePage(){
        //Go to Heroku test url
        herokuHomePage.GoToGoogle();
        // Do my Home Page Asserts
        herokuHomePage.PerformHerokuGeneralAsserts();
        // Click log in
        herokuHomePage.ClickLogIn();
        // perform asserts for sig in page
        herokuSigInPage.PerformSignInAsserts();
        //Fill the fields with wrong info
        herokuSigInPage.UserName("hjk");
        herokuSigInPage.Password("kjk");
        herokuSigInPage.Wait3000();
        herokuSigInPage.clickSubmitBTN();
        herokuSigInPage.clearEmailBoxField();
        herokuSigInPage.Wait3000();
        //Fill the Sign In fields: Email-Username
        herokuSigInPage.UserName("silvina.stani@gmail.com");
        //Fill the Sign In fields: Password
        herokuSigInPage.clickEye();
        herokuSigInPage.Password("1234Pqow");
       //Wait a while to see action
        herokuSigInPage.Wait3000();
       //Submit button
        herokuSigInPage.clickSubmitBTN();
       //Now we are on another web direction: Login Page
       
    }

}