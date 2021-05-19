using OpenQA.Selenium;
using static SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;
using OpenQA.Selenium.Chrome;

namespace finally_specflow_project.Drivers
{
    public static class WebDriver
    {
        [ThreadStatic]
        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get { return driver; }
            private set { driver = value; }
        }
        public static ChromeOptions SetChromeOptions()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            return chromeOptions;
        }

        public static void OpenBrowser(int implicitWaitTime = 0, bool IsWindowsOnly = false)
        {
            Driver = new ChromeDriver("D:\\chromedriver");
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
        }
        public static void endTest()
        {
            Driver.Quit();
            Driver.Dispose();
            Driver = null;
        }
    }

}
