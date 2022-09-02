namespace TestingChrome.Core
{
    public class TestBase: Base
    {
        public static GoogleHomePage googleHomePage;
        public static GoogleSearchResult googleSearchResult;

        [SetUp]
        public void SetUp(){
            SetUpDriver();

            googleHomePage = new GoogleHomePage();
            googleSearchResult = new GoogleSearchResult();
        }
        [TearDown]
        public void TearDown(){
           TearDownDriver();
        }
    }
}