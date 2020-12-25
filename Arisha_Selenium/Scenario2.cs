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
    class Scenario2
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
            IWebElement search = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[3]/div/button"));
            search.Click();

            IWebElement search_popup = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[3]/div/div"));
            bool visible = search_popup.Displayed;

            IWebElement text = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[3]/div/div/form/div/input"));
            text.SendKeys("Clouds");

            IWebElement bt_find = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/ul/li[3]/div/div/form/button"));
            bt_find.Click();

            String currentURL = driver.Url;
            Assert.AreEqual(currentURL, "https://www.epam.com/search?q=Clouds");

            IWebElement results = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div/section/div/div[2]/section/div[2]/span"));
            results.Text.Equals("344");

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
