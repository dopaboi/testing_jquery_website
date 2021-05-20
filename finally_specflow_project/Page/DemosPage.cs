using OpenQA.Selenium;
using TechTalk.SpecFlow;
using finally_specflow_project.Utils;

namespace finally_specflow_project.Page
{
    class DemosPage: BasePage
    {

        public string FindTheHeader(Table table)
        {
            string value = "";
            string[] expectedLines = table.AsStrings("Header");
            for(var i=0; i<expectedLines.Length; i++)
            {
                value = GetText(By.XPath($"//div[@id='sidebar']//h3[.='{expectedLines[i]}']"));
                return value;
            }
            return value;
        }

        public bool ThereIsHeaderOnThePage(Table table)
        {
            string[] expectedLines = table.AsStrings("Header");
            for (var i = 0; i < expectedLines.Length; i++)
            {
                if (expectedLines[i].Equals(FindTheHeader(table)))
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
