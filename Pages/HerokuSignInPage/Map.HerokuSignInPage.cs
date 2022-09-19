namespace TestingChrome.Pages.HerokuSignInPage
{
 public partial class HerokuSignInPageMap: Base
 {
    protected IWebElement EmailBox => WaitAndFindElement(By.Name("username"));
    protected IWebElement PasswordBox => WaitAndFindElement(By.Name("password"));
    protected IWebElement SubmitBtn => WaitAndFindElement(By.Name("action"));
    protected IWebElement EyeElementView => WaitAndFindElement(By.XPath("/html/body/div/main/section/div/div[2]/div/form/div[1]/div/div[2]/div/button"));

 }   
}