using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;


namespace TestProject12.BaseClass
{
    public class BaseClasss
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void setup()
        {
            var Chrome=Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
             driver = new ChromeDriver(Chrome);
        }

        [OneTimeTearDown]
        public void teardown()
        {
            driver.Quit();
        }
    }
}
