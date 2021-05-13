using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using second_project.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace second_project.Test
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;
        private readonly string baseUrl = Constants.BaseUrl;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver("D:\\chromedriver");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(25);
            driver.Navigate().GoToUrl(baseUrl + "demos");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
