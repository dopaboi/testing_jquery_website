using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Interactions;
using System.Linq;

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
        protected void SwitchTo(By by)
        {
            WaitUntilElementVisible(by);
            driver.SwitchTo().Frame(driver.FindElement(by));
        }
        protected void PressKeyboard(By by)
        {
            driver.FindElement(by).SendKeys(Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.ArrowDown + Keys.Enter);
            
        }

        protected void autoCompleteBox()
        {
            Actions builder = new Actions(driver);
            IWebElement webElement = driver.FindElement(By.XPath("//div[@role='status']/div[text()='Asp']"));
            builder.MoveToElement(webElement).Build().Perform();
            builder.Click(webElement).Build().Perform();
        }
        protected void selectOptionWithText(string textToSelect)
        {
        
            try
            {

                IWebElement autoOptions = driver.FindElement(By.XPath("//*[@id='ui - id - 1']"));
                IList<IWebElement> optionsToSelect = autoOptions.FindElements(By.TagName("li"));
                foreach (IWebElement option in optionsToSelect)
                {
                    Console.WriteLine(textToSelect);
                    option.Click();
                    break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Data);
            }
        }
       
        protected string GetTextAlert()
        {
            string value = driver.SwitchTo().Alert().Text;
            return value;
        }
        protected string GetValue(By by)
        {
            string value = driver.FindElement(by).GetAttribute("value");
            return value;
        }
        protected void AcceptAlert()
        {
            driver.SwitchTo().Alert().Accept();
        }
        protected string GetText(By by)
        {
            string value = driver.FindElement(by).Text;
            return value;
        }
      
    
    }
}
