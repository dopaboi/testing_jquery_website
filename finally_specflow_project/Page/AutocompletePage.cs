using OpenQA.Selenium;


namespace finally_specflow_project.Page
{
    class AutocompletePage: BasePage
    {
        private readonly By autocompletePage = By.LinkText("Autocomplete");
        private readonly By iframe = By.CssSelector(".demo-frame");
        private readonly By inputField = By.CssSelector(".ui-autocomplete-input");

        public void GoToAutocompletePage()
        {
            Click(autocompletePage); 
        }

        public void EnterTheCharacter(string character)
        {
            SwitchTo(iframe);
            Click(inputField);
            SendKeys(inputField, character);
        }

        public void SearchInTheDropdown(string word)
        {
            autoCompleteBox(By.XPath($"//li/div[text()='{word}']"));
        }

        public string GetValueFromField()
        {
            string value = GetValue(inputField);
            return value;
        }

    }
}
