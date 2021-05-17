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


        public string CheckInteractionsSection(string str)
        {
            string value = GetText(interactionsSection);
            return value;
        }

        public string CheckWidgetSection(string str)
        {
            string value = GetText(widgetSection);
            return value;
        }
        public string CheckEffectsSection(string str)
        {
            string value = GetText(effectsSection);
            return value;
        }
        public string CheckUtilitiesSection(string str)
        {
            string value = GetText(utilitiesSection);
            return value;
        }

       
    }
}
