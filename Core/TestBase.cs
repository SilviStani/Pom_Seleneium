namespace TestingChrome.Core
{
    public class TestBase: Base
    {
        [SetUp]
        public void SetUp(){
            SetUpDriver();
        }
        [TearDown]
        public void TearDown(){
           TearDownDriver();
        }
    }
}