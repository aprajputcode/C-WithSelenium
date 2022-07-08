using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using OpenQA.Selenium.Firefox;

namespace Csharp_Demo_Project
{
    public class STATSRoyalWebPage
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine(path);
            driver = new ChromeDriver(path);
        }
       
        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://statsroyale.com/");
            Console.WriteLine("okkk");
              
        }
        [TearDown]
        public void AfterEach()
        {
            driver.Close();
        }
    }
}