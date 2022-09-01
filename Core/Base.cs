namespace TestingChrome.Core
{
    public class Base 
    {
        protected IWebDriver driver;

        public void SetUpDriver(){
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void TearDownDriver(){
            driver.Quit();
        }

        public void Navigate(String url){
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement WaitAndFindElement(By locator){
            return driver.FindElement(locator);
        }

        public void SetUpText(IWebElement element, string text){
            element.SendKeys(text);
            element.SendKeys(Keys.Enter);
        } 

    }
}