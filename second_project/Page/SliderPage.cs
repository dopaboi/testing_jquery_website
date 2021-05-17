using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using second_project.Page;


namespace second_project.Page
{
    public class SliderPage : BasePage
    {
        private readonly By sliderPoint = By.LinkText("Spinner");
        private readonly By iframe = By.CssSelector(".demo-frame");
        private readonly By inputFIeld = By.CssSelector(".ui-spinner-input");
        private readonly By buttonGetValue = By.CssSelector("#getvalue");

        public SliderPage(IWebDriver driver) : base(driver)
        {
        }

        public void SliderClick()
        {
            Click(sliderPoint);
        }

        public string inputSlider(string number)
        {
            SwitchTo(iframe);
            SendKeys(inputFIeld, number);
            Click(buttonGetValue);
            string value = GetTextAlert();
            AcceptAlert();
            return value;
        }


    }
}
