using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using static finally_specflow_project.Drivers.WebDriver;

namespace finally_specflow_project.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            OpenBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            endTest();
        }
    }
}
