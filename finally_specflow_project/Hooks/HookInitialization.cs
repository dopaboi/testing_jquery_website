using TechTalk.SpecFlow;
using static finally_specflow_project.Drivers.WebDriver;

namespace finally_specflow_project.Hooks
{
    [Binding]
    public sealed class HookInitialization
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            OpenBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            QuitBrowser();
        }
    }
}
