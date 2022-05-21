using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM_Example.PAges;

namespace POM_Example.Tests
{
    public class ViewStudents
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
        [Test]
        public void TitlePresenceTest()
        {
            driver.Navigate().GoToUrl("https://mvc-app-node-express.nakov.repl.co/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            Assert.That(driver.FindElement(By.CssSelector("h1")).Text, Is.EqualTo("Students Registry"));
        }
        [Test]
        public void SecondTestStudents()
        {
            driver.Navigate().GoToUrl("https://mvc-app-node-express.nakov.repl.co/");
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
            driver.FindElement(By.LinkText("View Students")).Click();
            driver.FindElement(By.CssSelector("ul")).Click();
            var elements1 = driver.FindElements(By.CssSelector("li:nth-child(2)"));
            var elements2 = driver.FindElements(By.CssSelector("li:nth-child(3)"));
            var elements3 = driver.FindElements(By.CssSelector("li:nth-child(1)"));
            int sumOfAllElements = elements1.Count + elements2.Count + elements3.Count;

            Assert.True(sumOfAllElements >= 3);
        }

    }
}
