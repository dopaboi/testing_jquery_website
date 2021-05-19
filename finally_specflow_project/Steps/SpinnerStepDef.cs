using TechTalk.SpecFlow;
using finally_specflow_project.Page;
using System.Threading;
using NUnit.Framework;
using static finally_specflow_project.Drivers.WebDriver;

namespace finally_specflow_project.Steps
{
    [Binding]
    public sealed class SpinnerStepDef
    {

        private readonly SpinnerPage spinnerPage = new SpinnerPage();
    

        [Given(@"I navigate to Jquery site")]
        public void GivenINavigateToJquerySite()
        {
            spinnerPage.OpenLink();
        }

        [Given(@"Go to the Spinner page")]
        public void GivenGoToTheSpinnerPage()
        {
            spinnerPage.GoToSpinnerPage();
        }

        [Given(@"I enter the number (.*) in Input")]
        public void GivenIEnterTheNumberInInput(string numberToInput)
        {
            spinnerPage.InputValueInSpinnerBox(numberToInput);
        }

        [When(@"Сlick on the get value button")]
        public void WhenСlickOnTheGetValueButton()
        {
            spinnerPage.ClickGetValueButton();
        }

        [Then(@"The number in the alert must equal our (.*)")]
        public void ThenTheNumberInTheAlertMustEqualOur(string numberFromAlert)
        {
            string value = spinnerPage.GetTextFromAlert();
            Assert.AreEqual(value, numberFromAlert);
        }

    }
}
