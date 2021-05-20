using TechTalk.SpecFlow;
using finally_specflow_project.Page;
using NUnit.Framework;

namespace finally_specflow_project.Steps
{
    [Binding]
    public class AutocompleteStepDef
    {
        private AutocompletePage autocompletePage = new AutocompletePage();

        [StepDefinition(@"Go to the Autocomplete Page")]
        public void GoToTheAutocompletePage()
        {
            autocompletePage.GoToAutocompletePage();
        }

        [StepDefinition(@"I enter the character '(.*)' in Autocomplete field")]
        public void IEnterTheCharacterInAutocompleteField(string characterToInput)
        {
            autocompletePage.EnterTheCharacter(characterToInput);
        }

        [StepDefinition(@"I search '(.*)' in the list")]
        public void ISearchInTheList(string valueFromDropdown)
        {
            autocompletePage.SearchInTheDropdown(valueFromDropdown);
        }

        [Then(@"In the InputField must have '(.*)'")]
        public void InTheInputFieldMustHave(string textFromInput)
        {
            Assert.AreEqual(textFromInput, autocompletePage.GetValueFromField());
        }

    }
}
