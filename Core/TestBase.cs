namespace TestingChrome.Core
{
    public class TestBase: Base
    {
        public static GoogleHomePage googleHomePage;
        public static GoogleSearchResult googleSearchResult;
        public static HerokuHomePage herokuHomePage;
        public static HerokuSignInPage herokuSigInPage;

        [SetUp]
        public void SetUp(){
            SetUpDriver();
            googleHomePage = new GoogleHomePage();
            googleSearchResult = new GoogleSearchResult();
            herokuHomePage = new HerokuHomePage();
            herokuSigInPage = new HerokuSignInPage();
        }
        [TearDown]
        public void TearDown(){
           TearDownDriver();
        }
    }
}