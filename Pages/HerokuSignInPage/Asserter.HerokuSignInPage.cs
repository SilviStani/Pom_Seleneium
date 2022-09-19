namespace TestingChrome.Pages.HerokuSignInPage
{
    public partial class HerokuSignInPageAsserter: HerokuSignInPageMap
    {
        public void EmailBoxShown() => Assert.AreEqual(true, EmailBox.Displayed);
        public void PasswordBoxShown() => Assert.AreEqual(true, PasswordBox.Displayed);
        public void SubmitBtnShown() => Assert.AreEqual(true, SubmitBtn.Displayed);
    }
}