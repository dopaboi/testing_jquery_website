using NUnit.Framework;
using second_project.Page;
using System;
using System.Collections.Generic;
using System.Text;

namespace second_project.Test
{

    [TestFixture]
    public class DemosTest: BaseTest
    {
        private DemosPage demosPage;
        private readonly string _interactions = "Interactions";
        private readonly string _widget = "Widgets";
        private readonly string _utilities = "Utilities";
        private readonly string _effects = "Effects";

        [SetUp]
        public void Before()
        {
            demosPage = new DemosPage(driver);
        }

        [Test, Description("Checking that the page has headers with the right text")]
        public void LeftMenuTest()
        {
            Assert.AreEqual("Interactions", demosPage.CheckInteractionsSection(_interactions));
            Assert.AreEqual("Widgets", demosPage.CheckWidgetSection(_widget));
            Assert.AreEqual("Utilities", demosPage.CheckUtilitiesSection(_utilities));
            Assert.AreEqual("Effects", demosPage.CheckEffectsSection(_effects));
        }

    }
}
