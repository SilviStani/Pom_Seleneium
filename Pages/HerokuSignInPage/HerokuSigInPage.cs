namespace TestingChrome.Pages.HerokuSignInPage
{
    public partial class HerokuSignInPage: HerokuSignInPageAsserter
    {
        public void PerformSignInAsserts(){
            EmailBoxShown();
            PasswordBoxShown();
            SubmitBtnShown();
        }
        public void UserName(string userName){
            SetUpText(EmailBox, userName);
        }
        public void Password(string password){
            SetUpText(PasswordBox, password);
        }
        public void clickSubmitBTN(){
            ClickOn(SubmitBtn);
        }
        public void clearEmailBoxField(){
            EmailBox.Clear();
        }
        public void clickEye(){
           ClickOn(EyeElementView);
        }
    }
}