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
    class Scenario6
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
            IWebElement careers = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/header/div/nav/ul/li[6]/span[1]/a"));
            careers.Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string title = (string)js.ExecuteScript("window.scrollBy(0,200)");
            IWebElement bt_find = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[3]/section/div/div[2]/div/form/button"));
            bt_find.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            IWebElement bt_apply = driver.FindElement(By.XPath("/html/body/div[2]/main/div[1]/div[1]/section/div/div[1]/div/section/ul/li[1]/div[2]/div/div/a"));
            bt_apply.Click();
            string title2 = (string)js.ExecuteScript("window.scrollBy(0,200)");
            //name
            IWebElement name = driver.FindElement(By.XPath("/html/body/div[2]/main/article/div/div/div/div[1]/div/div/div/div/form/div[9]/div/input"));
            name.SendKeys("Harry");

            //surname
            IWebElement surname = driver.FindElement(By.XPath("/html/body/div[2]/main/article/div/div/div/div[1]/div/div/div/div/form/div[10]/div/input"));
            surname.SendKeys("Potter");

            //email
            IWebElement email = driver.FindElement(By.XPath("/html/body/div[2]/main/article/div/div/div/div[1]/div/div/div/div/form/div[11]/div/input"));
            email.SendKeys("h_potter@gmail.com");

            string title3 = (string)js.ExecuteScript("window.scrollBy(0,800)");
            //check
            IWebElement checker = driver.FindElement(By.XPath("/html/body/div[2]/main/article/div/div/div/div[1]/div/div/div/div/form/div[17]"));
            checker.Click();

            //submit
            IWebElement bt_submit = driver.FindElement(By.XPath("/html/body/div[2]/main/article/div/div/div/div[1]/div/div/div/div/form/div[21]/div/div[2]/button"));
            bt_submit.Click();
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
