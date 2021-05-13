using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Collections.Generic;
using System.Text;

namespace second_project.Page
{
    public class BasePage
    {
        private readonly IWebDriver driver;


        protected BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void WaitUntilElementVisible(By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        protected IWebElement GetElement(By by)
        {
            WaitUntilElementVisible(by);
            return driver.FindElement(by);
        }
        protected void Click(By by)
        {
            WaitUntilElementVisible(by);
            driver.FindElement(by).Click();
        }
        protected void SendKeys(By by, string text)
        {
            WaitUntilElementVisible(by);
            driver.FindElement(by).SendKeys(text);
        }
    }
}
