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
    class Scenario1
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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement bt_contact = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/ul/li[1]/a/span")); 
            bt_contact.Click();
            String currentURL = driver.Url;
            Assert.AreEqual(currentURL, "https://www.epam.com/about/who-we-are/contact");

            IWebElement name = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[2]/div/div[1]/div/div/div/input"));
            name.SendKeys(Keys.Down);
            name.SendKeys("Harry");

            IWebElement select1 = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[1]/div[1]/div/span[1]/span[1]/span/span[1]"));
            select1.Click();
            select1.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[1]/div[1]/div/span[3]/span/span[2]/ul/li[1]")).Click();

            IWebElement surname = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[2]/div/div[2]/div/div/div/input"));
            surname.SendKeys("Potter");
            IWebElement email = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[3]/div/div[1]/div/div/div/input"));
            email.SendKeys("h_potter@gmail.com");
            IWebElement phone = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[3]/div/div[2]/div/div/div/input"));
            phone.SendKeys("044 111 222 3");

            IWebElement comments = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[6]/div/textarea"));
            comments.SendKeys(Keys.Down);
            comments.SendKeys("Alohomora");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("window.scrollBy(0,150)");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement select2 = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[7]"));
            select2.Click();
            select2.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[7]/div[1]/div/span[3]/span/span[2]/ul/li[1]")).Click();
            string title2 = (string)js.ExecuteScript("window.scrollBy(0,300)");
            //checkbox
            IWebElement checker = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[2]/div/div/div/div/div[8]"));
            checker.Click();
            IWebElement bt_submit = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[6]/div/form/div[3]/div/div[2]/button"));
            bt_submit.Click();
            
            //???responce check*/

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
