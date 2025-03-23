using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Url = "https://nexign.com/ru";
            driver.FindElement(By.XPath("/html/body/div[1]/main/header/div/div/div[2]/nav/ul/li[1]")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/main/header/div/div/div[2]/nav/ul/li[1]/ul/li[5]")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/main/header/div/div/div[2]/nav/ul/li[1]/ul/li[5]/ul/li/ul[1]/li[2]/a")).Click();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }
    }
}