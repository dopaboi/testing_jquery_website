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


        public void CheckInteractionsSection(string str)
        {
            string value = GetText(interactionsSection);
            Assert.AreEqual(str, value);
        }

        public void CheckWidgetSection(string str)
        {
            string value = GetText(widgetSection);
            Assert.AreEqual(str, value);
        }
        public void CheckEffectsSection(string str)
        {
            string value = GetText(effectsSection);
            Assert.AreEqual(str, value);
        }
        public void CheckUtilitiesSection(string str)
        {
            string value = GetText(utilitiesSection);
            Assert.AreEqual(str, value);
        }

       
    }
}
