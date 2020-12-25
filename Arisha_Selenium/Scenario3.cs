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
    class Scenario3
    {
        IWebDriver driver;
        String[] links = { "https://www.epam.com/epam-continuum", "https://www.telescopeai.com/", "https://www.infongen.com/", "https://www.cyberdlab.com/" };
        String[] name = { "EPAM Continuum", "TelescopeAI", "InfoNgen", "Cyber R&D Lab" };

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.epam.com/";
            
        }

        [Test]
        public void a_test()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("window.scrollBy(0,6000)");

            String currentURL = driver.Url;
            IWebElement a = driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[1]/footer/div/div[1]/ul/li[1]"));
            //Assert.AreEqual(a.Text, name[0]);
            a.Click();
           // Assert.AreEqual(currentURL, links[0]);
            driver.Url = "https://www.epam.com/";
        }
        [Test]
        public void b_test()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("window.scrollBy(0,6000)");
            IWebElement b = driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[1]/footer/div/div[1]/ul/li[2]"));
            b.Click();
        }
        [Test]
        public void c_test()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("window.scrollBy(0,6000)");
            IWebElement c = driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[1]/footer/div/div[1]/ul/li[3]"));
            c.Click();
        }

        [Test]
        public void d_test()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("window.scrollBy(0,6000)");
            IWebElement d = driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[1]/footer/div/div[1]/ul/li[4]"));
            d.Click();
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
