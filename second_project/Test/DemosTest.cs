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

        [SetUp]
        public void Before()
        {
            demosPage = new DemosPage(driver);
        }

        [Test]
        public void LeftMenuTest()
        {
           
            demosPage.CheckInteractionsSection("Interactions");
            demosPage.CheckWidgetSection("Widgets");
            demosPage.CheckUtilitiesSection("Utilities");
            demosPage.CheckEffectsSection("Effects");
        }

    }
}
