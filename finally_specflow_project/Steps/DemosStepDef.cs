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
    public class DemosStepDef
    {
        private DemosPage demosPage = new DemosPage();


        [StepDefinition(@"I search the Header")]
        public void ISearchTheHeader(Table table)
        {
            demosPage.FindTheHeader(table);
        }

        [Then(@"The Page must containt the Header")]
        public void ThePageMustContaintTheHeader(Table table)
        {
            Assert.IsTrue(demosPage.ThereIsHeaderOnThePage(table));
        }

    }
}
