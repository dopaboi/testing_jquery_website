
using OpenQA.Selenium;

namespace specflow_IDT.Page
{
    class DemosPage : Page
    {

        IWebDriver driver;
        public DemosPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }


        public string FindTheHeader(string name)
        {
            string value = driver.FindElement(By.XPath("//div[@id='sidebar']//h3[.='" + name + "']")).Text;
            return value;
        }


        public bool ThereIsHeaderOnThePage(string name)
        {
            string value = driver.FindElement(By.XPath("//div[@id='sidebar']//h3[.='" + name + "']")).Text;
            if (value.Equals(name))
            {
                return true;
            }
            return false;
        }
      


    }
}
