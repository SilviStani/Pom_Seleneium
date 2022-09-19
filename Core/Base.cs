namespace TestingChrome.Core
{
    public class Base 
    {
        protected static IWebDriver driver;

        public void SetUpDriver(){
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void TearDownDriver(){
            Thread.Sleep(2000);
            driver.Quit();
        }

        public void Navigate(String txturl){
            driver.Navigate().GoToUrl(txturl);
        }

        public static IWebElement WaitAndFindElement(By locator){
            return driver.FindElement(locator);
        }

        public void SetUpText(IWebElement element, string text){
            element.SendKeys(text);
            Thread.Sleep(3000);
            element.SendKeys(Keys.Enter);
        } 
        public void ClickOn(IWebElement element){
            element.Click();
        }
        public void Wait3000(){
            Thread.Sleep(3000);
        }
        public void clearField(IWebElement element){
            element.Clear();
        }
    }
}