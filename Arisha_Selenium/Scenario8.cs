using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arisha_Selenium
{
    class Scenario8
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.epam.com/";
        }

        [Test]
        public void test()
        {
            IWebElement language = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/button"));
            language.Click();
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[1]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[2]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[3]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[4]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[5]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[6]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[7]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[8]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[9]")).Displayed);
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[2]/div/nav/ul/li[10]")).Displayed);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
