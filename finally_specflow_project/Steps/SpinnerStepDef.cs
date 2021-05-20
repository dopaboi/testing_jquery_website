using TechTalk.SpecFlow;
using finally_specflow_project.Page;
using System.Threading;
using NUnit.Framework;
using static finally_specflow_project.Drivers.WebDriver;

namespace finally_specflow_project.Steps
{
    [Binding]
    public class SpinnerStepDef
    {
        private readonly SpinnerPage spinnerPage = new SpinnerPage();

        [StepDefinition(@"I navigate to Jquery site")]
        public void INavigateToJquerySite()
        {
            spinnerPage.OpenLink();
        }

        [StepDefinition(@"Go to the Spinner page")]
        public void GoToTheSpinnerPage()
        {
            spinnerPage.GoToSpinnerPage();
        }

        [StepDefinition(@"I enter the number (.*) in Input")]
        public void IEnterTheNumberInInput(string numberToInput)
        {
            spinnerPage.InputValueInSpinnerBox(numberToInput);
        }

        [StepDefinition(@"Сlick on the get value button")]
        public void СlickOnTheGetValueButton()
        {
            spinnerPage.ClickGetValueButton();
        }

        [Then(@"The number in the alert must equal our (.*)")]
        public void TheNumberInTheAlertMustEqualOur(string numberFromAlert)
        {
            string value = spinnerPage.GetTextFromAlert();
            Assert.AreEqual(value, numberFromAlert);
        }

    }
}
