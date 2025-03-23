using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Task2
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
            string page = driver.PageSource;
            string[] words = page.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '\r', '\n', '\t' });
            int count = words.Count(word => word.ToLower().Trim() == "nexign".ToLower());
            Console.WriteLine(count);
        }

        [TearDown] public void TearDown()
        {
            driver.Close();
        }
    }
}