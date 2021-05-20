using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using static finally_specflow_project.Drivers.WebDriver;

namespace finally_specflow_project.Page
{

    class BasePage
    {
        protected void WaitUntilElementVisible(By by)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected void OpenLink(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        protected IWebElement GetElement(By by)
        {
            WaitUntilElementVisible(by);
            return Driver.FindElement(by);
        }
        protected void Click(By by)
        {
            WaitUntilElementVisible(by);
            Driver.FindElement(by).Click();
        }
        protected void SendKeys(By by, string text)
        {
            WaitUntilElementVisible(by);
            Driver.FindElement(by).SendKeys(text);
        }
        protected void SwitchTo(By by)
        {
            WaitUntilElementVisible(by);
            Driver.SwitchTo().Frame(Driver.FindElement(by));
        }

        protected void autoCompleteBox(By by)
        {
            Actions builder = new Actions(Driver);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement webElement = Driver.FindElement(by);
            builder.MoveToElement(webElement).Build().Perform();
            webElement.Click();
        }
        protected string GetTextAlert()
        {
            string value = Driver.SwitchTo().Alert().Text;
            return value;
        }
        protected string GetValue(By by)
        {
            string value = Driver.FindElement(by).GetAttribute("value");
            return value;
        }
        protected void AcceptAlert()
        {
            Driver.SwitchTo().Alert().Accept();
        }
        protected string GetText(By by)
        {
            string value = Driver.FindElement(by).Text;
            return value;
        }  
    }
    

}
