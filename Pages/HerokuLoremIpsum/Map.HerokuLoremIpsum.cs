namespace TestingChrome.Pages.HerokuLoremIpsum
{
    public partial class HerokuLoremIpsumMap: Base
    {
        protected IWebElement LoremIpsumBtn => WaitAndFindElement(By.ClassName("navbar-brand"));
        protected IWebElement LoremIpsumLink => WaitAndFindElement(By.XPath("//*[@id='root']/div/div[1]/nav/div/div[1]/a"));
        protected IWebElement NoticeTxt => WaitAndFindElement(By.Id("news"));
        protected IWebElement HiddenTxt => WaitAndFindElement(By.CssSelector("div .jumbotron :nth-child(1)"));
        protected IWebElement LoremIpsumH1 => WaitAndFindElement(By.XPath("//*[@id='titleScreen']/h2"));
        protected IWebElement WhatIsLorem => WaitAndFindElement(By.XPath("//*[@id='headingObj1']/h4/a"));
        protected IWebElement WhyUseLorem => WaitAndFindElement(By.XPath("//*[@id='headingObj2']/h4/a"));
        protected IWebElement WhereComeLorem => WaitAndFindElement(By.XPath("//*[@id='headingObj3']/h4/a"));
        protected IWebElement GetLorem => WaitAndFindElement(By.XPath("//*[@id='headingObj4']/h4/a"));
        protected IWebElement Facebook => WaitAndFindElement(By.LinkText("Post Something"));
        protected IWebElement Selenium => WaitAndFindElement(By.LinkText("Automate It!"));
        protected IWebElement Youtube => WaitAndFindElement(By.LinkText("Watch Videos"));
    }
}