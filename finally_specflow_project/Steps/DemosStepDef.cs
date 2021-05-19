using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using finally_specflow_project.Page;

namespace finally_specflow_project.Steps
{
    [Binding]
    public sealed class DemosStepDef
    {
        private DemosPage demosPage = new DemosPage();


        [When(@"I search the Header")]
        public void WhenISearchTheHeader(Table table)
        {
            demosPage.FindTheHeader(table);
        }

        [Then(@"The Page must containt the Header")]
        public void ThenThePageMustContaintTheHeader(Table table)
        {
            demosPage.ThereIsHeaderOnThePage(table);
        }

    }
}
