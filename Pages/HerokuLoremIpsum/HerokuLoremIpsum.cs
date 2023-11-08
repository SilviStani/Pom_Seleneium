namespace TestingChrome.Pages.HerokuLoremIpsum
{
    public partial class HerokuLoremIpsum: HerokuLoremIpsumAsserter 
    {
        public void LoremIpsumClick(){
            ClickOn(LoremIpsumLink);
        }
        public void AssertLoremIpsumPage(){
            AssertTitle();
            AssertNoticeTxt();
            AssertHiddenTxt();
            AssertLoremIpsumH1();
            AssertWhatIsLorem();
            AssertWhyUseLorem();
            AssertWhereComeLorem();
            AssertGetLorem();
            AssertFacebookDisplayed();
            AssertFacebookTxt();
            AssertYoutubeDisplayed();
            AssertYoutubeTxt();
            AssertSeleniumDisplayed();
            AssertSeleniumTxt();
        }
    }
}