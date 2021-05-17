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
        private readonly string _valueToInput = "12";

        [SetUp]
        public void Before()
        {
            sliderPage = new SliderPage(driver);
        }

        [Test, Description("Checking that alert produces the same value as input")]
        public void SliderCheck()
        {
            sliderPage.SliderClick();
            Assert.AreEqual("12", sliderPage.inputSlider(_valueToInput));
        }
    }
}
