using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ffinal
{
    class class1
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
            Console.WriteLine(driver.Title + " Checking");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}