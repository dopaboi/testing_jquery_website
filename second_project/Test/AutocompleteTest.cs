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

        [SetUp]
        public void Before()
        {
            autocompletePage = new AutocompletePage(driver);
        }

        [Test]
        public void AutocompleteCheck()
        {
            autocompletePage.ClickAutocomplete();
            autocompletePage.inputTag("a");
        }
    }
}
