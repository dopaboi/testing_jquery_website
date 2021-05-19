using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using static finally_specflow_project.Drivers.WebDriver;

namespace finally_specflow_project.Page
{
    class AutocompletePage
    {
        private readonly By autocompletePage = By.LinkText("Autocomplete");
        private readonly By iframe = By.CssSelector(".demo-frame");
        private readonly By inputField = By.CssSelector(".ui-autocomplete-input");

        public void GoToAutocompletePage()
        {
            Driver.FindElement(autocompletePage).Click();
        }

        public void EnterTheCharacter(string character)
        {
            Driver.SwitchTo().Frame(Driver.FindElement(iframe));
            Driver.FindElement(inputField).Click();
            Driver.FindElement(inputField).SendKeys(character);
        }

        public void SearchInTheDropdown(string word)
        {
            Actions builder = new Actions(Driver);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement webElement = Driver.FindElement(By.XPath("//li/div[text()='" + word + "']"));
            builder.MoveToElement(webElement).Build().Perform();
            webElement.Click();


        }

        public string GetTextFromField()
        {

            string value = Driver.FindElement(inputField).GetAttribute("value");
            return value;
        }

    }
}
