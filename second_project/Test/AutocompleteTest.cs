using NUnit.Framework;
using OpenQA.Selenium;
using second_project.Page;
using System;
using System.Collections.Generic;
using System.Text;

namespace second_project.Test
{
    [TestFixture]
    public class AutocompleteTest: BaseTest
    {
        private AutocompletePage autocompletePage;
        private readonly string _symbolToAutocomplete = "a";

        [SetUp]
        public void Before()
        {
            autocompletePage = new AutocompletePage(driver);
        }

        [Test, Description("Check that autocomplete gives the correct value")]
        public void AutocompleteCheck()
        {
            autocompletePage.ClickAutocomplete();
            Assert.AreEqual("Asp", autocompletePage.inputTag(_symbolToAutocomplete));
            
        }
    }
}
