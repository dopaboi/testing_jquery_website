using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using specflow_IDT.Page;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;


namespace specflow_IDT.Steps
{
    [Binding]
    public sealed class SpinnerStepDef
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private IWebDriver driver;
        private SpinnerPage spinnerPage;
        private DemosPage demosPage;
        private AutocompletePage autocompletePage;

        [BeforeScenario]
        public void Setup()
        {
            this.driver = new ChromeDriver("D:\\chromedriver");
            Console.WriteLine("Selenium webdriver start");
            this.spinnerPage = new SpinnerPage(driver);
            this.demosPage = new DemosPage(driver);
            this.autocompletePage = new AutocompletePage(driver);
  
        }
        
        [Given(@"I navigate to Jquery site")]
        public void GivenINavigateToJquerySite()
        {
            driver.Navigate().GoToUrl("https://jqueryui.com/");
        }

        [Given(@"Go to the Spinner page")]
        public void GivenGoToTheSpinnerPage()
        {
            spinnerPage.GoToSpinnerPage();
        }

        [Given(@"I enter the number (.*) in Input")]
        public void GivenIEnterTheNumberInInput(string p0)
        {
            spinnerPage.InputValueInSpinnerBox(p0);
        }

        [When(@"Сlick on the get value button")]
        public void WhenСlickOnTheGetValueButton()
        {
            spinnerPage.ClickGetValueButton();
        }

        [Then(@"The number in the alert must equal our (.*)")]
        public void ThenTheNumberInTheAlertMustEqualOur(string p0)
        {
            string value = spinnerPage.GetTextFromAlert();
            Assert.AreEqual(value, p0);
            Trace.WriteLine("");
        }

        [When(@"I search the header '(.*)'")]
        public void WhenISearchTheHeader(string p0)
        {
            demosPage.FindTheHeader(p0);
        }

       

        [Then(@"The page must contain a header '(.*)'")]
        public void ThenThePageMustContainAHeader(string p0)
        {
            Assert.IsTrue(demosPage.ThereIsHeaderOnThePage(p0));
        }

        [Given(@"Go to the Autocomplete Page")]
        public void GivenGoToTheAutocompletePage()
        {
            autocompletePage.GoToAutocompletePage();
        }


        [Given(@"I enter the character '(.*)' in Autocomplete field")]
        public void GivenIEnterTheCharachterInAutocompleteField(string p0)
        {
            autocompletePage.EnterTheCharacter(p0);
        }

        [When(@"I search '(.*)' in the list")]
        public void WhenISearchInTheList(string p0)
        {
            autocompletePage.SearchInTheDropdown(p0);
        }

        [Then(@"In the InputField must have '(.*)'")]
        public void ThenInTheInputFieldMustHave(string p0)
        {
            Assert.AreEqual(p0, autocompletePage.GetTextFromField());
        }


        [AfterScenario]
        public void TearDown()
        {
            Console.WriteLine("Selenium WebDriver quit");
            driver.Quit();
        }

    }
}
