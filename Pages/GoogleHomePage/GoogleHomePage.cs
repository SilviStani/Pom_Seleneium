namespace TestingChrome.Pages.GoogleHomePage
{
    public partial class GoogleHomePage: GoogleHomePageAsserters
    {
        public void GoToGoogle(){
            Navigate("https://www.google.com/");
        }

        public void PerformGeneralAsserts(){
            AssertGoogleImgVisible();
            AssertPageTitle();
            AssertSearchBoxVisible();
        }

        public void Search(string searchText){
            SetUpText(SearchBox, searchText);
        }
    }
}