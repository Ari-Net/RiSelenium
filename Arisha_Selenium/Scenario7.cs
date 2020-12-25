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
    class Scenario7
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
            //internal page
            IWebElement bt_contact = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/ul/li[1]/a/span"));
            bt_contact.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            //logo
            IWebElement logo = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div/div/header/div/a/img"));
            logo.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            String currentURL = driver.Url;
            Assert.AreEqual(currentURL, "https://www.epam.com/");
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
