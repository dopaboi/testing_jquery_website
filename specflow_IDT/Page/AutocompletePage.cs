using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace specflow_IDT.Page
{
    class AutocompletePage : Page
    {
        IWebDriver driver;

        public AutocompletePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private readonly By autocompletePage = By.LinkText("Autocomplete");
        private readonly By iframe = By.CssSelector(".demo-frame");
        private readonly By inputField = By.CssSelector(".ui-autocomplete-input");

        public void GoToAutocompletePage()
        {
            driver.FindElement(autocompletePage).Click();
        }

        public void EnterTheCharacter(string character)
        {
            driver.SwitchTo().Frame(driver.FindElement(iframe));
            driver.FindElement(inputField).Click();
            driver.FindElement(inputField).SendKeys(character);
        }

        public void SearchInTheDropdown(string word)
        {
            Actions builder = new Actions(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement webElement = driver.FindElement(By.XPath("//li/div[text()='" + word + "']"));
            builder.MoveToElement(webElement).Build().Perform();
            webElement.Click();
           
             
            }

            public string GetTextFromField()
        { 

            string value = driver.FindElement(inputField).GetAttribute("value");
            return value;
        }

    }
}
