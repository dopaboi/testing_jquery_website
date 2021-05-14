using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace second_project.Page
{
    public class AutocompletePage : BasePage
    {
        private readonly By autocompleteClick = By.LinkText("Autocomplete");
        private readonly By iframe = By.CssSelector(".demo-frame");
        private readonly By inputField = By.CssSelector(".ui-autocomplete-input");

        public AutocompletePage(IWebDriver driver) : base(driver)
        {
        }
        
        public void ClickAutocomplete()
        {
            Click(autocompleteClick);
        }
        
        public void inputTag(string character)
        {
            SwitchTo(iframe);
            Click(inputField);
            SendKeys(inputField, character);
            PressKeyboard(inputField);
            string characterFromInput = GetValue(inputField);
            Assert.AreEqual("Asp", characterFromInput);
        }


    }
}
