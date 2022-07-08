using OpenQA.Selenium;
using TestProject12.BaseClass;

namespace TestProject12
{
    public class FisrtTestNunit : BaseClasss
    {
       

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            IWebElement search = driver.FindElement(By.XPath("//input[contains(@id,'search')]"));
            search.SendKeys("hellow");
            Thread.Sleep(3000);
            search.SendKeys(Keys.Enter);
            search.Clear();
            search.SendKeys("bye");
            driver.FindElement(By.XPath("//form[contains(@id,'search-form')]")).Submit();
        }

    }
}