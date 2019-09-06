using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MenuAdminUITest
{
    class MenuAdminUITest
    {
        static void Main(string[] args)
        {



            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));


            driver.Url = "http://isbasi.logo-paas.com/login?returnUrl=%2Fsales";

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("login-username")).SendKeys("muruvvet.uzun@logo.com.tr");
            driver.FindElement(By.Id("login-password")).SendKeys("1234qqqQ" + Keys.Enter);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id='2da07d95 - 0bba - 4986 - a90c - 195094296f5e']")).Click();



        }
    }
}