using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arisha_Selenium
{
    class Scenario5
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.epam.com/";
           
        }

        [Test]
        public void test()
        {
            IWebElement careers = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/nav/ul/li[6]"));
            Actions mouseHover = new Actions(driver);
            mouseHover.MoveToElement(careers).Perform();
            Assert.IsTrue(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/nav/ul/li[6]/div/ul[1]/li/a")).Displayed);
            Assert.IsTrue(driver.FindElement(By.LinkText("/html/body/div[2]/div[2]/div[1]/header/div/nav/ul/li[6]/div/ul[2]/li/a")).Displayed);
            Assert.IsTrue(driver.FindElement(By.LinkText("/html/body/div[2]/div[2]/div[1]/header/div/nav/ul/li[6]/div/ul[3]/li/a")).Displayed);
            Assert.IsTrue(driver.FindElement(By.LinkText("/html/body/div[2]/div[2]/div[1]/header/div/nav/ul/li[6]/div/ul[4]/li/a")).Displayed);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
