using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM_Example.PAges;

namespace POM_Example.Tests
{

    internal class BaseTests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            this.driver = new ChromeDriver();
        }
        [TearDown]
        public void ShutDownBrowser()
        {
            driver.Quit();
        }
    }
}
