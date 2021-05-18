
using OpenQA.Selenium;

namespace specflow_IDT.Page
{
    class SpinnerPage : Page
    {
        IWebDriver driver;
        public SpinnerPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        private readonly By spinnerPoint = By.LinkText("Spinner");
        private readonly By iframe = By.CssSelector(".demo-frame");
        private readonly By inputFIeld = By.CssSelector(".ui-spinner-input");
        private readonly By buttonGetValue = By.CssSelector("#getvalue");

        public void GoToSpinnerPage()
        {
            driver.FindElement(spinnerPoint).Click();
        }
        public void InputValueInSpinnerBox(string p0)
        {
            driver.SwitchTo().Frame(driver.FindElement(iframe));
            driver.FindElement(inputFIeld).SendKeys(p0);
        }
        public void ClickGetValueButton()
        {
            driver.FindElement(buttonGetValue).Click();
        }
        public string GetTextFromAlert()
        {
            string value = driver.SwitchTo().Alert().Text;
            driver.SwitchTo().Alert().Accept();
            return value;
        }
    }
}
