using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using finally_specflow_project.Page;
using NUnit.Framework;

namespace finally_specflow_project.Steps
{
    [Binding]
    public sealed class AutocompleteStepDef
    {
        private AutocompletePage autocompletePage = new AutocompletePage();

        [Given(@"Go to the Autocomplete Page")]
        public void GivenGoToTheAutocompletePage()
        {
            autocompletePage.GoToAutocompletePage();
        }

        [Given(@"I enter the character '(.*)' in Autocomplete field")]
        public void GivenIEnterTheCharacterInAutocompleteField(string characterToInput)
        {
            autocompletePage.EnterTheCharacter(characterToInput);
        }

        [When(@"I search '(.*)' in the list")]
        public void WhenISearchInTheList(string valueFromDropdown)
        {
            autocompletePage.SearchInTheDropdown(valueFromDropdown);
        }

        [Then(@"In the InputField must have '(.*)'")]
        public void ThenInTheInputFieldMustHave(string textFromInput)
        {
            Assert.AreEqual(textFromInput, autocompletePage.GetTextFromField());
        }

    }
}
