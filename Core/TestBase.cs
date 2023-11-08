namespace TestingChrome.Core
{
    public class TestBase: Base
    {
        public static GoogleHomePage googleHomePage;
        public static GoogleSearchResult googleSearchResult;
        public static HerokuHomePage herokuHomePage;
        public static HerokuSignInPage herokuSigInPage;
        //public static HerokuLogInPage herokuLogInPage;
        //public static HerokuLoremIpsum herokuLoremIpsum;

        [SetUp]
        public void SetUp(){
            SetUpDriver();
            googleHomePage = new GoogleHomePage();
            googleSearchResult = new GoogleSearchResult();
            herokuHomePage = new HerokuHomePage();
            herokuSigInPage = new HerokuSignInPage();
          //  herokuLogInPage = new HerokuLogInPage();
           // herokuLoremIpsum = new HerokuLoremIpsum();

        }
        [TearDown]
        public void TearDown(){
           TearDownDriver();
        }
    }
}