using NUnit.Framework;
using second_project.Page;
using System;
using System.Collections.Generic;
using System.Text;

namespace second_project.Test
{
    [TestFixture]
    public class SliderTest : BaseTest
    {
        private SliderPage sliderPage;

        [SetUp]
        public void Before()
        {
            sliderPage = new SliderPage(driver);
        }

        [Test]
        public void SliderCheck()
        {
            sliderPage.SliderClick();
            sliderPage.inputSlider("12");
        }
    }
}
