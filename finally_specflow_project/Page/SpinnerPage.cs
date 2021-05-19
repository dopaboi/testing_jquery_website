using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static finally_specflow_project.Drivers.WebDriver;

namespace finally_specflow_project.Page
{
    class SpinnerPage
    {
        private readonly By spinnerPoint = By.LinkText("Spinner");
        private readonly By iframe = By.CssSelector(".demo-frame");
        private readonly By inputFIeld = By.CssSelector(".ui-spinner-input");
        private readonly By buttonGetValue = By.CssSelector("#getvalue");

        public void OpenLink()
        {
            Driver.Navigate().GoToUrl("https://jqueryui.com/");
        }

        public void GoToSpinnerPage()
        {
            Driver.FindElement(spinnerPoint).Click();
        }
        public void InputValueInSpinnerBox(string p0)
        {
            Driver.SwitchTo().Frame(Driver.FindElement(iframe));
            Driver.FindElement(inputFIeld).SendKeys(p0);
        }
        public void ClickGetValueButton()
        {
            Driver.FindElement(buttonGetValue).Click();
        }
        public string GetTextFromAlert()
        {
            string value = Driver.SwitchTo().Alert().Text;
            Driver.SwitchTo().Alert().Accept();
            return value;
        }
    }
}
