using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM_Example.PAges;

namespace POM_Example.Tests
{
    public class HomePageTEsts
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
        public void TestHomePage_Url_Heading_Title()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            Assert.That(driver.Url, Is.EqualTo(home_page.GetPageUrl()));
            Assert.That(home_page.GetPageHeading(), Is.EqualTo("Students Registry"));
            Assert.That(home_page.GetPageTitle(), Is.EqualTo("MVC Example"));

        }
        [Test]
        public void TestHomePage_HomeLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.HomeLink.Click();
            Assert.That(home_page.GetPageTitle, Is.EqualTo("MVC Example"));
            Assert.That(driver.Url, Is.EqualTo(home_page.GetPageUrl()));

        }
        [Test]
        public void TestHomePage_ViewStudentsLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.ViewStudentsLink.Click();
            var view_student = new ViewStudentsPage(driver);
            Assert.That(view_student.GetPageTitle, Is.EqualTo("Students"));
            Assert.That(driver.Url, Is.EqualTo(view_student.GetPageUrl()));

        }
        [Test]
        public void TestHomePage_AddStudentLink()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.AddStudentsLink.Click();
            var add_student = new AddStudentPage(driver);
            Assert.That(add_student.GetPageTitle, Is.EqualTo("Add Student"));
            Assert.That(driver.Url, Is.EqualTo(add_student.GetPageUrl()));

        }
        [Test]
        public void TestHome_ViewStudents()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            home_page.HomeLink.Click();
            Assert.That(home_page.GetPageTitle, Is.EqualTo("MVC Example"));

        }
        [Test]
        public void TestHome_ViewStudents_Count()
        {
            var home_page = new HomePage(driver);
            home_page.Open();
            Assert.Greater(home_page.GetStudentCount(), 0);

        }
    }
}
