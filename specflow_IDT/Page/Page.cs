using OpenQA.Selenium;



namespace specflow_IDT.Page
{
    public abstract class Page
    {
        protected Page(IWebDriver driver) => WrappedDriver = driver;
        protected IWebDriver WrappedDriver { get; }
    }
}
