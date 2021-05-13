using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace second_project.Page
{
    public class DemosPage : BasePage
    {
        private readonly By interactionsSection = By.XPath("//div[@id='sidebar']//h3[.='Interactions']");
        private readonly By widgetSection = By.XPath("//div[@id='sidebar']//h3[.='Widgets']");
        private readonly By effectsSection = By.XPath("//div[@id='sidebar']//h3[.='Effects']");
        private readonly By utilitiesSection = By.XPath("//div[@id='sidebar']//h3[.='Utilities']");

        public DemosPage(IWebDriver driver) : base(driver)
        {
        }

        public String checkSection(IWebElement webElement)
        {
            return webElement.Text;
        }
        public void CheckInteractionsSection(String str)
        {
            Assert.Equals(checkSection(interactionsSection), str);
        }
        public void CheckWidgetSection(String str)
        {
            Assert.Equals(checkSection(widgetSection), str);
        }
        public void CheckEffectsSection(String str)
        {
            Assert.Equals(checkSection(effectsSection), str);
        }
        public void CheckUtilitiesSection(String str)
        {
            Assert.Equals(checkSection(utilitiesSection), str);
        }

        private object checkSection(By interactionsSection)
        {
            throw new NotImplementedException();
        }
    }
}
