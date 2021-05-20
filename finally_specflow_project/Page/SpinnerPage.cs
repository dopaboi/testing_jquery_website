using OpenQA.Selenium;


namespace finally_specflow_project.Page
{
    class SpinnerPage: BasePage
    {
        private readonly By spinnerPoint = By.LinkText("Spinner");
        private readonly By iframe = By.CssSelector(".demo-frame");
        private readonly By inputFIeld = By.CssSelector(".ui-spinner-input");
        private readonly By buttonGetValue = By.CssSelector("#getvalue");

        public void OpenLink()
        {
            OpenLink("https://jqueryui.com/");
        }

        public void GoToSpinnerPage()
        {
            Click(spinnerPoint);
        }
        public void InputValueInSpinnerBox(string numberInSpinnerBox)
        {
            SwitchTo(iframe);
            SendKeys(inputFIeld, numberInSpinnerBox);
        }
        public void ClickGetValueButton()
        {
            Click(buttonGetValue);
        }
        public string GetTextFromAlert()
        {
            string value = GetTextAlert();
            AcceptAlert();
            return value;
        }
    }
}
