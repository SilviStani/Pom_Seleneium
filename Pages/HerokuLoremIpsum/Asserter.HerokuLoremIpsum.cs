namespace TestingChrome.Pages.HerokuLoremIpsum
{
    public partial class HerokuLoremIpsumAsserter: HerokuLoremIpsumMap
    {
        public void AssertTitle() => Assert.AreEqual("Lorem Ipsum Page", driver.Title);
        public void AssertNoticeTxt() => Assert.AreEqual("Notice: This is a testing site meant to be used for automation test trainings", NoticeTxt.Text);
        public void AssertHiddenTxt() => Assert.AreEqual(false, HiddenTxt.Displayed);
        public void AssertLoremIpsumH1() => Assert.AreEqual(true, LoremIpsumH1.Displayed);
        public void AssertWhatIsLorem() => Assert.AreEqual(true, WhatIsLorem.Displayed);
        public void AssertWhyUseLorem() => Assert.AreEqual(true, WhyUseLorem.Displayed);
        public void AssertWhereComeLorem() => Assert.AreEqual(true, WhereComeLorem.Displayed);
        public void AssertGetLorem() => Assert.AreEqual(true, GetLorem.Displayed);
        public void AssertFacebookDisplayed() => Assert.AreEqual(true, Facebook.Displayed);
        public void AssertFacebookTxt() => Assert.AreEqual("Post Something", Facebook.Text);
        public void AssertYoutubeDisplayed() => Assert.AreEqual(true, Youtube.Displayed);
        public void AssertYoutubeTxt() => Assert.AreEqual("Watch Videos", Youtube.Text);
        public void AssertSeleniumDisplayed() => Assert.AreEqual(true, Selenium.Displayed);
        public void AssertSeleniumTxt() => Assert.AreEqual("Automate It!", Selenium.Text);
    }
}