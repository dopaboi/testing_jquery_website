
using TechTalk.SpecFlow;

namespace specflow_IDT.Page
{
    public class PropertiesCollection
    {

        private static Page _currentPage;
        private ScenarioContext ScenarioContext;
        public PropertiesCollection(ScenarioContext scenarioContext)
        {
            this.ScenarioContext = scenarioContext;
        }
        public Page currentPage
        {
            get { return _currentPage; }
            set
            {
                ScenarioContext["class"] = value;
                _currentPage = ScenarioContext.Get<Page>("class");
            }
        }
    }
}
