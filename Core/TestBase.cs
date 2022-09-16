

namespace TestingChrome.Core
{
    public class TestBase: Base
    {
        public static GoogleHomePage googleHomePage;
        public static GoogleSearchResult googleSearchResult;
        public static HerokuHomePage herokuHomePage;

        [SetUp]
        public void SetUp(){
            SetUpDriver();
            googleHomePage = new GoogleHomePage();
            googleSearchResult = new GoogleSearchResult();
            herokuHomePage = new HerokuHomePage();
        }
        [TearDown]
        public void TearDown(){
           TearDownDriver();
        }
    }
}