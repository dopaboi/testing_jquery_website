using OpenQA.Selenium;
using static finally_specflow_project.Drivers.WebDriver;
using TechTalk.SpecFlow;
using finally_specflow_project.Utils;

namespace finally_specflow_project.Page
{
    class DemosPage
    {

        public string FindTheHeader(Table table)
        {
            string value = "";
            string[] expectedLines = table.AsStrings("Header");
            for(var i=0; i<expectedLines.Length; i++)
            {
                value = Driver.FindElement(By.XPath("//div[@id='sidebar']//h3[.='" + expectedLines[i] + "']")).Text;
                return value;
            }
            return value;
        }


        public bool ThereIsHeaderOnThePage(Table table)
        {
            string[] expectedLines = table.AsStrings("Header");
            for (var i = 0; i < expectedLines.Length; i++)
            {
                string value = Driver.FindElement(By.XPath("//div[@id='sidebar']//h3[.='" + expectedLines[i] + "']")).Text;
                if (value.Equals(table))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
